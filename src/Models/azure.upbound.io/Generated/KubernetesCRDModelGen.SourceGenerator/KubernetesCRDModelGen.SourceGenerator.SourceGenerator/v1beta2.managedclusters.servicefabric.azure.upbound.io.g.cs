#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicefabric.azure.upbound.io;
/// <summary>ManagedCluster is the Schema for the ManagedClusters API. Manages a Resource Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagedClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ManagedCluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagedClusterList";
    public const string KubeGroup = "servicefabric.azure.upbound.io";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicefabric.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ManagedCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ManagedCluster> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecDeletionPolicyEnum>))]
public enum V1beta2ManagedClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A active_directory block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderAuthenticationActiveDirectory
{
    /// <summary>The ID of the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The ID of the Cluster Application.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The ID of the Tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderAuthenticationCertificate
{
    /// <summary>The certificate&apos;s CN.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The type of the certificate. Can be AdminClient or ReadOnlyClient.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderAuthentication
{
    /// <summary>A active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2ManagedClusterSpecForProviderAuthenticationActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2ManagedClusterSpecForProviderAuthenticationCertificate>? Certificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderCustomFabricSetting
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Section name.</summary>
    [JsonPropertyName("section")]
    public string? Section { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderLbRule
{
    /// <summary>LB Backend port.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>LB Frontend port.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Protocol for the probe. Can be one of tcp, udp, http, or https.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>Path for the probe to check, when probe protocol is set to http.</summary>
    [JsonPropertyName("probeRequestPath")]
    public string? ProbeRequestPath { get; set; }

    /// <summary>The transport protocol used in this rule. Can be one of tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderNodeTypeVmSecretsCertificates
{
    /// <summary>The certificate store on the Virtual Machine to which the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The URL of a certificate that has been uploaded to Key Vault as a secret</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderNodeTypeVmSecrets
{
    /// <summary>One or more certificates blocks as defined above.</summary>
    [JsonPropertyName("certificates")]
    public IList<V1beta2ManagedClusterSpecForProviderNodeTypeVmSecretsCertificates>? Certificates { get; set; }

    /// <summary>The ID of the Vault that contain the certificates.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderNodeType
{
    /// <summary>Sets the port range available for applications. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000.</summary>
    [JsonPropertyName("applicationPortRange")]
    public string? ApplicationPortRange { get; set; }

    /// <summary>Specifies a list of key/value pairs used to set capacity tags for this node type.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The size of the data disk in gigabytes..</summary>
    [JsonPropertyName("dataDiskSizeGb")]
    public double? DataDiskSizeGb { get; set; }

    /// <summary>The type of the disk to use for storing data. It can be one of Premium_LRS, Standard_LRS, or StandardSSD_LRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("dataDiskType")]
    public string? DataDiskType { get; set; }

    /// <summary>Sets the port range available for the OS. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000. There has to be at least 255 ports available and cannot overlap with application_port_range..</summary>
    [JsonPropertyName("ephemeralPortRange")]
    public string? EphemeralPortRange { get; set; }

    /// <summary>If set the node type can be composed of multiple placement groups.</summary>
    [JsonPropertyName("multiplePlacementGroupsEnabled")]
    public bool? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>The name which should be used for this node type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of placement tags that can be used to indicate where services should run..</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>If set to true, system services will run on this node type. Only one node type should be marked as primary. Primary node type cannot be deleted or changed once they&apos;re created.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>If set to true, only stateless workloads can run on this node type.</summary>
    [JsonPropertyName("stateless")]
    public bool? Stateless { get; set; }

    /// <summary>The offer type of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageOffer")]
    public string? VmImageOffer { get; set; }

    /// <summary>The publisher of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImagePublisher")]
    public string? VmImagePublisher { get; set; }

    /// <summary>The SKU of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageSku")]
    public string? VmImageSku { get; set; }

    /// <summary>The version of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageVersion")]
    public string? VmImageVersion { get; set; }

    /// <summary>The number of instances this node type will launch.</summary>
    [JsonPropertyName("vmInstanceCount")]
    public double? VmInstanceCount { get; set; }

    /// <summary>One or more vm_secrets blocks as defined below.</summary>
    [JsonPropertyName("vmSecrets")]
    public IList<V1beta2ManagedClusterSpecForProviderNodeTypeVmSecrets>? VmSecrets { get; set; }

    /// <summary>The size of the instances in this node type.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderResourceGroupNameSelector
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
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedClusterSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProviderSubnetIdSelector
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
    public V1beta2ManagedClusterSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecForProvider
{
    /// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta2ManagedClusterSpecForProviderAuthentication? Authentication { get; set; }

    /// <summary>If true, backup service is enabled.</summary>
    [JsonPropertyName("backupServiceEnabled")]
    public bool? BackupServiceEnabled { get; set; }

    /// <summary>Port to use when connecting to the cluster.</summary>
    [JsonPropertyName("clientConnectionPort")]
    public double? ClientConnectionPort { get; set; }

    /// <summary>One or more custom_fabric_setting blocks as defined below.</summary>
    [JsonPropertyName("customFabricSetting")]
    public IList<V1beta2ManagedClusterSpecForProviderCustomFabricSetting>? CustomFabricSetting { get; set; }

    /// <summary>Hostname for the cluster. If unset the cluster&apos;s name will be used..</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>If true, DNS service is enabled.</summary>
    [JsonPropertyName("dnsServiceEnabled")]
    public bool? DnsServiceEnabled { get; set; }

    /// <summary>Port that should be used by the Service Fabric Explorer to visualize applications and cluster status.</summary>
    [JsonPropertyName("httpGatewayPort")]
    public double? HttpGatewayPort { get; set; }

    /// <summary>One or more lb_rule blocks as defined below.</summary>
    [JsonPropertyName("lbRule")]
    public IList<V1beta2ManagedClusterSpecForProviderLbRule>? LbRule { get; set; }

    /// <summary>The Azure Region where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta2ManagedClusterSpecForProviderNodeType>? NodeType { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2ManagedClusterSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The name of the Resource Group where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ManagedClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>SKU for this cluster. Changing this forces a new resource to be created. Default is Basic, allowed values are either Basic or Standard.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The resource ID of the Subnet. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ManagedClusterSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ManagedClusterSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Group.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Upgrade wave for the fabric runtime. Default is Wave0, allowed value must be one of Wave0, Wave1, or Wave2.</summary>
    [JsonPropertyName("upgradeWave")]
    public string? UpgradeWave { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A active_directory block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderAuthenticationActiveDirectory
{
    /// <summary>The ID of the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The ID of the Cluster Application.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The ID of the Tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderAuthenticationCertificate
{
    /// <summary>The certificate&apos;s CN.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The type of the certificate. Can be AdminClient or ReadOnlyClient.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderAuthentication
{
    /// <summary>A active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2ManagedClusterSpecInitProviderAuthenticationActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2ManagedClusterSpecInitProviderAuthenticationCertificate>? Certificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderCustomFabricSetting
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Section name.</summary>
    [JsonPropertyName("section")]
    public string? Section { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderLbRule
{
    /// <summary>LB Backend port.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>LB Frontend port.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Protocol for the probe. Can be one of tcp, udp, http, or https.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>Path for the probe to check, when probe protocol is set to http.</summary>
    [JsonPropertyName("probeRequestPath")]
    public string? ProbeRequestPath { get; set; }

    /// <summary>The transport protocol used in this rule. Can be one of tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderNodeTypeVmSecretsCertificates
{
    /// <summary>The certificate store on the Virtual Machine to which the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The URL of a certificate that has been uploaded to Key Vault as a secret</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderNodeTypeVmSecrets
{
    /// <summary>One or more certificates blocks as defined above.</summary>
    [JsonPropertyName("certificates")]
    public IList<V1beta2ManagedClusterSpecInitProviderNodeTypeVmSecretsCertificates>? Certificates { get; set; }

    /// <summary>The ID of the Vault that contain the certificates.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderNodeType
{
    /// <summary>Sets the port range available for applications. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000.</summary>
    [JsonPropertyName("applicationPortRange")]
    public string? ApplicationPortRange { get; set; }

    /// <summary>Specifies a list of key/value pairs used to set capacity tags for this node type.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The size of the data disk in gigabytes..</summary>
    [JsonPropertyName("dataDiskSizeGb")]
    public double? DataDiskSizeGb { get; set; }

    /// <summary>The type of the disk to use for storing data. It can be one of Premium_LRS, Standard_LRS, or StandardSSD_LRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("dataDiskType")]
    public string? DataDiskType { get; set; }

    /// <summary>Sets the port range available for the OS. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000. There has to be at least 255 ports available and cannot overlap with application_port_range..</summary>
    [JsonPropertyName("ephemeralPortRange")]
    public string? EphemeralPortRange { get; set; }

    /// <summary>If set the node type can be composed of multiple placement groups.</summary>
    [JsonPropertyName("multiplePlacementGroupsEnabled")]
    public bool? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>The name which should be used for this node type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of placement tags that can be used to indicate where services should run..</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>If set to true, system services will run on this node type. Only one node type should be marked as primary. Primary node type cannot be deleted or changed once they&apos;re created.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>If set to true, only stateless workloads can run on this node type.</summary>
    [JsonPropertyName("stateless")]
    public bool? Stateless { get; set; }

    /// <summary>The offer type of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageOffer")]
    public string? VmImageOffer { get; set; }

    /// <summary>The publisher of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImagePublisher")]
    public string? VmImagePublisher { get; set; }

    /// <summary>The SKU of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageSku")]
    public string? VmImageSku { get; set; }

    /// <summary>The version of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageVersion")]
    public string? VmImageVersion { get; set; }

    /// <summary>The number of instances this node type will launch.</summary>
    [JsonPropertyName("vmInstanceCount")]
    public double? VmInstanceCount { get; set; }

    /// <summary>One or more vm_secrets blocks as defined below.</summary>
    [JsonPropertyName("vmSecrets")]
    public IList<V1beta2ManagedClusterSpecInitProviderNodeTypeVmSecrets>? VmSecrets { get; set; }

    /// <summary>The size of the instances in this node type.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedClusterSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecInitProviderSubnetIdSelector
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
    public V1beta2ManagedClusterSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2ManagedClusterSpecInitProvider
{
    /// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta2ManagedClusterSpecInitProviderAuthentication? Authentication { get; set; }

    /// <summary>If true, backup service is enabled.</summary>
    [JsonPropertyName("backupServiceEnabled")]
    public bool? BackupServiceEnabled { get; set; }

    /// <summary>Port to use when connecting to the cluster.</summary>
    [JsonPropertyName("clientConnectionPort")]
    public double? ClientConnectionPort { get; set; }

    /// <summary>One or more custom_fabric_setting blocks as defined below.</summary>
    [JsonPropertyName("customFabricSetting")]
    public IList<V1beta2ManagedClusterSpecInitProviderCustomFabricSetting>? CustomFabricSetting { get; set; }

    /// <summary>Hostname for the cluster. If unset the cluster&apos;s name will be used..</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>If true, DNS service is enabled.</summary>
    [JsonPropertyName("dnsServiceEnabled")]
    public bool? DnsServiceEnabled { get; set; }

    /// <summary>Port that should be used by the Service Fabric Explorer to visualize applications and cluster status.</summary>
    [JsonPropertyName("httpGatewayPort")]
    public double? HttpGatewayPort { get; set; }

    /// <summary>One or more lb_rule blocks as defined below.</summary>
    [JsonPropertyName("lbRule")]
    public IList<V1beta2ManagedClusterSpecInitProviderLbRule>? LbRule { get; set; }

    /// <summary>The Azure Region where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta2ManagedClusterSpecInitProviderNodeType>? NodeType { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2ManagedClusterSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>SKU for this cluster. Changing this forces a new resource to be created. Default is Basic, allowed values are either Basic or Standard.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The resource ID of the Subnet. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ManagedClusterSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ManagedClusterSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Group.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Upgrade wave for the fabric runtime. Default is Wave0, allowed value must be one of Wave0, Wave1, or Wave2.</summary>
    [JsonPropertyName("upgradeWave")]
    public string? UpgradeWave { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecManagementPoliciesEnum>))]
public enum V1beta2ManagedClusterSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ManagedClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ManagedClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ManagedClusterSpec defines the desired state of ManagedCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterSpec
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
    public V1beta2ManagedClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ManagedClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta2ManagedClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ManagedClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ManagedClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ManagedClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A active_directory block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderAuthenticationActiveDirectory
{
    /// <summary>The ID of the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The ID of the Cluster Application.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The ID of the Tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderAuthenticationCertificate
{
    /// <summary>The certificate&apos;s CN.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The type of the certificate. Can be AdminClient or ReadOnlyClient.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderAuthentication
{
    /// <summary>A active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2ManagedClusterStatusAtProviderAuthenticationActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2ManagedClusterStatusAtProviderAuthenticationCertificate>? Certificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderCustomFabricSetting
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Section name.</summary>
    [JsonPropertyName("section")]
    public string? Section { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderLbRule
{
    /// <summary>LB Backend port.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>LB Frontend port.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Protocol for the probe. Can be one of tcp, udp, http, or https.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>Path for the probe to check, when probe protocol is set to http.</summary>
    [JsonPropertyName("probeRequestPath")]
    public string? ProbeRequestPath { get; set; }

    /// <summary>The transport protocol used in this rule. Can be one of tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderNodeTypeVmSecretsCertificates
{
    /// <summary>The certificate store on the Virtual Machine to which the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The URL of a certificate that has been uploaded to Key Vault as a secret</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderNodeTypeVmSecrets
{
    /// <summary>One or more certificates blocks as defined above.</summary>
    [JsonPropertyName("certificates")]
    public IList<V1beta2ManagedClusterStatusAtProviderNodeTypeVmSecretsCertificates>? Certificates { get; set; }

    /// <summary>The ID of the Vault that contain the certificates.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProviderNodeType
{
    /// <summary>Sets the port range available for applications. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000.</summary>
    [JsonPropertyName("applicationPortRange")]
    public string? ApplicationPortRange { get; set; }

    /// <summary>Specifies a list of key/value pairs used to set capacity tags for this node type.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The size of the data disk in gigabytes..</summary>
    [JsonPropertyName("dataDiskSizeGb")]
    public double? DataDiskSizeGb { get; set; }

    /// <summary>The type of the disk to use for storing data. It can be one of Premium_LRS, Standard_LRS, or StandardSSD_LRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("dataDiskType")]
    public string? DataDiskType { get; set; }

    /// <summary>Sets the port range available for the OS. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000. There has to be at least 255 ports available and cannot overlap with application_port_range..</summary>
    [JsonPropertyName("ephemeralPortRange")]
    public string? EphemeralPortRange { get; set; }

    /// <summary>The ID of the Resource Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If set the node type can be composed of multiple placement groups.</summary>
    [JsonPropertyName("multiplePlacementGroupsEnabled")]
    public bool? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>The name which should be used for this node type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of placement tags that can be used to indicate where services should run..</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>If set to true, system services will run on this node type. Only one node type should be marked as primary. Primary node type cannot be deleted or changed once they&apos;re created.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>If set to true, only stateless workloads can run on this node type.</summary>
    [JsonPropertyName("stateless")]
    public bool? Stateless { get; set; }

    /// <summary>The offer type of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageOffer")]
    public string? VmImageOffer { get; set; }

    /// <summary>The publisher of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImagePublisher")]
    public string? VmImagePublisher { get; set; }

    /// <summary>The SKU of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageSku")]
    public string? VmImageSku { get; set; }

    /// <summary>The version of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageVersion")]
    public string? VmImageVersion { get; set; }

    /// <summary>The number of instances this node type will launch.</summary>
    [JsonPropertyName("vmInstanceCount")]
    public double? VmInstanceCount { get; set; }

    /// <summary>One or more vm_secrets blocks as defined below.</summary>
    [JsonPropertyName("vmSecrets")]
    public IList<V1beta2ManagedClusterStatusAtProviderNodeTypeVmSecrets>? VmSecrets { get; set; }

    /// <summary>The size of the instances in this node type.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusAtProvider
{
    /// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta2ManagedClusterStatusAtProviderAuthentication? Authentication { get; set; }

    /// <summary>If true, backup service is enabled.</summary>
    [JsonPropertyName("backupServiceEnabled")]
    public bool? BackupServiceEnabled { get; set; }

    /// <summary>Port to use when connecting to the cluster.</summary>
    [JsonPropertyName("clientConnectionPort")]
    public double? ClientConnectionPort { get; set; }

    /// <summary>One or more custom_fabric_setting blocks as defined below.</summary>
    [JsonPropertyName("customFabricSetting")]
    public IList<V1beta2ManagedClusterStatusAtProviderCustomFabricSetting>? CustomFabricSetting { get; set; }

    /// <summary>Hostname for the cluster. If unset the cluster&apos;s name will be used..</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>If true, DNS service is enabled.</summary>
    [JsonPropertyName("dnsServiceEnabled")]
    public bool? DnsServiceEnabled { get; set; }

    /// <summary>Port that should be used by the Service Fabric Explorer to visualize applications and cluster status.</summary>
    [JsonPropertyName("httpGatewayPort")]
    public double? HttpGatewayPort { get; set; }

    /// <summary>The ID of the Resource Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more lb_rule blocks as defined below.</summary>
    [JsonPropertyName("lbRule")]
    public IList<V1beta2ManagedClusterStatusAtProviderLbRule>? LbRule { get; set; }

    /// <summary>The Azure Region where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta2ManagedClusterStatusAtProviderNodeType>? NodeType { get; set; }

    /// <summary>The name of the Resource Group where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>SKU for this cluster. Changing this forces a new resource to be created. Default is Basic, allowed values are either Basic or Standard.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The resource ID of the Subnet. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Group.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Upgrade wave for the fabric runtime. Default is Wave0, allowed value must be one of Wave0, Wave1, or Wave2.</summary>
    [JsonPropertyName("upgradeWave")]
    public string? UpgradeWave { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatusConditions
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

/// <summary>ManagedClusterStatus defines the observed state of ManagedCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ManagedClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ManagedClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ManagedCluster is the Schema for the ManagedClusters API. Manages a Resource Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ManagedClusterSpec>, IStatus<V1beta2ManagedClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagedCluster";
    public const string KubeGroup = "servicefabric.azure.upbound.io";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicefabric.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedClusterSpec defines the desired state of ManagedCluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ManagedClusterSpec Spec { get; set; }

    /// <summary>ManagedClusterStatus defines the observed state of ManagedCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2ManagedClusterStatus? Status { get; set; }
}
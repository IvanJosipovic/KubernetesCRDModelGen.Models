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
/// <summary>Cluster is the Schema for the Clusters API. Manages a Service Fabric Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Cluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "servicefabric.azure.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicefabric.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Cluster> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecDeletionPolicyEnum>))]
public enum V1beta2ClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An azure_active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderAzureActiveDirectory
{
    /// <summary>The Azure Active Directory Client ID which should be used for the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The Azure Active Directory Cluster Application ID.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta2ClusterSpecForProviderCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClientCertificateCommonName
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("issuerThumbprint")]
    public string? IssuerThumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClientCertificateThumbprint
{
    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Thumbprint associated with the Client Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>A diagnostics_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDiagnosticsConfig
{
    /// <summary>The Blob Endpoint of the Storage Account.</summary>
    [JsonPropertyName("blobEndpoint")]
    public string? BlobEndpoint { get; set; }

    /// <summary>The protected diagnostics storage key name, such as StorageAccountKey1.</summary>
    [JsonPropertyName("protectedAccountKeyName")]
    public string? ProtectedAccountKeyName { get; set; }

    /// <summary>The Queue Endpoint of the Storage Account.</summary>
    [JsonPropertyName("queueEndpoint")]
    public string? QueueEndpoint { get; set; }

    /// <summary>The name of the Storage Account where the Diagnostics should be sent to.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>The Table Endpoint of the Storage Account.</summary>
    [JsonPropertyName("tableEndpoint")]
    public string? TableEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderFabricSettings
{
    /// <summary>The name of the Fabric Setting, such as Security or Federation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map containing settings for the specified Fabric Setting.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>A application_ports block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderNodeTypeApplicationPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary>A ephemeral_ports block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderNodeTypeEphemeralPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderNodeType
{
    /// <summary>A application_ports block as defined below.</summary>
    [JsonPropertyName("applicationPorts")]
    public V1beta2ClusterSpecForProviderNodeTypeApplicationPorts? ApplicationPorts { get; set; }

    /// <summary>The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The Port used for the Client Endpoint for this Node Type.</summary>
    [JsonPropertyName("clientEndpointPort")]
    public double? ClientEndpointPort { get; set; }

    /// <summary>The Durability Level for this Node Type. Possible values include Bronze, Gold and Silver. Defaults to Bronze.</summary>
    [JsonPropertyName("durabilityLevel")]
    public string? DurabilityLevel { get; set; }

    /// <summary>A ephemeral_ports block as defined below.</summary>
    [JsonPropertyName("ephemeralPorts")]
    public V1beta2ClusterSpecForProviderNodeTypeEphemeralPorts? EphemeralPorts { get; set; }

    /// <summary>The Port used for the HTTP Endpoint for this Node Type.</summary>
    [JsonPropertyName("httpEndpointPort")]
    public double? HttpEndpointPort { get; set; }

    /// <summary>The number of nodes for this Node Type.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is this the Primary Node Type?</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>Should this node type run only stateless services?</summary>
    [JsonPropertyName("isStateless")]
    public bool? IsStateless { get; set; }

    /// <summary>Does this node type span availability zones?</summary>
    [JsonPropertyName("multipleAvailabilityZones")]
    public bool? MultipleAvailabilityZones { get; set; }

    /// <summary>The name of the Node Type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>The Port used for the Reverse Proxy Endpoint for this Node Type. Changing this will upgrade the cluster.</summary>
    [JsonPropertyName("reverseProxyEndpointPort")]
    public double? ReverseProxyEndpointPort { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderResourceGroupNameSelector
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
    public V1beta2ClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderReverseProxyCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderReverseProxyCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderReverseProxyCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta2ClusterSpecForProviderReverseProxyCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary>A delta_health_policy block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderUpgradePolicyDeltaHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy applications that can have aggregated health states of error. If the current unhealthy applications do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyApplicationsPercent")]
    public double? MaxDeltaUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy nodes that can have aggregated health states of error. If the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyNodesPercent")]
    public double? MaxDeltaUnhealthyNodesPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of upgrade domain delta unhealthy nodes that can have aggregated health state of error. If there is any upgrade domain where the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUpgradeDomainDeltaUnhealthyNodesPercent")]
    public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent { get; set; }
}

/// <summary>A health_policy block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderUpgradePolicyHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of applications that can have aggregated health state of error. If the upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyApplicationsPercent")]
    public double? MaxUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of nodes that can have aggregated health states of error. If an upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyNodesPercent")]
    public double? MaxUnhealthyNodesPercent { get; set; }
}

/// <summary>A upgrade_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderUpgradePolicy
{
    /// <summary>A delta_health_policy block as defined below</summary>
    [JsonPropertyName("deltaHealthPolicy")]
    public V1beta2ClusterSpecForProviderUpgradePolicyDeltaHealthPolicy? DeltaHealthPolicy { get; set; }

    /// <summary>Indicates whether to restart the Service Fabric node even if only dynamic configurations have changed.</summary>
    [JsonPropertyName("forceRestartEnabled")]
    public bool? ForceRestartEnabled { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, after which Service Fabric retries the health check if the previous health check fails. Defaults to 00:45:00.</summary>
    [JsonPropertyName("healthCheckRetryTimeout")]
    public string? HealthCheckRetryTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits in order to verify that the cluster is stable before it continues to the next upgrade domain or completes the upgrade. This wait duration prevents undetected changes of health right after the health check is performed. Defaults to 00:01:00.</summary>
    [JsonPropertyName("healthCheckStableDuration")]
    public string? HealthCheckStableDuration { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits before it performs the initial health check after it finishes the upgrade on the upgrade domain. Defaults to 00:00:30.</summary>
    [JsonPropertyName("healthCheckWaitDuration")]
    public string? HealthCheckWaitDuration { get; set; }

    /// <summary>A health_policy block as defined below</summary>
    [JsonPropertyName("healthPolicy")]
    public V1beta2ClusterSpecForProviderUpgradePolicyHealthPolicy? HealthPolicy { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric takes to upgrade a single upgrade domain. After this period, the upgrade fails. Defaults to 02:00:00.</summary>
    [JsonPropertyName("upgradeDomainTimeout")]
    public string? UpgradeDomainTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits for a replica set to reconfigure into a safe state, if it is not already in a safe state, before Service Fabric proceeds with the upgrade. Defaults to 10675199.02:48:05.4775807.</summary>
    [JsonPropertyName("upgradeReplicaSetCheckTimeout")]
    public string? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric takes for the entire upgrade. After this period, the upgrade fails. Defaults to 12:00:00.</summary>
    [JsonPropertyName("upgradeTimeout")]
    public string? UpgradeTimeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProvider
{
    /// <summary>A List of one or more features which should be enabled, such as DnsService.</summary>
    [JsonPropertyName("addOnFeatures")]
    public IList<string>? AddOnFeatures { get; set; }

    /// <summary>An azure_active_directory block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V1beta2ClusterSpecForProviderAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2ClusterSpecForProviderCertificate? Certificate { get; set; }

    /// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
    [JsonPropertyName("certificateCommonNames")]
    public V1beta2ClusterSpecForProviderCertificateCommonNames? CertificateCommonNames { get; set; }

    /// <summary>A client_certificate_common_name block as defined below.</summary>
    [JsonPropertyName("clientCertificateCommonName")]
    public IList<V1beta2ClusterSpecForProviderClientCertificateCommonName>? ClientCertificateCommonName { get; set; }

    /// <summary>One or more client_certificate_thumbprint blocks as defined below.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public IList<V1beta2ClusterSpecForProviderClientCertificateThumbprint>? ClientCertificateThumbprint { get; set; }

    /// <summary>Required if Upgrade Mode set to Manual, Specifies the Version of the Cluster Code of the cluster.</summary>
    [JsonPropertyName("clusterCodeVersion")]
    public string? ClusterCodeVersion { get; set; }

    /// <summary>A diagnostics_config block as defined below.</summary>
    [JsonPropertyName("diagnosticsConfig")]
    public V1beta2ClusterSpecForProviderDiagnosticsConfig? DiagnosticsConfig { get; set; }

    /// <summary>One or more fabric_settings blocks as defined below.</summary>
    [JsonPropertyName("fabricSettings")]
    public IList<V1beta2ClusterSpecForProviderFabricSettings>? FabricSettings { get; set; }

    /// <summary>Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Management Endpoint of the cluster such as http://example.com. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementEndpoint")]
    public string? ManagementEndpoint { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta2ClusterSpecForProviderNodeType>? NodeType { get; set; }

    /// <summary>Specifies the Reliability Level of the Cluster. Possible values include None, Bronze, Silver, Gold and Platinum.</summary>
    [JsonPropertyName("reliabilityLevel")]
    public string? ReliabilityLevel { get; set; }

    /// <summary>The name of the Resource Group in which the Service Fabric Cluster exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
    [JsonPropertyName("reverseProxyCertificate")]
    public V1beta2ClusterSpecForProviderReverseProxyCertificate? ReverseProxyCertificate { get; set; }

    /// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
    [JsonPropertyName("reverseProxyCertificateCommonNames")]
    public V1beta2ClusterSpecForProviderReverseProxyCertificateCommonNames? ReverseProxyCertificateCommonNames { get; set; }

    /// <summary>Specifies the logical grouping of VMs in upgrade domains. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("serviceFabricZonalUpgradeMode")]
    public string? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Upgrade Mode of the cluster. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>A upgrade_policy block as defined below.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V1beta2ClusterSpecForProviderUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>Specifies the Image expected for the Service Fabric Cluster, such as Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmImage")]
    public string? VmImage { get; set; }

    /// <summary>Specifies the upgrade mode for the virtual machine scale set updates that happen in all availability zones at once. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("vmssZonalUpgradeMode")]
    public string? VmssZonalUpgradeMode { get; set; }
}

/// <summary>An azure_active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderAzureActiveDirectory
{
    /// <summary>The Azure Active Directory Client ID which should be used for the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The Azure Active Directory Cluster Application ID.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta2ClusterSpecInitProviderCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClientCertificateCommonName
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("issuerThumbprint")]
    public string? IssuerThumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClientCertificateThumbprint
{
    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Thumbprint associated with the Client Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>A diagnostics_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDiagnosticsConfig
{
    /// <summary>The Blob Endpoint of the Storage Account.</summary>
    [JsonPropertyName("blobEndpoint")]
    public string? BlobEndpoint { get; set; }

    /// <summary>The protected diagnostics storage key name, such as StorageAccountKey1.</summary>
    [JsonPropertyName("protectedAccountKeyName")]
    public string? ProtectedAccountKeyName { get; set; }

    /// <summary>The Queue Endpoint of the Storage Account.</summary>
    [JsonPropertyName("queueEndpoint")]
    public string? QueueEndpoint { get; set; }

    /// <summary>The name of the Storage Account where the Diagnostics should be sent to.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>The Table Endpoint of the Storage Account.</summary>
    [JsonPropertyName("tableEndpoint")]
    public string? TableEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderFabricSettings
{
    /// <summary>The name of the Fabric Setting, such as Security or Federation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map containing settings for the specified Fabric Setting.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>A application_ports block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderNodeTypeApplicationPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary>A ephemeral_ports block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderNodeTypeEphemeralPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderNodeType
{
    /// <summary>A application_ports block as defined below.</summary>
    [JsonPropertyName("applicationPorts")]
    public V1beta2ClusterSpecInitProviderNodeTypeApplicationPorts? ApplicationPorts { get; set; }

    /// <summary>The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The Port used for the Client Endpoint for this Node Type.</summary>
    [JsonPropertyName("clientEndpointPort")]
    public double? ClientEndpointPort { get; set; }

    /// <summary>The Durability Level for this Node Type. Possible values include Bronze, Gold and Silver. Defaults to Bronze.</summary>
    [JsonPropertyName("durabilityLevel")]
    public string? DurabilityLevel { get; set; }

    /// <summary>A ephemeral_ports block as defined below.</summary>
    [JsonPropertyName("ephemeralPorts")]
    public V1beta2ClusterSpecInitProviderNodeTypeEphemeralPorts? EphemeralPorts { get; set; }

    /// <summary>The Port used for the HTTP Endpoint for this Node Type.</summary>
    [JsonPropertyName("httpEndpointPort")]
    public double? HttpEndpointPort { get; set; }

    /// <summary>The number of nodes for this Node Type.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is this the Primary Node Type?</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>Should this node type run only stateless services?</summary>
    [JsonPropertyName("isStateless")]
    public bool? IsStateless { get; set; }

    /// <summary>Does this node type span availability zones?</summary>
    [JsonPropertyName("multipleAvailabilityZones")]
    public bool? MultipleAvailabilityZones { get; set; }

    /// <summary>The name of the Node Type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>The Port used for the Reverse Proxy Endpoint for this Node Type. Changing this will upgrade the cluster.</summary>
    [JsonPropertyName("reverseProxyEndpointPort")]
    public double? ReverseProxyEndpointPort { get; set; }
}

/// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderReverseProxyCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderReverseProxyCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderReverseProxyCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta2ClusterSpecInitProviderReverseProxyCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary>A delta_health_policy block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderUpgradePolicyDeltaHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy applications that can have aggregated health states of error. If the current unhealthy applications do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyApplicationsPercent")]
    public double? MaxDeltaUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy nodes that can have aggregated health states of error. If the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyNodesPercent")]
    public double? MaxDeltaUnhealthyNodesPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of upgrade domain delta unhealthy nodes that can have aggregated health state of error. If there is any upgrade domain where the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUpgradeDomainDeltaUnhealthyNodesPercent")]
    public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent { get; set; }
}

/// <summary>A health_policy block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderUpgradePolicyHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of applications that can have aggregated health state of error. If the upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyApplicationsPercent")]
    public double? MaxUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of nodes that can have aggregated health states of error. If an upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyNodesPercent")]
    public double? MaxUnhealthyNodesPercent { get; set; }
}

/// <summary>A upgrade_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderUpgradePolicy
{
    /// <summary>A delta_health_policy block as defined below</summary>
    [JsonPropertyName("deltaHealthPolicy")]
    public V1beta2ClusterSpecInitProviderUpgradePolicyDeltaHealthPolicy? DeltaHealthPolicy { get; set; }

    /// <summary>Indicates whether to restart the Service Fabric node even if only dynamic configurations have changed.</summary>
    [JsonPropertyName("forceRestartEnabled")]
    public bool? ForceRestartEnabled { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, after which Service Fabric retries the health check if the previous health check fails. Defaults to 00:45:00.</summary>
    [JsonPropertyName("healthCheckRetryTimeout")]
    public string? HealthCheckRetryTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits in order to verify that the cluster is stable before it continues to the next upgrade domain or completes the upgrade. This wait duration prevents undetected changes of health right after the health check is performed. Defaults to 00:01:00.</summary>
    [JsonPropertyName("healthCheckStableDuration")]
    public string? HealthCheckStableDuration { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits before it performs the initial health check after it finishes the upgrade on the upgrade domain. Defaults to 00:00:30.</summary>
    [JsonPropertyName("healthCheckWaitDuration")]
    public string? HealthCheckWaitDuration { get; set; }

    /// <summary>A health_policy block as defined below</summary>
    [JsonPropertyName("healthPolicy")]
    public V1beta2ClusterSpecInitProviderUpgradePolicyHealthPolicy? HealthPolicy { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric takes to upgrade a single upgrade domain. After this period, the upgrade fails. Defaults to 02:00:00.</summary>
    [JsonPropertyName("upgradeDomainTimeout")]
    public string? UpgradeDomainTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits for a replica set to reconfigure into a safe state, if it is not already in a safe state, before Service Fabric proceeds with the upgrade. Defaults to 10675199.02:48:05.4775807.</summary>
    [JsonPropertyName("upgradeReplicaSetCheckTimeout")]
    public string? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric takes for the entire upgrade. After this period, the upgrade fails. Defaults to 12:00:00.</summary>
    [JsonPropertyName("upgradeTimeout")]
    public string? UpgradeTimeout { get; set; }
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
public partial class V1beta2ClusterSpecInitProvider
{
    /// <summary>A List of one or more features which should be enabled, such as DnsService.</summary>
    [JsonPropertyName("addOnFeatures")]
    public IList<string>? AddOnFeatures { get; set; }

    /// <summary>An azure_active_directory block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V1beta2ClusterSpecInitProviderAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2ClusterSpecInitProviderCertificate? Certificate { get; set; }

    /// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
    [JsonPropertyName("certificateCommonNames")]
    public V1beta2ClusterSpecInitProviderCertificateCommonNames? CertificateCommonNames { get; set; }

    /// <summary>A client_certificate_common_name block as defined below.</summary>
    [JsonPropertyName("clientCertificateCommonName")]
    public IList<V1beta2ClusterSpecInitProviderClientCertificateCommonName>? ClientCertificateCommonName { get; set; }

    /// <summary>One or more client_certificate_thumbprint blocks as defined below.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public IList<V1beta2ClusterSpecInitProviderClientCertificateThumbprint>? ClientCertificateThumbprint { get; set; }

    /// <summary>Required if Upgrade Mode set to Manual, Specifies the Version of the Cluster Code of the cluster.</summary>
    [JsonPropertyName("clusterCodeVersion")]
    public string? ClusterCodeVersion { get; set; }

    /// <summary>A diagnostics_config block as defined below.</summary>
    [JsonPropertyName("diagnosticsConfig")]
    public V1beta2ClusterSpecInitProviderDiagnosticsConfig? DiagnosticsConfig { get; set; }

    /// <summary>One or more fabric_settings blocks as defined below.</summary>
    [JsonPropertyName("fabricSettings")]
    public IList<V1beta2ClusterSpecInitProviderFabricSettings>? FabricSettings { get; set; }

    /// <summary>Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Management Endpoint of the cluster such as http://example.com. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementEndpoint")]
    public string? ManagementEndpoint { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta2ClusterSpecInitProviderNodeType>? NodeType { get; set; }

    /// <summary>Specifies the Reliability Level of the Cluster. Possible values include None, Bronze, Silver, Gold and Platinum.</summary>
    [JsonPropertyName("reliabilityLevel")]
    public string? ReliabilityLevel { get; set; }

    /// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
    [JsonPropertyName("reverseProxyCertificate")]
    public V1beta2ClusterSpecInitProviderReverseProxyCertificate? ReverseProxyCertificate { get; set; }

    /// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
    [JsonPropertyName("reverseProxyCertificateCommonNames")]
    public V1beta2ClusterSpecInitProviderReverseProxyCertificateCommonNames? ReverseProxyCertificateCommonNames { get; set; }

    /// <summary>Specifies the logical grouping of VMs in upgrade domains. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("serviceFabricZonalUpgradeMode")]
    public string? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Upgrade Mode of the cluster. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>A upgrade_policy block as defined below.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V1beta2ClusterSpecInitProviderUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>Specifies the Image expected for the Service Fabric Cluster, such as Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmImage")]
    public string? VmImage { get; set; }

    /// <summary>Specifies the upgrade mode for the virtual machine scale set updates that happen in all availability zones at once. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("vmssZonalUpgradeMode")]
    public string? VmssZonalUpgradeMode { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecManagementPoliciesEnum>))]
public enum V1beta2ClusterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpec
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
    public V1beta2ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta2ClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An azure_active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderAzureActiveDirectory
{
    /// <summary>The Azure Active Directory Client ID which should be used for the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The Azure Active Directory Cluster Application ID.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta2ClusterStatusAtProviderCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClientCertificateCommonName
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("issuerThumbprint")]
    public string? IssuerThumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClientCertificateThumbprint
{
    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Thumbprint associated with the Client Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>A diagnostics_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderDiagnosticsConfig
{
    /// <summary>The Blob Endpoint of the Storage Account.</summary>
    [JsonPropertyName("blobEndpoint")]
    public string? BlobEndpoint { get; set; }

    /// <summary>The protected diagnostics storage key name, such as StorageAccountKey1.</summary>
    [JsonPropertyName("protectedAccountKeyName")]
    public string? ProtectedAccountKeyName { get; set; }

    /// <summary>The Queue Endpoint of the Storage Account.</summary>
    [JsonPropertyName("queueEndpoint")]
    public string? QueueEndpoint { get; set; }

    /// <summary>The name of the Storage Account where the Diagnostics should be sent to.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>The Table Endpoint of the Storage Account.</summary>
    [JsonPropertyName("tableEndpoint")]
    public string? TableEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderFabricSettings
{
    /// <summary>The name of the Fabric Setting, such as Security or Federation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map containing settings for the specified Fabric Setting.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>A application_ports block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderNodeTypeApplicationPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary>A ephemeral_ports block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderNodeTypeEphemeralPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderNodeType
{
    /// <summary>A application_ports block as defined below.</summary>
    [JsonPropertyName("applicationPorts")]
    public V1beta2ClusterStatusAtProviderNodeTypeApplicationPorts? ApplicationPorts { get; set; }

    /// <summary>The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The Port used for the Client Endpoint for this Node Type.</summary>
    [JsonPropertyName("clientEndpointPort")]
    public double? ClientEndpointPort { get; set; }

    /// <summary>The Durability Level for this Node Type. Possible values include Bronze, Gold and Silver. Defaults to Bronze.</summary>
    [JsonPropertyName("durabilityLevel")]
    public string? DurabilityLevel { get; set; }

    /// <summary>A ephemeral_ports block as defined below.</summary>
    [JsonPropertyName("ephemeralPorts")]
    public V1beta2ClusterStatusAtProviderNodeTypeEphemeralPorts? EphemeralPorts { get; set; }

    /// <summary>The Port used for the HTTP Endpoint for this Node Type.</summary>
    [JsonPropertyName("httpEndpointPort")]
    public double? HttpEndpointPort { get; set; }

    /// <summary>The number of nodes for this Node Type.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is this the Primary Node Type?</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>Should this node type run only stateless services?</summary>
    [JsonPropertyName("isStateless")]
    public bool? IsStateless { get; set; }

    /// <summary>Does this node type span availability zones?</summary>
    [JsonPropertyName("multipleAvailabilityZones")]
    public bool? MultipleAvailabilityZones { get; set; }

    /// <summary>The name of the Node Type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>The Port used for the Reverse Proxy Endpoint for this Node Type. Changing this will upgrade the cluster.</summary>
    [JsonPropertyName("reverseProxyEndpointPort")]
    public double? ReverseProxyEndpointPort { get; set; }
}

/// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderReverseProxyCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderReverseProxyCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderReverseProxyCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta2ClusterStatusAtProviderReverseProxyCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary>A delta_health_policy block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderUpgradePolicyDeltaHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy applications that can have aggregated health states of error. If the current unhealthy applications do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyApplicationsPercent")]
    public double? MaxDeltaUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy nodes that can have aggregated health states of error. If the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyNodesPercent")]
    public double? MaxDeltaUnhealthyNodesPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of upgrade domain delta unhealthy nodes that can have aggregated health state of error. If there is any upgrade domain where the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUpgradeDomainDeltaUnhealthyNodesPercent")]
    public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent { get; set; }
}

/// <summary>A health_policy block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderUpgradePolicyHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of applications that can have aggregated health state of error. If the upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyApplicationsPercent")]
    public double? MaxUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of nodes that can have aggregated health states of error. If an upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyNodesPercent")]
    public double? MaxUnhealthyNodesPercent { get; set; }
}

/// <summary>A upgrade_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderUpgradePolicy
{
    /// <summary>A delta_health_policy block as defined below</summary>
    [JsonPropertyName("deltaHealthPolicy")]
    public V1beta2ClusterStatusAtProviderUpgradePolicyDeltaHealthPolicy? DeltaHealthPolicy { get; set; }

    /// <summary>Indicates whether to restart the Service Fabric node even if only dynamic configurations have changed.</summary>
    [JsonPropertyName("forceRestartEnabled")]
    public bool? ForceRestartEnabled { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, after which Service Fabric retries the health check if the previous health check fails. Defaults to 00:45:00.</summary>
    [JsonPropertyName("healthCheckRetryTimeout")]
    public string? HealthCheckRetryTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits in order to verify that the cluster is stable before it continues to the next upgrade domain or completes the upgrade. This wait duration prevents undetected changes of health right after the health check is performed. Defaults to 00:01:00.</summary>
    [JsonPropertyName("healthCheckStableDuration")]
    public string? HealthCheckStableDuration { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits before it performs the initial health check after it finishes the upgrade on the upgrade domain. Defaults to 00:00:30.</summary>
    [JsonPropertyName("healthCheckWaitDuration")]
    public string? HealthCheckWaitDuration { get; set; }

    /// <summary>A health_policy block as defined below</summary>
    [JsonPropertyName("healthPolicy")]
    public V1beta2ClusterStatusAtProviderUpgradePolicyHealthPolicy? HealthPolicy { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric takes to upgrade a single upgrade domain. After this period, the upgrade fails. Defaults to 02:00:00.</summary>
    [JsonPropertyName("upgradeDomainTimeout")]
    public string? UpgradeDomainTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric waits for a replica set to reconfigure into a safe state, if it is not already in a safe state, before Service Fabric proceeds with the upgrade. Defaults to 10675199.02:48:05.4775807.</summary>
    [JsonPropertyName("upgradeReplicaSetCheckTimeout")]
    public string? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>Specifies the duration, in &quot;hh:mm:ss&quot; string format, that Service Fabric takes for the entire upgrade. After this period, the upgrade fails. Defaults to 12:00:00.</summary>
    [JsonPropertyName("upgradeTimeout")]
    public string? UpgradeTimeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProvider
{
    /// <summary>A List of one or more features which should be enabled, such as DnsService.</summary>
    [JsonPropertyName("addOnFeatures")]
    public IList<string>? AddOnFeatures { get; set; }

    /// <summary>An azure_active_directory block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V1beta2ClusterStatusAtProviderAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2ClusterStatusAtProviderCertificate? Certificate { get; set; }

    /// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
    [JsonPropertyName("certificateCommonNames")]
    public V1beta2ClusterStatusAtProviderCertificateCommonNames? CertificateCommonNames { get; set; }

    /// <summary>A client_certificate_common_name block as defined below.</summary>
    [JsonPropertyName("clientCertificateCommonName")]
    public IList<V1beta2ClusterStatusAtProviderClientCertificateCommonName>? ClientCertificateCommonName { get; set; }

    /// <summary>One or more client_certificate_thumbprint blocks as defined below.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public IList<V1beta2ClusterStatusAtProviderClientCertificateThumbprint>? ClientCertificateThumbprint { get; set; }

    /// <summary>Required if Upgrade Mode set to Manual, Specifies the Version of the Cluster Code of the cluster.</summary>
    [JsonPropertyName("clusterCodeVersion")]
    public string? ClusterCodeVersion { get; set; }

    /// <summary>The Cluster Endpoint for this Service Fabric Cluster.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>A diagnostics_config block as defined below.</summary>
    [JsonPropertyName("diagnosticsConfig")]
    public V1beta2ClusterStatusAtProviderDiagnosticsConfig? DiagnosticsConfig { get; set; }

    /// <summary>One or more fabric_settings blocks as defined below.</summary>
    [JsonPropertyName("fabricSettings")]
    public IList<V1beta2ClusterStatusAtProviderFabricSettings>? FabricSettings { get; set; }

    /// <summary>The ID of the Service Fabric Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Management Endpoint of the cluster such as http://example.com. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementEndpoint")]
    public string? ManagementEndpoint { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta2ClusterStatusAtProviderNodeType>? NodeType { get; set; }

    /// <summary>Specifies the Reliability Level of the Cluster. Possible values include None, Bronze, Silver, Gold and Platinum.</summary>
    [JsonPropertyName("reliabilityLevel")]
    public string? ReliabilityLevel { get; set; }

    /// <summary>The name of the Resource Group in which the Service Fabric Cluster exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
    [JsonPropertyName("reverseProxyCertificate")]
    public V1beta2ClusterStatusAtProviderReverseProxyCertificate? ReverseProxyCertificate { get; set; }

    /// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
    [JsonPropertyName("reverseProxyCertificateCommonNames")]
    public V1beta2ClusterStatusAtProviderReverseProxyCertificateCommonNames? ReverseProxyCertificateCommonNames { get; set; }

    /// <summary>Specifies the logical grouping of VMs in upgrade domains. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("serviceFabricZonalUpgradeMode")]
    public string? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Upgrade Mode of the cluster. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>A upgrade_policy block as defined below.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V1beta2ClusterStatusAtProviderUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>Specifies the Image expected for the Service Fabric Cluster, such as Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmImage")]
    public string? VmImage { get; set; }

    /// <summary>Specifies the upgrade mode for the virtual machine scale set updates that happen in all availability zones at once. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("vmssZonalUpgradeMode")]
    public string? VmssZonalUpgradeMode { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. Manages a Service Fabric Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ClusterSpec>, IStatus<V1beta2ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "servicefabric.azure.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicefabric.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2ClusterStatus? Status { get; set; }
}
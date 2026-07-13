#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.databricks.azure.upbound.io;
/// <summary>Workspace is the Schema for the Workspaces API. Manages a Databricks Workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Workspace>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "databricks.azure.upbound.io";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databricks.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Workspace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Workspace> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecDeletionPolicyEnum>))]
public enum V1beta2WorkspaceSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelector
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
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelector
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
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom_parameters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderCustomParameters
{
    /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets (only for workspace with managed virtual network). Defaults to nat-gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>Are public IP Addresses not allowed? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("noPublicIp")]
    public bool? NoPublicIp { get; set; }

    /// <summary>The name of the Private Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateSubnetName")]
    public string? PrivateSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameRef")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRef? PrivateSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameSelector")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelector? PrivateSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the private_subnet_name field. This is the same as the ID of the subnet referred to by the private_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("privateSubnetNetworkSecurityGroupAssociationId")]
    public string? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Name of the Public IP for No Public IP workspace with managed virtual network. Defaults to nat-gw-public-ip. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpName")]
    public string? PublicIpName { get; set; }

    /// <summary>The name of the Public Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicSubnetName")]
    public string? PublicSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameRef")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameRef? PublicSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameSelector")]
    public V1beta2WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelector? PublicSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the public_subnet_name field. This is the same as the ID of the subnet referred to by the public_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("publicSubnetNetworkSecurityGroupAssociationId")]
    public string? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Default Databricks File Storage account name. Defaults to a randomized name(e.g. dbstoragel6mfeghoe5kxu). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Storage account SKU name. Possible values include Standard_LRS, Standard_GRS, Standard_RAGRS, Standard_GZRS, Standard_RAGZRS, Standard_ZRS, Premium_LRS or Premium_ZRS. Defaults to Standard_GRS.</summary>
    [JsonPropertyName("storageAccountSkuName")]
    public string? StorageAccountSkuName { get; set; }

    /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>Address prefix for Managed virtual network. Defaults to 10.139. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetAddressPrefix")]
    public string? VnetAddressPrefix { get; set; }
}

/// <summary>An enhanced_security_compliance block as documented below. This feature is only valid if sku is set to premium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderEnhancedSecurityCompliance
{
    /// <summary>Enables automatic cluster updates for this workspace. Defaults to false.</summary>
    [JsonPropertyName("automaticClusterUpdateEnabled")]
    public bool? AutomaticClusterUpdateEnabled { get; set; }

    /// <summary>Enables compliance security profile for this workspace. Defaults to false.</summary>
    [JsonPropertyName("complianceSecurityProfileEnabled")]
    public bool? ComplianceSecurityProfileEnabled { get; set; }

    /// <summary>A list of standards to enforce on this workspace. Possible values include HIPAA and PCI_DSS.</summary>
    [JsonPropertyName("complianceSecurityProfileStandards")]
    public IList<string>? ComplianceSecurityProfileStandards { get; set; }

    /// <summary>Enables enhanced security monitoring for this workspace. Defaults to false.</summary>
    [JsonPropertyName("enhancedSecurityMonitoringEnabled")]
    public bool? EnhancedSecurityMonitoringEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelector
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
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProviderResourceGroupNameSelector
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
    public V1beta2WorkspaceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecForProvider
{
    /// <summary>Access Connector ID to use when default storage account firewall is enabled.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>A custom_parameters block as documented below.</summary>
    [JsonPropertyName("customParameters")]
    public V1beta2WorkspaceSpecForProviderCustomParameters? CustomParameters { get; set; }

    /// <summary>Is the workspace enabled for customer managed key encryption? If true this enables the Managed Identity for the managed storage account. Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium.</summary>
    [JsonPropertyName("customerManagedKeyEnabled")]
    public bool? CustomerManagedKeyEnabled { get; set; }

    /// <summary>Disallow public access to default storage account. Defaults to false.</summary>
    [JsonPropertyName("defaultStorageFirewallEnabled")]
    public bool? DefaultStorageFirewallEnabled { get; set; }

    /// <summary>An enhanced_security_compliance block as documented below. This feature is only valid if sku is set to premium.</summary>
    [JsonPropertyName("enhancedSecurityCompliance")]
    public V1beta2WorkspaceSpecForProviderEnhancedSecurityCompliance? EnhancedSecurityCompliance { get; set; }

    /// <summary>Is the Databricks File System root file system enabled with a secondary layer of encryption with platform managed keys? Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Resource ID of the Outbound Load balancer Backend Address Pool for Secure Cluster Connectivity (No Public IP) workspace with managed virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolId")]
    public string? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Resource ID of the Key Vault which contains the managed_disk_cmk_key_vault_key_id key.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultId")]
    public string? ManagedDiskCmkKeyVaultId { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed disks.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultKeyId")]
    public string? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>Whether customer managed keys for disk encryption will automatically be rotated to the latest version.</summary>
    [JsonPropertyName("managedDiskCmkRotationToLatestVersionEnabled")]
    public bool? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameRef")]
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameRef? ManagedResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameSelector")]
    public V1beta2WorkspaceSpecForProviderManagedResourceGroupNameSelector? ManagedResourceGroupNameSelector { get; set; }

    /// <summary>Resource ID of the Key Vault which contains the managed_services_cmk_key_vault_key_id key.</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultId")]
    public string? ManagedServicesCmkKeyVaultId { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed resources(e.g. Notebooks and Artifacts).</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultKeyId")]
    public string? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>Does the data plane (clusters) to control plane communication happen over private link endpoint only or publicly? Possible values AllRules, NoAzureDatabricksRules or NoAzureServiceRules. Required when public_network_access_enabled is set to false.</summary>
    [JsonPropertyName("networkSecurityGroupRulesRequired")]
    public string? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>Allow public access for accessing workspace. Set value to false to access workspace only via private link endpoint. Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2WorkspaceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2WorkspaceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The sku to use for the Databricks Workspace. Possible values are standard, premium, or trial.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelector
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
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelector
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
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom_parameters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderCustomParameters
{
    /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets (only for workspace with managed virtual network). Defaults to nat-gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>Are public IP Addresses not allowed? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("noPublicIp")]
    public bool? NoPublicIp { get; set; }

    /// <summary>The name of the Private Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateSubnetName")]
    public string? PrivateSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameRef")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRef? PrivateSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameSelector")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelector? PrivateSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the private_subnet_name field. This is the same as the ID of the subnet referred to by the private_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("privateSubnetNetworkSecurityGroupAssociationId")]
    public string? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Name of the Public IP for No Public IP workspace with managed virtual network. Defaults to nat-gw-public-ip. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpName")]
    public string? PublicIpName { get; set; }

    /// <summary>The name of the Public Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicSubnetName")]
    public string? PublicSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameRef")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRef? PublicSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameSelector")]
    public V1beta2WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelector? PublicSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the public_subnet_name field. This is the same as the ID of the subnet referred to by the public_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("publicSubnetNetworkSecurityGroupAssociationId")]
    public string? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Default Databricks File Storage account name. Defaults to a randomized name(e.g. dbstoragel6mfeghoe5kxu). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Storage account SKU name. Possible values include Standard_LRS, Standard_GRS, Standard_RAGRS, Standard_GZRS, Standard_RAGZRS, Standard_ZRS, Premium_LRS or Premium_ZRS. Defaults to Standard_GRS.</summary>
    [JsonPropertyName("storageAccountSkuName")]
    public string? StorageAccountSkuName { get; set; }

    /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>Address prefix for Managed virtual network. Defaults to 10.139. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetAddressPrefix")]
    public string? VnetAddressPrefix { get; set; }
}

/// <summary>An enhanced_security_compliance block as documented below. This feature is only valid if sku is set to premium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderEnhancedSecurityCompliance
{
    /// <summary>Enables automatic cluster updates for this workspace. Defaults to false.</summary>
    [JsonPropertyName("automaticClusterUpdateEnabled")]
    public bool? AutomaticClusterUpdateEnabled { get; set; }

    /// <summary>Enables compliance security profile for this workspace. Defaults to false.</summary>
    [JsonPropertyName("complianceSecurityProfileEnabled")]
    public bool? ComplianceSecurityProfileEnabled { get; set; }

    /// <summary>A list of standards to enforce on this workspace. Possible values include HIPAA and PCI_DSS.</summary>
    [JsonPropertyName("complianceSecurityProfileStandards")]
    public IList<string>? ComplianceSecurityProfileStandards { get; set; }

    /// <summary>Enables enhanced security monitoring for this workspace. Defaults to false.</summary>
    [JsonPropertyName("enhancedSecurityMonitoringEnabled")]
    public bool? EnhancedSecurityMonitoringEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelector
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
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2WorkspaceSpecInitProvider
{
    /// <summary>Access Connector ID to use when default storage account firewall is enabled.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>A custom_parameters block as documented below.</summary>
    [JsonPropertyName("customParameters")]
    public V1beta2WorkspaceSpecInitProviderCustomParameters? CustomParameters { get; set; }

    /// <summary>Is the workspace enabled for customer managed key encryption? If true this enables the Managed Identity for the managed storage account. Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium.</summary>
    [JsonPropertyName("customerManagedKeyEnabled")]
    public bool? CustomerManagedKeyEnabled { get; set; }

    /// <summary>Disallow public access to default storage account. Defaults to false.</summary>
    [JsonPropertyName("defaultStorageFirewallEnabled")]
    public bool? DefaultStorageFirewallEnabled { get; set; }

    /// <summary>An enhanced_security_compliance block as documented below. This feature is only valid if sku is set to premium.</summary>
    [JsonPropertyName("enhancedSecurityCompliance")]
    public V1beta2WorkspaceSpecInitProviderEnhancedSecurityCompliance? EnhancedSecurityCompliance { get; set; }

    /// <summary>Is the Databricks File System root file system enabled with a secondary layer of encryption with platform managed keys? Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Resource ID of the Outbound Load balancer Backend Address Pool for Secure Cluster Connectivity (No Public IP) workspace with managed virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolId")]
    public string? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Resource ID of the Key Vault which contains the managed_disk_cmk_key_vault_key_id key.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultId")]
    public string? ManagedDiskCmkKeyVaultId { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed disks.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultKeyId")]
    public string? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>Whether customer managed keys for disk encryption will automatically be rotated to the latest version.</summary>
    [JsonPropertyName("managedDiskCmkRotationToLatestVersionEnabled")]
    public bool? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameRef")]
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameRef? ManagedResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameSelector")]
    public V1beta2WorkspaceSpecInitProviderManagedResourceGroupNameSelector? ManagedResourceGroupNameSelector { get; set; }

    /// <summary>Resource ID of the Key Vault which contains the managed_services_cmk_key_vault_key_id key.</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultId")]
    public string? ManagedServicesCmkKeyVaultId { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed resources(e.g. Notebooks and Artifacts).</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultKeyId")]
    public string? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>Does the data plane (clusters) to control plane communication happen over private link endpoint only or publicly? Possible values AllRules, NoAzureDatabricksRules or NoAzureServiceRules. Required when public_network_access_enabled is set to false.</summary>
    [JsonPropertyName("networkSecurityGroupRulesRequired")]
    public string? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>Allow public access for accessing workspace. Set value to false to access workspace only via private link endpoint. Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The sku to use for the Databricks Workspace. Possible values are standard, premium, or trial.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecManagementPoliciesEnum>))]
public enum V1beta2WorkspaceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WorkspaceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkspaceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WorkspaceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkspaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkspaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkspaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WorkspaceSpec defines the desired state of Workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceSpec
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
    public V1beta2WorkspaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WorkspaceSpecForProvider ForProvider { get; set; }

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
    public V1beta2WorkspaceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2WorkspaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WorkspaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WorkspaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A custom_parameters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceStatusAtProviderCustomParameters
{
    /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets (only for workspace with managed virtual network). Defaults to nat-gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>Are public IP Addresses not allowed? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("noPublicIp")]
    public bool? NoPublicIp { get; set; }

    /// <summary>The name of the Private Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateSubnetName")]
    public string? PrivateSubnetName { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the private_subnet_name field. This is the same as the ID of the subnet referred to by the private_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("privateSubnetNetworkSecurityGroupAssociationId")]
    public string? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Name of the Public IP for No Public IP workspace with managed virtual network. Defaults to nat-gw-public-ip. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpName")]
    public string? PublicIpName { get; set; }

    /// <summary>The name of the Public Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicSubnetName")]
    public string? PublicSubnetName { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the public_subnet_name field. This is the same as the ID of the subnet referred to by the public_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("publicSubnetNetworkSecurityGroupAssociationId")]
    public string? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Default Databricks File Storage account name. Defaults to a randomized name(e.g. dbstoragel6mfeghoe5kxu). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Storage account SKU name. Possible values include Standard_LRS, Standard_GRS, Standard_RAGRS, Standard_GZRS, Standard_RAGZRS, Standard_ZRS, Premium_LRS or Premium_ZRS. Defaults to Standard_GRS.</summary>
    [JsonPropertyName("storageAccountSkuName")]
    public string? StorageAccountSkuName { get; set; }

    /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>Address prefix for Managed virtual network. Defaults to 10.139. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetAddressPrefix")]
    public string? VnetAddressPrefix { get; set; }
}

/// <summary>An enhanced_security_compliance block as documented below. This feature is only valid if sku is set to premium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceStatusAtProviderEnhancedSecurityCompliance
{
    /// <summary>Enables automatic cluster updates for this workspace. Defaults to false.</summary>
    [JsonPropertyName("automaticClusterUpdateEnabled")]
    public bool? AutomaticClusterUpdateEnabled { get; set; }

    /// <summary>Enables compliance security profile for this workspace. Defaults to false.</summary>
    [JsonPropertyName("complianceSecurityProfileEnabled")]
    public bool? ComplianceSecurityProfileEnabled { get; set; }

    /// <summary>A list of standards to enforce on this workspace. Possible values include HIPAA and PCI_DSS.</summary>
    [JsonPropertyName("complianceSecurityProfileStandards")]
    public IList<string>? ComplianceSecurityProfileStandards { get; set; }

    /// <summary>Enables enhanced security monitoring for this workspace. Defaults to false.</summary>
    [JsonPropertyName("enhancedSecurityMonitoringEnabled")]
    public bool? EnhancedSecurityMonitoringEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceStatusAtProviderManagedDiskIdentity
{
    /// <summary>The principal UUID for the internal databricks disks identity needed to provide access to the workspace for enabling Customer Managed Keys.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The UUID of the tenant where the internal databricks disks identity was created.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of the internal databricks disks identity.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceStatusAtProviderStorageAccountIdentity
{
    /// <summary>The principal UUID for the internal databricks storage account needed to provide access to the workspace for enabling Customer Managed Keys.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The UUID of the tenant where the internal databricks storage account was created.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of the internal databricks storage account.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceStatusAtProvider
{
    /// <summary>Access Connector ID to use when default storage account firewall is enabled.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>A custom_parameters block as documented below.</summary>
    [JsonPropertyName("customParameters")]
    public V1beta2WorkspaceStatusAtProviderCustomParameters? CustomParameters { get; set; }

    /// <summary>Is the workspace enabled for customer managed key encryption? If true this enables the Managed Identity for the managed storage account. Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium.</summary>
    [JsonPropertyName("customerManagedKeyEnabled")]
    public bool? CustomerManagedKeyEnabled { get; set; }

    /// <summary>Disallow public access to default storage account. Defaults to false.</summary>
    [JsonPropertyName("defaultStorageFirewallEnabled")]
    public bool? DefaultStorageFirewallEnabled { get; set; }

    /// <summary>The ID of Managed Disk Encryption Set created by the Databricks Workspace.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>An enhanced_security_compliance block as documented below. This feature is only valid if sku is set to premium.</summary>
    [JsonPropertyName("enhancedSecurityCompliance")]
    public V1beta2WorkspaceStatusAtProviderEnhancedSecurityCompliance? EnhancedSecurityCompliance { get; set; }

    /// <summary>The ID of the Databricks Workspace in the Azure management plane.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Is the Databricks File System root file system enabled with a secondary layer of encryption with platform managed keys? Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Resource ID of the Outbound Load balancer Backend Address Pool for Secure Cluster Connectivity (No Public IP) workspace with managed virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolId")]
    public string? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Resource ID of the Key Vault which contains the managed_disk_cmk_key_vault_key_id key.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultId")]
    public string? ManagedDiskCmkKeyVaultId { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed disks.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultKeyId")]
    public string? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>Whether customer managed keys for disk encryption will automatically be rotated to the latest version.</summary>
    [JsonPropertyName("managedDiskCmkRotationToLatestVersionEnabled")]
    public bool? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>A managed_disk_identity block as documented below.</summary>
    [JsonPropertyName("managedDiskIdentity")]
    public IList<V1beta2WorkspaceStatusAtProviderManagedDiskIdentity>? ManagedDiskIdentity { get; set; }

    /// <summary>The ID of the Managed Resource Group created by the Databricks Workspace.</summary>
    [JsonPropertyName("managedResourceGroupId")]
    public string? ManagedResourceGroupId { get; set; }

    /// <summary>The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Resource ID of the Key Vault which contains the managed_services_cmk_key_vault_key_id key.</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultId")]
    public string? ManagedServicesCmkKeyVaultId { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed resources(e.g. Notebooks and Artifacts).</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultKeyId")]
    public string? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>Does the data plane (clusters) to control plane communication happen over private link endpoint only or publicly? Possible values AllRules, NoAzureDatabricksRules or NoAzureServiceRules. Required when public_network_access_enabled is set to false.</summary>
    [JsonPropertyName("networkSecurityGroupRulesRequired")]
    public string? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>Allow public access for accessing workspace. Set value to false to access workspace only via private link endpoint. Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The sku to use for the Databricks Workspace. Possible values are standard, premium, or trial.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A storage_account_identity block as documented below.</summary>
    [JsonPropertyName("storageAccountIdentity")]
    public IList<V1beta2WorkspaceStatusAtProviderStorageAccountIdentity>? StorageAccountIdentity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The unique identifier of the databricks workspace in Databricks control plane.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>The workspace URL which is of the format &apos;adb-{workspaceId}.{random}.azuredatabricks.net&apos;</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceStatusConditions
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

/// <summary>WorkspaceStatus defines the observed state of Workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkspaceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WorkspaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workspace is the Schema for the Workspaces API. Manages a Databricks Workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WorkspaceSpec>, IStatus<V1beta2WorkspaceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "databricks.azure.upbound.io";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databricks.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workspace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkspaceSpec defines the desired state of Workspace</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WorkspaceSpec Spec { get; set; }

    /// <summary>WorkspaceStatus defines the observed state of Workspace.</summary>
    [JsonPropertyName("status")]
    public V1beta2WorkspaceStatus? Status { get; set; }
}
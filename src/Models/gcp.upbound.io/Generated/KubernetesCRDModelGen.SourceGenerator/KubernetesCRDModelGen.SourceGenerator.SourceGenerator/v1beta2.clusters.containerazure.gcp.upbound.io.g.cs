#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerazure.gcp.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API. An Anthos cluster running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Cluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "containerazure.gcp.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerazure.gcp.upbound.io/v1beta2";

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderAuthorizationAdminGroups
{
    /// <summary>The name of the group, e.g. my-group@domain.com.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderAuthorizationAdminUsers
{
    /// <summary>The name of the user, e.g. my-gcp-id@gmail.com.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Configuration related to the cluster RBAC settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderAuthorization
{
    /// <summary>Groups of users that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the groups. Up to ten admin groups can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminGroups")]
    public IList<V1beta2ClusterSpecForProviderAuthorizationAdminGroups>? AdminGroups { get; set; }

    /// <summary>Users that can perform operations as a cluster admin. A new ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the users. Up to ten admin users can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminUsers")]
    public IList<V1beta2ClusterSpecForProviderAuthorizationAdminUsers>? AdminUsers { get; set; }
}

/// <summary>Azure authentication configuration for management of Azure resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderAzureServicesAuthentication
{
    /// <summary>The Azure Active Directory Application ID for Authentication configuration.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID for Authentication configuration.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Optional. Configuration related to application-layer secrets encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderControlPlaneDatabaseEncryption
{
    /// <summary>The ARM ID of the Azure Key Vault key to encrypt / decrypt data. For example: /subscriptions/&lt;subscription-id&gt;/resourceGroups/&lt;resource-group-id&gt;/providers/Microsoft.KeyVault/vaults/&lt;key-vault-id&gt;/keys/&lt;key-name&gt; Encryption will always take the latest version of the key and hence specific version is not supported.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>Optional. Configuration related to the main volume provisioned for each control plane replica. The main volume is in charge of storing all of the cluster&apos;s etcd state. When unspecified, it defaults to a 8-GiB Azure Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderControlPlaneMainVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

/// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderControlPlaneProxyConfig
{
    /// <summary>The ARM ID of the resource group where the cluster resources are deployed. For example: /subscriptions/*/resourceGroups/*</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>The URL the of the proxy setting secret with its version. Secret ids are formatted as https:&lt;key-vault-name&gt;.vault.azure.net/secrets/&lt;secret-name&gt;/&lt;secret-version&gt;.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderControlPlaneReplicaPlacements
{
    /// <summary>For a given replica, the Azure availability zone where to provision the control plane VM and the ETCD disk.</summary>
    [JsonPropertyName("azureAvailabilityZone")]
    public string? AzureAvailabilityZone { get; set; }

    /// <summary>For a given replica, the ARM ID of the subnet where the control plane VM is deployed. Make sure it&apos;s a subnet under the virtual network in the cluster configuration.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>Optional. Configuration related to the root volume provisioned for each control plane replica. When unspecified, it defaults to 32-GiB Azure Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderControlPlaneRootVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

/// <summary>SSH configuration for how to access the underlying control plane machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderControlPlaneSshConfig
{
    /// <summary>The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.</summary>
    [JsonPropertyName("authorizedKey")]
    public string? AuthorizedKey { get; set; }
}

/// <summary>Configuration related to the cluster control plane.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderControlPlane
{
    /// <summary>Optional. Configuration related to application-layer secrets encryption.</summary>
    [JsonPropertyName("databaseEncryption")]
    public V1beta2ClusterSpecForProviderControlPlaneDatabaseEncryption? DatabaseEncryption { get; set; }

    /// <summary>Optional. Configuration related to the main volume provisioned for each control plane replica. The main volume is in charge of storing all of the cluster&apos;s etcd state. When unspecified, it defaults to a 8-GiB Azure Disk.</summary>
    [JsonPropertyName("mainVolume")]
    public V1beta2ClusterSpecForProviderControlPlaneMainVolume? MainVolume { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta2ClusterSpecForProviderControlPlaneProxyConfig? ProxyConfig { get; set; }

    /// <summary>Configuration for where to place the control plane replicas. Up to three replica placement instances can be specified. If replica_placements is set, the replica placement instances will be applied to the three control plane replicas as evenly as possible.</summary>
    [JsonPropertyName("replicaPlacements")]
    public IList<V1beta2ClusterSpecForProviderControlPlaneReplicaPlacements>? ReplicaPlacements { get; set; }

    /// <summary>Optional. Configuration related to the root volume provisioned for each control plane replica. When unspecified, it defaults to 32-GiB Azure Disk.</summary>
    [JsonPropertyName("rootVolume")]
    public V1beta2ClusterSpecForProviderControlPlaneRootVolume? RootVolume { get; set; }

    /// <summary>SSH configuration for how to access the underlying control plane machines.</summary>
    [JsonPropertyName("sshConfig")]
    public V1beta2ClusterSpecForProviderControlPlaneSshConfig? SshConfig { get; set; }

    /// <summary>The ARM ID of the subnet where the control plane VMs are deployed. Example: /subscriptions//resourceGroups//providers/Microsoft.Network/virtualNetworks//subnets/default.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Optional. A set of tags to apply to all underlying control plane Azure resources.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Kubernetes version to run on control plane replicas (e.g. 1.19.10-gke.1000). You can list all supported versions on a given Google Cloud region by calling GetAzureServerConfig.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Optional. The Azure VM size name. Example: Standard_DS2_v2. For available VM sizes, see https://docs.microsoft.com/en-us/azure/virtual-machines/vm-naming-conventions. When unspecified, it defaults to Standard_DS2_v2.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Fleet configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>Cluster-wide networking configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderNetworking
{
    /// <summary>The IP address range of the pods in this cluster, in CIDR notation (e.g. 10.96.0.0/14). All pods in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.</summary>
    [JsonPropertyName("podAddressCidrBlocks")]
    public IList<string>? PodAddressCidrBlocks { get; set; }

    /// <summary>The IP address range for services in this cluster, in CIDR notation (e.g. 10.96.0.0/14). All services in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creating a cluster.</summary>
    [JsonPropertyName("serviceAddressCidrBlocks")]
    public IList<string>? ServiceAddressCidrBlocks { get; set; }

    /// <summary>The Azure Resource Manager (ARM) ID of the VNet associated with your cluster. All components in the cluster (i.e. control plane and node pools) run on a single VNet. Example: /subscriptions/*/resourceGroups/*/providers/Microsoft.Network/virtualNetworks/* This field cannot be changed after creation.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings.</summary>
    [JsonPropertyName("authorization")]
    public V1beta2ClusterSpecForProviderAuthorization? Authorization { get; set; }

    /// <summary>The Azure region where the cluster runs. Each Google Cloud region supports a subset of nearby Azure regions. You can call to list all supported Azure regions within a given Google Cloud region.</summary>
    [JsonPropertyName("azureRegion")]
    public string? AzureRegion { get; set; }

    /// <summary>Azure authentication configuration for management of Azure resources</summary>
    [JsonPropertyName("azureServicesAuthentication")]
    public V1beta2ClusterSpecForProviderAzureServicesAuthentication? AzureServicesAuthentication { get; set; }

    /// <summary>Name of the AzureClient. The AzureClient resource must reside on the same GCP project and region as the AzureCluster. AzureClient names are formatted as projects/&lt;project-number&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;. See Resource Names (https:cloud.google.com/apis/design/resource_names) for more details on Google Cloud resource names.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Configuration related to the cluster control plane.</summary>
    [JsonPropertyName("controlPlane")]
    public V1beta2ClusterSpecForProviderControlPlane? ControlPlane { get; set; }

    /// <summary>Optional. A human readable description of this cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Fleet configuration.</summary>
    [JsonPropertyName("fleet")]
    public V1beta2ClusterSpecForProviderFleet? Fleet { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Cluster-wide networking configuration.</summary>
    [JsonPropertyName("networking")]
    public V1beta2ClusterSpecForProviderNetworking? Networking { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The ARM ID of the resource group where the cluster resources are deployed. For example: /subscriptions/*/resourceGroups/*</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderAuthorizationAdminGroups
{
    /// <summary>The name of the group, e.g. my-group@domain.com.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderAuthorizationAdminUsers
{
    /// <summary>The name of the user, e.g. my-gcp-id@gmail.com.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Configuration related to the cluster RBAC settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderAuthorization
{
    /// <summary>Groups of users that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the groups. Up to ten admin groups can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminGroups")]
    public IList<V1beta2ClusterSpecInitProviderAuthorizationAdminGroups>? AdminGroups { get; set; }

    /// <summary>Users that can perform operations as a cluster admin. A new ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the users. Up to ten admin users can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminUsers")]
    public IList<V1beta2ClusterSpecInitProviderAuthorizationAdminUsers>? AdminUsers { get; set; }
}

/// <summary>Azure authentication configuration for management of Azure resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderAzureServicesAuthentication
{
    /// <summary>The Azure Active Directory Application ID for Authentication configuration.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID for Authentication configuration.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Optional. Configuration related to application-layer secrets encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderControlPlaneDatabaseEncryption
{
    /// <summary>The ARM ID of the Azure Key Vault key to encrypt / decrypt data. For example: /subscriptions/&lt;subscription-id&gt;/resourceGroups/&lt;resource-group-id&gt;/providers/Microsoft.KeyVault/vaults/&lt;key-vault-id&gt;/keys/&lt;key-name&gt; Encryption will always take the latest version of the key and hence specific version is not supported.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>Optional. Configuration related to the main volume provisioned for each control plane replica. The main volume is in charge of storing all of the cluster&apos;s etcd state. When unspecified, it defaults to a 8-GiB Azure Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderControlPlaneMainVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

/// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderControlPlaneProxyConfig
{
    /// <summary>The ARM ID of the resource group where the cluster resources are deployed. For example: /subscriptions/*/resourceGroups/*</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>The URL the of the proxy setting secret with its version. Secret ids are formatted as https:&lt;key-vault-name&gt;.vault.azure.net/secrets/&lt;secret-name&gt;/&lt;secret-version&gt;.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderControlPlaneReplicaPlacements
{
    /// <summary>For a given replica, the Azure availability zone where to provision the control plane VM and the ETCD disk.</summary>
    [JsonPropertyName("azureAvailabilityZone")]
    public string? AzureAvailabilityZone { get; set; }

    /// <summary>For a given replica, the ARM ID of the subnet where the control plane VM is deployed. Make sure it&apos;s a subnet under the virtual network in the cluster configuration.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>Optional. Configuration related to the root volume provisioned for each control plane replica. When unspecified, it defaults to 32-GiB Azure Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderControlPlaneRootVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

/// <summary>SSH configuration for how to access the underlying control plane machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderControlPlaneSshConfig
{
    /// <summary>The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.</summary>
    [JsonPropertyName("authorizedKey")]
    public string? AuthorizedKey { get; set; }
}

/// <summary>Configuration related to the cluster control plane.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderControlPlane
{
    /// <summary>Optional. Configuration related to application-layer secrets encryption.</summary>
    [JsonPropertyName("databaseEncryption")]
    public V1beta2ClusterSpecInitProviderControlPlaneDatabaseEncryption? DatabaseEncryption { get; set; }

    /// <summary>Optional. Configuration related to the main volume provisioned for each control plane replica. The main volume is in charge of storing all of the cluster&apos;s etcd state. When unspecified, it defaults to a 8-GiB Azure Disk.</summary>
    [JsonPropertyName("mainVolume")]
    public V1beta2ClusterSpecInitProviderControlPlaneMainVolume? MainVolume { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta2ClusterSpecInitProviderControlPlaneProxyConfig? ProxyConfig { get; set; }

    /// <summary>Configuration for where to place the control plane replicas. Up to three replica placement instances can be specified. If replica_placements is set, the replica placement instances will be applied to the three control plane replicas as evenly as possible.</summary>
    [JsonPropertyName("replicaPlacements")]
    public IList<V1beta2ClusterSpecInitProviderControlPlaneReplicaPlacements>? ReplicaPlacements { get; set; }

    /// <summary>Optional. Configuration related to the root volume provisioned for each control plane replica. When unspecified, it defaults to 32-GiB Azure Disk.</summary>
    [JsonPropertyName("rootVolume")]
    public V1beta2ClusterSpecInitProviderControlPlaneRootVolume? RootVolume { get; set; }

    /// <summary>SSH configuration for how to access the underlying control plane machines.</summary>
    [JsonPropertyName("sshConfig")]
    public V1beta2ClusterSpecInitProviderControlPlaneSshConfig? SshConfig { get; set; }

    /// <summary>The ARM ID of the subnet where the control plane VMs are deployed. Example: /subscriptions//resourceGroups//providers/Microsoft.Network/virtualNetworks//subnets/default.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Optional. A set of tags to apply to all underlying control plane Azure resources.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Kubernetes version to run on control plane replicas (e.g. 1.19.10-gke.1000). You can list all supported versions on a given Google Cloud region by calling GetAzureServerConfig.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Optional. The Azure VM size name. Example: Standard_DS2_v2. For available VM sizes, see https://docs.microsoft.com/en-us/azure/virtual-machines/vm-naming-conventions. When unspecified, it defaults to Standard_DS2_v2.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Fleet configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>Cluster-wide networking configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderNetworking
{
    /// <summary>The IP address range of the pods in this cluster, in CIDR notation (e.g. 10.96.0.0/14). All pods in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.</summary>
    [JsonPropertyName("podAddressCidrBlocks")]
    public IList<string>? PodAddressCidrBlocks { get; set; }

    /// <summary>The IP address range for services in this cluster, in CIDR notation (e.g. 10.96.0.0/14). All services in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creating a cluster.</summary>
    [JsonPropertyName("serviceAddressCidrBlocks")]
    public IList<string>? ServiceAddressCidrBlocks { get; set; }

    /// <summary>The Azure Resource Manager (ARM) ID of the VNet associated with your cluster. All components in the cluster (i.e. control plane and node pools) run on a single VNet. Example: /subscriptions/*/resourceGroups/*/providers/Microsoft.Network/virtualNetworks/* This field cannot be changed after creation.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
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
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings.</summary>
    [JsonPropertyName("authorization")]
    public V1beta2ClusterSpecInitProviderAuthorization? Authorization { get; set; }

    /// <summary>The Azure region where the cluster runs. Each Google Cloud region supports a subset of nearby Azure regions. You can call to list all supported Azure regions within a given Google Cloud region.</summary>
    [JsonPropertyName("azureRegion")]
    public string? AzureRegion { get; set; }

    /// <summary>Azure authentication configuration for management of Azure resources</summary>
    [JsonPropertyName("azureServicesAuthentication")]
    public V1beta2ClusterSpecInitProviderAzureServicesAuthentication? AzureServicesAuthentication { get; set; }

    /// <summary>Name of the AzureClient. The AzureClient resource must reside on the same GCP project and region as the AzureCluster. AzureClient names are formatted as projects/&lt;project-number&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;. See Resource Names (https:cloud.google.com/apis/design/resource_names) for more details on Google Cloud resource names.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Configuration related to the cluster control plane.</summary>
    [JsonPropertyName("controlPlane")]
    public V1beta2ClusterSpecInitProviderControlPlane? ControlPlane { get; set; }

    /// <summary>Optional. A human readable description of this cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Fleet configuration.</summary>
    [JsonPropertyName("fleet")]
    public V1beta2ClusterSpecInitProviderFleet? Fleet { get; set; }

    /// <summary>Cluster-wide networking configuration.</summary>
    [JsonPropertyName("networking")]
    public V1beta2ClusterSpecInitProviderNetworking? Networking { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The ARM ID of the resource group where the cluster resources are deployed. For example: /subscriptions/*/resourceGroups/*</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderAuthorizationAdminGroups
{
    /// <summary>The name of the group, e.g. my-group@domain.com.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderAuthorizationAdminUsers
{
    /// <summary>The name of the user, e.g. my-gcp-id@gmail.com.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Configuration related to the cluster RBAC settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderAuthorization
{
    /// <summary>Groups of users that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the groups. Up to ten admin groups can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminGroups")]
    public IList<V1beta2ClusterStatusAtProviderAuthorizationAdminGroups>? AdminGroups { get; set; }

    /// <summary>Users that can perform operations as a cluster admin. A new ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the users. Up to ten admin users can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminUsers")]
    public IList<V1beta2ClusterStatusAtProviderAuthorizationAdminUsers>? AdminUsers { get; set; }
}

/// <summary>Azure authentication configuration for management of Azure resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderAzureServicesAuthentication
{
    /// <summary>The Azure Active Directory Application ID for Authentication configuration.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID for Authentication configuration.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Optional. Configuration related to application-layer secrets encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderControlPlaneDatabaseEncryption
{
    /// <summary>The ARM ID of the Azure Key Vault key to encrypt / decrypt data. For example: /subscriptions/&lt;subscription-id&gt;/resourceGroups/&lt;resource-group-id&gt;/providers/Microsoft.KeyVault/vaults/&lt;key-vault-id&gt;/keys/&lt;key-name&gt; Encryption will always take the latest version of the key and hence specific version is not supported.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>Optional. Configuration related to the main volume provisioned for each control plane replica. The main volume is in charge of storing all of the cluster&apos;s etcd state. When unspecified, it defaults to a 8-GiB Azure Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderControlPlaneMainVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

/// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderControlPlaneProxyConfig
{
    /// <summary>The ARM ID of the resource group where the cluster resources are deployed. For example: /subscriptions/*/resourceGroups/*</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>The URL the of the proxy setting secret with its version. Secret ids are formatted as https:&lt;key-vault-name&gt;.vault.azure.net/secrets/&lt;secret-name&gt;/&lt;secret-version&gt;.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderControlPlaneReplicaPlacements
{
    /// <summary>For a given replica, the Azure availability zone where to provision the control plane VM and the ETCD disk.</summary>
    [JsonPropertyName("azureAvailabilityZone")]
    public string? AzureAvailabilityZone { get; set; }

    /// <summary>For a given replica, the ARM ID of the subnet where the control plane VM is deployed. Make sure it&apos;s a subnet under the virtual network in the cluster configuration.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>Optional. Configuration related to the root volume provisioned for each control plane replica. When unspecified, it defaults to 32-GiB Azure Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderControlPlaneRootVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

/// <summary>SSH configuration for how to access the underlying control plane machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderControlPlaneSshConfig
{
    /// <summary>The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.</summary>
    [JsonPropertyName("authorizedKey")]
    public string? AuthorizedKey { get; set; }
}

/// <summary>Configuration related to the cluster control plane.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderControlPlane
{
    /// <summary>Optional. Configuration related to application-layer secrets encryption.</summary>
    [JsonPropertyName("databaseEncryption")]
    public V1beta2ClusterStatusAtProviderControlPlaneDatabaseEncryption? DatabaseEncryption { get; set; }

    /// <summary>Optional. Configuration related to the main volume provisioned for each control plane replica. The main volume is in charge of storing all of the cluster&apos;s etcd state. When unspecified, it defaults to a 8-GiB Azure Disk.</summary>
    [JsonPropertyName("mainVolume")]
    public V1beta2ClusterStatusAtProviderControlPlaneMainVolume? MainVolume { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta2ClusterStatusAtProviderControlPlaneProxyConfig? ProxyConfig { get; set; }

    /// <summary>Configuration for where to place the control plane replicas. Up to three replica placement instances can be specified. If replica_placements is set, the replica placement instances will be applied to the three control plane replicas as evenly as possible.</summary>
    [JsonPropertyName("replicaPlacements")]
    public IList<V1beta2ClusterStatusAtProviderControlPlaneReplicaPlacements>? ReplicaPlacements { get; set; }

    /// <summary>Optional. Configuration related to the root volume provisioned for each control plane replica. When unspecified, it defaults to 32-GiB Azure Disk.</summary>
    [JsonPropertyName("rootVolume")]
    public V1beta2ClusterStatusAtProviderControlPlaneRootVolume? RootVolume { get; set; }

    /// <summary>SSH configuration for how to access the underlying control plane machines.</summary>
    [JsonPropertyName("sshConfig")]
    public V1beta2ClusterStatusAtProviderControlPlaneSshConfig? SshConfig { get; set; }

    /// <summary>The ARM ID of the subnet where the control plane VMs are deployed. Example: /subscriptions//resourceGroups//providers/Microsoft.Network/virtualNetworks//subnets/default.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Optional. A set of tags to apply to all underlying control plane Azure resources.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Kubernetes version to run on control plane replicas (e.g. 1.19.10-gke.1000). You can list all supported versions on a given Google Cloud region by calling GetAzureServerConfig.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Optional. The Azure VM size name. Example: Standard_DS2_v2. For available VM sizes, see https://docs.microsoft.com/en-us/azure/virtual-machines/vm-naming-conventions. When unspecified, it defaults to Standard_DS2_v2.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Fleet configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderFleet
{
    /// <summary>The name of the managed Hub Membership resource associated to this cluster. Membership names are formatted as projects//locations/global/membership/.</summary>
    [JsonPropertyName("membership")]
    public string? Membership { get; set; }

    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>Cluster-wide networking configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderNetworking
{
    /// <summary>The IP address range of the pods in this cluster, in CIDR notation (e.g. 10.96.0.0/14). All pods in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.</summary>
    [JsonPropertyName("podAddressCidrBlocks")]
    public IList<string>? PodAddressCidrBlocks { get; set; }

    /// <summary>The IP address range for services in this cluster, in CIDR notation (e.g. 10.96.0.0/14). All services in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creating a cluster.</summary>
    [JsonPropertyName("serviceAddressCidrBlocks")]
    public IList<string>? ServiceAddressCidrBlocks { get; set; }

    /// <summary>The Azure Resource Manager (ARM) ID of the VNet associated with your cluster. All components in the cluster (i.e. control plane and node pools) run on a single VNet. Example: /subscriptions/*/resourceGroups/*/providers/Microsoft.Network/virtualNetworks/* This field cannot be changed after creation.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderWorkloadIdentityConfig
{
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    [JsonPropertyName("workloadPool")]
    public string? WorkloadPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings.</summary>
    [JsonPropertyName("authorization")]
    public V1beta2ClusterStatusAtProviderAuthorization? Authorization { get; set; }

    /// <summary>The Azure region where the cluster runs. Each Google Cloud region supports a subset of nearby Azure regions. You can call to list all supported Azure regions within a given Google Cloud region.</summary>
    [JsonPropertyName("azureRegion")]
    public string? AzureRegion { get; set; }

    /// <summary>Azure authentication configuration for management of Azure resources</summary>
    [JsonPropertyName("azureServicesAuthentication")]
    public V1beta2ClusterStatusAtProviderAzureServicesAuthentication? AzureServicesAuthentication { get; set; }

    /// <summary>Name of the AzureClient. The AzureClient resource must reside on the same GCP project and region as the AzureCluster. AzureClient names are formatted as projects/&lt;project-number&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;. See Resource Names (https:cloud.google.com/apis/design/resource_names) for more details on Google Cloud resource names.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Configuration related to the cluster control plane.</summary>
    [JsonPropertyName("controlPlane")]
    public V1beta2ClusterStatusAtProviderControlPlane? ControlPlane { get; set; }

    /// <summary>Output only. The time at which this cluster was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. A human readable description of this cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>Output only. The endpoint of the cluster&apos;s API server.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Fleet configuration.</summary>
    [JsonPropertyName("fleet")]
    public V1beta2ClusterStatusAtProviderFleet? Fleet { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/azureClusters/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Cluster-wide networking configuration.</summary>
    [JsonPropertyName("networking")]
    public V1beta2ClusterStatusAtProviderNetworking? Networking { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Output only. If set, there are currently changes in flight to the cluster.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The ARM ID of the resource group where the cluster resources are deployed. For example: /subscriptions/*/resourceGroups/*</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Output only. The current state of the cluster. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. A globally unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time at which this cluster was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. Workload Identity settings.</summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public IList<V1beta2ClusterStatusAtProviderWorkloadIdentityConfig>? WorkloadIdentityConfig { get; set; }
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

/// <summary>Cluster is the Schema for the Clusters API. An Anthos cluster running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ClusterSpec>, IStatus<V1beta2ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "containerazure.gcp.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerazure.gcp.upbound.io/v1beta2";

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
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/workspace.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210601WorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V20210601Workspace>
{
    public const string KubeApiVersion = "v20210601";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.com/v20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20210601Workspace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20210601Workspace> Items { get; set; }
}

/// <summary>CspWorkspaceAdminProperties: Initial workspace AAD admin properties for a CSP subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecCspWorkspaceAdminProperties
{
    /// <summary>InitialWorkspaceAdminObjectId: AAD object ID of initial workspace admin</summary>
    [JsonPropertyName("initialWorkspaceAdminObjectId")]
    public string? InitialWorkspaceAdminObjectId { get; set; }
}

/// <summary>AccountUrlFromConfig: Account URL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecDefaultDataLakeStorageAccountUrlFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ResourceReference: ARM resource Id of this storage account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecDefaultDataLakeStorageResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>DefaultDataLakeStorage: Workspace default data lake storage account details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecDefaultDataLakeStorage
{
    /// <summary>AccountUrl: Account URL</summary>
    [JsonPropertyName("accountUrl")]
    public string? AccountUrl { get; set; }

    /// <summary>AccountUrlFromConfig: Account URL</summary>
    [JsonPropertyName("accountUrlFromConfig")]
    public V20210601WorkspaceSpecDefaultDataLakeStorageAccountUrlFromConfig? AccountUrlFromConfig { get; set; }

    /// <summary>CreateManagedPrivateEndpoint: Create managed private endpoint to this storage account or not</summary>
    [JsonPropertyName("createManagedPrivateEndpoint")]
    public bool? CreateManagedPrivateEndpoint { get; set; }

    /// <summary>Filesystem: Filesystem name</summary>
    [JsonPropertyName("filesystem")]
    public string? Filesystem { get; set; }

    /// <summary>ResourceReference: ARM resource Id of this storage account</summary>
    [JsonPropertyName("resourceReference")]
    public V20210601WorkspaceSpecDefaultDataLakeStorageResourceReference? ResourceReference { get; set; }
}

/// <summary>UserAssignedIdentityReference: User assigned identity resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecEncryptionCmkKekIdentityUserAssignedIdentityReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>KekIdentity: Key encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecEncryptionCmkKekIdentity
{
    /// <summary>UseSystemAssignedIdentity: Boolean specifying whether to use system assigned identity or not</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public JsonNode? UseSystemAssignedIdentity { get; set; }

    /// <summary>UserAssignedIdentityReference: User assigned identity resource Id</summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V20210601WorkspaceSpecEncryptionCmkKekIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>Key: The key object of the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecEncryptionCmkKey
{
    /// <summary>KeyVaultUrl: Workspace Key sub-resource key vault url</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary>Name: Workspace Key sub-resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Cmk: Customer Managed Key Details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecEncryptionCmk
{
    /// <summary>KekIdentity: Key encryption key</summary>
    [JsonPropertyName("kekIdentity")]
    public V20210601WorkspaceSpecEncryptionCmkKekIdentity? KekIdentity { get; set; }

    /// <summary>Key: The key object of the workspace</summary>
    [JsonPropertyName("key")]
    public V20210601WorkspaceSpecEncryptionCmkKey? Key { get; set; }
}

/// <summary>Encryption: The encryption details of the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecEncryption
{
    /// <summary>Cmk: Customer Managed Key Details</summary>
    [JsonPropertyName("cmk")]
    public V20210601WorkspaceSpecEncryptionCmk? Cmk { get; set; }
}

/// <summary>Type: The type of managed identity for the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210601WorkspaceSpecIdentityTypeEnum>))]
public enum V20210601WorkspaceSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20210601WorkspaceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Identity of the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecIdentity
{
    /// <summary>Type: The type of managed identity for the workspace</summary>
    [JsonPropertyName("type")]
    public V20210601WorkspaceSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: The user assigned managed identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20210601WorkspaceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ManagedVirtualNetworkSettings: Managed Virtual Network Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecManagedVirtualNetworkSettings
{
    /// <summary>AllowedAadTenantIdsForLinking: Allowed Aad Tenant Ids For Linking</summary>
    [JsonPropertyName("allowedAadTenantIdsForLinking")]
    public IList<string>? AllowedAadTenantIdsForLinking { get; set; }

    /// <summary>LinkedAccessCheckOnTargetResource: Linked Access Check On Target Resource</summary>
    [JsonPropertyName("linkedAccessCheckOnTargetResource")]
    public bool? LinkedAccessCheckOnTargetResource { get; set; }

    /// <summary>PreventDataExfiltration: Prevent Data Exfiltration</summary>
    [JsonPropertyName("preventDataExfiltration")]
    public bool? PreventDataExfiltration { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20210601WorkspaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20210601WorkspaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccess: Enable or Disable public network access to workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210601WorkspaceSpecPublicNetworkAccessEnum>))]
public enum V20210601WorkspaceSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PurviewResourceReference: Purview Resource ID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecPurviewConfigurationPurviewResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PurviewConfiguration: Purview Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecPurviewConfiguration
{
    /// <summary>PurviewResourceReference: Purview Resource ID</summary>
    [JsonPropertyName("purviewResourceReference")]
    public V20210601WorkspaceSpecPurviewConfigurationPurviewResourceReference? PurviewResourceReference { get; set; }
}

/// <summary>SqlAdministratorLoginPassword: SQL administrator login password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecSqlAdministratorLoginPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>VirtualNetworkProfile: Virtual Network profile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecVirtualNetworkProfile
{
    /// <summary>ComputeSubnetId: Subnet ID used for computes in workspace</summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }
}

/// <summary>WorkspaceRepositoryConfiguration: Git integration settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpecWorkspaceRepositoryConfiguration
{
    /// <summary>AccountName: Account name</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>CollaborationBranch: Collaboration branch</summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary>HostName: GitHub Enterprise host name. For example: `https://github.mydomain.com`</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>LastCommitId: The last commit ID</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>ProjectName: VSTS project name</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>RepositoryName: Repository name</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>RootFolder: Root folder to use in the repository</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>TenantId: The VSTS tenant ID</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of workspace repositoryID configuration. Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceSpec
{
    /// <summary>AzureADOnlyAuthentication: Enable or Disable AzureADOnlyAuthentication on All Workspace subresource</summary>
    [JsonPropertyName("azureADOnlyAuthentication")]
    public bool? AzureADOnlyAuthentication { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CspWorkspaceAdminProperties: Initial workspace AAD admin properties for a CSP subscription</summary>
    [JsonPropertyName("cspWorkspaceAdminProperties")]
    public V20210601WorkspaceSpecCspWorkspaceAdminProperties? CspWorkspaceAdminProperties { get; set; }

    /// <summary>DefaultDataLakeStorage: Workspace default data lake storage account details</summary>
    [JsonPropertyName("defaultDataLakeStorage")]
    public V20210601WorkspaceSpecDefaultDataLakeStorage? DefaultDataLakeStorage { get; set; }

    /// <summary>Encryption: The encryption details of the workspace</summary>
    [JsonPropertyName("encryption")]
    public V20210601WorkspaceSpecEncryption? Encryption { get; set; }

    /// <summary>Identity: Identity of the workspace</summary>
    [JsonPropertyName("identity")]
    public V20210601WorkspaceSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// ManagedResourceGroupName: Workspace managed resource group. The resource group name uniquely identifies the resource
    /// group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be
    /// alphanumeric characters (Char.IsLetterOrDigit()) and &apos;-&apos;, &apos;_&apos;, &apos;(&apos;, &apos;)&apos; and&apos;.&apos;. Note that the name cannot end with &apos;.&apos;
    /// </summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>
    /// ManagedVirtualNetwork: Setting this to &apos;default&apos; will ensure that all compute for this workspace is in a virtual network
    /// managed on behalf of the user.
    /// </summary>
    [JsonPropertyName("managedVirtualNetwork")]
    public string? ManagedVirtualNetwork { get; set; }

    /// <summary>ManagedVirtualNetworkSettings: Managed Virtual Network Settings</summary>
    [JsonPropertyName("managedVirtualNetworkSettings")]
    public V20210601WorkspaceSpecManagedVirtualNetworkSettings? ManagedVirtualNetworkSettings { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20210601WorkspaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20210601WorkspaceSpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccess: Enable or Disable public network access to workspace</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20210601WorkspaceSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>PurviewConfiguration: Purview Configuration</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V20210601WorkspaceSpecPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary>SqlAdministratorLogin: Login for workspace SQL active directory administrator</summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary>SqlAdministratorLoginPassword: SQL administrator login password</summary>
    [JsonPropertyName("sqlAdministratorLoginPassword")]
    public V20210601WorkspaceSpecSqlAdministratorLoginPassword? SqlAdministratorLoginPassword { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TrustedServiceBypassEnabled: Is trustedServiceBypassEnabled for the workspace</summary>
    [JsonPropertyName("trustedServiceBypassEnabled")]
    public bool? TrustedServiceBypassEnabled { get; set; }

    /// <summary>VirtualNetworkProfile: Virtual Network profile</summary>
    [JsonPropertyName("virtualNetworkProfile")]
    public V20210601WorkspaceSpecVirtualNetworkProfile? VirtualNetworkProfile { get; set; }

    /// <summary>WorkspaceRepositoryConfiguration: Git integration settings</summary>
    [JsonPropertyName("workspaceRepositoryConfiguration")]
    public V20210601WorkspaceSpecWorkspaceRepositoryConfiguration? WorkspaceRepositoryConfiguration { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>CspWorkspaceAdminProperties: Initial workspace AAD admin properties for a CSP subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusCspWorkspaceAdminProperties
{
    /// <summary>InitialWorkspaceAdminObjectId: AAD object ID of initial workspace admin</summary>
    [JsonPropertyName("initialWorkspaceAdminObjectId")]
    public string? InitialWorkspaceAdminObjectId { get; set; }
}

/// <summary>DefaultDataLakeStorage: Workspace default data lake storage account details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusDefaultDataLakeStorage
{
    /// <summary>AccountUrl: Account URL</summary>
    [JsonPropertyName("accountUrl")]
    public string? AccountUrl { get; set; }

    /// <summary>CreateManagedPrivateEndpoint: Create managed private endpoint to this storage account or not</summary>
    [JsonPropertyName("createManagedPrivateEndpoint")]
    public bool? CreateManagedPrivateEndpoint { get; set; }

    /// <summary>Filesystem: Filesystem name</summary>
    [JsonPropertyName("filesystem")]
    public string? Filesystem { get; set; }

    /// <summary>ResourceId: ARM resource Id of this storage account</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>KekIdentity: Key encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusEncryptionCmkKekIdentity
{
    /// <summary>UseSystemAssignedIdentity: Boolean specifying whether to use system assigned identity or not</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public JsonNode? UseSystemAssignedIdentity { get; set; }

    /// <summary>UserAssignedIdentity: User assigned identity resource Id</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Key: The key object of the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusEncryptionCmkKey
{
    /// <summary>KeyVaultUrl: Workspace Key sub-resource key vault url</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary>Name: Workspace Key sub-resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Cmk: Customer Managed Key Details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusEncryptionCmk
{
    /// <summary>KekIdentity: Key encryption key</summary>
    [JsonPropertyName("kekIdentity")]
    public V20210601WorkspaceStatusEncryptionCmkKekIdentity? KekIdentity { get; set; }

    /// <summary>Key: The key object of the workspace</summary>
    [JsonPropertyName("key")]
    public V20210601WorkspaceStatusEncryptionCmkKey? Key { get; set; }

    /// <summary>Status: The customer managed key status on the workspace</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Encryption: The encryption details of the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusEncryption
{
    /// <summary>Cmk: Customer Managed Key Details</summary>
    [JsonPropertyName("cmk")]
    public V20210601WorkspaceStatusEncryptionCmk? Cmk { get; set; }

    /// <summary>DoubleEncryptionEnabled: Double Encryption enabled</summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }
}

/// <summary>User Assigned Managed Identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Identity of the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of the workspace managed identity</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of the workspace managed identity</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The type of managed identity for the workspace</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The user assigned managed identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20210601WorkspaceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ManagedVirtualNetworkSettings: Managed Virtual Network Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusManagedVirtualNetworkSettings
{
    /// <summary>AllowedAadTenantIdsForLinking: Allowed Aad Tenant Ids For Linking</summary>
    [JsonPropertyName("allowedAadTenantIdsForLinking")]
    public IList<string>? AllowedAadTenantIdsForLinking { get; set; }

    /// <summary>LinkedAccessCheckOnTargetResource: Linked Access Check On Target Resource</summary>
    [JsonPropertyName("linkedAccessCheckOnTargetResource")]
    public bool? LinkedAccessCheckOnTargetResource { get; set; }

    /// <summary>PreventDataExfiltration: Prevent Data Exfiltration</summary>
    [JsonPropertyName("preventDataExfiltration")]
    public bool? PreventDataExfiltration { get; set; }
}

/// <summary>A private endpoint connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PurviewConfiguration: Purview Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusPurviewConfiguration
{
    /// <summary>PurviewResourceId: Purview Resource ID</summary>
    [JsonPropertyName("purviewResourceId")]
    public string? PurviewResourceId { get; set; }
}

/// <summary>VirtualNetworkProfile: Virtual Network profile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusVirtualNetworkProfile
{
    /// <summary>ComputeSubnetId: Subnet ID used for computes in workspace</summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }
}

/// <summary>WorkspaceRepositoryConfiguration: Git integration settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatusWorkspaceRepositoryConfiguration
{
    /// <summary>AccountName: Account name</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>CollaborationBranch: Collaboration branch</summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary>HostName: GitHub Enterprise host name. For example: `https://github.mydomain.com`</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>LastCommitId: The last commit ID</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>ProjectName: VSTS project name</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>RepositoryName: Repository name</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>RootFolder: Root folder to use in the repository</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>TenantId: The VSTS tenant ID</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of workspace repositoryID configuration. Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspaceStatus
{
    /// <summary>AdlaResourceId: The ADLA resource ID.</summary>
    [JsonPropertyName("adlaResourceId")]
    public string? AdlaResourceId { get; set; }

    /// <summary>AzureADOnlyAuthentication: Enable or Disable AzureADOnlyAuthentication on All Workspace subresource</summary>
    [JsonPropertyName("azureADOnlyAuthentication")]
    public bool? AzureADOnlyAuthentication { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20210601WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>ConnectivityEndpoints: Connectivity endpoints</summary>
    [JsonPropertyName("connectivityEndpoints")]
    public IDictionary<string, string>? ConnectivityEndpoints { get; set; }

    /// <summary>CspWorkspaceAdminProperties: Initial workspace AAD admin properties for a CSP subscription</summary>
    [JsonPropertyName("cspWorkspaceAdminProperties")]
    public V20210601WorkspaceStatusCspWorkspaceAdminProperties? CspWorkspaceAdminProperties { get; set; }

    /// <summary>DefaultDataLakeStorage: Workspace default data lake storage account details</summary>
    [JsonPropertyName("defaultDataLakeStorage")]
    public V20210601WorkspaceStatusDefaultDataLakeStorage? DefaultDataLakeStorage { get; set; }

    /// <summary>Encryption: The encryption details of the workspace</summary>
    [JsonPropertyName("encryption")]
    public V20210601WorkspaceStatusEncryption? Encryption { get; set; }

    /// <summary>ExtraProperties: Workspace level configs and feature flags</summary>
    [JsonPropertyName("extraProperties")]
    public IDictionary<string, JsonNode>? ExtraProperties { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity of the workspace</summary>
    [JsonPropertyName("identity")]
    public V20210601WorkspaceStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedResourceGroupName: Workspace managed resource group. The resource group name uniquely identifies the resource
    /// group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be
    /// alphanumeric characters (Char.IsLetterOrDigit()) and &apos;-&apos;, &apos;_&apos;, &apos;(&apos;, &apos;)&apos; and&apos;.&apos;. Note that the name cannot end with &apos;.&apos;
    /// </summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>
    /// ManagedVirtualNetwork: Setting this to &apos;default&apos; will ensure that all compute for this workspace is in a virtual network
    /// managed on behalf of the user.
    /// </summary>
    [JsonPropertyName("managedVirtualNetwork")]
    public string? ManagedVirtualNetwork { get; set; }

    /// <summary>ManagedVirtualNetworkSettings: Managed Virtual Network Settings</summary>
    [JsonPropertyName("managedVirtualNetworkSettings")]
    public V20210601WorkspaceStatusManagedVirtualNetworkSettings? ManagedVirtualNetworkSettings { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateEndpointConnections: Private endpoint connections to the workspace</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20210601WorkspaceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Resource provisioning state</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Enable or Disable public network access to workspace</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>PurviewConfiguration: Purview Configuration</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V20210601WorkspaceStatusPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary>Settings: Workspace settings</summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary>SqlAdministratorLogin: Login for workspace SQL active directory administrator</summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TrustedServiceBypassEnabled: Is trustedServiceBypassEnabled for the workspace</summary>
    [JsonPropertyName("trustedServiceBypassEnabled")]
    public bool? TrustedServiceBypassEnabled { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualNetworkProfile: Virtual Network profile</summary>
    [JsonPropertyName("virtualNetworkProfile")]
    public V20210601WorkspaceStatusVirtualNetworkProfile? VirtualNetworkProfile { get; set; }

    /// <summary>WorkspaceRepositoryConfiguration: Git integration settings</summary>
    [JsonPropertyName("workspaceRepositoryConfiguration")]
    public V20210601WorkspaceStatusWorkspaceRepositoryConfiguration? WorkspaceRepositoryConfiguration { get; set; }

    /// <summary>WorkspaceUID: The workspace unique identifier</summary>
    [JsonPropertyName("workspaceUID")]
    public string? WorkspaceUID { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/workspace.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210601Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V20210601WorkspaceSpec?>, IStatus<V20210601WorkspaceStatus?>
{
    public const string KubeApiVersion = "v20210601";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.com/v20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workspace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20210601WorkspaceSpec? Spec { get; set; }

    /// <summary>A workspace</summary>
    [JsonPropertyName("status")]
    public V20210601WorkspaceStatus? Status { get; set; }
}
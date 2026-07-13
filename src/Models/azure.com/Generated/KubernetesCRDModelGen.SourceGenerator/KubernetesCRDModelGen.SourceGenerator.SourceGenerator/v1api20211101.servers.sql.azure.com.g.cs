#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/Servers.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101ServerList : IKubernetesObject<V1ListMeta>, IItems<V1api20211101Server>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "ServerList";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "servers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211101Server objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211101Server> Items { get; set; }
}

/// <summary>AdministratorLoginPassword: The administrator login password (required for server creation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecAdministratorLoginPassword
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

/// <summary>AdministratorType: Type of the sever administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServerSpecAdministratorsAdministratorTypeEnum>))]
public enum V1api20211101ServerSpecAdministratorsAdministratorTypeEnum
{
    [EnumMember(Value = "ActiveDirectory"), JsonStringEnumMemberName("ActiveDirectory")]
    ActiveDirectory
}

/// <summary>PrincipalType: Principal Type of the sever administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServerSpecAdministratorsPrincipalTypeEnum>))]
public enum V1api20211101ServerSpecAdministratorsPrincipalTypeEnum
{
    [EnumMember(Value = "Application"), JsonStringEnumMemberName("Application")]
    Application,
    [EnumMember(Value = "Group"), JsonStringEnumMemberName("Group")]
    Group,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>Administrators: The Azure Active Directory administrator of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecAdministrators
{
    /// <summary>AdministratorType: Type of the sever administrator.</summary>
    [JsonPropertyName("administratorType")]
    public V1api20211101ServerSpecAdministratorsAdministratorTypeEnum? AdministratorType { get; set; }

    /// <summary>AzureADOnlyAuthentication: Azure Active Directory only Authentication enabled.</summary>
    [JsonPropertyName("azureADOnlyAuthentication")]
    public bool? AzureADOnlyAuthentication { get; set; }

    /// <summary>Login: Login name of the server administrator.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>PrincipalType: Principal Type of the sever administrator.</summary>
    [JsonPropertyName("principalType")]
    public V1api20211101ServerSpecAdministratorsPrincipalTypeEnum? PrincipalType { get; set; }

    /// <summary>Sid: SID (object ID) of the server administrator.</summary>
    [JsonPropertyName("sid")]
    public string? Sid { get; set; }

    /// <summary>TenantId: Tenant ID of the administrator.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Type: The identity type. Set this to &apos;SystemAssigned&apos; in order to automatically create and assign an Azure Active
/// Directory principal for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServerSpecIdentityTypeEnum>))]
public enum V1api20211101ServerSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20211101ServerSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211101ServerSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The Azure Active Directory identity of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecIdentity
{
    /// <summary>
    /// Type: The identity type. Set this to &apos;SystemAssigned&apos; in order to automatically create and assign an Azure Active
    /// Directory principal for the resource.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20211101ServerSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: The resource ids of the user assigned identities to use</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211101ServerSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecOperatorSpecConfigMapExpressions
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
/// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
/// config map will be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20211101ServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecOperatorSpecSecretExpressions
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
public partial class V1api20211101ServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211101ServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20211101ServerSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211101ServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrimaryUserAssignedIdentityReference: The resource id of a user assigned identity to be used by default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpecPrimaryUserAssignedIdentityReference
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

/// <summary>
/// PublicNetworkAccess: Whether or not public endpoint access is allowed for this server.  Value is optional but if passed
/// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServerSpecPublicNetworkAccessEnum>))]
public enum V1api20211101ServerSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// RestrictOutboundNetworkAccess: Whether or not to restrict outbound network access for this server.  Value is optional
/// but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServerSpecRestrictOutboundNetworkAccessEnum>))]
public enum V1api20211101ServerSpecRestrictOutboundNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerSpec
{
    /// <summary>AdministratorLogin: Administrator username for the server. Once created it cannot be changed.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AdministratorLoginPassword: The administrator login password (required for server creation).</summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V1api20211101ServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

    /// <summary>Administrators: The Azure Active Directory administrator of the server.</summary>
    [JsonPropertyName("administrators")]
    public V1api20211101ServerSpecAdministrators? Administrators { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>FederatedClientId: The Client id used for cross tenant CMK scenario</summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>Identity: The Azure Active Directory identity of the server.</summary>
    [JsonPropertyName("identity")]
    public V1api20211101ServerSpecIdentity? Identity { get; set; }

    /// <summary>KeyId: A CMK URI of the key to use for encryption.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MinimalTlsVersion: Minimal TLS version. Allowed values: &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211101ServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211101ServerSpecOwner Owner { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: The resource id of a user assigned identity to be used by default.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V1api20211101ServerSpecPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public endpoint access is allowed for this server.  Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20211101ServerSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RestrictOutboundNetworkAccess: Whether or not to restrict outbound network access for this server.  Value is optional
    /// but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public V1api20211101ServerSpecRestrictOutboundNetworkAccessEnum? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: The version of the server.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Administrators: The Azure Active Directory administrator of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusAdministrators
{
    /// <summary>AdministratorType: Type of the sever administrator.</summary>
    [JsonPropertyName("administratorType")]
    public string? AdministratorType { get; set; }

    /// <summary>AzureADOnlyAuthentication: Azure Active Directory only Authentication enabled.</summary>
    [JsonPropertyName("azureADOnlyAuthentication")]
    public bool? AzureADOnlyAuthentication { get; set; }

    /// <summary>Login: Login name of the server administrator.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>PrincipalType: Principal Type of the sever administrator.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>Sid: SID (object ID) of the server administrator.</summary>
    [JsonPropertyName("sid")]
    public string? Sid { get; set; }

    /// <summary>TenantId: Tenant ID of the administrator.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusConditions
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

/// <summary>Azure Active Directory identity configuration for a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The Azure Active Directory client id.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The Azure Active Directory principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The Azure Active Directory identity of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusIdentity
{
    /// <summary>PrincipalId: The Azure Active Directory principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The Azure Active Directory tenant id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The identity type. Set this to &apos;SystemAssigned&apos; in order to automatically create and assign an Azure Active
    /// Directory principal for the resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The resource ids of the user assigned identities to use</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20211101ServerStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>PrivateEndpoint: Private endpoint which the connection belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusPrivateEndpointConnectionsPropertiesPrivateEndpoint
{
    /// <summary>Id: Resource id of the private endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PrivateLinkServiceConnectionState: Connection state of the private endpoint connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusPrivateEndpointConnectionsPropertiesPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: The actions required for private link service connection.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: The private link service connection description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: The private link service connection status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Properties: Private endpoint connection properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusPrivateEndpointConnectionsProperties
{
    /// <summary>GroupIds: Group IDs.</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>PrivateEndpoint: Private endpoint which the connection belongs to.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20211101ServerStatusPrivateEndpointConnectionsPropertiesPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>PrivateLinkServiceConnectionState: Connection state of the private endpoint connection.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20211101ServerStatusPrivateEndpointConnectionsPropertiesPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>ProvisioningState: State of the private endpoint connection.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>A private endpoint connection under a server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatusPrivateEndpointConnections
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Properties: Private endpoint connection properties</summary>
    [JsonPropertyName("properties")]
    public V1api20211101ServerStatusPrivateEndpointConnectionsProperties? Properties { get; set; }
}

/// <summary>An Azure SQL Database server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServerStatus
{
    /// <summary>AdministratorLogin: Administrator username for the server. Once created it cannot be changed.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Administrators: The Azure Active Directory administrator of the server.</summary>
    [JsonPropertyName("administrators")]
    public V1api20211101ServerStatusAdministrators? Administrators { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101ServerStatusConditions>? Conditions { get; set; }

    /// <summary>FederatedClientId: The Client id used for cross tenant CMK scenario</summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>FullyQualifiedDomainName: The fully qualified domain name of the server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The Azure Active Directory identity of the server.</summary>
    [JsonPropertyName("identity")]
    public V1api20211101ServerStatusIdentity? Identity { get; set; }

    /// <summary>KeyId: A CMK URI of the key to use for encryption.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Kind: Kind of sql server. This is metadata used for the Azure portal experience.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MinimalTlsVersion: Minimal TLS version. Allowed values: &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrimaryUserAssignedIdentityId: The resource id of a user assigned identity to be used by default.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections on a server</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20211101ServerStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public endpoint access is allowed for this server.  Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RestrictOutboundNetworkAccess: Whether or not to restrict outbound network access for this server.  Value is optional
    /// but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public string? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>State: The state of the server.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: The version of the server.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>WorkspaceFeature: Whether or not existing server has a workspace created and if it allows connection from workspace</summary>
    [JsonPropertyName("workspaceFeature")]
    public string? WorkspaceFeature { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/Servers.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101Server : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101ServerSpec?>, IStatus<V1api20211101ServerStatus?>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "Server";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "servers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Server";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211101ServerSpec? Spec { get; set; }

    /// <summary>An Azure SQL Database server.</summary>
    [JsonPropertyName("status")]
    public V1api20211101ServerStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/authorization-RoleAssignmentsCalls.json
/// - ARM URI: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401RoleAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1api20220401RoleAssignment>
{
    public const string KubeApiVersion = "v1api20220401";
    public const string KubeKind = "RoleAssignmentList";
    public const string KubeGroup = "authorization.azure.com";
    public const string KubePluralName = "roleassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.com/v1api20220401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RoleAssignmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220401RoleAssignment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220401RoleAssignment> Items { get; set; }
}

/// <summary>DelegatedManagedIdentityResourceReference: Id of the delegated managed identity resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpecDelegatedManagedIdentityResourceReference
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpecOperatorSpecConfigMapExpressions
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
/// NamingConvention: The uuid generation technique to use for any role without an explicit AzureName. One of &apos;stable&apos; or
/// &apos;random&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401RoleAssignmentSpecOperatorSpecNamingConventionEnum>))]
public enum V1api20220401RoleAssignmentSpecOperatorSpecNamingConventionEnum
{
    [EnumMember(Value = "random"), JsonStringEnumMemberName("random")]
    Random,
    [EnumMember(Value = "stable"), JsonStringEnumMemberName("stable")]
    Stable
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220401RoleAssignmentSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>
    /// NamingConvention: The uuid generation technique to use for any role without an explicit AzureName. One of &apos;stable&apos; or
    /// &apos;random&apos;.
    /// </summary>
    [JsonPropertyName("namingConvention")]
    public V1api20220401RoleAssignmentSpecOperatorSpecNamingConventionEnum? NamingConvention { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220401RoleAssignmentSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpecOwner
{
    /// <summary>Ownership across namespaces is not supported.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrincipalIdFromConfig: The principal ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpecPrincipalIdFromConfig
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

/// <summary>PrincipalType: The principal type of the assigned principal ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401RoleAssignmentSpecPrincipalTypeEnum>))]
public enum V1api20220401RoleAssignmentSpecPrincipalTypeEnum
{
    [EnumMember(Value = "Device"), JsonStringEnumMemberName("Device")]
    Device,
    [EnumMember(Value = "ForeignGroup"), JsonStringEnumMemberName("ForeignGroup")]
    ForeignGroup,
    [EnumMember(Value = "Group"), JsonStringEnumMemberName("Group")]
    Group,
    [EnumMember(Value = "ServicePrincipal"), JsonStringEnumMemberName("ServicePrincipal")]
    ServicePrincipal,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>RoleDefinitionReference: The role definition ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpecRoleDefinitionReference
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

    [JsonPropertyName("wellKnownName")]
    public string? WellKnownName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Condition: The conditions on the role assignment. This limits the resources it can be assigned to. e.g.:
    /// @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase
    /// &apos;foo_storage_container&apos;
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>ConditionVersion: Version of the condition. Currently the only accepted value is &apos;2.0&apos;</summary>
    [JsonPropertyName("conditionVersion")]
    public string? ConditionVersion { get; set; }

    /// <summary>DelegatedManagedIdentityResourceReference: Id of the delegated managed identity resource</summary>
    [JsonPropertyName("delegatedManagedIdentityResourceReference")]
    public V1api20220401RoleAssignmentSpecDelegatedManagedIdentityResourceReference? DelegatedManagedIdentityResourceReference { get; set; }

    /// <summary>Description: Description of role assignment</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220401RoleAssignmentSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220401RoleAssignmentSpecOwner Owner { get; set; }

    /// <summary>PrincipalId: The principal ID.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>PrincipalIdFromConfig: The principal ID.</summary>
    [JsonPropertyName("principalIdFromConfig")]
    public V1api20220401RoleAssignmentSpecPrincipalIdFromConfig? PrincipalIdFromConfig { get; set; }

    /// <summary>PrincipalType: The principal type of the assigned principal ID.</summary>
    [JsonPropertyName("principalType")]
    public V1api20220401RoleAssignmentSpecPrincipalTypeEnum? PrincipalType { get; set; }

    /// <summary>RoleDefinitionReference: The role definition ID.</summary>
    [JsonPropertyName("roleDefinitionReference")]
    public required V1api20220401RoleAssignmentSpecRoleDefinitionReference RoleDefinitionReference { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentStatusConditions
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

/// <summary>Role Assignments</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401RoleAssignmentStatus
{
    /// <summary>
    /// Condition: The conditions on the role assignment. This limits the resources it can be assigned to. e.g.:
    /// @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase
    /// &apos;foo_storage_container&apos;
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>ConditionVersion: Version of the condition. Currently the only accepted value is &apos;2.0&apos;</summary>
    [JsonPropertyName("conditionVersion")]
    public string? ConditionVersion { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220401RoleAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>CreatedBy: Id of the user who created the assignment</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedOn: Time it was created</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>DelegatedManagedIdentityResourceId: Id of the delegated managed identity resource</summary>
    [JsonPropertyName("delegatedManagedIdentityResourceId")]
    public string? DelegatedManagedIdentityResourceId { get; set; }

    /// <summary>Description: Description of role assignment</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Id: The role assignment ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The role assignment name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrincipalId: The principal ID.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>PrincipalType: The principal type of the assigned principal ID.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>RoleDefinitionId: The role definition ID.</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>Scope: The role assignment scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Type: The role assignment type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpdatedBy: Id of the user who updated the assignment</summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    /// <summary>UpdatedOn: Time it was updated</summary>
    [JsonPropertyName("updatedOn")]
    public string? UpdatedOn { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/authorization-RoleAssignmentsCalls.json
/// - ARM URI: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401RoleAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220401RoleAssignmentSpec?>, IStatus<V1api20220401RoleAssignmentStatus?>
{
    public const string KubeApiVersion = "v1api20220401";
    public const string KubeKind = "RoleAssignment";
    public const string KubeGroup = "authorization.azure.com";
    public const string KubePluralName = "roleassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.com/v1api20220401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RoleAssignment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220401RoleAssignmentSpec? Spec { get; set; }

    /// <summary>Role Assignments</summary>
    [JsonPropertyName("status")]
    public V1api20220401RoleAssignmentStatus? Status { get; set; }
}
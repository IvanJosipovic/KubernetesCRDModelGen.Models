#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitiveservices.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/cognitiveservices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250601AccountList : IKubernetesObject<V1ListMeta>, IItems<V1api20250601Account>
{
    public const string KubeApiVersion = "v1api20250601";
    public const string KubeKind = "AccountList";
    public const string KubeGroup = "cognitiveservices.azure.com";
    public const string KubePluralName = "accounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitiveservices.azure.com/v1api20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250601Account objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250601Account> Items { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecIdentityTypeEnum>))]
public enum V1api20250601AccountSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20250601AccountSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20250601AccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public V1api20250601AccountSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user assigned identities associated with the resource. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20250601AccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250601AccountSpecOperatorSpecSecretExpressions
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

/// <summary>Key1: indicates where the Key1 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecOperatorSpecSecretsKey1
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Key2: indicates where the Key2 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecOperatorSpecSecretsKey2
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecOperatorSpecSecrets
{
    /// <summary>Key1: indicates where the Key1 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key1")]
    public V1api20250601AccountSpecOperatorSpecSecretsKey1? Key1 { get; set; }

    /// <summary>Key2: indicates where the Key2 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key2")]
    public V1api20250601AccountSpecOperatorSpecSecretsKey2? Key2 { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250601AccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250601AccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20250601AccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference: Full resource id of a AML account resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesAmlWorkspaceResourceReference
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

/// <summary>AmlWorkspace: The user owned AML account properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesAmlWorkspace
{
    /// <summary>IdentityClientId: Identity Client id of a AML account resource.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>ResourceReference: Full resource id of a AML account resource.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20250601AccountSpecPropertiesAmlWorkspaceResourceReference? ResourceReference { get; set; }
}

/// <summary>AadClientIdFromConfig: (Metrics Advisor Only) The Azure AD Client Id (Application Id).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesAadClientIdFromConfig
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

/// <summary>AadTenantIdFromConfig: (Metrics Advisor Only) The Azure AD Tenant Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesAadTenantIdFromConfig
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

/// <summary>EventHubConnectionString: (Personalization Only) The flag to enable statistics of Bing Search.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesEventHubConnectionString
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

/// <summary>QnaAzureSearchEndpointIdFromConfig: (QnAMaker Only) The Azure Search endpoint id of QnAMaker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesQnaAzureSearchEndpointIdFromConfig
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

/// <summary>QnaAzureSearchEndpointKey: (QnAMaker Only) The Azure Search endpoint key of QnAMaker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesQnaAzureSearchEndpointKey
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

/// <summary>QnaRuntimeEndpointFromConfig: (QnAMaker Only) The runtime endpoint of QnAMaker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesQnaRuntimeEndpointFromConfig
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

/// <summary>StorageAccountConnectionString: (Personalization Only) The storage account connection string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesStorageAccountConnectionString
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

/// <summary>SuperUserFromConfig: (Metrics Advisor Only) The super user of Metrics Advisor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesSuperUserFromConfig
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

/// <summary>WebsiteNameFromConfig: (Metrics Advisor Only) The website name of Metrics Advisor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiPropertiesWebsiteNameFromConfig
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

/// <summary>ApiProperties: The api properties for special APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesApiProperties
{
    /// <summary>AadClientId: (Metrics Advisor Only) The Azure AD Client Id (Application Id).</summary>
    [JsonPropertyName("aadClientId")]
    public string? AadClientId { get; set; }

    /// <summary>AadClientIdFromConfig: (Metrics Advisor Only) The Azure AD Client Id (Application Id).</summary>
    [JsonPropertyName("aadClientIdFromConfig")]
    public V1api20250601AccountSpecPropertiesApiPropertiesAadClientIdFromConfig? AadClientIdFromConfig { get; set; }

    /// <summary>AadTenantId: (Metrics Advisor Only) The Azure AD Tenant Id.</summary>
    [JsonPropertyName("aadTenantId")]
    public string? AadTenantId { get; set; }

    /// <summary>AadTenantIdFromConfig: (Metrics Advisor Only) The Azure AD Tenant Id.</summary>
    [JsonPropertyName("aadTenantIdFromConfig")]
    public V1api20250601AccountSpecPropertiesApiPropertiesAadTenantIdFromConfig? AadTenantIdFromConfig { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>EventHubConnectionString: (Personalization Only) The flag to enable statistics of Bing Search.</summary>
    [JsonPropertyName("eventHubConnectionString")]
    public V1api20250601AccountSpecPropertiesApiPropertiesEventHubConnectionString? EventHubConnectionString { get; set; }

    /// <summary>QnaAzureSearchEndpointId: (QnAMaker Only) The Azure Search endpoint id of QnAMaker.</summary>
    [JsonPropertyName("qnaAzureSearchEndpointId")]
    public string? QnaAzureSearchEndpointId { get; set; }

    /// <summary>QnaAzureSearchEndpointIdFromConfig: (QnAMaker Only) The Azure Search endpoint id of QnAMaker.</summary>
    [JsonPropertyName("qnaAzureSearchEndpointIdFromConfig")]
    public V1api20250601AccountSpecPropertiesApiPropertiesQnaAzureSearchEndpointIdFromConfig? QnaAzureSearchEndpointIdFromConfig { get; set; }

    /// <summary>QnaAzureSearchEndpointKey: (QnAMaker Only) The Azure Search endpoint key of QnAMaker.</summary>
    [JsonPropertyName("qnaAzureSearchEndpointKey")]
    public V1api20250601AccountSpecPropertiesApiPropertiesQnaAzureSearchEndpointKey? QnaAzureSearchEndpointKey { get; set; }

    /// <summary>QnaRuntimeEndpoint: (QnAMaker Only) The runtime endpoint of QnAMaker.</summary>
    [JsonPropertyName("qnaRuntimeEndpoint")]
    public string? QnaRuntimeEndpoint { get; set; }

    /// <summary>QnaRuntimeEndpointFromConfig: (QnAMaker Only) The runtime endpoint of QnAMaker.</summary>
    [JsonPropertyName("qnaRuntimeEndpointFromConfig")]
    public V1api20250601AccountSpecPropertiesApiPropertiesQnaRuntimeEndpointFromConfig? QnaRuntimeEndpointFromConfig { get; set; }

    /// <summary>StatisticsEnabled: (Bing Search Only) The flag to enable statistics of Bing Search.</summary>
    [JsonPropertyName("statisticsEnabled")]
    public bool? StatisticsEnabled { get; set; }

    /// <summary>StorageAccountConnectionString: (Personalization Only) The storage account connection string.</summary>
    [JsonPropertyName("storageAccountConnectionString")]
    public V1api20250601AccountSpecPropertiesApiPropertiesStorageAccountConnectionString? StorageAccountConnectionString { get; set; }

    /// <summary>SuperUser: (Metrics Advisor Only) The super user of Metrics Advisor.</summary>
    [JsonPropertyName("superUser")]
    public string? SuperUser { get; set; }

    /// <summary>SuperUserFromConfig: (Metrics Advisor Only) The super user of Metrics Advisor.</summary>
    [JsonPropertyName("superUserFromConfig")]
    public V1api20250601AccountSpecPropertiesApiPropertiesSuperUserFromConfig? SuperUserFromConfig { get; set; }

    /// <summary>WebsiteName: (Metrics Advisor Only) The website name of Metrics Advisor.</summary>
    [JsonPropertyName("websiteName")]
    public string? WebsiteName { get; set; }

    /// <summary>WebsiteNameFromConfig: (Metrics Advisor Only) The website name of Metrics Advisor.</summary>
    [JsonPropertyName("websiteNameFromConfig")]
    public V1api20250601AccountSpecPropertiesApiPropertiesWebsiteNameFromConfig? WebsiteNameFromConfig { get; set; }
}

/// <summary>KeySource: Enumerates the possible value of keySource for Encryption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecPropertiesEncryptionKeySourceEnum>))]
public enum V1api20250601AccountSpecPropertiesEncryptionKeySourceEnum
{
    [EnumMember(Value = "Microsoft.CognitiveServices"), JsonStringEnumMemberName("Microsoft.CognitiveServices")]
    MicrosoftCognitiveServices,
    [EnumMember(Value = "Microsoft.KeyVault"), JsonStringEnumMemberName("Microsoft.KeyVault")]
    MicrosoftKeyVault
}

/// <summary>KeyVaultProperties: Properties of KeyVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesEncryptionKeyVaultProperties
{
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>KeyName: Name of the Key from KeyVault</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>KeyVaultUri: Uri of KeyVault</summary>
    [JsonPropertyName("keyVaultUri")]
    public string? KeyVaultUri { get; set; }

    /// <summary>KeyVersion: Version of the Key from KeyVault</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }
}

/// <summary>Encryption: The encryption properties for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesEncryption
{
    /// <summary>KeySource: Enumerates the possible value of keySource for Encryption</summary>
    [JsonPropertyName("keySource")]
    public V1api20250601AccountSpecPropertiesEncryptionKeySourceEnum? KeySource { get; set; }

    /// <summary>KeyVaultProperties: Properties of KeyVault</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20250601AccountSpecPropertiesEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>The call rate limit Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesLocationsRegions
{
    /// <summary>Customsubdomain: Maps the region to the regional custom subdomain.</summary>
    [JsonPropertyName("customsubdomain")]
    public string? Customsubdomain { get; set; }

    /// <summary>Name: Name of the region.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: A value for priority or weighted routing methods.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>RoutingMethod: Multiregion routing methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecPropertiesLocationsRoutingMethodEnum>))]
public enum V1api20250601AccountSpecPropertiesLocationsRoutingMethodEnum
{
    [EnumMember(Value = "Performance"), JsonStringEnumMemberName("Performance")]
    Performance,
    [EnumMember(Value = "Priority"), JsonStringEnumMemberName("Priority")]
    Priority,
    [EnumMember(Value = "Weighted"), JsonStringEnumMemberName("Weighted")]
    Weighted
}

/// <summary>Locations: The multiregion settings of Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesLocations
{
    [JsonPropertyName("regions")]
    public IList<V1api20250601AccountSpecPropertiesLocationsRegions>? Regions { get; set; }

    /// <summary>RoutingMethod: Multiregion routing methods.</summary>
    [JsonPropertyName("routingMethod")]
    public V1api20250601AccountSpecPropertiesLocationsRoutingMethodEnum? RoutingMethod { get; set; }
}

/// <summary>MigrationToken: Resource migration token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesMigrationToken
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

/// <summary>Bypass: Setting for trusted services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecPropertiesNetworkAclsBypassEnum>))]
public enum V1api20250601AccountSpecPropertiesNetworkAclsBypassEnum
{
    [EnumMember(Value = "AzureServices"), JsonStringEnumMemberName("AzureServices")]
    AzureServices,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// DefaultAction: The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after
/// the bypass property has been evaluated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecPropertiesNetworkAclsDefaultActionEnum>))]
public enum V1api20250601AccountSpecPropertiesNetworkAclsDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>A rule governing the accessibility from a specific ip address or ip range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesNetworkAclsIpRules
{
    /// <summary>
    /// Value: An IPv4 address range in CIDR notation, such as &apos;124.56.78.91&apos; (simple IP address) or &apos;124.56.78.0/24&apos; (all
    /// addresses that start with 124.56.78).
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Reference: Full resource id of a vnet subnet, such as
/// &apos;/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesNetworkAclsVirtualNetworkRulesReference
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

/// <summary>A rule governing the accessibility from a specific virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesNetworkAclsVirtualNetworkRules
{
    /// <summary>IgnoreMissingVnetServiceEndpoint: Ignore missing vnet service endpoint or not.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

    /// <summary>
    /// Reference: Full resource id of a vnet subnet, such as
    /// &apos;/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1&apos;.
    /// </summary>
    [JsonPropertyName("reference")]
    public required V1api20250601AccountSpecPropertiesNetworkAclsVirtualNetworkRulesReference Reference { get; set; }

    /// <summary>State: Gets the state of virtual network rule.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>NetworkAcls: A collection of rules governing the accessibility from specific network locations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesNetworkAcls
{
    /// <summary>Bypass: Setting for trusted services.</summary>
    [JsonPropertyName("bypass")]
    public V1api20250601AccountSpecPropertiesNetworkAclsBypassEnum? Bypass { get; set; }

    /// <summary>
    /// DefaultAction: The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after
    /// the bypass property has been evaluated.
    /// </summary>
    [JsonPropertyName("defaultAction")]
    public V1api20250601AccountSpecPropertiesNetworkAclsDefaultActionEnum? DefaultAction { get; set; }

    /// <summary>IpRules: The list of IP address rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20250601AccountSpecPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>VirtualNetworkRules: The list of virtual network rules.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20250601AccountSpecPropertiesNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// Scenario: Specifies what features in AI Foundry network injection applies to. Currently only supports &apos;agent&apos; for agent
/// scenarios. &apos;none&apos; means no network injection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecPropertiesNetworkInjectionsScenarioEnum>))]
public enum V1api20250601AccountSpecPropertiesNetworkInjectionsScenarioEnum
{
    [EnumMember(Value = "agent"), JsonStringEnumMemberName("agent")]
    Agent,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>SubnetArmReference: Specify the subnet for which your Agent Client is injected into.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesNetworkInjectionsSubnetArmReference
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
/// Specifies in AI Foundry where virtual network injection occurs to secure scenarios like Agents entirely within the
/// user&apos;s private network, eliminating public internet exposure while maintaining control over network configurations and
/// resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesNetworkInjections
{
    /// <summary>
    /// Scenario: Specifies what features in AI Foundry network injection applies to. Currently only supports &apos;agent&apos; for agent
    /// scenarios. &apos;none&apos; means no network injection.
    /// </summary>
    [JsonPropertyName("scenario")]
    public V1api20250601AccountSpecPropertiesNetworkInjectionsScenarioEnum? Scenario { get; set; }

    /// <summary>SubnetArmReference: Specify the subnet for which your Agent Client is injected into.</summary>
    [JsonPropertyName("subnetArmReference")]
    public V1api20250601AccountSpecPropertiesNetworkInjectionsSubnetArmReference? SubnetArmReference { get; set; }

    /// <summary>UseMicrosoftManagedNetwork: Boolean to enable Microsoft Managed Network for subnet delegation</summary>
    [JsonPropertyName("useMicrosoftManagedNetwork")]
    public bool? UseMicrosoftManagedNetwork { get; set; }
}

/// <summary>PublicNetworkAccess: Whether or not public endpoint access is allowed for this account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecPropertiesPublicNetworkAccessEnum>))]
public enum V1api20250601AccountSpecPropertiesPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>AdxStorageResourceReference: The storage resource Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesRaiMonitorConfigAdxStorageResourceReference
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

/// <summary>RaiMonitorConfig: Cognitive Services Rai Monitor Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesRaiMonitorConfig
{
    /// <summary>AdxStorageResourceReference: The storage resource Id.</summary>
    [JsonPropertyName("adxStorageResourceReference")]
    public V1api20250601AccountSpecPropertiesRaiMonitorConfigAdxStorageResourceReference? AdxStorageResourceReference { get; set; }

    /// <summary>IdentityClientId: The identity client Id to access the storage.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }
}

/// <summary>ResourceReference: Full resource id of a Microsoft.Storage resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesUserOwnedStorageResourceReference
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

/// <summary>The user owned storage for Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecPropertiesUserOwnedStorage
{
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>ResourceReference: Full resource id of a Microsoft.Storage resource.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20250601AccountSpecPropertiesUserOwnedStorageResourceReference? ResourceReference { get; set; }
}

/// <summary>Properties: Properties of Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecProperties
{
    /// <summary>
    /// AllowProjectManagement: Specifies whether this resource support project management as child resources, used as
    /// containers for access management, data isolation and cost in AI Foundry.
    /// </summary>
    [JsonPropertyName("allowProjectManagement")]
    public bool? AllowProjectManagement { get; set; }

    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    /// <summary>AmlWorkspace: The user owned AML account properties.</summary>
    [JsonPropertyName("amlWorkspace")]
    public V1api20250601AccountSpecPropertiesAmlWorkspace? AmlWorkspace { get; set; }

    /// <summary>ApiProperties: The api properties for special APIs.</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20250601AccountSpecPropertiesApiProperties? ApiProperties { get; set; }

    /// <summary>AssociatedProjects: Specifies the projects, by project name, that are associated with this resource.</summary>
    [JsonPropertyName("associatedProjects")]
    public IList<string>? AssociatedProjects { get; set; }

    /// <summary>CustomSubDomainName: Optional subdomain name used for token-based authentication.</summary>
    [JsonPropertyName("customSubDomainName")]
    public string? CustomSubDomainName { get; set; }

    /// <summary>
    /// DefaultProject: Specifies the project, by project name, that is targeted when data plane endpoints are called without a
    /// project parameter.
    /// </summary>
    [JsonPropertyName("defaultProject")]
    public string? DefaultProject { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>DynamicThrottlingEnabled: The flag to enable dynamic throttling.</summary>
    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    /// <summary>Encryption: The encryption properties for this resource.</summary>
    [JsonPropertyName("encryption")]
    public V1api20250601AccountSpecPropertiesEncryption? Encryption { get; set; }

    /// <summary>Locations: The multiregion settings of Cognitive Services account.</summary>
    [JsonPropertyName("locations")]
    public V1api20250601AccountSpecPropertiesLocations? Locations { get; set; }

    /// <summary>MigrationToken: Resource migration token.</summary>
    [JsonPropertyName("migrationToken")]
    public V1api20250601AccountSpecPropertiesMigrationToken? MigrationToken { get; set; }

    /// <summary>NetworkAcls: A collection of rules governing the accessibility from specific network locations.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20250601AccountSpecPropertiesNetworkAcls? NetworkAcls { get; set; }

    [JsonPropertyName("networkInjections")]
    public IList<V1api20250601AccountSpecPropertiesNetworkInjections>? NetworkInjections { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public endpoint access is allowed for this account.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20250601AccountSpecPropertiesPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>RaiMonitorConfig: Cognitive Services Rai Monitor Config.</summary>
    [JsonPropertyName("raiMonitorConfig")]
    public V1api20250601AccountSpecPropertiesRaiMonitorConfig? RaiMonitorConfig { get; set; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }

    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public bool? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>UserOwnedStorage: The storage accounts for this resource.</summary>
    [JsonPropertyName("userOwnedStorage")]
    public IList<V1api20250601AccountSpecPropertiesUserOwnedStorage>? UserOwnedStorage { get; set; }
}

/// <summary>
/// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
/// not required on a PUT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601AccountSpecSkuTierEnum>))]
public enum V1api20250601AccountSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Enterprise"), JsonStringEnumMemberName("Enterprise")]
    Enterprise,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpecSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20250601AccountSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20250601AccountSpecIdentity? Identity { get; set; }

    /// <summary>Kind: The Kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250601AccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250601AccountSpecOwner Owner { get; set; }

    /// <summary>Properties: Properties of Cognitive Services account.</summary>
    [JsonPropertyName("properties")]
    public V1api20250601AccountSpecProperties? Properties { get; set; }

    /// <summary>Sku: The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20250601AccountSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusConditions
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

/// <summary>User-assigned managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Client App Id associated with this identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Azure Active Directory principal ID associated with this Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user assigned identities associated with the resource. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20250601AccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>AbusePenalty: The abuse penalty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesAbusePenalty
{
    /// <summary>Action: The action of AbusePenalty.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Expiration: The datetime of expiration of the AbusePenalty.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>RateLimitPercentage: The percentage of rate limit.</summary>
    [JsonPropertyName("rateLimitPercentage")]
    public double? RateLimitPercentage { get; set; }
}

/// <summary>AmlWorkspace: The user owned AML account properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesAmlWorkspace
{
    /// <summary>IdentityClientId: Identity Client id of a AML account resource.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>ResourceId: Full resource id of a AML account resource.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>ApiProperties: The api properties for special APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesApiProperties
{
    /// <summary>AadClientId: (Metrics Advisor Only) The Azure AD Client Id (Application Id).</summary>
    [JsonPropertyName("aadClientId")]
    public string? AadClientId { get; set; }

    /// <summary>AadTenantId: (Metrics Advisor Only) The Azure AD Tenant Id.</summary>
    [JsonPropertyName("aadTenantId")]
    public string? AadTenantId { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>QnaAzureSearchEndpointId: (QnAMaker Only) The Azure Search endpoint id of QnAMaker.</summary>
    [JsonPropertyName("qnaAzureSearchEndpointId")]
    public string? QnaAzureSearchEndpointId { get; set; }

    /// <summary>QnaRuntimeEndpoint: (QnAMaker Only) The runtime endpoint of QnAMaker.</summary>
    [JsonPropertyName("qnaRuntimeEndpoint")]
    public string? QnaRuntimeEndpoint { get; set; }

    /// <summary>StatisticsEnabled: (Bing Search Only) The flag to enable statistics of Bing Search.</summary>
    [JsonPropertyName("statisticsEnabled")]
    public bool? StatisticsEnabled { get; set; }

    /// <summary>SuperUser: (Metrics Advisor Only) The super user of Metrics Advisor.</summary>
    [JsonPropertyName("superUser")]
    public string? SuperUser { get; set; }

    /// <summary>WebsiteName: (Metrics Advisor Only) The website name of Metrics Advisor.</summary>
    [JsonPropertyName("websiteName")]
    public string? WebsiteName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesCallRateLimitRulesMatchPatterns
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesCallRateLimitRules
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("matchPatterns")]
    public IList<V1api20250601AccountStatusPropertiesCallRateLimitRulesMatchPatterns>? MatchPatterns { get; set; }

    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }
}

/// <summary>CallRateLimit: The call rate limit Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesCallRateLimit
{
    /// <summary>Count: The count value of Call Rate Limit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>RenewalPeriod: The renewal period in seconds of Call Rate Limit.</summary>
    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20250601AccountStatusPropertiesCallRateLimitRules>? Rules { get; set; }
}

/// <summary>SkuCapability indicates the capability of a certain feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesCapabilities
{
    /// <summary>Name: The name of the SkuCapability.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The value of the SkuCapability.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The commitment plan association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesCommitmentPlanAssociations
{
    /// <summary>CommitmentPlanId: The Azure resource id of the commitment plan.</summary>
    [JsonPropertyName("commitmentPlanId")]
    public string? CommitmentPlanId { get; set; }

    /// <summary>CommitmentPlanLocation: The location of of the commitment plan.</summary>
    [JsonPropertyName("commitmentPlanLocation")]
    public string? CommitmentPlanLocation { get; set; }
}

/// <summary>KeyVaultProperties: Properties of KeyVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesEncryptionKeyVaultProperties
{
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>KeyName: Name of the Key from KeyVault</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>KeyVaultUri: Uri of KeyVault</summary>
    [JsonPropertyName("keyVaultUri")]
    public string? KeyVaultUri { get; set; }

    /// <summary>KeyVersion: Version of the Key from KeyVault</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }
}

/// <summary>Encryption: The encryption properties for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesEncryption
{
    /// <summary>KeySource: Enumerates the possible value of keySource for Encryption</summary>
    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>KeyVaultProperties: Properties of KeyVault</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20250601AccountStatusPropertiesEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>The call rate limit Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesLocationsRegions
{
    /// <summary>Customsubdomain: Maps the region to the regional custom subdomain.</summary>
    [JsonPropertyName("customsubdomain")]
    public string? Customsubdomain { get; set; }

    /// <summary>Name: Name of the region.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: A value for priority or weighted routing methods.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Locations: The multiregion settings of Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesLocations
{
    [JsonPropertyName("regions")]
    public IList<V1api20250601AccountStatusPropertiesLocationsRegions>? Regions { get; set; }

    /// <summary>RoutingMethod: Multiregion routing methods.</summary>
    [JsonPropertyName("routingMethod")]
    public string? RoutingMethod { get; set; }
}

/// <summary>A rule governing the accessibility from a specific ip address or ip range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesNetworkAclsIpRules
{
    /// <summary>
    /// Value: An IPv4 address range in CIDR notation, such as &apos;124.56.78.91&apos; (simple IP address) or &apos;124.56.78.0/24&apos; (all
    /// addresses that start with 124.56.78).
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A rule governing the accessibility from a specific virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesNetworkAclsVirtualNetworkRules
{
    /// <summary>
    /// Id: Full resource id of a vnet subnet, such as
    /// &apos;/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1&apos;.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IgnoreMissingVnetServiceEndpoint: Ignore missing vnet service endpoint or not.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

    /// <summary>State: Gets the state of virtual network rule.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>NetworkAcls: A collection of rules governing the accessibility from specific network locations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesNetworkAcls
{
    /// <summary>Bypass: Setting for trusted services.</summary>
    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    /// <summary>
    /// DefaultAction: The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after
    /// the bypass property has been evaluated.
    /// </summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>IpRules: The list of IP address rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20250601AccountStatusPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>VirtualNetworkRules: The list of virtual network rules.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20250601AccountStatusPropertiesNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// Specifies in AI Foundry where virtual network injection occurs to secure scenarios like Agents entirely within the
/// user&apos;s private network, eliminating public internet exposure while maintaining control over network configurations and
/// resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesNetworkInjections
{
    /// <summary>
    /// Scenario: Specifies what features in AI Foundry network injection applies to. Currently only supports &apos;agent&apos; for agent
    /// scenarios. &apos;none&apos; means no network injection.
    /// </summary>
    [JsonPropertyName("scenario")]
    public string? Scenario { get; set; }

    /// <summary>SubnetArmId: Specify the subnet for which your Agent Client is injected into.</summary>
    [JsonPropertyName("subnetArmId")]
    public string? SubnetArmId { get; set; }

    /// <summary>UseMicrosoftManagedNetwork: Boolean to enable Microsoft Managed Network for subnet delegation</summary>
    [JsonPropertyName("useMicrosoftManagedNetwork")]
    public bool? UseMicrosoftManagedNetwork { get; set; }
}

/// <summary>The Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesQuotaLimitRulesMatchPatterns
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesQuotaLimitRules
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("matchPatterns")]
    public IList<V1api20250601AccountStatusPropertiesQuotaLimitRulesMatchPatterns>? MatchPatterns { get; set; }

    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesQuotaLimit
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20250601AccountStatusPropertiesQuotaLimitRules>? Rules { get; set; }
}

/// <summary>RaiMonitorConfig: Cognitive Services Rai Monitor Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesRaiMonitorConfig
{
    /// <summary>AdxStorageResourceId: The storage resource Id.</summary>
    [JsonPropertyName("adxStorageResourceId")]
    public string? AdxStorageResourceId { get; set; }

    /// <summary>IdentityClientId: The identity client Id to access the storage.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }
}

/// <summary>SkuChangeInfo: Sku change info of account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesSkuChangeInfo
{
    /// <summary>CountOfDowngrades: Gets the count of downgrades.</summary>
    [JsonPropertyName("countOfDowngrades")]
    public double? CountOfDowngrades { get; set; }

    /// <summary>CountOfUpgradesAfterDowngrades: Gets the count of upgrades after downgrades.</summary>
    [JsonPropertyName("countOfUpgradesAfterDowngrades")]
    public double? CountOfUpgradesAfterDowngrades { get; set; }

    /// <summary>LastChangeDate: Gets the last change date.</summary>
    [JsonPropertyName("lastChangeDate")]
    public string? LastChangeDate { get; set; }
}

/// <summary>The user owned storage for Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusPropertiesUserOwnedStorage
{
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>ResourceId: Full resource id of a Microsoft.Storage resource.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Properties: Properties of Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusProperties
{
    /// <summary>AbusePenalty: The abuse penalty.</summary>
    [JsonPropertyName("abusePenalty")]
    public V1api20250601AccountStatusPropertiesAbusePenalty? AbusePenalty { get; set; }

    /// <summary>
    /// AllowProjectManagement: Specifies whether this resource support project management as child resources, used as
    /// containers for access management, data isolation and cost in AI Foundry.
    /// </summary>
    [JsonPropertyName("allowProjectManagement")]
    public bool? AllowProjectManagement { get; set; }

    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    /// <summary>AmlWorkspace: The user owned AML account properties.</summary>
    [JsonPropertyName("amlWorkspace")]
    public V1api20250601AccountStatusPropertiesAmlWorkspace? AmlWorkspace { get; set; }

    /// <summary>ApiProperties: The api properties for special APIs.</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20250601AccountStatusPropertiesApiProperties? ApiProperties { get; set; }

    /// <summary>AssociatedProjects: Specifies the projects, by project name, that are associated with this resource.</summary>
    [JsonPropertyName("associatedProjects")]
    public IList<string>? AssociatedProjects { get; set; }

    /// <summary>CallRateLimit: The call rate limit Cognitive Services account.</summary>
    [JsonPropertyName("callRateLimit")]
    public V1api20250601AccountStatusPropertiesCallRateLimit? CallRateLimit { get; set; }

    /// <summary>
    /// Capabilities: Gets the capabilities of the cognitive services account. Each item indicates the capability of a specific
    /// feature. The values are read-only and for reference only.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20250601AccountStatusPropertiesCapabilities>? Capabilities { get; set; }

    /// <summary>CommitmentPlanAssociations: The commitment plan associations of Cognitive Services account.</summary>
    [JsonPropertyName("commitmentPlanAssociations")]
    public IList<V1api20250601AccountStatusPropertiesCommitmentPlanAssociations>? CommitmentPlanAssociations { get; set; }

    /// <summary>CustomSubDomainName: Optional subdomain name used for token-based authentication.</summary>
    [JsonPropertyName("customSubDomainName")]
    public string? CustomSubDomainName { get; set; }

    /// <summary>DateCreated: Gets the date of cognitive services account creation.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>
    /// DefaultProject: Specifies the project, by project name, that is targeted when data plane endpoints are called without a
    /// project parameter.
    /// </summary>
    [JsonPropertyName("defaultProject")]
    public string? DefaultProject { get; set; }

    /// <summary>DeletionDate: The deletion date, only available for deleted account.</summary>
    [JsonPropertyName("deletionDate")]
    public string? DeletionDate { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>DynamicThrottlingEnabled: The flag to enable dynamic throttling.</summary>
    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    /// <summary>Encryption: The encryption properties for this resource.</summary>
    [JsonPropertyName("encryption")]
    public V1api20250601AccountStatusPropertiesEncryption? Encryption { get; set; }

    /// <summary>Endpoint: Endpoint of the created account.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }

    /// <summary>InternalId: The internal identifier (deprecated, do not use this property).</summary>
    [JsonPropertyName("internalId")]
    public string? InternalId { get; set; }

    /// <summary>IsMigrated: If the resource is migrated from an existing key.</summary>
    [JsonPropertyName("isMigrated")]
    public bool? IsMigrated { get; set; }

    /// <summary>Locations: The multiregion settings of Cognitive Services account.</summary>
    [JsonPropertyName("locations")]
    public V1api20250601AccountStatusPropertiesLocations? Locations { get; set; }

    /// <summary>NetworkAcls: A collection of rules governing the accessibility from specific network locations.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20250601AccountStatusPropertiesNetworkAcls? NetworkAcls { get; set; }

    [JsonPropertyName("networkInjections")]
    public IList<V1api20250601AccountStatusPropertiesNetworkInjections>? NetworkInjections { get; set; }

    /// <summary>PrivateEndpointConnections: The private endpoint connection associated with the Cognitive Services account.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20250601AccountStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Gets the status of the cognitive services account at the time the operation was called.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public endpoint access is allowed for this account.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("quotaLimit")]
    public V1api20250601AccountStatusPropertiesQuotaLimit? QuotaLimit { get; set; }

    /// <summary>RaiMonitorConfig: Cognitive Services Rai Monitor Config.</summary>
    [JsonPropertyName("raiMonitorConfig")]
    public V1api20250601AccountStatusPropertiesRaiMonitorConfig? RaiMonitorConfig { get; set; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }

    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public bool? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>ScheduledPurgeDate: The scheduled purge date, only available for deleted account.</summary>
    [JsonPropertyName("scheduledPurgeDate")]
    public string? ScheduledPurgeDate { get; set; }

    /// <summary>SkuChangeInfo: Sku change info of account.</summary>
    [JsonPropertyName("skuChangeInfo")]
    public V1api20250601AccountStatusPropertiesSkuChangeInfo? SkuChangeInfo { get; set; }

    /// <summary>UserOwnedStorage: The storage accounts for this resource.</summary>
    [JsonPropertyName("userOwnedStorage")]
    public IList<V1api20250601AccountStatusPropertiesUserOwnedStorage>? UserOwnedStorage { get; set; }
}

/// <summary>Sku: The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Cognitive Services account is an Azure resource representing the provisioned account, it&apos;s type, location and SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601AccountStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20250601AccountStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: Resource Etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20250601AccountStatusIdentity? Identity { get; set; }

    /// <summary>Kind: The Kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Properties of Cognitive Services account.</summary>
    [JsonPropertyName("properties")]
    public V1api20250601AccountStatusProperties? Properties { get; set; }

    /// <summary>Sku: The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20250601AccountStatusSku? Sku { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20250601AccountStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/cognitiveservices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250601Account : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250601AccountSpec?>, IStatus<V1api20250601AccountStatus?>
{
    public const string KubeApiVersion = "v1api20250601";
    public const string KubeKind = "Account";
    public const string KubeGroup = "cognitiveservices.azure.com";
    public const string KubePluralName = "accounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitiveservices.azure.com/v1api20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Account";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20250601AccountSpec? Spec { get; set; }

    /// <summary>Cognitive Services account is an Azure resource representing the provisioned account, it&apos;s type, location and SKU.</summary>
    [JsonPropertyName("status")]
    public V1api20250601AccountStatus? Status { get; set; }
}
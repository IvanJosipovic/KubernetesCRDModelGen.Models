#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimnamedvalues.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230501previewNamedValueList : IKubernetesObject<V1ListMeta>, IItems<V20230501previewNamedValue>
{
    public const string KubeApiVersion = "v20230501preview";
    public const string KubeKind = "NamedValueList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "namedvalues";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20230501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamedValueList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20230501previewNamedValue objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20230501previewNamedValue> Items { get; set; }
}

/// <summary>
/// IdentityClientIdFromConfig: Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used
/// to access key vault secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueSpecKeyVaultIdentityClientIdFromConfig
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

/// <summary>KeyVault: KeyVault location details of the namedValue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueSpecKeyVault
{
    /// <summary>
    /// IdentityClientId: Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used to access
    /// key vault secret.
    /// </summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>
    /// IdentityClientIdFromConfig: Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used
    /// to access key vault secret.
    /// </summary>
    [JsonPropertyName("identityClientIdFromConfig")]
    public V20230501previewNamedValueSpecKeyVaultIdentityClientIdFromConfig? IdentityClientIdFromConfig { get; set; }

    /// <summary>
    /// SecretIdentifier: Key vault secret identifier for fetching secret. Providing a versioned secret will prevent
    /// auto-refresh. This requires API Management service to be configured with aka.ms/apimmsi
    /// </summary>
    [JsonPropertyName("secretIdentifier")]
    public string? SecretIdentifier { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueSpecOperatorSpecSecretExpressions
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
public partial class V20230501previewNamedValueSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20230501previewNamedValueSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20230501previewNamedValueSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DisplayName: Unique name of NamedValue. It may contain only letters, digits, period, dash, and underscore characters.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>KeyVault: KeyVault location details of the namedValue.</summary>
    [JsonPropertyName("keyVault")]
    public V20230501previewNamedValueSpecKeyVault? KeyVault { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20230501previewNamedValueSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20230501previewNamedValueSpecOwner Owner { get; set; }

    /// <summary>Secret: Determines whether the value is a secret and should be encrypted or not. Default value is false.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>Tags: Optional tags that when provided can be used to filter the NamedValue list.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// Value: Value of the NamedValue. Can contain policy expressions. It may not be empty or consist only of whitespace. This
    /// property will not be filled on &apos;GET&apos; operations! Use &apos;/listSecrets&apos; POST request to get the value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueStatusConditions
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

/// <summary>LastStatus: Last time sync and refresh status of secret from key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueStatusKeyVaultLastStatus
{
    /// <summary>Code: Last status code for sync and refresh of secret from key vault.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: Details of the error else empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// TimeStampUtc: Last time secret was accessed. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
    /// specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("timeStampUtc")]
    public string? TimeStampUtc { get; set; }
}

/// <summary>KeyVault: KeyVault location details of the namedValue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueStatusKeyVault
{
    /// <summary>
    /// IdentityClientId: Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used to access
    /// key vault secret.
    /// </summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>LastStatus: Last time sync and refresh status of secret from key vault.</summary>
    [JsonPropertyName("lastStatus")]
    public V20230501previewNamedValueStatusKeyVaultLastStatus? LastStatus { get; set; }

    /// <summary>
    /// SecretIdentifier: Key vault secret identifier for fetching secret. Providing a versioned secret will prevent
    /// auto-refresh. This requires API Management service to be configured with aka.ms/apimmsi
    /// </summary>
    [JsonPropertyName("secretIdentifier")]
    public string? SecretIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewNamedValueStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20230501previewNamedValueStatusConditions>? Conditions { get; set; }

    /// <summary>DisplayName: Unique name of NamedValue. It may contain only letters, digits, period, dash, and underscore characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>KeyVault: KeyVault location details of the namedValue.</summary>
    [JsonPropertyName("keyVault")]
    public V20230501previewNamedValueStatusKeyVault? KeyVault { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Secret: Determines whether the value is a secret and should be encrypted or not. Default value is false.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>Tags: Optional tags that when provided can be used to filter the NamedValue list.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Value: Value of the NamedValue. Can contain policy expressions. It may not be empty or consist only of whitespace. This
    /// property will not be filled on &apos;GET&apos; operations! Use &apos;/listSecrets&apos; POST request to get the value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimnamedvalues.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230501previewNamedValue : IKubernetesObject<V1ObjectMeta>, ISpec<V20230501previewNamedValueSpec?>, IStatus<V20230501previewNamedValueStatus?>
{
    public const string KubeApiVersion = "v20230501preview";
    public const string KubeKind = "NamedValue";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "namedvalues";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20230501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamedValue";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20230501previewNamedValueSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20230501previewNamedValueStatus? Status { get; set; }
}
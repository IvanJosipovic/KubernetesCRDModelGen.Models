#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devices.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /iothub/resource-manager/Microsoft.Devices/IoTHub/stable/2021-07-02/iothub.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210702IotHubList : IKubernetesObject<V1ListMeta>, IItems<V1api20210702IotHub>
{
    public const string KubeApiVersion = "v1api20210702";
    public const string KubeKind = "IotHubList";
    public const string KubeGroup = "devices.azure.com";
    public const string KubePluralName = "iothubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.com/v1api20210702";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IotHubList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210702IotHub objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210702IotHub> Items { get; set; }
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecIdentityTypeEnum>))]
public enum V1api20210702IotHubSpecIdentityTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210702IotHubSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The managed identities for the IotHub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20210702IotHubSpecIdentityTypeEnum? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210702IotHubSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210702IotHubSpecOperatorSpecSecretExpressions
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
/// DevicePrimaryKey: indicates where the DevicePrimaryKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsDevicePrimaryKey
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

/// <summary>
/// DeviceSecondaryKey: indicates where the DeviceSecondaryKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsDeviceSecondaryKey
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

/// <summary>
/// IotHubOwnerPrimaryKey: indicates where the IotHubOwnerPrimaryKey secret should be placed. If omitted, the secret will
/// not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsIotHubOwnerPrimaryKey
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

/// <summary>
/// IotHubOwnerSecondaryKey: indicates where the IotHubOwnerSecondaryKey secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsIotHubOwnerSecondaryKey
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

/// <summary>
/// RegistryReadPrimaryKey: indicates where the RegistryReadPrimaryKey secret should be placed. If omitted, the secret will
/// not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadPrimaryKey
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

/// <summary>
/// RegistryReadSecondaryKey: indicates where the RegistryReadSecondaryKey secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadSecondaryKey
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

/// <summary>
/// RegistryReadWritePrimaryKey: indicates where the RegistryReadWritePrimaryKey secret should be placed. If omitted, the
/// secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadWritePrimaryKey
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

/// <summary>
/// RegistryReadWriteSecondaryKey: indicates where the RegistryReadWriteSecondaryKey secret should be placed. If omitted,
/// the secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadWriteSecondaryKey
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

/// <summary>
/// ServicePrimaryKey: indicates where the ServicePrimaryKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsServicePrimaryKey
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

/// <summary>
/// ServiceSecondaryKey: indicates where the ServiceSecondaryKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecretsServiceSecondaryKey
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpecSecrets
{
    /// <summary>
    /// DevicePrimaryKey: indicates where the DevicePrimaryKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("devicePrimaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsDevicePrimaryKey? DevicePrimaryKey { get; set; }

    /// <summary>
    /// DeviceSecondaryKey: indicates where the DeviceSecondaryKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("deviceSecondaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsDeviceSecondaryKey? DeviceSecondaryKey { get; set; }

    /// <summary>
    /// IotHubOwnerPrimaryKey: indicates where the IotHubOwnerPrimaryKey secret should be placed. If omitted, the secret will
    /// not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("iotHubOwnerPrimaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsIotHubOwnerPrimaryKey? IotHubOwnerPrimaryKey { get; set; }

    /// <summary>
    /// IotHubOwnerSecondaryKey: indicates where the IotHubOwnerSecondaryKey secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("iotHubOwnerSecondaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsIotHubOwnerSecondaryKey? IotHubOwnerSecondaryKey { get; set; }

    /// <summary>
    /// RegistryReadPrimaryKey: indicates where the RegistryReadPrimaryKey secret should be placed. If omitted, the secret will
    /// not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("registryReadPrimaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadPrimaryKey? RegistryReadPrimaryKey { get; set; }

    /// <summary>
    /// RegistryReadSecondaryKey: indicates where the RegistryReadSecondaryKey secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("registryReadSecondaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadSecondaryKey? RegistryReadSecondaryKey { get; set; }

    /// <summary>
    /// RegistryReadWritePrimaryKey: indicates where the RegistryReadWritePrimaryKey secret should be placed. If omitted, the
    /// secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("registryReadWritePrimaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadWritePrimaryKey? RegistryReadWritePrimaryKey { get; set; }

    /// <summary>
    /// RegistryReadWriteSecondaryKey: indicates where the RegistryReadWriteSecondaryKey secret should be placed. If omitted,
    /// the secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("registryReadWriteSecondaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsRegistryReadWriteSecondaryKey? RegistryReadWriteSecondaryKey { get; set; }

    /// <summary>
    /// ServicePrimaryKey: indicates where the ServicePrimaryKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("servicePrimaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsServicePrimaryKey? ServicePrimaryKey { get; set; }

    /// <summary>
    /// ServiceSecondaryKey: indicates where the ServiceSecondaryKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("serviceSecondaryKey")]
    public V1api20210702IotHubSpecOperatorSpecSecretsServiceSecondaryKey? ServiceSecondaryKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210702IotHubSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210702IotHubSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20210702IotHubSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Rights: The permissions assigned to the shared access policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesAuthorizationPoliciesRightsEnum>))]
public enum V1api20210702IotHubSpecPropertiesAuthorizationPoliciesRightsEnum
{
    [EnumMember(Value = "DeviceConnect"), JsonStringEnumMemberName("DeviceConnect")]
    DeviceConnect,
    [EnumMember(Value = "RegistryRead"), JsonStringEnumMemberName("RegistryRead")]
    RegistryRead,
    [EnumMember(Value = "RegistryRead, DeviceConnect"), JsonStringEnumMemberName("RegistryRead, DeviceConnect")]
    RegistryReadDeviceConnect,
    [EnumMember(Value = "RegistryRead, RegistryWrite"), JsonStringEnumMemberName("RegistryRead, RegistryWrite")]
    RegistryReadRegistryWrite,
    [EnumMember(Value = "RegistryRead, RegistryWrite, DeviceConnect"), JsonStringEnumMemberName("RegistryRead, RegistryWrite, DeviceConnect")]
    RegistryReadRegistryWriteDeviceConnect,
    [EnumMember(Value = "RegistryRead, RegistryWrite, ServiceConnect"), JsonStringEnumMemberName("RegistryRead, RegistryWrite, ServiceConnect")]
    RegistryReadRegistryWriteServiceConnect,
    [EnumMember(Value = "RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect"), JsonStringEnumMemberName("RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect")]
    RegistryReadRegistryWriteServiceConnectDeviceConnect,
    [EnumMember(Value = "RegistryRead, ServiceConnect"), JsonStringEnumMemberName("RegistryRead, ServiceConnect")]
    RegistryReadServiceConnect,
    [EnumMember(Value = "RegistryRead, ServiceConnect, DeviceConnect"), JsonStringEnumMemberName("RegistryRead, ServiceConnect, DeviceConnect")]
    RegistryReadServiceConnectDeviceConnect,
    [EnumMember(Value = "RegistryWrite"), JsonStringEnumMemberName("RegistryWrite")]
    RegistryWrite,
    [EnumMember(Value = "RegistryWrite, DeviceConnect"), JsonStringEnumMemberName("RegistryWrite, DeviceConnect")]
    RegistryWriteDeviceConnect,
    [EnumMember(Value = "RegistryWrite, ServiceConnect"), JsonStringEnumMemberName("RegistryWrite, ServiceConnect")]
    RegistryWriteServiceConnect,
    [EnumMember(Value = "RegistryWrite, ServiceConnect, DeviceConnect"), JsonStringEnumMemberName("RegistryWrite, ServiceConnect, DeviceConnect")]
    RegistryWriteServiceConnectDeviceConnect,
    [EnumMember(Value = "ServiceConnect"), JsonStringEnumMemberName("ServiceConnect")]
    ServiceConnect,
    [EnumMember(Value = "ServiceConnect, DeviceConnect"), JsonStringEnumMemberName("ServiceConnect, DeviceConnect")]
    ServiceConnectDeviceConnect
}

/// <summary>The properties of an IoT hub shared access policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesAuthorizationPolicies
{
    /// <summary>KeyName: The name of the shared access policy.</summary>
    [JsonPropertyName("keyName")]
    public required string KeyName { get; set; }

    /// <summary>Rights: The permissions assigned to the shared access policy.</summary>
    [JsonPropertyName("rights")]
    public required V1api20210702IotHubSpecPropertiesAuthorizationPoliciesRightsEnum Rights { get; set; }
}

/// <summary>Feedback: The properties of the feedback queue for cloud-to-device messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesCloudToDeviceFeedback
{
    /// <summary>
    /// LockDurationAsIso8601: The lock duration for the feedback queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The number of times the IoT hub attempts to deliver a message on the feedback queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// TtlAsIso8601: The period of time for which a message is available to consume before it is expired by the IoT hub. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>CloudToDevice: The IoT hub cloud-to-device messaging properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesCloudToDevice
{
    /// <summary>
    /// DefaultTtlAsIso8601: The default time to live for cloud-to-device messages in the device queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("defaultTtlAsIso8601")]
    public string? DefaultTtlAsIso8601 { get; set; }

    /// <summary>Feedback: The properties of the feedback queue for cloud-to-device messages.</summary>
    [JsonPropertyName("feedback")]
    public V1api20210702IotHubSpecPropertiesCloudToDeviceFeedback? Feedback { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The max delivery count for cloud-to-device messages in the device queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }
}

/// <summary>The properties of the provisioned Event Hub-compatible endpoint used by the IoT hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesEventHubEndpoints
{
    /// <summary>
    /// PartitionCount: The number of partitions for receiving device-to-cloud messages in the Event Hub-compatible endpoint.
    /// See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages.
    /// </summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    /// <summary>
    /// RetentionTimeInDays: The retention time for device-to-cloud messages in days. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages
    /// </summary>
    [JsonPropertyName("retentionTimeInDays")]
    public int? RetentionTimeInDays { get; set; }
}

/// <summary>Features: The capabilities and features enabled for the IoT hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesFeaturesEnum>))]
public enum V1api20210702IotHubSpecPropertiesFeaturesEnum
{
    [EnumMember(Value = "DeviceManagement"), JsonStringEnumMemberName("DeviceManagement")]
    DeviceManagement,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Action: The desired action for requests captured by this rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesIpFilterRulesActionEnum>))]
public enum V1api20210702IotHubSpecPropertiesIpFilterRulesActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

/// <summary>The IP filter rules for the IoT hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesIpFilterRules
{
    /// <summary>Action: The desired action for requests captured by this rule.</summary>
    [JsonPropertyName("action")]
    public required V1api20210702IotHubSpecPropertiesIpFilterRulesActionEnum Action { get; set; }

    /// <summary>FilterName: The name of the IP filter rule.</summary>
    [JsonPropertyName("filterName")]
    public required string FilterName { get; set; }

    /// <summary>IpMask: A string that contains the IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public required string IpMask { get; set; }
}

/// <summary>The properties of the messaging endpoints used by this IoT hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesMessagingEndpoints
{
    /// <summary>LockDurationAsIso8601: The lock duration. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload.</summary>
    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The number of times the IoT hub attempts to deliver a message. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// TtlAsIso8601: The period of time for which a message is available to consume before it is expired by the IoT hub. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload.
    /// </summary>
    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>DefaultAction: Default Action for Network Rule Set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesNetworkRuleSetsDefaultActionEnum>))]
public enum V1api20210702IotHubSpecPropertiesNetworkRuleSetsDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: IP Filter Action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesNetworkRuleSetsIpRulesActionEnum>))]
public enum V1api20210702IotHubSpecPropertiesNetworkRuleSetsIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>IP Rule to be applied as part of Network Rule Set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesNetworkRuleSetsIpRules
{
    /// <summary>Action: IP Filter Action</summary>
    [JsonPropertyName("action")]
    public V1api20210702IotHubSpecPropertiesNetworkRuleSetsIpRulesActionEnum? Action { get; set; }

    /// <summary>FilterName: Name of the IP filter rule.</summary>
    [JsonPropertyName("filterName")]
    public required string FilterName { get; set; }

    /// <summary>IpMask: A string that contains the IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public required string IpMask { get; set; }
}

/// <summary>NetworkRuleSets: Network Rule Set Properties of IotHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesNetworkRuleSets
{
    /// <summary>ApplyToBuiltInEventHubEndpoint: If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub</summary>
    [JsonPropertyName("applyToBuiltInEventHubEndpoint")]
    public required bool ApplyToBuiltInEventHubEndpoint { get; set; }

    /// <summary>DefaultAction: Default Action for Network Rule Set</summary>
    [JsonPropertyName("defaultAction")]
    public V1api20210702IotHubSpecPropertiesNetworkRuleSetsDefaultActionEnum? DefaultAction { get; set; }

    /// <summary>IpRules: List of IP Rules</summary>
    [JsonPropertyName("ipRules")]
    public required IList<V1api20210702IotHubSpecPropertiesNetworkRuleSetsIpRules> IpRules { get; set; }
}

/// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesPublicNetworkAccessEnum>))]
public enum V1api20210702IotHubSpecPropertiesPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>AuthenticationType: Method used to authenticate against the event hub endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsAuthenticationTypeEnum>))]
public enum V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsAuthenticationTypeEnum
{
    [EnumMember(Value = "identityBased"), JsonStringEnumMemberName("identityBased")]
    IdentityBased,
    [EnumMember(Value = "keyBased"), JsonStringEnumMemberName("keyBased")]
    KeyBased
}

/// <summary>ConnectionString: The connection string of the event hub endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsConnectionString
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

/// <summary>Identity: Managed identity properties of routing event hub endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the event hub endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsReference
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

/// <summary>The properties related to an event hub endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubs
{
    /// <summary>AuthenticationType: Method used to authenticate against the event hub endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsAuthenticationTypeEnum? AuthenticationType { get; set; }

    /// <summary>ConnectionString: The connection string of the event hub endpoint.</summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsConnectionString? ConnectionString { get; set; }

    /// <summary>EndpointUri: The url of the event hub endpoint. It must include the protocol sb://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>EntityPath: Event hub name on the event hub namespace</summary>
    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>Identity: Managed identity properties of routing event hub endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsIdentity? Identity { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Reference: Id of the event hub endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubsReference? Reference { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the event hub endpoint.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the event hub endpoint.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>AuthenticationType: Method used to authenticate against the service bus queue endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesAuthenticationTypeEnum>))]
public enum V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesAuthenticationTypeEnum
{
    [EnumMember(Value = "identityBased"), JsonStringEnumMemberName("identityBased")]
    IdentityBased,
    [EnumMember(Value = "keyBased"), JsonStringEnumMemberName("keyBased")]
    KeyBased
}

/// <summary>ConnectionString: The connection string of the service bus queue endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesConnectionString
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

/// <summary>Identity: Managed identity properties of routing service bus queue endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the service bus queue endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesReference
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

/// <summary>The properties related to service bus queue endpoint types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueues
{
    /// <summary>AuthenticationType: Method used to authenticate against the service bus queue endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesAuthenticationTypeEnum? AuthenticationType { get; set; }

    /// <summary>ConnectionString: The connection string of the service bus queue endpoint.</summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesConnectionString? ConnectionString { get; set; }

    /// <summary>EndpointUri: The url of the service bus queue endpoint. It must include the protocol sb://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>EntityPath: Queue name on the service bus namespace</summary>
    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>Identity: Managed identity properties of routing service bus queue endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesIdentity? Identity { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types. The name need not be the same as the actual queue name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Reference: Id of the service bus queue endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueuesReference? Reference { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the service bus queue endpoint.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the service bus queue endpoint.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>AuthenticationType: Method used to authenticate against the service bus topic endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsAuthenticationTypeEnum>))]
public enum V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsAuthenticationTypeEnum
{
    [EnumMember(Value = "identityBased"), JsonStringEnumMemberName("identityBased")]
    IdentityBased,
    [EnumMember(Value = "keyBased"), JsonStringEnumMemberName("keyBased")]
    KeyBased
}

/// <summary>ConnectionString: The connection string of the service bus topic endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsConnectionString
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

/// <summary>Identity: Managed identity properties of routing service bus topic endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the service bus topic endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsReference
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

/// <summary>The properties related to service bus topic endpoint types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopics
{
    /// <summary>AuthenticationType: Method used to authenticate against the service bus topic endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsAuthenticationTypeEnum? AuthenticationType { get; set; }

    /// <summary>ConnectionString: The connection string of the service bus topic endpoint.</summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsConnectionString? ConnectionString { get; set; }

    /// <summary>EndpointUri: The url of the service bus topic endpoint. It must include the protocol sb://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>EntityPath: Queue name on the service bus topic</summary>
    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>Identity: Managed identity properties of routing service bus topic endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsIdentity? Identity { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types.  The name need not be the same as the actual topic name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Reference: Id of the service bus topic endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopicsReference? Reference { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the service bus topic endpoint.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the service bus topic endpoint.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>AuthenticationType: Method used to authenticate against the storage endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersAuthenticationTypeEnum>))]
public enum V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersAuthenticationTypeEnum
{
    [EnumMember(Value = "identityBased"), JsonStringEnumMemberName("identityBased")]
    IdentityBased,
    [EnumMember(Value = "keyBased"), JsonStringEnumMemberName("keyBased")]
    KeyBased
}

/// <summary>ConnectionString: The connection string of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersConnectionString
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

/// <summary>
/// Encoding: Encoding that is used to serialize messages to blobs. Supported values are &apos;avro&apos;, &apos;avrodeflate&apos;, and &apos;JSON&apos;.
/// Default value is &apos;avro&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersEncodingEnum>))]
public enum V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersEncodingEnum
{
    [EnumMember(Value = "Avro"), JsonStringEnumMemberName("Avro")]
    Avro,
    [EnumMember(Value = "AvroDeflate"), JsonStringEnumMemberName("AvroDeflate")]
    AvroDeflate,
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>Identity: Managed identity properties of routing storage endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the storage container endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersReference
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

/// <summary>The properties related to a storage container endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainers
{
    /// <summary>AuthenticationType: Method used to authenticate against the storage endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersAuthenticationTypeEnum? AuthenticationType { get; set; }

    /// <summary>
    /// BatchFrequencyInSeconds: Time interval at which blobs are written to storage. Value should be between 60 and 720
    /// seconds. Default value is 300 seconds.
    /// </summary>
    [JsonPropertyName("batchFrequencyInSeconds")]
    public int? BatchFrequencyInSeconds { get; set; }

    /// <summary>ConnectionString: The connection string of the storage account.</summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersConnectionString? ConnectionString { get; set; }

    /// <summary>ContainerName: The name of storage container in the storage account.</summary>
    [JsonPropertyName("containerName")]
    public required string ContainerName { get; set; }

    /// <summary>
    /// Encoding: Encoding that is used to serialize messages to blobs. Supported values are &apos;avro&apos;, &apos;avrodeflate&apos;, and &apos;JSON&apos;.
    /// Default value is &apos;avro&apos;.
    /// </summary>
    [JsonPropertyName("encoding")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersEncodingEnum? Encoding { get; set; }

    /// <summary>EndpointUri: The url of the storage endpoint. It must include the protocol https://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>
    /// FileNameFormat: File name format for the blob. Default format is {iothub}/{partition}/{YYYY}/{MM}/{DD}/{HH}/{mm}. All
    /// parameters are mandatory but can be reordered.
    /// </summary>
    [JsonPropertyName("fileNameFormat")]
    public string? FileNameFormat { get; set; }

    /// <summary>Identity: Managed identity properties of routing storage endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersIdentity? Identity { get; set; }

    /// <summary>
    /// MaxChunkSizeInBytes: Maximum number of bytes for each blob written to storage. Value should be between 10485760(10MB)
    /// and 524288000(500MB). Default value is 314572800(300MB).
    /// </summary>
    [JsonPropertyName("maxChunkSizeInBytes")]
    public int? MaxChunkSizeInBytes { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Reference: Id of the storage container endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainersReference? Reference { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the storage account.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the storage account.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// Endpoints: The properties related to the custom endpoints to which your IoT hub routes messages based on the routing
/// rules. A  maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint
/// is allowed  across all endpoint types for free hubs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEndpoints
{
    /// <summary>
    /// EventHubs: The list of Event Hubs endpoints that IoT hub routes messages to, based on the routing rules. This list does
    /// not include the built-in Event Hubs endpoint.
    /// </summary>
    [JsonPropertyName("eventHubs")]
    public IList<V1api20210702IotHubSpecPropertiesRoutingEndpointsEventHubs>? EventHubs { get; set; }

    /// <summary>
    /// ServiceBusQueues: The list of Service Bus queue endpoints that IoT hub routes the messages to, based on the routing
    /// rules.
    /// </summary>
    [JsonPropertyName("serviceBusQueues")]
    public IList<V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusQueues>? ServiceBusQueues { get; set; }

    /// <summary>
    /// ServiceBusTopics: The list of Service Bus topic endpoints that the IoT hub routes the messages to, based on the routing
    /// rules.
    /// </summary>
    [JsonPropertyName("serviceBusTopics")]
    public IList<V1api20210702IotHubSpecPropertiesRoutingEndpointsServiceBusTopics>? ServiceBusTopics { get; set; }

    /// <summary>StorageContainers: The list of storage container endpoints that IoT hub routes messages to, based on the routing rules.</summary>
    [JsonPropertyName("storageContainers")]
    public IList<V1api20210702IotHubSpecPropertiesRoutingEndpointsStorageContainers>? StorageContainers { get; set; }
}

/// <summary>The properties of an enrichment that your IoT hub applies to messages delivered to endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingEnrichments
{
    /// <summary>EndpointNames: The list of endpoints for which the enrichment is applied to the message.</summary>
    [JsonPropertyName("endpointNames")]
    public required IList<string> EndpointNames { get; set; }

    /// <summary>Key: The key or name for the enrichment property.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value: The value for the enrichment property.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Source: The source to which the routing rule is to be applied to. For example, DeviceMessages</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesRoutingFallbackRouteSourceEnum>))]
public enum V1api20210702IotHubSpecPropertiesRoutingFallbackRouteSourceEnum
{
    [EnumMember(Value = "DeviceMessages"), JsonStringEnumMemberName("DeviceMessages")]
    DeviceMessages
}

/// <summary>
/// FallbackRoute: The properties of the route that is used as a fall-back route when none of the conditions specified in
/// the &apos;routes&apos; section are met. This is an optional parameter. When this property is not present in the template, the
/// fallback route is disabled by default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingFallbackRoute
{
    /// <summary>
    /// Condition: The condition which is evaluated in order to apply the fallback route. If the condition is not provided it
    /// will evaluate to true by default. For grammar, See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>
    /// EndpointNames: The list of endpoints to which the messages that satisfy the condition are routed to. Currently only 1
    /// endpoint is allowed.
    /// </summary>
    [JsonPropertyName("endpointNames")]
    public required IList<string> EndpointNames { get; set; }

    /// <summary>IsEnabled: Used to specify whether the fallback route is enabled.</summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    /// <summary>
    /// Name: The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a
    /// maximum length of 64 characters, and must be unique.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Source: The source to which the routing rule is to be applied to. For example, DeviceMessages</summary>
    [JsonPropertyName("source")]
    public required V1api20210702IotHubSpecPropertiesRoutingFallbackRouteSourceEnum Source { get; set; }
}

/// <summary>Source: The source that the routing rule is to be applied to, such as DeviceMessages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesRoutingRoutesSourceEnum>))]
public enum V1api20210702IotHubSpecPropertiesRoutingRoutesSourceEnum
{
    [EnumMember(Value = "DeviceConnectionStateEvents"), JsonStringEnumMemberName("DeviceConnectionStateEvents")]
    DeviceConnectionStateEvents,
    [EnumMember(Value = "DeviceJobLifecycleEvents"), JsonStringEnumMemberName("DeviceJobLifecycleEvents")]
    DeviceJobLifecycleEvents,
    [EnumMember(Value = "DeviceLifecycleEvents"), JsonStringEnumMemberName("DeviceLifecycleEvents")]
    DeviceLifecycleEvents,
    [EnumMember(Value = "DeviceMessages"), JsonStringEnumMemberName("DeviceMessages")]
    DeviceMessages,
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid,
    [EnumMember(Value = "TwinChangeEvents"), JsonStringEnumMemberName("TwinChangeEvents")]
    TwinChangeEvents
}

/// <summary>The properties of a routing rule that your IoT hub uses to route messages to endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRoutingRoutes
{
    /// <summary>
    /// Condition: The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to true
    /// by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>
    /// EndpointNames: The list of endpoints to which messages that satisfy the condition are routed. Currently only one
    /// endpoint is allowed.
    /// </summary>
    [JsonPropertyName("endpointNames")]
    public required IList<string> EndpointNames { get; set; }

    /// <summary>IsEnabled: Used to specify whether a route is enabled.</summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    /// <summary>
    /// Name: The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a
    /// maximum length of 64 characters, and must be unique.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Source: The source that the routing rule is to be applied to, such as DeviceMessages.</summary>
    [JsonPropertyName("source")]
    public required V1api20210702IotHubSpecPropertiesRoutingRoutesSourceEnum Source { get; set; }
}

/// <summary>
/// Routing: The routing related properties of the IoT hub. See:
/// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesRouting
{
    /// <summary>
    /// Endpoints: The properties related to the custom endpoints to which your IoT hub routes messages based on the routing
    /// rules. A  maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint
    /// is allowed  across all endpoint types for free hubs.
    /// </summary>
    [JsonPropertyName("endpoints")]
    public V1api20210702IotHubSpecPropertiesRoutingEndpoints? Endpoints { get; set; }

    /// <summary>
    /// Enrichments: The list of user-provided enrichments that the IoT hub applies to messages to be delivered to built-in and
    /// custom endpoints. See: https://aka.ms/telemetryoneventgrid
    /// </summary>
    [JsonPropertyName("enrichments")]
    public IList<V1api20210702IotHubSpecPropertiesRoutingEnrichments>? Enrichments { get; set; }

    /// <summary>
    /// FallbackRoute: The properties of the route that is used as a fall-back route when none of the conditions specified in
    /// the &apos;routes&apos; section are met. This is an optional parameter. When this property is not present in the template, the
    /// fallback route is disabled by default.
    /// </summary>
    [JsonPropertyName("fallbackRoute")]
    public V1api20210702IotHubSpecPropertiesRoutingFallbackRoute? FallbackRoute { get; set; }

    /// <summary>
    /// Routes: The list of user-provided routing rules that the IoT hub uses to route messages to built-in and custom
    /// endpoints. A maximum of 100 routing rules are allowed for paid hubs and a maximum of 5 routing rules are allowed for
    /// free hubs.
    /// </summary>
    [JsonPropertyName("routes")]
    public IList<V1api20210702IotHubSpecPropertiesRoutingRoutes>? Routes { get; set; }
}

/// <summary>AuthenticationType: Specifies authentication type being used for connecting to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecPropertiesStorageEndpointsAuthenticationTypeEnum>))]
public enum V1api20210702IotHubSpecPropertiesStorageEndpointsAuthenticationTypeEnum
{
    [EnumMember(Value = "identityBased"), JsonStringEnumMemberName("identityBased")]
    IdentityBased,
    [EnumMember(Value = "keyBased"), JsonStringEnumMemberName("keyBased")]
    KeyBased
}

/// <summary>ConnectionString: The connection string for the Azure Storage account to which files are uploaded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesStorageEndpointsConnectionString
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

/// <summary>Identity: Managed identity properties of storage endpoint for file upload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesStorageEndpointsIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>The properties of the Azure Storage endpoint for file upload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecPropertiesStorageEndpoints
{
    /// <summary>AuthenticationType: Specifies authentication type being used for connecting to the storage account.</summary>
    [JsonPropertyName("authenticationType")]
    public V1api20210702IotHubSpecPropertiesStorageEndpointsAuthenticationTypeEnum? AuthenticationType { get; set; }

    /// <summary>ConnectionString: The connection string for the Azure Storage account to which files are uploaded.</summary>
    [JsonPropertyName("connectionString")]
    public required V1api20210702IotHubSpecPropertiesStorageEndpointsConnectionString ConnectionString { get; set; }

    /// <summary>
    /// ContainerName: The name of the root container where you upload files. The container need not exist but should be
    /// creatable using the connectionString specified.
    /// </summary>
    [JsonPropertyName("containerName")]
    public required string ContainerName { get; set; }

    /// <summary>Identity: Managed identity properties of storage endpoint for file upload.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubSpecPropertiesStorageEndpointsIdentity? Identity { get; set; }

    /// <summary>
    /// SasTtlAsIso8601: The period of time for which the SAS URI generated by IoT Hub for file upload is valid. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload#file-upload-notification-configuration-options.
    /// </summary>
    [JsonPropertyName("sasTtlAsIso8601")]
    public string? SasTtlAsIso8601 { get; set; }
}

/// <summary>Properties: IotHub properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecProperties
{
    /// <summary>AllowedFqdnList: List of allowed FQDNs(Fully Qualified Domain Name) for egress from Iot Hub.</summary>
    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    /// <summary>AuthorizationPolicies: The shared access policies you can use to secure a connection to the IoT hub.</summary>
    [JsonPropertyName("authorizationPolicies")]
    public IList<V1api20210702IotHubSpecPropertiesAuthorizationPolicies>? AuthorizationPolicies { get; set; }

    /// <summary>CloudToDevice: The IoT hub cloud-to-device messaging properties.</summary>
    [JsonPropertyName("cloudToDevice")]
    public V1api20210702IotHubSpecPropertiesCloudToDevice? CloudToDevice { get; set; }

    /// <summary>Comments: IoT hub comments.</summary>
    [JsonPropertyName("comments")]
    public string? Comments { get; set; }

    /// <summary>
    /// DisableDeviceSAS: If true, all device(including Edge devices but excluding modules) scoped SAS keys cannot be used for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableDeviceSAS")]
    public bool? DisableDeviceSAS { get; set; }

    /// <summary>DisableLocalAuth: If true, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication.</summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>DisableModuleSAS: If true, all module scoped SAS keys cannot be used for authentication.</summary>
    [JsonPropertyName("disableModuleSAS")]
    public bool? DisableModuleSAS { get; set; }

    /// <summary>EnableDataResidency: This property when set to true, will enable data residency, thus, disabling disaster recovery.</summary>
    [JsonPropertyName("enableDataResidency")]
    public bool? EnableDataResidency { get; set; }

    /// <summary>EnableFileUploadNotifications: If True, file upload notifications are enabled.</summary>
    [JsonPropertyName("enableFileUploadNotifications")]
    public bool? EnableFileUploadNotifications { get; set; }

    /// <summary>
    /// EventHubEndpoints: The Event Hub-compatible endpoint properties. The only possible keys to this dictionary is events.
    /// This key has to be present in the dictionary while making create or update calls for the IoT hub.
    /// </summary>
    [JsonPropertyName("eventHubEndpoints")]
    public IDictionary<string, V1api20210702IotHubSpecPropertiesEventHubEndpoints>? EventHubEndpoints { get; set; }

    /// <summary>Features: The capabilities and features enabled for the IoT hub.</summary>
    [JsonPropertyName("features")]
    public V1api20210702IotHubSpecPropertiesFeaturesEnum? Features { get; set; }

    /// <summary>IpFilterRules: The IP filter rules.</summary>
    [JsonPropertyName("ipFilterRules")]
    public IList<V1api20210702IotHubSpecPropertiesIpFilterRules>? IpFilterRules { get; set; }

    /// <summary>MessagingEndpoints: The messaging endpoint properties for the file upload notification queue.</summary>
    [JsonPropertyName("messagingEndpoints")]
    public IDictionary<string, V1api20210702IotHubSpecPropertiesMessagingEndpoints>? MessagingEndpoints { get; set; }

    /// <summary>
    /// MinTlsVersion: Specifies the minimum TLS version to support for this hub. Can be set to &quot;1.2&quot; to have clients that use a
    /// TLS version below 1.2 to be rejected.
    /// </summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>NetworkRuleSets: Network Rule Set Properties of IotHub</summary>
    [JsonPropertyName("networkRuleSets")]
    public V1api20210702IotHubSpecPropertiesNetworkRuleSets? NetworkRuleSets { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20210702IotHubSpecPropertiesPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RestrictOutboundNetworkAccess: If true, egress from IotHub will be restricted to only the allowed FQDNs that are
    /// configured via allowedFqdnList.
    /// </summary>
    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public bool? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>
    /// Routing: The routing related properties of the IoT hub. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
    /// </summary>
    [JsonPropertyName("routing")]
    public V1api20210702IotHubSpecPropertiesRouting? Routing { get; set; }

    /// <summary>
    /// StorageEndpoints: The list of Azure Storage endpoints where you can upload files. Currently you can configure only one
    /// Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error
    /// to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True,
    /// causes an error to be thrown.
    /// </summary>
    [JsonPropertyName("storageEndpoints")]
    public IDictionary<string, V1api20210702IotHubSpecPropertiesStorageEndpoints>? StorageEndpoints { get; set; }
}

/// <summary>Name: The name of the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210702IotHubSpecSkuNameEnum>))]
public enum V1api20210702IotHubSpecSkuNameEnum
{
    [EnumMember(Value = "B1"), JsonStringEnumMemberName("B1")]
    B1,
    [EnumMember(Value = "B2"), JsonStringEnumMemberName("B2")]
    B2,
    [EnumMember(Value = "B3"), JsonStringEnumMemberName("B3")]
    B3,
    [EnumMember(Value = "F1"), JsonStringEnumMemberName("F1")]
    F1,
    [EnumMember(Value = "S1"), JsonStringEnumMemberName("S1")]
    S1,
    [EnumMember(Value = "S2"), JsonStringEnumMemberName("S2")]
    S2,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3
}

/// <summary>Sku: IotHub SKU info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpecSku
{
    /// <summary>
    /// Capacity: The number of provisioned IoT Hub units. See:
    /// https://docs.microsoft.com/azure/azure-subscription-service-limits#iot-hub-limits.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: The name of the SKU.</summary>
    [JsonPropertyName("name")]
    public required V1api20210702IotHubSpecSkuNameEnum Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Identity: The managed identities for the IotHub.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubSpecIdentity? Identity { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210702IotHubSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210702IotHubSpecOwner Owner { get; set; }

    /// <summary>Properties: IotHub properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210702IotHubSpecProperties? Properties { get; set; }

    /// <summary>Sku: IotHub SKU info</summary>
    [JsonPropertyName("sku")]
    public required V1api20210702IotHubSpecSku Sku { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusIdentityUserAssignedIdentities
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The managed identities for the IotHub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusIdentity
{
    /// <summary>PrincipalId: Principal Id</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: Tenant Id</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210702IotHubStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>The properties of an IoT hub shared access policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesAuthorizationPolicies
{
    /// <summary>KeyName: The name of the shared access policy.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Rights: The permissions assigned to the shared access policy.</summary>
    [JsonPropertyName("rights")]
    public string? Rights { get; set; }
}

/// <summary>Feedback: The properties of the feedback queue for cloud-to-device messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesCloudToDeviceFeedback
{
    /// <summary>
    /// LockDurationAsIso8601: The lock duration for the feedback queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The number of times the IoT hub attempts to deliver a message on the feedback queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// TtlAsIso8601: The period of time for which a message is available to consume before it is expired by the IoT hub. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>CloudToDevice: The IoT hub cloud-to-device messaging properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesCloudToDevice
{
    /// <summary>
    /// DefaultTtlAsIso8601: The default time to live for cloud-to-device messages in the device queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("defaultTtlAsIso8601")]
    public string? DefaultTtlAsIso8601 { get; set; }

    /// <summary>Feedback: The properties of the feedback queue for cloud-to-device messages.</summary>
    [JsonPropertyName("feedback")]
    public V1api20210702IotHubStatusPropertiesCloudToDeviceFeedback? Feedback { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The max delivery count for cloud-to-device messages in the device queue. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }
}

/// <summary>The properties of the provisioned Event Hub-compatible endpoint used by the IoT hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesEventHubEndpoints
{
    /// <summary>Endpoint: The Event Hub-compatible endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// PartitionCount: The number of partitions for receiving device-to-cloud messages in the Event Hub-compatible endpoint.
    /// See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages.
    /// </summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    /// <summary>PartitionIds: The partition ids in the Event Hub-compatible endpoint.</summary>
    [JsonPropertyName("partitionIds")]
    public IList<string>? PartitionIds { get; set; }

    /// <summary>Path: The Event Hub-compatible name.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// RetentionTimeInDays: The retention time for device-to-cloud messages in days. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages
    /// </summary>
    [JsonPropertyName("retentionTimeInDays")]
    public int? RetentionTimeInDays { get; set; }
}

/// <summary>The IP filter rules for the IoT hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesIpFilterRules
{
    /// <summary>Action: The desired action for requests captured by this rule.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>FilterName: The name of the IP filter rule.</summary>
    [JsonPropertyName("filterName")]
    public string? FilterName { get; set; }

    /// <summary>IpMask: A string that contains the IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>Public representation of one of the locations where a resource is provisioned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesLocations
{
    /// <summary>Location: The name of the Azure region</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Role: The role of the region, can be either primary or secondary. The primary region is where the IoT hub is currently
    /// provisioned. The secondary region is the Azure disaster recovery (DR) paired region and also the region where the IoT
    /// hub can failover to.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>The properties of the messaging endpoints used by this IoT hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesMessagingEndpoints
{
    /// <summary>LockDurationAsIso8601: The lock duration. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload.</summary>
    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The number of times the IoT hub attempts to deliver a message. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// TtlAsIso8601: The period of time for which a message is available to consume before it is expired by the IoT hub. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload.
    /// </summary>
    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>IP Rule to be applied as part of Network Rule Set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesNetworkRuleSetsIpRules
{
    /// <summary>Action: IP Filter Action</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>FilterName: Name of the IP filter rule.</summary>
    [JsonPropertyName("filterName")]
    public string? FilterName { get; set; }

    /// <summary>IpMask: A string that contains the IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>NetworkRuleSets: Network Rule Set Properties of IotHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesNetworkRuleSets
{
    /// <summary>ApplyToBuiltInEventHubEndpoint: If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub</summary>
    [JsonPropertyName("applyToBuiltInEventHubEndpoint")]
    public bool? ApplyToBuiltInEventHubEndpoint { get; set; }

    /// <summary>DefaultAction: Default Action for Network Rule Set</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>IpRules: List of IP Rules</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210702IotHubStatusPropertiesNetworkRuleSetsIpRules>? IpRules { get; set; }
}

/// <summary>The private endpoint connection of an IotHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesPrivateEndpointConnections
{
    /// <summary>Id: The resource identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Identity: Managed identity properties of routing event hub endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsEventHubsIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>The properties related to an event hub endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsEventHubs
{
    /// <summary>AuthenticationType: Method used to authenticate against the event hub endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>EndpointUri: The url of the event hub endpoint. It must include the protocol sb://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>EntityPath: Event hub name on the event hub namespace</summary>
    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>Id: Id of the event hub endpoint</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed identity properties of routing event hub endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubStatusPropertiesRoutingEndpointsEventHubsIdentity? Identity { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the event hub endpoint.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the event hub endpoint.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Identity: Managed identity properties of routing service bus queue endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusQueuesIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>The properties related to service bus queue endpoint types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusQueues
{
    /// <summary>AuthenticationType: Method used to authenticate against the service bus queue endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>EndpointUri: The url of the service bus queue endpoint. It must include the protocol sb://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>EntityPath: Queue name on the service bus namespace</summary>
    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>Id: Id of the service bus queue endpoint</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed identity properties of routing service bus queue endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusQueuesIdentity? Identity { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types. The name need not be the same as the actual queue name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the service bus queue endpoint.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the service bus queue endpoint.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Identity: Managed identity properties of routing service bus topic endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusTopicsIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>The properties related to service bus topic endpoint types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusTopics
{
    /// <summary>AuthenticationType: Method used to authenticate against the service bus topic endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>EndpointUri: The url of the service bus topic endpoint. It must include the protocol sb://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>EntityPath: Queue name on the service bus topic</summary>
    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>Id: Id of the service bus topic endpoint</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed identity properties of routing service bus topic endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusTopicsIdentity? Identity { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types.  The name need not be the same as the actual topic name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the service bus topic endpoint.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the service bus topic endpoint.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Identity: Managed identity properties of routing storage endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsStorageContainersIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>The properties related to a storage container endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpointsStorageContainers
{
    /// <summary>AuthenticationType: Method used to authenticate against the storage endpoint</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>
    /// BatchFrequencyInSeconds: Time interval at which blobs are written to storage. Value should be between 60 and 720
    /// seconds. Default value is 300 seconds.
    /// </summary>
    [JsonPropertyName("batchFrequencyInSeconds")]
    public int? BatchFrequencyInSeconds { get; set; }

    /// <summary>ContainerName: The name of storage container in the storage account.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// Encoding: Encoding that is used to serialize messages to blobs. Supported values are &apos;avro&apos;, &apos;avrodeflate&apos;, and &apos;JSON&apos;.
    /// Default value is &apos;avro&apos;.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>EndpointUri: The url of the storage endpoint. It must include the protocol https://</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>
    /// FileNameFormat: File name format for the blob. Default format is {iothub}/{partition}/{YYYY}/{MM}/{DD}/{HH}/{mm}. All
    /// parameters are mandatory but can be reordered.
    /// </summary>
    [JsonPropertyName("fileNameFormat")]
    public string? FileNameFormat { get; set; }

    /// <summary>Id: Id of the storage container endpoint</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed identity properties of routing storage endpoint.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubStatusPropertiesRoutingEndpointsStorageContainersIdentity? Identity { get; set; }

    /// <summary>
    /// MaxChunkSizeInBytes: Maximum number of bytes for each blob written to storage. Value should be between 10485760(10MB)
    /// and 524288000(500MB). Default value is 314572800(300MB).
    /// </summary>
    [JsonPropertyName("maxChunkSizeInBytes")]
    public int? MaxChunkSizeInBytes { get; set; }

    /// <summary>
    /// Name: The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores,
    /// hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications,
    /// $default. Endpoint names must be unique across endpoint types.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceGroup: The name of the resource group of the storage account.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SubscriptionId: The subscription identifier of the storage account.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// Endpoints: The properties related to the custom endpoints to which your IoT hub routes messages based on the routing
/// rules. A  maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint
/// is allowed  across all endpoint types for free hubs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEndpoints
{
    /// <summary>
    /// EventHubs: The list of Event Hubs endpoints that IoT hub routes messages to, based on the routing rules. This list does
    /// not include the built-in Event Hubs endpoint.
    /// </summary>
    [JsonPropertyName("eventHubs")]
    public IList<V1api20210702IotHubStatusPropertiesRoutingEndpointsEventHubs>? EventHubs { get; set; }

    /// <summary>
    /// ServiceBusQueues: The list of Service Bus queue endpoints that IoT hub routes the messages to, based on the routing
    /// rules.
    /// </summary>
    [JsonPropertyName("serviceBusQueues")]
    public IList<V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusQueues>? ServiceBusQueues { get; set; }

    /// <summary>
    /// ServiceBusTopics: The list of Service Bus topic endpoints that the IoT hub routes the messages to, based on the routing
    /// rules.
    /// </summary>
    [JsonPropertyName("serviceBusTopics")]
    public IList<V1api20210702IotHubStatusPropertiesRoutingEndpointsServiceBusTopics>? ServiceBusTopics { get; set; }

    /// <summary>StorageContainers: The list of storage container endpoints that IoT hub routes messages to, based on the routing rules.</summary>
    [JsonPropertyName("storageContainers")]
    public IList<V1api20210702IotHubStatusPropertiesRoutingEndpointsStorageContainers>? StorageContainers { get; set; }
}

/// <summary>The properties of an enrichment that your IoT hub applies to messages delivered to endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingEnrichments
{
    /// <summary>EndpointNames: The list of endpoints for which the enrichment is applied to the message.</summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>Key: The key or name for the enrichment property.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value: The value for the enrichment property.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// FallbackRoute: The properties of the route that is used as a fall-back route when none of the conditions specified in
/// the &apos;routes&apos; section are met. This is an optional parameter. When this property is not present in the template, the
/// fallback route is disabled by default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingFallbackRoute
{
    /// <summary>
    /// Condition: The condition which is evaluated in order to apply the fallback route. If the condition is not provided it
    /// will evaluate to true by default. For grammar, See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>
    /// EndpointNames: The list of endpoints to which the messages that satisfy the condition are routed to. Currently only 1
    /// endpoint is allowed.
    /// </summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>IsEnabled: Used to specify whether the fallback route is enabled.</summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Name: The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a
    /// maximum length of 64 characters, and must be unique.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Source: The source to which the routing rule is to be applied to. For example, DeviceMessages</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>The properties of a routing rule that your IoT hub uses to route messages to endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRoutingRoutes
{
    /// <summary>
    /// Condition: The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to true
    /// by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>
    /// EndpointNames: The list of endpoints to which messages that satisfy the condition are routed. Currently only one
    /// endpoint is allowed.
    /// </summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>IsEnabled: Used to specify whether a route is enabled.</summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Name: The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a
    /// maximum length of 64 characters, and must be unique.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Source: The source that the routing rule is to be applied to, such as DeviceMessages.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>
/// Routing: The routing related properties of the IoT hub. See:
/// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesRouting
{
    /// <summary>
    /// Endpoints: The properties related to the custom endpoints to which your IoT hub routes messages based on the routing
    /// rules. A  maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint
    /// is allowed  across all endpoint types for free hubs.
    /// </summary>
    [JsonPropertyName("endpoints")]
    public V1api20210702IotHubStatusPropertiesRoutingEndpoints? Endpoints { get; set; }

    /// <summary>
    /// Enrichments: The list of user-provided enrichments that the IoT hub applies to messages to be delivered to built-in and
    /// custom endpoints. See: https://aka.ms/telemetryoneventgrid
    /// </summary>
    [JsonPropertyName("enrichments")]
    public IList<V1api20210702IotHubStatusPropertiesRoutingEnrichments>? Enrichments { get; set; }

    /// <summary>
    /// FallbackRoute: The properties of the route that is used as a fall-back route when none of the conditions specified in
    /// the &apos;routes&apos; section are met. This is an optional parameter. When this property is not present in the template, the
    /// fallback route is disabled by default.
    /// </summary>
    [JsonPropertyName("fallbackRoute")]
    public V1api20210702IotHubStatusPropertiesRoutingFallbackRoute? FallbackRoute { get; set; }

    /// <summary>
    /// Routes: The list of user-provided routing rules that the IoT hub uses to route messages to built-in and custom
    /// endpoints. A maximum of 100 routing rules are allowed for paid hubs and a maximum of 5 routing rules are allowed for
    /// free hubs.
    /// </summary>
    [JsonPropertyName("routes")]
    public IList<V1api20210702IotHubStatusPropertiesRoutingRoutes>? Routes { get; set; }
}

/// <summary>Identity: Managed identity properties of storage endpoint for file upload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesStorageEndpointsIdentity
{
    /// <summary>UserAssignedIdentity: The user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>The properties of the Azure Storage endpoint for file upload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusPropertiesStorageEndpoints
{
    /// <summary>AuthenticationType: Specifies authentication type being used for connecting to the storage account.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>
    /// ContainerName: The name of the root container where you upload files. The container need not exist but should be
    /// creatable using the connectionString specified.
    /// </summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Identity: Managed identity properties of storage endpoint for file upload.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubStatusPropertiesStorageEndpointsIdentity? Identity { get; set; }

    /// <summary>
    /// SasTtlAsIso8601: The period of time for which the SAS URI generated by IoT Hub for file upload is valid. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-file-upload#file-upload-notification-configuration-options.
    /// </summary>
    [JsonPropertyName("sasTtlAsIso8601")]
    public string? SasTtlAsIso8601 { get; set; }
}

/// <summary>Properties: IotHub properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusProperties
{
    /// <summary>AllowedFqdnList: List of allowed FQDNs(Fully Qualified Domain Name) for egress from Iot Hub.</summary>
    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    /// <summary>AuthorizationPolicies: The shared access policies you can use to secure a connection to the IoT hub.</summary>
    [JsonPropertyName("authorizationPolicies")]
    public IList<V1api20210702IotHubStatusPropertiesAuthorizationPolicies>? AuthorizationPolicies { get; set; }

    /// <summary>CloudToDevice: The IoT hub cloud-to-device messaging properties.</summary>
    [JsonPropertyName("cloudToDevice")]
    public V1api20210702IotHubStatusPropertiesCloudToDevice? CloudToDevice { get; set; }

    /// <summary>Comments: IoT hub comments.</summary>
    [JsonPropertyName("comments")]
    public string? Comments { get; set; }

    /// <summary>
    /// DisableDeviceSAS: If true, all device(including Edge devices but excluding modules) scoped SAS keys cannot be used for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableDeviceSAS")]
    public bool? DisableDeviceSAS { get; set; }

    /// <summary>DisableLocalAuth: If true, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication.</summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>DisableModuleSAS: If true, all module scoped SAS keys cannot be used for authentication.</summary>
    [JsonPropertyName("disableModuleSAS")]
    public bool? DisableModuleSAS { get; set; }

    /// <summary>EnableDataResidency: This property when set to true, will enable data residency, thus, disabling disaster recovery.</summary>
    [JsonPropertyName("enableDataResidency")]
    public bool? EnableDataResidency { get; set; }

    /// <summary>EnableFileUploadNotifications: If True, file upload notifications are enabled.</summary>
    [JsonPropertyName("enableFileUploadNotifications")]
    public bool? EnableFileUploadNotifications { get; set; }

    /// <summary>
    /// EventHubEndpoints: The Event Hub-compatible endpoint properties. The only possible keys to this dictionary is events.
    /// This key has to be present in the dictionary while making create or update calls for the IoT hub.
    /// </summary>
    [JsonPropertyName("eventHubEndpoints")]
    public IDictionary<string, V1api20210702IotHubStatusPropertiesEventHubEndpoints>? EventHubEndpoints { get; set; }

    /// <summary>Features: The capabilities and features enabled for the IoT hub.</summary>
    [JsonPropertyName("features")]
    public string? Features { get; set; }

    /// <summary>HostName: The name of the host.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>IpFilterRules: The IP filter rules.</summary>
    [JsonPropertyName("ipFilterRules")]
    public IList<V1api20210702IotHubStatusPropertiesIpFilterRules>? IpFilterRules { get; set; }

    /// <summary>Locations: Primary and secondary location for iot hub</summary>
    [JsonPropertyName("locations")]
    public IList<V1api20210702IotHubStatusPropertiesLocations>? Locations { get; set; }

    /// <summary>MessagingEndpoints: The messaging endpoint properties for the file upload notification queue.</summary>
    [JsonPropertyName("messagingEndpoints")]
    public IDictionary<string, V1api20210702IotHubStatusPropertiesMessagingEndpoints>? MessagingEndpoints { get; set; }

    /// <summary>
    /// MinTlsVersion: Specifies the minimum TLS version to support for this hub. Can be set to &quot;1.2&quot; to have clients that use a
    /// TLS version below 1.2 to be rejected.
    /// </summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>NetworkRuleSets: Network Rule Set Properties of IotHub</summary>
    [JsonPropertyName("networkRuleSets")]
    public V1api20210702IotHubStatusPropertiesNetworkRuleSets? NetworkRuleSets { get; set; }

    /// <summary>PrivateEndpointConnections: Private endpoint connections created on this IotHub</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210702IotHubStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: The provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RestrictOutboundNetworkAccess: If true, egress from IotHub will be restricted to only the allowed FQDNs that are
    /// configured via allowedFqdnList.
    /// </summary>
    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public bool? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>
    /// Routing: The routing related properties of the IoT hub. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
    /// </summary>
    [JsonPropertyName("routing")]
    public V1api20210702IotHubStatusPropertiesRouting? Routing { get; set; }

    /// <summary>State: The hub state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// StorageEndpoints: The list of Azure Storage endpoints where you can upload files. Currently you can configure only one
    /// Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error
    /// to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True,
    /// causes an error to be thrown.
    /// </summary>
    [JsonPropertyName("storageEndpoints")]
    public IDictionary<string, V1api20210702IotHubStatusPropertiesStorageEndpoints>? StorageEndpoints { get; set; }
}

/// <summary>Sku: IotHub SKU info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusSku
{
    /// <summary>
    /// Capacity: The number of provisioned IoT Hub units. See:
    /// https://docs.microsoft.com/azure/azure-subscription-service-limits#iot-hub-limits.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: The name of the SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The billing tier for the IoT hub.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: The system meta data relating to this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702IotHubStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210702IotHubStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Etag: The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per
    /// the normal ETag convention.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: The resource identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The managed identities for the IotHub.</summary>
    [JsonPropertyName("identity")]
    public V1api20210702IotHubStatusIdentity? Identity { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: IotHub properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210702IotHubStatusProperties? Properties { get; set; }

    /// <summary>Sku: IotHub SKU info</summary>
    [JsonPropertyName("sku")]
    public V1api20210702IotHubStatusSku? Sku { get; set; }

    /// <summary>SystemData: The system meta data relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210702IotHubStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /iothub/resource-manager/Microsoft.Devices/IoTHub/stable/2021-07-02/iothub.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210702IotHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210702IotHubSpec?>, IStatus<V1api20210702IotHubStatus?>
{
    public const string KubeApiVersion = "v1api20210702";
    public const string KubeKind = "IotHub";
    public const string KubeGroup = "devices.azure.com";
    public const string KubePluralName = "iothubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.com/v1api20210702";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IotHub";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210702IotHubSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210702IotHubStatus? Status { get; set; }
}
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
/// Storage version of v1api20210702.IotHub
/// Generator information:
/// - Generated from: /iothub/resource-manager/Microsoft.Devices/IoTHub/stable/2021-07-02/iothub.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210702storageIotHubList : IKubernetesObject<V1ListMeta>, IItems<V1api20210702storageIotHub>
{
    public const string KubeApiVersion = "v1api20210702storage";
    public const string KubeKind = "IotHubList";
    public const string KubeGroup = "devices.azure.com";
    public const string KubePluralName = "iothubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.com/v1api20210702storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IotHubList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210702storageIotHub objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210702storageIotHub> Items { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20210702.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210702storageIotHubSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20210702.ArmIdentity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210702storageIotHubSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretExpressions
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsDevicePrimaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsDeviceSecondaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsIotHubOwnerPrimaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsIotHubOwnerSecondaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadPrimaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadSecondaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadWritePrimaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadWriteSecondaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsServicePrimaryKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecretsServiceSecondaryKey
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

/// <summary>Storage version of v1api20210702.IotHubOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpecSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("devicePrimaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsDevicePrimaryKey? DevicePrimaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("deviceSecondaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsDeviceSecondaryKey? DeviceSecondaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("iotHubOwnerPrimaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsIotHubOwnerPrimaryKey? IotHubOwnerPrimaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("iotHubOwnerSecondaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsIotHubOwnerSecondaryKey? IotHubOwnerSecondaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("registryReadPrimaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadPrimaryKey? RegistryReadPrimaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("registryReadSecondaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadSecondaryKey? RegistryReadSecondaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("registryReadWritePrimaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadWritePrimaryKey? RegistryReadWritePrimaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("registryReadWriteSecondaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsRegistryReadWriteSecondaryKey? RegistryReadWriteSecondaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("servicePrimaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsServicePrimaryKey? ServicePrimaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("serviceSecondaryKey")]
    public V1api20210702storageIotHubSpecOperatorSpecSecretsServiceSecondaryKey? ServiceSecondaryKey { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IotHubOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210702storageIotHubSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210702storageIotHubSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20210702.IotHubOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20210702storageIotHubSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.SharedAccessSignatureAuthorizationRule
/// The properties of an IoT hub shared access policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesAuthorizationPolicies
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("rights")]
    public string? Rights { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.FeedbackProperties
/// The properties of the feedback queue for cloud-to-device messages.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesCloudToDeviceFeedback
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.CloudToDeviceProperties
/// The IoT hub cloud-to-device messaging properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesCloudToDevice
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultTtlAsIso8601")]
    public string? DefaultTtlAsIso8601 { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.FeedbackProperties
    /// The properties of the feedback queue for cloud-to-device messages.
    /// </summary>
    [JsonPropertyName("feedback")]
    public V1api20210702storageIotHubSpecPropertiesCloudToDeviceFeedback? Feedback { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.EventHubProperties
/// The properties of the provisioned Event Hub-compatible endpoint used by the IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesEventHubEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    [JsonPropertyName("retentionTimeInDays")]
    public int? RetentionTimeInDays { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IpFilterRule
/// The IP filter rules for the IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesIpFilterRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("filterName")]
    public string? FilterName { get; set; }

    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.MessagingEndpointProperties
/// The properties of the messaging endpoints used by this IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesMessagingEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.NetworkRuleSetIpRule
/// IP Rule to be applied as part of Network Rule Set
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesNetworkRuleSetsIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("filterName")]
    public string? FilterName { get; set; }

    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.NetworkRuleSetProperties
/// Network Rule Set Properties of IotHub
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesNetworkRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("applyToBuiltInEventHubEndpoint")]
    public bool? ApplyToBuiltInEventHubEndpoint { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V1api20210702storageIotHubSpecPropertiesNetworkRuleSetsIpRules>? IpRules { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubsConnectionString
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
/// Storage version of v1api20210702.ManagedIdentity
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubsIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the event hub endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubsReference
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
/// Storage version of v1api20210702.RoutingEventHubProperties
/// The properties related to an event hub endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubsConnectionString? ConnectionString { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubsIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Id of the event hub endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubsReference? Reference { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueuesConnectionString
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
/// Storage version of v1api20210702.ManagedIdentity
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueuesIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the service bus queue endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueuesReference
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
/// Storage version of v1api20210702.RoutingServiceBusQueueEndpointProperties
/// The properties related to service bus queue endpoint types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueues
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueuesConnectionString? ConnectionString { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueuesIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Id of the service bus queue endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueuesReference? Reference { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopicsConnectionString
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
/// Storage version of v1api20210702.ManagedIdentity
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopicsIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the service bus topic endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopicsReference
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
/// Storage version of v1api20210702.RoutingServiceBusTopicEndpointProperties
/// The properties related to service bus topic endpoint types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopicsConnectionString? ConnectionString { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopicsIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Id of the service bus topic endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopicsReference? Reference { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainersConnectionString
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
/// Storage version of v1api20210702.ManagedIdentity
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainersIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Reference: Id of the storage container endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainersReference
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
/// Storage version of v1api20210702.RoutingStorageContainerProperties
/// The properties related to a storage container endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    [JsonPropertyName("batchFrequencyInSeconds")]
    public int? BatchFrequencyInSeconds { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainersConnectionString? ConnectionString { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("fileNameFormat")]
    public string? FileNameFormat { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainersIdentity? Identity { get; set; }

    [JsonPropertyName("maxChunkSizeInBytes")]
    public int? MaxChunkSizeInBytes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Id of the storage container endpoint</summary>
    [JsonPropertyName("reference")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainersReference? Reference { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingEndpoints
/// The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A
/// maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed
/// across all endpoint types for free hubs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eventHubs")]
    public IList<V1api20210702storageIotHubSpecPropertiesRoutingEndpointsEventHubs>? EventHubs { get; set; }

    [JsonPropertyName("serviceBusQueues")]
    public IList<V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusQueues>? ServiceBusQueues { get; set; }

    [JsonPropertyName("serviceBusTopics")]
    public IList<V1api20210702storageIotHubSpecPropertiesRoutingEndpointsServiceBusTopics>? ServiceBusTopics { get; set; }

    [JsonPropertyName("storageContainers")]
    public IList<V1api20210702storageIotHubSpecPropertiesRoutingEndpointsStorageContainers>? StorageContainers { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.EnrichmentProperties
/// The properties of an enrichment that your IoT hub applies to messages delivered to endpoints.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingEnrichments
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.FallbackRouteProperties
/// The properties of the fallback route. IoT Hub uses these properties when it routes messages to the fallback endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingFallbackRoute
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RouteProperties
/// The properties of a routing rule that your IoT hub uses to route messages to endpoints.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRoutingRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingProperties
/// The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesRouting
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.RoutingEndpoints
    /// The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A
    /// maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed
    /// across all endpoint types for free hubs.
    /// </summary>
    [JsonPropertyName("endpoints")]
    public V1api20210702storageIotHubSpecPropertiesRoutingEndpoints? Endpoints { get; set; }

    [JsonPropertyName("enrichments")]
    public IList<V1api20210702storageIotHubSpecPropertiesRoutingEnrichments>? Enrichments { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.FallbackRouteProperties
    /// The properties of the fallback route. IoT Hub uses these properties when it routes messages to the fallback endpoint.
    /// </summary>
    [JsonPropertyName("fallbackRoute")]
    public V1api20210702storageIotHubSpecPropertiesRoutingFallbackRoute? FallbackRoute { get; set; }

    [JsonPropertyName("routes")]
    public IList<V1api20210702storageIotHubSpecPropertiesRoutingRoutes>? Routes { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesStorageEndpointsConnectionString
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
/// Storage version of v1api20210702.ManagedIdentity
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesStorageEndpointsIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.StorageEndpointProperties
/// The properties of the Azure Storage endpoint for file upload.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecPropertiesStorageEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionString")]
    public V1api20210702storageIotHubSpecPropertiesStorageEndpointsConnectionString? ConnectionString { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubSpecPropertiesStorageEndpointsIdentity? Identity { get; set; }

    [JsonPropertyName("sasTtlAsIso8601")]
    public string? SasTtlAsIso8601 { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IotHubProperties
/// The properties of an IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    [JsonPropertyName("authorizationPolicies")]
    public IList<V1api20210702storageIotHubSpecPropertiesAuthorizationPolicies>? AuthorizationPolicies { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.CloudToDeviceProperties
    /// The IoT hub cloud-to-device messaging properties.
    /// </summary>
    [JsonPropertyName("cloudToDevice")]
    public V1api20210702storageIotHubSpecPropertiesCloudToDevice? CloudToDevice { get; set; }

    [JsonPropertyName("comments")]
    public string? Comments { get; set; }

    [JsonPropertyName("disableDeviceSAS")]
    public bool? DisableDeviceSAS { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("disableModuleSAS")]
    public bool? DisableModuleSAS { get; set; }

    [JsonPropertyName("enableDataResidency")]
    public bool? EnableDataResidency { get; set; }

    [JsonPropertyName("enableFileUploadNotifications")]
    public bool? EnableFileUploadNotifications { get; set; }

    [JsonPropertyName("eventHubEndpoints")]
    public IDictionary<string, V1api20210702storageIotHubSpecPropertiesEventHubEndpoints>? EventHubEndpoints { get; set; }

    [JsonPropertyName("features")]
    public string? Features { get; set; }

    [JsonPropertyName("ipFilterRules")]
    public IList<V1api20210702storageIotHubSpecPropertiesIpFilterRules>? IpFilterRules { get; set; }

    [JsonPropertyName("messagingEndpoints")]
    public IDictionary<string, V1api20210702storageIotHubSpecPropertiesMessagingEndpoints>? MessagingEndpoints { get; set; }

    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.NetworkRuleSetProperties
    /// Network Rule Set Properties of IotHub
    /// </summary>
    [JsonPropertyName("networkRuleSets")]
    public V1api20210702storageIotHubSpecPropertiesNetworkRuleSets? NetworkRuleSets { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public bool? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.RoutingProperties
    /// The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
    /// </summary>
    [JsonPropertyName("routing")]
    public V1api20210702storageIotHubSpecPropertiesRouting? Routing { get; set; }

    [JsonPropertyName("storageEndpoints")]
    public IDictionary<string, V1api20210702storageIotHubSpecPropertiesStorageEndpoints>? StorageEndpoints { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IotHubSkuInfo
/// Information about the SKU of the IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210702.IotHub_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20210702.ArmIdentity</summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubSpecIdentity? Identity { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.IotHubOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210702storageIotHubSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210702storageIotHubSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.IotHubProperties
    /// The properties of an IoT hub.
    /// </summary>
    [JsonPropertyName("properties")]
    public V1api20210702storageIotHubSpecProperties? Properties { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.IotHubSkuInfo
    /// Information about the SKU of the IoT hub.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20210702storageIotHubSpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusConditions
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

/// <summary>Storage version of v1api20210702.ArmUserIdentity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Storage version of v1api20210702.ArmIdentity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210702storageIotHubStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.SharedAccessSignatureAuthorizationRule_STATUS
/// The properties of an IoT hub shared access policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesAuthorizationPolicies
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("rights")]
    public string? Rights { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.FeedbackProperties_STATUS
/// The properties of the feedback queue for cloud-to-device messages.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesCloudToDeviceFeedback
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.CloudToDeviceProperties_STATUS
/// The IoT hub cloud-to-device messaging properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesCloudToDevice
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultTtlAsIso8601")]
    public string? DefaultTtlAsIso8601 { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.FeedbackProperties_STATUS
    /// The properties of the feedback queue for cloud-to-device messages.
    /// </summary>
    [JsonPropertyName("feedback")]
    public V1api20210702storageIotHubStatusPropertiesCloudToDeviceFeedback? Feedback { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.EventHubProperties_STATUS
/// The properties of the provisioned Event Hub-compatible endpoint used by the IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesEventHubEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    [JsonPropertyName("partitionIds")]
    public IList<string>? PartitionIds { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("retentionTimeInDays")]
    public int? RetentionTimeInDays { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IpFilterRule_STATUS
/// The IP filter rules for the IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesIpFilterRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("filterName")]
    public string? FilterName { get; set; }

    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IotHubLocationDescription_STATUS
/// Public representation of one of the locations where a resource is provisioned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesLocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.MessagingEndpointProperties_STATUS
/// The properties of the messaging endpoints used by this IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesMessagingEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("lockDurationAsIso8601")]
    public string? LockDurationAsIso8601 { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    [JsonPropertyName("ttlAsIso8601")]
    public string? TtlAsIso8601 { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.NetworkRuleSetIpRule_STATUS
/// IP Rule to be applied as part of Network Rule Set
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesNetworkRuleSetsIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("filterName")]
    public string? FilterName { get; set; }

    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.NetworkRuleSetProperties_STATUS
/// Network Rule Set Properties of IotHub
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesNetworkRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("applyToBuiltInEventHubEndpoint")]
    public bool? ApplyToBuiltInEventHubEndpoint { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V1api20210702storageIotHubStatusPropertiesNetworkRuleSetsIpRules>? IpRules { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.PrivateEndpointConnection_STATUS
/// The private endpoint connection of an IotHub
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesPrivateEndpointConnections
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.ManagedIdentity_STATUS
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsEventHubsIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingEventHubProperties_STATUS
/// The properties related to an event hub endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsEventHubs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity_STATUS
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubStatusPropertiesRoutingEndpointsEventHubsIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.ManagedIdentity_STATUS
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusQueuesIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingServiceBusQueueEndpointProperties_STATUS
/// The properties related to service bus queue endpoint types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusQueues
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity_STATUS
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusQueuesIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.ManagedIdentity_STATUS
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusTopicsIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingServiceBusTopicEndpointProperties_STATUS
/// The properties related to service bus topic endpoint types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusTopics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity_STATUS
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusTopicsIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.ManagedIdentity_STATUS
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsStorageContainersIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingStorageContainerProperties_STATUS
/// The properties related to a storage container endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpointsStorageContainers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    [JsonPropertyName("batchFrequencyInSeconds")]
    public int? BatchFrequencyInSeconds { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    [JsonPropertyName("fileNameFormat")]
    public string? FileNameFormat { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity_STATUS
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubStatusPropertiesRoutingEndpointsStorageContainersIdentity? Identity { get; set; }

    [JsonPropertyName("maxChunkSizeInBytes")]
    public int? MaxChunkSizeInBytes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingEndpoints_STATUS
/// The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A
/// maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed
/// across all endpoint types for free hubs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eventHubs")]
    public IList<V1api20210702storageIotHubStatusPropertiesRoutingEndpointsEventHubs>? EventHubs { get; set; }

    [JsonPropertyName("serviceBusQueues")]
    public IList<V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusQueues>? ServiceBusQueues { get; set; }

    [JsonPropertyName("serviceBusTopics")]
    public IList<V1api20210702storageIotHubStatusPropertiesRoutingEndpointsServiceBusTopics>? ServiceBusTopics { get; set; }

    [JsonPropertyName("storageContainers")]
    public IList<V1api20210702storageIotHubStatusPropertiesRoutingEndpointsStorageContainers>? StorageContainers { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.EnrichmentProperties_STATUS
/// The properties of an enrichment that your IoT hub applies to messages delivered to endpoints.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingEnrichments
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.FallbackRouteProperties_STATUS
/// The properties of the fallback route. IoT Hub uses these properties when it routes messages to the fallback endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingFallbackRoute
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RouteProperties_STATUS
/// The properties of a routing rule that your IoT hub uses to route messages to endpoints.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRoutingRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.RoutingProperties_STATUS
/// The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesRouting
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.RoutingEndpoints_STATUS
    /// The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A
    /// maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed
    /// across all endpoint types for free hubs.
    /// </summary>
    [JsonPropertyName("endpoints")]
    public V1api20210702storageIotHubStatusPropertiesRoutingEndpoints? Endpoints { get; set; }

    [JsonPropertyName("enrichments")]
    public IList<V1api20210702storageIotHubStatusPropertiesRoutingEnrichments>? Enrichments { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.FallbackRouteProperties_STATUS
    /// The properties of the fallback route. IoT Hub uses these properties when it routes messages to the fallback endpoint.
    /// </summary>
    [JsonPropertyName("fallbackRoute")]
    public V1api20210702storageIotHubStatusPropertiesRoutingFallbackRoute? FallbackRoute { get; set; }

    [JsonPropertyName("routes")]
    public IList<V1api20210702storageIotHubStatusPropertiesRoutingRoutes>? Routes { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.ManagedIdentity_STATUS
/// The properties of the Managed identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesStorageEndpointsIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.StorageEndpointProperties_STATUS
/// The properties of the Azure Storage endpoint for file upload.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusPropertiesStorageEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.ManagedIdentity_STATUS
    /// The properties of the Managed identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubStatusPropertiesStorageEndpointsIdentity? Identity { get; set; }

    [JsonPropertyName("sasTtlAsIso8601")]
    public string? SasTtlAsIso8601 { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IotHubProperties_STATUS
/// The properties of an IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    [JsonPropertyName("authorizationPolicies")]
    public IList<V1api20210702storageIotHubStatusPropertiesAuthorizationPolicies>? AuthorizationPolicies { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.CloudToDeviceProperties_STATUS
    /// The IoT hub cloud-to-device messaging properties.
    /// </summary>
    [JsonPropertyName("cloudToDevice")]
    public V1api20210702storageIotHubStatusPropertiesCloudToDevice? CloudToDevice { get; set; }

    [JsonPropertyName("comments")]
    public string? Comments { get; set; }

    [JsonPropertyName("disableDeviceSAS")]
    public bool? DisableDeviceSAS { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("disableModuleSAS")]
    public bool? DisableModuleSAS { get; set; }

    [JsonPropertyName("enableDataResidency")]
    public bool? EnableDataResidency { get; set; }

    [JsonPropertyName("enableFileUploadNotifications")]
    public bool? EnableFileUploadNotifications { get; set; }

    [JsonPropertyName("eventHubEndpoints")]
    public IDictionary<string, V1api20210702storageIotHubStatusPropertiesEventHubEndpoints>? EventHubEndpoints { get; set; }

    [JsonPropertyName("features")]
    public string? Features { get; set; }

    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    [JsonPropertyName("ipFilterRules")]
    public IList<V1api20210702storageIotHubStatusPropertiesIpFilterRules>? IpFilterRules { get; set; }

    [JsonPropertyName("locations")]
    public IList<V1api20210702storageIotHubStatusPropertiesLocations>? Locations { get; set; }

    [JsonPropertyName("messagingEndpoints")]
    public IDictionary<string, V1api20210702storageIotHubStatusPropertiesMessagingEndpoints>? MessagingEndpoints { get; set; }

    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.NetworkRuleSetProperties_STATUS
    /// Network Rule Set Properties of IotHub
    /// </summary>
    [JsonPropertyName("networkRuleSets")]
    public V1api20210702storageIotHubStatusPropertiesNetworkRuleSets? NetworkRuleSets { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210702storageIotHubStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public bool? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.RoutingProperties_STATUS
    /// The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
    /// </summary>
    [JsonPropertyName("routing")]
    public V1api20210702storageIotHubStatusPropertiesRouting? Routing { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("storageEndpoints")]
    public IDictionary<string, V1api20210702storageIotHubStatusPropertiesStorageEndpoints>? StorageEndpoints { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IotHubSkuInfo_STATUS
/// Information about the SKU of the IoT hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20210702.IotHub_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210702storageIotHubStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20210702storageIotHubStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20210702.ArmIdentity_STATUS</summary>
    [JsonPropertyName("identity")]
    public V1api20210702storageIotHubStatusIdentity? Identity { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.IotHubProperties_STATUS
    /// The properties of an IoT hub.
    /// </summary>
    [JsonPropertyName("properties")]
    public V1api20210702storageIotHubStatusProperties? Properties { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.IotHubSkuInfo_STATUS
    /// Information about the SKU of the IoT hub.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20210702storageIotHubStatusSku? Sku { get; set; }

    /// <summary>
    /// Storage version of v1api20210702.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20210702storageIotHubStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20210702.IotHub
/// Generator information:
/// - Generated from: /iothub/resource-manager/Microsoft.Devices/IoTHub/stable/2021-07-02/iothub.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210702storageIotHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210702storageIotHubSpec?>, IStatus<V1api20210702storageIotHubStatus?>
{
    public const string KubeApiVersion = "v1api20210702storage";
    public const string KubeKind = "IotHub";
    public const string KubeGroup = "devices.azure.com";
    public const string KubePluralName = "iothubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.com/v1api20210702storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IotHub";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210702.IotHub_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210702storageIotHubSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210702.IotHub_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20210702storageIotHubStatus? Status { get; set; }
}
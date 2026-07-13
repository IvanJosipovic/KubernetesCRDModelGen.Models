#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.app.azure.com;
/// <summary>
/// Storage version of v1api20240301.ManagedEnvironment
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/ManagedEnvironments.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageManagedEnvironmentList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301storageManagedEnvironment>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "ManagedEnvironmentList";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "managedenvironments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedEnvironmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301storageManagedEnvironment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301storageManagedEnvironment> Items { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfigurationSharedKey
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
/// Storage version of v1api20240301.LogAnalyticsConfiguration
/// Log Analytics configuration, must only be provided when destination is configured as &apos;log-analytics&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("sharedKey")]
    public V1api20240301storageManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfigurationSharedKey? SharedKey { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.AppLogsConfiguration
/// Configuration of application logs
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecAppLogsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.LogAnalyticsConfiguration
    /// Log Analytics configuration, must only be provided when destination is configured as &apos;log-analytics&apos;
    /// </summary>
    [JsonPropertyName("logAnalyticsConfiguration")]
    public V1api20240301storageManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfiguration? LogAnalyticsConfiguration { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecCustomDomainConfigurationCertificatePassword
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
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecCustomDomainConfigurationCertificateValue
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
/// Storage version of v1api20240301.CustomDomainConfiguration
/// Configuration properties for apps environment custom domain
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecCustomDomainConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("certificatePassword")]
    public V1api20240301storageManagedEnvironmentSpecCustomDomainConfigurationCertificatePassword? CertificatePassword { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("certificateValue")]
    public V1api20240301storageManagedEnvironmentSpecCustomDomainConfigurationCertificateValue? CertificateValue { get; set; }

    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecDaprAIConnectionString
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
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecDaprAIInstrumentationKey
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240301storageManagedEnvironmentSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240301.ManagedEnvironmentOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageManagedEnvironmentSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageManagedEnvironmentSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.Mtls
/// Configuration properties for mutual TLS authentication
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecPeerAuthenticationMtls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerAuthentication_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecPeerAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.Mtls
    /// Configuration properties for mutual TLS authentication
    /// </summary>
    [JsonPropertyName("mtls")]
    public V1api20240301storageManagedEnvironmentSpecPeerAuthenticationMtls? Mtls { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_Encryption_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecPeerTrafficConfigurationEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecPeerTrafficConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_Encryption_Spec</summary>
    [JsonPropertyName("encryption")]
    public V1api20240301storageManagedEnvironmentSpecPeerTrafficConfigurationEncryption? Encryption { get; set; }
}

/// <summary>
/// InfrastructureSubnetReference: Resource ID of a subnet for infrastructure components. Must not overlap with any other
/// provided IP ranges.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecVnetConfigurationInfrastructureSubnetReference
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
/// Storage version of v1api20240301.VnetConfiguration
/// Configuration properties for apps environment to join a Virtual Network
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecVnetConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary>
    /// InfrastructureSubnetReference: Resource ID of a subnet for infrastructure components. Must not overlap with any other
    /// provided IP ranges.
    /// </summary>
    [JsonPropertyName("infrastructureSubnetReference")]
    public V1api20240301storageManagedEnvironmentSpecVnetConfigurationInfrastructureSubnetReference? InfrastructureSubnetReference { get; set; }

    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    [JsonPropertyName("platformReservedCidr")]
    public string? PlatformReservedCidr { get; set; }

    [JsonPropertyName("platformReservedDnsIP")]
    public string? PlatformReservedDnsIP { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.WorkloadProfile
/// Workload profile to scope container app execution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpecWorkloadProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maximumCount")]
    public int? MaximumCount { get; set; }

    [JsonPropertyName("minimumCount")]
    public int? MinimumCount { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedEnvironment_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.AppLogsConfiguration
    /// Configuration of application logs
    /// </summary>
    [JsonPropertyName("appLogsConfiguration")]
    public V1api20240301storageManagedEnvironmentSpecAppLogsConfiguration? AppLogsConfiguration { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.CustomDomainConfiguration
    /// Configuration properties for apps environment custom domain
    /// </summary>
    [JsonPropertyName("customDomainConfiguration")]
    public V1api20240301storageManagedEnvironmentSpecCustomDomainConfiguration? CustomDomainConfiguration { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("daprAIConnectionString")]
    public V1api20240301storageManagedEnvironmentSpecDaprAIConnectionString? DaprAIConnectionString { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("daprAIInstrumentationKey")]
    public V1api20240301storageManagedEnvironmentSpecDaprAIInstrumentationKey? DaprAIInstrumentationKey { get; set; }

    [JsonPropertyName("infrastructureResourceGroup")]
    public string? InfrastructureResourceGroup { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedEnvironmentOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageManagedEnvironmentSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301storageManagedEnvironmentSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerAuthentication_Spec</summary>
    [JsonPropertyName("peerAuthentication")]
    public V1api20240301storageManagedEnvironmentSpecPeerAuthentication? PeerAuthentication { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_Spec</summary>
    [JsonPropertyName("peerTrafficConfiguration")]
    public V1api20240301storageManagedEnvironmentSpecPeerTrafficConfiguration? PeerTrafficConfiguration { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.VnetConfiguration
    /// Configuration properties for apps environment to join a Virtual Network
    /// </summary>
    [JsonPropertyName("vnetConfiguration")]
    public V1api20240301storageManagedEnvironmentSpecVnetConfiguration? VnetConfiguration { get; set; }

    [JsonPropertyName("workloadProfiles")]
    public IList<V1api20240301storageManagedEnvironmentSpecWorkloadProfiles>? WorkloadProfiles { get; set; }

    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.LogAnalyticsConfiguration_STATUS
/// Log Analytics configuration, must only be provided when destination is configured as &apos;log-analytics&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusAppLogsConfigurationLogAnalyticsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.AppLogsConfiguration_STATUS
/// Configuration of application logs
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusAppLogsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.LogAnalyticsConfiguration_STATUS
    /// Log Analytics configuration, must only be provided when destination is configured as &apos;log-analytics&apos;
    /// </summary>
    [JsonPropertyName("logAnalyticsConfiguration")]
    public V1api20240301storageManagedEnvironmentStatusAppLogsConfigurationLogAnalyticsConfiguration? LogAnalyticsConfiguration { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusConditions
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

/// <summary>
/// Storage version of v1api20240301.CustomDomainConfiguration_STATUS
/// Configuration properties for apps environment custom domain
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusCustomDomainConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }

    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    [JsonPropertyName("subjectName")]
    public string? SubjectName { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.DaprConfiguration_STATUS
/// Configuration properties Dapr component
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusDaprConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.KedaConfiguration_STATUS
/// Configuration properties Keda component
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusKedaConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.Mtls_STATUS
/// Configuration properties for mutual TLS authentication
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusPeerAuthenticationMtls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerAuthentication_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusPeerAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.Mtls_STATUS
    /// Configuration properties for mutual TLS authentication
    /// </summary>
    [JsonPropertyName("mtls")]
    public V1api20240301storageManagedEnvironmentStatusPeerAuthenticationMtls? Mtls { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_Encryption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusPeerTrafficConfigurationEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusPeerTrafficConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_Encryption_STATUS</summary>
    [JsonPropertyName("encryption")]
    public V1api20240301storageManagedEnvironmentStatusPeerTrafficConfigurationEncryption? Encryption { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusSystemData
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

/// <summary>
/// Storage version of v1api20240301.VnetConfiguration_STATUS
/// Configuration properties for apps environment to join a Virtual Network
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusVnetConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    [JsonPropertyName("platformReservedCidr")]
    public string? PlatformReservedCidr { get; set; }

    [JsonPropertyName("platformReservedDnsIP")]
    public string? PlatformReservedDnsIP { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.WorkloadProfile_STATUS
/// Workload profile to scope container app execution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatusWorkloadProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maximumCount")]
    public int? MaximumCount { get; set; }

    [JsonPropertyName("minimumCount")]
    public int? MinimumCount { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedEnvironment_STATUS
/// An environment for hosting container apps
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageManagedEnvironmentStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.AppLogsConfiguration_STATUS
    /// Configuration of application logs
    /// </summary>
    [JsonPropertyName("appLogsConfiguration")]
    public V1api20240301storageManagedEnvironmentStatusAppLogsConfiguration? AppLogsConfiguration { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageManagedEnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.CustomDomainConfiguration_STATUS
    /// Configuration properties for apps environment custom domain
    /// </summary>
    [JsonPropertyName("customDomainConfiguration")]
    public V1api20240301storageManagedEnvironmentStatusCustomDomainConfiguration? CustomDomainConfiguration { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.DaprConfiguration_STATUS
    /// Configuration properties Dapr component
    /// </summary>
    [JsonPropertyName("daprConfiguration")]
    public V1api20240301storageManagedEnvironmentStatusDaprConfiguration? DaprConfiguration { get; set; }

    [JsonPropertyName("defaultDomain")]
    public string? DefaultDomain { get; set; }

    [JsonPropertyName("deploymentErrors")]
    public string? DeploymentErrors { get; set; }

    [JsonPropertyName("eventStreamEndpoint")]
    public string? EventStreamEndpoint { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("infrastructureResourceGroup")]
    public string? InfrastructureResourceGroup { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.KedaConfiguration_STATUS
    /// Configuration properties Keda component
    /// </summary>
    [JsonPropertyName("kedaConfiguration")]
    public V1api20240301storageManagedEnvironmentStatusKedaConfiguration? KedaConfiguration { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerAuthentication_STATUS</summary>
    [JsonPropertyName("peerAuthentication")]
    public V1api20240301storageManagedEnvironmentStatusPeerAuthentication? PeerAuthentication { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedEnvironment_Properties_PeerTrafficConfiguration_STATUS</summary>
    [JsonPropertyName("peerTrafficConfiguration")]
    public V1api20240301storageManagedEnvironmentStatusPeerTrafficConfiguration? PeerTrafficConfiguration { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("staticIp")]
    public string? StaticIp { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20240301storageManagedEnvironmentStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.VnetConfiguration_STATUS
    /// Configuration properties for apps environment to join a Virtual Network
    /// </summary>
    [JsonPropertyName("vnetConfiguration")]
    public V1api20240301storageManagedEnvironmentStatusVnetConfiguration? VnetConfiguration { get; set; }

    [JsonPropertyName("workloadProfiles")]
    public IList<V1api20240301storageManagedEnvironmentStatusWorkloadProfiles>? WorkloadProfiles { get; set; }

    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedEnvironment
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/ManagedEnvironments.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageManagedEnvironment : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageManagedEnvironmentSpec?>, IStatus<V1api20240301storageManagedEnvironmentStatus?>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "ManagedEnvironment";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "managedenvironments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedEnvironment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedEnvironment_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageManagedEnvironmentSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedEnvironment_STATUS
    /// An environment for hosting container apps
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20240301storageManagedEnvironmentStatus? Status { get; set; }
}
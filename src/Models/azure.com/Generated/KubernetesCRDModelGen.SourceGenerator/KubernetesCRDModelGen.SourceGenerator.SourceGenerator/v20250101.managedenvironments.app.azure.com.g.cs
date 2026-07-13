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
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2025-01-01/ManagedEnvironments.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101ManagedEnvironmentList : IKubernetesObject<V1ListMeta>, IItems<V20250101ManagedEnvironment>
{
    public const string KubeApiVersion = "v20250101";
    public const string KubeKind = "ManagedEnvironmentList";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "managedenvironments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20250101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedEnvironmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250101ManagedEnvironment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250101ManagedEnvironment> Items { get; set; }
}

/// <summary>SharedKey: Log analytics customer key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfigurationSharedKey
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
/// LogAnalyticsConfiguration: Log Analytics configuration, must only be provided when destination is configured as
/// &apos;log-analytics&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfiguration
{
    /// <summary>CustomerId: Log analytics customer id</summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }

    /// <summary>SharedKey: Log analytics customer key</summary>
    [JsonPropertyName("sharedKey")]
    public V20250101ManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfigurationSharedKey? SharedKey { get; set; }
}

/// <summary>AppLogsConfiguration: Cluster configuration which enables the log daemon to export app logs to configured destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecAppLogsConfiguration
{
    /// <summary>Destination: Logs destination, can be &apos;log-analytics&apos;, &apos;azure-monitor&apos; or &apos;none&apos;</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>
    /// LogAnalyticsConfiguration: Log Analytics configuration, must only be provided when destination is configured as
    /// &apos;log-analytics&apos;
    /// </summary>
    [JsonPropertyName("logAnalyticsConfiguration")]
    public V20250101ManagedEnvironmentSpecAppLogsConfigurationLogAnalyticsConfiguration? LogAnalyticsConfiguration { get; set; }
}

/// <summary>
/// IdentityReference: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a
/// system-assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificateKeyVaultPropertiesIdentityReference
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

/// <summary>CertificateKeyVaultProperties: Certificate stored in Azure Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificateKeyVaultProperties
{
    /// <summary>
    /// IdentityReference: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a
    /// system-assigned identity.
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificateKeyVaultPropertiesIdentityReference? IdentityReference { get; set; }

    /// <summary>KeyVaultUrl: URL pointing to the Azure Key Vault secret that holds the certificate.</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }
}

/// <summary>CertificatePassword: Certificate password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificatePassword
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

/// <summary>CertificateValue: PFX or PEM blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificateValue
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

/// <summary>CustomDomainConfiguration: Custom domain configuration for the environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecCustomDomainConfiguration
{
    /// <summary>CertificateKeyVaultProperties: Certificate stored in Azure Key Vault.</summary>
    [JsonPropertyName("certificateKeyVaultProperties")]
    public V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificateKeyVaultProperties? CertificateKeyVaultProperties { get; set; }

    /// <summary>CertificatePassword: Certificate password</summary>
    [JsonPropertyName("certificatePassword")]
    public V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificatePassword? CertificatePassword { get; set; }

    /// <summary>CertificateValue: PFX or PEM blob</summary>
    [JsonPropertyName("certificateValue")]
    public V20250101ManagedEnvironmentSpecCustomDomainConfigurationCertificateValue? CertificateValue { get; set; }

    /// <summary>DnsSuffix: Dns suffix for the environment domain</summary>
    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }
}

/// <summary>
/// DaprAIConnectionString: Application Insights connection string used by Dapr to export Service to Service communication
/// telemetry
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecDaprAIConnectionString
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
/// DaprAIInstrumentationKey: Azure Monitor instrumentation key used by Dapr to export Service to Service communication
/// telemetry
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecDaprAIInstrumentationKey
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

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ManagedEnvironmentSpecIdentityTypeEnum>))]
public enum V20250101ManagedEnvironmentSpecIdentityTypeEnum
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
public partial class V20250101ManagedEnvironmentSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20250101ManagedEnvironmentSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250101ManagedEnvironmentSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Identity: Managed identities for the Managed Environment to interact with other Azure services without maintaining any
/// secrets or credentials in code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V20250101ManagedEnvironmentSpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250101ManagedEnvironmentSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecOperatorSpecConfigMapExpressions
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
public partial class V20250101ManagedEnvironmentSpecOperatorSpecSecretExpressions
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
public partial class V20250101ManagedEnvironmentSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250101ManagedEnvironmentSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250101ManagedEnvironmentSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Mtls: Mutual TLS authentication settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecPeerAuthenticationMtls
{
    /// <summary>Enabled: Boolean indicating whether the mutual TLS authentication is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>PeerAuthentication: Peer authentication settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecPeerAuthentication
{
    /// <summary>Mtls: Mutual TLS authentication settings for the Managed Environment</summary>
    [JsonPropertyName("mtls")]
    public V20250101ManagedEnvironmentSpecPeerAuthenticationMtls? Mtls { get; set; }
}

/// <summary>Encryption: Peer traffic encryption settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecPeerTrafficConfigurationEncryption
{
    /// <summary>Enabled: Boolean indicating whether the peer traffic encryption is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>PeerTrafficConfiguration: Peer traffic settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecPeerTrafficConfiguration
{
    /// <summary>Encryption: Peer traffic encryption settings for the Managed Environment</summary>
    [JsonPropertyName("encryption")]
    public V20250101ManagedEnvironmentSpecPeerTrafficConfigurationEncryption? Encryption { get; set; }
}

/// <summary>
/// InfrastructureSubnetReference: Resource ID of a subnet for infrastructure components. Must not overlap with any other
/// provided IP ranges.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecVnetConfigurationInfrastructureSubnetReference
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

/// <summary>VnetConfiguration: Vnet configuration for the environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecVnetConfiguration
{
    /// <summary>
    /// DockerBridgeCidr: CIDR notation IP range assigned to the Docker bridge, network. Must not overlap with any other
    /// provided IP ranges.
    /// </summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary>
    /// InfrastructureSubnetReference: Resource ID of a subnet for infrastructure components. Must not overlap with any other
    /// provided IP ranges.
    /// </summary>
    [JsonPropertyName("infrastructureSubnetReference")]
    public V20250101ManagedEnvironmentSpecVnetConfigurationInfrastructureSubnetReference? InfrastructureSubnetReference { get; set; }

    /// <summary>
    /// Internal: Boolean indicating the environment only has an internal load balancer. These environments do not have a public
    /// static IP resource. They must provide infrastructureSubnetId if enabling this property
    /// </summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>
    /// PlatformReservedCidr: IP range in CIDR notation that can be reserved for environment infrastructure IP addresses. Must
    /// not overlap with any other provided IP ranges.
    /// </summary>
    [JsonPropertyName("platformReservedCidr")]
    public string? PlatformReservedCidr { get; set; }

    /// <summary>
    /// PlatformReservedDnsIP:  An IP address from the IP range defined by platformReservedCidr that will be reserved for the
    /// internal DNS server.
    /// </summary>
    [JsonPropertyName("platformReservedDnsIP")]
    public string? PlatformReservedDnsIP { get; set; }
}

/// <summary>Workload profile to scope container app execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpecWorkloadProfiles
{
    /// <summary>MaximumCount: The maximum capacity.</summary>
    [JsonPropertyName("maximumCount")]
    public int? MaximumCount { get; set; }

    /// <summary>MinimumCount: The minimum capacity.</summary>
    [JsonPropertyName("minimumCount")]
    public int? MinimumCount { get; set; }

    /// <summary>Name: Workload profile type for the workloads to run on.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>WorkloadProfileType: Workload profile type for the workloads to run on.</summary>
    [JsonPropertyName("workloadProfileType")]
    public required string WorkloadProfileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentSpec
{
    /// <summary>AppLogsConfiguration: Cluster configuration which enables the log daemon to export app logs to configured destination.</summary>
    [JsonPropertyName("appLogsConfiguration")]
    public V20250101ManagedEnvironmentSpecAppLogsConfiguration? AppLogsConfiguration { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CustomDomainConfiguration: Custom domain configuration for the environment</summary>
    [JsonPropertyName("customDomainConfiguration")]
    public V20250101ManagedEnvironmentSpecCustomDomainConfiguration? CustomDomainConfiguration { get; set; }

    /// <summary>
    /// DaprAIConnectionString: Application Insights connection string used by Dapr to export Service to Service communication
    /// telemetry
    /// </summary>
    [JsonPropertyName("daprAIConnectionString")]
    public V20250101ManagedEnvironmentSpecDaprAIConnectionString? DaprAIConnectionString { get; set; }

    /// <summary>
    /// DaprAIInstrumentationKey: Azure Monitor instrumentation key used by Dapr to export Service to Service communication
    /// telemetry
    /// </summary>
    [JsonPropertyName("daprAIInstrumentationKey")]
    public V20250101ManagedEnvironmentSpecDaprAIInstrumentationKey? DaprAIInstrumentationKey { get; set; }

    /// <summary>
    /// Identity: Managed identities for the Managed Environment to interact with other Azure services without maintaining any
    /// secrets or credentials in code.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250101ManagedEnvironmentSpecIdentity? Identity { get; set; }

    /// <summary>
    /// InfrastructureResourceGroup: Name of the platform-managed resource group created for the Managed Environment to host
    /// infrastructure resources. If a subnet ID is provided, this resource group will be created in the same subscription as
    /// the subnet.
    /// </summary>
    [JsonPropertyName("infrastructureResourceGroup")]
    public string? InfrastructureResourceGroup { get; set; }

    /// <summary>Kind: Kind of the Environment.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250101ManagedEnvironmentSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250101ManagedEnvironmentSpecOwner Owner { get; set; }

    /// <summary>PeerAuthentication: Peer authentication settings for the Managed Environment</summary>
    [JsonPropertyName("peerAuthentication")]
    public V20250101ManagedEnvironmentSpecPeerAuthentication? PeerAuthentication { get; set; }

    /// <summary>PeerTrafficConfiguration: Peer traffic settings for the Managed Environment</summary>
    [JsonPropertyName("peerTrafficConfiguration")]
    public V20250101ManagedEnvironmentSpecPeerTrafficConfiguration? PeerTrafficConfiguration { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VnetConfiguration: Vnet configuration for the environment</summary>
    [JsonPropertyName("vnetConfiguration")]
    public V20250101ManagedEnvironmentSpecVnetConfiguration? VnetConfiguration { get; set; }

    /// <summary>WorkloadProfiles: Workload profiles configured for the Managed Environment.</summary>
    [JsonPropertyName("workloadProfiles")]
    public IList<V20250101ManagedEnvironmentSpecWorkloadProfiles>? WorkloadProfiles { get; set; }

    /// <summary>ZoneRedundant: Whether or not this Managed Environment is zone-redundant.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// LogAnalyticsConfiguration: Log Analytics configuration, must only be provided when destination is configured as
/// &apos;log-analytics&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusAppLogsConfigurationLogAnalyticsConfiguration
{
    /// <summary>CustomerId: Log analytics customer id</summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }
}

/// <summary>AppLogsConfiguration: Cluster configuration which enables the log daemon to export app logs to configured destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusAppLogsConfiguration
{
    /// <summary>Destination: Logs destination, can be &apos;log-analytics&apos;, &apos;azure-monitor&apos; or &apos;none&apos;</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>
    /// LogAnalyticsConfiguration: Log Analytics configuration, must only be provided when destination is configured as
    /// &apos;log-analytics&apos;
    /// </summary>
    [JsonPropertyName("logAnalyticsConfiguration")]
    public V20250101ManagedEnvironmentStatusAppLogsConfigurationLogAnalyticsConfiguration? LogAnalyticsConfiguration { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusConditions
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

/// <summary>CertificateKeyVaultProperties: Certificate stored in Azure Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusCustomDomainConfigurationCertificateKeyVaultProperties
{
    /// <summary>
    /// Identity: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>KeyVaultUrl: URL pointing to the Azure Key Vault secret that holds the certificate.</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }
}

/// <summary>CustomDomainConfiguration: Custom domain configuration for the environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusCustomDomainConfiguration
{
    /// <summary>CertificateKeyVaultProperties: Certificate stored in Azure Key Vault.</summary>
    [JsonPropertyName("certificateKeyVaultProperties")]
    public V20250101ManagedEnvironmentStatusCustomDomainConfigurationCertificateKeyVaultProperties? CertificateKeyVaultProperties { get; set; }

    /// <summary>CustomDomainVerificationId: Id used to verify domain name ownership</summary>
    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    /// <summary>DnsSuffix: Dns suffix for the environment domain</summary>
    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }

    /// <summary>ExpirationDate: Certificate expiration date.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>SubjectName: Subject name of the certificate.</summary>
    [JsonPropertyName("subjectName")]
    public string? SubjectName { get; set; }

    /// <summary>Thumbprint: Certificate thumbprint.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>DaprConfiguration: The configuration of Dapr component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusDaprConfiguration
{
    /// <summary>Version: The version of Dapr</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Identity: Managed identities for the Managed Environment to interact with other Azure services without maintaining any
/// secrets or credentials in code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusIdentity
{
    /// <summary>
    /// PrincipalId: The service principal ID of the system assigned identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant ID of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250101ManagedEnvironmentStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KedaConfiguration: The configuration of Keda component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusKedaConfiguration
{
    /// <summary>Version: The version of Keda</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Mtls: Mutual TLS authentication settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusPeerAuthenticationMtls
{
    /// <summary>Enabled: Boolean indicating whether the mutual TLS authentication is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>PeerAuthentication: Peer authentication settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusPeerAuthentication
{
    /// <summary>Mtls: Mutual TLS authentication settings for the Managed Environment</summary>
    [JsonPropertyName("mtls")]
    public V20250101ManagedEnvironmentStatusPeerAuthenticationMtls? Mtls { get; set; }
}

/// <summary>Encryption: Peer traffic encryption settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusPeerTrafficConfigurationEncryption
{
    /// <summary>Enabled: Boolean indicating whether the peer traffic encryption is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>PeerTrafficConfiguration: Peer traffic settings for the Managed Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusPeerTrafficConfiguration
{
    /// <summary>Encryption: Peer traffic encryption settings for the Managed Environment</summary>
    [JsonPropertyName("encryption")]
    public V20250101ManagedEnvironmentStatusPeerTrafficConfigurationEncryption? Encryption { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusSystemData
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

/// <summary>VnetConfiguration: Vnet configuration for the environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusVnetConfiguration
{
    /// <summary>
    /// DockerBridgeCidr: CIDR notation IP range assigned to the Docker bridge, network. Must not overlap with any other
    /// provided IP ranges.
    /// </summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary>
    /// InfrastructureSubnetId: Resource ID of a subnet for infrastructure components. Must not overlap with any other provided
    /// IP ranges.
    /// </summary>
    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    /// <summary>
    /// Internal: Boolean indicating the environment only has an internal load balancer. These environments do not have a public
    /// static IP resource. They must provide infrastructureSubnetId if enabling this property
    /// </summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>
    /// PlatformReservedCidr: IP range in CIDR notation that can be reserved for environment infrastructure IP addresses. Must
    /// not overlap with any other provided IP ranges.
    /// </summary>
    [JsonPropertyName("platformReservedCidr")]
    public string? PlatformReservedCidr { get; set; }

    /// <summary>
    /// PlatformReservedDnsIP:  An IP address from the IP range defined by platformReservedCidr that will be reserved for the
    /// internal DNS server.
    /// </summary>
    [JsonPropertyName("platformReservedDnsIP")]
    public string? PlatformReservedDnsIP { get; set; }
}

/// <summary>Workload profile to scope container app execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatusWorkloadProfiles
{
    /// <summary>MaximumCount: The maximum capacity.</summary>
    [JsonPropertyName("maximumCount")]
    public int? MaximumCount { get; set; }

    /// <summary>MinimumCount: The minimum capacity.</summary>
    [JsonPropertyName("minimumCount")]
    public int? MinimumCount { get; set; }

    /// <summary>Name: Workload profile type for the workloads to run on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>WorkloadProfileType: Workload profile type for the workloads to run on.</summary>
    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}

/// <summary>An environment for hosting container apps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ManagedEnvironmentStatus
{
    /// <summary>AppLogsConfiguration: Cluster configuration which enables the log daemon to export app logs to configured destination.</summary>
    [JsonPropertyName("appLogsConfiguration")]
    public V20250101ManagedEnvironmentStatusAppLogsConfiguration? AppLogsConfiguration { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250101ManagedEnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>CustomDomainConfiguration: Custom domain configuration for the environment</summary>
    [JsonPropertyName("customDomainConfiguration")]
    public V20250101ManagedEnvironmentStatusCustomDomainConfiguration? CustomDomainConfiguration { get; set; }

    /// <summary>DaprConfiguration: The configuration of Dapr component.</summary>
    [JsonPropertyName("daprConfiguration")]
    public V20250101ManagedEnvironmentStatusDaprConfiguration? DaprConfiguration { get; set; }

    /// <summary>DefaultDomain: Default Domain Name for the cluster</summary>
    [JsonPropertyName("defaultDomain")]
    public string? DefaultDomain { get; set; }

    /// <summary>DeploymentErrors: Any errors that occurred during deployment or deployment validation</summary>
    [JsonPropertyName("deploymentErrors")]
    public string? DeploymentErrors { get; set; }

    /// <summary>EventStreamEndpoint: The endpoint of the eventstream of the Environment.</summary>
    [JsonPropertyName("eventStreamEndpoint")]
    public string? EventStreamEndpoint { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Identity: Managed identities for the Managed Environment to interact with other Azure services without maintaining any
    /// secrets or credentials in code.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250101ManagedEnvironmentStatusIdentity? Identity { get; set; }

    /// <summary>
    /// InfrastructureResourceGroup: Name of the platform-managed resource group created for the Managed Environment to host
    /// infrastructure resources. If a subnet ID is provided, this resource group will be created in the same subscription as
    /// the subnet.
    /// </summary>
    [JsonPropertyName("infrastructureResourceGroup")]
    public string? InfrastructureResourceGroup { get; set; }

    /// <summary>KedaConfiguration: The configuration of Keda component.</summary>
    [JsonPropertyName("kedaConfiguration")]
    public V20250101ManagedEnvironmentStatusKedaConfiguration? KedaConfiguration { get; set; }

    /// <summary>Kind: Kind of the Environment.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PeerAuthentication: Peer authentication settings for the Managed Environment</summary>
    [JsonPropertyName("peerAuthentication")]
    public V20250101ManagedEnvironmentStatusPeerAuthentication? PeerAuthentication { get; set; }

    /// <summary>PeerTrafficConfiguration: Peer traffic settings for the Managed Environment</summary>
    [JsonPropertyName("peerTrafficConfiguration")]
    public V20250101ManagedEnvironmentStatusPeerTrafficConfiguration? PeerTrafficConfiguration { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the Environment.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>StaticIp: Static IP of the Environment</summary>
    [JsonPropertyName("staticIp")]
    public string? StaticIp { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250101ManagedEnvironmentStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VnetConfiguration: Vnet configuration for the environment</summary>
    [JsonPropertyName("vnetConfiguration")]
    public V20250101ManagedEnvironmentStatusVnetConfiguration? VnetConfiguration { get; set; }

    /// <summary>WorkloadProfiles: Workload profiles configured for the Managed Environment.</summary>
    [JsonPropertyName("workloadProfiles")]
    public IList<V20250101ManagedEnvironmentStatusWorkloadProfiles>? WorkloadProfiles { get; set; }

    /// <summary>ZoneRedundant: Whether or not this Managed Environment is zone-redundant.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2025-01-01/ManagedEnvironments.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101ManagedEnvironment : IKubernetesObject<V1ObjectMeta>, ISpec<V20250101ManagedEnvironmentSpec?>, IStatus<V20250101ManagedEnvironmentStatus?>
{
    public const string KubeApiVersion = "v20250101";
    public const string KubeKind = "ManagedEnvironment";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "managedenvironments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20250101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedEnvironment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250101ManagedEnvironmentSpec? Spec { get; set; }

    /// <summary>An environment for hosting container apps</summary>
    [JsonPropertyName("status")]
    public V20250101ManagedEnvironmentStatus? Status { get; set; }
}
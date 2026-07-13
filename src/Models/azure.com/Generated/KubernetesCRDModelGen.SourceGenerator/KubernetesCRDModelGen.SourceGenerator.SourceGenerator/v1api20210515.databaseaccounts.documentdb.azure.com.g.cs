#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2021-05-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210515DatabaseAccountList : IKubernetesObject<V1ListMeta>, IItems<V1api20210515DatabaseAccount>
{
    public const string KubeApiVersion = "v1api20210515";
    public const string KubeKind = "DatabaseAccountList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "databaseaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20210515";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210515DatabaseAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210515DatabaseAccount> Items { get; set; }
}

/// <summary>SchemaType: Describes the types of schema for analytical storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecAnalyticalStorageConfigurationSchemaTypeEnum>))]
public enum V1api20210515DatabaseAccountSpecAnalyticalStorageConfigurationSchemaTypeEnum
{
    [EnumMember(Value = "FullFidelity"), JsonStringEnumMemberName("FullFidelity")]
    FullFidelity,
    [EnumMember(Value = "WellDefined"), JsonStringEnumMemberName("WellDefined")]
    WellDefined
}

/// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecAnalyticalStorageConfiguration
{
    /// <summary>SchemaType: Describes the types of schema for analytical storage.</summary>
    [JsonPropertyName("schemaType")]
    public V1api20210515DatabaseAccountSpecAnalyticalStorageConfigurationSchemaTypeEnum? SchemaType { get; set; }
}

/// <summary>ServerVersion: Describes the ServerVersion of an a MongoDB account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecApiPropertiesServerVersionEnum>))]
public enum V1api20210515DatabaseAccountSpecApiPropertiesServerVersionEnum
{
    [EnumMember(Value = "3.2"), JsonStringEnumMemberName("3.2")]
    _32,
    [EnumMember(Value = "3.6"), JsonStringEnumMemberName("3.6")]
    _36,
    [EnumMember(Value = "4.0"), JsonStringEnumMemberName("4.0")]
    _40
}

/// <summary>ApiProperties: API specific properties. Currently, supported only for MongoDB API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecApiProperties
{
    /// <summary>ServerVersion: Describes the ServerVersion of an a MongoDB account.</summary>
    [JsonPropertyName("serverVersion")]
    public V1api20210515DatabaseAccountSpecApiPropertiesServerVersionEnum? ServerVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecBackupPolicyContinuousTypeEnum>))]
public enum V1api20210515DatabaseAccountSpecBackupPolicyContinuousTypeEnum
{
    [EnumMember(Value = "Continuous"), JsonStringEnumMemberName("Continuous")]
    Continuous
}

/// <summary>Continuous: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecBackupPolicyContinuous
{
    [JsonPropertyName("type")]
    public required V1api20210515DatabaseAccountSpecBackupPolicyContinuousTypeEnum Type { get; set; }
}

/// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>BackupIntervalInMinutes: An integer representing the interval in minutes between two backups</summary>
    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    /// <summary>BackupRetentionIntervalInHours: An integer representing the time (in hours) that each backup is retained</summary>
    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecBackupPolicyPeriodicTypeEnum>))]
public enum V1api20210515DatabaseAccountSpecBackupPolicyPeriodicTypeEnum
{
    [EnumMember(Value = "Periodic"), JsonStringEnumMemberName("Periodic")]
    Periodic
}

/// <summary>Periodic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecBackupPolicyPeriodic
{
    /// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20210515DatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    [JsonPropertyName("type")]
    public required V1api20210515DatabaseAccountSpecBackupPolicyPeriodicTypeEnum Type { get; set; }
}

/// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecBackupPolicy
{
    /// <summary>Continuous: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("continuous")]
    public V1api20210515DatabaseAccountSpecBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Periodic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("periodic")]
    public V1api20210515DatabaseAccountSpecBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>Cosmos DB capability object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecCapabilities
{
    /// <summary>
    /// Name: Name of the Cosmos DB capability. For example, &quot;name&quot;: &quot;EnableCassandra&quot;. Current values also include
    /// &quot;EnableTable&quot; and &quot;EnableGremlin&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ConnectorOffer: The cassandra connector offer type for the Cosmos DB database C* account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecConnectorOfferEnum>))]
public enum V1api20210515DatabaseAccountSpecConnectorOfferEnum
{
    [EnumMember(Value = "Small"), JsonStringEnumMemberName("Small")]
    Small
}

/// <summary>DefaultConsistencyLevel: The default consistency level and configuration settings of the Cosmos DB account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecConsistencyPolicyDefaultConsistencyLevelEnum>))]
public enum V1api20210515DatabaseAccountSpecConsistencyPolicyDefaultConsistencyLevelEnum
{
    [EnumMember(Value = "BoundedStaleness"), JsonStringEnumMemberName("BoundedStaleness")]
    BoundedStaleness,
    [EnumMember(Value = "ConsistentPrefix"), JsonStringEnumMemberName("ConsistentPrefix")]
    ConsistentPrefix,
    [EnumMember(Value = "Eventual"), JsonStringEnumMemberName("Eventual")]
    Eventual,
    [EnumMember(Value = "Session"), JsonStringEnumMemberName("Session")]
    Session,
    [EnumMember(Value = "Strong"), JsonStringEnumMemberName("Strong")]
    Strong
}

/// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecConsistencyPolicy
{
    /// <summary>DefaultConsistencyLevel: The default consistency level and configuration settings of the Cosmos DB account.</summary>
    [JsonPropertyName("defaultConsistencyLevel")]
    public required V1api20210515DatabaseAccountSpecConsistencyPolicyDefaultConsistencyLevelEnum DefaultConsistencyLevel { get; set; }

    /// <summary>
    /// MaxIntervalInSeconds: When used with the Bounded Staleness consistency level, this value represents the time amount of
    /// staleness (in seconds) tolerated. Accepted range for this value is 5 - 86400. Required when defaultConsistencyPolicy is
    /// set to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    /// <summary>
    /// MaxStalenessPrefix: When used with the Bounded Staleness consistency level, this value represents the number of stale
    /// requests tolerated. Accepted range for this value is 1 – 2,147,483,647. Required when defaultConsistencyPolicy is set
    /// to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>The CORS policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecCors
{
    /// <summary>AllowedHeaders: The request headers that the origin domain may specify on the CORS request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    /// <summary>AllowedMethods: The methods (HTTP request verbs) that the origin domain may use for a CORS request.</summary>
    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    /// <summary>AllowedOrigins: The origin domains that are permitted to make a request against the service via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public required string AllowedOrigins { get; set; }

    /// <summary>
    /// ExposedHeaders: The response headers that may be sent in the response to the CORS request and exposed by the browser to
    /// the request issuer.
    /// </summary>
    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    /// <summary>MaxAgeInSeconds: The maximum amount time that a browser should cache the preflight OPTIONS request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>DatabaseAccountOfferType: The offer type for the database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecDatabaseAccountOfferTypeEnum>))]
public enum V1api20210515DatabaseAccountSpecDatabaseAccountOfferTypeEnum
{
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned,UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecIdentityTypeEnum>))]
public enum V1api20210515DatabaseAccountSpecIdentityTypeEnum
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
public partial class V1api20210515DatabaseAccountSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20210515DatabaseAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210515DatabaseAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned,UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20210515DatabaseAccountSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210515DatabaseAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>IpAddressOrRange object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecIpRules
{
    /// <summary>
    /// IpAddressOrRange: A single IPv4 address or a single IPv4 address range in CIDR format. Provided IPs must be
    /// well-formatted and cannot be contained in one of the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12,
    /// 192.168.0.0/16, since these are not enforceable by the IP address filter. Example of valid inputs: “23.40.210.245”
    /// or “23.40.210.0/8”.
    /// </summary>
    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>Kind: Indicates the type of database account. This can only be set at database account creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecKindEnum>))]
public enum V1api20210515DatabaseAccountSpecKindEnum
{
    [EnumMember(Value = "GlobalDocumentDB"), JsonStringEnumMemberName("GlobalDocumentDB")]
    GlobalDocumentDB,
    [EnumMember(Value = "MongoDB"), JsonStringEnumMemberName("MongoDB")]
    MongoDB,
    [EnumMember(Value = "Parse"), JsonStringEnumMemberName("Parse")]
    Parse
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecLocations
{
    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>NetworkAclBypass: Indicates what services are allowed to bypass firewall checks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecNetworkAclBypassEnum>))]
public enum V1api20210515DatabaseAccountSpecNetworkAclBypassEnum
{
    [EnumMember(Value = "AzureServices"), JsonStringEnumMemberName("AzureServices")]
    AzureServices,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210515DatabaseAccountSpecOperatorSpecSecretExpressions
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
/// DocumentEndpoint: indicates where the DocumentEndpoint secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint
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
/// PrimaryMasterKey: indicates where the PrimaryMasterKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey
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
/// PrimaryReadonlyMasterKey: indicates where the PrimaryReadonlyMasterKey secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey
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
/// SecondaryMasterKey: indicates where the SecondaryMasterKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey
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
/// SecondaryReadonlyMasterKey: indicates where the SecondaryReadonlyMasterKey secret should be placed. If omitted, the
/// secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey
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
public partial class V1api20210515DatabaseAccountSpecOperatorSpecSecrets
{
    /// <summary>
    /// DocumentEndpoint: indicates where the DocumentEndpoint secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public V1api20210515DatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint? DocumentEndpoint { get; set; }

    /// <summary>
    /// PrimaryMasterKey: indicates where the PrimaryMasterKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryMasterKey")]
    public V1api20210515DatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey? PrimaryMasterKey { get; set; }

    /// <summary>
    /// PrimaryReadonlyMasterKey: indicates where the PrimaryReadonlyMasterKey secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryReadonlyMasterKey")]
    public V1api20210515DatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey? PrimaryReadonlyMasterKey { get; set; }

    /// <summary>
    /// SecondaryMasterKey: indicates where the SecondaryMasterKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryMasterKey")]
    public V1api20210515DatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey? SecondaryMasterKey { get; set; }

    /// <summary>
    /// SecondaryReadonlyMasterKey: indicates where the SecondaryReadonlyMasterKey secret should be placed. If omitted, the
    /// secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryReadonlyMasterKey")]
    public V1api20210515DatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey? SecondaryReadonlyMasterKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210515DatabaseAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210515DatabaseAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20210515DatabaseAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515DatabaseAccountSpecPublicNetworkAccessEnum>))]
public enum V1api20210515DatabaseAccountSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// Reference: Resource ID of a subnet, for example:
/// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecVirtualNetworkRulesReference
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

/// <summary>Virtual Network ACL Rule object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpecVirtualNetworkRules
{
    /// <summary>IgnoreMissingVNetServiceEndpoint: Create firewall rule before the virtual network has vnet service endpoint enabled.</summary>
    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }

    /// <summary>
    /// Reference: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("reference")]
    public V1api20210515DatabaseAccountSpecVirtualNetworkRulesReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountSpec
{
    /// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20210515DatabaseAccountSpecAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>ApiProperties: API specific properties. Currently, supported only for MongoDB API.</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20210515DatabaseAccountSpecApiProperties? ApiProperties { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20210515DatabaseAccountSpecBackupPolicy? BackupPolicy { get; set; }

    /// <summary>Capabilities: List of Cosmos DB capabilities for the account</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20210515DatabaseAccountSpecCapabilities>? Capabilities { get; set; }

    /// <summary>ConnectorOffer: The cassandra connector offer type for the Cosmos DB database C* account.</summary>
    [JsonPropertyName("connectorOffer")]
    public V1api20210515DatabaseAccountSpecConnectorOfferEnum? ConnectorOffer { get; set; }

    /// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20210515DatabaseAccountSpecConsistencyPolicy? ConsistencyPolicy { get; set; }

    /// <summary>Cors: The CORS policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("cors")]
    public IList<V1api20210515DatabaseAccountSpecCors>? Cors { get; set; }

    /// <summary>DatabaseAccountOfferType: The offer type for the database</summary>
    [JsonPropertyName("databaseAccountOfferType")]
    public required V1api20210515DatabaseAccountSpecDatabaseAccountOfferTypeEnum DatabaseAccountOfferType { get; set; }

    /// <summary>
    /// DefaultIdentity: The default identity for accessing key vault used in features like customer managed keys. The default
    /// identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more.
    /// </summary>
    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    /// <summary>
    /// DisableKeyBasedMetadataWriteAccess: Disable write operations on metadata resources (databases, containers, throughput)
    /// via account keys
    /// </summary>
    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    /// <summary>EnableAnalyticalStorage: Flag to indicate whether to enable storage analytics.</summary>
    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    /// <summary>
    /// EnableAutomaticFailover: Enables automatic failover of the write region in the rare event that the region is unavailable
    /// due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the
    /// failover priorities configured for the account.
    /// </summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary>EnableCassandraConnector: Enables the cassandra connector on the Cosmos DB C* account</summary>
    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    /// <summary>EnableFreeTier: Flag to indicate whether Free Tier is enabled.</summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary>EnableMultipleWriteLocations: Enables the account to write in multiple locations</summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210515DatabaseAccountSpecIdentity? Identity { get; set; }

    /// <summary>IpRules: List of IpRules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210515DatabaseAccountSpecIpRules>? IpRules { get; set; }

    /// <summary>IsVirtualNetworkFilterEnabled: Flag to indicate whether to enable/disable Virtual Network ACL rules.</summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>KeyVaultKeyUri: The URI of the key vault</summary>
    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    /// <summary>Kind: Indicates the type of database account. This can only be set at database account creation.</summary>
    [JsonPropertyName("kind")]
    public V1api20210515DatabaseAccountSpecKindEnum? Kind { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Locations: An array that contains the georeplication locations enabled for the Cosmos DB account.</summary>
    [JsonPropertyName("locations")]
    public required IList<V1api20210515DatabaseAccountSpecLocations> Locations { get; set; }

    /// <summary>NetworkAclBypass: Indicates what services are allowed to bypass firewall checks.</summary>
    [JsonPropertyName("networkAclBypass")]
    public V1api20210515DatabaseAccountSpecNetworkAclBypassEnum? NetworkAclBypass { get; set; }

    /// <summary>NetworkAclBypassResourceIds: An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account.</summary>
    [JsonPropertyName("networkAclBypassResourceIds")]
    public IList<string>? NetworkAclBypassResourceIds { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210515DatabaseAccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210515DatabaseAccountSpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20210515DatabaseAccountSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VirtualNetworkRules: List of Virtual Network ACL rules configured for the Cosmos DB account.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20210515DatabaseAccountSpecVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusAnalyticalStorageConfiguration
{
    /// <summary>SchemaType: Describes the types of schema for analytical storage.</summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary>ApiProperties: API specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusApiProperties
{
    /// <summary>ServerVersion: Describes the ServerVersion of an a MongoDB account.</summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>Continuous: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusBackupPolicyContinuous
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>BackupIntervalInMinutes: An integer representing the interval in minutes between two backups</summary>
    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    /// <summary>BackupRetentionIntervalInHours: An integer representing the time (in hours) that each backup is retained</summary>
    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }
}

/// <summary>Periodic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusBackupPolicyPeriodic
{
    /// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20210515DatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusBackupPolicy
{
    /// <summary>Continuous: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("continuous")]
    public V1api20210515DatabaseAccountStatusBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Periodic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("periodic")]
    public V1api20210515DatabaseAccountStatusBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>Cosmos DB capability object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusCapabilities
{
    /// <summary>
    /// Name: Name of the Cosmos DB capability. For example, &quot;name&quot;: &quot;EnableCassandra&quot;. Current values also include
    /// &quot;EnableTable&quot; and &quot;EnableGremlin&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusConditions
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

/// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusConsistencyPolicy
{
    /// <summary>DefaultConsistencyLevel: The default consistency level and configuration settings of the Cosmos DB account.</summary>
    [JsonPropertyName("defaultConsistencyLevel")]
    public string? DefaultConsistencyLevel { get; set; }

    /// <summary>
    /// MaxIntervalInSeconds: When used with the Bounded Staleness consistency level, this value represents the time amount of
    /// staleness (in seconds) tolerated. Accepted range for this value is 5 - 86400. Required when defaultConsistencyPolicy is
    /// set to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    /// <summary>
    /// MaxStalenessPrefix: When used with the Bounded Staleness consistency level, this value represents the number of stale
    /// requests tolerated. Accepted range for this value is 1 – 2,147,483,647. Required when defaultConsistencyPolicy is set
    /// to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>The CORS policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusCors
{
    /// <summary>AllowedHeaders: The request headers that the origin domain may specify on the CORS request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    /// <summary>AllowedMethods: The methods (HTTP request verbs) that the origin domain may use for a CORS request.</summary>
    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    /// <summary>AllowedOrigins: The origin domains that are permitted to make a request against the service via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public string? AllowedOrigins { get; set; }

    /// <summary>
    /// ExposedHeaders: The response headers that may be sent in the response to the CORS request and exposed by the browser to
    /// the request issuer.
    /// </summary>
    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    /// <summary>MaxAgeInSeconds: The maximum amount time that a browser should cache the preflight OPTIONS request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>The failover policy for a given region of a database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusFailoverPolicies
{
    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>
    /// Id: The unique identifier of the region in which the database account replicates to. Example:
    /// &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LocationName: The name of the region in which the database account exists.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned,UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210515DatabaseAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>IpAddressOrRange object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusIpRules
{
    /// <summary>
    /// IpAddressOrRange: A single IPv4 address or a single IPv4 address range in CIDR format. Provided IPs must be
    /// well-formatted and cannot be contained in one of the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12,
    /// 192.168.0.0/16, since these are not enforceable by the IP address filter. Example of valid inputs: “23.40.210.245”
    /// or “23.40.210.0/8”.
    /// </summary>
    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusLocations
{
    /// <summary>
    /// DocumentEndpoint: The connection endpoint for the specific region. Example:
    /// https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>Id: The unique identifier of the region within the database account. Example: &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>A private endpoint connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusReadLocations
{
    /// <summary>
    /// DocumentEndpoint: The connection endpoint for the specific region. Example:
    /// https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>Id: The unique identifier of the region within the database account. Example: &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Virtual Network ACL Rule object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusVirtualNetworkRules
{
    /// <summary>
    /// Id: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IgnoreMissingVNetServiceEndpoint: Create firewall rule before the virtual network has vnet service endpoint enabled.</summary>
    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatusWriteLocations
{
    /// <summary>
    /// DocumentEndpoint: The connection endpoint for the specific region. Example:
    /// https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>Id: The unique identifier of the region within the database account. Example: &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515DatabaseAccountStatus
{
    /// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20210515DatabaseAccountStatusAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>ApiProperties: API specific properties.</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20210515DatabaseAccountStatusApiProperties? ApiProperties { get; set; }

    /// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20210515DatabaseAccountStatusBackupPolicy? BackupPolicy { get; set; }

    /// <summary>Capabilities: List of Cosmos DB capabilities for the account</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20210515DatabaseAccountStatusCapabilities>? Capabilities { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210515DatabaseAccountStatusConditions>? Conditions { get; set; }

    /// <summary>ConnectorOffer: The cassandra connector offer type for the Cosmos DB database C* account.</summary>
    [JsonPropertyName("connectorOffer")]
    public string? ConnectorOffer { get; set; }

    /// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20210515DatabaseAccountStatusConsistencyPolicy? ConsistencyPolicy { get; set; }

    /// <summary>Cors: The CORS policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("cors")]
    public IList<V1api20210515DatabaseAccountStatusCors>? Cors { get; set; }

    /// <summary>DatabaseAccountOfferType: The offer type for the Cosmos DB database account. Default value: Standard.</summary>
    [JsonPropertyName("databaseAccountOfferType")]
    public string? DatabaseAccountOfferType { get; set; }

    /// <summary>
    /// DefaultIdentity: The default identity for accessing key vault used in features like customer managed keys. The default
    /// identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more.
    /// </summary>
    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    /// <summary>
    /// DisableKeyBasedMetadataWriteAccess: Disable write operations on metadata resources (databases, containers, throughput)
    /// via account keys
    /// </summary>
    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    /// <summary>DocumentEndpoint: The connection endpoint for the Cosmos DB database account.</summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>EnableAnalyticalStorage: Flag to indicate whether to enable storage analytics.</summary>
    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    /// <summary>
    /// EnableAutomaticFailover: Enables automatic failover of the write region in the rare event that the region is unavailable
    /// due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the
    /// failover priorities configured for the account.
    /// </summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary>EnableCassandraConnector: Enables the cassandra connector on the Cosmos DB C* account</summary>
    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    /// <summary>EnableFreeTier: Flag to indicate whether Free Tier is enabled.</summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary>EnableMultipleWriteLocations: Enables the account to write in multiple locations</summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary>FailoverPolicies: An array that contains the regions ordered by their failover priorities.</summary>
    [JsonPropertyName("failoverPolicies")]
    public IList<V1api20210515DatabaseAccountStatusFailoverPolicies>? FailoverPolicies { get; set; }

    /// <summary>Id: The unique resource identifier of the ARM resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210515DatabaseAccountStatusIdentity? Identity { get; set; }

    /// <summary>IpRules: List of IpRules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210515DatabaseAccountStatusIpRules>? IpRules { get; set; }

    /// <summary>IsVirtualNetworkFilterEnabled: Flag to indicate whether to enable/disable Virtual Network ACL rules.</summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>KeyVaultKeyUri: The URI of the key vault</summary>
    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    /// <summary>Kind: Indicates the type of database account. This can only be set at database account creation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Locations: An array that contains all of the locations enabled for the Cosmos DB account.</summary>
    [JsonPropertyName("locations")]
    public IList<V1api20210515DatabaseAccountStatusLocations>? Locations { get; set; }

    /// <summary>Name: The name of the ARM resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkAclBypass: Indicates what services are allowed to bypass firewall checks.</summary>
    [JsonPropertyName("networkAclBypass")]
    public string? NetworkAclBypass { get; set; }

    /// <summary>NetworkAclBypassResourceIds: An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account.</summary>
    [JsonPropertyName("networkAclBypassResourceIds")]
    public IList<string>? NetworkAclBypassResourceIds { get; set; }

    /// <summary>PrivateEndpointConnections: List of Private Endpoint Connections configured for the Cosmos DB account.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210515DatabaseAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>ReadLocations: An array that contains of the read locations enabled for the Cosmos DB account.</summary>
    [JsonPropertyName("readLocations")]
    public IList<V1api20210515DatabaseAccountStatusReadLocations>? ReadLocations { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualNetworkRules: List of Virtual Network ACL rules configured for the Cosmos DB account.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20210515DatabaseAccountStatusVirtualNetworkRules>? VirtualNetworkRules { get; set; }

    /// <summary>WriteLocations: An array that contains the write location for the Cosmos DB account.</summary>
    [JsonPropertyName("writeLocations")]
    public IList<V1api20210515DatabaseAccountStatusWriteLocations>? WriteLocations { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2021-05-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210515DatabaseAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210515DatabaseAccountSpec?>, IStatus<V1api20210515DatabaseAccountStatus?>
{
    public const string KubeApiVersion = "v1api20210515";
    public const string KubeKind = "DatabaseAccount";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "databaseaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20210515";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210515DatabaseAccountSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210515DatabaseAccountStatus? Status { get; set; }
}
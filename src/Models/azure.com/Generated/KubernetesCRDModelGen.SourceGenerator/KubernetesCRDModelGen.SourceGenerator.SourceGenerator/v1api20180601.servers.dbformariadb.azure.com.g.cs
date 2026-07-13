#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbformariadb.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /mariadb/resource-manager/Microsoft.DBforMariaDB/stable/2018-06-01/mariadb.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMariaDB/servers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180601ServerList : IKubernetesObject<V1ListMeta>, IItems<V1api20180601Server>
{
    public const string KubeApiVersion = "v1api20180601";
    public const string KubeKind = "ServerList";
    public const string KubeGroup = "dbformariadb.azure.com";
    public const string KubePluralName = "servers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformariadb.azure.com/v1api20180601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20180601Server objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20180601Server> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20180601ServerSpecOperatorSpecSecretExpressions
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
/// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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
public partial class V1api20180601ServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20180601ServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20180601ServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20180601ServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20180601ServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>AdministratorLoginPassword: The password of the administrator login.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesDefaultAdministratorLoginPassword
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

/// <summary>CreateMode: The mode to create a new server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesDefaultCreateModeEnum>))]
public enum V1api20180601ServerSpecPropertiesDefaultCreateModeEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default
}

/// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesDefaultMinimalTlsVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesDefaultMinimalTlsVersionEnum
{
    [EnumMember(Value = "TLS1_0"), JsonStringEnumMemberName("TLS1_0")]
    TLS10,
    [EnumMember(Value = "TLS1_1"), JsonStringEnumMemberName("TLS1_1")]
    TLS11,
    [EnumMember(Value = "TLS1_2"), JsonStringEnumMemberName("TLS1_2")]
    TLS12,
    [EnumMember(Value = "TLSEnforcementDisabled"), JsonStringEnumMemberName("TLSEnforcementDisabled")]
    TLSEnforcementDisabled
}

/// <summary>
/// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
/// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesDefaultPublicNetworkAccessEnum>))]
public enum V1api20180601ServerSpecPropertiesDefaultPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesDefaultSslEnforcementEnum>))]
public enum V1api20180601ServerSpecPropertiesDefaultSslEnforcementEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesDefaultStorageProfileGeoRedundantBackupEnum>))]
public enum V1api20180601ServerSpecPropertiesDefaultStorageProfileGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesDefaultStorageProfileStorageAutogrowEnum>))]
public enum V1api20180601ServerSpecPropertiesDefaultStorageProfileStorageAutogrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageProfile: Storage profile of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesDefaultStorageProfile
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V1api20180601ServerSpecPropertiesDefaultStorageProfileGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }

    /// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
    [JsonPropertyName("storageAutogrow")]
    public V1api20180601ServerSpecPropertiesDefaultStorageProfileStorageAutogrowEnum? StorageAutogrow { get; set; }

    /// <summary>StorageMB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageMB")]
    public int? StorageMB { get; set; }
}

/// <summary>Version: Server version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesDefaultVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesDefaultVersionEnum
{
    [EnumMember(Value = "10.2"), JsonStringEnumMemberName("10.2")]
    _102,
    [EnumMember(Value = "10.3"), JsonStringEnumMemberName("10.3")]
    _103
}

/// <summary>Default: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesDefault
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public required string AdministratorLogin { get; set; }

    /// <summary>AdministratorLoginPassword: The password of the administrator login.</summary>
    [JsonPropertyName("administratorLoginPassword")]
    public required V1api20180601ServerSpecPropertiesDefaultAdministratorLoginPassword AdministratorLoginPassword { get; set; }

    /// <summary>CreateMode: The mode to create a new server.</summary>
    [JsonPropertyName("createMode")]
    public required V1api20180601ServerSpecPropertiesDefaultCreateModeEnum CreateMode { get; set; }

    /// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public V1api20180601ServerSpecPropertiesDefaultMinimalTlsVersionEnum? MinimalTlsVersion { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20180601ServerSpecPropertiesDefaultPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
    [JsonPropertyName("sslEnforcement")]
    public V1api20180601ServerSpecPropertiesDefaultSslEnforcementEnum? SslEnforcement { get; set; }

    /// <summary>StorageProfile: Storage profile of a server.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20180601ServerSpecPropertiesDefaultStorageProfile? StorageProfile { get; set; }

    /// <summary>Version: Server version.</summary>
    [JsonPropertyName("version")]
    public V1api20180601ServerSpecPropertiesDefaultVersionEnum? Version { get; set; }
}

/// <summary>CreateMode: The mode to create a new server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesGeoRestoreCreateModeEnum>))]
public enum V1api20180601ServerSpecPropertiesGeoRestoreCreateModeEnum
{
    [EnumMember(Value = "GeoRestore"), JsonStringEnumMemberName("GeoRestore")]
    GeoRestore
}

/// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesGeoRestoreMinimalTlsVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesGeoRestoreMinimalTlsVersionEnum
{
    [EnumMember(Value = "TLS1_0"), JsonStringEnumMemberName("TLS1_0")]
    TLS10,
    [EnumMember(Value = "TLS1_1"), JsonStringEnumMemberName("TLS1_1")]
    TLS11,
    [EnumMember(Value = "TLS1_2"), JsonStringEnumMemberName("TLS1_2")]
    TLS12,
    [EnumMember(Value = "TLSEnforcementDisabled"), JsonStringEnumMemberName("TLSEnforcementDisabled")]
    TLSEnforcementDisabled
}

/// <summary>
/// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
/// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesGeoRestorePublicNetworkAccessEnum>))]
public enum V1api20180601ServerSpecPropertiesGeoRestorePublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesGeoRestoreSslEnforcementEnum>))]
public enum V1api20180601ServerSpecPropertiesGeoRestoreSslEnforcementEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesGeoRestoreStorageProfileGeoRedundantBackupEnum>))]
public enum V1api20180601ServerSpecPropertiesGeoRestoreStorageProfileGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesGeoRestoreStorageProfileStorageAutogrowEnum>))]
public enum V1api20180601ServerSpecPropertiesGeoRestoreStorageProfileStorageAutogrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageProfile: Storage profile of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesGeoRestoreStorageProfile
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V1api20180601ServerSpecPropertiesGeoRestoreStorageProfileGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }

    /// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
    [JsonPropertyName("storageAutogrow")]
    public V1api20180601ServerSpecPropertiesGeoRestoreStorageProfileStorageAutogrowEnum? StorageAutogrow { get; set; }

    /// <summary>StorageMB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageMB")]
    public int? StorageMB { get; set; }
}

/// <summary>Version: Server version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesGeoRestoreVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesGeoRestoreVersionEnum
{
    [EnumMember(Value = "10.2"), JsonStringEnumMemberName("10.2")]
    _102,
    [EnumMember(Value = "10.3"), JsonStringEnumMemberName("10.3")]
    _103
}

/// <summary>GeoRestore: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesGeoRestore
{
    /// <summary>CreateMode: The mode to create a new server.</summary>
    [JsonPropertyName("createMode")]
    public required V1api20180601ServerSpecPropertiesGeoRestoreCreateModeEnum CreateMode { get; set; }

    /// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public V1api20180601ServerSpecPropertiesGeoRestoreMinimalTlsVersionEnum? MinimalTlsVersion { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20180601ServerSpecPropertiesGeoRestorePublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>SourceServerId: The source server id to restore from.</summary>
    [JsonPropertyName("sourceServerId")]
    public required string SourceServerId { get; set; }

    /// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
    [JsonPropertyName("sslEnforcement")]
    public V1api20180601ServerSpecPropertiesGeoRestoreSslEnforcementEnum? SslEnforcement { get; set; }

    /// <summary>StorageProfile: Storage profile of a server.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20180601ServerSpecPropertiesGeoRestoreStorageProfile? StorageProfile { get; set; }

    /// <summary>Version: Server version.</summary>
    [JsonPropertyName("version")]
    public V1api20180601ServerSpecPropertiesGeoRestoreVersionEnum? Version { get; set; }
}

/// <summary>CreateMode: The mode to create a new server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesPointInTimeRestoreCreateModeEnum>))]
public enum V1api20180601ServerSpecPropertiesPointInTimeRestoreCreateModeEnum
{
    [EnumMember(Value = "PointInTimeRestore"), JsonStringEnumMemberName("PointInTimeRestore")]
    PointInTimeRestore
}

/// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesPointInTimeRestoreMinimalTlsVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesPointInTimeRestoreMinimalTlsVersionEnum
{
    [EnumMember(Value = "TLS1_0"), JsonStringEnumMemberName("TLS1_0")]
    TLS10,
    [EnumMember(Value = "TLS1_1"), JsonStringEnumMemberName("TLS1_1")]
    TLS11,
    [EnumMember(Value = "TLS1_2"), JsonStringEnumMemberName("TLS1_2")]
    TLS12,
    [EnumMember(Value = "TLSEnforcementDisabled"), JsonStringEnumMemberName("TLSEnforcementDisabled")]
    TLSEnforcementDisabled
}

/// <summary>
/// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
/// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesPointInTimeRestorePublicNetworkAccessEnum>))]
public enum V1api20180601ServerSpecPropertiesPointInTimeRestorePublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesPointInTimeRestoreSslEnforcementEnum>))]
public enum V1api20180601ServerSpecPropertiesPointInTimeRestoreSslEnforcementEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfileGeoRedundantBackupEnum>))]
public enum V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfileGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfileStorageAutogrowEnum>))]
public enum V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfileStorageAutogrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageProfile: Storage profile of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfile
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfileGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }

    /// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
    [JsonPropertyName("storageAutogrow")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfileStorageAutogrowEnum? StorageAutogrow { get; set; }

    /// <summary>StorageMB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageMB")]
    public int? StorageMB { get; set; }
}

/// <summary>Version: Server version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesPointInTimeRestoreVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesPointInTimeRestoreVersionEnum
{
    [EnumMember(Value = "10.2"), JsonStringEnumMemberName("10.2")]
    _102,
    [EnumMember(Value = "10.3"), JsonStringEnumMemberName("10.3")]
    _103
}

/// <summary>PointInTimeRestore: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesPointInTimeRestore
{
    /// <summary>CreateMode: The mode to create a new server.</summary>
    [JsonPropertyName("createMode")]
    public required V1api20180601ServerSpecPropertiesPointInTimeRestoreCreateModeEnum CreateMode { get; set; }

    /// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestoreMinimalTlsVersionEnum? MinimalTlsVersion { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestorePublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>RestorePointInTime: Restore point creation time (ISO8601 format), specifying the time to restore from.</summary>
    [JsonPropertyName("restorePointInTime")]
    public required string RestorePointInTime { get; set; }

    /// <summary>SourceServerId: The source server id to restore from.</summary>
    [JsonPropertyName("sourceServerId")]
    public required string SourceServerId { get; set; }

    /// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
    [JsonPropertyName("sslEnforcement")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestoreSslEnforcementEnum? SslEnforcement { get; set; }

    /// <summary>StorageProfile: Storage profile of a server.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestoreStorageProfile? StorageProfile { get; set; }

    /// <summary>Version: Server version.</summary>
    [JsonPropertyName("version")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestoreVersionEnum? Version { get; set; }
}

/// <summary>CreateMode: The mode to create a new server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesReplicaCreateModeEnum>))]
public enum V1api20180601ServerSpecPropertiesReplicaCreateModeEnum
{
    [EnumMember(Value = "Replica"), JsonStringEnumMemberName("Replica")]
    Replica
}

/// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesReplicaMinimalTlsVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesReplicaMinimalTlsVersionEnum
{
    [EnumMember(Value = "TLS1_0"), JsonStringEnumMemberName("TLS1_0")]
    TLS10,
    [EnumMember(Value = "TLS1_1"), JsonStringEnumMemberName("TLS1_1")]
    TLS11,
    [EnumMember(Value = "TLS1_2"), JsonStringEnumMemberName("TLS1_2")]
    TLS12,
    [EnumMember(Value = "TLSEnforcementDisabled"), JsonStringEnumMemberName("TLSEnforcementDisabled")]
    TLSEnforcementDisabled
}

/// <summary>
/// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
/// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesReplicaPublicNetworkAccessEnum>))]
public enum V1api20180601ServerSpecPropertiesReplicaPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesReplicaSslEnforcementEnum>))]
public enum V1api20180601ServerSpecPropertiesReplicaSslEnforcementEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesReplicaStorageProfileGeoRedundantBackupEnum>))]
public enum V1api20180601ServerSpecPropertiesReplicaStorageProfileGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesReplicaStorageProfileStorageAutogrowEnum>))]
public enum V1api20180601ServerSpecPropertiesReplicaStorageProfileStorageAutogrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageProfile: Storage profile of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesReplicaStorageProfile
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V1api20180601ServerSpecPropertiesReplicaStorageProfileGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }

    /// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
    [JsonPropertyName("storageAutogrow")]
    public V1api20180601ServerSpecPropertiesReplicaStorageProfileStorageAutogrowEnum? StorageAutogrow { get; set; }

    /// <summary>StorageMB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageMB")]
    public int? StorageMB { get; set; }
}

/// <summary>Version: Server version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecPropertiesReplicaVersionEnum>))]
public enum V1api20180601ServerSpecPropertiesReplicaVersionEnum
{
    [EnumMember(Value = "10.2"), JsonStringEnumMemberName("10.2")]
    _102,
    [EnumMember(Value = "10.3"), JsonStringEnumMemberName("10.3")]
    _103
}

/// <summary>Replica: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecPropertiesReplica
{
    /// <summary>CreateMode: The mode to create a new server.</summary>
    [JsonPropertyName("createMode")]
    public required V1api20180601ServerSpecPropertiesReplicaCreateModeEnum CreateMode { get; set; }

    /// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public V1api20180601ServerSpecPropertiesReplicaMinimalTlsVersionEnum? MinimalTlsVersion { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20180601ServerSpecPropertiesReplicaPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>SourceServerId: The master server id to create replica from.</summary>
    [JsonPropertyName("sourceServerId")]
    public required string SourceServerId { get; set; }

    /// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
    [JsonPropertyName("sslEnforcement")]
    public V1api20180601ServerSpecPropertiesReplicaSslEnforcementEnum? SslEnforcement { get; set; }

    /// <summary>StorageProfile: Storage profile of a server.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20180601ServerSpecPropertiesReplicaStorageProfile? StorageProfile { get; set; }

    /// <summary>Version: Server version.</summary>
    [JsonPropertyName("version")]
    public V1api20180601ServerSpecPropertiesReplicaVersionEnum? Version { get; set; }
}

/// <summary>Properties: Properties of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecProperties
{
    /// <summary>Default: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("default")]
    public V1api20180601ServerSpecPropertiesDefault? Default { get; set; }

    /// <summary>GeoRestore: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("geoRestore")]
    public V1api20180601ServerSpecPropertiesGeoRestore? GeoRestore { get; set; }

    /// <summary>PointInTimeRestore: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("pointInTimeRestore")]
    public V1api20180601ServerSpecPropertiesPointInTimeRestore? PointInTimeRestore { get; set; }

    /// <summary>Replica: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("replica")]
    public V1api20180601ServerSpecPropertiesReplica? Replica { get; set; }
}

/// <summary>Tier: The tier of the particular SKU, e.g. Basic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601ServerSpecSkuTierEnum>))]
public enum V1api20180601ServerSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "GeneralPurpose"), JsonStringEnumMemberName("GeneralPurpose")]
    GeneralPurpose,
    [EnumMember(Value = "MemoryOptimized"), JsonStringEnumMemberName("MemoryOptimized")]
    MemoryOptimized
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpecSku
{
    /// <summary>Capacity: The scale up/out capacity, representing server&apos;s compute units.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: The family of hardware.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Size: The size code, to be interpreted by resource as appropriate.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. Basic.</summary>
    [JsonPropertyName("tier")]
    public V1api20180601ServerSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: The location the resource resides in.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20180601ServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20180601ServerSpecOwner Owner { get; set; }

    /// <summary>Properties: Properties of the server.</summary>
    [JsonPropertyName("properties")]
    public required V1api20180601ServerSpecProperties Properties { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V1api20180601ServerSpecSku? Sku { get; set; }

    /// <summary>Tags: Application-specific metadata in the form of key-value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerStatusConditions
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

/// <summary>PrivateEndpoint: Private endpoint which the connection belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerStatusPrivateEndpointConnectionsPropertiesPrivateEndpoint
{
    /// <summary>Id: Resource id of the private endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PrivateLinkServiceConnectionState: Connection state of the private endpoint connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerStatusPrivateEndpointConnectionsPropertiesPrivateLinkServiceConnectionState
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
public partial class V1api20180601ServerStatusPrivateEndpointConnectionsProperties
{
    /// <summary>PrivateEndpoint: Private endpoint which the connection belongs to.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20180601ServerStatusPrivateEndpointConnectionsPropertiesPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>PrivateLinkServiceConnectionState: Connection state of the private endpoint connection.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20180601ServerStatusPrivateEndpointConnectionsPropertiesPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>ProvisioningState: State of the private endpoint connection.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>A private endpoint connection under a server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerStatusPrivateEndpointConnections
{
    /// <summary>Id: Resource Id of the private endpoint connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Properties: Private endpoint connection properties</summary>
    [JsonPropertyName("properties")]
    public V1api20180601ServerStatusPrivateEndpointConnectionsProperties? Properties { get; set; }
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerStatusSku
{
    /// <summary>Capacity: The scale up/out capacity, representing server&apos;s compute units.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: The family of hardware.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: The size code, to be interpreted by resource as appropriate.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. Basic.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>StorageProfile: Storage profile of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerStatusStorageProfile
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Enable Geo-redundant or not for server backup.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public string? GeoRedundantBackup { get; set; }

    /// <summary>StorageAutogrow: Enable Storage Auto Grow.</summary>
    [JsonPropertyName("storageAutogrow")]
    public string? StorageAutogrow { get; set; }

    /// <summary>StorageMB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageMB")]
    public int? StorageMB { get; set; }
}

/// <summary>Represents a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601ServerStatus
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20180601ServerStatusConditions>? Conditions { get; set; }

    /// <summary>EarliestRestoreDate: Earliest restore point creation time (ISO8601 format)</summary>
    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    /// <summary>FullyQualifiedDomainName: The fully qualified domain name of a server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MasterServerId: The master server id of a replica server.</summary>
    [JsonPropertyName("masterServerId")]
    public string? MasterServerId { get; set; }

    /// <summary>MinimalTlsVersion: Enforce a minimal Tls version for the server.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections on a server</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20180601ServerStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>ReplicaCapacity: The maximum number of replicas that a master server can have.</summary>
    [JsonPropertyName("replicaCapacity")]
    public int? ReplicaCapacity { get; set; }

    /// <summary>ReplicationRole: The replication role of the server.</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V1api20180601ServerStatusSku? Sku { get; set; }

    /// <summary>SslEnforcement: Enable ssl enforcement or not when connect to server.</summary>
    [JsonPropertyName("sslEnforcement")]
    public string? SslEnforcement { get; set; }

    /// <summary>StorageProfile: Storage profile of a server.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20180601ServerStatusStorageProfile? StorageProfile { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserVisibleState: A state of a server that is visible to user.</summary>
    [JsonPropertyName("userVisibleState")]
    public string? UserVisibleState { get; set; }

    /// <summary>Version: Server version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /mariadb/resource-manager/Microsoft.DBforMariaDB/stable/2018-06-01/mariadb.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMariaDB/servers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180601Server : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180601ServerSpec?>, IStatus<V1api20180601ServerStatus?>
{
    public const string KubeApiVersion = "v1api20180601";
    public const string KubeKind = "Server";
    public const string KubeGroup = "dbformariadb.azure.com";
    public const string KubePluralName = "servers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformariadb.azure.com/v1api20180601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Server";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20180601ServerSpec? Spec { get; set; }

    /// <summary>Represents a server.</summary>
    [JsonPropertyName("status")]
    public V1api20180601ServerStatus? Status { get; set; }
}
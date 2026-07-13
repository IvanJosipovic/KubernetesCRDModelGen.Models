#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101BackupVaultsBackupInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1api20231101BackupVaultsBackupInstance>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "BackupVaultsBackupInstanceList";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackupinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231101BackupVaultsBackupInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231101BackupVaultsBackupInstance> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231101BackupVaultsBackupInstanceSpecOperatorSpecSecretExpressions
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
public partial class V1api20231101BackupVaultsBackupInstanceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231101BackupVaultsBackupInstanceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231101BackupVaultsBackupInstanceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a dataprotection.azure.com/BackupVault resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourcePropertiesObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourcePropertiesObjectTypeEnum
{
    [EnumMember(Value = "DefaultResourceProperties"), JsonStringEnumMemberName("DefaultResourceProperties")]
    DefaultResourceProperties
}

/// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourcePropertiesObjectTypeEnum ObjectType { get; set; }
}

/// <summary>ResourceProperties: Properties specific to data source</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceProperties
{
    /// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>
/// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
/// be the ID created by backup service via Fabric/Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceReference
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

/// <summary>DataSourceInfo: Gets or sets the data source information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfo
{
    /// <summary>DatasourceType: DatasourceType of the resource.</summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>ResourceLocation: Location of datasource.</summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary>ResourceName: Unique identifier of the resource in the context of parent.</summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>ResourceProperties: Properties specific to data source</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>
    /// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
    /// be the ID created by backup service via Fabric/Vault.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceReference ResourceReference { get; set; }

    /// <summary>ResourceType: Resource Type of Datasource.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>ResourceUri: Uri of the resource.</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourcePropertiesObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourcePropertiesObjectTypeEnum
{
    [EnumMember(Value = "DefaultResourceProperties"), JsonStringEnumMemberName("DefaultResourceProperties")]
    DefaultResourceProperties
}

/// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourcePropertiesObjectTypeEnum ObjectType { get; set; }
}

/// <summary>ResourceProperties: Properties specific to data source set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceProperties
{
    /// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>
/// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
/// be the ID created by backup service via Fabric/Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceReference
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

/// <summary>DataSourceSetInfo: Gets or sets the data source set information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfo
{
    /// <summary>DatasourceType: DatasourceType of the resource.</summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>ResourceLocation: Location of datasource.</summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary>ResourceName: Unique identifier of the resource in the context of parent.</summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>ResourceProperties: Properties specific to data source set</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>
    /// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
    /// be the ID created by backup service via Fabric/Vault.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceReference ResourceReference { get; set; }

    /// <summary>ResourceType: Resource Type of Datasource.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>ResourceUri: Uri of the resource.</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsObjectTypeEnum
{
    [EnumMember(Value = "SecretStoreBasedAuthCredentials"), JsonStringEnumMemberName("SecretStoreBasedAuthCredentials")]
    SecretStoreBasedAuthCredentials
}

/// <summary>SecretStoreType: Gets or sets the type of secret store</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResourceSecretStoreTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResourceSecretStoreTypeEnum
{
    [EnumMember(Value = "AzureKeyVault"), JsonStringEnumMemberName("AzureKeyVault")]
    AzureKeyVault,
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid
}

/// <summary>SecretStoreResource: Secret store resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource
{
    /// <summary>SecretStoreType: Gets or sets the type of secret store</summary>
    [JsonPropertyName("secretStoreType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResourceSecretStoreTypeEnum SecretStoreType { get; set; }

    /// <summary>Uri: Uri to get to the resource</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Value: Gets or sets value stored in secret store resource</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SecretStoreBasedAuthCredentials: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsObjectTypeEnum ObjectType { get; set; }

    /// <summary>SecretStoreResource: Secret store resource</summary>
    [JsonPropertyName("secretStoreResource")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource? SecretStoreResource { get; set; }
}

/// <summary>DatasourceAuthCredentials: Credentials to use to authenticate with data source provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentials
{
    /// <summary>SecretStoreBasedAuthCredentials: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("secretStoreBasedAuthCredentials")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials? SecretStoreBasedAuthCredentials { get; set; }
}

/// <summary>
/// IdentityDetails: Contains information of the Identity Details for the BI.
/// If it is null, default will be considered as System Assigned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesIdentityDetails
{
    /// <summary>UseSystemAssignedIdentity: Specifies if the BI is protected by System Identity.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>UserAssignedIdentityArmUrl: ARM URL for User Assigned Identity.</summary>
    [JsonPropertyName("userAssignedIdentityArmUrl")]
    public string? UserAssignedIdentityArmUrl { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParametersObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParametersObjectTypeEnum
{
    [EnumMember(Value = "BlobBackupDatasourceParameters"), JsonStringEnumMemberName("BlobBackupDatasourceParameters")]
    BlobBackupDatasourceParameters
}

/// <summary>Blob: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters
{
    /// <summary>ContainersList: List of containers to be backed up during configuration of backup of blobs</summary>
    [JsonPropertyName("containersList")]
    public required IList<string> ContainersList { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParametersObjectTypeEnum ObjectType { get; set; }
}

/// <summary>Class to refer resources which contains namespace and name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences
{
    /// <summary>Name: Name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: Namespace in which the resource exists</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersObjectTypeEnum
{
    [EnumMember(Value = "KubernetesClusterBackupDatasourceParameters"), JsonStringEnumMemberName("KubernetesClusterBackupDatasourceParameters")]
    KubernetesClusterBackupDatasourceParameters
}

/// <summary>KubernetesCluster: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters
{
    /// <summary>
    /// BackupHookReferences: Gets or sets the backup hook references. This property sets the hook reference to be executed
    /// during backup.
    /// </summary>
    [JsonPropertyName("backupHookReferences")]
    public IList<V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences>? BackupHookReferences { get; set; }

    /// <summary>
    /// ExcludedNamespaces: Gets or sets the exclude namespaces property. This property sets the namespaces to be excluded
    /// during backup.
    /// </summary>
    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    /// <summary>
    /// ExcludedResourceTypes: Gets or sets the exclude resource types property. This property sets the resource types to be
    /// excluded during backup.
    /// </summary>
    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    /// <summary>
    /// IncludeClusterScopeResources: Gets or sets the include cluster resources property. This property if enabled will include
    /// cluster scope resources during backup.
    /// </summary>
    [JsonPropertyName("includeClusterScopeResources")]
    public required bool IncludeClusterScopeResources { get; set; }

    /// <summary>
    /// IncludedNamespaces: Gets or sets the include namespaces property. This property sets the namespaces to be included
    /// during backup.
    /// </summary>
    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    /// <summary>
    /// IncludedResourceTypes: Gets or sets the include resource types property. This property sets the resource types to be
    /// included during backup.
    /// </summary>
    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    /// <summary>
    /// LabelSelectors: Gets or sets the LabelSelectors property. This property sets the resource with such label selectors to
    /// be included during backup.
    /// </summary>
    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersObjectTypeEnum ObjectType { get; set; }

    /// <summary>
    /// SnapshotVolumes: Gets or sets the volume snapshot property. This property if enabled will take volume snapshots during
    /// backup.
    /// </summary>
    [JsonPropertyName("snapshotVolumes")]
    public required bool SnapshotVolumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList
{
    /// <summary>Blob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("blobBackupDatasourceParameters")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters? BlobBackupDatasourceParameters { get; set; }

    /// <summary>KubernetesCluster: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("kubernetesClusterBackupDatasourceParameters")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters? KubernetesClusterBackupDatasourceParameters { get; set; }
}

/// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersDataStoreTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersDataStoreTypeEnum
{
    [EnumMember(Value = "ArchiveStore"), JsonStringEnumMemberName("ArchiveStore")]
    ArchiveStore,
    [EnumMember(Value = "OperationalStore"), JsonStringEnumMemberName("OperationalStore")]
    OperationalStore,
    [EnumMember(Value = "VaultStore"), JsonStringEnumMemberName("VaultStore")]
    VaultStore
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersObjectTypeEnum
{
    [EnumMember(Value = "AzureOperationalStoreParameters"), JsonStringEnumMemberName("AzureOperationalStoreParameters")]
    AzureOperationalStoreParameters
}

/// <summary>ResourceGroupReference: Gets or sets the Snapshot Resource Group Uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersResourceGroupReference
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

/// <summary>AzureOperationalStoreParameters: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersDataStoreTypeEnum DataStoreType { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersObjectTypeEnum ObjectType { get; set; }

    /// <summary>ResourceGroupReference: Gets or sets the Snapshot Resource Group Uri.</summary>
    [JsonPropertyName("resourceGroupReference")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersResourceGroupReference? ResourceGroupReference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersList
{
    /// <summary>AzureOperationalStoreParameters: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureOperationalStoreParameters")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters? AzureOperationalStoreParameters { get; set; }
}

/// <summary>PolicyParameters: Policy parameters for the backup instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParameters
{
    /// <summary>BackupDatasourceParametersList: Gets or sets the Backup Data Source Parameters</summary>
    [JsonPropertyName("backupDatasourceParametersList")]
    public IList<V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList>? BackupDatasourceParametersList { get; set; }

    /// <summary>DataStoreParametersList: Gets or sets the DataStore Parameters</summary>
    [JsonPropertyName("dataStoreParametersList")]
    public IList<V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersList>? DataStoreParametersList { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyReference
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

/// <summary>PolicyInfo: Gets or sets the policy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfo
{
    /// <summary>PolicyParameters: Policy parameters for the backup instance</summary>
    [JsonPropertyName("policyParameters")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParameters? PolicyParameters { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("policyReference")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyReference PolicyReference { get; set; }
}

/// <summary>
/// ValidationType: Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API
/// will run again.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupInstanceSpecPropertiesValidationTypeEnum>))]
public enum V1api20231101BackupVaultsBackupInstanceSpecPropertiesValidationTypeEnum
{
    [EnumMember(Value = "DeepValidation"), JsonStringEnumMemberName("DeepValidation")]
    DeepValidation,
    [EnumMember(Value = "ShallowValidation"), JsonStringEnumMemberName("ShallowValidation")]
    ShallowValidation
}

/// <summary>Properties: BackupInstanceResource properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpecProperties
{
    /// <summary>DataSourceInfo: Gets or sets the data source information.</summary>
    [JsonPropertyName("dataSourceInfo")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceInfo DataSourceInfo { get; set; }

    /// <summary>DataSourceSetInfo: Gets or sets the data source set information.</summary>
    [JsonPropertyName("dataSourceSetInfo")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfo? DataSourceSetInfo { get; set; }

    /// <summary>DatasourceAuthCredentials: Credentials to use to authenticate with data source provider.</summary>
    [JsonPropertyName("datasourceAuthCredentials")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentials? DatasourceAuthCredentials { get; set; }

    /// <summary>FriendlyName: Gets or sets the Backup Instance friendly name.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>
    /// IdentityDetails: Contains information of the Identity Details for the BI.
    /// If it is null, default will be considered as System Assigned.
    /// </summary>
    [JsonPropertyName("identityDetails")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesIdentityDetails? IdentityDetails { get; set; }

    [JsonPropertyName("objectType")]
    public required string ObjectType { get; set; }

    /// <summary>PolicyInfo: Gets or sets the policy information.</summary>
    [JsonPropertyName("policyInfo")]
    public required V1api20231101BackupVaultsBackupInstanceSpecPropertiesPolicyInfo PolicyInfo { get; set; }

    /// <summary>
    /// ValidationType: Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API
    /// will run again.
    /// </summary>
    [JsonPropertyName("validationType")]
    public V1api20231101BackupVaultsBackupInstanceSpecPropertiesValidationTypeEnum? ValidationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231101BackupVaultsBackupInstanceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a dataprotection.azure.com/BackupVault resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231101BackupVaultsBackupInstanceSpecOwner Owner { get; set; }

    /// <summary>Properties: BackupInstanceResource properties</summary>
    [JsonPropertyName("properties")]
    public V1api20231101BackupVaultsBackupInstanceSpecProperties? Properties { get; set; }

    /// <summary>Tags: Proxy Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusConditions
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

/// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>ResourceProperties: Properties specific to data source</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourceProperties
{
    /// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>DataSourceInfo: Gets or sets the data source information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceInfo
{
    /// <summary>DatasourceType: DatasourceType of the resource.</summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// ResourceID: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the
    /// ID created by backup service via Fabric/Vault.
    /// </summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>ResourceLocation: Location of datasource.</summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary>ResourceName: Unique identifier of the resource in the context of parent.</summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>ResourceProperties: Properties specific to data source</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>ResourceType: Resource Type of Datasource.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>ResourceUri: Uri of the resource.</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>ResourceProperties: Properties specific to data source set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourceProperties
{
    /// <summary>DefaultResourceProperties: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>DataSourceSetInfo: Gets or sets the data source set information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfo
{
    /// <summary>DatasourceType: DatasourceType of the resource.</summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// ResourceID: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the
    /// ID created by backup service via Fabric/Vault.
    /// </summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>ResourceLocation: Location of datasource.</summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary>ResourceName: Unique identifier of the resource in the context of parent.</summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>ResourceProperties: Properties specific to data source set</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>ResourceType: Resource Type of Datasource.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>ResourceUri: Uri of the resource.</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>SecretStoreResource: Secret store resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource
{
    /// <summary>SecretStoreType: Gets or sets the type of secret store</summary>
    [JsonPropertyName("secretStoreType")]
    public string? SecretStoreType { get; set; }

    /// <summary>Uri: Uri to get to the resource</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Value: Gets or sets value stored in secret store resource</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SecretStoreBasedAuthCredentials: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>SecretStoreResource: Secret store resource</summary>
    [JsonPropertyName("secretStoreResource")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource? SecretStoreResource { get; set; }
}

/// <summary>DatasourceAuthCredentials: Credentials to use to authenticate with data source provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentials
{
    /// <summary>SecretStoreBasedAuthCredentials: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("secretStoreBasedAuthCredentials")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials? SecretStoreBasedAuthCredentials { get; set; }
}

/// <summary>
/// IdentityDetails: Contains information of the Identity Details for the BI.
/// If it is null, default will be considered as System Assigned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesIdentityDetails
{
    /// <summary>UseSystemAssignedIdentity: Specifies if the BI is protected by System Identity.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>UserAssignedIdentityArmUrl: ARM URL for User Assigned Identity.</summary>
    [JsonPropertyName("userAssignedIdentityArmUrl")]
    public string? UserAssignedIdentityArmUrl { get; set; }
}

/// <summary>Blob: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters
{
    /// <summary>ContainersList: List of containers to be backed up during configuration of backup of blobs</summary>
    [JsonPropertyName("containersList")]
    public IList<string>? ContainersList { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Class to refer resources which contains namespace and name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences
{
    /// <summary>Name: Name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: Namespace in which the resource exists</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>KubernetesCluster: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters
{
    /// <summary>
    /// BackupHookReferences: Gets or sets the backup hook references. This property sets the hook reference to be executed
    /// during backup.
    /// </summary>
    [JsonPropertyName("backupHookReferences")]
    public IList<V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences>? BackupHookReferences { get; set; }

    /// <summary>
    /// ExcludedNamespaces: Gets or sets the exclude namespaces property. This property sets the namespaces to be excluded
    /// during backup.
    /// </summary>
    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    /// <summary>
    /// ExcludedResourceTypes: Gets or sets the exclude resource types property. This property sets the resource types to be
    /// excluded during backup.
    /// </summary>
    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    /// <summary>
    /// IncludeClusterScopeResources: Gets or sets the include cluster resources property. This property if enabled will include
    /// cluster scope resources during backup.
    /// </summary>
    [JsonPropertyName("includeClusterScopeResources")]
    public bool? IncludeClusterScopeResources { get; set; }

    /// <summary>
    /// IncludedNamespaces: Gets or sets the include namespaces property. This property sets the namespaces to be included
    /// during backup.
    /// </summary>
    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    /// <summary>
    /// IncludedResourceTypes: Gets or sets the include resource types property. This property sets the resource types to be
    /// included during backup.
    /// </summary>
    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    /// <summary>
    /// LabelSelectors: Gets or sets the LabelSelectors property. This property sets the resource with such label selectors to
    /// be included during backup.
    /// </summary>
    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// SnapshotVolumes: Gets or sets the volume snapshot property. This property if enabled will take volume snapshots during
    /// backup.
    /// </summary>
    [JsonPropertyName("snapshotVolumes")]
    public bool? SnapshotVolumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList
{
    /// <summary>Blob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("blobBackupDatasourceParameters")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters? BlobBackupDatasourceParameters { get; set; }

    /// <summary>KubernetesCluster: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("kubernetesClusterBackupDatasourceParameters")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters? KubernetesClusterBackupDatasourceParameters { get; set; }
}

/// <summary>AzureOperationalStoreParameters: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>ResourceGroupId: Gets or sets the Snapshot Resource Group Uri.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersList
{
    /// <summary>AzureOperationalStoreParameters: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureOperationalStoreParameters")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters? AzureOperationalStoreParameters { get; set; }
}

/// <summary>PolicyParameters: Policy parameters for the backup instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParameters
{
    /// <summary>BackupDatasourceParametersList: Gets or sets the Backup Data Source Parameters</summary>
    [JsonPropertyName("backupDatasourceParametersList")]
    public IList<V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList>? BackupDatasourceParametersList { get; set; }

    /// <summary>DataStoreParametersList: Gets or sets the DataStore Parameters</summary>
    [JsonPropertyName("dataStoreParametersList")]
    public IList<V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersList>? DataStoreParametersList { get; set; }
}

/// <summary>PolicyInfo: Gets or sets the policy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfo
{
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>PolicyParameters: Policy parameters for the backup instance</summary>
    [JsonPropertyName("policyParameters")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParameters? PolicyParameters { get; set; }

    [JsonPropertyName("policyVersion")]
    public string? PolicyVersion { get; set; }
}

/// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>InnerError: Inner Error</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetails
{
    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>InnerError: Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerError? InnerError { get; set; }

    /// <summary>IsRetryable: Whether the operation will be retryable or not</summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary>IsUserError: Whether the operation is due to a user error or service error</summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Properties: Any key value pairs that can be injected inside error object</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>RecommendedAction: RecommendedAction � localized.</summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary>Target: Target of the error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>InnerError: Inner Error</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>ProtectionErrorDetails: Specifies the protection error of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetails
{
    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: Additional related Errors</summary>
    [JsonPropertyName("details")]
    public IList<V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetails>? Details { get; set; }

    /// <summary>InnerError: Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerError? InnerError { get; set; }

    /// <summary>IsRetryable: Whether the operation will be retryable or not</summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary>IsUserError: Whether the operation is due to a user error or service error</summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Properties: Any key value pairs that can be injected inside error object</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>RecommendedAction: RecommendedAction � localized.</summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary>Target: Target of the error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>InnerError: Inner Error</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetails
{
    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>InnerError: Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerError? InnerError { get; set; }

    /// <summary>IsRetryable: Whether the operation will be retryable or not</summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary>IsUserError: Whether the operation is due to a user error or service error</summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Properties: Any key value pairs that can be injected inside error object</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>RecommendedAction: RecommendedAction � localized.</summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary>Target: Target of the error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>InnerError: Inner Error</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerError
{
    /// <summary>AdditionalInfo: Any Key value pairs that can be provided to the client for additional  verbose information.</summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>EmbeddedInnerError: Child Inner Error, to allow Nesting.</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>ErrorDetails: Specifies the protection status error of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetails
{
    /// <summary>Code: Unique code for this error</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: Additional related Errors</summary>
    [JsonPropertyName("details")]
    public IList<V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetails>? Details { get; set; }

    /// <summary>InnerError: Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerError? InnerError { get; set; }

    /// <summary>IsRetryable: Whether the operation will be retryable or not</summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary>IsUserError: Whether the operation is due to a user error or service error</summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Properties: Any key value pairs that can be injected inside error object</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>RecommendedAction: RecommendedAction � localized.</summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary>Target: Target of the error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>ProtectionStatus: Specifies the protection status of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatus
{
    /// <summary>ErrorDetails: Specifies the protection status error of the resource</summary>
    [JsonPropertyName("errorDetails")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetails? ErrorDetails { get; set; }

    /// <summary>Status: Specifies the protection status of the resource</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Properties: BackupInstanceResource properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusProperties
{
    /// <summary>CurrentProtectionState: Specifies the current protection state of the resource</summary>
    [JsonPropertyName("currentProtectionState")]
    public string? CurrentProtectionState { get; set; }

    /// <summary>DataSourceInfo: Gets or sets the data source information.</summary>
    [JsonPropertyName("dataSourceInfo")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceInfo? DataSourceInfo { get; set; }

    /// <summary>DataSourceSetInfo: Gets or sets the data source set information.</summary>
    [JsonPropertyName("dataSourceSetInfo")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfo? DataSourceSetInfo { get; set; }

    /// <summary>DatasourceAuthCredentials: Credentials to use to authenticate with data source provider.</summary>
    [JsonPropertyName("datasourceAuthCredentials")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentials? DatasourceAuthCredentials { get; set; }

    /// <summary>FriendlyName: Gets or sets the Backup Instance friendly name.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>
    /// IdentityDetails: Contains information of the Identity Details for the BI.
    /// If it is null, default will be considered as System Assigned.
    /// </summary>
    [JsonPropertyName("identityDetails")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesIdentityDetails? IdentityDetails { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>PolicyInfo: Gets or sets the policy information.</summary>
    [JsonPropertyName("policyInfo")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesPolicyInfo? PolicyInfo { get; set; }

    /// <summary>ProtectionErrorDetails: Specifies the protection error of the resource</summary>
    [JsonPropertyName("protectionErrorDetails")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetails? ProtectionErrorDetails { get; set; }

    /// <summary>ProtectionStatus: Specifies the protection status of the resource</summary>
    [JsonPropertyName("protectionStatus")]
    public V1api20231101BackupVaultsBackupInstanceStatusPropertiesProtectionStatus? ProtectionStatus { get; set; }

    /// <summary>ProvisioningState: Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// ValidationType: Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API
    /// will run again.
    /// </summary>
    [JsonPropertyName("validationType")]
    public string? ValidationType { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupInstanceStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231101BackupVaultsBackupInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Id: Proxy Resource Id represents the complete path to the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Proxy Resource name associated with the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: BackupInstanceResource properties</summary>
    [JsonPropertyName("properties")]
    public V1api20231101BackupVaultsBackupInstanceStatusProperties? Properties { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231101BackupVaultsBackupInstanceStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Proxy Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Proxy Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101BackupVaultsBackupInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101BackupVaultsBackupInstanceSpec?>, IStatus<V1api20231101BackupVaultsBackupInstanceStatus?>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "BackupVaultsBackupInstance";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackupinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231101BackupVaultsBackupInstanceSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20231101BackupVaultsBackupInstanceStatus? Status { get; set; }
}
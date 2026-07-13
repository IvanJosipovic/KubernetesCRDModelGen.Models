#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/file.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220901StorageAccountsFileServiceList : IKubernetesObject<V1ListMeta>, IItems<V20220901StorageAccountsFileService>
{
    public const string KubeApiVersion = "v20220901";
    public const string KubeKind = "StorageAccountsFileServiceList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20220901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220901StorageAccountsFileService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220901StorageAccountsFileService> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220901StorageAccountsFileServiceSpecCorsCorsRulesAllowedMethodsEnum>))]
public enum V20220901StorageAccountsFileServiceSpecCorsCorsRulesAllowedMethodsEnum
{
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE,
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "MERGE"), JsonStringEnumMemberName("MERGE")]
    MERGE,
    [EnumMember(Value = "OPTIONS"), JsonStringEnumMemberName("OPTIONS")]
    OPTIONS,
    [EnumMember(Value = "PATCH"), JsonStringEnumMemberName("PATCH")]
    PATCH,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST,
    [EnumMember(Value = "PUT"), JsonStringEnumMemberName("PUT")]
    PUT
}

/// <summary>Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecCorsCorsRules
{
    /// <summary>
    /// AllowedHeaders: Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin
    /// request.
    /// </summary>
    [JsonPropertyName("allowedHeaders")]
    public required IList<string> AllowedHeaders { get; set; }

    /// <summary>
    /// AllowedMethods: Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the
    /// origin.
    /// </summary>
    [JsonPropertyName("allowedMethods")]
    public required IList<V20220901StorageAccountsFileServiceSpecCorsCorsRulesAllowedMethodsEnum> AllowedMethods { get; set; }

    /// <summary>
    /// AllowedOrigins: Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or &quot;*&quot;
    /// to allow all domains
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public required IList<string> AllowedOrigins { get; set; }

    /// <summary>ExposedHeaders: Required if CorsRule element is present. A list of response headers to expose to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public required IList<string> ExposedHeaders { get; set; }

    /// <summary>
    /// MaxAgeInSeconds: Required if CorsRule element is present. The number of seconds that the client/browser should cache a
    /// preflight response.
    /// </summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public required int MaxAgeInSeconds { get; set; }
}

/// <summary>
/// Cors: Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no
/// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
/// File service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecCors
{
    /// <summary>CorsRules: The List of CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("corsRules")]
    public IList<V20220901StorageAccountsFileServiceSpecCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecOperatorSpecConfigMapExpressions
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
public partial class V20220901StorageAccountsFileServiceSpecOperatorSpecSecretExpressions
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
public partial class V20220901StorageAccountsFileServiceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20220901StorageAccountsFileServiceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20220901StorageAccountsFileServiceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccount resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Multichannel: Multichannel setting. Applies to Premium FileStorage only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecProtocolSettingsSmbMultichannel
{
    /// <summary>Enabled: Indicates whether multichannel is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Smb: Setting for SMB protocol</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecProtocolSettingsSmb
{
    /// <summary>
    /// AuthenticationMethods: SMB authentication methods supported by server. Valid values are NTLMv2, Kerberos. Should be
    /// passed as a string with delimiter &apos;;&apos;.
    /// </summary>
    [JsonPropertyName("authenticationMethods")]
    public string? AuthenticationMethods { get; set; }

    /// <summary>
    /// ChannelEncryption: SMB channel encryption supported by server. Valid values are AES-128-CCM, AES-128-GCM, AES-256-GCM.
    /// Should be passed as a string with delimiter &apos;;&apos;.
    /// </summary>
    [JsonPropertyName("channelEncryption")]
    public string? ChannelEncryption { get; set; }

    /// <summary>
    /// KerberosTicketEncryption: Kerberos ticket encryption supported by server. Valid values are RC4-HMAC, AES-256. Should be
    /// passed as a string with delimiter &apos;;&apos;
    /// </summary>
    [JsonPropertyName("kerberosTicketEncryption")]
    public string? KerberosTicketEncryption { get; set; }

    /// <summary>Multichannel: Multichannel setting. Applies to Premium FileStorage only.</summary>
    [JsonPropertyName("multichannel")]
    public V20220901StorageAccountsFileServiceSpecProtocolSettingsSmbMultichannel? Multichannel { get; set; }

    /// <summary>
    /// Versions: SMB protocol versions supported by server. Valid values are SMB2.1, SMB3.0, SMB3.1.1. Should be passed as a
    /// string with delimiter &apos;;&apos;.
    /// </summary>
    [JsonPropertyName("versions")]
    public string? Versions { get; set; }
}

/// <summary>ProtocolSettings: Protocol settings for file service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecProtocolSettings
{
    /// <summary>Smb: Setting for SMB protocol</summary>
    [JsonPropertyName("smb")]
    public V20220901StorageAccountsFileServiceSpecProtocolSettingsSmb? Smb { get; set; }
}

/// <summary>ShareDeleteRetentionPolicy: The file service properties for share soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpecShareDeleteRetentionPolicy
{
    /// <summary>
    /// AllowPermanentDelete: This property when set to true allows deletion of the soft deleted blob versions and snapshots.
    /// This property cannot be used blob restore policy. This property only applies to blob service and does not apply to
    /// containers or file share.
    /// </summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary>
    /// Days: Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and
    /// the maximum value can be 365.
    /// </summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>Enabled: Indicates whether DeleteRetentionPolicy is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceSpec
{
    /// <summary>
    /// Cors: Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no
    /// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
    /// File service.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20220901StorageAccountsFileServiceSpecCors? Cors { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220901StorageAccountsFileServiceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccount resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220901StorageAccountsFileServiceSpecOwner Owner { get; set; }

    /// <summary>ProtocolSettings: Protocol settings for file service</summary>
    [JsonPropertyName("protocolSettings")]
    public V20220901StorageAccountsFileServiceSpecProtocolSettings? ProtocolSettings { get; set; }

    /// <summary>ShareDeleteRetentionPolicy: The file service properties for share soft delete.</summary>
    [JsonPropertyName("shareDeleteRetentionPolicy")]
    public V20220901StorageAccountsFileServiceSpecShareDeleteRetentionPolicy? ShareDeleteRetentionPolicy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusConditions
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

/// <summary>Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusCorsCorsRules
{
    /// <summary>
    /// AllowedHeaders: Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin
    /// request.
    /// </summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// AllowedMethods: Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the
    /// origin.
    /// </summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>
    /// AllowedOrigins: Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or &quot;*&quot;
    /// to allow all domains
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>ExposedHeaders: Required if CorsRule element is present. A list of response headers to expose to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>
    /// MaxAgeInSeconds: Required if CorsRule element is present. The number of seconds that the client/browser should cache a
    /// preflight response.
    /// </summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>
/// Cors: Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no
/// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
/// File service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusCors
{
    /// <summary>CorsRules: The List of CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("corsRules")]
    public IList<V20220901StorageAccountsFileServiceStatusCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>Multichannel: Multichannel setting. Applies to Premium FileStorage only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusProtocolSettingsSmbMultichannel
{
    /// <summary>Enabled: Indicates whether multichannel is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Smb: Setting for SMB protocol</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusProtocolSettingsSmb
{
    /// <summary>
    /// AuthenticationMethods: SMB authentication methods supported by server. Valid values are NTLMv2, Kerberos. Should be
    /// passed as a string with delimiter &apos;;&apos;.
    /// </summary>
    [JsonPropertyName("authenticationMethods")]
    public string? AuthenticationMethods { get; set; }

    /// <summary>
    /// ChannelEncryption: SMB channel encryption supported by server. Valid values are AES-128-CCM, AES-128-GCM, AES-256-GCM.
    /// Should be passed as a string with delimiter &apos;;&apos;.
    /// </summary>
    [JsonPropertyName("channelEncryption")]
    public string? ChannelEncryption { get; set; }

    /// <summary>
    /// KerberosTicketEncryption: Kerberos ticket encryption supported by server. Valid values are RC4-HMAC, AES-256. Should be
    /// passed as a string with delimiter &apos;;&apos;
    /// </summary>
    [JsonPropertyName("kerberosTicketEncryption")]
    public string? KerberosTicketEncryption { get; set; }

    /// <summary>Multichannel: Multichannel setting. Applies to Premium FileStorage only.</summary>
    [JsonPropertyName("multichannel")]
    public V20220901StorageAccountsFileServiceStatusProtocolSettingsSmbMultichannel? Multichannel { get; set; }

    /// <summary>
    /// Versions: SMB protocol versions supported by server. Valid values are SMB2.1, SMB3.0, SMB3.1.1. Should be passed as a
    /// string with delimiter &apos;;&apos;.
    /// </summary>
    [JsonPropertyName("versions")]
    public string? Versions { get; set; }
}

/// <summary>ProtocolSettings: Protocol settings for file service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusProtocolSettings
{
    /// <summary>Smb: Setting for SMB protocol</summary>
    [JsonPropertyName("smb")]
    public V20220901StorageAccountsFileServiceStatusProtocolSettingsSmb? Smb { get; set; }
}

/// <summary>ShareDeleteRetentionPolicy: The file service properties for share soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusShareDeleteRetentionPolicy
{
    /// <summary>
    /// AllowPermanentDelete: This property when set to true allows deletion of the soft deleted blob versions and snapshots.
    /// This property cannot be used blob restore policy. This property only applies to blob service and does not apply to
    /// containers or file share.
    /// </summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary>
    /// Days: Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and
    /// the maximum value can be 365.
    /// </summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>Enabled: Indicates whether DeleteRetentionPolicy is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Sku: Sku name and tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatusSku
{
    /// <summary>
    /// Name: The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called
    ///  accountType.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The SKU tier. This is based on the SKU name.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsFileServiceStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20220901StorageAccountsFileServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Cors: Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no
    /// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
    /// File service.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20220901StorageAccountsFileServiceStatusCors? Cors { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProtocolSettings: Protocol settings for file service</summary>
    [JsonPropertyName("protocolSettings")]
    public V20220901StorageAccountsFileServiceStatusProtocolSettings? ProtocolSettings { get; set; }

    /// <summary>ShareDeleteRetentionPolicy: The file service properties for share soft delete.</summary>
    [JsonPropertyName("shareDeleteRetentionPolicy")]
    public V20220901StorageAccountsFileServiceStatusShareDeleteRetentionPolicy? ShareDeleteRetentionPolicy { get; set; }

    /// <summary>Sku: Sku name and tier.</summary>
    [JsonPropertyName("sku")]
    public V20220901StorageAccountsFileServiceStatusSku? Sku { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/file.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220901StorageAccountsFileService : IKubernetesObject<V1ObjectMeta>, ISpec<V20220901StorageAccountsFileServiceSpec?>, IStatus<V20220901StorageAccountsFileServiceStatus?>
{
    public const string KubeApiVersion = "v20220901";
    public const string KubeKind = "StorageAccountsFileService";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20220901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20220901StorageAccountsFileServiceSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20220901StorageAccountsFileServiceStatus? Status { get; set; }
}
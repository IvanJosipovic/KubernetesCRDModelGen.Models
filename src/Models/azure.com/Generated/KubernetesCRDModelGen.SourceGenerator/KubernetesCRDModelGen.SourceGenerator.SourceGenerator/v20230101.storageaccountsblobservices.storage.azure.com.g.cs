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
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/blob.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230101StorageAccountsBlobServiceList : IKubernetesObject<V1ListMeta>, IItems<V20230101StorageAccountsBlobService>
{
    public const string KubeApiVersion = "v20230101";
    public const string KubeKind = "StorageAccountsBlobServiceList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20230101StorageAccountsBlobService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20230101StorageAccountsBlobService> Items { get; set; }
}

/// <summary>ChangeFeed: The blob service properties for change feed events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecChangeFeed
{
    /// <summary>Enabled: Indicates whether change feed event logging is enabled for the Blob service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RetentionInDays: Indicates the duration of changeFeed retention in days. Minimum value is 1 day and maximum value is
    /// 146000 days (400 years). A null value indicates an infinite retention of the change feed.
    /// </summary>
    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }
}

/// <summary>ContainerDeleteRetentionPolicy: The blob service properties for container soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecContainerDeleteRetentionPolicy
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20230101StorageAccountsBlobServiceSpecCorsCorsRulesAllowedMethodsEnum>))]
public enum V20230101StorageAccountsBlobServiceSpecCorsCorsRulesAllowedMethodsEnum
{
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
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
    PUT,
    [EnumMember(Value = "TRACE"), JsonStringEnumMemberName("TRACE")]
    TRACE
}

/// <summary>Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecCorsCorsRules
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
    public required IList<V20230101StorageAccountsBlobServiceSpecCorsCorsRulesAllowedMethodsEnum> AllowedMethods { get; set; }

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
/// Cors: Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no
/// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
/// Blob service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecCors
{
    /// <summary>CorsRules: The List of CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("corsRules")]
    public IList<V20230101StorageAccountsBlobServiceSpecCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>DeleteRetentionPolicy: The blob service properties for blob soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecDeleteRetentionPolicy
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

/// <summary>Name: Name of the policy. The valid value is AccessTimeTracking. This field is currently read only</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20230101StorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicyNameEnum>))]
public enum V20230101StorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicyNameEnum
{
    [EnumMember(Value = "AccessTimeTracking"), JsonStringEnumMemberName("AccessTimeTracking")]
    AccessTimeTracking
}

/// <summary>LastAccessTimeTrackingPolicy: The blob service property to configure last access time based tracking policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicy
{
    /// <summary>
    /// BlobType: An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently
    /// read only
    /// </summary>
    [JsonPropertyName("blobType")]
    public IList<string>? BlobType { get; set; }

    /// <summary>Enable: When set to true last access time based tracking is enabled.</summary>
    [JsonPropertyName("enable")]
    public required bool Enable { get; set; }

    /// <summary>Name: Name of the policy. The valid value is AccessTimeTracking. This field is currently read only</summary>
    [JsonPropertyName("name")]
    public V20230101StorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicyNameEnum? Name { get; set; }

    /// <summary>
    /// TrackingGranularityInDays: The field specifies blob object tracking granularity in days, typically how often the blob
    /// object should be tracked.This field is currently read only with value as 1
    /// </summary>
    [JsonPropertyName("trackingGranularityInDays")]
    public int? TrackingGranularityInDays { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecOperatorSpecConfigMapExpressions
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
public partial class V20230101StorageAccountsBlobServiceSpecOperatorSpecSecretExpressions
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
public partial class V20230101StorageAccountsBlobServiceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20230101StorageAccountsBlobServiceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20230101StorageAccountsBlobServiceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccount resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RestorePolicy: The blob service properties for blob restore policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpecRestorePolicy
{
    /// <summary>Days: how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.</summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>Enabled: Blob restore is enabled if set to true.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceSpec
{
    /// <summary>AutomaticSnapshotPolicyEnabled: Deprecated in favor of isVersioningEnabled property.</summary>
    [JsonPropertyName("automaticSnapshotPolicyEnabled")]
    public bool? AutomaticSnapshotPolicyEnabled { get; set; }

    /// <summary>ChangeFeed: The blob service properties for change feed events.</summary>
    [JsonPropertyName("changeFeed")]
    public V20230101StorageAccountsBlobServiceSpecChangeFeed? ChangeFeed { get; set; }

    /// <summary>ContainerDeleteRetentionPolicy: The blob service properties for container soft delete.</summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public V20230101StorageAccountsBlobServiceSpecContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>
    /// Cors: Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no
    /// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
    /// Blob service.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20230101StorageAccountsBlobServiceSpecCors? Cors { get; set; }

    /// <summary>
    /// DefaultServiceVersion: DefaultServiceVersion indicates the default version to use for requests to the Blob service if an
    /// incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
    /// </summary>
    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>DeleteRetentionPolicy: The blob service properties for blob soft delete.</summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public V20230101StorageAccountsBlobServiceSpecDeleteRetentionPolicy? DeleteRetentionPolicy { get; set; }

    /// <summary>IsVersioningEnabled: Versioning is enabled if set to true.</summary>
    [JsonPropertyName("isVersioningEnabled")]
    public bool? IsVersioningEnabled { get; set; }

    /// <summary>LastAccessTimeTrackingPolicy: The blob service property to configure last access time based tracking policy.</summary>
    [JsonPropertyName("lastAccessTimeTrackingPolicy")]
    public V20230101StorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicy? LastAccessTimeTrackingPolicy { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20230101StorageAccountsBlobServiceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccount resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20230101StorageAccountsBlobServiceSpecOwner Owner { get; set; }

    /// <summary>RestorePolicy: The blob service properties for blob restore policy.</summary>
    [JsonPropertyName("restorePolicy")]
    public V20230101StorageAccountsBlobServiceSpecRestorePolicy? RestorePolicy { get; set; }
}

/// <summary>ChangeFeed: The blob service properties for change feed events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusChangeFeed
{
    /// <summary>Enabled: Indicates whether change feed event logging is enabled for the Blob service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RetentionInDays: Indicates the duration of changeFeed retention in days. Minimum value is 1 day and maximum value is
    /// 146000 days (400 years). A null value indicates an infinite retention of the change feed.
    /// </summary>
    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusConditions
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

/// <summary>ContainerDeleteRetentionPolicy: The blob service properties for container soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusContainerDeleteRetentionPolicy
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

/// <summary>Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusCorsCorsRules
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
/// Cors: Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no
/// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
/// Blob service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusCors
{
    /// <summary>CorsRules: The List of CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("corsRules")]
    public IList<V20230101StorageAccountsBlobServiceStatusCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>DeleteRetentionPolicy: The blob service properties for blob soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusDeleteRetentionPolicy
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

/// <summary>LastAccessTimeTrackingPolicy: The blob service property to configure last access time based tracking policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusLastAccessTimeTrackingPolicy
{
    /// <summary>
    /// BlobType: An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently
    /// read only
    /// </summary>
    [JsonPropertyName("blobType")]
    public IList<string>? BlobType { get; set; }

    /// <summary>Enable: When set to true last access time based tracking is enabled.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Name: Name of the policy. The valid value is AccessTimeTracking. This field is currently read only</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// TrackingGranularityInDays: The field specifies blob object tracking granularity in days, typically how often the blob
    /// object should be tracked.This field is currently read only with value as 1
    /// </summary>
    [JsonPropertyName("trackingGranularityInDays")]
    public int? TrackingGranularityInDays { get; set; }
}

/// <summary>RestorePolicy: The blob service properties for blob restore policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusRestorePolicy
{
    /// <summary>Days: how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.</summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>Enabled: Blob restore is enabled if set to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>LastEnabledTime: Deprecated in favor of minRestoreTime property.</summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }

    /// <summary>MinRestoreTime: Returns the minimum date and time that the restore can be started.</summary>
    [JsonPropertyName("minRestoreTime")]
    public string? MinRestoreTime { get; set; }
}

/// <summary>Sku: Sku name and tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatusSku
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsBlobServiceStatus
{
    /// <summary>AutomaticSnapshotPolicyEnabled: Deprecated in favor of isVersioningEnabled property.</summary>
    [JsonPropertyName("automaticSnapshotPolicyEnabled")]
    public bool? AutomaticSnapshotPolicyEnabled { get; set; }

    /// <summary>ChangeFeed: The blob service properties for change feed events.</summary>
    [JsonPropertyName("changeFeed")]
    public V20230101StorageAccountsBlobServiceStatusChangeFeed? ChangeFeed { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20230101StorageAccountsBlobServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ContainerDeleteRetentionPolicy: The blob service properties for container soft delete.</summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public V20230101StorageAccountsBlobServiceStatusContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>
    /// Cors: Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no
    /// CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the
    /// Blob service.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20230101StorageAccountsBlobServiceStatusCors? Cors { get; set; }

    /// <summary>
    /// DefaultServiceVersion: DefaultServiceVersion indicates the default version to use for requests to the Blob service if an
    /// incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
    /// </summary>
    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>DeleteRetentionPolicy: The blob service properties for blob soft delete.</summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public V20230101StorageAccountsBlobServiceStatusDeleteRetentionPolicy? DeleteRetentionPolicy { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsVersioningEnabled: Versioning is enabled if set to true.</summary>
    [JsonPropertyName("isVersioningEnabled")]
    public bool? IsVersioningEnabled { get; set; }

    /// <summary>LastAccessTimeTrackingPolicy: The blob service property to configure last access time based tracking policy.</summary>
    [JsonPropertyName("lastAccessTimeTrackingPolicy")]
    public V20230101StorageAccountsBlobServiceStatusLastAccessTimeTrackingPolicy? LastAccessTimeTrackingPolicy { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RestorePolicy: The blob service properties for blob restore policy.</summary>
    [JsonPropertyName("restorePolicy")]
    public V20230101StorageAccountsBlobServiceStatusRestorePolicy? RestorePolicy { get; set; }

    /// <summary>Sku: Sku name and tier.</summary>
    [JsonPropertyName("sku")]
    public V20230101StorageAccountsBlobServiceStatusSku? Sku { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/blob.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230101StorageAccountsBlobService : IKubernetesObject<V1ObjectMeta>, ISpec<V20230101StorageAccountsBlobServiceSpec?>, IStatus<V20230101StorageAccountsBlobServiceStatus?>
{
    public const string KubeApiVersion = "v20230101";
    public const string KubeKind = "StorageAccountsBlobService";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20230101StorageAccountsBlobServiceSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20230101StorageAccountsBlobServiceStatus? Status { get; set; }
}
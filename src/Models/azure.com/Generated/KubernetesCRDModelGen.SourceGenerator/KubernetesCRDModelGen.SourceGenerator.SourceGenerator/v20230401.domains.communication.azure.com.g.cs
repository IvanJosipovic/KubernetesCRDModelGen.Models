#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.communication.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /communication/resource-manager/Microsoft.Communication/stable/2023-04-01/Domains.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230401DomainList : IKubernetesObject<V1ListMeta>, IItems<V20230401Domain>
{
    public const string KubeApiVersion = "v20230401";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "communication.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "communication.azure.com/v20230401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20230401Domain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20230401Domain> Items { get; set; }
}

/// <summary>DomainManagement: Describes how a Domains resource is being managed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20230401DomainSpecDomainManagementEnum>))]
public enum V20230401DomainSpecDomainManagementEnum
{
    [EnumMember(Value = "AzureManaged"), JsonStringEnumMemberName("AzureManaged")]
    AzureManaged,
    [EnumMember(Value = "CustomerManaged"), JsonStringEnumMemberName("CustomerManaged")]
    CustomerManaged,
    [EnumMember(Value = "CustomerManagedInExchangeOnline"), JsonStringEnumMemberName("CustomerManagedInExchangeOnline")]
    CustomerManagedInExchangeOnline
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainSpecOperatorSpecConfigMapExpressions
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
public partial class V20230401DomainSpecOperatorSpecSecretExpressions
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
public partial class V20230401DomainSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20230401DomainSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20230401DomainSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a communication.azure.com/EmailService resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>UserEngagementTracking: Describes whether user engagement tracking is enabled or disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20230401DomainSpecUserEngagementTrackingEnum>))]
public enum V20230401DomainSpecUserEngagementTrackingEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DomainManagement: Describes how a Domains resource is being managed.</summary>
    [JsonPropertyName("domainManagement")]
    public required V20230401DomainSpecDomainManagementEnum DomainManagement { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20230401DomainSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a communication.azure.com/EmailService resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20230401DomainSpecOwner Owner { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UserEngagementTracking: Describes whether user engagement tracking is enabled or disabled.</summary>
    [JsonPropertyName("userEngagementTracking")]
    public V20230401DomainSpecUserEngagementTrackingEnum? UserEngagementTracking { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusConditions
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

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusSystemData
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

/// <summary>DKIM: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationRecordsDKIM
{
    /// <summary>Name: Name of the DNS record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Ttl: Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default =
    /// 3600sec.
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>Type: Type of the DNS record. Example: TXT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the DNS record.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DKIM2: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationRecordsDKIM2
{
    /// <summary>Name: Name of the DNS record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Ttl: Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default =
    /// 3600sec.
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>Type: Type of the DNS record. Example: TXT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the DNS record.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DMARC: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationRecordsDMARC
{
    /// <summary>Name: Name of the DNS record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Ttl: Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default =
    /// 3600sec.
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>Type: Type of the DNS record. Example: TXT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the DNS record.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Domain: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationRecordsDomain
{
    /// <summary>Name: Name of the DNS record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Ttl: Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default =
    /// 3600sec.
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>Type: Type of the DNS record. Example: TXT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the DNS record.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SPF: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationRecordsSPF
{
    /// <summary>Name: Name of the DNS record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Ttl: Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default =
    /// 3600sec.
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>Type: Type of the DNS record. Example: TXT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the DNS record.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>VerificationRecords: List of DnsRecord</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationRecords
{
    /// <summary>DKIM: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("DKIM")]
    public V20230401DomainStatusVerificationRecordsDKIM? DKIM { get; set; }

    /// <summary>DKIM2: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("DKIM2")]
    public V20230401DomainStatusVerificationRecordsDKIM2? DKIM2 { get; set; }

    /// <summary>DMARC: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("DMARC")]
    public V20230401DomainStatusVerificationRecordsDMARC? DMARC { get; set; }

    /// <summary>Domain: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("Domain")]
    public V20230401DomainStatusVerificationRecordsDomain? Domain { get; set; }

    /// <summary>SPF: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("SPF")]
    public V20230401DomainStatusVerificationRecordsSPF? SPF { get; set; }
}

/// <summary>DKIM: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationStatesDKIM
{
    /// <summary>ErrorCode: Error code. This property will only be present if the status is UnableToVerify.</summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>Status: Status of the verification operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>DKIM2: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationStatesDKIM2
{
    /// <summary>ErrorCode: Error code. This property will only be present if the status is UnableToVerify.</summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>Status: Status of the verification operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>DMARC: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationStatesDMARC
{
    /// <summary>ErrorCode: Error code. This property will only be present if the status is UnableToVerify.</summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>Status: Status of the verification operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Domain: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationStatesDomain
{
    /// <summary>ErrorCode: Error code. This property will only be present if the status is UnableToVerify.</summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>Status: Status of the verification operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>SPF: A class that represents a VerificationStatus record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationStatesSPF
{
    /// <summary>ErrorCode: Error code. This property will only be present if the status is UnableToVerify.</summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>Status: Status of the verification operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>VerificationStates: List of VerificationStatusRecord</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatusVerificationStates
{
    /// <summary>DKIM: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("DKIM")]
    public V20230401DomainStatusVerificationStatesDKIM? DKIM { get; set; }

    /// <summary>DKIM2: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("DKIM2")]
    public V20230401DomainStatusVerificationStatesDKIM2? DKIM2 { get; set; }

    /// <summary>DMARC: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("DMARC")]
    public V20230401DomainStatusVerificationStatesDMARC? DMARC { get; set; }

    /// <summary>Domain: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("Domain")]
    public V20230401DomainStatusVerificationStatesDomain? Domain { get; set; }

    /// <summary>SPF: A class that represents a VerificationStatus record.</summary>
    [JsonPropertyName("SPF")]
    public V20230401DomainStatusVerificationStatesSPF? SPF { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230401DomainStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20230401DomainStatusConditions>? Conditions { get; set; }

    /// <summary>DataLocation: The location where the Domains resource data is stored at rest.</summary>
    [JsonPropertyName("dataLocation")]
    public string? DataLocation { get; set; }

    /// <summary>DomainManagement: Describes how a Domains resource is being managed.</summary>
    [JsonPropertyName("domainManagement")]
    public string? DomainManagement { get; set; }

    /// <summary>FromSenderDomain: P2 sender domain that is displayed to the email recipients [RFC 5322].</summary>
    [JsonPropertyName("fromSenderDomain")]
    public string? FromSenderDomain { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MailFromSenderDomain: P1 sender domain that is present on the email envelope [RFC 5321].</summary>
    [JsonPropertyName("mailFromSenderDomain")]
    public string? MailFromSenderDomain { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20230401DomainStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserEngagementTracking: Describes whether user engagement tracking is enabled or disabled.</summary>
    [JsonPropertyName("userEngagementTracking")]
    public string? UserEngagementTracking { get; set; }

    /// <summary>VerificationRecords: List of DnsRecord</summary>
    [JsonPropertyName("verificationRecords")]
    public V20230401DomainStatusVerificationRecords? VerificationRecords { get; set; }

    /// <summary>VerificationStates: List of VerificationStatusRecord</summary>
    [JsonPropertyName("verificationStates")]
    public V20230401DomainStatusVerificationStates? VerificationStates { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /communication/resource-manager/Microsoft.Communication/stable/2023-04-01/Domains.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230401Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V20230401DomainSpec?>, IStatus<V20230401DomainStatus?>
{
    public const string KubeApiVersion = "v20230401";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "communication.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "communication.azure.com/v20230401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20230401DomainSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20230401DomainStatus? Status { get; set; }
}
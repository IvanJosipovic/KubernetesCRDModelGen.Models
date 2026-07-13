#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigateway.services.k8s.aws;
/// <summary>APIKey is the Schema for the APIKeys API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIKeyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIKey>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIKeyList";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "apikeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIKeyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIKey objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIKey> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeySpecStageKeysRestAPIRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for RestAPIID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeySpecStageKeysRestAPIRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1APIKeySpecStageKeysRestAPIRefFrom? From { get; set; }
}

/// <summary>A reference to a unique stage identified in the format {restApiId}/{stage}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeySpecStageKeys
{
    [JsonPropertyName("restAPIID")]
    public string? RestAPIID { get; set; }

    /// <summary>Reference field for RestAPIID</summary>
    [JsonPropertyName("restAPIRef")]
    public V1alpha1APIKeySpecStageKeysRestAPIRef? RestAPIRef { get; set; }

    [JsonPropertyName("stageName")]
    public string? StageName { get; set; }
}

/// <summary>Specifies a value of the API key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeySpecValue
{
    /// <summary>Key is the key within the secret</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>name is unique within a namespace to reference a secret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace defines the space within which the secret name must be unique.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// ApiKeySpec defines the desired state of ApiKey.
/// 
/// A resource that can be distributed to callers for executing Method resources
/// that require an API key. API keys can be mapped to any Stage on any RestApi,
/// which indicates that the callers with the API key can make requests to that
/// stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeySpec
{
    /// <summary>
    /// An Amazon Web Services Marketplace customer identifier, when integrating
    /// with the Amazon Web Services SaaS Marketplace.
    /// </summary>
    [JsonPropertyName("customerID")]
    public string? CustomerID { get; set; }

    /// <summary>The description of the ApiKey.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies whether the ApiKey can be used by callers.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Specifies whether (true) or not (false) the key identifier is distinct from
    /// the created API key value. This parameter is deprecated and should not be
    /// used.
    /// </summary>
    [JsonPropertyName("generateDistinctID")]
    public bool? GenerateDistinctID { get; set; }

    /// <summary>The name of the ApiKey.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>DEPRECATED FOR USAGE PLANS - Specifies stages associated with the API key.</summary>
    [JsonPropertyName("stageKeys")]
    public IList<V1alpha1APIKeySpecStageKeys>? StageKeys { get; set; }

    /// <summary>
    /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/].
    /// The tag key can be up to 128 characters and must not start with aws:. The
    /// tag value can be up to 256 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a value of the API key.</summary>
    [JsonPropertyName("value")]
    public V1alpha1APIKeySpecValue? Value { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeyStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>APIKeyStatus defines the observed state of APIKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1APIKeyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIKeyStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp when the API Key was created.</summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>The identifier of the API Key.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The timestamp when the API Key was last updated.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public DateTime? LastUpdatedDate { get; set; }
}

/// <summary>APIKey is the Schema for the APIKeys API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIKeySpec?>, IStatus<V1alpha1APIKeyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIKey";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "apikeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIKey";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ApiKeySpec defines the desired state of ApiKey.
    /// 
    /// A resource that can be distributed to callers for executing Method resources
    /// that require an API key. API keys can be mapped to any Stage on any RestApi,
    /// which indicates that the callers with the API key can make requests to that
    /// stage.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIKeySpec? Spec { get; set; }

    /// <summary>APIKeyStatus defines the observed state of APIKey</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIKeyStatus? Status { get; set; }
}
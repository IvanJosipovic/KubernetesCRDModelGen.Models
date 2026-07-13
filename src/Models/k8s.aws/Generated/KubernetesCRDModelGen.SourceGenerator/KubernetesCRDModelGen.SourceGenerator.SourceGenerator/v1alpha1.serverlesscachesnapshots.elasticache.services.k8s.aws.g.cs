#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elasticache.services.k8s.aws;
/// <summary>ServerlessCacheSnapshot is the Schema for the ServerlessCacheSnapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServerlessCacheSnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ServerlessCacheSnapshot>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServerlessCacheSnapshotList";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "serverlesscachesnapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerlessCacheSnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ServerlessCacheSnapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ServerlessCacheSnapshot> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotSpecKmsKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServerlessCacheSnapshotSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotSpecServerlessCacheRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotSpecServerlessCacheRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServerlessCacheSnapshotSpecServerlessCacheRefFrom? From { get; set; }
}

/// <summary>
/// A tag that can be added to an ElastiCache cluster or replication group. Tags
/// are composed of a Key/Value pair. You can use tags to categorize and track
/// all your ElastiCache resources, with the exception of global replication
/// group. When you add or remove tags on replication groups, those actions will
/// be replicated to all nodes in the replication group. A tag with a null Value
/// is permitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ServerlessCacheSnapshotSpec defines the desired state of ServerlessCacheSnapshot.
/// 
/// The resource representing a serverless cache snapshot. Available for Valkey,
/// Redis OSS and Serverless Memcached only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotSpec
{
    /// <summary>
    /// The ID of the KMS key used to encrypt the snapshot. Available for Valkey,
    /// Redis OSS and Serverless Memcached only. Default: NULL
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1ServerlessCacheSnapshotSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// The name of an existing serverless cache. The snapshot is created from this
    /// cache. Available for Valkey, Redis OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("serverlessCacheName")]
    public string? ServerlessCacheName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("serverlessCacheRef")]
    public V1alpha1ServerlessCacheSnapshotSpecServerlessCacheRef? ServerlessCacheRef { get; set; }

    /// <summary>
    /// The name for the snapshot being created. Must be unique for the customer
    /// account. Available for Valkey, Redis OSS and Serverless Memcached only. Must
    /// be between 1 and 255 characters.
    /// </summary>
    [JsonPropertyName("serverlessCacheSnapshotName")]
    public required string ServerlessCacheSnapshotName { get; set; }

    /// <summary>
    /// A list of tags to be added to the snapshot resource. A tag is a key-value
    /// pair. Available for Valkey, Redis OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ServerlessCacheSnapshotSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotStatusAckResourceMetadata
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
public partial class V1alpha1ServerlessCacheSnapshotStatusConditions
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

/// <summary>
/// The configuration of the serverless cache, at the time the snapshot was taken.
/// Available for Valkey, Redis OSS and Serverless Memcached only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotStatusServerlessCacheConfiguration
{
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    [JsonPropertyName("majorEngineVersion")]
    public string? MajorEngineVersion { get; set; }

    [JsonPropertyName("serverlessCacheName")]
    public string? ServerlessCacheName { get; set; }
}

/// <summary>ServerlessCacheSnapshotStatus defines the observed state of ServerlessCacheSnapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSnapshotStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ServerlessCacheSnapshotStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The total size of a serverless cache snapshot, in bytes. Available for Valkey,
    /// Redis OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("bytesUsedForCache")]
    public string? BytesUsedForCache { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ServerlessCacheSnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time that the source serverless cache&apos;s metadata and cache data
    /// set was obtained for the snapshot. Available for Valkey, Redis OSS and Serverless
    /// Memcached only.
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// The time that the serverless cache snapshot will expire. Available for Valkey,
    /// Redis OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("expiryTime")]
    public DateTime? ExpiryTime { get; set; }

    /// <summary>
    /// The configuration of the serverless cache, at the time the snapshot was taken.
    /// Available for Valkey, Redis OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("serverlessCacheConfiguration")]
    public V1alpha1ServerlessCacheSnapshotStatusServerlessCacheConfiguration? ServerlessCacheConfiguration { get; set; }

    /// <summary>
    /// The type of snapshot of serverless cache. Available for Valkey, Redis OSS
    /// and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("snapshotType")]
    public string? SnapshotType { get; set; }

    /// <summary>
    /// The current status of the serverless cache. Available for Valkey, Redis OSS
    /// and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ServerlessCacheSnapshot is the Schema for the ServerlessCacheSnapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServerlessCacheSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServerlessCacheSnapshotSpec?>, IStatus<V1alpha1ServerlessCacheSnapshotStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServerlessCacheSnapshot";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "serverlesscachesnapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerlessCacheSnapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ServerlessCacheSnapshotSpec defines the desired state of ServerlessCacheSnapshot.
    /// 
    /// The resource representing a serverless cache snapshot. Available for Valkey,
    /// Redis OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ServerlessCacheSnapshotSpec? Spec { get; set; }

    /// <summary>ServerlessCacheSnapshotStatus defines the observed state of ServerlessCacheSnapshot</summary>
    [JsonPropertyName("status")]
    public V1alpha1ServerlessCacheSnapshotStatus? Status { get; set; }
}
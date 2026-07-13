#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretsmanager.services.k8s.aws;
/// <summary>Secret is the Schema for the Secrets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Secret>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretList";
    public const string KubeGroup = "secretsmanager.services.k8s.aws";
    public const string KubePluralName = "secrets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "secretsmanager.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Secret objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Secret> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecKmsKeyRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SecretSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>A custom type that specifies a Region and the KmsKeyId for a replica secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecReplicaRegions
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The text data to encrypt and store in this new version of the secret. We
/// recommend you use a JSON structure of key/value pairs for your secret value.
/// 
/// Either SecretString or SecretBinary must have a value, but not both.
/// 
/// If you create a secret by using the Secrets Manager console then Secrets
/// Manager puts the protected secret text in only the SecretString parameter.
/// The Secrets Manager console stores the information as a JSON structure of
/// key/value pairs that a Lambda rotation function can parse.
/// 
/// Sensitive: This field contains sensitive information, so the service does
/// not include it in CloudTrail log entries. If you create your own log entries,
/// you must also avoid logging the information in this field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecSecretString
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

/// <summary>A structure that contains information about a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SecretSpec defines the desired state of Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpec
{
    /// <summary>The description of the secret.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies whether to overwrite a secret with the same name in the destination
    /// Region. By default, secrets aren&apos;t overwritten.
    /// </summary>
    [JsonPropertyName("forceOverwriteReplicaSecret")]
    public bool? ForceOverwriteReplicaSecret { get; set; }

    /// <summary>
    /// The ARN, key ID, or alias of the KMS key that Secrets Manager uses to encrypt
    /// the secret value in the secret. An alias is always prefixed by alias/, for
    /// example alias/aws/secretsmanager. For more information, see About aliases
    /// (https://docs.aws.amazon.com/kms/latest/developerguide/alias-about.html).
    /// 
    /// To use a KMS key in a different account, use the key ARN or the alias ARN.
    /// 
    /// If you don&apos;t specify this value, then Secrets Manager uses the key aws/secretsmanager.
    /// If that key doesn&apos;t yet exist, then Secrets Manager creates it for you automatically
    /// the first time it encrypts the secret value.
    /// 
    /// If the secret is in a different Amazon Web Services account from the credentials
    /// calling the API, then you can&apos;t use aws/secretsmanager to encrypt the secret,
    /// and you must create and use a customer managed KMS key.
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
    public V1alpha1SecretSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// The name of the new secret.
    /// 
    /// The secret name can contain ASCII letters, numbers, and the following characters:
    /// /_+=.@-
    /// 
    /// Do not end your secret name with a hyphen followed by six characters. If
    /// you do so, you risk confusion and unexpected results when searching for a
    /// secret by partial ARN. Secrets Manager automatically adds a hyphen and six
    /// random characters after the secret name at the end of the ARN.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>A list of Regions and KMS keys to replicate secrets.</summary>
    [JsonPropertyName("replicaRegions")]
    public IList<V1alpha1SecretSpecReplicaRegions>? ReplicaRegions { get; set; }

    /// <summary>
    /// The text data to encrypt and store in this new version of the secret. We
    /// recommend you use a JSON structure of key/value pairs for your secret value.
    /// 
    /// Either SecretString or SecretBinary must have a value, but not both.
    /// 
    /// If you create a secret by using the Secrets Manager console then Secrets
    /// Manager puts the protected secret text in only the SecretString parameter.
    /// The Secrets Manager console stores the information as a JSON structure of
    /// key/value pairs that a Lambda rotation function can parse.
    /// 
    /// Sensitive: This field contains sensitive information, so the service does
    /// not include it in CloudTrail log entries. If you create your own log entries,
    /// you must also avoid logging the information in this field.
    /// </summary>
    [JsonPropertyName("secretString")]
    public V1alpha1SecretSpecSecretString? SecretString { get; set; }

    /// <summary>
    /// A list of tags to attach to the secret. Each tag is a key and value pair
    /// of strings in a JSON text string, for example:
    /// 
    /// [{&quot;Key&quot;:&quot;CostCenter&quot;,&quot;Value&quot;:&quot;12345&quot;},{&quot;Key&quot;:&quot;environment&quot;,&quot;Value&quot;:&quot;production&quot;}]
    /// 
    /// Secrets Manager tag key names are case sensitive. A tag with the key &quot;ABC&quot;
    /// is a different tag from one with key &quot;abc&quot;.
    /// 
    /// If you check tags in permissions policies as part of your security strategy,
    /// then adding or removing a tag can change permissions. If the completion of
    /// this operation would result in you losing your permissions for this secret,
    /// then Secrets Manager blocks the operation and returns an Access Denied error.
    /// For more information, see Control access to secrets using tags (https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_examples.html#tag-secrets-abac)
    /// and Limit access to identities with tags that match secrets&apos; tags (https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_examples.html#auth-and-access_tags2).
    /// 
    /// For information about how to format a JSON parameter for the various command
    /// line tool environments, see Using JSON for Parameters (https://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json).
    /// If your command-line tool or SDK requires quotation marks around the parameter,
    /// you should use single quotes to avoid confusion with the double quotes required
    /// in the JSON text.
    /// 
    /// For tag quotas and naming restrictions, see Service quotas for Tagging (https://docs.aws.amazon.com/general/latest/gr/arg.html#taged-reference-quotas)
    /// in the Amazon Web Services General Reference guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SecretSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretStatusConditions
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
/// A replication object consisting of a RegionReplicationStatus object and includes
/// a Region, KMSKeyId, status, and status message.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretStatusReplicationStatus
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("lastAccessedDate")]
    public DateTime? LastAccessedDate { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>SecretStatus defines the observed state of Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1SecretStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretStatusConditions>? Conditions { get; set; }

    /// <summary>The ARN of the secret.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A list of the replicas of this secret and their status:
    /// 
    ///    * Failed, which indicates that the replica was not created.
    /// 
    ///    * InProgress, which indicates that Secrets Manager is in the process of
    ///    creating the replica.
    /// 
    ///    * InSync, which indicates that the replica was created.
    /// </summary>
    [JsonPropertyName("replicationStatus")]
    public IList<V1alpha1SecretStatusReplicationStatus>? ReplicationStatus { get; set; }

    /// <summary>The unique identifier associated with the version of the new secret.</summary>
    [JsonPropertyName("versionID")]
    public string? VersionID { get; set; }
}

/// <summary>Secret is the Schema for the Secrets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Secret : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretSpec?>, IStatus<V1alpha1SecretStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Secret";
    public const string KubeGroup = "secretsmanager.services.k8s.aws";
    public const string KubePluralName = "secrets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "secretsmanager.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Secret";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretSpec defines the desired state of Secret.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SecretSpec? Spec { get; set; }

    /// <summary>SecretStatus defines the observed state of Secret</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretStatus? Status { get; set; }
}
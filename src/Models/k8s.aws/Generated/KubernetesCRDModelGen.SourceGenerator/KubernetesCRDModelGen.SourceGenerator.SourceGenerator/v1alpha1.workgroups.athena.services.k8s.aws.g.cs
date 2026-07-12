#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.athena.services.k8s.aws;
/// <summary>WorkGroup is the Schema for the WorkGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkGroupList";
    public const string KubeGroup = "athena.services.k8s.aws";
    public const string KubePluralName = "workgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1WorkGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1WorkGroup> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationCustomerContentEncryptionConfigurationKmsKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KMSKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationCustomerContentEncryptionConfigurationKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1WorkGroupSpecConfigurationCustomerContentEncryptionConfigurationKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// Specifies the customer managed KMS key that is used to encrypt the user&apos;s
/// data stores in Athena. When an Amazon Web Services managed key is used, this
/// value is null. This setting does not apply to Athena SQL workgroups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationCustomerContentEncryptionConfiguration
{
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference field for KMSKey</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1WorkGroupSpecConfigurationCustomerContentEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary>
/// The Athena engine version for running queries, or the PySpark engine version
/// for running sessions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationEngineVersion
{
    [JsonPropertyName("effectiveEngineVersion")]
    public string? EffectiveEngineVersion { get; set; }

    [JsonPropertyName("selectedEngineVersion")]
    public string? SelectedEngineVersion { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationExecutionRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for ExecutionRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationExecutionRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1WorkGroupSpecConfigurationExecutionRoleRefFrom? From { get; set; }
}

/// <summary>Specifies whether the workgroup is IAM Identity Center supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationIdentityCenterConfiguration
{
    [JsonPropertyName("enableIdentityCenter")]
    public bool? EnableIdentityCenter { get; set; }

    [JsonPropertyName("identityCenterInstanceARN")]
    public string? IdentityCenterInstanceARN { get; set; }
}

/// <summary>Specifies whether Amazon S3 access grants are enabled for query results.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationQueryResultsS3AccessGrantsConfiguration
{
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    [JsonPropertyName("createUserLevelPrefix")]
    public bool? CreateUserLevelPrefix { get; set; }

    [JsonPropertyName("enableS3AccessGrants")]
    public bool? EnableS3AccessGrants { get; set; }
}

/// <summary>
/// Indicates that an Amazon S3 canned ACL should be set to control ownership
/// of stored query results, including data files inserted by Athena as the result
/// of statements like CTAS or INSERT INTO. When Athena stores query results
/// in Amazon S3, the canned ACL is set with the x-amz-acl request header. For
/// more information about S3 Object Ownership, see Object Ownership settings
/// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html#object-ownership-overview)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationResultConfigurationAclConfiguration
{
    [JsonPropertyName("s3ACLOption")]
    public string? S3ACLOption { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationResultConfigurationEncryptionConfigurationKmsKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KMSKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationResultConfigurationEncryptionConfigurationKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1WorkGroupSpecConfigurationResultConfigurationEncryptionConfigurationKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// If query and calculation results are encrypted in Amazon S3, indicates the
/// encryption option used (for example, SSE_KMS or CSE_KMS) and key information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationResultConfigurationEncryptionConfiguration
{
    [JsonPropertyName("encryptionOption")]
    public string? EncryptionOption { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference field for KMSKey</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1WorkGroupSpecConfigurationResultConfigurationEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary>
/// The location in Amazon S3 where query and calculation results are stored
/// and the encryption option, if any, used for query and calculation results.
/// These are known as &quot;client-side settings&quot;. If workgroup settings override
/// client-side settings, then the query uses the workgroup settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfigurationResultConfiguration
{
    /// <summary>
    /// Indicates that an Amazon S3 canned ACL should be set to control ownership
    /// of stored query results, including data files inserted by Athena as the result
    /// of statements like CTAS or INSERT INTO. When Athena stores query results
    /// in Amazon S3, the canned ACL is set with the x-amz-acl request header. For
    /// more information about S3 Object Ownership, see Object Ownership settings
    /// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html#object-ownership-overview)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("aclConfiguration")]
    public V1alpha1WorkGroupSpecConfigurationResultConfigurationAclConfiguration? AclConfiguration { get; set; }

    /// <summary>
    /// If query and calculation results are encrypted in Amazon S3, indicates the
    /// encryption option used (for example, SSE_KMS or CSE_KMS) and key information.
    /// </summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1WorkGroupSpecConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    [JsonPropertyName("outputLocation")]
    public string? OutputLocation { get; set; }
}

/// <summary>
/// Contains configuration information for creating an Athena SQL workgroup or
/// Spark enabled Athena workgroup. Athena SQL workgroup configuration includes
/// the location in Amazon S3 where query and calculation results are stored,
/// the encryption configuration, if any, used for encrypting query results,
/// whether the Amazon CloudWatch Metrics are enabled for the workgroup, the
/// limit for the amount of bytes scanned (cutoff) per query, if it is specified,
/// and whether workgroup&apos;s settings (specified with EnforceWorkGroupConfiguration)
/// in the WorkGroupConfiguration override client-side settings. See WorkGroupConfiguration$EnforceWorkGroupConfiguration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecConfiguration
{
    [JsonPropertyName("additionalConfiguration")]
    public string? AdditionalConfiguration { get; set; }

    [JsonPropertyName("bytesScannedCutoffPerQuery")]
    public long? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>
    /// Specifies the customer managed KMS key that is used to encrypt the user&apos;s
    /// data stores in Athena. When an Amazon Web Services managed key is used, this
    /// value is null. This setting does not apply to Athena SQL workgroups.
    /// </summary>
    [JsonPropertyName("customerContentEncryptionConfiguration")]
    public V1alpha1WorkGroupSpecConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration { get; set; }

    [JsonPropertyName("enableMinimumEncryptionConfiguration")]
    public bool? EnableMinimumEncryptionConfiguration { get; set; }

    [JsonPropertyName("enforceWorkGroupConfiguration")]
    public bool? EnforceWorkGroupConfiguration { get; set; }

    /// <summary>
    /// The Athena engine version for running queries, or the PySpark engine version
    /// for running sessions.
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public V1alpha1WorkGroupSpecConfigurationEngineVersion? EngineVersion { get; set; }

    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Reference field for ExecutionRole</summary>
    [JsonPropertyName("executionRoleRef")]
    public V1alpha1WorkGroupSpecConfigurationExecutionRoleRef? ExecutionRoleRef { get; set; }

    /// <summary>Specifies whether the workgroup is IAM Identity Center supported.</summary>
    [JsonPropertyName("identityCenterConfiguration")]
    public V1alpha1WorkGroupSpecConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration { get; set; }

    [JsonPropertyName("publishCloudWatchMetricsEnabled")]
    public bool? PublishCloudWatchMetricsEnabled { get; set; }

    /// <summary>Specifies whether Amazon S3 access grants are enabled for query results.</summary>
    [JsonPropertyName("queryResultsS3AccessGrantsConfiguration")]
    public V1alpha1WorkGroupSpecConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration { get; set; }

    [JsonPropertyName("requesterPaysEnabled")]
    public bool? RequesterPaysEnabled { get; set; }

    /// <summary>
    /// The location in Amazon S3 where query and calculation results are stored
    /// and the encryption option, if any, used for query and calculation results.
    /// These are known as &quot;client-side settings&quot;. If workgroup settings override
    /// client-side settings, then the query uses the workgroup settings.
    /// </summary>
    [JsonPropertyName("resultConfiguration")]
    public V1alpha1WorkGroupSpecConfigurationResultConfiguration? ResultConfiguration { get; set; }
}

/// <summary>
/// A label that you assign to a resource. Athena resources include workgroups,
/// data catalogs, and capacity reservations. Each tag consists of a key and
/// an optional value, both of which you define. For example, you can use tags
/// to categorize Athena resources by purpose, owner, or environment. Use a consistent
/// set of tag keys to make it easier to search and filter the resources in your
/// account. For best practices, see Tagging Best Practices (https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/tagging-best-practices.html).
/// Tag keys can be from 1 to 128 UTF-8 Unicode characters, and tag values can
/// be from 0 to 256 UTF-8 Unicode characters. Tags can use letters and numbers
/// representable in UTF-8, and the following characters: + - = . _ : / @. Tag
/// keys and values are case-sensitive. Tag keys must be unique per resource.
/// If you specify more than one tag, separate them by commas.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// WorkGroupSpec defines the desired state of WorkGroup.
/// 
/// A workgroup, which contains a name, description, creation time, state, and
/// other configuration, listed under WorkGroup$Configuration. Each workgroup
/// enables you to isolate queries for you or your group of users from other
/// queries in the same account, to configure the query results location and
/// the encryption configuration (known as workgroup settings), to enable sending
/// query metrics to Amazon CloudWatch, and to establish per-query data usage
/// control limits for all queries in a workgroup. The workgroup settings override
/// is specified in EnforceWorkGroupConfiguration (true/false) in the WorkGroupConfiguration.
/// See WorkGroupConfiguration$EnforceWorkGroupConfiguration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupSpec
{
    /// <summary>
    /// Contains configuration information for creating an Athena SQL workgroup or
    /// Spark enabled Athena workgroup. Athena SQL workgroup configuration includes
    /// the location in Amazon S3 where query and calculation results are stored,
    /// the encryption configuration, if any, used for encrypting query results,
    /// whether the Amazon CloudWatch Metrics are enabled for the workgroup, the
    /// limit for the amount of bytes scanned (cutoff) per query, if it is specified,
    /// and whether workgroup&apos;s settings (specified with EnforceWorkGroupConfiguration)
    /// in the WorkGroupConfiguration override client-side settings. See WorkGroupConfiguration$EnforceWorkGroupConfiguration.
    /// </summary>
    [JsonPropertyName("configuration")]
    public V1alpha1WorkGroupSpecConfiguration? Configuration { get; set; }

    /// <summary>The workgroup description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The workgroup name.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9._-]{1,128}$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>A list of comma separated tags to add to the workgroup that is created.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1WorkGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupStatusAckResourceMetadata
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
public partial class V1alpha1WorkGroupStatusConditions
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

/// <summary>WorkGroupStatus defines the observed state of WorkGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1WorkGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1WorkGroupStatusConditions>? Conditions { get; set; }
}

/// <summary>WorkGroup is the Schema for the WorkGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkGroupSpec?>, IStatus<V1alpha1WorkGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkGroup";
    public const string KubeGroup = "athena.services.k8s.aws";
    public const string KubePluralName = "workgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// WorkGroupSpec defines the desired state of WorkGroup.
    /// 
    /// A workgroup, which contains a name, description, creation time, state, and
    /// other configuration, listed under WorkGroup$Configuration. Each workgroup
    /// enables you to isolate queries for you or your group of users from other
    /// queries in the same account, to configure the query results location and
    /// the encryption configuration (known as workgroup settings), to enable sending
    /// query metrics to Amazon CloudWatch, and to establish per-query data usage
    /// control limits for all queries in a workgroup. The workgroup settings override
    /// is specified in EnforceWorkGroupConfiguration (true/false) in the WorkGroupConfiguration.
    /// See WorkGroupConfiguration$EnforceWorkGroupConfiguration.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1WorkGroupSpec? Spec { get; set; }

    /// <summary>WorkGroupStatus defines the observed state of WorkGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1WorkGroupStatus? Status { get; set; }
}
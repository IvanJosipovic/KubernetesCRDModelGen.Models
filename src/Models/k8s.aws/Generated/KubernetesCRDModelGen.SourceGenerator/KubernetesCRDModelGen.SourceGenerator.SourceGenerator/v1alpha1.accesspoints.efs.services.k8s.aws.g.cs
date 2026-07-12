#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.efs.services.k8s.aws;
/// <summary>AccessPoint is the Schema for the AccessPoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessPointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AccessPoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessPointList";
    public const string KubeGroup = "efs.services.k8s.aws";
    public const string KubePluralName = "accesspoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "efs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessPointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AccessPoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AccessPoint> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointSpecFileSystemRefFrom
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
public partial class V1alpha1AccessPointSpecFileSystemRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AccessPointSpecFileSystemRefFrom? From { get; set; }
}

/// <summary>
/// The operating system user and group applied to all file system requests made
/// using the access point.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointSpecPosixUser
{
    [JsonPropertyName("gid")]
    public long? Gid { get; set; }

    [JsonPropertyName("secondaryGIDs")]
    public IList<long>? SecondaryGIDs { get; set; }

    [JsonPropertyName("uid")]
    public long? Uid { get; set; }
}

/// <summary>
/// Required if the RootDirectory &gt; Path specified does not exist. Specifies
/// the POSIX IDs and permissions to apply to the access point&apos;s RootDirectory
/// &gt; Path. If the access point root directory does not exist, EFS creates it
/// with these settings when a client connects to the access point. When specifying
/// CreationInfo, you must include values for all properties.
/// 
/// Amazon EFS creates a root directory only if you have provided the CreationInfo:
/// OwnUid, OwnGID, and permissions for the directory. If you do not provide
/// this information, Amazon EFS does not create the root directory. If the root
/// directory does not exist, attempts to mount using the access point will fail.
/// 
/// If you do not provide CreationInfo and the specified RootDirectory does not
/// exist, attempts to mount the file system using the access point will fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointSpecRootDirectoryCreationInfo
{
    [JsonPropertyName("ownerGID")]
    public long? OwnerGID { get; set; }

    [JsonPropertyName("ownerUID")]
    public long? OwnerUID { get; set; }

    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
}

/// <summary>
/// Specifies the directory on the EFS file system that the access point exposes
/// as the root directory of your file system to NFS clients using the access
/// point. The clients using the access point can only access the root directory
/// and below. If the RootDirectory &gt; Path specified does not exist, Amazon EFS
/// creates it and applies the CreationInfo settings when a client connects to
/// an access point. When specifying a RootDirectory, you must provide the Path,
/// and the CreationInfo.
/// 
/// Amazon EFS creates a root directory only if you have provided the CreationInfo:
/// OwnUid, OwnGID, and permissions for the directory. If you do not provide
/// this information, Amazon EFS does not create the root directory. If the root
/// directory does not exist, attempts to mount using the access point will fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointSpecRootDirectory
{
    /// <summary>
    /// Required if the RootDirectory &gt; Path specified does not exist. Specifies
    /// the POSIX IDs and permissions to apply to the access point&apos;s RootDirectory
    /// &gt; Path. If the access point root directory does not exist, EFS creates it
    /// with these settings when a client connects to the access point. When specifying
    /// CreationInfo, you must include values for all properties.
    /// 
    /// Amazon EFS creates a root directory only if you have provided the CreationInfo:
    /// OwnUid, OwnGID, and permissions for the directory. If you do not provide
    /// this information, Amazon EFS does not create the root directory. If the root
    /// directory does not exist, attempts to mount using the access point will fail.
    /// 
    /// If you do not provide CreationInfo and the specified RootDirectory does not
    /// exist, attempts to mount the file system using the access point will fail.
    /// </summary>
    [JsonPropertyName("creationInfo")]
    public V1alpha1AccessPointSpecRootDirectoryCreationInfo? CreationInfo { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// A tag is a key-value pair. Allowed characters are letters, white space, and
/// numbers that can be represented in UTF-8, and the following characters:+
/// - = . _ : /.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>AccessPointSpec defines the desired state of AccessPoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointSpec
{
    /// <summary>
    /// The ID of the EFS file system that the access point provides access to.
    /// 
    /// Regex Pattern: `^(arn:aws[-a-z]*:elasticfilesystem:[0-9a-z-:]+:file-system/fs-[0-9a-f]{8,40}|fs-[0-9a-f]{8,40})$`
    /// </summary>
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("fileSystemRef")]
    public V1alpha1AccessPointSpecFileSystemRef? FileSystemRef { get; set; }

    /// <summary>
    /// The operating system user and group applied to all file system requests made
    /// using the access point.
    /// </summary>
    [JsonPropertyName("posixUser")]
    public V1alpha1AccessPointSpecPosixUser? PosixUser { get; set; }

    /// <summary>
    /// Specifies the directory on the EFS file system that the access point exposes
    /// as the root directory of your file system to NFS clients using the access
    /// point. The clients using the access point can only access the root directory
    /// and below. If the RootDirectory &gt; Path specified does not exist, Amazon EFS
    /// creates it and applies the CreationInfo settings when a client connects to
    /// an access point. When specifying a RootDirectory, you must provide the Path,
    /// and the CreationInfo.
    /// 
    /// Amazon EFS creates a root directory only if you have provided the CreationInfo:
    /// OwnUid, OwnGID, and permissions for the directory. If you do not provide
    /// this information, Amazon EFS does not create the root directory. If the root
    /// directory does not exist, attempts to mount using the access point will fail.
    /// </summary>
    [JsonPropertyName("rootDirectory")]
    public V1alpha1AccessPointSpecRootDirectory? RootDirectory { get; set; }

    /// <summary>
    /// Creates tags associated with the access point. Each tag is a key-value pair,
    /// each key must be unique. For more information, see Tagging Amazon Web Services
    /// resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html)
    /// in the Amazon Web Services General Reference Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1AccessPointSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointStatusAckResourceMetadata
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
public partial class V1alpha1AccessPointStatusConditions
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

/// <summary>AccessPointStatus defines the observed state of AccessPoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessPointStatus
{
    /// <summary>
    /// The ID of the access point, assigned by Amazon EFS.
    /// 
    /// Regex Pattern: `^(arn:aws[-a-z]*:elasticfilesystem:[0-9a-z-:]+:access-point/fsap-[0-9a-f]{8,40}|fsap-[0-9a-f]{8,40})$`
    /// </summary>
    [JsonPropertyName("accessPointID")]
    public string? AccessPointID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AccessPointStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AccessPointStatusConditions>? Conditions { get; set; }

    /// <summary>Identifies the lifecycle phase of the access point.</summary>
    [JsonPropertyName("lifeCycleState")]
    public string? LifeCycleState { get; set; }

    /// <summary>The name of the access point. This is the value of the Name tag.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Identifies the Amazon Web Services account that owns the access point resource.
    /// 
    /// Regex Pattern: `^(\d{12})|(\d{4}-\d{4}-\d{4})$`
    /// </summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }
}

/// <summary>AccessPoint is the Schema for the AccessPoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessPoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AccessPointSpec?>, IStatus<V1alpha1AccessPointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessPoint";
    public const string KubeGroup = "efs.services.k8s.aws";
    public const string KubePluralName = "accesspoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "efs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessPoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessPointSpec defines the desired state of AccessPoint.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AccessPointSpec? Spec { get; set; }

    /// <summary>AccessPointStatus defines the observed state of AccessPoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1AccessPointStatus? Status { get; set; }
}
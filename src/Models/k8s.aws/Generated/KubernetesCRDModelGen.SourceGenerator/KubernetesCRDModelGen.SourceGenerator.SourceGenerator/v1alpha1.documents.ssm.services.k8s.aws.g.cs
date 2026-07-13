#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.services.k8s.aws;
/// <summary>Document is the Schema for the Documents API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DocumentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Document>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DocumentList";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "documents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DocumentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Document objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Document> Items { get; set; }
}

/// <summary>
/// Identifying information about a document attachment, including the file name
/// and a key-value pair that identifies the location of an attachment to a document.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentSpecAttachments
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>An SSM document required by the current document.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentSpecRequires
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("requireType")]
    public string? RequireType { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary>
/// Metadata that you assign to your Amazon Web Services resources. Tags enable
/// you to categorize your resources in different ways, for example, by purpose,
/// owner, or environment. In Amazon Web Services Systems Manager, you can apply
/// tags to Systems Manager documents (SSM documents), managed nodes, maintenance
/// windows, parameters, patch baselines, OpsItems, and OpsMetadata.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DocumentSpec defines the desired state of Document.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentSpec
{
    /// <summary>A list of key-value pairs that describe attachments to a version of a document.</summary>
    [JsonPropertyName("attachments")]
    public IList<V1alpha1DocumentSpecAttachments>? Attachments { get; set; }

    /// <summary>
    /// The content for the new SSM document in JSON or YAML format. The content
    /// of the document must not exceed 64KB. This quota also includes the content
    /// specified for input parameters at runtime. We recommend storing the contents
    /// for your new document in an external JSON or YAML file and referencing the
    /// file in a command.
    /// 
    /// For examples, see the following topics in the Amazon Web Services Systems
    /// Manager User Guide.
    /// 
    ///   - Create an SSM document (console) (https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-console)
    /// 
    ///   - Create an SSM document (command line) (https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-cli)
    /// 
    ///   - Create an SSM document (API) (https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-api)
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// An optional field where you can specify a friendly name for the SSM document.
    /// This value can differ for each version of the document. You can update this
    /// value at a later time using the UpdateDocument operation.
    /// 
    /// Regex Pattern: `^[\w\.\-\:\/ ]*$`
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Specify the document format for the request. The document format can be JSON,
    /// YAML, or TEXT. JSON is the default format.
    /// </summary>
    [JsonPropertyName("documentFormat")]
    public string? DocumentFormat { get; set; }

    /// <summary>
    /// The type of document to create.
    /// 
    /// The DeploymentStrategy document type is an internal-use-only document type
    /// reserved for AppConfig.
    /// </summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>
    /// A name for the SSM document.
    /// 
    /// You can&apos;t use the following strings as document name prefixes. These are
    /// reserved by Amazon Web Services for use as document name prefixes:
    /// 
    ///   - aws
    /// 
    ///   - amazon
    /// 
    ///   - amzn
    /// 
    ///   - AWSEC2
    /// 
    ///   - AWSConfigRemediation
    /// 
    ///   - AWSSupport
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9_\-.]{3,128}$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A list of SSM documents required by a document. This parameter is used exclusively
    /// by AppConfig. When a user creates an AppConfig configuration in an SSM document,
    /// the user must also specify a required document for validation purposes. In
    /// this case, an ApplicationConfiguration document requires an ApplicationConfigurationSchema
    /// document for validation purposes. For more information, see What is AppConfig?
    /// (https://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html)
    /// in the AppConfig User Guide.
    /// </summary>
    [JsonPropertyName("requires")]
    public IList<V1alpha1DocumentSpecRequires>? Requires { get; set; }

    /// <summary>
    /// Optional metadata that you assign to a resource. Tags enable you to categorize
    /// a resource in different ways, such as by purpose, owner, or environment.
    /// For example, you might want to tag an SSM document to identify the types
    /// of targets or the environment where it will run. In this case, you could
    /// specify the following key-value pairs:
    /// 
    ///   - Key=OS,Value=Windows
    /// 
    ///   - Key=Environment,Value=Production
    /// 
    /// To add tags to an existing SSM document, use the AddTagsToResource operation.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DocumentSpecTags>? Tags { get; set; }

    /// <summary>
    /// Specify a target type to define the kinds of resources the document can run
    /// on. For example, to run a document on EC2 instances, specify the following
    /// value: /AWS::EC2::Instance. If you specify a value of &apos;/&apos; the document can
    /// run on all types of resources. If you don&apos;t specify a value, the document
    /// can&apos;t run on any resources. For a list of valid resource types, see Amazon
    /// Web Services resource and property types reference (https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html)
    /// in the CloudFormation User Guide.
    /// 
    /// Regex Pattern: `^\/[\w\.\-\:\/]*$`
    /// </summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// An optional field specifying the version of the artifact you are creating
    /// with the document. For example, Release12.1. This value is unique across
    /// all versions of a document, and can&apos;t be changed.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9_\-.]{1,128}$`
    /// </summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentStatusAckResourceMetadata
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

/// <summary>An attribute of an attachment, such as the attachment name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentStatusAttachmentsInformation
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentStatusConditions
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
/// Parameters specified in a Systems Manager document that run on the server
/// when the command is run.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentStatusParameters
{
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>Information about the result of a document review request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentStatusReviewInformation
{
    [JsonPropertyName("reviewedTime")]
    public DateTime? ReviewedTime { get; set; }

    [JsonPropertyName("reviewer")]
    public string? Reviewer { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>DocumentStatus defines the observed state of Document</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DocumentStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The version of the document currently approved for use in the organization.
    /// 
    /// Regex Pattern: `^([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)$`
    /// </summary>
    [JsonPropertyName("approvedVersion")]
    public string? ApprovedVersion { get; set; }

    /// <summary>
    /// Details about the document attachments, including names, locations, sizes,
    /// and so on.
    /// </summary>
    [JsonPropertyName("attachmentsInformation")]
    public IList<V1alpha1DocumentStatusAttachmentsInformation>? AttachmentsInformation { get; set; }

    /// <summary>The user in your organization who created the document.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>
    /// The classification of a document to help you identify and categorize its
    /// use.
    /// </summary>
    [JsonPropertyName("category")]
    public IList<string>? Category { get; set; }

    /// <summary>The value that identifies a document&apos;s category.</summary>
    [JsonPropertyName("categoryEnum")]
    public IList<string>? CategoryEnum { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DocumentStatusConditions>? Conditions { get; set; }

    /// <summary>The date when the document was created.</summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The default version.
    /// 
    /// Regex Pattern: `^([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)$`
    /// </summary>
    [JsonPropertyName("defaultVersion")]
    public string? DefaultVersion { get; set; }

    /// <summary>A description of the document.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The document version.
    /// 
    /// Regex Pattern: `^([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)$`
    /// </summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>
    /// The Sha256 or Sha1 hash created by the system when the document was created.
    /// 
    /// Sha1 hashes have been deprecated.
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>
    /// The hash type of the document. Valid values include Sha256 or Sha1.
    /// 
    /// Sha1 hashes have been deprecated.
    /// </summary>
    [JsonPropertyName("hashType")]
    public string? HashType { get; set; }

    /// <summary>
    /// The latest version of the document.
    /// 
    /// Regex Pattern: `^([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)$`
    /// </summary>
    [JsonPropertyName("latestVersion")]
    public string? LatestVersion { get; set; }

    /// <summary>The Amazon Web Services user that created the document.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>A description of the parameters for a document.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1DocumentStatusParameters>? Parameters { get; set; }

    /// <summary>
    /// The version of the document that is currently under review.
    /// 
    /// Regex Pattern: `^([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)$`
    /// </summary>
    [JsonPropertyName("pendingReviewVersion")]
    public string? PendingReviewVersion { get; set; }

    /// <summary>The list of operating system (OS) platforms compatible with this SSM document.</summary>
    [JsonPropertyName("platformTypes")]
    public IList<string>? PlatformTypes { get; set; }

    /// <summary>Details about the review of a document.</summary>
    [JsonPropertyName("reviewInformation")]
    public IList<V1alpha1DocumentStatusReviewInformation>? ReviewInformation { get; set; }

    /// <summary>The current status of the review.</summary>
    [JsonPropertyName("reviewStatus")]
    public string? ReviewStatus { get; set; }

    /// <summary>
    /// The schema version.
    /// 
    /// Regex Pattern: `^([0-9]+)\.([0-9]+)$`
    /// </summary>
    [JsonPropertyName("schemaVersion")]
    public string? SchemaVersion { get; set; }

    /// <summary>The SHA1 hash of the document, which you can use for verification.</summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>The status of the SSM document.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// A message returned by Amazon Web Services Systems Manager that explains the
    /// Status value. For example, a Failed status might be explained by the StatusInformation
    /// message, &quot;The specified S3 bucket doesn&apos;t exist. Verify that the URL of the
    /// S3 bucket is correct.&quot;
    /// </summary>
    [JsonPropertyName("statusInformation")]
    public string? StatusInformation { get; set; }
}

/// <summary>Document is the Schema for the Documents API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Document : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DocumentSpec?>, IStatus<V1alpha1DocumentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Document";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "documents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Document";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DocumentSpec defines the desired state of Document.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DocumentSpec? Spec { get; set; }

    /// <summary>DocumentStatus defines the observed state of Document</summary>
    [JsonPropertyName("status")]
    public V1alpha1DocumentStatus? Status { get; set; }
}
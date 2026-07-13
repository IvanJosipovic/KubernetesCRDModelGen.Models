#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.services.k8s.aws;
/// <summary>Project is the Schema for the Projects API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ProjectList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Project>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ProjectList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Project objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Project> Items { get; set; }
}

/// <summary>
/// A key value pair used when you provision a project as a service catalog product.
/// For information, see What is Amazon Web Services Service Catalog (https://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectSpecServiceCatalogProvisioningDetailsProvisioningParameters
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The product ID and provisioning artifact ID to provision a service catalog.
/// The provisioning artifact ID will default to the latest provisioning artifact
/// ID of the product, if you don&apos;t provide the provisioning artifact ID. For
/// more information, see What is Amazon Web Services Service Catalog (https://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectSpecServiceCatalogProvisioningDetails
{
    [JsonPropertyName("pathID")]
    public string? PathID { get; set; }

    [JsonPropertyName("productID")]
    public string? ProductID { get; set; }

    [JsonPropertyName("provisioningArtifactID")]
    public string? ProvisioningArtifactID { get; set; }

    [JsonPropertyName("provisioningParameters")]
    public IList<V1alpha1ProjectSpecServiceCatalogProvisioningDetailsProvisioningParameters>? ProvisioningParameters { get; set; }
}

/// <summary>
/// A tag object that consists of a key and an optional value, used to manage
/// metadata for SageMaker Amazon Web Services resources.
/// 
/// You can add tags to notebook instances, training jobs, hyperparameter tuning
/// jobs, batch transform jobs, models, labeling jobs, work teams, endpoint configurations,
/// and endpoints. For more information on adding tags to SageMaker resources,
/// see AddTags (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AddTags.html).
/// 
/// For more information on adding metadata to your Amazon Web Services resources
/// with tagging, see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
/// For advice on best practices for managing Amazon Web Services resources with
/// tagging, see Tagging Best Practices: Implement an Effective Amazon Web Services
/// Resource Tagging Strategy (https://d1.awsstatic.com/whitepapers/aws-tagging-best-practices.pdf).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A key-value pair that represents a parameter for the CloudFormation stack.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectSpecTemplateProvidersCfnTemplateProviderParameters
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The CloudFormation template provider configuration for creating infrastructure
/// resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectSpecTemplateProvidersCfnTemplateProvider
{
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ProjectSpecTemplateProvidersCfnTemplateProviderParameters>? Parameters { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }

    [JsonPropertyName("templateURL")]
    public string? TemplateURL { get; set; }
}

/// <summary>
/// Contains configuration details for a template provider. Only one type of
/// template provider can be specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectSpecTemplateProviders
{
    /// <summary>
    /// The CloudFormation template provider configuration for creating infrastructure
    /// resources.
    /// </summary>
    [JsonPropertyName("cfnTemplateProvider")]
    public V1alpha1ProjectSpecTemplateProvidersCfnTemplateProvider? CfnTemplateProvider { get; set; }
}

/// <summary>
/// ProjectSpec defines the desired state of Project.
/// 
/// The properties of a project as returned by the Search API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectSpec
{
    /// <summary>
    /// A description for the project.
    /// 
    /// Regex Pattern: `^[\p{L}\p{M}\p{Z}\p{S}\p{N}\p{P}]*$`
    /// </summary>
    [JsonPropertyName("projectDescription")]
    public string? ProjectDescription { get; set; }

    /// <summary>
    /// The name of the project.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,31}$`
    /// </summary>
    [JsonPropertyName("projectName")]
    public required string ProjectName { get; set; }

    /// <summary>
    /// The product ID and provisioning artifact ID to provision a service catalog.
    /// The provisioning artifact ID will default to the latest provisioning artifact
    /// ID of the product, if you don&apos;t provide the provisioning artifact ID. For
    /// more information, see What is Amazon Web Services Service Catalog (https://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html).
    /// </summary>
    [JsonPropertyName("serviceCatalogProvisioningDetails")]
    public V1alpha1ProjectSpecServiceCatalogProvisioningDetails? ServiceCatalogProvisioningDetails { get; set; }

    /// <summary>
    /// An array of key-value pairs that you want to use to organize and track your
    /// Amazon Web Services resource costs. For more information, see Tagging Amazon
    /// Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html)
    /// in the Amazon Web Services General Reference Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ProjectSpecTags>? Tags { get; set; }

    /// <summary>
    /// An array of template provider configurations for creating infrastructure
    /// resources for the project.
    /// </summary>
    [JsonPropertyName("templateProviders")]
    public IList<V1alpha1ProjectSpecTemplateProviders>? TemplateProviders { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusAckResourceMetadata
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
public partial class V1alpha1ProjectStatusConditions
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

/// <summary>Information about a provisioned service catalog product.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusServiceCatalogProvisionedProductDetails
{
    [JsonPropertyName("provisionedProductID")]
    public string? ProvisionedProductID { get; set; }

    [JsonPropertyName("provisionedProductStatusMessage")]
    public string? ProvisionedProductStatusMessage { get; set; }
}

/// <summary>A key-value pair representing a parameter used in the CloudFormation stack.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusTemplateProviderDetailsCfnTemplateProviderDetailParameters
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details about the CloudFormation stack.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusTemplateProviderDetailsCfnTemplateProviderDetailStackDetail
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>
/// Details about a CloudFormation template provider configuration and associated
/// provisioning information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusTemplateProviderDetailsCfnTemplateProviderDetail
{
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ProjectStatusTemplateProviderDetailsCfnTemplateProviderDetailParameters>? Parameters { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Details about the CloudFormation stack.</summary>
    [JsonPropertyName("stackDetail")]
    public V1alpha1ProjectStatusTemplateProviderDetailsCfnTemplateProviderDetailStackDetail? StackDetail { get; set; }

    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }

    [JsonPropertyName("templateURL")]
    public string? TemplateURL { get; set; }
}

/// <summary>
/// Details about a template provider configuration and associated provisioning
/// information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusTemplateProviderDetails
{
    /// <summary>
    /// Details about a CloudFormation template provider configuration and associated
    /// provisioning information.
    /// </summary>
    [JsonPropertyName("cfnTemplateProviderDetail")]
    public V1alpha1ProjectStatusTemplateProviderDetailsCfnTemplateProviderDetail? CfnTemplateProviderDetail { get; set; }
}

/// <summary>ProjectStatus defines the observed state of Project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ProjectStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ProjectStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the project was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// The ID of the new project.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9])*$`
    /// </summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>The status of the project.</summary>
    [JsonPropertyName("projectStatus")]
    public string? ProjectStatus { get; set; }

    /// <summary>Information about a provisioned service catalog product.</summary>
    [JsonPropertyName("serviceCatalogProvisionedProductDetails")]
    public V1alpha1ProjectStatusServiceCatalogProvisionedProductDetails? ServiceCatalogProvisionedProductDetails { get; set; }

    /// <summary>An array of template providers associated with the project.</summary>
    [JsonPropertyName("templateProviderDetails")]
    public IList<V1alpha1ProjectStatusTemplateProviderDetails>? TemplateProviderDetails { get; set; }
}

/// <summary>Project is the Schema for the Projects API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Project : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ProjectSpec?>, IStatus<V1alpha1ProjectStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Project";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Project";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ProjectSpec defines the desired state of Project.
    /// 
    /// The properties of a project as returned by the Search API.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ProjectSpec? Spec { get; set; }

    /// <summary>ProjectStatus defines the observed state of Project</summary>
    [JsonPropertyName("status")]
    public V1alpha1ProjectStatus? Status { get; set; }
}
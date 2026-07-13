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
/// <summary>Parameter is the Schema for the Parameters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ParameterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Parameter>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ParameterList";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "parameters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ParameterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Parameter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Parameter> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterSpecKeyRefFrom
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
public partial class V1alpha1ParameterSpecKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ParameterSpecKeyRefFrom? From { get; set; }
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
public partial class V1alpha1ParameterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ParameterSpec defines the desired state of Parameter.
/// 
/// An Amazon Web Services Systems Manager parameter in Parameter Store.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterSpec
{
    /// <summary>
    /// A regular expression used to validate the parameter value. For example, for
    /// String types with values restricted to numbers, you can specify the following:
    /// AllowedPattern=^\d+$
    /// </summary>
    [JsonPropertyName("allowedPattern")]
    public string? AllowedPattern { get; set; }

    /// <summary>
    /// The data type for a String parameter. Supported data types include plain
    /// text and Amazon Machine Image (AMI) IDs.
    /// 
    /// The following data type values are supported.
    /// 
    ///   - text
    /// 
    ///   - aws:ec2:image
    /// 
    ///   - aws:ssm:integration
    /// 
    /// When you create a String parameter and specify aws:ec2:image, Amazon Web
    /// Services Systems Manager validates the parameter value is in the required
    /// format, such as ami-12345abcdeEXAMPLE, and that the specified AMI is available
    /// in your Amazon Web Services account.
    /// 
    /// If the action is successful, the service sends back an HTTP 200 response
    /// which indicates a successful PutParameter call for all cases except for data
    /// type aws:ec2:image. If you call PutParameter with aws:ec2:image data type,
    /// a successful HTTP 200 response does not guarantee that your parameter was
    /// successfully created or updated. The aws:ec2:image value is validated asynchronously,
    /// and the PutParameter call returns before the validation is complete. If you
    /// submit an invalid AMI value, the PutParameter operation will return success,
    /// but the asynchronous validation will fail and the parameter will not be created
    /// or updated. To monitor whether your aws:ec2:image parameters are created
    /// successfully, see Setting up notifications or trigger actions based on Parameter
    /// Store events (https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-cwe.html).
    /// For more information about AMI format validation , see Native parameter support
    /// for Amazon Machine Image IDs (https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-ec2-aliases.html).
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// Information about the parameter that you want to add to the system. Optional
    /// but recommended.
    /// 
    /// Don&apos;t enter personally identifiable information in this field.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The Key Management Service (KMS) ID that you want to use to encrypt a parameter.
    /// Use a custom key for better security. Required for parameters that use the
    /// SecureString data type.
    /// 
    /// If you don&apos;t specify a key ID, the system uses the default key associated
    /// with your Amazon Web Services account which is not as secure as using a custom
    /// key.
    /// 
    ///   - To use a custom KMS key, choose the SecureString data type with the
    ///     Key ID parameter.
    /// 
    /// Regex Pattern: `^([a-zA-Z0-9:/_-]+)$`
    /// </summary>
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("keyRef")]
    public V1alpha1ParameterSpecKeyRef? KeyRef { get; set; }

    /// <summary>
    /// The fully qualified name of the parameter that you want to add to the system.
    /// 
    /// You can&apos;t enter the Amazon Resource Name (ARN) for a parameter, only the
    /// parameter name itself.
    /// 
    /// The fully qualified name includes the complete hierarchy of the parameter
    /// path and name. For parameters in a hierarchy, you must include a leading
    /// forward slash character (/) when you create or reference a parameter. For
    /// example: /Dev/DBServer/MySQL/db-string13
    /// 
    /// Naming Constraints:
    /// 
    ///   - Parameter names are case sensitive.
    /// 
    ///   - A parameter name must be unique within an Amazon Web Services Region
    /// 
    ///   - A parameter name can&apos;t be prefixed with &quot;aws&quot; or &quot;ssm&quot; (case-insensitive).
    /// 
    ///   - Parameter names can include only the following symbols and letters:
    ///     a-zA-Z0-9_.- In addition, the slash character ( / ) is used to delineate
    ///     hierarchies in parameter names. For example: /Dev/Production/East/Project-ABC/MyParameter
    /// 
    ///   - A parameter name can&apos;t include spaces.
    /// 
    ///   - Parameter hierarchies are limited to a maximum depth of fifteen levels.
    /// 
    /// For additional information about valid values for parameter names, see Creating
    /// Systems Manager parameters (https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-su-create.html)
    /// in the Amazon Web Services Systems Manager User Guide.
    /// 
    /// The maximum length constraint of 2048 characters listed below includes 1037
    /// characters reserved for internal use by Systems Manager. The maximum length
    /// for a parameter name that you create is 1011 characters. This includes the
    /// characters in the ARN that precede the name you specify, such as arn:aws:ssm:us-east-2:111122223333:parameter/.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// One or more policies to apply to a parameter. This operation takes a JSON
    /// array. Parameter Store, a tool in Amazon Web Services Systems Manager supports
    /// the following policy types:
    /// 
    /// Expiration: This policy deletes the parameter after it expires. When you
    /// create the policy, you specify the expiration date. You can update the expiration
    /// date and time by updating the policy. Updating the parameter doesn&apos;t affect
    /// the expiration date and time. When the expiration time is reached, Parameter
    /// Store deletes the parameter.
    /// 
    /// ExpirationNotification: This policy initiates an event in Amazon CloudWatch
    /// Events that notifies you about the expiration. By using this policy, you
    /// can receive notification before or after the expiration time is reached,
    /// in units of days or hours.
    /// 
    /// NoChangeNotification: This policy initiates a CloudWatch Events event if
    /// a parameter hasn&apos;t been modified for a specified period of time. This policy
    /// type is useful when, for example, a secret needs to be changed within a period
    /// of time, but it hasn&apos;t been changed.
    /// 
    /// All existing policies are preserved until you send new policies or an empty
    /// policy. For more information about parameter policies, see Assigning parameter
    /// policies (https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-policies.html).
    /// </summary>
    [JsonPropertyName("policies")]
    public string? Policies { get; set; }

    /// <summary>
    /// Optional metadata that you assign to a resource. Tags enable you to categorize
    /// a resource in different ways, such as by purpose, owner, or environment.
    /// For example, you might want to tag a Systems Manager parameter to identify
    /// the type of resource to which it applies, the environment, or the type of
    /// configuration data referenced by the parameter. In this case, you could specify
    /// the following key-value pairs:
    /// 
    ///   - Key=Resource,Value=S3bucket
    /// 
    ///   - Key=OS,Value=Windows
    /// 
    ///   - Key=ParameterType,Value=LicenseKey
    /// 
    /// To add tags to an existing Systems Manager parameter, use the AddTagsToResource
    /// operation.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ParameterSpecTags>? Tags { get; set; }

    /// <summary>
    /// The parameter tier to assign to a parameter.
    /// 
    /// Parameter Store offers a standard tier and an advanced tier for parameters.
    /// Standard parameters have a content size limit of 4 KB and can&apos;t be configured
    /// to use parameter policies. You can create a maximum of 10,000 standard parameters
    /// for each Region in an Amazon Web Services account. Standard parameters are
    /// offered at no additional cost.
    /// 
    /// Advanced parameters have a content size limit of 8 KB and can be configured
    /// to use parameter policies. You can create a maximum of 100,000 advanced parameters
    /// for each Region in an Amazon Web Services account. Advanced parameters incur
    /// a charge. For more information, see Managing parameter tiers (https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html)
    /// in the Amazon Web Services Systems Manager User Guide.
    /// 
    /// You can change a standard parameter to an advanced parameter any time. But
    /// you can&apos;t revert an advanced parameter to a standard parameter. Reverting
    /// an advanced parameter to a standard parameter would result in data loss because
    /// the system would truncate the size of the parameter from 8 KB to 4 KB. Reverting
    /// would also remove any policies attached to the parameter. Lastly, advanced
    /// parameters use a different form of encryption than standard parameters.
    /// 
    /// If you no longer need an advanced parameter, or if you no longer want to
    /// incur charges for an advanced parameter, you must delete it and recreate
    /// it as a new standard parameter.
    /// 
    /// # Using the Default Tier Configuration
    /// 
    /// In PutParameter requests, you can specify the tier to create the parameter
    /// in. Whenever you specify a tier in the request, Parameter Store creates or
    /// updates the parameter according to that request. However, if you don&apos;t specify
    /// a tier in a request, Parameter Store assigns the tier based on the current
    /// Parameter Store default tier configuration.
    /// 
    /// The default tier when you begin using Parameter Store is the standard-parameter
    /// tier. If you use the advanced-parameter tier, you can specify one of the
    /// following as the default:
    /// 
    ///   - Advanced: With this option, Parameter Store evaluates all requests as
    ///     advanced parameters.
    /// 
    ///   - Intelligent-Tiering: With this option, Parameter Store evaluates each
    ///     request to determine if the parameter is standard or advanced. If the
    ///     request doesn&apos;t include any options that require an advanced parameter,
    ///     the parameter is created in the standard-parameter tier. If one or more
    ///     options requiring an advanced parameter are included in the request, Parameter
    ///     Store create a parameter in the advanced-parameter tier. This approach
    ///     helps control your parameter-related costs by always creating standard
    ///     parameters unless an advanced parameter is necessary.
    /// 
    /// Options that require an advanced parameter include the following:
    /// 
    ///   - The content size of the parameter is more than 4 KB.
    /// 
    ///   - The parameter uses a parameter policy.
    /// 
    ///   - More than 10,000 parameters already exist in your Amazon Web Services
    ///     account in the current Amazon Web Services Region.
    /// 
    /// For more information about configuring the default tier option, see Specifying
    /// a default parameter tier (https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html#ps-default-tier)
    /// in the Amazon Web Services Systems Manager User Guide.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>
    /// The type of parameter that you want to add to the system.
    /// 
    /// SecureString isn&apos;t currently supported for CloudFormation templates.
    /// 
    /// Items in a StringList must be separated by a comma (,). You can&apos;t use other
    /// punctuation or special character to escape items in the list. If you have
    /// a parameter value that requires a comma, then use the String data type.
    /// 
    /// Specifying a parameter type isn&apos;t required when updating a parameter. You
    /// must specify a parameter type when creating a parameter.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The parameter value that you want to add to the system. Standard parameters
    /// have a value limit of 4 KB. Advanced parameters have a value limit of 8 KB.
    /// 
    /// Parameters can&apos;t be referenced or nested in the values of other parameters.
    /// You can&apos;t include values wrapped in double brackets {{}} or {{ssm:parameter-name}}
    /// in a parameter value.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterStatusAckResourceMetadata
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
public partial class V1alpha1ParameterStatusConditions
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

/// <summary>ParameterStatus defines the observed state of Parameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ParameterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ParameterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The new version number of a parameter. If you edit a parameter value, Parameter
    /// Store automatically creates a new version and assigns this new version a
    /// unique ID. You can reference a parameter version ID in API operations or
    /// in Systems Manager documents (SSM documents). By default, if you don&apos;t specify
    /// a specific version, the system returns the latest parameter value when a
    /// parameter is called.
    /// </summary>
    [JsonPropertyName("version")]
    public long? Version { get; set; }
}

/// <summary>Parameter is the Schema for the Parameters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Parameter : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ParameterSpec?>, IStatus<V1alpha1ParameterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Parameter";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "parameters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Parameter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ParameterSpec defines the desired state of Parameter.
    /// 
    /// An Amazon Web Services Systems Manager parameter in Parameter Store.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ParameterSpec? Spec { get; set; }

    /// <summary>ParameterStatus defines the observed state of Parameter</summary>
    [JsonPropertyName("status")]
    public V1alpha1ParameterStatus? Status { get; set; }
}
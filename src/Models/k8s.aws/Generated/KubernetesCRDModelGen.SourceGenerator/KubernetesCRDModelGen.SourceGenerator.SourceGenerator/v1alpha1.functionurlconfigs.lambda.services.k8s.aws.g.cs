#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.services.k8s.aws;
/// <summary>FunctionURLConfig is the Schema for the FunctionURLConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FunctionURLConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FunctionURLConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FunctionURLConfigList";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "functionurlconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionURLConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FunctionURLConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FunctionURLConfig> Items { get; set; }
}

/// <summary>
/// The cross-origin resource sharing (CORS) (https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)
/// settings for your function URL.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionURLConfigSpecCors
{
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    [JsonPropertyName("maxAge")]
    public long? MaxAge { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionURLConfigSpecFunctionRefFrom
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
public partial class V1alpha1FunctionURLConfigSpecFunctionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FunctionURLConfigSpecFunctionRefFrom? From { get; set; }
}

/// <summary>
/// FunctionUrlConfigSpec defines the desired state of FunctionUrlConfig.
/// 
/// Details about a Lambda function URL.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionURLConfigSpec
{
    /// <summary>
    /// The type of authentication that your function URL uses. Set to AWS_IAM if
    /// you want to restrict access to authenticated users only. Set to NONE if you
    /// want to bypass IAM authentication to create a public endpoint. For more information,
    /// see Control access to Lambda function URLs (https://docs.aws.amazon.com/lambda/latest/dg/urls-auth.html).
    /// </summary>
    [JsonPropertyName("authType")]
    public required string AuthType { get; set; }

    /// <summary>
    /// The cross-origin resource sharing (CORS) (https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)
    /// settings for your function URL.
    /// </summary>
    [JsonPropertyName("cors")]
    public V1alpha1FunctionURLConfigSpecCors? Cors { get; set; }

    /// <summary>
    /// The name or ARN of the Lambda function.
    /// 
    /// Name formats
    /// 
    ///   - Function name – my-function.
    /// 
    ///   - Function ARN – arn:aws:lambda:us-west-2:123456789012:function:my-function.
    /// 
    ///   - Partial ARN – 123456789012:function:my-function.
    /// 
    /// The length constraint applies only to the full ARN. If you specify only the
    /// function name, it is limited to 64 characters in length.
    /// 
    /// Regex Pattern: `^(arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("functionRef")]
    public V1alpha1FunctionURLConfigSpecFunctionRef? FunctionRef { get; set; }

    /// <summary>
    /// The alias name.
    /// 
    /// Regex Pattern: `^((?!^\d+$)^[0-9a-zA-Z-_]+$)$`
    /// </summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionURLConfigStatusAckResourceMetadata
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
public partial class V1alpha1FunctionURLConfigStatusConditions
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

/// <summary>FunctionURLConfigStatus defines the observed state of FunctionURLConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionURLConfigStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1FunctionURLConfigStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FunctionURLConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// When the function URL was created, in ISO-8601 format (https://www.w3.org/TR/NOTE-datetime)
    /// (YYYY-MM-DDThh:mm:ss.sTZD).
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of your function.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:lambda:[a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:\d{12}:function:[a-zA-Z0-9-_]+(:(\$LATEST|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("functionARN")]
    public string? FunctionARN { get; set; }

    /// <summary>The HTTP URL endpoint for your function.</summary>
    [JsonPropertyName("functionURL")]
    public string? FunctionURL { get; set; }
}

/// <summary>FunctionURLConfig is the Schema for the FunctionURLConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FunctionURLConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FunctionURLConfigSpec?>, IStatus<V1alpha1FunctionURLConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FunctionURLConfig";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "functionurlconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionURLConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// FunctionUrlConfigSpec defines the desired state of FunctionUrlConfig.
    /// 
    /// Details about a Lambda function URL.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1FunctionURLConfigSpec? Spec { get; set; }

    /// <summary>FunctionURLConfigStatus defines the observed state of FunctionURLConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1FunctionURLConfigStatus? Status { get; set; }
}
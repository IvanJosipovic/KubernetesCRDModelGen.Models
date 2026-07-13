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
/// <summary>LayerVersion is the Schema for the LayerVersions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LayerVersionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1LayerVersion>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LayerVersionList";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "layerversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LayerVersionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1LayerVersion objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1LayerVersion> Items { get; set; }
}

/// <summary>The function layer archive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LayerVersionSpecContent
{
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    [JsonPropertyName("zipFile")]
    public byte[]? ZipFile { get; set; }
}

/// <summary>LayerVersionSpec defines the desired state of LayerVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LayerVersionSpec
{
    /// <summary>A list of compatible instruction set architectures (https://docs.aws.amazon.com/lambda/latest/dg/foundation-arch.html).</summary>
    [JsonPropertyName("compatibleArchitectures")]
    public IList<string>? CompatibleArchitectures { get; set; }

    /// <summary>
    /// A list of compatible function runtimes (https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html).
    /// Used for filtering with ListLayers and ListLayerVersions.
    /// 
    /// The following list includes deprecated runtimes. For more information, see
    /// Runtime deprecation policy (https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtime-support-policy).
    /// </summary>
    [JsonPropertyName("compatibleRuntimes")]
    public IList<string>? CompatibleRuntimes { get; set; }

    /// <summary>The function layer archive.</summary>
    [JsonPropertyName("content")]
    public required V1alpha1LayerVersionSpecContent Content { get; set; }

    /// <summary>The description of the version.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The name or Amazon Resource Name (ARN) of the layer.
    /// 
    /// Regex Pattern: `^(arn:[a-zA-Z0-9-]+:lambda:[a-zA-Z0-9-]+:\d{12}:layer:[a-zA-Z0-9-_]+)|[a-zA-Z0-9-_]+$`
    /// </summary>
    [JsonPropertyName("layerName")]
    public required string LayerName { get; set; }

    /// <summary>
    /// The layer&apos;s software license. It can be any of the following:
    /// 
    ///   - An SPDX license identifier (https://spdx.org/licenses/). For example,
    ///     MIT.
    /// 
    ///   - The URL of a license hosted on the internet. For example, https://opensource.org/licenses/MIT.
    /// 
    ///   - The full text of the license.
    /// </summary>
    [JsonPropertyName("licenseInfo")]
    public string? LicenseInfo { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LayerVersionStatusAckResourceMetadata
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
public partial class V1alpha1LayerVersionStatusConditions
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

/// <summary>LayerVersionStatus defines the observed state of LayerVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LayerVersionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1LayerVersionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1LayerVersionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date that the layer version was created, in ISO-8601 format (https://www.w3.org/TR/NOTE-datetime)
    /// (YYYY-MM-DDThh:mm:ss.sTZD).
    /// </summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>
    /// The ARN of the layer.
    /// 
    /// Regex Pattern: `^arn:[a-zA-Z0-9-]+:lambda:[a-zA-Z0-9-]+:\d{12}:layer:[a-zA-Z0-9-_]+$`
    /// </summary>
    [JsonPropertyName("layerARN")]
    public string? LayerARN { get; set; }

    /// <summary>The version number.</summary>
    [JsonPropertyName("versionNumber")]
    public long? VersionNumber { get; set; }
}

/// <summary>LayerVersion is the Schema for the LayerVersions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LayerVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1LayerVersionSpec?>, IStatus<V1alpha1LayerVersionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LayerVersion";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "layerversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LayerVersion";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LayerVersionSpec defines the desired state of LayerVersion.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1LayerVersionSpec? Spec { get; set; }

    /// <summary>LayerVersionStatus defines the observed state of LayerVersion</summary>
    [JsonPropertyName("status")]
    public V1alpha1LayerVersionStatus? Status { get; set; }
}
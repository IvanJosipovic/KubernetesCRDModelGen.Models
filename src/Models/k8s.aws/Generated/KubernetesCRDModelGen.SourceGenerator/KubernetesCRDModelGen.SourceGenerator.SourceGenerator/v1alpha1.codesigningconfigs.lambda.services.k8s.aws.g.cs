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
/// <summary>CodeSigningConfig is the Schema for the CodeSigningConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CodeSigningConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CodeSigningConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CodeSigningConfigList";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "codesigningconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CodeSigningConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CodeSigningConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CodeSigningConfig> Items { get; set; }
}

/// <summary>Signing profiles for this code signing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CodeSigningConfigSpecAllowedPublishers
{
    [JsonPropertyName("signingProfileVersionARNs")]
    public IList<string>? SigningProfileVersionARNs { get; set; }
}

/// <summary>
/// The code signing policies define the actions to take if the validation checks
/// fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CodeSigningConfigSpecCodeSigningPolicies
{
    [JsonPropertyName("untrustedArtifactOnDeployment")]
    public string? UntrustedArtifactOnDeployment { get; set; }
}

/// <summary>
/// CodeSigningConfigSpec defines the desired state of CodeSigningConfig.
/// 
/// Details about a Code signing configuration (https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CodeSigningConfigSpec
{
    /// <summary>Signing profiles for this code signing configuration.</summary>
    [JsonPropertyName("allowedPublishers")]
    public required V1alpha1CodeSigningConfigSpecAllowedPublishers AllowedPublishers { get; set; }

    /// <summary>
    /// The code signing policies define the actions to take if the validation checks
    /// fail.
    /// </summary>
    [JsonPropertyName("codeSigningPolicies")]
    public V1alpha1CodeSigningConfigSpecCodeSigningPolicies? CodeSigningPolicies { get; set; }

    /// <summary>Descriptive name for this code signing configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of tags to add to the code signing configuration.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CodeSigningConfigStatusAckResourceMetadata
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
public partial class V1alpha1CodeSigningConfigStatusConditions
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

/// <summary>CodeSigningConfigStatus defines the observed state of CodeSigningConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CodeSigningConfigStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CodeSigningConfigStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// Unique identifer for the Code signing configuration.
    /// 
    /// Regex Pattern: `^csc-[a-zA-Z0-9-_\.]{17}$`
    /// </summary>
    [JsonPropertyName("codeSigningConfigID")]
    public string? CodeSigningConfigID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CodeSigningConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time that the Code signing configuration was last modified,
    /// in ISO-8601 format (YYYY-MM-DDThh:mm:ss.sTZD).
    /// </summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }
}

/// <summary>CodeSigningConfig is the Schema for the CodeSigningConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CodeSigningConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CodeSigningConfigSpec?>, IStatus<V1alpha1CodeSigningConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CodeSigningConfig";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "codesigningconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CodeSigningConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CodeSigningConfigSpec defines the desired state of CodeSigningConfig.
    /// 
    /// Details about a Code signing configuration (https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html).
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CodeSigningConfigSpec? Spec { get; set; }

    /// <summary>CodeSigningConfigStatus defines the observed state of CodeSigningConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1CodeSigningConfigStatus? Status { get; set; }
}
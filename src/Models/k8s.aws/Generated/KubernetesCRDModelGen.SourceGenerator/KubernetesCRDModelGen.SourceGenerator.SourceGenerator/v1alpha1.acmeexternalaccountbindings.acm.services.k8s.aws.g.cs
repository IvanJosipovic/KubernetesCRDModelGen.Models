#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acm.services.k8s.aws;
/// <summary>AcmeExternalAccountBinding is the Schema for the AcmeExternalAccountBindings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AcmeExternalAccountBindingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AcmeExternalAccountBinding>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AcmeExternalAccountBindingList";
    public const string KubeGroup = "acm.services.k8s.aws";
    public const string KubePluralName = "acmeexternalaccountbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AcmeExternalAccountBindingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AcmeExternalAccountBinding objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AcmeExternalAccountBinding> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingSpecAcmeEndpointRefFrom
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
public partial class V1alpha1AcmeExternalAccountBindingSpecAcmeEndpointRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AcmeExternalAccountBindingSpecAcmeEndpointRefFrom? From { get; set; }
}

/// <summary>
/// The Kubernetes Secret where EAB credentials are written. Specify the namespace,
/// name, and key. The sensitive macKey is written under the given key; the keyId is
/// written under a fixed keyId key, unless key is itself keyId, in which case the
/// macKey wins and the identifier is available in status.keyID. If namespace is
/// omitted, the resource&apos;s namespace is used. The Secret must already exist; the
/// controller populates it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingSpecCredentialsOutput
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

/// <summary>The expiration configuration for the external account binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingSpecExpiration
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingSpecRoleRefFrom
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
public partial class V1alpha1AcmeExternalAccountBindingSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AcmeExternalAccountBindingSpecRoleRefFrom? From { get; set; }
}

/// <summary>A key-value pair that identifies or specifies metadata about an ACM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// AcmeExternalAccountBindingSpec defines the desired state of AcmeExternalAccountBinding.
/// 
/// Contains detailed information about an ACME external account binding.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingSpec
{
    /// <summary>
    /// The ARN of the ACME endpoint to associate this external account binding with.
    /// 
    /// The Amazon Resource Name (ARN) of the ACME endpoint.
    /// 
    /// Regex Pattern: `^arn:aws[a-z-]*:acm:[a-z0-9-]+:[0-9]{12}:acme-endpoint/[a-zA-Z0-9-]+$`
    /// </summary>
    [JsonPropertyName("acmeEndpointARN")]
    public string? AcmeEndpointARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("acmeEndpointRef")]
    public V1alpha1AcmeExternalAccountBindingSpecAcmeEndpointRef? AcmeEndpointRef { get; set; }

    /// <summary>
    /// The Kubernetes Secret where EAB credentials are written. Specify the namespace,
    /// name, and key. The sensitive macKey is written under the given key; the keyId is
    /// written under a fixed keyId key, unless key is itself keyId, in which case the
    /// macKey wins and the identifier is available in status.keyID. If namespace is
    /// omitted, the resource&apos;s namespace is used. The Secret must already exist; the
    /// controller populates it.
    /// </summary>
    [JsonPropertyName("credentialsOutput")]
    public V1alpha1AcmeExternalAccountBindingSpecCredentialsOutput? CredentialsOutput { get; set; }

    /// <summary>The expiration configuration for the external account binding.</summary>
    [JsonPropertyName("expiration")]
    public V1alpha1AcmeExternalAccountBindingSpecExpiration? Expiration { get; set; }

    /// <summary>
    /// The ARN of the IAM role associated with the external account binding.
    /// The role&apos;s trust policy must grant acm-acme.amazonaws.com access to
    /// sts:AssumeRole, sts:SetSourceIdentity, and sts:TagSession.
    /// 
    /// The Amazon Resource Name (ARN) of the IAM role to associate with the external
    /// account binding.
    /// 
    /// Regex Pattern: `^arn:aws[a-z-]*:iam::[0-9]{12}:role/.+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1AcmeExternalAccountBindingSpecRoleRef? RoleRef { get; set; }

    /// <summary>One or more tags to associate with the external account binding.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1AcmeExternalAccountBindingSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingStatusAckResourceMetadata
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
public partial class V1alpha1AcmeExternalAccountBindingStatusConditions
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

/// <summary>AcmeExternalAccountBindingStatus defines the observed state of AcmeExternalAccountBinding</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeExternalAccountBindingStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AcmeExternalAccountBindingStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AcmeExternalAccountBindingStatusConditions>? Conditions { get; set; }

    /// <summary>The time at which the external account binding was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>The time at which the external account binding expires.</summary>
    [JsonPropertyName("expiresAt")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// The external account binding key identifier. This value is not sensitive and
    /// pairs with the macKey stored in the credentials Secret. It is surfaced in status
    /// so ACME clients can reference it directly when registering an account.
    /// </summary>
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    /// <summary>The time at which the external account binding was last used.</summary>
    [JsonPropertyName("lastUsedAt")]
    public DateTime? LastUsedAt { get; set; }

    /// <summary>The time at which the external account binding was revoked.</summary>
    [JsonPropertyName("revokedAt")]
    public DateTime? RevokedAt { get; set; }

    /// <summary>The time at which the external account binding was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}

/// <summary>AcmeExternalAccountBinding is the Schema for the AcmeExternalAccountBindings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AcmeExternalAccountBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AcmeExternalAccountBindingSpec?>, IStatus<V1alpha1AcmeExternalAccountBindingStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AcmeExternalAccountBinding";
    public const string KubeGroup = "acm.services.k8s.aws";
    public const string KubePluralName = "acmeexternalaccountbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AcmeExternalAccountBinding";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// AcmeExternalAccountBindingSpec defines the desired state of AcmeExternalAccountBinding.
    /// 
    /// Contains detailed information about an ACME external account binding.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1AcmeExternalAccountBindingSpec? Spec { get; set; }

    /// <summary>AcmeExternalAccountBindingStatus defines the observed state of AcmeExternalAccountBinding</summary>
    [JsonPropertyName("status")]
    public V1alpha1AcmeExternalAccountBindingStatus? Status { get; set; }
}
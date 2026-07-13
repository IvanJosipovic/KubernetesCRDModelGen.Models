#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.services.k8s.aws;
/// <summary>OpenIDConnectProvider is the Schema for the OpenIDConnectProviders API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OpenIDConnectProviderList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OpenIDConnectProvider>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OpenIDConnectProviderList";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "openidconnectproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OpenIDConnectProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1OpenIDConnectProvider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1OpenIDConnectProvider> Items { get; set; }
}

/// <summary>
/// A structure that represents user-provided metadata that can be associated
/// with an IAM resource. For more information about tagging, see Tagging IAM
/// resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
/// in the IAM User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OpenIDConnectProviderSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>OpenIDConnectProviderSpec defines the desired state of OpenIDConnectProvider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OpenIDConnectProviderSpec
{
    /// <summary>
    /// Provides a list of client IDs, also known as audiences. When a mobile or
    /// web app registers with an OpenID Connect provider, they establish a value
    /// that identifies the application. This is the value that&apos;s sent as the client_id
    /// parameter on OAuth requests.
    /// 
    /// You can register multiple client IDs with the same provider. For example,
    /// you might have multiple applications that use the same OIDC provider. You
    /// cannot register more than 100 client IDs with a single IAM OIDC provider.
    /// 
    /// There is no defined format for a client ID. The CreateOpenIDConnectProviderRequest
    /// operation accepts client IDs up to 255 characters long.
    /// </summary>
    [JsonPropertyName("clientIDs")]
    public IList<string>? ClientIDs { get; set; }

    /// <summary>
    /// A list of tags that you want to attach to the new IAM OpenID Connect (OIDC)
    /// provider. Each tag consists of a key name and an associated value. For more
    /// information about tagging, see Tagging IAM resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
    /// in the IAM User Guide.
    /// 
    /// If any one of the tags is invalid or if you exceed the allowed maximum number
    /// of tags, then the entire request fails and the resource is not created.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1OpenIDConnectProviderSpecTags>? Tags { get; set; }

    /// <summary>
    /// A list of server certificate thumbprints for the OpenID Connect (OIDC) identity
    /// provider&apos;s server certificates. Typically this list includes only one entry.
    /// However, IAM lets you have up to five thumbprints for an OIDC provider. This
    /// lets you maintain multiple thumbprints if the identity provider is rotating
    /// certificates.
    /// 
    /// This parameter is optional. If it is not included, IAM will retrieve and
    /// use the top intermediate certificate authority (CA) thumbprint of the OpenID
    /// Connect identity provider server certificate.
    /// 
    /// The server certificate thumbprint is the hex-encoded SHA-1 hash value of
    /// the X.509 certificate used by the domain where the OpenID Connect provider
    /// makes its keys available. It is always a 40-character string.
    /// 
    /// For example, assume that the OIDC provider is server.example.com and the
    /// provider stores its keys at https://keys.server.example.com/openid-connect.
    /// In that case, the thumbprint string would be the hex-encoded SHA-1 hash value
    /// of the certificate used by https://keys.server.example.com.
    /// 
    /// For more information about obtaining the OIDC provider thumbprint, see Obtaining
    /// the thumbprint for an OpenID Connect provider (https://docs.aws.amazon.com/IAM/latest/UserGuide/identity-providers-oidc-obtain-thumbprint.html)
    /// in the IAM user Guide.
    /// </summary>
    [JsonPropertyName("thumbprints")]
    public IList<string>? Thumbprints { get; set; }

    /// <summary>
    /// The URL of the identity provider. The URL must begin with https:// and should
    /// correspond to the iss claim in the provider&apos;s OpenID Connect ID tokens. Per
    /// the OIDC standard, path components are allowed but query parameters are not.
    /// Typically the URL consists of only a hostname, like https://server.example.org
    /// or https://example.com. The URL should not contain a port number.
    /// 
    /// You cannot register the same provider multiple times in a single Amazon Web
    /// Services account. If you try to submit a URL that has already been used for
    /// an OpenID Connect provider in the Amazon Web Services account, you will get
    /// an error.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OpenIDConnectProviderStatusAckResourceMetadata
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
public partial class V1alpha1OpenIDConnectProviderStatusConditions
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

/// <summary>OpenIDConnectProviderStatus defines the observed state of OpenIDConnectProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OpenIDConnectProviderStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1OpenIDConnectProviderStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OpenIDConnectProviderStatusConditions>? Conditions { get; set; }
}

/// <summary>OpenIDConnectProvider is the Schema for the OpenIDConnectProviders API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OpenIDConnectProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OpenIDConnectProviderSpec?>, IStatus<V1alpha1OpenIDConnectProviderStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OpenIDConnectProvider";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "openidconnectproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OpenIDConnectProvider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OpenIDConnectProviderSpec defines the desired state of OpenIDConnectProvider.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1OpenIDConnectProviderSpec? Spec { get; set; }

    /// <summary>OpenIDConnectProviderStatus defines the observed state of OpenIDConnectProvider</summary>
    [JsonPropertyName("status")]
    public V1alpha1OpenIDConnectProviderStatus? Status { get; set; }
}
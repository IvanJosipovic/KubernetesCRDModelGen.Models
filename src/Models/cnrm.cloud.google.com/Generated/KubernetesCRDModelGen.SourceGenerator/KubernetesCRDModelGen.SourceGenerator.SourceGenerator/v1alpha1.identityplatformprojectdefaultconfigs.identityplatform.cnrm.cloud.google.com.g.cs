#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1IdentityPlatformProjectDefaultConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IdentityPlatformProjectDefaultConfigList";
    public const string KubeGroup = "identityplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "identityplatformprojectdefaultconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identityplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IdentityPlatformProjectDefaultConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1IdentityPlatformProjectDefaultConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1IdentityPlatformProjectDefaultConfig> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration options related to authenticating an anonymous user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInAnonymous
{
    /// <summary>Whether anonymous user auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Configuration options related to authenticating a user by their email address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInEmail
{
    /// <summary>Whether email auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Whether a password is required for email auth or not. If true, both an email and
    /// password must be provided to sign in. If false, a user may sign in via either
    /// email/password or email link.
    /// </summary>
    [JsonPropertyName("passwordRequired")]
    public bool? PasswordRequired { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInHashConfig
{
    /// <summary>Different password hash algorithms used in Identity Toolkit.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Memory cost for hash calculation. Used by scrypt and other similar password derivation algorithms. See https://tools.ietf.org/html/rfc7914 for explanation of field.</summary>
    [JsonPropertyName("memoryCost")]
    public int? MemoryCost { get; set; }

    /// <summary>How many rounds for hash calculation. Used by scrypt and other similar password derivation algorithms.</summary>
    [JsonPropertyName("rounds")]
    public int? Rounds { get; set; }

    /// <summary>Non-printable character to be inserted between the salt and plain text password in base64.</summary>
    [JsonPropertyName("saltSeparator")]
    public string? SaltSeparator { get; set; }

    /// <summary>Signer key in base64.</summary>
    [JsonPropertyName("signerKey")]
    public string? SignerKey { get; set; }
}

/// <summary>Configuration options related to authenticated a user by their phone number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInPhoneNumber
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A map of &lt;test phone number, fake code&gt; that can be used for phone auth testing.</summary>
    [JsonPropertyName("testPhoneNumbers")]
    public IDictionary<string, string>? TestPhoneNumbers { get; set; }
}

/// <summary>Configuration related to local sign in methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigSpecSignIn
{
    /// <summary>Whether to allow more than one account to have the same email.</summary>
    [JsonPropertyName("allowDuplicateEmails")]
    public bool? AllowDuplicateEmails { get; set; }

    /// <summary>Configuration options related to authenticating an anonymous user.</summary>
    [JsonPropertyName("anonymous")]
    public V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInAnonymous? Anonymous { get; set; }

    /// <summary>Configuration options related to authenticating a user by their email address.</summary>
    [JsonPropertyName("email")]
    public V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInEmail? Email { get; set; }

    /// <summary>Output only. Hash config information.</summary>
    [JsonPropertyName("hashConfig")]
    public IList<V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInHashConfig>? HashConfig { get; set; }

    /// <summary>Configuration options related to authenticated a user by their phone number.</summary>
    [JsonPropertyName("phoneNumber")]
    public V1alpha1IdentityPlatformProjectDefaultConfigSpecSignInPhoneNumber? PhoneNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigSpec
{
    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1IdentityPlatformProjectDefaultConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Configuration related to local sign in methods.</summary>
    [JsonPropertyName("signIn")]
    public V1alpha1IdentityPlatformProjectDefaultConfigSpecSignIn? SignIn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IdentityPlatformProjectDefaultConfigStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IdentityPlatformProjectDefaultConfigStatusConditions>? Conditions { get; set; }

    /// <summary>The name of the Config resource. Example: &quot;projects/my-awesome-project/config&quot;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IdentityPlatformProjectDefaultConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IdentityPlatformProjectDefaultConfigSpec>, IStatus<V1alpha1IdentityPlatformProjectDefaultConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IdentityPlatformProjectDefaultConfig";
    public const string KubeGroup = "identityplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "identityplatformprojectdefaultconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identityplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IdentityPlatformProjectDefaultConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1IdentityPlatformProjectDefaultConfigSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1IdentityPlatformProjectDefaultConfigStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.cnrm.cloud.google.com;
/// <summary>BinaryAuthorizationPlatformPolicy is the Schema for the BinaryAuthorizationPlatformPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BinaryAuthorizationPlatformPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BinaryAuthorizationPlatformPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BinaryAuthorizationPlatformPolicyList";
    public const string KubeGroup = "binaryauthorization.cnrm.cloud.google.com";
    public const string KubePluralName = "binaryauthorizationplatformpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BinaryAuthorizationPlatformPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BinaryAuthorizationPlatformPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BinaryAuthorizationPlatformPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksImageAllowlist
{
    [JsonPropertyName("allowPattern")]
    public IList<string>? AllowPattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksImageFreshnessCheck
{
    [JsonPropertyName("maxUploadAgeDays")]
    public int? MaxUploadAgeDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheckSigstoreAuthoritiesPublicKeySetPublicKeys
{
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheckSigstoreAuthoritiesPublicKeySet
{
    [JsonPropertyName("publicKeys")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheckSigstoreAuthoritiesPublicKeySetPublicKeys>? PublicKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheckSigstoreAuthorities
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("publicKeySet")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheckSigstoreAuthoritiesPublicKeySet? PublicKeySet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheck
{
    [JsonPropertyName("sigstoreAuthorities")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheckSigstoreAuthorities>? SigstoreAuthorities { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheckAttestationAuthenticatorsPkixPublicKeySetPkixPublicKeys
{
    /// <summary>A PEM-encoded public key, as described in https://tools.ietf.org/html/rfc7468#section-13</summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>The signature algorithm used to verify a message against a signature using this key. These signature algorithm must match the structure and any object identifiers encoded in `public_key_pem` (i.e. this algorithm must match that of the public key).</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheckAttestationAuthenticatorsPkixPublicKeySet
{
    [JsonPropertyName("pkixPublicKeys")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheckAttestationAuthenticatorsPkixPublicKeySetPkixPublicKeys>? PkixPublicKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheckAttestationAuthenticators
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("pkixPublicKeySet")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheckAttestationAuthenticatorsPkixPublicKeySet? PkixPublicKeySet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheck
{
    [JsonPropertyName("attestationAuthenticators")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheckAttestationAuthenticators>? AttestationAuthenticators { get; set; }

    [JsonPropertyName("containerAnalysisAttestationProjects")]
    public IList<string>? ContainerAnalysisAttestationProjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSlsaCheckRules
{
    [JsonPropertyName("trustedBuilder")]
    public string? TrustedBuilder { get; set; }

    [JsonPropertyName("trustedSourceRepoPatterns")]
    public IList<string>? TrustedSourceRepoPatterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSlsaCheck
{
    [JsonPropertyName("rules")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSlsaCheckRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksTrustedDirectoryCheck
{
    [JsonPropertyName("trustedDirPatterns")]
    public IList<string>? TrustedDirPatterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksVulnerabilityCheck
{
    [JsonPropertyName("allowedCves")]
    public IList<string>? AllowedCves { get; set; }

    [JsonPropertyName("blockedCves")]
    public IList<string>? BlockedCves { get; set; }

    [JsonPropertyName("containerAnalysisVulnerabilityProjects")]
    public IList<string>? ContainerAnalysisVulnerabilityProjects { get; set; }

    [JsonPropertyName("maximumFixableSeverity")]
    public string? MaximumFixableSeverity { get; set; }

    [JsonPropertyName("maximumUnfixableSeverity")]
    public string? MaximumUnfixableSeverity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecks
{
    [JsonPropertyName("alwaysDeny")]
    public bool? AlwaysDeny { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("imageAllowlist")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksImageAllowlist? ImageAllowlist { get; set; }

    [JsonPropertyName("imageFreshnessCheck")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksImageFreshnessCheck? ImageFreshnessCheck { get; set; }

    [JsonPropertyName("sigstoreSignatureCheck")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSigstoreSignatureCheck? SigstoreSignatureCheck { get; set; }

    [JsonPropertyName("simpleSigningAttestationCheck")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSimpleSigningAttestationCheck? SimpleSigningAttestationCheck { get; set; }

    [JsonPropertyName("slsaCheck")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksSlsaCheck? SlsaCheck { get; set; }

    [JsonPropertyName("trustedDirectoryCheck")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksTrustedDirectoryCheck? TrustedDirectoryCheck { get; set; }

    [JsonPropertyName("vulnerabilityCheck")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecksVulnerabilityCheck? VulnerabilityCheck { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsImageAllowlist
{
    [JsonPropertyName("allowPattern")]
    public IList<string>? AllowPattern { get; set; }
}

/// <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsScopeKubernetesServiceAccountRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: &quot;spec.containers{name}&quot; (where &quot;name&quot; refers to the name of the container that triggered the event) or if no container name is specified &quot;spec.containers[2]&quot; (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsScope
{
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary>
    [JsonPropertyName("kubernetesServiceAccountRef")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsScopeKubernetesServiceAccountRef? KubernetesServiceAccountRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSets
{
    [JsonPropertyName("checks")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsChecks>? Checks { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("imageAllowlist")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsImageAllowlist? ImageAllowlist { get; set; }

    [JsonPropertyName("scope")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSetsScope? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyImageAllowlist
{
    [JsonPropertyName("allowPattern")]
    public IList<string>? AllowPattern { get; set; }
}

/// <summary>Optional. GKE platform-specific policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicy
{
    [JsonPropertyName("checkSets")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyCheckSets>? CheckSets { get; set; }

    [JsonPropertyName("imageAllowlist")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicyImageAllowlist? ImageAllowlist { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BinaryAuthorizationPlatformPolicySpec defines the desired state of BinaryAuthorizationPlatformPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicySpec
{
    /// <summary>Optional. A description comment about the policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. GKE platform-specific policy.</summary>
    [JsonPropertyName("gkePolicy")]
    public V1alpha1BinaryAuthorizationPlatformPolicySpecGkePolicy? GkePolicy { get; set; }

    /// <summary>The platform of this resource.</summary>
    [JsonPropertyName("platform")]
    public required string Platform { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1BinaryAuthorizationPlatformPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The BinaryAuthorizationPlatformPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicyStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicyStatusObservedState
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BinaryAuthorizationPlatformPolicyStatus defines the config connector machine state of BinaryAuthorizationPlatformPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BinaryAuthorizationPlatformPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BinaryAuthorizationPlatformPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BinaryAuthorizationPlatformPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BinaryAuthorizationPlatformPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>BinaryAuthorizationPlatformPolicy is the Schema for the BinaryAuthorizationPlatformPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BinaryAuthorizationPlatformPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BinaryAuthorizationPlatformPolicySpec>, IStatus<V1alpha1BinaryAuthorizationPlatformPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BinaryAuthorizationPlatformPolicy";
    public const string KubeGroup = "binaryauthorization.cnrm.cloud.google.com";
    public const string KubePluralName = "binaryauthorizationplatformpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BinaryAuthorizationPlatformPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BinaryAuthorizationPlatformPolicySpec defines the desired state of BinaryAuthorizationPlatformPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BinaryAuthorizationPlatformPolicySpec Spec { get; set; }

    /// <summary>BinaryAuthorizationPlatformPolicyStatus defines the config connector machine state of BinaryAuthorizationPlatformPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1BinaryAuthorizationPlatformPolicyStatus? Status { get; set; }
}
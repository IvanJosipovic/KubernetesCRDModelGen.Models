#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.image.toolkit.fluxcd.io;
/// <summary>ImageUpdateAutomation is the Schema for the imageupdateautomations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageUpdateAutomationList : IKubernetesObject<V1ListMeta>, IItems<V1ImageUpdateAutomation>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageUpdateAutomationList";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imageupdateautomations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "image.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageUpdateAutomationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ImageUpdateAutomation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ImageUpdateAutomation> Items { get; set; }
}

/// <summary>
/// Reference gives a branch, tag or commit to clone from the Git
/// repository.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGitCheckoutRef
{
    /// <summary>Branch to check out, defaults to &apos;master&apos; if no other field is defined.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Commit SHA to check out, takes precedence over all reference fields.
    /// 
    /// This can be combined with Branch to shallow clone the branch, in which
    /// the commit is expected to exist.
    /// </summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>
    /// Name of the reference to check out; takes precedence over Branch, Tag and SemVer.
    /// 
    /// It must be a valid Git reference: https://git-scm.com/docs/git-check-ref-format#_description
    /// Examples: &quot;refs/heads/main&quot;, &quot;refs/tags/v0.1.0&quot;, &quot;refs/pull/420/head&quot;, &quot;refs/merge-requests/1/head&quot;
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SemVer tag expression to check out, takes precedence over Tag.</summary>
    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    /// <summary>Tag to check out, takes precedence over Branch.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Checkout gives the parameters for cloning the git repository,
/// ready to make changes. If not present, the `spec.ref` field from the
/// referenced `GitRepository` or its default will be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGitCheckout
{
    /// <summary>
    /// Reference gives a branch, tag or commit to clone from the Git
    /// repository.
    /// </summary>
    [JsonPropertyName("ref")]
    public required V1ImageUpdateAutomationSpecGitCheckoutRef Ref { get; set; }
}

/// <summary>
/// Author gives the email and optionally the name to use as the
/// author of commits.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGitCommitAuthor
{
    /// <summary>Email gives the email to provide when making a commit.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Name gives the name to provide when making a commit.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// SecretRef references a Secret containing the signing key. For type
/// &apos;gpg&apos;, the Secret must contain a &apos;git.asc&apos; (ASCII-armored OpenPGP
/// keypair) and may contain a &apos;passphrase&apos;. For type &apos;ssh&apos;, the Secret
/// must contain an &apos;identity&apos; (an SSH private key in any format
/// golang.org/x/crypto/ssh.ParsePrivateKey accepts; typically the
/// OpenSSH format produced by &apos;ssh-keygen&apos;) and may contain a &apos;password&apos;
/// (the key&apos;s passphrase). The SSH conventions match the GitRepository
/// SSH transport-auth Secret format, allowing a single Secret to serve
/// both transport and signing when the ImageUpdateAutomation lives in
/// the same namespace as the GitRepository.
/// 
/// The Secret itself must live in the same namespace as the
/// ImageUpdateAutomation.
/// 
/// Supported SSH key algorithms: ed25519, ecdsa-sha2-nistp256/384/521,
/// and rsa (&gt;= 2048-bit).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGitCommitSigningKeySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Type selects the signing-key format expected in the referenced
/// Secret. When empty, the controller defaults to &apos;gpg&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImageUpdateAutomationSpecGitCommitSigningKeyTypeEnum>))]
public enum V1ImageUpdateAutomationSpecGitCommitSigningKeyTypeEnum
{
    [EnumMember(Value = "gpg"), JsonStringEnumMemberName("gpg")]
    Gpg,
    [EnumMember(Value = "ssh"), JsonStringEnumMemberName("ssh")]
    Ssh
}

/// <summary>
/// SigningKey provides the option to sign commits with an OpenPGP or
/// SSH signing key, referenced from a Secret. See SigningKey.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGitCommitSigningKey
{
    /// <summary>
    /// SecretRef references a Secret containing the signing key. For type
    /// &apos;gpg&apos;, the Secret must contain a &apos;git.asc&apos; (ASCII-armored OpenPGP
    /// keypair) and may contain a &apos;passphrase&apos;. For type &apos;ssh&apos;, the Secret
    /// must contain an &apos;identity&apos; (an SSH private key in any format
    /// golang.org/x/crypto/ssh.ParsePrivateKey accepts; typically the
    /// OpenSSH format produced by &apos;ssh-keygen&apos;) and may contain a &apos;password&apos;
    /// (the key&apos;s passphrase). The SSH conventions match the GitRepository
    /// SSH transport-auth Secret format, allowing a single Secret to serve
    /// both transport and signing when the ImageUpdateAutomation lives in
    /// the same namespace as the GitRepository.
    /// 
    /// The Secret itself must live in the same namespace as the
    /// ImageUpdateAutomation.
    /// 
    /// Supported SSH key algorithms: ed25519, ecdsa-sha2-nistp256/384/521,
    /// and rsa (&gt;= 2048-bit).
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1ImageUpdateAutomationSpecGitCommitSigningKeySecretRef SecretRef { get; set; }

    /// <summary>
    /// Type selects the signing-key format expected in the referenced
    /// Secret. When empty, the controller defaults to &apos;gpg&apos;.
    /// </summary>
    [JsonPropertyName("type")]
    public V1ImageUpdateAutomationSpecGitCommitSigningKeyTypeEnum? Type { get; set; }
}

/// <summary>Commit specifies how to commit to the git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGitCommit
{
    /// <summary>
    /// Author gives the email and optionally the name to use as the
    /// author of commits.
    /// </summary>
    [JsonPropertyName("author")]
    public required V1ImageUpdateAutomationSpecGitCommitAuthor Author { get; set; }

    /// <summary>
    /// MessageTemplate provides a template for the commit message,
    /// into which will be interpolated the details of the change made.
    /// Note: The `Updated` template field has been removed. Use `Changed` instead.
    /// </summary>
    [JsonPropertyName("messageTemplate")]
    public string? MessageTemplate { get; set; }

    /// <summary>
    /// MessageTemplateValues provides additional values to be available to the
    /// templating rendering.
    /// </summary>
    [JsonPropertyName("messageTemplateValues")]
    public IDictionary<string, string>? MessageTemplateValues { get; set; }

    /// <summary>
    /// SigningKey provides the option to sign commits with an OpenPGP or
    /// SSH signing key, referenced from a Secret. See SigningKey.
    /// </summary>
    [JsonPropertyName("signingKey")]
    public V1ImageUpdateAutomationSpecGitCommitSigningKey? SigningKey { get; set; }
}

/// <summary>
/// Push specifies how and where to push commits made by the
/// automation. If missing, commits are pushed (back) to
/// `.spec.checkout.branch` or its default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGitPush
{
    /// <summary>
    /// Branch specifies that commits should be pushed to the branch
    /// named. The branch is created using `.spec.checkout.branch` as the
    /// starting point, if it doesn&apos;t already exist.
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Options specifies the push options that are sent to the Git
    /// server when performing a push operation. For details, see:
    /// https://git-scm.com/docs/git-push#Documentation/git-push.txt---push-optionltoptiongt
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// Refspec specifies the Git Refspec to use for a push operation.
    /// If both Branch and Refspec are provided, then the commit is pushed
    /// to the branch and also using the specified refspec.
    /// For more details about Git Refspecs, see:
    /// https://git-scm.com/book/en/v2/Git-Internals-The-Refspec
    /// </summary>
    [JsonPropertyName("refspec")]
    public string? Refspec { get; set; }
}

/// <summary>
/// GitSpec contains all the git-specific definitions. This is
/// technically optional, but in practice mandatory until there are
/// other kinds of source allowed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecGit
{
    /// <summary>
    /// Checkout gives the parameters for cloning the git repository,
    /// ready to make changes. If not present, the `spec.ref` field from the
    /// referenced `GitRepository` or its default will be used.
    /// </summary>
    [JsonPropertyName("checkout")]
    public V1ImageUpdateAutomationSpecGitCheckout? Checkout { get; set; }

    /// <summary>Commit specifies how to commit to the git repository.</summary>
    [JsonPropertyName("commit")]
    public required V1ImageUpdateAutomationSpecGitCommit Commit { get; set; }

    /// <summary>
    /// Push specifies how and where to push commits made by the
    /// automation. If missing, commits are pushed (back) to
    /// `.spec.checkout.branch` or its default.
    /// </summary>
    [JsonPropertyName("push")]
    public V1ImageUpdateAutomationSpecGitPush? Push { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecPolicySelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// PolicySelector allows to filter applied policies based on labels.
/// By default includes all policies in namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecPolicySelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ImageUpdateAutomationSpecPolicySelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Kind of the referent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImageUpdateAutomationSpecSourceRefKindEnum>))]
public enum V1ImageUpdateAutomationSpecSourceRefKindEnum
{
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository
}

/// <summary>
/// SourceRef refers to the resource giving access details
/// to a git repository.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecSourceRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public V1ImageUpdateAutomationSpecSourceRefKindEnum? Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent, defaults to the namespace of the Kubernetes resource object that contains the reference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Strategy names the strategy to be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImageUpdateAutomationSpecUpdateStrategyEnum>))]
public enum V1ImageUpdateAutomationSpecUpdateStrategyEnum
{
    [EnumMember(Value = "Setters"), JsonStringEnumMemberName("Setters")]
    Setters
}

/// <summary>
/// Update gives the specification for how to update the files in
/// the repository. This can be left empty, to use the default
/// value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpecUpdate
{
    /// <summary>
    /// Path to the directory containing the manifests to be updated.
    /// Defaults to &apos;None&apos;, which translates to the root path
    /// of the GitRepositoryRef.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Strategy names the strategy to be used.</summary>
    [JsonPropertyName("strategy")]
    public V1ImageUpdateAutomationSpecUpdateStrategyEnum? Strategy { get; set; }
}

/// <summary>ImageUpdateAutomationSpec defines the desired state of ImageUpdateAutomation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationSpec
{
    /// <summary>
    /// GitSpec contains all the git-specific definitions. This is
    /// technically optional, but in practice mandatory until there are
    /// other kinds of source allowed.
    /// </summary>
    [JsonPropertyName("git")]
    public V1ImageUpdateAutomationSpecGit? Git { get; set; }

    /// <summary>
    /// Interval gives an lower bound for how often the automation
    /// run should be attempted.
    /// </summary>
    [JsonPropertyName("interval")]
    public required string Interval { get; set; }

    /// <summary>
    /// PolicySelector allows to filter applied policies based on labels.
    /// By default includes all policies in namespace.
    /// </summary>
    [JsonPropertyName("policySelector")]
    public V1ImageUpdateAutomationSpecPolicySelector? PolicySelector { get; set; }

    /// <summary>
    /// SourceRef refers to the resource giving access details
    /// to a git repository.
    /// </summary>
    [JsonPropertyName("sourceRef")]
    public required V1ImageUpdateAutomationSpecSourceRef SourceRef { get; set; }

    /// <summary>
    /// Suspend tells the controller to not run this automation, until
    /// it is unset (or set to false). Defaults to false.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// Update gives the specification for how to update the files in
    /// the repository. This can be left empty, to use the default
    /// value.
    /// </summary>
    [JsonPropertyName("update")]
    public V1ImageUpdateAutomationSpecUpdate? Update { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImageUpdateAutomationStatusConditionsStatusEnum>))]
public enum V1ImageUpdateAutomationStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1ImageUpdateAutomationStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ImageRef represents an image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationStatusObservedPolicies
{
    /// <summary>Digest is the image&apos;s digest.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Name is the bare image&apos;s name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tag is the image&apos;s tag.</summary>
    [JsonPropertyName("tag")]
    public required string Tag { get; set; }
}

/// <summary>ImageUpdateAutomationStatus defines the observed state of ImageUpdateAutomation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageUpdateAutomationStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1ImageUpdateAutomationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastAutomationRunTime records the last time the controller ran
    /// this automation through to completion (even if no updates were
    /// made).
    /// </summary>
    [JsonPropertyName("lastAutomationRunTime")]
    public DateTime? LastAutomationRunTime { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// LastPushCommit records the SHA1 of the last commit made by the
    /// controller, for this automation object
    /// </summary>
    [JsonPropertyName("lastPushCommit")]
    public string? LastPushCommit { get; set; }

    /// <summary>LastPushTime records the time of the last pushed change.</summary>
    [JsonPropertyName("lastPushTime")]
    public DateTime? LastPushTime { get; set; }

    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// ObservedPolicies is the list of observed ImagePolicies that were
    /// considered by the ImageUpdateAutomation update process.
    /// </summary>
    [JsonPropertyName("observedPolicies")]
    public IDictionary<string, V1ImageUpdateAutomationStatusObservedPolicies>? ObservedPolicies { get; set; }

    /// <summary>
    /// ObservedPolicies []ObservedPolicy `json:&quot;observedPolicies,omitempty&quot;`
    /// ObservedSourceRevision is the last observed source revision. This can be
    /// used to determine if the source has been updated since last observation.
    /// </summary>
    [JsonPropertyName("observedSourceRevision")]
    public string? ObservedSourceRevision { get; set; }
}

/// <summary>ImageUpdateAutomation is the Schema for the imageupdateautomations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageUpdateAutomation : IKubernetesObject<V1ObjectMeta>, ISpec<V1ImageUpdateAutomationSpec?>, IStatus<V1ImageUpdateAutomationStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageUpdateAutomation";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imageupdateautomations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "image.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageUpdateAutomation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageUpdateAutomationSpec defines the desired state of ImageUpdateAutomation</summary>
    [JsonPropertyName("spec")]
    public V1ImageUpdateAutomationSpec? Spec { get; set; }

    /// <summary>ImageUpdateAutomationStatus defines the observed state of ImageUpdateAutomation</summary>
    [JsonPropertyName("status")]
    public V1ImageUpdateAutomationStatus? Status { get; set; }
}
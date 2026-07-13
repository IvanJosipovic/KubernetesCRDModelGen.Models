#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>Receiver is the Schema for the receivers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ReceiverList : IKubernetesObject<V1ListMeta>, IItems<V1Receiver>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ReceiverList";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "receivers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReceiverList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Receiver objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Receiver> Items { get; set; }
}

/// <summary>
/// OIDCValidation is a CEL boolean expression evaluated against the OIDC token
/// claims and variables of a &apos;generic-oidc&apos; Receiver.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpecOidcProvidersValidations
{
    /// <summary>Expression is the CEL boolean expression to evaluate.</summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>Message is returned to the caller when the expression evaluates to false.</summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}

/// <summary>
/// OIDCVariable is a named CEL expression evaluated against the OIDC token
/// claims of a &apos;generic-oidc&apos; Receiver.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpecOidcProvidersVariables
{
    /// <summary>Expression is the CEL expression that defines the variable value.</summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>Name is the variable name; it must be a valid CEL identifier.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// OIDCProvider configures an OIDC issuer used to authenticate requests for a
/// &apos;generic-oidc&apos; Receiver.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpecOidcProviders
{
    /// <summary>
    /// Audience is the expected audience (&apos;aud&apos; claim) for tokens issued by
    /// this provider. Defaults to &apos;notification-controller&apos;.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// IssuerURL is the OIDC issuer URL used for provider discovery. It must
    /// match the &apos;iss&apos; claim of tokens issued by this provider.
    /// </summary>
    [JsonPropertyName("issuerURL")]
    public required string IssuerURL { get; set; }

    /// <summary>
    /// Validations is the list of CEL boolean expressions evaluated against the
    /// token claims and the variables. The request is accepted only if all of
    /// them evaluate to true; the message of each failing expression is returned
    /// to the caller.
    /// 
    /// At least one validation is required. A valid signature alone does not
    /// authorize a request: public issuers issue tokens to any caller on the
    /// platform, so the validations must constrain the caller&apos;s identity claims
    /// (e.g. &apos;repository_owner&apos; for GitHub Actions).
    /// </summary>
    [JsonPropertyName("validations")]
    public required IList<V1ReceiverSpecOidcProvidersValidations> Validations { get; set; }

    /// <summary>
    /// Variables is an optional list of named CEL expressions, evaluated in order
    /// and exposed as &apos;vars.&lt;name&gt; &apos;. Each expression can read the token claims
    /// via &apos;claims&apos; and any variable defined before it. Use it to share
    /// sub-expressions across validations.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V1ReceiverSpecOidcProvidersVariables>? Variables { get; set; }
}

/// <summary>Kind of the referent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ReceiverSpecResourcesKindEnum>))]
public enum V1ReceiverSpecResourcesKindEnum
{
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "Kustomization"), JsonStringEnumMemberName("Kustomization")]
    Kustomization,
    [EnumMember(Value = "HelmRelease"), JsonStringEnumMemberName("HelmRelease")]
    HelmRelease,
    [EnumMember(Value = "HelmChart"), JsonStringEnumMemberName("HelmChart")]
    HelmChart,
    [EnumMember(Value = "HelmRepository"), JsonStringEnumMemberName("HelmRepository")]
    HelmRepository,
    [EnumMember(Value = "ImageRepository"), JsonStringEnumMemberName("ImageRepository")]
    ImageRepository,
    [EnumMember(Value = "ImagePolicy"), JsonStringEnumMemberName("ImagePolicy")]
    ImagePolicy,
    [EnumMember(Value = "ImageUpdateAutomation"), JsonStringEnumMemberName("ImageUpdateAutomation")]
    ImageUpdateAutomation,
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    OCIRepository,
    [EnumMember(Value = "ArtifactGenerator"), JsonStringEnumMemberName("ArtifactGenerator")]
    ArtifactGenerator,
    [EnumMember(Value = "ExternalArtifact"), JsonStringEnumMemberName("ExternalArtifact")]
    ExternalArtifact
}

/// <summary>
/// ReceiverResource references a resource to be notified about changes, with an
/// optional per-resource CEL filter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpecResources
{
    /// <summary>API version of the referent</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Filter is a CEL expression expected to return a boolean that is evaluated
    /// for each resource matched by this reference when a webhook is received,
    /// in addition to the top-level resourceFilter. A reconciliation is requested
    /// only when both expressions (when set) return true.
    /// The expression can read the resource metadata via &apos;res&apos; and the webhook
    /// request body via &apos;req&apos;. For generic-oidc receivers, the verified OIDC
    /// token claims are also available via &apos;claims&apos;.
    /// When the expression is specified the controller will parse it and mark
    /// the object as terminally failed if the expression is invalid or does not
    /// return a boolean.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Kind of the referent</summary>
    [JsonPropertyName("kind")]
    public required V1ReceiverSpecResourcesKindEnum Kind { get; set; }

    /// <summary>
    /// MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// MatchLabels requires the name to be set to `*`.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>
    /// Name of the referent
    /// If multiple resources are targeted `*` may be set.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// SecretRef specifies the Secret containing the token used
/// to validate the payload authenticity. The Secret must contain a &apos;token&apos;
/// key. For GCR receivers, the Secret must also contain an &apos;email&apos; key
/// with the IAM service account email configured on the Pub/Sub push
/// subscription, and an &apos;audience&apos; key with the expected OIDC token audience.
/// 
/// Required for all receiver types except &apos;generic-oidc&apos;, which authenticates
/// requests using the OIDC token instead and must not set this field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Type of webhook sender, used to determine
/// the validation procedure and payload deserialization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ReceiverSpecTypeEnum>))]
public enum V1ReceiverSpecTypeEnum
{
    [EnumMember(Value = "generic"), JsonStringEnumMemberName("generic")]
    Generic,
    [EnumMember(Value = "generic-hmac"), JsonStringEnumMemberName("generic-hmac")]
    GenericHmac,
    [EnumMember(Value = "generic-oidc"), JsonStringEnumMemberName("generic-oidc")]
    GenericOidc,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github,
    [EnumMember(Value = "gitlab"), JsonStringEnumMemberName("gitlab")]
    Gitlab,
    [EnumMember(Value = "bitbucket"), JsonStringEnumMemberName("bitbucket")]
    Bitbucket,
    [EnumMember(Value = "harbor"), JsonStringEnumMemberName("harbor")]
    Harbor,
    [EnumMember(Value = "dockerhub"), JsonStringEnumMemberName("dockerhub")]
    Dockerhub,
    [EnumMember(Value = "quay"), JsonStringEnumMemberName("quay")]
    Quay,
    [EnumMember(Value = "gcr"), JsonStringEnumMemberName("gcr")]
    Gcr,
    [EnumMember(Value = "nexus"), JsonStringEnumMemberName("nexus")]
    Nexus,
    [EnumMember(Value = "acr"), JsonStringEnumMemberName("acr")]
    Acr,
    [EnumMember(Value = "cdevents"), JsonStringEnumMemberName("cdevents")]
    Cdevents
}

/// <summary>ReceiverSpec defines the desired state of the Receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpec
{
    /// <summary>
    /// Events specifies the list of event types to handle,
    /// e.g. &apos;push&apos; for GitHub or &apos;Push Hook&apos; for GitLab.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Interval at which to reconcile the Receiver with its Secret references.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>
    /// OIDCProviders specifies the OIDC providers used to authenticate incoming
    /// requests when Type is &apos;generic-oidc&apos;. The provider whose IssuerURL matches
    /// the token&apos;s &apos;iss&apos; claim is used to verify the token signature, expiration
    /// and audience, and to evaluate the configured CEL validations against the
    /// token claims.
    /// </summary>
    [JsonPropertyName("oidcProviders")]
    public IList<V1ReceiverSpecOidcProviders>? OidcProviders { get; set; }

    /// <summary>
    /// ResourceFilter is a CEL expression expected to return a boolean that is
    /// evaluated for each resource referenced in the Resources field when a
    /// webhook is received. If the expression returns false then the controller
    /// will not request a reconciliation for the resource.
    /// The expression can read the resource metadata via &apos;res&apos; and the webhook
    /// request body via &apos;req&apos;. For generic-oidc receivers, the verified OIDC
    /// token claims are also available via &apos;claims&apos;.
    /// When the expression is specified the controller will parse it and mark
    /// the object as terminally failed if the expression is invalid or does not
    /// return a boolean.
    /// </summary>
    [JsonPropertyName("resourceFilter")]
    public string? ResourceFilter { get; set; }

    /// <summary>A list of resources to be notified about changes.</summary>
    [JsonPropertyName("resources")]
    public required IList<V1ReceiverSpecResources> Resources { get; set; }

    /// <summary>
    /// SecretRef specifies the Secret containing the token used
    /// to validate the payload authenticity. The Secret must contain a &apos;token&apos;
    /// key. For GCR receivers, the Secret must also contain an &apos;email&apos; key
    /// with the IAM service account email configured on the Pub/Sub push
    /// subscription, and an &apos;audience&apos; key with the expected OIDC token audience.
    /// 
    /// Required for all receiver types except &apos;generic-oidc&apos;, which authenticates
    /// requests using the OIDC token instead and must not set this field.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1ReceiverSpecSecretRef? SecretRef { get; set; }

    /// <summary>
    /// Suspend tells the controller to suspend subsequent
    /// events handling for this receiver.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// Type of webhook sender, used to determine
    /// the validation procedure and payload deserialization.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1ReceiverSpecTypeEnum Type { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ReceiverStatusConditionsStatusEnum>))]
public enum V1ReceiverStatusConditionsStatusEnum
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
public partial class V1ReceiverStatusConditions
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
    public required V1ReceiverStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ReceiverStatus defines the observed state of the Receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverStatus
{
    /// <summary>Conditions holds the conditions for the Receiver.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ReceiverStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation of the Receiver object.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// WebhookPath is the generated incoming webhook address in the format
    /// of &apos;/hook/sha256sum(token+name+namespace)&apos;.
    /// </summary>
    [JsonPropertyName("webhookPath")]
    public string? WebhookPath { get; set; }
}

/// <summary>Receiver is the Schema for the receivers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Receiver : IKubernetesObject<V1ObjectMeta>, ISpec<V1ReceiverSpec?>, IStatus<V1ReceiverStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Receiver";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "receivers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Receiver";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReceiverSpec defines the desired state of the Receiver.</summary>
    [JsonPropertyName("spec")]
    public V1ReceiverSpec? Spec { get; set; }

    /// <summary>ReceiverStatus defines the observed state of the Receiver.</summary>
    [JsonPropertyName("status")]
    public V1ReceiverStatus? Status { get; set; }
}
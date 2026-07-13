#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.oauth.databricks.m.crossplane.io;
/// <summary>AccountFederationPolicy is the Schema for the AccountFederationPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountFederationPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccountFederationPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountFederationPolicyList";
    public const string KubeGroup = "oauth.databricks.m.crossplane.io";
    public const string KubePluralName = "accountfederationpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "oauth.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountFederationPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AccountFederationPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AccountFederationPolicy> Items { get; set; }
}

/// <summary>(OidcFederationPolicy, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicySpecForProviderOidcPolicy
{
    /// <summary>
    /// The allowed token audiences, as specified in the &apos;aud&apos; claim of federated tokens.
    /// The audience identifier is intended to represent the recipient of the token.
    /// Can be any non-empty string value. As long as the audience in the token matches
    /// at least one audience in the policy, the token is considered a match. If audiences
    /// is unspecified, defaults to your Databricks account id
    /// </summary>
    [JsonPropertyName("audiences")]
    public IList<string>? Audiences { get; set; }

    /// <summary>The required token issuer, as specified in the &apos;iss&apos; claim of federated tokens</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// The public keys used to validate the signature of federated tokens, in JWKS format.
    /// Most use cases should not need to specify this field. If jwks_uri and jwks_json
    /// are both unspecified (recommended), Databricks automatically fetches the public
    /// keys from your issuer’s well known endpoint. Databricks strongly recommends
    /// relying on your issuer’s well known endpoint for discovering public keys
    /// </summary>
    [JsonPropertyName("jwksJson")]
    public string? JwksJson { get; set; }

    /// <summary>
    /// URL of the public keys used to validate the signature of federated tokens, in
    /// JWKS format. Most use cases should not need to specify this field. If jwks_uri
    /// and jwks_json are both unspecified (recommended), Databricks automatically
    /// fetches the public keys from your issuer’s well known endpoint. Databricks
    /// strongly recommends relying on your issuer’s well known endpoint for discovering
    /// public keys
    /// </summary>
    [JsonPropertyName("jwksUri")]
    public string? JwksUri { get; set; }

    /// <summary>
    /// The required token subject, as specified in the subject claim of federated tokens.
    /// Must be specified for service principal federation policies. Must not be specified
    /// for account federation policies
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The claim that contains the subject of the token. If unspecified, the default value
    /// is &apos;sub&apos;
    /// </summary>
    [JsonPropertyName("subjectClaim")]
    public string? SubjectClaim { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicySpecForProvider
{
    /// <summary>Description of the federation policy</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>(OidcFederationPolicy, optional)</summary>
    [JsonPropertyName("oidcPolicy")]
    public V1beta1AccountFederationPolicySpecForProviderOidcPolicy? OidcPolicy { get; set; }

    /// <summary>The ID of the federation policy. Output only</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>The service principal ID that this federation policy applies to. Output only. Only set for service principal federation policies</summary>
    [JsonPropertyName("servicePrincipalId")]
    public double? ServicePrincipalId { get; set; }
}

/// <summary>(OidcFederationPolicy, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicySpecInitProviderOidcPolicy
{
    /// <summary>
    /// The allowed token audiences, as specified in the &apos;aud&apos; claim of federated tokens.
    /// The audience identifier is intended to represent the recipient of the token.
    /// Can be any non-empty string value. As long as the audience in the token matches
    /// at least one audience in the policy, the token is considered a match. If audiences
    /// is unspecified, defaults to your Databricks account id
    /// </summary>
    [JsonPropertyName("audiences")]
    public IList<string>? Audiences { get; set; }

    /// <summary>The required token issuer, as specified in the &apos;iss&apos; claim of federated tokens</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// The public keys used to validate the signature of federated tokens, in JWKS format.
    /// Most use cases should not need to specify this field. If jwks_uri and jwks_json
    /// are both unspecified (recommended), Databricks automatically fetches the public
    /// keys from your issuer’s well known endpoint. Databricks strongly recommends
    /// relying on your issuer’s well known endpoint for discovering public keys
    /// </summary>
    [JsonPropertyName("jwksJson")]
    public string? JwksJson { get; set; }

    /// <summary>
    /// URL of the public keys used to validate the signature of federated tokens, in
    /// JWKS format. Most use cases should not need to specify this field. If jwks_uri
    /// and jwks_json are both unspecified (recommended), Databricks automatically
    /// fetches the public keys from your issuer’s well known endpoint. Databricks
    /// strongly recommends relying on your issuer’s well known endpoint for discovering
    /// public keys
    /// </summary>
    [JsonPropertyName("jwksUri")]
    public string? JwksUri { get; set; }

    /// <summary>
    /// The required token subject, as specified in the subject claim of federated tokens.
    /// Must be specified for service principal federation policies. Must not be specified
    /// for account federation policies
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The claim that contains the subject of the token. If unspecified, the default value
    /// is &apos;sub&apos;
    /// </summary>
    [JsonPropertyName("subjectClaim")]
    public string? SubjectClaim { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicySpecInitProvider
{
    /// <summary>Description of the federation policy</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>(OidcFederationPolicy, optional)</summary>
    [JsonPropertyName("oidcPolicy")]
    public V1beta1AccountFederationPolicySpecInitProviderOidcPolicy? OidcPolicy { get; set; }

    /// <summary>The ID of the federation policy. Output only</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>The service principal ID that this federation policy applies to. Output only. Only set for service principal federation policies</summary>
    [JsonPropertyName("servicePrincipalId")]
    public double? ServicePrincipalId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountFederationPolicySpecManagementPoliciesEnum>))]
public enum V1beta1AccountFederationPolicySpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AccountFederationPolicySpec defines the desired state of AccountFederationPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1AccountFederationPolicySpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccountFederationPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AccountFederationPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccountFederationPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccountFederationPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>(OidcFederationPolicy, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicyStatusAtProviderOidcPolicy
{
    /// <summary>
    /// The allowed token audiences, as specified in the &apos;aud&apos; claim of federated tokens.
    /// The audience identifier is intended to represent the recipient of the token.
    /// Can be any non-empty string value. As long as the audience in the token matches
    /// at least one audience in the policy, the token is considered a match. If audiences
    /// is unspecified, defaults to your Databricks account id
    /// </summary>
    [JsonPropertyName("audiences")]
    public IList<string>? Audiences { get; set; }

    /// <summary>The required token issuer, as specified in the &apos;iss&apos; claim of federated tokens</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// The public keys used to validate the signature of federated tokens, in JWKS format.
    /// Most use cases should not need to specify this field. If jwks_uri and jwks_json
    /// are both unspecified (recommended), Databricks automatically fetches the public
    /// keys from your issuer’s well known endpoint. Databricks strongly recommends
    /// relying on your issuer’s well known endpoint for discovering public keys
    /// </summary>
    [JsonPropertyName("jwksJson")]
    public string? JwksJson { get; set; }

    /// <summary>
    /// URL of the public keys used to validate the signature of federated tokens, in
    /// JWKS format. Most use cases should not need to specify this field. If jwks_uri
    /// and jwks_json are both unspecified (recommended), Databricks automatically
    /// fetches the public keys from your issuer’s well known endpoint. Databricks
    /// strongly recommends relying on your issuer’s well known endpoint for discovering
    /// public keys
    /// </summary>
    [JsonPropertyName("jwksUri")]
    public string? JwksUri { get; set; }

    /// <summary>
    /// The required token subject, as specified in the subject claim of federated tokens.
    /// Must be specified for service principal federation policies. Must not be specified
    /// for account federation policies
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The claim that contains the subject of the token. If unspecified, the default value
    /// is &apos;sub&apos;
    /// </summary>
    [JsonPropertyName("subjectClaim")]
    public string? SubjectClaim { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicyStatusAtProvider
{
    /// <summary>Creation time of the federation policy</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Description of the federation policy</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>(OidcFederationPolicy, optional)</summary>
    [JsonPropertyName("oidcPolicy")]
    public V1beta1AccountFederationPolicyStatusAtProviderOidcPolicy? OidcPolicy { get; set; }

    /// <summary>The ID of the federation policy. Output only</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>The service principal ID that this federation policy applies to. Output only. Only set for service principal federation policies</summary>
    [JsonPropertyName("servicePrincipalId")]
    public double? ServicePrincipalId { get; set; }

    /// <summary>Unique, immutable id of the federation policy</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Last update time of the federation policy</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicyStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>AccountFederationPolicyStatus defines the observed state of AccountFederationPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountFederationPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AccountFederationPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccountFederationPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AccountFederationPolicy is the Schema for the AccountFederationPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountFederationPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccountFederationPolicySpec>, IStatus<V1beta1AccountFederationPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountFederationPolicy";
    public const string KubeGroup = "oauth.databricks.m.crossplane.io";
    public const string KubePluralName = "accountfederationpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "oauth.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountFederationPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccountFederationPolicySpec defines the desired state of AccountFederationPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AccountFederationPolicySpec Spec { get; set; }

    /// <summary>AccountFederationPolicyStatus defines the observed state of AccountFederationPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccountFederationPolicyStatus? Status { get; set; }
}
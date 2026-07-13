#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elasticsearch.aws.m.upbound.io;
/// <summary>DomainSAMLOptions is the Schema for the DomainSAMLOptionss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainSAMLOptionsList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DomainSAMLOptions>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainSAMLOptionsList";
    public const string KubeGroup = "elasticsearch.aws.m.upbound.io";
    public const string KubePluralName = "domainsamloptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticsearch.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainSAMLOptionsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DomainSAMLOptions objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DomainSAMLOptions> Items { get; set; }
}

/// <summary>Information from your identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpecForProviderSamlOptionsIdp
{
    /// <summary>The unique Entity ID of the application in SAML Identity Provider.</summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    /// <summary>The Metadata of the SAML application in xml format.</summary>
    [JsonPropertyName("metadataContent")]
    public string? MetadataContent { get; set; }
}

/// <summary>This username from the SAML IdP receives full permissions to the cluster, equivalent to a new master user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpecForProviderSamlOptionsMasterUserNameSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The SAML authentication options for an AWS Elasticsearch Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpecForProviderSamlOptions
{
    /// <summary>Whether SAML authentication is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Information from your identity provider.</summary>
    [JsonPropertyName("idp")]
    public V1beta1DomainSAMLOptionsSpecForProviderSamlOptionsIdp? Idp { get; set; }

    /// <summary>This backend role from the SAML IdP receives full permissions to the cluster, equivalent to a new master user.</summary>
    [JsonPropertyName("masterBackendRole")]
    public string? MasterBackendRole { get; set; }

    /// <summary>This username from the SAML IdP receives full permissions to the cluster, equivalent to a new master user.</summary>
    [JsonPropertyName("masterUserNameSecretRef")]
    public V1beta1DomainSAMLOptionsSpecForProviderSamlOptionsMasterUserNameSecretRef? MasterUserNameSecretRef { get; set; }

    /// <summary>Element of the SAML assertion to use for backend roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Duration of a session in minutes after a user logs in. Default is 60. Maximum value is 1,440.</summary>
    [JsonPropertyName("sessionTimeoutMinutes")]
    public double? SessionTimeoutMinutes { get; set; }

    /// <summary>Custom SAML attribute to use for user names. Default is an empty string - &quot; &quot;. This will cause Elasticsearch to use the NameID element of the Subject, which is the default location for name identifiers in the SAML specification.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpecForProvider
{
    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The SAML authentication options for an AWS Elasticsearch Domain.</summary>
    [JsonPropertyName("samlOptions")]
    public V1beta1DomainSAMLOptionsSpecForProviderSamlOptions? SamlOptions { get; set; }
}

/// <summary>Information from your identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpecInitProviderSamlOptionsIdp
{
    /// <summary>The unique Entity ID of the application in SAML Identity Provider.</summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    /// <summary>The Metadata of the SAML application in xml format.</summary>
    [JsonPropertyName("metadataContent")]
    public string? MetadataContent { get; set; }
}

/// <summary>This username from the SAML IdP receives full permissions to the cluster, equivalent to a new master user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpecInitProviderSamlOptionsMasterUserNameSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The SAML authentication options for an AWS Elasticsearch Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpecInitProviderSamlOptions
{
    /// <summary>Whether SAML authentication is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Information from your identity provider.</summary>
    [JsonPropertyName("idp")]
    public V1beta1DomainSAMLOptionsSpecInitProviderSamlOptionsIdp? Idp { get; set; }

    /// <summary>This backend role from the SAML IdP receives full permissions to the cluster, equivalent to a new master user.</summary>
    [JsonPropertyName("masterBackendRole")]
    public string? MasterBackendRole { get; set; }

    /// <summary>This username from the SAML IdP receives full permissions to the cluster, equivalent to a new master user.</summary>
    [JsonPropertyName("masterUserNameSecretRef")]
    public V1beta1DomainSAMLOptionsSpecInitProviderSamlOptionsMasterUserNameSecretRef? MasterUserNameSecretRef { get; set; }

    /// <summary>Element of the SAML assertion to use for backend roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Duration of a session in minutes after a user logs in. Default is 60. Maximum value is 1,440.</summary>
    [JsonPropertyName("sessionTimeoutMinutes")]
    public double? SessionTimeoutMinutes { get; set; }

    /// <summary>Custom SAML attribute to use for user names. Default is an empty string - &quot; &quot;. This will cause Elasticsearch to use the NameID element of the Subject, which is the default location for name identifiers in the SAML specification.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
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
public partial class V1beta1DomainSAMLOptionsSpecInitProvider
{
    /// <summary>The SAML authentication options for an AWS Elasticsearch Domain.</summary>
    [JsonPropertyName("samlOptions")]
    public V1beta1DomainSAMLOptionsSpecInitProviderSamlOptions? SamlOptions { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSAMLOptionsSpecManagementPoliciesEnum>))]
public enum V1beta1DomainSAMLOptionsSpecManagementPoliciesEnum
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
public partial class V1beta1DomainSAMLOptionsSpecProviderConfigRef
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
public partial class V1beta1DomainSAMLOptionsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DomainSAMLOptionsSpec defines the desired state of DomainSAMLOptions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1DomainSAMLOptionsSpecForProvider ForProvider { get; set; }

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
    public V1beta1DomainSAMLOptionsSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DomainSAMLOptionsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainSAMLOptionsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainSAMLOptionsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Information from your identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsStatusAtProviderSamlOptionsIdp
{
    /// <summary>The unique Entity ID of the application in SAML Identity Provider.</summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    /// <summary>The Metadata of the SAML application in xml format.</summary>
    [JsonPropertyName("metadataContent")]
    public string? MetadataContent { get; set; }
}

/// <summary>The SAML authentication options for an AWS Elasticsearch Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsStatusAtProviderSamlOptions
{
    /// <summary>Whether SAML authentication is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Information from your identity provider.</summary>
    [JsonPropertyName("idp")]
    public V1beta1DomainSAMLOptionsStatusAtProviderSamlOptionsIdp? Idp { get; set; }

    /// <summary>This backend role from the SAML IdP receives full permissions to the cluster, equivalent to a new master user.</summary>
    [JsonPropertyName("masterBackendRole")]
    public string? MasterBackendRole { get; set; }

    /// <summary>Element of the SAML assertion to use for backend roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Duration of a session in minutes after a user logs in. Default is 60. Maximum value is 1,440.</summary>
    [JsonPropertyName("sessionTimeoutMinutes")]
    public double? SessionTimeoutMinutes { get; set; }

    /// <summary>Custom SAML attribute to use for user names. Default is an empty string - &quot; &quot;. This will cause Elasticsearch to use the NameID element of the Subject, which is the default location for name identifiers in the SAML specification.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsStatusAtProvider
{
    /// <summary>The name of the domain the SAML options are associated with.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The SAML authentication options for an AWS Elasticsearch Domain.</summary>
    [JsonPropertyName("samlOptions")]
    public V1beta1DomainSAMLOptionsStatusAtProviderSamlOptions? SamlOptions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsStatusConditions
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

/// <summary>DomainSAMLOptionsStatus defines the observed state of DomainSAMLOptions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSAMLOptionsStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DomainSAMLOptionsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainSAMLOptionsStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DomainSAMLOptions is the Schema for the DomainSAMLOptionss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainSAMLOptions : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainSAMLOptionsSpec>, IStatus<V1beta1DomainSAMLOptionsStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainSAMLOptions";
    public const string KubeGroup = "elasticsearch.aws.m.upbound.io";
    public const string KubePluralName = "domainsamloptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticsearch.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainSAMLOptions";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSAMLOptionsSpec defines the desired state of DomainSAMLOptions</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DomainSAMLOptionsSpec Spec { get; set; }

    /// <summary>DomainSAMLOptionsStatus defines the observed state of DomainSAMLOptions.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainSAMLOptionsStatus? Status { get; set; }
}
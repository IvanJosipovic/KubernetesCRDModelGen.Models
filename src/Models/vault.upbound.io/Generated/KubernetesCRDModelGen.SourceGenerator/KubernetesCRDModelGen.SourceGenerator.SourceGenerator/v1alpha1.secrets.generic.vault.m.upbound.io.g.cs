#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.generic.vault.m.upbound.io;
/// <summary>Secret is the Schema for the Secrets API. Writes arbitrary data to a given path in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Secret>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretList";
    public const string KubeGroup = "generic.vault.m.upbound.io";
    public const string KubePluralName = "secrets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "generic.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Secret objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Secret> Items { get; set; }
}

/// <summary>
/// String containing a JSON-encoded object that will be
/// written as the secret data at the given path.
/// JSON-encoded secret data to write.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecForProviderDataJsonSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecForProvider
{
    /// <summary>
    /// String containing a JSON-encoded object that will be
    /// written as the secret data at the given path.
    /// JSON-encoded secret data to write.
    /// </summary>
    [JsonPropertyName("dataJsonSecretRef")]
    public V1alpha1SecretSpecForProviderDataJsonSecretRef? DataJsonSecretRef { get; set; }

    /// <summary>
    /// true/false.  Only applicable for kv-v2 stores.
    /// If set to true, permanently deletes all versions for
    /// the specified key. The default behavior is to only delete the latest version of the
    /// secret.
    /// Only applicable for kv-v2 stores. If set, permanently deletes all versions for the specified key.
    /// </summary>
    [JsonPropertyName("deleteAllVersions")]
    public bool? DeleteAllVersions { get; set; }

    /// <summary>
    /// true/false. Set this to true if your vault
    /// authentication is not able to read the data. Setting this to true will
    /// break drift detection. Defaults to false.
    /// Don&apos;t attempt to read the token from Vault if true; drift won&apos;t be detected.
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The full logical path at which to write the given data.
    /// To write data into the &quot;generic&quot; secret backend mounted in Vault by default,
    /// this should be prefixed with secret/. Writing to other backends with this
    /// resource is possible; consult each backend&apos;s documentation to see which
    /// endpoints support the PUT and DELETE methods.
    /// Full path where the generic secret will be written.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// String containing a JSON-encoded object that will be
/// written as the secret data at the given path.
/// JSON-encoded secret data to write.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpecInitProviderDataJsonSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
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
public partial class V1alpha1SecretSpecInitProvider
{
    /// <summary>
    /// String containing a JSON-encoded object that will be
    /// written as the secret data at the given path.
    /// JSON-encoded secret data to write.
    /// </summary>
    [JsonPropertyName("dataJsonSecretRef")]
    public required V1alpha1SecretSpecInitProviderDataJsonSecretRef DataJsonSecretRef { get; set; }

    /// <summary>
    /// true/false.  Only applicable for kv-v2 stores.
    /// If set to true, permanently deletes all versions for
    /// the specified key. The default behavior is to only delete the latest version of the
    /// secret.
    /// Only applicable for kv-v2 stores. If set, permanently deletes all versions for the specified key.
    /// </summary>
    [JsonPropertyName("deleteAllVersions")]
    public bool? DeleteAllVersions { get; set; }

    /// <summary>
    /// true/false. Set this to true if your vault
    /// authentication is not able to read the data. Setting this to true will
    /// break drift detection. Defaults to false.
    /// Don&apos;t attempt to read the token from Vault if true; drift won&apos;t be detected.
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The full logical path at which to write the given data.
    /// To write data into the &quot;generic&quot; secret backend mounted in Vault by default,
    /// this should be prefixed with secret/. Writing to other backends with this
    /// resource is possible; consult each backend&apos;s documentation to see which
    /// endpoints support the PUT and DELETE methods.
    /// Full path where the generic secret will be written.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretSpecManagementPoliciesEnum
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
public partial class V1alpha1SecretSpecProviderConfigRef
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
public partial class V1alpha1SecretSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecretSpec defines the desired state of Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SecretSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretStatusAtProvider
{
    /// <summary>
    /// true/false.  Only applicable for kv-v2 stores.
    /// If set to true, permanently deletes all versions for
    /// the specified key. The default behavior is to only delete the latest version of the
    /// secret.
    /// Only applicable for kv-v2 stores. If set, permanently deletes all versions for the specified key.
    /// </summary>
    [JsonPropertyName("deleteAllVersions")]
    public bool? DeleteAllVersions { get; set; }

    /// <summary>
    /// true/false. Set this to true if your vault
    /// authentication is not able to read the data. Setting this to true will
    /// break drift detection. Defaults to false.
    /// Don&apos;t attempt to read the token from Vault if true; drift won&apos;t be detected.
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The full logical path at which to write the given data.
    /// To write data into the &quot;generic&quot; secret backend mounted in Vault by default,
    /// this should be prefixed with secret/. Writing to other backends with this
    /// resource is possible; consult each backend&apos;s documentation to see which
    /// endpoints support the PUT and DELETE methods.
    /// Full path where the generic secret will be written.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretStatusConditions
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

/// <summary>SecretStatus defines the observed state of Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Secret is the Schema for the Secrets API. Writes arbitrary data to a given path in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Secret : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretSpec>, IStatus<V1alpha1SecretStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Secret";
    public const string KubeGroup = "generic.vault.m.upbound.io";
    public const string KubePluralName = "secrets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "generic.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Secret";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretSpec defines the desired state of Secret</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretSpec Spec { get; set; }

    /// <summary>SecretStatus defines the observed state of Secret.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretStatus? Status { get; set; }
}
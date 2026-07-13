#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.quota.vault.m.upbound.io;
/// <summary>LeaseCount is the Schema for the LeaseCounts API. Manage Lease Count Quota</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LeaseCountList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1LeaseCount>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LeaseCountList";
    public const string KubeGroup = "quota.vault.m.upbound.io";
    public const string KubePluralName = "leasecounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "quota.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LeaseCountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1LeaseCount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1LeaseCount> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LeaseCountSpecForProvider
{
    /// <summary>
    /// If set to true on a quota where path is set to a namespace, the same quota will be cumulatively applied to all child namespace. The inheritable parameter cannot be set to true if the path does not specify a namespace. Only the quotas associated with the root namespace are inheritable by default. Requires Vault 1.15+.
    /// If set to true on a quota where path is set to a namespace, the same quota will be cumulatively applied to all child namespace. The inheritable parameter cannot be set to true if the path does not specify a namespace. Only the quotas associated with the root namespace are inheritable by default.
    /// </summary>
    [JsonPropertyName("inheritable")]
    public bool? Inheritable { get; set; }

    /// <summary>
    /// The maximum number of leases to be allowed by the quota
    /// rule. The max_leases must be positive.
    /// The maximum number of leases to be allowed by the quota rule. The max_leases must be positive.
    /// </summary>
    [JsonPropertyName("maxLeases")]
    public double? MaxLeases { get; set; }

    /// <summary>
    /// Name of the rate limit quota
    /// The name of the quota.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    /// Path of the mount or namespace to apply the quota. A blank path configures a
    /// global rate limit quota. For example namespace1/ adds a quota to a full namespace,
    /// namespace1/auth/userpass adds a quota to userpass in namespace1.
    /// Updating this field on an existing quota can have &quot;moving&quot; effects. For example, updating
    /// auth/userpass to namespace1/auth/userpass moves this quota from being a global mount quota to
    /// a namespace specific mount quota. Note, namespaces are supported in Enterprise only.
    /// Path of the mount or namespace to apply the quota. A blank path configures a global lease count quota.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// If set on a quota where path is set to an auth mount with a concept of roles (such as /auth/approle/), this will make the quota restrict login requests to that mount that are made with the specified role.
    /// If set on a quota where path is set to an auth mount with a concept of roles (such as /auth/approle/), this will make the quota restrict login requests to that mount that are made with the specified role.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
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
public partial class V1alpha1LeaseCountSpecInitProvider
{
    /// <summary>
    /// If set to true on a quota where path is set to a namespace, the same quota will be cumulatively applied to all child namespace. The inheritable parameter cannot be set to true if the path does not specify a namespace. Only the quotas associated with the root namespace are inheritable by default. Requires Vault 1.15+.
    /// If set to true on a quota where path is set to a namespace, the same quota will be cumulatively applied to all child namespace. The inheritable parameter cannot be set to true if the path does not specify a namespace. Only the quotas associated with the root namespace are inheritable by default.
    /// </summary>
    [JsonPropertyName("inheritable")]
    public bool? Inheritable { get; set; }

    /// <summary>
    /// The maximum number of leases to be allowed by the quota
    /// rule. The max_leases must be positive.
    /// The maximum number of leases to be allowed by the quota rule. The max_leases must be positive.
    /// </summary>
    [JsonPropertyName("maxLeases")]
    public double? MaxLeases { get; set; }

    /// <summary>
    /// Name of the rate limit quota
    /// The name of the quota.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    /// Path of the mount or namespace to apply the quota. A blank path configures a
    /// global rate limit quota. For example namespace1/ adds a quota to a full namespace,
    /// namespace1/auth/userpass adds a quota to userpass in namespace1.
    /// Updating this field on an existing quota can have &quot;moving&quot; effects. For example, updating
    /// auth/userpass to namespace1/auth/userpass moves this quota from being a global mount quota to
    /// a namespace specific mount quota. Note, namespaces are supported in Enterprise only.
    /// Path of the mount or namespace to apply the quota. A blank path configures a global lease count quota.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// If set on a quota where path is set to an auth mount with a concept of roles (such as /auth/approle/), this will make the quota restrict login requests to that mount that are made with the specified role.
    /// If set on a quota where path is set to an auth mount with a concept of roles (such as /auth/approle/), this will make the quota restrict login requests to that mount that are made with the specified role.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1LeaseCountSpecManagementPoliciesEnum>))]
public enum V1alpha1LeaseCountSpecManagementPoliciesEnum
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
public partial class V1alpha1LeaseCountSpecProviderConfigRef
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
public partial class V1alpha1LeaseCountSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>LeaseCountSpec defines the desired state of LeaseCount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LeaseCountSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1LeaseCountSpecForProvider ForProvider { get; set; }

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
    public V1alpha1LeaseCountSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1LeaseCountSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1LeaseCountSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1LeaseCountSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LeaseCountStatusAtProvider
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// If set to true on a quota where path is set to a namespace, the same quota will be cumulatively applied to all child namespace. The inheritable parameter cannot be set to true if the path does not specify a namespace. Only the quotas associated with the root namespace are inheritable by default. Requires Vault 1.15+.
    /// If set to true on a quota where path is set to a namespace, the same quota will be cumulatively applied to all child namespace. The inheritable parameter cannot be set to true if the path does not specify a namespace. Only the quotas associated with the root namespace are inheritable by default.
    /// </summary>
    [JsonPropertyName("inheritable")]
    public bool? Inheritable { get; set; }

    /// <summary>
    /// The maximum number of leases to be allowed by the quota
    /// rule. The max_leases must be positive.
    /// The maximum number of leases to be allowed by the quota rule. The max_leases must be positive.
    /// </summary>
    [JsonPropertyName("maxLeases")]
    public double? MaxLeases { get; set; }

    /// <summary>
    /// Name of the rate limit quota
    /// The name of the quota.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    /// Path of the mount or namespace to apply the quota. A blank path configures a
    /// global rate limit quota. For example namespace1/ adds a quota to a full namespace,
    /// namespace1/auth/userpass adds a quota to userpass in namespace1.
    /// Updating this field on an existing quota can have &quot;moving&quot; effects. For example, updating
    /// auth/userpass to namespace1/auth/userpass moves this quota from being a global mount quota to
    /// a namespace specific mount quota. Note, namespaces are supported in Enterprise only.
    /// Path of the mount or namespace to apply the quota. A blank path configures a global lease count quota.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// If set on a quota where path is set to an auth mount with a concept of roles (such as /auth/approle/), this will make the quota restrict login requests to that mount that are made with the specified role.
    /// If set on a quota where path is set to an auth mount with a concept of roles (such as /auth/approle/), this will make the quota restrict login requests to that mount that are made with the specified role.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LeaseCountStatusConditions
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

/// <summary>LeaseCountStatus defines the observed state of LeaseCount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LeaseCountStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1LeaseCountStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1LeaseCountStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LeaseCount is the Schema for the LeaseCounts API. Manage Lease Count Quota</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LeaseCount : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1LeaseCountSpec>, IStatus<V1alpha1LeaseCountStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LeaseCount";
    public const string KubeGroup = "quota.vault.m.upbound.io";
    public const string KubePluralName = "leasecounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "quota.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LeaseCount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LeaseCountSpec defines the desired state of LeaseCount</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1LeaseCountSpec Spec { get; set; }

    /// <summary>LeaseCountStatus defines the observed state of LeaseCount.</summary>
    [JsonPropertyName("status")]
    public V1alpha1LeaseCountStatus? Status { get; set; }
}
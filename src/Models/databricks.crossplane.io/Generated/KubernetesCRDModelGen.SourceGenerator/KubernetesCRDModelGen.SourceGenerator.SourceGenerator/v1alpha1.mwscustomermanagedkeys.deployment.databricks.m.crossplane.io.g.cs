#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.m.crossplane.io;
/// <summary>
/// MwsCustomerManagedKeys is the Schema for the MwsCustomerManagedKeyss API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsCustomerManagedKeysList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsCustomerManagedKeys>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsCustomerManagedKeysList";
    public const string KubeGroup = "deployment.databricks.m.crossplane.io";
    public const string KubePluralName = "mwscustomermanagedkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsCustomerManagedKeysList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MwsCustomerManagedKeys objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MwsCustomerManagedKeys> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecForProviderAwsKeyInfo
{
    /// <summary>The AWS KMS key alias.</summary>
    [JsonPropertyName("keyAlias")]
    public string? KeyAlias { get; set; }

    /// <summary>The AWS KMS key&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }

    /// <summary>(Computed) The AWS region in which KMS key is deployed to. This is not required.</summary>
    [JsonPropertyName("keyRegion")]
    public string? KeyRegion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecForProviderGcpKeyInfo
{
    /// <summary>The GCP KMS key&apos;s resource name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
    [JsonPropertyName("awsKeyInfo")]
    public IList<V1alpha1MwsCustomerManagedKeysSpecForProviderAwsKeyInfo>? AwsKeyInfo { get; set; }

    /// <summary>(Integer) Time in epoch milliseconds when the customer key was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) ID of the encryption key configuration object.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
    [JsonPropertyName("gcpKeyInfo")]
    public IList<V1alpha1MwsCustomerManagedKeysSpecForProviderGcpKeyInfo>? GcpKeyInfo { get; set; }

    /// <summary>(since v0.3.4) List of use cases for which this key will be used. If you&apos;ve used the resource before, please add  Possible values are:</summary>
    [JsonPropertyName("useCases")]
    public IList<string>? UseCases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecInitProviderAwsKeyInfo
{
    /// <summary>The AWS KMS key alias.</summary>
    [JsonPropertyName("keyAlias")]
    public string? KeyAlias { get; set; }

    /// <summary>The AWS KMS key&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }

    /// <summary>(Computed) The AWS region in which KMS key is deployed to. This is not required.</summary>
    [JsonPropertyName("keyRegion")]
    public string? KeyRegion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecInitProviderGcpKeyInfo
{
    /// <summary>The GCP KMS key&apos;s resource name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
    [JsonPropertyName("awsKeyInfo")]
    public IList<V1alpha1MwsCustomerManagedKeysSpecInitProviderAwsKeyInfo>? AwsKeyInfo { get; set; }

    /// <summary>(Integer) Time in epoch milliseconds when the customer key was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) ID of the encryption key configuration object.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
    [JsonPropertyName("gcpKeyInfo")]
    public IList<V1alpha1MwsCustomerManagedKeysSpecInitProviderGcpKeyInfo>? GcpKeyInfo { get; set; }

    /// <summary>(since v0.3.4) List of use cases for which this key will be used. If you&apos;ve used the resource before, please add  Possible values are:</summary>
    [JsonPropertyName("useCases")]
    public IList<string>? UseCases { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsCustomerManagedKeysSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsCustomerManagedKeysSpecManagementPoliciesEnum
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecProviderConfigRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MwsCustomerManagedKeysSpec defines the desired state of MwsCustomerManagedKeys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1MwsCustomerManagedKeysSpecForProvider ForProvider { get; set; }

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
    public V1alpha1MwsCustomerManagedKeysSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1MwsCustomerManagedKeysSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsCustomerManagedKeysSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsCustomerManagedKeysSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysStatusAtProviderAwsKeyInfo
{
    /// <summary>The AWS KMS key alias.</summary>
    [JsonPropertyName("keyAlias")]
    public string? KeyAlias { get; set; }

    /// <summary>The AWS KMS key&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }

    /// <summary>(Computed) The AWS region in which KMS key is deployed to. This is not required.</summary>
    [JsonPropertyName("keyRegion")]
    public string? KeyRegion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysStatusAtProviderGcpKeyInfo
{
    /// <summary>The GCP KMS key&apos;s resource name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysStatusAtProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
    [JsonPropertyName("awsKeyInfo")]
    public IList<V1alpha1MwsCustomerManagedKeysStatusAtProviderAwsKeyInfo>? AwsKeyInfo { get; set; }

    /// <summary>(Integer) Time in epoch milliseconds when the customer key was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) ID of the encryption key configuration object.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
    [JsonPropertyName("gcpKeyInfo")]
    public IList<V1alpha1MwsCustomerManagedKeysStatusAtProviderGcpKeyInfo>? GcpKeyInfo { get; set; }

    /// <summary>Canonical unique identifier for the mws customer managed keys.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>(since v0.3.4) List of use cases for which this key will be used. If you&apos;ve used the resource before, please add  Possible values are:</summary>
    [JsonPropertyName("useCases")]
    public IList<string>? UseCases { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysStatusConditions
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

/// <summary>MwsCustomerManagedKeysStatus defines the observed state of MwsCustomerManagedKeys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsCustomerManagedKeysStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsCustomerManagedKeysStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsCustomerManagedKeysStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// MwsCustomerManagedKeys is the Schema for the MwsCustomerManagedKeyss API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsCustomerManagedKeys : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsCustomerManagedKeysSpec>, IStatus<V1alpha1MwsCustomerManagedKeysStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsCustomerManagedKeys";
    public const string KubeGroup = "deployment.databricks.m.crossplane.io";
    public const string KubePluralName = "mwscustomermanagedkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsCustomerManagedKeys";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsCustomerManagedKeysSpec defines the desired state of MwsCustomerManagedKeys</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MwsCustomerManagedKeysSpec Spec { get; set; }

    /// <summary>MwsCustomerManagedKeysStatus defines the observed state of MwsCustomerManagedKeys.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsCustomerManagedKeysStatus? Status { get; set; }
}
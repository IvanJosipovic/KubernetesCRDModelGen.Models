#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.mws.databricks.m.upbound.io;
/// <summary>CustomerManagedKeys is the Schema for the CustomerManagedKeyss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomerManagedKeysList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CustomerManagedKeys>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomerManagedKeysList";
    public const string KubeGroup = "mws.databricks.m.upbound.io";
    public const string KubePluralName = "customermanagedkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mws.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CustomerManagedKeysList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CustomerManagedKeys objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CustomerManagedKeys> Items { get; set; }
}

/// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysSpecForProviderAwsKeyInfo
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

/// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysSpecForProviderGcpKeyInfo
{
    /// <summary>The GCP KMS key&apos;s resource name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysSpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
    [JsonPropertyName("awsKeyInfo")]
    public V1beta1CustomerManagedKeysSpecForProviderAwsKeyInfo? AwsKeyInfo { get; set; }

    /// <summary>(Integer) Time in epoch milliseconds when the customer key was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) ID of the encryption key configuration object.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
    [JsonPropertyName("gcpKeyInfo")]
    public V1beta1CustomerManagedKeysSpecForProviderGcpKeyInfo? GcpKeyInfo { get; set; }

    /// <summary>(since v0.3.4) List of use cases for which this key will be used. If you&apos;ve used the resource before, please add  Possible values are:</summary>
    [JsonPropertyName("useCases")]
    public IList<string>? UseCases { get; set; }
}

/// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysSpecInitProviderAwsKeyInfo
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

/// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysSpecInitProviderGcpKeyInfo
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
public partial class V1beta1CustomerManagedKeysSpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
    [JsonPropertyName("awsKeyInfo")]
    public V1beta1CustomerManagedKeysSpecInitProviderAwsKeyInfo? AwsKeyInfo { get; set; }

    /// <summary>(Integer) Time in epoch milliseconds when the customer key was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) ID of the encryption key configuration object.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
    [JsonPropertyName("gcpKeyInfo")]
    public V1beta1CustomerManagedKeysSpecInitProviderGcpKeyInfo? GcpKeyInfo { get; set; }

    /// <summary>(since v0.3.4) List of use cases for which this key will be used. If you&apos;ve used the resource before, please add  Possible values are:</summary>
    [JsonPropertyName("useCases")]
    public IList<string>? UseCases { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomerManagedKeysSpecManagementPoliciesEnum>))]
public enum V1beta1CustomerManagedKeysSpecManagementPoliciesEnum
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
public partial class V1beta1CustomerManagedKeysSpecProviderConfigRef
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
public partial class V1beta1CustomerManagedKeysSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CustomerManagedKeysSpec defines the desired state of CustomerManagedKeys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1CustomerManagedKeysSpecForProvider ForProvider { get; set; }

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
    public V1beta1CustomerManagedKeysSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CustomerManagedKeysSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CustomerManagedKeysSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CustomerManagedKeysSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysStatusAtProviderAwsKeyInfo
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

/// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysStatusAtProviderGcpKeyInfo
{
    /// <summary>The GCP KMS key&apos;s resource name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysStatusAtProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with gcp_key_info</summary>
    [JsonPropertyName("awsKeyInfo")]
    public V1beta1CustomerManagedKeysStatusAtProviderAwsKeyInfo? AwsKeyInfo { get; set; }

    /// <summary>(Integer) Time in epoch milliseconds when the customer key was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) ID of the encryption key configuration object.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>This field is a block and is documented below. This conflicts with aws_key_info</summary>
    [JsonPropertyName("gcpKeyInfo")]
    public V1beta1CustomerManagedKeysStatusAtProviderGcpKeyInfo? GcpKeyInfo { get; set; }

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
public partial class V1beta1CustomerManagedKeysStatusConditions
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

/// <summary>CustomerManagedKeysStatus defines the observed state of CustomerManagedKeys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomerManagedKeysStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1CustomerManagedKeysStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CustomerManagedKeysStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CustomerManagedKeys is the Schema for the CustomerManagedKeyss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomerManagedKeys : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CustomerManagedKeysSpec>, IStatus<V1beta1CustomerManagedKeysStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomerManagedKeys";
    public const string KubeGroup = "mws.databricks.m.upbound.io";
    public const string KubePluralName = "customermanagedkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mws.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CustomerManagedKeys";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomerManagedKeysSpec defines the desired state of CustomerManagedKeys</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CustomerManagedKeysSpec Spec { get; set; }

    /// <summary>CustomerManagedKeysStatus defines the observed state of CustomerManagedKeys.</summary>
    [JsonPropertyName("status")]
    public V1beta1CustomerManagedKeysStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kmip.vault.upbound.io;
/// <summary>SecretRole is the Schema for the SecretRoles API. Provision KMIP Secret roles in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretRoleList";
    public const string KubeGroup = "kmip.vault.upbound.io";
    public const string KubePluralName = "secretroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kmip.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretRoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretRole objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretRole> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecDeletionPolicyEnum>))]
public enum V1alpha1SecretRoleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderPathRefPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecForProviderPathRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderPathRefPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecForProviderPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecForProviderPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecForProviderPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretScope in kmip to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecForProviderPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderPathSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecForProviderPathSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderPathSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecForProviderPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecForProviderPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecForProviderPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretScope in kmip to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderPathSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecForProviderPathSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderScopeRefPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecForProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderScopeRefPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecForProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecForProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecForProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretScope in kmip to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecForProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecForProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecForProviderScopeSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecForProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecForProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecForProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretScope in kmip to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProviderScopeSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecForProviderScopeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecForProvider
{
    /// <summary>Name of the ca to use, if absent use legacy ca</summary>
    [JsonPropertyName("ca")]
    public string? Ca { get; set; }

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
    /// Grant permission to use the KMIP Activate operation.
    /// Grant permission to use the KMIP Activate operation
    /// </summary>
    [JsonPropertyName("operationActivate")]
    public bool? OperationActivate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Add Attribute operation.
    /// Grant permission to use the KMIP Add Attribute operation
    /// </summary>
    [JsonPropertyName("operationAddAttribute")]
    public bool? OperationAddAttribute { get; set; }

    /// <summary>
    /// Grant all permissions to this role. May not be specified with any other operation_* params.
    /// Grant all permissions to this role. May not be specified with any other operation_* params
    /// </summary>
    [JsonPropertyName("operationAll")]
    public bool? OperationAll { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Create operation.
    /// Grant permission to use the KMIP Create operation
    /// </summary>
    [JsonPropertyName("operationCreate")]
    public bool? OperationCreate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Create Key Pair operation.
    /// Grant permission to use the KMIP Create Key Pair operation
    /// </summary>
    [JsonPropertyName("operationCreateKeyPair")]
    public bool? OperationCreateKeyPair { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Decrypt operation.
    /// Grant permission to use the KMIP Decrypt operation
    /// </summary>
    [JsonPropertyName("operationDecrypt")]
    public bool? OperationDecrypt { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Delete Attribute operation.
    /// Grant permission to use the KMIP Delete Attribute operation
    /// </summary>
    [JsonPropertyName("operationDeleteAttribute")]
    public bool? OperationDeleteAttribute { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Destroy operation.
    /// Grant permission to use the KMIP Destroy operation
    /// </summary>
    [JsonPropertyName("operationDestroy")]
    public bool? OperationDestroy { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Discover Version operation.
    /// Grant permission to use the KMIP Discover Version operation
    /// </summary>
    [JsonPropertyName("operationDiscoverVersions")]
    public bool? OperationDiscoverVersions { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Encrypt operation.
    /// Grant permission to use the KMIP Encrypt operation
    /// </summary>
    [JsonPropertyName("operationEncrypt")]
    public bool? OperationEncrypt { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get operation.
    /// Grant permission to use the KMIP Get operation
    /// </summary>
    [JsonPropertyName("operationGet")]
    public bool? OperationGet { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Atrribute List operation.
    /// Grant permission to use the KMIP Get Attribute List operation
    /// </summary>
    [JsonPropertyName("operationGetAttributeList")]
    public bool? OperationGetAttributeList { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Atrributes operation.
    /// Grant permission to use the KMIP Get Attributes operation
    /// </summary>
    [JsonPropertyName("operationGetAttributes")]
    public bool? OperationGetAttributes { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Import operation.
    /// Grant permission to use the KMIP Import operation
    /// </summary>
    [JsonPropertyName("operationImport")]
    public bool? OperationImport { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Locate operation.
    /// Grant permission to use the KMIP Locate operation
    /// </summary>
    [JsonPropertyName("operationLocate")]
    public bool? OperationLocate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP MAC operation.
    /// Grant permission to use the KMIP MAC operation
    /// </summary>
    [JsonPropertyName("operationMac")]
    public bool? OperationMac { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP MAC Verify operation.
    /// Grant permission to use the KMIP MAC Verify operation
    /// </summary>
    [JsonPropertyName("operationMacVerify")]
    public bool? OperationMacVerify { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Modify Attribute operation.
    /// Grant permission to use the KMIP Modify Attribute operation
    /// </summary>
    [JsonPropertyName("operationModifyAttribute")]
    public bool? OperationModifyAttribute { get; set; }

    /// <summary>
    /// Remove all permissions from this role. May not be specified with any other operation_* params.
    /// Remove all permissions from this role. May not be specified with any other operation_* params
    /// </summary>
    [JsonPropertyName("operationNone")]
    public bool? OperationNone { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Query operation.
    /// Grant permission to use the KMIP Query operation
    /// </summary>
    [JsonPropertyName("operationQuery")]
    public bool? OperationQuery { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Register operation.
    /// Grant permission to use the KMIP Register operation
    /// </summary>
    [JsonPropertyName("operationRegister")]
    public bool? OperationRegister { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Rekey operation.
    /// Grant permission to use the KMIP Rekey operation
    /// </summary>
    [JsonPropertyName("operationRekey")]
    public bool? OperationRekey { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Rekey Key Pair operation.
    /// Grant permission to use the KMIP Rekey Key Pair operation
    /// </summary>
    [JsonPropertyName("operationRekeyKeyPair")]
    public bool? OperationRekeyKeyPair { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Revoke operation.
    /// Grant permission to use the KMIP Revoke operation
    /// </summary>
    [JsonPropertyName("operationRevoke")]
    public bool? OperationRevoke { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP RNG Retrieve operation.
    /// Grant permission to use the KMIP RNG Retrieve operation
    /// </summary>
    [JsonPropertyName("operationRngRetrieve")]
    public bool? OperationRngRetrieve { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP RNG Seed operation.
    /// Grant permission to use the KMIP RNG Seed operation
    /// </summary>
    [JsonPropertyName("operationRngSeed")]
    public bool? OperationRngSeed { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Sign operation.
    /// Grant permission to use the KMIP Sign operation
    /// </summary>
    [JsonPropertyName("operationSign")]
    public bool? OperationSign { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Signature Verify operation.
    /// Grant permission to use the KMIP Signature Verify operation
    /// </summary>
    [JsonPropertyName("operationSignatureVerify")]
    public bool? OperationSignatureVerify { get; set; }

    /// <summary>
    /// The unique path this backend should be mounted at. Must
    /// not begin or end with a /. Defaults to kmip.
    /// Path where KMIP backend is mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Reference to a SecretScope in kmip to populate path.</summary>
    [JsonPropertyName("pathRef")]
    public V1alpha1SecretRoleSpecForProviderPathRef? PathRef { get; set; }

    /// <summary>Selector for a SecretScope in kmip to populate path.</summary>
    [JsonPropertyName("pathSelector")]
    public V1alpha1SecretRoleSpecForProviderPathSelector? PathSelector { get; set; }

    /// <summary>
    /// Name of the role.
    /// Name of the role
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// Name of the scope.
    /// Name of the scope
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a SecretScope in kmip to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1alpha1SecretRoleSpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a SecretScope in kmip to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1alpha1SecretRoleSpecForProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>
    /// Client certificate key bits, valid values depend on key type.
    /// Client certificate key bits, valid values depend on key type
    /// </summary>
    [JsonPropertyName("tlsClientKeyBits")]
    public double? TlsClientKeyBits { get; set; }

    /// <summary>
    /// Client certificate key type, rsa or ec.
    /// Client certificate key type, rsa or ec
    /// </summary>
    [JsonPropertyName("tlsClientKeyType")]
    public string? TlsClientKeyType { get; set; }

    /// <summary>
    /// Client certificate TTL in seconds.
    /// Client certificate TTL in seconds
    /// </summary>
    [JsonPropertyName("tlsClientTtl")]
    public double? TlsClientTtl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderPathRefPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderPathRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderPathRefPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecInitProviderPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecInitProviderPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretScope in kmip to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecInitProviderPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderPathSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderPathSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderPathSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecInitProviderPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecInitProviderPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretScope in kmip to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderPathSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecInitProviderPathSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderScopeRefPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderScopeRefPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecInitProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecInitProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretScope in kmip to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecInitProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretScope in kmip to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecInitProviderScopeSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecInitProviderScopeSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1SecretRoleSpecInitProvider
{
    /// <summary>Name of the ca to use, if absent use legacy ca</summary>
    [JsonPropertyName("ca")]
    public string? Ca { get; set; }

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
    /// Grant permission to use the KMIP Activate operation.
    /// Grant permission to use the KMIP Activate operation
    /// </summary>
    [JsonPropertyName("operationActivate")]
    public bool? OperationActivate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Add Attribute operation.
    /// Grant permission to use the KMIP Add Attribute operation
    /// </summary>
    [JsonPropertyName("operationAddAttribute")]
    public bool? OperationAddAttribute { get; set; }

    /// <summary>
    /// Grant all permissions to this role. May not be specified with any other operation_* params.
    /// Grant all permissions to this role. May not be specified with any other operation_* params
    /// </summary>
    [JsonPropertyName("operationAll")]
    public bool? OperationAll { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Create operation.
    /// Grant permission to use the KMIP Create operation
    /// </summary>
    [JsonPropertyName("operationCreate")]
    public bool? OperationCreate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Create Key Pair operation.
    /// Grant permission to use the KMIP Create Key Pair operation
    /// </summary>
    [JsonPropertyName("operationCreateKeyPair")]
    public bool? OperationCreateKeyPair { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Decrypt operation.
    /// Grant permission to use the KMIP Decrypt operation
    /// </summary>
    [JsonPropertyName("operationDecrypt")]
    public bool? OperationDecrypt { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Delete Attribute operation.
    /// Grant permission to use the KMIP Delete Attribute operation
    /// </summary>
    [JsonPropertyName("operationDeleteAttribute")]
    public bool? OperationDeleteAttribute { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Destroy operation.
    /// Grant permission to use the KMIP Destroy operation
    /// </summary>
    [JsonPropertyName("operationDestroy")]
    public bool? OperationDestroy { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Discover Version operation.
    /// Grant permission to use the KMIP Discover Version operation
    /// </summary>
    [JsonPropertyName("operationDiscoverVersions")]
    public bool? OperationDiscoverVersions { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Encrypt operation.
    /// Grant permission to use the KMIP Encrypt operation
    /// </summary>
    [JsonPropertyName("operationEncrypt")]
    public bool? OperationEncrypt { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get operation.
    /// Grant permission to use the KMIP Get operation
    /// </summary>
    [JsonPropertyName("operationGet")]
    public bool? OperationGet { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Atrribute List operation.
    /// Grant permission to use the KMIP Get Attribute List operation
    /// </summary>
    [JsonPropertyName("operationGetAttributeList")]
    public bool? OperationGetAttributeList { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Atrributes operation.
    /// Grant permission to use the KMIP Get Attributes operation
    /// </summary>
    [JsonPropertyName("operationGetAttributes")]
    public bool? OperationGetAttributes { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Import operation.
    /// Grant permission to use the KMIP Import operation
    /// </summary>
    [JsonPropertyName("operationImport")]
    public bool? OperationImport { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Locate operation.
    /// Grant permission to use the KMIP Locate operation
    /// </summary>
    [JsonPropertyName("operationLocate")]
    public bool? OperationLocate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP MAC operation.
    /// Grant permission to use the KMIP MAC operation
    /// </summary>
    [JsonPropertyName("operationMac")]
    public bool? OperationMac { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP MAC Verify operation.
    /// Grant permission to use the KMIP MAC Verify operation
    /// </summary>
    [JsonPropertyName("operationMacVerify")]
    public bool? OperationMacVerify { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Modify Attribute operation.
    /// Grant permission to use the KMIP Modify Attribute operation
    /// </summary>
    [JsonPropertyName("operationModifyAttribute")]
    public bool? OperationModifyAttribute { get; set; }

    /// <summary>
    /// Remove all permissions from this role. May not be specified with any other operation_* params.
    /// Remove all permissions from this role. May not be specified with any other operation_* params
    /// </summary>
    [JsonPropertyName("operationNone")]
    public bool? OperationNone { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Query operation.
    /// Grant permission to use the KMIP Query operation
    /// </summary>
    [JsonPropertyName("operationQuery")]
    public bool? OperationQuery { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Register operation.
    /// Grant permission to use the KMIP Register operation
    /// </summary>
    [JsonPropertyName("operationRegister")]
    public bool? OperationRegister { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Rekey operation.
    /// Grant permission to use the KMIP Rekey operation
    /// </summary>
    [JsonPropertyName("operationRekey")]
    public bool? OperationRekey { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Rekey Key Pair operation.
    /// Grant permission to use the KMIP Rekey Key Pair operation
    /// </summary>
    [JsonPropertyName("operationRekeyKeyPair")]
    public bool? OperationRekeyKeyPair { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Revoke operation.
    /// Grant permission to use the KMIP Revoke operation
    /// </summary>
    [JsonPropertyName("operationRevoke")]
    public bool? OperationRevoke { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP RNG Retrieve operation.
    /// Grant permission to use the KMIP RNG Retrieve operation
    /// </summary>
    [JsonPropertyName("operationRngRetrieve")]
    public bool? OperationRngRetrieve { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP RNG Seed operation.
    /// Grant permission to use the KMIP RNG Seed operation
    /// </summary>
    [JsonPropertyName("operationRngSeed")]
    public bool? OperationRngSeed { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Sign operation.
    /// Grant permission to use the KMIP Sign operation
    /// </summary>
    [JsonPropertyName("operationSign")]
    public bool? OperationSign { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Signature Verify operation.
    /// Grant permission to use the KMIP Signature Verify operation
    /// </summary>
    [JsonPropertyName("operationSignatureVerify")]
    public bool? OperationSignatureVerify { get; set; }

    /// <summary>
    /// The unique path this backend should be mounted at. Must
    /// not begin or end with a /. Defaults to kmip.
    /// Path where KMIP backend is mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Reference to a SecretScope in kmip to populate path.</summary>
    [JsonPropertyName("pathRef")]
    public V1alpha1SecretRoleSpecInitProviderPathRef? PathRef { get; set; }

    /// <summary>Selector for a SecretScope in kmip to populate path.</summary>
    [JsonPropertyName("pathSelector")]
    public V1alpha1SecretRoleSpecInitProviderPathSelector? PathSelector { get; set; }

    /// <summary>
    /// Name of the role.
    /// Name of the role
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// Name of the scope.
    /// Name of the scope
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a SecretScope in kmip to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1alpha1SecretRoleSpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a SecretScope in kmip to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1alpha1SecretRoleSpecInitProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>
    /// Client certificate key bits, valid values depend on key type.
    /// Client certificate key bits, valid values depend on key type
    /// </summary>
    [JsonPropertyName("tlsClientKeyBits")]
    public double? TlsClientKeyBits { get; set; }

    /// <summary>
    /// Client certificate key type, rsa or ec.
    /// Client certificate key type, rsa or ec
    /// </summary>
    [JsonPropertyName("tlsClientKeyType")]
    public string? TlsClientKeyType { get; set; }

    /// <summary>
    /// Client certificate TTL in seconds.
    /// Client certificate TTL in seconds
    /// </summary>
    [JsonPropertyName("tlsClientTtl")]
    public double? TlsClientTtl { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretRoleSpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretRoleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretRoleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretRoleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretRoleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretRoleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretRoleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretRoleSpec defines the desired state of SecretRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1alpha1SecretRoleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretRoleSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretRoleSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SecretRoleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretRoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretRoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleStatusAtProvider
{
    /// <summary>Name of the ca to use, if absent use legacy ca</summary>
    [JsonPropertyName("ca")]
    public string? Ca { get; set; }

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
    /// Grant permission to use the KMIP Activate operation.
    /// Grant permission to use the KMIP Activate operation
    /// </summary>
    [JsonPropertyName("operationActivate")]
    public bool? OperationActivate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Add Attribute operation.
    /// Grant permission to use the KMIP Add Attribute operation
    /// </summary>
    [JsonPropertyName("operationAddAttribute")]
    public bool? OperationAddAttribute { get; set; }

    /// <summary>
    /// Grant all permissions to this role. May not be specified with any other operation_* params.
    /// Grant all permissions to this role. May not be specified with any other operation_* params
    /// </summary>
    [JsonPropertyName("operationAll")]
    public bool? OperationAll { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Create operation.
    /// Grant permission to use the KMIP Create operation
    /// </summary>
    [JsonPropertyName("operationCreate")]
    public bool? OperationCreate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Create Key Pair operation.
    /// Grant permission to use the KMIP Create Key Pair operation
    /// </summary>
    [JsonPropertyName("operationCreateKeyPair")]
    public bool? OperationCreateKeyPair { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Decrypt operation.
    /// Grant permission to use the KMIP Decrypt operation
    /// </summary>
    [JsonPropertyName("operationDecrypt")]
    public bool? OperationDecrypt { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Delete Attribute operation.
    /// Grant permission to use the KMIP Delete Attribute operation
    /// </summary>
    [JsonPropertyName("operationDeleteAttribute")]
    public bool? OperationDeleteAttribute { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Destroy operation.
    /// Grant permission to use the KMIP Destroy operation
    /// </summary>
    [JsonPropertyName("operationDestroy")]
    public bool? OperationDestroy { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Discover Version operation.
    /// Grant permission to use the KMIP Discover Version operation
    /// </summary>
    [JsonPropertyName("operationDiscoverVersions")]
    public bool? OperationDiscoverVersions { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Encrypt operation.
    /// Grant permission to use the KMIP Encrypt operation
    /// </summary>
    [JsonPropertyName("operationEncrypt")]
    public bool? OperationEncrypt { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get operation.
    /// Grant permission to use the KMIP Get operation
    /// </summary>
    [JsonPropertyName("operationGet")]
    public bool? OperationGet { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Atrribute List operation.
    /// Grant permission to use the KMIP Get Attribute List operation
    /// </summary>
    [JsonPropertyName("operationGetAttributeList")]
    public bool? OperationGetAttributeList { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Atrributes operation.
    /// Grant permission to use the KMIP Get Attributes operation
    /// </summary>
    [JsonPropertyName("operationGetAttributes")]
    public bool? OperationGetAttributes { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Import operation.
    /// Grant permission to use the KMIP Import operation
    /// </summary>
    [JsonPropertyName("operationImport")]
    public bool? OperationImport { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Get Locate operation.
    /// Grant permission to use the KMIP Locate operation
    /// </summary>
    [JsonPropertyName("operationLocate")]
    public bool? OperationLocate { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP MAC operation.
    /// Grant permission to use the KMIP MAC operation
    /// </summary>
    [JsonPropertyName("operationMac")]
    public bool? OperationMac { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP MAC Verify operation.
    /// Grant permission to use the KMIP MAC Verify operation
    /// </summary>
    [JsonPropertyName("operationMacVerify")]
    public bool? OperationMacVerify { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Modify Attribute operation.
    /// Grant permission to use the KMIP Modify Attribute operation
    /// </summary>
    [JsonPropertyName("operationModifyAttribute")]
    public bool? OperationModifyAttribute { get; set; }

    /// <summary>
    /// Remove all permissions from this role. May not be specified with any other operation_* params.
    /// Remove all permissions from this role. May not be specified with any other operation_* params
    /// </summary>
    [JsonPropertyName("operationNone")]
    public bool? OperationNone { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Query operation.
    /// Grant permission to use the KMIP Query operation
    /// </summary>
    [JsonPropertyName("operationQuery")]
    public bool? OperationQuery { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Register operation.
    /// Grant permission to use the KMIP Register operation
    /// </summary>
    [JsonPropertyName("operationRegister")]
    public bool? OperationRegister { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Rekey operation.
    /// Grant permission to use the KMIP Rekey operation
    /// </summary>
    [JsonPropertyName("operationRekey")]
    public bool? OperationRekey { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Rekey Key Pair operation.
    /// Grant permission to use the KMIP Rekey Key Pair operation
    /// </summary>
    [JsonPropertyName("operationRekeyKeyPair")]
    public bool? OperationRekeyKeyPair { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Revoke operation.
    /// Grant permission to use the KMIP Revoke operation
    /// </summary>
    [JsonPropertyName("operationRevoke")]
    public bool? OperationRevoke { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP RNG Retrieve operation.
    /// Grant permission to use the KMIP RNG Retrieve operation
    /// </summary>
    [JsonPropertyName("operationRngRetrieve")]
    public bool? OperationRngRetrieve { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP RNG Seed operation.
    /// Grant permission to use the KMIP RNG Seed operation
    /// </summary>
    [JsonPropertyName("operationRngSeed")]
    public bool? OperationRngSeed { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Sign operation.
    /// Grant permission to use the KMIP Sign operation
    /// </summary>
    [JsonPropertyName("operationSign")]
    public bool? OperationSign { get; set; }

    /// <summary>
    /// Grant permission to use the KMIP Signature Verify operation.
    /// Grant permission to use the KMIP Signature Verify operation
    /// </summary>
    [JsonPropertyName("operationSignatureVerify")]
    public bool? OperationSignatureVerify { get; set; }

    /// <summary>
    /// The unique path this backend should be mounted at. Must
    /// not begin or end with a /. Defaults to kmip.
    /// Path where KMIP backend is mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Name of the role.
    /// Name of the role
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// Name of the scope.
    /// Name of the scope
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Client certificate key bits, valid values depend on key type.
    /// Client certificate key bits, valid values depend on key type
    /// </summary>
    [JsonPropertyName("tlsClientKeyBits")]
    public double? TlsClientKeyBits { get; set; }

    /// <summary>
    /// Client certificate key type, rsa or ec.
    /// Client certificate key type, rsa or ec
    /// </summary>
    [JsonPropertyName("tlsClientKeyType")]
    public string? TlsClientKeyType { get; set; }

    /// <summary>
    /// Client certificate TTL in seconds.
    /// Client certificate TTL in seconds
    /// </summary>
    [JsonPropertyName("tlsClientTtl")]
    public double? TlsClientTtl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleStatusConditions
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

/// <summary>SecretRoleStatus defines the observed state of SecretRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretRoleStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretRoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretRoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretRole is the Schema for the SecretRoles API. Provision KMIP Secret roles in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretRoleSpec>, IStatus<V1alpha1SecretRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretRole";
    public const string KubeGroup = "kmip.vault.upbound.io";
    public const string KubePluralName = "secretroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kmip.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretRole";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretRoleSpec defines the desired state of SecretRole</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretRoleSpec Spec { get; set; }

    /// <summary>SecretRoleStatus defines the observed state of SecretRole.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretRoleStatus? Status { get; set; }
}
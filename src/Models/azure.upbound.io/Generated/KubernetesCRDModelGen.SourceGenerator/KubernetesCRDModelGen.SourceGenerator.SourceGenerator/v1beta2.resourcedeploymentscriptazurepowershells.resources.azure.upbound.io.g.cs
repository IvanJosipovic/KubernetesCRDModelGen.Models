#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.resources.azure.upbound.io;
/// <summary>ResourceDeploymentScriptAzurePowerShell is the Schema for the ResourceDeploymentScriptAzurePowerShells API. Manages a Resource Deployment Script of Azure PowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ResourceDeploymentScriptAzurePowerShell>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourceDeploymentScriptAzurePowerShellList";
    public const string KubeGroup = "resources.azure.upbound.io";
    public const string KubePluralName = "resourcedeploymentscriptazurepowershells";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceDeploymentScriptAzurePowerShellList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ResourceDeploymentScriptAzurePowerShell objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ResourceDeploymentScriptAzurePowerShell> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecDeletionPolicyEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A container block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderContainer
{
    /// <summary>Container group name, if not specified then the name will get auto-generated. For more information, please refer to the Container Configuration documentation.</summary>
    [JsonPropertyName("containerGroupName")]
    public string? ContainerGroupName { get; set; }
}

/// <summary>Specifies the value of the secure environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderEnvironmentVariableSecureValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderEnvironmentVariable
{
    /// <summary>Specifies the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the secure environment variable.</summary>
    [JsonPropertyName("secureValueSecretRef")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderEnvironmentVariableSecureValueSecretRef? SecureValueSecretRef { get; set; }

    /// <summary>Specifies the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelector
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
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentity
{
    /// <summary>Specifies the list of user-assigned managed identity IDs associated with the resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Type of the managed identity. The only possible value is UserAssigned. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelector
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
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the storage account access key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderStorageAccountKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A storage_account block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderStorageAccount
{
    /// <summary>Specifies the storage account access key.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderStorageAccountKeySecretRef? KeySecretRef { get; set; }

    /// <summary>Specifies the storage account name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProvider
{
    /// <summary>Specifies the cleanup preference when the script execution gets in a terminal state. Possible values are Always, OnExpiration, OnSuccess. Defaults to Always. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("cleanupPreference")]
    public string? CleanupPreference { get; set; }

    /// <summary>Command line arguments to pass to the script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("commandLine")]
    public string? CommandLine { get; set; }

    /// <summary>A container block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("container")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderContainer? Container { get; set; }

    /// <summary>An environment_variable block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("environmentVariable")]
    public IList<V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderEnvironmentVariable>? EnvironmentVariable { get; set; }

    /// <summary>Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Resource Deployment Script should exist. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name which should be used for this Resource Deployment Script. The name length must be from 1 to 260 characters. The name can only contain alphanumeric, underscore, parentheses, hyphen and period, and it cannot end with a period. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Uri for the script. This is the entry point for the external script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("primaryScriptUri")]
    public string? PrimaryScriptUri { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Resource Deployment Script should exist. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. The time duration should be between 1 hour and 26 hours (inclusive) and should be specified in ISO 8601 format. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("retentionInterval")]
    public string? RetentionInterval { get; set; }

    /// <summary>Script body. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("scriptContent")]
    public string? ScriptContent { get; set; }

    /// <summary>A storage_account block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("storageAccount")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProviderStorageAccount? StorageAccount { get; set; }

    /// <summary>Supporting files for the external script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("supportingScriptUris")]
    public IList<string>? SupportingScriptUris { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Deployment Script.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Maximum allowed script execution time specified in ISO 8601 format. Needs to be greater than 0 and smaller than 1 day. Defaults to P1D. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Specifies the version of the Azure PowerShell that should be used in the format X.Y (e.g. 9.7). A canonical list of versions is available from the Microsoft Container Registry API. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A container block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderContainer
{
    /// <summary>Container group name, if not specified then the name will get auto-generated. For more information, please refer to the Container Configuration documentation.</summary>
    [JsonPropertyName("containerGroupName")]
    public string? ContainerGroupName { get; set; }
}

/// <summary>Specifies the value of the secure environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderEnvironmentVariableSecureValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderEnvironmentVariable
{
    /// <summary>Specifies the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the secure environment variable.</summary>
    [JsonPropertyName("secureValueSecretRef")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderEnvironmentVariableSecureValueSecretRef? SecureValueSecretRef { get; set; }

    /// <summary>Specifies the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelector
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
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentity
{
    /// <summary>Specifies the list of user-assigned managed identity IDs associated with the resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Type of the managed identity. The only possible value is UserAssigned. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelector
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
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the storage account access key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderStorageAccountKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A storage_account block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderStorageAccount
{
    /// <summary>Specifies the storage account access key.</summary>
    [JsonPropertyName("keySecretRef")]
    public required V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderStorageAccountKeySecretRef KeySecretRef { get; set; }

    /// <summary>Specifies the storage account name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProvider
{
    /// <summary>Specifies the cleanup preference when the script execution gets in a terminal state. Possible values are Always, OnExpiration, OnSuccess. Defaults to Always. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("cleanupPreference")]
    public string? CleanupPreference { get; set; }

    /// <summary>Command line arguments to pass to the script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("commandLine")]
    public string? CommandLine { get; set; }

    /// <summary>A container block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("container")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderContainer? Container { get; set; }

    /// <summary>An environment_variable block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("environmentVariable")]
    public IList<V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderEnvironmentVariable>? EnvironmentVariable { get; set; }

    /// <summary>Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Resource Deployment Script should exist. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name which should be used for this Resource Deployment Script. The name length must be from 1 to 260 characters. The name can only contain alphanumeric, underscore, parentheses, hyphen and period, and it cannot end with a period. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Uri for the script. This is the entry point for the external script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("primaryScriptUri")]
    public string? PrimaryScriptUri { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Resource Deployment Script should exist. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. The time duration should be between 1 hour and 26 hours (inclusive) and should be specified in ISO 8601 format. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("retentionInterval")]
    public string? RetentionInterval { get; set; }

    /// <summary>Script body. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("scriptContent")]
    public string? ScriptContent { get; set; }

    /// <summary>A storage_account block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("storageAccount")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProviderStorageAccount? StorageAccount { get; set; }

    /// <summary>Supporting files for the external script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("supportingScriptUris")]
    public IList<string>? SupportingScriptUris { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Deployment Script.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Maximum allowed script execution time specified in ISO 8601 format. Needs to be greater than 0 and smaller than 1 day. Defaults to P1D. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Specifies the version of the Azure PowerShell that should be used in the format X.Y (e.g. 9.7). A canonical list of versions is available from the Microsoft Container Registry API. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecManagementPoliciesEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ResourceDeploymentScriptAzurePowerShellSpec defines the desired state of ResourceDeploymentScriptAzurePowerShell</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellSpec
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
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ResourceDeploymentScriptAzurePowerShellSpecForProvider ForProvider { get; set; }

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
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ResourceDeploymentScriptAzurePowerShellSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A container block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderContainer
{
    /// <summary>Container group name, if not specified then the name will get auto-generated. For more information, please refer to the Container Configuration documentation.</summary>
    [JsonPropertyName("containerGroupName")]
    public string? ContainerGroupName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderEnvironmentVariable
{
    /// <summary>Specifies the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderIdentity
{
    /// <summary>Specifies the list of user-assigned managed identity IDs associated with the resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Type of the managed identity. The only possible value is UserAssigned. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A storage_account block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderStorageAccount
{
    /// <summary>Specifies the storage account name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProvider
{
    /// <summary>Specifies the cleanup preference when the script execution gets in a terminal state. Possible values are Always, OnExpiration, OnSuccess. Defaults to Always. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("cleanupPreference")]
    public string? CleanupPreference { get; set; }

    /// <summary>Command line arguments to pass to the script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("commandLine")]
    public string? CommandLine { get; set; }

    /// <summary>A container block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("container")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderContainer? Container { get; set; }

    /// <summary>An environment_variable block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("environmentVariable")]
    public IList<V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderEnvironmentVariable>? EnvironmentVariable { get; set; }

    /// <summary>Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>The ID of the Resource Deployment Script.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Resource Deployment Script should exist. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name which should be used for this Resource Deployment Script. The name length must be from 1 to 260 characters. The name can only contain alphanumeric, underscore, parentheses, hyphen and period, and it cannot end with a period. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of script outputs.</summary>
    [JsonPropertyName("outputs")]
    public string? Outputs { get; set; }

    /// <summary>Uri for the script. This is the entry point for the external script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("primaryScriptUri")]
    public string? PrimaryScriptUri { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Resource Deployment Script should exist. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. The time duration should be between 1 hour and 26 hours (inclusive) and should be specified in ISO 8601 format. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("retentionInterval")]
    public string? RetentionInterval { get; set; }

    /// <summary>Script body. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("scriptContent")]
    public string? ScriptContent { get; set; }

    /// <summary>A storage_account block as defined below. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("storageAccount")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProviderStorageAccount? StorageAccount { get; set; }

    /// <summary>Supporting files for the external script. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("supportingScriptUris")]
    public IList<string>? SupportingScriptUris { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Deployment Script.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Maximum allowed script execution time specified in ISO 8601 format. Needs to be greater than 0 and smaller than 1 day. Defaults to P1D. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Specifies the version of the Azure PowerShell that should be used in the format X.Y (e.g. 9.7). A canonical list of versions is available from the Microsoft Container Registry API. Changing this forces a new Resource Deployment Script to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellStatusConditions
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

/// <summary>ResourceDeploymentScriptAzurePowerShellStatus defines the observed state of ResourceDeploymentScriptAzurePowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShellStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ResourceDeploymentScriptAzurePowerShellStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResourceDeploymentScriptAzurePowerShell is the Schema for the ResourceDeploymentScriptAzurePowerShells API. Manages a Resource Deployment Script of Azure PowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourceDeploymentScriptAzurePowerShell : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ResourceDeploymentScriptAzurePowerShellSpec>, IStatus<V1beta2ResourceDeploymentScriptAzurePowerShellStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourceDeploymentScriptAzurePowerShell";
    public const string KubeGroup = "resources.azure.upbound.io";
    public const string KubePluralName = "resourcedeploymentscriptazurepowershells";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceDeploymentScriptAzurePowerShell";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceDeploymentScriptAzurePowerShellSpec defines the desired state of ResourceDeploymentScriptAzurePowerShell</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ResourceDeploymentScriptAzurePowerShellSpec Spec { get; set; }

    /// <summary>ResourceDeploymentScriptAzurePowerShellStatus defines the observed state of ResourceDeploymentScriptAzurePowerShell.</summary>
    [JsonPropertyName("status")]
    public V1beta2ResourceDeploymentScriptAzurePowerShellStatus? Status { get; set; }
}
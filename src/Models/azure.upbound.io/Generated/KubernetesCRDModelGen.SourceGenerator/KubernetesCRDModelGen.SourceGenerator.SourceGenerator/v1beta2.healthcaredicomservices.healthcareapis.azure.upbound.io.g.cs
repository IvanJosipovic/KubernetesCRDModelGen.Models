#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcareapis.azure.upbound.io;
/// <summary>HealthcareDICOMService is the Schema for the HealthcareDICOMServices API. Manages a Healthcare DICOM (Digital Imaging and Communications in Medicine) Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HealthcareDICOMServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2HealthcareDICOMService>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HealthcareDICOMServiceList";
    public const string KubeGroup = "healthcareapis.azure.upbound.io";
    public const string KubePluralName = "healthcaredicomservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "healthcareapis.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HealthcareDICOMServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2HealthcareDICOMService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2HealthcareDICOMService> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecDeletionPolicyEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProviderCors
{
    /// <summary>Whether to allow credentials in CORS. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A list of allowed headers for CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of allowed methods for CORS.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of allowed origins for CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The maximum age in seconds for the CORS configuration (must be between 0 and 99998 inclusive).</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Identity IDs which should be assigned to this Healthcare DICOM service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of identity used for the Healthcare DICOM service. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned. If UserAssigned is set, an identity_ids must be set as well.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A storage block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProviderStorage
{
    /// <summary>The filesystem name of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("fileSystemName")]
    public string? FileSystemName { get; set; }

    /// <summary>The resource ID of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelector
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
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecForProvider
{
    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2HealthcareDICOMServiceSpecForProviderCors? Cors { get; set; }

    /// <summary>If data partitions are enabled or not. Defaults to false. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("dataPartitionsEnabled")]
    public bool? DataPartitionsEnabled { get; set; }

    /// <summary>The URL of the key to use for encryption as part of the customer-managed key encryption settings. For more details, refer to the Azure Customer-Managed Keys Overview.</summary>
    [JsonPropertyName("encryptionKeyUrl")]
    public string? EncryptionKeyUrl { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2HealthcareDICOMServiceSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare DICOM Service should be created. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether to enabled public networks when data plane traffic coming from public networks while private endpoint is enabled. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A storage block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storage")]
    public V1beta2HealthcareDICOMServiceSpecForProviderStorage? Storage { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the ID of the Healthcare Workspace where the Healthcare DICOM Service should exist. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>Reference to a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdRef")]
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdRef? WorkspaceIdRef { get; set; }

    /// <summary>Selector for a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdSelector")]
    public V1beta2HealthcareDICOMServiceSpecForProviderWorkspaceIdSelector? WorkspaceIdSelector { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecInitProviderCors
{
    /// <summary>Whether to allow credentials in CORS. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A list of allowed headers for CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of allowed methods for CORS.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of allowed origins for CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The maximum age in seconds for the CORS configuration (must be between 0 and 99998 inclusive).</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Identity IDs which should be assigned to this Healthcare DICOM service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of identity used for the Healthcare DICOM service. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned. If UserAssigned is set, an identity_ids must be set as well.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A storage block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecInitProviderStorage
{
    /// <summary>The filesystem name of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("fileSystemName")]
    public string? FileSystemName { get; set; }

    /// <summary>The resource ID of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
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
public partial class V1beta2HealthcareDICOMServiceSpecInitProvider
{
    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2HealthcareDICOMServiceSpecInitProviderCors? Cors { get; set; }

    /// <summary>If data partitions are enabled or not. Defaults to false. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("dataPartitionsEnabled")]
    public bool? DataPartitionsEnabled { get; set; }

    /// <summary>The URL of the key to use for encryption as part of the customer-managed key encryption settings. For more details, refer to the Azure Customer-Managed Keys Overview.</summary>
    [JsonPropertyName("encryptionKeyUrl")]
    public string? EncryptionKeyUrl { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2HealthcareDICOMServiceSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare DICOM Service should be created. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether to enabled public networks when data plane traffic coming from public networks while private endpoint is enabled. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A storage block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storage")]
    public V1beta2HealthcareDICOMServiceSpecInitProviderStorage? Storage { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecManagementPoliciesEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HealthcareDICOMServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>HealthcareDICOMServiceSpec defines the desired state of HealthcareDICOMService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceSpec
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
    public V1beta2HealthcareDICOMServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2HealthcareDICOMServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2HealthcareDICOMServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2HealthcareDICOMServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2HealthcareDICOMServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2HealthcareDICOMServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatusAtProviderAuthentication
{
    /// <summary>The intended audience to receive authentication tokens for the service. The default value is https://dicom.azurehealthcareapis.azure.com</summary>
    [JsonPropertyName("audience")]
    public IList<string>? Audience { get; set; }

    /// <summary>
    /// The Azure Active Directory (tenant) that serves as the authentication authority to access the service.
    /// Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.
    /// </summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatusAtProviderCors
{
    /// <summary>Whether to allow credentials in CORS. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A list of allowed headers for CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of allowed methods for CORS.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of allowed origins for CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The maximum age in seconds for the CORS configuration (must be between 0 and 99998 inclusive).</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Identity IDs which should be assigned to this Healthcare DICOM service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of identity used for the Healthcare DICOM service. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned. If UserAssigned is set, an identity_ids must be set as well.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatusAtProviderPrivateEndpoint
{
    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Healthcare DICOM Service. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A storage block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatusAtProviderStorage
{
    /// <summary>The filesystem name of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("fileSystemName")]
    public string? FileSystemName { get; set; }

    /// <summary>The resource ID of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatusAtProvider
{
    /// <summary>The authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2HealthcareDICOMServiceStatusAtProviderAuthentication>? Authentication { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2HealthcareDICOMServiceStatusAtProviderCors? Cors { get; set; }

    /// <summary>If data partitions are enabled or not. Defaults to false. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("dataPartitionsEnabled")]
    public bool? DataPartitionsEnabled { get; set; }

    /// <summary>The URL of the key to use for encryption as part of the customer-managed key encryption settings. For more details, refer to the Azure Customer-Managed Keys Overview.</summary>
    [JsonPropertyName("encryptionKeyUrl")]
    public string? EncryptionKeyUrl { get; set; }

    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2HealthcareDICOMServiceStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare DICOM Service should be created. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("privateEndpoint")]
    public IList<V1beta2HealthcareDICOMServiceStatusAtProviderPrivateEndpoint>? PrivateEndpoint { get; set; }

    /// <summary>Whether to enabled public networks when data plane traffic coming from public networks while private endpoint is enabled. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The url of the Healthcare DICOM Services.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>A storage block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storage")]
    public V1beta2HealthcareDICOMServiceStatusAtProviderStorage? Storage { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the ID of the Healthcare Workspace where the Healthcare DICOM Service should exist. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatusConditions
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

/// <summary>HealthcareDICOMServiceStatus defines the observed state of HealthcareDICOMService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthcareDICOMServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2HealthcareDICOMServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2HealthcareDICOMServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HealthcareDICOMService is the Schema for the HealthcareDICOMServices API. Manages a Healthcare DICOM (Digital Imaging and Communications in Medicine) Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HealthcareDICOMService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2HealthcareDICOMServiceSpec>, IStatus<V1beta2HealthcareDICOMServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HealthcareDICOMService";
    public const string KubeGroup = "healthcareapis.azure.upbound.io";
    public const string KubePluralName = "healthcaredicomservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "healthcareapis.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HealthcareDICOMService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HealthcareDICOMServiceSpec defines the desired state of HealthcareDICOMService</summary>
    [JsonPropertyName("spec")]
    public required V1beta2HealthcareDICOMServiceSpec Spec { get; set; }

    /// <summary>HealthcareDICOMServiceStatus defines the observed state of HealthcareDICOMService.</summary>
    [JsonPropertyName("status")]
    public V1beta2HealthcareDICOMServiceStatus? Status { get; set; }
}
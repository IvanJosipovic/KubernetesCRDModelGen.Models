#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
/// <summary>SpringCloudCustomizedAccelerator is the Schema for the SpringCloudCustomizedAccelerators API. Manages a Spring Cloud Customized Accelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpringCloudCustomizedAcceleratorList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SpringCloudCustomizedAccelerator>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpringCloudCustomizedAcceleratorList";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudcustomizedaccelerators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudCustomizedAcceleratorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SpringCloudCustomizedAccelerator objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SpringCloudCustomizedAccelerator> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecDeletionPolicyEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Specifies the password of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuthPasswordSecretRef
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

/// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuth
{
    /// <summary>Specifies the password of git repository basic auth.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Specifies the Public SSH Key of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthHostKeySecretRef
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

/// <summary>Specifies the Private SSH Key of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthPrivateKeySecretRef
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

/// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuth
{
    /// <summary>Specifies the SSH Key algorithm of git repository basic auth.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Specifies the Public SSH Key of git repository basic auth.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>Specifies the Private SSH Key of git repository basic auth.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthPrivateKeySecretRef? PrivateKeySecretRef { get; set; }
}

/// <summary>A git_repository block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepository
{
    /// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuth? BasicAuth { get; set; }

    /// <summary>Specifies the Git repository branch to be used.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Specifies the ID of the CA Spring Cloud Certificate for https URL of Git repository.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the Git repository commit to be used.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Specifies the Git repository tag to be used.</summary>
    [JsonPropertyName("gitTag")]
    public string? GitTag { get; set; }

    /// <summary>Specifies the interval for checking for updates to Git or image repository. It should be greater than 10.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path under the git repository to be treated as the root directory of the accelerator or the fragment (depending on accelerator_type).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuth? SshAuth { get; set; }

    /// <summary>Specifies Git repository URL for the accelerator.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelector
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
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecForProvider
{
    /// <summary>Specifies a list of accelerator tags.</summary>
    [JsonPropertyName("acceleratorTags")]
    public IList<string>? AcceleratorTags { get; set; }

    /// <summary>Specifies the type of the Spring Cloud Customized Accelerator. Possible values are Accelerator and Fragment. Defaults to Accelerator.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Specifies the description of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A git_repository block as defined below.</summary>
    [JsonPropertyName("gitRepository")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderGitRepository? GitRepository { get; set; }

    /// <summary>Specifies the icon URL of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    /// <summary>The ID of the Spring Cloud Accelerator. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("springCloudAcceleratorId")]
    public string? SpringCloudAcceleratorId { get; set; }

    /// <summary>Reference to a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
    [JsonPropertyName("springCloudAcceleratorIdRef")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRef? SpringCloudAcceleratorIdRef { get; set; }

    /// <summary>Selector for a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
    [JsonPropertyName("springCloudAcceleratorIdSelector")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelector? SpringCloudAcceleratorIdSelector { get; set; }
}

/// <summary>Specifies the password of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositoryBasicAuthPasswordSecretRef
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

/// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositoryBasicAuth
{
    /// <summary>Specifies the password of git repository basic auth.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositoryBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Specifies the Public SSH Key of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuthHostKeySecretRef
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

/// <summary>Specifies the Private SSH Key of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuthPrivateKeySecretRef
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

/// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuth
{
    /// <summary>Specifies the SSH Key algorithm of git repository basic auth.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Specifies the Public SSH Key of git repository basic auth.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>Specifies the Private SSH Key of git repository basic auth.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuthPrivateKeySecretRef PrivateKeySecretRef { get; set; }
}

/// <summary>A git_repository block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepository
{
    /// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositoryBasicAuth? BasicAuth { get; set; }

    /// <summary>Specifies the Git repository branch to be used.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Specifies the ID of the CA Spring Cloud Certificate for https URL of Git repository.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the Git repository commit to be used.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Specifies the Git repository tag to be used.</summary>
    [JsonPropertyName("gitTag")]
    public string? GitTag { get; set; }

    /// <summary>Specifies the interval for checking for updates to Git or image repository. It should be greater than 10.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path under the git repository to be treated as the root directory of the accelerator or the fragment (depending on accelerator_type).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuth? SshAuth { get; set; }

    /// <summary>Specifies Git repository URL for the accelerator.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
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
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecInitProvider
{
    /// <summary>Specifies a list of accelerator tags.</summary>
    [JsonPropertyName("acceleratorTags")]
    public IList<string>? AcceleratorTags { get; set; }

    /// <summary>Specifies the type of the Spring Cloud Customized Accelerator. Possible values are Accelerator and Fragment. Defaults to Accelerator.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Specifies the description of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A git_repository block as defined below.</summary>
    [JsonPropertyName("gitRepository")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecInitProviderGitRepository? GitRepository { get; set; }

    /// <summary>Specifies the icon URL of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecManagementPoliciesEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SpringCloudCustomizedAcceleratorSpec defines the desired state of SpringCloudCustomizedAccelerator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorSpec
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
    public V1beta2SpringCloudCustomizedAcceleratorSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SpringCloudCustomizedAcceleratorSpecForProvider ForProvider { get; set; }

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
    public V1beta2SpringCloudCustomizedAcceleratorSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SpringCloudCustomizedAcceleratorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SpringCloudCustomizedAcceleratorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositoryBasicAuth
{
    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositorySshAuth
{
    /// <summary>Specifies the SSH Key algorithm of git repository basic auth.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }
}

/// <summary>A git_repository block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorStatusAtProviderGitRepository
{
    /// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta2SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositoryBasicAuth? BasicAuth { get; set; }

    /// <summary>Specifies the Git repository branch to be used.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Specifies the ID of the CA Spring Cloud Certificate for https URL of Git repository.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the Git repository commit to be used.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Specifies the Git repository tag to be used.</summary>
    [JsonPropertyName("gitTag")]
    public string? GitTag { get; set; }

    /// <summary>Specifies the interval for checking for updates to Git or image repository. It should be greater than 10.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path under the git repository to be treated as the root directory of the accelerator or the fragment (depending on accelerator_type).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositorySshAuth? SshAuth { get; set; }

    /// <summary>Specifies Git repository URL for the accelerator.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorStatusAtProvider
{
    /// <summary>Specifies a list of accelerator tags.</summary>
    [JsonPropertyName("acceleratorTags")]
    public IList<string>? AcceleratorTags { get; set; }

    /// <summary>Specifies the type of the Spring Cloud Customized Accelerator. Possible values are Accelerator and Fragment. Defaults to Accelerator.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Specifies the description of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A git_repository block as defined below.</summary>
    [JsonPropertyName("gitRepository")]
    public V1beta2SpringCloudCustomizedAcceleratorStatusAtProviderGitRepository? GitRepository { get; set; }

    /// <summary>Specifies the icon URL of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    /// <summary>The ID of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Spring Cloud Accelerator. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("springCloudAcceleratorId")]
    public string? SpringCloudAcceleratorId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorStatusConditions
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

/// <summary>SpringCloudCustomizedAcceleratorStatus defines the observed state of SpringCloudCustomizedAccelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudCustomizedAcceleratorStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SpringCloudCustomizedAcceleratorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SpringCloudCustomizedAcceleratorStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudCustomizedAccelerator is the Schema for the SpringCloudCustomizedAccelerators API. Manages a Spring Cloud Customized Accelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpringCloudCustomizedAccelerator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SpringCloudCustomizedAcceleratorSpec>, IStatus<V1beta2SpringCloudCustomizedAcceleratorStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpringCloudCustomizedAccelerator";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudcustomizedaccelerators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudCustomizedAccelerator";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudCustomizedAcceleratorSpec defines the desired state of SpringCloudCustomizedAccelerator</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SpringCloudCustomizedAcceleratorSpec Spec { get; set; }

    /// <summary>SpringCloudCustomizedAcceleratorStatus defines the observed state of SpringCloudCustomizedAccelerator.</summary>
    [JsonPropertyName("status")]
    public V1beta2SpringCloudCustomizedAcceleratorStatus? Status { get; set; }
}
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
/// <summary>SpringCloudService is the Schema for the SpringCloudServices API. Manages an Azure Spring Cloud Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpringCloudServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SpringCloudService>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpringCloudServiceList";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SpringCloudService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SpringCloudService> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecDeletionPolicyEnum>))]
public enum V1beta2SpringCloudServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuthPasswordSecretRef
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

/// <summary>A http_basic_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuth
{
    /// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The username that&apos;s used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuthPasswordSecretRef
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

/// <summary>A http_basic_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuth
{
    /// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The username that&apos;s used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthHostKeySecretRef
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

/// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthPrivateKeySecretRef
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

/// <summary>A ssh_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepository
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuth? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>A name to identify on the Git repository, required only if repos exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An array of strings used to match an application name. For each pattern, use the {application}/{profile} format with wildcards.</summary>
    [JsonPropertyName("pattern")]
    public IList<string>? Pattern { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuth? SshAuth { get; set; }

    /// <summary>The URI of the Git repository that&apos;s used as the Config Server back end should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthHostKeySecretRef
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

/// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthPrivateKeySecretRef
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

/// <summary>A ssh_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderConfigServerGitSetting
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuth? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingRepository>? Repository { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuth? SshAuth { get; set; }

    /// <summary>The URI of the default Git repository used as the Config Server back end, should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Specifies the password of the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderContainerRegistryPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderContainerRegistry
{
    /// <summary>Specifies the name of the container registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the password of the container registry.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2SpringCloudServiceSpecForProviderContainerRegistryPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Specifies the login server of the container registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Specifies the username of the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderDefaultBuildService
{
    /// <summary>Specifies the name of the container registry used in the default build service.</summary>
    [JsonPropertyName("containerRegistryName")]
    public string? ContainerRegistryName { get; set; }
}

/// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderMarketplace
{
    /// <summary>Specifies the plan ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("plan")]
    public string? Plan { get; set; }

    /// <summary>Specifies the 3rd Party artifact that is being procured.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelector
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
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelector
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
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderNetwork
{
    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Apps. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appNetworkResourceGroup")]
    public string? AppNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet which should host the Spring Boot Applications deployed in this Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appSubnetId")]
    public string? AppSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdRef")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdRef? AppSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdSelector")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelector? AppSubnetIdSelector { get; set; }

    /// <summary>A list of (at least 3) CIDR ranges (at least /16) which are used to host the Spring Cloud infrastructure, which must not overlap with any existing CIDR ranges in the Subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Specifies the egress traffic type of the Spring Cloud Service. Possible values are loadBalancer and userDefinedRouting. Defaults to loadBalancer. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>Ingress read time out in seconds.</summary>
    [JsonPropertyName("readTimeoutSeconds")]
    public double? ReadTimeoutSeconds { get; set; }

    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeNetworkResourceGroup")]
    public string? ServiceRuntimeNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet where the Service Runtime components of the Spring Cloud Service will exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeSubnetId")]
    public string? ServiceRuntimeSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdRef")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRef? ServiceRuntimeSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdSelector")]
    public V1beta2SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelector? ServiceRuntimeSubnetIdSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelector
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
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelector
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
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicy? Policy { get; set; }
}

/// <summary>A trace block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProviderTrace
{
    /// <summary>The connection string used for Application Insights.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringRef")]
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringRef? ConnectionStringRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringSelector")]
    public V1beta2SpringCloudServiceSpecForProviderTraceConnectionStringSelector? ConnectionStringSelector { get; set; }

    /// <summary>The sampling rate of Application Insights Agent. Must be between 0.0 and 100.0. Defaults to 10.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecForProvider
{
    /// <summary>Specifies the size for this Spring Cloud Service&apos;s default build agent pool. Possible values are S1, S2, S3, S4 and S5. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("buildAgentPoolSize")]
    public string? BuildAgentPoolSize { get; set; }

    /// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
    [JsonPropertyName("configServerGitSetting")]
    public V1beta2SpringCloudServiceSpecForProviderConfigServerGitSetting? ConfigServerGitSetting { get; set; }

    /// <summary>One or more container_registry block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("containerRegistry")]
    public IList<V1beta2SpringCloudServiceSpecForProviderContainerRegistry>? ContainerRegistry { get; set; }

    /// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("defaultBuildService")]
    public V1beta2SpringCloudServiceSpecForProviderDefaultBuildService? DefaultBuildService { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should the log stream in vnet injection instance could be accessed from Internet?</summary>
    [JsonPropertyName("logStreamPublicEndpointEnabled")]
    public bool? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>The resource Id of the Managed Environment that the Spring Apps instance builds on. Can only be specified when sku_tier is set to StandardGen2.</summary>
    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    /// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
    [JsonPropertyName("marketplace")]
    public V1beta2SpringCloudServiceSpecForProviderMarketplace? Marketplace { get; set; }

    /// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("network")]
    public V1beta2SpringCloudServiceSpecForProviderNetwork? Network { get; set; }

    /// <summary>Specifies The name of the resource group in which to create the Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2SpringCloudServiceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Whether enable the default Service Registry. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("serviceRegistryEnabled")]
    public bool? ServiceRegistryEnabled { get; set; }

    /// <summary>Specifies the SKU Name for this Spring Cloud Service. Possible values are B0, S0 and E0. Defaults to S0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the SKU Tier for this Spring Cloud Service. Possible values are Basic, Enterprise, Standard and StandardGen2. The attribute is automatically computed from API response except when managed_environment_id is defined. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trace block as defined below.</summary>
    [JsonPropertyName("trace")]
    public V1beta2SpringCloudServiceSpecForProviderTrace? Trace { get; set; }

    /// <summary>Whether zone redundancy is enabled for this Spring Cloud Service. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingHttpBasicAuthPasswordSecretRef
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

/// <summary>A http_basic_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingHttpBasicAuth
{
    /// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingHttpBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username that&apos;s used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositoryHttpBasicAuthPasswordSecretRef
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

/// <summary>A http_basic_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositoryHttpBasicAuth
{
    /// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositoryHttpBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username that&apos;s used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuthHostKeySecretRef
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

/// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuthPrivateKeySecretRef
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

/// <summary>A ssh_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuthPrivateKeySecretRef PrivateKeySecretRef { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepository
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositoryHttpBasicAuth? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>A name to identify on the Git repository, required only if repos exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An array of strings used to match an application name. For each pattern, use the {application}/{profile} format with wildcards.</summary>
    [JsonPropertyName("pattern")]
    public IList<string>? Pattern { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuth? SshAuth { get; set; }

    /// <summary>The URI of the Git repository that&apos;s used as the Config Server back end should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuthHostKeySecretRef
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

/// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuthPrivateKeySecretRef
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

/// <summary>A ssh_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuthPrivateKeySecretRef PrivateKeySecretRef { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSetting
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingHttpBasicAuth? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingRepository>? Repository { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuth? SshAuth { get; set; }

    /// <summary>The URI of the default Git repository used as the Config Server back end, should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Specifies the password of the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderContainerRegistryPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderContainerRegistry
{
    /// <summary>Specifies the name of the container registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the password of the container registry.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2SpringCloudServiceSpecInitProviderContainerRegistryPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Specifies the login server of the container registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Specifies the username of the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderDefaultBuildService
{
    /// <summary>Specifies the name of the container registry used in the default build service.</summary>
    [JsonPropertyName("containerRegistryName")]
    public string? ContainerRegistryName { get; set; }
}

/// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderMarketplace
{
    /// <summary>Specifies the plan ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("plan")]
    public string? Plan { get; set; }

    /// <summary>Specifies the 3rd Party artifact that is being procured.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelector
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
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelector
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
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderNetwork
{
    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Apps. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appNetworkResourceGroup")]
    public string? AppNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet which should host the Spring Boot Applications deployed in this Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appSubnetId")]
    public string? AppSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdRef")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRef? AppSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdSelector")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelector? AppSubnetIdSelector { get; set; }

    /// <summary>A list of (at least 3) CIDR ranges (at least /16) which are used to host the Spring Cloud infrastructure, which must not overlap with any existing CIDR ranges in the Subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Specifies the egress traffic type of the Spring Cloud Service. Possible values are loadBalancer and userDefinedRouting. Defaults to loadBalancer. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>Ingress read time out in seconds.</summary>
    [JsonPropertyName("readTimeoutSeconds")]
    public double? ReadTimeoutSeconds { get; set; }

    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeNetworkResourceGroup")]
    public string? ServiceRuntimeNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet where the Service Runtime components of the Spring Cloud Service will exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeSubnetId")]
    public string? ServiceRuntimeSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdRef")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRef? ServiceRuntimeSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdSelector")]
    public V1beta2SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelector? ServiceRuntimeSubnetIdSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelector
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
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicy? Policy { get; set; }
}

/// <summary>A trace block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProviderTrace
{
    /// <summary>The connection string used for Application Insights.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringRef")]
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringRef? ConnectionStringRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringSelector")]
    public V1beta2SpringCloudServiceSpecInitProviderTraceConnectionStringSelector? ConnectionStringSelector { get; set; }

    /// <summary>The sampling rate of Application Insights Agent. Must be between 0.0 and 100.0. Defaults to 10.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecInitProvider
{
    /// <summary>Specifies the size for this Spring Cloud Service&apos;s default build agent pool. Possible values are S1, S2, S3, S4 and S5. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("buildAgentPoolSize")]
    public string? BuildAgentPoolSize { get; set; }

    /// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
    [JsonPropertyName("configServerGitSetting")]
    public V1beta2SpringCloudServiceSpecInitProviderConfigServerGitSetting? ConfigServerGitSetting { get; set; }

    /// <summary>One or more container_registry block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("containerRegistry")]
    public IList<V1beta2SpringCloudServiceSpecInitProviderContainerRegistry>? ContainerRegistry { get; set; }

    /// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("defaultBuildService")]
    public V1beta2SpringCloudServiceSpecInitProviderDefaultBuildService? DefaultBuildService { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should the log stream in vnet injection instance could be accessed from Internet?</summary>
    [JsonPropertyName("logStreamPublicEndpointEnabled")]
    public bool? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>The resource Id of the Managed Environment that the Spring Apps instance builds on. Can only be specified when sku_tier is set to StandardGen2.</summary>
    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    /// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
    [JsonPropertyName("marketplace")]
    public V1beta2SpringCloudServiceSpecInitProviderMarketplace? Marketplace { get; set; }

    /// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("network")]
    public V1beta2SpringCloudServiceSpecInitProviderNetwork? Network { get; set; }

    /// <summary>Whether enable the default Service Registry. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("serviceRegistryEnabled")]
    public bool? ServiceRegistryEnabled { get; set; }

    /// <summary>Specifies the SKU Name for this Spring Cloud Service. Possible values are B0, S0 and E0. Defaults to S0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the SKU Tier for this Spring Cloud Service. Possible values are Basic, Enterprise, Standard and StandardGen2. The attribute is automatically computed from API response except when managed_environment_id is defined. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trace block as defined below.</summary>
    [JsonPropertyName("trace")]
    public V1beta2SpringCloudServiceSpecInitProviderTrace? Trace { get; set; }

    /// <summary>Whether zone redundancy is enabled for this Spring Cloud Service. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecManagementPoliciesEnum>))]
public enum V1beta2SpringCloudServiceSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudServiceSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SpringCloudServiceSpec defines the desired state of SpringCloudService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceSpec
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
    public V1beta2SpringCloudServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SpringCloudServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2SpringCloudServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SpringCloudServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SpringCloudServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SpringCloudServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A http_basic_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingHttpBasicAuth
{
    /// <summary>The username that&apos;s used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A http_basic_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositoryHttpBasicAuth
{
    /// <summary>The username that&apos;s used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A ssh_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositorySshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingRepository
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositoryHttpBasicAuth? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>A name to identify on the Git repository, required only if repos exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An array of strings used to match an application name. For each pattern, use the {application}/{profile} format with wildcards.</summary>
    [JsonPropertyName("pattern")]
    public IList<string>? Pattern { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositorySshAuth? SshAuth { get; set; }

    /// <summary>The URI of the Git repository that&apos;s used as the Config Server back end should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A ssh_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingSshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSetting
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingHttpBasicAuth? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingRepository>? Repository { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSettingSshAuth? SshAuth { get; set; }

    /// <summary>The URI of the default Git repository used as the Config Server back end, should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderContainerRegistry
{
    /// <summary>Specifies the name of the container registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the login server of the container registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Specifies the username of the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderDefaultBuildService
{
    /// <summary>Specifies the name of the container registry used in the default build service.</summary>
    [JsonPropertyName("containerRegistryName")]
    public string? ContainerRegistryName { get; set; }
}

/// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderMarketplace
{
    /// <summary>Specifies the plan ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("plan")]
    public string? Plan { get; set; }

    /// <summary>Specifies the 3rd Party artifact that is being procured.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderNetwork
{
    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Apps. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appNetworkResourceGroup")]
    public string? AppNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet which should host the Spring Boot Applications deployed in this Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appSubnetId")]
    public string? AppSubnetId { get; set; }

    /// <summary>A list of (at least 3) CIDR ranges (at least /16) which are used to host the Spring Cloud infrastructure, which must not overlap with any existing CIDR ranges in the Subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Specifies the egress traffic type of the Spring Cloud Service. Possible values are loadBalancer and userDefinedRouting. Defaults to loadBalancer. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>Ingress read time out in seconds.</summary>
    [JsonPropertyName("readTimeoutSeconds")]
    public double? ReadTimeoutSeconds { get; set; }

    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeNetworkResourceGroup")]
    public string? ServiceRuntimeNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet where the Service Runtime components of the Spring Cloud Service will exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeSubnetId")]
    public string? ServiceRuntimeSubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderRequiredNetworkTrafficRules
{
    /// <summary>The direction of required traffic. Possible values are Inbound, Outbound.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The FQDN list of required traffic.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>The IP list of required traffic.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The port of required traffic.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol of required traffic.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>A trace block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProviderTrace
{
    /// <summary>The connection string used for Application Insights.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>The sampling rate of Application Insights Agent. Must be between 0.0 and 100.0. Defaults to 10.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusAtProvider
{
    /// <summary>Specifies the size for this Spring Cloud Service&apos;s default build agent pool. Possible values are S1, S2, S3, S4 and S5. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("buildAgentPoolSize")]
    public string? BuildAgentPoolSize { get; set; }

    /// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
    [JsonPropertyName("configServerGitSetting")]
    public V1beta2SpringCloudServiceStatusAtProviderConfigServerGitSetting? ConfigServerGitSetting { get; set; }

    /// <summary>One or more container_registry block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("containerRegistry")]
    public IList<V1beta2SpringCloudServiceStatusAtProviderContainerRegistry>? ContainerRegistry { get; set; }

    /// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("defaultBuildService")]
    public V1beta2SpringCloudServiceStatusAtProviderDefaultBuildService? DefaultBuildService { get; set; }

    /// <summary>The ID of the Spring Cloud Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should the log stream in vnet injection instance could be accessed from Internet?</summary>
    [JsonPropertyName("logStreamPublicEndpointEnabled")]
    public bool? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>The resource Id of the Managed Environment that the Spring Apps instance builds on. Can only be specified when sku_tier is set to StandardGen2.</summary>
    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    /// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
    [JsonPropertyName("marketplace")]
    public V1beta2SpringCloudServiceStatusAtProviderMarketplace? Marketplace { get; set; }

    /// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("network")]
    public V1beta2SpringCloudServiceStatusAtProviderNetwork? Network { get; set; }

    /// <summary>A list of the outbound Public IP Addresses used by this Spring Cloud Service.</summary>
    [JsonPropertyName("outboundPublicIpAddresses")]
    public IList<string>? OutboundPublicIpAddresses { get; set; }

    /// <summary>A list of required_network_traffic_rules blocks as defined below.</summary>
    [JsonPropertyName("requiredNetworkTrafficRules")]
    public IList<V1beta2SpringCloudServiceStatusAtProviderRequiredNetworkTrafficRules>? RequiredNetworkTrafficRules { get; set; }

    /// <summary>Specifies The name of the resource group in which to create the Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Whether enable the default Service Registry. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("serviceRegistryEnabled")]
    public bool? ServiceRegistryEnabled { get; set; }

    /// <summary>The ID of the Spring Cloud Service Registry.</summary>
    [JsonPropertyName("serviceRegistryId")]
    public string? ServiceRegistryId { get; set; }

    /// <summary>Specifies the SKU Name for this Spring Cloud Service. Possible values are B0, S0 and E0. Defaults to S0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the SKU Tier for this Spring Cloud Service. Possible values are Basic, Enterprise, Standard and StandardGen2. The attribute is automatically computed from API response except when managed_environment_id is defined. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trace block as defined below.</summary>
    [JsonPropertyName("trace")]
    public V1beta2SpringCloudServiceStatusAtProviderTrace? Trace { get; set; }

    /// <summary>Whether zone redundancy is enabled for this Spring Cloud Service. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatusConditions
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

/// <summary>SpringCloudServiceStatus defines the observed state of SpringCloudService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SpringCloudServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SpringCloudServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudService is the Schema for the SpringCloudServices API. Manages an Azure Spring Cloud Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpringCloudService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SpringCloudServiceSpec>, IStatus<V1beta2SpringCloudServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpringCloudService";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudServiceSpec defines the desired state of SpringCloudService</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SpringCloudServiceSpec Spec { get; set; }

    /// <summary>SpringCloudServiceStatus defines the observed state of SpringCloudService.</summary>
    [JsonPropertyName("status")]
    public V1beta2SpringCloudServiceStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagecache.azure.upbound.io;
/// <summary>HPCCache is the Schema for the HPCCaches API. Manages a HPC Cache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HPCCacheList : IKubernetesObject<V1ListMeta>, IItems<V1beta2HPCCache>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HPCCacheList";
    public const string KubeGroup = "storagecache.azure.upbound.io";
    public const string KubePluralName = "hpccaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storagecache.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HPCCacheList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2HPCCache objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2HPCCache> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecDeletionPolicyEnum>))]
public enum V1beta2HPCCacheSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDefaultAccessPolicyAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter&apos;s format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}

/// <summary>A default_access_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDefaultAccessPolicy
{
    /// <summary>One or more access_rule blocks (up to three) as defined above.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta2HPCCacheSpecForProviderDefaultAccessPolicyAccessRule>? AccessRule { get; set; }
}

/// <summary>The password of the Active Directory domain administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDirectoryActiveDirectoryPasswordSecretRef
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

/// <summary>A directory_active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDirectoryActiveDirectory
{
    /// <summary>The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server.</summary>
    [JsonPropertyName("cacheNetbiosName")]
    public string? CacheNetbiosName { get; set; }

    /// <summary>The primary DNS IP address used to resolve the Active Directory domain controller&apos;s FQDN.</summary>
    [JsonPropertyName("dnsPrimaryIp")]
    public string? DnsPrimaryIp { get; set; }

    /// <summary>The secondary DNS IP address used to resolve the Active Directory domain controller&apos;s FQDN.</summary>
    [JsonPropertyName("dnsSecondaryIp")]
    public string? DnsSecondaryIp { get; set; }

    /// <summary>The fully qualified domain name of the Active Directory domain controller.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The Active Directory domain&apos;s NetBIOS name.</summary>
    [JsonPropertyName("domainNetbiosName")]
    public string? DomainNetbiosName { get; set; }

    /// <summary>The password of the Active Directory domain administrator.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HPCCacheSpecForProviderDirectoryActiveDirectoryPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The username of the Active Directory domain administrator.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A directory_flat_file block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDirectoryFlatFile
{
    /// <summary>The URI of the file containing group information (/etc/group file format in Unix-like OS).</summary>
    [JsonPropertyName("groupFileUri")]
    public string? GroupFileUri { get; set; }

    /// <summary>The URI of the file containing user information (/etc/passwd file format in Unix-like OS).</summary>
    [JsonPropertyName("passwordFileUri")]
    public string? PasswordFileUri { get; set; }
}

/// <summary>The password of the Active Directory domain administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDirectoryLdapBindPasswordSecretRef
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

/// <summary>A bind block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDirectoryLdapBind
{
    /// <summary>The Bind Distinguished Name (DN) identity to be used in the secure LDAP connection.</summary>
    [JsonPropertyName("dn")]
    public string? Dn { get; set; }

    /// <summary>The password of the Active Directory domain administrator.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HPCCacheSpecForProviderDirectoryLdapBindPasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary>A directory_ldap block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDirectoryLdap
{
    /// <summary>The base distinguished name (DN) for the LDAP domain.</summary>
    [JsonPropertyName("baseDn")]
    public string? BaseDn { get; set; }

    /// <summary>A bind block as defined above.</summary>
    [JsonPropertyName("bind")]
    public V1beta2HPCCacheSpecForProviderDirectoryLdapBind? Bind { get; set; }

    /// <summary>The URI of the CA certificate to validate the LDAP secure connection.</summary>
    [JsonPropertyName("certificateValidationUri")]
    public string? CertificateValidationUri { get; set; }

    /// <summary>Whether the certificate should be automatically downloaded. This can be set to true only when certificate_validation_uri is provided.</summary>
    [JsonPropertyName("downloadCertificateAutomatically")]
    public bool? DownloadCertificateAutomatically { get; set; }

    /// <summary>Whether the LDAP connection should be encrypted?</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The FQDN or IP address of the LDAP server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>A dns block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderDns
{
    /// <summary>The DNS search domain for the HPC Cache.</summary>
    [JsonPropertyName("searchDomain")]
    public string? SearchDomain { get; set; }

    /// <summary>A list of DNS servers for the HPC Cache. At most three IP(s) are allowed to set.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this HPC Cache. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HPCCacheSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderResourceGroupNameSelector
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
    public V1beta2HPCCacheSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HPCCacheSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HPCCacheSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HPCCacheSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HPCCacheSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HPCCacheSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProviderSubnetIdSelector
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
    public V1beta2HPCCacheSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecForProvider
{
    /// <summary>Specifies whether the HPC Cache automatically rotates Encryption Key to the latest version.</summary>
    [JsonPropertyName("automaticallyRotateKeyToLatestEnabled")]
    public bool? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>The size of the HPC Cache, in GB. Possible values are 3072, 6144, 12288, 21623, 24576, 43246, 49152 and 86491. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheSizeInGb")]
    public double? CacheSizeInGb { get; set; }

    /// <summary>A default_access_policy block as defined below.</summary>
    [JsonPropertyName("defaultAccessPolicy")]
    public V1beta2HPCCacheSpecForProviderDefaultAccessPolicy? DefaultAccessPolicy { get; set; }

    /// <summary>A directory_active_directory block as defined below.</summary>
    [JsonPropertyName("directoryActiveDirectory")]
    public V1beta2HPCCacheSpecForProviderDirectoryActiveDirectory? DirectoryActiveDirectory { get; set; }

    /// <summary>A directory_flat_file block as defined below.</summary>
    [JsonPropertyName("directoryFlatFile")]
    public V1beta2HPCCacheSpecForProviderDirectoryFlatFile? DirectoryFlatFile { get; set; }

    /// <summary>A directory_ldap block as defined below.</summary>
    [JsonPropertyName("directoryLdap")]
    public V1beta2HPCCacheSpecForProviderDirectoryLdap? DirectoryLdap { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public V1beta2HPCCacheSpecForProviderDns? Dns { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta2HPCCacheSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The ID of the Key Vault Key which should be used to encrypt the data in this HPC Cache.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The IPv4 maximum transmission unit configured for the subnet of the HPC Cache. Possible values range from 576 - 1500. Defaults to 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The NTP server IP Address or FQDN for the HPC Cache. Defaults to time.windows.com.</summary>
    [JsonPropertyName("ntpServer")]
    public string? NtpServer { get; set; }

    /// <summary>The name of the Resource Group in which to create the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2HPCCacheSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2HPCCacheSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The SKU of HPC Cache to use. Possible values are (ReadWrite) - Standard_2G, Standard_4G Standard_8G or (ReadOnly) - Standard_L4_5G, Standard_L9G, and Standard_L16G. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HPCCacheSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HPCCacheSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the HPC Cache.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDefaultAccessPolicyAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter&apos;s format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}

/// <summary>A default_access_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDefaultAccessPolicy
{
    /// <summary>One or more access_rule blocks (up to three) as defined above.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta2HPCCacheSpecInitProviderDefaultAccessPolicyAccessRule>? AccessRule { get; set; }
}

/// <summary>The password of the Active Directory domain administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDirectoryActiveDirectoryPasswordSecretRef
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

/// <summary>A directory_active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDirectoryActiveDirectory
{
    /// <summary>The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server.</summary>
    [JsonPropertyName("cacheNetbiosName")]
    public string? CacheNetbiosName { get; set; }

    /// <summary>The primary DNS IP address used to resolve the Active Directory domain controller&apos;s FQDN.</summary>
    [JsonPropertyName("dnsPrimaryIp")]
    public string? DnsPrimaryIp { get; set; }

    /// <summary>The secondary DNS IP address used to resolve the Active Directory domain controller&apos;s FQDN.</summary>
    [JsonPropertyName("dnsSecondaryIp")]
    public string? DnsSecondaryIp { get; set; }

    /// <summary>The fully qualified domain name of the Active Directory domain controller.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The Active Directory domain&apos;s NetBIOS name.</summary>
    [JsonPropertyName("domainNetbiosName")]
    public string? DomainNetbiosName { get; set; }

    /// <summary>The password of the Active Directory domain administrator.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2HPCCacheSpecInitProviderDirectoryActiveDirectoryPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username of the Active Directory domain administrator.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A directory_flat_file block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDirectoryFlatFile
{
    /// <summary>The URI of the file containing group information (/etc/group file format in Unix-like OS).</summary>
    [JsonPropertyName("groupFileUri")]
    public string? GroupFileUri { get; set; }

    /// <summary>The URI of the file containing user information (/etc/passwd file format in Unix-like OS).</summary>
    [JsonPropertyName("passwordFileUri")]
    public string? PasswordFileUri { get; set; }
}

/// <summary>The password of the Active Directory domain administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDirectoryLdapBindPasswordSecretRef
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

/// <summary>A bind block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDirectoryLdapBind
{
    /// <summary>The Bind Distinguished Name (DN) identity to be used in the secure LDAP connection.</summary>
    [JsonPropertyName("dn")]
    public string? Dn { get; set; }

    /// <summary>The password of the Active Directory domain administrator.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2HPCCacheSpecInitProviderDirectoryLdapBindPasswordSecretRef PasswordSecretRef { get; set; }
}

/// <summary>A directory_ldap block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDirectoryLdap
{
    /// <summary>The base distinguished name (DN) for the LDAP domain.</summary>
    [JsonPropertyName("baseDn")]
    public string? BaseDn { get; set; }

    /// <summary>A bind block as defined above.</summary>
    [JsonPropertyName("bind")]
    public V1beta2HPCCacheSpecInitProviderDirectoryLdapBind? Bind { get; set; }

    /// <summary>The URI of the CA certificate to validate the LDAP secure connection.</summary>
    [JsonPropertyName("certificateValidationUri")]
    public string? CertificateValidationUri { get; set; }

    /// <summary>Whether the certificate should be automatically downloaded. This can be set to true only when certificate_validation_uri is provided.</summary>
    [JsonPropertyName("downloadCertificateAutomatically")]
    public bool? DownloadCertificateAutomatically { get; set; }

    /// <summary>Whether the LDAP connection should be encrypted?</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The FQDN or IP address of the LDAP server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>A dns block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderDns
{
    /// <summary>The DNS search domain for the HPC Cache.</summary>
    [JsonPropertyName("searchDomain")]
    public string? SearchDomain { get; set; }

    /// <summary>A list of DNS servers for the HPC Cache. At most three IP(s) are allowed to set.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this HPC Cache. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HPCCacheSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecInitProviderSubnetIdSelector
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
    public V1beta2HPCCacheSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2HPCCacheSpecInitProvider
{
    /// <summary>Specifies whether the HPC Cache automatically rotates Encryption Key to the latest version.</summary>
    [JsonPropertyName("automaticallyRotateKeyToLatestEnabled")]
    public bool? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>The size of the HPC Cache, in GB. Possible values are 3072, 6144, 12288, 21623, 24576, 43246, 49152 and 86491. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheSizeInGb")]
    public double? CacheSizeInGb { get; set; }

    /// <summary>A default_access_policy block as defined below.</summary>
    [JsonPropertyName("defaultAccessPolicy")]
    public V1beta2HPCCacheSpecInitProviderDefaultAccessPolicy? DefaultAccessPolicy { get; set; }

    /// <summary>A directory_active_directory block as defined below.</summary>
    [JsonPropertyName("directoryActiveDirectory")]
    public V1beta2HPCCacheSpecInitProviderDirectoryActiveDirectory? DirectoryActiveDirectory { get; set; }

    /// <summary>A directory_flat_file block as defined below.</summary>
    [JsonPropertyName("directoryFlatFile")]
    public V1beta2HPCCacheSpecInitProviderDirectoryFlatFile? DirectoryFlatFile { get; set; }

    /// <summary>A directory_ldap block as defined below.</summary>
    [JsonPropertyName("directoryLdap")]
    public V1beta2HPCCacheSpecInitProviderDirectoryLdap? DirectoryLdap { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public V1beta2HPCCacheSpecInitProviderDns? Dns { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta2HPCCacheSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The ID of the Key Vault Key which should be used to encrypt the data in this HPC Cache.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The IPv4 maximum transmission unit configured for the subnet of the HPC Cache. Possible values range from 576 - 1500. Defaults to 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The NTP server IP Address or FQDN for the HPC Cache. Defaults to time.windows.com.</summary>
    [JsonPropertyName("ntpServer")]
    public string? NtpServer { get; set; }

    /// <summary>The SKU of HPC Cache to use. Possible values are (ReadWrite) - Standard_2G, Standard_4G Standard_8G or (ReadOnly) - Standard_L4_5G, Standard_L9G, and Standard_L16G. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HPCCacheSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HPCCacheSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the HPC Cache.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecManagementPoliciesEnum>))]
public enum V1beta2HPCCacheSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2HPCCacheSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HPCCacheSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2HPCCacheSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HPCCacheSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HPCCacheSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HPCCacheSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>HPCCacheSpec defines the desired state of HPCCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheSpec
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
    public V1beta2HPCCacheSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2HPCCacheSpecForProvider ForProvider { get; set; }

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
    public V1beta2HPCCacheSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2HPCCacheSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2HPCCacheSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2HPCCacheSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderDefaultAccessPolicyAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter&apos;s format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}

/// <summary>A default_access_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderDefaultAccessPolicy
{
    /// <summary>One or more access_rule blocks (up to three) as defined above.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta2HPCCacheStatusAtProviderDefaultAccessPolicyAccessRule>? AccessRule { get; set; }
}

/// <summary>A directory_active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderDirectoryActiveDirectory
{
    /// <summary>The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server.</summary>
    [JsonPropertyName("cacheNetbiosName")]
    public string? CacheNetbiosName { get; set; }

    /// <summary>The primary DNS IP address used to resolve the Active Directory domain controller&apos;s FQDN.</summary>
    [JsonPropertyName("dnsPrimaryIp")]
    public string? DnsPrimaryIp { get; set; }

    /// <summary>The secondary DNS IP address used to resolve the Active Directory domain controller&apos;s FQDN.</summary>
    [JsonPropertyName("dnsSecondaryIp")]
    public string? DnsSecondaryIp { get; set; }

    /// <summary>The fully qualified domain name of the Active Directory domain controller.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The Active Directory domain&apos;s NetBIOS name.</summary>
    [JsonPropertyName("domainNetbiosName")]
    public string? DomainNetbiosName { get; set; }

    /// <summary>The username of the Active Directory domain administrator.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A directory_flat_file block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderDirectoryFlatFile
{
    /// <summary>The URI of the file containing group information (/etc/group file format in Unix-like OS).</summary>
    [JsonPropertyName("groupFileUri")]
    public string? GroupFileUri { get; set; }

    /// <summary>The URI of the file containing user information (/etc/passwd file format in Unix-like OS).</summary>
    [JsonPropertyName("passwordFileUri")]
    public string? PasswordFileUri { get; set; }
}

/// <summary>A bind block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderDirectoryLdapBind
{
    /// <summary>The Bind Distinguished Name (DN) identity to be used in the secure LDAP connection.</summary>
    [JsonPropertyName("dn")]
    public string? Dn { get; set; }
}

/// <summary>A directory_ldap block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderDirectoryLdap
{
    /// <summary>The base distinguished name (DN) for the LDAP domain.</summary>
    [JsonPropertyName("baseDn")]
    public string? BaseDn { get; set; }

    /// <summary>A bind block as defined above.</summary>
    [JsonPropertyName("bind")]
    public V1beta2HPCCacheStatusAtProviderDirectoryLdapBind? Bind { get; set; }

    /// <summary>The URI of the CA certificate to validate the LDAP secure connection.</summary>
    [JsonPropertyName("certificateValidationUri")]
    public string? CertificateValidationUri { get; set; }

    /// <summary>Whether the certificate should be automatically downloaded. This can be set to true only when certificate_validation_uri is provided.</summary>
    [JsonPropertyName("downloadCertificateAutomatically")]
    public bool? DownloadCertificateAutomatically { get; set; }

    /// <summary>Whether the LDAP connection should be encrypted?</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The FQDN or IP address of the LDAP server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>A dns block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderDns
{
    /// <summary>The DNS search domain for the HPC Cache.</summary>
    [JsonPropertyName("searchDomain")]
    public string? SearchDomain { get; set; }

    /// <summary>A list of DNS servers for the HPC Cache. At most three IP(s) are allowed to set.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this HPC Cache. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusAtProvider
{
    /// <summary>Specifies whether the HPC Cache automatically rotates Encryption Key to the latest version.</summary>
    [JsonPropertyName("automaticallyRotateKeyToLatestEnabled")]
    public bool? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>The size of the HPC Cache, in GB. Possible values are 3072, 6144, 12288, 21623, 24576, 43246, 49152 and 86491. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheSizeInGb")]
    public double? CacheSizeInGb { get; set; }

    /// <summary>A default_access_policy block as defined below.</summary>
    [JsonPropertyName("defaultAccessPolicy")]
    public V1beta2HPCCacheStatusAtProviderDefaultAccessPolicy? DefaultAccessPolicy { get; set; }

    /// <summary>A directory_active_directory block as defined below.</summary>
    [JsonPropertyName("directoryActiveDirectory")]
    public V1beta2HPCCacheStatusAtProviderDirectoryActiveDirectory? DirectoryActiveDirectory { get; set; }

    /// <summary>A directory_flat_file block as defined below.</summary>
    [JsonPropertyName("directoryFlatFile")]
    public V1beta2HPCCacheStatusAtProviderDirectoryFlatFile? DirectoryFlatFile { get; set; }

    /// <summary>A directory_ldap block as defined below.</summary>
    [JsonPropertyName("directoryLdap")]
    public V1beta2HPCCacheStatusAtProviderDirectoryLdap? DirectoryLdap { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public V1beta2HPCCacheStatusAtProviderDns? Dns { get; set; }

    /// <summary>The id of the HPC Cache.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta2HPCCacheStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The ID of the Key Vault Key which should be used to encrypt the data in this HPC Cache.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of IP Addresses where the HPC Cache can be mounted.</summary>
    [JsonPropertyName("mountAddresses")]
    public IList<string>? MountAddresses { get; set; }

    /// <summary>The IPv4 maximum transmission unit configured for the subnet of the HPC Cache. Possible values range from 576 - 1500. Defaults to 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The NTP server IP Address or FQDN for the HPC Cache. Defaults to time.windows.com.</summary>
    [JsonPropertyName("ntpServer")]
    public string? NtpServer { get; set; }

    /// <summary>The name of the Resource Group in which to create the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The SKU of HPC Cache to use. Possible values are (ReadWrite) - Standard_2G, Standard_4G Standard_8G or (ReadOnly) - Standard_L4_5G, Standard_L9G, and Standard_L16G. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags to assign to the HPC Cache.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatusConditions
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

/// <summary>HPCCacheStatus defines the observed state of HPCCache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HPCCacheStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2HPCCacheStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2HPCCacheStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HPCCache is the Schema for the HPCCaches API. Manages a HPC Cache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HPCCache : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2HPCCacheSpec>, IStatus<V1beta2HPCCacheStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HPCCache";
    public const string KubeGroup = "storagecache.azure.upbound.io";
    public const string KubePluralName = "hpccaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storagecache.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HPCCache";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HPCCacheSpec defines the desired state of HPCCache</summary>
    [JsonPropertyName("spec")]
    public required V1beta2HPCCacheSpec Spec { get; set; }

    /// <summary>HPCCacheStatus defines the observed state of HPCCache.</summary>
    [JsonPropertyName("status")]
    public V1beta2HPCCacheStatus? Status { get; set; }
}
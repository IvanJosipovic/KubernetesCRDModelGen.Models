#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.gcp.upbound.io;
/// <summary>AccessLevel is the Schema for the AccessLevels API. An AccessLevel is a label that can be applied to requests to GCP services, along with a list of requirements necessary for the label to be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AccessLevelList : IKubernetesObject<V1ListMeta>, IItems<V1beta2AccessLevel>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AccessLevelList";
    public const string KubeGroup = "accesscontextmanager.gcp.upbound.io";
    public const string KubePluralName = "accesslevels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessLevelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2AccessLevel objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2AccessLevel> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AccessLevelSpecDeletionPolicyEnum>))]
public enum V1beta2AccessLevelSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>
    /// The minimum allowed OS version. If not set, any version
    /// of this OS satisfies the constraint.
    /// Format: &quot;major.minor.patch&quot; such as &quot;10.5.301&quot;, &quot;9.2.1&quot;.
    /// </summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>
    /// The operating system type of the device.
    /// Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.
    /// </summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}

/// <summary>
/// Device specific restrictions, all restrictions must hold for
/// the Condition to be true. If not specified, all devices are
/// allowed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderBasicConditionsDevicePolicy
{
    /// <summary>
    /// A list of allowed device management levels.
    /// An empty list allows all management levels.
    /// Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.
    /// </summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>
    /// A list of allowed encryptions statuses.
    /// An empty list allows all statuses.
    /// Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.
    /// </summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>
    /// A list of allowed OS versions.
    /// An empty list allows all types and all versions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta2AccessLevelSpecForProviderBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

    /// <summary>Whether the device needs to be approved by the customer admin.</summary>
    [JsonPropertyName("requireAdminApproval")]
    public bool? RequireAdminApproval { get; set; }

    /// <summary>Whether the device needs to be corp owned.</summary>
    [JsonPropertyName("requireCorpOwned")]
    public bool? RequireCorpOwned { get; set; }

    /// <summary>
    /// Whether or not screenlock is required for the DevicePolicy
    /// to be true. Defaults to false.
    /// </summary>
    [JsonPropertyName("requireScreenLock")]
    public bool? RequireScreenLock { get; set; }
}

/// <summary>
/// Sub networks within a VPC network.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderBasicConditionsVpcNetworkSources
{
    /// <summary>
    /// Sub networks within a VPC network.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcSubnetwork")]
    public V1beta2AccessLevelSpecForProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork? VpcSubnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderBasicConditions
{
    /// <summary>
    /// Device specific restrictions, all restrictions must hold for
    /// the Condition to be true. If not specified, all devices are
    /// allowed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("devicePolicy")]
    public V1beta2AccessLevelSpecForProviderBasicConditionsDevicePolicy? DevicePolicy { get; set; }

    /// <summary>
    /// A list of CIDR block IP subnetwork specification. May be IPv4
    /// or IPv6.
    /// Note that for a CIDR IP address block, the specified IP address
    /// portion must be properly truncated (i.e. all the host bits must
    /// be zero) or the input is considered malformed. For example,
    /// &quot;192.0.2.0/24&quot; is accepted but &quot;192.0.2.1/24&quot; is not. Similarly,
    /// for IPv6, &quot;2001:db8::/32&quot; is accepted whereas &quot;2001:db8::1/32&quot;
    /// is not. The originating IP of a request must be in one of the
    /// listed subnets in order for this Condition to be true.
    /// If empty, all IP addresses are allowed.
    /// </summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>
    /// An allowed list of members (users, service accounts).
    /// Using groups is not supported yet.
    /// The signed-in user originating the request must be a part of one
    /// of the provided members. If not specified, a request may come
    /// from any user (logged in/not logged in, not present in any
    /// groups, etc.).
    /// Formats: user:{emailid}, serviceAccount:{emailid}
    /// </summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<string>? RequiredAccessLevels { get; set; }

    /// <summary>
    /// The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field together with ip_subnetworks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta2AccessLevelSpecForProviderBasicConditionsVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>
/// A set of predefined conditions for the access level and a combining function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderBasic
{
    /// <summary>
    /// How the conditions list should be combined to determine if a request
    /// is granted this AccessLevel. If AND is used, each Condition in
    /// conditions must be satisfied for the AccessLevel to be applied. If
    /// OR is used, at least one Condition in conditions must be satisfied
    /// for the AccessLevel to be applied.
    /// Default value is AND.
    /// Possible values are: AND, OR.
    /// </summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>
    /// A set of requirements for the AccessLevel to be granted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AccessLevelSpecForProviderBasicConditions>? Conditions { get; set; }
}

/// <summary>
/// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language.
/// This page details the objects and attributes that are used to the build the CEL expressions for
/// custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderCustomExpr
{
    /// <summary>Description of the expression</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request.
/// See CEL spec at: https://github.com/google/cel-spec.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProviderCustom
{
    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language.
    /// This page details the objects and attributes that are used to the build the CEL expressions for
    /// custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expr")]
    public V1beta2AccessLevelSpecForProviderCustomExpr? Expr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecForProvider
{
    /// <summary>
    /// A set of predefined conditions for the access level and a combining function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basic")]
    public V1beta2AccessLevelSpecForProviderBasic? Basic { get; set; }

    /// <summary>
    /// Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request.
    /// See CEL spec at: https://github.com/google/cel-spec.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("custom")]
    public V1beta2AccessLevelSpecForProviderCustom? Custom { get; set; }

    /// <summary>Description of the AccessLevel and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &apos;_&apos;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>
    /// The minimum allowed OS version. If not set, any version
    /// of this OS satisfies the constraint.
    /// Format: &quot;major.minor.patch&quot; such as &quot;10.5.301&quot;, &quot;9.2.1&quot;.
    /// </summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>
    /// The operating system type of the device.
    /// Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.
    /// </summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}

/// <summary>
/// Device specific restrictions, all restrictions must hold for
/// the Condition to be true. If not specified, all devices are
/// allowed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderBasicConditionsDevicePolicy
{
    /// <summary>
    /// A list of allowed device management levels.
    /// An empty list allows all management levels.
    /// Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.
    /// </summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>
    /// A list of allowed encryptions statuses.
    /// An empty list allows all statuses.
    /// Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.
    /// </summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>
    /// A list of allowed OS versions.
    /// An empty list allows all types and all versions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta2AccessLevelSpecInitProviderBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

    /// <summary>Whether the device needs to be approved by the customer admin.</summary>
    [JsonPropertyName("requireAdminApproval")]
    public bool? RequireAdminApproval { get; set; }

    /// <summary>Whether the device needs to be corp owned.</summary>
    [JsonPropertyName("requireCorpOwned")]
    public bool? RequireCorpOwned { get; set; }

    /// <summary>
    /// Whether or not screenlock is required for the DevicePolicy
    /// to be true. Defaults to false.
    /// </summary>
    [JsonPropertyName("requireScreenLock")]
    public bool? RequireScreenLock { get; set; }
}

/// <summary>
/// Sub networks within a VPC network.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderBasicConditionsVpcNetworkSources
{
    /// <summary>
    /// Sub networks within a VPC network.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcSubnetwork")]
    public V1beta2AccessLevelSpecInitProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork? VpcSubnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderBasicConditions
{
    /// <summary>
    /// Device specific restrictions, all restrictions must hold for
    /// the Condition to be true. If not specified, all devices are
    /// allowed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("devicePolicy")]
    public V1beta2AccessLevelSpecInitProviderBasicConditionsDevicePolicy? DevicePolicy { get; set; }

    /// <summary>
    /// A list of CIDR block IP subnetwork specification. May be IPv4
    /// or IPv6.
    /// Note that for a CIDR IP address block, the specified IP address
    /// portion must be properly truncated (i.e. all the host bits must
    /// be zero) or the input is considered malformed. For example,
    /// &quot;192.0.2.0/24&quot; is accepted but &quot;192.0.2.1/24&quot; is not. Similarly,
    /// for IPv6, &quot;2001:db8::/32&quot; is accepted whereas &quot;2001:db8::1/32&quot;
    /// is not. The originating IP of a request must be in one of the
    /// listed subnets in order for this Condition to be true.
    /// If empty, all IP addresses are allowed.
    /// </summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>
    /// An allowed list of members (users, service accounts).
    /// Using groups is not supported yet.
    /// The signed-in user originating the request must be a part of one
    /// of the provided members. If not specified, a request may come
    /// from any user (logged in/not logged in, not present in any
    /// groups, etc.).
    /// Formats: user:{emailid}, serviceAccount:{emailid}
    /// </summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<string>? RequiredAccessLevels { get; set; }

    /// <summary>
    /// The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field together with ip_subnetworks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta2AccessLevelSpecInitProviderBasicConditionsVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>
/// A set of predefined conditions for the access level and a combining function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderBasic
{
    /// <summary>
    /// How the conditions list should be combined to determine if a request
    /// is granted this AccessLevel. If AND is used, each Condition in
    /// conditions must be satisfied for the AccessLevel to be applied. If
    /// OR is used, at least one Condition in conditions must be satisfied
    /// for the AccessLevel to be applied.
    /// Default value is AND.
    /// Possible values are: AND, OR.
    /// </summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>
    /// A set of requirements for the AccessLevel to be granted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AccessLevelSpecInitProviderBasicConditions>? Conditions { get; set; }
}

/// <summary>
/// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language.
/// This page details the objects and attributes that are used to the build the CEL expressions for
/// custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderCustomExpr
{
    /// <summary>Description of the expression</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request.
/// See CEL spec at: https://github.com/google/cel-spec.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecInitProviderCustom
{
    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language.
    /// This page details the objects and attributes that are used to the build the CEL expressions for
    /// custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expr")]
    public V1beta2AccessLevelSpecInitProviderCustomExpr? Expr { get; set; }
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
public partial class V1beta2AccessLevelSpecInitProvider
{
    /// <summary>
    /// A set of predefined conditions for the access level and a combining function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basic")]
    public V1beta2AccessLevelSpecInitProviderBasic? Basic { get; set; }

    /// <summary>
    /// Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request.
    /// See CEL spec at: https://github.com/google/cel-spec.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("custom")]
    public V1beta2AccessLevelSpecInitProviderCustom? Custom { get; set; }

    /// <summary>Description of the AccessLevel and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &apos;_&apos;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AccessLevelSpecManagementPoliciesEnum>))]
public enum V1beta2AccessLevelSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AccessLevelSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AccessLevelSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AccessLevelSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AccessLevelSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AccessLevelSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AccessLevelSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AccessLevelSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AccessLevelSpec defines the desired state of AccessLevel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelSpec
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
    public V1beta2AccessLevelSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AccessLevelSpecForProvider ForProvider { get; set; }

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
    public V1beta2AccessLevelSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AccessLevelSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AccessLevelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AccessLevelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>
    /// The minimum allowed OS version. If not set, any version
    /// of this OS satisfies the constraint.
    /// Format: &quot;major.minor.patch&quot; such as &quot;10.5.301&quot;, &quot;9.2.1&quot;.
    /// </summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>
    /// The operating system type of the device.
    /// Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.
    /// </summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}

/// <summary>
/// Device specific restrictions, all restrictions must hold for
/// the Condition to be true. If not specified, all devices are
/// allowed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderBasicConditionsDevicePolicy
{
    /// <summary>
    /// A list of allowed device management levels.
    /// An empty list allows all management levels.
    /// Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.
    /// </summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>
    /// A list of allowed encryptions statuses.
    /// An empty list allows all statuses.
    /// Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.
    /// </summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>
    /// A list of allowed OS versions.
    /// An empty list allows all types and all versions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta2AccessLevelStatusAtProviderBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

    /// <summary>Whether the device needs to be approved by the customer admin.</summary>
    [JsonPropertyName("requireAdminApproval")]
    public bool? RequireAdminApproval { get; set; }

    /// <summary>Whether the device needs to be corp owned.</summary>
    [JsonPropertyName("requireCorpOwned")]
    public bool? RequireCorpOwned { get; set; }

    /// <summary>
    /// Whether or not screenlock is required for the DevicePolicy
    /// to be true. Defaults to false.
    /// </summary>
    [JsonPropertyName("requireScreenLock")]
    public bool? RequireScreenLock { get; set; }
}

/// <summary>
/// Sub networks within a VPC network.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderBasicConditionsVpcNetworkSources
{
    /// <summary>
    /// Sub networks within a VPC network.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcSubnetwork")]
    public V1beta2AccessLevelStatusAtProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork? VpcSubnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderBasicConditions
{
    /// <summary>
    /// Device specific restrictions, all restrictions must hold for
    /// the Condition to be true. If not specified, all devices are
    /// allowed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("devicePolicy")]
    public V1beta2AccessLevelStatusAtProviderBasicConditionsDevicePolicy? DevicePolicy { get; set; }

    /// <summary>
    /// A list of CIDR block IP subnetwork specification. May be IPv4
    /// or IPv6.
    /// Note that for a CIDR IP address block, the specified IP address
    /// portion must be properly truncated (i.e. all the host bits must
    /// be zero) or the input is considered malformed. For example,
    /// &quot;192.0.2.0/24&quot; is accepted but &quot;192.0.2.1/24&quot; is not. Similarly,
    /// for IPv6, &quot;2001:db8::/32&quot; is accepted whereas &quot;2001:db8::1/32&quot;
    /// is not. The originating IP of a request must be in one of the
    /// listed subnets in order for this Condition to be true.
    /// If empty, all IP addresses are allowed.
    /// </summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>
    /// An allowed list of members (users, service accounts).
    /// Using groups is not supported yet.
    /// The signed-in user originating the request must be a part of one
    /// of the provided members. If not specified, a request may come
    /// from any user (logged in/not logged in, not present in any
    /// groups, etc.).
    /// Formats: user:{emailid}, serviceAccount:{emailid}
    /// </summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<string>? RequiredAccessLevels { get; set; }

    /// <summary>
    /// The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field together with ip_subnetworks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta2AccessLevelStatusAtProviderBasicConditionsVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>
/// A set of predefined conditions for the access level and a combining function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderBasic
{
    /// <summary>
    /// How the conditions list should be combined to determine if a request
    /// is granted this AccessLevel. If AND is used, each Condition in
    /// conditions must be satisfied for the AccessLevel to be applied. If
    /// OR is used, at least one Condition in conditions must be satisfied
    /// for the AccessLevel to be applied.
    /// Default value is AND.
    /// Possible values are: AND, OR.
    /// </summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>
    /// A set of requirements for the AccessLevel to be granted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AccessLevelStatusAtProviderBasicConditions>? Conditions { get; set; }
}

/// <summary>
/// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language.
/// This page details the objects and attributes that are used to the build the CEL expressions for
/// custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderCustomExpr
{
    /// <summary>Description of the expression</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request.
/// See CEL spec at: https://github.com/google/cel-spec.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProviderCustom
{
    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language.
    /// This page details the objects and attributes that are used to the build the CEL expressions for
    /// custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expr")]
    public V1beta2AccessLevelStatusAtProviderCustomExpr? Expr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusAtProvider
{
    /// <summary>
    /// A set of predefined conditions for the access level and a combining function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basic")]
    public V1beta2AccessLevelStatusAtProviderBasic? Basic { get; set; }

    /// <summary>
    /// Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request.
    /// See CEL spec at: https://github.com/google/cel-spec.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("custom")]
    public V1beta2AccessLevelStatusAtProviderCustom? Custom { get; set; }

    /// <summary>Description of the AccessLevel and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &apos;_&apos;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatusConditions
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

/// <summary>AccessLevelStatus defines the observed state of AccessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AccessLevelStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AccessLevelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AccessLevelStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AccessLevel is the Schema for the AccessLevels API. An AccessLevel is a label that can be applied to requests to GCP services, along with a list of requirements necessary for the label to be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AccessLevel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AccessLevelSpec>, IStatus<V1beta2AccessLevelStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AccessLevel";
    public const string KubeGroup = "accesscontextmanager.gcp.upbound.io";
    public const string KubePluralName = "accesslevels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessLevel";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessLevelSpec defines the desired state of AccessLevel</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AccessLevelSpec Spec { get; set; }

    /// <summary>AccessLevelStatus defines the observed state of AccessLevel.</summary>
    [JsonPropertyName("status")]
    public V1beta2AccessLevelStatus? Status { get; set; }
}
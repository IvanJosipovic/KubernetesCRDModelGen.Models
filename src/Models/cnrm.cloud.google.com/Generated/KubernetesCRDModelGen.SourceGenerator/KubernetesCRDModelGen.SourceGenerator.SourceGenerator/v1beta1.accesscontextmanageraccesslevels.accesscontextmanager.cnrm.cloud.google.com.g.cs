#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.cnrm.cloud.google.com;
/// <summary>AccessContextManagerAccessLevel is the Schema for the AccessContextManagerAccessLevel API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessContextManagerAccessLevelList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccessContextManagerAccessLevel>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerAccessLevelList";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanageraccesslevels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessContextManagerAccessLevelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AccessContextManagerAccessLevel objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AccessContextManagerAccessLevel> Items { get; set; }
}

/// <summary>The AccessPolicy that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecAccessPolicyRef
{
    /// <summary>A reference to an externally managed AccessContextManagerAccessPolicy resource. As per https://docs.cloud.google.com/asset-inventory/docs/asset-names Should be in the format &quot;accessPolicies/{{accesspolicyID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a AccessContextManagerAccessPolicy resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a AccessContextManagerAccessPolicy resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: &quot;major.minor.patch&quot; such as &quot;10.5.301&quot;, &quot;9.2.1&quot;.</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values: [&quot;OS_UNSPECIFIED&quot;, &quot;DESKTOP_MAC&quot;, &quot;DESKTOP_WINDOWS&quot;, &quot;DESKTOP_LINUX&quot;, &quot;DESKTOP_CHROME_OS&quot;, &quot;ANDROID&quot;, &quot;IOS&quot;].</summary>
    [JsonPropertyName("osType")]
    public required string OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}

/// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Possible values: [&quot;MANAGEMENT_UNSPECIFIED&quot;, &quot;NONE&quot;, &quot;BASIC&quot;, &quot;COMPLETE&quot;].</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Possible values: [&quot;ENCRYPTION_UNSPECIFIED&quot;, &quot;ENCRYPTION_UNSUPPORTED&quot;, &quot;UNENCRYPTED&quot;, &quot;ENCRYPTED&quot;].</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

    /// <summary>Whether the device needs to be approved by the customer admin.</summary>
    [JsonPropertyName("requireAdminApproval")]
    public bool? RequireAdminApproval { get; set; }

    /// <summary>Whether the device needs to be corp owned.</summary>
    [JsonPropertyName("requireCorpOwned")]
    public bool? RequireCorpOwned { get; set; }

    /// <summary>Whether or not screenlock is required for the DevicePolicy to be true. Defaults to false.</summary>
    [JsonPropertyName("requireScreenLock")]
    public bool? RequireScreenLock { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembersServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembers
{
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembersServiceAccountRef? ServiceAccountRef { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>AccessLevelRef is a reference to a AccessLevel resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsRequiredAccessLevels
{
    /// <summary>A reference to an externally managed AccessLevel resource. Should be in the format &quot;accessPolicies/{{accessPolicyID}}/accessLevels/{{accessLevel}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a AccessLevel resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a AccessLevel resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditions
{
    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed.</summary>
    [JsonPropertyName("devicePolicy")]
    public V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicy? DevicePolicy { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example, &quot;192.0.2.0/24&quot; is accepted but &quot;192.0.2.1/24&quot; is not. Similarly, for IPv6, &quot;2001:db8::/32&quot; is accepted whereas &quot;2001:db8::1/32&quot; is not. The originating IP of a request must be in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.</summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>The request must be made by one of the provided user or service accounts. Groups are not supported. Syntax: `user:{emailid}` `serviceAccount:{emailid}` If not specified, a request may come from any user.</summary>
    [JsonPropertyName("members")]
    public IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembers>? Members { get; set; }

    /// <summary>Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field must be false for the Condition overall to be satisfied. Defaults to false.</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The request must originate from one of the provided countries/regions. Format: A valid ISO 3166-1 alpha-2 code.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>A list of other access levels defined in the same `Policy`, referenced by resource name. Referencing an `AccessLevel` which does not exist is an error. All access levels listed must be granted for the Condition to be true. Example: &quot;`accessPolicies/MY_POLICY/accessLevels/LEVEL_NAME&quot;`</summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditionsRequiredAccessLevels>? RequiredAccessLevels { get; set; }
}

/// <summary>A `BasicLevel` composed of `Conditions`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecBasic
{
    /// <summary>How the conditions list should be combined to determine if a request is granted this AccessLevel. If AND is used, each Condition in conditions must be satisfied for the AccessLevel to be applied. If OR is used, at least one Condition in conditions must be satisfied for the AccessLevel to be applied. Default value: &quot;AND&quot; Possible values: [&quot;AND&quot;, &quot;OR&quot;].</summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>A set of requirements for the AccessLevel to be granted.</summary>
    [JsonPropertyName("conditions")]
    public required IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditions> Conditions { get; set; }
}

/// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. This page details the objects and attributes that are used to the build the CEL expressions for custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecCustomExpr
{
    /// <summary>Description of the expression.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>A `CustomLevel` written in the Common Expression Language.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpecCustom
{
    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. This page details the objects and attributes that are used to the build the CEL expressions for custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.</summary>
    [JsonPropertyName("expr")]
    public required V1beta1AccessContextManagerAccessLevelSpecCustomExpr Expr { get; set; }
}

/// <summary>AccessContextManagerAccessLevelSpec defines the desired state of AccessContextManagerAccessLevel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelSpec
{
    /// <summary>The AccessPolicy that this resource belongs to.</summary>
    [JsonPropertyName("accessPolicyRef")]
    public required V1beta1AccessContextManagerAccessLevelSpecAccessPolicyRef AccessPolicyRef { get; set; }

    /// <summary>A `BasicLevel` composed of `Conditions`.</summary>
    [JsonPropertyName("basic")]
    public V1beta1AccessContextManagerAccessLevelSpecBasic? Basic { get; set; }

    /// <summary>A `CustomLevel` written in the Common Expression Language.</summary>
    [JsonPropertyName("custom")]
    public V1beta1AccessContextManagerAccessLevelSpecCustom? Custom { get; set; }

    /// <summary>Description of the `AccessLevel` and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The AccessContextManagerAccessLevel name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelStatusObservedState
{
}

/// <summary>AccessContextManagerAccessLevelStatus defines the config connector machine state of AccessContextManagerAccessLevel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessLevelStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessContextManagerAccessLevelStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AccessContextManagerAccessLevel resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1AccessContextManagerAccessLevelStatusObservedState? ObservedState { get; set; }
}

/// <summary>AccessContextManagerAccessLevel is the Schema for the AccessContextManagerAccessLevel API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessContextManagerAccessLevel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessContextManagerAccessLevelSpec>, IStatus<V1beta1AccessContextManagerAccessLevelStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerAccessLevel";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanageraccesslevels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessContextManagerAccessLevel";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessContextManagerAccessLevelSpec defines the desired state of AccessContextManagerAccessLevel</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AccessContextManagerAccessLevelSpec Spec { get; set; }

    /// <summary>AccessContextManagerAccessLevelStatus defines the config connector machine state of AccessContextManagerAccessLevel</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessContextManagerAccessLevelStatus? Status { get; set; }
}
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
/// <summary>ServicePerimeter is the Schema for the ServicePerimeters API. ServicePerimeter describes a set of GCP resources which can freely import and export data amongst themselves, but not export outside of the ServicePerimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ServicePerimeterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ServicePerimeter>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ServicePerimeterList";
    public const string KubeGroup = "accesscontextmanager.gcp.upbound.io";
    public const string KubePluralName = "serviceperimeters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServicePerimeterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ServicePerimeter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ServicePerimeter> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecDeletionPolicyEnum>))]
public enum V1beta2ServicePerimeterSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelector
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
    public V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines conditions on the source of a request causing this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED.
    /// Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.
    /// </summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and destination resources that
/// cause this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressTo
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &apos;*&apos; is not allowed.
    /// </summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecEgressPolicies
{
    /// <summary>
    /// Defines conditions on the source of a request causing this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressFrom")]
    public V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and destination resources that
    /// cause this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressTo")]
    public V1beta2ServicePerimeterSpecForProviderSpecEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines the conditions on the source of a request causing this IngressPolicy
/// to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and request destination that cause
/// this IngressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressTo
{
    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecIngressPolicies
{
    /// <summary>
    /// Defines the conditions on the source of a request causing this IngressPolicy
    /// to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and request destination that cause
    /// this IngressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressTo")]
    public V1beta2ServicePerimeterSpecForProviderSpecIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Specifies how APIs are allowed to communicate within the Service
/// Perimeter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpecVpcAccessibleServices
{
    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless enableRestriction is True.
    /// </summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &apos;allowedServices&apos;.
    /// </summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>
/// Proposed (or dry run) ServicePerimeter configuration.
/// This configuration allows to specify and test ServicePerimeter configuration
/// without enforcing actual access restrictions. Only allowed to be set when
/// the useExplicitDryRunSpec flag is set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderSpec
{
    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta2ServicePerimeterSpecForProviderSpecAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>
    /// List of EgressPolicies to apply to the perimeter. A perimeter may
    /// have multiple EgressPolicies, each of which is evaluated separately.
    /// Access is granted if any EgressPolicy grants it. Must be empty for
    /// a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>
    /// List of IngressPolicies to apply to the perimeter. A perimeter may
    /// have multiple IngressPolicies, each of which is evaluated
    /// separately. Access is granted if any Ingress Policy grants it.
    /// Must be empty for a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta2ServicePerimeterSpecForProviderSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// storage.googleapis.com is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&apos;s access
    /// restrictions.
    /// </summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>
    /// Specifies how APIs are allowed to communicate within the Service
    /// Perimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta2ServicePerimeterSpecForProviderSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelector
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
    public V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines conditions on the source of a request causing this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED.
    /// Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.
    /// </summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and destination resources that
/// cause this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressTo
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &apos;*&apos; is not allowed.
    /// </summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusEgressPolicies
{
    /// <summary>
    /// Defines conditions on the source of a request causing this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressFrom")]
    public V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and destination resources that
    /// cause this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressTo")]
    public V1beta2ServicePerimeterSpecForProviderStatusEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector
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
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelSelector")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector? AccessLevelSelector { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines the conditions on the source of a request causing this IngressPolicy
/// to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and request destination that cause
/// this IngressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressTo
{
    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusIngressPolicies
{
    /// <summary>
    /// Defines the conditions on the source of a request causing this IngressPolicy
    /// to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and request destination that cause
    /// this IngressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressTo")]
    public V1beta2ServicePerimeterSpecForProviderStatusIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Specifies how APIs are allowed to communicate within the Service
/// Perimeter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatusVpcAccessibleServices
{
    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless enableRestriction is True.
    /// </summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &apos;allowedServices&apos;.
    /// </summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>
/// ServicePerimeter configuration. Specifies sets of resources,
/// restricted services and access levels that determine
/// perimeter content and boundaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProviderStatus
{
    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta2ServicePerimeterSpecForProviderStatusAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>
    /// List of EgressPolicies to apply to the perimeter. A perimeter may
    /// have multiple EgressPolicies, each of which is evaluated separately.
    /// Access is granted if any EgressPolicy grants it. Must be empty for
    /// a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>
    /// List of IngressPolicies to apply to the perimeter. A perimeter may
    /// have multiple IngressPolicies, each of which is evaluated
    /// separately. Access is granted if any Ingress Policy grants it.
    /// Must be empty for a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta2ServicePerimeterSpecForProviderStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// storage.googleapis.com is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&apos;s access
    /// restrictions.
    /// </summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>
    /// Specifies how APIs are allowed to communicate within the Service
    /// Perimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta2ServicePerimeterSpecForProviderStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecForProvider
{
    /// <summary>
    /// Description of the ServicePerimeter and its use. Does not affect
    /// behavior.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Resource name for the ServicePerimeter. The short_name component must
    /// begin with a letter and only include alphanumeric and &apos;_&apos;.
    /// Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AccessPolicy this ServicePerimeter lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Specifies the type of the Perimeter. There are two types: regular and
    /// bridge. Regular Service Perimeter contains resources, access levels,
    /// and restricted services. Every resource can be in at most
    /// ONE regular Service Perimeter.
    /// In addition to being in a regular service perimeter, a resource can also
    /// be in zero or more perimeter bridges. A perimeter bridge only contains
    /// resources. Cross project operations are permitted if all effected
    /// resources share some perimeter (whether bridge or regular). Perimeter
    /// Bridge does not contain access levels or services: those are governed
    /// entirely by the regular perimeter that resource is in.
    /// Perimeter Bridges are typically useful when building more complex
    /// topologies with many independent perimeters that need to share some data
    /// with a common perimeter, but should not be able to share data among
    /// themselves.
    /// Default value is PERIMETER_TYPE_REGULAR.
    /// Possible values are: PERIMETER_TYPE_REGULAR, PERIMETER_TYPE_BRIDGE.
    /// </summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>
    /// Proposed (or dry run) ServicePerimeter configuration.
    /// This configuration allows to specify and test ServicePerimeter configuration
    /// without enforcing actual access restrictions. Only allowed to be set when
    /// the useExplicitDryRunSpec flag is set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2ServicePerimeterSpecForProviderSpec? Spec { get; set; }

    /// <summary>
    /// ServicePerimeter configuration. Specifies sets of resources,
    /// restricted services and access levels that determine
    /// perimeter content and boundaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("status")]
    public V1beta2ServicePerimeterSpecForProviderStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists
    /// for all Service Perimeters, and that spec is identical to the status for those
    /// Service Perimeters. When this flag is set, it inhibits the generation of the
    /// implicit spec, thereby allowing the user to explicitly provide a
    /// configuration (&quot;spec&quot;) to use in a dry-run version of the Service Perimeter.
    /// This allows the user to test changes to the enforced config (&quot;status&quot;) without
    /// actually enforcing them. This testing is done through analyzing the differences
    /// between currently enforced and suggested restrictions. useExplicitDryRunSpec must
    /// bet set to True if any of the fields in the spec are set to non-default values.
    /// </summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelector
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
    public V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines conditions on the source of a request causing this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED.
    /// Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.
    /// </summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and destination resources that
/// cause this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressTo
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &apos;*&apos; is not allowed.
    /// </summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecEgressPolicies
{
    /// <summary>
    /// Defines conditions on the source of a request causing this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressFrom")]
    public V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and destination resources that
    /// cause this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressTo")]
    public V1beta2ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines the conditions on the source of a request causing this IngressPolicy
/// to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and request destination that cause
/// this IngressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressTo
{
    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecIngressPolicies
{
    /// <summary>
    /// Defines the conditions on the source of a request causing this IngressPolicy
    /// to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and request destination that cause
    /// this IngressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressTo")]
    public V1beta2ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Specifies how APIs are allowed to communicate within the Service
/// Perimeter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpecVpcAccessibleServices
{
    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless enableRestriction is True.
    /// </summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &apos;allowedServices&apos;.
    /// </summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>
/// Proposed (or dry run) ServicePerimeter configuration.
/// This configuration allows to specify and test ServicePerimeter configuration
/// without enforcing actual access restrictions. Only allowed to be set when
/// the useExplicitDryRunSpec flag is set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderSpec
{
    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta2ServicePerimeterSpecInitProviderSpecAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>
    /// List of EgressPolicies to apply to the perimeter. A perimeter may
    /// have multiple EgressPolicies, each of which is evaluated separately.
    /// Access is granted if any EgressPolicy grants it. Must be empty for
    /// a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>
    /// List of IngressPolicies to apply to the perimeter. A perimeter may
    /// have multiple IngressPolicies, each of which is evaluated
    /// separately. Access is granted if any Ingress Policy grants it.
    /// Must be empty for a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta2ServicePerimeterSpecInitProviderSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// storage.googleapis.com is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&apos;s access
    /// restrictions.
    /// </summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>
    /// Specifies how APIs are allowed to communicate within the Service
    /// Perimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta2ServicePerimeterSpecInitProviderSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelector
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
    public V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines conditions on the source of a request causing this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED.
    /// Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.
    /// </summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and destination resources that
/// cause this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressTo
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &apos;*&apos; is not allowed.
    /// </summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusEgressPolicies
{
    /// <summary>
    /// Defines conditions on the source of a request causing this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressFrom")]
    public V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and destination resources that
    /// cause this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressTo")]
    public V1beta2ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector
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
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelSelector")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector? AccessLevelSelector { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines the conditions on the source of a request causing this IngressPolicy
/// to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and request destination that cause
/// this IngressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressTo
{
    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusIngressPolicies
{
    /// <summary>
    /// Defines the conditions on the source of a request causing this IngressPolicy
    /// to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and request destination that cause
    /// this IngressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressTo")]
    public V1beta2ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Specifies how APIs are allowed to communicate within the Service
/// Perimeter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatusVpcAccessibleServices
{
    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless enableRestriction is True.
    /// </summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &apos;allowedServices&apos;.
    /// </summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>
/// ServicePerimeter configuration. Specifies sets of resources,
/// restricted services and access levels that determine
/// perimeter content and boundaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecInitProviderStatus
{
    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta2ServicePerimeterSpecInitProviderStatusAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>
    /// List of EgressPolicies to apply to the perimeter. A perimeter may
    /// have multiple EgressPolicies, each of which is evaluated separately.
    /// Access is granted if any EgressPolicy grants it. Must be empty for
    /// a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>
    /// List of IngressPolicies to apply to the perimeter. A perimeter may
    /// have multiple IngressPolicies, each of which is evaluated
    /// separately. Access is granted if any Ingress Policy grants it.
    /// Must be empty for a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta2ServicePerimeterSpecInitProviderStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// storage.googleapis.com is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&apos;s access
    /// restrictions.
    /// </summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>
    /// Specifies how APIs are allowed to communicate within the Service
    /// Perimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta2ServicePerimeterSpecInitProviderStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
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
public partial class V1beta2ServicePerimeterSpecInitProvider
{
    /// <summary>
    /// Description of the ServicePerimeter and its use. Does not affect
    /// behavior.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Resource name for the ServicePerimeter. The short_name component must
    /// begin with a letter and only include alphanumeric and &apos;_&apos;.
    /// Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AccessPolicy this ServicePerimeter lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Specifies the type of the Perimeter. There are two types: regular and
    /// bridge. Regular Service Perimeter contains resources, access levels,
    /// and restricted services. Every resource can be in at most
    /// ONE regular Service Perimeter.
    /// In addition to being in a regular service perimeter, a resource can also
    /// be in zero or more perimeter bridges. A perimeter bridge only contains
    /// resources. Cross project operations are permitted if all effected
    /// resources share some perimeter (whether bridge or regular). Perimeter
    /// Bridge does not contain access levels or services: those are governed
    /// entirely by the regular perimeter that resource is in.
    /// Perimeter Bridges are typically useful when building more complex
    /// topologies with many independent perimeters that need to share some data
    /// with a common perimeter, but should not be able to share data among
    /// themselves.
    /// Default value is PERIMETER_TYPE_REGULAR.
    /// Possible values are: PERIMETER_TYPE_REGULAR, PERIMETER_TYPE_BRIDGE.
    /// </summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>
    /// Proposed (or dry run) ServicePerimeter configuration.
    /// This configuration allows to specify and test ServicePerimeter configuration
    /// without enforcing actual access restrictions. Only allowed to be set when
    /// the useExplicitDryRunSpec flag is set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2ServicePerimeterSpecInitProviderSpec? Spec { get; set; }

    /// <summary>
    /// ServicePerimeter configuration. Specifies sets of resources,
    /// restricted services and access levels that determine
    /// perimeter content and boundaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("status")]
    public V1beta2ServicePerimeterSpecInitProviderStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists
    /// for all Service Perimeters, and that spec is identical to the status for those
    /// Service Perimeters. When this flag is set, it inhibits the generation of the
    /// implicit spec, thereby allowing the user to explicitly provide a
    /// configuration (&quot;spec&quot;) to use in a dry-run version of the Service Perimeter.
    /// This allows the user to test changes to the enforced config (&quot;status&quot;) without
    /// actually enforcing them. This testing is done through analyzing the differences
    /// between currently enforced and suggested restrictions. useExplicitDryRunSpec must
    /// bet set to True if any of the fields in the spec are set to non-default values.
    /// </summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecManagementPoliciesEnum>))]
public enum V1beta2ServicePerimeterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ServicePerimeterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServicePerimeterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ServicePerimeterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServicePerimeterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServicePerimeterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServicePerimeterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ServicePerimeterSpec defines the desired state of ServicePerimeter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterSpec
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
    public V1beta2ServicePerimeterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ServicePerimeterSpecForProvider ForProvider { get; set; }

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
    public V1beta2ServicePerimeterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ServicePerimeterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ServicePerimeterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ServicePerimeterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines conditions on the source of a request causing this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED.
    /// Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.
    /// </summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and destination resources that
/// cause this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressTo
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &apos;*&apos; is not allowed.
    /// </summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecEgressPolicies
{
    /// <summary>
    /// Defines conditions on the source of a request causing this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressFrom")]
    public V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and destination resources that
    /// cause this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressTo")]
    public V1beta2ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines the conditions on the source of a request causing this IngressPolicy
/// to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and request destination that cause
/// this IngressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressTo
{
    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecIngressPolicies
{
    /// <summary>
    /// Defines the conditions on the source of a request causing this IngressPolicy
    /// to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and request destination that cause
    /// this IngressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressTo")]
    public V1beta2ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Specifies how APIs are allowed to communicate within the Service
/// Perimeter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpecVpcAccessibleServices
{
    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless enableRestriction is True.
    /// </summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &apos;allowedServices&apos;.
    /// </summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>
/// Proposed (or dry run) ServicePerimeter configuration.
/// This configuration allows to specify and test ServicePerimeter configuration
/// without enforcing actual access restrictions. Only allowed to be set when
/// the useExplicitDryRunSpec flag is set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderSpec
{
    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>
    /// List of EgressPolicies to apply to the perimeter. A perimeter may
    /// have multiple EgressPolicies, each of which is evaluated separately.
    /// Access is granted if any EgressPolicy grants it. Must be empty for
    /// a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>
    /// List of IngressPolicies to apply to the perimeter. A perimeter may
    /// have multiple IngressPolicies, each of which is evaluated
    /// separately. Access is granted if any Ingress Policy grants it.
    /// Must be empty for a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta2ServicePerimeterStatusAtProviderSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// storage.googleapis.com is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&apos;s access
    /// restrictions.
    /// </summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>
    /// Specifies how APIs are allowed to communicate within the Service
    /// Perimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta2ServicePerimeterStatusAtProviderSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines conditions on the source of a request causing this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED.
    /// Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.
    /// </summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and destination resources that
/// cause this EgressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressTo
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &apos;*&apos; is not allowed.
    /// </summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusEgressPolicies
{
    /// <summary>
    /// Defines conditions on the source of a request causing this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressFrom")]
    public V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and destination resources that
    /// cause this EgressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressTo")]
    public V1beta2ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFromSources
{
    /// <summary>
    /// An AccessLevel resource name that allow resources within the
    /// ServicePerimeters to be accessed from the internet. AccessLevels listed
    /// must be in the same policy as this ServicePerimeter. Referencing a nonexistent
    /// AccessLevel will cause an error. If no AccessLevel names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects and VPCs are allowed.
    /// Project format: projects/{projectNumber}
    /// VPC network format:
    /// //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}.
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. * is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Defines the conditions on the source of a request causing this IngressPolicy
/// to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFrom
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of identities field will be
    /// allowed access.
    /// Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Sources that this IngressPolicy authorizes access from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in ApiOperation. If * used as value for method, then
    /// ALL methods and permissions are allowed.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding serviceName in ApiOperation.
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperations
{
    /// <summary>
    /// API methods or permissions to allow. Method or permission must belong to
    /// the service specified by serviceName field. A single MethodSelector entry
    /// with * specified for the method field will allow all methods AND
    /// permissions for the service specified in serviceName.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>
    /// The name of the API whose methods or permissions the IngressPolicy or
    /// EgressPolicy want to allow. A single ApiOperation with serviceName
    /// field set to * will allow all methods AND permissions for all services.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>
/// Defines the conditions on the ApiOperation and request destination that cause
/// this IngressPolicy to apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressTo
{
    /// <summary>
    /// A list of ApiOperations the sources specified in corresponding IngressFrom
    /// are allowed to perform in this ServicePerimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding IngressFrom
    /// are allowed to perform.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusIngressPolicies
{
    /// <summary>
    /// Defines the conditions on the source of a request causing this IngressPolicy
    /// to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>
    /// Defines the conditions on the ApiOperation and request destination that cause
    /// this IngressPolicy to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressTo")]
    public V1beta2ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Specifies how APIs are allowed to communicate within the Service
/// Perimeter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatusVpcAccessibleServices
{
    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless enableRestriction is True.
    /// </summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &apos;allowedServices&apos;.
    /// </summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>
/// ServicePerimeter configuration. Specifies sets of resources,
/// restricted services and access levels that determine
/// perimeter content and boundaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProviderStatus
{
    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>
    /// List of EgressPolicies to apply to the perimeter. A perimeter may
    /// have multiple EgressPolicies, each of which is evaluated separately.
    /// Access is granted if any EgressPolicy grants it. Must be empty for
    /// a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>
    /// List of IngressPolicies to apply to the perimeter. A perimeter may
    /// have multiple IngressPolicies, each of which is evaluated
    /// separately. Access is granted if any Ingress Policy grants it.
    /// Must be empty for a perimeter bridge.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta2ServicePerimeterStatusAtProviderStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// storage.googleapis.com is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&apos;s access
    /// restrictions.
    /// </summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>
    /// Specifies how APIs are allowed to communicate within the Service
    /// Perimeter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta2ServicePerimeterStatusAtProviderStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusAtProvider
{
    /// <summary>Time the AccessPolicy was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Description of the ServicePerimeter and its use. Does not affect
    /// behavior.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Resource name for the ServicePerimeter. The short_name component must
    /// begin with a letter and only include alphanumeric and &apos;_&apos;.
    /// Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AccessPolicy this ServicePerimeter lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Specifies the type of the Perimeter. There are two types: regular and
    /// bridge. Regular Service Perimeter contains resources, access levels,
    /// and restricted services. Every resource can be in at most
    /// ONE regular Service Perimeter.
    /// In addition to being in a regular service perimeter, a resource can also
    /// be in zero or more perimeter bridges. A perimeter bridge only contains
    /// resources. Cross project operations are permitted if all effected
    /// resources share some perimeter (whether bridge or regular). Perimeter
    /// Bridge does not contain access levels or services: those are governed
    /// entirely by the regular perimeter that resource is in.
    /// Perimeter Bridges are typically useful when building more complex
    /// topologies with many independent perimeters that need to share some data
    /// with a common perimeter, but should not be able to share data among
    /// themselves.
    /// Default value is PERIMETER_TYPE_REGULAR.
    /// Possible values are: PERIMETER_TYPE_REGULAR, PERIMETER_TYPE_BRIDGE.
    /// </summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>
    /// Proposed (or dry run) ServicePerimeter configuration.
    /// This configuration allows to specify and test ServicePerimeter configuration
    /// without enforcing actual access restrictions. Only allowed to be set when
    /// the useExplicitDryRunSpec flag is set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2ServicePerimeterStatusAtProviderSpec? Spec { get; set; }

    /// <summary>
    /// ServicePerimeter configuration. Specifies sets of resources,
    /// restricted services and access levels that determine
    /// perimeter content and boundaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("status")]
    public V1beta2ServicePerimeterStatusAtProviderStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Time the AccessPolicy was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists
    /// for all Service Perimeters, and that spec is identical to the status for those
    /// Service Perimeters. When this flag is set, it inhibits the generation of the
    /// implicit spec, thereby allowing the user to explicitly provide a
    /// configuration (&quot;spec&quot;) to use in a dry-run version of the Service Perimeter.
    /// This allows the user to test changes to the enforced config (&quot;status&quot;) without
    /// actually enforcing them. This testing is done through analyzing the differences
    /// between currently enforced and suggested restrictions. useExplicitDryRunSpec must
    /// bet set to True if any of the fields in the spec are set to non-default values.
    /// </summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatusConditions
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

/// <summary>ServicePerimeterStatus defines the observed state of ServicePerimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServicePerimeterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ServicePerimeterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ServicePerimeterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ServicePerimeter is the Schema for the ServicePerimeters API. ServicePerimeter describes a set of GCP resources which can freely import and export data amongst themselves, but not export outside of the ServicePerimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ServicePerimeter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ServicePerimeterSpec>, IStatus<V1beta2ServicePerimeterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ServicePerimeter";
    public const string KubeGroup = "accesscontextmanager.gcp.upbound.io";
    public const string KubePluralName = "serviceperimeters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServicePerimeter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServicePerimeterSpec defines the desired state of ServicePerimeter</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ServicePerimeterSpec Spec { get; set; }

    /// <summary>ServicePerimeterStatus defines the observed state of ServicePerimeter.</summary>
    [JsonPropertyName("status")]
    public V1beta2ServicePerimeterStatus? Status { get; set; }
}
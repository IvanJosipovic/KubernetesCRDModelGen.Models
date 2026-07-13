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
/// <summary>AccessContextManagerServicePerimeter is the Schema for the AccessContextManagerServicePerimeter API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessContextManagerServicePerimeterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccessContextManagerServicePerimeter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerServicePerimeterList";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanagerserviceperimeters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessContextManagerServicePerimeterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AccessContextManagerServicePerimeter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AccessContextManagerServicePerimeter> Items { get; set; }
}

/// <summary>The AccessContextManagerAccessPolicy this AccessContextManagerServicePerimeter lives in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecAccessPolicyRef
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

/// <summary>AccessLevelRef is a reference to a AccessLevel resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecAccessLevels
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

/// <summary>A reference to an IAMServiceAccount resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentitiesServiceAccountRef
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentities
{
    /// <summary>A reference to an IAMServiceAccount resource.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>A user identity, should represent individual user or service account only.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>Defines conditions on the source of a request causing this &apos;EgressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFrom
{
    /// <summary>(Optional) A list of identities that are allowed access through this EgressPolicy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then members of &apos;identities&apos; field will be allowed access. Possible values: [&quot;IDENTITY_TYPE_UNSPECIFIED&quot;, &quot;ANY_IDENTITY&quot;, &quot;ANY_USER_ACCOUNT&quot;, &quot;ANY_SERVICE_ACCOUNT&quot;].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for &apos;method&apos; should be a valid method name for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;. If &apos;*&apos; used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by &apos;serviceName&apos; field. A single MethodSelector entry with &apos;*&apos; specified for the &apos;method&apos; field will allow all methods AND permissions for the service specified in &apos;serviceName&apos;.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the &apos;IngressPolicy&apos; or &apos;EgressPolicy&apos; want to allow. A single &apos;ApiOperation&apos; with serviceName field set to &apos;*&apos; will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>(Optional) A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;. A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResources
{
    /// <summary>(Optional) A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the &apos;ApiOperation&apos; and destination resources that cause this &apos;EgressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently &apos;*&apos; is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of &apos;ApiOperations&apos; that this egress rule applies to. A request matches if it contains an operation/service in this list.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>(Optional) A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this &apos;EgressPolicy&apos; to apply.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the &apos;ApiOperation&apos; and destination resources that cause this &apos;EgressPolicy&apos; to apply.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressTo? EgressTo { get; set; }
}

/// <summary>A reference to an IAMServiceAccount resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentitiesServiceAccountRef
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentities
{
    /// <summary>A reference to an IAMServiceAccount resource.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>A user identity, should represent individual user or service account only.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>(Optional) A reference to an AccessLevel resource that is allowed to ingress the perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesAccessLevelRef
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

/// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format &quot;projects/{project_number}&quot; The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSources
{
    /// <summary>(Optional) A reference to an AccessLevel resource that is allowed to ingress the perimeter.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format &quot;projects/{project_number}&quot; The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the source of a request causing this &apos;IngressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFrom
{
    /// <summary>(Optional) A list of identities that are allowed access through this ingress policy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of &apos;identities&apos; field will be allowed access. Possible values: [&quot;IDENTITY_TYPE_UNSPECIFIED&quot;, &quot;ANY_IDENTITY&quot;, &quot;ANY_USER_ACCOUNT&quot;, &quot;ANY_SERVICE_ACCOUNT&quot;].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this &apos;IngressPolicy&apos; authorizes access from.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for &apos;method&apos; should be a valid method name for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;. If &apos;*&apos; used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by &apos;serviceName&apos; field. A single MethodSelector entry with &apos;*&apos; specified for the &apos;method&apos; field will allow all methods AND permissions for the service specified in &apos;serviceName&apos;.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the &apos;IngressPolicy&apos; or &apos;EgressPolicy&apos; want to allow. A single &apos;ApiOperation&apos; with serviceName field set to &apos;*&apos; will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;, protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResources
{
    /// <summary>A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;, protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the &apos;ApiOperation&apos; and request destination that cause this &apos;IngressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressTo
{
    /// <summary>A list of &apos;ApiOperations&apos; the sources specified in corresponding &apos;IngressFrom&apos; are allowed to perform in this &apos;ServicePerimeter&apos;.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;, protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this &apos;IngressPolicy&apos; to apply.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the &apos;ApiOperation&apos; and request destination that cause this &apos;IngressPolicy&apos; to apply.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressTo? IngressTo { get; set; }
}

/// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecResources
{
    /// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless &apos;enableRestriction&apos; is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in &apos;allowedServices&apos;.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the &apos;useExplicitDryRunSpec&apos; flag is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecSpec
{
    /// <summary>(Optional) A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty.</summary>
    [JsonPropertyName("accessLevels")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecAccessLevels>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of &apos;IngressPolicies&apos; to apply to the perimeter. A perimeter may have multiple &apos;IngressPolicies&apos;, each of which is evaluated separately. Access is granted if any &apos;Ingress Policy&apos; grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecResources>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if &apos;storage.googleapis.com&apos; is specified, access to the storage buckets inside the perimeter must meet the perimeter&apos;s access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

/// <summary>AccessLevelRef is a reference to a AccessLevel resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusAccessLevels
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

/// <summary>A reference to an IAMServiceAccount resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentitiesServiceAccountRef
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentities
{
    /// <summary>A reference to an IAMServiceAccount resource.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>A user identity, should represent individual user or service account only.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>Defines conditions on the source of a request causing this &apos;EgressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFrom
{
    /// <summary>(Optional) A list of identities that are allowed access through this EgressPolicy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then members of &apos;identities&apos; field will be allowed access. Possible values: [&quot;IDENTITY_TYPE_UNSPECIFIED&quot;, &quot;ANY_IDENTITY&quot;, &quot;ANY_USER_ACCOUNT&quot;, &quot;ANY_SERVICE_ACCOUNT&quot;].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for &apos;method&apos; should be a valid method name for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;. If &apos;*&apos; used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by &apos;serviceName&apos; field. A single MethodSelector entry with &apos;*&apos; specified for the &apos;method&apos; field will allow all methods AND permissions for the service specified in &apos;serviceName&apos;.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the &apos;IngressPolicy&apos; or &apos;EgressPolicy&apos; want to allow. A single &apos;ApiOperation&apos; with serviceName field set to &apos;*&apos; will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>(Optional) A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;. A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResources
{
    /// <summary>(Optional) A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the &apos;ApiOperation&apos; and destination resources that cause this &apos;EgressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently &apos;*&apos; is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of &apos;ApiOperations&apos; that this egress rule applies to. A request matches if it contains an operation/service in this list.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>(Optional) A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this &apos;EgressPolicy&apos; to apply.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the &apos;ApiOperation&apos; and destination resources that cause this &apos;EgressPolicy&apos; to apply.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressTo? EgressTo { get; set; }
}

/// <summary>A reference to an IAMServiceAccount resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentitiesServiceAccountRef
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentities
{
    /// <summary>A reference to an IAMServiceAccount resource.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>A user identity, should represent individual user or service account only.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>(Optional) A reference to an AccessLevel resource that is allowed to ingress the perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesAccessLevelRef
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

/// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format &quot;projects/{project_number}&quot; The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSources
{
    /// <summary>(Optional) A reference to an AccessLevel resource that is allowed to ingress the perimeter.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format &quot;projects/{project_number}&quot; The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the source of a request causing this &apos;IngressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFrom
{
    /// <summary>(Optional) A list of identities that are allowed access through this ingress policy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of &apos;identities&apos; field will be allowed access. Possible values: [&quot;IDENTITY_TYPE_UNSPECIFIED&quot;, &quot;ANY_IDENTITY&quot;, &quot;ANY_USER_ACCOUNT&quot;, &quot;ANY_SERVICE_ACCOUNT&quot;].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this &apos;IngressPolicy&apos; authorizes access from.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for &apos;method&apos; should be a valid method name for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;. If &apos;*&apos; used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding &apos;serviceName&apos; in &apos;ApiOperation&apos;.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by &apos;serviceName&apos; field. A single MethodSelector entry with &apos;*&apos; specified for the &apos;method&apos; field will allow all methods AND permissions for the service specified in &apos;serviceName&apos;.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the &apos;IngressPolicy&apos; or &apos;EgressPolicy&apos; want to allow. A single &apos;ApiOperation&apos; with serviceName field set to &apos;*&apos; will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;, protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResources
{
    /// <summary>A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;, protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the &apos;ApiOperation&apos; and request destination that cause this &apos;IngressPolicy&apos; to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressTo
{
    /// <summary>A list of &apos;ApiOperations&apos; the sources specified in corresponding &apos;IngressFrom&apos; are allowed to perform in this &apos;ServicePerimeter&apos;.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of resources, currently only projects in the form &quot;projects/{project_number}&quot;, protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this &apos;IngressPolicy&apos; to apply.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the &apos;ApiOperation&apos; and request destination that cause this &apos;IngressPolicy&apos; to apply.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressTo? IngressTo { get; set; }
}

/// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
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
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusResources
{
    /// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless &apos;enableRestriction&apos; is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in &apos;allowedServices&apos;.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpecStatus
{
    /// <summary>(Optional) A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty.</summary>
    [JsonPropertyName("accessLevels")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusAccessLevels>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of &apos;IngressPolicies&apos; to apply to the perimeter. A perimeter may have multiple &apos;IngressPolicies&apos;, each of which is evaluated separately. Access is granted if any &apos;Ingress Policy&apos; grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusResources>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if &apos;storage.googleapis.com&apos; is specified, access to the storage buckets inside the perimeter must meet the perimeter&apos;s access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

/// <summary>AccessContextManagerServicePerimeterSpec defines the desired state of AccessContextManagerServicePerimeter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterSpec
{
    /// <summary>The AccessContextManagerAccessPolicy this AccessContextManagerServicePerimeter lives in.</summary>
    [JsonPropertyName("accessPolicyRef")]
    public required V1beta1AccessContextManagerServicePerimeterSpecAccessPolicyRef AccessPolicyRef { get; set; }

    /// <summary>Description of the ServicePerimeter and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Immutable. Specifies the type of the Perimeter. There are two types: regular and
    /// bridge. Regular Service Perimeter contains resources, access levels,
    /// and restricted services. Every resource can be in at most
    /// ONE regular Service Perimeter.
    /// 
    /// In addition to being in a regular service perimeter, a resource can also
    /// be in zero or more perimeter bridges. A perimeter bridge only contains
    /// resources. Cross project operations are permitted if all effected
    /// resources share some perimeter (whether bridge or regular). Perimeter
    /// Bridge does not contain access levels or services: those are governed
    /// entirely by the regular perimeter that resource is in.
    /// 
    /// Perimeter Bridges are typically useful when building more complex
    /// topologies with many independent perimeters that need to share some data
    /// with a common perimeter, but should not be able to share data among
    /// themselves. Default value: &quot;PERIMETER_TYPE_REGULAR&quot; Possible values: [&quot;PERIMETER_TYPE_REGULAR&quot;, &quot;PERIMETER_TYPE_BRIDGE&quot;].
    /// </summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the &apos;useExplicitDryRunSpec&apos; flag is set.</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpec? Spec { get; set; }

    /// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the generation of the implicit spec, thereby allowing the user to explicitly provide a configuration (&quot;spec&quot;) to use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced config (&quot;status&quot;) without actually enforcing them. This testing is done through analyzing the differences between currently enforced and suggested restrictions. useExplicitDryRunSpec must bet set to True if any of the fields in the spec are set to non-default values.</summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterStatusConditions
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

/// <summary>AccessContextManagerServicePerimeterStatus defines the config connector machine state of AccessContextManagerServicePerimeter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerServicePerimeterStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessContextManagerServicePerimeterStatusConditions>? Conditions { get; set; }

    /// <summary>Time the AccessPolicy was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A unique specifier for the AccessContextManagerServicePerimeter resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Time the AccessPolicy was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>AccessContextManagerServicePerimeter is the Schema for the AccessContextManagerServicePerimeter API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessContextManagerServicePerimeter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessContextManagerServicePerimeterSpec>, IStatus<V1beta1AccessContextManagerServicePerimeterStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerServicePerimeter";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanagerserviceperimeters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessContextManagerServicePerimeter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessContextManagerServicePerimeterSpec defines the desired state of AccessContextManagerServicePerimeter</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AccessContextManagerServicePerimeterSpec Spec { get; set; }

    /// <summary>AccessContextManagerServicePerimeterStatus defines the config connector machine state of AccessContextManagerServicePerimeter</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessContextManagerServicePerimeterStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.com;
/// <summary>
/// Storage version of v20220301.Site
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/WebApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220301storageSiteList : IKubernetesObject<V1ListMeta>, IItems<V20220301storageSite>
{
    public const string KubeApiVersion = "v20220301storage";
    public const string KubeKind = "SiteList";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v20220301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SiteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220301storageSite objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220301storageSite> Items { get; set; }
}

/// <summary>
/// SourceWebAppReference: ARM resource ID of the source app. App resource ID is of the form
/// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots
/// and
/// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for
/// other slots.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecCloningInfoSourceWebAppReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// TrafficManagerProfileReference: ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager
/// resource ID is of the form
/// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecCloningInfoTrafficManagerProfileReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.CloningInfo
/// Information needed for cloning operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecCloningInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("appSettingsOverrides")]
    public IDictionary<string, string>? AppSettingsOverrides { get; set; }

    [JsonPropertyName("cloneCustomHostNames")]
    public bool? CloneCustomHostNames { get; set; }

    [JsonPropertyName("cloneSourceControl")]
    public bool? CloneSourceControl { get; set; }

    [JsonPropertyName("configureLoadBalancing")]
    public bool? ConfigureLoadBalancing { get; set; }

    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    [JsonPropertyName("hostingEnvironment")]
    public string? HostingEnvironment { get; set; }

    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    [JsonPropertyName("sourceWebAppLocation")]
    public string? SourceWebAppLocation { get; set; }

    /// <summary>
    /// SourceWebAppReference: ARM resource ID of the source app. App resource ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots
    /// and
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for
    /// other slots.
    /// </summary>
    [JsonPropertyName("sourceWebAppReference")]
    public required V20220301storageSiteSpecCloningInfoSourceWebAppReference SourceWebAppReference { get; set; }

    [JsonPropertyName("trafficManagerProfileName")]
    public string? TrafficManagerProfileName { get; set; }

    /// <summary>
    /// TrafficManagerProfileReference: ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager
    /// resource ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
    /// </summary>
    [JsonPropertyName("trafficManagerProfileReference")]
    public V20220301storageSiteSpecCloningInfoTrafficManagerProfileReference? TrafficManagerProfileReference { get; set; }
}

/// <summary>
/// Storage version of v20220301.ExtendedLocation
/// Extended Location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.HostNameSslState
/// SSL-enabled hostname.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecHostNameSslStates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sslState")]
    public string? SslState { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    [JsonPropertyName("toUpdate")]
    public bool? ToUpdate { get; set; }

    [JsonPropertyName("virtualIP")]
    public string? VirtualIP { get; set; }
}

/// <summary>Reference: Resource ID of the App Service Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecHostingEnvironmentProfileReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.HostingEnvironmentProfile
/// Specification for an App Service Environment to use for this resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecHostingEnvironmentProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("reference")]
    public V20220301storageSiteSpecHostingEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20220301storageSiteSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20220301.ManagedServiceIdentity
/// Managed service identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20220301storageSiteSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Storage version of v20220301.SiteOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20220301storageSiteSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20220301storageSiteSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ServerFarmReference: Resource ID of the associated App Service plan, formatted as:
/// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecServerFarmReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.ApiDefinitionInfo
/// Information about the formal API definition for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigApiDefinition
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference: APIM-Api Identifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigApiManagementConfigReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.ApiManagementConfig
/// Azure API management (APIM) configuration linked to the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigApiManagementConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: APIM-Api Identifier.</summary>
    [JsonPropertyName("reference")]
    public V20220301storageSiteSpecSiteConfigApiManagementConfigReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20220301.NameValuePair
/// Name value pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAppSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealCustomAction
/// Custom action to be executed
/// when an auto heal rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesActionsCustomAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exe")]
    public string? Exe { get; set; }

    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealActions
/// Actions which to take by the auto-heal module when a rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealCustomAction
    /// Custom action to be executed
    /// when an auto heal rule is triggered.
    /// </summary>
    [JsonPropertyName("customAction")]
    public V20220301storageSiteSpecSiteConfigAutoHealRulesActionsCustomAction? CustomAction { get; set; }

    [JsonPropertyName("minProcessExecutionTime")]
    public string? MinProcessExecutionTime { get; set; }
}

/// <summary>
/// Storage version of v20220301.RequestsBasedTrigger
/// Trigger based on total requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersRequests
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>
/// Storage version of v20220301.SlowRequestsBasedTrigger
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequests
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>
/// Storage version of v20220301.SlowRequestsBasedTrigger
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequestsWithPath
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>
/// Storage version of v20220301.StatusCodesBasedTrigger
/// Trigger based on status code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("status")]
    public int? Status { get; set; }

    [JsonPropertyName("subStatus")]
    public int? SubStatus { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    [JsonPropertyName("win32Status")]
    public int? Win32Status { get; set; }
}

/// <summary>
/// Storage version of v20220301.StatusCodesRangeBasedTrigger
/// Trigger based on range of status codes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodesRange
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("statusCodes")]
    public string? StatusCodes { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealTriggers
/// Triggers for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRulesTriggers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("privateBytesInKB")]
    public int? PrivateBytesInKB { get; set; }

    /// <summary>
    /// Storage version of v20220301.RequestsBasedTrigger
    /// Trigger based on total requests.
    /// </summary>
    [JsonPropertyName("requests")]
    public V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersRequests? Requests { get; set; }

    /// <summary>
    /// Storage version of v20220301.SlowRequestsBasedTrigger
    /// Trigger based on request execution time.
    /// </summary>
    [JsonPropertyName("slowRequests")]
    public V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequests? SlowRequests { get; set; }

    [JsonPropertyName("slowRequestsWithPath")]
    public IList<V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequestsWithPath>? SlowRequestsWithPath { get; set; }

    [JsonPropertyName("statusCodes")]
    public IList<V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodes>? StatusCodes { get; set; }

    [JsonPropertyName("statusCodesRange")]
    public IList<V20220301storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodesRange>? StatusCodesRange { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealRules
/// Rules that can be defined for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAutoHealRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealActions
    /// Actions which to take by the auto-heal module when a rule is triggered.
    /// </summary>
    [JsonPropertyName("actions")]
    public V20220301storageSiteSpecSiteConfigAutoHealRulesActions? Actions { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealTriggers
    /// Triggers for auto-heal.
    /// </summary>
    [JsonPropertyName("triggers")]
    public V20220301storageSiteSpecSiteConfigAutoHealRulesTriggers? Triggers { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAzureStorageAccountsAccessKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.AzureStorageInfoValue
/// Azure Files or Blob Storage access information value for dictionary storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigAzureStorageAccounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("accessKey")]
    public V20220301storageSiteSpecSiteConfigAzureStorageAccountsAccessKey? AccessKey { get; set; }

    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.ConnStringInfo
/// Database connection string information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigConnectionStrings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.CorsSettings
/// Cross-Origin Resource Sharing (CORS) settings for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>
/// Storage version of v20220301.RampUpRule
/// Routing rules for ramp up testing. This rule allows to redirect static traffic % to a slot or to gradually change
/// routing % based on performance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigExperimentsRampUpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionHostName")]
    public string? ActionHostName { get; set; }

    [JsonPropertyName("changeDecisionCallbackUrl")]
    public string? ChangeDecisionCallbackUrl { get; set; }

    [JsonPropertyName("changeIntervalInMinutes")]
    public int? ChangeIntervalInMinutes { get; set; }

    [JsonPropertyName("changeStep")]
    public double? ChangeStep { get; set; }

    [JsonPropertyName("maxReroutePercentage")]
    public double? MaxReroutePercentage { get; set; }

    [JsonPropertyName("minReroutePercentage")]
    public double? MinReroutePercentage { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("reroutePercentage")]
    public double? ReroutePercentage { get; set; }
}

/// <summary>
/// Storage version of v20220301.Experiments
/// Routing rules in production experiments.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigExperiments
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rampUpRules")]
    public IList<V20220301storageSiteSpecSiteConfigExperimentsRampUpRules>? RampUpRules { get; set; }
}

/// <summary>
/// Storage version of v20220301.HandlerMapping
/// The IIS handler mappings used to define which handler processes HTTP requests with certain extension.
/// For example, it
/// is used to configure php-cgi.exe process to handle all HTTP requests with *.php extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigHandlerMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("arguments")]
    public string? Arguments { get; set; }

    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    [JsonPropertyName("scriptProcessor")]
    public string? ScriptProcessor { get; set; }
}

/// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigIpSecurityRestrictionsVnetSubnetResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.IpSecurityRestriction
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigIpSecurityRestrictions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
    [JsonPropertyName("vnetSubnetResourceReference")]
    public V20220301storageSiteSpecSiteConfigIpSecurityRestrictionsVnetSubnetResourceReference? VnetSubnetResourceReference { get; set; }

    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>
/// Storage version of v20220301.SiteLimits
/// Metric limits set on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigLimits
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxDiskSizeInMb")]
    public int? MaxDiskSizeInMb { get; set; }

    [JsonPropertyName("maxMemoryInMb")]
    public int? MaxMemoryInMb { get; set; }

    [JsonPropertyName("maxPercentageCpu")]
    public double? MaxPercentageCpu { get; set; }
}

/// <summary>
/// Storage version of v20220301.PushSettings
/// Push settings for the App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigPush
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dynamicTagsJson")]
    public string? DynamicTagsJson { get; set; }

    [JsonPropertyName("isPushEnabled")]
    public bool? IsPushEnabled { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("tagWhitelistJson")]
    public string? TagWhitelistJson { get; set; }

    [JsonPropertyName("tagsRequiringAuth")]
    public string? TagsRequiringAuth { get; set; }
}

/// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigScmIpSecurityRestrictionsVnetSubnetResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220301.IpSecurityRestriction
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigScmIpSecurityRestrictions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
    [JsonPropertyName("vnetSubnetResourceReference")]
    public V20220301storageSiteSpecSiteConfigScmIpSecurityRestrictionsVnetSubnetResourceReference? VnetSubnetResourceReference { get; set; }

    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>
/// Storage version of v20220301.VirtualDirectory
/// Directory for virtual application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigVirtualApplicationsVirtualDirectories
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>
/// Storage version of v20220301.VirtualApplication
/// Virtual application in an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfigVirtualApplications
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    [JsonPropertyName("preloadEnabled")]
    public bool? PreloadEnabled { get; set; }

    [JsonPropertyName("virtualDirectories")]
    public IList<V20220301storageSiteSpecSiteConfigVirtualApplicationsVirtualDirectories>? VirtualDirectories { get; set; }

    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>
/// Storage version of v20220301.SiteConfig
/// Configuration of an App Service app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecSiteConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("acrUseManagedIdentityCreds")]
    public bool? AcrUseManagedIdentityCreds { get; set; }

    [JsonPropertyName("acrUserManagedIdentityID")]
    public string? AcrUserManagedIdentityID { get; set; }

    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>
    /// Storage version of v20220301.ApiDefinitionInfo
    /// Information about the formal API definition for the app.
    /// </summary>
    [JsonPropertyName("apiDefinition")]
    public V20220301storageSiteSpecSiteConfigApiDefinition? ApiDefinition { get; set; }

    /// <summary>
    /// Storage version of v20220301.ApiManagementConfig
    /// Azure API management (APIM) configuration linked to the app.
    /// </summary>
    [JsonPropertyName("apiManagementConfig")]
    public V20220301storageSiteSpecSiteConfigApiManagementConfig? ApiManagementConfig { get; set; }

    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    [JsonPropertyName("appSettings")]
    public IList<V20220301storageSiteSpecSiteConfigAppSettings>? AppSettings { get; set; }

    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealRules
    /// Rules that can be defined for auto-heal.
    /// </summary>
    [JsonPropertyName("autoHealRules")]
    public V20220301storageSiteSpecSiteConfigAutoHealRules? AutoHealRules { get; set; }

    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    [JsonPropertyName("azureStorageAccounts")]
    public IDictionary<string, V20220301storageSiteSpecSiteConfigAzureStorageAccounts>? AzureStorageAccounts { get; set; }

    [JsonPropertyName("connectionStrings")]
    public IList<V20220301storageSiteSpecSiteConfigConnectionStrings>? ConnectionStrings { get; set; }

    /// <summary>
    /// Storage version of v20220301.CorsSettings
    /// Cross-Origin Resource Sharing (CORS) settings for the app.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20220301storageSiteSpecSiteConfigCors? Cors { get; set; }

    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    [JsonPropertyName("documentRoot")]
    public string? DocumentRoot { get; set; }

    /// <summary>
    /// Storage version of v20220301.Experiments
    /// Routing rules in production experiments.
    /// </summary>
    [JsonPropertyName("experiments")]
    public V20220301storageSiteSpecSiteConfigExperiments? Experiments { get; set; }

    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    [JsonPropertyName("functionAppScaleLimit")]
    public int? FunctionAppScaleLimit { get; set; }

    [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
    public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }

    [JsonPropertyName("handlerMappings")]
    public IList<V20220301storageSiteSpecSiteConfigHandlerMappings>? HandlerMappings { get; set; }

    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    [JsonPropertyName("http20Enabled")]
    public bool? Http20Enabled { get; set; }

    [JsonPropertyName("httpLoggingEnabled")]
    public bool? HttpLoggingEnabled { get; set; }

    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V20220301storageSiteSpecSiteConfigIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>
    /// Storage version of v20220301.SiteLimits
    /// Metric limits set on an app.
    /// </summary>
    [JsonPropertyName("limits")]
    public V20220301storageSiteSpecSiteConfigLimits? Limits { get; set; }

    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    [JsonPropertyName("loadBalancing")]
    public string? LoadBalancing { get; set; }

    [JsonPropertyName("localMySqlEnabled")]
    public bool? LocalMySqlEnabled { get; set; }

    [JsonPropertyName("logsDirectorySizeLimit")]
    public int? LogsDirectorySizeLimit { get; set; }

    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    [JsonPropertyName("managedServiceIdentityId")]
    public int? ManagedServiceIdentityId { get; set; }

    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    [JsonPropertyName("minimumElasticInstanceCount")]
    public int? MinimumElasticInstanceCount { get; set; }

    [JsonPropertyName("netFrameworkVersion")]
    public string? NetFrameworkVersion { get; set; }

    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    [JsonPropertyName("numberOfWorkers")]
    public int? NumberOfWorkers { get; set; }

    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    [JsonPropertyName("powerShellVersion")]
    public string? PowerShellVersion { get; set; }

    [JsonPropertyName("preWarmedInstanceCount")]
    public int? PreWarmedInstanceCount { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("publishingUsername")]
    public string? PublishingUsername { get; set; }

    /// <summary>
    /// Storage version of v20220301.PushSettings
    /// Push settings for the App.
    /// </summary>
    [JsonPropertyName("push")]
    public V20220301storageSiteSpecSiteConfigPush? Push { get; set; }

    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    [JsonPropertyName("requestTracingEnabled")]
    public bool? RequestTracingEnabled { get; set; }

    [JsonPropertyName("requestTracingExpirationTime")]
    public string? RequestTracingExpirationTime { get; set; }

    [JsonPropertyName("scmIpSecurityRestrictions")]
    public IList<V20220301storageSiteSpecSiteConfigScmIpSecurityRestrictions>? ScmIpSecurityRestrictions { get; set; }

    [JsonPropertyName("scmIpSecurityRestrictionsUseMain")]
    public bool? ScmIpSecurityRestrictionsUseMain { get; set; }

    [JsonPropertyName("scmMinTlsVersion")]
    public string? ScmMinTlsVersion { get; set; }

    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    [JsonPropertyName("tracingOptions")]
    public string? TracingOptions { get; set; }

    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    [JsonPropertyName("virtualApplications")]
    public IList<V20220301storageSiteSpecSiteConfigVirtualApplications>? VirtualApplications { get; set; }

    [JsonPropertyName("vnetName")]
    public string? VnetName { get; set; }

    [JsonPropertyName("vnetPrivatePortsCount")]
    public int? VnetPrivatePortsCount { get; set; }

    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    [JsonPropertyName("webSocketsEnabled")]
    public bool? WebSocketsEnabled { get; set; }

    [JsonPropertyName("websiteTimeZone")]
    public string? WebsiteTimeZone { get; set; }

    [JsonPropertyName("windowsFxVersion")]
    public string? WindowsFxVersion { get; set; }

    [JsonPropertyName("xManagedServiceIdentityId")]
    public int? XManagedServiceIdentityId { get; set; }
}

/// <summary>
/// VirtualNetworkSubnetReference: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
/// Integration.
/// This must be of the form
/// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpecVirtualNetworkSubnetReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20220301.Site_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }

    [JsonPropertyName("clientCertExclusionPaths")]
    public string? ClientCertExclusionPaths { get; set; }

    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>
    /// Storage version of v20220301.CloningInfo
    /// Information needed for cloning operation.
    /// </summary>
    [JsonPropertyName("cloningInfo")]
    public V20220301storageSiteSpecCloningInfo? CloningInfo { get; set; }

    [JsonPropertyName("containerSize")]
    public int? ContainerSize { get; set; }

    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    [JsonPropertyName("dailyMemoryTimeQuota")]
    public int? DailyMemoryTimeQuota { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20220301.ExtendedLocation
    /// Extended Location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20220301storageSiteSpecExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("hostNameSslStates")]
    public IList<V20220301storageSiteSpecHostNameSslStates>? HostNameSslStates { get; set; }

    [JsonPropertyName("hostNamesDisabled")]
    public bool? HostNamesDisabled { get; set; }

    /// <summary>
    /// Storage version of v20220301.HostingEnvironmentProfile
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V20220301storageSiteSpecHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>
    /// Storage version of v20220301.ManagedServiceIdentity
    /// Managed service identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20220301storageSiteSpecIdentity? Identity { get; set; }

    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v20220301.SiteOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220301storageSiteSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220301storageSiteSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("redundancyMode")]
    public string? RedundancyMode { get; set; }

    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    [JsonPropertyName("scmSiteAlsoStopped")]
    public bool? ScmSiteAlsoStopped { get; set; }

    /// <summary>
    /// ServerFarmReference: Resource ID of the associated App Service plan, formatted as:
    /// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
    /// </summary>
    [JsonPropertyName("serverFarmReference")]
    public V20220301storageSiteSpecServerFarmReference? ServerFarmReference { get; set; }

    /// <summary>
    /// Storage version of v20220301.SiteConfig
    /// Configuration of an App Service app.
    /// </summary>
    [JsonPropertyName("siteConfig")]
    public V20220301storageSiteSpecSiteConfig? SiteConfig { get; set; }

    [JsonPropertyName("storageAccountRequired")]
    public bool? StorageAccountRequired { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// VirtualNetworkSubnetReference: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
    /// Integration.
    /// This must be of the form
    /// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetReference")]
    public V20220301storageSiteSpecVirtualNetworkSubnetReference? VirtualNetworkSubnetReference { get; set; }

    [JsonPropertyName("vnetContentShareEnabled")]
    public bool? VnetContentShareEnabled { get; set; }

    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }
}

/// <summary>
/// Storage version of v20220301.CloningInfo_STATUS
/// Information needed for cloning operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusCloningInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("appSettingsOverrides")]
    public IDictionary<string, string>? AppSettingsOverrides { get; set; }

    [JsonPropertyName("cloneCustomHostNames")]
    public bool? CloneCustomHostNames { get; set; }

    [JsonPropertyName("cloneSourceControl")]
    public bool? CloneSourceControl { get; set; }

    [JsonPropertyName("configureLoadBalancing")]
    public bool? ConfigureLoadBalancing { get; set; }

    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    [JsonPropertyName("hostingEnvironment")]
    public string? HostingEnvironment { get; set; }

    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    [JsonPropertyName("sourceWebAppId")]
    public string? SourceWebAppId { get; set; }

    [JsonPropertyName("sourceWebAppLocation")]
    public string? SourceWebAppLocation { get; set; }

    [JsonPropertyName("trafficManagerProfileId")]
    public string? TrafficManagerProfileId { get; set; }

    [JsonPropertyName("trafficManagerProfileName")]
    public string? TrafficManagerProfileName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.ExtendedLocation_STATUS
/// Extended Location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.HostNameSslState_STATUS
/// SSL-enabled hostname.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusHostNameSslStates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sslState")]
    public string? SslState { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    [JsonPropertyName("toUpdate")]
    public bool? ToUpdate { get; set; }

    [JsonPropertyName("virtualIP")]
    public string? VirtualIP { get; set; }
}

/// <summary>
/// Storage version of v20220301.HostingEnvironmentProfile_STATUS
/// Specification for an App Service Environment to use for this resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusHostingEnvironmentProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.UserAssignedIdentity_STATUS
/// User Assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v20220301.ManagedServiceIdentity_STATUS
/// Managed service identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20220301storageSiteStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20220301.ApiDefinitionInfo_STATUS
/// Information about the formal API definition for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigApiDefinition
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v20220301.ApiManagementConfig_STATUS
/// Azure API management (APIM) configuration linked to the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigApiManagementConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20220301.NameValuePair_STATUS
/// Name value pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAppSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealCustomAction_STATUS
/// Custom action to be executed
/// when an auto heal rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesActionsCustomAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exe")]
    public string? Exe { get; set; }

    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealActions_STATUS
/// Actions which to take by the auto-heal module when a rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealCustomAction_STATUS
    /// Custom action to be executed
    /// when an auto heal rule is triggered.
    /// </summary>
    [JsonPropertyName("customAction")]
    public V20220301storageSiteStatusSiteConfigAutoHealRulesActionsCustomAction? CustomAction { get; set; }

    [JsonPropertyName("minProcessExecutionTime")]
    public string? MinProcessExecutionTime { get; set; }
}

/// <summary>
/// Storage version of v20220301.RequestsBasedTrigger_STATUS
/// Trigger based on total requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersRequests
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>
/// Storage version of v20220301.SlowRequestsBasedTrigger_STATUS
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequests
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>
/// Storage version of v20220301.SlowRequestsBasedTrigger_STATUS
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequestsWithPath
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>
/// Storage version of v20220301.StatusCodesBasedTrigger_STATUS
/// Trigger based on status code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("status")]
    public int? Status { get; set; }

    [JsonPropertyName("subStatus")]
    public int? SubStatus { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    [JsonPropertyName("win32Status")]
    public int? Win32Status { get; set; }
}

/// <summary>
/// Storage version of v20220301.StatusCodesRangeBasedTrigger_STATUS
/// Trigger based on range of status codes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodesRange
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("statusCodes")]
    public string? StatusCodes { get; set; }

    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealTriggers_STATUS
/// Triggers for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRulesTriggers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("privateBytesInKB")]
    public int? PrivateBytesInKB { get; set; }

    /// <summary>
    /// Storage version of v20220301.RequestsBasedTrigger_STATUS
    /// Trigger based on total requests.
    /// </summary>
    [JsonPropertyName("requests")]
    public V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersRequests? Requests { get; set; }

    /// <summary>
    /// Storage version of v20220301.SlowRequestsBasedTrigger_STATUS
    /// Trigger based on request execution time.
    /// </summary>
    [JsonPropertyName("slowRequests")]
    public V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequests? SlowRequests { get; set; }

    [JsonPropertyName("slowRequestsWithPath")]
    public IList<V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequestsWithPath>? SlowRequestsWithPath { get; set; }

    [JsonPropertyName("statusCodes")]
    public IList<V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodes>? StatusCodes { get; set; }

    [JsonPropertyName("statusCodesRange")]
    public IList<V20220301storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodesRange>? StatusCodesRange { get; set; }
}

/// <summary>
/// Storage version of v20220301.AutoHealRules_STATUS
/// Rules that can be defined for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAutoHealRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealActions_STATUS
    /// Actions which to take by the auto-heal module when a rule is triggered.
    /// </summary>
    [JsonPropertyName("actions")]
    public V20220301storageSiteStatusSiteConfigAutoHealRulesActions? Actions { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealTriggers_STATUS
    /// Triggers for auto-heal.
    /// </summary>
    [JsonPropertyName("triggers")]
    public V20220301storageSiteStatusSiteConfigAutoHealRulesTriggers? Triggers { get; set; }
}

/// <summary>
/// Storage version of v20220301.AzureStorageInfoValue_STATUS
/// Azure Files or Blob Storage access information value for dictionary storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigAzureStorageAccounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.ConnStringInfo_STATUS
/// Database connection string information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigConnectionStrings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.CorsSettings_STATUS
/// Cross-Origin Resource Sharing (CORS) settings for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>
/// Storage version of v20220301.RampUpRule_STATUS
/// Routing rules for ramp up testing. This rule allows to redirect static traffic % to a slot or to gradually change
/// routing % based on performance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigExperimentsRampUpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionHostName")]
    public string? ActionHostName { get; set; }

    [JsonPropertyName("changeDecisionCallbackUrl")]
    public string? ChangeDecisionCallbackUrl { get; set; }

    [JsonPropertyName("changeIntervalInMinutes")]
    public int? ChangeIntervalInMinutes { get; set; }

    [JsonPropertyName("changeStep")]
    public double? ChangeStep { get; set; }

    [JsonPropertyName("maxReroutePercentage")]
    public double? MaxReroutePercentage { get; set; }

    [JsonPropertyName("minReroutePercentage")]
    public double? MinReroutePercentage { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("reroutePercentage")]
    public double? ReroutePercentage { get; set; }
}

/// <summary>
/// Storage version of v20220301.Experiments_STATUS
/// Routing rules in production experiments.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigExperiments
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rampUpRules")]
    public IList<V20220301storageSiteStatusSiteConfigExperimentsRampUpRules>? RampUpRules { get; set; }
}

/// <summary>
/// Storage version of v20220301.HandlerMapping_STATUS
/// The IIS handler mappings used to define which handler processes HTTP requests with certain extension.
/// For example, it
/// is used to configure php-cgi.exe process to handle all HTTP requests with *.php extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigHandlerMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("arguments")]
    public string? Arguments { get; set; }

    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    [JsonPropertyName("scriptProcessor")]
    public string? ScriptProcessor { get; set; }
}

/// <summary>
/// Storage version of v20220301.IpSecurityRestriction_STATUS
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigIpSecurityRestrictions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    [JsonPropertyName("vnetSubnetResourceId")]
    public string? VnetSubnetResourceId { get; set; }

    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>
/// Storage version of v20220301.SiteLimits_STATUS
/// Metric limits set on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigLimits
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxDiskSizeInMb")]
    public int? MaxDiskSizeInMb { get; set; }

    [JsonPropertyName("maxMemoryInMb")]
    public int? MaxMemoryInMb { get; set; }

    [JsonPropertyName("maxPercentageCpu")]
    public double? MaxPercentageCpu { get; set; }
}

/// <summary>
/// Storage version of v20220301.SiteMachineKey_STATUS
/// MachineKey of an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigMachineKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("decryption")]
    public string? Decryption { get; set; }

    [JsonPropertyName("decryptionKey")]
    public string? DecryptionKey { get; set; }

    [JsonPropertyName("validation")]
    public string? Validation { get; set; }

    [JsonPropertyName("validationKey")]
    public string? ValidationKey { get; set; }
}

/// <summary>
/// Storage version of v20220301.PushSettings_STATUS
/// Push settings for the App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigPush
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dynamicTagsJson")]
    public string? DynamicTagsJson { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isPushEnabled")]
    public bool? IsPushEnabled { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tagWhitelistJson")]
    public string? TagWhitelistJson { get; set; }

    [JsonPropertyName("tagsRequiringAuth")]
    public string? TagsRequiringAuth { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220301.IpSecurityRestriction_STATUS
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigScmIpSecurityRestrictions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    [JsonPropertyName("vnetSubnetResourceId")]
    public string? VnetSubnetResourceId { get; set; }

    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>
/// Storage version of v20220301.VirtualDirectory_STATUS
/// Directory for virtual application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigVirtualApplicationsVirtualDirectories
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>
/// Storage version of v20220301.VirtualApplication_STATUS
/// Virtual application in an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfigVirtualApplications
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    [JsonPropertyName("preloadEnabled")]
    public bool? PreloadEnabled { get; set; }

    [JsonPropertyName("virtualDirectories")]
    public IList<V20220301storageSiteStatusSiteConfigVirtualApplicationsVirtualDirectories>? VirtualDirectories { get; set; }

    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>
/// Storage version of v20220301.SiteConfig_STATUS
/// Configuration of an App Service app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSiteConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("acrUseManagedIdentityCreds")]
    public bool? AcrUseManagedIdentityCreds { get; set; }

    [JsonPropertyName("acrUserManagedIdentityID")]
    public string? AcrUserManagedIdentityID { get; set; }

    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>
    /// Storage version of v20220301.ApiDefinitionInfo_STATUS
    /// Information about the formal API definition for the app.
    /// </summary>
    [JsonPropertyName("apiDefinition")]
    public V20220301storageSiteStatusSiteConfigApiDefinition? ApiDefinition { get; set; }

    /// <summary>
    /// Storage version of v20220301.ApiManagementConfig_STATUS
    /// Azure API management (APIM) configuration linked to the app.
    /// </summary>
    [JsonPropertyName("apiManagementConfig")]
    public V20220301storageSiteStatusSiteConfigApiManagementConfig? ApiManagementConfig { get; set; }

    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    [JsonPropertyName("appSettings")]
    public IList<V20220301storageSiteStatusSiteConfigAppSettings>? AppSettings { get; set; }

    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>
    /// Storage version of v20220301.AutoHealRules_STATUS
    /// Rules that can be defined for auto-heal.
    /// </summary>
    [JsonPropertyName("autoHealRules")]
    public V20220301storageSiteStatusSiteConfigAutoHealRules? AutoHealRules { get; set; }

    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    [JsonPropertyName("azureStorageAccounts")]
    public IDictionary<string, V20220301storageSiteStatusSiteConfigAzureStorageAccounts>? AzureStorageAccounts { get; set; }

    [JsonPropertyName("connectionStrings")]
    public IList<V20220301storageSiteStatusSiteConfigConnectionStrings>? ConnectionStrings { get; set; }

    /// <summary>
    /// Storage version of v20220301.CorsSettings_STATUS
    /// Cross-Origin Resource Sharing (CORS) settings for the app.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20220301storageSiteStatusSiteConfigCors? Cors { get; set; }

    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    [JsonPropertyName("documentRoot")]
    public string? DocumentRoot { get; set; }

    /// <summary>
    /// Storage version of v20220301.Experiments_STATUS
    /// Routing rules in production experiments.
    /// </summary>
    [JsonPropertyName("experiments")]
    public V20220301storageSiteStatusSiteConfigExperiments? Experiments { get; set; }

    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    [JsonPropertyName("functionAppScaleLimit")]
    public int? FunctionAppScaleLimit { get; set; }

    [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
    public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }

    [JsonPropertyName("handlerMappings")]
    public IList<V20220301storageSiteStatusSiteConfigHandlerMappings>? HandlerMappings { get; set; }

    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    [JsonPropertyName("http20Enabled")]
    public bool? Http20Enabled { get; set; }

    [JsonPropertyName("httpLoggingEnabled")]
    public bool? HttpLoggingEnabled { get; set; }

    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V20220301storageSiteStatusSiteConfigIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>
    /// Storage version of v20220301.SiteLimits_STATUS
    /// Metric limits set on an app.
    /// </summary>
    [JsonPropertyName("limits")]
    public V20220301storageSiteStatusSiteConfigLimits? Limits { get; set; }

    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    [JsonPropertyName("loadBalancing")]
    public string? LoadBalancing { get; set; }

    [JsonPropertyName("localMySqlEnabled")]
    public bool? LocalMySqlEnabled { get; set; }

    [JsonPropertyName("logsDirectorySizeLimit")]
    public int? LogsDirectorySizeLimit { get; set; }

    /// <summary>
    /// Storage version of v20220301.SiteMachineKey_STATUS
    /// MachineKey of an app.
    /// </summary>
    [JsonPropertyName("machineKey")]
    public V20220301storageSiteStatusSiteConfigMachineKey? MachineKey { get; set; }

    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    [JsonPropertyName("managedServiceIdentityId")]
    public int? ManagedServiceIdentityId { get; set; }

    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    [JsonPropertyName("minimumElasticInstanceCount")]
    public int? MinimumElasticInstanceCount { get; set; }

    [JsonPropertyName("netFrameworkVersion")]
    public string? NetFrameworkVersion { get; set; }

    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    [JsonPropertyName("numberOfWorkers")]
    public int? NumberOfWorkers { get; set; }

    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    [JsonPropertyName("powerShellVersion")]
    public string? PowerShellVersion { get; set; }

    [JsonPropertyName("preWarmedInstanceCount")]
    public int? PreWarmedInstanceCount { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("publishingUsername")]
    public string? PublishingUsername { get; set; }

    /// <summary>
    /// Storage version of v20220301.PushSettings_STATUS
    /// Push settings for the App.
    /// </summary>
    [JsonPropertyName("push")]
    public V20220301storageSiteStatusSiteConfigPush? Push { get; set; }

    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    [JsonPropertyName("requestTracingEnabled")]
    public bool? RequestTracingEnabled { get; set; }

    [JsonPropertyName("requestTracingExpirationTime")]
    public string? RequestTracingExpirationTime { get; set; }

    [JsonPropertyName("scmIpSecurityRestrictions")]
    public IList<V20220301storageSiteStatusSiteConfigScmIpSecurityRestrictions>? ScmIpSecurityRestrictions { get; set; }

    [JsonPropertyName("scmIpSecurityRestrictionsUseMain")]
    public bool? ScmIpSecurityRestrictionsUseMain { get; set; }

    [JsonPropertyName("scmMinTlsVersion")]
    public string? ScmMinTlsVersion { get; set; }

    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    [JsonPropertyName("tracingOptions")]
    public string? TracingOptions { get; set; }

    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    [JsonPropertyName("virtualApplications")]
    public IList<V20220301storageSiteStatusSiteConfigVirtualApplications>? VirtualApplications { get; set; }

    [JsonPropertyName("vnetName")]
    public string? VnetName { get; set; }

    [JsonPropertyName("vnetPrivatePortsCount")]
    public int? VnetPrivatePortsCount { get; set; }

    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    [JsonPropertyName("webSocketsEnabled")]
    public bool? WebSocketsEnabled { get; set; }

    [JsonPropertyName("websiteTimeZone")]
    public string? WebsiteTimeZone { get; set; }

    [JsonPropertyName("windowsFxVersion")]
    public string? WindowsFxVersion { get; set; }

    [JsonPropertyName("xManagedServiceIdentityId")]
    public int? XManagedServiceIdentityId { get; set; }
}

/// <summary>
/// Storage version of v20220301.SlotSwapStatus_STATUS
/// The status of the last successful slot swap operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatusSlotSwapStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("destinationSlotName")]
    public string? DestinationSlotName { get; set; }

    [JsonPropertyName("sourceSlotName")]
    public string? SourceSlotName { get; set; }

    [JsonPropertyName("timestampUtc")]
    public string? TimestampUtc { get; set; }
}

/// <summary>
/// Storage version of v20220301.Site_STATUS
/// A web app, a mobile app backend, or an API app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301storageSiteStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("availabilityState")]
    public string? AvailabilityState { get; set; }

    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }

    [JsonPropertyName("clientCertExclusionPaths")]
    public string? ClientCertExclusionPaths { get; set; }

    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>
    /// Storage version of v20220301.CloningInfo_STATUS
    /// Information needed for cloning operation.
    /// </summary>
    [JsonPropertyName("cloningInfo")]
    public V20220301storageSiteStatusCloningInfo? CloningInfo { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20220301storageSiteStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("containerSize")]
    public int? ContainerSize { get; set; }

    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    [JsonPropertyName("dailyMemoryTimeQuota")]
    public int? DailyMemoryTimeQuota { get; set; }

    [JsonPropertyName("defaultHostName")]
    public string? DefaultHostName { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("enabledHostNames")]
    public IList<string>? EnabledHostNames { get; set; }

    /// <summary>
    /// Storage version of v20220301.ExtendedLocation_STATUS
    /// Extended Location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20220301storageSiteStatusExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("hostNameSslStates")]
    public IList<V20220301storageSiteStatusHostNameSslStates>? HostNameSslStates { get; set; }

    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    [JsonPropertyName("hostNamesDisabled")]
    public bool? HostNamesDisabled { get; set; }

    /// <summary>
    /// Storage version of v20220301.HostingEnvironmentProfile_STATUS
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V20220301storageSiteStatusHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20220301.ManagedServiceIdentity_STATUS
    /// Managed service identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20220301storageSiteStatusIdentity? Identity { get; set; }

    [JsonPropertyName("inProgressOperationId")]
    public string? InProgressOperationId { get; set; }

    [JsonPropertyName("isDefaultContainer")]
    public bool? IsDefaultContainer { get; set; }

    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("lastModifiedTimeUtc")]
    public string? LastModifiedTimeUtc { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("maxNumberOfWorkers")]
    public int? MaxNumberOfWorkers { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("redundancyMode")]
    public string? RedundancyMode { get; set; }

    [JsonPropertyName("repositorySiteName")]
    public string? RepositorySiteName { get; set; }

    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("scmSiteAlsoStopped")]
    public bool? ScmSiteAlsoStopped { get; set; }

    [JsonPropertyName("serverFarmId")]
    public string? ServerFarmId { get; set; }

    /// <summary>
    /// Storage version of v20220301.SiteConfig_STATUS
    /// Configuration of an App Service app.
    /// </summary>
    [JsonPropertyName("siteConfig")]
    public V20220301storageSiteStatusSiteConfig? SiteConfig { get; set; }

    /// <summary>
    /// Storage version of v20220301.SlotSwapStatus_STATUS
    /// The status of the last successful slot swap operation.
    /// </summary>
    [JsonPropertyName("slotSwapStatus")]
    public V20220301storageSiteStatusSlotSwapStatus? SlotSwapStatus { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("storageAccountRequired")]
    public bool? StorageAccountRequired { get; set; }

    [JsonPropertyName("suspendedTill")]
    public string? SuspendedTill { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("targetSwapSlot")]
    public string? TargetSwapSlot { get; set; }

    [JsonPropertyName("trafficManagerHostNames")]
    public IList<string>? TrafficManagerHostNames { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("usageState")]
    public string? UsageState { get; set; }

    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    [JsonPropertyName("vnetContentShareEnabled")]
    public bool? VnetContentShareEnabled { get; set; }

    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }
}

/// <summary>
/// Storage version of v20220301.Site
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/WebApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220301storageSite : IKubernetesObject<V1ObjectMeta>, ISpec<V20220301storageSiteSpec?>, IStatus<V20220301storageSiteStatus?>
{
    public const string KubeApiVersion = "v20220301storage";
    public const string KubeKind = "Site";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v20220301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Site";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20220301.Site_Spec</summary>
    [JsonPropertyName("spec")]
    public V20220301storageSiteSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20220301.Site_STATUS
    /// A web app, a mobile app backend, or an API app.
    /// </summary>
    [JsonPropertyName("status")]
    public V20220301storageSiteStatus? Status { get; set; }
}
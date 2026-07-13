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
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/WebApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301SiteList : IKubernetesObject<V1ListMeta>, IItems<V1api20220301Site>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "SiteList";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SiteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220301Site objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220301Site> Items { get; set; }
}

/// <summary>
/// ClientCertMode: This composes with ClientCertEnabled setting.
/// - ClientCertEnabled: false means ClientCert is ignored.
/// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
/// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecClientCertModeEnum>))]
public enum V1api20220301SiteSpecClientCertModeEnum
{
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional,
    [EnumMember(Value = "OptionalInteractiveUser"), JsonStringEnumMemberName("OptionalInteractiveUser")]
    OptionalInteractiveUser,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required
}

/// <summary>
/// SourceWebAppReference: ARM resource ID of the source app. App resource ID is of the form
/// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots
/// and
/// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for
/// other slots.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecCloningInfoSourceWebAppReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecCloningInfoTrafficManagerProfileReference
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

/// <summary>CloningInfo: If specified during app creation, the app is cloned from a source app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecCloningInfo
{
    /// <summary>
    /// AppSettingsOverrides: Application setting overrides for cloned app. If specified, these settings override the settings
    /// cloned
    /// from source app. Otherwise, application settings from source app are retained.
    /// </summary>
    [JsonPropertyName("appSettingsOverrides")]
    public IDictionary<string, string>? AppSettingsOverrides { get; set; }

    /// <summary>CloneCustomHostNames: &lt;code&gt;true&lt;/code&gt; to clone custom hostnames from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("cloneCustomHostNames")]
    public bool? CloneCustomHostNames { get; set; }

    /// <summary>CloneSourceControl: &lt;code&gt;true&lt;/code&gt; to clone source control from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("cloneSourceControl")]
    public bool? CloneSourceControl { get; set; }

    /// <summary>ConfigureLoadBalancing: &lt;code&gt;true&lt;/code&gt; to configure load balancing for source and destination app.</summary>
    [JsonPropertyName("configureLoadBalancing")]
    public bool? ConfigureLoadBalancing { get; set; }

    /// <summary>
    /// CorrelationId: Correlation ID of cloning operation. This ID ties multiple cloning operations
    /// together to use the same snapshot.
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>HostingEnvironment: App Service Environment.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public string? HostingEnvironment { get; set; }

    /// <summary>Overwrite: &lt;code&gt;true&lt;/code&gt; to overwrite destination app; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    /// <summary>SourceWebAppLocation: Location of source app ex: West US or North Europe</summary>
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
    public required V1api20220301SiteSpecCloningInfoSourceWebAppReference SourceWebAppReference { get; set; }

    /// <summary>
    /// TrafficManagerProfileName: Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile
    /// does not already exist.
    /// </summary>
    [JsonPropertyName("trafficManagerProfileName")]
    public string? TrafficManagerProfileName { get; set; }

    /// <summary>
    /// TrafficManagerProfileReference: ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager
    /// resource ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
    /// </summary>
    [JsonPropertyName("trafficManagerProfileReference")]
    public V1api20220301SiteSpecCloningInfoTrafficManagerProfileReference? TrafficManagerProfileReference { get; set; }
}

/// <summary>ExtendedLocation: Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecExtendedLocation
{
    /// <summary>Name: Name of extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>HostType: Indicates whether the hostname is a standard or repository hostname.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecHostNameSslStatesHostTypeEnum>))]
public enum V1api20220301SiteSpecHostNameSslStatesHostTypeEnum
{
    [EnumMember(Value = "Repository"), JsonStringEnumMemberName("Repository")]
    Repository,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>SslState: SSL type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecHostNameSslStatesSslStateEnum>))]
public enum V1api20220301SiteSpecHostNameSslStatesSslStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "IpBasedEnabled"), JsonStringEnumMemberName("IpBasedEnabled")]
    IpBasedEnabled,
    [EnumMember(Value = "SniEnabled"), JsonStringEnumMemberName("SniEnabled")]
    SniEnabled
}

/// <summary>SSL-enabled hostname.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecHostNameSslStates
{
    /// <summary>HostType: Indicates whether the hostname is a standard or repository hostname.</summary>
    [JsonPropertyName("hostType")]
    public V1api20220301SiteSpecHostNameSslStatesHostTypeEnum? HostType { get; set; }

    /// <summary>Name: Hostname.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SslState: SSL type.</summary>
    [JsonPropertyName("sslState")]
    public V1api20220301SiteSpecHostNameSslStatesSslStateEnum? SslState { get; set; }

    /// <summary>Thumbprint: SSL certificate thumbprint.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>ToUpdate: Set to &lt;code&gt;true&lt;/code&gt; to update existing hostname.</summary>
    [JsonPropertyName("toUpdate")]
    public bool? ToUpdate { get; set; }

    /// <summary>VirtualIP: Virtual IP address assigned to the hostname if IP based SSL is enabled.</summary>
    [JsonPropertyName("virtualIP")]
    public string? VirtualIP { get; set; }
}

/// <summary>Reference: Resource ID of the App Service Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecHostingEnvironmentProfileReference
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

/// <summary>HostingEnvironmentProfile: App Service Environment to use for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecHostingEnvironmentProfile
{
    /// <summary>Reference: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("reference")]
    public V1api20220301SiteSpecHostingEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>Type: Type of managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecIdentityTypeEnum>))]
public enum V1api20220301SiteSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220301SiteSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecIdentity
{
    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public V1api20220301SiteSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user assigned identities associated with the resource. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220301SiteSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecOperatorSpecSecretExpressions
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
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220301SiteSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220301SiteSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RedundancyMode: Site redundancy mode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecRedundancyModeEnum>))]
public enum V1api20220301SiteSpecRedundancyModeEnum
{
    [EnumMember(Value = "ActiveActive"), JsonStringEnumMemberName("ActiveActive")]
    ActiveActive,
    [EnumMember(Value = "Failover"), JsonStringEnumMemberName("Failover")]
    Failover,
    [EnumMember(Value = "GeoRedundant"), JsonStringEnumMemberName("GeoRedundant")]
    GeoRedundant,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// ServerFarmReference: Resource ID of the associated App Service plan, formatted as:
/// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecServerFarmReference
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

/// <summary>ApiDefinition: Information about the formal API definition for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigApiDefinition
{
    /// <summary>Url: The URL of the API definition.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference: APIM-Api Identifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigApiManagementConfigReference
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

/// <summary>ApiManagementConfig: Azure API management settings linked to the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigApiManagementConfig
{
    /// <summary>Reference: APIM-Api Identifier.</summary>
    [JsonPropertyName("reference")]
    public V1api20220301SiteSpecSiteConfigApiManagementConfigReference? Reference { get; set; }
}

/// <summary>Name value pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAppSettings
{
    /// <summary>Name: Pair name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Pair value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ActionType: Predefined action to be taken.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigAutoHealRulesActionsActionTypeEnum>))]
public enum V1api20220301SiteSpecSiteConfigAutoHealRulesActionsActionTypeEnum
{
    [EnumMember(Value = "CustomAction"), JsonStringEnumMemberName("CustomAction")]
    CustomAction,
    [EnumMember(Value = "LogEvent"), JsonStringEnumMemberName("LogEvent")]
    LogEvent,
    [EnumMember(Value = "Recycle"), JsonStringEnumMemberName("Recycle")]
    Recycle
}

/// <summary>CustomAction: Custom action to be taken.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesActionsCustomAction
{
    /// <summary>Exe: Executable to be run.</summary>
    [JsonPropertyName("exe")]
    public string? Exe { get; set; }

    /// <summary>Parameters: Parameters for the executable.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary>Actions: Actions to be executed when a rule is triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesActions
{
    /// <summary>ActionType: Predefined action to be taken.</summary>
    [JsonPropertyName("actionType")]
    public V1api20220301SiteSpecSiteConfigAutoHealRulesActionsActionTypeEnum? ActionType { get; set; }

    /// <summary>CustomAction: Custom action to be taken.</summary>
    [JsonPropertyName("customAction")]
    public V1api20220301SiteSpecSiteConfigAutoHealRulesActionsCustomAction? CustomAction { get; set; }

    /// <summary>
    /// MinProcessExecutionTime: Minimum time the process must execute
    /// before taking the action
    /// </summary>
    [JsonPropertyName("minProcessExecutionTime")]
    public string? MinProcessExecutionTime { get; set; }
}

/// <summary>Requests: A rule based on total requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersRequests
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>SlowRequests: A rule based on request execution time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersSlowRequests
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Path: Request Path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    /// <summary>TimeTaken: Time taken.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>Trigger based on request execution time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersSlowRequestsWithPath
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Path: Request Path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    /// <summary>TimeTaken: Time taken.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>Trigger based on status code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersStatusCodes
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Path: Request Path</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Status: HTTP status code.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>SubStatus: Request Sub Status.</summary>
    [JsonPropertyName("subStatus")]
    public int? SubStatus { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    /// <summary>Win32Status: Win32 error code.</summary>
    [JsonPropertyName("win32Status")]
    public int? Win32Status { get; set; }
}

/// <summary>Trigger based on range of status codes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersStatusCodesRange
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>StatusCodes: HTTP status code.</summary>
    [JsonPropertyName("statusCodes")]
    public string? StatusCodes { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>Triggers: Conditions that describe when to execute the auto-heal actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRulesTriggers
{
    /// <summary>PrivateBytesInKB: A rule based on private bytes.</summary>
    [JsonPropertyName("privateBytesInKB")]
    public int? PrivateBytesInKB { get; set; }

    /// <summary>Requests: A rule based on total requests.</summary>
    [JsonPropertyName("requests")]
    public V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersRequests? Requests { get; set; }

    /// <summary>SlowRequests: A rule based on request execution time.</summary>
    [JsonPropertyName("slowRequests")]
    public V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersSlowRequests? SlowRequests { get; set; }

    /// <summary>SlowRequestsWithPath: A rule based on multiple Slow Requests Rule with path</summary>
    [JsonPropertyName("slowRequestsWithPath")]
    public IList<V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersSlowRequestsWithPath>? SlowRequestsWithPath { get; set; }

    /// <summary>StatusCodes: A rule based on status codes.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersStatusCodes>? StatusCodes { get; set; }

    /// <summary>StatusCodesRange: A rule based on status codes ranges.</summary>
    [JsonPropertyName("statusCodesRange")]
    public IList<V1api20220301SiteSpecSiteConfigAutoHealRulesTriggersStatusCodesRange>? StatusCodesRange { get; set; }
}

/// <summary>AutoHealRules: Auto Heal rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAutoHealRules
{
    /// <summary>Actions: Actions to be executed when a rule is triggered.</summary>
    [JsonPropertyName("actions")]
    public V1api20220301SiteSpecSiteConfigAutoHealRulesActions? Actions { get; set; }

    /// <summary>Triggers: Conditions that describe when to execute the auto-heal actions.</summary>
    [JsonPropertyName("triggers")]
    public V1api20220301SiteSpecSiteConfigAutoHealRulesTriggers? Triggers { get; set; }
}

/// <summary>AccessKey: Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAzureStorageAccountsAccessKey
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

/// <summary>Type: Type of storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigAzureStorageAccountsTypeEnum>))]
public enum V1api20220301SiteSpecSiteConfigAzureStorageAccountsTypeEnum
{
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureFiles"), JsonStringEnumMemberName("AzureFiles")]
    AzureFiles
}

/// <summary>Azure Files or Blob Storage access information value for dictionary storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigAzureStorageAccounts
{
    /// <summary>AccessKey: Access key for the storage account.</summary>
    [JsonPropertyName("accessKey")]
    public V1api20220301SiteSpecSiteConfigAzureStorageAccountsAccessKey? AccessKey { get; set; }

    /// <summary>AccountName: Name of the storage account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>MountPath: Path to mount the storage within the site&apos;s runtime environment.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>ShareName: Name of the file share (container name, for Blob storage).</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>Type: Type of storage.</summary>
    [JsonPropertyName("type")]
    public V1api20220301SiteSpecSiteConfigAzureStorageAccountsTypeEnum? Type { get; set; }
}

/// <summary>Type: Type of database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigConnectionStringsTypeEnum>))]
public enum V1api20220301SiteSpecSiteConfigConnectionStringsTypeEnum
{
    [EnumMember(Value = "ApiHub"), JsonStringEnumMemberName("ApiHub")]
    ApiHub,
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom,
    [EnumMember(Value = "DocDb"), JsonStringEnumMemberName("DocDb")]
    DocDb,
    [EnumMember(Value = "EventHub"), JsonStringEnumMemberName("EventHub")]
    EventHub,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "NotificationHub"), JsonStringEnumMemberName("NotificationHub")]
    NotificationHub,
    [EnumMember(Value = "PostgreSQL"), JsonStringEnumMemberName("PostgreSQL")]
    PostgreSQL,
    [EnumMember(Value = "RedisCache"), JsonStringEnumMemberName("RedisCache")]
    RedisCache,
    [EnumMember(Value = "SQLAzure"), JsonStringEnumMemberName("SQLAzure")]
    SQLAzure,
    [EnumMember(Value = "SQLServer"), JsonStringEnumMemberName("SQLServer")]
    SQLServer,
    [EnumMember(Value = "ServiceBus"), JsonStringEnumMemberName("ServiceBus")]
    ServiceBus
}

/// <summary>Database connection string information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigConnectionStrings
{
    /// <summary>ConnectionString: Connection string value.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>Name: Name of connection string.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of database.</summary>
    [JsonPropertyName("type")]
    public V1api20220301SiteSpecSiteConfigConnectionStringsTypeEnum? Type { get; set; }
}

/// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigCors
{
    /// <summary>
    /// AllowedOrigins: Gets or sets the list of origins that should be allowed to make cross-origin
    /// calls (for example: http://example.com:12345). Use &quot;*&quot; to allow all.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// SupportCredentials: Gets or sets whether CORS requests with credentials are allowed. See
    /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
    /// for more details.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>
/// Routing rules for ramp up testing. This rule allows to redirect static traffic % to a slot or to gradually change
/// routing % based on performance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigExperimentsRampUpRules
{
    /// <summary>
    /// ActionHostName: Hostname of a slot to which the traffic will be redirected if decided to. E.g.
    /// myapp-stage.azurewebsites.net.
    /// </summary>
    [JsonPropertyName("actionHostName")]
    public string? ActionHostName { get; set; }

    /// <summary>
    /// ChangeDecisionCallbackUrl: Custom decision algorithm can be provided in TiPCallback site extension which URL can be
    /// specified.
    /// </summary>
    [JsonPropertyName("changeDecisionCallbackUrl")]
    public string? ChangeDecisionCallbackUrl { get; set; }

    /// <summary>ChangeIntervalInMinutes: Specifies interval in minutes to reevaluate ReroutePercentage.</summary>
    [JsonPropertyName("changeIntervalInMinutes")]
    public int? ChangeIntervalInMinutes { get; set; }

    /// <summary>
    /// ChangeStep: In auto ramp up scenario this is the step to add/remove from &lt;code&gt;ReroutePercentage&lt;/code&gt; until it reaches
    /// \n&lt;code&gt;MinReroutePercentage&lt;/code&gt; or
    /// &lt;code&gt;MaxReroutePercentage&lt;/code&gt;. Site metrics are checked every N minutes specified in
    /// &lt;code&gt;ChangeIntervalInMinutes&lt;/code&gt;.\nCustom decision algorithm
    /// can be provided in TiPCallback site extension which URL can be specified in &lt;code&gt;ChangeDecisionCallbackUrl&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("changeStep")]
    public double? ChangeStep { get; set; }

    /// <summary>MaxReroutePercentage: Specifies upper boundary below which ReroutePercentage will stay.</summary>
    [JsonPropertyName("maxReroutePercentage")]
    public double? MaxReroutePercentage { get; set; }

    /// <summary>MinReroutePercentage: Specifies lower boundary above which ReroutePercentage will stay.</summary>
    [JsonPropertyName("minReroutePercentage")]
    public double? MinReroutePercentage { get; set; }

    /// <summary>
    /// Name: Name of the routing rule. The recommended name would be to point to the slot which will receive the traffic in the
    /// experiment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ReroutePercentage: Percentage of the traffic which will be redirected to &lt;code&gt;ActionHostName&lt;/code&gt;.</summary>
    [JsonPropertyName("reroutePercentage")]
    public double? ReroutePercentage { get; set; }
}

/// <summary>Experiments: This is work around for polymorphic types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigExperiments
{
    /// <summary>RampUpRules: List of ramp-up rules.</summary>
    [JsonPropertyName("rampUpRules")]
    public IList<V1api20220301SiteSpecSiteConfigExperimentsRampUpRules>? RampUpRules { get; set; }
}

/// <summary>FtpsState: State of FTP / FTPS service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigFtpsStateEnum>))]
public enum V1api20220301SiteSpecSiteConfigFtpsStateEnum
{
    [EnumMember(Value = "AllAllowed"), JsonStringEnumMemberName("AllAllowed")]
    AllAllowed,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "FtpsOnly"), JsonStringEnumMemberName("FtpsOnly")]
    FtpsOnly
}

/// <summary>
/// The IIS handler mappings used to define which handler processes HTTP requests with certain extension.
/// For example, it
/// is used to configure php-cgi.exe process to handle all HTTP requests with *.php extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigHandlerMappings
{
    /// <summary>Arguments: Command-line arguments to be passed to the script processor.</summary>
    [JsonPropertyName("arguments")]
    public string? Arguments { get; set; }

    /// <summary>Extension: Requests with this extension will be handled using the specified FastCGI application.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>ScriptProcessor: The absolute path to the FastCGI application.</summary>
    [JsonPropertyName("scriptProcessor")]
    public string? ScriptProcessor { get; set; }
}

/// <summary>Tag: Defines what this IP filter will be used for. This is to support IP filtering on proxies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigIpSecurityRestrictionsTagEnum>))]
public enum V1api20220301SiteSpecSiteConfigIpSecurityRestrictionsTagEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "ServiceTag"), JsonStringEnumMemberName("ServiceTag")]
    ServiceTag,
    [EnumMember(Value = "XffProxy"), JsonStringEnumMemberName("XffProxy")]
    XffProxy
}

/// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigIpSecurityRestrictionsVnetSubnetResourceReference
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

/// <summary>IP security restriction on an app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigIpSecurityRestrictions
{
    /// <summary>Action: Allow or Deny access for this IP range.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description: IP restriction rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Headers: IP restriction rule headers.
    /// X-Forwarded-Host (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-Host#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), all hosts(or lack of) are allowed.
    /// - A value is compared using ordinal-ignore-case (excluding port number).
    /// - Subdomain wildcards are permitted but don&apos;t match the root domain. For example, *.contoso.com matches the subdomain
    /// foo.contoso.com
    /// but not the root domain contoso.com or multi-level foo.bar.contoso.com
    /// - Unicode host names are allowed but are converted to Punycode for matching.
    /// X-Forwarded-For (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-For#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), any forwarded-for chains (or lack of) are allowed.
    /// - If any address (excluding port number) in the chain (comma separated) matches the CIDR defined by the property.
    /// X-Azure-FDID and X-FD-HealthProbe.
    /// The matching logic is exact match.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>
    /// IpAddress: IP address the security restriction is valid for.
    /// It can be in form of pure ipv4 address (required SubnetMask property) or
    /// CIDR notation such as ipv4/mask (leading bit match). For CIDR,
    /// SubnetMask property must not be specified.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Name: IP restriction rule name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of IP restriction rule.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>SubnetMask: Subnet mask for the range of IP addresses the restriction is valid for.</summary>
    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    /// <summary>SubnetTrafficTag: (internal) Subnet traffic tag</summary>
    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    /// <summary>Tag: Defines what this IP filter will be used for. This is to support IP filtering on proxies.</summary>
    [JsonPropertyName("tag")]
    public V1api20220301SiteSpecSiteConfigIpSecurityRestrictionsTagEnum? Tag { get; set; }

    /// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
    [JsonPropertyName("vnetSubnetResourceReference")]
    public V1api20220301SiteSpecSiteConfigIpSecurityRestrictionsVnetSubnetResourceReference? VnetSubnetResourceReference { get; set; }

    /// <summary>VnetTrafficTag: (internal) Vnet traffic tag</summary>
    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>Limits: Site limits.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigLimits
{
    /// <summary>MaxDiskSizeInMb: Maximum allowed disk size usage in MB.</summary>
    [JsonPropertyName("maxDiskSizeInMb")]
    public int? MaxDiskSizeInMb { get; set; }

    /// <summary>MaxMemoryInMb: Maximum allowed memory usage in MB.</summary>
    [JsonPropertyName("maxMemoryInMb")]
    public int? MaxMemoryInMb { get; set; }

    /// <summary>MaxPercentageCpu: Maximum allowed CPU usage percentage.</summary>
    [JsonPropertyName("maxPercentageCpu")]
    public double? MaxPercentageCpu { get; set; }
}

/// <summary>LoadBalancing: Site load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigLoadBalancingEnum>))]
public enum V1api20220301SiteSpecSiteConfigLoadBalancingEnum
{
    [EnumMember(Value = "LeastRequests"), JsonStringEnumMemberName("LeastRequests")]
    LeastRequests,
    [EnumMember(Value = "LeastResponseTime"), JsonStringEnumMemberName("LeastResponseTime")]
    LeastResponseTime,
    [EnumMember(Value = "PerSiteRoundRobin"), JsonStringEnumMemberName("PerSiteRoundRobin")]
    PerSiteRoundRobin,
    [EnumMember(Value = "RequestHash"), JsonStringEnumMemberName("RequestHash")]
    RequestHash,
    [EnumMember(Value = "WeightedRoundRobin"), JsonStringEnumMemberName("WeightedRoundRobin")]
    WeightedRoundRobin,
    [EnumMember(Value = "WeightedTotalTraffic"), JsonStringEnumMemberName("WeightedTotalTraffic")]
    WeightedTotalTraffic
}

/// <summary>ManagedPipelineMode: Managed pipeline mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigManagedPipelineModeEnum>))]
public enum V1api20220301SiteSpecSiteConfigManagedPipelineModeEnum
{
    [EnumMember(Value = "Classic"), JsonStringEnumMemberName("Classic")]
    Classic,
    [EnumMember(Value = "Integrated"), JsonStringEnumMemberName("Integrated")]
    Integrated
}

/// <summary>MinTlsVersion: MinTlsVersion: configures the minimum version of TLS required for SSL requests</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigMinTlsVersionEnum>))]
public enum V1api20220301SiteSpecSiteConfigMinTlsVersionEnum
{
    [EnumMember(Value = "1.0"), JsonStringEnumMemberName("1.0")]
    _10,
    [EnumMember(Value = "1.1"), JsonStringEnumMemberName("1.1")]
    _11,
    [EnumMember(Value = "1.2"), JsonStringEnumMemberName("1.2")]
    _12
}

/// <summary>Push: Push endpoint settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigPush
{
    /// <summary>
    /// DynamicTagsJson: Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in
    /// the push registration endpoint.
    /// </summary>
    [JsonPropertyName("dynamicTagsJson")]
    public string? DynamicTagsJson { get; set; }

    /// <summary>IsPushEnabled: Gets or sets a flag indicating whether the Push endpoint is enabled.</summary>
    [JsonPropertyName("isPushEnabled")]
    public required bool IsPushEnabled { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// TagWhitelistJson: Gets or sets a JSON string containing a list of tags that are in the allowed list for use by the push
    /// registration endpoint.
    /// </summary>
    [JsonPropertyName("tagWhitelistJson")]
    public string? TagWhitelistJson { get; set; }

    /// <summary>
    /// TagsRequiringAuth: Gets or sets a JSON string containing a list of tags that require user authentication to be used in
    /// the push registration endpoint.
    /// Tags can consist of alphanumeric characters and the following:
    /// &apos;_&apos;, &apos;@&apos;, &apos;#&apos;, &apos;.&apos;, &apos;:&apos;, &apos;-&apos;.
    /// Validation should be performed at the PushRequestHandler.
    /// </summary>
    [JsonPropertyName("tagsRequiringAuth")]
    public string? TagsRequiringAuth { get; set; }
}

/// <summary>Tag: Defines what this IP filter will be used for. This is to support IP filtering on proxies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigScmIpSecurityRestrictionsTagEnum>))]
public enum V1api20220301SiteSpecSiteConfigScmIpSecurityRestrictionsTagEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "ServiceTag"), JsonStringEnumMemberName("ServiceTag")]
    ServiceTag,
    [EnumMember(Value = "XffProxy"), JsonStringEnumMemberName("XffProxy")]
    XffProxy
}

/// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigScmIpSecurityRestrictionsVnetSubnetResourceReference
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

/// <summary>IP security restriction on an app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigScmIpSecurityRestrictions
{
    /// <summary>Action: Allow or Deny access for this IP range.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description: IP restriction rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Headers: IP restriction rule headers.
    /// X-Forwarded-Host (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-Host#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), all hosts(or lack of) are allowed.
    /// - A value is compared using ordinal-ignore-case (excluding port number).
    /// - Subdomain wildcards are permitted but don&apos;t match the root domain. For example, *.contoso.com matches the subdomain
    /// foo.contoso.com
    /// but not the root domain contoso.com or multi-level foo.bar.contoso.com
    /// - Unicode host names are allowed but are converted to Punycode for matching.
    /// X-Forwarded-For (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-For#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), any forwarded-for chains (or lack of) are allowed.
    /// - If any address (excluding port number) in the chain (comma separated) matches the CIDR defined by the property.
    /// X-Azure-FDID and X-FD-HealthProbe.
    /// The matching logic is exact match.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>
    /// IpAddress: IP address the security restriction is valid for.
    /// It can be in form of pure ipv4 address (required SubnetMask property) or
    /// CIDR notation such as ipv4/mask (leading bit match). For CIDR,
    /// SubnetMask property must not be specified.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Name: IP restriction rule name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of IP restriction rule.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>SubnetMask: Subnet mask for the range of IP addresses the restriction is valid for.</summary>
    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    /// <summary>SubnetTrafficTag: (internal) Subnet traffic tag</summary>
    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    /// <summary>Tag: Defines what this IP filter will be used for. This is to support IP filtering on proxies.</summary>
    [JsonPropertyName("tag")]
    public V1api20220301SiteSpecSiteConfigScmIpSecurityRestrictionsTagEnum? Tag { get; set; }

    /// <summary>VnetSubnetResourceReference: Virtual network resource id</summary>
    [JsonPropertyName("vnetSubnetResourceReference")]
    public V1api20220301SiteSpecSiteConfigScmIpSecurityRestrictionsVnetSubnetResourceReference? VnetSubnetResourceReference { get; set; }

    /// <summary>VnetTrafficTag: (internal) Vnet traffic tag</summary>
    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>ScmMinTlsVersion: ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigScmMinTlsVersionEnum>))]
public enum V1api20220301SiteSpecSiteConfigScmMinTlsVersionEnum
{
    [EnumMember(Value = "1.0"), JsonStringEnumMemberName("1.0")]
    _10,
    [EnumMember(Value = "1.1"), JsonStringEnumMemberName("1.1")]
    _11,
    [EnumMember(Value = "1.2"), JsonStringEnumMemberName("1.2")]
    _12
}

/// <summary>ScmType: SCM type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301SiteSpecSiteConfigScmTypeEnum>))]
public enum V1api20220301SiteSpecSiteConfigScmTypeEnum
{
    [EnumMember(Value = "BitbucketGit"), JsonStringEnumMemberName("BitbucketGit")]
    BitbucketGit,
    [EnumMember(Value = "BitbucketHg"), JsonStringEnumMemberName("BitbucketHg")]
    BitbucketHg,
    [EnumMember(Value = "CodePlexGit"), JsonStringEnumMemberName("CodePlexGit")]
    CodePlexGit,
    [EnumMember(Value = "CodePlexHg"), JsonStringEnumMemberName("CodePlexHg")]
    CodePlexHg,
    [EnumMember(Value = "Dropbox"), JsonStringEnumMemberName("Dropbox")]
    Dropbox,
    [EnumMember(Value = "ExternalGit"), JsonStringEnumMemberName("ExternalGit")]
    ExternalGit,
    [EnumMember(Value = "ExternalHg"), JsonStringEnumMemberName("ExternalHg")]
    ExternalHg,
    [EnumMember(Value = "GitHub"), JsonStringEnumMemberName("GitHub")]
    GitHub,
    [EnumMember(Value = "LocalGit"), JsonStringEnumMemberName("LocalGit")]
    LocalGit,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "OneDrive"), JsonStringEnumMemberName("OneDrive")]
    OneDrive,
    [EnumMember(Value = "Tfs"), JsonStringEnumMemberName("Tfs")]
    Tfs,
    [EnumMember(Value = "VSO"), JsonStringEnumMemberName("VSO")]
    VSO,
    [EnumMember(Value = "VSTSRM"), JsonStringEnumMemberName("VSTSRM")]
    VSTSRM
}

/// <summary>Directory for virtual application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigVirtualApplicationsVirtualDirectories
{
    /// <summary>PhysicalPath: Physical path.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>VirtualPath: Path to virtual application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>Virtual application in an app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfigVirtualApplications
{
    /// <summary>PhysicalPath: Physical path.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>PreloadEnabled: &lt;code&gt;true&lt;/code&gt; if preloading is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("preloadEnabled")]
    public bool? PreloadEnabled { get; set; }

    /// <summary>VirtualDirectories: Virtual directories for virtual application.</summary>
    [JsonPropertyName("virtualDirectories")]
    public IList<V1api20220301SiteSpecSiteConfigVirtualApplicationsVirtualDirectories>? VirtualDirectories { get; set; }

    /// <summary>VirtualPath: Virtual path.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>SiteConfig: Configuration of the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecSiteConfig
{
    /// <summary>AcrUseManagedIdentityCreds: Flag to use Managed Identity Creds for ACR pull</summary>
    [JsonPropertyName("acrUseManagedIdentityCreds")]
    public bool? AcrUseManagedIdentityCreds { get; set; }

    /// <summary>AcrUserManagedIdentityID: If using user managed identity, the user managed identity ClientId</summary>
    [JsonPropertyName("acrUserManagedIdentityID")]
    public string? AcrUserManagedIdentityID { get; set; }

    /// <summary>AlwaysOn: &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>ApiDefinition: Information about the formal API definition for the app.</summary>
    [JsonPropertyName("apiDefinition")]
    public V1api20220301SiteSpecSiteConfigApiDefinition? ApiDefinition { get; set; }

    /// <summary>ApiManagementConfig: Azure API management settings linked to the app.</summary>
    [JsonPropertyName("apiManagementConfig")]
    public V1api20220301SiteSpecSiteConfigApiManagementConfig? ApiManagementConfig { get; set; }

    /// <summary>AppCommandLine: App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>AppSettings: Application settings.</summary>
    [JsonPropertyName("appSettings")]
    public IList<V1api20220301SiteSpecSiteConfigAppSettings>? AppSettings { get; set; }

    /// <summary>AutoHealEnabled: &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>AutoHealRules: Auto Heal rules.</summary>
    [JsonPropertyName("autoHealRules")]
    public V1api20220301SiteSpecSiteConfigAutoHealRules? AutoHealRules { get; set; }

    /// <summary>AutoSwapSlotName: Auto-swap slot name.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>AzureStorageAccounts: List of Azure Storage Accounts.</summary>
    [JsonPropertyName("azureStorageAccounts")]
    public IDictionary<string, V1api20220301SiteSpecSiteConfigAzureStorageAccounts>? AzureStorageAccounts { get; set; }

    /// <summary>ConnectionStrings: Connection strings.</summary>
    [JsonPropertyName("connectionStrings")]
    public IList<V1api20220301SiteSpecSiteConfigConnectionStrings>? ConnectionStrings { get; set; }

    /// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20220301SiteSpecSiteConfigCors? Cors { get; set; }

    /// <summary>DefaultDocuments: Default documents.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>DetailedErrorLoggingEnabled: &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    /// <summary>DocumentRoot: Document root.</summary>
    [JsonPropertyName("documentRoot")]
    public string? DocumentRoot { get; set; }

    /// <summary>Experiments: This is work around for polymorphic types.</summary>
    [JsonPropertyName("experiments")]
    public V1api20220301SiteSpecSiteConfigExperiments? Experiments { get; set; }

    /// <summary>FtpsState: State of FTP / FTPS service</summary>
    [JsonPropertyName("ftpsState")]
    public V1api20220301SiteSpecSiteConfigFtpsStateEnum? FtpsState { get; set; }

    /// <summary>
    /// FunctionAppScaleLimit: Maximum number of workers that a site can scale out to.
    /// This setting only applies to the Consumption and Elastic Premium Plans
    /// </summary>
    [JsonPropertyName("functionAppScaleLimit")]
    public int? FunctionAppScaleLimit { get; set; }

    /// <summary>
    /// FunctionsRuntimeScaleMonitoringEnabled: Gets or sets a value indicating whether functions runtime scale monitoring is
    /// enabled. When enabled,
    /// the ScaleController will not monitor event sources directly, but will instead call to the
    /// runtime to get scale status.
    /// </summary>
    [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
    public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>HandlerMappings: Handler mappings.</summary>
    [JsonPropertyName("handlerMappings")]
    public IList<V1api20220301SiteSpecSiteConfigHandlerMappings>? HandlerMappings { get; set; }

    /// <summary>HealthCheckPath: Health check path</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Http20Enabled: Http20Enabled: configures a web site to allow clients to connect over http2.0</summary>
    [JsonPropertyName("http20Enabled")]
    public bool? Http20Enabled { get; set; }

    /// <summary>HttpLoggingEnabled: &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("httpLoggingEnabled")]
    public bool? HttpLoggingEnabled { get; set; }

    /// <summary>IpSecurityRestrictions: IP security restrictions for main.</summary>
    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V1api20220301SiteSpecSiteConfigIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    /// <summary>JavaContainer: Java container.</summary>
    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    /// <summary>JavaContainerVersion: Java container version.</summary>
    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    /// <summary>JavaVersion: Java version.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>KeyVaultReferenceIdentity: Identity to use for Key Vault Reference authentication.</summary>
    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>Limits: Site limits.</summary>
    [JsonPropertyName("limits")]
    public V1api20220301SiteSpecSiteConfigLimits? Limits { get; set; }

    /// <summary>LinuxFxVersion: Linux App Framework and version</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>LoadBalancing: Site load balancing.</summary>
    [JsonPropertyName("loadBalancing")]
    public V1api20220301SiteSpecSiteConfigLoadBalancingEnum? LoadBalancing { get; set; }

    /// <summary>LocalMySqlEnabled: &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("localMySqlEnabled")]
    public bool? LocalMySqlEnabled { get; set; }

    /// <summary>LogsDirectorySizeLimit: HTTP logs directory size limit.</summary>
    [JsonPropertyName("logsDirectorySizeLimit")]
    public int? LogsDirectorySizeLimit { get; set; }

    /// <summary>ManagedPipelineMode: Managed pipeline mode.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public V1api20220301SiteSpecSiteConfigManagedPipelineModeEnum? ManagedPipelineMode { get; set; }

    /// <summary>ManagedServiceIdentityId: Managed Service Identity Id</summary>
    [JsonPropertyName("managedServiceIdentityId")]
    public int? ManagedServiceIdentityId { get; set; }

    /// <summary>MinTlsVersion: MinTlsVersion: configures the minimum version of TLS required for SSL requests</summary>
    [JsonPropertyName("minTlsVersion")]
    public V1api20220301SiteSpecSiteConfigMinTlsVersionEnum? MinTlsVersion { get; set; }

    /// <summary>
    /// MinimumElasticInstanceCount: Number of minimum instance count for a site
    /// This setting only applies to the Elastic Plans
    /// </summary>
    [JsonPropertyName("minimumElasticInstanceCount")]
    public int? MinimumElasticInstanceCount { get; set; }

    /// <summary>NetFrameworkVersion: .NET Framework version.</summary>
    [JsonPropertyName("netFrameworkVersion")]
    public string? NetFrameworkVersion { get; set; }

    /// <summary>NodeVersion: Version of Node.js.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>NumberOfWorkers: Number of workers.</summary>
    [JsonPropertyName("numberOfWorkers")]
    public int? NumberOfWorkers { get; set; }

    /// <summary>PhpVersion: Version of PHP.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>PowerShellVersion: Version of PowerShell.</summary>
    [JsonPropertyName("powerShellVersion")]
    public string? PowerShellVersion { get; set; }

    /// <summary>
    /// PreWarmedInstanceCount: Number of preWarmed instances.
    /// This setting only applies to the Consumption and Elastic Plans
    /// </summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public int? PreWarmedInstanceCount { get; set; }

    /// <summary>PublicNetworkAccess: Property to allow or block all public traffic.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>PublishingUsername: Publishing user name.</summary>
    [JsonPropertyName("publishingUsername")]
    public string? PublishingUsername { get; set; }

    /// <summary>Push: Push endpoint settings.</summary>
    [JsonPropertyName("push")]
    public V1api20220301SiteSpecSiteConfigPush? Push { get; set; }

    /// <summary>PythonVersion: Version of Python.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>RemoteDebuggingEnabled: &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>RemoteDebuggingVersion: Remote debugging version.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>RequestTracingEnabled: &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("requestTracingEnabled")]
    public bool? RequestTracingEnabled { get; set; }

    /// <summary>RequestTracingExpirationTime: Request tracing expiration time.</summary>
    [JsonPropertyName("requestTracingExpirationTime")]
    public string? RequestTracingExpirationTime { get; set; }

    /// <summary>ScmIpSecurityRestrictions: IP security restrictions for scm.</summary>
    [JsonPropertyName("scmIpSecurityRestrictions")]
    public IList<V1api20220301SiteSpecSiteConfigScmIpSecurityRestrictions>? ScmIpSecurityRestrictions { get; set; }

    /// <summary>ScmIpSecurityRestrictionsUseMain: IP security restrictions for scm to use main.</summary>
    [JsonPropertyName("scmIpSecurityRestrictionsUseMain")]
    public bool? ScmIpSecurityRestrictionsUseMain { get; set; }

    /// <summary>ScmMinTlsVersion: ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site</summary>
    [JsonPropertyName("scmMinTlsVersion")]
    public V1api20220301SiteSpecSiteConfigScmMinTlsVersionEnum? ScmMinTlsVersion { get; set; }

    /// <summary>ScmType: SCM type.</summary>
    [JsonPropertyName("scmType")]
    public V1api20220301SiteSpecSiteConfigScmTypeEnum? ScmType { get; set; }

    /// <summary>TracingOptions: Tracing options.</summary>
    [JsonPropertyName("tracingOptions")]
    public string? TracingOptions { get; set; }

    /// <summary>Use32BitWorkerProcess: &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>VirtualApplications: Virtual applications.</summary>
    [JsonPropertyName("virtualApplications")]
    public IList<V1api20220301SiteSpecSiteConfigVirtualApplications>? VirtualApplications { get; set; }

    /// <summary>VnetName: Virtual Network name.</summary>
    [JsonPropertyName("vnetName")]
    public string? VnetName { get; set; }

    /// <summary>VnetPrivatePortsCount: The number of private ports assigned to this app. These will be assigned dynamically on runtime.</summary>
    [JsonPropertyName("vnetPrivatePortsCount")]
    public int? VnetPrivatePortsCount { get; set; }

    /// <summary>
    /// VnetRouteAllEnabled: Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network
    /// Security Groups and User Defined Routes applied.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>WebSocketsEnabled: &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("webSocketsEnabled")]
    public bool? WebSocketsEnabled { get; set; }

    /// <summary>
    /// WebsiteTimeZone: Sets the time zone a site uses for generating timestamps. Compatible with Linux and Windows App
    /// Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence over this config. For Linux, expects tz database
    /// values https://www.iana.org/time-zones (for a quick reference see
    /// https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For Windows, expects one of the time zones listed under
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones
    /// </summary>
    [JsonPropertyName("websiteTimeZone")]
    public string? WebsiteTimeZone { get; set; }

    /// <summary>WindowsFxVersion: Xenon App Framework and version</summary>
    [JsonPropertyName("windowsFxVersion")]
    public string? WindowsFxVersion { get; set; }

    /// <summary>XManagedServiceIdentityId: Explicit Managed Service Identity Id</summary>
    [JsonPropertyName("xManagedServiceIdentityId")]
    public int? XManagedServiceIdentityId { get; set; }
}

/// <summary>
/// VirtualNetworkSubnetReference: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
/// Integration.
/// This must be of the form
/// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpecVirtualNetworkSubnetReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// ClientAffinityEnabled: &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity
    /// cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>
    /// ClientCertEnabled: &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise,
    /// &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }

    /// <summary>ClientCertExclusionPaths: client certificate authentication comma-separated exclusion paths</summary>
    [JsonPropertyName("clientCertExclusionPaths")]
    public string? ClientCertExclusionPaths { get; set; }

    /// <summary>
    /// ClientCertMode: This composes with ClientCertEnabled setting.
    /// - ClientCertEnabled: false means ClientCert is ignored.
    /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
    /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
    /// </summary>
    [JsonPropertyName("clientCertMode")]
    public V1api20220301SiteSpecClientCertModeEnum? ClientCertMode { get; set; }

    /// <summary>CloningInfo: If specified during app creation, the app is cloned from a source app.</summary>
    [JsonPropertyName("cloningInfo")]
    public V1api20220301SiteSpecCloningInfo? CloningInfo { get; set; }

    /// <summary>ContainerSize: Size of the function container.</summary>
    [JsonPropertyName("containerSize")]
    public int? ContainerSize { get; set; }

    /// <summary>
    /// CustomDomainVerificationId: Unique identifier that verifies the custom domains assigned to the app. Customer will add
    /// this id to a txt record for verification.
    /// </summary>
    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    /// <summary>DailyMemoryTimeQuota: Maximum allowed daily memory-time quota (applicable on dynamic apps only).</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public int? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// Enabled: &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables
    /// the app (takes the app offline).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ExtendedLocation: Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301SiteSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HostNameSslStates: Hostname SSL states are used to manage the SSL bindings for app&apos;s hostnames.</summary>
    [JsonPropertyName("hostNameSslStates")]
    public IList<V1api20220301SiteSpecHostNameSslStates>? HostNameSslStates { get; set; }

    /// <summary>
    /// HostNamesDisabled: &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
    /// </summary>
    [JsonPropertyName("hostNamesDisabled")]
    public bool? HostNamesDisabled { get; set; }

    /// <summary>HostingEnvironmentProfile: App Service Environment to use for the app.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V1api20220301SiteSpecHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary>
    /// HttpsOnly: HttpsOnly: configures a web site to accept only https requests. Issues redirect for
    /// http requests
    /// </summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>HyperV: Hyper-V sandbox.</summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>Identity: Managed service identity.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301SiteSpecIdentity? Identity { get; set; }

    /// <summary>IsXenon: Obsolete: Hyper-V sandbox.</summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary>KeyVaultReferenceIdentity: Identity to use for Key Vault Reference authentication.</summary>
    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Resource Location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220301SiteSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220301SiteSpecOwner Owner { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Property to allow or block all public traffic. Allowed Values: &apos;Enabled&apos;, &apos;Disabled&apos; or an empty
    /// string.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>RedundancyMode: Site redundancy mode</summary>
    [JsonPropertyName("redundancyMode")]
    public V1api20220301SiteSpecRedundancyModeEnum? RedundancyMode { get; set; }

    /// <summary>Reserved: &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>
    /// ScmSiteAlsoStopped: &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// The default is &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("scmSiteAlsoStopped")]
    public bool? ScmSiteAlsoStopped { get; set; }

    /// <summary>
    /// ServerFarmReference: Resource ID of the associated App Service plan, formatted as:
    /// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
    /// </summary>
    [JsonPropertyName("serverFarmReference")]
    public V1api20220301SiteSpecServerFarmReference? ServerFarmReference { get; set; }

    /// <summary>SiteConfig: Configuration of the app.</summary>
    [JsonPropertyName("siteConfig")]
    public V1api20220301SiteSpecSiteConfig? SiteConfig { get; set; }

    /// <summary>StorageAccountRequired: Checks if Customer provided storage account is required</summary>
    [JsonPropertyName("storageAccountRequired")]
    public bool? StorageAccountRequired { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// VirtualNetworkSubnetReference: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
    /// Integration.
    /// This must be of the form
    /// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetReference")]
    public V1api20220301SiteSpecVirtualNetworkSubnetReference? VirtualNetworkSubnetReference { get; set; }

    /// <summary>VnetContentShareEnabled: To enable accessing content over virtual network</summary>
    [JsonPropertyName("vnetContentShareEnabled")]
    public bool? VnetContentShareEnabled { get; set; }

    /// <summary>VnetImagePullEnabled: To enable pulling image over Virtual Network</summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>
    /// VnetRouteAllEnabled: Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network
    /// Security Groups and User Defined Routes applied.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }
}

/// <summary>CloningInfo: If specified during app creation, the app is cloned from a source app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusCloningInfo
{
    /// <summary>
    /// AppSettingsOverrides: Application setting overrides for cloned app. If specified, these settings override the settings
    /// cloned
    /// from source app. Otherwise, application settings from source app are retained.
    /// </summary>
    [JsonPropertyName("appSettingsOverrides")]
    public IDictionary<string, string>? AppSettingsOverrides { get; set; }

    /// <summary>CloneCustomHostNames: &lt;code&gt;true&lt;/code&gt; to clone custom hostnames from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("cloneCustomHostNames")]
    public bool? CloneCustomHostNames { get; set; }

    /// <summary>CloneSourceControl: &lt;code&gt;true&lt;/code&gt; to clone source control from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("cloneSourceControl")]
    public bool? CloneSourceControl { get; set; }

    /// <summary>ConfigureLoadBalancing: &lt;code&gt;true&lt;/code&gt; to configure load balancing for source and destination app.</summary>
    [JsonPropertyName("configureLoadBalancing")]
    public bool? ConfigureLoadBalancing { get; set; }

    /// <summary>
    /// CorrelationId: Correlation ID of cloning operation. This ID ties multiple cloning operations
    /// together to use the same snapshot.
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>HostingEnvironment: App Service Environment.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public string? HostingEnvironment { get; set; }

    /// <summary>Overwrite: &lt;code&gt;true&lt;/code&gt; to overwrite destination app; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    /// <summary>
    /// SourceWebAppId: ARM resource ID of the source app. App resource ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots
    /// and
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for
    /// other slots.
    /// </summary>
    [JsonPropertyName("sourceWebAppId")]
    public string? SourceWebAppId { get; set; }

    /// <summary>SourceWebAppLocation: Location of source app ex: West US or North Europe</summary>
    [JsonPropertyName("sourceWebAppLocation")]
    public string? SourceWebAppLocation { get; set; }

    /// <summary>
    /// TrafficManagerProfileId: ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager resource
    /// ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
    /// </summary>
    [JsonPropertyName("trafficManagerProfileId")]
    public string? TrafficManagerProfileId { get; set; }

    /// <summary>
    /// TrafficManagerProfileName: Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile
    /// does not already exist.
    /// </summary>
    [JsonPropertyName("trafficManagerProfileName")]
    public string? TrafficManagerProfileName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusConditions
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

/// <summary>ExtendedLocation: Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusExtendedLocation
{
    /// <summary>Name: Name of extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SSL-enabled hostname.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusHostNameSslStates
{
    /// <summary>HostType: Indicates whether the hostname is a standard or repository hostname.</summary>
    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    /// <summary>Name: Hostname.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SslState: SSL type.</summary>
    [JsonPropertyName("sslState")]
    public string? SslState { get; set; }

    /// <summary>Thumbprint: SSL certificate thumbprint.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>ToUpdate: Set to &lt;code&gt;true&lt;/code&gt; to update existing hostname.</summary>
    [JsonPropertyName("toUpdate")]
    public bool? ToUpdate { get; set; }

    /// <summary>VirtualIP: Virtual IP address assigned to the hostname if IP based SSL is enabled.</summary>
    [JsonPropertyName("virtualIP")]
    public string? VirtualIP { get; set; }
}

/// <summary>HostingEnvironmentProfile: App Service Environment to use for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusHostingEnvironmentProfile
{
    /// <summary>Id: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Name of the App Service Environment.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Resource type of the App Service Environment.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>User Assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Client Id of user assigned identity</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Principal Id of user assigned identity</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusIdentity
{
    /// <summary>PrincipalId: Principal Id of managed service identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: Tenant of managed service identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user assigned identities associated with the resource. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20220301SiteStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ApiDefinition: Information about the formal API definition for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigApiDefinition
{
    /// <summary>Url: The URL of the API definition.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>ApiManagementConfig: Azure API management settings linked to the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigApiManagementConfig
{
    /// <summary>Id: APIM-Api Identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Name value pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAppSettings
{
    /// <summary>Name: Pair name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Pair value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>CustomAction: Custom action to be taken.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesActionsCustomAction
{
    /// <summary>Exe: Executable to be run.</summary>
    [JsonPropertyName("exe")]
    public string? Exe { get; set; }

    /// <summary>Parameters: Parameters for the executable.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary>Actions: Actions to be executed when a rule is triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesActions
{
    /// <summary>ActionType: Predefined action to be taken.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>CustomAction: Custom action to be taken.</summary>
    [JsonPropertyName("customAction")]
    public V1api20220301SiteStatusSiteConfigAutoHealRulesActionsCustomAction? CustomAction { get; set; }

    /// <summary>
    /// MinProcessExecutionTime: Minimum time the process must execute
    /// before taking the action
    /// </summary>
    [JsonPropertyName("minProcessExecutionTime")]
    public string? MinProcessExecutionTime { get; set; }
}

/// <summary>Requests: A rule based on total requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersRequests
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>SlowRequests: A rule based on request execution time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersSlowRequests
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Path: Request Path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    /// <summary>TimeTaken: Time taken.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>Trigger based on request execution time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersSlowRequestsWithPath
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Path: Request Path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    /// <summary>TimeTaken: Time taken.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary>Trigger based on status code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersStatusCodes
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Path: Request Path</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Status: HTTP status code.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>SubStatus: Request Sub Status.</summary>
    [JsonPropertyName("subStatus")]
    public int? SubStatus { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }

    /// <summary>Win32Status: Win32 error code.</summary>
    [JsonPropertyName("win32Status")]
    public int? Win32Status { get; set; }
}

/// <summary>Trigger based on range of status codes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersStatusCodesRange
{
    /// <summary>Count: Request Count.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>StatusCodes: HTTP status code.</summary>
    [JsonPropertyName("statusCodes")]
    public string? StatusCodes { get; set; }

    /// <summary>TimeInterval: Time interval.</summary>
    [JsonPropertyName("timeInterval")]
    public string? TimeInterval { get; set; }
}

/// <summary>Triggers: Conditions that describe when to execute the auto-heal actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRulesTriggers
{
    /// <summary>PrivateBytesInKB: A rule based on private bytes.</summary>
    [JsonPropertyName("privateBytesInKB")]
    public int? PrivateBytesInKB { get; set; }

    /// <summary>Requests: A rule based on total requests.</summary>
    [JsonPropertyName("requests")]
    public V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersRequests? Requests { get; set; }

    /// <summary>SlowRequests: A rule based on request execution time.</summary>
    [JsonPropertyName("slowRequests")]
    public V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersSlowRequests? SlowRequests { get; set; }

    /// <summary>SlowRequestsWithPath: A rule based on multiple Slow Requests Rule with path</summary>
    [JsonPropertyName("slowRequestsWithPath")]
    public IList<V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersSlowRequestsWithPath>? SlowRequestsWithPath { get; set; }

    /// <summary>StatusCodes: A rule based on status codes.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersStatusCodes>? StatusCodes { get; set; }

    /// <summary>StatusCodesRange: A rule based on status codes ranges.</summary>
    [JsonPropertyName("statusCodesRange")]
    public IList<V1api20220301SiteStatusSiteConfigAutoHealRulesTriggersStatusCodesRange>? StatusCodesRange { get; set; }
}

/// <summary>AutoHealRules: Auto Heal rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAutoHealRules
{
    /// <summary>Actions: Actions to be executed when a rule is triggered.</summary>
    [JsonPropertyName("actions")]
    public V1api20220301SiteStatusSiteConfigAutoHealRulesActions? Actions { get; set; }

    /// <summary>Triggers: Conditions that describe when to execute the auto-heal actions.</summary>
    [JsonPropertyName("triggers")]
    public V1api20220301SiteStatusSiteConfigAutoHealRulesTriggers? Triggers { get; set; }
}

/// <summary>Azure Files or Blob Storage access information value for dictionary storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigAzureStorageAccounts
{
    /// <summary>AccountName: Name of the storage account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>MountPath: Path to mount the storage within the site&apos;s runtime environment.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>ShareName: Name of the file share (container name, for Blob storage).</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>State: State of the storage account.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Type: Type of storage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Database connection string information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigConnectionStrings
{
    /// <summary>ConnectionString: Connection string value.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>Name: Name of connection string.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of database.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigCors
{
    /// <summary>
    /// AllowedOrigins: Gets or sets the list of origins that should be allowed to make cross-origin
    /// calls (for example: http://example.com:12345). Use &quot;*&quot; to allow all.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// SupportCredentials: Gets or sets whether CORS requests with credentials are allowed. See
    /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
    /// for more details.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>
/// Routing rules for ramp up testing. This rule allows to redirect static traffic % to a slot or to gradually change
/// routing % based on performance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigExperimentsRampUpRules
{
    /// <summary>
    /// ActionHostName: Hostname of a slot to which the traffic will be redirected if decided to. E.g.
    /// myapp-stage.azurewebsites.net.
    /// </summary>
    [JsonPropertyName("actionHostName")]
    public string? ActionHostName { get; set; }

    /// <summary>
    /// ChangeDecisionCallbackUrl: Custom decision algorithm can be provided in TiPCallback site extension which URL can be
    /// specified.
    /// </summary>
    [JsonPropertyName("changeDecisionCallbackUrl")]
    public string? ChangeDecisionCallbackUrl { get; set; }

    /// <summary>ChangeIntervalInMinutes: Specifies interval in minutes to reevaluate ReroutePercentage.</summary>
    [JsonPropertyName("changeIntervalInMinutes")]
    public int? ChangeIntervalInMinutes { get; set; }

    /// <summary>
    /// ChangeStep: In auto ramp up scenario this is the step to add/remove from &lt;code&gt;ReroutePercentage&lt;/code&gt; until it reaches
    /// \n&lt;code&gt;MinReroutePercentage&lt;/code&gt; or
    /// &lt;code&gt;MaxReroutePercentage&lt;/code&gt;. Site metrics are checked every N minutes specified in
    /// &lt;code&gt;ChangeIntervalInMinutes&lt;/code&gt;.\nCustom decision algorithm
    /// can be provided in TiPCallback site extension which URL can be specified in &lt;code&gt;ChangeDecisionCallbackUrl&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("changeStep")]
    public double? ChangeStep { get; set; }

    /// <summary>MaxReroutePercentage: Specifies upper boundary below which ReroutePercentage will stay.</summary>
    [JsonPropertyName("maxReroutePercentage")]
    public double? MaxReroutePercentage { get; set; }

    /// <summary>MinReroutePercentage: Specifies lower boundary above which ReroutePercentage will stay.</summary>
    [JsonPropertyName("minReroutePercentage")]
    public double? MinReroutePercentage { get; set; }

    /// <summary>
    /// Name: Name of the routing rule. The recommended name would be to point to the slot which will receive the traffic in the
    /// experiment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ReroutePercentage: Percentage of the traffic which will be redirected to &lt;code&gt;ActionHostName&lt;/code&gt;.</summary>
    [JsonPropertyName("reroutePercentage")]
    public double? ReroutePercentage { get; set; }
}

/// <summary>Experiments: This is work around for polymorphic types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigExperiments
{
    /// <summary>RampUpRules: List of ramp-up rules.</summary>
    [JsonPropertyName("rampUpRules")]
    public IList<V1api20220301SiteStatusSiteConfigExperimentsRampUpRules>? RampUpRules { get; set; }
}

/// <summary>
/// The IIS handler mappings used to define which handler processes HTTP requests with certain extension.
/// For example, it
/// is used to configure php-cgi.exe process to handle all HTTP requests with *.php extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigHandlerMappings
{
    /// <summary>Arguments: Command-line arguments to be passed to the script processor.</summary>
    [JsonPropertyName("arguments")]
    public string? Arguments { get; set; }

    /// <summary>Extension: Requests with this extension will be handled using the specified FastCGI application.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>ScriptProcessor: The absolute path to the FastCGI application.</summary>
    [JsonPropertyName("scriptProcessor")]
    public string? ScriptProcessor { get; set; }
}

/// <summary>IP security restriction on an app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigIpSecurityRestrictions
{
    /// <summary>Action: Allow or Deny access for this IP range.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description: IP restriction rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Headers: IP restriction rule headers.
    /// X-Forwarded-Host (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-Host#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), all hosts(or lack of) are allowed.
    /// - A value is compared using ordinal-ignore-case (excluding port number).
    /// - Subdomain wildcards are permitted but don&apos;t match the root domain. For example, *.contoso.com matches the subdomain
    /// foo.contoso.com
    /// but not the root domain contoso.com or multi-level foo.bar.contoso.com
    /// - Unicode host names are allowed but are converted to Punycode for matching.
    /// X-Forwarded-For (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-For#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), any forwarded-for chains (or lack of) are allowed.
    /// - If any address (excluding port number) in the chain (comma separated) matches the CIDR defined by the property.
    /// X-Azure-FDID and X-FD-HealthProbe.
    /// The matching logic is exact match.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>
    /// IpAddress: IP address the security restriction is valid for.
    /// It can be in form of pure ipv4 address (required SubnetMask property) or
    /// CIDR notation such as ipv4/mask (leading bit match). For CIDR,
    /// SubnetMask property must not be specified.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Name: IP restriction rule name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of IP restriction rule.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>SubnetMask: Subnet mask for the range of IP addresses the restriction is valid for.</summary>
    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    /// <summary>SubnetTrafficTag: (internal) Subnet traffic tag</summary>
    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    /// <summary>Tag: Defines what this IP filter will be used for. This is to support IP filtering on proxies.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>VnetSubnetResourceId: Virtual network resource id</summary>
    [JsonPropertyName("vnetSubnetResourceId")]
    public string? VnetSubnetResourceId { get; set; }

    /// <summary>VnetTrafficTag: (internal) Vnet traffic tag</summary>
    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>Limits: Site limits.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigLimits
{
    /// <summary>MaxDiskSizeInMb: Maximum allowed disk size usage in MB.</summary>
    [JsonPropertyName("maxDiskSizeInMb")]
    public int? MaxDiskSizeInMb { get; set; }

    /// <summary>MaxMemoryInMb: Maximum allowed memory usage in MB.</summary>
    [JsonPropertyName("maxMemoryInMb")]
    public int? MaxMemoryInMb { get; set; }

    /// <summary>MaxPercentageCpu: Maximum allowed CPU usage percentage.</summary>
    [JsonPropertyName("maxPercentageCpu")]
    public double? MaxPercentageCpu { get; set; }
}

/// <summary>MachineKey: Site MachineKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigMachineKey
{
    /// <summary>Decryption: Algorithm used for decryption.</summary>
    [JsonPropertyName("decryption")]
    public string? Decryption { get; set; }

    /// <summary>DecryptionKey: Decryption key.</summary>
    [JsonPropertyName("decryptionKey")]
    public string? DecryptionKey { get; set; }

    /// <summary>Validation: MachineKey validation.</summary>
    [JsonPropertyName("validation")]
    public string? Validation { get; set; }

    /// <summary>ValidationKey: Validation key.</summary>
    [JsonPropertyName("validationKey")]
    public string? ValidationKey { get; set; }
}

/// <summary>Push: Push endpoint settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigPush
{
    /// <summary>
    /// DynamicTagsJson: Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in
    /// the push registration endpoint.
    /// </summary>
    [JsonPropertyName("dynamicTagsJson")]
    public string? DynamicTagsJson { get; set; }

    /// <summary>Id: Resource Id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsPushEnabled: Gets or sets a flag indicating whether the Push endpoint is enabled.</summary>
    [JsonPropertyName("isPushEnabled")]
    public bool? IsPushEnabled { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name: Resource Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// TagWhitelistJson: Gets or sets a JSON string containing a list of tags that are in the allowed list for use by the push
    /// registration endpoint.
    /// </summary>
    [JsonPropertyName("tagWhitelistJson")]
    public string? TagWhitelistJson { get; set; }

    /// <summary>
    /// TagsRequiringAuth: Gets or sets a JSON string containing a list of tags that require user authentication to be used in
    /// the push registration endpoint.
    /// Tags can consist of alphanumeric characters and the following:
    /// &apos;_&apos;, &apos;@&apos;, &apos;#&apos;, &apos;.&apos;, &apos;:&apos;, &apos;-&apos;.
    /// Validation should be performed at the PushRequestHandler.
    /// </summary>
    [JsonPropertyName("tagsRequiringAuth")]
    public string? TagsRequiringAuth { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>IP security restriction on an app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigScmIpSecurityRestrictions
{
    /// <summary>Action: Allow or Deny access for this IP range.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description: IP restriction rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Headers: IP restriction rule headers.
    /// X-Forwarded-Host (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-Host#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), all hosts(or lack of) are allowed.
    /// - A value is compared using ordinal-ignore-case (excluding port number).
    /// - Subdomain wildcards are permitted but don&apos;t match the root domain. For example, *.contoso.com matches the subdomain
    /// foo.contoso.com
    /// but not the root domain contoso.com or multi-level foo.bar.contoso.com
    /// - Unicode host names are allowed but are converted to Punycode for matching.
    /// X-Forwarded-For (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-For#Examples).
    /// The matching logic is ..
    /// - If the property is null or empty (default), any forwarded-for chains (or lack of) are allowed.
    /// - If any address (excluding port number) in the chain (comma separated) matches the CIDR defined by the property.
    /// X-Azure-FDID and X-FD-HealthProbe.
    /// The matching logic is exact match.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>
    /// IpAddress: IP address the security restriction is valid for.
    /// It can be in form of pure ipv4 address (required SubnetMask property) or
    /// CIDR notation such as ipv4/mask (leading bit match). For CIDR,
    /// SubnetMask property must not be specified.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Name: IP restriction rule name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of IP restriction rule.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>SubnetMask: Subnet mask for the range of IP addresses the restriction is valid for.</summary>
    [JsonPropertyName("subnetMask")]
    public string? SubnetMask { get; set; }

    /// <summary>SubnetTrafficTag: (internal) Subnet traffic tag</summary>
    [JsonPropertyName("subnetTrafficTag")]
    public int? SubnetTrafficTag { get; set; }

    /// <summary>Tag: Defines what this IP filter will be used for. This is to support IP filtering on proxies.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>VnetSubnetResourceId: Virtual network resource id</summary>
    [JsonPropertyName("vnetSubnetResourceId")]
    public string? VnetSubnetResourceId { get; set; }

    /// <summary>VnetTrafficTag: (internal) Vnet traffic tag</summary>
    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>Directory for virtual application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigVirtualApplicationsVirtualDirectories
{
    /// <summary>PhysicalPath: Physical path.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>VirtualPath: Path to virtual application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>Virtual application in an app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfigVirtualApplications
{
    /// <summary>PhysicalPath: Physical path.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>PreloadEnabled: &lt;code&gt;true&lt;/code&gt; if preloading is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("preloadEnabled")]
    public bool? PreloadEnabled { get; set; }

    /// <summary>VirtualDirectories: Virtual directories for virtual application.</summary>
    [JsonPropertyName("virtualDirectories")]
    public IList<V1api20220301SiteStatusSiteConfigVirtualApplicationsVirtualDirectories>? VirtualDirectories { get; set; }

    /// <summary>VirtualPath: Virtual path.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>SiteConfig: Configuration of the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSiteConfig
{
    /// <summary>AcrUseManagedIdentityCreds: Flag to use Managed Identity Creds for ACR pull</summary>
    [JsonPropertyName("acrUseManagedIdentityCreds")]
    public bool? AcrUseManagedIdentityCreds { get; set; }

    /// <summary>AcrUserManagedIdentityID: If using user managed identity, the user managed identity ClientId</summary>
    [JsonPropertyName("acrUserManagedIdentityID")]
    public string? AcrUserManagedIdentityID { get; set; }

    /// <summary>AlwaysOn: &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>ApiDefinition: Information about the formal API definition for the app.</summary>
    [JsonPropertyName("apiDefinition")]
    public V1api20220301SiteStatusSiteConfigApiDefinition? ApiDefinition { get; set; }

    /// <summary>ApiManagementConfig: Azure API management settings linked to the app.</summary>
    [JsonPropertyName("apiManagementConfig")]
    public V1api20220301SiteStatusSiteConfigApiManagementConfig? ApiManagementConfig { get; set; }

    /// <summary>AppCommandLine: App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>AppSettings: Application settings.</summary>
    [JsonPropertyName("appSettings")]
    public IList<V1api20220301SiteStatusSiteConfigAppSettings>? AppSettings { get; set; }

    /// <summary>AutoHealEnabled: &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>AutoHealRules: Auto Heal rules.</summary>
    [JsonPropertyName("autoHealRules")]
    public V1api20220301SiteStatusSiteConfigAutoHealRules? AutoHealRules { get; set; }

    /// <summary>AutoSwapSlotName: Auto-swap slot name.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>AzureStorageAccounts: List of Azure Storage Accounts.</summary>
    [JsonPropertyName("azureStorageAccounts")]
    public IDictionary<string, V1api20220301SiteStatusSiteConfigAzureStorageAccounts>? AzureStorageAccounts { get; set; }

    /// <summary>ConnectionStrings: Connection strings.</summary>
    [JsonPropertyName("connectionStrings")]
    public IList<V1api20220301SiteStatusSiteConfigConnectionStrings>? ConnectionStrings { get; set; }

    /// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20220301SiteStatusSiteConfigCors? Cors { get; set; }

    /// <summary>DefaultDocuments: Default documents.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>DetailedErrorLoggingEnabled: &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    /// <summary>DocumentRoot: Document root.</summary>
    [JsonPropertyName("documentRoot")]
    public string? DocumentRoot { get; set; }

    /// <summary>Experiments: This is work around for polymorphic types.</summary>
    [JsonPropertyName("experiments")]
    public V1api20220301SiteStatusSiteConfigExperiments? Experiments { get; set; }

    /// <summary>FtpsState: State of FTP / FTPS service</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>
    /// FunctionAppScaleLimit: Maximum number of workers that a site can scale out to.
    /// This setting only applies to the Consumption and Elastic Premium Plans
    /// </summary>
    [JsonPropertyName("functionAppScaleLimit")]
    public int? FunctionAppScaleLimit { get; set; }

    /// <summary>
    /// FunctionsRuntimeScaleMonitoringEnabled: Gets or sets a value indicating whether functions runtime scale monitoring is
    /// enabled. When enabled,
    /// the ScaleController will not monitor event sources directly, but will instead call to the
    /// runtime to get scale status.
    /// </summary>
    [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
    public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>HandlerMappings: Handler mappings.</summary>
    [JsonPropertyName("handlerMappings")]
    public IList<V1api20220301SiteStatusSiteConfigHandlerMappings>? HandlerMappings { get; set; }

    /// <summary>HealthCheckPath: Health check path</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Http20Enabled: Http20Enabled: configures a web site to allow clients to connect over http2.0</summary>
    [JsonPropertyName("http20Enabled")]
    public bool? Http20Enabled { get; set; }

    /// <summary>HttpLoggingEnabled: &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("httpLoggingEnabled")]
    public bool? HttpLoggingEnabled { get; set; }

    /// <summary>IpSecurityRestrictions: IP security restrictions for main.</summary>
    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V1api20220301SiteStatusSiteConfigIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    /// <summary>JavaContainer: Java container.</summary>
    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    /// <summary>JavaContainerVersion: Java container version.</summary>
    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    /// <summary>JavaVersion: Java version.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>KeyVaultReferenceIdentity: Identity to use for Key Vault Reference authentication.</summary>
    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>Limits: Site limits.</summary>
    [JsonPropertyName("limits")]
    public V1api20220301SiteStatusSiteConfigLimits? Limits { get; set; }

    /// <summary>LinuxFxVersion: Linux App Framework and version</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>LoadBalancing: Site load balancing.</summary>
    [JsonPropertyName("loadBalancing")]
    public string? LoadBalancing { get; set; }

    /// <summary>LocalMySqlEnabled: &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("localMySqlEnabled")]
    public bool? LocalMySqlEnabled { get; set; }

    /// <summary>LogsDirectorySizeLimit: HTTP logs directory size limit.</summary>
    [JsonPropertyName("logsDirectorySizeLimit")]
    public int? LogsDirectorySizeLimit { get; set; }

    /// <summary>MachineKey: Site MachineKey.</summary>
    [JsonPropertyName("machineKey")]
    public V1api20220301SiteStatusSiteConfigMachineKey? MachineKey { get; set; }

    /// <summary>ManagedPipelineMode: Managed pipeline mode.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>ManagedServiceIdentityId: Managed Service Identity Id</summary>
    [JsonPropertyName("managedServiceIdentityId")]
    public int? ManagedServiceIdentityId { get; set; }

    /// <summary>MinTlsVersion: MinTlsVersion: configures the minimum version of TLS required for SSL requests</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>
    /// MinimumElasticInstanceCount: Number of minimum instance count for a site
    /// This setting only applies to the Elastic Plans
    /// </summary>
    [JsonPropertyName("minimumElasticInstanceCount")]
    public int? MinimumElasticInstanceCount { get; set; }

    /// <summary>NetFrameworkVersion: .NET Framework version.</summary>
    [JsonPropertyName("netFrameworkVersion")]
    public string? NetFrameworkVersion { get; set; }

    /// <summary>NodeVersion: Version of Node.js.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>NumberOfWorkers: Number of workers.</summary>
    [JsonPropertyName("numberOfWorkers")]
    public int? NumberOfWorkers { get; set; }

    /// <summary>PhpVersion: Version of PHP.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>PowerShellVersion: Version of PowerShell.</summary>
    [JsonPropertyName("powerShellVersion")]
    public string? PowerShellVersion { get; set; }

    /// <summary>
    /// PreWarmedInstanceCount: Number of preWarmed instances.
    /// This setting only applies to the Consumption and Elastic Plans
    /// </summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public int? PreWarmedInstanceCount { get; set; }

    /// <summary>PublicNetworkAccess: Property to allow or block all public traffic.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>PublishingUsername: Publishing user name.</summary>
    [JsonPropertyName("publishingUsername")]
    public string? PublishingUsername { get; set; }

    /// <summary>Push: Push endpoint settings.</summary>
    [JsonPropertyName("push")]
    public V1api20220301SiteStatusSiteConfigPush? Push { get; set; }

    /// <summary>PythonVersion: Version of Python.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>RemoteDebuggingEnabled: &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>RemoteDebuggingVersion: Remote debugging version.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>RequestTracingEnabled: &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("requestTracingEnabled")]
    public bool? RequestTracingEnabled { get; set; }

    /// <summary>RequestTracingExpirationTime: Request tracing expiration time.</summary>
    [JsonPropertyName("requestTracingExpirationTime")]
    public string? RequestTracingExpirationTime { get; set; }

    /// <summary>ScmIpSecurityRestrictions: IP security restrictions for scm.</summary>
    [JsonPropertyName("scmIpSecurityRestrictions")]
    public IList<V1api20220301SiteStatusSiteConfigScmIpSecurityRestrictions>? ScmIpSecurityRestrictions { get; set; }

    /// <summary>ScmIpSecurityRestrictionsUseMain: IP security restrictions for scm to use main.</summary>
    [JsonPropertyName("scmIpSecurityRestrictionsUseMain")]
    public bool? ScmIpSecurityRestrictionsUseMain { get; set; }

    /// <summary>ScmMinTlsVersion: ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site</summary>
    [JsonPropertyName("scmMinTlsVersion")]
    public string? ScmMinTlsVersion { get; set; }

    /// <summary>ScmType: SCM type.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>TracingOptions: Tracing options.</summary>
    [JsonPropertyName("tracingOptions")]
    public string? TracingOptions { get; set; }

    /// <summary>Use32BitWorkerProcess: &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>VirtualApplications: Virtual applications.</summary>
    [JsonPropertyName("virtualApplications")]
    public IList<V1api20220301SiteStatusSiteConfigVirtualApplications>? VirtualApplications { get; set; }

    /// <summary>VnetName: Virtual Network name.</summary>
    [JsonPropertyName("vnetName")]
    public string? VnetName { get; set; }

    /// <summary>VnetPrivatePortsCount: The number of private ports assigned to this app. These will be assigned dynamically on runtime.</summary>
    [JsonPropertyName("vnetPrivatePortsCount")]
    public int? VnetPrivatePortsCount { get; set; }

    /// <summary>
    /// VnetRouteAllEnabled: Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network
    /// Security Groups and User Defined Routes applied.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>WebSocketsEnabled: &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("webSocketsEnabled")]
    public bool? WebSocketsEnabled { get; set; }

    /// <summary>
    /// WebsiteTimeZone: Sets the time zone a site uses for generating timestamps. Compatible with Linux and Windows App
    /// Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence over this config. For Linux, expects tz database
    /// values https://www.iana.org/time-zones (for a quick reference see
    /// https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For Windows, expects one of the time zones listed under
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones
    /// </summary>
    [JsonPropertyName("websiteTimeZone")]
    public string? WebsiteTimeZone { get; set; }

    /// <summary>WindowsFxVersion: Xenon App Framework and version</summary>
    [JsonPropertyName("windowsFxVersion")]
    public string? WindowsFxVersion { get; set; }

    /// <summary>XManagedServiceIdentityId: Explicit Managed Service Identity Id</summary>
    [JsonPropertyName("xManagedServiceIdentityId")]
    public int? XManagedServiceIdentityId { get; set; }
}

/// <summary>SlotSwapStatus: Status of the last deployment slot swap operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatusSlotSwapStatus
{
    /// <summary>DestinationSlotName: The destination slot of the last swap operation.</summary>
    [JsonPropertyName("destinationSlotName")]
    public string? DestinationSlotName { get; set; }

    /// <summary>SourceSlotName: The source slot of the last swap operation.</summary>
    [JsonPropertyName("sourceSlotName")]
    public string? SourceSlotName { get; set; }

    /// <summary>TimestampUtc: The time the last successful slot swap completed.</summary>
    [JsonPropertyName("timestampUtc")]
    public string? TimestampUtc { get; set; }
}

/// <summary>A web app, a mobile app backend, or an API app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SiteStatus
{
    /// <summary>AvailabilityState: Management information availability state for the app.</summary>
    [JsonPropertyName("availabilityState")]
    public string? AvailabilityState { get; set; }

    /// <summary>
    /// ClientAffinityEnabled: &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity
    /// cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>
    /// ClientCertEnabled: &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise,
    /// &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }

    /// <summary>ClientCertExclusionPaths: client certificate authentication comma-separated exclusion paths</summary>
    [JsonPropertyName("clientCertExclusionPaths")]
    public string? ClientCertExclusionPaths { get; set; }

    /// <summary>
    /// ClientCertMode: This composes with ClientCertEnabled setting.
    /// - ClientCertEnabled: false means ClientCert is ignored.
    /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
    /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
    /// </summary>
    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>CloningInfo: If specified during app creation, the app is cloned from a source app.</summary>
    [JsonPropertyName("cloningInfo")]
    public V1api20220301SiteStatusCloningInfo? CloningInfo { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220301SiteStatusConditions>? Conditions { get; set; }

    /// <summary>ContainerSize: Size of the function container.</summary>
    [JsonPropertyName("containerSize")]
    public int? ContainerSize { get; set; }

    /// <summary>
    /// CustomDomainVerificationId: Unique identifier that verifies the custom domains assigned to the app. Customer will add
    /// this id to a txt record for verification.
    /// </summary>
    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    /// <summary>DailyMemoryTimeQuota: Maximum allowed daily memory-time quota (applicable on dynamic apps only).</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public int? DailyMemoryTimeQuota { get; set; }

    /// <summary>DefaultHostName: Default hostname of the app. Read-only.</summary>
    [JsonPropertyName("defaultHostName")]
    public string? DefaultHostName { get; set; }

    /// <summary>
    /// Enabled: &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables
    /// the app (takes the app offline).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// EnabledHostNames: Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
    /// the app is not served on those hostnames.
    /// </summary>
    [JsonPropertyName("enabledHostNames")]
    public IList<string>? EnabledHostNames { get; set; }

    /// <summary>ExtendedLocation: Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301SiteStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HostNameSslStates: Hostname SSL states are used to manage the SSL bindings for app&apos;s hostnames.</summary>
    [JsonPropertyName("hostNameSslStates")]
    public IList<V1api20220301SiteStatusHostNameSslStates>? HostNameSslStates { get; set; }

    /// <summary>HostNames: Hostnames associated with the app.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>
    /// HostNamesDisabled: &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
    /// </summary>
    [JsonPropertyName("hostNamesDisabled")]
    public bool? HostNamesDisabled { get; set; }

    /// <summary>HostingEnvironmentProfile: App Service Environment to use for the app.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V1api20220301SiteStatusHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary>
    /// HttpsOnly: HttpsOnly: configures a web site to accept only https requests. Issues redirect for
    /// http requests
    /// </summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>HyperV: Hyper-V sandbox.</summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>Id: Resource Id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed service identity.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301SiteStatusIdentity? Identity { get; set; }

    /// <summary>InProgressOperationId: Specifies an operation id if this site has a pending operation.</summary>
    [JsonPropertyName("inProgressOperationId")]
    public string? InProgressOperationId { get; set; }

    /// <summary>IsDefaultContainer: &lt;code&gt;true&lt;/code&gt; if the app is a default container; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("isDefaultContainer")]
    public bool? IsDefaultContainer { get; set; }

    /// <summary>IsXenon: Obsolete: Hyper-V sandbox.</summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary>KeyVaultReferenceIdentity: Identity to use for Key Vault Reference authentication.</summary>
    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>LastModifiedTimeUtc: Last time the app was modified, in UTC. Read-only.</summary>
    [JsonPropertyName("lastModifiedTimeUtc")]
    public string? LastModifiedTimeUtc { get; set; }

    /// <summary>Location: Resource Location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MaxNumberOfWorkers: Maximum number of workers.
    /// This only applies to Functions container.
    /// </summary>
    [JsonPropertyName("maxNumberOfWorkers")]
    public int? MaxNumberOfWorkers { get; set; }

    /// <summary>Name: Resource Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// OutboundIpAddresses: List of IP addresses that the app uses for outbound connections (e.g. database access). Includes
    /// VIPs from tenants that site can be hosted with current settings. Read-only.
    /// </summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>
    /// PossibleOutboundIpAddresses: List of IP addresses that the app uses for outbound connections (e.g. database access).
    /// Includes VIPs from all tenants except dataComponent. Read-only.
    /// </summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Property to allow or block all public traffic. Allowed Values: &apos;Enabled&apos;, &apos;Disabled&apos; or an empty
    /// string.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>RedundancyMode: Site redundancy mode</summary>
    [JsonPropertyName("redundancyMode")]
    public string? RedundancyMode { get; set; }

    /// <summary>RepositorySiteName: Name of the repository site.</summary>
    [JsonPropertyName("repositorySiteName")]
    public string? RepositorySiteName { get; set; }

    /// <summary>Reserved: &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>ResourceGroup: Name of the resource group the app belongs to. Read-only.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>
    /// ScmSiteAlsoStopped: &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// The default is &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("scmSiteAlsoStopped")]
    public bool? ScmSiteAlsoStopped { get; set; }

    /// <summary>
    /// ServerFarmId: Resource ID of the associated App Service plan, formatted as:
    /// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
    /// </summary>
    [JsonPropertyName("serverFarmId")]
    public string? ServerFarmId { get; set; }

    /// <summary>SiteConfig: Configuration of the app.</summary>
    [JsonPropertyName("siteConfig")]
    public V1api20220301SiteStatusSiteConfig? SiteConfig { get; set; }

    /// <summary>SlotSwapStatus: Status of the last deployment slot swap operation.</summary>
    [JsonPropertyName("slotSwapStatus")]
    public V1api20220301SiteStatusSlotSwapStatus? SlotSwapStatus { get; set; }

    /// <summary>State: Current state of the app.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>StorageAccountRequired: Checks if Customer provided storage account is required</summary>
    [JsonPropertyName("storageAccountRequired")]
    public bool? StorageAccountRequired { get; set; }

    /// <summary>SuspendedTill: App suspended till in case memory-time quota is exceeded.</summary>
    [JsonPropertyName("suspendedTill")]
    public string? SuspendedTill { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetSwapSlot: Specifies which deployment slot this app will swap into. Read-only.</summary>
    [JsonPropertyName("targetSwapSlot")]
    public string? TargetSwapSlot { get; set; }

    /// <summary>TrafficManagerHostNames: Azure Traffic Manager hostnames associated with the app. Read-only.</summary>
    [JsonPropertyName("trafficManagerHostNames")]
    public IList<string>? TrafficManagerHostNames { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UsageState: State indicating whether the app has exceeded its quota usage. Read-only.</summary>
    [JsonPropertyName("usageState")]
    public string? UsageState { get; set; }

    /// <summary>
    /// VirtualNetworkSubnetId: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
    /// Integration.
    /// This must be of the form
    /// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>VnetContentShareEnabled: To enable accessing content over virtual network</summary>
    [JsonPropertyName("vnetContentShareEnabled")]
    public bool? VnetContentShareEnabled { get; set; }

    /// <summary>VnetImagePullEnabled: To enable pulling image over Virtual Network</summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>
    /// VnetRouteAllEnabled: Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network
    /// Security Groups and User Defined Routes applied.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/WebApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301Site : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220301SiteSpec?>, IStatus<V1api20220301SiteStatus?>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "Site";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Site";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220301SiteSpec? Spec { get; set; }

    /// <summary>A web app, a mobile app backend, or an API app.</summary>
    [JsonPropertyName("status")]
    public V1api20220301SiteStatus? Status { get; set; }
}
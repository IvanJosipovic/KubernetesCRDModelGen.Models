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
/// Storage version of v20250501.Site
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2025-05-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250501storageSiteList : IKubernetesObject<V1ListMeta>, IItems<V20250501storageSite>
{
    public const string KubeApiVersion = "v20250501storage";
    public const string KubeKind = "SiteList";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v20250501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SiteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250501storageSite objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250501storageSite> Items { get; set; }
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
public partial class V20250501storageSiteSpecCloningInfoSourceWebAppReference
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
public partial class V20250501storageSiteSpecCloningInfoTrafficManagerProfileReference
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
/// Storage version of v20250501.CloningInfo
/// Information needed for cloning operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecCloningInfo
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
    public required V20250501storageSiteSpecCloningInfoSourceWebAppReference SourceWebAppReference { get; set; }

    [JsonPropertyName("trafficManagerProfileName")]
    public string? TrafficManagerProfileName { get; set; }

    /// <summary>
    /// TrafficManagerProfileReference: ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager
    /// resource ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
    /// </summary>
    [JsonPropertyName("trafficManagerProfileReference")]
    public V20250501storageSiteSpecCloningInfoTrafficManagerProfileReference? TrafficManagerProfileReference { get; set; }
}

/// <summary>
/// Storage version of v20250501.DaprConfig
/// App Dapr configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecDaprConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    [JsonPropertyName("appPort")]
    public int? AppPort { get; set; }

    [JsonPropertyName("enableApiLogging")]
    public bool? EnableApiLogging { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("httpMaxRequestSize")]
    public int? HttpMaxRequestSize { get; set; }

    [JsonPropertyName("httpReadBufferSize")]
    public int? HttpReadBufferSize { get; set; }

    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }
}

/// <summary>Storage version of v20250501.SiteDnsConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecDnsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dnsAltServer")]
    public string? DnsAltServer { get; set; }

    [JsonPropertyName("dnsMaxCacheTimeout")]
    public int? DnsMaxCacheTimeout { get; set; }

    [JsonPropertyName("dnsRetryAttemptCount")]
    public int? DnsRetryAttemptCount { get; set; }

    [JsonPropertyName("dnsRetryAttemptTimeout")]
    public int? DnsRetryAttemptTimeout { get; set; }

    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>
/// Storage version of v20250501.ExtendedLocation
/// Extended Location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecExtendedLocation
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
/// UserAssignedIdentityResourceReference: Use this property for UserAssignedIdentity. Set the resource ID of the identity.
/// Do not set a value for this property when using other authentication type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigDeploymentStorageAuthenticationUserAssignedIdentityResourceReference
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
/// Storage version of v20250501.FunctionsDeploymentStorageAuthentication
/// Authentication method to access the storage account for deployment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigDeploymentStorageAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("storageAccountConnectionStringName")]
    public string? StorageAccountConnectionStringName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentityResourceReference: Use this property for UserAssignedIdentity. Set the resource ID of the identity.
    /// Do not set a value for this property when using other authentication type.
    /// </summary>
    [JsonPropertyName("userAssignedIdentityResourceReference")]
    public V20250501storageSiteSpecFunctionAppConfigDeploymentStorageAuthenticationUserAssignedIdentityResourceReference? UserAssignedIdentityResourceReference { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsDeploymentStorage
/// Storage for deployed package used by the function app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigDeploymentStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsDeploymentStorageAuthentication
    /// Authentication method to access the storage account for deployment.
    /// </summary>
    [JsonPropertyName("authentication")]
    public V20250501storageSiteSpecFunctionAppConfigDeploymentStorageAuthentication? Authentication { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsDeployment
/// Configuration section for the function app deployment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigDeployment
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsDeploymentStorage
    /// Storage for deployed package used by the function app.
    /// </summary>
    [JsonPropertyName("storage")]
    public V20250501storageSiteSpecFunctionAppConfigDeploymentStorage? Storage { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsRuntime
/// Function app runtime name and version.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigRuntime
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsAlwaysReadyConfig
/// Sets the number of &apos;Always Ready&apos; instances for a function group or a specific function.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrencyAlwaysReady
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("instanceCount")]
    public int? InstanceCount { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggersHttp
/// Scale and concurrency settings for the HTTP trigger.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrencyTriggersHttp
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("perInstanceConcurrency")]
    public int? PerInstanceConcurrency { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggers
/// Scale and concurrency settings for the function app triggers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrencyTriggers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggersHttp
    /// Scale and concurrency settings for the HTTP trigger.
    /// </summary>
    [JsonPropertyName("http")]
    public V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrencyTriggersHttp? Http { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsScaleAndConcurrency
/// Scale and concurrency settings for the function app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrency
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("alwaysReady")]
    public IList<V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrencyAlwaysReady>? AlwaysReady { get; set; }

    [JsonPropertyName("instanceMemoryMB")]
    public int? InstanceMemoryMB { get; set; }

    [JsonPropertyName("maximumInstanceCount")]
    public int? MaximumInstanceCount { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggers
    /// Scale and concurrency settings for the function app triggers.
    /// </summary>
    [JsonPropertyName("triggers")]
    public V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrencyTriggers? Triggers { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsSiteUpdateStrategy
/// Function app site update strategy configuration for deployments and site config updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfigSiteUpdateStrategy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionAppConfig
/// Function app configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecFunctionAppConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsDeployment
    /// Configuration section for the function app deployment.
    /// </summary>
    [JsonPropertyName("deployment")]
    public V20250501storageSiteSpecFunctionAppConfigDeployment? Deployment { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsRuntime
    /// Function app runtime name and version.
    /// </summary>
    [JsonPropertyName("runtime")]
    public V20250501storageSiteSpecFunctionAppConfigRuntime? Runtime { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsScaleAndConcurrency
    /// Scale and concurrency settings for the function app.
    /// </summary>
    [JsonPropertyName("scaleAndConcurrency")]
    public V20250501storageSiteSpecFunctionAppConfigScaleAndConcurrency? ScaleAndConcurrency { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsSiteUpdateStrategy
    /// Function app site update strategy configuration for deployments and site config updates.
    /// </summary>
    [JsonPropertyName("siteUpdateStrategy")]
    public V20250501storageSiteSpecFunctionAppConfigSiteUpdateStrategy? SiteUpdateStrategy { get; set; }
}

/// <summary>
/// Storage version of v20250501.HostNameSslState
/// SSL-enabled hostname.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecHostNameSslStates
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
public partial class V20250501storageSiteSpecHostingEnvironmentProfileReference
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
/// Storage version of v20250501.HostingEnvironmentProfile
/// Specification for an App Service Environment to use for this resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecHostingEnvironmentProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("reference")]
    public V20250501storageSiteSpecHostingEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20250501.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250501storageSiteSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250501.ManagedServiceIdentity
/// Managed service identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecIdentity
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
    public IList<V20250501storageSiteSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// ManagedEnvironmentReference: Azure Resource Manager ID of the customer&apos;s selected Managed Environment on which to host
/// this app. This must be of the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.App/managedEnvironments/{managedEnvironmentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecManagedEnvironmentReference
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecOperatorSpecConfigMapExpressions
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
public partial class V20250501storageSiteSpecOperatorSpecSecretExpressions
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
/// Storage version of v20250501.SiteOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250501storageSiteSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250501storageSiteSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Storage version of v20250501.OutboundVnetRouting
/// Outbound traffic options over virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecOutboundVnetRouting
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allTraffic")]
    public bool? AllTraffic { get; set; }

    [JsonPropertyName("applicationTraffic")]
    public bool? ApplicationTraffic { get; set; }

    [JsonPropertyName("backupRestoreTraffic")]
    public bool? BackupRestoreTraffic { get; set; }

    [JsonPropertyName("contentShareTraffic")]
    public bool? ContentShareTraffic { get; set; }

    [JsonPropertyName("imagePullTraffic")]
    public bool? ImagePullTraffic { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250501.ResourceConfig
/// Function app resource requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecResourceConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// ServerFarmReference: Resource ID of the associated App Service plan, formatted as:
/// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecServerFarmReference
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
/// Storage version of v20250501.ApiDefinitionInfo
/// Information about the formal API definition for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigApiDefinition
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
public partial class V20250501storageSiteSpecSiteConfigApiManagementConfigReference
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
/// Storage version of v20250501.ApiManagementConfig
/// Azure API management (APIM) configuration linked to the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigApiManagementConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: APIM-Api Identifier.</summary>
    [JsonPropertyName("reference")]
    public V20250501storageSiteSpecSiteConfigApiManagementConfigReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250501.NameValuePair
/// Name value pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAppSettings
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
/// Storage version of v20250501.AutoHealCustomAction
/// Custom action to be executed
/// when an auto heal rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesActionsCustomAction
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
/// Storage version of v20250501.AutoHealActions
/// Actions which to take by the auto-heal module when a rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesActions
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
    /// Storage version of v20250501.AutoHealCustomAction
    /// Custom action to be executed
    /// when an auto heal rule is triggered.
    /// </summary>
    [JsonPropertyName("customAction")]
    public V20250501storageSiteSpecSiteConfigAutoHealRulesActionsCustomAction? CustomAction { get; set; }

    [JsonPropertyName("minProcessExecutionTime")]
    public string? MinProcessExecutionTime { get; set; }
}

/// <summary>
/// Storage version of v20250501.RequestsBasedTrigger
/// Trigger based on total requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersRequests
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
/// Storage version of v20250501.SlowRequestsBasedTrigger
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequests
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
/// Storage version of v20250501.SlowRequestsBasedTrigger
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequestsWithPath
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
/// Storage version of v20250501.StatusCodesBasedTrigger
/// Trigger based on status code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodes
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
/// Storage version of v20250501.StatusCodesRangeBasedTrigger
/// Trigger based on range of status codes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodesRange
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
/// Storage version of v20250501.AutoHealTriggers
/// Triggers for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRulesTriggers
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
    /// Storage version of v20250501.RequestsBasedTrigger
    /// Trigger based on total requests.
    /// </summary>
    [JsonPropertyName("requests")]
    public V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersRequests? Requests { get; set; }

    /// <summary>
    /// Storage version of v20250501.SlowRequestsBasedTrigger
    /// Trigger based on request execution time.
    /// </summary>
    [JsonPropertyName("slowRequests")]
    public V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequests? SlowRequests { get; set; }

    [JsonPropertyName("slowRequestsWithPath")]
    public IList<V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersSlowRequestsWithPath>? SlowRequestsWithPath { get; set; }

    [JsonPropertyName("statusCodes")]
    public IList<V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodes>? StatusCodes { get; set; }

    [JsonPropertyName("statusCodesRange")]
    public IList<V20250501storageSiteSpecSiteConfigAutoHealRulesTriggersStatusCodesRange>? StatusCodesRange { get; set; }
}

/// <summary>
/// Storage version of v20250501.AutoHealRules
/// Rules that can be defined for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAutoHealRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.AutoHealActions
    /// Actions which to take by the auto-heal module when a rule is triggered.
    /// </summary>
    [JsonPropertyName("actions")]
    public V20250501storageSiteSpecSiteConfigAutoHealRulesActions? Actions { get; set; }

    /// <summary>
    /// Storage version of v20250501.AutoHealTriggers
    /// Triggers for auto-heal.
    /// </summary>
    [JsonPropertyName("triggers")]
    public V20250501storageSiteSpecSiteConfigAutoHealRulesTriggers? Triggers { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAzureStorageAccountsAccessKey
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
/// Storage version of v20250501.AzureStorageInfoValue
/// Azure Files or Blob Storage access information value for dictionary storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigAzureStorageAccounts
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
    public V20250501storageSiteSpecSiteConfigAzureStorageAccountsAccessKey? AccessKey { get; set; }

    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250501.ConnStringInfo
/// Database connection string information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigConnectionStrings
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
/// Storage version of v20250501.CorsSettings
/// Cross-Origin Resource Sharing (CORS) settings for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigCors
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
/// Storage version of v20250501.RampUpRule
/// Routing rules for ramp up testing. This rule allows to redirect static traffic % to a slot or to gradually change
/// routing % based on performance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigExperimentsRampUpRules
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
/// Storage version of v20250501.Experiments
/// Routing rules in production experiments.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigExperiments
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rampUpRules")]
    public IList<V20250501storageSiteSpecSiteConfigExperimentsRampUpRules>? RampUpRules { get; set; }
}

/// <summary>
/// Storage version of v20250501.HandlerMapping
/// The IIS handler mappings used to define which handler processes HTTP requests with certain extension.
/// For example, it is
/// used to configure php-cgi.exe process to handle all HTTP requests with *.php extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigHandlerMappings
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
public partial class V20250501storageSiteSpecSiteConfigIpSecurityRestrictionsVnetSubnetResourceReference
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
/// Storage version of v20250501.IpSecurityRestriction
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigIpSecurityRestrictions
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
    public V20250501storageSiteSpecSiteConfigIpSecurityRestrictionsVnetSubnetResourceReference? VnetSubnetResourceReference { get; set; }

    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>
/// Storage version of v20250501.SiteLimits
/// Metric limits set on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigLimits
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
/// Storage version of v20250501.NameValuePair
/// Name value pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigMetadata
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
/// Storage version of v20250501.PushSettings
/// Push settings for the App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigPush
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
public partial class V20250501storageSiteSpecSiteConfigScmIpSecurityRestrictionsVnetSubnetResourceReference
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
/// Storage version of v20250501.IpSecurityRestriction
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigScmIpSecurityRestrictions
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
    public V20250501storageSiteSpecSiteConfigScmIpSecurityRestrictionsVnetSubnetResourceReference? VnetSubnetResourceReference { get; set; }

    [JsonPropertyName("vnetTrafficTag")]
    public int? VnetTrafficTag { get; set; }
}

/// <summary>
/// Storage version of v20250501.VirtualDirectory
/// Directory for virtual application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigVirtualApplicationsVirtualDirectories
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
/// Storage version of v20250501.VirtualApplication
/// Virtual application in an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfigVirtualApplications
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
    public IList<V20250501storageSiteSpecSiteConfigVirtualApplicationsVirtualDirectories>? VirtualDirectories { get; set; }

    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>
/// Storage version of v20250501.SiteConfig
/// Configuration of an App Service app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpecSiteConfig
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
    /// Storage version of v20250501.ApiDefinitionInfo
    /// Information about the formal API definition for the app.
    /// </summary>
    [JsonPropertyName("apiDefinition")]
    public V20250501storageSiteSpecSiteConfigApiDefinition? ApiDefinition { get; set; }

    /// <summary>
    /// Storage version of v20250501.ApiManagementConfig
    /// Azure API management (APIM) configuration linked to the app.
    /// </summary>
    [JsonPropertyName("apiManagementConfig")]
    public V20250501storageSiteSpecSiteConfigApiManagementConfig? ApiManagementConfig { get; set; }

    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    [JsonPropertyName("appSettings")]
    public IList<V20250501storageSiteSpecSiteConfigAppSettings>? AppSettings { get; set; }

    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>
    /// Storage version of v20250501.AutoHealRules
    /// Rules that can be defined for auto-heal.
    /// </summary>
    [JsonPropertyName("autoHealRules")]
    public V20250501storageSiteSpecSiteConfigAutoHealRules? AutoHealRules { get; set; }

    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    [JsonPropertyName("azureStorageAccounts")]
    public IDictionary<string, V20250501storageSiteSpecSiteConfigAzureStorageAccounts>? AzureStorageAccounts { get; set; }

    [JsonPropertyName("connectionStrings")]
    public IList<V20250501storageSiteSpecSiteConfigConnectionStrings>? ConnectionStrings { get; set; }

    /// <summary>
    /// Storage version of v20250501.CorsSettings
    /// Cross-Origin Resource Sharing (CORS) settings for the app.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20250501storageSiteSpecSiteConfigCors? Cors { get; set; }

    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    [JsonPropertyName("documentRoot")]
    public string? DocumentRoot { get; set; }

    [JsonPropertyName("elasticWebAppScaleLimit")]
    public int? ElasticWebAppScaleLimit { get; set; }

    /// <summary>
    /// Storage version of v20250501.Experiments
    /// Routing rules in production experiments.
    /// </summary>
    [JsonPropertyName("experiments")]
    public V20250501storageSiteSpecSiteConfigExperiments? Experiments { get; set; }

    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    [JsonPropertyName("functionAppScaleLimit")]
    public int? FunctionAppScaleLimit { get; set; }

    [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
    public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }

    [JsonPropertyName("handlerMappings")]
    public IList<V20250501storageSiteSpecSiteConfigHandlerMappings>? HandlerMappings { get; set; }

    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    [JsonPropertyName("http20Enabled")]
    public bool? Http20Enabled { get; set; }

    [JsonPropertyName("http20ProxyFlag")]
    public int? Http20ProxyFlag { get; set; }

    [JsonPropertyName("httpLoggingEnabled")]
    public bool? HttpLoggingEnabled { get; set; }

    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V20250501storageSiteSpecSiteConfigIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    [JsonPropertyName("ipSecurityRestrictionsDefaultAction")]
    public string? IpSecurityRestrictionsDefaultAction { get; set; }

    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>
    /// Storage version of v20250501.SiteLimits
    /// Metric limits set on an app.
    /// </summary>
    [JsonPropertyName("limits")]
    public V20250501storageSiteSpecSiteConfigLimits? Limits { get; set; }

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

    [JsonPropertyName("metadata")]
    public IList<V20250501storageSiteSpecSiteConfigMetadata>? Metadata { get; set; }

    [JsonPropertyName("minTlsCipherSuite")]
    public string? MinTlsCipherSuite { get; set; }

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
    /// Storage version of v20250501.PushSettings
    /// Push settings for the App.
    /// </summary>
    [JsonPropertyName("push")]
    public V20250501storageSiteSpecSiteConfigPush? Push { get; set; }

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
    public IList<V20250501storageSiteSpecSiteConfigScmIpSecurityRestrictions>? ScmIpSecurityRestrictions { get; set; }

    [JsonPropertyName("scmIpSecurityRestrictionsDefaultAction")]
    public string? ScmIpSecurityRestrictionsDefaultAction { get; set; }

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
    public IList<V20250501storageSiteSpecSiteConfigVirtualApplications>? VirtualApplications { get; set; }

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
public partial class V20250501storageSiteSpecVirtualNetworkSubnetReference
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

/// <summary>Storage version of v20250501.Site_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoGeneratedDomainNameLabelScope")]
    public string? AutoGeneratedDomainNameLabelScope { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    [JsonPropertyName("clientAffinityPartitioningEnabled")]
    public bool? ClientAffinityPartitioningEnabled { get; set; }

    [JsonPropertyName("clientAffinityProxyEnabled")]
    public bool? ClientAffinityProxyEnabled { get; set; }

    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }

    [JsonPropertyName("clientCertExclusionPaths")]
    public string? ClientCertExclusionPaths { get; set; }

    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>
    /// Storage version of v20250501.CloningInfo
    /// Information needed for cloning operation.
    /// </summary>
    [JsonPropertyName("cloningInfo")]
    public V20250501storageSiteSpecCloningInfo? CloningInfo { get; set; }

    [JsonPropertyName("containerSize")]
    public int? ContainerSize { get; set; }

    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    [JsonPropertyName("dailyMemoryTimeQuota")]
    public int? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// Storage version of v20250501.DaprConfig
    /// App Dapr configuration.
    /// </summary>
    [JsonPropertyName("daprConfig")]
    public V20250501storageSiteSpecDaprConfig? DaprConfig { get; set; }

    /// <summary>Storage version of v20250501.SiteDnsConfig</summary>
    [JsonPropertyName("dnsConfiguration")]
    public V20250501storageSiteSpecDnsConfiguration? DnsConfiguration { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("endToEndEncryptionEnabled")]
    public bool? EndToEndEncryptionEnabled { get; set; }

    /// <summary>
    /// Storage version of v20250501.ExtendedLocation
    /// Extended Location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20250501storageSiteSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionAppConfig
    /// Function app configuration.
    /// </summary>
    [JsonPropertyName("functionAppConfig")]
    public V20250501storageSiteSpecFunctionAppConfig? FunctionAppConfig { get; set; }

    [JsonPropertyName("hostNameSslStates")]
    public IList<V20250501storageSiteSpecHostNameSslStates>? HostNameSslStates { get; set; }

    [JsonPropertyName("hostNamesDisabled")]
    public bool? HostNamesDisabled { get; set; }

    /// <summary>
    /// Storage version of v20250501.HostingEnvironmentProfile
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V20250501storageSiteSpecHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>
    /// Storage version of v20250501.ManagedServiceIdentity
    /// Managed service identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250501storageSiteSpecIdentity? Identity { get; set; }

    [JsonPropertyName("ipMode")]
    public string? IpMode { get; set; }

    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedEnvironmentReference: Azure Resource Manager ID of the customer&apos;s selected Managed Environment on which to host
    /// this app. This must be of the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.App/managedEnvironments/{managedEnvironmentName}
    /// </summary>
    [JsonPropertyName("managedEnvironmentReference")]
    public V20250501storageSiteSpecManagedEnvironmentReference? ManagedEnvironmentReference { get; set; }

    /// <summary>
    /// Storage version of v20250501.SiteOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250501storageSiteSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Storage version of v20250501.OutboundVnetRouting
    /// Outbound traffic options over virtual network.
    /// </summary>
    [JsonPropertyName("outboundVnetRouting")]
    public V20250501storageSiteSpecOutboundVnetRouting? OutboundVnetRouting { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250501storageSiteSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("redundancyMode")]
    public string? RedundancyMode { get; set; }

    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>
    /// Storage version of v20250501.ResourceConfig
    /// Function app resource requirements.
    /// </summary>
    [JsonPropertyName("resourceConfig")]
    public V20250501storageSiteSpecResourceConfig? ResourceConfig { get; set; }

    [JsonPropertyName("scmSiteAlsoStopped")]
    public bool? ScmSiteAlsoStopped { get; set; }

    /// <summary>
    /// ServerFarmReference: Resource ID of the associated App Service plan, formatted as:
    /// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
    /// </summary>
    [JsonPropertyName("serverFarmReference")]
    public V20250501storageSiteSpecServerFarmReference? ServerFarmReference { get; set; }

    /// <summary>
    /// Storage version of v20250501.SiteConfig
    /// Configuration of an App Service app.
    /// </summary>
    [JsonPropertyName("siteConfig")]
    public V20250501storageSiteSpecSiteConfig? SiteConfig { get; set; }

    [JsonPropertyName("sshEnabled")]
    public bool? SshEnabled { get; set; }

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
    public V20250501storageSiteSpecVirtualNetworkSubnetReference? VirtualNetworkSubnetReference { get; set; }

    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// Storage version of v20250501.CloningInfo_STATUS
/// Information needed for cloning operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusCloningInfo
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
public partial class V20250501storageSiteStatusConditions
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
/// Storage version of v20250501.DaprConfig_STATUS
/// App Dapr configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusDaprConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    [JsonPropertyName("appPort")]
    public int? AppPort { get; set; }

    [JsonPropertyName("enableApiLogging")]
    public bool? EnableApiLogging { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("httpMaxRequestSize")]
    public int? HttpMaxRequestSize { get; set; }

    [JsonPropertyName("httpReadBufferSize")]
    public int? HttpReadBufferSize { get; set; }

    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }
}

/// <summary>Storage version of v20250501.SiteDnsConfig_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusDnsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dnsAltServer")]
    public string? DnsAltServer { get; set; }

    [JsonPropertyName("dnsLegacySortOrder")]
    public bool? DnsLegacySortOrder { get; set; }

    [JsonPropertyName("dnsMaxCacheTimeout")]
    public int? DnsMaxCacheTimeout { get; set; }

    [JsonPropertyName("dnsRetryAttemptCount")]
    public int? DnsRetryAttemptCount { get; set; }

    [JsonPropertyName("dnsRetryAttemptTimeout")]
    public int? DnsRetryAttemptTimeout { get; set; }

    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>
/// Storage version of v20250501.ExtendedLocation_STATUS
/// Extended Location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusExtendedLocation
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
/// Storage version of v20250501.FunctionsDeploymentStorageAuthentication_STATUS
/// Authentication method to access the storage account for deployment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigDeploymentStorageAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("storageAccountConnectionStringName")]
    public string? StorageAccountConnectionStringName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentityResourceId")]
    public string? UserAssignedIdentityResourceId { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsDeploymentStorage_STATUS
/// Storage for deployed package used by the function app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigDeploymentStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsDeploymentStorageAuthentication_STATUS
    /// Authentication method to access the storage account for deployment.
    /// </summary>
    [JsonPropertyName("authentication")]
    public V20250501storageSiteStatusFunctionAppConfigDeploymentStorageAuthentication? Authentication { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsDeployment_STATUS
/// Configuration section for the function app deployment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigDeployment
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsDeploymentStorage_STATUS
    /// Storage for deployed package used by the function app.
    /// </summary>
    [JsonPropertyName("storage")]
    public V20250501storageSiteStatusFunctionAppConfigDeploymentStorage? Storage { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsRuntime_STATUS
/// Function app runtime name and version.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigRuntime
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsAlwaysReadyConfig_STATUS
/// Sets the number of &apos;Always Ready&apos; instances for a function group or a specific function.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrencyAlwaysReady
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("instanceCount")]
    public int? InstanceCount { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggersHttp_STATUS
/// Scale and concurrency settings for the HTTP trigger.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrencyTriggersHttp
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("perInstanceConcurrency")]
    public int? PerInstanceConcurrency { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggers_STATUS
/// Scale and concurrency settings for the function app triggers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrencyTriggers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggersHttp_STATUS
    /// Scale and concurrency settings for the HTTP trigger.
    /// </summary>
    [JsonPropertyName("http")]
    public V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrencyTriggersHttp? Http { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsScaleAndConcurrency_STATUS
/// Scale and concurrency settings for the function app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrency
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("alwaysReady")]
    public IList<V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrencyAlwaysReady>? AlwaysReady { get; set; }

    [JsonPropertyName("instanceMemoryMB")]
    public int? InstanceMemoryMB { get; set; }

    [JsonPropertyName("maximumInstanceCount")]
    public int? MaximumInstanceCount { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsScaleAndConcurrencyTriggers_STATUS
    /// Scale and concurrency settings for the function app triggers.
    /// </summary>
    [JsonPropertyName("triggers")]
    public V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrencyTriggers? Triggers { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionsSiteUpdateStrategy_STATUS
/// Function app site update strategy configuration for deployments and site config updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfigSiteUpdateStrategy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250501.FunctionAppConfig_STATUS
/// Function app configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusFunctionAppConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsDeployment_STATUS
    /// Configuration section for the function app deployment.
    /// </summary>
    [JsonPropertyName("deployment")]
    public V20250501storageSiteStatusFunctionAppConfigDeployment? Deployment { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsRuntime_STATUS
    /// Function app runtime name and version.
    /// </summary>
    [JsonPropertyName("runtime")]
    public V20250501storageSiteStatusFunctionAppConfigRuntime? Runtime { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsScaleAndConcurrency_STATUS
    /// Scale and concurrency settings for the function app.
    /// </summary>
    [JsonPropertyName("scaleAndConcurrency")]
    public V20250501storageSiteStatusFunctionAppConfigScaleAndConcurrency? ScaleAndConcurrency { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionsSiteUpdateStrategy_STATUS
    /// Function app site update strategy configuration for deployments and site config updates.
    /// </summary>
    [JsonPropertyName("siteUpdateStrategy")]
    public V20250501storageSiteStatusFunctionAppConfigSiteUpdateStrategy? SiteUpdateStrategy { get; set; }
}

/// <summary>
/// Storage version of v20250501.HostNameSslState_STATUS
/// SSL-enabled hostname.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusHostNameSslStates
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
/// Storage version of v20250501.HostingEnvironmentProfile_STATUS
/// Specification for an App Service Environment to use for this resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusHostingEnvironmentProfile
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
/// Storage version of v20250501.UserAssignedIdentity_STATUS
/// User Assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusIdentityUserAssignedIdentities
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
/// Storage version of v20250501.ManagedServiceIdentity_STATUS
/// Managed service identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusIdentity
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
    public IDictionary<string, V20250501storageSiteStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20250501.OutboundVnetRouting_STATUS
/// Outbound traffic options over virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusOutboundVnetRouting
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allTraffic")]
    public bool? AllTraffic { get; set; }

    [JsonPropertyName("applicationTraffic")]
    public bool? ApplicationTraffic { get; set; }

    [JsonPropertyName("backupRestoreTraffic")]
    public bool? BackupRestoreTraffic { get; set; }

    [JsonPropertyName("contentShareTraffic")]
    public bool? ContentShareTraffic { get; set; }

    [JsonPropertyName("imagePullTraffic")]
    public bool? ImagePullTraffic { get; set; }
}

/// <summary>
/// Storage version of v20250501.ResourceConfig_STATUS
/// Function app resource requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusResourceConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Storage version of v20250501.ApiDefinitionInfo_STATUS
/// Information about the formal API definition for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigApiDefinition
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
/// Storage version of v20250501.ApiManagementConfig_STATUS
/// Azure API management (APIM) configuration linked to the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigApiManagementConfig
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
/// Storage version of v20250501.NameValuePair_STATUS
/// Name value pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAppSettings
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
/// Storage version of v20250501.AutoHealCustomAction_STATUS
/// Custom action to be executed
/// when an auto heal rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesActionsCustomAction
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
/// Storage version of v20250501.AutoHealActions_STATUS
/// Actions which to take by the auto-heal module when a rule is triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesActions
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
    /// Storage version of v20250501.AutoHealCustomAction_STATUS
    /// Custom action to be executed
    /// when an auto heal rule is triggered.
    /// </summary>
    [JsonPropertyName("customAction")]
    public V20250501storageSiteStatusSiteConfigAutoHealRulesActionsCustomAction? CustomAction { get; set; }

    [JsonPropertyName("minProcessExecutionTime")]
    public string? MinProcessExecutionTime { get; set; }
}

/// <summary>
/// Storage version of v20250501.RequestsBasedTrigger_STATUS
/// Trigger based on total requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersRequests
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
/// Storage version of v20250501.SlowRequestsBasedTrigger_STATUS
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequests
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
/// Storage version of v20250501.SlowRequestsBasedTrigger_STATUS
/// Trigger based on request execution time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequestsWithPath
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
/// Storage version of v20250501.StatusCodesBasedTrigger_STATUS
/// Trigger based on status code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodes
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
/// Storage version of v20250501.StatusCodesRangeBasedTrigger_STATUS
/// Trigger based on range of status codes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodesRange
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
/// Storage version of v20250501.AutoHealTriggers_STATUS
/// Triggers for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRulesTriggers
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
    /// Storage version of v20250501.RequestsBasedTrigger_STATUS
    /// Trigger based on total requests.
    /// </summary>
    [JsonPropertyName("requests")]
    public V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersRequests? Requests { get; set; }

    /// <summary>
    /// Storage version of v20250501.SlowRequestsBasedTrigger_STATUS
    /// Trigger based on request execution time.
    /// </summary>
    [JsonPropertyName("slowRequests")]
    public V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequests? SlowRequests { get; set; }

    [JsonPropertyName("slowRequestsWithPath")]
    public IList<V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersSlowRequestsWithPath>? SlowRequestsWithPath { get; set; }

    [JsonPropertyName("statusCodes")]
    public IList<V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodes>? StatusCodes { get; set; }

    [JsonPropertyName("statusCodesRange")]
    public IList<V20250501storageSiteStatusSiteConfigAutoHealRulesTriggersStatusCodesRange>? StatusCodesRange { get; set; }
}

/// <summary>
/// Storage version of v20250501.AutoHealRules_STATUS
/// Rules that can be defined for auto-heal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAutoHealRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250501.AutoHealActions_STATUS
    /// Actions which to take by the auto-heal module when a rule is triggered.
    /// </summary>
    [JsonPropertyName("actions")]
    public V20250501storageSiteStatusSiteConfigAutoHealRulesActions? Actions { get; set; }

    /// <summary>
    /// Storage version of v20250501.AutoHealTriggers_STATUS
    /// Triggers for auto-heal.
    /// </summary>
    [JsonPropertyName("triggers")]
    public V20250501storageSiteStatusSiteConfigAutoHealRulesTriggers? Triggers { get; set; }
}

/// <summary>
/// Storage version of v20250501.AzureStorageInfoValue_STATUS
/// Azure Files or Blob Storage access information value for dictionary storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigAzureStorageAccounts
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

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250501.ConnStringInfo_STATUS
/// Database connection string information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigConnectionStrings
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
/// Storage version of v20250501.CorsSettings_STATUS
/// Cross-Origin Resource Sharing (CORS) settings for the app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigCors
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
/// Storage version of v20250501.RampUpRule_STATUS
/// Routing rules for ramp up testing. This rule allows to redirect static traffic % to a slot or to gradually change
/// routing % based on performance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigExperimentsRampUpRules
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
/// Storage version of v20250501.Experiments_STATUS
/// Routing rules in production experiments.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigExperiments
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rampUpRules")]
    public IList<V20250501storageSiteStatusSiteConfigExperimentsRampUpRules>? RampUpRules { get; set; }
}

/// <summary>
/// Storage version of v20250501.HandlerMapping_STATUS
/// The IIS handler mappings used to define which handler processes HTTP requests with certain extension.
/// For example, it is
/// used to configure php-cgi.exe process to handle all HTTP requests with *.php extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigHandlerMappings
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
/// Storage version of v20250501.IpSecurityRestriction_STATUS
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigIpSecurityRestrictions
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
/// Storage version of v20250501.SiteLimits_STATUS
/// Metric limits set on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigLimits
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
/// Storage version of v20250501.SiteMachineKey_STATUS
/// MachineKey of an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigMachineKey
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
/// Storage version of v20250501.NameValuePair_STATUS
/// Name value pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigMetadata
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
/// Storage version of v20250501.PushSettings_STATUS
/// Push settings for the App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigPush
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
/// Storage version of v20250501.IpSecurityRestriction_STATUS
/// IP security restriction on an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigScmIpSecurityRestrictions
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
/// Storage version of v20250501.VirtualDirectory_STATUS
/// Directory for virtual application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigVirtualApplicationsVirtualDirectories
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
/// Storage version of v20250501.VirtualApplication_STATUS
/// Virtual application in an app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfigVirtualApplications
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
    public IList<V20250501storageSiteStatusSiteConfigVirtualApplicationsVirtualDirectories>? VirtualDirectories { get; set; }

    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary>
/// Storage version of v20250501.SiteConfig_STATUS
/// Configuration of an App Service app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSiteConfig
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
    /// Storage version of v20250501.ApiDefinitionInfo_STATUS
    /// Information about the formal API definition for the app.
    /// </summary>
    [JsonPropertyName("apiDefinition")]
    public V20250501storageSiteStatusSiteConfigApiDefinition? ApiDefinition { get; set; }

    /// <summary>
    /// Storage version of v20250501.ApiManagementConfig_STATUS
    /// Azure API management (APIM) configuration linked to the app.
    /// </summary>
    [JsonPropertyName("apiManagementConfig")]
    public V20250501storageSiteStatusSiteConfigApiManagementConfig? ApiManagementConfig { get; set; }

    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    [JsonPropertyName("appSettings")]
    public IList<V20250501storageSiteStatusSiteConfigAppSettings>? AppSettings { get; set; }

    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>
    /// Storage version of v20250501.AutoHealRules_STATUS
    /// Rules that can be defined for auto-heal.
    /// </summary>
    [JsonPropertyName("autoHealRules")]
    public V20250501storageSiteStatusSiteConfigAutoHealRules? AutoHealRules { get; set; }

    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    [JsonPropertyName("azureStorageAccounts")]
    public IDictionary<string, V20250501storageSiteStatusSiteConfigAzureStorageAccounts>? AzureStorageAccounts { get; set; }

    [JsonPropertyName("connectionStrings")]
    public IList<V20250501storageSiteStatusSiteConfigConnectionStrings>? ConnectionStrings { get; set; }

    /// <summary>
    /// Storage version of v20250501.CorsSettings_STATUS
    /// Cross-Origin Resource Sharing (CORS) settings for the app.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20250501storageSiteStatusSiteConfigCors? Cors { get; set; }

    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    [JsonPropertyName("documentRoot")]
    public string? DocumentRoot { get; set; }

    [JsonPropertyName("elasticWebAppScaleLimit")]
    public int? ElasticWebAppScaleLimit { get; set; }

    /// <summary>
    /// Storage version of v20250501.Experiments_STATUS
    /// Routing rules in production experiments.
    /// </summary>
    [JsonPropertyName("experiments")]
    public V20250501storageSiteStatusSiteConfigExperiments? Experiments { get; set; }

    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    [JsonPropertyName("functionAppScaleLimit")]
    public int? FunctionAppScaleLimit { get; set; }

    [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
    public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }

    [JsonPropertyName("handlerMappings")]
    public IList<V20250501storageSiteStatusSiteConfigHandlerMappings>? HandlerMappings { get; set; }

    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    [JsonPropertyName("http20Enabled")]
    public bool? Http20Enabled { get; set; }

    [JsonPropertyName("http20ProxyFlag")]
    public int? Http20ProxyFlag { get; set; }

    [JsonPropertyName("httpLoggingEnabled")]
    public bool? HttpLoggingEnabled { get; set; }

    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V20250501storageSiteStatusSiteConfigIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    [JsonPropertyName("ipSecurityRestrictionsDefaultAction")]
    public string? IpSecurityRestrictionsDefaultAction { get; set; }

    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    [JsonPropertyName("keyVaultReferenceIdentity")]
    public string? KeyVaultReferenceIdentity { get; set; }

    /// <summary>
    /// Storage version of v20250501.SiteLimits_STATUS
    /// Metric limits set on an app.
    /// </summary>
    [JsonPropertyName("limits")]
    public V20250501storageSiteStatusSiteConfigLimits? Limits { get; set; }

    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    [JsonPropertyName("loadBalancing")]
    public string? LoadBalancing { get; set; }

    [JsonPropertyName("localMySqlEnabled")]
    public bool? LocalMySqlEnabled { get; set; }

    [JsonPropertyName("logsDirectorySizeLimit")]
    public int? LogsDirectorySizeLimit { get; set; }

    /// <summary>
    /// Storage version of v20250501.SiteMachineKey_STATUS
    /// MachineKey of an app.
    /// </summary>
    [JsonPropertyName("machineKey")]
    public V20250501storageSiteStatusSiteConfigMachineKey? MachineKey { get; set; }

    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    [JsonPropertyName("managedServiceIdentityId")]
    public int? ManagedServiceIdentityId { get; set; }

    [JsonPropertyName("metadata")]
    public IList<V20250501storageSiteStatusSiteConfigMetadata>? Metadata { get; set; }

    [JsonPropertyName("minTlsCipherSuite")]
    public string? MinTlsCipherSuite { get; set; }

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
    /// Storage version of v20250501.PushSettings_STATUS
    /// Push settings for the App.
    /// </summary>
    [JsonPropertyName("push")]
    public V20250501storageSiteStatusSiteConfigPush? Push { get; set; }

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
    public IList<V20250501storageSiteStatusSiteConfigScmIpSecurityRestrictions>? ScmIpSecurityRestrictions { get; set; }

    [JsonPropertyName("scmIpSecurityRestrictionsDefaultAction")]
    public string? ScmIpSecurityRestrictionsDefaultAction { get; set; }

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
    public IList<V20250501storageSiteStatusSiteConfigVirtualApplications>? VirtualApplications { get; set; }

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
/// Storage version of v20250501.SlotSwapStatus_STATUS
/// The status of the last successful slot swap operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSlotSwapStatus
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
/// Storage version of v20250501.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v20250501.Site_STATUS
/// A web app, a mobile app backend, or an API app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501storageSiteStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoGeneratedDomainNameLabelScope")]
    public string? AutoGeneratedDomainNameLabelScope { get; set; }

    [JsonPropertyName("availabilityState")]
    public string? AvailabilityState { get; set; }

    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    [JsonPropertyName("clientAffinityPartitioningEnabled")]
    public bool? ClientAffinityPartitioningEnabled { get; set; }

    [JsonPropertyName("clientAffinityProxyEnabled")]
    public bool? ClientAffinityProxyEnabled { get; set; }

    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }

    [JsonPropertyName("clientCertExclusionPaths")]
    public string? ClientCertExclusionPaths { get; set; }

    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>
    /// Storage version of v20250501.CloningInfo_STATUS
    /// Information needed for cloning operation.
    /// </summary>
    [JsonPropertyName("cloningInfo")]
    public V20250501storageSiteStatusCloningInfo? CloningInfo { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250501storageSiteStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("containerSize")]
    public int? ContainerSize { get; set; }

    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    [JsonPropertyName("dailyMemoryTimeQuota")]
    public int? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// Storage version of v20250501.DaprConfig_STATUS
    /// App Dapr configuration.
    /// </summary>
    [JsonPropertyName("daprConfig")]
    public V20250501storageSiteStatusDaprConfig? DaprConfig { get; set; }

    [JsonPropertyName("defaultHostName")]
    public string? DefaultHostName { get; set; }

    /// <summary>Storage version of v20250501.SiteDnsConfig_STATUS</summary>
    [JsonPropertyName("dnsConfiguration")]
    public V20250501storageSiteStatusDnsConfiguration? DnsConfiguration { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("enabledHostNames")]
    public IList<string>? EnabledHostNames { get; set; }

    [JsonPropertyName("endToEndEncryptionEnabled")]
    public bool? EndToEndEncryptionEnabled { get; set; }

    /// <summary>
    /// Storage version of v20250501.ExtendedLocation_STATUS
    /// Extended Location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20250501storageSiteStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Storage version of v20250501.FunctionAppConfig_STATUS
    /// Function app configuration.
    /// </summary>
    [JsonPropertyName("functionAppConfig")]
    public V20250501storageSiteStatusFunctionAppConfig? FunctionAppConfig { get; set; }

    [JsonPropertyName("hostNameSslStates")]
    public IList<V20250501storageSiteStatusHostNameSslStates>? HostNameSslStates { get; set; }

    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    [JsonPropertyName("hostNamesDisabled")]
    public bool? HostNamesDisabled { get; set; }

    /// <summary>
    /// Storage version of v20250501.HostingEnvironmentProfile_STATUS
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V20250501storageSiteStatusHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250501.ManagedServiceIdentity_STATUS
    /// Managed service identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250501storageSiteStatusIdentity? Identity { get; set; }

    [JsonPropertyName("inProgressOperationId")]
    public string? InProgressOperationId { get; set; }

    [JsonPropertyName("ipMode")]
    public string? IpMode { get; set; }

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

    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    [JsonPropertyName("maxNumberOfWorkers")]
    public int? MaxNumberOfWorkers { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>
    /// Storage version of v20250501.OutboundVnetRouting_STATUS
    /// Outbound traffic options over virtual network.
    /// </summary>
    [JsonPropertyName("outboundVnetRouting")]
    public V20250501storageSiteStatusOutboundVnetRouting? OutboundVnetRouting { get; set; }

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

    /// <summary>
    /// Storage version of v20250501.ResourceConfig_STATUS
    /// Function app resource requirements.
    /// </summary>
    [JsonPropertyName("resourceConfig")]
    public V20250501storageSiteStatusResourceConfig? ResourceConfig { get; set; }

    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    [JsonPropertyName("scmSiteAlsoStopped")]
    public bool? ScmSiteAlsoStopped { get; set; }

    [JsonPropertyName("serverFarmId")]
    public string? ServerFarmId { get; set; }

    /// <summary>
    /// Storage version of v20250501.SiteConfig_STATUS
    /// Configuration of an App Service app.
    /// </summary>
    [JsonPropertyName("siteConfig")]
    public V20250501storageSiteStatusSiteConfig? SiteConfig { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// Storage version of v20250501.SlotSwapStatus_STATUS
    /// The status of the last successful slot swap operation.
    /// </summary>
    [JsonPropertyName("slotSwapStatus")]
    public V20250501storageSiteStatusSlotSwapStatus? SlotSwapStatus { get; set; }

    [JsonPropertyName("sshEnabled")]
    public bool? SshEnabled { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("storageAccountRequired")]
    public bool? StorageAccountRequired { get; set; }

    [JsonPropertyName("suspendedTill")]
    public string? SuspendedTill { get; set; }

    /// <summary>
    /// Storage version of v20250501.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20250501storageSiteStatusSystemData? SystemData { get; set; }

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

    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// Storage version of v20250501.Site
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2025-05-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250501storageSite : IKubernetesObject<V1ObjectMeta>, ISpec<V20250501storageSiteSpec?>, IStatus<V20250501storageSiteStatus?>
{
    public const string KubeApiVersion = "v20250501storage";
    public const string KubeKind = "Site";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v20250501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Site";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250501.Site_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250501storageSiteSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20250501.Site_STATUS
    /// A web app, a mobile app backend, or an API app.
    /// </summary>
    [JsonPropertyName("status")]
    public V20250501storageSiteStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.conditionalaccess.azuread.m.upbound.io;
/// <summary>Location is the Schema for the Locations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LocationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Location>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LocationList";
    public const string KubeGroup = "conditionalaccess.azuread.m.upbound.io";
    public const string KubePluralName = "locations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "conditionalaccess.azuread.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LocationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Location objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Location> Items { get; set; }
}

/// <summary>A country block as documented below, which configures a country-based named location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecForProviderCountry
{
    /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2.</summary>
    [JsonPropertyName("countriesAndRegions")]
    public IList<string>? CountriesAndRegions { get; set; }

    /// <summary>Method of detecting country the user is located in. Possible values are clientIpAddress for IP-based location and authenticatorAppGps for Authenticator app GPS-based location.  Defaults to clientIpAddress.</summary>
    [JsonPropertyName("countryLookupMethod")]
    public string? CountryLookupMethod { get; set; }

    /// <summary>Whether IP addresses that don&apos;t map to a country or region should be included in the named location. Defaults to false.</summary>
    [JsonPropertyName("includeUnknownCountriesAndRegions")]
    public bool? IncludeUnknownCountriesAndRegions { get; set; }
}

/// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecForProviderIp
{
    /// <summary>List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Each CIDR prefix must be /8 or larger.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Whether the named location is trusted. Defaults to false.</summary>
    [JsonPropertyName("trusted")]
    public bool? Trusted { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecForProvider
{
    /// <summary>A country block as documented below, which configures a country-based named location.</summary>
    [JsonPropertyName("country")]
    public V1beta1LocationSpecForProviderCountry? Country { get; set; }

    /// <summary>The friendly name for this named location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
    [JsonPropertyName("ip")]
    public V1beta1LocationSpecForProviderIp? Ip { get; set; }
}

/// <summary>A country block as documented below, which configures a country-based named location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecInitProviderCountry
{
    /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2.</summary>
    [JsonPropertyName("countriesAndRegions")]
    public IList<string>? CountriesAndRegions { get; set; }

    /// <summary>Method of detecting country the user is located in. Possible values are clientIpAddress for IP-based location and authenticatorAppGps for Authenticator app GPS-based location.  Defaults to clientIpAddress.</summary>
    [JsonPropertyName("countryLookupMethod")]
    public string? CountryLookupMethod { get; set; }

    /// <summary>Whether IP addresses that don&apos;t map to a country or region should be included in the named location. Defaults to false.</summary>
    [JsonPropertyName("includeUnknownCountriesAndRegions")]
    public bool? IncludeUnknownCountriesAndRegions { get; set; }
}

/// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecInitProviderIp
{
    /// <summary>List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Each CIDR prefix must be /8 or larger.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Whether the named location is trusted. Defaults to false.</summary>
    [JsonPropertyName("trusted")]
    public bool? Trusted { get; set; }
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
public partial class V1beta1LocationSpecInitProvider
{
    /// <summary>A country block as documented below, which configures a country-based named location.</summary>
    [JsonPropertyName("country")]
    public V1beta1LocationSpecInitProviderCountry? Country { get; set; }

    /// <summary>The friendly name for this named location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
    [JsonPropertyName("ip")]
    public V1beta1LocationSpecInitProviderIp? Ip { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LocationSpecManagementPoliciesEnum>))]
public enum V1beta1LocationSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>LocationSpec defines the desired state of Location</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1LocationSpecForProvider ForProvider { get; set; }

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
    public V1beta1LocationSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LocationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LocationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LocationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A country block as documented below, which configures a country-based named location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusAtProviderCountry
{
    /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2.</summary>
    [JsonPropertyName("countriesAndRegions")]
    public IList<string>? CountriesAndRegions { get; set; }

    /// <summary>Method of detecting country the user is located in. Possible values are clientIpAddress for IP-based location and authenticatorAppGps for Authenticator app GPS-based location.  Defaults to clientIpAddress.</summary>
    [JsonPropertyName("countryLookupMethod")]
    public string? CountryLookupMethod { get; set; }

    /// <summary>Whether IP addresses that don&apos;t map to a country or region should be included in the named location. Defaults to false.</summary>
    [JsonPropertyName("includeUnknownCountriesAndRegions")]
    public bool? IncludeUnknownCountriesAndRegions { get; set; }
}

/// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusAtProviderIp
{
    /// <summary>List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Each CIDR prefix must be /8 or larger.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Whether the named location is trusted. Defaults to false.</summary>
    [JsonPropertyName("trusted")]
    public bool? Trusted { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusAtProvider
{
    /// <summary>A country block as documented below, which configures a country-based named location.</summary>
    [JsonPropertyName("country")]
    public V1beta1LocationStatusAtProviderCountry? Country { get; set; }

    /// <summary>The friendly name for this named location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the named location.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
    [JsonPropertyName("ip")]
    public V1beta1LocationStatusAtProviderIp? Ip { get; set; }

    /// <summary>
    /// The object ID of the named location.
    /// The object ID of the named location
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusConditions
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

/// <summary>LocationStatus defines the observed state of Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1LocationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LocationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Location is the Schema for the Locations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Location : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LocationSpec>, IStatus<V1beta1LocationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Location";
    public const string KubeGroup = "conditionalaccess.azuread.m.upbound.io";
    public const string KubePluralName = "locations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "conditionalaccess.azuread.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Location";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LocationSpec defines the desired state of Location</summary>
    [JsonPropertyName("spec")]
    public required V1beta1LocationSpec Spec { get; set; }

    /// <summary>LocationStatus defines the observed state of Location.</summary>
    [JsonPropertyName("status")]
    public V1beta1LocationStatus? Status { get; set; }
}
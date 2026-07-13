#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devices.azure.m.upbound.io;
/// <summary>IOTHubDPS is the Schema for the IOTHubDPSs API. Manages an IoT Device Provisioning Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IOTHubDPSList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IOTHubDPS>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IOTHubDPSList";
    public const string KubeGroup = "devices.azure.m.upbound.io";
    public const string KubePluralName = "iothubdps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IOTHubDPSList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1IOTHubDPS objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1IOTHubDPS> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderIpFilterRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Accept, Reject</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Target for requests captured by this rule. Possible values are all, deviceApi and serviceApi.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>The connection string to connect to the IoT Hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderLinkedHubConnectionStringSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderLinkedHub
{
    /// <summary>The weight applied to the IoT Hub. Defaults to 1.</summary>
    [JsonPropertyName("allocationWeight")]
    public double? AllocationWeight { get; set; }

    /// <summary>Determines whether to apply allocation policies to the IoT Hub. Defaults to true.</summary>
    [JsonPropertyName("applyAllocationPolicy")]
    public bool? ApplyAllocationPolicy { get; set; }

    /// <summary>The connection string to connect to the IoT Hub.</summary>
    [JsonPropertyName("connectionStringSecretRef")]
    public V1beta1IOTHubDPSSpecForProviderLinkedHubConnectionStringSecretRef? ConnectionStringSecretRef { get; set; }

    /// <summary>The location of the IoT hub.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderSku
{
    /// <summary>The number of provisioned IoT Device Provisioning Service units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Currently can only be set to S1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProvider
{
    /// <summary>The allocation policy of the IoT Device Provisioning Service (Hashed, GeoLatency or Static). Defaults to Hashed.</summary>
    [JsonPropertyName("allocationPolicy")]
    public string? AllocationPolicy { get; set; }

    /// <summary>Specifies if the IoT Device Provisioning Service has data residency enabled, removing the cross geo-pair disaster recovery. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataResidencyEnabled")]
    public bool? DataResidencyEnabled { get; set; }

    /// <summary>An ip_filter_rule block as defined below.</summary>
    [JsonPropertyName("ipFilterRule")]
    public IList<V1beta1IOTHubDPSSpecForProviderIpFilterRule>? IpFilterRule { get; set; }

    /// <summary>A linked_hub block as defined below.</summary>
    [JsonPropertyName("linkedHub")]
    public IList<V1beta1IOTHubDPSSpecForProviderLinkedHub>? LinkedHub { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether requests from Public Network are allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group under which the Iot Device Provisioning Service resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta1IOTHubDPSSpecForProviderSku? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProviderIpFilterRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Accept, Reject</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Target for requests captured by this rule. Possible values are all, deviceApi and serviceApi.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>The connection string to connect to the IoT Hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProviderLinkedHubConnectionStringSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProviderLinkedHub
{
    /// <summary>The weight applied to the IoT Hub. Defaults to 1.</summary>
    [JsonPropertyName("allocationWeight")]
    public double? AllocationWeight { get; set; }

    /// <summary>Determines whether to apply allocation policies to the IoT Hub. Defaults to true.</summary>
    [JsonPropertyName("applyAllocationPolicy")]
    public bool? ApplyAllocationPolicy { get; set; }

    /// <summary>The connection string to connect to the IoT Hub.</summary>
    [JsonPropertyName("connectionStringSecretRef")]
    public required V1beta1IOTHubDPSSpecInitProviderLinkedHubConnectionStringSecretRef ConnectionStringSecretRef { get; set; }

    /// <summary>The location of the IoT hub.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProviderSku
{
    /// <summary>The number of provisioned IoT Device Provisioning Service units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Currently can only be set to S1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
public partial class V1beta1IOTHubDPSSpecInitProvider
{
    /// <summary>The allocation policy of the IoT Device Provisioning Service (Hashed, GeoLatency or Static). Defaults to Hashed.</summary>
    [JsonPropertyName("allocationPolicy")]
    public string? AllocationPolicy { get; set; }

    /// <summary>Specifies if the IoT Device Provisioning Service has data residency enabled, removing the cross geo-pair disaster recovery. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataResidencyEnabled")]
    public bool? DataResidencyEnabled { get; set; }

    /// <summary>An ip_filter_rule block as defined below.</summary>
    [JsonPropertyName("ipFilterRule")]
    public IList<V1beta1IOTHubDPSSpecInitProviderIpFilterRule>? IpFilterRule { get; set; }

    /// <summary>A linked_hub block as defined below.</summary>
    [JsonPropertyName("linkedHub")]
    public IList<V1beta1IOTHubDPSSpecInitProviderLinkedHub>? LinkedHub { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether requests from Public Network are allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta1IOTHubDPSSpecInitProviderSku? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubDPSSpecManagementPoliciesEnum>))]
public enum V1beta1IOTHubDPSSpecManagementPoliciesEnum
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
public partial class V1beta1IOTHubDPSSpecProviderConfigRef
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
public partial class V1beta1IOTHubDPSSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>IOTHubDPSSpec defines the desired state of IOTHubDPS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1IOTHubDPSSpecForProvider ForProvider { get; set; }

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
    public V1beta1IOTHubDPSSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1IOTHubDPSSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IOTHubDPSSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IOTHubDPSSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProviderIpFilterRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Accept, Reject</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Target for requests captured by this rule. Possible values are all, deviceApi and serviceApi.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProviderLinkedHub
{
    /// <summary>The weight applied to the IoT Hub. Defaults to 1.</summary>
    [JsonPropertyName("allocationWeight")]
    public double? AllocationWeight { get; set; }

    /// <summary>Determines whether to apply allocation policies to the IoT Hub. Defaults to true.</summary>
    [JsonPropertyName("applyAllocationPolicy")]
    public bool? ApplyAllocationPolicy { get; set; }

    /// <summary>(Computed) The IoT Hub hostname.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The location of the IoT hub.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProviderSku
{
    /// <summary>The number of provisioned IoT Device Provisioning Service units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Currently can only be set to S1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProvider
{
    /// <summary>The allocation policy of the IoT Device Provisioning Service (Hashed, GeoLatency or Static). Defaults to Hashed.</summary>
    [JsonPropertyName("allocationPolicy")]
    public string? AllocationPolicy { get; set; }

    /// <summary>Specifies if the IoT Device Provisioning Service has data residency enabled, removing the cross geo-pair disaster recovery. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataResidencyEnabled")]
    public bool? DataResidencyEnabled { get; set; }

    /// <summary>The device endpoint of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("deviceProvisioningHostName")]
    public string? DeviceProvisioningHostName { get; set; }

    /// <summary>The ID of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique identifier of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("idScope")]
    public string? IdScope { get; set; }

    /// <summary>An ip_filter_rule block as defined below.</summary>
    [JsonPropertyName("ipFilterRule")]
    public IList<V1beta1IOTHubDPSStatusAtProviderIpFilterRule>? IpFilterRule { get; set; }

    /// <summary>A linked_hub block as defined below.</summary>
    [JsonPropertyName("linkedHub")]
    public IList<V1beta1IOTHubDPSStatusAtProviderLinkedHub>? LinkedHub { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether requests from Public Network are allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group under which the Iot Device Provisioning Service resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The service endpoint of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("serviceOperationsHostName")]
    public string? ServiceOperationsHostName { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta1IOTHubDPSStatusAtProviderSku? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusConditions
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

/// <summary>IOTHubDPSStatus defines the observed state of IOTHubDPS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1IOTHubDPSStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IOTHubDPSStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IOTHubDPS is the Schema for the IOTHubDPSs API. Manages an IoT Device Provisioning Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IOTHubDPS : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IOTHubDPSSpec>, IStatus<V1beta1IOTHubDPSStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IOTHubDPS";
    public const string KubeGroup = "devices.azure.m.upbound.io";
    public const string KubePluralName = "iothubdps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IOTHubDPS";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IOTHubDPSSpec defines the desired state of IOTHubDPS</summary>
    [JsonPropertyName("spec")]
    public required V1beta1IOTHubDPSSpec Spec { get; set; }

    /// <summary>IOTHubDPSStatus defines the observed state of IOTHubDPS.</summary>
    [JsonPropertyName("status")]
    public V1beta1IOTHubDPSStatus? Status { get; set; }
}
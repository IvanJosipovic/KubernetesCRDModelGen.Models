#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kubevirt.io;
/// <summary>KubeVirt represents the object deploying all KubeVirt resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3KubeVirtList : IKubernetesObject<V1ListMeta>, IItems<V1alpha3KubeVirt>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "KubeVirtList";
    public const string KubeGroup = "kubevirt.io";
    public const string KubePluralName = "kubevirts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubevirt.io/v1alpha3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KubeVirtList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha3KubeVirt objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha3KubeVirt> Items { get; set; }
}

/// <summary>
/// CA configuration
/// CA certs are kept in the CA bundle as long as they are valid
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecCertificateRotateStrategySelfSignedCa
{
    /// <summary>The requested &apos;duration&apos; (i.e. lifetime) of the Certificate.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// The amount of time before the currently issued certificate&apos;s &quot;notAfter&quot;
    /// time that we will begin to attempt to renew the certificate.
    /// </summary>
    [JsonPropertyName("renewBefore")]
    public string? RenewBefore { get; set; }
}

/// <summary>
/// Server configuration
/// Certs are rotated and discarded
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecCertificateRotateStrategySelfSignedServer
{
    /// <summary>The requested &apos;duration&apos; (i.e. lifetime) of the Certificate.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// The amount of time before the currently issued certificate&apos;s &quot;notAfter&quot;
    /// time that we will begin to attempt to renew the certificate.
    /// </summary>
    [JsonPropertyName("renewBefore")]
    public string? RenewBefore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecCertificateRotateStrategySelfSigned
{
    /// <summary>
    /// CA configuration
    /// CA certs are kept in the CA bundle as long as they are valid
    /// </summary>
    [JsonPropertyName("ca")]
    public V1alpha3KubeVirtSpecCertificateRotateStrategySelfSignedCa? Ca { get; set; }

    /// <summary>Deprecated. Use CA.Duration and CA.RenewBefore instead</summary>
    [JsonPropertyName("caOverlapInterval")]
    public string? CaOverlapInterval { get; set; }

    /// <summary>Deprecated. Use CA.Duration instead</summary>
    [JsonPropertyName("caRotateInterval")]
    public string? CaRotateInterval { get; set; }

    /// <summary>Deprecated. Use Server.Duration instead</summary>
    [JsonPropertyName("certRotateInterval")]
    public string? CertRotateInterval { get; set; }

    /// <summary>
    /// Server configuration
    /// Certs are rotated and discarded
    /// </summary>
    [JsonPropertyName("server")]
    public V1alpha3KubeVirtSpecCertificateRotateStrategySelfSignedServer? Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecCertificateRotateStrategy
{
    [JsonPropertyName("selfSigned")]
    public V1alpha3KubeVirtSpecCertificateRotateStrategySelfSigned? SelfSigned { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>
    /// Maximum burst for throttle.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("burst")]
    public required int Burst { get; set; }

    /// <summary>
    /// QPS indicates the maximum QPS to the apiserver from this client.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("qps")]
    public required double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiter
{
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationApiConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>
/// ReloadableComponentConfiguration holds all generic k8s configuration options which can
/// be reloaded by components without requiring a restart.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationApiConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1alpha3KubeVirtSpecConfigurationApiConfigurationRestClient? RestClient { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationAmd64
{
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationArm64
{
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }
}

/// <summary>Deprecated: ppc64le architecture is no longer supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationPpc64le
{
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationS390x
{
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationArchitectureConfiguration
{
    [JsonPropertyName("amd64")]
    public V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationAmd64? Amd64 { get; set; }

    [JsonPropertyName("arm64")]
    public V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationArm64? Arm64 { get; set; }

    [JsonPropertyName("defaultArchitecture")]
    public string? DefaultArchitecture { get; set; }

    /// <summary>Deprecated: ppc64le architecture is no longer supported.</summary>
    [JsonPropertyName("ppc64le")]
    public V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationPpc64le? Ppc64le { get; set; }

    [JsonPropertyName("s390x")]
    public V1alpha3KubeVirtSpecConfigurationArchitectureConfigurationS390x? S390x { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// When set, AutoCPULimitNamespaceLabelSelector will set a CPU limit on virt-launcher for VMIs running inside
/// namespaces that match the label selector.
/// The CPU limit will equal the number of requested vCPUs.
/// This setting does not apply to VMIs with dedicated CPUs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsNamespaceLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>NamespaceSelector will enable changedBlockTracking on all VMs running inside namespaces that match the label selector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsNamespaceLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsNamespaceLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsVirtualMachineLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>VirtualMachineSelector will enable changedBlockTracking on all VMs that match the label selector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsVirtualMachineLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsVirtualMachineLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// ChangedBlockTrackingLabelSelectors defines label selectors. VMs matching these selectors will have changed block tracking enabled.
/// Enabling changedBlockTracking is mandatory for performing storage-agnostic backups and incremental backups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectors
{
    /// <summary>NamespaceSelector will enable changedBlockTracking on all VMs running inside namespaces that match the label selector.</summary>
    [JsonPropertyName("namespaceLabelSelector")]
    public V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsNamespaceLabelSelector? NamespaceLabelSelector { get; set; }

    /// <summary>VirtualMachineSelector will enable changedBlockTracking on all VMs that match the label selector.</summary>
    [JsonPropertyName("virtualMachineLabelSelector")]
    public V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectorsVirtualMachineLabelSelector? VirtualMachineLabelSelector { get; set; }
}

/// <summary>CommonInstancetypesDeployment controls the deployment of common-instancetypes resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationCommonInstancetypesDeployment
{
    /// <summary>Enabled controls the deployment of common-instancetypes resources, defaults to True.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>
    /// Maximum burst for throttle.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("burst")]
    public required int Burst { get; set; }

    /// <summary>
    /// QPS indicates the maximum QPS to the apiserver from this client.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("qps")]
    public required double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiter
{
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationControllerConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>
/// ReloadableComponentConfiguration holds all generic k8s configuration options which can
/// be reloaded by components without requiring a restart.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationControllerConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1alpha3KubeVirtSpecConfigurationControllerConfigurationRestClient? RestClient { get; set; }
}

/// <summary>DiskVerification holds container disks verification limits</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationDeveloperConfigurationDiskVerification
{
    [JsonPropertyName("memoryLimit")]
    public required IntOrString MemoryLimit { get; set; }
}

/// <summary>LogVerbosity sets log verbosity level of  various components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationDeveloperConfigurationLogVerbosity
{
    /// <summary>NodeVerbosity represents a map of nodes with a specific verbosity level</summary>
    [JsonPropertyName("nodeVerbosity")]
    public IDictionary<string, int>? NodeVerbosity { get; set; }

    [JsonPropertyName("virtAPI")]
    public int? VirtAPI { get; set; }

    [JsonPropertyName("virtController")]
    public int? VirtController { get; set; }

    [JsonPropertyName("virtHandler")]
    public int? VirtHandler { get; set; }

    [JsonPropertyName("virtLauncher")]
    public int? VirtLauncher { get; set; }

    [JsonPropertyName("virtOperator")]
    public int? VirtOperator { get; set; }

    [JsonPropertyName("virtSynchronizationController")]
    public int? VirtSynchronizationController { get; set; }
}

/// <summary>DeveloperConfiguration holds developer options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationDeveloperConfiguration
{
    /// <summary>Enable the ability to pprof profile KubeVirt control plane</summary>
    [JsonPropertyName("clusterProfiler")]
    public bool? ClusterProfiler { get; set; }

    /// <summary>
    /// For each requested virtual CPU, CPUAllocationRatio defines how much physical CPU to request per VMI
    /// from the hosting node. The value is in fraction of a CPU thread (or core on non-hyperthreaded nodes).
    /// For example, a value of 1 means 1 physical CPU thread per VMI CPU thread.
    /// A value of 100 would be 1% of a physical thread allocated for each requested VMI thread.
    /// This option has no effect on VMIs that request dedicated CPUs. More information at:
    /// https://kubevirt.io/user-guide/operations/node_overcommit/#node-cpu-allocation-ratio
    /// Defaults to 10
    /// </summary>
    [JsonPropertyName("cpuAllocationRatio")]
    public int? CpuAllocationRatio { get; set; }

    /// <summary>
    /// DisabledFeatureGates specifies a list of experimental feature gates to disable.
    /// A feature gate must not appear in both FeatureGates and DisabledFeatureGates.
    /// </summary>
    [JsonPropertyName("disabledFeatureGates")]
    public IList<string>? DisabledFeatureGates { get; set; }

    /// <summary>DiskVerification holds container disks verification limits</summary>
    [JsonPropertyName("diskVerification")]
    public V1alpha3KubeVirtSpecConfigurationDeveloperConfigurationDiskVerification? DiskVerification { get; set; }

    /// <summary>
    /// FeatureGates specifies a list of experimental feature gates to enable. Defaults to none.
    /// A feature gate must not appear in both FeatureGates and DisabledFeatureGates.
    /// </summary>
    [JsonPropertyName("featureGates")]
    public IList<string>? FeatureGates { get; set; }

    /// <summary>LogVerbosity sets log verbosity level of  various components</summary>
    [JsonPropertyName("logVerbosity")]
    public V1alpha3KubeVirtSpecConfigurationDeveloperConfigurationLogVerbosity? LogVerbosity { get; set; }

    /// <summary>
    /// MemoryOvercommit is the percentage of memory we want to give VMIs compared to the amount
    /// given to its parent pod (virt-launcher). For example, a value of 102 means the VMI will
    /// &quot;see&quot; 2% more memory than its parent pod. Values under 100 are effectively &quot;undercommits&quot;.
    /// Overcommits can lead to memory exhaustion, which in turn can lead to crashes. Use carefully.
    /// Defaults to 100
    /// </summary>
    [JsonPropertyName("memoryOvercommit")]
    public int? MemoryOvercommit { get; set; }

    /// <summary>
    /// Allow overriding the automatically determined minimum TSC frequency of the cluster
    /// and fixate the minimum to this frequency.
    /// </summary>
    [JsonPropertyName("minimumClusterTSCFrequency")]
    public long? MinimumClusterTSCFrequency { get; set; }

    /// <summary>
    /// MinimumReservePVCBytes is the amount of space, in bytes, to leave unused on disks.
    /// Defaults to 131072 (128KiB)
    /// </summary>
    [JsonPropertyName("minimumReservePVCBytes")]
    public long? MinimumReservePVCBytes { get; set; }

    /// <summary>
    /// NodeSelectors allows restricting VMI creation to nodes that match a set of labels.
    /// Defaults to none
    /// </summary>
    [JsonPropertyName("nodeSelectors")]
    public IDictionary<string, string>? NodeSelectors { get; set; }

    /// <summary>
    /// LessPVCSpaceToleration determines how much smaller, in percentage, disk PVCs are
    /// allowed to be compared to the requested size (to account for various overheads).
    /// Defaults to 10
    /// </summary>
    [JsonPropertyName("pvcTolerateLessSpaceUpToPercent")]
    public int? PvcTolerateLessSpaceUpToPercent { get; set; }

    /// <summary>
    /// UseEmulation can be set to true to allow fallback to software emulation
    /// in case hardware-assisted emulation is not available. Defaults to false
    /// </summary>
    [JsonPropertyName("useEmulation")]
    public bool? UseEmulation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>
    /// Maximum burst for throttle.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("burst")]
    public required int Burst { get; set; }

    /// <summary>
    /// QPS indicates the maximum QPS to the apiserver from this client.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("qps")]
    public required double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiter
{
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationHandlerConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>
/// ReloadableComponentConfiguration holds all generic k8s configuration options which can
/// be reloaded by components without requiring a restart.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationHandlerConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1alpha3KubeVirtSpecConfigurationHandlerConfigurationRestClient? RestClient { get; set; }
}

/// <summary>
/// Name is the name of the hypervisor.
/// Supported values are: &quot;kvm&quot;, &quot;hyperv-direct&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3KubeVirtSpecConfigurationHypervisorsNameEnum>))]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public enum V1alpha3KubeVirtSpecConfigurationHypervisorsNameEnum
{
    [EnumMember(Value = "kvm"), JsonStringEnumMemberName("kvm")]
    Kvm,
    [EnumMember(Value = "hyperv-direct"), JsonStringEnumMemberName("hyperv-direct")]
    HypervDirect
}

/// <summary>HypervisorConfiguration holds information regarding the hypervisor present on cluster nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationHypervisors
{
    /// <summary>
    /// Name is the name of the hypervisor.
    /// Supported values are: &quot;kvm&quot;, &quot;hyperv-direct&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public V1alpha3KubeVirtSpecConfigurationHypervisorsNameEnum? Name { get; set; }
}

/// <summary>
/// ReferencePolicy defines how an instance type or preference should be referenced by the VM after submission, supported values are:
/// reference (default) - Where a copy of the original object is stashed in a ControllerRevision and referenced by the VM.
/// expand - Where the instance type or preference are expanded into the VM if no revisionNames have been populated.
/// expandAll - Where the instance type or preference are expanded into the VM regardless of revisionNames previously being populated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3KubeVirtSpecConfigurationInstancetypeReferencePolicyEnum>))]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public enum V1alpha3KubeVirtSpecConfigurationInstancetypeReferencePolicyEnum
{
    [EnumMember(Value = "reference"), JsonStringEnumMemberName("reference")]
    Reference,
    [EnumMember(Value = "expand"), JsonStringEnumMemberName("expand")]
    Expand,
    [EnumMember(Value = "expandAll"), JsonStringEnumMemberName("expandAll")]
    ExpandAll
}

/// <summary>Instancetype configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationInstancetype
{
    /// <summary>
    /// ReferencePolicy defines how an instance type or preference should be referenced by the VM after submission, supported values are:
    /// reference (default) - Where a copy of the original object is stashed in a ControllerRevision and referenced by the VM.
    /// expand - Where the instance type or preference are expanded into the VM if no revisionNames have been populated.
    /// expandAll - Where the instance type or preference are expanded into the VM regardless of revisionNames previously being populated.
    /// </summary>
    [JsonPropertyName("referencePolicy")]
    public V1alpha3KubeVirtSpecConfigurationInstancetypeReferencePolicyEnum? ReferencePolicy { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NodeLabelSelector is a selector that filters in which nodes the KSM will be enabled.
/// Empty NodeLabelSelector will enable ksm for every node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>KSMConfiguration holds the information regarding the enabling the KSM in the nodes (if available).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationKsmConfiguration
{
    /// <summary>
    /// NodeLabelSelector is a selector that filters in which nodes the KSM will be enabled.
    /// Empty NodeLabelSelector will enable ksm for every node.
    /// </summary>
    [JsonPropertyName("nodeLabelSelector")]
    public V1alpha3KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelector? NodeLabelSelector { get; set; }
}

/// <summary>LiveUpdateConfiguration holds defaults for live update features</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationLiveUpdateConfiguration
{
    /// <summary>
    /// MaxCpuSockets provides a MaxSockets value for VMs that do not provide their own.
    /// For VMs with more sockets than maximum the MaxSockets will be set to equal number of sockets.
    /// </summary>
    [JsonPropertyName("maxCpuSockets")]
    public int? MaxCpuSockets { get; set; }

    /// <summary>
    /// MaxGuest defines the maximum amount memory that can be allocated
    /// to the guest using hotplug.
    /// </summary>
    [JsonPropertyName("maxGuest")]
    public IntOrString? MaxGuest { get; set; }

    /// <summary>
    /// MaxHotplugRatio is the ratio used to define the max amount
    /// of a hotplug resource that can be made available to a VM
    /// when the specific Max* setting is not defined (MaxCpuSockets, MaxGuest)
    /// Example: VM is configured with 512Mi of guest memory, if MaxGuest is not
    /// defined and MaxHotplugRatio is 2 then MaxGuest = 1Gi
    /// defaults to 4
    /// </summary>
    [JsonPropertyName("maxHotplugRatio")]
    public int? MaxHotplugRatio { get; set; }
}

/// <summary>NodeMediatedDeviceTypesConfig holds information about MDEV types to be defined in a specific node that matches the NodeSelector field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationMediatedDevicesConfigurationNodeMediatedDeviceTypes
{
    [JsonPropertyName("mediatedDeviceTypes")]
    public IList<string>? MediatedDeviceTypes { get; set; }

    /// <summary>Deprecated. Use mediatedDeviceTypes instead.</summary>
    [JsonPropertyName("mediatedDevicesTypes")]
    public IList<string>? MediatedDevicesTypes { get; set; }

    /// <summary>
    /// NodeSelector is a selector which must be true for the vmi to fit on a node.
    /// Selector which must match a node&apos;s labels for the vmi to be scheduled on that node.
    /// More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public required IDictionary<string, string> NodeSelector { get; set; }
}

/// <summary>MediatedDevicesConfiguration holds information about MDEV types to be defined, if available</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationMediatedDevicesConfiguration
{
    /// <summary>
    /// Enable the creation and removal of mediated devices by virt-handler
    /// Replaces the deprecated DisableMDEVConfiguration feature gate
    /// Defaults to true
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("mediatedDeviceTypes")]
    public IList<string>? MediatedDeviceTypes { get; set; }

    /// <summary>Deprecated. Use mediatedDeviceTypes instead.</summary>
    [JsonPropertyName("mediatedDevicesTypes")]
    public IList<string>? MediatedDevicesTypes { get; set; }

    [JsonPropertyName("nodeMediatedDeviceTypes")]
    public IList<V1alpha3KubeVirtSpecConfigurationMediatedDevicesConfigurationNodeMediatedDeviceTypes>? NodeMediatedDeviceTypes { get; set; }
}

/// <summary>
/// MigrationConfiguration holds migration options.
/// Can be overridden for specific groups of VMs though migration policies.
/// Visit https://kubevirt.io/user-guide/operations/migration_policies/ for more information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationMigrations
{
    /// <summary>
    /// AllowAutoConverge allows the platform to compromise performance/availability of VMIs to
    /// guarantee successful VMI live migrations. Defaults to false
    /// </summary>
    [JsonPropertyName("allowAutoConverge")]
    public bool? AllowAutoConverge { get; set; }

    /// <summary>
    /// AllowPostCopy enables post-copy live migrations. Such migrations allow even the busiest VMIs
    /// to successfully live-migrate. However, events like a network failure can cause a VMI crash.
    /// If set to true, migrations will still start in pre-copy, but switch to post-copy when
    /// CompletionTimeoutPerGiB triggers. Defaults to false
    /// </summary>
    [JsonPropertyName("allowPostCopy")]
    public bool? AllowPostCopy { get; set; }

    /// <summary>
    /// AllowWorkloadDisruption indicates that the migration shouldn&apos;t be
    /// canceled after acceptableCompletionTime is exceeded. Instead, if
    /// permitted, migration will be switched to post-copy or the VMI will be
    /// paused to allow the migration to complete
    /// </summary>
    [JsonPropertyName("allowWorkloadDisruption")]
    public bool? AllowWorkloadDisruption { get; set; }

    /// <summary>
    /// BandwidthPerMigration limits the amount of network bandwidth live migrations are allowed to use.
    /// The value is in quantity per second. Defaults to 0 (no limit)
    /// </summary>
    [JsonPropertyName("bandwidthPerMigration")]
    public IntOrString? BandwidthPerMigration { get; set; }

    /// <summary>
    /// CompletionTimeoutPerGiB is the maximum number of seconds per GiB a migration is allowed to take.
    /// If the timeout is reached, the migration will be either paused, switched
    /// to post-copy or cancelled depending on other settings. Defaults to 150
    /// </summary>
    [JsonPropertyName("completionTimeoutPerGiB")]
    public long? CompletionTimeoutPerGiB { get; set; }

    /// <summary>
    /// When set to true, DisableTLS will disable the additional layer of live migration encryption
    /// provided by KubeVirt. This is usually a bad idea. Defaults to false
    /// </summary>
    [JsonPropertyName("disableTLS")]
    public bool? DisableTLS { get; set; }

    /// <summary>
    /// By default, the SELinux level of target virt-launcher pods is forced to the level of the source virt-launcher.
    /// When set to true, MatchSELinuxLevelOnMigration lets the CRI auto-assign a random level to the target.
    /// That will ensure the target virt-launcher doesn&apos;t share categories with another pod on the node.
    /// However, migrations will fail when using RWX volumes that don&apos;t automatically deal with SELinux levels.
    /// </summary>
    [JsonPropertyName("matchSELinuxLevelOnMigration")]
    public bool? MatchSELinuxLevelOnMigration { get; set; }

    /// <summary>
    /// Network is the name of the CNI network to use for live migrations. By default, migrations go
    /// through the pod network.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// NodeDrainTaintKey defines the taint key that indicates a node should be drained.
    /// Note: this option relies on the deprecated node taint feature. Default: kubevirt.io/drain
    /// </summary>
    [JsonPropertyName("nodeDrainTaintKey")]
    public string? NodeDrainTaintKey { get; set; }

    /// <summary>
    /// ParallelMigrationsPerCluster is the total number of concurrent live migrations
    /// allowed cluster-wide. Defaults to 5
    /// </summary>
    [JsonPropertyName("parallelMigrationsPerCluster")]
    public int? ParallelMigrationsPerCluster { get; set; }

    /// <summary>
    /// ParallelOutboundMigrationsPerNode is the maximum number of concurrent outgoing live migrations
    /// allowed per node. Defaults to 2
    /// </summary>
    [JsonPropertyName("parallelOutboundMigrationsPerNode")]
    public int? ParallelOutboundMigrationsPerNode { get; set; }

    /// <summary>
    /// ProgressTimeout is the maximum number of seconds a live migration is allowed to make no progress.
    /// Hitting this timeout means a migration transferred 0 data for that many seconds. The migration is
    /// then considered stuck and therefore cancelled. Defaults to 150
    /// </summary>
    [JsonPropertyName("progressTimeout")]
    public long? ProgressTimeout { get; set; }

    /// <summary>
    /// UnsafeMigrationOverride allows live migrations to occur even if the compatibility check
    /// indicates the migration will be unsafe to the guest. Defaults to false
    /// </summary>
    [JsonPropertyName("unsafeMigrationOverride")]
    public bool? UnsafeMigrationOverride { get; set; }

    /// <summary>
    /// UtilityVolumesTimeout is the maximum number of seconds a migration can wait in Pending state
    /// for utility volumes to be detached. If utility volumes are still present after this timeout,
    /// the migration will be marked as Failed. Defaults to 150
    /// </summary>
    [JsonPropertyName("utilityVolumesTimeout")]
    public long? UtilityVolumesTimeout { get; set; }
}

/// <summary>
/// ComputeResourceOverhead specifies the resource overhead that should be added to the compute container when using the binding.
/// version: v1alphav1
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationNetworkBindingComputeResourceOverhead
{
    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
    /// otherwise to an implementation-defined value. Requests cannot exceed Limits.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>
/// Migration means the VM using the plugin can be safely migrated
/// version: 1alphav1
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationNetworkBindingMigration
{
    /// <summary>
    /// Method defines a pre-defined migration methodology
    /// version: 1alphav1
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationNetworkBinding
{
    /// <summary>
    /// ComputeResourceOverhead specifies the resource overhead that should be added to the compute container when using the binding.
    /// version: v1alphav1
    /// </summary>
    [JsonPropertyName("computeResourceOverhead")]
    public V1alpha3KubeVirtSpecConfigurationNetworkBindingComputeResourceOverhead? ComputeResourceOverhead { get; set; }

    /// <summary>
    /// DomainAttachmentType is a standard domain network attachment method kubevirt supports.
    /// Supported values: &quot;tap&quot;, &quot;managedTap&quot; (since v1.4).
    /// The standard domain attachment can be used instead or in addition to the sidecarImage.
    /// version: 1alphav1
    /// </summary>
    [JsonPropertyName("domainAttachmentType")]
    public string? DomainAttachmentType { get; set; }

    /// <summary>
    /// DownwardAPI specifies what kind of data should be exposed to the binding plugin sidecar.
    /// Supported values: &quot;device-info&quot;
    /// version: v1alphav1
    /// </summary>
    [JsonPropertyName("downwardAPI")]
    public string? DownwardAPI { get; set; }

    /// <summary>
    /// Migration means the VM using the plugin can be safely migrated
    /// version: 1alphav1
    /// </summary>
    [JsonPropertyName("migration")]
    public V1alpha3KubeVirtSpecConfigurationNetworkBindingMigration? Migration { get; set; }

    /// <summary>
    /// NetworkAttachmentDefinition references to a NetworkAttachmentDefinition CR object.
    /// Format: &lt;name&gt;, &lt;namespace&gt;/&lt;name&gt;.
    /// If namespace is not specified, VMI namespace is assumed.
    /// version: 1alphav1
    /// </summary>
    [JsonPropertyName("networkAttachmentDefinition")]
    public string? NetworkAttachmentDefinition { get; set; }

    /// <summary>
    /// SidecarImage references a container image that runs in the virt-launcher pod.
    /// The sidecar handles (libvirt) domain configuration and optional services.
    /// version: 1alphav1
    /// </summary>
    [JsonPropertyName("sidecarImage")]
    public string? SidecarImage { get; set; }
}

/// <summary>NetworkConfiguration holds network options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationNetwork
{
    [JsonPropertyName("binding")]
    public IDictionary<string, V1alpha3KubeVirtSpecConfigurationNetworkBinding>? Binding { get; set; }

    [JsonPropertyName("defaultNetworkInterface")]
    public string? DefaultNetworkInterface { get; set; }

    [JsonPropertyName("permitBridgeInterfaceOnPodNetwork")]
    public bool? PermitBridgeInterfaceOnPodNetwork { get; set; }

    /// <summary>
    /// DeprecatedPermitSlirpInterface is an alias for the deprecated PermitSlirpInterface.
    /// Deprecated: Removed in v1.3.
    /// </summary>
    [JsonPropertyName("permitSlirpInterface")]
    public bool? PermitSlirpInterface { get; set; }
}

/// <summary>MediatedHostDevice represents a host mediated device allowed for passthrough</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesMediatedDevices
{
    [JsonPropertyName("externalResourceProvider")]
    public bool? ExternalResourceProvider { get; set; }

    [JsonPropertyName("mdevNameSelector")]
    public required string MdevNameSelector { get; set; }

    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }
}

/// <summary>PciHostDevice represents a host PCI device allowed for passthrough</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesPciHostDevices
{
    /// <summary>
    /// If true, KubeVirt will leave the allocation and monitoring to an
    /// external device plugin
    /// </summary>
    [JsonPropertyName("externalResourceProvider")]
    public bool? ExternalResourceProvider { get; set; }

    /// <summary>The vendor_id:product_id tuple of the PCI device</summary>
    [JsonPropertyName("pciVendorSelector")]
    public required string PciVendorSelector { get; set; }

    /// <summary>
    /// The name of the resource that is representing the device. Exposed by
    /// a device plugin and requested by VMs. Typically of the form
    /// vendor.com/product_name
    /// </summary>
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesUsbSelectors
{
    [JsonPropertyName("product")]
    public required string Product { get; set; }

    [JsonPropertyName("vendor")]
    public required string Vendor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesUsb
{
    /// <summary>
    /// If true, KubeVirt will leave the allocation and monitoring to an
    /// external device plugin
    /// </summary>
    [JsonPropertyName("externalResourceProvider")]
    public bool? ExternalResourceProvider { get; set; }

    /// <summary>
    /// Identifies the list of USB host devices.
    /// e.g: kubevirt.io/storage, kubevirt.io/bootable-usb, etc
    /// </summary>
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("selectors")]
    public IList<V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesUsbSelectors>? Selectors { get; set; }
}

/// <summary>PermittedHostDevices holds information about devices allowed for passthrough</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationPermittedHostDevices
{
    [JsonPropertyName("mediatedDevices")]
    public IList<V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesMediatedDevices>? MediatedDevices { get; set; }

    [JsonPropertyName("pciHostDevices")]
    public IList<V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesPciHostDevices>? PciHostDevices { get; set; }

    [JsonPropertyName("usb")]
    public IList<V1alpha3KubeVirtSpecConfigurationPermittedHostDevicesUsb>? Usb { get; set; }
}

/// <summary>
/// RoleAggregationStrategy controls whether RBAC cluster roles should be aggregated
/// to the default Kubernetes roles (admin, edit, view).
/// When set to &quot;AggregateToDefault&quot; (default) or not specified, the aggregate-to-* labels are added to the cluster roles.
/// When set to &quot;Manual&quot;, the labels are not added, and roles will not be aggregated to the default roles.
/// Setting this field to &quot;Manual&quot; requires the OptOutRoleAggregation feature gate to be enabled.
/// This is an Alpha feature and subject to change.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3KubeVirtSpecConfigurationRoleAggregationStrategyEnum>))]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public enum V1alpha3KubeVirtSpecConfigurationRoleAggregationStrategyEnum
{
    [EnumMember(Value = "AggregateToDefault"), JsonStringEnumMemberName("AggregateToDefault")]
    AggregateToDefault,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>CustomProfile allows to request arbitrary profile for virt-launcher</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfileCustomProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("runtimeDefaultProfile")]
    public bool? RuntimeDefaultProfile { get; set; }
}

/// <summary>VirtualMachineInstanceProfile defines what profile should be used with virt-launcher. Defaults to none</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfile
{
    /// <summary>CustomProfile allows to request arbitrary profile for virt-launcher</summary>
    [JsonPropertyName("customProfile")]
    public V1alpha3KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfileCustomProfile? CustomProfile { get; set; }
}

/// <summary>SeccompConfiguration holds Seccomp configuration for Kubevirt components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationSeccompConfiguration
{
    /// <summary>VirtualMachineInstanceProfile defines what profile should be used with virt-launcher. Defaults to none</summary>
    [JsonPropertyName("virtualMachineInstanceProfile")]
    public V1alpha3KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfile? VirtualMachineInstanceProfile { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationSmbios
{
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    [JsonPropertyName("product")]
    public string? Product { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// ResourceRequirementsWithoutClaims describes the compute resource requirements.
/// This struct was taken from the k8s.ResourceRequirements and cleaned up the &apos;Claims&apos; field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationSupportContainerResourcesResources
{
    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
    /// otherwise to an implementation-defined value. Requests cannot exceed Limits.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>SupportContainerResources are used to specify the cpu/memory request and limits for the containers that support various features of Virtual Machines. These containers are usually idle and don&apos;t require a lot of memory or cpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationSupportContainerResources
{
    /// <summary>
    /// ResourceRequirementsWithoutClaims describes the compute resource requirements.
    /// This struct was taken from the k8s.ResourceRequirements and cleaned up the &apos;Claims&apos; field.
    /// </summary>
    [JsonPropertyName("resources")]
    public required V1alpha3KubeVirtSpecConfigurationSupportContainerResourcesResources Resources { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// MinTLSVersion is a way to specify the minimum protocol version that is acceptable for TLS connections.
/// Protocol versions are based on the following most common TLS configurations:
/// 
///   https://ssl-config.mozilla.org/
/// 
/// Note that SSLv3.0 is not a supported protocol version due to well known
/// vulnerabilities such as POODLE: https://en.wikipedia.org/wiki/POODLE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3KubeVirtSpecConfigurationTlsConfigurationMinTLSVersionEnum>))]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public enum V1alpha3KubeVirtSpecConfigurationTlsConfigurationMinTLSVersionEnum
{
    [EnumMember(Value = "VersionTLS10"), JsonStringEnumMemberName("VersionTLS10")]
    VersionTLS10,
    [EnumMember(Value = "VersionTLS11"), JsonStringEnumMemberName("VersionTLS11")]
    VersionTLS11,
    [EnumMember(Value = "VersionTLS12"), JsonStringEnumMemberName("VersionTLS12")]
    VersionTLS12,
    [EnumMember(Value = "VersionTLS13"), JsonStringEnumMemberName("VersionTLS13")]
    VersionTLS13
}

/// <summary>TLSConfiguration holds TLS options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationTlsConfiguration
{
    [JsonPropertyName("ciphers")]
    public IList<string>? Ciphers { get; set; }

    /// <summary>
    /// MinTLSVersion is a way to specify the minimum protocol version that is acceptable for TLS connections.
    /// Protocol versions are based on the following most common TLS configurations:
    /// 
    ///   https://ssl-config.mozilla.org/
    /// 
    /// Note that SSLv3.0 is not a supported protocol version due to well known
    /// vulnerabilities such as POODLE: https://en.wikipedia.org/wiki/POODLE
    /// </summary>
    [JsonPropertyName("minTLSVersion")]
    public V1alpha3KubeVirtSpecConfigurationTlsConfigurationMinTLSVersionEnum? MinTLSVersion { get; set; }
}

/// <summary>VirtTemplateDeployment controls the deployment of virt-template components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationVirtTemplateDeployment
{
    /// <summary>Enabled controls the deployment of virt-template resources, defaults to True when feature gate is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// DisableFreePageReporting disable the free page reporting of
/// memory balloon device https://libvirt.org/formatdomain.html#memory-balloon-device.
/// This will have effect only if AutoattachMemBalloon is not false and the vmi is not
/// requesting any high performance feature (dedicatedCPU/realtime/hugePages), in which free page reporting is always disabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationVirtualMachineOptionsDisableFreePageReporting
{
}

/// <summary>
/// DisableSerialConsoleLog disables logging the auto-attached default serial console.
/// If not set, serial console logs will be written to a file and then streamed from a container named &apos;guest-console-log&apos;.
/// The value can be individually overridden for each VM, not relevant if AutoattachSerialConsole is disabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationVirtualMachineOptionsDisableSerialConsoleLog
{
}

/// <summary>VirtualMachineOptions holds the cluster level information regarding the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationVirtualMachineOptions
{
    /// <summary>
    /// DisableFreePageReporting disable the free page reporting of
    /// memory balloon device https://libvirt.org/formatdomain.html#memory-balloon-device.
    /// This will have effect only if AutoattachMemBalloon is not false and the vmi is not
    /// requesting any high performance feature (dedicatedCPU/realtime/hugePages), in which free page reporting is always disabled.
    /// </summary>
    [JsonPropertyName("disableFreePageReporting")]
    public V1alpha3KubeVirtSpecConfigurationVirtualMachineOptionsDisableFreePageReporting? DisableFreePageReporting { get; set; }

    /// <summary>
    /// DisableSerialConsoleLog disables logging the auto-attached default serial console.
    /// If not set, serial console logs will be written to a file and then streamed from a container named &apos;guest-console-log&apos;.
    /// The value can be individually overridden for each VM, not relevant if AutoattachSerialConsole is disabled.
    /// </summary>
    [JsonPropertyName("disableSerialConsoleLog")]
    public V1alpha3KubeVirtSpecConfigurationVirtualMachineOptionsDisableSerialConsoleLog? DisableSerialConsoleLog { get; set; }
}

/// <summary>
/// VMRolloutStrategy defines how live-updatable fields, like CPU sockets, memory,
/// tolerations, and affinity, are propagated from a VM to its VMI.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3KubeVirtSpecConfigurationVmRolloutStrategyEnum>))]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public enum V1alpha3KubeVirtSpecConfigurationVmRolloutStrategyEnum
{
    [EnumMember(Value = "Stage"), JsonStringEnumMemberName("Stage")]
    Stage,
    [EnumMember(Value = "LiveUpdate"), JsonStringEnumMemberName("LiveUpdate")]
    LiveUpdate
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>
    /// Maximum burst for throttle.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("burst")]
    public required int Burst { get; set; }

    /// <summary>
    /// QPS indicates the maximum QPS to the apiserver from this client.
    /// If it&apos;s zero, the component default will be used
    /// </summary>
    [JsonPropertyName("qps")]
    public required double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiter
{
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationWebhookConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1alpha3KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>
/// ReloadableComponentConfiguration holds all generic k8s configuration options which can
/// be reloaded by components without requiring a restart.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfigurationWebhookConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1alpha3KubeVirtSpecConfigurationWebhookConfigurationRestClient? RestClient { get; set; }
}

/// <summary>
/// holds kubevirt configurations.
/// same as the virt-configMap
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecConfiguration
{
    /// <summary>
    /// AdditionalGuestMemoryOverheadRatio can be used to increase the virtualization infrastructure
    /// overhead. This is useful, since the calculation of this overhead is not accurate and cannot
    /// be entirely known in advance. The ratio that is being set determines by which factor to increase
    /// the overhead calculated by Kubevirt. A higher ratio means that the VMs would be less compromised
    /// by node pressures, but would mean that fewer VMs could be scheduled to a node.
    /// If not set, the default is 1.
    /// </summary>
    [JsonPropertyName("additionalGuestMemoryOverheadRatio")]
    public string? AdditionalGuestMemoryOverheadRatio { get; set; }

    /// <summary>
    /// ReloadableComponentConfiguration holds all generic k8s configuration options which can
    /// be reloaded by components without requiring a restart.
    /// </summary>
    [JsonPropertyName("apiConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationApiConfiguration? ApiConfiguration { get; set; }

    [JsonPropertyName("architectureConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationArchitectureConfiguration? ArchitectureConfiguration { get; set; }

    /// <summary>
    /// When set, AutoCPULimitNamespaceLabelSelector will set a CPU limit on virt-launcher for VMIs running inside
    /// namespaces that match the label selector.
    /// The CPU limit will equal the number of requested vCPUs.
    /// This setting does not apply to VMIs with dedicated CPUs.
    /// </summary>
    [JsonPropertyName("autoCPULimitNamespaceLabelSelector")]
    public V1alpha3KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelector? AutoCPULimitNamespaceLabelSelector { get; set; }

    /// <summary>
    /// ChangedBlockTrackingLabelSelectors defines label selectors. VMs matching these selectors will have changed block tracking enabled.
    /// Enabling changedBlockTracking is mandatory for performing storage-agnostic backups and incremental backups.
    /// </summary>
    [JsonPropertyName("changedBlockTrackingLabelSelectors")]
    public V1alpha3KubeVirtSpecConfigurationChangedBlockTrackingLabelSelectors? ChangedBlockTrackingLabelSelectors { get; set; }

    /// <summary>CommonInstancetypesDeployment controls the deployment of common-instancetypes resources</summary>
    [JsonPropertyName("commonInstancetypesDeployment")]
    public V1alpha3KubeVirtSpecConfigurationCommonInstancetypesDeployment? CommonInstancetypesDeployment { get; set; }

    /// <summary>
    /// ReloadableComponentConfiguration holds all generic k8s configuration options which can
    /// be reloaded by components without requiring a restart.
    /// </summary>
    [JsonPropertyName("controllerConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationControllerConfiguration? ControllerConfiguration { get; set; }

    [JsonPropertyName("cpuModel")]
    public string? CpuModel { get; set; }

    [JsonPropertyName("cpuRequest")]
    public IntOrString? CpuRequest { get; set; }

    [JsonPropertyName("defaultRuntimeClass")]
    public string? DefaultRuntimeClass { get; set; }

    /// <summary>DeveloperConfiguration holds developer options</summary>
    [JsonPropertyName("developerConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationDeveloperConfiguration? DeveloperConfiguration { get; set; }

    /// <summary>Deprecated. Use architectureConfiguration instead.</summary>
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    /// <summary>
    /// EvictionStrategy defines at the cluster level if the VirtualMachineInstance should be
    /// migrated instead of shut-off in case of a node drain. If the VirtualMachineInstance specific
    /// field is set it overrides the cluster level one.
    /// </summary>
    [JsonPropertyName("evictionStrategy")]
    public string? EvictionStrategy { get; set; }

    /// <summary>
    /// ReloadableComponentConfiguration holds all generic k8s configuration options which can
    /// be reloaded by components without requiring a restart.
    /// </summary>
    [JsonPropertyName("handlerConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationHandlerConfiguration? HandlerConfiguration { get; set; }

    /// <summary>Hypervisors holds information regarding the hypervisor configurations supported on this cluster.</summary>
    [JsonPropertyName("hypervisors")]
    public IList<V1alpha3KubeVirtSpecConfigurationHypervisors>? Hypervisors { get; set; }

    /// <summary>PullPolicy describes a policy for if/when to pull a container image</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Instancetype configuration</summary>
    [JsonPropertyName("instancetype")]
    public V1alpha3KubeVirtSpecConfigurationInstancetype? Instancetype { get; set; }

    /// <summary>KSMConfiguration holds the information regarding the enabling the KSM in the nodes (if available).</summary>
    [JsonPropertyName("ksmConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationKsmConfiguration? KsmConfiguration { get; set; }

    /// <summary>LiveUpdateConfiguration holds defaults for live update features</summary>
    [JsonPropertyName("liveUpdateConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationLiveUpdateConfiguration? LiveUpdateConfiguration { get; set; }

    /// <summary>Deprecated. Use architectureConfiguration instead.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>MediatedDevicesConfiguration holds information about MDEV types to be defined, if available</summary>
    [JsonPropertyName("mediatedDevicesConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationMediatedDevicesConfiguration? MediatedDevicesConfiguration { get; set; }

    [JsonPropertyName("memBalloonStatsPeriod")]
    public int? MemBalloonStatsPeriod { get; set; }

    /// <summary>
    /// MigrationConfiguration holds migration options.
    /// Can be overridden for specific groups of VMs though migration policies.
    /// Visit https://kubevirt.io/user-guide/operations/migration_policies/ for more information.
    /// </summary>
    [JsonPropertyName("migrations")]
    public V1alpha3KubeVirtSpecConfigurationMigrations? Migrations { get; set; }

    /// <summary>deprecated</summary>
    [JsonPropertyName("minCPUModel")]
    public string? MinCPUModel { get; set; }

    /// <summary>NetworkConfiguration holds network options</summary>
    [JsonPropertyName("network")]
    public V1alpha3KubeVirtSpecConfigurationNetwork? Network { get; set; }

    [JsonPropertyName("obsoleteCPUModels")]
    public IDictionary<string, bool>? ObsoleteCPUModels { get; set; }

    /// <summary>Deprecated. Use architectureConfiguration instead.</summary>
    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }

    /// <summary>PermittedHostDevices holds information about devices allowed for passthrough</summary>
    [JsonPropertyName("permittedHostDevices")]
    public V1alpha3KubeVirtSpecConfigurationPermittedHostDevices? PermittedHostDevices { get; set; }

    /// <summary>
    /// RoleAggregationStrategy controls whether RBAC cluster roles should be aggregated
    /// to the default Kubernetes roles (admin, edit, view).
    /// When set to &quot;AggregateToDefault&quot; (default) or not specified, the aggregate-to-* labels are added to the cluster roles.
    /// When set to &quot;Manual&quot;, the labels are not added, and roles will not be aggregated to the default roles.
    /// Setting this field to &quot;Manual&quot; requires the OptOutRoleAggregation feature gate to be enabled.
    /// This is an Alpha feature and subject to change.
    /// </summary>
    [JsonPropertyName("roleAggregationStrategy")]
    public V1alpha3KubeVirtSpecConfigurationRoleAggregationStrategyEnum? RoleAggregationStrategy { get; set; }

    /// <summary>SeccompConfiguration holds Seccomp configuration for Kubevirt components</summary>
    [JsonPropertyName("seccompConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationSeccompConfiguration? SeccompConfiguration { get; set; }

    [JsonPropertyName("selinuxLauncherType")]
    public string? SelinuxLauncherType { get; set; }

    [JsonPropertyName("smbios")]
    public V1alpha3KubeVirtSpecConfigurationSmbios? Smbios { get; set; }

    /// <summary>SupportContainerResources specifies the resource requirements for various types of supporting containers such as container disks/virtiofs/sidecars and hotplug attachment pods. If omitted a sensible default will be supplied.</summary>
    [JsonPropertyName("supportContainerResources")]
    public IList<V1alpha3KubeVirtSpecConfigurationSupportContainerResources>? SupportContainerResources { get; set; }

    /// <summary>deprecated</summary>
    [JsonPropertyName("supportedGuestAgentVersions")]
    public IList<string>? SupportedGuestAgentVersions { get; set; }

    /// <summary>TLSConfiguration holds TLS options</summary>
    [JsonPropertyName("tlsConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationTlsConfiguration? TlsConfiguration { get; set; }

    /// <summary>VirtTemplateDeployment controls the deployment of virt-template components</summary>
    [JsonPropertyName("virtTemplateDeployment")]
    public V1alpha3KubeVirtSpecConfigurationVirtTemplateDeployment? VirtTemplateDeployment { get; set; }

    [JsonPropertyName("virtualMachineInstancesPerNode")]
    public int? VirtualMachineInstancesPerNode { get; set; }

    /// <summary>VirtualMachineOptions holds the cluster level information regarding the virtual machine.</summary>
    [JsonPropertyName("virtualMachineOptions")]
    public V1alpha3KubeVirtSpecConfigurationVirtualMachineOptions? VirtualMachineOptions { get; set; }

    /// <summary>
    /// VMRolloutStrategy defines how live-updatable fields, like CPU sockets, memory,
    /// tolerations, and affinity, are propagated from a VM to its VMI.
    /// </summary>
    [JsonPropertyName("vmRolloutStrategy")]
    public V1alpha3KubeVirtSpecConfigurationVmRolloutStrategyEnum? VmRolloutStrategy { get; set; }

    /// <summary>VMStateStorageClass is the name of the storage class to use for the PVCs created to preserve VM state, like TPM.</summary>
    [JsonPropertyName("vmStateStorageClass")]
    public string? VmStateStorageClass { get; set; }

    /// <summary>
    /// ReloadableComponentConfiguration holds all generic k8s configuration options which can
    /// be reloaded by components without requiring a restart.
    /// </summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1alpha3KubeVirtSpecConfigurationWebhookConfiguration? WebhookConfiguration { get; set; }
}

/// <summary>Configure the value used for deployment and daemonset resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecCustomizeComponentsFlags
{
    [JsonPropertyName("api")]
    public IDictionary<string, string>? Api { get; set; }

    [JsonPropertyName("controller")]
    public IDictionary<string, string>? Controller { get; set; }

    [JsonPropertyName("handler")]
    public IDictionary<string, string>? Handler { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecCustomizeComponentsPatches
{
    [JsonPropertyName("patch")]
    public required string Patch { get; set; }

    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("resourceType")]
    public required string ResourceType { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecCustomizeComponents
{
    /// <summary>Configure the value used for deployment and daemonset resources</summary>
    [JsonPropertyName("flags")]
    public V1alpha3KubeVirtSpecCustomizeComponentsFlags? Flags { get; set; }

    [JsonPropertyName("patches")]
    public IList<V1alpha3KubeVirtSpecCustomizeComponentsPatches>? Patches { get; set; }
}

/// <summary>
/// LocalObjectReference contains enough information to let you locate the
/// referenced object inside the same namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecImagePullSecrets
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A null or empty node selector term matches no objects. The requirements of
/// them are ANDed.
/// The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// If the affinity requirements specified by this field are not met at
/// scheduling time, the pod will not be scheduled onto the node.
/// If the affinity requirements specified by this field cease to be met
/// at some point during pod execution (e.g. due to an update), the system
/// may or may not try to eventually evict the pod from its node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node matches the corresponding matchExpressions; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the anti-affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling anti-affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and subtracting
    /// &quot;weight&quot; from the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the anti-affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the anti-affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// affinity enables pod affinity/anti-affinity placement expanding the types of constraints
/// that can be expressed with nodeSelector.
/// affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector
/// See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacementTolerations
{
    /// <summary>
    /// Effect indicates the taint effect to match. Empty means match all taint effects.
    /// When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
    /// </summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>
    /// Key is the taint key that the toleration applies to. Empty means match all taint keys.
    /// If the key is empty, operator must be Exists; this combination means to match all values and all keys.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Operator represents a key&apos;s relationship to the value.
    /// Valid operators are Exists and Equal. Defaults to Equal.
    /// Exists is equivalent to wildcard for value, so that a pod can
    /// tolerate all taints of a particular category.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// TolerationSeconds represents the period of time the toleration (which must be
    /// of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,
    /// it is not set, which means tolerate the taint forever (do not evict). Zero and
    /// negative values will be treated as 0 (evict immediately) by the system.
    /// </summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>
    /// Value is the taint value the toleration matches to.
    /// If the operator is Exists, the value should be empty, otherwise just a regular string.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// nodePlacement describes scheduling configuration for specific
/// KubeVirt components
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfraNodePlacement
{
    /// <summary>
    /// affinity enables pod affinity/anti-affinity placement expanding the types of constraints
    /// that can be expressed with nodeSelector.
    /// affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector
    /// See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
    /// </summary>
    [JsonPropertyName("affinity")]
    public V1alpha3KubeVirtSpecInfraNodePlacementAffinity? Affinity { get; set; }

    /// <summary>
    /// nodeSelector is the node selector applied to the relevant kind of pods
    /// It specifies a map of key-value pairs: for the pod to be eligible to run on a node,
    /// the node must have each of the indicated key-value pairs as labels
    /// (it can have additional labels as well).
    /// See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>
    /// tolerations is a list of tolerations applied to the relevant kind of pods
    /// See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info.
    /// These are additional tolerations other than default ones.
    /// </summary>
    [JsonPropertyName("tolerations")]
    public IList<V1alpha3KubeVirtSpecInfraNodePlacementTolerations>? Tolerations { get; set; }
}

/// <summary>selectors and tolerations that should apply to KubeVirt infrastructure components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecInfra
{
    /// <summary>
    /// nodePlacement describes scheduling configuration for specific
    /// KubeVirt components
    /// </summary>
    [JsonPropertyName("nodePlacement")]
    public V1alpha3KubeVirtSpecInfraNodePlacement? NodePlacement { get; set; }

    /// <summary>
    /// replicas indicates how many replicas should be created for each KubeVirt infrastructure
    /// component (like virt-api or virt-controller). Defaults to 2.
    /// WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!
    /// </summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }
}

/// <summary>
/// WorkloadUpdateStrategy defines at the cluster level how to handle
/// automated workload updates
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadUpdateStrategy
{
    /// <summary>
    /// BatchEvictionInterval Represents the interval to wait before issuing the next
    /// batch of shutdowns
    /// 
    /// Defaults to 1 minute
    /// </summary>
    [JsonPropertyName("batchEvictionInterval")]
    public string? BatchEvictionInterval { get; set; }

    /// <summary>
    /// BatchEvictionSize Represents the number of VMIs that can be forced updated per
    /// the BatchShutdownInteral interval
    /// 
    /// Defaults to 10
    /// </summary>
    [JsonPropertyName("batchEvictionSize")]
    public int? BatchEvictionSize { get; set; }

    /// <summary>
    /// WorkloadUpdateMethods defines the methods that can be used to disrupt workloads
    /// during automated workload updates.
    /// When multiple methods are present, the least disruptive method takes
    /// precedence over more disruptive methods. For example if both LiveMigrate and Shutdown
    /// methods are listed, only VMs which are not live migratable will be restarted/shutdown
    /// 
    /// An empty list defaults to no automated workload updating
    /// </summary>
    [JsonPropertyName("workloadUpdateMethods")]
    public IList<string>? WorkloadUpdateMethods { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A null or empty node selector term matches no objects. The requirements of
/// them are ANDed.
/// The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// If the affinity requirements specified by this field are not met at
/// scheduling time, the pod will not be scheduled onto the node.
/// If the affinity requirements specified by this field cease to be met
/// at some point during pod execution (e.g. due to an update), the system
/// may or may not try to eventually evict the pod from its node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node matches the corresponding matchExpressions; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key in (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with &apos;labelSelector&apos; as &apos;key notin (value)&apos;
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the anti-affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling anti-affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and subtracting
    /// &quot;weight&quot; from the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the anti-affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the anti-affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// affinity enables pod affinity/anti-affinity placement expanding the types of constraints
/// that can be expressed with nodeSelector.
/// affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector
/// See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacementTolerations
{
    /// <summary>
    /// Effect indicates the taint effect to match. Empty means match all taint effects.
    /// When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
    /// </summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>
    /// Key is the taint key that the toleration applies to. Empty means match all taint keys.
    /// If the key is empty, operator must be Exists; this combination means to match all values and all keys.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Operator represents a key&apos;s relationship to the value.
    /// Valid operators are Exists and Equal. Defaults to Equal.
    /// Exists is equivalent to wildcard for value, so that a pod can
    /// tolerate all taints of a particular category.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// TolerationSeconds represents the period of time the toleration (which must be
    /// of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,
    /// it is not set, which means tolerate the taint forever (do not evict). Zero and
    /// negative values will be treated as 0 (evict immediately) by the system.
    /// </summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>
    /// Value is the taint value the toleration matches to.
    /// If the operator is Exists, the value should be empty, otherwise just a regular string.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// nodePlacement describes scheduling configuration for specific
/// KubeVirt components
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloadsNodePlacement
{
    /// <summary>
    /// affinity enables pod affinity/anti-affinity placement expanding the types of constraints
    /// that can be expressed with nodeSelector.
    /// affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector
    /// See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
    /// </summary>
    [JsonPropertyName("affinity")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacementAffinity? Affinity { get; set; }

    /// <summary>
    /// nodeSelector is the node selector applied to the relevant kind of pods
    /// It specifies a map of key-value pairs: for the pod to be eligible to run on a node,
    /// the node must have each of the indicated key-value pairs as labels
    /// (it can have additional labels as well).
    /// See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>
    /// tolerations is a list of tolerations applied to the relevant kind of pods
    /// See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info.
    /// These are additional tolerations other than default ones.
    /// </summary>
    [JsonPropertyName("tolerations")]
    public IList<V1alpha3KubeVirtSpecWorkloadsNodePlacementTolerations>? Tolerations { get; set; }
}

/// <summary>selectors and tolerations that should apply to KubeVirt workloads</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpecWorkloads
{
    /// <summary>
    /// nodePlacement describes scheduling configuration for specific
    /// KubeVirt components
    /// </summary>
    [JsonPropertyName("nodePlacement")]
    public V1alpha3KubeVirtSpecWorkloadsNodePlacement? NodePlacement { get; set; }

    /// <summary>
    /// replicas indicates how many replicas should be created for each KubeVirt infrastructure
    /// component (like virt-api or virt-controller). Defaults to 2.
    /// WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!
    /// </summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtSpec
{
    [JsonPropertyName("certificateRotateStrategy")]
    public V1alpha3KubeVirtSpecCertificateRotateStrategy? CertificateRotateStrategy { get; set; }

    /// <summary>
    /// holds kubevirt configurations.
    /// same as the virt-configMap
    /// </summary>
    [JsonPropertyName("configuration")]
    public V1alpha3KubeVirtSpecConfiguration? Configuration { get; set; }

    [JsonPropertyName("customizeComponents")]
    public V1alpha3KubeVirtSpecCustomizeComponents? CustomizeComponents { get; set; }

    /// <summary>The ImagePullPolicy to use.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>
    /// The imagePullSecrets to pull the container images from
    /// Defaults to none
    /// </summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1alpha3KubeVirtSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>
    /// The image registry to pull the container images from
    /// Defaults to the same registry the operator&apos;s container image is pulled from.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public string? ImageRegistry { get; set; }

    /// <summary>
    /// The image tag to use for the continer images installed.
    /// Defaults to the same tag as the operator&apos;s container image.
    /// </summary>
    [JsonPropertyName("imageTag")]
    public string? ImageTag { get; set; }

    /// <summary>selectors and tolerations that should apply to KubeVirt infrastructure components</summary>
    [JsonPropertyName("infra")]
    public V1alpha3KubeVirtSpecInfra? Infra { get; set; }

    /// <summary>
    /// The name of the Prometheus service account that needs read-access to KubeVirt endpoints
    /// Defaults to prometheus-k8s
    /// </summary>
    [JsonPropertyName("monitorAccount")]
    public string? MonitorAccount { get; set; }

    /// <summary>
    /// The namespace Prometheus is deployed in
    /// Defaults to openshift-monitor
    /// </summary>
    [JsonPropertyName("monitorNamespace")]
    public string? MonitorNamespace { get; set; }

    /// <summary>
    /// Designate the apps.kubevirt.io/component label for KubeVirt components.
    /// Useful if KubeVirt is included as part of a product.
    /// If ProductComponent is not specified, the component label default value is kubevirt.
    /// </summary>
    [JsonPropertyName("productComponent")]
    public string? ProductComponent { get; set; }

    /// <summary>
    /// Designate the apps.kubevirt.io/part-of label for KubeVirt components.
    /// Useful if KubeVirt is included as part of a product.
    /// If ProductName is not specified, the part-of label will be omitted.
    /// </summary>
    [JsonPropertyName("productName")]
    public string? ProductName { get; set; }

    /// <summary>
    /// Designate the apps.kubevirt.io/version label for KubeVirt components.
    /// Useful if KubeVirt is included as part of a product.
    /// If ProductVersion is not specified, KubeVirt&apos;s version will be used.
    /// </summary>
    [JsonPropertyName("productVersion")]
    public string? ProductVersion { get; set; }

    /// <summary>
    /// The namespace the service monitor will be deployed
    ///  When ServiceMonitorNamespace is set, then we&apos;ll install the service monitor object in that namespace
    /// otherwise we will use the monitoring namespace.
    /// </summary>
    [JsonPropertyName("serviceMonitorNamespace")]
    public string? ServiceMonitorNamespace { get; set; }

    /// <summary>Specify the port to listen on for VMI status synchronization traffic. Default is 9185</summary>
    [JsonPropertyName("synchronizationPort")]
    public string? SynchronizationPort { get; set; }

    /// <summary>
    /// Specifies if kubevirt can be deleted if workloads are still present.
    /// This is mainly a precaution to avoid accidental data loss
    /// </summary>
    [JsonPropertyName("uninstallStrategy")]
    public string? UninstallStrategy { get; set; }

    /// <summary>
    /// WorkloadUpdateStrategy defines at the cluster level how to handle
    /// automated workload updates
    /// </summary>
    [JsonPropertyName("workloadUpdateStrategy")]
    public V1alpha3KubeVirtSpecWorkloadUpdateStrategy? WorkloadUpdateStrategy { get; set; }

    /// <summary>selectors and tolerations that should apply to KubeVirt workloads</summary>
    [JsonPropertyName("workloads")]
    public V1alpha3KubeVirtSpecWorkloads? Workloads { get; set; }
}

/// <summary>KubeVirtCondition represents a condition of a KubeVirt deployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtStatusConditions
{
    [JsonPropertyName("lastProbeTime")]
    public DateTime? LastProbeTime { get; set; }

    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtStatusGenerations
{
    /// <summary>group is the group of the thing you&apos;re tracking</summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>hash is an optional field set for resources without generation that are content sensitive like secrets and configmaps</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>lastGeneration is the last generation of the workload controller involved</summary>
    [JsonPropertyName("lastGeneration")]
    public required long LastGeneration { get; set; }

    /// <summary>name is the name of the thing you&apos;re tracking</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>namespace is where the thing you&apos;re tracking is</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>resource is the resource type of the thing you&apos;re tracking</summary>
    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

/// <summary>KubeVirtStatus represents information pertaining to a KubeVirt deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
public partial class V1alpha3KubeVirtStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha3KubeVirtStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("defaultArchitecture")]
    public string? DefaultArchitecture { get; set; }

    [JsonPropertyName("generations")]
    public IList<V1alpha3KubeVirtStatusGenerations>? Generations { get; set; }

    [JsonPropertyName("observedDeploymentConfig")]
    public string? ObservedDeploymentConfig { get; set; }

    [JsonPropertyName("observedDeploymentID")]
    public string? ObservedDeploymentID { get; set; }

    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    [JsonPropertyName("observedKubeVirtRegistry")]
    public string? ObservedKubeVirtRegistry { get; set; }

    [JsonPropertyName("observedKubeVirtVersion")]
    public string? ObservedKubeVirtVersion { get; set; }

    [JsonPropertyName("operatorVersion")]
    public string? OperatorVersion { get; set; }

    [JsonPropertyName("outdatedVirtualMachineInstanceWorkloads")]
    public int? OutdatedVirtualMachineInstanceWorkloads { get; set; }

    /// <summary>KubeVirtPhase is a label for the phase of a KubeVirt deployment at the current time.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    [JsonPropertyName("synchronizationAddresses")]
    public IList<string>? SynchronizationAddresses { get; set; }

    [JsonPropertyName("targetDeploymentConfig")]
    public string? TargetDeploymentConfig { get; set; }

    [JsonPropertyName("targetDeploymentID")]
    public string? TargetDeploymentID { get; set; }

    [JsonPropertyName("targetKubeVirtRegistry")]
    public string? TargetKubeVirtRegistry { get; set; }

    [JsonPropertyName("targetKubeVirtVersion")]
    public string? TargetKubeVirtVersion { get; set; }
}

/// <summary>KubeVirt represents the object deploying all KubeVirt resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3KubeVirt : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha3KubeVirtSpec>, IStatus<V1alpha3KubeVirtStatus?>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "KubeVirt";
    public const string KubeGroup = "kubevirt.io";
    public const string KubePluralName = "kubevirts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubevirt.io/v1alpha3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KubeVirt";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha3KubeVirtSpec Spec { get; set; }

    /// <summary>KubeVirtStatus represents information pertaining to a KubeVirt deployment.</summary>
    [JsonPropertyName("status")]
    public V1alpha3KubeVirtStatus? Status { get; set; }
}
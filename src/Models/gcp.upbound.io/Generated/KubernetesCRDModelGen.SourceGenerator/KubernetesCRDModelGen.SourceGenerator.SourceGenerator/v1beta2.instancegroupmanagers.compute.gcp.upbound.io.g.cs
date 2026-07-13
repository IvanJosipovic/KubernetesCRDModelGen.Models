#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>InstanceGroupManager is the Schema for the InstanceGroupManagers API. Manages an Instance Group within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceGroupManagerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2InstanceGroupManager>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceGroupManagerList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "instancegroupmanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceGroupManagerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2InstanceGroupManager objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2InstanceGroupManager> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecDeletionPolicyEnum>))]
public enum V1beta2InstanceGroupManagerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Properties to set on all instances in the group. After setting
/// allInstancesConfig on the group, you must update the group&apos;s instances to
/// apply the configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderAllInstancesConfig
{
    /// <summary>, The label key-value pairs that you want to patch onto the instance.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>, The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelector
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
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The autohealing policies for this managed instance
/// group. You can specify only one value. Structure is documented below. For more information, see the official documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>
    /// The number of seconds that the managed instance group waits before
    /// it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderInstanceLifecyclePolicy
{
    /// <summary>, Specifies the action that a MIG performs on a failed VM. If the value of the on_failed_health_check field is DEFAULT_ACTION, then the same action also applies to the VMs on which your application fails a health check. Valid options are: DO_NOTHING, REPAIR. If DO_NOTHING, then MIG does not repair a failed VM. If REPAIR (default), then MIG automatically repairs a failed VM by recreating it. For more information, see about repairing VMs in a MIG.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>, Specifies whether to apply the group&apos;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&apos;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&apos;s update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourcePolicy in compute to populate workloadPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourcePolicy in compute to populate workloadPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelector
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
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelectorPolicy? Policy { get; set; }
}

/// <summary>Resource policies for this managed instance group. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderResourcePolicies
{
    /// <summary>The URL of the workload policy that is specified for this managed instance group. It can be a full or partial URL.</summary>
    [JsonPropertyName("workloadPolicy")]
    public string? WorkloadPolicy { get; set; }

    /// <summary>Reference to a ResourcePolicy in compute to populate workloadPolicy.</summary>
    [JsonPropertyName("workloadPolicyRef")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicyRef? WorkloadPolicyRef { get; set; }

    /// <summary>Selector for a ResourcePolicy in compute to populate workloadPolicy.</summary>
    [JsonPropertyName("workloadPolicySelector")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePoliciesWorkloadPolicySelector? WorkloadPolicySelector { get; set; }
}

/// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderStandbyPolicy
{
    /// <summary>- Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }

    /// <summary>- Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. Valid options are: MANUAL, SCALE_OUT_POOL. If MANUAL(default), you have full control over which VMs are stopped and suspended in the MIG. If SCALE_OUT_POOL, the MIG uses the VMs from the standby pools to accelerate the scale out by resuming or starting them and then automatically replenishes the standby pool with new VMs to maintain the target sizes.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderStatefulDisk
{
    /// <summary>, A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The device name of the disk to be attached.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelector
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
    public V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicy? Policy { get; set; }
}

/// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderUpdatePolicy
{
    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0.</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%..</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>- Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>, The instance replacement method for managed instance groups. Valid values are: &quot;RECREATE&quot;, &quot;SUBSTITUTE&quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.</summary>
    [JsonPropertyName("replacementMethod")]
    public string? ReplacementMethod { get; set; }

    /// <summary>- The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelector
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
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderVersionTargetSize
{
    /// <summary>, The number of instances which are managed for this version. Conflicts with percent.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// , The number of instances (calculated as percentage) which are managed for this version. Conflicts with fixed.
    /// Note that when using percent, rounding will be in favor of explicitly set target_size values; a managed instance group with 2 instances and 2 versions,
    /// one of which has a target_size.percent of 60 will create 2 instances of that version.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created. It is recommended to reference instance templates through their unique id (self_link_unique attribute).</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateRef")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateRef? InstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateSelector")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelector? InstanceTemplateSelector { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public V1beta2InstanceGroupManagerSpecForProviderVersionTargetSize? TargetSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecForProvider
{
    /// <summary>
    /// Properties to set on all instances in the group. After setting
    /// allInstancesConfig on the group, you must update the group&apos;s instances to
    /// apply the configuration.
    /// </summary>
    [JsonPropertyName("allInstancesConfig")]
    public V1beta2InstanceGroupManagerSpecForProviderAllInstancesConfig? AllInstancesConfig { get; set; }

    /// <summary>
    /// The autohealing policies for this managed instance
    /// group. You can specify only one value. Structure is documented below. For more information, see the official documentation.
    /// </summary>
    [JsonPropertyName("autoHealingPolicies")]
    public V1beta2InstanceGroupManagerSpecForProviderAutoHealingPolicies? AutoHealingPolicies { get; set; }

    /// <summary>
    /// The base instance name to use for
    /// instances in this group. The value must be a valid
    /// RFC1035 name. Supported characters
    /// are lowercase letters, numbers, and hyphens (-). Instances are named by
    /// appending a hyphen and a random four-character string to the base instance
    /// name.
    /// </summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>
    /// An optional textual description of the instance
    /// group manager.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("instanceLifecyclePolicy")]
    public V1beta2InstanceGroupManagerSpecForProviderInstanceLifecyclePolicy? InstanceLifecyclePolicy { get; set; }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API
    /// method for this managed instance group. Valid values are: PAGELESS, PAGINATED.
    /// If PAGELESS (default), Pagination is disabled for the group&apos;s listManagedInstances API method.
    /// maxResults and pageToken query parameters are ignored and all instances are returned in a single
    /// response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are
    /// respected.
    /// </summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>
    /// The named port configuration. See the section below
    /// for details on configuration.
    /// </summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta2InstanceGroupManagerSpecForProviderNamedPort>? NamedPort { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Resource policies for this managed instance group. Structure is documented below.</summary>
    [JsonPropertyName("resourcePolicies")]
    public V1beta2InstanceGroupManagerSpecForProviderResourcePolicies? ResourcePolicies { get; set; }

    /// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("standbyPolicy")]
    public V1beta2InstanceGroupManagerSpecForProviderStandbyPolicy? StandbyPolicy { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta2InstanceGroupManagerSpecForProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta2InstanceGroupManagerSpecForProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta2InstanceGroupManagerSpecForProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>
    /// The full URL of all target pools to which new
    /// instances in the group are added. Updating the target pools attribute does
    /// not affect existing instances.
    /// </summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>References to TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsRefs")]
    public IList<V1beta2InstanceGroupManagerSpecForProviderTargetPoolsRefs>? TargetPoolsRefs { get; set; }

    /// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsSelector")]
    public V1beta2InstanceGroupManagerSpecForProviderTargetPoolsSelector? TargetPoolsSelector { get; set; }

    /// <summary>
    /// The target number of running instances for this managed
    /// instance group. This value will fight with autoscaler settings when set, and generally shouldn&apos;t be set
    /// when using one. If a value is required, such as to specify a creation-time target size for the MIG,
    /// lifecycle. Defaults to 0.
    /// </summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The target number of stopped instances for this managed instance group.</summary>
    [JsonPropertyName("targetStoppedSize")]
    public double? TargetStoppedSize { get; set; }

    /// <summary>The target number of suspended instances for this managed instance group.</summary>
    [JsonPropertyName("targetSuspendedSize")]
    public double? TargetSuspendedSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API.</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta2InstanceGroupManagerSpecForProviderUpdatePolicy? UpdatePolicy { get; set; }

    /// <summary>
    /// Application versions managed by this instance group. Each
    /// version deals with a specific instance template, allowing canary release scenarios.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<V1beta2InstanceGroupManagerSpecForProviderVersion>? Version { get; set; }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before
    /// returning.
    /// </summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>
    /// When used with wait_for_instances it specifies the status to wait for.
    /// When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is
    /// set, it will wait for the version target to be reached and any per instance configs to be effective as well as all
    /// instances to be stable before returning. The possible values are STABLE and UPDATED
    /// </summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }

    /// <summary>
    /// The zone that instances in this group should be created
    /// in.
    /// </summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

/// <summary>
/// Properties to set on all instances in the group. After setting
/// allInstancesConfig on the group, you must update the group&apos;s instances to
/// apply the configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderAllInstancesConfig
{
    /// <summary>, The label key-value pairs that you want to patch onto the instance.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>, The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelector
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
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The autohealing policies for this managed instance
/// group. You can specify only one value. Structure is documented below. For more information, see the official documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>
    /// The number of seconds that the managed instance group waits before
    /// it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderInstanceLifecyclePolicy
{
    /// <summary>, Specifies the action that a MIG performs on a failed VM. If the value of the on_failed_health_check field is DEFAULT_ACTION, then the same action also applies to the VMs on which your application fails a health check. Valid options are: DO_NOTHING, REPAIR. If DO_NOTHING, then MIG does not repair a failed VM. If REPAIR (default), then MIG automatically repairs a failed VM by recreating it. For more information, see about repairing VMs in a MIG.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>, Specifies whether to apply the group&apos;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&apos;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&apos;s update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourcePolicy in compute to populate workloadPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourcePolicy in compute to populate workloadPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelector
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
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelectorPolicy? Policy { get; set; }
}

/// <summary>Resource policies for this managed instance group. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderResourcePolicies
{
    /// <summary>The URL of the workload policy that is specified for this managed instance group. It can be a full or partial URL.</summary>
    [JsonPropertyName("workloadPolicy")]
    public string? WorkloadPolicy { get; set; }

    /// <summary>Reference to a ResourcePolicy in compute to populate workloadPolicy.</summary>
    [JsonPropertyName("workloadPolicyRef")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicyRef? WorkloadPolicyRef { get; set; }

    /// <summary>Selector for a ResourcePolicy in compute to populate workloadPolicy.</summary>
    [JsonPropertyName("workloadPolicySelector")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePoliciesWorkloadPolicySelector? WorkloadPolicySelector { get; set; }
}

/// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderStandbyPolicy
{
    /// <summary>- Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }

    /// <summary>- Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. Valid options are: MANUAL, SCALE_OUT_POOL. If MANUAL(default), you have full control over which VMs are stopped and suspended in the MIG. If SCALE_OUT_POOL, the MIG uses the VMs from the standby pools to accelerate the scale out by resuming or starting them and then automatically replenishes the standby pool with new VMs to maintain the target sizes.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderStatefulDisk
{
    /// <summary>, A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The device name of the disk to be attached.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelector
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
    public V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicy? Policy { get; set; }
}

/// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderUpdatePolicy
{
    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0.</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%..</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>- Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>, The instance replacement method for managed instance groups. Valid values are: &quot;RECREATE&quot;, &quot;SUBSTITUTE&quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.</summary>
    [JsonPropertyName("replacementMethod")]
    public string? ReplacementMethod { get; set; }

    /// <summary>- The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelector
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
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderVersionTargetSize
{
    /// <summary>, The number of instances which are managed for this version. Conflicts with percent.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// , The number of instances (calculated as percentage) which are managed for this version. Conflicts with fixed.
    /// Note that when using percent, rounding will be in favor of explicitly set target_size values; a managed instance group with 2 instances and 2 versions,
    /// one of which has a target_size.percent of 60 will create 2 instances of that version.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecInitProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created. It is recommended to reference instance templates through their unique id (self_link_unique attribute).</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateRef")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRef? InstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateSelector")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelector? InstanceTemplateSelector { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public V1beta2InstanceGroupManagerSpecInitProviderVersionTargetSize? TargetSize { get; set; }
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
public partial class V1beta2InstanceGroupManagerSpecInitProvider
{
    /// <summary>
    /// Properties to set on all instances in the group. After setting
    /// allInstancesConfig on the group, you must update the group&apos;s instances to
    /// apply the configuration.
    /// </summary>
    [JsonPropertyName("allInstancesConfig")]
    public V1beta2InstanceGroupManagerSpecInitProviderAllInstancesConfig? AllInstancesConfig { get; set; }

    /// <summary>
    /// The autohealing policies for this managed instance
    /// group. You can specify only one value. Structure is documented below. For more information, see the official documentation.
    /// </summary>
    [JsonPropertyName("autoHealingPolicies")]
    public V1beta2InstanceGroupManagerSpecInitProviderAutoHealingPolicies? AutoHealingPolicies { get; set; }

    /// <summary>
    /// The base instance name to use for
    /// instances in this group. The value must be a valid
    /// RFC1035 name. Supported characters
    /// are lowercase letters, numbers, and hyphens (-). Instances are named by
    /// appending a hyphen and a random four-character string to the base instance
    /// name.
    /// </summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>
    /// An optional textual description of the instance
    /// group manager.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("instanceLifecyclePolicy")]
    public V1beta2InstanceGroupManagerSpecInitProviderInstanceLifecyclePolicy? InstanceLifecyclePolicy { get; set; }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API
    /// method for this managed instance group. Valid values are: PAGELESS, PAGINATED.
    /// If PAGELESS (default), Pagination is disabled for the group&apos;s listManagedInstances API method.
    /// maxResults and pageToken query parameters are ignored and all instances are returned in a single
    /// response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are
    /// respected.
    /// </summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>
    /// The named port configuration. See the section below
    /// for details on configuration.
    /// </summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta2InstanceGroupManagerSpecInitProviderNamedPort>? NamedPort { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Resource policies for this managed instance group. Structure is documented below.</summary>
    [JsonPropertyName("resourcePolicies")]
    public V1beta2InstanceGroupManagerSpecInitProviderResourcePolicies? ResourcePolicies { get; set; }

    /// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("standbyPolicy")]
    public V1beta2InstanceGroupManagerSpecInitProviderStandbyPolicy? StandbyPolicy { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta2InstanceGroupManagerSpecInitProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta2InstanceGroupManagerSpecInitProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta2InstanceGroupManagerSpecInitProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>
    /// The full URL of all target pools to which new
    /// instances in the group are added. Updating the target pools attribute does
    /// not affect existing instances.
    /// </summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>References to TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsRefs")]
    public IList<V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsRefs>? TargetPoolsRefs { get; set; }

    /// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsSelector")]
    public V1beta2InstanceGroupManagerSpecInitProviderTargetPoolsSelector? TargetPoolsSelector { get; set; }

    /// <summary>
    /// The target number of running instances for this managed
    /// instance group. This value will fight with autoscaler settings when set, and generally shouldn&apos;t be set
    /// when using one. If a value is required, such as to specify a creation-time target size for the MIG,
    /// lifecycle. Defaults to 0.
    /// </summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The target number of stopped instances for this managed instance group.</summary>
    [JsonPropertyName("targetStoppedSize")]
    public double? TargetStoppedSize { get; set; }

    /// <summary>The target number of suspended instances for this managed instance group.</summary>
    [JsonPropertyName("targetSuspendedSize")]
    public double? TargetSuspendedSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API.</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta2InstanceGroupManagerSpecInitProviderUpdatePolicy? UpdatePolicy { get; set; }

    /// <summary>
    /// Application versions managed by this instance group. Each
    /// version deals with a specific instance template, allowing canary release scenarios.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<V1beta2InstanceGroupManagerSpecInitProviderVersion>? Version { get; set; }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before
    /// returning.
    /// </summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>
    /// When used with wait_for_instances it specifies the status to wait for.
    /// When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is
    /// set, it will wait for the version target to be reached and any per instance configs to be effective as well as all
    /// instances to be stable before returning. The possible values are STABLE and UPDATED
    /// </summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecManagementPoliciesEnum>))]
public enum V1beta2InstanceGroupManagerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InstanceGroupManagerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceGroupManagerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InstanceGroupManagerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceGroupManagerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceGroupManagerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceGroupManagerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceGroupManagerSpec defines the desired state of InstanceGroupManager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerSpec
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
    public V1beta2InstanceGroupManagerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InstanceGroupManagerSpecForProvider ForProvider { get; set; }

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
    public V1beta2InstanceGroupManagerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InstanceGroupManagerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InstanceGroupManagerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InstanceGroupManagerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Properties to set on all instances in the group. After setting
/// allInstancesConfig on the group, you must update the group&apos;s instances to
/// apply the configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderAllInstancesConfig
{
    /// <summary>, The label key-value pairs that you want to patch onto the instance.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>, The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>
/// The autohealing policies for this managed instance
/// group. You can specify only one value. Structure is documented below. For more information, see the official documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>
    /// The number of seconds that the managed instance group waits before
    /// it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderInstanceLifecyclePolicy
{
    /// <summary>, Specifies the action that a MIG performs on a failed VM. If the value of the on_failed_health_check field is DEFAULT_ACTION, then the same action also applies to the VMs on which your application fails a health check. Valid options are: DO_NOTHING, REPAIR. If DO_NOTHING, then MIG does not repair a failed VM. If REPAIR (default), then MIG automatically repairs a failed VM by recreating it. For more information, see about repairing VMs in a MIG.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>, Specifies whether to apply the group&apos;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&apos;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&apos;s update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Resource policies for this managed instance group. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderResourcePolicies
{
    /// <summary>The URL of the workload policy that is specified for this managed instance group. It can be a full or partial URL.</summary>
    [JsonPropertyName("workloadPolicy")]
    public string? WorkloadPolicy { get; set; }
}

/// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStandbyPolicy
{
    /// <summary>- Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }

    /// <summary>- Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. Valid options are: MANUAL, SCALE_OUT_POOL. If MANUAL(default), you have full control over which VMs are stopped and suspended in the MIG. If SCALE_OUT_POOL, the MIG uses the VMs from the standby pools to accelerate the scale out by resuming or starting them and then automatically replenishes the standby pool with new VMs to maintain the target sizes.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatefulDisk
{
    /// <summary>, A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The device name of the disk to be attached.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatusAllInstancesConfig
{
    /// <summary>Current all-instances configuration revision. This value is in RFC3339 text format.</summary>
    [JsonPropertyName("currentRevision")]
    public string? CurrentRevision { get; set; }

    /// <summary>A bit indicating whether this configuration has been applied to all managed instances in the group.</summary>
    [JsonPropertyName("effective")]
    public bool? Effective { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatusStatefulPerInstanceConfigs
{
    /// <summary>A bit indicating if all of the group&apos;s per-instance configs (listed in the output of a listPerInstanceConfigs API call) have status EFFECTIVE or there are no per-instance-configs.</summary>
    [JsonPropertyName("allEffective")]
    public bool? AllEffective { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatusStateful
{
    /// <summary>A bit indicating whether the managed instance group has stateful configuration, that is, if you have configured any items in a stateful policy or in per-instance configs. The group might report that it has no stateful config even when there is still some preserved state on a managed instance, for example, if you have deleted all PICs but not yet applied those deletions.</summary>
    [JsonPropertyName("hasStatefulConfig")]
    public bool? HasStatefulConfig { get; set; }

    /// <summary>Status of per-instance configs on the instances.</summary>
    [JsonPropertyName("perInstanceConfigs")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatusStatefulPerInstanceConfigs>? PerInstanceConfigs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatusVersionTarget
{
    [JsonPropertyName("isReached")]
    public bool? IsReached { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderStatus
{
    /// <summary>Status of all-instances configuration on the group.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatusAllInstancesConfig>? AllInstancesConfig { get; set; }

    /// <summary>A bit indicating whether the managed instance group is in a stable state. A stable state means that: none of the instances in the managed instance group is currently undergoing any type of change (for example, creation, restart, or deletion); no future changes are scheduled for instances in the managed instance group; and the managed instance group itself is not being modified.</summary>
    [JsonPropertyName("isStable")]
    public bool? IsStable { get; set; }

    /// <summary>Stateful status of the given Instance Group Manager.</summary>
    [JsonPropertyName("stateful")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatusStateful>? Stateful { get; set; }

    /// <summary>A status of consistency of Instances&apos; versions with their target version specified by version field on Instance Group Manager.</summary>
    [JsonPropertyName("versionTarget")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatusVersionTarget>? VersionTarget { get; set; }
}

/// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderUpdatePolicy
{
    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0.</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%..</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>- Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>, The instance replacement method for managed instance groups. Valid values are: &quot;RECREATE&quot;, &quot;SUBSTITUTE&quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.</summary>
    [JsonPropertyName("replacementMethod")]
    public string? ReplacementMethod { get; set; }

    /// <summary>- The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderVersionTargetSize
{
    /// <summary>, The number of instances which are managed for this version. Conflicts with percent.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// , The number of instances (calculated as percentage) which are managed for this version. Conflicts with fixed.
    /// Note that when using percent, rounding will be in favor of explicitly set target_size values; a managed instance group with 2 instances and 2 versions,
    /// one of which has a target_size.percent of 60 will create 2 instances of that version.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created. It is recommended to reference instance templates through their unique id (self_link_unique attribute).</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public V1beta2InstanceGroupManagerStatusAtProviderVersionTargetSize? TargetSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusAtProvider
{
    /// <summary>
    /// Properties to set on all instances in the group. After setting
    /// allInstancesConfig on the group, you must update the group&apos;s instances to
    /// apply the configuration.
    /// </summary>
    [JsonPropertyName("allInstancesConfig")]
    public V1beta2InstanceGroupManagerStatusAtProviderAllInstancesConfig? AllInstancesConfig { get; set; }

    /// <summary>
    /// The autohealing policies for this managed instance
    /// group. You can specify only one value. Structure is documented below. For more information, see the official documentation.
    /// </summary>
    [JsonPropertyName("autoHealingPolicies")]
    public V1beta2InstanceGroupManagerStatusAtProviderAutoHealingPolicies? AutoHealingPolicies { get; set; }

    /// <summary>
    /// The base instance name to use for
    /// instances in this group. The value must be a valid
    /// RFC1035 name. Supported characters
    /// are lowercase letters, numbers, and hyphens (-). Instances are named by
    /// appending a hyphen and a random four-character string to the base instance
    /// name.
    /// </summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// An optional textual description of the instance
    /// group manager.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The fingerprint of the instance group manager.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/zones/{{zone}}/instanceGroupManagers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The full URL of the instance group created by the manager.</summary>
    [JsonPropertyName("instanceGroup")]
    public string? InstanceGroup { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/zones/{{zone}}/instanceGroupManagers/{{name}}</summary>
    [JsonPropertyName("instanceGroupManagerId")]
    public double? InstanceGroupManagerId { get; set; }

    [JsonPropertyName("instanceLifecyclePolicy")]
    public V1beta2InstanceGroupManagerStatusAtProviderInstanceLifecyclePolicy? InstanceLifecyclePolicy { get; set; }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API
    /// method for this managed instance group. Valid values are: PAGELESS, PAGINATED.
    /// If PAGELESS (default), Pagination is disabled for the group&apos;s listManagedInstances API method.
    /// maxResults and pageToken query parameters are ignored and all instances are returned in a single
    /// response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are
    /// respected.
    /// </summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>
    /// The named port configuration. See the section below
    /// for details on configuration.
    /// </summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderNamedPort>? NamedPort { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Resource policies for this managed instance group. Structure is documented below.</summary>
    [JsonPropertyName("resourcePolicies")]
    public V1beta2InstanceGroupManagerStatusAtProviderResourcePolicies? ResourcePolicies { get; set; }

    /// <summary>The URL of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("standbyPolicy")]
    public V1beta2InstanceGroupManagerStatusAtProviderStandbyPolicy? StandbyPolicy { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>The status of this managed instance group.</summary>
    [JsonPropertyName("status")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderStatus>? Status { get; set; }

    /// <summary>
    /// The full URL of all target pools to which new
    /// instances in the group are added. Updating the target pools attribute does
    /// not affect existing instances.
    /// </summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>
    /// The target number of running instances for this managed
    /// instance group. This value will fight with autoscaler settings when set, and generally shouldn&apos;t be set
    /// when using one. If a value is required, such as to specify a creation-time target size for the MIG,
    /// lifecycle. Defaults to 0.
    /// </summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The target number of stopped instances for this managed instance group.</summary>
    [JsonPropertyName("targetStoppedSize")]
    public double? TargetStoppedSize { get; set; }

    /// <summary>The target number of suspended instances for this managed instance group.</summary>
    [JsonPropertyName("targetSuspendedSize")]
    public double? TargetSuspendedSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API.</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta2InstanceGroupManagerStatusAtProviderUpdatePolicy? UpdatePolicy { get; set; }

    /// <summary>
    /// Application versions managed by this instance group. Each
    /// version deals with a specific instance template, allowing canary release scenarios.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<V1beta2InstanceGroupManagerStatusAtProviderVersion>? Version { get; set; }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before
    /// returning.
    /// </summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>
    /// When used with wait_for_instances it specifies the status to wait for.
    /// When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is
    /// set, it will wait for the version target to be reached and any per instance configs to be effective as well as all
    /// instances to be stable before returning. The possible values are STABLE and UPDATED
    /// </summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }

    /// <summary>
    /// The zone that instances in this group should be created
    /// in.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatusConditions
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

/// <summary>InstanceGroupManagerStatus defines the observed state of InstanceGroupManager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceGroupManagerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InstanceGroupManagerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceGroupManagerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstanceGroupManager is the Schema for the InstanceGroupManagers API. Manages an Instance Group within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceGroupManager : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceGroupManagerSpec>, IStatus<V1beta2InstanceGroupManagerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceGroupManager";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "instancegroupmanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceGroupManager";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceGroupManagerSpec defines the desired state of InstanceGroupManager</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InstanceGroupManagerSpec Spec { get; set; }

    /// <summary>InstanceGroupManagerStatus defines the observed state of InstanceGroupManager.</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceGroupManagerStatus? Status { get; set; }
}
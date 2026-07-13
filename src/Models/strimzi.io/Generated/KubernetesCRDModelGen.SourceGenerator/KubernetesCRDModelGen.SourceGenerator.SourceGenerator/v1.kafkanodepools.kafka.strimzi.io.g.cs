#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.strimzi.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaNodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1KafkaNodePool>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaNodePoolList";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkanodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaNodePoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KafkaNodePool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KafkaNodePool> Items { get; set; }
}

/// <summary>Specifies whether this volume should be used for storing KRaft metadata. This property is optional. When set, the only currently supported value is `shared`. At most one volume can have this property set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolSpecStorageKraftMetadataEnum>))]
public enum V1KafkaNodePoolSpecStorageKraftMetadataEnum
{
    [EnumMember(Value = "shared"), JsonStringEnumMemberName("shared")]
    Shared
}

/// <summary>Storage type, must be either &apos;ephemeral&apos;, &apos;persistent-claim&apos;, or &apos;jbod&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolSpecStorageTypeEnum>))]
public enum V1KafkaNodePoolSpecStorageTypeEnum
{
    [EnumMember(Value = "ephemeral"), JsonStringEnumMemberName("ephemeral")]
    Ephemeral,
    [EnumMember(Value = "persistent-claim"), JsonStringEnumMemberName("persistent-claim")]
    PersistentClaim,
    [EnumMember(Value = "jbod"), JsonStringEnumMemberName("jbod")]
    Jbod
}

/// <summary>Specifies whether this volume should be used for storing KRaft metadata. This property is optional. When set, the only currently supported value is `shared`. At most one volume can have this property set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolSpecStorageVolumesKraftMetadataEnum>))]
public enum V1KafkaNodePoolSpecStorageVolumesKraftMetadataEnum
{
    [EnumMember(Value = "shared"), JsonStringEnumMemberName("shared")]
    Shared
}

/// <summary>Storage type, must be either &apos;ephemeral&apos; or &apos;persistent-claim&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolSpecStorageVolumesTypeEnum>))]
public enum V1KafkaNodePoolSpecStorageVolumesTypeEnum
{
    [EnumMember(Value = "ephemeral"), JsonStringEnumMemberName("ephemeral")]
    Ephemeral,
    [EnumMember(Value = "persistent-claim"), JsonStringEnumMemberName("persistent-claim")]
    PersistentClaim
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecStorageVolumes
{
    /// <summary>The storage class to use for dynamic volume allocation.</summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary>Specifies whether the persistent volume claim is deleted when a Kafka node is deleted. Optional. Defaults to `false`.</summary>
    [JsonPropertyName("deleteClaim")]
    public bool? DeleteClaim { get; set; }

    /// <summary>Storage identification number. Mandatory for storage volumes defined with a `jbod` storage type configuration.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Specifies whether this volume should be used for storing KRaft metadata. This property is optional. When set, the only currently supported value is `shared`. At most one volume can have this property set.</summary>
    [JsonPropertyName("kraftMetadata")]
    public V1KafkaNodePoolSpecStorageVolumesKraftMetadataEnum? KraftMetadata { get; set; }

    /// <summary>Specifies a specific persistent volume to use. It contains key:value pairs representing labels for selecting such a volume.</summary>
    [JsonPropertyName("selector")]
    public IDictionary<string, string>? Selector { get; set; }

    /// <summary>When `type=persistent-claim`, defines the size of the persistent volume claim, such as 100Gi. Mandatory when `type=persistent-claim`.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>When type=ephemeral, defines the total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }

    /// <summary>Storage type, must be either &apos;ephemeral&apos; or &apos;persistent-claim&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaNodePoolSpecStorageVolumesTypeEnum Type { get; set; }

    /// <summary>Specifies `VolumeAttributeClass` name for dynamically configuring storage attributes.</summary>
    [JsonPropertyName("volumeAttributesClass")]
    public string? VolumeAttributesClass { get; set; }
}

/// <summary>Storage configuration (disk). Cannot be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecStorage
{
    /// <summary>The storage class to use for dynamic volume allocation.</summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary>Specifies whether the persistent volume claim is deleted when a Kafka node is deleted. Optional. Defaults to `false`.</summary>
    [JsonPropertyName("deleteClaim")]
    public bool? DeleteClaim { get; set; }

    /// <summary>Storage identification number. It is mandatory only for storage volumes defined in a storage of type &apos;jbod&apos;.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Specifies whether this volume should be used for storing KRaft metadata. This property is optional. When set, the only currently supported value is `shared`. At most one volume can have this property set.</summary>
    [JsonPropertyName("kraftMetadata")]
    public V1KafkaNodePoolSpecStorageKraftMetadataEnum? KraftMetadata { get; set; }

    /// <summary>Specifies a specific persistent volume to use. It contains key:value pairs representing labels for selecting such a volume.</summary>
    [JsonPropertyName("selector")]
    public IDictionary<string, string>? Selector { get; set; }

    /// <summary>When `type=persistent-claim`, defines the size of the persistent volume claim, such as 100Gi. Mandatory when `type=persistent-claim`.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>When type=ephemeral, defines the total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }

    /// <summary>Storage type, must be either &apos;ephemeral&apos;, &apos;persistent-claim&apos;, or &apos;jbod&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaNodePoolSpecStorageTypeEnum Type { get; set; }

    /// <summary>Specifies `VolumeAttributeClass` name for dynamically configuring storage attributes.</summary>
    [JsonPropertyName("volumeAttributesClass")]
    public string? VolumeAttributesClass { get; set; }

    /// <summary>List of volumes as Storage objects representing the JBOD disks array.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaNodePoolSpecStorageVolumes>? Volumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolSpecRolesEnum>))]
public enum V1KafkaNodePoolSpecRolesEnum
{
    [EnumMember(Value = "controller"), JsonStringEnumMemberName("controller")]
    Controller,
    [EnumMember(Value = "broker"), JsonStringEnumMemberName("broker")]
    Broker
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>CPU and memory resources to reserve.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaNodePoolSpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecJvmOptionsJavaSystemProperties
{
    /// <summary>The system property name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The system property value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>JVM Options for pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecJvmOptions
{
    /// <summary>A map of -XX options to the JVM.</summary>
    [JsonPropertyName("-XX")]
    public IDictionary<string, string>? XX { get; set; }

    /// <summary>-Xmx option to to the JVM.</summary>
    [JsonPropertyName("-Xmx")]
    public string? Xmx { get; set; }

    /// <summary>-Xms option to to the JVM.</summary>
    [JsonPropertyName("-Xms")]
    public string? Xms { get; set; }

    /// <summary>Specifies whether the Garbage Collection logging is enabled. The default is false.</summary>
    [JsonPropertyName("gcLoggingEnabled")]
    public bool? GcLoggingEnabled { get; set; }

    /// <summary>A map of additional system properties which will be passed using the `-D` option to the JVM.</summary>
    [JsonPropertyName("javaSystemProperties")]
    public IList<V1KafkaNodePoolSpecJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka `StrimziPodSet` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSet
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaNodePoolSpecTemplatePodSetMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Configures pod-level security attributes and common container settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaNodePoolSpecTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public int? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaNodePoolSpecTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaNodePoolSpecTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaNodePoolSpecTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaNodePoolSpecTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaNodePoolSpecTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaNodePoolSpecTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public int? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaNodePoolSpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaNodePoolSpecTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public int? MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public string? WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolSpecTemplatePodDnsPolicyEnum>))]
public enum V1KafkaNodePoolSpecTemplatePodDnsPolicyEnum
{
    [EnumMember(Value = "ClusterFirst"), JsonStringEnumMemberName("ClusterFirst")]
    ClusterFirst,
    [EnumMember(Value = "ClusterFirstWithHostNet"), JsonStringEnumMemberName("ClusterFirstWithHostNet")]
    ClusterFirstWithHostNet,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaNodePoolSpecTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaNodePoolSpecTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaNodePoolSpecTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolSpecTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaNodePoolSpecTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaNodePoolSpecTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaNodePoolSpecTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaNodePoolSpecTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaNodePoolSpecTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaNodePoolSpecTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaNodePoolSpecTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaNodePoolSpecTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaNodePoolSpecTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for Kafka `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaNodePoolSpecTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaNodePoolSpecTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaNodePoolSpecTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaNodePoolSpecTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaNodePoolSpecTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaNodePoolSpecTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaNodePoolSpecTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaNodePoolSpecTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaNodePoolSpecTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaNodePoolSpecTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePerPodServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka per-pod `Services` used for access from outside of Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePerPodService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaNodePoolSpecTemplatePerPodServiceMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePerPodRouteMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka per-pod `Routes` used for access from outside of OpenShift.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePerPodRoute
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaNodePoolSpecTemplatePerPodRouteMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePerPodIngressMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka per-pod `Ingress` used for access from outside of Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePerPodIngress
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaNodePoolSpecTemplatePerPodIngressMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePersistentVolumeClaimMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for all Kafka `PersistentVolumeClaims`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplatePersistentVolumeClaim
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaNodePoolSpecTemplatePersistentVolumeClaimMetadata? Metadata { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka broker container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateKafkaContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaNodePoolSpecTemplateKafkaContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaNodePoolSpecTemplateKafkaContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaNodePoolSpecTemplateKafkaContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaNodePoolSpecTemplateInitContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaNodePoolSpecTemplateInitContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaNodePoolSpecTemplateInitContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaNodePoolSpecTemplateInitContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaNodePoolSpecTemplateInitContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaNodePoolSpecTemplateInitContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaNodePoolSpecTemplateInitContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaNodePoolSpecTemplateInitContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplateInitContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaNodePoolSpecTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaNodePoolSpecTemplateInitContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaNodePoolSpecTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Template for pool resources. The template allows users to specify how the resources belonging to this pool are generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpecTemplate
{
    /// <summary>Template for Kafka `StrimziPodSet` resource.</summary>
    [JsonPropertyName("podSet")]
    public V1KafkaNodePoolSpecTemplatePodSet? PodSet { get; set; }

    /// <summary>Template for Kafka `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaNodePoolSpecTemplatePod? Pod { get; set; }

    /// <summary>Template for Kafka per-pod `Services` used for access from outside of Kubernetes.</summary>
    [JsonPropertyName("perPodService")]
    public V1KafkaNodePoolSpecTemplatePerPodService? PerPodService { get; set; }

    /// <summary>Template for Kafka per-pod `Routes` used for access from outside of OpenShift.</summary>
    [JsonPropertyName("perPodRoute")]
    public V1KafkaNodePoolSpecTemplatePerPodRoute? PerPodRoute { get; set; }

    /// <summary>Template for Kafka per-pod `Ingress` used for access from outside of Kubernetes.</summary>
    [JsonPropertyName("perPodIngress")]
    public V1KafkaNodePoolSpecTemplatePerPodIngress? PerPodIngress { get; set; }

    /// <summary>Template for all Kafka `PersistentVolumeClaims`.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaNodePoolSpecTemplatePersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>Template for the Kafka broker container.</summary>
    [JsonPropertyName("kafkaContainer")]
    public V1KafkaNodePoolSpecTemplateKafkaContainer? KafkaContainer { get; set; }

    /// <summary>Template for the Kafka init container.</summary>
    [JsonPropertyName("initContainer")]
    public V1KafkaNodePoolSpecTemplateInitContainer? InitContainer { get; set; }
}

/// <summary>The specification of the KafkaNodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolSpec
{
    /// <summary>The number of pods in the pool.</summary>
    [JsonPropertyName("replicas")]
    public required int Replicas { get; set; }

    /// <summary>Storage configuration (disk). Cannot be updated.</summary>
    [JsonPropertyName("storage")]
    public required V1KafkaNodePoolSpecStorage Storage { get; set; }

    /// <summary>The roles assigned to the node pool. Supported values are `broker` and `controller`. This property is required.</summary>
    [JsonPropertyName("roles")]
    public required IList<V1KafkaNodePoolSpecRolesEnum> Roles { get; set; }

    /// <summary>CPU and memory resources to reserve.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaNodePoolSpecResources? Resources { get; set; }

    /// <summary>JVM Options for pods.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaNodePoolSpecJvmOptions? JvmOptions { get; set; }

    /// <summary>Template for pool resources. The template allows users to specify how the resources belonging to this pool are generated.</summary>
    [JsonPropertyName("template")]
    public V1KafkaNodePoolSpecTemplate? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolStatusConditions
{
    /// <summary>The unique identifier of a condition, used to distinguish between other conditions in the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The status of the condition, either True, False or Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Last time the condition of a type changed from one status to another. The required format is &apos;yyyy-MM-ddTHH:mm:ssZ&apos;, in the UTC time zone.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>The reason for the condition&apos;s last transition (a single word in CamelCase).</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Human-readable message indicating details about the condition&apos;s last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaNodePoolStatusRolesEnum>))]
public enum V1KafkaNodePoolStatusRolesEnum
{
    [EnumMember(Value = "controller"), JsonStringEnumMemberName("controller")]
    Controller,
    [EnumMember(Value = "broker"), JsonStringEnumMemberName("broker")]
    Broker
}

/// <summary>The status of the KafkaNodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaNodePoolStatus
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaNodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Node IDs used by Kafka nodes in this pool.</summary>
    [JsonPropertyName("nodeIds")]
    public IList<int>? NodeIds { get; set; }

    /// <summary>Kafka cluster ID.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>The roles currently assigned to this pool.</summary>
    [JsonPropertyName("roles")]
    public IList<V1KafkaNodePoolStatusRolesEnum>? Roles { get; set; }

    /// <summary>The current number of pods being used to provide this resource.</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary>Label selector for pods providing this resource.</summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaNodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaNodePoolSpec>, IStatus<V1KafkaNodePoolStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaNodePool";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkanodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaNodePool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the KafkaNodePool.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaNodePoolSpec Spec { get; set; }

    /// <summary>The status of the KafkaNodePool.</summary>
    [JsonPropertyName("status")]
    public V1KafkaNodePoolStatus? Status { get; set; }
}
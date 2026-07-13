#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gamelift.aws.upbound.io;
/// <summary>Fleet is the Schema for the Fleets API. Provides a GameLift Fleet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FleetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Fleet>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FleetList";
    public const string KubeGroup = "gamelift.aws.upbound.io";
    public const string KubePluralName = "fleet";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gamelift.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FleetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Fleet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Fleet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecDeletionPolicyEnum>))]
public enum V1beta2FleetSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderBuildIdRefPolicyResolutionEnum>))]
public enum V1beta2FleetSpecForProviderBuildIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderBuildIdRefPolicyResolveEnum>))]
public enum V1beta2FleetSpecForProviderBuildIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderBuildIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecForProviderBuildIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecForProviderBuildIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderBuildIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FleetSpecForProviderBuildIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderBuildIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FleetSpecForProviderBuildIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderBuildIdSelectorPolicyResolveEnum>))]
public enum V1beta2FleetSpecForProviderBuildIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderBuildIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecForProviderBuildIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecForProviderBuildIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderBuildIdSelector
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
    public V1beta2FleetSpecForProviderBuildIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderCertificateConfiguration
{
    /// <summary>Indicates whether a TLS/SSL certificate is generated for a fleet. Valid values are DISABLED and GENERATED. Default value is DISABLED.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderEc2InboundPermission
{
    /// <summary>Starting value for a range of allowed port numbers.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Range of allowed IP addresses expressed in CIDR notationE.g., 000.000.000.000/[subnet mask] or 0.0.0.0/[subnet mask].</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Network communication protocol used by the fleetE.g., TCP or UDP</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderInstanceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2FleetSpecForProviderInstanceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderInstanceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2FleetSpecForProviderInstanceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderInstanceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecForProviderInstanceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecForProviderInstanceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderInstanceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FleetSpecForProviderInstanceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderInstanceRoleArnSelector
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
    public V1beta2FleetSpecForProviderInstanceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderResourceCreationLimitPolicy
{
    /// <summary>Maximum number of game sessions that an individual can create during the policy period.</summary>
    [JsonPropertyName("newGameSessionsPerCreator")]
    public double? NewGameSessionsPerCreator { get; set; }

    /// <summary>Time span used in evaluating the resource creation limit policy.</summary>
    [JsonPropertyName("policyPeriodInMinutes")]
    public double? PolicyPeriodInMinutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderRuntimeConfigurationServerProcess
{
    /// <summary>Number of server processes using this configuration to run concurrently on an instance.</summary>
    [JsonPropertyName("concurrentExecutions")]
    public double? ConcurrentExecutions { get; set; }

    /// <summary>Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances C:\game, and for Linux instances /local/game.</summary>
    [JsonPropertyName("launchPath")]
    public string? LaunchPath { get; set; }

    /// <summary>Optional list of parameters to pass to the server executable on launch.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProviderRuntimeConfiguration
{
    /// <summary>Maximum amount of time (in seconds) that a game session can remain in status ACTIVATING.</summary>
    [JsonPropertyName("gameSessionActivationTimeoutSeconds")]
    public double? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>Maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously.</summary>
    [JsonPropertyName("maxConcurrentGameSessionActivations")]
    public double? MaxConcurrentGameSessionActivations { get; set; }

    /// <summary>Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.</summary>
    [JsonPropertyName("serverProcess")]
    public IList<V1beta2FleetSpecForProviderRuntimeConfigurationServerProcess>? ServerProcess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecForProvider
{
    /// <summary>ID of the GameLift Build to be deployed on the fleet. Conflicts with script_id.</summary>
    [JsonPropertyName("buildId")]
    public string? BuildId { get; set; }

    /// <summary>Reference to a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdRef")]
    public V1beta2FleetSpecForProviderBuildIdRef? BuildIdRef { get; set; }

    /// <summary>Selector for a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdSelector")]
    public V1beta2FleetSpecForProviderBuildIdSelector? BuildIdSelector { get; set; }

    /// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
    [JsonPropertyName("certificateConfiguration")]
    public V1beta2FleetSpecForProviderCertificateConfiguration? CertificateConfiguration { get; set; }

    /// <summary>Human-readable description of the fleet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.</summary>
    [JsonPropertyName("ec2InboundPermission")]
    public IList<V1beta2FleetSpecForProviderEc2InboundPermission>? Ec2InboundPermission { get; set; }

    /// <summary>Name of an EC2 instance typeE.g., t2.micro</summary>
    [JsonPropertyName("ec2InstanceType")]
    public string? Ec2InstanceType { get; set; }

    /// <summary>Type of fleet. This value must be ON_DEMAND or SPOT. Defaults to ON_DEMAND.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>ARN of an IAM role that instances in the fleet can assume.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnRef")]
    public V1beta2FleetSpecForProviderInstanceRoleArnRef? InstanceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnSelector")]
    public V1beta2FleetSpecForProviderInstanceRoleArnSelector? InstanceRoleArnSelector { get; set; }

    /// <summary>List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to default.</summary>
    [JsonPropertyName("metricGroups")]
    public IList<string>? MetricGroups { get; set; }

    /// <summary>The name of the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Game session protection policy to apply to all instances in this fleetE.g., FullProtection. Defaults to NoProtection.</summary>
    [JsonPropertyName("newGameSessionProtectionPolicy")]
    public string? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
    [JsonPropertyName("resourceCreationLimitPolicy")]
    public V1beta2FleetSpecForProviderResourceCreationLimitPolicy? ResourceCreationLimitPolicy { get; set; }

    /// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
    [JsonPropertyName("runtimeConfiguration")]
    public V1beta2FleetSpecForProviderRuntimeConfiguration? RuntimeConfiguration { get; set; }

    /// <summary>ID of the GameLift Script to be deployed on the fleet. Conflicts with build_id.</summary>
    [JsonPropertyName("scriptId")]
    public string? ScriptId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderBuildIdRefPolicyResolutionEnum>))]
public enum V1beta2FleetSpecInitProviderBuildIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderBuildIdRefPolicyResolveEnum>))]
public enum V1beta2FleetSpecInitProviderBuildIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderBuildIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecInitProviderBuildIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecInitProviderBuildIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderBuildIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FleetSpecInitProviderBuildIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderBuildIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FleetSpecInitProviderBuildIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderBuildIdSelectorPolicyResolveEnum>))]
public enum V1beta2FleetSpecInitProviderBuildIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderBuildIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecInitProviderBuildIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecInitProviderBuildIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderBuildIdSelector
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
    public V1beta2FleetSpecInitProviderBuildIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderCertificateConfiguration
{
    /// <summary>Indicates whether a TLS/SSL certificate is generated for a fleet. Valid values are DISABLED and GENERATED. Default value is DISABLED.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderEc2InboundPermission
{
    /// <summary>Starting value for a range of allowed port numbers.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Range of allowed IP addresses expressed in CIDR notationE.g., 000.000.000.000/[subnet mask] or 0.0.0.0/[subnet mask].</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Network communication protocol used by the fleetE.g., TCP or UDP</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderInstanceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FleetSpecInitProviderInstanceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderInstanceRoleArnSelector
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
    public V1beta2FleetSpecInitProviderInstanceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderResourceCreationLimitPolicy
{
    /// <summary>Maximum number of game sessions that an individual can create during the policy period.</summary>
    [JsonPropertyName("newGameSessionsPerCreator")]
    public double? NewGameSessionsPerCreator { get; set; }

    /// <summary>Time span used in evaluating the resource creation limit policy.</summary>
    [JsonPropertyName("policyPeriodInMinutes")]
    public double? PolicyPeriodInMinutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderRuntimeConfigurationServerProcess
{
    /// <summary>Number of server processes using this configuration to run concurrently on an instance.</summary>
    [JsonPropertyName("concurrentExecutions")]
    public double? ConcurrentExecutions { get; set; }

    /// <summary>Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances C:\game, and for Linux instances /local/game.</summary>
    [JsonPropertyName("launchPath")]
    public string? LaunchPath { get; set; }

    /// <summary>Optional list of parameters to pass to the server executable on launch.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecInitProviderRuntimeConfiguration
{
    /// <summary>Maximum amount of time (in seconds) that a game session can remain in status ACTIVATING.</summary>
    [JsonPropertyName("gameSessionActivationTimeoutSeconds")]
    public double? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>Maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously.</summary>
    [JsonPropertyName("maxConcurrentGameSessionActivations")]
    public double? MaxConcurrentGameSessionActivations { get; set; }

    /// <summary>Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.</summary>
    [JsonPropertyName("serverProcess")]
    public IList<V1beta2FleetSpecInitProviderRuntimeConfigurationServerProcess>? ServerProcess { get; set; }
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
public partial class V1beta2FleetSpecInitProvider
{
    /// <summary>ID of the GameLift Build to be deployed on the fleet. Conflicts with script_id.</summary>
    [JsonPropertyName("buildId")]
    public string? BuildId { get; set; }

    /// <summary>Reference to a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdRef")]
    public V1beta2FleetSpecInitProviderBuildIdRef? BuildIdRef { get; set; }

    /// <summary>Selector for a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdSelector")]
    public V1beta2FleetSpecInitProviderBuildIdSelector? BuildIdSelector { get; set; }

    /// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
    [JsonPropertyName("certificateConfiguration")]
    public V1beta2FleetSpecInitProviderCertificateConfiguration? CertificateConfiguration { get; set; }

    /// <summary>Human-readable description of the fleet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.</summary>
    [JsonPropertyName("ec2InboundPermission")]
    public IList<V1beta2FleetSpecInitProviderEc2InboundPermission>? Ec2InboundPermission { get; set; }

    /// <summary>Name of an EC2 instance typeE.g., t2.micro</summary>
    [JsonPropertyName("ec2InstanceType")]
    public string? Ec2InstanceType { get; set; }

    /// <summary>Type of fleet. This value must be ON_DEMAND or SPOT. Defaults to ON_DEMAND.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>ARN of an IAM role that instances in the fleet can assume.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnRef")]
    public V1beta2FleetSpecInitProviderInstanceRoleArnRef? InstanceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnSelector")]
    public V1beta2FleetSpecInitProviderInstanceRoleArnSelector? InstanceRoleArnSelector { get; set; }

    /// <summary>List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to default.</summary>
    [JsonPropertyName("metricGroups")]
    public IList<string>? MetricGroups { get; set; }

    /// <summary>The name of the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Game session protection policy to apply to all instances in this fleetE.g., FullProtection. Defaults to NoProtection.</summary>
    [JsonPropertyName("newGameSessionProtectionPolicy")]
    public string? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
    [JsonPropertyName("resourceCreationLimitPolicy")]
    public V1beta2FleetSpecInitProviderResourceCreationLimitPolicy? ResourceCreationLimitPolicy { get; set; }

    /// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
    [JsonPropertyName("runtimeConfiguration")]
    public V1beta2FleetSpecInitProviderRuntimeConfiguration? RuntimeConfiguration { get; set; }

    /// <summary>ID of the GameLift Script to be deployed on the fleet. Conflicts with build_id.</summary>
    [JsonPropertyName("scriptId")]
    public string? ScriptId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecManagementPoliciesEnum>))]
public enum V1beta2FleetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FleetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FleetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FleetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FleetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FleetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FleetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FleetSpec defines the desired state of Fleet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetSpec
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
    public V1beta2FleetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FleetSpecForProvider ForProvider { get; set; }

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
    public V1beta2FleetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FleetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FleetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FleetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatusAtProviderCertificateConfiguration
{
    /// <summary>Indicates whether a TLS/SSL certificate is generated for a fleet. Valid values are DISABLED and GENERATED. Default value is DISABLED.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatusAtProviderEc2InboundPermission
{
    /// <summary>Starting value for a range of allowed port numbers.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Range of allowed IP addresses expressed in CIDR notationE.g., 000.000.000.000/[subnet mask] or 0.0.0.0/[subnet mask].</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Network communication protocol used by the fleetE.g., TCP or UDP</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatusAtProviderResourceCreationLimitPolicy
{
    /// <summary>Maximum number of game sessions that an individual can create during the policy period.</summary>
    [JsonPropertyName("newGameSessionsPerCreator")]
    public double? NewGameSessionsPerCreator { get; set; }

    /// <summary>Time span used in evaluating the resource creation limit policy.</summary>
    [JsonPropertyName("policyPeriodInMinutes")]
    public double? PolicyPeriodInMinutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatusAtProviderRuntimeConfigurationServerProcess
{
    /// <summary>Number of server processes using this configuration to run concurrently on an instance.</summary>
    [JsonPropertyName("concurrentExecutions")]
    public double? ConcurrentExecutions { get; set; }

    /// <summary>Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances C:\game, and for Linux instances /local/game.</summary>
    [JsonPropertyName("launchPath")]
    public string? LaunchPath { get; set; }

    /// <summary>Optional list of parameters to pass to the server executable on launch.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatusAtProviderRuntimeConfiguration
{
    /// <summary>Maximum amount of time (in seconds) that a game session can remain in status ACTIVATING.</summary>
    [JsonPropertyName("gameSessionActivationTimeoutSeconds")]
    public double? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>Maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously.</summary>
    [JsonPropertyName("maxConcurrentGameSessionActivations")]
    public double? MaxConcurrentGameSessionActivations { get; set; }

    /// <summary>Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.</summary>
    [JsonPropertyName("serverProcess")]
    public IList<V1beta2FleetStatusAtProviderRuntimeConfigurationServerProcess>? ServerProcess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatusAtProvider
{
    /// <summary>Fleet ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Build ARN.</summary>
    [JsonPropertyName("buildArn")]
    public string? BuildArn { get; set; }

    /// <summary>ID of the GameLift Build to be deployed on the fleet. Conflicts with script_id.</summary>
    [JsonPropertyName("buildId")]
    public string? BuildId { get; set; }

    /// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
    [JsonPropertyName("certificateConfiguration")]
    public V1beta2FleetStatusAtProviderCertificateConfiguration? CertificateConfiguration { get; set; }

    /// <summary>Human-readable description of the fleet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.</summary>
    [JsonPropertyName("ec2InboundPermission")]
    public IList<V1beta2FleetStatusAtProviderEc2InboundPermission>? Ec2InboundPermission { get; set; }

    /// <summary>Name of an EC2 instance typeE.g., t2.micro</summary>
    [JsonPropertyName("ec2InstanceType")]
    public string? Ec2InstanceType { get; set; }

    /// <summary>Type of fleet. This value must be ON_DEMAND or SPOT. Defaults to ON_DEMAND.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>Fleet ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of an IAM role that instances in the fleet can assume.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    [JsonPropertyName("logPaths")]
    public IList<string>? LogPaths { get; set; }

    /// <summary>List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to default.</summary>
    [JsonPropertyName("metricGroups")]
    public IList<string>? MetricGroups { get; set; }

    /// <summary>The name of the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Game session protection policy to apply to all instances in this fleetE.g., FullProtection. Defaults to NoProtection.</summary>
    [JsonPropertyName("newGameSessionProtectionPolicy")]
    public string? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>Operating system of the fleet&apos;s computing resources.</summary>
    [JsonPropertyName("operatingSystem")]
    public string? OperatingSystem { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
    [JsonPropertyName("resourceCreationLimitPolicy")]
    public V1beta2FleetStatusAtProviderResourceCreationLimitPolicy? ResourceCreationLimitPolicy { get; set; }

    /// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
    [JsonPropertyName("runtimeConfiguration")]
    public V1beta2FleetStatusAtProviderRuntimeConfiguration? RuntimeConfiguration { get; set; }

    /// <summary>Script ARN.</summary>
    [JsonPropertyName("scriptArn")]
    public string? ScriptArn { get; set; }

    /// <summary>ID of the GameLift Script to be deployed on the fleet. Conflicts with build_id.</summary>
    [JsonPropertyName("scriptId")]
    public string? ScriptId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatusConditions
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

/// <summary>FleetStatus defines the observed state of Fleet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FleetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FleetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FleetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Fleet is the Schema for the Fleets API. Provides a GameLift Fleet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Fleet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FleetSpec>, IStatus<V1beta2FleetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Fleet";
    public const string KubeGroup = "gamelift.aws.upbound.io";
    public const string KubePluralName = "fleet";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gamelift.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Fleet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FleetSpec defines the desired state of Fleet</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FleetSpec Spec { get; set; }

    /// <summary>FleetStatus defines the observed state of Fleet.</summary>
    [JsonPropertyName("status")]
    public V1beta2FleetStatus? Status { get; set; }
}
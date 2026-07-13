#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.gcp.upbound.io;
/// <summary>Instance is the Schema for the Instances API. A managed alloydb cluster instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Instance>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "alloydb.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alloydb.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Instance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Instance> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecDeletionPolicyEnum>))]
public enum V1beta2InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// SSL config option for this instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderClientConnectionConfigSslConfig
{
    /// <summary>
    /// SSL mode. Specifies client-server SSL/TLS connection behavior.
    /// Possible values are: ENCRYPTED_ONLY, ALLOW_UNENCRYPTED_AND_ENCRYPTED.
    /// </summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}

/// <summary>
/// Client connection specific configurations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderClientConnectionConfig
{
    /// <summary>Configuration to enforce connectors only (ex: AuthProxy) connections to the database.</summary>
    [JsonPropertyName("requireConnectors")]
    public bool? RequireConnectors { get; set; }

    /// <summary>
    /// SSL config option for this instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sslConfig")]
    public V1beta2InstanceSpecForProviderClientConnectionConfigSslConfig? SslConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderClusterRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderClusterRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderClusterRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderClusterRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderClusterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in alloydb to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderClusterRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderClusterSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderClusterSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderClusterSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderClusterSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in alloydb to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderClusterSelector
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
    public V1beta2InstanceSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderInstanceTypeRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderInstanceTypeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderInstanceTypeRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderInstanceTypeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInstanceTypeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderInstanceTypeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderInstanceTypeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInstanceTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderInstanceTypeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInstanceTypeSelector
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
    public V1beta2InstanceSpecForProviderInstanceTypeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configurations for the machines that host the underlying database engine.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderMachineConfig
{
    /// <summary>The number of CPU&apos;s in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }

    /// <summary>
    /// Machine type of the VM instance.
    /// E.g. &quot;n2-highmem-4&quot;, &quot;n2-highmem-8&quot;, &quot;c4a-highmem-4-lssd&quot;.
    /// cpu_count must match the number of vCPUs in the machine type.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorized network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}

/// <summary>
/// Instance level network configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworkConfig
{
    /// <summary>
    /// Name of the allocated IP range for the private IP AlloyDB instance, for example: &quot;google-managed-services-default&quot;.
    /// If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster.
    /// The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.
    /// </summary>
    [JsonPropertyName("allocatedIpRangeOverride")]
    public string? AllocatedIpRangeOverride { get; set; }

    /// <summary>
    /// A list of external networks authorized to access this instance. This
    /// field is only allowed to be set when enable_public_ip is set to
    /// true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1beta2InstanceSpecForProviderNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Enabling outbound public ip for the instance.</summary>
    [JsonPropertyName("enableOutboundPublicIp")]
    public bool? EnableOutboundPublicIp { get; set; }

    /// <summary>
    /// Enabling public ip for the instance. If a user wishes to disable this,
    /// please also clear the list of the authorized external networks set on
    /// the same instance.
    /// </summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPscInstanceConfigPscAutoConnections
{
    /// <summary>
    /// The consumer network for the PSC service automation, example:
    /// &quot;projects/vpc-host-project/global/networks/default&quot;.
    /// The consumer network might be hosted a different project than the
    /// consumer project. The API expects the consumer project specified to be
    /// the project ID (and not the project number)
    /// </summary>
    [JsonPropertyName("consumerNetwork")]
    public string? ConsumerNetwork { get; set; }

    /// <summary>
    /// The consumer project to which the PSC service automation endpoint will
    /// be created. The API expects the consumer project to be the project ID(
    /// and not the project number).
    /// </summary>
    [JsonPropertyName("consumerProject")]
    public string? ConsumerProject { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPscInstanceConfigPscInterfaceConfigs
{
    /// <summary>
    /// The network attachment resource created in the consumer project to which the PSC interface will be linked.
    /// This is of the format: &quot;projects/${CONSUMER_PROJECT}/regions/${REGION}/networkAttachments/${NETWORK_ATTACHMENT_NAME}&quot;.
    /// The network attachment must be in the same region as the instance.
    /// </summary>
    [JsonPropertyName("networkAttachmentResource")]
    public string? NetworkAttachmentResource { get; set; }
}

/// <summary>
/// Configuration for Private Service Connect (PSC) for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPscInstanceConfig
{
    /// <summary>
    /// List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance.
    /// These should be specified as project numbers only.
    /// </summary>
    [JsonPropertyName("allowedConsumerProjects")]
    public IList<string>? AllowedConsumerProjects { get; set; }

    /// <summary>
    /// Configurations for setting up PSC service automation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscAutoConnections")]
    public IList<V1beta2InstanceSpecForProviderPscInstanceConfigPscAutoConnections>? PscAutoConnections { get; set; }

    /// <summary>
    /// Configurations for setting up PSC interfaces attached to the instance
    /// which are used for outbound connectivity. Currently, AlloyDB supports only 0 or 1 PSC interface.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInterfaceConfigs")]
    public IList<V1beta2InstanceSpecForProviderPscInstanceConfigPscInterfaceConfigs>? PscInterfaceConfigs { get; set; }
}

/// <summary>
/// Configuration for query insights.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderQueryInsightsConfig
{
    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Record client address for an instance. Client address is PII information. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary>
/// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProvider
{
    /// <summary>
    /// &apos;Specifies whether an instance needs to spin up. Once the instance is
    /// active, the activation policy can be updated to the NEVER to stop the
    /// instance. Likewise, the activation policy can be updated to ALWAYS to
    /// start the instance.
    /// There are restrictions around when an instance can/cannot be activated (for
    /// example, a read pool instance should be stopped before stopping primary
    /// etc.). Please refer to the API documentation for more details.
    /// Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.&apos;
    /// Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.
    /// </summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// Note: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field effective_annotations for all of the annotations present on the resource.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// &apos;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.&apos;
    /// Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.
    /// </summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary>
    /// Client connection specific configurations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientConnectionConfig")]
    public V1beta2InstanceSpecForProviderClientConnectionConfig? ClientConnectionConfig { get; set; }

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &apos;projects/{project}/locations/{location}/clusters/{cluster_id}&apos;
    /// </summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in alloydb to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta2InstanceSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in alloydb to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta2InstanceSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>
    /// The type of the instance.
    /// If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the depends_on meta-data attribute.
    /// If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY.
    /// Example: {instance_type = google_alloydb_cluster.&lt;secondary_cluster_name&gt;.
    /// Use deletion_policy = &quot;FORCE&quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
    /// Possible values are: PRIMARY, READ_POOL, SECONDARY.
    /// </summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeRef")]
    public V1beta2InstanceSpecForProviderInstanceTypeRef? InstanceTypeRef { get; set; }

    /// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeSelector")]
    public V1beta2InstanceSpecForProviderInstanceTypeSelector? InstanceTypeSelector { get; set; }

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Configurations for the machines that host the underlying database engine.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("machineConfig")]
    public V1beta2InstanceSpecForProviderMachineConfig? MachineConfig { get; set; }

    /// <summary>
    /// Instance level network configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2InstanceSpecForProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInstanceConfig")]
    public V1beta2InstanceSpecForProviderPscInstanceConfig? PscInstanceConfig { get; set; }

    /// <summary>
    /// Configuration for query insights.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryInsightsConfig")]
    public V1beta2InstanceSpecForProviderQueryInsightsConfig? QueryInsightsConfig { get; set; }

    /// <summary>
    /// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readPoolConfig")]
    public V1beta2InstanceSpecForProviderReadPoolConfig? ReadPoolConfig { get; set; }
}

/// <summary>
/// SSL config option for this instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderClientConnectionConfigSslConfig
{
    /// <summary>
    /// SSL mode. Specifies client-server SSL/TLS connection behavior.
    /// Possible values are: ENCRYPTED_ONLY, ALLOW_UNENCRYPTED_AND_ENCRYPTED.
    /// </summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}

/// <summary>
/// Client connection specific configurations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderClientConnectionConfig
{
    /// <summary>Configuration to enforce connectors only (ex: AuthProxy) connections to the database.</summary>
    [JsonPropertyName("requireConnectors")]
    public bool? RequireConnectors { get; set; }

    /// <summary>
    /// SSL config option for this instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sslConfig")]
    public V1beta2InstanceSpecInitProviderClientConnectionConfigSslConfig? SslConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderInstanceTypeRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderInstanceTypeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderInstanceTypeRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderInstanceTypeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInstanceTypeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderInstanceTypeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderInstanceTypeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInstanceTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderInstanceTypeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInstanceTypeSelector
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
    public V1beta2InstanceSpecInitProviderInstanceTypeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configurations for the machines that host the underlying database engine.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderMachineConfig
{
    /// <summary>The number of CPU&apos;s in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }

    /// <summary>
    /// Machine type of the VM instance.
    /// E.g. &quot;n2-highmem-4&quot;, &quot;n2-highmem-8&quot;, &quot;c4a-highmem-4-lssd&quot;.
    /// cpu_count must match the number of vCPUs in the machine type.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorized network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}

/// <summary>
/// Instance level network configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworkConfig
{
    /// <summary>
    /// Name of the allocated IP range for the private IP AlloyDB instance, for example: &quot;google-managed-services-default&quot;.
    /// If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster.
    /// The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.
    /// </summary>
    [JsonPropertyName("allocatedIpRangeOverride")]
    public string? AllocatedIpRangeOverride { get; set; }

    /// <summary>
    /// A list of external networks authorized to access this instance. This
    /// field is only allowed to be set when enable_public_ip is set to
    /// true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1beta2InstanceSpecInitProviderNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Enabling outbound public ip for the instance.</summary>
    [JsonPropertyName("enableOutboundPublicIp")]
    public bool? EnableOutboundPublicIp { get; set; }

    /// <summary>
    /// Enabling public ip for the instance. If a user wishes to disable this,
    /// please also clear the list of the authorized external networks set on
    /// the same instance.
    /// </summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPscInstanceConfigPscAutoConnections
{
    /// <summary>
    /// The consumer network for the PSC service automation, example:
    /// &quot;projects/vpc-host-project/global/networks/default&quot;.
    /// The consumer network might be hosted a different project than the
    /// consumer project. The API expects the consumer project specified to be
    /// the project ID (and not the project number)
    /// </summary>
    [JsonPropertyName("consumerNetwork")]
    public string? ConsumerNetwork { get; set; }

    /// <summary>
    /// The consumer project to which the PSC service automation endpoint will
    /// be created. The API expects the consumer project to be the project ID(
    /// and not the project number).
    /// </summary>
    [JsonPropertyName("consumerProject")]
    public string? ConsumerProject { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPscInstanceConfigPscInterfaceConfigs
{
    /// <summary>
    /// The network attachment resource created in the consumer project to which the PSC interface will be linked.
    /// This is of the format: &quot;projects/${CONSUMER_PROJECT}/regions/${REGION}/networkAttachments/${NETWORK_ATTACHMENT_NAME}&quot;.
    /// The network attachment must be in the same region as the instance.
    /// </summary>
    [JsonPropertyName("networkAttachmentResource")]
    public string? NetworkAttachmentResource { get; set; }
}

/// <summary>
/// Configuration for Private Service Connect (PSC) for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPscInstanceConfig
{
    /// <summary>
    /// List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance.
    /// These should be specified as project numbers only.
    /// </summary>
    [JsonPropertyName("allowedConsumerProjects")]
    public IList<string>? AllowedConsumerProjects { get; set; }

    /// <summary>
    /// Configurations for setting up PSC service automation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscAutoConnections")]
    public IList<V1beta2InstanceSpecInitProviderPscInstanceConfigPscAutoConnections>? PscAutoConnections { get; set; }

    /// <summary>
    /// Configurations for setting up PSC interfaces attached to the instance
    /// which are used for outbound connectivity. Currently, AlloyDB supports only 0 or 1 PSC interface.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInterfaceConfigs")]
    public IList<V1beta2InstanceSpecInitProviderPscInstanceConfigPscInterfaceConfigs>? PscInterfaceConfigs { get; set; }
}

/// <summary>
/// Configuration for query insights.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderQueryInsightsConfig
{
    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Record client address for an instance. Client address is PII information. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary>
/// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }
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
public partial class V1beta2InstanceSpecInitProvider
{
    /// <summary>
    /// &apos;Specifies whether an instance needs to spin up. Once the instance is
    /// active, the activation policy can be updated to the NEVER to stop the
    /// instance. Likewise, the activation policy can be updated to ALWAYS to
    /// start the instance.
    /// There are restrictions around when an instance can/cannot be activated (for
    /// example, a read pool instance should be stopped before stopping primary
    /// etc.). Please refer to the API documentation for more details.
    /// Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.&apos;
    /// Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.
    /// </summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// Note: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field effective_annotations for all of the annotations present on the resource.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// &apos;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.&apos;
    /// Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.
    /// </summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary>
    /// Client connection specific configurations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientConnectionConfig")]
    public V1beta2InstanceSpecInitProviderClientConnectionConfig? ClientConnectionConfig { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>
    /// The type of the instance.
    /// If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the depends_on meta-data attribute.
    /// If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY.
    /// Example: {instance_type = google_alloydb_cluster.&lt;secondary_cluster_name&gt;.
    /// Use deletion_policy = &quot;FORCE&quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
    /// Possible values are: PRIMARY, READ_POOL, SECONDARY.
    /// </summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeRef")]
    public V1beta2InstanceSpecInitProviderInstanceTypeRef? InstanceTypeRef { get; set; }

    /// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeSelector")]
    public V1beta2InstanceSpecInitProviderInstanceTypeSelector? InstanceTypeSelector { get; set; }

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Configurations for the machines that host the underlying database engine.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("machineConfig")]
    public V1beta2InstanceSpecInitProviderMachineConfig? MachineConfig { get; set; }

    /// <summary>
    /// Instance level network configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2InstanceSpecInitProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInstanceConfig")]
    public V1beta2InstanceSpecInitProviderPscInstanceConfig? PscInstanceConfig { get; set; }

    /// <summary>
    /// Configuration for query insights.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryInsightsConfig")]
    public V1beta2InstanceSpecInitProviderQueryInsightsConfig? QueryInsightsConfig { get; set; }

    /// <summary>
    /// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readPoolConfig")]
    public V1beta2InstanceSpecInitProviderReadPoolConfig? ReadPoolConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecManagementPoliciesEnum>))]
public enum V1beta2InstanceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpec
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
    public V1beta2InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta2InstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// SSL config option for this instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderClientConnectionConfigSslConfig
{
    /// <summary>
    /// SSL mode. Specifies client-server SSL/TLS connection behavior.
    /// Possible values are: ENCRYPTED_ONLY, ALLOW_UNENCRYPTED_AND_ENCRYPTED.
    /// </summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}

/// <summary>
/// Client connection specific configurations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderClientConnectionConfig
{
    /// <summary>Configuration to enforce connectors only (ex: AuthProxy) connections to the database.</summary>
    [JsonPropertyName("requireConnectors")]
    public bool? RequireConnectors { get; set; }

    /// <summary>
    /// SSL config option for this instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sslConfig")]
    public V1beta2InstanceStatusAtProviderClientConnectionConfigSslConfig? SslConfig { get; set; }
}

/// <summary>
/// Configurations for the machines that host the underlying database engine.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMachineConfig
{
    /// <summary>The number of CPU&apos;s in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }

    /// <summary>
    /// Machine type of the VM instance.
    /// E.g. &quot;n2-highmem-4&quot;, &quot;n2-highmem-8&quot;, &quot;c4a-highmem-4-lssd&quot;.
    /// cpu_count must match the number of vCPUs in the machine type.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorized network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}

/// <summary>
/// Instance level network configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderNetworkConfig
{
    /// <summary>
    /// Name of the allocated IP range for the private IP AlloyDB instance, for example: &quot;google-managed-services-default&quot;.
    /// If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster.
    /// The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.
    /// </summary>
    [JsonPropertyName("allocatedIpRangeOverride")]
    public string? AllocatedIpRangeOverride { get; set; }

    /// <summary>
    /// A list of external networks authorized to access this instance. This
    /// field is only allowed to be set when enable_public_ip is set to
    /// true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1beta2InstanceStatusAtProviderNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Enabling outbound public ip for the instance.</summary>
    [JsonPropertyName("enableOutboundPublicIp")]
    public bool? EnableOutboundPublicIp { get; set; }

    /// <summary>
    /// Enabling public ip for the instance. If a user wishes to disable this,
    /// please also clear the list of the authorized external networks set on
    /// the same instance.
    /// </summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPscInstanceConfigPscAutoConnections
{
    /// <summary>
    /// The consumer network for the PSC service automation, example:
    /// &quot;projects/vpc-host-project/global/networks/default&quot;.
    /// The consumer network might be hosted a different project than the
    /// consumer project. The API expects the consumer project specified to be
    /// the project ID (and not the project number)
    /// </summary>
    [JsonPropertyName("consumerNetwork")]
    public string? ConsumerNetwork { get; set; }

    /// <summary>
    /// (Output)
    /// The status of the service connection policy.
    /// </summary>
    [JsonPropertyName("consumerNetworkStatus")]
    public string? ConsumerNetworkStatus { get; set; }

    /// <summary>
    /// The consumer project to which the PSC service automation endpoint will
    /// be created. The API expects the consumer project to be the project ID(
    /// and not the project number).
    /// </summary>
    [JsonPropertyName("consumerProject")]
    public string? ConsumerProject { get; set; }

    /// <summary>
    /// (Output)
    /// The IP address of the PSC service automation endpoint.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// (Output)
    /// The status of the PSC service automation connection.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPscInstanceConfigPscInterfaceConfigs
{
    /// <summary>
    /// The network attachment resource created in the consumer project to which the PSC interface will be linked.
    /// This is of the format: &quot;projects/${CONSUMER_PROJECT}/regions/${REGION}/networkAttachments/${NETWORK_ATTACHMENT_NAME}&quot;.
    /// The network attachment must be in the same region as the instance.
    /// </summary>
    [JsonPropertyName("networkAttachmentResource")]
    public string? NetworkAttachmentResource { get; set; }
}

/// <summary>
/// Configuration for Private Service Connect (PSC) for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPscInstanceConfig
{
    /// <summary>
    /// List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance.
    /// These should be specified as project numbers only.
    /// </summary>
    [JsonPropertyName("allowedConsumerProjects")]
    public IList<string>? AllowedConsumerProjects { get; set; }

    /// <summary>
    /// Configurations for setting up PSC service automation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscAutoConnections")]
    public IList<V1beta2InstanceStatusAtProviderPscInstanceConfigPscAutoConnections>? PscAutoConnections { get; set; }

    /// <summary>
    /// (Output)
    /// The DNS name of the instance for PSC connectivity.
    /// Name convention: ...alloydb-psc.goog
    /// </summary>
    [JsonPropertyName("pscDnsName")]
    public string? PscDnsName { get; set; }

    /// <summary>
    /// Configurations for setting up PSC interfaces attached to the instance
    /// which are used for outbound connectivity. Currently, AlloyDB supports only 0 or 1 PSC interface.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInterfaceConfigs")]
    public IList<V1beta2InstanceStatusAtProviderPscInstanceConfigPscInterfaceConfigs>? PscInterfaceConfigs { get; set; }

    /// <summary>
    /// (Output)
    /// The service attachment created when Private Service Connect (PSC) is enabled for the instance.
    /// The name of the resource will be in the format of
    /// projects/&lt;alloydb-tenant-project-number&gt;/regions/&lt;region-name&gt;/serviceAttachments/&lt;service-attachment-name&gt;
    /// </summary>
    [JsonPropertyName("serviceAttachmentLink")]
    public string? ServiceAttachmentLink { get; set; }
}

/// <summary>
/// Configuration for query insights.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderQueryInsightsConfig
{
    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Record client address for an instance. Client address is PII information. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary>
/// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProvider
{
    /// <summary>
    /// &apos;Specifies whether an instance needs to spin up. Once the instance is
    /// active, the activation policy can be updated to the NEVER to stop the
    /// instance. Likewise, the activation policy can be updated to ALWAYS to
    /// start the instance.
    /// There are restrictions around when an instance can/cannot be activated (for
    /// example, a read pool instance should be stopped before stopping primary
    /// etc.). Please refer to the API documentation for more details.
    /// Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.&apos;
    /// Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.
    /// </summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// Note: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field effective_annotations for all of the annotations present on the resource.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// &apos;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.&apos;
    /// Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.
    /// </summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary>
    /// Client connection specific configurations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientConnectionConfig")]
    public V1beta2InstanceStatusAtProviderClientConnectionConfig? ClientConnectionConfig { get; set; }

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &apos;projects/{project}/locations/{location}/clusters/{cluster_id}&apos;
    /// </summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Time the Instance was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>an identifier for the resource with format {{cluster}}/instances/{{instance_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The type of the instance.
    /// If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the depends_on meta-data attribute.
    /// If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY.
    /// Example: {instance_type = google_alloydb_cluster.&lt;secondary_cluster_name&gt;.
    /// Use deletion_policy = &quot;FORCE&quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
    /// Possible values are: PRIMARY, READ_POOL, SECONDARY.
    /// </summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The IP address for the Instance. This is the connection endpoint for an end-user application.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Configurations for the machines that host the underlying database engine.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("machineConfig")]
    public V1beta2InstanceStatusAtProviderMachineConfig? MachineConfig { get; set; }

    /// <summary>The name of the instance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Instance level network configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2InstanceStatusAtProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>
    /// The outbound public IP addresses for the instance. This is available ONLY when
    /// networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used
    /// for outbound connections.
    /// </summary>
    [JsonPropertyName("outboundPublicIpAddresses")]
    public IList<string>? OutboundPublicIpAddresses { get; set; }

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInstanceConfig")]
    public V1beta2InstanceStatusAtProviderPscInstanceConfig? PscInstanceConfig { get; set; }

    /// <summary>
    /// The public IP addresses for the Instance. This is available ONLY when
    /// networkConfig.enablePublicIp is set to true. This is the connection
    /// endpoint for an end-user application.
    /// </summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>
    /// Configuration for query insights.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryInsightsConfig")]
    public V1beta2InstanceStatusAtProviderQueryInsightsConfig? QueryInsightsConfig { get; set; }

    /// <summary>
    /// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readPoolConfig")]
    public V1beta2InstanceStatusAtProviderReadPoolConfig? ReadPoolConfig { get; set; }

    /// <summary>Set to true if the current state of Instance does not match the user&apos;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The current state of the alloydb instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The system-generated UID of the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Time the Instance was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusConditions
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

/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Instance is the Schema for the Instances API. A managed alloydb cluster instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceSpec>, IStatus<V1beta2InstanceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "alloydb.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alloydb.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Instance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceStatus? Status { get; set; }
}
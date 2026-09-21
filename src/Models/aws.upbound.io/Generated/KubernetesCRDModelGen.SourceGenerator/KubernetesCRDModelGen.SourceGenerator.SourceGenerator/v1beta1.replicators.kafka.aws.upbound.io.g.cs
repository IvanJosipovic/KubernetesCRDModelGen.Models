#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.aws.upbound.io;
/// <summary>Replicator is the Schema for the Replicators API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReplicatorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Replicator>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReplicatorList";
    public const string KubeGroup = "kafka.aws.upbound.io";
    public const string KubePluralName = "replicators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReplicatorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Replicator objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Replicator> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecDeletionPolicyEnum>))]
public enum V1beta1ReplicatorSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelector
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
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon MSK cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskCluster
{
    /// <summary>The ARN of an Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnRef")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRef? MskClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelector? MskClusterArnSelector { get; set; }
}

/// <summary>Details of a self-managed or on-premises Apache Kafka cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The Kafka cluster.id of the self-managed or on-premises Apache Kafka cluster (as reported by the cluster itself, e.g. via the Kafka admin tooling), not an arbitrary name. MSK Replicator validates this value against the source cluster. See Migrate third-party and self-managed Apache Kafka clusters to Amazon MSK for how to obtain the cluster ID and the other required inputs.</summary>
    [JsonPropertyName("apacheKafkaClusterId")]
    public string? ApacheKafkaClusterId { get; set; }

    /// <summary>The bootstrap broker connection string used to connect to the Apache Kafka cluster.</summary>
    [JsonPropertyName("bootstrapBrokerString")]
    public string? BootstrapBrokerString { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelector
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
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of the mTLS client authentication used by the Kafka cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtls
{
    /// <summary>The ARN of the AWS Secrets Manager secret that stores the private key and certificate used for mTLS authentication. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnRef")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnRef? SecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtlsSecretArnSelector? SecretArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelector
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
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of the SASL/SCRAM client authentication used by the Kafka cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScram
{
    /// <summary>The SASL/SCRAM mechanism used for authentication. Valid values are SHA256 and SHA512.</summary>
    [JsonPropertyName("mechanism")]
    public string? Mechanism { get; set; }

    /// <summary>The ARN of the AWS Secrets Manager secret that stores the private key and certificate used for mTLS authentication. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnRef")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnRef? SecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelector? SecretArnSelector { get; set; }
}

/// <summary>Details of the client authentication used by the Kafka cluster. Only valid for an apache_kafka_cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthentication
{
    /// <summary>Details of the mTLS client authentication used by the Kafka cluster. Detailed below.</summary>
    [JsonPropertyName("mtls")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationMtls? Mtls { get; set; }

    /// <summary>Details of the SASL/SCRAM client authentication used by the Kafka cluster. Detailed below.</summary>
    [JsonPropertyName("saslScram")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthenticationSaslScram? SaslScram { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate rootCaCertificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate rootCaCertificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelector
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
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of encryption in transit to the Kafka cluster. Only valid for an apache_kafka_cluster. TLS encryption in transit is always applied to an apache_kafka_cluster; this block is only required to supply a custom root CA chain (for a cluster using a private or self-signed certificate). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The ARN of the AWS Secrets Manager secret that stores the custom root CA certificate chain used to trust the certificate authority of the Apache Kafka cluster. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("rootCaCertificate")]
    public string? RootCaCertificate { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate rootCaCertificate.</summary>
    [JsonPropertyName("rootCaCertificateRef")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateRef? RootCaCertificateRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate rootCaCertificate.</summary>
    [JsonPropertyName("rootCaCertificateSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransitRootCaCertificateSelector? RootCaCertificateSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector
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
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelector
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
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Kafka cluster. Provide this on the amazon_msk_cluster entry only; the replicator reaches the Apache Kafka cluster through that VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfig
{
    /// <summary>The AWS security groups to associate with the ENIs used by the replicator. If a security group is not specified, the default security group associated with the VPC is used.</summary>
    [JsonPropertyName("securityGroupsIds")]
    public IList<string>? SecurityGroupsIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsRefs")]
    public IList<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs>? SecurityGroupsIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector? SecurityGroupsIdsSelector { get; set; }

    /// <summary>List of subnets to connect to in the VPC. AWS creates elastic network interfaces inside these subnets to allow communication between your Kafka Cluster and the replicator.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaCluster
{
    /// <summary>Details of an Amazon MSK cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
    [JsonPropertyName("amazonMskCluster")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskCluster? AmazonMskCluster { get; set; }

    /// <summary>Details of a self-managed or on-premises Apache Kafka cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterApacheKafkaCluster? ApacheKafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Kafka cluster. Only valid for an apache_kafka_cluster. Detailed below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Kafka cluster. Only valid for an apache_kafka_cluster. TLS encryption in transit is always applied to an apache_kafka_cluster; this block is only required to supply a custom root CA chain (for a cluster using a private or self-signed certificate). Detailed below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterEncryptionInTransit? EncryptionInTransit { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Kafka cluster. Provide this on the amazon_msk_cluster entry only; the replicator reaches the Apache Kafka cluster through that VPC.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelector
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
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon CloudWatch Logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogs
{
    /// <summary>Boolean whether to enable log delivery to CloudWatch Logs.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of CloudWatch Logs log group. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelector
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
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon Data Firehose. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehose
{
    /// <summary>Name of the Firehose delivery stream. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Boolean whether to enable log delivery to Firehose.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelector
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
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon S3. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3
{
    /// <summary>Name of the S3 bucket. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Boolean whether to enable log delivery to S3.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to use when storing replicator logs in S3. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for replicator log delivery. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDelivery
{
    /// <summary>Configuration block for replicator log delivery to Amazon CloudWatch Logs. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block for replicator log delivery to Amazon Data Firehose. Detailed below.</summary>
    [JsonPropertyName("firehose")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryFirehose? Firehose { get; set; }

    /// <summary>Configuration block for replicator log delivery to Amazon S3. Detailed below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDeliveryS3? S3 { get; set; }
}

/// <summary>Configuration block for delivering replicator logs to customer destinations. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderLogDelivery
{
    /// <summary>Configuration block for replicator log delivery. Detailed below.</summary>
    [JsonPropertyName("replicatorLogDelivery")]
    public V1beta1ReplicatorSpecForProviderLogDeliveryReplicatorLogDelivery? ReplicatorLogDelivery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListConsumerGroupReplication
{
    /// <summary>Consumer group offset synchronization mode. Valid values are LEGACY and ENHANCED. With LEGACY, offsets are synchronized when producers write to the source cluster. With ENHANCED, consumer offsets are synchronized regardless of producer location. ENHANCED requires a corresponding replicator that replicates data from the target cluster to the source cluster and requires topic_name_configuration.type to be set to IDENTICAL. Defaults to LEGACY. Changing this value will force a new resource.</summary>
    [JsonPropertyName("consumerGroupOffsetSyncMode")]
    public string? ConsumerGroupOffsetSyncMode { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups that should not be replicated.</summary>
    [JsonPropertyName("consumerGroupsToExclude")]
    public IList<string>? ConsumerGroupsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups to copy.</summary>
    [JsonPropertyName("consumerGroupsToReplicate")]
    public IList<string>? ConsumerGroupsToReplicate { get; set; }

    /// <summary>Whether to periodically check for new consumer groups.</summary>
    [JsonPropertyName("detectAndCopyNewConsumerGroups")]
    public bool? DetectAndCopyNewConsumerGroups { get; set; }

    /// <summary>Whether to periodically write the translated offsets to __consumer_offsets topic in target cluster.</summary>
    [JsonPropertyName("synchroniseConsumerGroupOffsets")]
    public bool? SynchroniseConsumerGroupOffsets { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelector
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
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelector
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
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationStartingPosition
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for specifying replicated topic names should be the same as their corresponding upstream topics or prefixed with source cluster alias.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationTopicNameConfiguration
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplication
{
    /// <summary>Whether to periodically configure remote topic ACLs to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyAccessControlListsForTopics")]
    public bool? CopyAccessControlListsForTopics { get; set; }

    /// <summary>Whether to periodically configure remote topics to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyTopicConfigurations")]
    public bool? CopyTopicConfigurations { get; set; }

    /// <summary>Whether to periodically check for new topics and partitions.</summary>
    [JsonPropertyName("detectAndCopyNewTopics")]
    public bool? DetectAndCopyNewTopics { get; set; }

    /// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
    [JsonPropertyName("startingPosition")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationStartingPosition? StartingPosition { get; set; }

    /// <summary>Configuration for specifying replicated topic names should be the same as their corresponding upstream topics or prefixed with source cluster alias.</summary>
    [JsonPropertyName("topicNameConfiguration")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration { get; set; }

    /// <summary>List of regular expression patterns indicating the topics that should not be replica.</summary>
    [JsonPropertyName("topicsToExclude")]
    public IList<string>? TopicsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the topics to copy.</summary>
    [JsonPropertyName("topicsToReplicate")]
    public IList<string>? TopicsToReplicate { get; set; }
}

/// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoList
{
    /// <summary>Configuration relating to consumer group replication.</summary>
    [JsonPropertyName("consumerGroupReplication")]
    public IList<V1beta1ReplicatorSpecForProviderReplicationInfoListConsumerGroupReplication>? ConsumerGroupReplication { get; set; }

    /// <summary>The ARN of the source Kafka cluster. Use for an Amazon MSK source. Exactly one of source_kafka_cluster_arn or source_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("sourceKafkaClusterArn")]
    public string? SourceKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRef? SourceKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelector? SourceKafkaClusterArnSelector { get; set; }

    /// <summary>The identifier of the source Kafka cluster. Use for a self-managed / on-premises Apache Kafka source (matches apache_kafka_cluster_id). Exactly one of source_kafka_cluster_arn or source_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("sourceKafkaClusterId")]
    public string? SourceKafkaClusterId { get; set; }

    /// <summary>The type of compression to use writing records to target Kafka cluster.</summary>
    [JsonPropertyName("targetCompressionType")]
    public string? TargetCompressionType { get; set; }

    /// <summary>The ARN of the target Kafka cluster. Use for an Amazon MSK target. Exactly one of target_kafka_cluster_arn or target_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("targetKafkaClusterArn")]
    public string? TargetKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRef? TargetKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelector? TargetKafkaClusterArnSelector { get; set; }

    /// <summary>The identifier of the target Kafka cluster. Use for a self-managed / on-premises Apache Kafka target (matches apache_kafka_cluster_id). Exactly one of target_kafka_cluster_arn or target_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("targetKafkaClusterId")]
    public string? TargetKafkaClusterId { get; set; }

    /// <summary>Configuration relating to topic replication.</summary>
    [JsonPropertyName("topicReplication")]
    public IList<V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplication>? TopicReplication { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelector
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
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProvider
{
    /// <summary>A summary description of the replicator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The source and target Kafka clusters for the replicator. Exactly two blocks are required. Detailed below.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ReplicatorSpecForProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>Configuration block for delivering replicator logs to customer destinations. Detailed below.</summary>
    [JsonPropertyName("logDelivery")]
    public V1beta1ReplicatorSpecForProviderLogDelivery? LogDelivery { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
    [JsonPropertyName("replicationInfoList")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoList? ReplicationInfoList { get; set; }

    /// <summary>The name of the replicator.</summary>
    [JsonPropertyName("replicatorName")]
    public string? ReplicatorName { get; set; }

    /// <summary>The ARN of the IAM role used by the replicator to access resources in the customer&apos;s account (e.g source and target clusters).</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelector
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
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon MSK cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskCluster
{
    /// <summary>The ARN of an Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnRef")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRef? MskClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelector? MskClusterArnSelector { get; set; }
}

/// <summary>Details of a self-managed or on-premises Apache Kafka cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The Kafka cluster.id of the self-managed or on-premises Apache Kafka cluster (as reported by the cluster itself, e.g. via the Kafka admin tooling), not an arbitrary name. MSK Replicator validates this value against the source cluster. See Migrate third-party and self-managed Apache Kafka clusters to Amazon MSK for how to obtain the cluster ID and the other required inputs.</summary>
    [JsonPropertyName("apacheKafkaClusterId")]
    public string? ApacheKafkaClusterId { get; set; }

    /// <summary>The bootstrap broker connection string used to connect to the Apache Kafka cluster.</summary>
    [JsonPropertyName("bootstrapBrokerString")]
    public string? BootstrapBrokerString { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelector
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
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of the mTLS client authentication used by the Kafka cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtls
{
    /// <summary>The ARN of the AWS Secrets Manager secret that stores the private key and certificate used for mTLS authentication. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnRef")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnRef? SecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtlsSecretArnSelector? SecretArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelector
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
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of the SASL/SCRAM client authentication used by the Kafka cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScram
{
    /// <summary>The SASL/SCRAM mechanism used for authentication. Valid values are SHA256 and SHA512.</summary>
    [JsonPropertyName("mechanism")]
    public string? Mechanism { get; set; }

    /// <summary>The ARN of the AWS Secrets Manager secret that stores the private key and certificate used for mTLS authentication. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnRef")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnRef? SecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScramSecretArnSelector? SecretArnSelector { get; set; }
}

/// <summary>Details of the client authentication used by the Kafka cluster. Only valid for an apache_kafka_cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthentication
{
    /// <summary>Details of the mTLS client authentication used by the Kafka cluster. Detailed below.</summary>
    [JsonPropertyName("mtls")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationMtls? Mtls { get; set; }

    /// <summary>Details of the SASL/SCRAM client authentication used by the Kafka cluster. Detailed below.</summary>
    [JsonPropertyName("saslScram")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthenticationSaslScram? SaslScram { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate rootCaCertificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate rootCaCertificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelector
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
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of encryption in transit to the Kafka cluster. Only valid for an apache_kafka_cluster. TLS encryption in transit is always applied to an apache_kafka_cluster; this block is only required to supply a custom root CA chain (for a cluster using a private or self-signed certificate). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The ARN of the AWS Secrets Manager secret that stores the custom root CA certificate chain used to trust the certificate authority of the Apache Kafka cluster. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("rootCaCertificate")]
    public string? RootCaCertificate { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate rootCaCertificate.</summary>
    [JsonPropertyName("rootCaCertificateRef")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateRef? RootCaCertificateRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate rootCaCertificate.</summary>
    [JsonPropertyName("rootCaCertificateSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransitRootCaCertificateSelector? RootCaCertificateSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector
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
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelector
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
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Kafka cluster. Provide this on the amazon_msk_cluster entry only; the replicator reaches the Apache Kafka cluster through that VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfig
{
    /// <summary>The AWS security groups to associate with the ENIs used by the replicator. If a security group is not specified, the default security group associated with the VPC is used.</summary>
    [JsonPropertyName("securityGroupsIds")]
    public IList<string>? SecurityGroupsIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsRefs")]
    public IList<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs>? SecurityGroupsIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector? SecurityGroupsIdsSelector { get; set; }

    /// <summary>List of subnets to connect to in the VPC. AWS creates elastic network interfaces inside these subnets to allow communication between your Kafka Cluster and the replicator.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaCluster
{
    /// <summary>Details of an Amazon MSK cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
    [JsonPropertyName("amazonMskCluster")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskCluster? AmazonMskCluster { get; set; }

    /// <summary>Details of a self-managed or on-premises Apache Kafka cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterApacheKafkaCluster? ApacheKafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Kafka cluster. Only valid for an apache_kafka_cluster. Detailed below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Kafka cluster. Only valid for an apache_kafka_cluster. TLS encryption in transit is always applied to an apache_kafka_cluster; this block is only required to supply a custom root CA chain (for a cluster using a private or self-signed certificate). Detailed below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterEncryptionInTransit? EncryptionInTransit { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Kafka cluster. Provide this on the amazon_msk_cluster entry only; the replicator reaches the Apache Kafka cluster through that VPC.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelector
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
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon CloudWatch Logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogs
{
    /// <summary>Boolean whether to enable log delivery to CloudWatch Logs.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of CloudWatch Logs log group. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelector
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
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon Data Firehose. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehose
{
    /// <summary>Name of the Firehose delivery stream. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Boolean whether to enable log delivery to Firehose.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelector
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
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon S3. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3
{
    /// <summary>Name of the S3 bucket. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Boolean whether to enable log delivery to S3.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to use when storing replicator logs in S3. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for replicator log delivery. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDelivery
{
    /// <summary>Configuration block for replicator log delivery to Amazon CloudWatch Logs. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block for replicator log delivery to Amazon Data Firehose. Detailed below.</summary>
    [JsonPropertyName("firehose")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryFirehose? Firehose { get; set; }

    /// <summary>Configuration block for replicator log delivery to Amazon S3. Detailed below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDeliveryS3? S3 { get; set; }
}

/// <summary>Configuration block for delivering replicator logs to customer destinations. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderLogDelivery
{
    /// <summary>Configuration block for replicator log delivery. Detailed below.</summary>
    [JsonPropertyName("replicatorLogDelivery")]
    public V1beta1ReplicatorSpecInitProviderLogDeliveryReplicatorLogDelivery? ReplicatorLogDelivery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListConsumerGroupReplication
{
    /// <summary>Consumer group offset synchronization mode. Valid values are LEGACY and ENHANCED. With LEGACY, offsets are synchronized when producers write to the source cluster. With ENHANCED, consumer offsets are synchronized regardless of producer location. ENHANCED requires a corresponding replicator that replicates data from the target cluster to the source cluster and requires topic_name_configuration.type to be set to IDENTICAL. Defaults to LEGACY. Changing this value will force a new resource.</summary>
    [JsonPropertyName("consumerGroupOffsetSyncMode")]
    public string? ConsumerGroupOffsetSyncMode { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups that should not be replicated.</summary>
    [JsonPropertyName("consumerGroupsToExclude")]
    public IList<string>? ConsumerGroupsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups to copy.</summary>
    [JsonPropertyName("consumerGroupsToReplicate")]
    public IList<string>? ConsumerGroupsToReplicate { get; set; }

    /// <summary>Whether to periodically check for new consumer groups.</summary>
    [JsonPropertyName("detectAndCopyNewConsumerGroups")]
    public bool? DetectAndCopyNewConsumerGroups { get; set; }

    /// <summary>Whether to periodically write the translated offsets to __consumer_offsets topic in target cluster.</summary>
    [JsonPropertyName("synchroniseConsumerGroupOffsets")]
    public bool? SynchroniseConsumerGroupOffsets { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelector
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
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelector
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
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationStartingPosition
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for specifying replicated topic names should be the same as their corresponding upstream topics or prefixed with source cluster alias.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationTopicNameConfiguration
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplication
{
    /// <summary>Whether to periodically configure remote topic ACLs to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyAccessControlListsForTopics")]
    public bool? CopyAccessControlListsForTopics { get; set; }

    /// <summary>Whether to periodically configure remote topics to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyTopicConfigurations")]
    public bool? CopyTopicConfigurations { get; set; }

    /// <summary>Whether to periodically check for new topics and partitions.</summary>
    [JsonPropertyName("detectAndCopyNewTopics")]
    public bool? DetectAndCopyNewTopics { get; set; }

    /// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
    [JsonPropertyName("startingPosition")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationStartingPosition? StartingPosition { get; set; }

    /// <summary>Configuration for specifying replicated topic names should be the same as their corresponding upstream topics or prefixed with source cluster alias.</summary>
    [JsonPropertyName("topicNameConfiguration")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration { get; set; }

    /// <summary>List of regular expression patterns indicating the topics that should not be replica.</summary>
    [JsonPropertyName("topicsToExclude")]
    public IList<string>? TopicsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the topics to copy.</summary>
    [JsonPropertyName("topicsToReplicate")]
    public IList<string>? TopicsToReplicate { get; set; }
}

/// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoList
{
    /// <summary>Configuration relating to consumer group replication.</summary>
    [JsonPropertyName("consumerGroupReplication")]
    public IList<V1beta1ReplicatorSpecInitProviderReplicationInfoListConsumerGroupReplication>? ConsumerGroupReplication { get; set; }

    /// <summary>The ARN of the source Kafka cluster. Use for an Amazon MSK source. Exactly one of source_kafka_cluster_arn or source_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("sourceKafkaClusterArn")]
    public string? SourceKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRef? SourceKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelector? SourceKafkaClusterArnSelector { get; set; }

    /// <summary>The identifier of the source Kafka cluster. Use for a self-managed / on-premises Apache Kafka source (matches apache_kafka_cluster_id). Exactly one of source_kafka_cluster_arn or source_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("sourceKafkaClusterId")]
    public string? SourceKafkaClusterId { get; set; }

    /// <summary>The type of compression to use writing records to target Kafka cluster.</summary>
    [JsonPropertyName("targetCompressionType")]
    public string? TargetCompressionType { get; set; }

    /// <summary>The ARN of the target Kafka cluster. Use for an Amazon MSK target. Exactly one of target_kafka_cluster_arn or target_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("targetKafkaClusterArn")]
    public string? TargetKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRef? TargetKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelector? TargetKafkaClusterArnSelector { get; set; }

    /// <summary>The identifier of the target Kafka cluster. Use for a self-managed / on-premises Apache Kafka target (matches apache_kafka_cluster_id). Exactly one of target_kafka_cluster_arn or target_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("targetKafkaClusterId")]
    public string? TargetKafkaClusterId { get; set; }

    /// <summary>Configuration relating to topic replication.</summary>
    [JsonPropertyName("topicReplication")]
    public IList<V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplication>? TopicReplication { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelector
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
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProvider
{
    /// <summary>A summary description of the replicator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The source and target Kafka clusters for the replicator. Exactly two blocks are required. Detailed below.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ReplicatorSpecInitProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>Configuration block for delivering replicator logs to customer destinations. Detailed below.</summary>
    [JsonPropertyName("logDelivery")]
    public V1beta1ReplicatorSpecInitProviderLogDelivery? LogDelivery { get; set; }

    /// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
    [JsonPropertyName("replicationInfoList")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoList? ReplicationInfoList { get; set; }

    /// <summary>The name of the replicator.</summary>
    [JsonPropertyName("replicatorName")]
    public string? ReplicatorName { get; set; }

    /// <summary>The ARN of the IAM role used by the replicator to access resources in the customer&apos;s account (e.g source and target clusters).</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecManagementPoliciesEnum>))]
public enum V1beta1ReplicatorSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1ReplicatorSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicatorSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1ReplicatorSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReplicatorSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReplicatorSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ReplicatorSpec defines the desired state of Replicator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpec
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
    public V1beta1ReplicatorSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ReplicatorSpecForProvider ForProvider { get; set; }

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
    public V1beta1ReplicatorSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ReplicatorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReplicatorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReplicatorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Details of an Amazon MSK cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterAmazonMskCluster
{
    /// <summary>The ARN of an Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }
}

/// <summary>Details of a self-managed or on-premises Apache Kafka cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The Kafka cluster.id of the self-managed or on-premises Apache Kafka cluster (as reported by the cluster itself, e.g. via the Kafka admin tooling), not an arbitrary name. MSK Replicator validates this value against the source cluster. See Migrate third-party and self-managed Apache Kafka clusters to Amazon MSK for how to obtain the cluster ID and the other required inputs.</summary>
    [JsonPropertyName("apacheKafkaClusterId")]
    public string? ApacheKafkaClusterId { get; set; }

    /// <summary>The bootstrap broker connection string used to connect to the Apache Kafka cluster.</summary>
    [JsonPropertyName("bootstrapBrokerString")]
    public string? BootstrapBrokerString { get; set; }
}

/// <summary>Details of the mTLS client authentication used by the Kafka cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterClientAuthenticationMtls
{
    /// <summary>The ARN of the AWS Secrets Manager secret that stores the private key and certificate used for mTLS authentication. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Details of the SASL/SCRAM client authentication used by the Kafka cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterClientAuthenticationSaslScram
{
    /// <summary>The SASL/SCRAM mechanism used for authentication. Valid values are SHA256 and SHA512.</summary>
    [JsonPropertyName("mechanism")]
    public string? Mechanism { get; set; }

    /// <summary>The ARN of the AWS Secrets Manager secret that stores the private key and certificate used for mTLS authentication. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Details of the client authentication used by the Kafka cluster. Only valid for an apache_kafka_cluster. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterClientAuthentication
{
    /// <summary>Details of the mTLS client authentication used by the Kafka cluster. Detailed below.</summary>
    [JsonPropertyName("mtls")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterClientAuthenticationMtls? Mtls { get; set; }

    /// <summary>Details of the SASL/SCRAM client authentication used by the Kafka cluster. Detailed below.</summary>
    [JsonPropertyName("saslScram")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterClientAuthenticationSaslScram? SaslScram { get; set; }
}

/// <summary>Details of encryption in transit to the Kafka cluster. Only valid for an apache_kafka_cluster. TLS encryption in transit is always applied to an apache_kafka_cluster; this block is only required to supply a custom root CA chain (for a cluster using a private or self-signed certificate). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The ARN of the AWS Secrets Manager secret that stores the custom root CA certificate chain used to trust the certificate authority of the Apache Kafka cluster. See Set up prerequisites for MSK Replicator with self-managed Apache Kafka clusters for the required secret contents and format.</summary>
    [JsonPropertyName("rootCaCertificate")]
    public string? RootCaCertificate { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Kafka cluster. Provide this on the amazon_msk_cluster entry only; the replicator reaches the Apache Kafka cluster through that VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterVpcConfig
{
    /// <summary>The AWS security groups to associate with the ENIs used by the replicator. If a security group is not specified, the default security group associated with the VPC is used.</summary>
    [JsonPropertyName("securityGroupsIds")]
    public IList<string>? SecurityGroupsIds { get; set; }

    /// <summary>List of subnets to connect to in the VPC. AWS creates elastic network interfaces inside these subnets to allow communication between your Kafka Cluster and the replicator.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaCluster
{
    /// <summary>Details of an Amazon MSK cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
    [JsonPropertyName("amazonMskCluster")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterAmazonMskCluster? AmazonMskCluster { get; set; }

    /// <summary>Details of a self-managed or on-premises Apache Kafka cluster. Exactly one of amazon_msk_cluster or apache_kafka_cluster must be specified. Detailed below.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterApacheKafkaCluster? ApacheKafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Kafka cluster. Only valid for an apache_kafka_cluster. Detailed below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Kafka cluster. Only valid for an apache_kafka_cluster. TLS encryption in transit is always applied to an apache_kafka_cluster; this block is only required to supply a custom root CA chain (for a cluster using a private or self-signed certificate). Detailed below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterEncryptionInTransit? EncryptionInTransit { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Kafka cluster. Provide this on the amazon_msk_cluster entry only; the replicator reaches the Apache Kafka cluster through that VPC.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterVpcConfig? VpcConfig { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon CloudWatch Logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogs
{
    /// <summary>Boolean whether to enable log delivery to CloudWatch Logs.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of CloudWatch Logs log group. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon Data Firehose. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDeliveryFirehose
{
    /// <summary>Name of the Firehose delivery stream. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Boolean whether to enable log delivery to Firehose.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for replicator log delivery to Amazon S3. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDeliveryS3
{
    /// <summary>Name of the S3 bucket. Required if enabled is true. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Boolean whether to enable log delivery to S3.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to use when storing replicator logs in S3. If enabled is false, this value must not be set.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for replicator log delivery. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDelivery
{
    /// <summary>Configuration block for replicator log delivery to Amazon CloudWatch Logs. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDeliveryCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block for replicator log delivery to Amazon Data Firehose. Detailed below.</summary>
    [JsonPropertyName("firehose")]
    public V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDeliveryFirehose? Firehose { get; set; }

    /// <summary>Configuration block for replicator log delivery to Amazon S3. Detailed below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDeliveryS3? S3 { get; set; }
}

/// <summary>Configuration block for delivering replicator logs to customer destinations. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderLogDelivery
{
    /// <summary>Configuration block for replicator log delivery. Detailed below.</summary>
    [JsonPropertyName("replicatorLogDelivery")]
    public V1beta1ReplicatorStatusAtProviderLogDeliveryReplicatorLogDelivery? ReplicatorLogDelivery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListConsumerGroupReplication
{
    /// <summary>Consumer group offset synchronization mode. Valid values are LEGACY and ENHANCED. With LEGACY, offsets are synchronized when producers write to the source cluster. With ENHANCED, consumer offsets are synchronized regardless of producer location. ENHANCED requires a corresponding replicator that replicates data from the target cluster to the source cluster and requires topic_name_configuration.type to be set to IDENTICAL. Defaults to LEGACY. Changing this value will force a new resource.</summary>
    [JsonPropertyName("consumerGroupOffsetSyncMode")]
    public string? ConsumerGroupOffsetSyncMode { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups that should not be replicated.</summary>
    [JsonPropertyName("consumerGroupsToExclude")]
    public IList<string>? ConsumerGroupsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups to copy.</summary>
    [JsonPropertyName("consumerGroupsToReplicate")]
    public IList<string>? ConsumerGroupsToReplicate { get; set; }

    /// <summary>Whether to periodically check for new consumer groups.</summary>
    [JsonPropertyName("detectAndCopyNewConsumerGroups")]
    public bool? DetectAndCopyNewConsumerGroups { get; set; }

    /// <summary>Whether to periodically write the translated offsets to __consumer_offsets topic in target cluster.</summary>
    [JsonPropertyName("synchroniseConsumerGroupOffsets")]
    public bool? SynchroniseConsumerGroupOffsets { get; set; }
}

/// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationStartingPosition
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for specifying replicated topic names should be the same as their corresponding upstream topics or prefixed with source cluster alias.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationTopicNameConfiguration
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplication
{
    /// <summary>Whether to periodically configure remote topic ACLs to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyAccessControlListsForTopics")]
    public bool? CopyAccessControlListsForTopics { get; set; }

    /// <summary>Whether to periodically configure remote topics to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyTopicConfigurations")]
    public bool? CopyTopicConfigurations { get; set; }

    /// <summary>Whether to periodically check for new topics and partitions.</summary>
    [JsonPropertyName("detectAndCopyNewTopics")]
    public bool? DetectAndCopyNewTopics { get; set; }

    /// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
    [JsonPropertyName("startingPosition")]
    public V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationStartingPosition? StartingPosition { get; set; }

    /// <summary>Configuration for specifying replicated topic names should be the same as their corresponding upstream topics or prefixed with source cluster alias.</summary>
    [JsonPropertyName("topicNameConfiguration")]
    public V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration { get; set; }

    /// <summary>List of regular expression patterns indicating the topics that should not be replica.</summary>
    [JsonPropertyName("topicsToExclude")]
    public IList<string>? TopicsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the topics to copy.</summary>
    [JsonPropertyName("topicsToReplicate")]
    public IList<string>? TopicsToReplicate { get; set; }
}

/// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoList
{
    /// <summary>Configuration relating to consumer group replication.</summary>
    [JsonPropertyName("consumerGroupReplication")]
    public IList<V1beta1ReplicatorStatusAtProviderReplicationInfoListConsumerGroupReplication>? ConsumerGroupReplication { get; set; }

    [JsonPropertyName("sourceKafkaClusterAlias")]
    public string? SourceKafkaClusterAlias { get; set; }

    /// <summary>The ARN of the source Kafka cluster. Use for an Amazon MSK source. Exactly one of source_kafka_cluster_arn or source_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("sourceKafkaClusterArn")]
    public string? SourceKafkaClusterArn { get; set; }

    /// <summary>The identifier of the source Kafka cluster. Use for a self-managed / on-premises Apache Kafka source (matches apache_kafka_cluster_id). Exactly one of source_kafka_cluster_arn or source_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("sourceKafkaClusterId")]
    public string? SourceKafkaClusterId { get; set; }

    /// <summary>The type of compression to use writing records to target Kafka cluster.</summary>
    [JsonPropertyName("targetCompressionType")]
    public string? TargetCompressionType { get; set; }

    [JsonPropertyName("targetKafkaClusterAlias")]
    public string? TargetKafkaClusterAlias { get; set; }

    /// <summary>The ARN of the target Kafka cluster. Use for an Amazon MSK target. Exactly one of target_kafka_cluster_arn or target_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("targetKafkaClusterArn")]
    public string? TargetKafkaClusterArn { get; set; }

    /// <summary>The identifier of the target Kafka cluster. Use for a self-managed / on-premises Apache Kafka target (matches apache_kafka_cluster_id). Exactly one of target_kafka_cluster_arn or target_kafka_cluster_id must be specified.</summary>
    [JsonPropertyName("targetKafkaClusterId")]
    public string? TargetKafkaClusterId { get; set; }

    /// <summary>Configuration relating to topic replication.</summary>
    [JsonPropertyName("topicReplication")]
    public IList<V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplication>? TopicReplication { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProvider
{
    /// <summary>ARN of the Replicator.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>A summary description of the replicator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The source and target Kafka clusters for the replicator. Exactly two blocks are required. Detailed below.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ReplicatorStatusAtProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>Configuration block for delivering replicator logs to customer destinations. Detailed below.</summary>
    [JsonPropertyName("logDelivery")]
    public V1beta1ReplicatorStatusAtProviderLogDelivery? LogDelivery { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
    [JsonPropertyName("replicationInfoList")]
    public V1beta1ReplicatorStatusAtProviderReplicationInfoList? ReplicationInfoList { get; set; }

    /// <summary>The name of the replicator.</summary>
    [JsonPropertyName("replicatorName")]
    public string? ReplicatorName { get; set; }

    /// <summary>The ARN of the IAM role used by the replicator to access resources in the customer&apos;s account (e.g source and target clusters).</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusConditions
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

/// <summary>ReplicatorStatus defines the observed state of Replicator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ReplicatorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReplicatorStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Replicator is the Schema for the Replicators API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Replicator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReplicatorSpec>, IStatus<V1beta1ReplicatorStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Replicator";
    public const string KubeGroup = "kafka.aws.upbound.io";
    public const string KubePluralName = "replicators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Replicator";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReplicatorSpec defines the desired state of Replicator</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ReplicatorSpec Spec { get; set; }

    /// <summary>ReplicatorStatus defines the observed state of Replicator.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReplicatorStatus? Status { get; set; }
}
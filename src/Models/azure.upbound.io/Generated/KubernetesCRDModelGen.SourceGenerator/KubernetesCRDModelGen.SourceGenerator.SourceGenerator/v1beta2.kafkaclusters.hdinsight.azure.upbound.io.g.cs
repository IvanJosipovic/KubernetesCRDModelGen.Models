#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hdinsight.azure.upbound.io;
/// <summary>KafkaCluster is the Schema for the KafkaClusters API. Manages a HDInsight Kafka Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2KafkaClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2KafkaCluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "KafkaClusterList";
    public const string KubeGroup = "hdinsight.azure.upbound.io";
    public const string KubePluralName = "kafkaclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hdinsight.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2KafkaCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2KafkaCluster> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecDeletionPolicyEnum>))]
public enum V1beta2KafkaClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A component_version block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderComponentVersion
{
    /// <summary>The version of Kafka which should be used for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kafka")]
    public string? Kafka { get; set; }
}

/// <summary>A compute_isolation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderDiskEncryption
{
    /// <summary>This is an algorithm identifier for encryption. Possible values are RSA1_5, RSA-OAEP, RSA-OAEP-256.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>This is indicator to show whether resource disk encryption is enabled.</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The ID of the key vault key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>This is the resource ID of Managed Identity used to access the key vault.</summary>
    [JsonPropertyName("keyVaultManagedIdentityId")]
    public string? KeyVaultManagedIdentityId { get; set; }
}

/// <summary>The workspace key of the log analytics extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderExtensionPrimaryKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An extension block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The workspace key of the log analytics extension.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta2KafkaClusterSpecForProviderExtensionPrimaryKeySecretRef? PrimaryKeySecretRef { get; set; }
}

/// <summary>The password used for the Ambari Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderGatewayPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A gateway block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderGateway
{
    /// <summary>The password used for the Ambari Portal.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderGatewayPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMetastoresAmbariPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An ambari block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderMetastoresAmbariPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMetastoresHivePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A hive block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMetastoresHive
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderMetastoresHivePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMetastoresOoziePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An oozie block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderMetastoresOoziePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A metastores block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public V1beta2KafkaClusterSpecForProviderMetastoresAmbari? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public V1beta2KafkaClusterSpecForProviderMetastoresHive? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public V1beta2KafkaClusterSpecForProviderMetastoresOozie? Oozie { get; set; }
}

/// <summary>The Operations Management Suite (OMS) workspace key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMonitorPrimaryKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A monitor block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Operations Management Suite (OMS) workspace key.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta2KafkaClusterSpecForProviderMonitorPrimaryKeySecretRef? PrimaryKeySecretRef { get; set; }
}

/// <summary>A network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
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
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An ip_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates whether this IP configuration is primary.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The private IP allocation method. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAllocationMethod")]
    public string? PrivateIpAllocationMethod { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>A private_link_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>An ip_configuration block as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfiguration? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderResourceGroupNameSelector
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
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A rest_proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRestProxy
{
    /// <summary>The Azure Active Directory Security Group ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>The Azure Active Directory Security Group name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupName")]
    public string? SecurityGroupName { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesHeadNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A head_node block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesHeadNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecForProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A kafka_management_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesWorkerNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A worker_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesWorkerNode
{
    /// <summary>The number of Data Disks which should be assigned to each Worker Node, which can be between 1 and 8. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("numberOfDisksPerNode")]
    public double? NumberOfDisksPerNode { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecForProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesZookeeperNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A zookeeper_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRolesZookeeperNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>A roles block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderRoles
{
    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public V1beta2KafkaClusterSpecForProviderRolesHeadNode? HeadNode { get; set; }

    /// <summary>A kafka_management_node block as defined below.</summary>
    [JsonPropertyName("kafkaManagementNode")]
    public V1beta2KafkaClusterSpecForProviderRolesKafkaManagementNode? KafkaManagementNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public V1beta2KafkaClusterSpecForProviderRolesWorkerNode? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public V1beta2KafkaClusterSpecForProviderRolesZookeeperNode? ZookeeperNode { get; set; }
}

/// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderSecurityProfile
{
    /// <summary>The resource ID of the Azure Active Directory Domain Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("aaddsResourceId")]
    public string? AaddsResourceId { get; set; }

    /// <summary>A list of the distinguished names for the cluster user groups. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterUsersGroupDns")]
    public IList<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>The name of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUserPasswordSecretRef")]
    public V1beta2KafkaClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef? DomainUserPasswordSecretRef { get; set; }

    /// <summary>The username of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUsername")]
    public string? DomainUsername { get; set; }

    /// <summary>A list of the LDAPS URLs to communicate with the Azure Active Directory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ldapsUrls")]
    public IList<string>? LdapsUrls { get; set; }

    /// <summary>The User Assigned Identity for the HDInsight Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("msiResourceId")]
    public string? MsiResourceId { get; set; }
}

/// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderStorageAccountStorageAccountKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelector
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
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountKeySecretRef")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageAccountKeySecretRef? StorageAccountKeySecretRef { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

/// <summary>A storage_account_gen2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProviderStorageAccountGen2
{
    /// <summary>The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemId")]
    public string? FilesystemId { get; set; }

    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecForProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public V1beta2KafkaClusterSpecForProviderComponentVersion? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public V1beta2KafkaClusterSpecForProviderComputeIsolation? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta2KafkaClusterSpecForProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>Whether encryption in transit is enabled for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionInTransitEnabled")]
    public bool? EncryptionInTransitEnabled { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public V1beta2KafkaClusterSpecForProviderExtension? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public V1beta2KafkaClusterSpecForProviderGateway? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public V1beta2KafkaClusterSpecForProviderMetastores? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public V1beta2KafkaClusterSpecForProviderMonitor? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public V1beta2KafkaClusterSpecForProviderNetwork? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1beta2KafkaClusterSpecForProviderPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2KafkaClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A rest_proxy block as defined below.</summary>
    [JsonPropertyName("restProxy")]
    public V1beta2KafkaClusterSpecForProviderRestProxy? RestProxy { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public V1beta2KafkaClusterSpecForProviderRoles? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public V1beta2KafkaClusterSpecForProviderSecurityProfile? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2KafkaClusterSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public V1beta2KafkaClusterSpecForProviderStorageAccountGen2? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Kafka Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary>A component_version block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderComponentVersion
{
    /// <summary>The version of Kafka which should be used for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kafka")]
    public string? Kafka { get; set; }
}

/// <summary>A compute_isolation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderDiskEncryption
{
    /// <summary>This is an algorithm identifier for encryption. Possible values are RSA1_5, RSA-OAEP, RSA-OAEP-256.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>This is indicator to show whether resource disk encryption is enabled.</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The ID of the key vault key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>This is the resource ID of Managed Identity used to access the key vault.</summary>
    [JsonPropertyName("keyVaultManagedIdentityId")]
    public string? KeyVaultManagedIdentityId { get; set; }
}

/// <summary>The workspace key of the log analytics extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderExtensionPrimaryKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An extension block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The workspace key of the log analytics extension.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderExtensionPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

/// <summary>The password used for the Ambari Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderGatewayPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A gateway block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderGateway
{
    /// <summary>The password used for the Ambari Portal.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderGatewayPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMetastoresAmbariPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An ambari block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderMetastoresAmbariPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMetastoresHivePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A hive block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMetastoresHive
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderMetastoresHivePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMetastoresOoziePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An oozie block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderMetastoresOoziePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A metastores block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public V1beta2KafkaClusterSpecInitProviderMetastoresAmbari? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public V1beta2KafkaClusterSpecInitProviderMetastoresHive? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public V1beta2KafkaClusterSpecInitProviderMetastoresOozie? Oozie { get; set; }
}

/// <summary>The Operations Management Suite (OMS) workspace key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMonitorPrimaryKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A monitor block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Operations Management Suite (OMS) workspace key.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderMonitorPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

/// <summary>A network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
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
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An ip_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates whether this IP configuration is primary.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The private IP allocation method. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAllocationMethod")]
    public string? PrivateIpAllocationMethod { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>A private_link_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>An ip_configuration block as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfiguration? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A rest_proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRestProxy
{
    /// <summary>The Azure Active Directory Security Group ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>The Azure Active Directory Security Group name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupName")]
    public string? SecurityGroupName { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesHeadNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A head_node block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesHeadNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecInitProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A kafka_management_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesWorkerNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A worker_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesWorkerNode
{
    /// <summary>The number of Data Disks which should be assigned to each Worker Node, which can be between 1 and 8. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("numberOfDisksPerNode")]
    public double? NumberOfDisksPerNode { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector
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
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A zookeeper_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRolesZookeeperNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>A roles block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderRoles
{
    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public V1beta2KafkaClusterSpecInitProviderRolesHeadNode? HeadNode { get; set; }

    /// <summary>A kafka_management_node block as defined below.</summary>
    [JsonPropertyName("kafkaManagementNode")]
    public V1beta2KafkaClusterSpecInitProviderRolesKafkaManagementNode? KafkaManagementNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public V1beta2KafkaClusterSpecInitProviderRolesWorkerNode? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public V1beta2KafkaClusterSpecInitProviderRolesZookeeperNode? ZookeeperNode { get; set; }
}

/// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderSecurityProfileDomainUserPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderSecurityProfile
{
    /// <summary>The resource ID of the Azure Active Directory Domain Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("aaddsResourceId")]
    public string? AaddsResourceId { get; set; }

    /// <summary>A list of the distinguished names for the cluster user groups. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterUsersGroupDns")]
    public IList<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>The name of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUserPasswordSecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderSecurityProfileDomainUserPasswordSecretRef DomainUserPasswordSecretRef { get; set; }

    /// <summary>The username of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUsername")]
    public string? DomainUsername { get; set; }

    /// <summary>A list of the LDAPS URLs to communicate with the Azure Active Directory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ldapsUrls")]
    public IList<string>? LdapsUrls { get; set; }

    /// <summary>The User Assigned Identity for the HDInsight Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("msiResourceId")]
    public string? MsiResourceId { get; set; }
}

/// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderStorageAccountStorageAccountKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelector
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
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountKeySecretRef")]
    public required V1beta2KafkaClusterSpecInitProviderStorageAccountStorageAccountKeySecretRef StorageAccountKeySecretRef { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

/// <summary>A storage_account_gen2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecInitProviderStorageAccountGen2
{
    /// <summary>The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemId")]
    public string? FilesystemId { get; set; }

    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
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
public partial class V1beta2KafkaClusterSpecInitProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public V1beta2KafkaClusterSpecInitProviderComponentVersion? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public V1beta2KafkaClusterSpecInitProviderComputeIsolation? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta2KafkaClusterSpecInitProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>Whether encryption in transit is enabled for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionInTransitEnabled")]
    public bool? EncryptionInTransitEnabled { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public V1beta2KafkaClusterSpecInitProviderExtension? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public V1beta2KafkaClusterSpecInitProviderGateway? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public V1beta2KafkaClusterSpecInitProviderMetastores? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public V1beta2KafkaClusterSpecInitProviderMonitor? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public V1beta2KafkaClusterSpecInitProviderNetwork? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1beta2KafkaClusterSpecInitProviderPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>A rest_proxy block as defined below.</summary>
    [JsonPropertyName("restProxy")]
    public V1beta2KafkaClusterSpecInitProviderRestProxy? RestProxy { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public V1beta2KafkaClusterSpecInitProviderRoles? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public V1beta2KafkaClusterSpecInitProviderSecurityProfile? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2KafkaClusterSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public V1beta2KafkaClusterSpecInitProviderStorageAccountGen2? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Kafka Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecManagementPoliciesEnum>))]
public enum V1beta2KafkaClusterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2KafkaClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KafkaClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2KafkaClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KafkaClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KafkaClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KafkaClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>KafkaClusterSpec defines the desired state of KafkaCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterSpec
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
    public V1beta2KafkaClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2KafkaClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta2KafkaClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2KafkaClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2KafkaClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2KafkaClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A component_version block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderComponentVersion
{
    /// <summary>The version of Kafka which should be used for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kafka")]
    public string? Kafka { get; set; }
}

/// <summary>A compute_isolation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderDiskEncryption
{
    /// <summary>This is an algorithm identifier for encryption. Possible values are RSA1_5, RSA-OAEP, RSA-OAEP-256.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>This is indicator to show whether resource disk encryption is enabled.</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The ID of the key vault key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>This is the resource ID of Managed Identity used to access the key vault.</summary>
    [JsonPropertyName("keyVaultManagedIdentityId")]
    public string? KeyVaultManagedIdentityId { get; set; }
}

/// <summary>An extension block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary>A gateway block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderGateway
{
    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>An ambari block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A hive block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderMetastoresHive
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>An oozie block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A metastores block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public V1beta2KafkaClusterStatusAtProviderMetastoresAmbari? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public V1beta2KafkaClusterStatusAtProviderMetastoresHive? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public V1beta2KafkaClusterStatusAtProviderMetastoresOozie? Oozie { get; set; }
}

/// <summary>A monitor block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary>A network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

/// <summary>An ip_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates whether this IP configuration is primary.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The private IP allocation method. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAllocationMethod")]
    public string? PrivateIpAllocationMethod { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>A private_link_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>An ip_configuration block as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public V1beta2KafkaClusterStatusAtProviderPrivateLinkConfigurationIpConfiguration? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A rest_proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRestProxy
{
    /// <summary>The Azure Active Directory Security Group ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>The Azure Active Directory Security Group name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupName")]
    public string? SecurityGroupName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A head_node block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesHeadNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterStatusAtProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesKafkaManagementNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A kafka_management_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesKafkaManagementNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterStatusAtProviderRolesKafkaManagementNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A worker_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesWorkerNode
{
    /// <summary>The number of Data Disks which should be assigned to each Worker Node, which can be between 1 and 8. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("numberOfDisksPerNode")]
    public double? NumberOfDisksPerNode { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterStatusAtProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A zookeeper_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRolesZookeeperNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2KafkaClusterStatusAtProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>A roles block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderRoles
{
    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public V1beta2KafkaClusterStatusAtProviderRolesHeadNode? HeadNode { get; set; }

    /// <summary>A kafka_management_node block as defined below.</summary>
    [JsonPropertyName("kafkaManagementNode")]
    public V1beta2KafkaClusterStatusAtProviderRolesKafkaManagementNode? KafkaManagementNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public V1beta2KafkaClusterStatusAtProviderRolesWorkerNode? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public V1beta2KafkaClusterStatusAtProviderRolesZookeeperNode? ZookeeperNode { get; set; }
}

/// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderSecurityProfile
{
    /// <summary>The resource ID of the Azure Active Directory Domain Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("aaddsResourceId")]
    public string? AaddsResourceId { get; set; }

    /// <summary>A list of the distinguished names for the cluster user groups. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterUsersGroupDns")]
    public IList<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>The name of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The username of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUsername")]
    public string? DomainUsername { get; set; }

    /// <summary>A list of the LDAPS URLs to communicate with the Azure Active Directory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ldapsUrls")]
    public IList<string>? LdapsUrls { get; set; }

    /// <summary>The User Assigned Identity for the HDInsight Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("msiResourceId")]
    public string? MsiResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

/// <summary>A storage_account_gen2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProviderStorageAccountGen2
{
    /// <summary>The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemId")]
    public string? FilesystemId { get; set; }

    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusAtProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public V1beta2KafkaClusterStatusAtProviderComponentVersion? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public V1beta2KafkaClusterStatusAtProviderComputeIsolation? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta2KafkaClusterStatusAtProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>Whether encryption in transit is enabled for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionInTransitEnabled")]
    public bool? EncryptionInTransitEnabled { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public V1beta2KafkaClusterStatusAtProviderExtension? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public V1beta2KafkaClusterStatusAtProviderGateway? Gateway { get; set; }

    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("httpsEndpoint")]
    public string? HttpsEndpoint { get; set; }

    /// <summary>The ID of the HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Kafka Rest Proxy Endpoint for this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("kafkaRestProxyEndpoint")]
    public string? KafkaRestProxyEndpoint { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public V1beta2KafkaClusterStatusAtProviderMetastores? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public V1beta2KafkaClusterStatusAtProviderMonitor? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public V1beta2KafkaClusterStatusAtProviderNetwork? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1beta2KafkaClusterStatusAtProviderPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A rest_proxy block as defined below.</summary>
    [JsonPropertyName("restProxy")]
    public V1beta2KafkaClusterStatusAtProviderRestProxy? RestProxy { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public V1beta2KafkaClusterStatusAtProviderRoles? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public V1beta2KafkaClusterStatusAtProviderSecurityProfile? SecurityProfile { get; set; }

    /// <summary>The SSH Connectivity Endpoint for this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("sshEndpoint")]
    public string? SshEndpoint { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2KafkaClusterStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public V1beta2KafkaClusterStatusAtProviderStorageAccountGen2? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Kafka Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatusConditions
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

/// <summary>KafkaClusterStatus defines the observed state of KafkaCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KafkaClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2KafkaClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2KafkaClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>KafkaCluster is the Schema for the KafkaClusters API. Manages a HDInsight Kafka Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2KafkaCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2KafkaClusterSpec>, IStatus<V1beta2KafkaClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "KafkaCluster";
    public const string KubeGroup = "hdinsight.azure.upbound.io";
    public const string KubePluralName = "kafkaclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hdinsight.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KafkaClusterSpec defines the desired state of KafkaCluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta2KafkaClusterSpec Spec { get; set; }

    /// <summary>KafkaClusterStatus defines the observed state of KafkaCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2KafkaClusterStatus? Status { get; set; }
}
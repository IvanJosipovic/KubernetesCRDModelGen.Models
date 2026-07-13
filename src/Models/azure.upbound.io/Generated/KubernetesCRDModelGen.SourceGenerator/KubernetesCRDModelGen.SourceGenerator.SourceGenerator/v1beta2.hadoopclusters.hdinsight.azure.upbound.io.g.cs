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
/// <summary>HadoopCluster is the Schema for the HadoopClusters API. Manages a HDInsight Hadoop Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HadoopClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2HadoopCluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HadoopClusterList";
    public const string KubeGroup = "hdinsight.azure.upbound.io";
    public const string KubePluralName = "hadoopclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hdinsight.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HadoopClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2HadoopCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2HadoopCluster> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecDeletionPolicyEnum>))]
public enum V1beta2HadoopClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A component_version block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderComponentVersion
{
    /// <summary>The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hadoop")]
    public string? Hadoop { get; set; }
}

/// <summary>A compute_isolation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderComputeIsolation
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
public partial class V1beta2HadoopClusterSpecForProviderDiskEncryption
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
public partial class V1beta2HadoopClusterSpecForProviderExtensionPrimaryKeySecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The workspace key of the log analytics extension.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta2HadoopClusterSpecForProviderExtensionPrimaryKeySecretRef? PrimaryKeySecretRef { get; set; }
}

/// <summary>The password used for the Ambari Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderGatewayPasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderGateway
{
    /// <summary>The password used for the Ambari Portal.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecForProviderGatewayPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderMetastoresAmbariPasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecForProviderMetastoresAmbariPasswordSecretRef? PasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecForProviderMetastoresHivePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderMetastoresHive
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecForProviderMetastoresHivePasswordSecretRef? PasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecForProviderMetastoresOoziePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecForProviderMetastoresOoziePasswordSecretRef? PasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecForProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public V1beta2HadoopClusterSpecForProviderMetastoresAmbari? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public V1beta2HadoopClusterSpecForProviderMetastoresHive? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public V1beta2HadoopClusterSpecForProviderMetastoresOozie? Oozie { get; set; }
}

/// <summary>The Operations Management Suite (OMS) workspace key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderMonitorPrimaryKeySecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Operations Management Suite (OMS) workspace key.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta2HadoopClusterSpecForProviderMonitorPrimaryKeySecretRef? PrimaryKeySecretRef { get; set; }
}

/// <summary>A network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderNetwork
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
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
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An ip_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the uninstall script action.</summary>
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
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>A private_link_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>An ip_configuration block as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfigurationIpConfiguration? IpConfiguration { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderResourceGroupNameSelector
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
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesEdgeNodeHttpsEndpoints
{
    /// <summary>A list of access modes for the application.</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>The destination port to connect to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>The value indicates whether the gateway authentication is enabled or not.</summary>
    [JsonPropertyName("disableGatewayAuth")]
    public bool? DisableGatewayAuth { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The application&apos;s subdomain suffix.</summary>
    [JsonPropertyName("subDomainSuffix")]
    public string? SubDomainSuffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesEdgeNodeInstallScriptAction
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesEdgeNodeUninstallScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A edge_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesEdgeNode
{
    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster. One or more https_endpoints blocks as defined below.</summary>
    [JsonPropertyName("httpsEndpoints")]
    public IList<V1beta2HadoopClusterSpecForProviderRolesEdgeNodeHttpsEndpoints>? HttpsEndpoints { get; set; }

    /// <summary>A install_script_action block as defined below.</summary>
    [JsonPropertyName("installScriptAction")]
    public IList<V1beta2HadoopClusterSpecForProviderRolesEdgeNodeInstallScriptAction>? InstallScriptAction { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>A uninstall_script_actions block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uninstallScriptActions")]
    public IList<V1beta2HadoopClusterSpecForProviderRolesEdgeNodeUninstallScriptActions>? UninstallScriptActions { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesHeadNodePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelector
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
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A head_node block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesHeadNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterSpecForProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

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

/// <summary>A capacity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleCapacity
{
    /// <summary>The maximum number of worker nodes to autoscale to based on the cluster&apos;s activity.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of worker nodes to autoscale to based on the cluster&apos;s activity.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrenceSchedule
{
    /// <summary>The days of the week to perform autoscale. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The time of day to perform the autoscale in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A recurrence block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrence
{
    /// <summary>A list of schedule blocks as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The time zone for the autoscale schedule times.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A autoscale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscale
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleCapacity? Capacity { get; set; }

    /// <summary>A recurrence block as defined below.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrence? Recurrence { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelector
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
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A worker_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesWorkerNode
{
    /// <summary>A autoscale block as defined below.</summary>
    [JsonPropertyName("autoscale")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeAutoscale? Autoscale { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterSpecForProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

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
public partial class V1beta2HadoopClusterSpecForProviderRolesZookeeperNodePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector
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
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A zookeeper_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderRolesZookeeperNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

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
public partial class V1beta2HadoopClusterSpecForProviderRoles
{
    /// <summary>A edge_node block as defined below.</summary>
    [JsonPropertyName("edgeNode")]
    public V1beta2HadoopClusterSpecForProviderRolesEdgeNode? EdgeNode { get; set; }

    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public V1beta2HadoopClusterSpecForProviderRolesHeadNode? HeadNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public V1beta2HadoopClusterSpecForProviderRolesWorkerNode? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public V1beta2HadoopClusterSpecForProviderRolesZookeeperNode? ZookeeperNode { get; set; }
}

/// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecForProviderSecurityProfile
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
    public V1beta2HadoopClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef? DomainUserPasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecForProviderStorageAccountStorageAccountKeySecretRef
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelector
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
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountKeySecretRef")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageAccountKeySecretRef? StorageAccountKeySecretRef { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

/// <summary>A storage_account_gen2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecForProviderStorageAccountGen2
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
public partial class V1beta2HadoopClusterSpecForProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public V1beta2HadoopClusterSpecForProviderComponentVersion? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public V1beta2HadoopClusterSpecForProviderComputeIsolation? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta2HadoopClusterSpecForProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public V1beta2HadoopClusterSpecForProviderExtension? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public V1beta2HadoopClusterSpecForProviderGateway? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public V1beta2HadoopClusterSpecForProviderMetastores? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public V1beta2HadoopClusterSpecForProviderMonitor? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public V1beta2HadoopClusterSpecForProviderNetwork? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1beta2HadoopClusterSpecForProviderPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2HadoopClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public V1beta2HadoopClusterSpecForProviderRoles? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public V1beta2HadoopClusterSpecForProviderSecurityProfile? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2HadoopClusterSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public V1beta2HadoopClusterSpecForProviderStorageAccountGen2? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary>A component_version block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderComponentVersion
{
    /// <summary>The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hadoop")]
    public string? Hadoop { get; set; }
}

/// <summary>A compute_isolation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderComputeIsolation
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
public partial class V1beta2HadoopClusterSpecInitProviderDiskEncryption
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
public partial class V1beta2HadoopClusterSpecInitProviderExtensionPrimaryKeySecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The workspace key of the log analytics extension.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public required V1beta2HadoopClusterSpecInitProviderExtensionPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

/// <summary>The password used for the Ambari Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderGatewayPasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderGateway
{
    /// <summary>The password used for the Ambari Portal.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2HadoopClusterSpecInitProviderGatewayPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderMetastoresAmbariPasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2HadoopClusterSpecInitProviderMetastoresAmbariPasswordSecretRef PasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecInitProviderMetastoresHivePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderMetastoresHive
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2HadoopClusterSpecInitProviderMetastoresHivePasswordSecretRef PasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecInitProviderMetastoresOoziePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore&apos;s existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2HadoopClusterSpecInitProviderMetastoresOoziePasswordSecretRef PasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecInitProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public V1beta2HadoopClusterSpecInitProviderMetastoresAmbari? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public V1beta2HadoopClusterSpecInitProviderMetastoresHive? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public V1beta2HadoopClusterSpecInitProviderMetastoresOozie? Oozie { get; set; }
}

/// <summary>The Operations Management Suite (OMS) workspace key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderMonitorPrimaryKeySecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Operations Management Suite (OMS) workspace key.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public required V1beta2HadoopClusterSpecInitProviderMonitorPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

/// <summary>A network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderNetwork
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
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
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An ip_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the uninstall script action.</summary>
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
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>A private_link_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>An ip_configuration block as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfigurationIpConfiguration? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesEdgeNodeHttpsEndpoints
{
    /// <summary>A list of access modes for the application.</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>The destination port to connect to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>The value indicates whether the gateway authentication is enabled or not.</summary>
    [JsonPropertyName("disableGatewayAuth")]
    public bool? DisableGatewayAuth { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The application&apos;s subdomain suffix.</summary>
    [JsonPropertyName("subDomainSuffix")]
    public string? SubDomainSuffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesEdgeNodeInstallScriptAction
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesEdgeNodeUninstallScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A edge_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesEdgeNode
{
    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster. One or more https_endpoints blocks as defined below.</summary>
    [JsonPropertyName("httpsEndpoints")]
    public IList<V1beta2HadoopClusterSpecInitProviderRolesEdgeNodeHttpsEndpoints>? HttpsEndpoints { get; set; }

    /// <summary>A install_script_action block as defined below.</summary>
    [JsonPropertyName("installScriptAction")]
    public IList<V1beta2HadoopClusterSpecInitProviderRolesEdgeNodeInstallScriptAction>? InstallScriptAction { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>A uninstall_script_actions block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uninstallScriptActions")]
    public IList<V1beta2HadoopClusterSpecInitProviderRolesEdgeNodeUninstallScriptActions>? UninstallScriptActions { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesHeadNodePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelector
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
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A head_node block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesHeadNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterSpecInitProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

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

/// <summary>A capacity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleCapacity
{
    /// <summary>The maximum number of worker nodes to autoscale to based on the cluster&apos;s activity.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of worker nodes to autoscale to based on the cluster&apos;s activity.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrenceSchedule
{
    /// <summary>The days of the week to perform autoscale. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The time of day to perform the autoscale in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A recurrence block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrence
{
    /// <summary>A list of schedule blocks as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The time zone for the autoscale schedule times.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A autoscale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscale
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleCapacity? Capacity { get; set; }

    /// <summary>A recurrence block as defined below.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrence? Recurrence { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector
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
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A worker_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesWorkerNode
{
    /// <summary>A autoscale block as defined below.</summary>
    [JsonPropertyName("autoscale")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeAutoscale? Autoscale { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

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
public partial class V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodePasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector
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
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A zookeeper_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderRolesZookeeperNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

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
public partial class V1beta2HadoopClusterSpecInitProviderRoles
{
    /// <summary>A edge_node block as defined below.</summary>
    [JsonPropertyName("edgeNode")]
    public V1beta2HadoopClusterSpecInitProviderRolesEdgeNode? EdgeNode { get; set; }

    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public V1beta2HadoopClusterSpecInitProviderRolesHeadNode? HeadNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public V1beta2HadoopClusterSpecInitProviderRolesWorkerNode? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public V1beta2HadoopClusterSpecInitProviderRolesZookeeperNode? ZookeeperNode { get; set; }
}

/// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderSecurityProfileDomainUserPasswordSecretRef
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
public partial class V1beta2HadoopClusterSpecInitProviderSecurityProfile
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
    public required V1beta2HadoopClusterSpecInitProviderSecurityProfileDomainUserPasswordSecretRef DomainUserPasswordSecretRef { get; set; }

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
public partial class V1beta2HadoopClusterSpecInitProviderStorageAccountStorageAccountKeySecretRef
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelector
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
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountKeySecretRef")]
    public required V1beta2HadoopClusterSpecInitProviderStorageAccountStorageAccountKeySecretRef StorageAccountKeySecretRef { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

/// <summary>A storage_account_gen2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecInitProviderStorageAccountGen2
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
public partial class V1beta2HadoopClusterSpecInitProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public V1beta2HadoopClusterSpecInitProviderComponentVersion? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public V1beta2HadoopClusterSpecInitProviderComputeIsolation? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta2HadoopClusterSpecInitProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public V1beta2HadoopClusterSpecInitProviderExtension? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public V1beta2HadoopClusterSpecInitProviderGateway? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public V1beta2HadoopClusterSpecInitProviderMetastores? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public V1beta2HadoopClusterSpecInitProviderMonitor? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public V1beta2HadoopClusterSpecInitProviderNetwork? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1beta2HadoopClusterSpecInitProviderPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public V1beta2HadoopClusterSpecInitProviderRoles? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public V1beta2HadoopClusterSpecInitProviderSecurityProfile? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2HadoopClusterSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public V1beta2HadoopClusterSpecInitProviderStorageAccountGen2? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecManagementPoliciesEnum>))]
public enum V1beta2HadoopClusterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2HadoopClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HadoopClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2HadoopClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HadoopClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HadoopClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HadoopClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>HadoopClusterSpec defines the desired state of HadoopCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterSpec
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
    public V1beta2HadoopClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2HadoopClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta2HadoopClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2HadoopClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2HadoopClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2HadoopClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A component_version block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderComponentVersion
{
    /// <summary>The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hadoop")]
    public string? Hadoop { get; set; }
}

/// <summary>A compute_isolation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderComputeIsolation
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
public partial class V1beta2HadoopClusterStatusAtProviderDiskEncryption
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
public partial class V1beta2HadoopClusterStatusAtProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary>A gateway block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderGateway
{
    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>An ambari block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderMetastoresAmbari
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
public partial class V1beta2HadoopClusterStatusAtProviderMetastoresHive
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
public partial class V1beta2HadoopClusterStatusAtProviderMetastoresOozie
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
public partial class V1beta2HadoopClusterStatusAtProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public V1beta2HadoopClusterStatusAtProviderMetastoresAmbari? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public V1beta2HadoopClusterStatusAtProviderMetastoresHive? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public V1beta2HadoopClusterStatusAtProviderMetastoresOozie? Oozie { get; set; }
}

/// <summary>A monitor block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary>A network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderNetwork
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
public partial class V1beta2HadoopClusterStatusAtProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the uninstall script action.</summary>
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
public partial class V1beta2HadoopClusterStatusAtProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>An ip_configuration block as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public V1beta2HadoopClusterStatusAtProviderPrivateLinkConfigurationIpConfiguration? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesEdgeNodeHttpsEndpoints
{
    /// <summary>A list of access modes for the application.</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>The destination port to connect to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>The value indicates whether the gateway authentication is enabled or not.</summary>
    [JsonPropertyName("disableGatewayAuth")]
    public bool? DisableGatewayAuth { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The application&apos;s subdomain suffix.</summary>
    [JsonPropertyName("subDomainSuffix")]
    public string? SubDomainSuffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesEdgeNodeInstallScriptAction
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesEdgeNodeUninstallScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A edge_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesEdgeNode
{
    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster. One or more https_endpoints blocks as defined below.</summary>
    [JsonPropertyName("httpsEndpoints")]
    public IList<V1beta2HadoopClusterStatusAtProviderRolesEdgeNodeHttpsEndpoints>? HttpsEndpoints { get; set; }

    /// <summary>A install_script_action block as defined below.</summary>
    [JsonPropertyName("installScriptAction")]
    public IList<V1beta2HadoopClusterStatusAtProviderRolesEdgeNodeInstallScriptAction>? InstallScriptAction { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>A uninstall_script_actions block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uninstallScriptActions")]
    public IList<V1beta2HadoopClusterStatusAtProviderRolesEdgeNodeUninstallScriptActions>? UninstallScriptActions { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A head_node block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesHeadNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterStatusAtProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

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

/// <summary>A capacity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleCapacity
{
    /// <summary>The maximum number of worker nodes to autoscale to based on the cluster&apos;s activity.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of worker nodes to autoscale to based on the cluster&apos;s activity.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrenceSchedule
{
    /// <summary>The days of the week to perform autoscale. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The time of day to perform the autoscale in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A recurrence block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrence
{
    /// <summary>A list of schedule blocks as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The time zone for the autoscale schedule times.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A autoscale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscale
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleCapacity? Capacity { get; set; }

    /// <summary>A recurrence block as defined below.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrence? Recurrence { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A worker_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesWorkerNode
{
    /// <summary>A autoscale block as defined below.</summary>
    [JsonPropertyName("autoscale")]
    public V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeAutoscale? Autoscale { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterStatusAtProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

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
public partial class V1beta2HadoopClusterStatusAtProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A zookeeper_node block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderRolesZookeeperNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta2HadoopClusterStatusAtProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

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
public partial class V1beta2HadoopClusterStatusAtProviderRoles
{
    /// <summary>A edge_node block as defined below.</summary>
    [JsonPropertyName("edgeNode")]
    public V1beta2HadoopClusterStatusAtProviderRolesEdgeNode? EdgeNode { get; set; }

    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public V1beta2HadoopClusterStatusAtProviderRolesHeadNode? HeadNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public V1beta2HadoopClusterStatusAtProviderRolesWorkerNode? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public V1beta2HadoopClusterStatusAtProviderRolesZookeeperNode? ZookeeperNode { get; set; }
}

/// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusAtProviderSecurityProfile
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
public partial class V1beta2HadoopClusterStatusAtProviderStorageAccount
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
public partial class V1beta2HadoopClusterStatusAtProviderStorageAccountGen2
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
public partial class V1beta2HadoopClusterStatusAtProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public V1beta2HadoopClusterStatusAtProviderComponentVersion? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public V1beta2HadoopClusterStatusAtProviderComputeIsolation? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta2HadoopClusterStatusAtProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public V1beta2HadoopClusterStatusAtProviderExtension? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public V1beta2HadoopClusterStatusAtProviderGateway? Gateway { get; set; }

    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("httpsEndpoint")]
    public string? HttpsEndpoint { get; set; }

    /// <summary>The ID of the HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public V1beta2HadoopClusterStatusAtProviderMetastores? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public V1beta2HadoopClusterStatusAtProviderMonitor? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public V1beta2HadoopClusterStatusAtProviderNetwork? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1beta2HadoopClusterStatusAtProviderPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public V1beta2HadoopClusterStatusAtProviderRoles? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public V1beta2HadoopClusterStatusAtProviderSecurityProfile? SecurityProfile { get; set; }

    /// <summary>The SSH Connectivity Endpoint for this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("sshEndpoint")]
    public string? SshEndpoint { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2HadoopClusterStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public V1beta2HadoopClusterStatusAtProviderStorageAccountGen2? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatusConditions
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

/// <summary>HadoopClusterStatus defines the observed state of HadoopCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HadoopClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2HadoopClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2HadoopClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HadoopCluster is the Schema for the HadoopClusters API. Manages a HDInsight Hadoop Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HadoopCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2HadoopClusterSpec>, IStatus<V1beta2HadoopClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HadoopCluster";
    public const string KubeGroup = "hdinsight.azure.upbound.io";
    public const string KubePluralName = "hadoopclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hdinsight.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HadoopCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HadoopClusterSpec defines the desired state of HadoopCluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta2HadoopClusterSpec Spec { get; set; }

    /// <summary>HadoopClusterStatus defines the observed state of HadoopCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2HadoopClusterStatus? Status { get; set; }
}
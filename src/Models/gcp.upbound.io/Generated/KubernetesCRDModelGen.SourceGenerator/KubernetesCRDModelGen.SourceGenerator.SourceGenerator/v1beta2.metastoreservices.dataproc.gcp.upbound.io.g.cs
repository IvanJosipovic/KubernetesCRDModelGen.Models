#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.gcp.upbound.io;
/// <summary>MetastoreService is the Schema for the MetastoreServices API. A managed metastore service that serves metadata queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MetastoreServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2MetastoreService>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MetastoreServiceList";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "metastoreservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2MetastoreService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2MetastoreService> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecDeletionPolicyEnum>))]
public enum V1beta2MetastoreServiceSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelector
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
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Information used to configure the Dataproc Metastore service to encrypt
/// customer data at rest.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderEncryptionConfig
{
    /// <summary>
    /// The fully qualified customer provided Cloud KMS key name to use for customer data encryption.
    /// Use the following format: projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)
    /// </summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelector? KmsKeySelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfigAuxiliaryVersions
{
    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfigKeytab
{
    /// <summary>
    /// The relative resource name of a Secret Manager secret version, in the following form:
    /// &quot;projects/{projectNumber}/secrets/{secret_id}/versions/{version_id}&quot;.
    /// </summary>
    [JsonPropertyName("cloudSecret")]
    public string? CloudSecret { get; set; }
}

/// <summary>
/// Information used to configure the Hive metastore service as a service principal in a Kerberos realm.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfig
{
    /// <summary>
    /// A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keytab")]
    public V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfigKeytab? Keytab { get; set; }

    /// <summary>A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.</summary>
    [JsonPropertyName("krb5ConfigGcsUri")]
    public string? Krb5ConfigGcsUri { get; set; }

    /// <summary>A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form &quot;primary/instance@REALM&quot;, but there is no exact format.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary>
/// Configuration information specific to running Hive metastore software as the metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfig
{
    /// <summary>
    /// A mapping of Hive metastore version to the auxiliary version configuration.
    /// When specified, a secondary Hive metastore service is created along with the primary service.
    /// All auxiliary versions must be less than the service&apos;s primary version.
    /// The key is the auxiliary service name and it must match the regular expression a-z?.
    /// This means that the first character must be a lowercase letter, and all the following characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a hyphen.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("auxiliaryVersions")]
    public IList<V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfigAuxiliaryVersions>? AuxiliaryVersions { get; set; }

    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>
    /// The protocol to use for the metastore service endpoint. If unspecified, defaults to THRIFT.
    /// Default value is THRIFT.
    /// Possible values are: THRIFT, GRPC.
    /// </summary>
    [JsonPropertyName("endpointProtocol")]
    public string? EndpointProtocol { get; set; }

    /// <summary>
    /// Information used to configure the Hive metastore service as a service principal in a Kerberos realm.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfig? KerberosConfig { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// The one hour maintenance window of the metastore service.
/// This specifies when the service can be restarted for maintenance purposes in UTC time.
/// Maintenance window is not needed for services with the SPANNER database type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderMaintenanceWindow
{
    /// <summary>
    /// The day of week, when the window starts.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day (0-23) when the window starts.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary>
/// The integration config for the Data Catalog service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderMetadataIntegrationDataCatalogConfig
{
    /// <summary>Defines whether the metastore metadata should be synced to Data Catalog. The default value is to disable syncing metastore metadata to Data Catalog.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// The setting that defines how metastore metadata should be integrated with external services and systems.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderMetadataIntegration
{
    /// <summary>
    /// The integration config for the Data Catalog service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataCatalogConfig")]
    public V1beta2MetastoreServiceSpecForProviderMetadataIntegrationDataCatalogConfig? DataCatalogConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelector
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
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumers
{
    /// <summary>
    /// The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service&apos;s endpoint.
    /// It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network.
    /// There must be at least one IP address available in the subnet&apos;s primary range. The subnet is specified in the following form:
    /// `projects/{projectNumber}/regions/{region_id}/subnetworks/{subnetwork_id}
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>
/// The configuration specifying the network settings for the Dataproc Metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderNetworkConfig
{
    /// <summary>
    /// The consumer-side network configuration for the Dataproc Metastore instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consumers")]
    public IList<V1beta2MetastoreServiceSpecForProviderNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary>
/// Represents the limit configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderScalingConfigAutoscalingConfigLimitConfig
{
    /// <summary>The maximum scaling factor that the service will autoscale to. The default value is 6.0.</summary>
    [JsonPropertyName("maxScalingFactor")]
    public double? MaxScalingFactor { get; set; }

    /// <summary>The minimum scaling factor that the service will autoscale to. The default value is 0.1.</summary>
    [JsonPropertyName("minScalingFactor")]
    public double? MinScalingFactor { get; set; }
}

/// <summary>
/// Represents the autoscaling configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderScalingConfigAutoscalingConfig
{
    /// <summary>Defines whether autoscaling is enabled. The default value is false.</summary>
    [JsonPropertyName("autoscalingEnabled")]
    public bool? AutoscalingEnabled { get; set; }

    /// <summary>
    /// Represents the limit configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limitConfig")]
    public V1beta2MetastoreServiceSpecForProviderScalingConfigAutoscalingConfigLimitConfig? LimitConfig { get; set; }
}

/// <summary>
/// Represents the scaling configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderScalingConfig
{
    /// <summary>
    /// Represents the autoscaling configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2MetastoreServiceSpecForProviderScalingConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// Metastore instance sizes.
    /// Possible values are: EXTRA_SMALL, SMALL, MEDIUM, LARGE, EXTRA_LARGE.
    /// </summary>
    [JsonPropertyName("instanceSize")]
    public string? InstanceSize { get; set; }

    /// <summary>Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.</summary>
    [JsonPropertyName("scalingFactor")]
    public double? ScalingFactor { get; set; }
}

/// <summary>
/// The configuration of scheduled backup for the metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderScheduledBackup
{
    /// <summary>A Cloud Storage URI of a folder, in the format gs://&lt;bucket_name&gt;/&lt;path_inside_bucket&gt;. A sub-folder &lt;backup_folder&gt; containing backup files will be stored below it.</summary>
    [JsonPropertyName("backupLocation")]
    public string? BackupLocation { get; set; }

    /// <summary>The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>Defines whether the scheduled backup is enabled. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProviderTelemetryConfig
{
    /// <summary>
    /// The output format of the Dataproc Metastore service&apos;s logs.
    /// Default value is JSON.
    /// Possible values are: LEGACY, JSON.
    /// </summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecForProvider
{
    /// <summary>
    /// The database type that the Metastore service stores its data.
    /// Default value is MYSQL.
    /// Possible values are: MYSQL, SPANNER.
    /// </summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>Indicates if the dataproc metastore should be protected against accidental deletions.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>
    /// Information used to configure the Dataproc Metastore service to encrypt
    /// customer data at rest.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2MetastoreServiceSpecForProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// Configuration information specific to running Hive metastore software as the metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hiveMetastoreConfig")]
    public V1beta2MetastoreServiceSpecForProviderHiveMetastoreConfig? HiveMetastoreConfig { get; set; }

    /// <summary>
    /// User-defined labels for the metastore service.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The one hour maintenance window of the metastore service.
    /// This specifies when the service can be restarted for maintenance purposes in UTC time.
    /// Maintenance window is not needed for services with the SPANNER database type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta2MetastoreServiceSpecForProviderMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// The setting that defines how metastore metadata should be integrated with external services and systems.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadataIntegration")]
    public V1beta2MetastoreServiceSpecForProviderMetadataIntegration? MetadataIntegration { get; set; }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// &quot;projects/{projectNumber}/global/networks/{network_id}&quot;.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// The configuration specifying the network settings for the Dataproc Metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2MetastoreServiceSpecForProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The TCP port at which the metastore service is reached. Default: 9083.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to STABLE.
    /// Default value is STABLE.
    /// Possible values are: CANARY, STABLE.
    /// </summary>
    [JsonPropertyName("releaseChannel")]
    public string? ReleaseChannel { get; set; }

    /// <summary>
    /// Represents the scaling configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta2MetastoreServiceSpecForProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>
    /// The configuration of scheduled backup for the metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scheduledBackup")]
    public V1beta2MetastoreServiceSpecForProviderScheduledBackup? ScheduledBackup { get; set; }

    /// <summary>
    /// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telemetryConfig")]
    public V1beta2MetastoreServiceSpecForProviderTelemetryConfig? TelemetryConfig { get; set; }

    /// <summary>
    /// The tier of the service.
    /// Possible values are: DEVELOPER, ENTERPRISE.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelector
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
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Information used to configure the Dataproc Metastore service to encrypt
/// customer data at rest.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderEncryptionConfig
{
    /// <summary>
    /// The fully qualified customer provided Cloud KMS key name to use for customer data encryption.
    /// Use the following format: projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)
    /// </summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelector? KmsKeySelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfigAuxiliaryVersions
{
    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfigKeytab
{
    /// <summary>
    /// The relative resource name of a Secret Manager secret version, in the following form:
    /// &quot;projects/{projectNumber}/secrets/{secret_id}/versions/{version_id}&quot;.
    /// </summary>
    [JsonPropertyName("cloudSecret")]
    public string? CloudSecret { get; set; }
}

/// <summary>
/// Information used to configure the Hive metastore service as a service principal in a Kerberos realm.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfig
{
    /// <summary>
    /// A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keytab")]
    public V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfigKeytab? Keytab { get; set; }

    /// <summary>A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.</summary>
    [JsonPropertyName("krb5ConfigGcsUri")]
    public string? Krb5ConfigGcsUri { get; set; }

    /// <summary>A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form &quot;primary/instance@REALM&quot;, but there is no exact format.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary>
/// Configuration information specific to running Hive metastore software as the metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfig
{
    /// <summary>
    /// A mapping of Hive metastore version to the auxiliary version configuration.
    /// When specified, a secondary Hive metastore service is created along with the primary service.
    /// All auxiliary versions must be less than the service&apos;s primary version.
    /// The key is the auxiliary service name and it must match the regular expression a-z?.
    /// This means that the first character must be a lowercase letter, and all the following characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a hyphen.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("auxiliaryVersions")]
    public IList<V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfigAuxiliaryVersions>? AuxiliaryVersions { get; set; }

    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>
    /// The protocol to use for the metastore service endpoint. If unspecified, defaults to THRIFT.
    /// Default value is THRIFT.
    /// Possible values are: THRIFT, GRPC.
    /// </summary>
    [JsonPropertyName("endpointProtocol")]
    public string? EndpointProtocol { get; set; }

    /// <summary>
    /// Information used to configure the Hive metastore service as a service principal in a Kerberos realm.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfig? KerberosConfig { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// The one hour maintenance window of the metastore service.
/// This specifies when the service can be restarted for maintenance purposes in UTC time.
/// Maintenance window is not needed for services with the SPANNER database type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderMaintenanceWindow
{
    /// <summary>
    /// The day of week, when the window starts.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day (0-23) when the window starts.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary>
/// The integration config for the Data Catalog service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderMetadataIntegrationDataCatalogConfig
{
    /// <summary>Defines whether the metastore metadata should be synced to Data Catalog. The default value is to disable syncing metastore metadata to Data Catalog.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// The setting that defines how metastore metadata should be integrated with external services and systems.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderMetadataIntegration
{
    /// <summary>
    /// The integration config for the Data Catalog service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataCatalogConfig")]
    public V1beta2MetastoreServiceSpecInitProviderMetadataIntegrationDataCatalogConfig? DataCatalogConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelector
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
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumers
{
    /// <summary>
    /// The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service&apos;s endpoint.
    /// It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network.
    /// There must be at least one IP address available in the subnet&apos;s primary range. The subnet is specified in the following form:
    /// `projects/{projectNumber}/regions/{region_id}/subnetworks/{subnetwork_id}
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>
/// The configuration specifying the network settings for the Dataproc Metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderNetworkConfig
{
    /// <summary>
    /// The consumer-side network configuration for the Dataproc Metastore instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consumers")]
    public IList<V1beta2MetastoreServiceSpecInitProviderNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary>
/// Represents the limit configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfigLimitConfig
{
    /// <summary>The maximum scaling factor that the service will autoscale to. The default value is 6.0.</summary>
    [JsonPropertyName("maxScalingFactor")]
    public double? MaxScalingFactor { get; set; }

    /// <summary>The minimum scaling factor that the service will autoscale to. The default value is 0.1.</summary>
    [JsonPropertyName("minScalingFactor")]
    public double? MinScalingFactor { get; set; }
}

/// <summary>
/// Represents the autoscaling configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfig
{
    /// <summary>Defines whether autoscaling is enabled. The default value is false.</summary>
    [JsonPropertyName("autoscalingEnabled")]
    public bool? AutoscalingEnabled { get; set; }

    /// <summary>
    /// Represents the limit configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limitConfig")]
    public V1beta2MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfigLimitConfig? LimitConfig { get; set; }
}

/// <summary>
/// Represents the scaling configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderScalingConfig
{
    /// <summary>
    /// Represents the autoscaling configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// Metastore instance sizes.
    /// Possible values are: EXTRA_SMALL, SMALL, MEDIUM, LARGE, EXTRA_LARGE.
    /// </summary>
    [JsonPropertyName("instanceSize")]
    public string? InstanceSize { get; set; }

    /// <summary>Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.</summary>
    [JsonPropertyName("scalingFactor")]
    public double? ScalingFactor { get; set; }
}

/// <summary>
/// The configuration of scheduled backup for the metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderScheduledBackup
{
    /// <summary>A Cloud Storage URI of a folder, in the format gs://&lt;bucket_name&gt;/&lt;path_inside_bucket&gt;. A sub-folder &lt;backup_folder&gt; containing backup files will be stored below it.</summary>
    [JsonPropertyName("backupLocation")]
    public string? BackupLocation { get; set; }

    /// <summary>The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>Defines whether the scheduled backup is enabled. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecInitProviderTelemetryConfig
{
    /// <summary>
    /// The output format of the Dataproc Metastore service&apos;s logs.
    /// Default value is JSON.
    /// Possible values are: LEGACY, JSON.
    /// </summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }
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
public partial class V1beta2MetastoreServiceSpecInitProvider
{
    /// <summary>
    /// The database type that the Metastore service stores its data.
    /// Default value is MYSQL.
    /// Possible values are: MYSQL, SPANNER.
    /// </summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>Indicates if the dataproc metastore should be protected against accidental deletions.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>
    /// Information used to configure the Dataproc Metastore service to encrypt
    /// customer data at rest.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2MetastoreServiceSpecInitProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// Configuration information specific to running Hive metastore software as the metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hiveMetastoreConfig")]
    public V1beta2MetastoreServiceSpecInitProviderHiveMetastoreConfig? HiveMetastoreConfig { get; set; }

    /// <summary>
    /// User-defined labels for the metastore service.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The one hour maintenance window of the metastore service.
    /// This specifies when the service can be restarted for maintenance purposes in UTC time.
    /// Maintenance window is not needed for services with the SPANNER database type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta2MetastoreServiceSpecInitProviderMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// The setting that defines how metastore metadata should be integrated with external services and systems.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadataIntegration")]
    public V1beta2MetastoreServiceSpecInitProviderMetadataIntegration? MetadataIntegration { get; set; }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// &quot;projects/{projectNumber}/global/networks/{network_id}&quot;.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// The configuration specifying the network settings for the Dataproc Metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2MetastoreServiceSpecInitProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The TCP port at which the metastore service is reached. Default: 9083.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to STABLE.
    /// Default value is STABLE.
    /// Possible values are: CANARY, STABLE.
    /// </summary>
    [JsonPropertyName("releaseChannel")]
    public string? ReleaseChannel { get; set; }

    /// <summary>
    /// Represents the scaling configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta2MetastoreServiceSpecInitProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>
    /// The configuration of scheduled backup for the metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scheduledBackup")]
    public V1beta2MetastoreServiceSpecInitProviderScheduledBackup? ScheduledBackup { get; set; }

    /// <summary>
    /// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telemetryConfig")]
    public V1beta2MetastoreServiceSpecInitProviderTelemetryConfig? TelemetryConfig { get; set; }

    /// <summary>
    /// The tier of the service.
    /// Possible values are: DEVELOPER, ENTERPRISE.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecManagementPoliciesEnum>))]
public enum V1beta2MetastoreServiceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MetastoreServiceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetastoreServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MetastoreServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetastoreServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetastoreServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetastoreServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MetastoreServiceSpec defines the desired state of MetastoreService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceSpec
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
    public V1beta2MetastoreServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MetastoreServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2MetastoreServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2MetastoreServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MetastoreServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MetastoreServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Information used to configure the Dataproc Metastore service to encrypt
/// customer data at rest.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderEncryptionConfig
{
    /// <summary>
    /// The fully qualified customer provided Cloud KMS key name to use for customer data encryption.
    /// Use the following format: projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)
    /// </summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfigAuxiliaryVersions
{
    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfigKeytab
{
    /// <summary>
    /// The relative resource name of a Secret Manager secret version, in the following form:
    /// &quot;projects/{projectNumber}/secrets/{secret_id}/versions/{version_id}&quot;.
    /// </summary>
    [JsonPropertyName("cloudSecret")]
    public string? CloudSecret { get; set; }
}

/// <summary>
/// Information used to configure the Hive metastore service as a service principal in a Kerberos realm.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfig
{
    /// <summary>
    /// A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keytab")]
    public V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfigKeytab? Keytab { get; set; }

    /// <summary>A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.</summary>
    [JsonPropertyName("krb5ConfigGcsUri")]
    public string? Krb5ConfigGcsUri { get; set; }

    /// <summary>A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form &quot;primary/instance@REALM&quot;, but there is no exact format.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary>
/// Configuration information specific to running Hive metastore software as the metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfig
{
    /// <summary>
    /// A mapping of Hive metastore version to the auxiliary version configuration.
    /// When specified, a secondary Hive metastore service is created along with the primary service.
    /// All auxiliary versions must be less than the service&apos;s primary version.
    /// The key is the auxiliary service name and it must match the regular expression a-z?.
    /// This means that the first character must be a lowercase letter, and all the following characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a hyphen.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("auxiliaryVersions")]
    public IList<V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfigAuxiliaryVersions>? AuxiliaryVersions { get; set; }

    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>
    /// The protocol to use for the metastore service endpoint. If unspecified, defaults to THRIFT.
    /// Default value is THRIFT.
    /// Possible values are: THRIFT, GRPC.
    /// </summary>
    [JsonPropertyName("endpointProtocol")]
    public string? EndpointProtocol { get; set; }

    /// <summary>
    /// Information used to configure the Hive metastore service as a service principal in a Kerberos realm.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfig? KerberosConfig { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// The one hour maintenance window of the metastore service.
/// This specifies when the service can be restarted for maintenance purposes in UTC time.
/// Maintenance window is not needed for services with the SPANNER database type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderMaintenanceWindow
{
    /// <summary>
    /// The day of week, when the window starts.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day (0-23) when the window starts.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary>
/// The integration config for the Data Catalog service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderMetadataIntegrationDataCatalogConfig
{
    /// <summary>Defines whether the metastore metadata should be synced to Data Catalog. The default value is to disable syncing metastore metadata to Data Catalog.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// The setting that defines how metastore metadata should be integrated with external services and systems.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderMetadataIntegration
{
    /// <summary>
    /// The integration config for the Data Catalog service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataCatalogConfig")]
    public V1beta2MetastoreServiceStatusAtProviderMetadataIntegrationDataCatalogConfig? DataCatalogConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderNetworkConfigConsumers
{
    /// <summary>The URI of the endpoint used to access the metastore service.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>
    /// The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service&apos;s endpoint.
    /// It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network.
    /// There must be at least one IP address available in the subnet&apos;s primary range. The subnet is specified in the following form:
    /// `projects/{projectNumber}/regions/{region_id}/subnetworks/{subnetwork_id}
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary>
/// The configuration specifying the network settings for the Dataproc Metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderNetworkConfig
{
    /// <summary>
    /// The consumer-side network configuration for the Dataproc Metastore instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consumers")]
    public IList<V1beta2MetastoreServiceStatusAtProviderNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary>
/// Represents the limit configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfigLimitConfig
{
    /// <summary>The maximum scaling factor that the service will autoscale to. The default value is 6.0.</summary>
    [JsonPropertyName("maxScalingFactor")]
    public double? MaxScalingFactor { get; set; }

    /// <summary>The minimum scaling factor that the service will autoscale to. The default value is 0.1.</summary>
    [JsonPropertyName("minScalingFactor")]
    public double? MinScalingFactor { get; set; }
}

/// <summary>
/// Represents the autoscaling configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfig
{
    /// <summary>Defines whether autoscaling is enabled. The default value is false.</summary>
    [JsonPropertyName("autoscalingEnabled")]
    public bool? AutoscalingEnabled { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The scaling factor of a service with autoscaling enabled.
    /// </summary>
    [JsonPropertyName("autoscalingFactor")]
    public double? AutoscalingFactor { get; set; }

    /// <summary>
    /// Represents the limit configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limitConfig")]
    public V1beta2MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfigLimitConfig? LimitConfig { get; set; }
}

/// <summary>
/// Represents the scaling configuration of a metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderScalingConfig
{
    /// <summary>
    /// Represents the autoscaling configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// Metastore instance sizes.
    /// Possible values are: EXTRA_SMALL, SMALL, MEDIUM, LARGE, EXTRA_LARGE.
    /// </summary>
    [JsonPropertyName("instanceSize")]
    public string? InstanceSize { get; set; }

    /// <summary>Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.</summary>
    [JsonPropertyName("scalingFactor")]
    public double? ScalingFactor { get; set; }
}

/// <summary>
/// The configuration of scheduled backup for the metastore service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderScheduledBackup
{
    /// <summary>A Cloud Storage URI of a folder, in the format gs://&lt;bucket_name&gt;/&lt;path_inside_bucket&gt;. A sub-folder &lt;backup_folder&gt; containing backup files will be stored below it.</summary>
    [JsonPropertyName("backupLocation")]
    public string? BackupLocation { get; set; }

    /// <summary>The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>Defines whether the scheduled backup is enabled. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProviderTelemetryConfig
{
    /// <summary>
    /// The output format of the Dataproc Metastore service&apos;s logs.
    /// Default value is JSON.
    /// Possible values are: LEGACY, JSON.
    /// </summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusAtProvider
{
    /// <summary>A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the metastore service are stored.</summary>
    [JsonPropertyName("artifactGcsUri")]
    public string? ArtifactGcsUri { get; set; }

    /// <summary>Output only. The time when the metastore service was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// The database type that the Metastore service stores its data.
    /// Default value is MYSQL.
    /// Possible values are: MYSQL, SPANNER.
    /// </summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>Indicates if the dataproc metastore should be protected against accidental deletions.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Information used to configure the Dataproc Metastore service to encrypt
    /// customer data at rest.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2MetastoreServiceStatusAtProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The URI of the endpoint used to access the metastore service.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>
    /// Configuration information specific to running Hive metastore software as the metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hiveMetastoreConfig")]
    public V1beta2MetastoreServiceStatusAtProviderHiveMetastoreConfig? HiveMetastoreConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/services/{{service_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// User-defined labels for the metastore service.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The one hour maintenance window of the metastore service.
    /// This specifies when the service can be restarted for maintenance purposes in UTC time.
    /// Maintenance window is not needed for services with the SPANNER database type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta2MetastoreServiceStatusAtProviderMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// The setting that defines how metastore metadata should be integrated with external services and systems.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadataIntegration")]
    public V1beta2MetastoreServiceStatusAtProviderMetadataIntegration? MetadataIntegration { get; set; }

    /// <summary>The relative resource name of the metastore service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// &quot;projects/{projectNumber}/global/networks/{network_id}&quot;.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// The configuration specifying the network settings for the Dataproc Metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2MetastoreServiceStatusAtProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The TCP port at which the metastore service is reached. Default: 9083.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to STABLE.
    /// Default value is STABLE.
    /// Possible values are: CANARY, STABLE.
    /// </summary>
    [JsonPropertyName("releaseChannel")]
    public string? ReleaseChannel { get; set; }

    /// <summary>
    /// Represents the scaling configuration of a metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta2MetastoreServiceStatusAtProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>
    /// The configuration of scheduled backup for the metastore service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scheduledBackup")]
    public V1beta2MetastoreServiceStatusAtProviderScheduledBackup? ScheduledBackup { get; set; }

    /// <summary>The current state of the metastore service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Additional information about the current state of the metastore service, if available.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>
    /// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telemetryConfig")]
    public V1beta2MetastoreServiceStatusAtProviderTelemetryConfig? TelemetryConfig { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// The tier of the service.
    /// Possible values are: DEVELOPER, ENTERPRISE.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The globally unique resource identifier of the metastore service.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the metastore service was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatusConditions
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

/// <summary>MetastoreServiceStatus defines the observed state of MetastoreService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetastoreServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MetastoreServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MetastoreServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MetastoreService is the Schema for the MetastoreServices API. A managed metastore service that serves metadata queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MetastoreService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MetastoreServiceSpec>, IStatus<V1beta2MetastoreServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MetastoreService";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "metastoreservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreServiceSpec defines the desired state of MetastoreService</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MetastoreServiceSpec Spec { get; set; }

    /// <summary>MetastoreServiceStatus defines the observed state of MetastoreService.</summary>
    [JsonPropertyName("status")]
    public V1beta2MetastoreServiceStatus? Status { get; set; }
}
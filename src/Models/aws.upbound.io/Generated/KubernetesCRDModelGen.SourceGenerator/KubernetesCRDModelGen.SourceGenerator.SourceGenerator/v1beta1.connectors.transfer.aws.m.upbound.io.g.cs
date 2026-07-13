#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.transfer.aws.m.upbound.io;
/// <summary>Connector is the Schema for the Connectors API. Provides a AWS Transfer AS2 Connector Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConnectorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Connector>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectorList";
    public const string KubeGroup = "transfer.aws.m.upbound.io";
    public const string KubePluralName = "connectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "transfer.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Connector objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Connector> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderAccessRoleRefPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecForProviderAccessRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderAccessRoleRefPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecForProviderAccessRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderAccessRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecForProviderAccessRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecForProviderAccessRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate accessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderAccessRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderAccessRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate accessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderAccessRoleSelector
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
    public V1beta1ConnectorSpecForProviderAccessRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderAs2Config
{
    /// <summary>Specifies weather AS2 file is compressed. The valud values are ZLIB and  DISABLED.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The algorithm that is used to encrypt the file. The valid values are AES128_CBC | AES192_CBC | AES256_CBC | NONE.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>The unique identifier for the AS2 local profile.</summary>
    [JsonPropertyName("localProfileId")]
    public string? LocalProfileId { get; set; }

    /// <summary>Used for outbound requests to determine if a partner response for transfers is synchronous or asynchronous. The valid values are SYNC and NONE.</summary>
    [JsonPropertyName("mdnResponse")]
    public string? MdnResponse { get; set; }

    /// <summary>The signing algorithm for the Mdn response. The valid values are SHA256 | SHA384 | SHA512 | SHA1 | NONE | DEFAULT.</summary>
    [JsonPropertyName("mdnSigningAlgorithm")]
    public string? MdnSigningAlgorithm { get; set; }

    /// <summary>Used as the subject HTTP header attribute in AS2 messages that are being sent with the connector.</summary>
    [JsonPropertyName("messageSubject")]
    public string? MessageSubject { get; set; }

    /// <summary>The unique identifier for the AS2 partner profile.</summary>
    [JsonPropertyName("partnerProfileId")]
    public string? PartnerProfileId { get; set; }

    /// <summary>The algorithm that is used to sign AS2 messages sent with the connector. The valid values are SHA256 | SHA384 | SHA512 | SHA1 | NONE .</summary>
    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }
}

/// <summary>VPC Lattice configuration for routing connector traffic through customer VPCs. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderEgressConfigVpcLattice
{
    /// <summary>Port number for connecting to the SFTP server through VPC Lattice. Defaults to 22 if not specified. Must match the port on which the target SFTP server is listening. Valid values are between 1 and 65535.</summary>
    [JsonPropertyName("portNumber")]
    public double? PortNumber { get; set; }

    /// <summary>ARN of the VPC Lattice Resource Configuration that defines the target SFTP server location. Must point to a valid Resource Configuration in a VPC with appropriate network connectivity to the SFTP server.</summary>
    [JsonPropertyName("resourceConfigurationArn")]
    public string? ResourceConfigurationArn { get; set; }
}

/// <summary>Specifies the egress configuration for the connector. When set, enables routing through customer VPCs using VPC Lattice for private connectivity. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderEgressConfig
{
    /// <summary>VPC Lattice configuration for routing connector traffic through customer VPCs. Fields documented below.</summary>
    [JsonPropertyName("vpcLattice")]
    public V1beta1ConnectorSpecForProviderEgressConfigVpcLattice? VpcLattice { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate userSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate userSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelector
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
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProviderSftpConfig
{
    /// <summary>A list of public portion of the host key, or keys, that are used to authenticate the user to the external server to which you are connecting.(https://docs.aws.amazon.com/transfer/latest/userguide/API_SftpConnectorConfig.html)</summary>
    [JsonPropertyName("trustedHostKeys")]
    public IList<string>? TrustedHostKeys { get; set; }

    /// <summary>The identifier for the secret (in AWS Secrets Manager) that contains the SFTP user&apos;s private key, password, or both. The identifier can be either the Amazon Resource Name (ARN) or the name of the secret.</summary>
    [JsonPropertyName("userSecretId")]
    public string? UserSecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate userSecretId.</summary>
    [JsonPropertyName("userSecretIdRef")]
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdRef? UserSecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate userSecretId.</summary>
    [JsonPropertyName("userSecretIdSelector")]
    public V1beta1ConnectorSpecForProviderSftpConfigUserSecretIdSelector? UserSecretIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecForProvider
{
    /// <summary>The IAM Role which provides read and write access to the parent directory of the file location mentioned in the StartFileTransfer request.</summary>
    [JsonPropertyName("accessRole")]
    public string? AccessRole { get; set; }

    /// <summary>Reference to a Role in iam to populate accessRole.</summary>
    [JsonPropertyName("accessRoleRef")]
    public V1beta1ConnectorSpecForProviderAccessRoleRef? AccessRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate accessRole.</summary>
    [JsonPropertyName("accessRoleSelector")]
    public V1beta1ConnectorSpecForProviderAccessRoleSelector? AccessRoleSelector { get; set; }

    /// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
    [JsonPropertyName("as2Config")]
    public V1beta1ConnectorSpecForProviderAs2Config? As2Config { get; set; }

    /// <summary>Specifies the egress configuration for the connector. When set, enables routing through customer VPCs using VPC Lattice for private connectivity. Fields documented below.</summary>
    [JsonPropertyName("egressConfig")]
    public V1beta1ConnectorSpecForProviderEgressConfig? EgressConfig { get; set; }

    /// <summary>The IAM Role which is required for allowing the connector to turn on CloudWatch logging for Amazon S3 events.</summary>
    [JsonPropertyName("loggingRole")]
    public string? LoggingRole { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Name of the security policy for the connector.</summary>
    [JsonPropertyName("securityPolicyName")]
    public string? SecurityPolicyName { get; set; }

    /// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
    [JsonPropertyName("sftpConfig")]
    public V1beta1ConnectorSpecForProviderSftpConfig? SftpConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The URL of the partners AS2 endpoint or SFTP endpoint. Required for AS2 connectors and service-managed SFTP connectors. Must be null when using VPC Lattice egress configuration.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderAccessRoleRefPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecInitProviderAccessRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderAccessRoleRefPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecInitProviderAccessRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderAccessRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecInitProviderAccessRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecInitProviderAccessRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate accessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderAccessRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderAccessRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate accessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderAccessRoleSelector
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
    public V1beta1ConnectorSpecInitProviderAccessRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderAs2Config
{
    /// <summary>Specifies weather AS2 file is compressed. The valud values are ZLIB and  DISABLED.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The algorithm that is used to encrypt the file. The valid values are AES128_CBC | AES192_CBC | AES256_CBC | NONE.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>The unique identifier for the AS2 local profile.</summary>
    [JsonPropertyName("localProfileId")]
    public string? LocalProfileId { get; set; }

    /// <summary>Used for outbound requests to determine if a partner response for transfers is synchronous or asynchronous. The valid values are SYNC and NONE.</summary>
    [JsonPropertyName("mdnResponse")]
    public string? MdnResponse { get; set; }

    /// <summary>The signing algorithm for the Mdn response. The valid values are SHA256 | SHA384 | SHA512 | SHA1 | NONE | DEFAULT.</summary>
    [JsonPropertyName("mdnSigningAlgorithm")]
    public string? MdnSigningAlgorithm { get; set; }

    /// <summary>Used as the subject HTTP header attribute in AS2 messages that are being sent with the connector.</summary>
    [JsonPropertyName("messageSubject")]
    public string? MessageSubject { get; set; }

    /// <summary>The unique identifier for the AS2 partner profile.</summary>
    [JsonPropertyName("partnerProfileId")]
    public string? PartnerProfileId { get; set; }

    /// <summary>The algorithm that is used to sign AS2 messages sent with the connector. The valid values are SHA256 | SHA384 | SHA512 | SHA1 | NONE .</summary>
    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }
}

/// <summary>VPC Lattice configuration for routing connector traffic through customer VPCs. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderEgressConfigVpcLattice
{
    /// <summary>Port number for connecting to the SFTP server through VPC Lattice. Defaults to 22 if not specified. Must match the port on which the target SFTP server is listening. Valid values are between 1 and 65535.</summary>
    [JsonPropertyName("portNumber")]
    public double? PortNumber { get; set; }

    /// <summary>ARN of the VPC Lattice Resource Configuration that defines the target SFTP server location. Must point to a valid Resource Configuration in a VPC with appropriate network connectivity to the SFTP server.</summary>
    [JsonPropertyName("resourceConfigurationArn")]
    public string? ResourceConfigurationArn { get; set; }
}

/// <summary>Specifies the egress configuration for the connector. When set, enables routing through customer VPCs using VPC Lattice for private connectivity. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderEgressConfig
{
    /// <summary>VPC Lattice configuration for routing connector traffic through customer VPCs. Fields documented below.</summary>
    [JsonPropertyName("vpcLattice")]
    public V1beta1ConnectorSpecInitProviderEgressConfigVpcLattice? VpcLattice { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate userSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate userSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelector
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
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpecInitProviderSftpConfig
{
    /// <summary>A list of public portion of the host key, or keys, that are used to authenticate the user to the external server to which you are connecting.(https://docs.aws.amazon.com/transfer/latest/userguide/API_SftpConnectorConfig.html)</summary>
    [JsonPropertyName("trustedHostKeys")]
    public IList<string>? TrustedHostKeys { get; set; }

    /// <summary>The identifier for the secret (in AWS Secrets Manager) that contains the SFTP user&apos;s private key, password, or both. The identifier can be either the Amazon Resource Name (ARN) or the name of the secret.</summary>
    [JsonPropertyName("userSecretId")]
    public string? UserSecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate userSecretId.</summary>
    [JsonPropertyName("userSecretIdRef")]
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdRef? UserSecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate userSecretId.</summary>
    [JsonPropertyName("userSecretIdSelector")]
    public V1beta1ConnectorSpecInitProviderSftpConfigUserSecretIdSelector? UserSecretIdSelector { get; set; }
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
public partial class V1beta1ConnectorSpecInitProvider
{
    /// <summary>The IAM Role which provides read and write access to the parent directory of the file location mentioned in the StartFileTransfer request.</summary>
    [JsonPropertyName("accessRole")]
    public string? AccessRole { get; set; }

    /// <summary>Reference to a Role in iam to populate accessRole.</summary>
    [JsonPropertyName("accessRoleRef")]
    public V1beta1ConnectorSpecInitProviderAccessRoleRef? AccessRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate accessRole.</summary>
    [JsonPropertyName("accessRoleSelector")]
    public V1beta1ConnectorSpecInitProviderAccessRoleSelector? AccessRoleSelector { get; set; }

    /// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
    [JsonPropertyName("as2Config")]
    public V1beta1ConnectorSpecInitProviderAs2Config? As2Config { get; set; }

    /// <summary>Specifies the egress configuration for the connector. When set, enables routing through customer VPCs using VPC Lattice for private connectivity. Fields documented below.</summary>
    [JsonPropertyName("egressConfig")]
    public V1beta1ConnectorSpecInitProviderEgressConfig? EgressConfig { get; set; }

    /// <summary>The IAM Role which is required for allowing the connector to turn on CloudWatch logging for Amazon S3 events.</summary>
    [JsonPropertyName("loggingRole")]
    public string? LoggingRole { get; set; }

    /// <summary>Name of the security policy for the connector.</summary>
    [JsonPropertyName("securityPolicyName")]
    public string? SecurityPolicyName { get; set; }

    /// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
    [JsonPropertyName("sftpConfig")]
    public V1beta1ConnectorSpecInitProviderSftpConfig? SftpConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The URL of the partners AS2 endpoint or SFTP endpoint. Required for AS2 connectors and service-managed SFTP connectors. Must be null when using VPC Lattice egress configuration.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecManagementPoliciesEnum>))]
public enum V1beta1ConnectorSpecManagementPoliciesEnum
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
public partial class V1beta1ConnectorSpecProviderConfigRef
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
public partial class V1beta1ConnectorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConnectorSpec defines the desired state of Connector</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ConnectorSpecForProvider ForProvider { get; set; }

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
    public V1beta1ConnectorSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ConnectorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorStatusAtProviderAs2Config
{
    /// <summary>Specifies weather AS2 file is compressed. The valud values are ZLIB and  DISABLED.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The algorithm that is used to encrypt the file. The valid values are AES128_CBC | AES192_CBC | AES256_CBC | NONE.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>The unique identifier for the AS2 local profile.</summary>
    [JsonPropertyName("localProfileId")]
    public string? LocalProfileId { get; set; }

    /// <summary>Used for outbound requests to determine if a partner response for transfers is synchronous or asynchronous. The valid values are SYNC and NONE.</summary>
    [JsonPropertyName("mdnResponse")]
    public string? MdnResponse { get; set; }

    /// <summary>The signing algorithm for the Mdn response. The valid values are SHA256 | SHA384 | SHA512 | SHA1 | NONE | DEFAULT.</summary>
    [JsonPropertyName("mdnSigningAlgorithm")]
    public string? MdnSigningAlgorithm { get; set; }

    /// <summary>Used as the subject HTTP header attribute in AS2 messages that are being sent with the connector.</summary>
    [JsonPropertyName("messageSubject")]
    public string? MessageSubject { get; set; }

    /// <summary>The unique identifier for the AS2 partner profile.</summary>
    [JsonPropertyName("partnerProfileId")]
    public string? PartnerProfileId { get; set; }

    /// <summary>The algorithm that is used to sign AS2 messages sent with the connector. The valid values are SHA256 | SHA384 | SHA512 | SHA1 | NONE .</summary>
    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }
}

/// <summary>VPC Lattice configuration for routing connector traffic through customer VPCs. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorStatusAtProviderEgressConfigVpcLattice
{
    /// <summary>Port number for connecting to the SFTP server through VPC Lattice. Defaults to 22 if not specified. Must match the port on which the target SFTP server is listening. Valid values are between 1 and 65535.</summary>
    [JsonPropertyName("portNumber")]
    public double? PortNumber { get; set; }

    /// <summary>ARN of the VPC Lattice Resource Configuration that defines the target SFTP server location. Must point to a valid Resource Configuration in a VPC with appropriate network connectivity to the SFTP server.</summary>
    [JsonPropertyName("resourceConfigurationArn")]
    public string? ResourceConfigurationArn { get; set; }
}

/// <summary>Specifies the egress configuration for the connector. When set, enables routing through customer VPCs using VPC Lattice for private connectivity. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorStatusAtProviderEgressConfig
{
    /// <summary>VPC Lattice configuration for routing connector traffic through customer VPCs. Fields documented below.</summary>
    [JsonPropertyName("vpcLattice")]
    public V1beta1ConnectorStatusAtProviderEgressConfigVpcLattice? VpcLattice { get; set; }
}

/// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorStatusAtProviderSftpConfig
{
    /// <summary>A list of public portion of the host key, or keys, that are used to authenticate the user to the external server to which you are connecting.(https://docs.aws.amazon.com/transfer/latest/userguide/API_SftpConnectorConfig.html)</summary>
    [JsonPropertyName("trustedHostKeys")]
    public IList<string>? TrustedHostKeys { get; set; }

    /// <summary>The identifier for the secret (in AWS Secrets Manager) that contains the SFTP user&apos;s private key, password, or both. The identifier can be either the Amazon Resource Name (ARN) or the name of the secret.</summary>
    [JsonPropertyName("userSecretId")]
    public string? UserSecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorStatusAtProvider
{
    /// <summary>The IAM Role which provides read and write access to the parent directory of the file location mentioned in the StartFileTransfer request.</summary>
    [JsonPropertyName("accessRole")]
    public string? AccessRole { get; set; }

    /// <summary>The ARN of the connector.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
    [JsonPropertyName("as2Config")]
    public V1beta1ConnectorStatusAtProviderAs2Config? As2Config { get; set; }

    /// <summary>The unique identifier for the AS2 profile or SFTP Profile.</summary>
    [JsonPropertyName("connectorId")]
    public string? ConnectorId { get; set; }

    /// <summary>Specifies the egress configuration for the connector. When set, enables routing through customer VPCs using VPC Lattice for private connectivity. Fields documented below.</summary>
    [JsonPropertyName("egressConfig")]
    public V1beta1ConnectorStatusAtProviderEgressConfig? EgressConfig { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IAM Role which is required for allowing the connector to turn on CloudWatch logging for Amazon S3 events.</summary>
    [JsonPropertyName("loggingRole")]
    public string? LoggingRole { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Name of the security policy for the connector.</summary>
    [JsonPropertyName("securityPolicyName")]
    public string? SecurityPolicyName { get; set; }

    /// <summary>Either SFTP or AS2 is configured.The parameters to configure for the connector object. Fields documented below.</summary>
    [JsonPropertyName("sftpConfig")]
    public V1beta1ConnectorStatusAtProviderSftpConfig? SftpConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The URL of the partners AS2 endpoint or SFTP endpoint. Required for AS2 connectors and service-managed SFTP connectors. Must be null when using VPC Lattice egress configuration.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorStatusConditions
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

/// <summary>ConnectorStatus defines the observed state of Connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectorStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectorStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Connector is the Schema for the Connectors API. Provides a AWS Transfer AS2 Connector Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Connector : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectorSpec>, IStatus<V1beta1ConnectorStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Connector";
    public const string KubeGroup = "transfer.aws.m.upbound.io";
    public const string KubePluralName = "connectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "transfer.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Connector";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectorSpec defines the desired state of Connector</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ConnectorSpec Spec { get; set; }

    /// <summary>ConnectorStatus defines the observed state of Connector.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectorStatus? Status { get; set; }
}
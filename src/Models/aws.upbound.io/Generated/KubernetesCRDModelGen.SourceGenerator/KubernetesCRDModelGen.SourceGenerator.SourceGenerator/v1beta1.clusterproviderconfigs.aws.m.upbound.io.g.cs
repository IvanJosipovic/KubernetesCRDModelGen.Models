#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aws.m.upbound.io;
/// <summary>A ClusterProviderConfig configures the AWS provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterProviderConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ClusterProviderConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterProviderConfigList";
    public const string KubeGroup = "aws.m.upbound.io";
    public const string KubePluralName = "clusterproviderconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterProviderConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ClusterProviderConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ClusterProviderConfig> Items { get; set; }
}

/// <summary>Tag is session tag that can be used to assume an IAM Role</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecAssumeRoleChainTags
{
    /// <summary>
    /// Name of the tag.
    /// Key is a required field
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Value of the tag.
    /// Value is a required field
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// AssumeRoleOptions define the options for assuming an IAM Role
/// Fields are similar to the STS AssumeRoleOptions in the AWS SDK
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecAssumeRoleChain
{
    /// <summary>ExternalID is the external ID used when assuming role.</summary>
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    /// <summary>AssumeRoleARN to assume with provider credentials</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>
    /// Tags is list of session tags that you want to pass. Each session tag consists of a key
    /// name and an associated value. For more information about session tags, see
    /// Tagging STS Sessions
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1ClusterProviderConfigSpecAssumeRoleChainTags>? Tags { get; set; }

    /// <summary>
    /// TransitiveTagKeys is a list of keys for session tags that you want to set as transitive. If you set a
    /// tag key as transitive, the corresponding key and value passes to subsequent
    /// sessions in a role chain. For more information, see Chaining Roles with Session Tags
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html#id_session-tags_role-chaining).
    /// </summary>
    [JsonPropertyName("transitiveTagKeys")]
    public IList<string>? TransitiveTagKeys { get; set; }
}

/// <summary>
/// Env is a reference to an environment variable that contains credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Fs is a reference to a filesystem location that contains credentials that
/// must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>
/// A SecretRef is a reference to a secret key that contains the credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsSecretRef
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

/// <summary>Source of the provider credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterProviderConfigSpecCredentialsSourceEnum>))]
public enum V1beta1ClusterProviderConfigSpecCredentialsSourceEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret,
    [EnumMember(Value = "IRSA"), JsonStringEnumMemberName("IRSA")]
    IRSA,
    [EnumMember(Value = "WebIdentity"), JsonStringEnumMemberName("WebIdentity")]
    WebIdentity,
    [EnumMember(Value = "PodIdentity"), JsonStringEnumMemberName("PodIdentity")]
    PodIdentity,
    [EnumMember(Value = "Upbound"), JsonStringEnumMemberName("Upbound")]
    Upbound
}

/// <summary>
/// Fs is a reference to a filesystem location that contains credentials that
/// must be used to obtain the web identity token.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>
/// A SecretRef is a reference to a secret key that contains the credentials
/// that must be used to obtain the web identity token.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigSecretRef
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

/// <summary>Source is the source of the web identity token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigSourceEnum>))]
public enum V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigSourceEnum
{
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret,
    [EnumMember(Value = "Filesystem"), JsonStringEnumMemberName("Filesystem")]
    Filesystem
}

/// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfig
{
    /// <summary>
    /// Fs is a reference to a filesystem location that contains credentials that
    /// must be used to obtain the web identity token.
    /// </summary>
    [JsonPropertyName("fs")]
    public V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigFs? Fs { get; set; }

    /// <summary>
    /// A SecretRef is a reference to a secret key that contains the credentials
    /// that must be used to obtain the web identity token.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigSecretRef? SecretRef { get; set; }

    /// <summary>Source is the source of the web identity token.</summary>
    [JsonPropertyName("source")]
    public required V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigSourceEnum Source { get; set; }
}

/// <summary>
/// WebIdentity defines the options for assuming an IAM role with a Web
/// Identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentity
{
    /// <summary>AssumeRoleARN to assume with provider credentials</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>RoleSessionName is the session name, if you wish to uniquely identify this session.</summary>
    [JsonPropertyName("roleSessionName")]
    public string? RoleSessionName { get; set; }

    /// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
    [JsonPropertyName("tokenConfig")]
    public V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentityTokenConfig? TokenConfig { get; set; }
}

/// <summary>Upbound defines the options for authenticating using Upbound as an identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsUpbound
{
    /// <summary>
    /// WebIdentity defines the options for assuming an IAM role with a Web
    /// Identity.
    /// </summary>
    [JsonPropertyName("webIdentity")]
    public V1beta1ClusterProviderConfigSpecCredentialsUpboundWebIdentity? WebIdentity { get; set; }
}

/// <summary>
/// Fs is a reference to a filesystem location that contains credentials that
/// must be used to obtain the web identity token.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfigFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>
/// A SecretRef is a reference to a secret key that contains the credentials
/// that must be used to obtain the web identity token.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfigSecretRef
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

/// <summary>Source is the source of the web identity token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfigSourceEnum>))]
public enum V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfigSourceEnum
{
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret,
    [EnumMember(Value = "Filesystem"), JsonStringEnumMemberName("Filesystem")]
    Filesystem
}

/// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfig
{
    /// <summary>
    /// Fs is a reference to a filesystem location that contains credentials that
    /// must be used to obtain the web identity token.
    /// </summary>
    [JsonPropertyName("fs")]
    public V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfigFs? Fs { get; set; }

    /// <summary>
    /// A SecretRef is a reference to a secret key that contains the credentials
    /// that must be used to obtain the web identity token.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfigSecretRef? SecretRef { get; set; }

    /// <summary>Source is the source of the web identity token.</summary>
    [JsonPropertyName("source")]
    public required V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfigSourceEnum Source { get; set; }
}

/// <summary>WebIdentity defines the options for assuming an IAM role with a Web Identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsWebIdentity
{
    /// <summary>AssumeRoleARN to assume with provider credentials</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>RoleSessionName is the session name, if you wish to uniquely identify this session.</summary>
    [JsonPropertyName("roleSessionName")]
    public string? RoleSessionName { get; set; }

    /// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
    [JsonPropertyName("tokenConfig")]
    public V1beta1ClusterProviderConfigSpecCredentialsWebIdentityTokenConfig? TokenConfig { get; set; }
}

/// <summary>Credentials required to authenticate to this provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentials
{
    /// <summary>
    /// Env is a reference to an environment variable that contains credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("env")]
    public V1beta1ClusterProviderConfigSpecCredentialsEnv? Env { get; set; }

    /// <summary>
    /// Fs is a reference to a filesystem location that contains credentials that
    /// must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("fs")]
    public V1beta1ClusterProviderConfigSpecCredentialsFs? Fs { get; set; }

    /// <summary>
    /// A SecretRef is a reference to a secret key that contains the credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ClusterProviderConfigSpecCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    public required V1beta1ClusterProviderConfigSpecCredentialsSourceEnum Source { get; set; }

    /// <summary>Upbound defines the options for authenticating using Upbound as an identity provider.</summary>
    [JsonPropertyName("upbound")]
    public V1beta1ClusterProviderConfigSpecCredentialsUpbound? Upbound { get; set; }

    /// <summary>WebIdentity defines the options for assuming an IAM role with a Web Identity.</summary>
    [JsonPropertyName("webIdentity")]
    public V1beta1ClusterProviderConfigSpecCredentialsWebIdentity? WebIdentity { get; set; }
}

/// <summary>
/// The source of the Endpoint. By default, this will be ServiceMetadata.
/// When providing a custom endpoint, you should set the source as Custom.
/// If source is not provided when providing a custom endpoint, the SDK may not
/// perform required host mutations correctly. Source should be used along with
/// HostnameImmutable property as per the usage requirement.
/// Note that this is effective only for resources that use AWS SDK v2.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterProviderConfigSpecEndpointSourceEnum>))]
public enum V1beta1ClusterProviderConfigSpecEndpointSourceEnum
{
    [EnumMember(Value = "ServiceMetadata"), JsonStringEnumMemberName("ServiceMetadata")]
    ServiceMetadata,
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom
}

/// <summary>
/// Protocol is the HTTP protocol that will be used in the URL. Currently,
/// only http and https are supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterProviderConfigSpecEndpointUrlDynamicProtocolEnum>))]
public enum V1beta1ClusterProviderConfigSpecEndpointUrlDynamicProtocolEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "https"), JsonStringEnumMemberName("https")]
    Https
}

/// <summary>Dynamic lets you configure the behavior of endpoint URL resolver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecEndpointUrlDynamic
{
    /// <summary>
    /// Host is the address of the main host that the resolver will use to
    /// prepend protocol, service and region configurations.
    /// For example, the final URL for EC2 in us-east-1 looks like https://ec2.us-east-1.amazonaws.com
    /// You would need to use &quot;amazonaws.com&quot; as Host and &quot;https&quot; as protocol
    /// to have the resolver construct it.
    /// </summary>
    [JsonPropertyName("host")]
    public required string Host { get; set; }

    /// <summary>
    /// Protocol is the HTTP protocol that will be used in the URL. Currently,
    /// only http and https are supported.
    /// </summary>
    [JsonPropertyName("protocol")]
    public required V1beta1ClusterProviderConfigSpecEndpointUrlDynamicProtocolEnum Protocol { get; set; }
}

/// <summary>
/// You can provide a static URL that will be used regardless of the service
/// and region by choosing Static type. Alternatively, you can provide
/// configuration for dynamically resolving the URL with the config you provide
/// once you set the type as Dynamic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterProviderConfigSpecEndpointUrlTypeEnum>))]
public enum V1beta1ClusterProviderConfigSpecEndpointUrlTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static,
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Auto"), JsonStringEnumMemberName("Auto")]
    Auto
}

/// <summary>URL lets you configure the endpoint URL to be used in SDK calls.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecEndpointUrl
{
    /// <summary>Dynamic lets you configure the behavior of endpoint URL resolver.</summary>
    [JsonPropertyName("dynamic")]
    public V1beta1ClusterProviderConfigSpecEndpointUrlDynamic? Dynamic { get; set; }

    /// <summary>
    /// Static is the full URL you&apos;d like the AWS SDK to use.
    /// Recommended for using tools like localstack where a single host is exposed
    /// for all services and regions.
    /// </summary>
    [JsonPropertyName("static")]
    public string? Static { get; set; }

    /// <summary>
    /// You can provide a static URL that will be used regardless of the service
    /// and region by choosing Static type. Alternatively, you can provide
    /// configuration for dynamically resolving the URL with the config you provide
    /// once you set the type as Dynamic.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1ClusterProviderConfigSpecEndpointUrlTypeEnum Type { get; set; }
}

/// <summary>
/// Endpoint is where you can override the default endpoint configuration
/// of AWS calls made by the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecEndpoint
{
    /// <summary>
    /// Specifies if the endpoint&apos;s hostname can be modified by the SDK&apos;s API
    /// client.
    /// 
    /// If the hostname is mutable the SDK API clients may modify any part of
    /// the hostname based on the requirements of the API, (e.g. adding, or
    /// removing content in the hostname). Such as, Amazon S3 API client
    /// prefixing &quot;bucketname&quot; to the hostname, or changing the
    /// hostname service name component from &quot;s3.&quot; to &quot;s3-accesspoint.dualstack.&quot;
    /// for the dualstack endpoint of an S3 Accesspoint resource.
    /// 
    /// Care should be taken when providing a custom endpoint for an API. If the
    /// endpoint hostname is mutable, and the client cannot modify the endpoint
    /// correctly, the operation call will most likely fail, or have undefined
    /// behavior.
    /// 
    /// If hostname is immutable, the SDK API clients will not modify the
    /// hostname of the URL. This may cause the API client not to function
    /// correctly if the API requires the operation specific hostname values
    /// to be used by the client.
    /// 
    /// This flag does not modify the API client&apos;s behavior if this endpoint
    /// will be used instead of Endpoint Discovery, or if the endpoint will be
    /// used to perform Endpoint Discovery. That behavior is configured via the
    /// API Client&apos;s Options.
    /// Note that this is effective only for resources that use AWS SDK v2.
    /// </summary>
    [JsonPropertyName("hostnameImmutable")]
    public bool? HostnameImmutable { get; set; }

    /// <summary>The AWS partition the endpoint belongs to.</summary>
    [JsonPropertyName("partitionId")]
    public string? PartitionId { get; set; }

    /// <summary>Specifies the list of services you want endpoint to be used for</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }

    /// <summary>
    /// The signing method that should be used for signing the requests to the
    /// endpoint.
    /// </summary>
    [JsonPropertyName("signingMethod")]
    public string? SigningMethod { get; set; }

    /// <summary>
    /// The service name that should be used for signing the requests to the
    /// endpoint.
    /// </summary>
    [JsonPropertyName("signingName")]
    public string? SigningName { get; set; }

    /// <summary>
    /// The region that should be used for signing the request to the endpoint.
    /// For IAM, which doesn&apos;t have any region, us-east-1 is used to sign the
    /// requests, which is the only signing region of IAM.
    /// </summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>
    /// The source of the Endpoint. By default, this will be ServiceMetadata.
    /// When providing a custom endpoint, you should set the source as Custom.
    /// If source is not provided when providing a custom endpoint, the SDK may not
    /// perform required host mutations correctly. Source should be used along with
    /// HostnameImmutable property as per the usage requirement.
    /// Note that this is effective only for resources that use AWS SDK v2.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta1ClusterProviderConfigSpecEndpointSourceEnum? Source { get; set; }

    /// <summary>URL lets you configure the endpoint URL to be used in SDK calls.</summary>
    [JsonPropertyName("url")]
    public required V1beta1ClusterProviderConfigSpecEndpointUrl Url { get; set; }
}

/// <summary>
/// ExponentialFailureRateLimiter, when set, overrides the parameters of the
/// exponential failure rate limiter used to schedule retries for the
/// managed resource that this policy applies to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecReconciliationPolicyExponentialFailureRateLimiter
{
    /// <summary>BaseDelay is the initial delay between retries.</summary>
    [JsonPropertyName("baseDelay")]
    public string? BaseDelay { get; set; }

    /// <summary>MaxDelay is the maximum delay between retries.</summary>
    [JsonPropertyName("maxDelay")]
    public string? MaxDelay { get; set; }
}

/// <summary>
/// ReconciliationPolicy configures how a managed resource is reconciled.
/// It currently allows overriding the controller&apos;s failure rate limiter
/// parameters on a per-resource basis via ExponentialFailureRateLimiter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecReconciliationPolicy
{
    /// <summary>
    /// ExponentialFailureRateLimiter, when set, overrides the parameters of the
    /// exponential failure rate limiter used to schedule retries for the
    /// managed resource that this policy applies to.
    /// </summary>
    [JsonPropertyName("exponentialFailureRateLimiter")]
    public V1beta1ClusterProviderConfigSpecReconciliationPolicyExponentialFailureRateLimiter? ExponentialFailureRateLimiter { get; set; }
}

/// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpec
{
    /// <summary>AssumeRoleChain defines the options for assuming an IAM role</summary>
    [JsonPropertyName("assumeRoleChain")]
    public IList<V1beta1ClusterProviderConfigSpecAssumeRoleChain>? AssumeRoleChain { get; set; }

    /// <summary>Credentials required to authenticate to this provider.</summary>
    [JsonPropertyName("credentials")]
    public required V1beta1ClusterProviderConfigSpecCredentials Credentials { get; set; }

    /// <summary>
    /// Endpoint is where you can override the default endpoint configuration
    /// of AWS calls made by the provider.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public V1beta1ClusterProviderConfigSpecEndpoint? Endpoint { get; set; }

    /// <summary>
    /// ReconciliationPolicy configures how a managed resource is reconciled.
    /// It currently allows overriding the controller&apos;s failure rate limiter
    /// parameters on a per-resource basis via ExponentialFailureRateLimiter.
    /// </summary>
    [JsonPropertyName("reconciliationPolicy")]
    public V1beta1ClusterProviderConfigSpecReconciliationPolicy? ReconciliationPolicy { get; set; }

    /// <summary>Whether to enable the request to use path-style addressing, i.e., https://s3.amazonaws.com/BUCKET/KEY.</summary>
    [JsonPropertyName("s3_use_path_style")]
    public bool? S3UsePathStyle { get; set; }

    /// <summary>
    /// Whether to skip credentials validation via the STS API.
    /// This can be useful for testing and for AWS API implementations that do not have STS available.
    /// </summary>
    [JsonPropertyName("skip_credentials_validation")]
    public bool? SkipCredentialsValidation { get; set; }

    /// <summary>
    /// Whether to skip the AWS Metadata API check
    /// Useful for AWS API implementations that do not have a metadata API endpoint.
    /// </summary>
    [JsonPropertyName("skip_metadata_api_check")]
    public bool? SkipMetadataApiCheck { get; set; }

    /// <summary>
    /// Whether to skip validation of provided region name.
    /// Useful for AWS-like implementations that use their own region names or to bypass the validation for
    /// regions that aren&apos;t publicly available yet.
    /// </summary>
    [JsonPropertyName("skip_region_validation")]
    public bool? SkipRegionValidation { get; set; }

    /// <summary>
    /// Whether to skip requesting the account ID.
    /// Useful for AWS API implementations that do not have the IAM, STS API, or metadata API
    /// </summary>
    [JsonPropertyName("skip_requesting_account_id")]
    public bool? SkipRequestingAccountId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigStatusConditions
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

/// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterProviderConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Users of this provider configuration.</summary>
    [JsonPropertyName("users")]
    public long? Users { get; set; }
}

/// <summary>A ClusterProviderConfig configures the AWS provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterProviderConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterProviderConfigSpec>, IStatus<V1beta1ClusterProviderConfigStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterProviderConfig";
    public const string KubeGroup = "aws.m.upbound.io";
    public const string KubePluralName = "clusterproviderconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterProviderConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ClusterProviderConfigSpec Spec { get; set; }

    /// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterProviderConfigStatus? Status { get; set; }
}
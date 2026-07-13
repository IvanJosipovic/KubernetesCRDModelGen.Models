#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keda.sh;
/// <summary>TriggerAuthentication defines how a trigger can authenticate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TriggerAuthenticationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TriggerAuthentication>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TriggerAuthenticationList";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "triggerauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TriggerAuthenticationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TriggerAuthentication objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TriggerAuthentication> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentials
{
    [JsonPropertyName("accessKey")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey AccessKey { get; set; }

    [JsonPropertyName("accessSecretKey")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey AccessSecretKey { get; set; }

    [JsonPropertyName("accessToken")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken? AccessToken { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum>))]
public enum V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>
/// AuthPodIdentity allows users to select the platform native identity
/// mechanism
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentity
{
    /// <summary>ExternalID sets the External ID to be used when assuming an identity. This is only applicable when using AWS pod identity with a RoleArn.</summary>
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerSecrets
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("secretKey")]
    public string? SecretKey { get; set; }

    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    [JsonPropertyName("versionStage")]
    public string? VersionStage { get; set; }
}

/// <summary>AwsSecretManager is used to authenticate using AwsSecretManager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManager
{
    [JsonPropertyName("credentials")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentials? Credentials { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1TriggerAuthenticationSpecAwsSecretManagerSecrets> Secrets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCloud
{
    [JsonPropertyName("activeDirectoryEndpoint")]
    public string? ActiveDirectoryEndpoint { get; set; }

    [JsonPropertyName("keyVaultResourceURL")]
    public string? KeyVaultResourceURL { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentials
{
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public required V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret ClientSecret { get; set; }

    [JsonPropertyName("tenantId")]
    public required string TenantId { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum>))]
public enum V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>
/// AuthPodIdentity allows users to select the platform native identity
/// mechanism
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentity
{
    /// <summary>ExternalID sets the External ID to be used when assuming an identity. This is only applicable when using AWS pod identity with a RoleArn.</summary>
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultSecrets
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>AzureKeyVault is used to authenticate using Azure Key Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVault
{
    [JsonPropertyName("cloud")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultCloud? Cloud { get; set; }

    [JsonPropertyName("credentials")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentials? Credentials { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1TriggerAuthenticationSpecAzureKeyVaultSecrets> Secrets { get; set; }

    [JsonPropertyName("vaultUri")]
    public required string VaultUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecBoundServiceAccountToken
{
    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public required string ServiceAccountName { get; set; }
}

/// <summary>AuthConfigMapTargetRef is used to authenticate using a reference to a config map</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecConfigMapTargetRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }
}

/// <summary>
/// AuthEnvironment is used to authenticate using environment variables
/// in the destination ScaleTarget spec
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecEnv
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentials
{
    [JsonPropertyName("clientSecret")]
    public required V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret ClientSecret { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum>))]
public enum V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>
/// AuthPodIdentity allows users to select the platform native identity
/// mechanism
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentity
{
    /// <summary>ExternalID sets the External ID to be used when assuming an identity. This is only applicable when using AWS pod identity with a RoleArn.</summary>
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerSecrets
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManager
{
    [JsonPropertyName("credentials")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentials? Credentials { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1TriggerAuthenticationSpecGcpSecretManagerSecrets> Secrets { get; set; }
}

/// <summary>VaultAuthentication contains the list of Hashicorp Vault authentication methods</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecHashiCorpVaultAuthenticationEnum>))]
public enum V1alpha1TriggerAuthenticationSpecHashiCorpVaultAuthenticationEnum
{
    [EnumMember(Value = "token"), JsonStringEnumMemberName("token")]
    Token,
    [EnumMember(Value = "kubernetes"), JsonStringEnumMemberName("kubernetes")]
    Kubernetes
}

/// <summary>Credential defines the Hashicorp Vault credentials depending on the authentication method</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVaultCredential
{
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecretsPkiData
{
    [JsonPropertyName("altNames")]
    public string? AltNames { get; set; }

    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("ipSans")]
    public string? IpSans { get; set; }

    [JsonPropertyName("otherSans")]
    public string? OtherSans { get; set; }

    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    [JsonPropertyName("uriSans")]
    public string? UriSans { get; set; }
}

/// <summary>VaultSecret defines the mapping between the path of the secret in Vault to the parameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecrets
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("pkiData")]
    public V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecretsPkiData? PkiData { get; set; }

    /// <summary>VaultSecretType defines the type of vault secret</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HashiCorpVault is used to authenticate using Hashicorp Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVault
{
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>VaultAuthentication contains the list of Hashicorp Vault authentication methods</summary>
    [JsonPropertyName("authentication")]
    public required V1alpha1TriggerAuthenticationSpecHashiCorpVaultAuthenticationEnum Authentication { get; set; }

    /// <summary>Credential defines the Hashicorp Vault credentials depending on the authentication method</summary>
    [JsonPropertyName("credential")]
    public V1alpha1TriggerAuthenticationSpecHashiCorpVaultCredential? Credential { get; set; }

    [JsonPropertyName("mount")]
    public string? Mount { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecrets> Secrets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecOauth2ClientSecretValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecOauth2ClientSecretValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1TriggerAuthenticationSpecOauth2ClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecOauth2ClientSecret
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1TriggerAuthenticationSpecOauth2ClientSecretValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecOauth2TypeEnum>))]
public enum V1alpha1TriggerAuthenticationSpecOauth2TypeEnum
{
    [EnumMember(Value = "clientCredentials"), JsonStringEnumMemberName("clientCredentials")]
    ClientCredentials
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecOauth2
{
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public V1alpha1TriggerAuthenticationSpecOauth2ClientSecret? ClientSecret { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenUrl")]
    public required string TokenUrl { get; set; }

    [JsonPropertyName("tokenUrlParams")]
    public IDictionary<string, string>? TokenUrlParams { get; set; }

    [JsonPropertyName("type")]
    public V1alpha1TriggerAuthenticationSpecOauth2TypeEnum? Type { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1TriggerAuthenticationSpecPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TriggerAuthenticationSpecPodIdentityProviderEnum>))]
public enum V1alpha1TriggerAuthenticationSpecPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>
/// AuthPodIdentity allows users to select the platform native identity
/// mechanism
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecPodIdentity
{
    /// <summary>ExternalID sets the External ID to be used when assuming an identity. This is only applicable when using AWS pod identity with a RoleArn.</summary>
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public V1alpha1TriggerAuthenticationSpecPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1TriggerAuthenticationSpecPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>AuthSecretTargetRef is used to authenticate using a reference to a secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecSecretTargetRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }
}

/// <summary>TriggerAuthenticationSpec defines the various ways to authenticate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpec
{
    /// <summary>AwsSecretManager is used to authenticate using AwsSecretManager</summary>
    [JsonPropertyName("awsSecretManager")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManager? AwsSecretManager { get; set; }

    /// <summary>AzureKeyVault is used to authenticate using Azure Key Vault</summary>
    [JsonPropertyName("azureKeyVault")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVault? AzureKeyVault { get; set; }

    [JsonPropertyName("boundServiceAccountToken")]
    public IList<V1alpha1TriggerAuthenticationSpecBoundServiceAccountToken>? BoundServiceAccountToken { get; set; }

    [JsonPropertyName("configMapTargetRef")]
    public IList<V1alpha1TriggerAuthenticationSpecConfigMapTargetRef>? ConfigMapTargetRef { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1TriggerAuthenticationSpecEnv>? Env { get; set; }

    /// <summary>
    /// FilePath specifies a file containing auth parameters as JSON map[string]string.
    /// When set, auth params are read directly from this file instead.
    /// </summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    [JsonPropertyName("gcpSecretManager")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManager? GcpSecretManager { get; set; }

    /// <summary>HashiCorpVault is used to authenticate using Hashicorp Vault</summary>
    [JsonPropertyName("hashiCorpVault")]
    public V1alpha1TriggerAuthenticationSpecHashiCorpVault? HashiCorpVault { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1TriggerAuthenticationSpecOauth2? Oauth2 { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("secretTargetRef")]
    public IList<V1alpha1TriggerAuthenticationSpecSecretTargetRef>? SecretTargetRef { get; set; }
}

/// <summary>TriggerAuthenticationStatus defines the observed state of TriggerAuthentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationStatus
{
    [JsonPropertyName("scaledjobs")]
    public string? Scaledjobs { get; set; }

    [JsonPropertyName("scaledobjects")]
    public string? Scaledobjects { get; set; }
}

/// <summary>TriggerAuthentication defines how a trigger can authenticate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TriggerAuthentication : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TriggerAuthenticationSpec>, IStatus<V1alpha1TriggerAuthenticationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TriggerAuthentication";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "triggerauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TriggerAuthentication";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerAuthenticationSpec defines the various ways to authenticate</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1TriggerAuthenticationSpec Spec { get; set; }

    /// <summary>TriggerAuthenticationStatus defines the observed state of TriggerAuthentication</summary>
    [JsonPropertyName("status")]
    public V1alpha1TriggerAuthenticationStatus? Status { get; set; }
}
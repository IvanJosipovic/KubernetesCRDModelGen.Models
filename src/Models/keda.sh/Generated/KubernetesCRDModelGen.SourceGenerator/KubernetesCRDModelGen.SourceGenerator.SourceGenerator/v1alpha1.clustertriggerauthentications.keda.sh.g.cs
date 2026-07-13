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
/// <summary>ClusterTriggerAuthentication defines how a trigger can authenticate globally</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterTriggerAuthenticationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterTriggerAuthentication>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterTriggerAuthenticationList";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "clustertriggerauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterTriggerAuthenticationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ClusterTriggerAuthentication objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ClusterTriggerAuthentication> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentials
{
    [JsonPropertyName("accessKey")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey AccessKey { get; set; }

    [JsonPropertyName("accessSecretKey")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey AccessSecretKey { get; set; }

    [JsonPropertyName("accessToken")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken? AccessToken { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentity
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
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerSecrets
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManager
{
    [JsonPropertyName("credentials")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentials? Credentials { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerSecrets> Secrets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCloud
{
    [JsonPropertyName("activeDirectoryEndpoint")]
    public string? ActiveDirectoryEndpoint { get; set; }

    [JsonPropertyName("keyVaultResourceURL")]
    public string? KeyVaultResourceURL { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentials
{
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret ClientSecret { get; set; }

    [JsonPropertyName("tenantId")]
    public required string TenantId { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentity
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
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultSecrets
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>AzureKeyVault is used to authenticate using Azure Key Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVault
{
    [JsonPropertyName("cloud")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCloud? Cloud { get; set; }

    [JsonPropertyName("credentials")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentials? Credentials { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultSecrets> Secrets { get; set; }

    [JsonPropertyName("vaultUri")]
    public required string VaultUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecBoundServiceAccountToken
{
    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public required string ServiceAccountName { get; set; }
}

/// <summary>AuthConfigMapTargetRef is used to authenticate using a reference to a config map</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecConfigMapTargetRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecEnv
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentials
{
    [JsonPropertyName("clientSecret")]
    public required V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret ClientSecret { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentity
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
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerSecrets
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManager
{
    [JsonPropertyName("credentials")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentials? Credentials { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerSecrets> Secrets { get; set; }
}

/// <summary>VaultAuthentication contains the list of Hashicorp Vault authentication methods</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultAuthenticationEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultAuthenticationEnum
{
    [EnumMember(Value = "token"), JsonStringEnumMemberName("token")]
    Token,
    [EnumMember(Value = "kubernetes"), JsonStringEnumMemberName("kubernetes")]
    Kubernetes
}

/// <summary>Credential defines the Hashicorp Vault credentials depending on the authentication method</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultCredential
{
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecretsPkiData
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecrets
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("pkiData")]
    public V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecretsPkiData? PkiData { get; set; }

    /// <summary>VaultSecretType defines the type of vault secret</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HashiCorpVault is used to authenticate using Hashicorp Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVault
{
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>VaultAuthentication contains the list of Hashicorp Vault authentication methods</summary>
    [JsonPropertyName("authentication")]
    public required V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultAuthenticationEnum Authentication { get; set; }

    /// <summary>Credential defines the Hashicorp Vault credentials depending on the authentication method</summary>
    [JsonPropertyName("credential")]
    public V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultCredential? Credential { get; set; }

    [JsonPropertyName("mount")]
    public string? Mount { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("secrets")]
    public required IList<V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecrets> Secrets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecOauth2ClientSecretValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecOauth2ClientSecretValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public required V1alpha1ClusterTriggerAuthenticationSpecOauth2ClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecOauth2ClientSecret
{
    [JsonPropertyName("valueFrom")]
    public required V1alpha1ClusterTriggerAuthenticationSpecOauth2ClientSecretValueFrom ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecOauth2TypeEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecOauth2TypeEnum
{
    [EnumMember(Value = "clientCredentials"), JsonStringEnumMemberName("clientCredentials")]
    ClientCredentials
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecOauth2
{
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public V1alpha1ClusterTriggerAuthenticationSpecOauth2ClientSecret? ClientSecret { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenUrl")]
    public required string TokenUrl { get; set; }

    [JsonPropertyName("tokenUrlParams")]
    public IDictionary<string, string>? TokenUrlParams { get; set; }

    [JsonPropertyName("type")]
    public V1alpha1ClusterTriggerAuthenticationSpecOauth2TypeEnum? Type { get; set; }
}

/// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecPodIdentityIdentityOwnerEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    Workload
}

/// <summary>PodIdentityProvider contains the list of providers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecPodIdentityProviderEnum>))]
public enum V1alpha1ClusterTriggerAuthenticationSpecPodIdentityProviderEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecPodIdentity
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
    public V1alpha1ClusterTriggerAuthenticationSpecPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public required V1alpha1ClusterTriggerAuthenticationSpecPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>AuthSecretTargetRef is used to authenticate using a reference to a secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpecSecretTargetRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }
}

/// <summary>TriggerAuthenticationSpec defines the various ways to authenticate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationSpec
{
    /// <summary>AwsSecretManager is used to authenticate using AwsSecretManager</summary>
    [JsonPropertyName("awsSecretManager")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManager? AwsSecretManager { get; set; }

    /// <summary>AzureKeyVault is used to authenticate using Azure Key Vault</summary>
    [JsonPropertyName("azureKeyVault")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVault? AzureKeyVault { get; set; }

    [JsonPropertyName("boundServiceAccountToken")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecBoundServiceAccountToken>? BoundServiceAccountToken { get; set; }

    [JsonPropertyName("configMapTargetRef")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecConfigMapTargetRef>? ConfigMapTargetRef { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecEnv>? Env { get; set; }

    /// <summary>
    /// FilePath specifies a file containing auth parameters as JSON map[string]string.
    /// When set, auth params are read directly from this file instead.
    /// </summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    [JsonPropertyName("gcpSecretManager")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManager? GcpSecretManager { get; set; }

    /// <summary>HashiCorpVault is used to authenticate using Hashicorp Vault</summary>
    [JsonPropertyName("hashiCorpVault")]
    public V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVault? HashiCorpVault { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1ClusterTriggerAuthenticationSpecOauth2? Oauth2 { get; set; }

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity
    /// mechanism
    /// </summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecPodIdentity? PodIdentity { get; set; }

    [JsonPropertyName("secretTargetRef")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecSecretTargetRef>? SecretTargetRef { get; set; }
}

/// <summary>TriggerAuthenticationStatus defines the observed state of TriggerAuthentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterTriggerAuthenticationStatus
{
    [JsonPropertyName("scaledjobs")]
    public string? Scaledjobs { get; set; }

    [JsonPropertyName("scaledobjects")]
    public string? Scaledobjects { get; set; }
}

/// <summary>ClusterTriggerAuthentication defines how a trigger can authenticate globally</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterTriggerAuthentication : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterTriggerAuthenticationSpec>, IStatus<V1alpha1ClusterTriggerAuthenticationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterTriggerAuthentication";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "clustertriggerauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterTriggerAuthentication";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerAuthenticationSpec defines the various ways to authenticate</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ClusterTriggerAuthenticationSpec Spec { get; set; }

    /// <summary>TriggerAuthenticationStatus defines the observed state of TriggerAuthentication</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterTriggerAuthenticationStatus? Status { get; set; }
}
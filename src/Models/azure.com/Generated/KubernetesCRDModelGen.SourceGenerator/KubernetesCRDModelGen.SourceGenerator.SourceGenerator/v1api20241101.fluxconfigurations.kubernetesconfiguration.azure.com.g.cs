#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kubernetesconfiguration.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/fluxConfigurations/stable/2024-11-01/fluxconfiguration.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241101FluxConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1api20241101FluxConfiguration>
{
    public const string KubeApiVersion = "v1api20241101";
    public const string KubeKind = "FluxConfigurationList";
    public const string KubeGroup = "kubernetesconfiguration.azure.com";
    public const string KubePluralName = "fluxconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetesconfiguration.azure.com/v1api20241101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FluxConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20241101FluxConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20241101FluxConfiguration> Items { get; set; }
}

/// <summary>AccountKey: The account key (shared key) to access the storage account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobAccountKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ManagedIdentity: Parameters to authenticate using a Managed Identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobManagedIdentity
{
    /// <summary>ClientId: The client Id for authenticating a Managed Identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>SasToken: The Shared Access token to access the storage container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobSasToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ClientCertificate: Base64-encoded certificate used to authenticate a Service Principal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientCertificate
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ClientCertificatePassword: The password for the certificate used to authenticate a Service Principal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientCertificatePassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ClientIdFromConfig: The client Id for authenticating a Service Principal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ClientSecret: The client secret for authenticating a Service Principal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TenantIdFromConfig: The tenant Id for authenticating a Service Principal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ServicePrincipal: Parameters to authenticate using Service Principal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlobServicePrincipal
{
    /// <summary>ClientCertificate: Base64-encoded certificate used to authenticate a Service Principal</summary>
    [JsonPropertyName("clientCertificate")]
    public V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientCertificate? ClientCertificate { get; set; }

    /// <summary>ClientCertificatePassword: The password for the certificate used to authenticate a Service Principal</summary>
    [JsonPropertyName("clientCertificatePassword")]
    public V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientCertificatePassword? ClientCertificatePassword { get; set; }

    /// <summary>
    /// ClientCertificateSendChain: Specifies whether to include x5c header in client claims when acquiring a token to enable
    /// subject name / issuer based authentication for the Client Certificate
    /// </summary>
    [JsonPropertyName("clientCertificateSendChain")]
    public bool? ClientCertificateSendChain { get; set; }

    /// <summary>ClientId: The client Id for authenticating a Service Principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client Id for authenticating a Service Principal.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ClientSecret: The client secret for authenticating a Service Principal</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalClientSecret? ClientSecret { get; set; }

    /// <summary>TenantId: The tenant Id for authenticating a Service Principal</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>TenantIdFromConfig: The tenant Id for authenticating a Service Principal</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20241101FluxConfigurationSpecAzureBlobServicePrincipalTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>AzureBlob: Parameters to reconcile to the AzureBlob source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecAzureBlob
{
    /// <summary>AccountKey: The account key (shared key) to access the storage account</summary>
    [JsonPropertyName("accountKey")]
    public V1api20241101FluxConfigurationSpecAzureBlobAccountKey? AccountKey { get; set; }

    /// <summary>ContainerName: The Azure Blob container name to sync from the url endpoint for the flux configuration.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>ManagedIdentity: Parameters to authenticate using a Managed Identity.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20241101FluxConfigurationSpecAzureBlobManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>SasToken: The Shared Access token to access the storage container</summary>
    [JsonPropertyName("sasToken")]
    public V1api20241101FluxConfigurationSpecAzureBlobSasToken? SasToken { get; set; }

    /// <summary>ServicePrincipal: Parameters to authenticate using Service Principal.</summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20241101FluxConfigurationSpecAzureBlobServicePrincipal? ServicePrincipal { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster Azure Blob source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster Azure Blob source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration Azure Blob storage account.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>AccessKey: Plaintext access key used to securely access the S3 bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecBucketAccessKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Bucket: Parameters to reconcile to the Bucket source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecBucket
{
    /// <summary>AccessKey: Plaintext access key used to securely access the S3 bucket</summary>
    [JsonPropertyName("accessKey")]
    public V1api20241101FluxConfigurationSpecBucketAccessKey? AccessKey { get; set; }

    /// <summary>BucketName: The bucket name to sync from the url endpoint for the flux configuration.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Insecure: Specify whether to use insecure communication when puling data from the S3 bucket.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster bucket source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster bucket source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration S3 bucket.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>ConfigurationProtectedSettings: Key-value pairs of protected configuration settings for the configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecConfigurationProtectedSettings
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>HttpsCACert: Base64-encoded HTTPS certificate authority contents used to access git private git repositories over HTTPS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecGitRepositoryHttpsCACert
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Provider: Name of the provider used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20241101FluxConfigurationSpecGitRepositoryProviderEnum>))]
public enum V1api20241101FluxConfigurationSpecGitRepositoryProviderEnum
{
    [EnumMember(Value = "Azure"), JsonStringEnumMemberName("Azure")]
    Azure,
    [EnumMember(Value = "Generic"), JsonStringEnumMemberName("Generic")]
    Generic
}

/// <summary>RepositoryRef: The source reference for the GitRepository object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecGitRepositoryRepositoryRef
{
    /// <summary>Branch: The git repository branch name to checkout.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Commit: The commit SHA to checkout. This value must be combined with the branch name to be valid. This takes precedence
    /// over semver.
    /// </summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Semver: The semver range used to match against git repository tags. This takes precedence over tag.</summary>
    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    /// <summary>Tag: The git repository tag name to checkout. This takes precedence over branch.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>GitRepository: Parameters to reconcile to the GitRepository source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecGitRepository
{
    /// <summary>HttpsCACert: Base64-encoded HTTPS certificate authority contents used to access git private git repositories over HTTPS</summary>
    [JsonPropertyName("httpsCACert")]
    public V1api20241101FluxConfigurationSpecGitRepositoryHttpsCACert? HttpsCACert { get; set; }

    /// <summary>HttpsUser: Plaintext HTTPS username used to access private git repositories over HTTPS</summary>
    [JsonPropertyName("httpsUser")]
    public string? HttpsUser { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>Provider: Name of the provider used for authentication.</summary>
    [JsonPropertyName("provider")]
    public V1api20241101FluxConfigurationSpecGitRepositoryProviderEnum? Provider { get; set; }

    /// <summary>RepositoryRef: The source reference for the GitRepository object.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1api20241101FluxConfigurationSpecGitRepositoryRepositoryRef? RepositoryRef { get; set; }

    /// <summary>
    /// SshKnownHosts: Base64-encoded known_hosts value containing public SSH keys required to access private git repositories
    /// over SSH
    /// </summary>
    [JsonPropertyName("sshKnownHosts")]
    public string? SshKnownHosts { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster git repository source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster git repository source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration git repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Array of ConfigMaps/Secrets from which the variables are substituted for this Kustomization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecKustomizationsPostBuildSubstituteFrom
{
    /// <summary>Kind: Define whether it is ConfigMap or Secret that holds the variables to be used in substitution.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name: Name of the ConfigMap/Secret that holds the variables to be used in substitution.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional: Set to True to proceed without ConfigMap/Secret, if it is not present.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>PostBuild: Used for variable substitution for this Kustomization after kustomize build.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecKustomizationsPostBuild
{
    /// <summary>Substitute: Key/value pairs holding the variables to be substituted in this Kustomization.</summary>
    [JsonPropertyName("substitute")]
    public IDictionary<string, string>? Substitute { get; set; }

    /// <summary>SubstituteFrom: Array of ConfigMaps/Secrets from which the variables are substituted for this Kustomization.</summary>
    [JsonPropertyName("substituteFrom")]
    public IList<V1api20241101FluxConfigurationSpecKustomizationsPostBuildSubstituteFrom>? SubstituteFrom { get; set; }
}

/// <summary>The Kustomization defining how to reconcile the artifact pulled by the source type on the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecKustomizations
{
    /// <summary>
    /// DependsOn: Specifies other Kustomizations that this Kustomization depends on. This Kustomization will not reconcile
    /// until all dependencies have completed their reconciliation.
    /// </summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>
    /// Force: Enable/disable re-creating Kubernetes resources on the cluster when patching fails due to an immutable field
    /// change.
    /// </summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>Path: The path in the source reference to reconcile on the cluster.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>PostBuild: Used for variable substitution for this Kustomization after kustomize build.</summary>
    [JsonPropertyName("postBuild")]
    public V1api20241101FluxConfigurationSpecKustomizationsPostBuild? PostBuild { get; set; }

    /// <summary>Prune: Enable/disable garbage collections of Kubernetes objects created by this Kustomization.</summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>
    /// RetryIntervalInSeconds: The interval at which to re-reconcile the Kustomization on the cluster in the event of failure
    /// on reconciliation.
    /// </summary>
    [JsonPropertyName("retryIntervalInSeconds")]
    public int? RetryIntervalInSeconds { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the Kustomization on the cluster.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the Kustomization on the cluster.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Wait: Enable/disable health check for all Kubernetes objects created by this Kustomization.</summary>
    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }
}

/// <summary>
/// Operation: The operation to be performed on the selected layer. The default value is &apos;extract&apos;, but it can be set to
/// &apos;copy&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20241101FluxConfigurationSpecOciRepositoryLayerSelectorOperationEnum>))]
public enum V1api20241101FluxConfigurationSpecOciRepositoryLayerSelectorOperationEnum
{
    [EnumMember(Value = "copy"), JsonStringEnumMemberName("copy")]
    Copy,
    [EnumMember(Value = "extract"), JsonStringEnumMemberName("extract")]
    Extract
}

/// <summary>LayerSelector: The layer to be pulled from the OCI artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryLayerSelector
{
    /// <summary>MediaType: The first layer matching the specified media type will be used.</summary>
    [JsonPropertyName("mediaType")]
    public string? MediaType { get; set; }

    /// <summary>
    /// Operation: The operation to be performed on the selected layer. The default value is &apos;extract&apos;, but it can be set to
    /// &apos;copy&apos;.
    /// </summary>
    [JsonPropertyName("operation")]
    public V1api20241101FluxConfigurationSpecOciRepositoryLayerSelectorOperationEnum? Operation { get; set; }
}

/// <summary>RepositoryRef: The source reference for the OCIRepository object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryRepositoryRef
{
    /// <summary>
    /// Digest: The image digest to pull from OCI repository, the value should be in the format ‘sha256:’. This takes
    /// precedence over semver.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Semver: The semver range used to match against OCI repository tags. This takes precedence over tag.</summary>
    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    /// <summary>Tag: The OCI repository image tag name to pull. This defaults to &apos;latest&apos;.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>CaCertificate: Base64-encoded CA certificate used to verify the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryTlsConfigCaCertificate
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ClientCertificate: Base64-encoded certificate used to authenticate a client with the OCI repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryTlsConfigClientCertificate
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PrivateKey: Base64-encoded private key used to authenticate a client with the OCI repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryTlsConfigPrivateKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TlsConfig: Parameters to authenticate using TLS config for OCI repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryTlsConfig
{
    /// <summary>CaCertificate: Base64-encoded CA certificate used to verify the server.</summary>
    [JsonPropertyName("caCertificate")]
    public V1api20241101FluxConfigurationSpecOciRepositoryTlsConfigCaCertificate? CaCertificate { get; set; }

    /// <summary>ClientCertificate: Base64-encoded certificate used to authenticate a client with the OCI repository.</summary>
    [JsonPropertyName("clientCertificate")]
    public V1api20241101FluxConfigurationSpecOciRepositoryTlsConfigClientCertificate? ClientCertificate { get; set; }

    /// <summary>PrivateKey: Base64-encoded private key used to authenticate a client with the OCI repository.</summary>
    [JsonPropertyName("privateKey")]
    public V1api20241101FluxConfigurationSpecOciRepositoryTlsConfigPrivateKey? PrivateKey { get; set; }
}

/// <summary>MatchOIDCIdentity defines the criteria for matching the identity while verifying an OCI artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryVerifyMatchOidcIdentity
{
    /// <summary>Issuer: The regex pattern to match against to verify the OIDC issuer.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Subject: The regex pattern to match against to verify the identity subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>Verify: Verification of the authenticity of an OCI Artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepositoryVerify
{
    /// <summary>MatchOidcIdentity: Array defining the criteria for matching the identity while verifying an OCI artifact.</summary>
    [JsonPropertyName("matchOidcIdentity")]
    public IList<V1api20241101FluxConfigurationSpecOciRepositoryVerifyMatchOidcIdentity>? MatchOidcIdentity { get; set; }

    /// <summary>Provider: Verification provider name.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>VerificationConfig: An object containing trusted public keys of trusted authors.</summary>
    [JsonPropertyName("verificationConfig")]
    public IDictionary<string, string>? VerificationConfig { get; set; }
}

/// <summary>OciRepository: Parameters to reconcile to the OCIRepository source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOciRepository
{
    /// <summary>Insecure: Specify whether to allow connecting to a non-TLS HTTP container registry.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>LayerSelector: The layer to be pulled from the OCI artifact.</summary>
    [JsonPropertyName("layerSelector")]
    public V1api20241101FluxConfigurationSpecOciRepositoryLayerSelector? LayerSelector { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>RepositoryRef: The source reference for the OCIRepository object.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1api20241101FluxConfigurationSpecOciRepositoryRepositoryRef? RepositoryRef { get; set; }

    /// <summary>ServiceAccountName: The service account name to authenticate with the OCI repository.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster OCI repository source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster OCI repository source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>TlsConfig: Parameters to authenticate using TLS config for OCI repository.</summary>
    [JsonPropertyName("tlsConfig")]
    public V1api20241101FluxConfigurationSpecOciRepositoryTlsConfig? TlsConfig { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration OCI repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>UseWorkloadIdentity: Specifies whether to use Workload Identity to authenticate with the OCI repository.</summary>
    [JsonPropertyName("useWorkloadIdentity")]
    public bool? UseWorkloadIdentity { get; set; }

    /// <summary>Verify: Verification of the authenticity of an OCI Artifact.</summary>
    [JsonPropertyName("verify")]
    public V1api20241101FluxConfigurationSpecOciRepositoryVerify? Verify { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20241101FluxConfigurationSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20241101FluxConfigurationSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpecOwner
{
    /// <summary>Ownership across namespaces is not supported.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Scope: Scope at which the operator will be installed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20241101FluxConfigurationSpecScopeEnum>))]
public enum V1api20241101FluxConfigurationSpecScopeEnum
{
    [EnumMember(Value = "cluster"), JsonStringEnumMemberName("cluster")]
    Cluster,
    [EnumMember(Value = "namespace"), JsonStringEnumMemberName("namespace")]
    Namespace
}

/// <summary>SourceKind: Source Kind to pull the configuration data from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20241101FluxConfigurationSpecSourceKindEnum>))]
public enum V1api20241101FluxConfigurationSpecSourceKindEnum
{
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    OCIRepository
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationSpec
{
    /// <summary>AzureBlob: Parameters to reconcile to the AzureBlob source kind type.</summary>
    [JsonPropertyName("azureBlob")]
    public V1api20241101FluxConfigurationSpecAzureBlob? AzureBlob { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Bucket: Parameters to reconcile to the Bucket source kind type.</summary>
    [JsonPropertyName("bucket")]
    public V1api20241101FluxConfigurationSpecBucket? Bucket { get; set; }

    /// <summary>ConfigurationProtectedSettings: Key-value pairs of protected configuration settings for the configuration</summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public V1api20241101FluxConfigurationSpecConfigurationProtectedSettings? ConfigurationProtectedSettings { get; set; }

    /// <summary>GitRepository: Parameters to reconcile to the GitRepository source kind type.</summary>
    [JsonPropertyName("gitRepository")]
    public V1api20241101FluxConfigurationSpecGitRepository? GitRepository { get; set; }

    /// <summary>Kustomizations: Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster.</summary>
    [JsonPropertyName("kustomizations")]
    public IDictionary<string, V1api20241101FluxConfigurationSpecKustomizations>? Kustomizations { get; set; }

    /// <summary>
    /// Namespace: The namespace to which this configuration is installed to. Maximum of 253 lower case alphanumeric characters,
    /// hyphen and period only.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>OciRepository: Parameters to reconcile to the OCIRepository source kind type.</summary>
    [JsonPropertyName("ociRepository")]
    public V1api20241101FluxConfigurationSpecOciRepository? OciRepository { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20241101FluxConfigurationSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20241101FluxConfigurationSpecOwner Owner { get; set; }

    /// <summary>ReconciliationWaitDuration: Maximum duration to wait for flux configuration reconciliation. E.g PT1H, PT5M, P1D</summary>
    [JsonPropertyName("reconciliationWaitDuration")]
    public string? ReconciliationWaitDuration { get; set; }

    /// <summary>Scope: Scope at which the operator will be installed.</summary>
    [JsonPropertyName("scope")]
    public V1api20241101FluxConfigurationSpecScopeEnum? Scope { get; set; }

    /// <summary>SourceKind: Source Kind to pull the configuration data from.</summary>
    [JsonPropertyName("sourceKind")]
    public V1api20241101FluxConfigurationSpecSourceKindEnum? SourceKind { get; set; }

    /// <summary>Suspend: Whether this configuration should suspend its reconciliation of its kustomizations and sources.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>WaitForReconciliation: Whether flux configuration deployment should wait for cluster to reconcile the kustomizations.</summary>
    [JsonPropertyName("waitForReconciliation")]
    public bool? WaitForReconciliation { get; set; }
}

/// <summary>ManagedIdentity: Parameters to authenticate using a Managed Identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusAzureBlobManagedIdentity
{
    /// <summary>ClientId: The client Id for authenticating a Managed Identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>ServicePrincipal: Parameters to authenticate using Service Principal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusAzureBlobServicePrincipal
{
    /// <summary>
    /// ClientCertificateSendChain: Specifies whether to include x5c header in client claims when acquiring a token to enable
    /// subject name / issuer based authentication for the Client Certificate
    /// </summary>
    [JsonPropertyName("clientCertificateSendChain")]
    public bool? ClientCertificateSendChain { get; set; }

    /// <summary>ClientId: The client Id for authenticating a Service Principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>TenantId: The tenant Id for authenticating a Service Principal</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>AzureBlob: Parameters to reconcile to the AzureBlob source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusAzureBlob
{
    /// <summary>ContainerName: The Azure Blob container name to sync from the url endpoint for the flux configuration.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>ManagedIdentity: Parameters to authenticate using a Managed Identity.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20241101FluxConfigurationStatusAzureBlobManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>ServicePrincipal: Parameters to authenticate using Service Principal.</summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20241101FluxConfigurationStatusAzureBlobServicePrincipal? ServicePrincipal { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster Azure Blob source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster Azure Blob source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration Azure Blob storage account.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Bucket: Parameters to reconcile to the Bucket source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusBucket
{
    /// <summary>BucketName: The bucket name to sync from the url endpoint for the flux configuration.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Insecure: Specify whether to use insecure communication when puling data from the S3 bucket.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster bucket source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster bucket source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration S3 bucket.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>RepositoryRef: The source reference for the GitRepository object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusGitRepositoryRepositoryRef
{
    /// <summary>Branch: The git repository branch name to checkout.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Commit: The commit SHA to checkout. This value must be combined with the branch name to be valid. This takes precedence
    /// over semver.
    /// </summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Semver: The semver range used to match against git repository tags. This takes precedence over tag.</summary>
    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    /// <summary>Tag: The git repository tag name to checkout. This takes precedence over branch.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>GitRepository: Parameters to reconcile to the GitRepository source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusGitRepository
{
    /// <summary>HttpsUser: Plaintext HTTPS username used to access private git repositories over HTTPS</summary>
    [JsonPropertyName("httpsUser")]
    public string? HttpsUser { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>Provider: Name of the provider used for authentication.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>RepositoryRef: The source reference for the GitRepository object.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1api20241101FluxConfigurationStatusGitRepositoryRepositoryRef? RepositoryRef { get; set; }

    /// <summary>
    /// SshKnownHosts: Base64-encoded known_hosts value containing public SSH keys required to access private git repositories
    /// over SSH
    /// </summary>
    [JsonPropertyName("sshKnownHosts")]
    public string? SshKnownHosts { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster git repository source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster git repository source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration git repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Array of ConfigMaps/Secrets from which the variables are substituted for this Kustomization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusKustomizationsPostBuildSubstituteFrom
{
    /// <summary>Kind: Define whether it is ConfigMap or Secret that holds the variables to be used in substitution.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name: Name of the ConfigMap/Secret that holds the variables to be used in substitution.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional: Set to True to proceed without ConfigMap/Secret, if it is not present.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>PostBuild: Used for variable substitution for this Kustomization after kustomize build.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusKustomizationsPostBuild
{
    /// <summary>Substitute: Key/value pairs holding the variables to be substituted in this Kustomization.</summary>
    [JsonPropertyName("substitute")]
    public IDictionary<string, string>? Substitute { get; set; }

    /// <summary>SubstituteFrom: Array of ConfigMaps/Secrets from which the variables are substituted for this Kustomization.</summary>
    [JsonPropertyName("substituteFrom")]
    public IList<V1api20241101FluxConfigurationStatusKustomizationsPostBuildSubstituteFrom>? SubstituteFrom { get; set; }
}

/// <summary>The Kustomization defining how to reconcile the artifact pulled by the source type on the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusKustomizations
{
    /// <summary>
    /// DependsOn: Specifies other Kustomizations that this Kustomization depends on. This Kustomization will not reconcile
    /// until all dependencies have completed their reconciliation.
    /// </summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>
    /// Force: Enable/disable re-creating Kubernetes resources on the cluster when patching fails due to an immutable field
    /// change.
    /// </summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>Name: Name of the Kustomization, matching the key in the Kustomizations object map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path: The path in the source reference to reconcile on the cluster.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>PostBuild: Used for variable substitution for this Kustomization after kustomize build.</summary>
    [JsonPropertyName("postBuild")]
    public V1api20241101FluxConfigurationStatusKustomizationsPostBuild? PostBuild { get; set; }

    /// <summary>Prune: Enable/disable garbage collections of Kubernetes objects created by this Kustomization.</summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>
    /// RetryIntervalInSeconds: The interval at which to re-reconcile the Kustomization on the cluster in the event of failure
    /// on reconciliation.
    /// </summary>
    [JsonPropertyName("retryIntervalInSeconds")]
    public int? RetryIntervalInSeconds { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the Kustomization on the cluster.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the Kustomization on the cluster.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>Wait: Enable/disable health check for all Kubernetes objects created by this Kustomization.</summary>
    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }
}

/// <summary>LayerSelector: The layer to be pulled from the OCI artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusOciRepositoryLayerSelector
{
    /// <summary>MediaType: The first layer matching the specified media type will be used.</summary>
    [JsonPropertyName("mediaType")]
    public string? MediaType { get; set; }

    /// <summary>
    /// Operation: The operation to be performed on the selected layer. The default value is &apos;extract&apos;, but it can be set to
    /// &apos;copy&apos;.
    /// </summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }
}

/// <summary>RepositoryRef: The source reference for the OCIRepository object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusOciRepositoryRepositoryRef
{
    /// <summary>
    /// Digest: The image digest to pull from OCI repository, the value should be in the format ‘sha256:’. This takes
    /// precedence over semver.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Semver: The semver range used to match against OCI repository tags. This takes precedence over tag.</summary>
    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    /// <summary>Tag: The OCI repository image tag name to pull. This defaults to &apos;latest&apos;.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>TlsConfig: Parameters to authenticate using TLS config for OCI repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusOciRepositoryTlsConfig
{
}

/// <summary>MatchOIDCIdentity defines the criteria for matching the identity while verifying an OCI artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusOciRepositoryVerifyMatchOidcIdentity
{
    /// <summary>Issuer: The regex pattern to match against to verify the OIDC issuer.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Subject: The regex pattern to match against to verify the identity subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>Verify: Verification of the authenticity of an OCI Artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusOciRepositoryVerify
{
    /// <summary>MatchOidcIdentity: Array defining the criteria for matching the identity while verifying an OCI artifact.</summary>
    [JsonPropertyName("matchOidcIdentity")]
    public IList<V1api20241101FluxConfigurationStatusOciRepositoryVerifyMatchOidcIdentity>? MatchOidcIdentity { get; set; }

    /// <summary>Provider: Verification provider name.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>VerificationConfig: An object containing trusted public keys of trusted authors.</summary>
    [JsonPropertyName("verificationConfig")]
    public IDictionary<string, string>? VerificationConfig { get; set; }
}

/// <summary>OciRepository: Parameters to reconcile to the OCIRepository source kind type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusOciRepository
{
    /// <summary>Insecure: Specify whether to allow connecting to a non-TLS HTTP container registry.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>LayerSelector: The layer to be pulled from the OCI artifact.</summary>
    [JsonPropertyName("layerSelector")]
    public V1api20241101FluxConfigurationStatusOciRepositoryLayerSelector? LayerSelector { get; set; }

    /// <summary>
    /// LocalAuthRef: Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the
    /// managed or user-provided configuration secrets.
    /// </summary>
    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>RepositoryRef: The source reference for the OCIRepository object.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1api20241101FluxConfigurationStatusOciRepositoryRepositoryRef? RepositoryRef { get; set; }

    /// <summary>ServiceAccountName: The service account name to authenticate with the OCI repository.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>SyncIntervalInSeconds: The interval at which to re-reconcile the cluster OCI repository source with the remote.</summary>
    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    /// <summary>TimeoutInSeconds: The maximum time to attempt to reconcile the cluster OCI repository source with the remote.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>TlsConfig: Parameters to authenticate using TLS config for OCI repository.</summary>
    [JsonPropertyName("tlsConfig")]
    public V1api20241101FluxConfigurationStatusOciRepositoryTlsConfig? TlsConfig { get; set; }

    /// <summary>Url: The URL to sync for the flux configuration OCI repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>UseWorkloadIdentity: Specifies whether to use Workload Identity to authenticate with the OCI repository.</summary>
    [JsonPropertyName("useWorkloadIdentity")]
    public bool? UseWorkloadIdentity { get; set; }

    /// <summary>Verify: Verification of the authenticity of an OCI Artifact.</summary>
    [JsonPropertyName("verify")]
    public V1api20241101FluxConfigurationStatusOciRepositoryVerify? Verify { get; set; }
}

/// <summary>AppliedBy: Object reference to the Kustomization that applied this object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusStatusesAppliedBy
{
    /// <summary>Name: Name of the object</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: Namespace of the object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>HelmChartRef: The reference to the HelmChart object used as the source to this HelmRelease</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusStatusesHelmReleasePropertiesHelmChartRef
{
    /// <summary>Name: Name of the object</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: Namespace of the object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>HelmReleaseProperties: Additional properties that are provided from objects of the HelmRelease kind</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusStatusesHelmReleaseProperties
{
    /// <summary>FailureCount: Total number of times that the HelmRelease failed to install or upgrade</summary>
    [JsonPropertyName("failureCount")]
    public int? FailureCount { get; set; }

    /// <summary>HelmChartRef: The reference to the HelmChart object used as the source to this HelmRelease</summary>
    [JsonPropertyName("helmChartRef")]
    public V1api20241101FluxConfigurationStatusStatusesHelmReleasePropertiesHelmChartRef? HelmChartRef { get; set; }

    /// <summary>InstallFailureCount: Number of times that the HelmRelease failed to install</summary>
    [JsonPropertyName("installFailureCount")]
    public int? InstallFailureCount { get; set; }

    /// <summary>LastRevisionApplied: The revision number of the last released object change</summary>
    [JsonPropertyName("lastRevisionApplied")]
    public int? LastRevisionApplied { get; set; }

    /// <summary>UpgradeFailureCount: Number of times that the HelmRelease failed to upgrade</summary>
    [JsonPropertyName("upgradeFailureCount")]
    public int? UpgradeFailureCount { get; set; }
}

/// <summary>Status condition of Kubernetes object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusStatusesStatusConditions
{
    /// <summary>LastTransitionTime: Last time this status condition has changed</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Message: A more verbose description of the object status condition</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Reason: Reason for the specified status condition type status</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status: Status of the Kubernetes object condition type</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type: Object status condition type for this object</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Statuses of objects deployed by the user-specified kustomizations from the git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatusStatuses
{
    /// <summary>AppliedBy: Object reference to the Kustomization that applied this object</summary>
    [JsonPropertyName("appliedBy")]
    public V1api20241101FluxConfigurationStatusStatusesAppliedBy? AppliedBy { get; set; }

    /// <summary>
    /// ComplianceState: Compliance state of the applied object showing whether the applied object has come into a ready state
    /// on the cluster.
    /// </summary>
    [JsonPropertyName("complianceState")]
    public string? ComplianceState { get; set; }

    /// <summary>HelmReleaseProperties: Additional properties that are provided from objects of the HelmRelease kind</summary>
    [JsonPropertyName("helmReleaseProperties")]
    public V1api20241101FluxConfigurationStatusStatusesHelmReleaseProperties? HelmReleaseProperties { get; set; }

    /// <summary>Kind: Kind of the applied object</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name: Name of the applied object</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: Namespace of the applied object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>StatusConditions: List of Kubernetes object status conditions present on the cluster</summary>
    [JsonPropertyName("statusConditions")]
    public IList<V1api20241101FluxConfigurationStatusStatusesStatusConditions>? StatusConditions { get; set; }
}

/// <summary>The Flux Configuration object returned in Get &amp; Put response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101FluxConfigurationStatus
{
    /// <summary>AzureBlob: Parameters to reconcile to the AzureBlob source kind type.</summary>
    [JsonPropertyName("azureBlob")]
    public V1api20241101FluxConfigurationStatusAzureBlob? AzureBlob { get; set; }

    /// <summary>Bucket: Parameters to reconcile to the Bucket source kind type.</summary>
    [JsonPropertyName("bucket")]
    public V1api20241101FluxConfigurationStatusBucket? Bucket { get; set; }

    /// <summary>
    /// ComplianceState: Combined status of the Flux Kubernetes resources created by the fluxConfiguration or created by the
    /// managed objects.
    /// </summary>
    [JsonPropertyName("complianceState")]
    public string? ComplianceState { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20241101FluxConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ConfigurationProtectedSettings: Key-value pairs of protected configuration settings for the configuration</summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public IDictionary<string, string>? ConfigurationProtectedSettings { get; set; }

    /// <summary>ErrorMessage: Error message returned to the user in the case of provisioning failure.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>GitRepository: Parameters to reconcile to the GitRepository source kind type.</summary>
    [JsonPropertyName("gitRepository")]
    public V1api20241101FluxConfigurationStatusGitRepository? GitRepository { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Kustomizations: Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster.</summary>
    [JsonPropertyName("kustomizations")]
    public IDictionary<string, V1api20241101FluxConfigurationStatusKustomizations>? Kustomizations { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace: The namespace to which this configuration is installed to. Maximum of 253 lower case alphanumeric characters,
    /// hyphen and period only.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>OciRepository: Parameters to reconcile to the OCIRepository source kind type.</summary>
    [JsonPropertyName("ociRepository")]
    public V1api20241101FluxConfigurationStatusOciRepository? OciRepository { get; set; }

    /// <summary>ReconciliationWaitDuration: Maximum duration to wait for flux configuration reconciliation. E.g PT1H, PT5M, P1D</summary>
    [JsonPropertyName("reconciliationWaitDuration")]
    public string? ReconciliationWaitDuration { get; set; }

    /// <summary>
    /// RepositoryPublicKey: Public Key associated with this fluxConfiguration (either generated within the cluster or provided
    /// by the user).
    /// </summary>
    [JsonPropertyName("repositoryPublicKey")]
    public string? RepositoryPublicKey { get; set; }

    /// <summary>Scope: Scope at which the operator will be installed.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>SourceKind: Source Kind to pull the configuration data from.</summary>
    [JsonPropertyName("sourceKind")]
    public string? SourceKind { get; set; }

    /// <summary>SourceSyncedCommitId: Branch and/or SHA of the source commit synced with the cluster.</summary>
    [JsonPropertyName("sourceSyncedCommitId")]
    public string? SourceSyncedCommitId { get; set; }

    /// <summary>SourceUpdatedAt: Datetime the fluxConfiguration synced its source on the cluster.</summary>
    [JsonPropertyName("sourceUpdatedAt")]
    public string? SourceUpdatedAt { get; set; }

    /// <summary>StatusUpdatedAt: Datetime the fluxConfiguration synced its status on the cluster with Azure.</summary>
    [JsonPropertyName("statusUpdatedAt")]
    public string? StatusUpdatedAt { get; set; }

    /// <summary>
    /// Statuses: Statuses of the Flux Kubernetes resources created by the fluxConfiguration or created by the managed objects
    /// provisioned by the fluxConfiguration.
    /// </summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20241101FluxConfigurationStatusStatuses>? Statuses { get; set; }

    /// <summary>Suspend: Whether this configuration should suspend its reconciliation of its kustomizations and sources.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WaitForReconciliation: Whether flux configuration deployment should wait for cluster to reconcile the kustomizations.</summary>
    [JsonPropertyName("waitForReconciliation")]
    public bool? WaitForReconciliation { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/fluxConfigurations/stable/2024-11-01/fluxconfiguration.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241101FluxConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20241101FluxConfigurationSpec?>, IStatus<V1api20241101FluxConfigurationStatus?>
{
    public const string KubeApiVersion = "v1api20241101";
    public const string KubeKind = "FluxConfiguration";
    public const string KubeGroup = "kubernetesconfiguration.azure.com";
    public const string KubePluralName = "fluxconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetesconfiguration.azure.com/v1api20241101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FluxConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20241101FluxConfigurationSpec? Spec { get; set; }

    /// <summary>The Flux Configuration object returned in Get &amp; Put response.</summary>
    [JsonPropertyName("status")]
    public V1api20241101FluxConfigurationStatus? Status { get; set; }
}
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
/// Storage version of v1api20230501.FluxConfiguration
/// Generator information:
/// - Generated from: /kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2023-05-01/fluxconfiguration.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501storageFluxConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501storageFluxConfiguration>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "FluxConfigurationList";
    public const string KubeGroup = "kubernetesconfiguration.azure.com";
    public const string KubePluralName = "fluxconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetesconfiguration.azure.com/v1api20230501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FluxConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230501storageFluxConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230501storageFluxConfiguration> Items { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobAccountKey
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

/// <summary>
/// Storage version of v1api20230501.ManagedIdentityDefinition
/// Parameters to authenticate using a Managed Identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobManagedIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobSasToken
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

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientCertificate
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

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientCertificatePassword
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

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientIdFromConfig
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

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientSecret
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

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalTenantIdFromConfig
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

/// <summary>
/// Storage version of v1api20230501.ServicePrincipalDefinition
/// Parameters to authenticate using Service Principal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipal
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientCertificate")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientCertificate? ClientCertificate { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientCertificatePassword")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientCertificatePassword? ClientCertificatePassword { get; set; }

    [JsonPropertyName("clientCertificateSendChain")]
    public bool? ClientCertificateSendChain { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalClientSecret? ClientSecret { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipalTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.AzureBlobDefinition
/// Parameters to reconcile to the AzureBlob source kind type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecAzureBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("accountKey")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobAccountKey? AccountKey { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.ManagedIdentityDefinition
    /// Parameters to authenticate using a Managed Identity.
    /// </summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("sasToken")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobSasToken? SasToken { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.ServicePrincipalDefinition
    /// Parameters to authenticate using Service Principal.
    /// </summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20230501storageFluxConfigurationSpecAzureBlobServicePrincipal? ServicePrincipal { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecBucketAccessKey
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

/// <summary>
/// Storage version of v1api20230501.BucketDefinition
/// Parameters to reconcile to the Bucket source kind type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecBucket
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("accessKey")]
    public V1api20230501storageFluxConfigurationSpecBucketAccessKey? AccessKey { get; set; }

    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// SecretMapReference is a reference to a Kubernetes secret in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecConfigurationProtectedSettings
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecGitRepositoryHttpsCACert
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

/// <summary>
/// Storage version of v1api20230501.RepositoryRefDefinition
/// The source reference for the GitRepository object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecGitRepositoryRepositoryRef
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.GitRepositoryDefinition
/// Parameters to reconcile to the GitRepository source kind type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecGitRepository
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("httpsCACert")]
    public V1api20230501storageFluxConfigurationSpecGitRepositoryHttpsCACert? HttpsCACert { get; set; }

    [JsonPropertyName("httpsUser")]
    public string? HttpsUser { get; set; }

    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.RepositoryRefDefinition
    /// The source reference for the GitRepository object.
    /// </summary>
    [JsonPropertyName("repositoryRef")]
    public V1api20230501storageFluxConfigurationSpecGitRepositoryRepositoryRef? RepositoryRef { get; set; }

    [JsonPropertyName("sshKnownHosts")]
    public string? SshKnownHosts { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.SubstituteFromDefinition
/// Array of ConfigMaps/Secrets from which the variables are substituted for this Kustomization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecKustomizationsPostBuildSubstituteFrom
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.PostBuildDefinition
/// The postBuild definitions defining variable substitutions for this Kustomization after kustomize build.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecKustomizationsPostBuild
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("substitute")]
    public IDictionary<string, string>? Substitute { get; set; }

    [JsonPropertyName("substituteFrom")]
    public IList<V1api20230501storageFluxConfigurationSpecKustomizationsPostBuildSubstituteFrom>? SubstituteFrom { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.KustomizationDefinition
/// The Kustomization defining how to reconcile the artifact pulled by the source type on the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecKustomizations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.PostBuildDefinition
    /// The postBuild definitions defining variable substitutions for this Kustomization after kustomize build.
    /// </summary>
    [JsonPropertyName("postBuild")]
    public V1api20230501storageFluxConfigurationSpecKustomizationsPostBuild? PostBuild { get; set; }

    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    [JsonPropertyName("retryIntervalInSeconds")]
    public int? RetryIntervalInSeconds { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230501storageFluxConfigurationSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20230501.FluxConfigurationOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501storageFluxConfigurationSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501storageFluxConfigurationSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpecOwner
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

/// <summary>Storage version of v1api20230501.FluxConfiguration_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.AzureBlobDefinition
    /// Parameters to reconcile to the AzureBlob source kind type.
    /// </summary>
    [JsonPropertyName("azureBlob")]
    public V1api20230501storageFluxConfigurationSpecAzureBlob? AzureBlob { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.BucketDefinition
    /// Parameters to reconcile to the Bucket source kind type.
    /// </summary>
    [JsonPropertyName("bucket")]
    public V1api20230501storageFluxConfigurationSpecBucket? Bucket { get; set; }

    /// <summary>
    /// SecretMapReference is a reference to a Kubernetes secret in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public V1api20230501storageFluxConfigurationSpecConfigurationProtectedSettings? ConfigurationProtectedSettings { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.GitRepositoryDefinition
    /// Parameters to reconcile to the GitRepository source kind type.
    /// </summary>
    [JsonPropertyName("gitRepository")]
    public V1api20230501storageFluxConfigurationSpecGitRepository? GitRepository { get; set; }

    [JsonPropertyName("kustomizations")]
    public IDictionary<string, V1api20230501storageFluxConfigurationSpecKustomizations>? Kustomizations { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.FluxConfigurationOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501storageFluxConfigurationSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230501storageFluxConfigurationSpecOwner Owner { get; set; }

    [JsonPropertyName("reconciliationWaitDuration")]
    public string? ReconciliationWaitDuration { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [JsonPropertyName("sourceKind")]
    public string? SourceKind { get; set; }

    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    [JsonPropertyName("waitForReconciliation")]
    public bool? WaitForReconciliation { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.ManagedIdentityDefinition_STATUS
/// Parameters to authenticate using a Managed Identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusAzureBlobManagedIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.ServicePrincipalDefinition_STATUS
/// Parameters to authenticate using Service Principal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusAzureBlobServicePrincipal
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientCertificateSendChain")]
    public bool? ClientCertificateSendChain { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.AzureBlobDefinition_STATUS
/// Parameters to reconcile to the AzureBlob source kind type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusAzureBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.ManagedIdentityDefinition_STATUS
    /// Parameters to authenticate using a Managed Identity.
    /// </summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20230501storageFluxConfigurationStatusAzureBlobManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.ServicePrincipalDefinition_STATUS
    /// Parameters to authenticate using Service Principal.
    /// </summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20230501storageFluxConfigurationStatusAzureBlobServicePrincipal? ServicePrincipal { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.BucketDefinition_STATUS
/// Parameters to reconcile to the Bucket source kind type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusBucket
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusConditions
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

/// <summary>
/// Storage version of v1api20230501.RepositoryRefDefinition_STATUS
/// The source reference for the GitRepository object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusGitRepositoryRepositoryRef
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.GitRepositoryDefinition_STATUS
/// Parameters to reconcile to the GitRepository source kind type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusGitRepository
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("httpsUser")]
    public string? HttpsUser { get; set; }

    [JsonPropertyName("localAuthRef")]
    public string? LocalAuthRef { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.RepositoryRefDefinition_STATUS
    /// The source reference for the GitRepository object.
    /// </summary>
    [JsonPropertyName("repositoryRef")]
    public V1api20230501storageFluxConfigurationStatusGitRepositoryRepositoryRef? RepositoryRef { get; set; }

    [JsonPropertyName("sshKnownHosts")]
    public string? SshKnownHosts { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.SubstituteFromDefinition_STATUS
/// Array of ConfigMaps/Secrets from which the variables are substituted for this Kustomization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusKustomizationsPostBuildSubstituteFrom
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.PostBuildDefinition_STATUS
/// The postBuild definitions defining variable substitutions for this Kustomization after kustomize build.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusKustomizationsPostBuild
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("substitute")]
    public IDictionary<string, string>? Substitute { get; set; }

    [JsonPropertyName("substituteFrom")]
    public IList<V1api20230501storageFluxConfigurationStatusKustomizationsPostBuildSubstituteFrom>? SubstituteFrom { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.KustomizationDefinition_STATUS
/// The Kustomization defining how to reconcile the artifact pulled by the source type on the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusKustomizations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.PostBuildDefinition_STATUS
    /// The postBuild definitions defining variable substitutions for this Kustomization after kustomize build.
    /// </summary>
    [JsonPropertyName("postBuild")]
    public V1api20230501storageFluxConfigurationStatusKustomizationsPostBuild? PostBuild { get; set; }

    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    [JsonPropertyName("retryIntervalInSeconds")]
    public int? RetryIntervalInSeconds { get; set; }

    [JsonPropertyName("syncIntervalInSeconds")]
    public int? SyncIntervalInSeconds { get; set; }

    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.ObjectReferenceDefinition_STATUS
/// Object reference to a Kubernetes object on a cluster
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusStatusesAppliedBy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.ObjectReferenceDefinition_STATUS
/// Object reference to a Kubernetes object on a cluster
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusStatusesHelmReleasePropertiesHelmChartRef
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.HelmReleasePropertiesDefinition_STATUS
/// Properties for HelmRelease objects
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusStatusesHelmReleaseProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("failureCount")]
    public int? FailureCount { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.ObjectReferenceDefinition_STATUS
    /// Object reference to a Kubernetes object on a cluster
    /// </summary>
    [JsonPropertyName("helmChartRef")]
    public V1api20230501storageFluxConfigurationStatusStatusesHelmReleasePropertiesHelmChartRef? HelmChartRef { get; set; }

    [JsonPropertyName("installFailureCount")]
    public int? InstallFailureCount { get; set; }

    [JsonPropertyName("lastRevisionApplied")]
    public int? LastRevisionApplied { get; set; }

    [JsonPropertyName("upgradeFailureCount")]
    public int? UpgradeFailureCount { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.ObjectStatusConditionDefinition_STATUS
/// Status condition of Kubernetes object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusStatusesStatusConditions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.ObjectStatusDefinition_STATUS
/// Statuses of objects deployed by the user-specified kustomizations from the git repository.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatusStatuses
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.ObjectReferenceDefinition_STATUS
    /// Object reference to a Kubernetes object on a cluster
    /// </summary>
    [JsonPropertyName("appliedBy")]
    public V1api20230501storageFluxConfigurationStatusStatusesAppliedBy? AppliedBy { get; set; }

    [JsonPropertyName("complianceState")]
    public string? ComplianceState { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.HelmReleasePropertiesDefinition_STATUS
    /// Properties for HelmRelease objects
    /// </summary>
    [JsonPropertyName("helmReleaseProperties")]
    public V1api20230501storageFluxConfigurationStatusStatusesHelmReleaseProperties? HelmReleaseProperties { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("statusConditions")]
    public IList<V1api20230501storageFluxConfigurationStatusStatusesStatusConditions>? StatusConditions { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.FluxConfiguration_STATUS
/// The Flux Configuration object returned in Get &amp; Put response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageFluxConfigurationStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.AzureBlobDefinition_STATUS
    /// Parameters to reconcile to the AzureBlob source kind type.
    /// </summary>
    [JsonPropertyName("azureBlob")]
    public V1api20230501storageFluxConfigurationStatusAzureBlob? AzureBlob { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.BucketDefinition_STATUS
    /// Parameters to reconcile to the Bucket source kind type.
    /// </summary>
    [JsonPropertyName("bucket")]
    public V1api20230501storageFluxConfigurationStatusBucket? Bucket { get; set; }

    [JsonPropertyName("complianceState")]
    public string? ComplianceState { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20230501storageFluxConfigurationStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("configurationProtectedSettings")]
    public IDictionary<string, string>? ConfigurationProtectedSettings { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.GitRepositoryDefinition_STATUS
    /// Parameters to reconcile to the GitRepository source kind type.
    /// </summary>
    [JsonPropertyName("gitRepository")]
    public V1api20230501storageFluxConfigurationStatusGitRepository? GitRepository { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("kustomizations")]
    public IDictionary<string, V1api20230501storageFluxConfigurationStatusKustomizations>? Kustomizations { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("reconciliationWaitDuration")]
    public string? ReconciliationWaitDuration { get; set; }

    [JsonPropertyName("repositoryPublicKey")]
    public string? RepositoryPublicKey { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [JsonPropertyName("sourceKind")]
    public string? SourceKind { get; set; }

    [JsonPropertyName("sourceSyncedCommitId")]
    public string? SourceSyncedCommitId { get; set; }

    [JsonPropertyName("sourceUpdatedAt")]
    public string? SourceUpdatedAt { get; set; }

    [JsonPropertyName("statusUpdatedAt")]
    public string? StatusUpdatedAt { get; set; }

    [JsonPropertyName("statuses")]
    public IList<V1api20230501storageFluxConfigurationStatusStatuses>? Statuses { get; set; }

    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("waitForReconciliation")]
    public bool? WaitForReconciliation { get; set; }
}

/// <summary>
/// Storage version of v1api20230501.FluxConfiguration
/// Generator information:
/// - Generated from: /kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2023-05-01/fluxconfiguration.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501storageFluxConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501storageFluxConfigurationSpec?>, IStatus<V1api20230501storageFluxConfigurationStatus?>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "FluxConfiguration";
    public const string KubeGroup = "kubernetesconfiguration.azure.com";
    public const string KubePluralName = "fluxconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetesconfiguration.azure.com/v1api20230501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FluxConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230501.FluxConfiguration_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230501storageFluxConfigurationSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20230501.FluxConfiguration_STATUS
    /// The Flux Configuration object returned in Get &amp; Put response.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20230501storageFluxConfigurationStatus? Status { get; set; }
}
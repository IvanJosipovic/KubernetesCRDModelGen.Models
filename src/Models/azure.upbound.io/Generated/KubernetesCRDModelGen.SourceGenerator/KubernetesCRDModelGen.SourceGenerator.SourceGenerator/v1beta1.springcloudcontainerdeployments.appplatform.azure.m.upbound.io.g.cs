#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.m.upbound.io;
/// <summary>SpringCloudContainerDeployment is the Schema for the SpringCloudContainerDeployments API. Manages a Spring Cloud Container Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudContainerDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudContainerDeployment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudContainerDeploymentList";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudcontainerdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudContainerDeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SpringCloudContainerDeployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SpringCloudContainerDeployment> Items { get; set; }
}

/// <summary>A quota block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpecForProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 1Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum>))]
public enum V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolveEnum>))]
public enum V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum>))]
public enum V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelector
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
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpecForProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Container Deployment.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies the arguments to the entrypoint. The docker image&apos;s CMD is used if not specified.</summary>
    [JsonPropertyName("arguments")]
    public IList<string>? Arguments { get; set; }

    /// <summary>Specifies the entrypoint array. It will not be executed within a shell. The docker image&apos;s ENTRYPOINT is used if not specified.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Deployment as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Container image of the custom container. This should be in the form of &lt;repository&gt;:&lt;tag&gt; without the server name of the registry.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Deployment. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Specifies the language framework of the container image. The only possible value is springboot.</summary>
    [JsonPropertyName("languageFramework")]
    public string? LanguageFramework { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderQuota? Quota { get; set; }

    /// <summary>The name of the registry that contains the container image.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Container Deployment to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }

    /// <summary>Reference to a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdRef")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdRef? SpringCloudAppIdRef { get; set; }

    /// <summary>Selector for a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdSelector")]
    public V1beta1SpringCloudContainerDeploymentSpecForProviderSpringCloudAppIdSelector? SpringCloudAppIdSelector { get; set; }
}

/// <summary>A quota block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpecInitProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 1Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
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
public partial class V1beta1SpringCloudContainerDeploymentSpecInitProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Container Deployment.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies the arguments to the entrypoint. The docker image&apos;s CMD is used if not specified.</summary>
    [JsonPropertyName("arguments")]
    public IList<string>? Arguments { get; set; }

    /// <summary>Specifies the entrypoint array. It will not be executed within a shell. The docker image&apos;s ENTRYPOINT is used if not specified.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Deployment as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Container image of the custom container. This should be in the form of &lt;repository&gt;:&lt;tag&gt; without the server name of the registry.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Deployment. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Specifies the language framework of the container image. The only possible value is springboot.</summary>
    [JsonPropertyName("languageFramework")]
    public string? LanguageFramework { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public V1beta1SpringCloudContainerDeploymentSpecInitProviderQuota? Quota { get; set; }

    /// <summary>The name of the registry that contains the container image.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudContainerDeploymentSpecManagementPoliciesEnum>))]
public enum V1beta1SpringCloudContainerDeploymentSpecManagementPoliciesEnum
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
public partial class V1beta1SpringCloudContainerDeploymentSpecProviderConfigRef
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
public partial class V1beta1SpringCloudContainerDeploymentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SpringCloudContainerDeploymentSpec defines the desired state of SpringCloudContainerDeployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1SpringCloudContainerDeploymentSpecForProvider ForProvider { get; set; }

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
    public V1beta1SpringCloudContainerDeploymentSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpringCloudContainerDeploymentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudContainerDeploymentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudContainerDeploymentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A quota block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentStatusAtProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 1Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentStatusAtProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Container Deployment.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies the arguments to the entrypoint. The docker image&apos;s CMD is used if not specified.</summary>
    [JsonPropertyName("arguments")]
    public IList<string>? Arguments { get; set; }

    /// <summary>Specifies the entrypoint array. It will not be executed within a shell. The docker image&apos;s ENTRYPOINT is used if not specified.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Deployment as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>The ID of the Spring Cloud Container Deployment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Container image of the custom container. This should be in the form of &lt;repository&gt;:&lt;tag&gt; without the server name of the registry.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Deployment. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Specifies the language framework of the container image. The only possible value is springboot.</summary>
    [JsonPropertyName("languageFramework")]
    public string? LanguageFramework { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public V1beta1SpringCloudContainerDeploymentStatusAtProviderQuota? Quota { get; set; }

    /// <summary>The name of the registry that contains the container image.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Container Deployment to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentStatusConditions
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

/// <summary>SpringCloudContainerDeploymentStatus defines the observed state of SpringCloudContainerDeployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudContainerDeploymentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudContainerDeploymentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudContainerDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudContainerDeployment is the Schema for the SpringCloudContainerDeployments API. Manages a Spring Cloud Container Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudContainerDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudContainerDeploymentSpec>, IStatus<V1beta1SpringCloudContainerDeploymentStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudContainerDeployment";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudcontainerdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudContainerDeployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudContainerDeploymentSpec defines the desired state of SpringCloudContainerDeployment</summary>
    [JsonPropertyName("spec")]
    public required V1beta1SpringCloudContainerDeploymentSpec Spec { get; set; }

    /// <summary>SpringCloudContainerDeploymentStatus defines the observed state of SpringCloudContainerDeployment.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudContainerDeploymentStatus? Status { get; set; }
}
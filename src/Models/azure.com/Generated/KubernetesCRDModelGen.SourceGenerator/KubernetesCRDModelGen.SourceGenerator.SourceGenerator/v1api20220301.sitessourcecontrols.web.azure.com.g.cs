#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/WebApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301SitesSourcecontrolList : IKubernetesObject<V1ListMeta>, IItems<V1api20220301SitesSourcecontrol>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "SitesSourcecontrolList";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sitessourcecontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SitesSourcecontrolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220301SitesSourcecontrol objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220301SitesSourcecontrol> Items { get; set; }
}

/// <summary>CodeConfiguration: GitHub Action code configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolSpecGitHubActionConfigurationCodeConfiguration
{
    /// <summary>RuntimeStack: Runtime stack is used to determine the workflow file content for code base apps.</summary>
    [JsonPropertyName("runtimeStack")]
    public string? RuntimeStack { get; set; }

    /// <summary>RuntimeVersion: Runtime version is used to determine what build version to set in the workflow file.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Password: The password used to upload the image to the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolSpecGitHubActionConfigurationContainerConfigurationPassword
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

/// <summary>ContainerConfiguration: GitHub Action container configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolSpecGitHubActionConfigurationContainerConfiguration
{
    /// <summary>ImageName: The image name for the build.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Password: The password used to upload the image to the container registry.</summary>
    [JsonPropertyName("password")]
    public V1api20220301SitesSourcecontrolSpecGitHubActionConfigurationContainerConfigurationPassword? Password { get; set; }

    /// <summary>ServerUrl: The server URL for the container registry where the build will be hosted.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Username: The username used to upload the image to the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>GitHubActionConfiguration: If GitHub Action is selected, than the associated configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolSpecGitHubActionConfiguration
{
    /// <summary>CodeConfiguration: GitHub Action code configuration.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1api20220301SitesSourcecontrolSpecGitHubActionConfigurationCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>ContainerConfiguration: GitHub Action container configuration.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1api20220301SitesSourcecontrolSpecGitHubActionConfigurationContainerConfiguration? ContainerConfiguration { get; set; }

    /// <summary>
    /// GenerateWorkflowFile: Workflow option to determine whether the workflow file should be generated and written to the
    /// repository.
    /// </summary>
    [JsonPropertyName("generateWorkflowFile")]
    public bool? GenerateWorkflowFile { get; set; }

    /// <summary>IsLinux: This will help determine the workflow configuration to select.</summary>
    [JsonPropertyName("isLinux")]
    public bool? IsLinux { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220301SitesSourcecontrolSpecOperatorSpecSecretExpressions
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
public partial class V1api20220301SitesSourcecontrolSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220301SitesSourcecontrolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220301SitesSourcecontrolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a web.azure.com/Site resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolSpec
{
    /// <summary>Branch: Name of branch to use for deployment.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>DeploymentRollbackEnabled: &lt;code&gt;true&lt;/code&gt; to enable deployment rollback; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("deploymentRollbackEnabled")]
    public bool? DeploymentRollbackEnabled { get; set; }

    /// <summary>GitHubActionConfiguration: If GitHub Action is selected, than the associated configuration.</summary>
    [JsonPropertyName("gitHubActionConfiguration")]
    public V1api20220301SitesSourcecontrolSpecGitHubActionConfiguration? GitHubActionConfiguration { get; set; }

    /// <summary>IsGitHubAction: &lt;code&gt;true&lt;/code&gt; if this is deployed via GitHub action.</summary>
    [JsonPropertyName("isGitHubAction")]
    public bool? IsGitHubAction { get; set; }

    /// <summary>
    /// IsManualIntegration: &lt;code&gt;true&lt;/code&gt; to limit to manual integration; &lt;code&gt;false&lt;/code&gt; to enable continuous
    /// integration (which configures webhooks into online repos like GitHub).
    /// </summary>
    [JsonPropertyName("isManualIntegration")]
    public bool? IsManualIntegration { get; set; }

    /// <summary>IsMercurial: &lt;code&gt;true&lt;/code&gt; for a Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git repository.</summary>
    [JsonPropertyName("isMercurial")]
    public bool? IsMercurial { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220301SitesSourcecontrolSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a web.azure.com/Site resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220301SitesSourcecontrolSpecOwner Owner { get; set; }

    /// <summary>RepoUrl: Repository or source control URL.</summary>
    [JsonPropertyName("repoUrl")]
    public string? RepoUrl { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolStatusConditions
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

/// <summary>CodeConfiguration: GitHub Action code configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolStatusGitHubActionConfigurationCodeConfiguration
{
    /// <summary>RuntimeStack: Runtime stack is used to determine the workflow file content for code base apps.</summary>
    [JsonPropertyName("runtimeStack")]
    public string? RuntimeStack { get; set; }

    /// <summary>RuntimeVersion: Runtime version is used to determine what build version to set in the workflow file.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>ContainerConfiguration: GitHub Action container configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolStatusGitHubActionConfigurationContainerConfiguration
{
    /// <summary>ImageName: The image name for the build.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>ServerUrl: The server URL for the container registry where the build will be hosted.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Username: The username used to upload the image to the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>GitHubActionConfiguration: If GitHub Action is selected, than the associated configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolStatusGitHubActionConfiguration
{
    /// <summary>CodeConfiguration: GitHub Action code configuration.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1api20220301SitesSourcecontrolStatusGitHubActionConfigurationCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>ContainerConfiguration: GitHub Action container configuration.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1api20220301SitesSourcecontrolStatusGitHubActionConfigurationContainerConfiguration? ContainerConfiguration { get; set; }

    /// <summary>
    /// GenerateWorkflowFile: Workflow option to determine whether the workflow file should be generated and written to the
    /// repository.
    /// </summary>
    [JsonPropertyName("generateWorkflowFile")]
    public bool? GenerateWorkflowFile { get; set; }

    /// <summary>IsLinux: This will help determine the workflow configuration to select.</summary>
    [JsonPropertyName("isLinux")]
    public bool? IsLinux { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301SitesSourcecontrolStatus
{
    /// <summary>Branch: Name of branch to use for deployment.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220301SitesSourcecontrolStatusConditions>? Conditions { get; set; }

    /// <summary>DeploymentRollbackEnabled: &lt;code&gt;true&lt;/code&gt; to enable deployment rollback; otherwise, &lt;code&gt;false&lt;/code&gt;.</summary>
    [JsonPropertyName("deploymentRollbackEnabled")]
    public bool? DeploymentRollbackEnabled { get; set; }

    /// <summary>GitHubActionConfiguration: If GitHub Action is selected, than the associated configuration.</summary>
    [JsonPropertyName("gitHubActionConfiguration")]
    public V1api20220301SitesSourcecontrolStatusGitHubActionConfiguration? GitHubActionConfiguration { get; set; }

    /// <summary>Id: Resource Id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsGitHubAction: &lt;code&gt;true&lt;/code&gt; if this is deployed via GitHub action.</summary>
    [JsonPropertyName("isGitHubAction")]
    public bool? IsGitHubAction { get; set; }

    /// <summary>
    /// IsManualIntegration: &lt;code&gt;true&lt;/code&gt; to limit to manual integration; &lt;code&gt;false&lt;/code&gt; to enable continuous
    /// integration (which configures webhooks into online repos like GitHub).
    /// </summary>
    [JsonPropertyName("isManualIntegration")]
    public bool? IsManualIntegration { get; set; }

    /// <summary>IsMercurial: &lt;code&gt;true&lt;/code&gt; for a Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git repository.</summary>
    [JsonPropertyName("isMercurial")]
    public bool? IsMercurial { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name: Resource Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RepoUrl: Repository or source control URL.</summary>
    [JsonPropertyName("repoUrl")]
    public string? RepoUrl { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/WebApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301SitesSourcecontrol : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220301SitesSourcecontrolSpec?>, IStatus<V1api20220301SitesSourcecontrolStatus?>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "SitesSourcecontrol";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "sitessourcecontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SitesSourcecontrol";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220301SitesSourcecontrolSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20220301SitesSourcecontrolStatus? Status { get; set; }
}
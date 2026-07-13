#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kargo.akuity.io;
/// <summary>
/// ProjectConfig is a resource type that describes the configuration of a
/// Project.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ProjectConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ProjectConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ProjectConfigList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "projectconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ProjectConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ProjectConfig> Items { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecPromotionPoliciesStageSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// StageSelector is a selector that matches the Stage resource to which
/// this policy applies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecPromotionPoliciesStageSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ProjectConfigSpecPromotionPoliciesStageSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>
    /// Name is the name of the resource to which this policy applies.
    /// 
    /// It can be an exact name, a regex pattern (with prefix &quot;regex:&quot;), or a
    /// glob pattern (with prefix &quot;glob:&quot;).
    /// 
    /// When both Name and LabelSelector are specified, the Name is ANDed with
    /// the LabelSelector. I.e., the resource must match both the Name and
    /// LabelSelector to be selected by this policy.
    /// 
    /// NOTE: Using a specific exact name is the most secure option. Pattern
    /// matching via regex or glob can be exploited by users with permissions to
    /// match promotion policies that weren&apos;t intended to apply to their
    /// resources. For example, a user could create a resource with a name
    /// deliberately crafted to match the pattern, potentially bypassing intended
    /// promotion controls.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PromotionPolicy defines policies governing the promotion of Freight to a
/// specific Stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecPromotionPolicies
{
    /// <summary>
    /// AutoPromotionEnabled indicates whether new Freight can automatically be
    /// promoted into the Stage referenced by the Stage field. Note: There are may
    /// be other conditions also required for an auto-promotion to occur. This
    /// field defaults to false, but is commonly set to true for Stages that
    /// subscribe to Warehouses instead of other, upstream Stages. This allows
    /// users to define Stages that are automatically updated as soon as new
    /// artifacts are detected.
    /// </summary>
    [JsonPropertyName("autoPromotionEnabled")]
    public bool? AutoPromotionEnabled { get; set; }

    /// <summary>
    /// Stage is the name of the Stage to which this policy applies.
    /// 
    /// Deprecated: Use StageSelector instead.
    /// </summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>
    /// StageSelector is a selector that matches the Stage resource to which
    /// this policy applies.
    /// </summary>
    [JsonPropertyName("stageSelector")]
    public V1alpha1ProjectConfigSpecPromotionPoliciesStageSelector? StageSelector { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The Secret&apos;s data map is expected to contain a `secret-token` key whose
/// value is the shared secret used to authenticate the webhook requests sent
/// by JFrog Artifactory. For more information please refer to the JFrog
/// Artifactory documentation:
///   https://jfrog.com/help/r/jfrog-platform-administration-documentation/webhooks
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversArtifactorySecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Artifactory contains the configuration for a webhook receiver that is
/// compatible with JFrog Artifactory payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversArtifactory
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret-token` key whose
    /// value is the shared secret used to authenticate the webhook requests sent
    /// by JFrog Artifactory. For more information please refer to the JFrog
    /// Artifactory documentation:
    ///   https://jfrog.com/help/r/jfrog-platform-administration-documentation/webhooks
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversArtifactorySecretRef SecretRef { get; set; }

    /// <summary>
    /// VirtualRepoName is the name of an Artifactory virtual repository.
    /// 
    /// When unspecified, the Artifactory webhook receiver depends on the value of
    /// the webhook payload&apos;s `data.repo_key` field when inferring the URL of the
    /// repository from which the webhook originated, which will always be an
    /// Artifactory &quot;local repository.&quot; In cases where a Warehouse subscribes to
    /// such a repository indirectly via a &quot;virtual repository,&quot; there will be a
    /// discrepancy between the inferred (local) repository URL and the URL
    /// actually used by the subscription, which can prevent the receiver from
    /// identifying such a Warehouse as one in need of refreshing. When specified,
    /// the value of the VirtualRepoName field supersedes the value of the webhook
    /// payload&apos;s `data.repo_key` field to compensate for that discrepancy.
    /// 
    /// In practice, when using virtual repositories, a separate Artifactory
    /// webhook receiver should be configured for each, but one such receiver can
    /// handle inbound webhooks from any number of local repositories that are
    /// aggregated by that virtual repository. For example, if a virtual repository
    /// `proj-virtual` aggregates container images from all of the `proj`
    /// Artifactory project&apos;s local image repositories, with a single webhook
    /// configured to post to a single receiver configured for the `proj-virtual`
    /// virtual repository, an image pushed to
    /// `example.frog.io/proj-&lt;local-repo-name&gt;/&lt;path&gt;/image`, will cause that
    /// receiver to refresh all Warehouses subscribed to
    /// `example.frog.io/proj-virtual/&lt;path&gt;/image`.
    /// </summary>
    [JsonPropertyName("virtualRepoName")]
    public string? VirtualRepoName { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The Secret&apos;s data map is expected to contain a `secret` key whose value
/// does NOT need to be shared directly with Azure when registering a webhook.
/// It is used only by Kargo to create a complex, hard-to-guess URL,
/// which implicitly serves as a shared secret. For more information about
/// Azure webhooks, please refer to the Azure documentation:
/// 
///  Azure Container Registry:
/// 	https://learn.microsoft.com/en-us/azure/container-registry/container-registry-repositories
/// 
///  Azure DevOps:
/// 	http://learn.microsoft.com/en-us/azure/devops/service-hooks/services/webhooks?view=azure-devops
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversAzureSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Azure contains the configuration for a webhook receiver that is compatible
/// with Azure Container Registry (ACR) and Azure DevOps payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversAzure
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret` key whose value
    /// does NOT need to be shared directly with Azure when registering a webhook.
    /// It is used only by Kargo to create a complex, hard-to-guess URL,
    /// which implicitly serves as a shared secret. For more information about
    /// Azure webhooks, please refer to the Azure documentation:
    /// 
    ///  Azure Container Registry:
    /// 	https://learn.microsoft.com/en-us/azure/container-registry/container-registry-repositories
    /// 
    ///  Azure DevOps:
    /// 	http://learn.microsoft.com/en-us/azure/devops/service-hooks/services/webhooks?view=azure-devops
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversAzureSecretRef SecretRef { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The Secret&apos;s data map is expected to contain a `secret` key whose
/// value is the shared secret used to authenticate the webhook requests sent
/// by Bitbucket. For more information please refer to the Bitbucket
/// documentation:
///   https://support.atlassian.com/bitbucket-cloud/docs/manage-webhooks/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversBitbucketSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Bitbucket contains the configuration for a webhook receiver that is
/// compatible with Bitbucket payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversBitbucket
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret` key whose
    /// value is the shared secret used to authenticate the webhook requests sent
    /// by Bitbucket. For more information please refer to the Bitbucket
    /// documentation:
    ///   https://support.atlassian.com/bitbucket-cloud/docs/manage-webhooks/
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversBitbucketSecretRef SecretRef { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// The Secret&apos;s data map is expected to contain a `secret` key whose value
/// does NOT need to be shared directly with Docker Hub when registering a
/// webhook. It is used only by Kargo to create a complex, hard-to-guess URL,
/// which implicitly serves as a shared secret. For more information about
/// Docker Hub webhooks, please refer to the Docker documentation:
///   https://docs.docker.com/docker-hub/webhooks/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversDockerhubSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// DockerHub contains the configuration for a webhook receiver that is
/// compatible with DockerHub payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversDockerhub
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret` key whose value
    /// does NOT need to be shared directly with Docker Hub when registering a
    /// webhook. It is used only by Kargo to create a complex, hard-to-guess URL,
    /// which implicitly serves as a shared secret. For more information about
    /// Docker Hub webhooks, please refer to the Docker documentation:
    ///   https://docs.docker.com/docker-hub/webhooks/
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversDockerhubSecretRef SecretRef { get; set; }
}

/// <summary>
/// ActionType indicates the type of action to be performed. `Refresh` is the
/// only currently supported action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsActionEnum>))]
public enum V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsActionEnum
{
    [EnumMember(Value = "Refresh"), JsonStringEnumMemberName("Refresh")]
    Refresh
}

/// <summary>Key is the key of the index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaIndexSelectorMatchIndicesKeyEnum>))]
public enum V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaIndexSelectorMatchIndicesKeyEnum
{
    [EnumMember(Value = "subscribedURLs"), JsonStringEnumMemberName("subscribedURLs")]
    SubscribedURLs,
    [EnumMember(Value = "receiverPaths"), JsonStringEnumMemberName("receiverPaths")]
    ReceiverPaths
}

/// <summary>
/// IndexSelectorRequirement encapsulates a requirement used to select indexes
/// based on specific criteria.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaIndexSelectorMatchIndices
{
    /// <summary>Key is the key of the index.</summary>
    [JsonPropertyName("key")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaIndexSelectorMatchIndicesKeyEnum Key { get; set; }

    /// <summary>
    /// Operator indicates the operation that should be used to evaluate
    /// whether the selection requirement is satisfied.
    /// 
    /// kubebuilder:validation:Enum=Equal;NotEqual;
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// Value can be a static string or an expression that will be evaluated.
    /// 
    /// kubebuilder:validation:Required
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// IndexSelector is a selector used to identify cached target resources by cache key.
/// If used with LabelSelector and/or Name, the results are the combined (logical AND) of all the criteria.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaIndexSelector
{
    /// <summary>MatchIndices is a list of index selector requirements.</summary>
    [JsonPropertyName("matchIndices")]
    public IList<V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaIndexSelectorMatchIndices>? MatchIndices { get; set; }
}

/// <summary>Kind is the kind of the target resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaKindEnum>))]
public enum V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// LabelSelector is a label selector to identify the target resources.
/// If used with IndexSelector and/or Name, the results are the combined (logical AND) of all the criteria.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// GenericWebhookTargetSelectionCriteria describes selection criteria for resources to which some
/// action is to be applied. Name, LabelSelector, and IndexSelector are all optional
/// however, at least one must be specified. When multiple criteria are specified, the
/// results are the combined (logical AND) of the criteria.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteria
{
    /// <summary>
    /// IndexSelector is a selector used to identify cached target resources by cache key.
    /// If used with LabelSelector and/or Name, the results are the combined (logical AND) of all the criteria.
    /// </summary>
    [JsonPropertyName("indexSelector")]
    public V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaIndexSelector? IndexSelector { get; set; }

    /// <summary>Kind is the kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaKindEnum Kind { get; set; }

    /// <summary>
    /// LabelSelector is a label selector to identify the target resources.
    /// If used with IndexSelector and/or Name, the results are the combined (logical AND) of all the criteria.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteriaLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// Name is the name of the target resource. If LabelSelector and/or IndexSelectors
    /// are also specified, the results are the combined (logical AND) of the criteria.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// GenericWebhookAction describes an action to be performed on a resource
/// and the conditions under which it should be performed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGenericActions
{
    /// <summary>
    /// ActionType indicates the type of action to be performed. `Refresh` is the
    /// only currently supported action.
    /// </summary>
    [JsonPropertyName("action")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsActionEnum Action { get; set; }

    /// <summary>
    /// Parameters contains additional, action-specific parameters. Values may be
    /// static or extracted from the request using expressions.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>
    /// TargetSelectionCriteria is a list of selection criteria for the resources on which the
    /// action should be performed.
    /// </summary>
    [JsonPropertyName("targetSelectionCriteria")]
    public IList<V1alpha1ProjectConfigSpecWebhookReceiversGenericActionsTargetSelectionCriteria>? TargetSelectionCriteria { get; set; }

    /// <summary>
    /// WhenExpression defines criteria that a request must meet to run this
    /// action.
    /// </summary>
    [JsonPropertyName("whenExpression")]
    public string? WhenExpression { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The Secret&apos;s data map is expected to contain a `secret` key whose value
/// does NOT need to be shared directly with the sender. It is used only by
/// Kargo to create a complex, hard-to-guess URL, which implicitly serves as a
/// shared secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGenericSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Generic contains the configuration for a generic webhook receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGeneric
{
    /// <summary>Actions is a list of actions to be performed when a webhook event is received.</summary>
    [JsonPropertyName("actions")]
    public IList<V1alpha1ProjectConfigSpecWebhookReceiversGenericActions>? Actions { get; set; }

    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret` key whose value
    /// does NOT need to be shared directly with the sender. It is used only by
    /// Kargo to create a complex, hard-to-guess URL, which implicitly serves as a
    /// shared secret.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversGenericSecretRef SecretRef { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The Secret&apos;s data map is expected to contain a `secret` key whose value is
/// the shared secret used to authenticate the webhook requests sent by Gitea.
/// For more information please refer to the Gitea documentation:
///   https://docs.gitea.io/en-us/webhooks/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGiteaSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Gitea contains the configuration for a webhook receiver that is compatible
/// with Gitea payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGitea
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret` key whose value is
    /// the shared secret used to authenticate the webhook requests sent by Gitea.
    /// For more information please refer to the Gitea documentation:
    ///   https://docs.gitea.io/en-us/webhooks/
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversGiteaSecretRef SecretRef { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The Secret&apos;s data map is expected to contain a `secret` key whose value is
/// the shared secret used to authenticate the webhook requests sent by GitHub.
/// For more information please refer to GitHub documentation:
///   https://docs.github.com/en/webhooks/using-webhooks/validating-webhook-deliveries
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGithubSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// GitHub contains the configuration for a webhook receiver that is compatible
/// with GitHub payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGithub
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret` key whose value is
    /// the shared secret used to authenticate the webhook requests sent by GitHub.
    /// For more information please refer to GitHub documentation:
    ///   https://docs.github.com/en/webhooks/using-webhooks/validating-webhook-deliveries
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversGithubSecretRef SecretRef { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The secret is expected to contain a `secret-token` key containing the
/// shared secret specified when registering the webhook in GitLab. For more
/// information about this token, please refer to the GitLab documentation:
///   https://docs.gitlab.com/user/project/integrations/webhooks/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGitlabSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// GitLab contains the configuration for a webhook receiver that is compatible
/// with GitLab payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversGitlab
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The secret is expected to contain a `secret-token` key containing the
    /// shared secret specified when registering the webhook in GitLab. For more
    /// information about this token, please refer to the GitLab documentation:
    ///   https://docs.gitlab.com/user/project/integrations/webhooks/
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversGitlabSecretRef SecretRef { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The secret is expected to contain an `auth-header` key containing the &quot;auth
/// header&quot; specified when registering the webhook in Harbor. For more
/// information, please refer to the Harbor documentation:
///   https://goharbor.io/docs/main/working-with-projects/project-configuration/configure-webhooks/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversHarborSecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Harbor contains the configuration for a webhook receiver that is compatible
/// with Harbor payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversHarbor
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The secret is expected to contain an `auth-header` key containing the &quot;auth
    /// header&quot; specified when registering the webhook in Harbor. For more
    /// information, please refer to the Harbor documentation:
    ///   https://goharbor.io/docs/main/working-with-projects/project-configuration/configure-webhooks/
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversHarborSecretRef SecretRef { get; set; }
}

/// <summary>
/// SecretRef contains a reference to a Secret. For Project-scoped webhook
/// receivers, the referenced Secret must be in the same namespace as the
/// ProjectConfig.
/// 
/// For cluster-scoped webhook receivers, the referenced Secret must be in the
/// designated &quot;system resources&quot; namespace.
/// 
/// The Secret&apos;s data map is expected to contain a `secret` key whose value
/// does NOT need to be shared directly with Quay when registering a
/// webhook. It is used only by Kargo to create a complex, hard-to-guess URL,
/// which implicitly serves as a shared secret. For more information about
/// Quay webhooks, please refer to the Quay documentation:
///   https://docs.quay.io/guides/notifications.html
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversQuaySecretRef
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Quay contains the configuration for a webhook receiver that is compatible
/// with Quay payloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceiversQuay
{
    /// <summary>
    /// SecretRef contains a reference to a Secret. For Project-scoped webhook
    /// receivers, the referenced Secret must be in the same namespace as the
    /// ProjectConfig.
    /// 
    /// For cluster-scoped webhook receivers, the referenced Secret must be in the
    /// designated &quot;system resources&quot; namespace.
    /// 
    /// The Secret&apos;s data map is expected to contain a `secret` key whose value
    /// does NOT need to be shared directly with Quay when registering a
    /// webhook. It is used only by Kargo to create a complex, hard-to-guess URL,
    /// which implicitly serves as a shared secret. For more information about
    /// Quay webhooks, please refer to the Quay documentation:
    ///   https://docs.quay.io/guides/notifications.html
    /// </summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1ProjectConfigSpecWebhookReceiversQuaySecretRef SecretRef { get; set; }
}

/// <summary>
/// WebhookReceiverConfig describes the configuration for a single webhook
/// receiver.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpecWebhookReceivers
{
    /// <summary>
    /// Artifactory contains the configuration for a webhook receiver that is
    /// compatible with JFrog Artifactory payloads.
    /// </summary>
    [JsonPropertyName("artifactory")]
    public V1alpha1ProjectConfigSpecWebhookReceiversArtifactory? Artifactory { get; set; }

    /// <summary>
    /// Azure contains the configuration for a webhook receiver that is compatible
    /// with Azure Container Registry (ACR) and Azure DevOps payloads.
    /// </summary>
    [JsonPropertyName("azure")]
    public V1alpha1ProjectConfigSpecWebhookReceiversAzure? Azure { get; set; }

    /// <summary>
    /// Bitbucket contains the configuration for a webhook receiver that is
    /// compatible with Bitbucket payloads.
    /// </summary>
    [JsonPropertyName("bitbucket")]
    public V1alpha1ProjectConfigSpecWebhookReceiversBitbucket? Bitbucket { get; set; }

    /// <summary>
    /// DockerHub contains the configuration for a webhook receiver that is
    /// compatible with DockerHub payloads.
    /// </summary>
    [JsonPropertyName("dockerhub")]
    public V1alpha1ProjectConfigSpecWebhookReceiversDockerhub? Dockerhub { get; set; }

    /// <summary>Generic contains the configuration for a generic webhook receiver.</summary>
    [JsonPropertyName("generic")]
    public V1alpha1ProjectConfigSpecWebhookReceiversGeneric? Generic { get; set; }

    /// <summary>
    /// Gitea contains the configuration for a webhook receiver that is compatible
    /// with Gitea payloads.
    /// </summary>
    [JsonPropertyName("gitea")]
    public V1alpha1ProjectConfigSpecWebhookReceiversGitea? Gitea { get; set; }

    /// <summary>
    /// GitHub contains the configuration for a webhook receiver that is compatible
    /// with GitHub payloads.
    /// </summary>
    [JsonPropertyName("github")]
    public V1alpha1ProjectConfigSpecWebhookReceiversGithub? Github { get; set; }

    /// <summary>
    /// GitLab contains the configuration for a webhook receiver that is compatible
    /// with GitLab payloads.
    /// </summary>
    [JsonPropertyName("gitlab")]
    public V1alpha1ProjectConfigSpecWebhookReceiversGitlab? Gitlab { get; set; }

    /// <summary>
    /// Harbor contains the configuration for a webhook receiver that is compatible
    /// with Harbor payloads.
    /// </summary>
    [JsonPropertyName("harbor")]
    public V1alpha1ProjectConfigSpecWebhookReceiversHarbor? Harbor { get; set; }

    /// <summary>Name is the name of the webhook receiver.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Quay contains the configuration for a webhook receiver that is compatible
    /// with Quay payloads.
    /// </summary>
    [JsonPropertyName("quay")]
    public V1alpha1ProjectConfigSpecWebhookReceiversQuay? Quay { get; set; }
}

/// <summary>Spec describes the configuration of a Project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigSpec
{
    /// <summary>
    /// PromotionPolicies defines policies governing the promotion of Freight to
    /// specific Stages within the Project.
    /// </summary>
    [JsonPropertyName("promotionPolicies")]
    public IList<V1alpha1ProjectConfigSpecPromotionPolicies>? PromotionPolicies { get; set; }

    /// <summary>
    /// WebhookReceivers describes Project-specific webhook receivers used for
    /// processing events from various external platforms
    /// </summary>
    [JsonPropertyName("webhookReceivers")]
    public IList<V1alpha1ProjectConfigSpecWebhookReceivers>? WebhookReceivers { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ProjectConfigStatusConditionsStatusEnum>))]
public enum V1alpha1ProjectConfigStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1alpha1ProjectConfigStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>WebhookReceiverDetails encapsulates the details of a webhook receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigStatusWebhookReceivers
{
    /// <summary>Name is the name of the webhook receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the receiver&apos;s webhook endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>URL includes the full address of the receiver&apos;s webhook endpoint.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Status describes the current status of a ProjectConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectConfigStatus
{
    /// <summary>
    /// Conditions contains the last observations of the Project Config&apos;s current
    /// state.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ProjectConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledRefresh holds the value of the most recent AnnotationKeyRefresh
    /// annotation that was handled by the controller. This field can be used to
    /// determine whether the request to refresh the resource has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledRefresh")]
    public string? LastHandledRefresh { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that this
    /// ProjectConfig was reconciled against.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// WebhookReceivers describes the status of Project-specific webhook
    /// receivers.
    /// </summary>
    [JsonPropertyName("webhookReceivers")]
    public IList<V1alpha1ProjectConfigStatusWebhookReceivers>? WebhookReceivers { get; set; }
}

/// <summary>
/// ProjectConfig is a resource type that describes the configuration of a
/// Project.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ProjectConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ProjectConfigSpec?>, IStatus<V1alpha1ProjectConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ProjectConfig";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "projectconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec describes the configuration of a Project.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ProjectConfigSpec? Spec { get; set; }

    /// <summary>Status describes the current status of a ProjectConfig.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ProjectConfigStatus? Status { get; set; }
}
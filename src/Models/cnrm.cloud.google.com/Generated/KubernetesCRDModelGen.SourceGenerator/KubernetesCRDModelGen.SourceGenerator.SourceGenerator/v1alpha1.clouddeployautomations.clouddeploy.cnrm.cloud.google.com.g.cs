#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddeploy.cnrm.cloud.google.com;
/// <summary>CloudDeployAutomation is the Schema for the CloudDeployAutomation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployAutomationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDeployAutomation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployAutomationList";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeployautomations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddeploy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDeployAutomationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudDeployAutomation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudDeployAutomation> Items { get; set; }
}

/// <summary>Immutable. Required. The DeliveryPipeline that this automation belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecDeliveryPipelineRef
{
    /// <summary>A reference to an externally managed DeployDeliveryPipeline resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/deliverypipelines/{{deliverypipelineID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DeployDeliveryPipeline resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DeployDeliveryPipeline resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The `AdvanceRolloutRule` will automatically advance a successful Rollout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesAdvanceRolloutRule
{
    /// <summary>Required. ID of the rule.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Optional. Proceeds only after phase name matched any one in the list.</summary>
    [JsonPropertyName("sourcePhases")]
    public IList<string>? SourcePhases { get; set; }

    /// <summary>Optional. How long to wait after a rollout is finished.</summary>
    [JsonPropertyName("wait")]
    public string? Wait { get; set; }
}

/// <summary>Optional. The ID of the stage in the pipeline to which this `Release` is deploying.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesPromoteReleaseRuleDestinationTargetRef
{
    /// <summary>A reference to an externally managed CloudDeployTarget resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/targets/{{targetID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. `PromoteReleaseRule` will automatically promote a release from the current target to a specified target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesPromoteReleaseRule
{
    /// <summary>Optional. The starting phase of the rollout created by this operation. Default to the first phase.</summary>
    [JsonPropertyName("destinationPhase")]
    public string? DestinationPhase { get; set; }

    /// <summary>Optional. The ID of the stage in the pipeline to which this `Release` is deploying.</summary>
    [JsonPropertyName("destinationTargetRef")]
    public V1alpha1CloudDeployAutomationSpecRulesPromoteReleaseRuleDestinationTargetRef? DestinationTargetRef { get; set; }

    /// <summary>Required. ID of the rule.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Optional. How long the release need to be paused until being promoted to the next target.</summary>
    [JsonPropertyName("wait")]
    public string? Wait { get; set; }
}

/// <summary>Optional. Retries a failed job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRuleRepairPhasesRetry
{
    /// <summary>Required. Total number of retries.</summary>
    [JsonPropertyName("attempts")]
    public required long Attempts { get; set; }

    /// <summary>Optional. The pattern of how wait time will be increased.</summary>
    [JsonPropertyName("backoffMode")]
    public string? BackoffMode { get; set; }

    /// <summary>Optional. How long to wait for the first retry.</summary>
    [JsonPropertyName("wait")]
    public string? Wait { get; set; }
}

/// <summary>Optional. Rolls back a `Rollout`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRuleRepairPhasesRollback
{
    /// <summary>Optional. The starting phase ID for the `Rollout`.</summary>
    [JsonPropertyName("destinationPhase")]
    public string? DestinationPhase { get; set; }

    /// <summary>Optional. If pending rollout exists on the target, the rollback operation will be aborted.</summary>
    [JsonPropertyName("disableRollbackIfRolloutPending")]
    public bool? DisableRollbackIfRolloutPending { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRuleRepairPhases
{
    /// <summary>Optional. Retries a failed job.</summary>
    [JsonPropertyName("retry")]
    public V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRuleRepairPhasesRetry? Retry { get; set; }

    /// <summary>Optional. Rolls back a `Rollout`.</summary>
    [JsonPropertyName("rollback")]
    public V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRuleRepairPhasesRollback? Rollback { get; set; }
}

/// <summary>Optional. The `RepairRolloutRule` will automatically repair a failed rollout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRule
{
    /// <summary>Required. ID of the rule.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Optional. Jobs to repair.</summary>
    [JsonPropertyName("jobs")]
    public IList<string>? Jobs { get; set; }

    /// <summary>Optional. Phases within which jobs are subject to automatic repair actions on failure.</summary>
    [JsonPropertyName("phases")]
    public IList<string>? Phases { get; set; }

    /// <summary>Required. Defines the types of automatic repair phases for failed jobs.</summary>
    [JsonPropertyName("repairPhases")]
    public required IList<V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRuleRepairPhases> RepairPhases { get; set; }
}

/// <summary>Optional. The ID of the stage in the pipeline to which this `Release` is deploying.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesTimedPromoteReleaseRuleDestinationTargetRef
{
    /// <summary>A reference to an externally managed CloudDeployTarget resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/targets/{{targetID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The `TimedPromoteReleaseRule` will automatically promote a release from the current target(s) to the specified target(s) on a configured schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRulesTimedPromoteReleaseRule
{
    /// <summary>Optional. The starting phase of the rollout created by this rule.</summary>
    [JsonPropertyName("destinationPhase")]
    public string? DestinationPhase { get; set; }

    /// <summary>Optional. The ID of the stage in the pipeline to which this `Release` is deploying.</summary>
    [JsonPropertyName("destinationTargetRef")]
    public V1alpha1CloudDeployAutomationSpecRulesTimedPromoteReleaseRuleDestinationTargetRef? DestinationTargetRef { get; set; }

    /// <summary>Required. ID of the rule.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Required. Schedule in crontab format.</summary>
    [JsonPropertyName("schedule")]
    public required string Schedule { get; set; }

    /// <summary>Required. The time zone in IANA format.</summary>
    [JsonPropertyName("timeZone")]
    public required string TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecRules
{
    /// <summary>Optional. The `AdvanceRolloutRule` will automatically advance a successful Rollout.</summary>
    [JsonPropertyName("advanceRolloutRule")]
    public V1alpha1CloudDeployAutomationSpecRulesAdvanceRolloutRule? AdvanceRolloutRule { get; set; }

    /// <summary>Optional. `PromoteReleaseRule` will automatically promote a release from the current target to a specified target.</summary>
    [JsonPropertyName("promoteReleaseRule")]
    public V1alpha1CloudDeployAutomationSpecRulesPromoteReleaseRule? PromoteReleaseRule { get; set; }

    /// <summary>Optional. The `RepairRolloutRule` will automatically repair a failed rollout.</summary>
    [JsonPropertyName("repairRolloutRule")]
    public V1alpha1CloudDeployAutomationSpecRulesRepairRolloutRule? RepairRolloutRule { get; set; }

    /// <summary>Optional. The `TimedPromoteReleaseRule` will automatically promote a release from the current target(s) to the specified target(s) on a configured schedule.</summary>
    [JsonPropertyName("timedPromoteReleaseRule")]
    public V1alpha1CloudDeployAutomationSpecRulesTimedPromoteReleaseRule? TimedPromoteReleaseRule { get; set; }
}

/// <summary>Optional. The Target to which the rule applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecSelectorTargetsTargetRef
{
    /// <summary>A reference to an externally managed CloudDeployTarget resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/targets/{{targetID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecSelectorTargets
{
    /// <summary>Target labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Optional. The Target to which the rule applies.</summary>
    [JsonPropertyName("targetRef")]
    public V1alpha1CloudDeployAutomationSpecSelectorTargetsTargetRef? TargetRef { get; set; }
}

/// <summary>Required. Selected resources to which the automation will be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecSelector
{
    /// <summary>Optional. Contains attributes about a target.</summary>
    [JsonPropertyName("targets")]
    public IList<V1alpha1CloudDeployAutomationSpecSelectorTargets>? Targets { get; set; }
}

/// <summary>Required. Email address of the user-managed IAM service account that creates Cloud Deploy release and rollout resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>CloudDeployAutomationSpec defines the desired state of CloudDeployAutomation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationSpec
{
    /// <summary>Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Immutable. Required. The DeliveryPipeline that this automation belongs to.</summary>
    [JsonPropertyName("deliveryPipelineRef")]
    public required V1alpha1CloudDeployAutomationSpecDeliveryPipelineRef DeliveryPipelineRef { get; set; }

    /// <summary>Optional. Description of the `Automation`. Max length is 255 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudDeployAutomationSpecProjectRef ProjectRef { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. List of Automation rules associated with the Automation resource.</summary>
    [JsonPropertyName("rules")]
    public required IList<V1alpha1CloudDeployAutomationSpecRules> Rules { get; set; }

    /// <summary>Required. Selected resources to which the automation will be applied.</summary>
    [JsonPropertyName("selector")]
    public required V1alpha1CloudDeployAutomationSpecSelector Selector { get; set; }

    /// <summary>Required. Email address of the user-managed IAM service account that creates Cloud Deploy release and rollout resources.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public required V1alpha1CloudDeployAutomationSpecServiceAccountRef ServiceAccountRef { get; set; }

    /// <summary>Optional. When Suspended, automation is deactivated from execution.</summary>
    [JsonPropertyName("suspended")]
    public bool? Suspended { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Optional. Details around targets enumerated in the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleConditionTargetsPresentCondition
{
    /// <summary>The list of Target names that do not exist.</summary>
    [JsonPropertyName("missingTargets")]
    public IList<string>? MissingTargets { get; set; }

    /// <summary>True if there aren&apos;t any missing Targets.</summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }

    /// <summary>Last time the condition was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleConditionTimedPromoteReleaseConditionTargetsList
{
    /// <summary>Optional. The destination target ID.</summary>
    [JsonPropertyName("destinationTargetID")]
    public string? DestinationTargetID { get; set; }

    /// <summary>Optional. The source target ID.</summary>
    [JsonPropertyName("sourceTargetID")]
    public string? SourceTargetID { get; set; }
}

/// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleConditionTimedPromoteReleaseCondition
{
    /// <summary>Output only. When the next scheduled promotion(s) will occur.</summary>
    [JsonPropertyName("nextPromotionTime")]
    public string? NextPromotionTime { get; set; }

    /// <summary>Output only. A list of targets involved in the upcoming timed promotion(s).</summary>
    [JsonPropertyName("targetsList")]
    public IList<V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleConditionTimedPromoteReleaseConditionTargetsList>? TargetsList { get; set; }
}

/// <summary>Output only. Information around the state of the Automation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleCondition
{
    /// <summary>Optional. Details around targets enumerated in the rule.</summary>
    [JsonPropertyName("targetsPresentCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleConditionTargetsPresentCondition? TargetsPresentCondition { get; set; }

    /// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
    [JsonPropertyName("timedPromoteReleaseCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleConditionTimedPromoteReleaseCondition? TimedPromoteReleaseCondition { get; set; }
}

/// <summary>Optional. The `AdvanceRolloutRule` will automatically advance a successful Rollout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRule
{
    /// <summary>Output only. Information around the state of the Automation rule.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRuleCondition? Condition { get; set; }
}

/// <summary>Optional. Details around targets enumerated in the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleConditionTargetsPresentCondition
{
    /// <summary>The list of Target names that do not exist.</summary>
    [JsonPropertyName("missingTargets")]
    public IList<string>? MissingTargets { get; set; }

    /// <summary>True if there aren&apos;t any missing Targets.</summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }

    /// <summary>Last time the condition was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleConditionTimedPromoteReleaseConditionTargetsList
{
    /// <summary>Optional. The destination target ID.</summary>
    [JsonPropertyName("destinationTargetID")]
    public string? DestinationTargetID { get; set; }

    /// <summary>Optional. The source target ID.</summary>
    [JsonPropertyName("sourceTargetID")]
    public string? SourceTargetID { get; set; }
}

/// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleConditionTimedPromoteReleaseCondition
{
    /// <summary>Output only. When the next scheduled promotion(s) will occur.</summary>
    [JsonPropertyName("nextPromotionTime")]
    public string? NextPromotionTime { get; set; }

    /// <summary>Output only. A list of targets involved in the upcoming timed promotion(s).</summary>
    [JsonPropertyName("targetsList")]
    public IList<V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleConditionTimedPromoteReleaseConditionTargetsList>? TargetsList { get; set; }
}

/// <summary>Output only. Information around the state of the Automation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleCondition
{
    /// <summary>Optional. Details around targets enumerated in the rule.</summary>
    [JsonPropertyName("targetsPresentCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleConditionTargetsPresentCondition? TargetsPresentCondition { get; set; }

    /// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
    [JsonPropertyName("timedPromoteReleaseCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleConditionTimedPromoteReleaseCondition? TimedPromoteReleaseCondition { get; set; }
}

/// <summary>Optional. `PromoteReleaseRule` will automatically promote a release from the current target to a specified target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRule
{
    /// <summary>Output only. Information around the state of the Automation rule.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRuleCondition? Condition { get; set; }
}

/// <summary>Optional. Details around targets enumerated in the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleConditionTargetsPresentCondition
{
    /// <summary>The list of Target names that do not exist.</summary>
    [JsonPropertyName("missingTargets")]
    public IList<string>? MissingTargets { get; set; }

    /// <summary>True if there aren&apos;t any missing Targets.</summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }

    /// <summary>Last time the condition was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleConditionTimedPromoteReleaseConditionTargetsList
{
    /// <summary>Optional. The destination target ID.</summary>
    [JsonPropertyName("destinationTargetID")]
    public string? DestinationTargetID { get; set; }

    /// <summary>Optional. The source target ID.</summary>
    [JsonPropertyName("sourceTargetID")]
    public string? SourceTargetID { get; set; }
}

/// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleConditionTimedPromoteReleaseCondition
{
    /// <summary>Output only. When the next scheduled promotion(s) will occur.</summary>
    [JsonPropertyName("nextPromotionTime")]
    public string? NextPromotionTime { get; set; }

    /// <summary>Output only. A list of targets involved in the upcoming timed promotion(s).</summary>
    [JsonPropertyName("targetsList")]
    public IList<V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleConditionTimedPromoteReleaseConditionTargetsList>? TargetsList { get; set; }
}

/// <summary>Output only. Information around the state of the &apos;Automation&apos; rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleCondition
{
    /// <summary>Optional. Details around targets enumerated in the rule.</summary>
    [JsonPropertyName("targetsPresentCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleConditionTargetsPresentCondition? TargetsPresentCondition { get; set; }

    /// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
    [JsonPropertyName("timedPromoteReleaseCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleConditionTimedPromoteReleaseCondition? TimedPromoteReleaseCondition { get; set; }
}

/// <summary>Optional. The `RepairRolloutRule` will automatically repair a failed rollout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRule
{
    /// <summary>Output only. Information around the state of the &apos;Automation&apos; rule.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRuleCondition? Condition { get; set; }
}

/// <summary>Optional. Details around targets enumerated in the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleConditionTargetsPresentCondition
{
    /// <summary>The list of Target names that do not exist.</summary>
    [JsonPropertyName("missingTargets")]
    public IList<string>? MissingTargets { get; set; }

    /// <summary>True if there aren&apos;t any missing Targets.</summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }

    /// <summary>Last time the condition was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleConditionTimedPromoteReleaseConditionTargetsList
{
    /// <summary>Optional. The destination target ID.</summary>
    [JsonPropertyName("destinationTargetID")]
    public string? DestinationTargetID { get; set; }

    /// <summary>Optional. The source target ID.</summary>
    [JsonPropertyName("sourceTargetID")]
    public string? SourceTargetID { get; set; }
}

/// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleConditionTimedPromoteReleaseCondition
{
    /// <summary>Output only. When the next scheduled promotion(s) will occur.</summary>
    [JsonPropertyName("nextPromotionTime")]
    public string? NextPromotionTime { get; set; }

    /// <summary>Output only. A list of targets involved in the upcoming timed promotion(s).</summary>
    [JsonPropertyName("targetsList")]
    public IList<V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleConditionTimedPromoteReleaseConditionTargetsList>? TargetsList { get; set; }
}

/// <summary>Output only. Information around the state of the Automation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleCondition
{
    /// <summary>Optional. Details around targets enumerated in the rule.</summary>
    [JsonPropertyName("targetsPresentCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleConditionTargetsPresentCondition? TargetsPresentCondition { get; set; }

    /// <summary>Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed promote release rule defined.</summary>
    [JsonPropertyName("timedPromoteReleaseCondition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleConditionTimedPromoteReleaseCondition? TimedPromoteReleaseCondition { get; set; }
}

/// <summary>Optional. The `TimedPromoteReleaseRule` will automatically promote a release from the current target(s) to the specified target(s) on a configured schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRule
{
    /// <summary>Output only. Information around the state of the Automation rule.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRuleCondition? Condition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedStateRules
{
    /// <summary>Optional. The `AdvanceRolloutRule` will automatically advance a successful Rollout.</summary>
    [JsonPropertyName("advanceRolloutRule")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesAdvanceRolloutRule? AdvanceRolloutRule { get; set; }

    /// <summary>Optional. `PromoteReleaseRule` will automatically promote a release from the current target to a specified target.</summary>
    [JsonPropertyName("promoteReleaseRule")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesPromoteReleaseRule? PromoteReleaseRule { get; set; }

    /// <summary>Optional. The `RepairRolloutRule` will automatically repair a failed rollout.</summary>
    [JsonPropertyName("repairRolloutRule")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesRepairRolloutRule? RepairRolloutRule { get; set; }

    /// <summary>Optional. The `TimedPromoteReleaseRule` will automatically promote a release from the current target(s) to the specified target(s) on a configured schedule.</summary>
    [JsonPropertyName("timedPromoteReleaseRule")]
    public V1alpha1CloudDeployAutomationStatusObservedStateRulesTimedPromoteReleaseRule? TimedPromoteReleaseRule { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatusObservedState
{
    /// <summary>Output only. Time at which the automation was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. The weak etag of the `Automation` resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Required. List of Automation rules associated with the Automation resource.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1CloudDeployAutomationStatusObservedStateRules>? Rules { get; set; }

    /// <summary>Output only. Unique identifier of the `Automation`.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Time at which the automation was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CloudDeployAutomationStatus defines the config connector machine state of CloudDeployAutomation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployAutomationStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDeployAutomationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudDeployAutomation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDeployAutomationStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudDeployAutomation is the Schema for the CloudDeployAutomation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployAutomation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDeployAutomationSpec>, IStatus<V1alpha1CloudDeployAutomationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployAutomation";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeployautomations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddeploy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDeployAutomation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudDeployAutomationSpec defines the desired state of CloudDeployAutomation</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudDeployAutomationSpec Spec { get; set; }

    /// <summary>CloudDeployAutomationStatus defines the config connector machine state of CloudDeployAutomation</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDeployAutomationStatus? Status { get; set; }
}
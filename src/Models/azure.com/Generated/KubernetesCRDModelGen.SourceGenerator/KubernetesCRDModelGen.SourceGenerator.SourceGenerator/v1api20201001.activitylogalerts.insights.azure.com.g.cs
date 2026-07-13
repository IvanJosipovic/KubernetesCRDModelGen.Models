#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2020-10-01/activityLogAlerts_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201001ActivityLogAlertList : IKubernetesObject<V1ListMeta>, IItems<V1api20201001ActivityLogAlert>
{
    public const string KubeApiVersion = "v1api20201001";
    public const string KubeKind = "ActivityLogAlertList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "activitylogalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20201001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ActivityLogAlertList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201001ActivityLogAlert objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201001ActivityLogAlert> Items { get; set; }
}

/// <summary>ActionGroupReference: The resource ID of the Action Group. This cannot be null or empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecActionsActionGroupsActionGroupReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A pointer to an Azure Action Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecActionsActionGroups
{
    /// <summary>ActionGroupReference: The resource ID of the Action Group. This cannot be null or empty.</summary>
    [JsonPropertyName("actionGroupReference")]
    public required V1api20201001ActivityLogAlertSpecActionsActionGroupsActionGroupReference ActionGroupReference { get; set; }

    /// <summary>
    /// WebhookProperties: the dictionary of custom properties to include with the post operation. These data are appended to
    /// the webhook payload.
    /// </summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary>Actions: The actions that will activate when the condition is met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecActions
{
    /// <summary>ActionGroups: The list of the Action Groups.</summary>
    [JsonPropertyName("actionGroups")]
    public IList<V1api20201001ActivityLogAlertSpecActionsActionGroups>? ActionGroups { get; set; }
}

/// <summary>
/// An Activity Log Alert rule condition that is met by comparing the field and value of an Activity Log event.
/// This
/// condition must contain &apos;field&apos; and either &apos;equals&apos; or &apos;containsAny&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecConditionAllOfAnyOf
{
    /// <summary>
    /// ContainsAny: The value of the event&apos;s field will be compared to the values in this array (case-insensitive) to determine
    /// if the condition is met.
    /// </summary>
    [JsonPropertyName("containsAny")]
    public IList<string>? ContainsAny { get; set; }

    /// <summary>
    /// Equals: The value of the event&apos;s field will be compared to this value (case-insensitive) to determine if the condition
    /// is met.
    /// </summary>
    [JsonPropertyName("equals")]
    public string? Equals { get; set; }

    /// <summary>
    /// Field: The name of the Activity Log event&apos;s field that this condition will examine.
    /// The possible values for this field are (case-insensitive): &apos;resourceId&apos;, &apos;category&apos;, &apos;caller&apos;, &apos;level&apos;, &apos;operationName&apos;,
    /// &apos;resourceGroup&apos;, &apos;resourceProvider&apos;, &apos;status&apos;, &apos;subStatus&apos;, &apos;resourceType&apos;, or anything beginning with &apos;properties&apos;.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

/// <summary>
/// An Activity Log Alert rule condition that is met when all its member conditions are met.
/// Each condition can be of one of
/// the following types:
/// __Important__: Each type has its unique subset of properties. Properties from different types
/// CANNOT exist in one condition.
/// * __Leaf Condition -__ must contain &apos;field&apos; and either &apos;equals&apos; or &apos;containsAny&apos;.
/// _Please note, &apos;anyOf&apos; should __not__ be set in a Leaf Condition._
/// * __AnyOf Condition -__ must contain __only__
/// &apos;anyOf&apos; (which is an array of Leaf Conditions).
/// _Please note, &apos;field&apos;, &apos;equals&apos; and &apos;containsAny&apos; should __not__ be
/// set in an AnyOf Condition._
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecConditionAllOf
{
    /// <summary>AnyOf: An Activity Log Alert rule condition that is met when at least one of its member leaf conditions are met.</summary>
    [JsonPropertyName("anyOf")]
    public IList<V1api20201001ActivityLogAlertSpecConditionAllOfAnyOf>? AnyOf { get; set; }

    /// <summary>
    /// ContainsAny: The value of the event&apos;s field will be compared to the values in this array (case-insensitive) to determine
    /// if the condition is met.
    /// </summary>
    [JsonPropertyName("containsAny")]
    public IList<string>? ContainsAny { get; set; }

    /// <summary>
    /// Equals: The value of the event&apos;s field will be compared to this value (case-insensitive) to determine if the condition
    /// is met.
    /// </summary>
    [JsonPropertyName("equals")]
    public string? Equals { get; set; }

    /// <summary>
    /// Field: The name of the Activity Log event&apos;s field that this condition will examine.
    /// The possible values for this field are (case-insensitive): &apos;resourceId&apos;, &apos;category&apos;, &apos;caller&apos;, &apos;level&apos;, &apos;operationName&apos;,
    /// &apos;resourceGroup&apos;, &apos;resourceProvider&apos;, &apos;status&apos;, &apos;subStatus&apos;, &apos;resourceType&apos;, or anything beginning with &apos;properties&apos;.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

/// <summary>Condition: The condition that will cause this alert to activate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecCondition
{
    /// <summary>AllOf: The list of Activity Log Alert rule conditions.</summary>
    [JsonPropertyName("allOf")]
    public required IList<V1api20201001ActivityLogAlertSpecConditionAllOf> AllOf { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201001ActivityLogAlertSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201001ActivityLogAlertSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpecScopesReferences
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertSpec
{
    /// <summary>Actions: The actions that will activate when the condition is met.</summary>
    [JsonPropertyName("actions")]
    public required V1api20201001ActivityLogAlertSpecActions Actions { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Condition: The condition that will cause this alert to activate.</summary>
    [JsonPropertyName("condition")]
    public required V1api20201001ActivityLogAlertSpecCondition Condition { get; set; }

    /// <summary>Description: A description of this Activity Log Alert rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Enabled: Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then
    /// none of its actions will be activated.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Location: The location of the resource. Azure Activity Log Alert rules are supported on Global, West Europe and North
    /// Europe regions.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201001ActivityLogAlertSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201001ActivityLogAlertSpecOwner Owner { get; set; }

    /// <summary>
    /// ScopesReferences: A list of resource IDs that will be used as prefixes. The alert will only apply to Activity Log events
    /// with resource IDs that fall under one of these prefixes. This list must include at least one item.
    /// </summary>
    [JsonPropertyName("scopesReferences")]
    public required IList<V1api20201001ActivityLogAlertSpecScopesReferences> ScopesReferences { get; set; }

    /// <summary>Tags: The tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A pointer to an Azure Action Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertStatusActionsActionGroups
{
    /// <summary>ActionGroupId: The resource ID of the Action Group. This cannot be null or empty.</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>
    /// WebhookProperties: the dictionary of custom properties to include with the post operation. These data are appended to
    /// the webhook payload.
    /// </summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary>Actions: The actions that will activate when the condition is met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertStatusActions
{
    /// <summary>ActionGroups: The list of the Action Groups.</summary>
    [JsonPropertyName("actionGroups")]
    public IList<V1api20201001ActivityLogAlertStatusActionsActionGroups>? ActionGroups { get; set; }
}

/// <summary>
/// An Activity Log Alert rule condition that is met by comparing the field and value of an Activity Log event.
/// This
/// condition must contain &apos;field&apos; and either &apos;equals&apos; or &apos;containsAny&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertStatusConditionAllOfAnyOf
{
    /// <summary>
    /// ContainsAny: The value of the event&apos;s field will be compared to the values in this array (case-insensitive) to determine
    /// if the condition is met.
    /// </summary>
    [JsonPropertyName("containsAny")]
    public IList<string>? ContainsAny { get; set; }

    /// <summary>
    /// Equals: The value of the event&apos;s field will be compared to this value (case-insensitive) to determine if the condition
    /// is met.
    /// </summary>
    [JsonPropertyName("equals")]
    public string? Equals { get; set; }

    /// <summary>
    /// Field: The name of the Activity Log event&apos;s field that this condition will examine.
    /// The possible values for this field are (case-insensitive): &apos;resourceId&apos;, &apos;category&apos;, &apos;caller&apos;, &apos;level&apos;, &apos;operationName&apos;,
    /// &apos;resourceGroup&apos;, &apos;resourceProvider&apos;, &apos;status&apos;, &apos;subStatus&apos;, &apos;resourceType&apos;, or anything beginning with &apos;properties&apos;.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

/// <summary>
/// An Activity Log Alert rule condition that is met when all its member conditions are met.
/// Each condition can be of one of
/// the following types:
/// __Important__: Each type has its unique subset of properties. Properties from different types
/// CANNOT exist in one condition.
/// * __Leaf Condition -__ must contain &apos;field&apos; and either &apos;equals&apos; or &apos;containsAny&apos;.
/// _Please note, &apos;anyOf&apos; should __not__ be set in a Leaf Condition._
/// * __AnyOf Condition -__ must contain __only__
/// &apos;anyOf&apos; (which is an array of Leaf Conditions).
/// _Please note, &apos;field&apos;, &apos;equals&apos; and &apos;containsAny&apos; should __not__ be
/// set in an AnyOf Condition._
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertStatusConditionAllOf
{
    /// <summary>AnyOf: An Activity Log Alert rule condition that is met when at least one of its member leaf conditions are met.</summary>
    [JsonPropertyName("anyOf")]
    public IList<V1api20201001ActivityLogAlertStatusConditionAllOfAnyOf>? AnyOf { get; set; }

    /// <summary>
    /// ContainsAny: The value of the event&apos;s field will be compared to the values in this array (case-insensitive) to determine
    /// if the condition is met.
    /// </summary>
    [JsonPropertyName("containsAny")]
    public IList<string>? ContainsAny { get; set; }

    /// <summary>
    /// Equals: The value of the event&apos;s field will be compared to this value (case-insensitive) to determine if the condition
    /// is met.
    /// </summary>
    [JsonPropertyName("equals")]
    public string? Equals { get; set; }

    /// <summary>
    /// Field: The name of the Activity Log event&apos;s field that this condition will examine.
    /// The possible values for this field are (case-insensitive): &apos;resourceId&apos;, &apos;category&apos;, &apos;caller&apos;, &apos;level&apos;, &apos;operationName&apos;,
    /// &apos;resourceGroup&apos;, &apos;resourceProvider&apos;, &apos;status&apos;, &apos;subStatus&apos;, &apos;resourceType&apos;, or anything beginning with &apos;properties&apos;.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

/// <summary>Condition: The condition that will cause this alert to activate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertStatusCondition
{
    /// <summary>AllOf: The list of Activity Log Alert rule conditions.</summary>
    [JsonPropertyName("allOf")]
    public IList<V1api20201001ActivityLogAlertStatusConditionAllOf>? AllOf { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201001ActivityLogAlertStatus
{
    /// <summary>Actions: The actions that will activate when the condition is met.</summary>
    [JsonPropertyName("actions")]
    public V1api20201001ActivityLogAlertStatusActions? Actions { get; set; }

    /// <summary>Condition: The condition that will cause this alert to activate.</summary>
    [JsonPropertyName("condition")]
    public V1api20201001ActivityLogAlertStatusCondition? Condition { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201001ActivityLogAlertStatusConditions>? Conditions { get; set; }

    /// <summary>Description: A description of this Activity Log Alert rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Enabled: Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then
    /// none of its actions will be activated.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Id: The resource Id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Location: The location of the resource. Azure Activity Log Alert rules are supported on Global, West Europe and North
    /// Europe regions.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Scopes: A list of resource IDs that will be used as prefixes. The alert will only apply to Activity Log events with
    /// resource IDs that fall under one of these prefixes. This list must include at least one item.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>Tags: The tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2020-10-01/activityLogAlerts_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201001ActivityLogAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201001ActivityLogAlertSpec?>, IStatus<V1api20201001ActivityLogAlertStatus?>
{
    public const string KubeApiVersion = "v1api20201001";
    public const string KubeKind = "ActivityLogAlert";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "activitylogalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20201001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ActivityLogAlert";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20201001ActivityLogAlertSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20201001ActivityLogAlertStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alertsmanagement.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /alertsmanagement/resource-manager/Microsoft.AlertsManagement/Legacy/stable/2021-04-01/SmartDetectorAlertRulesApi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.alertsManagement/smartDetectorAlertRules/{alertRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210401SmartDetectorAlertRuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20210401SmartDetectorAlertRule>
{
    public const string KubeApiVersion = "v1api20210401";
    public const string KubeKind = "SmartDetectorAlertRuleList";
    public const string KubeGroup = "alertsmanagement.azure.com";
    public const string KubePluralName = "smartdetectoralertrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alertsmanagement.azure.com/v1api20210401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SmartDetectorAlertRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210401SmartDetectorAlertRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210401SmartDetectorAlertRule> Items { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpecActionGroupsGroupReferences
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

/// <summary>ActionGroups: The alert rule actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpecActionGroups
{
    /// <summary>CustomEmailSubject: An optional custom email subject to use in email notifications.</summary>
    [JsonPropertyName("customEmailSubject")]
    public string? CustomEmailSubject { get; set; }

    /// <summary>CustomWebhookPayload: An optional custom web-hook payload to use in web-hook notifications.</summary>
    [JsonPropertyName("customWebhookPayload")]
    public string? CustomWebhookPayload { get; set; }

    /// <summary>GroupReferences: The Action Group resource IDs.</summary>
    [JsonPropertyName("groupReferences")]
    public required IList<V1api20210401SmartDetectorAlertRuleSpecActionGroupsGroupReferences> GroupReferences { get; set; }
}

/// <summary>Detector: The alert rule&apos;s detector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpecDetector
{
    /// <summary>Id: The detector id.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Parameters: The detector&apos;s parameters.&apos;</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, JsonNode>? Parameters { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210401SmartDetectorAlertRuleSpecOperatorSpecSecretExpressions
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
public partial class V1api20210401SmartDetectorAlertRuleSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210401SmartDetectorAlertRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210401SmartDetectorAlertRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpecScopeReferences
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

/// <summary>Severity: The alert rule severity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401SmartDetectorAlertRuleSpecSeverityEnum>))]
public enum V1api20210401SmartDetectorAlertRuleSpecSeverityEnum
{
    [EnumMember(Value = "Sev0"), JsonStringEnumMemberName("Sev0")]
    Sev0,
    [EnumMember(Value = "Sev1"), JsonStringEnumMemberName("Sev1")]
    Sev1,
    [EnumMember(Value = "Sev2"), JsonStringEnumMemberName("Sev2")]
    Sev2,
    [EnumMember(Value = "Sev3"), JsonStringEnumMemberName("Sev3")]
    Sev3,
    [EnumMember(Value = "Sev4"), JsonStringEnumMemberName("Sev4")]
    Sev4
}

/// <summary>State: The alert rule state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401SmartDetectorAlertRuleSpecStateEnum>))]
public enum V1api20210401SmartDetectorAlertRuleSpecStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Throttling: The alert rule throttling information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpecThrottling
{
    /// <summary>
    /// Duration: The required duration (in ISO8601 format) to wait before notifying on the alert rule again. The time
    /// granularity must be in minutes and minimum value is 0 minutes
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleSpec
{
    /// <summary>ActionGroups: The alert rule actions.</summary>
    [JsonPropertyName("actionGroups")]
    public required V1api20210401SmartDetectorAlertRuleSpecActionGroups ActionGroups { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Description: The alert rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Detector: The alert rule&apos;s detector.</summary>
    [JsonPropertyName("detector")]
    public required V1api20210401SmartDetectorAlertRuleSpecDetector Detector { get; set; }

    /// <summary>
    /// Frequency: The alert rule frequency in ISO8601 format. The time granularity must be in minutes and minimum value is 1
    /// minute, depending on the detector.
    /// </summary>
    [JsonPropertyName("frequency")]
    public required string Frequency { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210401SmartDetectorAlertRuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210401SmartDetectorAlertRuleSpecOwner Owner { get; set; }

    /// <summary>ScopeReferences: The alert rule resources scope.</summary>
    [JsonPropertyName("scopeReferences")]
    public required IList<V1api20210401SmartDetectorAlertRuleSpecScopeReferences> ScopeReferences { get; set; }

    /// <summary>Severity: The alert rule severity.</summary>
    [JsonPropertyName("severity")]
    public required V1api20210401SmartDetectorAlertRuleSpecSeverityEnum Severity { get; set; }

    /// <summary>State: The alert rule state.</summary>
    [JsonPropertyName("state")]
    public required V1api20210401SmartDetectorAlertRuleSpecStateEnum State { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throttling: The alert rule throttling information.</summary>
    [JsonPropertyName("throttling")]
    public V1api20210401SmartDetectorAlertRuleSpecThrottling? Throttling { get; set; }
}

/// <summary>ActionGroups: The alert rule actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleStatusActionGroups
{
    /// <summary>CustomEmailSubject: An optional custom email subject to use in email notifications.</summary>
    [JsonPropertyName("customEmailSubject")]
    public string? CustomEmailSubject { get; set; }

    /// <summary>CustomWebhookPayload: An optional custom web-hook payload to use in web-hook notifications.</summary>
    [JsonPropertyName("customWebhookPayload")]
    public string? CustomWebhookPayload { get; set; }

    /// <summary>GroupIds: The Action Group resource IDs.</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleStatusConditions
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

/// <summary>The detector parameter definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleStatusDetectorParameterDefinitions
{
    /// <summary>Description: The detector parameter description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The detector parameter display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>IsMandatory: A value indicating whether this detector parameter is mandatory.</summary>
    [JsonPropertyName("isMandatory")]
    public bool? IsMandatory { get; set; }

    /// <summary>Name: The detector parameter name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The detector parameter type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Detector: The alert rule&apos;s detector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleStatusDetector
{
    /// <summary>Description: The Smart Detector description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Id: The detector id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ImagePaths: The Smart Detector image path. By default this is not populated, unless it&apos;s specified in expandDetector</summary>
    [JsonPropertyName("imagePaths")]
    public IList<string>? ImagePaths { get; set; }

    /// <summary>Name: The Smart Detector name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ParameterDefinitions: The Smart Detector parameters definitions.&apos;</summary>
    [JsonPropertyName("parameterDefinitions")]
    public IList<V1api20210401SmartDetectorAlertRuleStatusDetectorParameterDefinitions>? ParameterDefinitions { get; set; }

    /// <summary>Parameters: The detector&apos;s parameters.&apos;</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, JsonNode>? Parameters { get; set; }

    /// <summary>SupportedCadences: The Smart Detector supported cadences.</summary>
    [JsonPropertyName("supportedCadences")]
    public IList<int>? SupportedCadences { get; set; }

    /// <summary>SupportedResourceTypes: The Smart Detector supported resource types.</summary>
    [JsonPropertyName("supportedResourceTypes")]
    public IList<string>? SupportedResourceTypes { get; set; }
}

/// <summary>Throttling: The alert rule throttling information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleStatusThrottling
{
    /// <summary>
    /// Duration: The required duration (in ISO8601 format) to wait before notifying on the alert rule again. The time
    /// granularity must be in minutes and minimum value is 0 minutes
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401SmartDetectorAlertRuleStatus
{
    /// <summary>ActionGroups: The alert rule actions.</summary>
    [JsonPropertyName("actionGroups")]
    public V1api20210401SmartDetectorAlertRuleStatusActionGroups? ActionGroups { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210401SmartDetectorAlertRuleStatusConditions>? Conditions { get; set; }

    /// <summary>Description: The alert rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Detector: The alert rule&apos;s detector.</summary>
    [JsonPropertyName("detector")]
    public V1api20210401SmartDetectorAlertRuleStatusDetector? Detector { get; set; }

    /// <summary>
    /// Frequency: The alert rule frequency in ISO8601 format. The time granularity must be in minutes and minimum value is 1
    /// minute, depending on the detector.
    /// </summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>Id: The resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Scope: The alert rule resources scope.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }

    /// <summary>Severity: The alert rule severity.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>State: The alert rule state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throttling: The alert rule throttling information.</summary>
    [JsonPropertyName("throttling")]
    public V1api20210401SmartDetectorAlertRuleStatusThrottling? Throttling { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /alertsmanagement/resource-manager/Microsoft.AlertsManagement/Legacy/stable/2021-04-01/SmartDetectorAlertRulesApi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.alertsManagement/smartDetectorAlertRules/{alertRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210401SmartDetectorAlertRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210401SmartDetectorAlertRuleSpec?>, IStatus<V1api20210401SmartDetectorAlertRuleStatus?>
{
    public const string KubeApiVersion = "v1api20210401";
    public const string KubeKind = "SmartDetectorAlertRule";
    public const string KubeGroup = "alertsmanagement.azure.com";
    public const string KubePluralName = "smartdetectoralertrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alertsmanagement.azure.com/v1api20210401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SmartDetectorAlertRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210401SmartDetectorAlertRuleSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210401SmartDetectorAlertRuleStatus? Status { get; set; }
}
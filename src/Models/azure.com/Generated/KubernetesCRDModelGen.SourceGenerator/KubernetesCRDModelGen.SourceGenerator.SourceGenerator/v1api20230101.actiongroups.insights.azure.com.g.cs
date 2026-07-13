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
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2023-01-01/actionGroups_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101ActionGroupList : IKubernetesObject<V1ListMeta>, IItems<V1api20230101ActionGroup>
{
    public const string KubeApiVersion = "v1api20230101";
    public const string KubeKind = "ActionGroupList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "actiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ActionGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230101ActionGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230101ActionGroup> Items { get; set; }
}

/// <summary>An arm role receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecArmRoleReceivers
{
    /// <summary>Name: The name of the arm role receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>RoleId: The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public required string RoleId { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>ServiceUriFromSecret: The URI where webhooks should be sent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecAutomationRunbookReceiversServiceUriFromSecret
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

/// <summary>WebhookResourceReference: The resource id for webhook linked to this runbook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecAutomationRunbookReceiversWebhookResourceReference
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

/// <summary>The Azure Automation Runbook notification receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecAutomationRunbookReceivers
{
    /// <summary>AutomationAccountId: The Azure automation account Id which holds this runbook and authenticate to Azure resource.</summary>
    [JsonPropertyName("automationAccountId")]
    public required string AutomationAccountId { get; set; }

    /// <summary>IsGlobalRunbook: Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public required bool IsGlobalRunbook { get; set; }

    /// <summary>Name: Indicates name of the webhook.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RunbookName: The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public required string RunbookName { get; set; }

    /// <summary>ServiceUri: The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>ServiceUriFromSecret: The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUriFromSecret")]
    public V1api20230101ActionGroupSpecAutomationRunbookReceiversServiceUriFromSecret? ServiceUriFromSecret { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>WebhookResourceReference: The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceReference")]
    public required V1api20230101ActionGroupSpecAutomationRunbookReceiversWebhookResourceReference WebhookResourceReference { get; set; }
}

/// <summary>The Azure mobile App push notification receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecAzureAppPushReceivers
{
    /// <summary>EmailAddress: The email address registered for the Azure mobile app.</summary>
    [JsonPropertyName("emailAddress")]
    public required string EmailAddress { get; set; }

    /// <summary>Name: The name of the Azure mobile app push receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>FunctionAppResourceReference: The azure resource id of the function app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecAzureFunctionReceiversFunctionAppResourceReference
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

/// <summary>An azure function receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecAzureFunctionReceivers
{
    /// <summary>FunctionAppResourceReference: The azure resource id of the function app.</summary>
    [JsonPropertyName("functionAppResourceReference")]
    public required V1api20230101ActionGroupSpecAzureFunctionReceiversFunctionAppResourceReference FunctionAppResourceReference { get; set; }

    /// <summary>FunctionName: The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public required string FunctionName { get; set; }

    /// <summary>HttpTriggerUrl: The http trigger url where http request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public required string HttpTriggerUrl { get; set; }

    /// <summary>Name: The name of the azure function receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>An email receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecEmailReceivers
{
    /// <summary>EmailAddress: The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public required string EmailAddress { get; set; }

    /// <summary>Name: The name of the email receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>An Event hub receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecEventHubReceivers
{
    /// <summary>EventHubName: The name of the specific Event Hub queue</summary>
    [JsonPropertyName("eventHubName")]
    public required string EventHubName { get; set; }

    /// <summary>EventHubNameSpace: The Event Hub namespace</summary>
    [JsonPropertyName("eventHubNameSpace")]
    public required string EventHubNameSpace { get; set; }

    /// <summary>Name: The name of the Event hub receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>SubscriptionId: The Id for the subscription containing this event hub</summary>
    [JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }

    /// <summary>TenantId: The tenant Id for the subscription containing this event hub</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>An Itsm receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecItsmReceivers
{
    /// <summary>ConnectionId: Unique identification of ITSM connection among multiple defined in above workspace.</summary>
    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; set; }

    /// <summary>Name: The name of the Itsm receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Region: Region in which workspace resides. Supported
    /// values:&apos;centralindia&apos;,&apos;japaneast&apos;,&apos;southeastasia&apos;,&apos;australiasoutheast&apos;,&apos;uksouth&apos;,&apos;westcentralus&apos;,&apos;canadacentral&apos;,&apos;eastus&apos;,&apos;westeurope&apos;
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// TicketConfiguration: JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of
    /// this blob as well.
    /// </summary>
    [JsonPropertyName("ticketConfiguration")]
    public required string TicketConfiguration { get; set; }

    /// <summary>WorkspaceId: OMS LA instance identifier.</summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
}

/// <summary>ResourceReference: The azure resource id of the logic app receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecLogicAppReceiversResourceReference
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

/// <summary>A logic app receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecLogicAppReceivers
{
    /// <summary>CallbackUrl: The callback url where http request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public required string CallbackUrl { get; set; }

    /// <summary>Name: The name of the logic app receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>ResourceReference: The azure resource id of the logic app receiver.</summary>
    [JsonPropertyName("resourceReference")]
    public required V1api20230101ActionGroupSpecLogicAppReceiversResourceReference ResourceReference { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230101ActionGroupSpecOperatorSpecSecretExpressions
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
public partial class V1api20230101ActionGroupSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230101ActionGroupSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230101ActionGroupSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An SMS receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecSmsReceivers
{
    /// <summary>CountryCode: The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    /// <summary>Name: The name of the SMS receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>PhoneNumber: The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public required string PhoneNumber { get; set; }
}

/// <summary>A voice receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecVoiceReceivers
{
    /// <summary>CountryCode: The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    /// <summary>Name: The name of the voice receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>PhoneNumber: The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public required string PhoneNumber { get; set; }
}

/// <summary>ServiceUriFromSecret: The URI where webhooks should be sent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecWebhookReceiversServiceUriFromSecret
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

/// <summary>A webhook receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpecWebhookReceivers
{
    /// <summary>IdentifierUri: Indicates the identifier uri for aad auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>Name: The name of the webhook receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>ObjectId: Indicates the webhook app object Id for aad auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ServiceUri: The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>ServiceUriFromSecret: The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUriFromSecret")]
    public V1api20230101ActionGroupSpecWebhookReceiversServiceUriFromSecret? ServiceUriFromSecret { get; set; }

    /// <summary>TenantId: Indicates the tenant id for aad auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>UseAadAuth: Indicates whether or not use AAD authentication.</summary>
    [JsonPropertyName("useAadAuth")]
    public bool? UseAadAuth { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupSpec
{
    /// <summary>
    /// ArmRoleReceivers: The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only
    /// built-in roles are supported.
    /// </summary>
    [JsonPropertyName("armRoleReceivers")]
    public IList<V1api20230101ActionGroupSpecArmRoleReceivers>? ArmRoleReceivers { get; set; }

    /// <summary>AutomationRunbookReceivers: The list of AutomationRunbook receivers that are part of this action group.</summary>
    [JsonPropertyName("automationRunbookReceivers")]
    public IList<V1api20230101ActionGroupSpecAutomationRunbookReceivers>? AutomationRunbookReceivers { get; set; }

    /// <summary>AzureAppPushReceivers: The list of AzureAppPush receivers that are part of this action group.</summary>
    [JsonPropertyName("azureAppPushReceivers")]
    public IList<V1api20230101ActionGroupSpecAzureAppPushReceivers>? AzureAppPushReceivers { get; set; }

    /// <summary>AzureFunctionReceivers: The list of azure function receivers that are part of this action group.</summary>
    [JsonPropertyName("azureFunctionReceivers")]
    public IList<V1api20230101ActionGroupSpecAzureFunctionReceivers>? AzureFunctionReceivers { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>EmailReceivers: The list of email receivers that are part of this action group.</summary>
    [JsonPropertyName("emailReceivers")]
    public IList<V1api20230101ActionGroupSpecEmailReceivers>? EmailReceivers { get; set; }

    /// <summary>
    /// Enabled: Indicates whether this action group is enabled. If an action group is not enabled, then none of its receivers
    /// will receive communications.
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>EventHubReceivers: The list of event hub receivers that are part of this action group.</summary>
    [JsonPropertyName("eventHubReceivers")]
    public IList<V1api20230101ActionGroupSpecEventHubReceivers>? EventHubReceivers { get; set; }

    /// <summary>GroupShortName: The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("groupShortName")]
    public required string GroupShortName { get; set; }

    /// <summary>ItsmReceivers: The list of ITSM receivers that are part of this action group.</summary>
    [JsonPropertyName("itsmReceivers")]
    public IList<V1api20230101ActionGroupSpecItsmReceivers>? ItsmReceivers { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>LogicAppReceivers: The list of logic app receivers that are part of this action group.</summary>
    [JsonPropertyName("logicAppReceivers")]
    public IList<V1api20230101ActionGroupSpecLogicAppReceivers>? LogicAppReceivers { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230101ActionGroupSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230101ActionGroupSpecOwner Owner { get; set; }

    /// <summary>SmsReceivers: The list of SMS receivers that are part of this action group.</summary>
    [JsonPropertyName("smsReceivers")]
    public IList<V1api20230101ActionGroupSpecSmsReceivers>? SmsReceivers { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VoiceReceivers: The list of voice receivers that are part of this action group.</summary>
    [JsonPropertyName("voiceReceivers")]
    public IList<V1api20230101ActionGroupSpecVoiceReceivers>? VoiceReceivers { get; set; }

    /// <summary>WebhookReceivers: The list of webhook receivers that are part of this action group.</summary>
    [JsonPropertyName("webhookReceivers")]
    public IList<V1api20230101ActionGroupSpecWebhookReceivers>? WebhookReceivers { get; set; }
}

/// <summary>An arm role receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusArmRoleReceivers
{
    /// <summary>Name: The name of the arm role receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RoleId: The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>The Azure Automation Runbook notification receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusAutomationRunbookReceivers
{
    /// <summary>AutomationAccountId: The Azure automation account Id which holds this runbook and authenticate to Azure resource.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>IsGlobalRunbook: Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary>Name: Indicates name of the webhook.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RunbookName: The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>WebhookResourceId: The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

/// <summary>The Azure mobile App push notification receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusAzureAppPushReceivers
{
    /// <summary>EmailAddress: The email address registered for the Azure mobile app.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>Name: The name of the Azure mobile app push receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An azure function receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusAzureFunctionReceivers
{
    /// <summary>FunctionAppResourceId: The azure resource id of the function app.</summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary>FunctionName: The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>HttpTriggerUrl: The http trigger url where http request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary>Name: The name of the azure function receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusConditions
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

/// <summary>An email receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusEmailReceivers
{
    /// <summary>EmailAddress: The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>Name: The name of the email receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Status: The receiver status of the e-mail.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>An Event hub receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusEventHubReceivers
{
    /// <summary>EventHubName: The name of the specific Event Hub queue</summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary>EventHubNameSpace: The Event Hub namespace</summary>
    [JsonPropertyName("eventHubNameSpace")]
    public string? EventHubNameSpace { get; set; }

    /// <summary>Name: The name of the Event hub receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SubscriptionId: The Id for the subscription containing this event hub</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>TenantId: The tenant Id for the subscription containing this event hub</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>An Itsm receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusItsmReceivers
{
    /// <summary>ConnectionId: Unique identification of ITSM connection among multiple defined in above workspace.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Name: The name of the Itsm receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region: Region in which workspace resides. Supported
    /// values:&apos;centralindia&apos;,&apos;japaneast&apos;,&apos;southeastasia&apos;,&apos;australiasoutheast&apos;,&apos;uksouth&apos;,&apos;westcentralus&apos;,&apos;canadacentral&apos;,&apos;eastus&apos;,&apos;westeurope&apos;
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// TicketConfiguration: JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of
    /// this blob as well.
    /// </summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary>WorkspaceId: OMS LA instance identifier.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>A logic app receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusLogicAppReceivers
{
    /// <summary>CallbackUrl: The callback url where http request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>Name: The name of the logic app receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceId: The azure resource id of the logic app receiver.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>An SMS receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusSmsReceivers
{
    /// <summary>CountryCode: The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>Name: The name of the SMS receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PhoneNumber: The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }

    /// <summary>Status: The status of the receiver.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A voice receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusVoiceReceivers
{
    /// <summary>CountryCode: The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>Name: The name of the voice receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PhoneNumber: The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A webhook receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatusWebhookReceivers
{
    /// <summary>IdentifierUri: Indicates the identifier uri for aad auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>Name: The name of the webhook receiver. Names must be unique across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObjectId: Indicates the webhook app object Id for aad auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>TenantId: Indicates the tenant id for aad auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>UseAadAuth: Indicates whether or not use AAD authentication.</summary>
    [JsonPropertyName("useAadAuth")]
    public bool? UseAadAuth { get; set; }

    /// <summary>UseCommonAlertSchema: Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>An action group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101ActionGroupStatus
{
    /// <summary>
    /// ArmRoleReceivers: The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only
    /// built-in roles are supported.
    /// </summary>
    [JsonPropertyName("armRoleReceivers")]
    public IList<V1api20230101ActionGroupStatusArmRoleReceivers>? ArmRoleReceivers { get; set; }

    /// <summary>AutomationRunbookReceivers: The list of AutomationRunbook receivers that are part of this action group.</summary>
    [JsonPropertyName("automationRunbookReceivers")]
    public IList<V1api20230101ActionGroupStatusAutomationRunbookReceivers>? AutomationRunbookReceivers { get; set; }

    /// <summary>AzureAppPushReceivers: The list of AzureAppPush receivers that are part of this action group.</summary>
    [JsonPropertyName("azureAppPushReceivers")]
    public IList<V1api20230101ActionGroupStatusAzureAppPushReceivers>? AzureAppPushReceivers { get; set; }

    /// <summary>AzureFunctionReceivers: The list of azure function receivers that are part of this action group.</summary>
    [JsonPropertyName("azureFunctionReceivers")]
    public IList<V1api20230101ActionGroupStatusAzureFunctionReceivers>? AzureFunctionReceivers { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101ActionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>EmailReceivers: The list of email receivers that are part of this action group.</summary>
    [JsonPropertyName("emailReceivers")]
    public IList<V1api20230101ActionGroupStatusEmailReceivers>? EmailReceivers { get; set; }

    /// <summary>
    /// Enabled: Indicates whether this action group is enabled. If an action group is not enabled, then none of its receivers
    /// will receive communications.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>EventHubReceivers: The list of event hub receivers that are part of this action group.</summary>
    [JsonPropertyName("eventHubReceivers")]
    public IList<V1api20230101ActionGroupStatusEventHubReceivers>? EventHubReceivers { get; set; }

    /// <summary>GroupShortName: The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("groupShortName")]
    public string? GroupShortName { get; set; }

    /// <summary>Id: Azure resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ItsmReceivers: The list of ITSM receivers that are part of this action group.</summary>
    [JsonPropertyName("itsmReceivers")]
    public IList<V1api20230101ActionGroupStatusItsmReceivers>? ItsmReceivers { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>LogicAppReceivers: The list of logic app receivers that are part of this action group.</summary>
    [JsonPropertyName("logicAppReceivers")]
    public IList<V1api20230101ActionGroupStatusLogicAppReceivers>? LogicAppReceivers { get; set; }

    /// <summary>Name: Azure resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SmsReceivers: The list of SMS receivers that are part of this action group.</summary>
    [JsonPropertyName("smsReceivers")]
    public IList<V1api20230101ActionGroupStatusSmsReceivers>? SmsReceivers { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Azure resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VoiceReceivers: The list of voice receivers that are part of this action group.</summary>
    [JsonPropertyName("voiceReceivers")]
    public IList<V1api20230101ActionGroupStatusVoiceReceivers>? VoiceReceivers { get; set; }

    /// <summary>WebhookReceivers: The list of webhook receivers that are part of this action group.</summary>
    [JsonPropertyName("webhookReceivers")]
    public IList<V1api20230101ActionGroupStatusWebhookReceivers>? WebhookReceivers { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2023-01-01/actionGroups_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101ActionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101ActionGroupSpec?>, IStatus<V1api20230101ActionGroupStatus?>
{
    public const string KubeApiVersion = "v1api20230101";
    public const string KubeKind = "ActionGroup";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "actiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ActionGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230101ActionGroupSpec? Spec { get; set; }

    /// <summary>An action group resource.</summary>
    [JsonPropertyName("status")]
    public V1api20230101ActionGroupStatus? Status { get; set; }
}
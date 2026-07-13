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
/// - Generated from: /kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2023-05-01/extensions.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501ExtensionList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501Extension>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "ExtensionList";
    public const string KubeGroup = "kubernetesconfiguration.azure.com";
    public const string KubePluralName = "extensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetesconfiguration.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExtensionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230501Extension objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230501Extension> Items { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501ExtensionSpecAksAssignedIdentityTypeEnum>))]
public enum V1api20230501ExtensionSpecAksAssignedIdentityTypeEnum
{
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>AksAssignedIdentity: Identity of the Extension resource in an AKS cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecAksAssignedIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public V1api20230501ExtensionSpecAksAssignedIdentityTypeEnum? Type { get; set; }
}

/// <summary>
/// ConfigurationProtectedSettings: Configuration settings that are sensitive, as name-value pairs for configuring this
/// extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecConfigurationProtectedSettings
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501ExtensionSpecIdentityTypeEnum>))]
public enum V1api20230501ExtensionSpecIdentityTypeEnum
{
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned
}

/// <summary>Identity: Identity of the Extension resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public V1api20230501ExtensionSpecIdentityTypeEnum? Type { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecOperatorSpecConfigMapExpressions
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

/// <summary>PrincipalId: indicates where the PrincipalId config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecOperatorSpecConfigMapsPrincipalId
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecOperatorSpecConfigMaps
{
    /// <summary>PrincipalId: indicates where the PrincipalId config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("principalId")]
    public V1api20230501ExtensionSpecOperatorSpecConfigMapsPrincipalId? PrincipalId { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecOperatorSpecSecretExpressions
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
public partial class V1api20230501ExtensionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501ExtensionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20230501ExtensionSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501ExtensionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecOwner
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

/// <summary>Plan: The plan information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecPlan
{
    /// <summary>Name: A user defined name of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Product: The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the
    /// artifact at the time of Data Market onboarding.
    /// </summary>
    [JsonPropertyName("product")]
    public required string Product { get; set; }

    /// <summary>PromotionCode: A publisher provided promotion code as provisioned in Data Market for the said product/artifact.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Publisher: The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
    [JsonPropertyName("publisher")]
    public required string Publisher { get; set; }

    /// <summary>Version: The version of the desired product/artifact.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Cluster: Specifies that the scope of the extension is Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecScopeCluster
{
    /// <summary>
    /// ReleaseNamespace: Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this
    /// namespace does not exist, it will be created
    /// </summary>
    [JsonPropertyName("releaseNamespace")]
    public string? ReleaseNamespace { get; set; }
}

/// <summary>Namespace: Specifies that the scope of the extension is Namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecScopeNamespace
{
    /// <summary>
    /// TargetNamespace: Namespace where the extension will be created for an Namespace scoped extension.  If this namespace
    /// does not exist, it will be created
    /// </summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }
}

/// <summary>Scope: Scope at which the extension is installed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecScope
{
    /// <summary>Cluster: Specifies that the scope of the extension is Cluster</summary>
    [JsonPropertyName("cluster")]
    public V1api20230501ExtensionSpecScopeCluster? Cluster { get; set; }

    /// <summary>Namespace: Specifies that the scope of the extension is Namespace</summary>
    [JsonPropertyName("namespace")]
    public V1api20230501ExtensionSpecScopeNamespace? Namespace { get; set; }
}

/// <summary>CreatedByType: The type of identity that created the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501ExtensionSpecSystemDataCreatedByTypeEnum>))]
public enum V1api20230501ExtensionSpecSystemDataCreatedByTypeEnum
{
    [EnumMember(Value = "Application"), JsonStringEnumMemberName("Application")]
    Application,
    [EnumMember(Value = "Key"), JsonStringEnumMemberName("Key")]
    Key,
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501ExtensionSpecSystemDataLastModifiedByTypeEnum>))]
public enum V1api20230501ExtensionSpecSystemDataLastModifiedByTypeEnum
{
    [EnumMember(Value = "Application"), JsonStringEnumMemberName("Application")]
    Application,
    [EnumMember(Value = "Key"), JsonStringEnumMemberName("Key")]
    Key,
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>
/// SystemData: Top level metadata
/// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpecSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public V1api20230501ExtensionSpecSystemDataCreatedByTypeEnum? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public V1api20230501ExtensionSpecSystemDataLastModifiedByTypeEnum? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionSpec
{
    /// <summary>AksAssignedIdentity: Identity of the Extension resource in an AKS cluster</summary>
    [JsonPropertyName("aksAssignedIdentity")]
    public V1api20230501ExtensionSpecAksAssignedIdentity? AksAssignedIdentity { get; set; }

    /// <summary>AutoUpgradeMinorVersion: Flag to note if this extension participates in auto upgrade of minor version, or not.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// ConfigurationProtectedSettings: Configuration settings that are sensitive, as name-value pairs for configuring this
    /// extension.
    /// </summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public V1api20230501ExtensionSpecConfigurationProtectedSettings? ConfigurationProtectedSettings { get; set; }

    /// <summary>ConfigurationSettings: Configuration settings, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationSettings")]
    public IDictionary<string, string>? ConfigurationSettings { get; set; }

    /// <summary>
    /// ExtensionType: Type of the Extension, of which this resource is an instance of.  It must be one of the Extension Types
    /// registered with Microsoft.KubernetesConfiguration by the Extension publisher.
    /// </summary>
    [JsonPropertyName("extensionType")]
    public string? ExtensionType { get; set; }

    /// <summary>Identity: Identity of the Extension resource</summary>
    [JsonPropertyName("identity")]
    public V1api20230501ExtensionSpecIdentity? Identity { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501ExtensionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230501ExtensionSpecOwner Owner { get; set; }

    /// <summary>Plan: The plan information.</summary>
    [JsonPropertyName("plan")]
    public V1api20230501ExtensionSpecPlan? Plan { get; set; }

    /// <summary>
    /// ReleaseTrain: ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if
    /// autoUpgradeMinorVersion is &apos;true&apos;.
    /// </summary>
    [JsonPropertyName("releaseTrain")]
    public string? ReleaseTrain { get; set; }

    /// <summary>Scope: Scope at which the extension is installed.</summary>
    [JsonPropertyName("scope")]
    public V1api20230501ExtensionSpecScope? Scope { get; set; }

    /// <summary>
    /// SystemData: Top level metadata
    /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20230501ExtensionSpecSystemData? SystemData { get; set; }

    /// <summary>
    /// Version: User-specified version of the extension for this extension to &apos;pin&apos;. To use &apos;version&apos;, autoUpgradeMinorVersion
    /// must be &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>AksAssignedIdentity: Identity of the Extension resource in an AKS cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusAksAssignedIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusConditions
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

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusErrorInfoAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusErrorInfoDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusErrorInfoDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230501ExtensionStatusErrorInfoDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>ErrorInfo: Error information from the Agent - e.g. errors during installation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusErrorInfo
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230501ExtensionStatusErrorInfoAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20230501ExtensionStatusErrorInfoDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Identity: Identity of the Extension resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Plan: The plan information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusPlan
{
    /// <summary>Name: A user defined name of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Product: The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the
    /// artifact at the time of Data Market onboarding.
    /// </summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>PromotionCode: A publisher provided promotion code as provisioned in Data Market for the said product/artifact.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Publisher: The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Version: The version of the desired product/artifact.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Cluster: Specifies that the scope of the extension is Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusScopeCluster
{
    /// <summary>
    /// ReleaseNamespace: Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this
    /// namespace does not exist, it will be created
    /// </summary>
    [JsonPropertyName("releaseNamespace")]
    public string? ReleaseNamespace { get; set; }
}

/// <summary>Namespace: Specifies that the scope of the extension is Namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusScopeNamespace
{
    /// <summary>
    /// TargetNamespace: Namespace where the extension will be created for an Namespace scoped extension.  If this namespace
    /// does not exist, it will be created
    /// </summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }
}

/// <summary>Scope: Scope at which the extension is installed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusScope
{
    /// <summary>Cluster: Specifies that the scope of the extension is Cluster</summary>
    [JsonPropertyName("cluster")]
    public V1api20230501ExtensionStatusScopeCluster? Cluster { get; set; }

    /// <summary>Namespace: Specifies that the scope of the extension is Namespace</summary>
    [JsonPropertyName("namespace")]
    public V1api20230501ExtensionStatusScopeNamespace? Namespace { get; set; }
}

/// <summary>Status from the extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusStatuses
{
    /// <summary>Code: Status code provided by the Extension</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>DisplayStatus: Short description of status of the extension.</summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary>Level: Level of the status.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Message: Detailed message of the status from the Extension.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Time: DateLiteral (per ISO8601) noting the time of installation status.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>
/// SystemData: Top level metadata
/// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>The Extension object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501ExtensionStatus
{
    /// <summary>AksAssignedIdentity: Identity of the Extension resource in an AKS cluster</summary>
    [JsonPropertyName("aksAssignedIdentity")]
    public V1api20230501ExtensionStatusAksAssignedIdentity? AksAssignedIdentity { get; set; }

    /// <summary>AutoUpgradeMinorVersion: Flag to note if this extension participates in auto upgrade of minor version, or not.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501ExtensionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ConfigurationProtectedSettings: Configuration settings that are sensitive, as name-value pairs for configuring this
    /// extension.
    /// </summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public IDictionary<string, string>? ConfigurationProtectedSettings { get; set; }

    /// <summary>ConfigurationSettings: Configuration settings, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationSettings")]
    public IDictionary<string, string>? ConfigurationSettings { get; set; }

    /// <summary>CurrentVersion: Currently installed version of the extension.</summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>CustomLocationSettings: Custom Location settings properties.</summary>
    [JsonPropertyName("customLocationSettings")]
    public IDictionary<string, string>? CustomLocationSettings { get; set; }

    /// <summary>ErrorInfo: Error information from the Agent - e.g. errors during installation.</summary>
    [JsonPropertyName("errorInfo")]
    public V1api20230501ExtensionStatusErrorInfo? ErrorInfo { get; set; }

    /// <summary>
    /// ExtensionType: Type of the Extension, of which this resource is an instance of.  It must be one of the Extension Types
    /// registered with Microsoft.KubernetesConfiguration by the Extension publisher.
    /// </summary>
    [JsonPropertyName("extensionType")]
    public string? ExtensionType { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity of the Extension resource</summary>
    [JsonPropertyName("identity")]
    public V1api20230501ExtensionStatusIdentity? Identity { get; set; }

    /// <summary>IsSystemExtension: Flag to note if this extension is a system extension</summary>
    [JsonPropertyName("isSystemExtension")]
    public bool? IsSystemExtension { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PackageUri: Uri of the Helm package</summary>
    [JsonPropertyName("packageUri")]
    public string? PackageUri { get; set; }

    /// <summary>Plan: The plan information.</summary>
    [JsonPropertyName("plan")]
    public V1api20230501ExtensionStatusPlan? Plan { get; set; }

    /// <summary>ProvisioningState: Status of installation of this extension.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// ReleaseTrain: ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if
    /// autoUpgradeMinorVersion is &apos;true&apos;.
    /// </summary>
    [JsonPropertyName("releaseTrain")]
    public string? ReleaseTrain { get; set; }

    /// <summary>Scope: Scope at which the extension is installed.</summary>
    [JsonPropertyName("scope")]
    public V1api20230501ExtensionStatusScope? Scope { get; set; }

    /// <summary>Statuses: Status from this extension.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20230501ExtensionStatusStatuses>? Statuses { get; set; }

    /// <summary>
    /// SystemData: Top level metadata
    /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20230501ExtensionStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Version: User-specified version of the extension for this extension to &apos;pin&apos;. To use &apos;version&apos;, autoUpgradeMinorVersion
    /// must be &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2023-05-01/extensions.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501Extension : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501ExtensionSpec?>, IStatus<V1api20230501ExtensionStatus?>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "Extension";
    public const string KubeGroup = "kubernetesconfiguration.azure.com";
    public const string KubePluralName = "extensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetesconfiguration.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Extension";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230501ExtensionSpec? Spec { get; set; }

    /// <summary>The Extension object.</summary>
    [JsonPropertyName("status")]
    public V1api20230501ExtensionStatus? Status { get; set; }
}
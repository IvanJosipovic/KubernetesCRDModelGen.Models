#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.mosaic.databricks.m.crossplane.io;
/// <summary>VectorSearchEndpoint is the Schema for the VectorSearchEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VectorSearchEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VectorSearchEndpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VectorSearchEndpointList";
    public const string KubeGroup = "mosaic.databricks.m.crossplane.io";
    public const string KubePluralName = "vectorsearchendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mosaic.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1VectorSearchEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1VectorSearchEndpoint> Items { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointSpecForProviderScalingInfo
{
    [JsonPropertyName("requestedMinQps")]
    public double? RequestedMinQps { get; set; }

    /// <summary>Current state of the endpoint. Currently following values are supported: PROVISIONING, ONLINE, and OFFLINE.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointSpecForProvider
{
    /// <summary>The Budget Policy ID set for this resource.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Type of Mosaic AI Vector Search Endpoint.  Currently only accepting single value: STANDARD (See documentation for the list of currently supported values). (Change leads to recreation of the resource).</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Name of the Mosaic AI Vector Search Endpoint to create. (Change leads to recreation of the resource).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1VectorSearchEndpointSpecForProviderProviderConfig? ProviderConfig { get; set; }

    [JsonPropertyName("scalingInfo")]
    public V1beta1VectorSearchEndpointSpecForProviderScalingInfo? ScalingInfo { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointSpecInitProviderScalingInfo
{
    [JsonPropertyName("requestedMinQps")]
    public double? RequestedMinQps { get; set; }

    /// <summary>Current state of the endpoint. Currently following values are supported: PROVISIONING, ONLINE, and OFFLINE.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
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
public partial class V1beta1VectorSearchEndpointSpecInitProvider
{
    /// <summary>The Budget Policy ID set for this resource.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Type of Mosaic AI Vector Search Endpoint.  Currently only accepting single value: STANDARD (See documentation for the list of currently supported values). (Change leads to recreation of the resource).</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Name of the Mosaic AI Vector Search Endpoint to create. (Change leads to recreation of the resource).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1VectorSearchEndpointSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    [JsonPropertyName("scalingInfo")]
    public V1beta1VectorSearchEndpointSpecInitProviderScalingInfo? ScalingInfo { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchEndpointSpecManagementPoliciesEnum>))]
public enum V1beta1VectorSearchEndpointSpecManagementPoliciesEnum
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
public partial class V1beta1VectorSearchEndpointSpecProviderConfigRef
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
public partial class V1beta1VectorSearchEndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>VectorSearchEndpointSpec defines the desired state of VectorSearchEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1VectorSearchEndpointSpecForProvider ForProvider { get; set; }

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
    public V1beta1VectorSearchEndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VectorSearchEndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VectorSearchEndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VectorSearchEndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointStatusAtProviderEndpointStatus
{
    /// <summary>Additional status message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Current state of the endpoint. Currently following values are supported: PROVISIONING, ONLINE, and OFFLINE.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointStatusAtProviderScalingInfo
{
    [JsonPropertyName("requestedMinQps")]
    public double? RequestedMinQps { get; set; }

    /// <summary>Current state of the endpoint. Currently following values are supported: PROVISIONING, ONLINE, and OFFLINE.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointStatusAtProvider
{
    /// <summary>The Budget Policy ID set for this resource.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Timestamp of endpoint creation (milliseconds).</summary>
    [JsonPropertyName("creationTimestamp")]
    public double? CreationTimestamp { get; set; }

    /// <summary>Creator of the endpoint.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>The effective budget policy ID.</summary>
    [JsonPropertyName("effectiveBudgetPolicyId")]
    public string? EffectiveBudgetPolicyId { get; set; }

    /// <summary>Unique internal identifier of the endpoint (UUID).</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>Object describing the current status of the endpoint consisting of the following fields:</summary>
    [JsonPropertyName("endpointStatus")]
    public IList<V1beta1VectorSearchEndpointStatusAtProviderEndpointStatus>? EndpointStatus { get; set; }

    /// <summary>Type of Mosaic AI Vector Search Endpoint.  Currently only accepting single value: STANDARD (See documentation for the list of currently supported values). (Change leads to recreation of the resource).</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>The same as the name of the endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Timestamp of the last update to the endpoint (milliseconds).</summary>
    [JsonPropertyName("lastUpdatedTimestamp")]
    public double? LastUpdatedTimestamp { get; set; }

    /// <summary>User who last updated the endpoint.</summary>
    [JsonPropertyName("lastUpdatedUser")]
    public string? LastUpdatedUser { get; set; }

    /// <summary>Name of the Mosaic AI Vector Search Endpoint to create. (Change leads to recreation of the resource).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Number of indexes on the endpoint.</summary>
    [JsonPropertyName("numIndexes")]
    public double? NumIndexes { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1VectorSearchEndpointStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    [JsonPropertyName("scalingInfo")]
    public V1beta1VectorSearchEndpointStatusAtProviderScalingInfo? ScalingInfo { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointStatusConditions
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

/// <summary>VectorSearchEndpointStatus defines the observed state of VectorSearchEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchEndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1VectorSearchEndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VectorSearchEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VectorSearchEndpoint is the Schema for the VectorSearchEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VectorSearchEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VectorSearchEndpointSpec>, IStatus<V1beta1VectorSearchEndpointStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VectorSearchEndpoint";
    public const string KubeGroup = "mosaic.databricks.m.crossplane.io";
    public const string KubePluralName = "vectorsearchendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mosaic.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VectorSearchEndpointSpec defines the desired state of VectorSearchEndpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta1VectorSearchEndpointSpec Spec { get; set; }

    /// <summary>VectorSearchEndpointStatus defines the observed state of VectorSearchEndpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1VectorSearchEndpointStatus? Status { get; set; }
}
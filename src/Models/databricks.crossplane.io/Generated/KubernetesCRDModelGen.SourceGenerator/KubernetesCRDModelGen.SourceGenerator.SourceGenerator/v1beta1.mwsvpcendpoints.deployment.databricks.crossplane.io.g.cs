#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.crossplane.io;
/// <summary>MwsVPCEndpoint is the Schema for the MwsVPCEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MwsVPCEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MwsVPCEndpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MwsVPCEndpointList";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsvpcendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsVPCEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MwsVPCEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MwsVPCEndpoint> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsVPCEndpointSpecDeletionPolicyEnum>))]
public enum V1beta1MwsVPCEndpointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>(GCP only) a block consists of Google Cloud specific information for this PSC endpoint. It has the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointSpecForProviderGcpVpcEndpointInfo
{
    /// <summary>Region of the PSC endpoint.</summary>
    [JsonPropertyName("endpointRegion")]
    public string? EndpointRegion { get; set; }

    /// <summary>The Google Cloud project ID of the VPC network where the PSC connection resides.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The unique ID of this PSC connection.</summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>The name of the PSC endpoint in the Google Cloud project.</summary>
    [JsonPropertyName("pscEndpointName")]
    public string? PscEndpointName { get; set; }

    /// <summary>The service attachment this PSC connection connects to.</summary>
    [JsonPropertyName("serviceAttachmentId")]
    public string? ServiceAttachmentId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointSpecForProvider
{
    /// <summary>Account Id that could be found in the Accounts Console for AWS or GCP</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Account Id that could be found in the Accounts Console for AWS or GCP</summary>
    [JsonPropertyName("awsAccountId")]
    public string? AwsAccountId { get; set; }

    /// <summary>(AWS Only) The ID of the Databricks endpoint service that this VPC endpoint is connected to. Please find the list of endpoint service IDs for each supported region in the Databricks PrivateLink documentation</summary>
    [JsonPropertyName("awsEndpointServiceId")]
    public string? AwsEndpointServiceId { get; set; }

    /// <summary>(AWS only) ID of configured aws_vpc_endpoint</summary>
    [JsonPropertyName("awsVpcEndpointId")]
    public string? AwsVpcEndpointId { get; set; }

    /// <summary>(GCP only) a block consists of Google Cloud specific information for this PSC endpoint. It has the following fields:</summary>
    [JsonPropertyName("gcpVpcEndpointInfo")]
    public V1beta1MwsVPCEndpointSpecForProviderGcpVpcEndpointInfo? GcpVpcEndpointInfo { get; set; }

    /// <summary>(AWS only) Region of AWS VPC</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>(AWS Only) State of VPC Endpoint</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("useCase")]
    public string? UseCase { get; set; }

    /// <summary>Canonical unique identifier of VPC Endpoint in Databricks Account</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Name of VPC Endpoint in Databricks Account</summary>
    [JsonPropertyName("vpcEndpointName")]
    public string? VpcEndpointName { get; set; }
}

/// <summary>(GCP only) a block consists of Google Cloud specific information for this PSC endpoint. It has the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointSpecInitProviderGcpVpcEndpointInfo
{
    /// <summary>Region of the PSC endpoint.</summary>
    [JsonPropertyName("endpointRegion")]
    public string? EndpointRegion { get; set; }

    /// <summary>The Google Cloud project ID of the VPC network where the PSC connection resides.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The unique ID of this PSC connection.</summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>The name of the PSC endpoint in the Google Cloud project.</summary>
    [JsonPropertyName("pscEndpointName")]
    public string? PscEndpointName { get; set; }

    /// <summary>The service attachment this PSC connection connects to.</summary>
    [JsonPropertyName("serviceAttachmentId")]
    public string? ServiceAttachmentId { get; set; }
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
public partial class V1beta1MwsVPCEndpointSpecInitProvider
{
    /// <summary>Account Id that could be found in the Accounts Console for AWS or GCP</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Account Id that could be found in the Accounts Console for AWS or GCP</summary>
    [JsonPropertyName("awsAccountId")]
    public string? AwsAccountId { get; set; }

    /// <summary>(AWS Only) The ID of the Databricks endpoint service that this VPC endpoint is connected to. Please find the list of endpoint service IDs for each supported region in the Databricks PrivateLink documentation</summary>
    [JsonPropertyName("awsEndpointServiceId")]
    public string? AwsEndpointServiceId { get; set; }

    /// <summary>(AWS only) ID of configured aws_vpc_endpoint</summary>
    [JsonPropertyName("awsVpcEndpointId")]
    public string? AwsVpcEndpointId { get; set; }

    /// <summary>(GCP only) a block consists of Google Cloud specific information for this PSC endpoint. It has the following fields:</summary>
    [JsonPropertyName("gcpVpcEndpointInfo")]
    public V1beta1MwsVPCEndpointSpecInitProviderGcpVpcEndpointInfo? GcpVpcEndpointInfo { get; set; }

    /// <summary>(AWS only) Region of AWS VPC</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>(AWS Only) State of VPC Endpoint</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("useCase")]
    public string? UseCase { get; set; }

    /// <summary>Canonical unique identifier of VPC Endpoint in Databricks Account</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Name of VPC Endpoint in Databricks Account</summary>
    [JsonPropertyName("vpcEndpointName")]
    public string? VpcEndpointName { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsVPCEndpointSpecManagementPoliciesEnum>))]
public enum V1beta1MwsVPCEndpointSpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsVPCEndpointSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1MwsVPCEndpointSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsVPCEndpointSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1MwsVPCEndpointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsVPCEndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsVPCEndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MwsVPCEndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MwsVPCEndpointSpec defines the desired state of MwsVPCEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1MwsVPCEndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1MwsVPCEndpointSpecForProvider ForProvider { get; set; }

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
    public V1beta1MwsVPCEndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MwsVPCEndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MwsVPCEndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MwsVPCEndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>(GCP only) a block consists of Google Cloud specific information for this PSC endpoint. It has the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointStatusAtProviderGcpVpcEndpointInfo
{
    /// <summary>Region of the PSC endpoint.</summary>
    [JsonPropertyName("endpointRegion")]
    public string? EndpointRegion { get; set; }

    /// <summary>The Google Cloud project ID of the VPC network where the PSC connection resides.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The unique ID of this PSC connection.</summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>The name of the PSC endpoint in the Google Cloud project.</summary>
    [JsonPropertyName("pscEndpointName")]
    public string? PscEndpointName { get; set; }

    /// <summary>The service attachment this PSC connection connects to.</summary>
    [JsonPropertyName("serviceAttachmentId")]
    public string? ServiceAttachmentId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointStatusAtProvider
{
    /// <summary>Account Id that could be found in the Accounts Console for AWS or GCP</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Account Id that could be found in the Accounts Console for AWS or GCP</summary>
    [JsonPropertyName("awsAccountId")]
    public string? AwsAccountId { get; set; }

    /// <summary>(AWS Only) The ID of the Databricks endpoint service that this VPC endpoint is connected to. Please find the list of endpoint service IDs for each supported region in the Databricks PrivateLink documentation</summary>
    [JsonPropertyName("awsEndpointServiceId")]
    public string? AwsEndpointServiceId { get; set; }

    /// <summary>(AWS only) ID of configured aws_vpc_endpoint</summary>
    [JsonPropertyName("awsVpcEndpointId")]
    public string? AwsVpcEndpointId { get; set; }

    /// <summary>(GCP only) a block consists of Google Cloud specific information for this PSC endpoint. It has the following fields:</summary>
    [JsonPropertyName("gcpVpcEndpointInfo")]
    public V1beta1MwsVPCEndpointStatusAtProviderGcpVpcEndpointInfo? GcpVpcEndpointInfo { get; set; }

    /// <summary>the ID of VPC Endpoint in form of account_id/vpc_endpoint_id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>(AWS only) Region of AWS VPC</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>(AWS Only) State of VPC Endpoint</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("useCase")]
    public string? UseCase { get; set; }

    /// <summary>Canonical unique identifier of VPC Endpoint in Databricks Account</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Name of VPC Endpoint in Databricks Account</summary>
    [JsonPropertyName("vpcEndpointName")]
    public string? VpcEndpointName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointStatusConditions
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

/// <summary>MwsVPCEndpointStatus defines the observed state of MwsVPCEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsVPCEndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MwsVPCEndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MwsVPCEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MwsVPCEndpoint is the Schema for the MwsVPCEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MwsVPCEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MwsVPCEndpointSpec>, IStatus<V1beta1MwsVPCEndpointStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MwsVPCEndpoint";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsvpcendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsVPCEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsVPCEndpointSpec defines the desired state of MwsVPCEndpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MwsVPCEndpointSpec Spec { get; set; }

    /// <summary>MwsVPCEndpointStatus defines the observed state of MwsVPCEndpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1MwsVPCEndpointStatus? Status { get; set; }
}
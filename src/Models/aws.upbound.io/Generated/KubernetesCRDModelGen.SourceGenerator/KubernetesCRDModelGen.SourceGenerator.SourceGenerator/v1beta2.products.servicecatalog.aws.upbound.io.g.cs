#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicecatalog.aws.upbound.io;
/// <summary>Product is the Schema for the Products API. Manages a Service Catalog Product</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ProductList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Product>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ProductList";
    public const string KubeGroup = "servicecatalog.aws.upbound.io";
    public const string KubePluralName = "products";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicecatalog.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProductList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Product objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Product> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProductSpecDeletionPolicyEnum>))]
public enum V1beta2ProductSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block for provisioning artifact (i.e., version) parameters. See provisioning_artifact_parameters Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductSpecForProviderProvisioningArtifactParameters
{
    /// <summary>Description of the provisioning artifact (i.e., version), including how it differs from the previous provisioning artifact.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether AWS Service Catalog stops validating the specified provisioning artifact template even if it is invalid.</summary>
    [JsonPropertyName("disableTemplateValidation")]
    public bool? DisableTemplateValidation { get; set; }

    /// <summary>Name of the provisioning artifact (for example, v1, v2beta). No spaces are allowed.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template source as the physical ID of the resource that contains the template. Currently only supports CloudFormation stack ARN. Specify the physical ID as arn:[partition]:cloudformation:[region]:[account ID]:stack/[stack name]/[resource ID].</summary>
    [JsonPropertyName("templatePhysicalId")]
    public string? TemplatePhysicalId { get; set; }

    /// <summary>Template source as URL of the CloudFormation template in Amazon S3.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }

    /// <summary>Type of provisioning artifact. See AWS Docs for valid list of values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductSpecForProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Description of the product.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Distributor (i.e., vendor) of the product.</summary>
    [JsonPropertyName("distributor")]
    public string? Distributor { get; set; }

    /// <summary>Name of the product.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the product.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configuration block for provisioning artifact (i.e., version) parameters. See provisioning_artifact_parameters Block for details.</summary>
    [JsonPropertyName("provisioningArtifactParameters")]
    public V1beta2ProductSpecForProviderProvisioningArtifactParameters? ProvisioningArtifactParameters { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Support information about the product.</summary>
    [JsonPropertyName("supportDescription")]
    public string? SupportDescription { get; set; }

    /// <summary>Contact email for product support.</summary>
    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; set; }

    /// <summary>Contact URL for product support.</summary>
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type of product. See AWS Docs for valid list of values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for provisioning artifact (i.e., version) parameters. See provisioning_artifact_parameters Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductSpecInitProviderProvisioningArtifactParameters
{
    /// <summary>Description of the provisioning artifact (i.e., version), including how it differs from the previous provisioning artifact.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether AWS Service Catalog stops validating the specified provisioning artifact template even if it is invalid.</summary>
    [JsonPropertyName("disableTemplateValidation")]
    public bool? DisableTemplateValidation { get; set; }

    /// <summary>Name of the provisioning artifact (for example, v1, v2beta). No spaces are allowed.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template source as the physical ID of the resource that contains the template. Currently only supports CloudFormation stack ARN. Specify the physical ID as arn:[partition]:cloudformation:[region]:[account ID]:stack/[stack name]/[resource ID].</summary>
    [JsonPropertyName("templatePhysicalId")]
    public string? TemplatePhysicalId { get; set; }

    /// <summary>Template source as URL of the CloudFormation template in Amazon S3.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }

    /// <summary>Type of provisioning artifact. See AWS Docs for valid list of values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
public partial class V1beta2ProductSpecInitProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Description of the product.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Distributor (i.e., vendor) of the product.</summary>
    [JsonPropertyName("distributor")]
    public string? Distributor { get; set; }

    /// <summary>Name of the product.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the product.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configuration block for provisioning artifact (i.e., version) parameters. See provisioning_artifact_parameters Block for details.</summary>
    [JsonPropertyName("provisioningArtifactParameters")]
    public V1beta2ProductSpecInitProviderProvisioningArtifactParameters? ProvisioningArtifactParameters { get; set; }

    /// <summary>Support information about the product.</summary>
    [JsonPropertyName("supportDescription")]
    public string? SupportDescription { get; set; }

    /// <summary>Contact email for product support.</summary>
    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; set; }

    /// <summary>Contact URL for product support.</summary>
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type of product. See AWS Docs for valid list of values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProductSpecManagementPoliciesEnum>))]
public enum V1beta2ProductSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProductSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ProductSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProductSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ProductSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ProductSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ProductSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ProductSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ProductSpec defines the desired state of Product</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductSpec
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
    public V1beta2ProductSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ProductSpecForProvider ForProvider { get; set; }

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
    public V1beta2ProductSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ProductSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ProductSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ProductSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block for provisioning artifact (i.e., version) parameters. See provisioning_artifact_parameters Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductStatusAtProviderProvisioningArtifactParameters
{
    /// <summary>Description of the provisioning artifact (i.e., version), including how it differs from the previous provisioning artifact.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether AWS Service Catalog stops validating the specified provisioning artifact template even if it is invalid.</summary>
    [JsonPropertyName("disableTemplateValidation")]
    public bool? DisableTemplateValidation { get; set; }

    /// <summary>Name of the provisioning artifact (for example, v1, v2beta). No spaces are allowed.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template source as the physical ID of the resource that contains the template. Currently only supports CloudFormation stack ARN. Specify the physical ID as arn:[partition]:cloudformation:[region]:[account ID]:stack/[stack name]/[resource ID].</summary>
    [JsonPropertyName("templatePhysicalId")]
    public string? TemplatePhysicalId { get; set; }

    /// <summary>Template source as URL of the CloudFormation template in Amazon S3.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }

    /// <summary>Type of provisioning artifact. See AWS Docs for valid list of values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductStatusAtProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>ARN of the product.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Time when the product was created.</summary>
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    /// <summary>Description of the product.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Distributor (i.e., vendor) of the product.</summary>
    [JsonPropertyName("distributor")]
    public string? Distributor { get; set; }

    /// <summary>Whether the product has a default path. If the product does not have a default path, call ListLaunchPaths to disambiguate between paths.  Otherwise, ListLaunchPaths is not required, and the output of ProductViewSummary can be used directly with DescribeProvisioningParameters.</summary>
    [JsonPropertyName("hasDefaultPath")]
    public bool? HasDefaultPath { get; set; }

    /// <summary>Product ID. For example, prod-dnigbtea24ste.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the product.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the product.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configuration block for provisioning artifact (i.e., version) parameters. See provisioning_artifact_parameters Block for details.</summary>
    [JsonPropertyName("provisioningArtifactParameters")]
    public V1beta2ProductStatusAtProviderProvisioningArtifactParameters? ProvisioningArtifactParameters { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Status of the product.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Support information about the product.</summary>
    [JsonPropertyName("supportDescription")]
    public string? SupportDescription { get; set; }

    /// <summary>Contact email for product support.</summary>
    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; set; }

    /// <summary>Contact URL for product support.</summary>
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Type of product. See AWS Docs for valid list of values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductStatusConditions
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

/// <summary>ProductStatus defines the observed state of Product.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProductStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ProductStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ProductStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Product is the Schema for the Products API. Manages a Service Catalog Product</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Product : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ProductSpec>, IStatus<V1beta2ProductStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Product";
    public const string KubeGroup = "servicecatalog.aws.upbound.io";
    public const string KubePluralName = "products";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicecatalog.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Product";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProductSpec defines the desired state of Product</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ProductSpec Spec { get; set; }

    /// <summary>ProductStatus defines the observed state of Product.</summary>
    [JsonPropertyName("status")]
    public V1beta2ProductStatus? Status { get; set; }
}
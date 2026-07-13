#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codepipeline.aws.upbound.io;
/// <summary>CustomActionType is the Schema for the CustomActionTypes API. Provides a CodePipeline CustomActionType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CustomActionTypeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2CustomActionType>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CustomActionTypeList";
    public const string KubeGroup = "codepipeline.aws.upbound.io";
    public const string KubePluralName = "customactiontypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codepipeline.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CustomActionTypeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2CustomActionType objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2CustomActionType> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CustomActionTypeSpecDeletionPolicyEnum>))]
public enum V1beta2CustomActionTypeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecForProviderConfigurationProperty
{
    /// <summary>The description of the action configuration property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the configuration property is a key.</summary>
    [JsonPropertyName("key")]
    public bool? Key { get; set; }

    /// <summary>The name of the action configuration property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates that the property will be used in conjunction with PollForJobs.</summary>
    [JsonPropertyName("queryable")]
    public bool? Queryable { get; set; }

    /// <summary>Whether the configuration property is a required value.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Whether the configuration property is secret.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>The type of the configuration property. Valid values: String, Number, Boolean</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The details of the input artifact for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecForProviderInputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}

/// <summary>The details of the output artifact of the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecForProviderOutputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}

/// <summary>The settings for an action type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecForProviderSettings
{
    /// <summary>The URL returned to the AWS CodePipeline console that provides a deep link to the resources of the external system.</summary>
    [JsonPropertyName("entityUrlTemplate")]
    public string? EntityUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the top-level landing page for the external system.</summary>
    [JsonPropertyName("executionUrlTemplate")]
    public string? ExecutionUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the page where customers can update or change the configuration of the external action.</summary>
    [JsonPropertyName("revisionUrlTemplate")]
    public string? RevisionUrlTemplate { get; set; }

    /// <summary>The URL of a sign-up page where users can sign up for an external service and perform initial configuration of the action provided by that service.</summary>
    [JsonPropertyName("thirdPartyConfigurationUrl")]
    public string? ThirdPartyConfigurationUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecForProvider
{
    /// <summary>The category of the custom action. Valid values: Source, Build, Deploy, Test, Invoke, Approval</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The configuration properties for the custom action. Max 10 items.</summary>
    [JsonPropertyName("configurationProperty")]
    public IList<V1beta2CustomActionTypeSpecForProviderConfigurationProperty>? ConfigurationProperty { get; set; }

    /// <summary>The details of the input artifact for the action.</summary>
    [JsonPropertyName("inputArtifactDetails")]
    public V1beta2CustomActionTypeSpecForProviderInputArtifactDetails? InputArtifactDetails { get; set; }

    /// <summary>The details of the output artifact of the action.</summary>
    [JsonPropertyName("outputArtifactDetails")]
    public V1beta2CustomActionTypeSpecForProviderOutputArtifactDetails? OutputArtifactDetails { get; set; }

    /// <summary>The provider of the service used in the custom action</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The settings for an action type.</summary>
    [JsonPropertyName("settings")]
    public V1beta2CustomActionTypeSpecForProviderSettings? Settings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version identifier of the custom action.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecInitProviderConfigurationProperty
{
    /// <summary>The description of the action configuration property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the configuration property is a key.</summary>
    [JsonPropertyName("key")]
    public bool? Key { get; set; }

    /// <summary>The name of the action configuration property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates that the property will be used in conjunction with PollForJobs.</summary>
    [JsonPropertyName("queryable")]
    public bool? Queryable { get; set; }

    /// <summary>Whether the configuration property is a required value.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Whether the configuration property is secret.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>The type of the configuration property. Valid values: String, Number, Boolean</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The details of the input artifact for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecInitProviderInputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}

/// <summary>The details of the output artifact of the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecInitProviderOutputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}

/// <summary>The settings for an action type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecInitProviderSettings
{
    /// <summary>The URL returned to the AWS CodePipeline console that provides a deep link to the resources of the external system.</summary>
    [JsonPropertyName("entityUrlTemplate")]
    public string? EntityUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the top-level landing page for the external system.</summary>
    [JsonPropertyName("executionUrlTemplate")]
    public string? ExecutionUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the page where customers can update or change the configuration of the external action.</summary>
    [JsonPropertyName("revisionUrlTemplate")]
    public string? RevisionUrlTemplate { get; set; }

    /// <summary>The URL of a sign-up page where users can sign up for an external service and perform initial configuration of the action provided by that service.</summary>
    [JsonPropertyName("thirdPartyConfigurationUrl")]
    public string? ThirdPartyConfigurationUrl { get; set; }
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
public partial class V1beta2CustomActionTypeSpecInitProvider
{
    /// <summary>The category of the custom action. Valid values: Source, Build, Deploy, Test, Invoke, Approval</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The configuration properties for the custom action. Max 10 items.</summary>
    [JsonPropertyName("configurationProperty")]
    public IList<V1beta2CustomActionTypeSpecInitProviderConfigurationProperty>? ConfigurationProperty { get; set; }

    /// <summary>The details of the input artifact for the action.</summary>
    [JsonPropertyName("inputArtifactDetails")]
    public V1beta2CustomActionTypeSpecInitProviderInputArtifactDetails? InputArtifactDetails { get; set; }

    /// <summary>The details of the output artifact of the action.</summary>
    [JsonPropertyName("outputArtifactDetails")]
    public V1beta2CustomActionTypeSpecInitProviderOutputArtifactDetails? OutputArtifactDetails { get; set; }

    /// <summary>The provider of the service used in the custom action</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The settings for an action type.</summary>
    [JsonPropertyName("settings")]
    public V1beta2CustomActionTypeSpecInitProviderSettings? Settings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version identifier of the custom action.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CustomActionTypeSpecManagementPoliciesEnum>))]
public enum V1beta2CustomActionTypeSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CustomActionTypeSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CustomActionTypeSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CustomActionTypeSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CustomActionTypeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CustomActionTypeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CustomActionTypeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CustomActionTypeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CustomActionTypeSpec defines the desired state of CustomActionType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeSpec
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
    public V1beta2CustomActionTypeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CustomActionTypeSpecForProvider ForProvider { get; set; }

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
    public V1beta2CustomActionTypeSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CustomActionTypeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CustomActionTypeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CustomActionTypeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeStatusAtProviderConfigurationProperty
{
    /// <summary>The description of the action configuration property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the configuration property is a key.</summary>
    [JsonPropertyName("key")]
    public bool? Key { get; set; }

    /// <summary>The name of the action configuration property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates that the property will be used in conjunction with PollForJobs.</summary>
    [JsonPropertyName("queryable")]
    public bool? Queryable { get; set; }

    /// <summary>Whether the configuration property is a required value.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Whether the configuration property is secret.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>The type of the configuration property. Valid values: String, Number, Boolean</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The details of the input artifact for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeStatusAtProviderInputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}

/// <summary>The details of the output artifact of the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeStatusAtProviderOutputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}

/// <summary>The settings for an action type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeStatusAtProviderSettings
{
    /// <summary>The URL returned to the AWS CodePipeline console that provides a deep link to the resources of the external system.</summary>
    [JsonPropertyName("entityUrlTemplate")]
    public string? EntityUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the top-level landing page for the external system.</summary>
    [JsonPropertyName("executionUrlTemplate")]
    public string? ExecutionUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the page where customers can update or change the configuration of the external action.</summary>
    [JsonPropertyName("revisionUrlTemplate")]
    public string? RevisionUrlTemplate { get; set; }

    /// <summary>The URL of a sign-up page where users can sign up for an external service and perform initial configuration of the action provided by that service.</summary>
    [JsonPropertyName("thirdPartyConfigurationUrl")]
    public string? ThirdPartyConfigurationUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeStatusAtProvider
{
    /// <summary>The action ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The category of the custom action. Valid values: Source, Build, Deploy, Test, Invoke, Approval</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The configuration properties for the custom action. Max 10 items.</summary>
    [JsonPropertyName("configurationProperty")]
    public IList<V1beta2CustomActionTypeStatusAtProviderConfigurationProperty>? ConfigurationProperty { get; set; }

    /// <summary>Composed of category, provider and version</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The details of the input artifact for the action.</summary>
    [JsonPropertyName("inputArtifactDetails")]
    public V1beta2CustomActionTypeStatusAtProviderInputArtifactDetails? InputArtifactDetails { get; set; }

    /// <summary>The details of the output artifact of the action.</summary>
    [JsonPropertyName("outputArtifactDetails")]
    public V1beta2CustomActionTypeStatusAtProviderOutputArtifactDetails? OutputArtifactDetails { get; set; }

    /// <summary>The creator of the action being called.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service used in the custom action</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The settings for an action type.</summary>
    [JsonPropertyName("settings")]
    public V1beta2CustomActionTypeStatusAtProviderSettings? Settings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The version identifier of the custom action.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeStatusConditions
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

/// <summary>CustomActionTypeStatus defines the observed state of CustomActionType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CustomActionTypeStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CustomActionTypeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CustomActionTypeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CustomActionType is the Schema for the CustomActionTypes API. Provides a CodePipeline CustomActionType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CustomActionType : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CustomActionTypeSpec>, IStatus<V1beta2CustomActionTypeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CustomActionType";
    public const string KubeGroup = "codepipeline.aws.upbound.io";
    public const string KubePluralName = "customactiontypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codepipeline.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CustomActionType";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomActionTypeSpec defines the desired state of CustomActionType</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CustomActionTypeSpec Spec { get; set; }

    /// <summary>CustomActionTypeStatus defines the observed state of CustomActionType.</summary>
    [JsonPropertyName("status")]
    public V1beta2CustomActionTypeStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
/// <summary>APIOperation is the Schema for the APIOperations API. Manages an API Operation within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2APIOperationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2APIOperation>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "APIOperationList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apioperations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIOperationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2APIOperation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2APIOperation> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecDeletionPolicyEnum>))]
public enum V1beta2APIOperationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiManagementNameRefPolicyResolutionEnum>))]
public enum V1beta2APIOperationSpecForProviderApiManagementNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiManagementNameRefPolicyResolveEnum>))]
public enum V1beta2APIOperationSpecForProviderApiManagementNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIOperationSpecForProviderApiManagementNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIOperationSpecForProviderApiManagementNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIOperationSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicyResolveEnum>))]
public enum V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiManagementNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIOperationSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiNameRefPolicyResolutionEnum>))]
public enum V1beta2APIOperationSpecForProviderApiNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiNameRefPolicyResolveEnum>))]
public enum V1beta2APIOperationSpecForProviderApiNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIOperationSpecForProviderApiNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIOperationSpecForProviderApiNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIOperationSpecForProviderApiNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APIOperationSpecForProviderApiNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderApiNameSelectorPolicyResolveEnum>))]
public enum V1beta2APIOperationSpecForProviderApiNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIOperationSpecForProviderApiNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIOperationSpecForProviderApiNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderApiNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIOperationSpecForProviderApiNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderRequestHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestQueryParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestQueryParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderRequestQueryParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderRequestRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequestRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderRequestRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta2APIOperationSpecForProviderRequestRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>A request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderRequest
{
    /// <summary>A description of the HTTP Request, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2APIOperationSpecForProviderRequestHeader>? Header { get; set; }

    /// <summary>One or more query_parameter blocks as defined above.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2APIOperationSpecForProviderRequestQueryParameter>? QueryParameter { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta2APIOperationSpecForProviderRequestRepresentation>? Representation { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResourceGroupNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResponseHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResponseHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderResponseHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResponseRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResponseRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResponseRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderResponseRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResponseRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderResponseRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta2APIOperationSpecForProviderResponseRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderResponse
{
    /// <summary>A description of the HTTP Response, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2APIOperationSpecForProviderResponseHeader>? Header { get; set; }

    /// <summary>One or more representation blocks as defined above.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta2APIOperationSpecForProviderResponseRepresentation>? Representation { get; set; }

    /// <summary>The HTTP Status Code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderTemplateParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProviderTemplateParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecForProviderTemplateParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecForProvider
{
    /// <summary>The Name of the API Management Service where the API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta2APIOperationSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta2APIOperationSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>The name of the API within the API Management Service where this API Operation should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>Reference to a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameRef")]
    public V1beta2APIOperationSpecForProviderApiNameRef? ApiNameRef { get; set; }

    /// <summary>Selector for a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameSelector")]
    public V1beta2APIOperationSpecForProviderApiNameSelector? ApiNameSelector { get; set; }

    /// <summary>A description for this API Operation, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this API Management Operation.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The HTTP Method used for this API Management Operation, like GET, DELETE, PUT or POST - but not limited to these values.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public V1beta2APIOperationSpecForProviderRequest? Request { get; set; }

    /// <summary>The Name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2APIOperationSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more response blocks as defined below.</summary>
    [JsonPropertyName("response")]
    public IList<V1beta2APIOperationSpecForProviderResponse>? Response { get; set; }

    /// <summary>One or more template_parameter blocks as defined below. Required if url_template contains one or more parameters.</summary>
    [JsonPropertyName("templateParameter")]
    public IList<V1beta2APIOperationSpecForProviderTemplateParameter>? TemplateParameter { get; set; }

    /// <summary>The relative URL Template identifying the target resource for this operation, which may include parameters.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderRequestHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestQueryParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestQueryParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderRequestQueryParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderRequestRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequestRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderRequestRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta2APIOperationSpecInitProviderRequestRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>A request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderRequest
{
    /// <summary>A description of the HTTP Request, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2APIOperationSpecInitProviderRequestHeader>? Header { get; set; }

    /// <summary>One or more query_parameter blocks as defined above.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2APIOperationSpecInitProviderRequestQueryParameter>? QueryParameter { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta2APIOperationSpecInitProviderRequestRepresentation>? Representation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderResponseHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderResponseHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderResponseHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderResponseRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderResponseRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderResponseRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderResponseRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderResponseRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderResponseRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta2APIOperationSpecInitProviderResponseRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderResponse
{
    /// <summary>A description of the HTTP Response, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2APIOperationSpecInitProviderResponseHeader>? Header { get; set; }

    /// <summary>One or more representation blocks as defined above.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta2APIOperationSpecInitProviderResponseRepresentation>? Representation { get; set; }

    /// <summary>The HTTP Status Code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderTemplateParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProviderTemplateParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationSpecInitProviderTemplateParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecInitProvider
{
    /// <summary>A description for this API Operation, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this API Management Operation.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The HTTP Method used for this API Management Operation, like GET, DELETE, PUT or POST - but not limited to these values.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public V1beta2APIOperationSpecInitProviderRequest? Request { get; set; }

    /// <summary>One or more response blocks as defined below.</summary>
    [JsonPropertyName("response")]
    public IList<V1beta2APIOperationSpecInitProviderResponse>? Response { get; set; }

    /// <summary>One or more template_parameter blocks as defined below. Required if url_template contains one or more parameters.</summary>
    [JsonPropertyName("templateParameter")]
    public IList<V1beta2APIOperationSpecInitProviderTemplateParameter>? TemplateParameter { get; set; }

    /// <summary>The relative URL Template identifying the target resource for this operation, which may include parameters.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecManagementPoliciesEnum>))]
public enum V1beta2APIOperationSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2APIOperationSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIOperationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2APIOperationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIOperationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIOperationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIOperationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>APIOperationSpec defines the desired state of APIOperation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationSpec
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
    public V1beta2APIOperationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2APIOperationSpecForProvider ForProvider { get; set; }

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
    public V1beta2APIOperationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2APIOperationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2APIOperationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2APIOperationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderRequestHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestQueryParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestQueryParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderRequestQueryParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderRequestRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequestRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderRequestRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta2APIOperationStatusAtProviderRequestRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>A request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderRequest
{
    /// <summary>A description of the HTTP Request, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2APIOperationStatusAtProviderRequestHeader>? Header { get; set; }

    /// <summary>One or more query_parameter blocks as defined above.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2APIOperationStatusAtProviderRequestQueryParameter>? QueryParameter { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta2APIOperationStatusAtProviderRequestRepresentation>? Representation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderResponseHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderResponseHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderResponseHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderResponseRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderResponseRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderResponseRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderResponseRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderResponseRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderResponseRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta2APIOperationStatusAtProviderResponseRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderResponse
{
    /// <summary>A description of the HTTP Response, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2APIOperationStatusAtProviderResponseHeader>? Header { get; set; }

    /// <summary>One or more representation blocks as defined above.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta2APIOperationStatusAtProviderResponseRepresentation>? Representation { get; set; }

    /// <summary>The HTTP Status Code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderTemplateParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProviderTemplateParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta2APIOperationStatusAtProviderTemplateParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusAtProvider
{
    /// <summary>The Name of the API Management Service where the API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>The name of the API within the API Management Service where this API Operation should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>A description for this API Operation, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this API Management Operation.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the API Management API Operation.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The HTTP Method used for this API Management Operation, like GET, DELETE, PUT or POST - but not limited to these values.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public V1beta2APIOperationStatusAtProviderRequest? Request { get; set; }

    /// <summary>The Name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more response blocks as defined below.</summary>
    [JsonPropertyName("response")]
    public IList<V1beta2APIOperationStatusAtProviderResponse>? Response { get; set; }

    /// <summary>One or more template_parameter blocks as defined below. Required if url_template contains one or more parameters.</summary>
    [JsonPropertyName("templateParameter")]
    public IList<V1beta2APIOperationStatusAtProviderTemplateParameter>? TemplateParameter { get; set; }

    /// <summary>The relative URL Template identifying the target resource for this operation, which may include parameters.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatusConditions
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

/// <summary>APIOperationStatus defines the observed state of APIOperation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIOperationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2APIOperationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2APIOperationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>APIOperation is the Schema for the APIOperations API. Manages an API Operation within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2APIOperation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2APIOperationSpec>, IStatus<V1beta2APIOperationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "APIOperation";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apioperations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIOperation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIOperationSpec defines the desired state of APIOperation</summary>
    [JsonPropertyName("spec")]
    public required V1beta2APIOperationSpec Spec { get; set; }

    /// <summary>APIOperationStatus defines the observed state of APIOperation.</summary>
    [JsonPropertyName("status")]
    public V1beta2APIOperationStatus? Status { get; set; }
}
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
/// <summary>APIDiagnostic is the Schema for the APIDiagnostics API. Manages a API Management Service API Diagnostics Logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2APIDiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V1beta2APIDiagnostic>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "APIDiagnosticList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apidiagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIDiagnosticList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2APIDiagnostic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2APIDiagnostic> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecDeletionPolicyEnum>))]
public enum V1beta2APIDiagnosticSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelector
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
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiManagementNameSelector
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
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiNameRefPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiNameRefPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderApiNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderApiNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIDiagnosticSpecForProviderApiNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderApiNameSelector
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
    public V1beta2APIDiagnosticSpecForProviderApiNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecForProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecForProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecForProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecForProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecForProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecForProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecForProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecForProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecForProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecForProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelector
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
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecForProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The ID (name) of the Diagnostics Logger.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>The name of the API Management Service instance. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta2APIDiagnosticSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>The name of the API on which to configure the Diagnostics Logs. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>Reference to a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameRef")]
    public V1beta2APIDiagnosticSpecForProviderApiNameRef? ApiNameRef { get; set; }

    /// <summary>Selector for a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameSelector")]
    public V1beta2APIDiagnosticSpecForProviderApiNameSelector? ApiNameSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta2APIDiagnosticSpecForProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta2APIDiagnosticSpecForProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta2APIDiagnosticSpecForProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta2APIDiagnosticSpecForProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url. Defaults to Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The name of the Resource Group where the API Management Service API Diagnostics Logs should exist. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2APIDiagnosticSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelector
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
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecInitProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecInitProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecInitProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecInitProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecInitProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecInitProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticSpecInitProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
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
public partial class V1beta2APIDiagnosticSpecInitProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The ID (name) of the Diagnostics Logger.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta2APIDiagnosticSpecInitProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta2APIDiagnosticSpecInitProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta2APIDiagnosticSpecInitProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta2APIDiagnosticSpecInitProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta2APIDiagnosticSpecInitProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url. Defaults to Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecManagementPoliciesEnum>))]
public enum V1beta2APIDiagnosticSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2APIDiagnosticSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APIDiagnosticSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2APIDiagnosticSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APIDiagnosticSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APIDiagnosticSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APIDiagnosticSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>APIDiagnosticSpec defines the desired state of APIDiagnostic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticSpec
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
    public V1beta2APIDiagnosticSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2APIDiagnosticSpecForProvider ForProvider { get; set; }

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
    public V1beta2APIDiagnosticSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2APIDiagnosticSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2APIDiagnosticSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2APIDiagnosticSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticStatusAtProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticStatusAtProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticStatusAtProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticStatusAtProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticStatusAtProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2APIDiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2APIDiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2APIDiagnosticStatusAtProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusAtProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The ID (name) of the Diagnostics Logger.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>The name of the API Management Service instance. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>The name of the API on which to configure the Diagnostics Logs. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta2APIDiagnosticStatusAtProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta2APIDiagnosticStatusAtProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta2APIDiagnosticStatusAtProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta2APIDiagnosticStatusAtProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>The ID of the API Management Service API Diagnostics Logs.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url. Defaults to Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The name of the Resource Group where the API Management Service API Diagnostics Logs should exist. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatusConditions
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

/// <summary>APIDiagnosticStatus defines the observed state of APIDiagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIDiagnosticStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2APIDiagnosticStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2APIDiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>APIDiagnostic is the Schema for the APIDiagnostics API. Manages a API Management Service API Diagnostics Logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2APIDiagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2APIDiagnosticSpec>, IStatus<V1beta2APIDiagnosticStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "APIDiagnostic";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apidiagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIDiagnostic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIDiagnosticSpec defines the desired state of APIDiagnostic</summary>
    [JsonPropertyName("spec")]
    public required V1beta2APIDiagnosticSpec Spec { get; set; }

    /// <summary>APIDiagnosticStatus defines the observed state of APIDiagnostic.</summary>
    [JsonPropertyName("status")]
    public V1beta2APIDiagnosticStatus? Status { get; set; }
}
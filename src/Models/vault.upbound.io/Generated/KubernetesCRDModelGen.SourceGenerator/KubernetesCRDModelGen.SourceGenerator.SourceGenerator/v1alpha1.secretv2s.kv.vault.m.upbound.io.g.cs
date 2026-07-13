#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kv.vault.m.upbound.io;
/// <summary>SecretV2 is the Schema for the SecretV2s API. Writes a KV-V2 secret to a given path in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretV2List : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretV2>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretV2List";
    public const string KubeGroup = "kv.vault.m.upbound.io";
    public const string KubePluralName = "secretv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kv.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretV2List";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretV2 objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretV2> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecForProviderCustomMetadata
{
    /// <summary>
    /// If true, all keys will require the cas
    /// parameter to be set on all write requests.
    /// If true, all keys will require the cas parameter to be set on all write requests.
    /// </summary>
    [JsonPropertyName("casRequired")]
    public bool? CasRequired { get; set; }

    /// <summary>
    /// A string to string map describing the secret.
    /// A map of arbitrary string to string valued user-provided metadata meant to describe the secret.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// If set, specifies the length of time before
    /// a version is deleted. Accepts duration in integer seconds.
    /// If set, specifies the length of time before a version is deleted.
    /// </summary>
    [JsonPropertyName("deleteVersionAfter")]
    public double? DeleteVersionAfter { get; set; }

    /// <summary>
    /// The number of versions to keep per key.
    /// The number of versions to keep per key.
    /// </summary>
    [JsonPropertyName("maxVersions")]
    public double? MaxVersions { get; set; }
}

/// <summary>
/// JSON-encoded string that will be
/// written as the secret data at the given path. This is required if data_json_wo is not set.
/// JSON-encoded secret data to write.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecForProviderDataJsonSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecForProviderMountRefPolicyResolutionEnum>))]
public enum V1alpha1SecretV2SpecForProviderMountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecForProviderMountRefPolicyResolveEnum>))]
public enum V1alpha1SecretV2SpecForProviderMountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecForProviderMountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretV2SpecForProviderMountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretV2SpecForProviderMountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecForProviderMountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretV2SpecForProviderMountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecForProviderMountSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretV2SpecForProviderMountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecForProviderMountSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretV2SpecForProviderMountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecForProviderMountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretV2SpecForProviderMountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretV2SpecForProviderMountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecForProviderMountSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretV2SpecForProviderMountSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecForProvider
{
    /// <summary>
    /// This flag is required if cas_required is set to true
    /// on either the secret or the engine&apos;s config. In order for a
    /// write operation to be successful, cas must be set to the current version
    /// of the secret.
    /// This flag is required if cas_required is set to true on either the secret or the engine&apos;s config. In order for a write to be successful, cas must be set to the current version of the secret.
    /// </summary>
    [JsonPropertyName("cas")]
    public double? Cas { get; set; }

    /// <summary>
    /// A nested block that allows configuring metadata for the
    /// KV secret. Refer to the
    /// Configuration Options for more info.
    /// Custom metadata to be set for the secret.
    /// </summary>
    [JsonPropertyName("customMetadata")]
    public IList<V1alpha1SecretV2SpecForProviderCustomMetadata>? CustomMetadata { get; set; }

    /// <summary>
    /// JSON-encoded string that will be
    /// written as the secret data at the given path. This is required if data_json_wo is not set.
    /// JSON-encoded secret data to write.
    /// </summary>
    [JsonPropertyName("dataJsonSecretRef")]
    public V1alpha1SecretV2SpecForProviderDataJsonSecretRef? DataJsonSecretRef { get; set; }

    /// <summary>
    /// JSON-encoded string that will be
    /// written as the secret data at the given path. This is required if data_json is not set. Note: This property is write-only and will not be read from the API.
    /// Write-Only JSON-encoded secret data to write.
    /// </summary>
    [JsonPropertyName("dataJsonWo")]
    public string? DataJsonWo { get; set; }

    /// <summary>
    /// The version of the data_json_wo. For more info see updating write-only attributes.
    /// Version counter for write-only secret data.
    /// </summary>
    [JsonPropertyName("dataJsonWoVersion")]
    public double? DataJsonWoVersion { get; set; }

    /// <summary>
    /// If set to true, permanently deletes all
    /// versions for the specified key.
    /// If set to true, permanently deletes all versions for the specified key.
    /// </summary>
    [JsonPropertyName("deleteAllVersions")]
    public bool? DeleteAllVersions { get; set; }

    /// <summary>
    /// If set to true, disables reading secret from Vault;
    /// note: drift won&apos;t be detected.
    /// If set to true, disables reading secret from Vault; note: drift won&apos;t be detected.
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    /// <summary>
    /// Path where KV-V2 engine is mounted.
    /// Path where KV-V2 engine is mounted.
    /// </summary>
    [JsonPropertyName("mount")]
    public string? Mount { get; set; }

    /// <summary>Reference to a Mount in vault to populate mount.</summary>
    [JsonPropertyName("mountRef")]
    public V1alpha1SecretV2SpecForProviderMountRef? MountRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate mount.</summary>
    [JsonPropertyName("mountSelector")]
    public V1alpha1SecretV2SpecForProviderMountSelector? MountSelector { get; set; }

    /// <summary>
    /// Full name of the secret. For a nested secret
    /// the name is the nested path excluding the mount and data
    /// prefix. For example, for a secret at kvv2/data/foo/bar/baz
    /// the name is foo/bar/baz.
    /// Full name of the secret. For a nested secret, the name is the nested path excluding the mount and data prefix. For example, for a secret at &apos;kvv2/data/foo/bar/baz&apos;, the name is &apos;foo/bar/baz&apos;
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// An object that holds option settings.
    /// An object that holds option settings.
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecInitProviderCustomMetadata
{
    /// <summary>
    /// If true, all keys will require the cas
    /// parameter to be set on all write requests.
    /// If true, all keys will require the cas parameter to be set on all write requests.
    /// </summary>
    [JsonPropertyName("casRequired")]
    public bool? CasRequired { get; set; }

    /// <summary>
    /// A string to string map describing the secret.
    /// A map of arbitrary string to string valued user-provided metadata meant to describe the secret.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// If set, specifies the length of time before
    /// a version is deleted. Accepts duration in integer seconds.
    /// If set, specifies the length of time before a version is deleted.
    /// </summary>
    [JsonPropertyName("deleteVersionAfter")]
    public double? DeleteVersionAfter { get; set; }

    /// <summary>
    /// The number of versions to keep per key.
    /// The number of versions to keep per key.
    /// </summary>
    [JsonPropertyName("maxVersions")]
    public double? MaxVersions { get; set; }
}

/// <summary>
/// JSON-encoded string that will be
/// written as the secret data at the given path. This is required if data_json_wo is not set.
/// JSON-encoded secret data to write.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecInitProviderDataJsonSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecInitProviderMountRefPolicyResolutionEnum>))]
public enum V1alpha1SecretV2SpecInitProviderMountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecInitProviderMountRefPolicyResolveEnum>))]
public enum V1alpha1SecretV2SpecInitProviderMountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecInitProviderMountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretV2SpecInitProviderMountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretV2SpecInitProviderMountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecInitProviderMountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretV2SpecInitProviderMountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecInitProviderMountSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretV2SpecInitProviderMountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecInitProviderMountSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretV2SpecInitProviderMountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecInitProviderMountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretV2SpecInitProviderMountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretV2SpecInitProviderMountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecInitProviderMountSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretV2SpecInitProviderMountSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1SecretV2SpecInitProvider
{
    /// <summary>
    /// This flag is required if cas_required is set to true
    /// on either the secret or the engine&apos;s config. In order for a
    /// write operation to be successful, cas must be set to the current version
    /// of the secret.
    /// This flag is required if cas_required is set to true on either the secret or the engine&apos;s config. In order for a write to be successful, cas must be set to the current version of the secret.
    /// </summary>
    [JsonPropertyName("cas")]
    public double? Cas { get; set; }

    /// <summary>
    /// A nested block that allows configuring metadata for the
    /// KV secret. Refer to the
    /// Configuration Options for more info.
    /// Custom metadata to be set for the secret.
    /// </summary>
    [JsonPropertyName("customMetadata")]
    public IList<V1alpha1SecretV2SpecInitProviderCustomMetadata>? CustomMetadata { get; set; }

    /// <summary>
    /// JSON-encoded string that will be
    /// written as the secret data at the given path. This is required if data_json_wo is not set.
    /// JSON-encoded secret data to write.
    /// </summary>
    [JsonPropertyName("dataJsonSecretRef")]
    public V1alpha1SecretV2SpecInitProviderDataJsonSecretRef? DataJsonSecretRef { get; set; }

    /// <summary>
    /// JSON-encoded string that will be
    /// written as the secret data at the given path. This is required if data_json is not set. Note: This property is write-only and will not be read from the API.
    /// Write-Only JSON-encoded secret data to write.
    /// </summary>
    [JsonPropertyName("dataJsonWo")]
    public string? DataJsonWo { get; set; }

    /// <summary>
    /// The version of the data_json_wo. For more info see updating write-only attributes.
    /// Version counter for write-only secret data.
    /// </summary>
    [JsonPropertyName("dataJsonWoVersion")]
    public double? DataJsonWoVersion { get; set; }

    /// <summary>
    /// If set to true, permanently deletes all
    /// versions for the specified key.
    /// If set to true, permanently deletes all versions for the specified key.
    /// </summary>
    [JsonPropertyName("deleteAllVersions")]
    public bool? DeleteAllVersions { get; set; }

    /// <summary>
    /// If set to true, disables reading secret from Vault;
    /// note: drift won&apos;t be detected.
    /// If set to true, disables reading secret from Vault; note: drift won&apos;t be detected.
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    /// <summary>
    /// Path where KV-V2 engine is mounted.
    /// Path where KV-V2 engine is mounted.
    /// </summary>
    [JsonPropertyName("mount")]
    public string? Mount { get; set; }

    /// <summary>Reference to a Mount in vault to populate mount.</summary>
    [JsonPropertyName("mountRef")]
    public V1alpha1SecretV2SpecInitProviderMountRef? MountRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate mount.</summary>
    [JsonPropertyName("mountSelector")]
    public V1alpha1SecretV2SpecInitProviderMountSelector? MountSelector { get; set; }

    /// <summary>
    /// Full name of the secret. For a nested secret
    /// the name is the nested path excluding the mount and data
    /// prefix. For example, for a secret at kvv2/data/foo/bar/baz
    /// the name is foo/bar/baz.
    /// Full name of the secret. For a nested secret, the name is the nested path excluding the mount and data prefix. For example, for a secret at &apos;kvv2/data/foo/bar/baz&apos;, the name is &apos;foo/bar/baz&apos;
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// An object that holds option settings.
    /// An object that holds option settings.
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretV2SpecManagementPoliciesEnum>))]
public enum V1alpha1SecretV2SpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2SpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecretV2Spec defines the desired state of SecretV2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2Spec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretV2SpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretV2SpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SecretV2SpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretV2SpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretV2SpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2StatusAtProviderCustomMetadata
{
    /// <summary>
    /// If true, all keys will require the cas
    /// parameter to be set on all write requests.
    /// If true, all keys will require the cas parameter to be set on all write requests.
    /// </summary>
    [JsonPropertyName("casRequired")]
    public bool? CasRequired { get; set; }

    /// <summary>
    /// A string to string map describing the secret.
    /// A map of arbitrary string to string valued user-provided metadata meant to describe the secret.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// If set, specifies the length of time before
    /// a version is deleted. Accepts duration in integer seconds.
    /// If set, specifies the length of time before a version is deleted.
    /// </summary>
    [JsonPropertyName("deleteVersionAfter")]
    public double? DeleteVersionAfter { get; set; }

    /// <summary>
    /// The number of versions to keep per key.
    /// The number of versions to keep per key.
    /// </summary>
    [JsonPropertyName("maxVersions")]
    public double? MaxVersions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2StatusAtProvider
{
    /// <summary>
    /// This flag is required if cas_required is set to true
    /// on either the secret or the engine&apos;s config. In order for a
    /// write operation to be successful, cas must be set to the current version
    /// of the secret.
    /// This flag is required if cas_required is set to true on either the secret or the engine&apos;s config. In order for a write to be successful, cas must be set to the current version of the secret.
    /// </summary>
    [JsonPropertyName("cas")]
    public double? Cas { get; set; }

    /// <summary>
    /// A nested block that allows configuring metadata for the
    /// KV secret. Refer to the
    /// Configuration Options for more info.
    /// Custom metadata to be set for the secret.
    /// </summary>
    [JsonPropertyName("customMetadata")]
    public IList<V1alpha1SecretV2StatusAtProviderCustomMetadata>? CustomMetadata { get; set; }

    /// <summary>
    /// JSON-encoded string that will be
    /// written as the secret data at the given path. This is required if data_json is not set. Note: This property is write-only and will not be read from the API.
    /// Write-Only JSON-encoded secret data to write.
    /// </summary>
    [JsonPropertyName("dataJsonWo")]
    public string? DataJsonWo { get; set; }

    /// <summary>
    /// The version of the data_json_wo. For more info see updating write-only attributes.
    /// Version counter for write-only secret data.
    /// </summary>
    [JsonPropertyName("dataJsonWoVersion")]
    public double? DataJsonWoVersion { get; set; }

    /// <summary>
    /// If set to true, permanently deletes all
    /// versions for the specified key.
    /// If set to true, permanently deletes all versions for the specified key.
    /// </summary>
    [JsonPropertyName("deleteAllVersions")]
    public bool? DeleteAllVersions { get; set; }

    /// <summary>
    /// If set to true, disables reading secret from Vault;
    /// note: drift won&apos;t be detected.
    /// If set to true, disables reading secret from Vault; note: drift won&apos;t be detected.
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Metadata associated with this secret read from Vault.
    /// Metadata associated with this secret read from Vault.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Path where KV-V2 engine is mounted.
    /// Path where KV-V2 engine is mounted.
    /// </summary>
    [JsonPropertyName("mount")]
    public string? Mount { get; set; }

    /// <summary>
    /// Full name of the secret. For a nested secret
    /// the name is the nested path excluding the mount and data
    /// prefix. For example, for a secret at kvv2/data/foo/bar/baz
    /// the name is foo/bar/baz.
    /// Full name of the secret. For a nested secret, the name is the nested path excluding the mount and data prefix. For example, for a secret at &apos;kvv2/data/foo/bar/baz&apos;, the name is &apos;foo/bar/baz&apos;
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// An object that holds option settings.
    /// An object that holds option settings.
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// Full path where the KV-V2 secret will be written.
    /// Full path where the KV-V2 secret will be written.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2StatusConditions
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

/// <summary>SecretV2Status defines the observed state of SecretV2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretV2Status
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretV2StatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretV2StatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretV2 is the Schema for the SecretV2s API. Writes a KV-V2 secret to a given path in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretV2 : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretV2Spec>, IStatus<V1alpha1SecretV2Status?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretV2";
    public const string KubeGroup = "kv.vault.m.upbound.io";
    public const string KubePluralName = "secretv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kv.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretV2";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretV2Spec defines the desired state of SecretV2</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretV2Spec Spec { get; set; }

    /// <summary>SecretV2Status defines the observed state of SecretV2.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretV2Status? Status { get; set; }
}
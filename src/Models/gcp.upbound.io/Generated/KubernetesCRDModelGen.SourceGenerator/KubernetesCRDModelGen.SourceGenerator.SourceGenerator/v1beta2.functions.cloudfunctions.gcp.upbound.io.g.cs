#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfunctions.gcp.upbound.io;
/// <summary>Function is the Schema for the Functions API. Creates a new Cloud Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Function>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FunctionList";
    public const string KubeGroup = "cloudfunctions.gcp.upbound.io";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfunctions.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Function objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Function> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecDeletionPolicyEnum>))]
public enum V1beta2FunctionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Security patches are applied automatically to the runtime without requiring the function to be redeployed. This should be specified as an empty block and cannot be set alongside on_deploy_update_policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderAutomaticUpdatePolicy
{
}

/// <summary>Specifies policy for failed executions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerFailurePolicy
{
    /// <summary>Whether the function should be retried on failure. Defaults to false.</summary>
    [JsonPropertyName("retry")]
    public bool? Retry { get; set; }
}

/// <summary>A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with trigger_http.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTrigger
{
    /// <summary>
    /// The type of event to observe. For example: &quot;google.storage.object.finalize&quot;.
    /// See the documentation on calling Cloud Functions for a
    /// full reference of accepted triggers.
    /// </summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies policy for failed executions. Structure is documented below.</summary>
    [JsonPropertyName("failurePolicy")]
    public V1beta2FunctionSpecForProviderEventTriggerFailurePolicy? FailurePolicy { get; set; }

    /// <summary>
    /// Required. The name or partial URI of the resource from
    /// which to observe events. For example, &quot;myBucket&quot; or &quot;projects/my-project/topics/my-topic&quot;
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Security patches are only applied when a function is redeployed. This should be specified as an empty block and cannot be set alongside automatic_update_policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderOnDeployUpdatePolicy
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSecretEnvironmentVariables
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&apos;s project, assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>ID of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Version of the secret (version number or the string &quot;latest&quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSecretVolumesVersions
{
    /// <summary>Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mount_path as &quot;/etc/secrets&quot; and path as &quot;/secret_foo&quot; would mount the secret value file at &quot;/etc/secrets/secret_foo&quot;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Version of the secret (version number or the string &quot;latest&quot;). It is preferable to use &quot;latest&quot; version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSecretVolumes
{
    /// <summary>The path within the container to mount the secret volume. For example, setting the mount_path as &quot;/etc/secrets&quot; would mount the secret value files under the &quot;/etc/secrets&quot; directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount paths: &quot;/etc/secrets&quot; Restricted mount paths: &quot;/cloudsql&quot;, &quot;/dev/log&quot;, &quot;/pod&quot;, &quot;/proc&quot;, &quot;/var/log&quot;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&apos;s project, assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>ID of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>List of secret versions to mount for this secret. If empty, the &quot;latest&quot; version of the secret will be made available in a file named after the secret under the mount point. Structure is documented below.</summary>
    [JsonPropertyName("versions")]
    public IList<V1beta2FunctionSpecForProviderSecretVolumesVersions>? Versions { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate sourceArchiveBucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderSourceArchiveBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate sourceArchiveBucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveBucketSelector
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
    public V1beta2FunctionSpecForProviderSourceArchiveBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketObject in storage to populate sourceArchiveObject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveObjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderSourceArchiveObjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketObject in storage to populate sourceArchiveObject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceArchiveObjectSelector
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
    public V1beta2FunctionSpecForProviderSourceArchiveObjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents parameters related to source repository where a function is hosted.
/// Cannot be set alongside source_archive_bucket or source_archive_object. Structure is documented below. It must match the pattern projects/{project}/locations/{location}/repositories/{repository}.*
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderSourceRepository
{
    /// <summary>The URL pointing to the hosted repository where the function is defined. There are supported Cloud Source Repository URLs in the following formats:</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProvider
{
    /// <summary>Security patches are applied automatically to the runtime without requiring the function to be redeployed. This should be specified as an empty block and cannot be set alongside on_deploy_update_policy.</summary>
    [JsonPropertyName("automaticUpdatePolicy")]
    public V1beta2FunctionSpecForProviderAutomaticUpdatePolicy? AutomaticUpdatePolicy { get; set; }

    /// <summary>Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.</summary>
    [JsonPropertyName("availableMemoryMb")]
    public double? AvailableMemoryMb { get; set; }

    /// <summary>A set of key/value environment variable pairs available during build time.</summary>
    [JsonPropertyName("buildEnvironmentVariables")]
    public IDictionary<string, string>? BuildEnvironmentVariables { get; set; }

    /// <summary>If provided, the self-provided service account to use to build the function. The format of this field is projects/{project}/serviceAccounts/{serviceAccountEmail}</summary>
    [JsonPropertyName("buildServiceAccount")]
    public string? BuildServiceAccount { get; set; }

    /// <summary>Name of the Cloud Build Custom Worker Pool that should be used to build the function.</summary>
    [JsonPropertyName("buildWorkerPool")]
    public string? BuildWorkerPool { get; set; }

    /// <summary>Description of the function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker Registry to use for storing the function&apos;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.</summary>
    [JsonPropertyName("dockerRegistry")]
    public string? DockerRegistry { get; set; }

    /// <summary>User-managed repository created in Artifact Registry to which the function&apos;s Docker image will be pushed after it is built by Cloud Build. May optionally be encrypted with a customer-managed encryption key (CMEK). If unspecified and docker_registry is not explicitly set to CONTAINER_REGISTRY, GCF will create and use a default Artifact Registry repository named &apos;gcf-artifacts&apos; in the region.</summary>
    [JsonPropertyName("dockerRepository")]
    public string? DockerRepository { get; set; }

    /// <summary>Name of the function that will be executed when the Google Cloud Function is triggered.</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>A set of key/value environment variable pairs to assign to the function.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with trigger_http.</summary>
    [JsonPropertyName("eventTrigger")]
    public V1beta2FunctionSpecForProviderEventTrigger? EventTrigger { get; set; }

    /// <summary>The security level for the function. The following options are available:</summary>
    [JsonPropertyName("httpsTriggerSecurityLevel")]
    public string? HttpsTriggerSecurityLevel { get; set; }

    /// <summary>URL which triggers function execution. Returned only if trigger_http is used.</summary>
    [JsonPropertyName("httpsTriggerUrl")]
    public string? HttpsTriggerUrl { get; set; }

    /// <summary>String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL, ALLOW_INTERNAL_AND_GCLB and ALLOW_INTERNAL_ONLY. Check ingress documentation to see the impact of each settings value. Changes to this field will recreate the cloud function.</summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources. It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// If specified, you must also provide an artifact registry repository using the docker_repository field that was created with the same KMS crypto key. Before deploying, please complete all pre-requisites described in https://cloud.google.com/functions/docs/securing/cmek#granting_service_accounts_access_to_the_key
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The limit on the maximum number of function instances that may coexist at a given time.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>The limit on the minimum number of function instances that may coexist at a given time.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>Security patches are only applied when a function is redeployed. This should be specified as an empty block and cannot be set alongside automatic_update_policy. Structure is documented below.</summary>
    [JsonPropertyName("onDeployUpdatePolicy")]
    public V1beta2FunctionSpecForProviderOnDeployUpdatePolicy? OnDeployUpdatePolicy { get; set; }

    /// <summary>Project of the function. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region of function. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// The runtime in which the function is going to run.
    /// Eg. &quot;nodejs20&quot;, &quot;python39&quot;, &quot;dotnet3&quot;, &quot;go116&quot;, &quot;java11&quot;, &quot;ruby30&quot;, &quot;php74&quot;, etc. Check the official doc for the up-to-date list.
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secret environment variables configuration. Structure is documented below.</summary>
    [JsonPropertyName("secretEnvironmentVariables")]
    public IList<V1beta2FunctionSpecForProviderSecretEnvironmentVariables>? SecretEnvironmentVariables { get; set; }

    /// <summary>Secret volumes configuration. Structure is documented below.</summary>
    [JsonPropertyName("secretVolumes")]
    public IList<V1beta2FunctionSpecForProviderSecretVolumes>? SecretVolumes { get; set; }

    /// <summary>If provided, the self-provided service account to run the function with.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The GCS bucket containing the zip archive which contains the function.</summary>
    [JsonPropertyName("sourceArchiveBucket")]
    public string? SourceArchiveBucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate sourceArchiveBucket.</summary>
    [JsonPropertyName("sourceArchiveBucketRef")]
    public V1beta2FunctionSpecForProviderSourceArchiveBucketRef? SourceArchiveBucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate sourceArchiveBucket.</summary>
    [JsonPropertyName("sourceArchiveBucketSelector")]
    public V1beta2FunctionSpecForProviderSourceArchiveBucketSelector? SourceArchiveBucketSelector { get; set; }

    /// <summary>The source archive object (file) in archive bucket.</summary>
    [JsonPropertyName("sourceArchiveObject")]
    public string? SourceArchiveObject { get; set; }

    /// <summary>Reference to a BucketObject in storage to populate sourceArchiveObject.</summary>
    [JsonPropertyName("sourceArchiveObjectRef")]
    public V1beta2FunctionSpecForProviderSourceArchiveObjectRef? SourceArchiveObjectRef { get; set; }

    /// <summary>Selector for a BucketObject in storage to populate sourceArchiveObject.</summary>
    [JsonPropertyName("sourceArchiveObjectSelector")]
    public V1beta2FunctionSpecForProviderSourceArchiveObjectSelector? SourceArchiveObjectSelector { get; set; }

    /// <summary>
    /// Represents parameters related to source repository where a function is hosted.
    /// Cannot be set alongside source_archive_bucket or source_archive_object. Structure is documented below. It must match the pattern projects/{project}/locations/{location}/repositories/{repository}.*
    /// </summary>
    [JsonPropertyName("sourceRepository")]
    public V1beta2FunctionSpecForProviderSourceRepository? SourceRepository { get; set; }

    /// <summary>Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with event_trigger.</summary>
    [JsonPropertyName("triggerHttp")]
    public bool? TriggerHttp { get; set; }

    /// <summary>The VPC Network Connector that this cloud function can connect to. It should be set up as fully-qualified URI. The format of this field is projects/*/locations/*/connectors/*.</summary>
    [JsonPropertyName("vpcConnector")]
    public string? VpcConnector { get; set; }

    /// <summary>The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.</summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }
}

/// <summary>Security patches are applied automatically to the runtime without requiring the function to be redeployed. This should be specified as an empty block and cannot be set alongside on_deploy_update_policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderAutomaticUpdatePolicy
{
}

/// <summary>Specifies policy for failed executions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerFailurePolicy
{
    /// <summary>Whether the function should be retried on failure. Defaults to false.</summary>
    [JsonPropertyName("retry")]
    public bool? Retry { get; set; }
}

/// <summary>A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with trigger_http.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTrigger
{
    /// <summary>
    /// The type of event to observe. For example: &quot;google.storage.object.finalize&quot;.
    /// See the documentation on calling Cloud Functions for a
    /// full reference of accepted triggers.
    /// </summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies policy for failed executions. Structure is documented below.</summary>
    [JsonPropertyName("failurePolicy")]
    public V1beta2FunctionSpecInitProviderEventTriggerFailurePolicy? FailurePolicy { get; set; }

    /// <summary>
    /// Required. The name or partial URI of the resource from
    /// which to observe events. For example, &quot;myBucket&quot; or &quot;projects/my-project/topics/my-topic&quot;
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Security patches are only applied when a function is redeployed. This should be specified as an empty block and cannot be set alongside automatic_update_policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderOnDeployUpdatePolicy
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSecretEnvironmentVariables
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&apos;s project, assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>ID of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Version of the secret (version number or the string &quot;latest&quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSecretVolumesVersions
{
    /// <summary>Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mount_path as &quot;/etc/secrets&quot; and path as &quot;/secret_foo&quot; would mount the secret value file at &quot;/etc/secrets/secret_foo&quot;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Version of the secret (version number or the string &quot;latest&quot;). It is preferable to use &quot;latest&quot; version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSecretVolumes
{
    /// <summary>The path within the container to mount the secret volume. For example, setting the mount_path as &quot;/etc/secrets&quot; would mount the secret value files under the &quot;/etc/secrets&quot; directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount paths: &quot;/etc/secrets&quot; Restricted mount paths: &quot;/cloudsql&quot;, &quot;/dev/log&quot;, &quot;/pod&quot;, &quot;/proc&quot;, &quot;/var/log&quot;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&apos;s project, assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>ID of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>List of secret versions to mount for this secret. If empty, the &quot;latest&quot; version of the secret will be made available in a file named after the secret under the mount point. Structure is documented below.</summary>
    [JsonPropertyName("versions")]
    public IList<V1beta2FunctionSpecInitProviderSecretVolumesVersions>? Versions { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate sourceArchiveBucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate sourceArchiveBucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveBucketSelector
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
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketObject in storage to populate sourceArchiveObject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveObjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketObject in storage to populate sourceArchiveObject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceArchiveObjectSelector
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
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents parameters related to source repository where a function is hosted.
/// Cannot be set alongside source_archive_bucket or source_archive_object. Structure is documented below. It must match the pattern projects/{project}/locations/{location}/repositories/{repository}.*
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderSourceRepository
{
    /// <summary>The URL pointing to the hosted repository where the function is defined. There are supported Cloud Source Repository URLs in the following formats:</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
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
public partial class V1beta2FunctionSpecInitProvider
{
    /// <summary>Security patches are applied automatically to the runtime without requiring the function to be redeployed. This should be specified as an empty block and cannot be set alongside on_deploy_update_policy.</summary>
    [JsonPropertyName("automaticUpdatePolicy")]
    public V1beta2FunctionSpecInitProviderAutomaticUpdatePolicy? AutomaticUpdatePolicy { get; set; }

    /// <summary>Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.</summary>
    [JsonPropertyName("availableMemoryMb")]
    public double? AvailableMemoryMb { get; set; }

    /// <summary>A set of key/value environment variable pairs available during build time.</summary>
    [JsonPropertyName("buildEnvironmentVariables")]
    public IDictionary<string, string>? BuildEnvironmentVariables { get; set; }

    /// <summary>If provided, the self-provided service account to use to build the function. The format of this field is projects/{project}/serviceAccounts/{serviceAccountEmail}</summary>
    [JsonPropertyName("buildServiceAccount")]
    public string? BuildServiceAccount { get; set; }

    /// <summary>Name of the Cloud Build Custom Worker Pool that should be used to build the function.</summary>
    [JsonPropertyName("buildWorkerPool")]
    public string? BuildWorkerPool { get; set; }

    /// <summary>Description of the function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker Registry to use for storing the function&apos;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.</summary>
    [JsonPropertyName("dockerRegistry")]
    public string? DockerRegistry { get; set; }

    /// <summary>User-managed repository created in Artifact Registry to which the function&apos;s Docker image will be pushed after it is built by Cloud Build. May optionally be encrypted with a customer-managed encryption key (CMEK). If unspecified and docker_registry is not explicitly set to CONTAINER_REGISTRY, GCF will create and use a default Artifact Registry repository named &apos;gcf-artifacts&apos; in the region.</summary>
    [JsonPropertyName("dockerRepository")]
    public string? DockerRepository { get; set; }

    /// <summary>Name of the function that will be executed when the Google Cloud Function is triggered.</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>A set of key/value environment variable pairs to assign to the function.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with trigger_http.</summary>
    [JsonPropertyName("eventTrigger")]
    public V1beta2FunctionSpecInitProviderEventTrigger? EventTrigger { get; set; }

    /// <summary>The security level for the function. The following options are available:</summary>
    [JsonPropertyName("httpsTriggerSecurityLevel")]
    public string? HttpsTriggerSecurityLevel { get; set; }

    /// <summary>URL which triggers function execution. Returned only if trigger_http is used.</summary>
    [JsonPropertyName("httpsTriggerUrl")]
    public string? HttpsTriggerUrl { get; set; }

    /// <summary>String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL, ALLOW_INTERNAL_AND_GCLB and ALLOW_INTERNAL_ONLY. Check ingress documentation to see the impact of each settings value. Changes to this field will recreate the cloud function.</summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources. It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// If specified, you must also provide an artifact registry repository using the docker_repository field that was created with the same KMS crypto key. Before deploying, please complete all pre-requisites described in https://cloud.google.com/functions/docs/securing/cmek#granting_service_accounts_access_to_the_key
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The limit on the maximum number of function instances that may coexist at a given time.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>The limit on the minimum number of function instances that may coexist at a given time.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>Security patches are only applied when a function is redeployed. This should be specified as an empty block and cannot be set alongside automatic_update_policy. Structure is documented below.</summary>
    [JsonPropertyName("onDeployUpdatePolicy")]
    public V1beta2FunctionSpecInitProviderOnDeployUpdatePolicy? OnDeployUpdatePolicy { get; set; }

    /// <summary>Project of the function. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The runtime in which the function is going to run.
    /// Eg. &quot;nodejs20&quot;, &quot;python39&quot;, &quot;dotnet3&quot;, &quot;go116&quot;, &quot;java11&quot;, &quot;ruby30&quot;, &quot;php74&quot;, etc. Check the official doc for the up-to-date list.
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secret environment variables configuration. Structure is documented below.</summary>
    [JsonPropertyName("secretEnvironmentVariables")]
    public IList<V1beta2FunctionSpecInitProviderSecretEnvironmentVariables>? SecretEnvironmentVariables { get; set; }

    /// <summary>Secret volumes configuration. Structure is documented below.</summary>
    [JsonPropertyName("secretVolumes")]
    public IList<V1beta2FunctionSpecInitProviderSecretVolumes>? SecretVolumes { get; set; }

    /// <summary>If provided, the self-provided service account to run the function with.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The GCS bucket containing the zip archive which contains the function.</summary>
    [JsonPropertyName("sourceArchiveBucket")]
    public string? SourceArchiveBucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate sourceArchiveBucket.</summary>
    [JsonPropertyName("sourceArchiveBucketRef")]
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketRef? SourceArchiveBucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate sourceArchiveBucket.</summary>
    [JsonPropertyName("sourceArchiveBucketSelector")]
    public V1beta2FunctionSpecInitProviderSourceArchiveBucketSelector? SourceArchiveBucketSelector { get; set; }

    /// <summary>The source archive object (file) in archive bucket.</summary>
    [JsonPropertyName("sourceArchiveObject")]
    public string? SourceArchiveObject { get; set; }

    /// <summary>Reference to a BucketObject in storage to populate sourceArchiveObject.</summary>
    [JsonPropertyName("sourceArchiveObjectRef")]
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectRef? SourceArchiveObjectRef { get; set; }

    /// <summary>Selector for a BucketObject in storage to populate sourceArchiveObject.</summary>
    [JsonPropertyName("sourceArchiveObjectSelector")]
    public V1beta2FunctionSpecInitProviderSourceArchiveObjectSelector? SourceArchiveObjectSelector { get; set; }

    /// <summary>
    /// Represents parameters related to source repository where a function is hosted.
    /// Cannot be set alongside source_archive_bucket or source_archive_object. Structure is documented below. It must match the pattern projects/{project}/locations/{location}/repositories/{repository}.*
    /// </summary>
    [JsonPropertyName("sourceRepository")]
    public V1beta2FunctionSpecInitProviderSourceRepository? SourceRepository { get; set; }

    /// <summary>Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with event_trigger.</summary>
    [JsonPropertyName("triggerHttp")]
    public bool? TriggerHttp { get; set; }

    /// <summary>The VPC Network Connector that this cloud function can connect to. It should be set up as fully-qualified URI. The format of this field is projects/*/locations/*/connectors/*.</summary>
    [JsonPropertyName("vpcConnector")]
    public string? VpcConnector { get; set; }

    /// <summary>The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.</summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecManagementPoliciesEnum>))]
public enum V1beta2FunctionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FunctionSpec defines the desired state of Function</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpec
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
    public V1beta2FunctionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FunctionSpecForProvider ForProvider { get; set; }

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
    public V1beta2FunctionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FunctionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FunctionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FunctionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Security patches are applied automatically to the runtime without requiring the function to be redeployed. This should be specified as an empty block and cannot be set alongside on_deploy_update_policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderAutomaticUpdatePolicy
{
}

/// <summary>Specifies policy for failed executions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderEventTriggerFailurePolicy
{
    /// <summary>Whether the function should be retried on failure. Defaults to false.</summary>
    [JsonPropertyName("retry")]
    public bool? Retry { get; set; }
}

/// <summary>A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with trigger_http.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderEventTrigger
{
    /// <summary>
    /// The type of event to observe. For example: &quot;google.storage.object.finalize&quot;.
    /// See the documentation on calling Cloud Functions for a
    /// full reference of accepted triggers.
    /// </summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies policy for failed executions. Structure is documented below.</summary>
    [JsonPropertyName("failurePolicy")]
    public V1beta2FunctionStatusAtProviderEventTriggerFailurePolicy? FailurePolicy { get; set; }

    /// <summary>
    /// Required. The name or partial URI of the resource from
    /// which to observe events. For example, &quot;myBucket&quot; or &quot;projects/my-project/topics/my-topic&quot;
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Security patches are only applied when a function is redeployed. This should be specified as an empty block and cannot be set alongside automatic_update_policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderOnDeployUpdatePolicy
{
    /// <summary>(Output) The runtime version which was used during latest function deployment.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderSecretEnvironmentVariables
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&apos;s project, assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>ID of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Version of the secret (version number or the string &quot;latest&quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderSecretVolumesVersions
{
    /// <summary>Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mount_path as &quot;/etc/secrets&quot; and path as &quot;/secret_foo&quot; would mount the secret value file at &quot;/etc/secrets/secret_foo&quot;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Version of the secret (version number or the string &quot;latest&quot;). It is preferable to use &quot;latest&quot; version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderSecretVolumes
{
    /// <summary>The path within the container to mount the secret volume. For example, setting the mount_path as &quot;/etc/secrets&quot; would mount the secret value files under the &quot;/etc/secrets&quot; directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount paths: &quot;/etc/secrets&quot; Restricted mount paths: &quot;/cloudsql&quot;, &quot;/dev/log&quot;, &quot;/pod&quot;, &quot;/proc&quot;, &quot;/var/log&quot;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&apos;s project, assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>ID of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>List of secret versions to mount for this secret. If empty, the &quot;latest&quot; version of the secret will be made available in a file named after the secret under the mount point. Structure is documented below.</summary>
    [JsonPropertyName("versions")]
    public IList<V1beta2FunctionStatusAtProviderSecretVolumesVersions>? Versions { get; set; }
}

/// <summary>
/// Represents parameters related to source repository where a function is hosted.
/// Cannot be set alongside source_archive_bucket or source_archive_object. Structure is documented below. It must match the pattern projects/{project}/locations/{location}/repositories/{repository}.*
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderSourceRepository
{
    /// <summary>The URL pointing to the hosted repository where the function was defined at the time of deployment.</summary>
    [JsonPropertyName("deployedUrl")]
    public string? DeployedUrl { get; set; }

    /// <summary>The URL pointing to the hosted repository where the function is defined. There are supported Cloud Source Repository URLs in the following formats:</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProvider
{
    /// <summary>Security patches are applied automatically to the runtime without requiring the function to be redeployed. This should be specified as an empty block and cannot be set alongside on_deploy_update_policy.</summary>
    [JsonPropertyName("automaticUpdatePolicy")]
    public V1beta2FunctionStatusAtProviderAutomaticUpdatePolicy? AutomaticUpdatePolicy { get; set; }

    /// <summary>Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.</summary>
    [JsonPropertyName("availableMemoryMb")]
    public double? AvailableMemoryMb { get; set; }

    /// <summary>A set of key/value environment variable pairs available during build time.</summary>
    [JsonPropertyName("buildEnvironmentVariables")]
    public IDictionary<string, string>? BuildEnvironmentVariables { get; set; }

    /// <summary>If provided, the self-provided service account to use to build the function. The format of this field is projects/{project}/serviceAccounts/{serviceAccountEmail}</summary>
    [JsonPropertyName("buildServiceAccount")]
    public string? BuildServiceAccount { get; set; }

    /// <summary>Name of the Cloud Build Custom Worker Pool that should be used to build the function.</summary>
    [JsonPropertyName("buildWorkerPool")]
    public string? BuildWorkerPool { get; set; }

    /// <summary>Description of the function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker Registry to use for storing the function&apos;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.</summary>
    [JsonPropertyName("dockerRegistry")]
    public string? DockerRegistry { get; set; }

    /// <summary>User-managed repository created in Artifact Registry to which the function&apos;s Docker image will be pushed after it is built by Cloud Build. May optionally be encrypted with a customer-managed encryption key (CMEK). If unspecified and docker_registry is not explicitly set to CONTAINER_REGISTRY, GCF will create and use a default Artifact Registry repository named &apos;gcf-artifacts&apos; in the region.</summary>
    [JsonPropertyName("dockerRepository")]
    public string? DockerRepository { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Name of the function that will be executed when the Google Cloud Function is triggered.</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>A set of key/value environment variable pairs to assign to the function.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with trigger_http.</summary>
    [JsonPropertyName("eventTrigger")]
    public V1beta2FunctionStatusAtProviderEventTrigger? EventTrigger { get; set; }

    /// <summary>The security level for the function. The following options are available:</summary>
    [JsonPropertyName("httpsTriggerSecurityLevel")]
    public string? HttpsTriggerSecurityLevel { get; set; }

    /// <summary>URL which triggers function execution. Returned only if trigger_http is used.</summary>
    [JsonPropertyName("httpsTriggerUrl")]
    public string? HttpsTriggerUrl { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL, ALLOW_INTERNAL_AND_GCLB and ALLOW_INTERNAL_ONLY. Check ingress documentation to see the impact of each settings value. Changes to this field will recreate the cloud function.</summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources. It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// If specified, you must also provide an artifact registry repository using the docker_repository field that was created with the same KMS crypto key. Before deploying, please complete all pre-requisites described in https://cloud.google.com/functions/docs/securing/cmek#granting_service_accounts_access_to_the_key
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The limit on the maximum number of function instances that may coexist at a given time.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>The limit on the minimum number of function instances that may coexist at a given time.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>Security patches are only applied when a function is redeployed. This should be specified as an empty block and cannot be set alongside automatic_update_policy. Structure is documented below.</summary>
    [JsonPropertyName("onDeployUpdatePolicy")]
    public V1beta2FunctionStatusAtProviderOnDeployUpdatePolicy? OnDeployUpdatePolicy { get; set; }

    /// <summary>Project of the function. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region of function. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The runtime in which the function is going to run.
    /// Eg. &quot;nodejs20&quot;, &quot;python39&quot;, &quot;dotnet3&quot;, &quot;go116&quot;, &quot;java11&quot;, &quot;ruby30&quot;, &quot;php74&quot;, etc. Check the official doc for the up-to-date list.
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secret environment variables configuration. Structure is documented below.</summary>
    [JsonPropertyName("secretEnvironmentVariables")]
    public IList<V1beta2FunctionStatusAtProviderSecretEnvironmentVariables>? SecretEnvironmentVariables { get; set; }

    /// <summary>Secret volumes configuration. Structure is documented below.</summary>
    [JsonPropertyName("secretVolumes")]
    public IList<V1beta2FunctionStatusAtProviderSecretVolumes>? SecretVolumes { get; set; }

    /// <summary>If provided, the self-provided service account to run the function with.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The GCS bucket containing the zip archive which contains the function.</summary>
    [JsonPropertyName("sourceArchiveBucket")]
    public string? SourceArchiveBucket { get; set; }

    /// <summary>The source archive object (file) in archive bucket.</summary>
    [JsonPropertyName("sourceArchiveObject")]
    public string? SourceArchiveObject { get; set; }

    /// <summary>
    /// Represents parameters related to source repository where a function is hosted.
    /// Cannot be set alongside source_archive_bucket or source_archive_object. Structure is documented below. It must match the pattern projects/{project}/locations/{location}/repositories/{repository}.*
    /// </summary>
    [JsonPropertyName("sourceRepository")]
    public V1beta2FunctionStatusAtProviderSourceRepository? SourceRepository { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with event_trigger.</summary>
    [JsonPropertyName("triggerHttp")]
    public bool? TriggerHttp { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    /// <summary>The VPC Network Connector that this cloud function can connect to. It should be set up as fully-qualified URI. The format of this field is projects/*/locations/*/connectors/*.</summary>
    [JsonPropertyName("vpcConnector")]
    public string? VpcConnector { get; set; }

    /// <summary>The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.</summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusConditions
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

/// <summary>FunctionStatus defines the observed state of Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FunctionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Function is the Schema for the Functions API. Creates a new Cloud Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FunctionSpec>, IStatus<V1beta2FunctionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Function";
    public const string KubeGroup = "cloudfunctions.gcp.upbound.io";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfunctions.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Function";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionSpec defines the desired state of Function</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FunctionSpec Spec { get; set; }

    /// <summary>FunctionStatus defines the observed state of Function.</summary>
    [JsonPropertyName("status")]
    public V1beta2FunctionStatus? Status { get; set; }
}
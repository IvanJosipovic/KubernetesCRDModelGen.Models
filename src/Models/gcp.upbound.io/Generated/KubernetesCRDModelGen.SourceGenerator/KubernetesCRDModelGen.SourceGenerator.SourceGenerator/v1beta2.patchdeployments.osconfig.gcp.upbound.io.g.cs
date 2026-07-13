#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.osconfig.gcp.upbound.io;
/// <summary>PatchDeployment is the Schema for the PatchDeployments API. Patch deployments are configurations that individual patch jobs use to complete a patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PatchDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1beta2PatchDeployment>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PatchDeploymentList";
    public const string KubeGroup = "osconfig.gcp.upbound.io";
    public const string KubePluralName = "patchdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "osconfig.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PatchDeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2PatchDeployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2PatchDeployment> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecDeletionPolicyEnum>))]
public enum V1beta2PatchDeploymentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderInstanceFilterGroupLabels
{
    /// <summary>Compute Engine instance labels that must be present for a VM instance to be targeted by this filter</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicyResolutionEnum>))]
public enum V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicyResolveEnum>))]
public enum V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicyResolutionEnum>))]
public enum V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicyResolveEnum>))]
public enum V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in compute to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelector
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
    public V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// VM instances to patch.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderInstanceFilter
{
    /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>
    /// Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupLabels")]
    public IList<V1beta2PatchDeploymentSpecForProviderInstanceFilterGroupLabels>? GroupLabels { get; set; }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&quot;prod-&quot;.
    /// </summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the form zones/{{zone}}/instances/{{instance_name}},
    /// projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}, or
    /// https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}
    /// </summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta2PatchDeploymentSpecForProviderInstanceFilterInstancesSelector? InstancesSelector { get; set; }

    /// <summary>Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Schedule a one-time execution.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderOneTimeSchedule
{
    /// <summary>
    /// The desired patch job execution time. A timestamp in RFC3339 UTC &quot;Zulu&quot; format,
    /// accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("executeTime")]
    public string? ExecuteTime { get; set; }
}

/// <summary>
/// Apt update settings. Use this setting to override the default apt patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigApt
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>
    /// By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead.
    /// Possible values are: DIST, UPGRADE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// goo update settings. Use this setting to override the default goo patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigGoo
{
    /// <summary>goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// The ExecStep to run after the patch update.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPostStep
{
    /// <summary>
    /// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>
    /// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// The ExecStep to run before the patch update.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigPreStep
{
    /// <summary>
    /// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>
    /// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>
/// Windows update settings. Use this setting to override the default Windows patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigWindowsUpdate
{
    /// <summary>
    /// Only apply updates of these windows update classifications. If empty, all updates are applied.
    /// Each value may be one of: CRITICAL, SECURITY, DEFINITION, DRIVER, FEATURE_PACK, SERVICE_PACK, TOOL, UPDATE_ROLLUP, UPDATE.
    /// </summary>
    [JsonPropertyName("classifications")]
    public IList<string>? Classifications { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of patches to be updated. These are the only patches that will be installed using &apos;zypper patch patch:&apos; command.
    /// This field must not be used with any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }
}

/// <summary>
/// Yum update settings. Use this setting to override the default yum patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigYum
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Will cause patch to run yum update-minimal instead.</summary>
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; set; }

    /// <summary>Adds the --security flag to yum update. Not supported on all platforms.</summary>
    [JsonPropertyName("security")]
    public bool? Security { get; set; }
}

/// <summary>
/// zypper update settings. Use this setting to override the default zypper patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfigZypper
{
    /// <summary>Install only patches with these categories. Common categories include security, recommended, and feature.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of patches to be updated. These are the only patches that will be installed using &apos;zypper patch patch:&apos; command.
    /// This field must not be used with any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }

    /// <summary>Install only patches with these severities. Common severities include critical, important, moderate, and low.</summary>
    [JsonPropertyName("severities")]
    public IList<string>? Severities { get; set; }

    /// <summary>Adds the --with-optional flag to zypper patch.</summary>
    [JsonPropertyName("withOptional")]
    public bool? WithOptional { get; set; }

    /// <summary>Adds the --with-update flag, to zypper patch.</summary>
    [JsonPropertyName("withUpdate")]
    public bool? WithUpdate { get; set; }
}

/// <summary>
/// Patch configuration that is applied.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderPatchConfig
{
    /// <summary>
    /// Apt update settings. Use this setting to override the default apt patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigApt? Apt { get; set; }

    /// <summary>
    /// goo update settings. Use this setting to override the default goo patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goo")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigGoo? Goo { get; set; }

    /// <summary>Allows the patch job to run on Managed instance groups (MIGs).</summary>
    [JsonPropertyName("migInstancesAllowed")]
    public bool? MigInstancesAllowed { get; set; }

    /// <summary>
    /// The ExecStep to run after the patch update.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postStep")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPostStep? PostStep { get; set; }

    /// <summary>
    /// The ExecStep to run before the patch update.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("preStep")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigPreStep? PreStep { get; set; }

    /// <summary>
    /// Post-patch reboot settings.
    /// Possible values are: DEFAULT, ALWAYS, NEVER.
    /// </summary>
    [JsonPropertyName("rebootConfig")]
    public string? RebootConfig { get; set; }

    /// <summary>
    /// Windows update settings. Use this setting to override the default Windows patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsUpdate")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigWindowsUpdate? WindowsUpdate { get; set; }

    /// <summary>
    /// Yum update settings. Use this setting to override the default yum patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigYum? Yum { get; set; }

    /// <summary>
    /// zypper update settings. Use this setting to override the default zypper patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfigZypper? Zypper { get; set; }
}

/// <summary>
/// Week day in a month.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRecurringScheduleMonthlyWeekDayOfMonth
{
    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Represents the number of days before or after the given week day of month that the patch deployment is scheduled for.</summary>
    [JsonPropertyName("dayOffset")]
    public double? DayOffset { get; set; }

    /// <summary>Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.</summary>
    [JsonPropertyName("weekOrdinal")]
    public double? WeekOrdinal { get; set; }
}

/// <summary>
/// Schedule with monthly executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRecurringScheduleMonthly
{
    /// <summary>
    /// One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month.
    /// Months without the target day will be skipped. For example, a schedule to run &quot;every month on the 31st&quot;
    /// will not run in February, April, June, etc.
    /// </summary>
    [JsonPropertyName("monthDay")]
    public double? MonthDay { get; set; }

    /// <summary>
    /// Week day in a month.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weekDayOfMonth")]
    public V1beta2PatchDeploymentSpecForProviderRecurringScheduleMonthlyWeekDayOfMonth? WeekDayOfMonth { get; set; }
}

/// <summary>
/// Time of the day to run a recurring deployment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRecurringScheduleTimeOfDay
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are
/// determined by the chosen time zone.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRecurringScheduleTimeZone
{
    /// <summary>IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IANA Time Zone Database version number, e.g. &quot;2019a&quot;.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Schedule with weekly executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRecurringScheduleWeekly
{
    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }
}

/// <summary>
/// Schedule recurring executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRecurringSchedule
{
    /// <summary>
    /// The end time at which a recurring patch deployment schedule is no longer active.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Schedule with monthly executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("monthly")]
    public V1beta2PatchDeploymentSpecForProviderRecurringScheduleMonthly? Monthly { get; set; }

    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Time of the day to run a recurring deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeOfDay")]
    public V1beta2PatchDeploymentSpecForProviderRecurringScheduleTimeOfDay? TimeOfDay { get; set; }

    /// <summary>
    /// Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are
    /// determined by the chosen time zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public V1beta2PatchDeploymentSpecForProviderRecurringScheduleTimeZone? TimeZone { get; set; }

    /// <summary>
    /// Schedule with weekly executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weekly")]
    public V1beta2PatchDeploymentSpecForProviderRecurringScheduleWeekly? Weekly { get; set; }
}

/// <summary>
/// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up.
/// During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps.
/// A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget.
/// For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone.
/// For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Rollout strategy of the patch job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProviderRollout
{
    /// <summary>
    /// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up.
    /// During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps.
    /// A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget.
    /// For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone.
    /// For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta2PatchDeploymentSpecForProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>
    /// Mode of the patch rollout.
    /// Possible values are: ZONE_BY_ZONE, CONCURRENT_ZONES.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecForProvider
{
    /// <summary>Description of the patch deployment. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// VM instances to patch.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta2PatchDeploymentSpecForProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>
    /// Schedule a one-time execution.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oneTimeSchedule")]
    public V1beta2PatchDeploymentSpecForProviderOneTimeSchedule? OneTimeSchedule { get; set; }

    /// <summary>
    /// Patch configuration that is applied.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("patchConfig")]
    public V1beta2PatchDeploymentSpecForProviderPatchConfig? PatchConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Schedule recurring executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recurringSchedule")]
    public V1beta2PatchDeploymentSpecForProviderRecurringSchedule? RecurringSchedule { get; set; }

    /// <summary>
    /// Rollout strategy of the patch job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rollout")]
    public V1beta2PatchDeploymentSpecForProviderRollout? Rollout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderInstanceFilterGroupLabels
{
    /// <summary>Compute Engine instance labels that must be present for a VM instance to be targeted by this filter</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicyResolutionEnum>))]
public enum V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicyResolveEnum>))]
public enum V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicyResolutionEnum>))]
public enum V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicyResolveEnum>))]
public enum V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in compute to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelector
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
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// VM instances to patch.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderInstanceFilter
{
    /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>
    /// Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupLabels")]
    public IList<V1beta2PatchDeploymentSpecInitProviderInstanceFilterGroupLabels>? GroupLabels { get; set; }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&quot;prod-&quot;.
    /// </summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the form zones/{{zone}}/instances/{{instance_name}},
    /// projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}, or
    /// https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}
    /// </summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilterInstancesSelector? InstancesSelector { get; set; }

    /// <summary>Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Schedule a one-time execution.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderOneTimeSchedule
{
    /// <summary>
    /// The desired patch job execution time. A timestamp in RFC3339 UTC &quot;Zulu&quot; format,
    /// accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("executeTime")]
    public string? ExecuteTime { get; set; }
}

/// <summary>
/// Apt update settings. Use this setting to override the default apt patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigApt
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>
    /// By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead.
    /// Possible values are: DIST, UPGRADE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// goo update settings. Use this setting to override the default goo patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigGoo
{
    /// <summary>goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// The ExecStep to run after the patch update.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStep
{
    /// <summary>
    /// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>
    /// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// The ExecStep to run before the patch update.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStep
{
    /// <summary>
    /// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>
    /// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>
/// Windows update settings. Use this setting to override the default Windows patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigWindowsUpdate
{
    /// <summary>
    /// Only apply updates of these windows update classifications. If empty, all updates are applied.
    /// Each value may be one of: CRITICAL, SECURITY, DEFINITION, DRIVER, FEATURE_PACK, SERVICE_PACK, TOOL, UPDATE_ROLLUP, UPDATE.
    /// </summary>
    [JsonPropertyName("classifications")]
    public IList<string>? Classifications { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of patches to be updated. These are the only patches that will be installed using &apos;zypper patch patch:&apos; command.
    /// This field must not be used with any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }
}

/// <summary>
/// Yum update settings. Use this setting to override the default yum patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigYum
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Will cause patch to run yum update-minimal instead.</summary>
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; set; }

    /// <summary>Adds the --security flag to yum update. Not supported on all platforms.</summary>
    [JsonPropertyName("security")]
    public bool? Security { get; set; }
}

/// <summary>
/// zypper update settings. Use this setting to override the default zypper patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfigZypper
{
    /// <summary>Install only patches with these categories. Common categories include security, recommended, and feature.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of patches to be updated. These are the only patches that will be installed using &apos;zypper patch patch:&apos; command.
    /// This field must not be used with any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }

    /// <summary>Install only patches with these severities. Common severities include critical, important, moderate, and low.</summary>
    [JsonPropertyName("severities")]
    public IList<string>? Severities { get; set; }

    /// <summary>Adds the --with-optional flag to zypper patch.</summary>
    [JsonPropertyName("withOptional")]
    public bool? WithOptional { get; set; }

    /// <summary>Adds the --with-update flag, to zypper patch.</summary>
    [JsonPropertyName("withUpdate")]
    public bool? WithUpdate { get; set; }
}

/// <summary>
/// Patch configuration that is applied.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderPatchConfig
{
    /// <summary>
    /// Apt update settings. Use this setting to override the default apt patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigApt? Apt { get; set; }

    /// <summary>
    /// goo update settings. Use this setting to override the default goo patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goo")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigGoo? Goo { get; set; }

    /// <summary>Allows the patch job to run on Managed instance groups (MIGs).</summary>
    [JsonPropertyName("migInstancesAllowed")]
    public bool? MigInstancesAllowed { get; set; }

    /// <summary>
    /// The ExecStep to run after the patch update.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postStep")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPostStep? PostStep { get; set; }

    /// <summary>
    /// The ExecStep to run before the patch update.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("preStep")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigPreStep? PreStep { get; set; }

    /// <summary>
    /// Post-patch reboot settings.
    /// Possible values are: DEFAULT, ALWAYS, NEVER.
    /// </summary>
    [JsonPropertyName("rebootConfig")]
    public string? RebootConfig { get; set; }

    /// <summary>
    /// Windows update settings. Use this setting to override the default Windows patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsUpdate")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigWindowsUpdate? WindowsUpdate { get; set; }

    /// <summary>
    /// Yum update settings. Use this setting to override the default yum patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigYum? Yum { get; set; }

    /// <summary>
    /// zypper update settings. Use this setting to override the default zypper patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfigZypper? Zypper { get; set; }
}

/// <summary>
/// Week day in a month.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRecurringScheduleMonthlyWeekDayOfMonth
{
    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Represents the number of days before or after the given week day of month that the patch deployment is scheduled for.</summary>
    [JsonPropertyName("dayOffset")]
    public double? DayOffset { get; set; }

    /// <summary>Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.</summary>
    [JsonPropertyName("weekOrdinal")]
    public double? WeekOrdinal { get; set; }
}

/// <summary>
/// Schedule with monthly executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRecurringScheduleMonthly
{
    /// <summary>
    /// One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month.
    /// Months without the target day will be skipped. For example, a schedule to run &quot;every month on the 31st&quot;
    /// will not run in February, April, June, etc.
    /// </summary>
    [JsonPropertyName("monthDay")]
    public double? MonthDay { get; set; }

    /// <summary>
    /// Week day in a month.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weekDayOfMonth")]
    public V1beta2PatchDeploymentSpecInitProviderRecurringScheduleMonthlyWeekDayOfMonth? WeekDayOfMonth { get; set; }
}

/// <summary>
/// Time of the day to run a recurring deployment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRecurringScheduleTimeOfDay
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are
/// determined by the chosen time zone.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRecurringScheduleTimeZone
{
    /// <summary>IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IANA Time Zone Database version number, e.g. &quot;2019a&quot;.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Schedule with weekly executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRecurringScheduleWeekly
{
    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }
}

/// <summary>
/// Schedule recurring executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRecurringSchedule
{
    /// <summary>
    /// The end time at which a recurring patch deployment schedule is no longer active.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Schedule with monthly executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("monthly")]
    public V1beta2PatchDeploymentSpecInitProviderRecurringScheduleMonthly? Monthly { get; set; }

    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Time of the day to run a recurring deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeOfDay")]
    public V1beta2PatchDeploymentSpecInitProviderRecurringScheduleTimeOfDay? TimeOfDay { get; set; }

    /// <summary>
    /// Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are
    /// determined by the chosen time zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public V1beta2PatchDeploymentSpecInitProviderRecurringScheduleTimeZone? TimeZone { get; set; }

    /// <summary>
    /// Schedule with weekly executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weekly")]
    public V1beta2PatchDeploymentSpecInitProviderRecurringScheduleWeekly? Weekly { get; set; }
}

/// <summary>
/// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up.
/// During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps.
/// A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget.
/// For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone.
/// For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Rollout strategy of the patch job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecInitProviderRollout
{
    /// <summary>
    /// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up.
    /// During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps.
    /// A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget.
    /// For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone.
    /// For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta2PatchDeploymentSpecInitProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>
    /// Mode of the patch rollout.
    /// Possible values are: ZONE_BY_ZONE, CONCURRENT_ZONES.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
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
public partial class V1beta2PatchDeploymentSpecInitProvider
{
    /// <summary>Description of the patch deployment. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// VM instances to patch.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta2PatchDeploymentSpecInitProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>
    /// Schedule a one-time execution.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oneTimeSchedule")]
    public V1beta2PatchDeploymentSpecInitProviderOneTimeSchedule? OneTimeSchedule { get; set; }

    /// <summary>
    /// Patch configuration that is applied.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("patchConfig")]
    public V1beta2PatchDeploymentSpecInitProviderPatchConfig? PatchConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Schedule recurring executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recurringSchedule")]
    public V1beta2PatchDeploymentSpecInitProviderRecurringSchedule? RecurringSchedule { get; set; }

    /// <summary>
    /// Rollout strategy of the patch job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rollout")]
    public V1beta2PatchDeploymentSpecInitProviderRollout? Rollout { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecManagementPoliciesEnum>))]
public enum V1beta2PatchDeploymentSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2PatchDeploymentSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PatchDeploymentSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2PatchDeploymentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PatchDeploymentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PatchDeploymentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PatchDeploymentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PatchDeploymentSpec defines the desired state of PatchDeployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentSpec
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
    public V1beta2PatchDeploymentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2PatchDeploymentSpecForProvider ForProvider { get; set; }

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
    public V1beta2PatchDeploymentSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2PatchDeploymentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2PatchDeploymentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2PatchDeploymentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderInstanceFilterGroupLabels
{
    /// <summary>Compute Engine instance labels that must be present for a VM instance to be targeted by this filter</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// VM instances to patch.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderInstanceFilter
{
    /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>
    /// Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupLabels")]
    public IList<V1beta2PatchDeploymentStatusAtProviderInstanceFilterGroupLabels>? GroupLabels { get; set; }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&quot;prod-&quot;.
    /// </summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the form zones/{{zone}}/instances/{{instance_name}},
    /// projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}, or
    /// https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}
    /// </summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Schedule a one-time execution.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderOneTimeSchedule
{
    /// <summary>
    /// The desired patch job execution time. A timestamp in RFC3339 UTC &quot;Zulu&quot; format,
    /// accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("executeTime")]
    public string? ExecuteTime { get; set; }
}

/// <summary>
/// Apt update settings. Use this setting to override the default apt patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigApt
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>
    /// By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead.
    /// Possible values are: DIST, UPGRADE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// goo update settings. Use this setting to override the default goo patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigGoo
{
    /// <summary>goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// The ExecStep to run after the patch update.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStep
{
    /// <summary>
    /// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>
    /// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// A Cloud Storage object containing the executable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>
    /// A Cloud Storage object containing the executable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsObject")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines.
    /// Possible values are: SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>
/// The ExecStep to run before the patch update.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStep
{
    /// <summary>
    /// The ExecStepConfig for all Linux VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>
    /// The ExecStepConfig for all Windows VMs targeted by the PatchJob.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>
/// Windows update settings. Use this setting to override the default Windows patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigWindowsUpdate
{
    /// <summary>
    /// Only apply updates of these windows update classifications. If empty, all updates are applied.
    /// Each value may be one of: CRITICAL, SECURITY, DEFINITION, DRIVER, FEATURE_PACK, SERVICE_PACK, TOOL, UPDATE_ROLLUP, UPDATE.
    /// </summary>
    [JsonPropertyName("classifications")]
    public IList<string>? Classifications { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of patches to be updated. These are the only patches that will be installed using &apos;zypper patch patch:&apos; command.
    /// This field must not be used with any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }
}

/// <summary>
/// Yum update settings. Use this setting to override the default yum patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigYum
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Will cause patch to run yum update-minimal instead.</summary>
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; set; }

    /// <summary>Adds the --security flag to yum update. Not supported on all platforms.</summary>
    [JsonPropertyName("security")]
    public bool? Security { get; set; }
}

/// <summary>
/// zypper update settings. Use this setting to override the default zypper patch rules.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfigZypper
{
    /// <summary>Install only patches with these categories. Common categories include security, recommended, and feature.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>
    /// An exclusive list of patches to be updated. These are the only patches that will be installed using &apos;zypper patch patch:&apos; command.
    /// This field must not be used with any other patch configuration fields.
    /// </summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }

    /// <summary>Install only patches with these severities. Common severities include critical, important, moderate, and low.</summary>
    [JsonPropertyName("severities")]
    public IList<string>? Severities { get; set; }

    /// <summary>Adds the --with-optional flag to zypper patch.</summary>
    [JsonPropertyName("withOptional")]
    public bool? WithOptional { get; set; }

    /// <summary>Adds the --with-update flag, to zypper patch.</summary>
    [JsonPropertyName("withUpdate")]
    public bool? WithUpdate { get; set; }
}

/// <summary>
/// Patch configuration that is applied.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderPatchConfig
{
    /// <summary>
    /// Apt update settings. Use this setting to override the default apt patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigApt? Apt { get; set; }

    /// <summary>
    /// goo update settings. Use this setting to override the default goo patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goo")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigGoo? Goo { get; set; }

    /// <summary>Allows the patch job to run on Managed instance groups (MIGs).</summary>
    [JsonPropertyName("migInstancesAllowed")]
    public bool? MigInstancesAllowed { get; set; }

    /// <summary>
    /// The ExecStep to run after the patch update.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postStep")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPostStep? PostStep { get; set; }

    /// <summary>
    /// The ExecStep to run before the patch update.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("preStep")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigPreStep? PreStep { get; set; }

    /// <summary>
    /// Post-patch reboot settings.
    /// Possible values are: DEFAULT, ALWAYS, NEVER.
    /// </summary>
    [JsonPropertyName("rebootConfig")]
    public string? RebootConfig { get; set; }

    /// <summary>
    /// Windows update settings. Use this setting to override the default Windows patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsUpdate")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigWindowsUpdate? WindowsUpdate { get; set; }

    /// <summary>
    /// Yum update settings. Use this setting to override the default yum patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigYum? Yum { get; set; }

    /// <summary>
    /// zypper update settings. Use this setting to override the default zypper patch rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfigZypper? Zypper { get; set; }
}

/// <summary>
/// Week day in a month.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRecurringScheduleMonthlyWeekDayOfMonth
{
    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Represents the number of days before or after the given week day of month that the patch deployment is scheduled for.</summary>
    [JsonPropertyName("dayOffset")]
    public double? DayOffset { get; set; }

    /// <summary>Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.</summary>
    [JsonPropertyName("weekOrdinal")]
    public double? WeekOrdinal { get; set; }
}

/// <summary>
/// Schedule with monthly executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRecurringScheduleMonthly
{
    /// <summary>
    /// One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month.
    /// Months without the target day will be skipped. For example, a schedule to run &quot;every month on the 31st&quot;
    /// will not run in February, April, June, etc.
    /// </summary>
    [JsonPropertyName("monthDay")]
    public double? MonthDay { get; set; }

    /// <summary>
    /// Week day in a month.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weekDayOfMonth")]
    public V1beta2PatchDeploymentStatusAtProviderRecurringScheduleMonthlyWeekDayOfMonth? WeekDayOfMonth { get; set; }
}

/// <summary>
/// Time of the day to run a recurring deployment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRecurringScheduleTimeOfDay
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are
/// determined by the chosen time zone.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRecurringScheduleTimeZone
{
    /// <summary>IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IANA Time Zone Database version number, e.g. &quot;2019a&quot;.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Schedule with weekly executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRecurringScheduleWeekly
{
    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &quot;America/New_York&quot;.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }
}

/// <summary>
/// Schedule recurring executions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRecurringSchedule
{
    /// <summary>
    /// The end time at which a recurring patch deployment schedule is no longer active.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// (Output)
    /// The time the last patch job ran successfully.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("lastExecuteTime")]
    public string? LastExecuteTime { get; set; }

    /// <summary>
    /// Schedule with monthly executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("monthly")]
    public V1beta2PatchDeploymentStatusAtProviderRecurringScheduleMonthly? Monthly { get; set; }

    /// <summary>
    /// (Output)
    /// The time the next patch job is scheduled to run.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("nextExecuteTime")]
    public string? NextExecuteTime { get; set; }

    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Time of the day to run a recurring deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeOfDay")]
    public V1beta2PatchDeploymentStatusAtProviderRecurringScheduleTimeOfDay? TimeOfDay { get; set; }

    /// <summary>
    /// Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are
    /// determined by the chosen time zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public V1beta2PatchDeploymentStatusAtProviderRecurringScheduleTimeZone? TimeZone { get; set; }

    /// <summary>
    /// Schedule with weekly executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weekly")]
    public V1beta2PatchDeploymentStatusAtProviderRecurringScheduleWeekly? Weekly { get; set; }
}

/// <summary>
/// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up.
/// During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps.
/// A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget.
/// For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone.
/// For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Rollout strategy of the patch job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProviderRollout
{
    /// <summary>
    /// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up.
    /// During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps.
    /// A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget.
    /// For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone.
    /// For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta2PatchDeploymentStatusAtProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>
    /// Mode of the patch rollout.
    /// Possible values are: ZONE_BY_ZONE, CONCURRENT_ZONES.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusAtProvider
{
    /// <summary>
    /// Time the patch deployment was created. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Description of the patch deployment. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// VM instances to patch.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta2PatchDeploymentStatusAtProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>
    /// The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("lastExecuteTime")]
    public string? LastExecuteTime { get; set; }

    /// <summary>
    /// Unique name for the patch deployment resource in a project.
    /// The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Schedule a one-time execution.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oneTimeSchedule")]
    public V1beta2PatchDeploymentStatusAtProviderOneTimeSchedule? OneTimeSchedule { get; set; }

    /// <summary>
    /// Patch configuration that is applied.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("patchConfig")]
    public V1beta2PatchDeploymentStatusAtProviderPatchConfig? PatchConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Schedule recurring executions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recurringSchedule")]
    public V1beta2PatchDeploymentStatusAtProviderRecurringSchedule? RecurringSchedule { get; set; }

    /// <summary>
    /// Rollout strategy of the patch job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rollout")]
    public V1beta2PatchDeploymentStatusAtProviderRollout? Rollout { get; set; }

    /// <summary>
    /// Time the patch deployment was last updated. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatusConditions
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

/// <summary>PatchDeploymentStatus defines the observed state of PatchDeployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PatchDeploymentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2PatchDeploymentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2PatchDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PatchDeployment is the Schema for the PatchDeployments API. Patch deployments are configurations that individual patch jobs use to complete a patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PatchDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PatchDeploymentSpec>, IStatus<V1beta2PatchDeploymentStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PatchDeployment";
    public const string KubeGroup = "osconfig.gcp.upbound.io";
    public const string KubePluralName = "patchdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "osconfig.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PatchDeployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PatchDeploymentSpec defines the desired state of PatchDeployment</summary>
    [JsonPropertyName("spec")]
    public required V1beta2PatchDeploymentSpec Spec { get; set; }

    /// <summary>PatchDeploymentStatus defines the observed state of PatchDeployment.</summary>
    [JsonPropertyName("status")]
    public V1beta2PatchDeploymentStatus? Status { get; set; }
}
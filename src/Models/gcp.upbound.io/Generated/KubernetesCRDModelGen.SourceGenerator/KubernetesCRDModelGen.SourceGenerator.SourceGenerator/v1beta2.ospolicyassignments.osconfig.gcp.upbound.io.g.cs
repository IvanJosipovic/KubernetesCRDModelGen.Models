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
/// <summary>OsPolicyAssignment is the Schema for the OsPolicyAssignments API. OS policy assignment is an API resource that is used to apply a set of OS policies to a dynamically targeted group of Compute Engine VM instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2OsPolicyAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta2OsPolicyAssignment>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "OsPolicyAssignmentList";
    public const string KubeGroup = "osconfig.gcp.upbound.io";
    public const string KubePluralName = "ospolicyassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "osconfig.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OsPolicyAssignmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2OsPolicyAssignment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2OsPolicyAssignment> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OsPolicyAssignmentSpecDeletionPolicyEnum>))]
public enum V1beta2OsPolicyAssignmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderInstanceFilterExclusionLabels
{
    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this map to be
    /// selected.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderInstanceFilterInclusionLabels
{
    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this map to be
    /// selected.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderInstanceFilterInventories
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>
    /// The OS version Prefix matches are supported if
    /// asterisk(*) is provided as the last character. For example, to match all
    /// versions with a major version of 7, specify the following value for this
    /// field 7.* An empty string matches all OS versions.
    /// </summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>
/// Filter to select VMs. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderInstanceFilter
{
    /// <summary>
    /// Target all VMs in the project. If true, no other criteria
    /// is permitted.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>
    /// List of label sets used for VM exclusion. If
    /// the list has more than one label set, the VM is excluded if any of the label
    /// sets are applicable for the VM. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("exclusionLabels")]
    public IList<V1beta2OsPolicyAssignmentSpecForProviderInstanceFilterExclusionLabels>? ExclusionLabels { get; set; }

    /// <summary>
    /// List of label sets used for VM inclusion. If
    /// the list has more than one LabelSet, the VM is included if any of the
    /// label sets are applicable for the VM. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("inclusionLabels")]
    public IList<V1beta2OsPolicyAssignmentSpecForProviderInstanceFilterInclusionLabels>? InclusionLabels { get; set; }

    /// <summary>
    /// List of inventories to select VMs. A VM is
    /// selected if its inventory data matches at least one of the following
    /// inventories. Structure is documented below.
    /// </summary>
    [JsonPropertyName("inventories")]
    public IList<V1beta2OsPolicyAssignmentSpecForProviderInstanceFilterInventories>? Inventories { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsInventoryFilters
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>
    /// The OS version Prefix matches are supported if
    /// asterisk(*) is provided as the last character. For example, to match all
    /// versions with a major version of 7, specify the following value for this
    /// field 7.* An empty string matches all OS versions.
    /// </summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote? Remote { get; set; }
}

/// <summary>
/// What to run to bring this resource into the desired
/// state. An exit code of 100 indicates &quot;success&quot;, any other exit code
/// indicates a failure running enforce. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforce
{
    /// <summary>
    /// Optional arguments to pass to the source during
    /// execution.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFile? File { get; set; }

    /// <summary>
    /// The script interpreter to use. Possible values
    /// are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an
    /// output file (that is created by this Exec) whose content will be recorded in
    /// OSPolicyResourceCompliance after a successful run. Absence or failure to
    /// read this file will result in this ExecResource being non-compliant. Output
    /// file size is limited to 100K bytes.
    /// </summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>
    /// An inline script. The size of the script is limited to
    /// 1024 characters.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote? Remote { get; set; }
}

/// <summary>
/// What to run to validate this resource is in the
/// desired state. An exit code of 100 indicates &quot;in desired state&quot;, and exit
/// code of 101 indicates &quot;not in desired state&quot;. Any other exit code indicates
/// a failure running validate. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidate
{
    /// <summary>
    /// Optional arguments to pass to the source during
    /// execution.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFile? File { get; set; }

    /// <summary>
    /// The script interpreter to use. Possible values
    /// are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an
    /// output file (that is created by this Exec) whose content will be recorded in
    /// OSPolicyResourceCompliance after a successful run. Absence or failure to
    /// read this file will result in this ExecResource being non-compliant. Output
    /// file size is limited to 100K bytes.
    /// </summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>
    /// An inline script. The size of the script is limited to
    /// 1024 characters.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>
/// Exec resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExec
{
    /// <summary>
    /// What to run to bring this resource into the desired
    /// state. An exit code of 100 indicates &quot;success&quot;, any other exit code
    /// indicates a failure running enforce. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("enforce")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforce? Enforce { get; set; }

    /// <summary>
    /// What to run to validate this resource is in the
    /// desired state. An exit code of 100 indicates &quot;in desired state&quot;, and exit
    /// code of 101 indicates &quot;not in desired state&quot;. Any other exit code indicates
    /// a failure running validate. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("validate")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidate? Validate { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileRemote? Remote { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFile
{
    /// <summary>
    /// A a file with this content. The size of the content
    /// is limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFile? File { get; set; }

    /// <summary>The absolute path of the file within the VM.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Desired state of the file. Possible values are:
    /// DESIRED_STATE_UNSPECIFIED, PRESENT, ABSENT, CONTENTS_MATCH.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// An Apt Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgApt
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote? Remote { get; set; }
}

/// <summary>
/// A deb package file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDeb
{
    /// <summary>
    /// Whether dependencies should also be installed. -
    /// install when false: rpm --upgrade --replacepkgs package.rpm - install when
    /// true: yum -y install package.rpm or zypper -y install package.rpm
    /// </summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSource? Source { get; set; }
}

/// <summary>
/// A package managed by GooGet. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgGooget
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote? Remote { get; set; }
}

/// <summary>
/// An MSI package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsi
{
    /// <summary>
    /// Additional properties to use during installation.
    /// This should be in the format of Property=Setting. Appended to the defaults
    /// of ACTION=INSTALL REBOOT=ReallySuppress.
    /// </summary>
    [JsonPropertyName("properties")]
    public IList<string>? Properties { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSource? Source { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote? Remote { get; set; }
}

/// <summary>
/// An rpm package file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpm
{
    /// <summary>
    /// Whether dependencies should also be installed. -
    /// install when false: rpm --upgrade --replacepkgs package.rpm - install when
    /// true: yum -y install package.rpm or zypper -y install package.rpm
    /// </summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSource? Source { get; set; }
}

/// <summary>
/// A Yum Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgYum
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Zypper Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgZypper
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Package resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkg
{
    /// <summary>
    /// An Apt Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgApt? Apt { get; set; }

    /// <summary>
    /// A deb package file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("deb")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDeb? Deb { get; set; }

    /// <summary>
    /// The desired state the agent should maintain for
    /// this package. Possible values are: DESIRED_STATE_UNSPECIFIED, INSTALLED,
    /// REMOVED.
    /// </summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>
    /// A package managed by GooGet. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("googet")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgGooget? Googet { get; set; }

    /// <summary>
    /// An MSI package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("msi")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsi? Msi { get; set; }

    /// <summary>
    /// An rpm package file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("rpm")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpm? Rpm { get; set; }

    /// <summary>
    /// A Yum Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgYum? Yum { get; set; }

    /// <summary>
    /// A Zypper Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgZypper? Zypper { get; set; }
}

/// <summary>
/// An Apt Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryApt
{
    /// <summary>
    /// Type of archive files in this repository.
    /// Possible values are: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC.
    /// </summary>
    [JsonPropertyName("archiveType")]
    public string? ArchiveType { get; set; }

    /// <summary>
    /// List of components for this repository. Must
    /// contain at least one item.
    /// </summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>
    /// URI of the key file for this repository. The agent
    /// maintains a keyring at /etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg.
    /// </summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A Goo Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryGoo
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The url of the repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A Yum Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryYum
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// A Zypper Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryZypper
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Package repository resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepository
{
    /// <summary>
    /// An Apt Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryApt? Apt { get; set; }

    /// <summary>
    /// A Goo Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("goo")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryGoo? Goo { get; set; }

    /// <summary>
    /// A Yum Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryYum? Yum { get; set; }

    /// <summary>
    /// A Zypper Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryZypper? Zypper { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResources
{
    /// <summary>
    /// Exec resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("exec")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExec? Exec { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFile? File { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Package resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("pkg")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkg? Pkg { get; set; }

    /// <summary>
    /// Package repository resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("repository")]
    public V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepository? Repository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroups
{
    /// <summary>
    /// List of inventory filters for the resource
    /// group. The resources in this resource group are applied to the target VM if
    /// it satisfies at least one of the following inventory filters. For example,
    /// to apply this resource group to VMs running either RHEL or CentOS
    /// operating systems, specify 2 items for the list with following values:
    /// inventory_filters[0].os_short_name=&apos;rhel&apos; and
    /// inventory_filters[1].os_short_name=&apos;centos&apos; If the list is empty, this
    /// resource group will be applied to the target VM unconditionally. Structure
    /// is documented below.
    /// </summary>
    [JsonPropertyName("inventoryFilters")]
    public IList<V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsInventoryFilters>? InventoryFilters { get; set; }

    /// <summary>
    /// List of resources configured for this resource
    /// group. The resources are executed in the exact order specified here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderOsPolicies
{
    /// <summary>
    /// This flag determines the OS
    /// policy compliance status when none of the resource groups within the policy
    /// are applicable for a VM. Set this value to true if the policy needs to be
    /// reported as compliant even if the policy has nothing to validate or enforce.
    /// </summary>
    [JsonPropertyName("allowNoResourceGroupMatch")]
    public bool? AllowNoResourceGroupMatch { get; set; }

    /// <summary>
    /// Policy description. Length of the description is
    /// limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The id of the OS policy with the following restrictions:</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Policy mode Possible values are: MODE_UNSPECIFIED,
    /// VALIDATION, ENFORCEMENT.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// List of resource groups for the policy. For a
    /// particular VM, resource groups are evaluated in the order specified and the
    /// first resource group that is applicable is selected and the rest are
    /// ignored. If none of the resource groups are applicable for a VM, the VM is
    /// considered to be non-compliant w.r.t this policy. This behavior can be
    /// toggled by the flag allow_no_resource_group_match Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("resourceGroups")]
    public IList<V1beta2OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroups>? ResourceGroups { get; set; }
}

/// <summary>
/// The maximum number (or percentage) of VMs
/// per zone to disrupt at any given moment. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// Specifies the relative value defined as a percentage,
    /// which will be multiplied by a reference value.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Rollout to deploy the OS policy assignment. A rollout
/// is triggered in the following situations: 1) OSPolicyAssignment is created.
/// 2) OSPolicyAssignment is updated and the update contains changes to one of
/// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment
/// is deleted. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProviderRollout
{
    /// <summary>
    /// The maximum number (or percentage) of VMs
    /// per zone to disrupt at any given moment. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta2OsPolicyAssignmentSpecForProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>
    /// This determines the minimum duration of
    /// time to wait after the configuration changes are applied through the current
    /// rollout. A VM continues to count towards the disruption_budget at least
    /// until this duration of time has passed after configuration changes are
    /// applied.
    /// </summary>
    [JsonPropertyName("minWaitDuration")]
    public string? MinWaitDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecForProvider
{
    /// <summary>
    /// Policy description. Length of the description is
    /// limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Filter to select VMs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta2OsPolicyAssignmentSpecForProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// List of OS policies to be applied to the VMs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("osPolicies")]
    public IList<V1beta2OsPolicyAssignmentSpecForProviderOsPolicies>? OsPolicies { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Rollout to deploy the OS policy assignment. A rollout
    /// is triggered in the following situations: 1) OSPolicyAssignment is created.
    /// 2) OSPolicyAssignment is updated and the update contains changes to one of
    /// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment
    /// is deleted. Structure is documented below.
    /// </summary>
    [JsonPropertyName("rollout")]
    public V1beta2OsPolicyAssignmentSpecForProviderRollout? Rollout { get; set; }

    /// <summary>
    /// Set to true to skip awaiting rollout
    /// during resource creation and update.
    /// </summary>
    [JsonPropertyName("skipAwaitRollout")]
    public bool? SkipAwaitRollout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilterExclusionLabels
{
    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this map to be
    /// selected.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilterInclusionLabels
{
    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this map to be
    /// selected.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilterInventories
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>
    /// The OS version Prefix matches are supported if
    /// asterisk(*) is provided as the last character. For example, to match all
    /// versions with a major version of 7, specify the following value for this
    /// field 7.* An empty string matches all OS versions.
    /// </summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>
/// Filter to select VMs. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilter
{
    /// <summary>
    /// Target all VMs in the project. If true, no other criteria
    /// is permitted.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>
    /// List of label sets used for VM exclusion. If
    /// the list has more than one label set, the VM is excluded if any of the label
    /// sets are applicable for the VM. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("exclusionLabels")]
    public IList<V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilterExclusionLabels>? ExclusionLabels { get; set; }

    /// <summary>
    /// List of label sets used for VM inclusion. If
    /// the list has more than one LabelSet, the VM is included if any of the
    /// label sets are applicable for the VM. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("inclusionLabels")]
    public IList<V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilterInclusionLabels>? InclusionLabels { get; set; }

    /// <summary>
    /// List of inventories to select VMs. A VM is
    /// selected if its inventory data matches at least one of the following
    /// inventories. Structure is documented below.
    /// </summary>
    [JsonPropertyName("inventories")]
    public IList<V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilterInventories>? Inventories { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsInventoryFilters
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>
    /// The OS version Prefix matches are supported if
    /// asterisk(*) is provided as the last character. For example, to match all
    /// versions with a major version of 7, specify the following value for this
    /// field 7.* An empty string matches all OS versions.
    /// </summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote? Remote { get; set; }
}

/// <summary>
/// What to run to bring this resource into the desired
/// state. An exit code of 100 indicates &quot;success&quot;, any other exit code
/// indicates a failure running enforce. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforce
{
    /// <summary>
    /// Optional arguments to pass to the source during
    /// execution.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFile? File { get; set; }

    /// <summary>
    /// The script interpreter to use. Possible values
    /// are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an
    /// output file (that is created by this Exec) whose content will be recorded in
    /// OSPolicyResourceCompliance after a successful run. Absence or failure to
    /// read this file will result in this ExecResource being non-compliant. Output
    /// file size is limited to 100K bytes.
    /// </summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>
    /// An inline script. The size of the script is limited to
    /// 1024 characters.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote? Remote { get; set; }
}

/// <summary>
/// What to run to validate this resource is in the
/// desired state. An exit code of 100 indicates &quot;in desired state&quot;, and exit
/// code of 101 indicates &quot;not in desired state&quot;. Any other exit code indicates
/// a failure running validate. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidate
{
    /// <summary>
    /// Optional arguments to pass to the source during
    /// execution.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFile? File { get; set; }

    /// <summary>
    /// The script interpreter to use. Possible values
    /// are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an
    /// output file (that is created by this Exec) whose content will be recorded in
    /// OSPolicyResourceCompliance after a successful run. Absence or failure to
    /// read this file will result in this ExecResource being non-compliant. Output
    /// file size is limited to 100K bytes.
    /// </summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>
    /// An inline script. The size of the script is limited to
    /// 1024 characters.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>
/// Exec resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExec
{
    /// <summary>
    /// What to run to bring this resource into the desired
    /// state. An exit code of 100 indicates &quot;success&quot;, any other exit code
    /// indicates a failure running enforce. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("enforce")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforce? Enforce { get; set; }

    /// <summary>
    /// What to run to validate this resource is in the
    /// desired state. An exit code of 100 indicates &quot;in desired state&quot;, and exit
    /// code of 101 indicates &quot;not in desired state&quot;. Any other exit code indicates
    /// a failure running validate. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("validate")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidate? Validate { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileRemote? Remote { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFile
{
    /// <summary>
    /// A a file with this content. The size of the content
    /// is limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFile? File { get; set; }

    /// <summary>The absolute path of the file within the VM.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Desired state of the file. Possible values are:
    /// DESIRED_STATE_UNSPECIFIED, PRESENT, ABSENT, CONTENTS_MATCH.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// An Apt Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgApt
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote? Remote { get; set; }
}

/// <summary>
/// A deb package file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDeb
{
    /// <summary>
    /// Whether dependencies should also be installed. -
    /// install when false: rpm --upgrade --replacepkgs package.rpm - install when
    /// true: yum -y install package.rpm or zypper -y install package.rpm
    /// </summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSource? Source { get; set; }
}

/// <summary>
/// A package managed by GooGet. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgGooget
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote? Remote { get; set; }
}

/// <summary>
/// An MSI package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsi
{
    /// <summary>
    /// Additional properties to use during installation.
    /// This should be in the format of Property=Setting. Appended to the defaults
    /// of ACTION=INSTALL REBOOT=ReallySuppress.
    /// </summary>
    [JsonPropertyName("properties")]
    public IList<string>? Properties { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSource? Source { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote? Remote { get; set; }
}

/// <summary>
/// An rpm package file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpm
{
    /// <summary>
    /// Whether dependencies should also be installed. -
    /// install when false: rpm --upgrade --replacepkgs package.rpm - install when
    /// true: yum -y install package.rpm or zypper -y install package.rpm
    /// </summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSource? Source { get; set; }
}

/// <summary>
/// A Yum Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgYum
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Zypper Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgZypper
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Package resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkg
{
    /// <summary>
    /// An Apt Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgApt? Apt { get; set; }

    /// <summary>
    /// A deb package file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("deb")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDeb? Deb { get; set; }

    /// <summary>
    /// The desired state the agent should maintain for
    /// this package. Possible values are: DESIRED_STATE_UNSPECIFIED, INSTALLED,
    /// REMOVED.
    /// </summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>
    /// A package managed by GooGet. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("googet")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgGooget? Googet { get; set; }

    /// <summary>
    /// An MSI package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("msi")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsi? Msi { get; set; }

    /// <summary>
    /// An rpm package file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("rpm")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpm? Rpm { get; set; }

    /// <summary>
    /// A Yum Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgYum? Yum { get; set; }

    /// <summary>
    /// A Zypper Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgZypper? Zypper { get; set; }
}

/// <summary>
/// An Apt Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryApt
{
    /// <summary>
    /// Type of archive files in this repository.
    /// Possible values are: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC.
    /// </summary>
    [JsonPropertyName("archiveType")]
    public string? ArchiveType { get; set; }

    /// <summary>
    /// List of components for this repository. Must
    /// contain at least one item.
    /// </summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>
    /// URI of the key file for this repository. The agent
    /// maintains a keyring at /etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg.
    /// </summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A Goo Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryGoo
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The url of the repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A Yum Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryYum
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// A Zypper Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryZypper
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Package repository resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepository
{
    /// <summary>
    /// An Apt Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryApt? Apt { get; set; }

    /// <summary>
    /// A Goo Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("goo")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryGoo? Goo { get; set; }

    /// <summary>
    /// A Yum Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryYum? Yum { get; set; }

    /// <summary>
    /// A Zypper Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryZypper? Zypper { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResources
{
    /// <summary>
    /// Exec resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("exec")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExec? Exec { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFile? File { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Package resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("pkg")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkg? Pkg { get; set; }

    /// <summary>
    /// Package repository resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("repository")]
    public V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepository? Repository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroups
{
    /// <summary>
    /// List of inventory filters for the resource
    /// group. The resources in this resource group are applied to the target VM if
    /// it satisfies at least one of the following inventory filters. For example,
    /// to apply this resource group to VMs running either RHEL or CentOS
    /// operating systems, specify 2 items for the list with following values:
    /// inventory_filters[0].os_short_name=&apos;rhel&apos; and
    /// inventory_filters[1].os_short_name=&apos;centos&apos; If the list is empty, this
    /// resource group will be applied to the target VM unconditionally. Structure
    /// is documented below.
    /// </summary>
    [JsonPropertyName("inventoryFilters")]
    public IList<V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsInventoryFilters>? InventoryFilters { get; set; }

    /// <summary>
    /// List of resources configured for this resource
    /// group. The resources are executed in the exact order specified here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderOsPolicies
{
    /// <summary>
    /// This flag determines the OS
    /// policy compliance status when none of the resource groups within the policy
    /// are applicable for a VM. Set this value to true if the policy needs to be
    /// reported as compliant even if the policy has nothing to validate or enforce.
    /// </summary>
    [JsonPropertyName("allowNoResourceGroupMatch")]
    public bool? AllowNoResourceGroupMatch { get; set; }

    /// <summary>
    /// Policy description. Length of the description is
    /// limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The id of the OS policy with the following restrictions:</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Policy mode Possible values are: MODE_UNSPECIFIED,
    /// VALIDATION, ENFORCEMENT.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// List of resource groups for the policy. For a
    /// particular VM, resource groups are evaluated in the order specified and the
    /// first resource group that is applicable is selected and the rest are
    /// ignored. If none of the resource groups are applicable for a VM, the VM is
    /// considered to be non-compliant w.r.t this policy. This behavior can be
    /// toggled by the flag allow_no_resource_group_match Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("resourceGroups")]
    public IList<V1beta2OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroups>? ResourceGroups { get; set; }
}

/// <summary>
/// The maximum number (or percentage) of VMs
/// per zone to disrupt at any given moment. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// Specifies the relative value defined as a percentage,
    /// which will be multiplied by a reference value.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Rollout to deploy the OS policy assignment. A rollout
/// is triggered in the following situations: 1) OSPolicyAssignment is created.
/// 2) OSPolicyAssignment is updated and the update contains changes to one of
/// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment
/// is deleted. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecInitProviderRollout
{
    /// <summary>
    /// The maximum number (or percentage) of VMs
    /// per zone to disrupt at any given moment. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta2OsPolicyAssignmentSpecInitProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>
    /// This determines the minimum duration of
    /// time to wait after the configuration changes are applied through the current
    /// rollout. A VM continues to count towards the disruption_budget at least
    /// until this duration of time has passed after configuration changes are
    /// applied.
    /// </summary>
    [JsonPropertyName("minWaitDuration")]
    public string? MinWaitDuration { get; set; }
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
public partial class V1beta2OsPolicyAssignmentSpecInitProvider
{
    /// <summary>
    /// Policy description. Length of the description is
    /// limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Filter to select VMs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta2OsPolicyAssignmentSpecInitProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>
    /// List of OS policies to be applied to the VMs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("osPolicies")]
    public IList<V1beta2OsPolicyAssignmentSpecInitProviderOsPolicies>? OsPolicies { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Rollout to deploy the OS policy assignment. A rollout
    /// is triggered in the following situations: 1) OSPolicyAssignment is created.
    /// 2) OSPolicyAssignment is updated and the update contains changes to one of
    /// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment
    /// is deleted. Structure is documented below.
    /// </summary>
    [JsonPropertyName("rollout")]
    public V1beta2OsPolicyAssignmentSpecInitProviderRollout? Rollout { get; set; }

    /// <summary>
    /// Set to true to skip awaiting rollout
    /// during resource creation and update.
    /// </summary>
    [JsonPropertyName("skipAwaitRollout")]
    public bool? SkipAwaitRollout { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OsPolicyAssignmentSpecManagementPoliciesEnum>))]
public enum V1beta2OsPolicyAssignmentSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2OsPolicyAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OsPolicyAssignmentSpec defines the desired state of OsPolicyAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentSpec
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
    public V1beta2OsPolicyAssignmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2OsPolicyAssignmentSpecForProvider ForProvider { get; set; }

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
    public V1beta2OsPolicyAssignmentSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2OsPolicyAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2OsPolicyAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2OsPolicyAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilterExclusionLabels
{
    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this map to be
    /// selected.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilterInclusionLabels
{
    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this map to be
    /// selected.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilterInventories
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>
    /// The OS version Prefix matches are supported if
    /// asterisk(*) is provided as the last character. For example, to match all
    /// versions with a major version of 7, specify the following value for this
    /// field 7.* An empty string matches all OS versions.
    /// </summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>
/// Filter to select VMs. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilter
{
    /// <summary>
    /// Target all VMs in the project. If true, no other criteria
    /// is permitted.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>
    /// List of label sets used for VM exclusion. If
    /// the list has more than one label set, the VM is excluded if any of the label
    /// sets are applicable for the VM. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("exclusionLabels")]
    public IList<V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilterExclusionLabels>? ExclusionLabels { get; set; }

    /// <summary>
    /// List of label sets used for VM inclusion. If
    /// the list has more than one LabelSet, the VM is included if any of the
    /// label sets are applicable for the VM. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("inclusionLabels")]
    public IList<V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilterInclusionLabels>? InclusionLabels { get; set; }

    /// <summary>
    /// List of inventories to select VMs. A VM is
    /// selected if its inventory data matches at least one of the following
    /// inventories. Structure is documented below.
    /// </summary>
    [JsonPropertyName("inventories")]
    public IList<V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilterInventories>? Inventories { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsInventoryFilters
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>
    /// The OS version Prefix matches are supported if
    /// asterisk(*) is provided as the last character. For example, to match all
    /// versions with a major version of 7, specify the following value for this
    /// field 7.* An empty string matches all OS versions.
    /// </summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote? Remote { get; set; }
}

/// <summary>
/// What to run to bring this resource into the desired
/// state. An exit code of 100 indicates &quot;success&quot;, any other exit code
/// indicates a failure running enforce. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforce
{
    /// <summary>
    /// Optional arguments to pass to the source during
    /// execution.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFile? File { get; set; }

    /// <summary>
    /// The script interpreter to use. Possible values
    /// are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an
    /// output file (that is created by this Exec) whose content will be recorded in
    /// OSPolicyResourceCompliance after a successful run. Absence or failure to
    /// read this file will result in this ExecResource being non-compliant. Output
    /// file size is limited to 100K bytes.
    /// </summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>
    /// An inline script. The size of the script is limited to
    /// 1024 characters.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote? Remote { get; set; }
}

/// <summary>
/// What to run to validate this resource is in the
/// desired state. An exit code of 100 indicates &quot;in desired state&quot;, and exit
/// code of 101 indicates &quot;not in desired state&quot;. Any other exit code indicates
/// a failure running validate. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidate
{
    /// <summary>
    /// Optional arguments to pass to the source during
    /// execution.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFile? File { get; set; }

    /// <summary>
    /// The script interpreter to use. Possible values
    /// are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.
    /// </summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an
    /// output file (that is created by this Exec) whose content will be recorded in
    /// OSPolicyResourceCompliance after a successful run. Absence or failure to
    /// read this file will result in this ExecResource being non-compliant. Output
    /// file size is limited to 100K bytes.
    /// </summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>
    /// An inline script. The size of the script is limited to
    /// 1024 characters.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>
/// Exec resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExec
{
    /// <summary>
    /// What to run to bring this resource into the desired
    /// state. An exit code of 100 indicates &quot;success&quot;, any other exit code
    /// indicates a failure running enforce. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("enforce")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforce? Enforce { get; set; }

    /// <summary>
    /// What to run to validate this resource is in the
    /// desired state. An exit code of 100 indicates &quot;in desired state&quot;, and exit
    /// code of 101 indicates &quot;not in desired state&quot;. Any other exit code indicates
    /// a failure running validate. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("validate")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidate? Validate { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFile
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileRemote? Remote { get; set; }
}

/// <summary>
/// A remote or local file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFile
{
    /// <summary>
    /// A a file with this content. The size of the content
    /// is limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFile? File { get; set; }

    /// <summary>The absolute path of the file within the VM.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// (Output) Consists of three octal digits which represent, in
    /// order, the permissions of the owner, group, and other users for the file
    /// (similarly to the numeric mode used in the linux chmod utility). Each digit
    /// represents a three bit number with the 4 bit corresponding to the read
    /// permissions, the 2 bit corresponds to the write bit, and the one bit
    /// corresponds to the execute permission. Default behavior is 755. Below are
    /// some examples of permissions and their associated values: read, write, and
    /// execute: 7 read and execute: 5 read and write: 6 read only: 4
    /// </summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }

    /// <summary>
    /// Desired state of the file. Possible values are:
    /// DESIRED_STATE_UNSPECIFIED, PRESENT, ABSENT, CONTENTS_MATCH.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// An Apt Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgApt
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote? Remote { get; set; }
}

/// <summary>
/// A deb package file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDeb
{
    /// <summary>
    /// Whether dependencies should also be installed. -
    /// install when false: rpm --upgrade --replacepkgs package.rpm - install when
    /// true: yum -y install package.rpm or zypper -y install package.rpm
    /// </summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSource? Source { get; set; }
}

/// <summary>
/// A package managed by GooGet. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgGooget
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote? Remote { get; set; }
}

/// <summary>
/// An MSI package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsi
{
    /// <summary>
    /// Additional properties to use during installation.
    /// This should be in the format of Property=Setting. Appended to the defaults
    /// of ACTION=INSTALL REBOOT=ReallySuppress.
    /// </summary>
    [JsonPropertyName("properties")]
    public IList<string>? Properties { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSource? Source { get; set; }
}

/// <summary>
/// A Cloud Storage object. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// A generic remote file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// An rpm package. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSource
{
    /// <summary>
    /// Defaults to false. When false, files are
    /// subject to validations based on the file type: Remote: A checksum must be
    /// specified. Cloud Storage: An object generation number must be specified.
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// A Cloud Storage object. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("gcs")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>
    /// A generic remote file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("remote")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote? Remote { get; set; }
}

/// <summary>
/// An rpm package file. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpm
{
    /// <summary>
    /// Whether dependencies should also be installed. -
    /// install when false: rpm --upgrade --replacepkgs package.rpm - install when
    /// true: yum -y install package.rpm or zypper -y install package.rpm
    /// </summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>
    /// An rpm package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSource? Source { get; set; }
}

/// <summary>
/// A Yum Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgYum
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A Zypper Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgZypper
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Package resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkg
{
    /// <summary>
    /// An Apt Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgApt? Apt { get; set; }

    /// <summary>
    /// A deb package file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("deb")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDeb? Deb { get; set; }

    /// <summary>
    /// The desired state the agent should maintain for
    /// this package. Possible values are: DESIRED_STATE_UNSPECIFIED, INSTALLED,
    /// REMOVED.
    /// </summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>
    /// A package managed by GooGet. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("googet")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgGooget? Googet { get; set; }

    /// <summary>
    /// An MSI package. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("msi")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsi? Msi { get; set; }

    /// <summary>
    /// An rpm package file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("rpm")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpm? Rpm { get; set; }

    /// <summary>
    /// A Yum Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgYum? Yum { get; set; }

    /// <summary>
    /// A Zypper Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgZypper? Zypper { get; set; }
}

/// <summary>
/// An Apt Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryApt
{
    /// <summary>
    /// Type of archive files in this repository.
    /// Possible values are: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC.
    /// </summary>
    [JsonPropertyName("archiveType")]
    public string? ArchiveType { get; set; }

    /// <summary>
    /// List of components for this repository. Must
    /// contain at least one item.
    /// </summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>
    /// URI of the key file for this repository. The agent
    /// maintains a keyring at /etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg.
    /// </summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>
    /// URI from which to fetch the object. It should contain
    /// both the protocol and path following the format {protocol}://{location}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// A Goo Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryGoo
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The url of the repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A Yum Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryYum
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// A Zypper Repository. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryZypper
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Package repository resource Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepository
{
    /// <summary>
    /// An Apt Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("apt")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryApt? Apt { get; set; }

    /// <summary>
    /// A Goo Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("goo")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryGoo? Goo { get; set; }

    /// <summary>
    /// A Yum Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("yum")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryYum? Yum { get; set; }

    /// <summary>
    /// A Zypper Repository. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("zypper")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryZypper? Zypper { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResources
{
    /// <summary>
    /// Exec resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("exec")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExec? Exec { get; set; }

    /// <summary>
    /// A remote or local file. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("file")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFile? File { get; set; }

    /// <summary>
    /// A one word, unique name for this repository. This is the
    /// repo id in the zypper config file and also the display_name if
    /// display_name is omitted. This id is also used as the unique identifier
    /// when checking for GuestPolicy conflicts.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Package resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("pkg")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkg? Pkg { get; set; }

    /// <summary>
    /// Package repository resource Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("repository")]
    public V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepository? Repository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroups
{
    /// <summary>
    /// List of inventory filters for the resource
    /// group. The resources in this resource group are applied to the target VM if
    /// it satisfies at least one of the following inventory filters. For example,
    /// to apply this resource group to VMs running either RHEL or CentOS
    /// operating systems, specify 2 items for the list with following values:
    /// inventory_filters[0].os_short_name=&apos;rhel&apos; and
    /// inventory_filters[1].os_short_name=&apos;centos&apos; If the list is empty, this
    /// resource group will be applied to the target VM unconditionally. Structure
    /// is documented below.
    /// </summary>
    [JsonPropertyName("inventoryFilters")]
    public IList<V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsInventoryFilters>? InventoryFilters { get; set; }

    /// <summary>
    /// List of resources configured for this resource
    /// group. The resources are executed in the exact order specified here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderOsPolicies
{
    /// <summary>
    /// This flag determines the OS
    /// policy compliance status when none of the resource groups within the policy
    /// are applicable for a VM. Set this value to true if the policy needs to be
    /// reported as compliant even if the policy has nothing to validate or enforce.
    /// </summary>
    [JsonPropertyName("allowNoResourceGroupMatch")]
    public bool? AllowNoResourceGroupMatch { get; set; }

    /// <summary>
    /// Policy description. Length of the description is
    /// limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The id of the OS policy with the following restrictions:</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Policy mode Possible values are: MODE_UNSPECIFIED,
    /// VALIDATION, ENFORCEMENT.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// List of resource groups for the policy. For a
    /// particular VM, resource groups are evaluated in the order specified and the
    /// first resource group that is applicable is selected and the rest are
    /// ignored. If none of the resource groups are applicable for a VM, the VM is
    /// considered to be non-compliant w.r.t this policy. This behavior can be
    /// toggled by the flag allow_no_resource_group_match Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("resourceGroups")]
    public IList<V1beta2OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroups>? ResourceGroups { get; set; }
}

/// <summary>
/// The maximum number (or percentage) of VMs
/// per zone to disrupt at any given moment. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// Specifies the relative value defined as a percentage,
    /// which will be multiplied by a reference value.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Rollout to deploy the OS policy assignment. A rollout
/// is triggered in the following situations: 1) OSPolicyAssignment is created.
/// 2) OSPolicyAssignment is updated and the update contains changes to one of
/// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment
/// is deleted. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProviderRollout
{
    /// <summary>
    /// The maximum number (or percentage) of VMs
    /// per zone to disrupt at any given moment. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta2OsPolicyAssignmentStatusAtProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>
    /// This determines the minimum duration of
    /// time to wait after the configuration changes are applied through the current
    /// rollout. A VM continues to count towards the disruption_budget at least
    /// until this duration of time has passed after configuration changes are
    /// applied.
    /// </summary>
    [JsonPropertyName("minWaitDuration")]
    public string? MinWaitDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusAtProvider
{
    /// <summary>
    /// Output only. Indicates that this revision has been successfully
    /// rolled out in this zone and new VMs will be assigned OS policies from this
    /// revision. For a given OS policy assignment, there is only one revision with
    /// a value of true for this field.
    /// </summary>
    [JsonPropertyName("baseline")]
    public bool? Baseline { get; set; }

    /// <summary>
    /// Output only. Indicates that this revision deletes the OS policy
    /// assignment.
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// Policy description. Length of the description is
    /// limited to 1024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The etag for this OS policy assignment. If this is provided on
    /// update, it must match the server&apos;s etag.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// an identifier for the resource with format
    /// projects/{{project}}/locations/{{location}}/osPolicyAssignments/{{name}}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Filter to select VMs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta2OsPolicyAssignmentStatusAtProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// List of OS policies to be applied to the VMs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("osPolicies")]
    public IList<V1beta2OsPolicyAssignmentStatusAtProviderOsPolicies>? OsPolicies { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Output only. Indicates that reconciliation is in progress
    /// for the revision. This value is true when the rollout_state is one of:
    /// </summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>
    /// Output only. The timestamp that the revision was
    /// created.
    /// </summary>
    [JsonPropertyName("revisionCreateTime")]
    public string? RevisionCreateTime { get; set; }

    /// <summary>
    /// Output only. The assignment revision ID A new revision is
    /// committed whenever a rollout is triggered for a OS policy assignment
    /// </summary>
    [JsonPropertyName("revisionId")]
    public string? RevisionId { get; set; }

    /// <summary>
    /// Rollout to deploy the OS policy assignment. A rollout
    /// is triggered in the following situations: 1) OSPolicyAssignment is created.
    /// 2) OSPolicyAssignment is updated and the update contains changes to one of
    /// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment
    /// is deleted. Structure is documented below.
    /// </summary>
    [JsonPropertyName("rollout")]
    public V1beta2OsPolicyAssignmentStatusAtProviderRollout? Rollout { get; set; }

    /// <summary>Output only. OS policy assignment rollout state</summary>
    [JsonPropertyName("rolloutState")]
    public string? RolloutState { get; set; }

    /// <summary>
    /// Set to true to skip awaiting rollout
    /// during resource creation and update.
    /// </summary>
    [JsonPropertyName("skipAwaitRollout")]
    public bool? SkipAwaitRollout { get; set; }

    /// <summary>
    /// Output only. Server generated unique id for the OS policy assignment
    /// resource.
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatusConditions
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

/// <summary>OsPolicyAssignmentStatus defines the observed state of OsPolicyAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OsPolicyAssignmentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2OsPolicyAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2OsPolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OsPolicyAssignment is the Schema for the OsPolicyAssignments API. OS policy assignment is an API resource that is used to apply a set of OS policies to a dynamically targeted group of Compute Engine VM instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2OsPolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2OsPolicyAssignmentSpec>, IStatus<V1beta2OsPolicyAssignmentStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "OsPolicyAssignment";
    public const string KubeGroup = "osconfig.gcp.upbound.io";
    public const string KubePluralName = "ospolicyassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "osconfig.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OsPolicyAssignment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OsPolicyAssignmentSpec defines the desired state of OsPolicyAssignment</summary>
    [JsonPropertyName("spec")]
    public required V1beta2OsPolicyAssignmentSpec Spec { get; set; }

    /// <summary>OsPolicyAssignmentStatus defines the observed state of OsPolicyAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta2OsPolicyAssignmentStatus? Status { get; set; }
}
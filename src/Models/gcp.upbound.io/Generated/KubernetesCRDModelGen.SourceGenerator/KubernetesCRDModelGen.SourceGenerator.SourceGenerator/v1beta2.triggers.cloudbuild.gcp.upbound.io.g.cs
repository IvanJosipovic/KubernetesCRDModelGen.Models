#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudbuild.gcp.upbound.io;
/// <summary>Trigger is the Schema for the Triggers API. Configuration for an automated build in response to source repository changes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TriggerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Trigger>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TriggerList";
    public const string KubeGroup = "cloudbuild.gcp.upbound.io";
    public const string KubePluralName = "triggers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TriggerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Trigger objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Trigger> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecDeletionPolicyEnum>))]
public enum V1beta2TriggerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Configuration for manual approval to start a build invocation of this BuildTrigger.
/// Builds created by this trigger will require approval before they execute.
/// Any user with a Cloud Build Approver role for the project can approve a build.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderApprovalConfig
{
    /// <summary>
    /// Whether or not approval is needed. If this is set on a build, it will become pending when run,
    /// and will need to be explicitly approved to start.
    /// </summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }
}

/// <summary>
/// Filter to match changes in pull requests.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBitbucketServerTriggerConfigPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// Filter to match changes in refs like branches, tags.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBitbucketServerTriggerConfigPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBitbucketServerTriggerConfig
{
    /// <summary>The Bitbucket server config resource that this trigger config maps to.</summary>
    [JsonPropertyName("bitbucketServerConfigResource")]
    public string? BitbucketServerConfigResource { get; set; }

    /// <summary>Key of the project that the repo is in. For example: The key for https://mybitbucket.server/projects/TEST/repos/test-repo is &quot;TEST&quot;.</summary>
    [JsonPropertyName("projectKey")]
    public string? ProjectKey { get; set; }

    /// <summary>
    /// Filter to match changes in pull requests.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerSpecForProviderBitbucketServerTriggerConfigPullRequest? PullRequest { get; set; }

    /// <summary>
    /// Filter to match changes in refs like branches, tags.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerSpecForProviderBitbucketServerTriggerConfigPush? Push { get; set; }

    /// <summary>
    /// Slug of the repository. A repository slug is a URL-friendly version of a repository name, automatically generated by Bitbucket for use in the URL.
    /// For example, if the repository name is &apos;test repo&apos;, in the URL it would become &apos;test-repo&apos; as in https://mybitbucket.server/projects/TEST/repos/test-repo.
    /// </summary>
    [JsonPropertyName("repoSlug")]
    public string? RepoSlug { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildArtifactsMavenArtifacts
{
    /// <summary>Maven artifactId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Maven groupId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Maven version value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildArtifactsNpmPackages
{
    /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
    [JsonPropertyName("packagePath")]
    public string? PackagePath { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.
/// Files in the workspace matching specified paths globs will be uploaded to the
/// Cloud Storage location using the builder service account&apos;s credentials.
/// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
/// If any objects fail to be pushed, the build is marked FAILURE.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildArtifactsObjects
{
    /// <summary>
    /// Cloud Storage bucket and optional object path, in the form &quot;gs://bucket/path/to/somewhere/&quot;.
    /// Files in the workspace matching any path pattern will be uploaded to Cloud Storage with
    /// this location as a prefix.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Path globs used to match files in the build&apos;s workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildArtifactsPythonPackages
{
    /// <summary>Path globs used to match files in the build&apos;s workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildArtifacts
{
    /// <summary>
    /// A list of images to be pushed upon the successful completion of all build steps.
    /// The images are pushed using the builder service account&apos;s credentials.
    /// The digests of the pushed images will be stored in the Build resource&apos;s results field.
    /// If any of the images fail to be pushed, the build status is marked FAILURE.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// A Maven artifact to upload to Artifact Registry upon successful completion of all build steps.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenArtifacts")]
    public IList<V1beta2TriggerSpecForProviderBuildArtifactsMavenArtifacts>? MavenArtifacts { get; set; }

    /// <summary>
    /// Npm package to upload to Artifact Registry upon successful completion of all build steps.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("npmPackages")]
    public IList<V1beta2TriggerSpecForProviderBuildArtifactsNpmPackages>? NpmPackages { get; set; }

    /// <summary>
    /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.
    /// Files in the workspace matching specified paths globs will be uploaded to the
    /// Cloud Storage location using the builder service account&apos;s credentials.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public V1beta2TriggerSpecForProviderBuildArtifactsObjects? Objects { get; set; }

    /// <summary>
    /// Python package to upload to Artifact Registry upon successful completion of all build steps. A package can encapsulate multiple objects to be uploaded to a single repository.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonPackages")]
    public IList<V1beta2TriggerSpecForProviderBuildArtifactsPythonPackages>? PythonPackages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildAvailableSecretsSecretManager
{
    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public string? Env { get; set; }

    /// <summary>Resource name of the SecretVersion. In format: projects//secrets//versions/*</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary>
/// Secrets and secret environment variables.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildAvailableSecrets
{
    /// <summary>
    /// Pairs a secret environment variable with a SecretVersion in Secret Manager.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretManager")]
    public IList<V1beta2TriggerSpecForProviderBuildAvailableSecretsSecretManager>? SecretManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildOptionsVolumes
{
    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Special options for this build.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildOptions
{
    /// <summary>
    /// Requested disk size for the VM that runs the build. Note that this is NOT &quot;disk free&quot;;
    /// some of the space will be used by the operating system and build utilities.
    /// Also note that this is the minimum disk size that will be allocated for the build --
    /// the build may run with a larger disk than requested. At present, the maximum disk size
    /// is 1000GB; builds that request more than the maximum are rejected with an error.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// Option to specify whether or not to apply bash style string operations to the substitutions.
    /// NOTE this is always enabled for triggered builds and cannot be overridden in the build configuration file.
    /// </summary>
    [JsonPropertyName("dynamicSubstitutions")]
    public bool? DynamicSubstitutions { get; set; }

    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>
    /// Option to define build log streaming behavior to Google Cloud Storage.
    /// Possible values are: STREAM_DEFAULT, STREAM_ON, STREAM_OFF.
    /// </summary>
    [JsonPropertyName("logStreamingOption")]
    public string? LogStreamingOption { get; set; }

    /// <summary>
    /// Option to specify the logging mode, which determines if and where build logs are stored.
    /// Possible values are: LOGGING_UNSPECIFIED, LEGACY, GCS_ONLY, STACKDRIVER_ONLY, CLOUD_LOGGING_ONLY, NONE.
    /// </summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Compute Engine machine type on which to run the build.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Requested verifiability options.
    /// Possible values are: NOT_VERIFIED, VERIFIED.
    /// </summary>
    [JsonPropertyName("requestedVerifyOption")]
    public string? RequestedVerifyOption { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>
    /// Requested hash for SourceProvenance.
    /// Each value may be one of: NONE, SHA256, MD5.
    /// </summary>
    [JsonPropertyName("sourceProvenanceHash")]
    public IList<string>? SourceProvenanceHash { get; set; }

    /// <summary>
    /// Option to specify behavior when there is an error in the substitution checks.
    /// NOTE this is always set to ALLOW_LOOSE for triggered builds and cannot be overridden
    /// in the build configuration file.
    /// Possible values are: MUST_MATCH, ALLOW_LOOSE.
    /// </summary>
    [JsonPropertyName("substitutionOption")]
    public string? SubstitutionOption { get; set; }

    /// <summary>
    /// List of volumes to mount into the build step.
    /// Each volume is created as an empty volume prior to execution of the
    /// build step. Upon completion of the build, volumes and their contents
    /// are discarded.
    /// Using a named volume in only one step is not valid as it is
    /// indicative of a build request with an incorrect configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2TriggerSpecForProviderBuildOptionsVolumes>? Volumes { get; set; }

    /// <summary>
    /// Option to specify a WorkerPool for the build. Format projects/{project}/workerPools/{workerPool}
    /// This field is experimental.
    /// </summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildSecret
{
    /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IDictionary<string, string>? SecretEnv { get; set; }
}

/// <summary>
/// Location of the source in a Google Cloud Source Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildSourceRepoSource
{
    /// <summary>
    /// Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// ID of the project that owns the Cloud Source Repository. If
    /// omitted, the project ID requesting the build is assumed.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name &quot;default&quot; is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>
    /// Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Location of the source in an archive file in Google Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Google Cloud Storage generation for the object.
    /// If the generation is omitted, the latest generation will be used
    /// </summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>
    /// Google Cloud Storage object containing the source.
    /// This object must be a gzipped archive file (.tar.gz) containing source to build.
    /// </summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The location of the source files to build.
/// One of storageSource or repoSource must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildSource
{
    /// <summary>
    /// Location of the source in a Google Cloud Source Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repoSource")]
    public V1beta2TriggerSpecForProviderBuildSourceRepoSource? RepoSource { get; set; }

    /// <summary>
    /// Location of the source in an archive file in Google Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageSource")]
    public V1beta2TriggerSpecForProviderBuildSourceStorageSource? StorageSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildStepVolumes
{
    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuildStep
{
    /// <summary>
    /// Allow this build step to fail without failing the entire build if and
    /// only if the exit code is one of the specified codes.
    /// If allowFailure is also specified, this field will take precedence.
    /// </summary>
    [JsonPropertyName("allowExitCodes")]
    public IList<double>? AllowExitCodes { get; set; }

    /// <summary>
    /// Allow this build step to fail without failing the entire build.
    /// If false, the entire build will fail if this step fails. Otherwise, the
    /// build will succeed, but this step will still have a failure status.
    /// Error information will be reported in the failureDetail field.
    /// allowExitCodes takes precedence over this field.
    /// </summary>
    [JsonPropertyName("allowFailure")]
    public bool? AllowFailure { get; set; }

    /// <summary>
    /// A list of arguments that will be presented to the step when it is started.
    /// If the image used to run the step&apos;s container has an entrypoint, the args
    /// are used as arguments to that entrypoint. If the image does not define an
    /// entrypoint, the first element in args is used as the entrypoint, and the
    /// remainder will be used as arguments.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>
    /// Entrypoint to be used instead of the build step image&apos;s
    /// default entrypoint.
    /// If unset, the image&apos;s default entrypoint is used
    /// </summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>
    /// Unique identifier for this build step, used in wait_for to
    /// reference this build step as a dependency.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A shell script to be executed in the step.
    /// When script is provided, the user cannot specify the entrypoint or args.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>
    /// Time limit for executing this build step. If not defined,
    /// the step has no
    /// time limit and will be allowed to continue to run until either it
    /// completes or the build itself times out.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>
    /// Output only. Stores timing information for executing this
    /// build step.
    /// </summary>
    [JsonPropertyName("timing")]
    public string? Timing { get; set; }

    /// <summary>
    /// List of volumes to mount into the build step.
    /// Each volume is created as an empty volume prior to execution of the
    /// build step. Upon completion of the build, volumes and their contents
    /// are discarded.
    /// Using a named volume in only one step is not valid as it is
    /// indicative of a build request with an incorrect configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2TriggerSpecForProviderBuildStepVolumes>? Volumes { get; set; }

    /// <summary>
    /// The ID(s) of the step(s) that this build step depends on.
    /// This build step will not start until all the build steps in wait_for
    /// have completed successfully. If wait_for is empty, this build step
    /// will start when all previous build steps in the Build.Steps list
    /// have completed successfully.
    /// </summary>
    [JsonPropertyName("waitFor")]
    public IList<string>? WaitFor { get; set; }
}

/// <summary>
/// Contents of the build template. Either a filename or build template must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderBuild
{
    /// <summary>
    /// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public V1beta2TriggerSpecForProviderBuildArtifacts? Artifacts { get; set; }

    /// <summary>
    /// Secrets and secret environment variables.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availableSecrets")]
    public V1beta2TriggerSpecForProviderBuildAvailableSecrets? AvailableSecrets { get; set; }

    /// <summary>
    /// A list of images to be pushed upon the successful completion of all build steps.
    /// The images are pushed using the builder service account&apos;s credentials.
    /// The digests of the pushed images will be stored in the Build resource&apos;s results field.
    /// If any of the images fail to be pushed, the build status is marked FAILURE.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// Google Cloud Storage bucket where logs should be written.
    /// Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.
    /// </summary>
    [JsonPropertyName("logsBucket")]
    public string? LogsBucket { get; set; }

    /// <summary>
    /// Special options for this build.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("options")]
    public V1beta2TriggerSpecForProviderBuildOptions? Options { get; set; }

    /// <summary>
    /// TTL in queue for this build. If provided and the build is enqueued longer than this value,
    /// the build will expire and the build status will be EXPIRED.
    /// The TTL starts ticking from createTime.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("queueTtl")]
    public string? QueueTtl { get; set; }

    /// <summary>
    /// Secrets to decrypt using Cloud Key Management Service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2TriggerSpecForProviderBuildSecret>? Secret { get; set; }

    /// <summary>
    /// The location of the source files to build.
    /// One of storageSource or repoSource must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2TriggerSpecForProviderBuildSource? Source { get; set; }

    /// <summary>
    /// The operations to be performed on the workspace.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("step")]
    public IList<V1beta2TriggerSpecForProviderBuildStep>? Step { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a Build. These are not docker tags.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// Amount of time that this build should be allowed to run, to second granularity.
    /// If this amount of time elapses, work on the build will cease and the build status will be TIMEOUT.
    /// This timeout must be equal to or greater than the sum of the timeouts for build steps within the build.
    /// The expected format is the number of seconds followed by s.
    /// Default time is ten minutes (600s).
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// The file source describing the local or remote Build template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderGitFileSource
{
    /// <summary>
    /// The full resource name of the bitbucket server config.
    /// Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.
    /// </summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>
    /// The full resource name of the github enterprise config.
    /// Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The path of the file, with the repo root as the root of the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The type of the repo, since it may not be explicit from the repo field (e.g from a URL).
    /// Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER
    /// Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.
    /// </summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>
    /// The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository.
    /// If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>
    /// The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the
    /// filename . This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions
    /// If unspecified, the revision from which the trigger invocation originated is assumed to be the revision from which to read the specified path.
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>
    /// The URI of the repo . If unspecified, the repo from which the trigger
    /// invocation originated is assumed to be the repo from which to read the specified path.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// filter to match changes in pull requests. Specify only one of pull_request or push.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderGithubPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// filter to match changes in refs, like branches or tags. Specify only one of pull_request or push.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderGithubPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
/// One of trigger_template, github, pubsub_config or webhook_config must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderGithub
{
    /// <summary>
    /// The resource name of the github enterprise config that should be applied to this installation.
    /// For example: &quot;projects/{$projectId}/locations/{$locationId}/githubEnterpriseConfigs/{$configId}&quot;
    /// </summary>
    [JsonPropertyName("enterpriseConfigResourceName")]
    public string? EnterpriseConfigResourceName { get; set; }

    /// <summary>
    /// Name of the repository. For example: The name for
    /// https://github.com/googlecloudplatform/cloud-builders is &quot;cloud-builders&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Owner of the repository. For example: The owner for
    /// https://github.com/googlecloudplatform/cloud-builders is &quot;googlecloudplatform&quot;.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// filter to match changes in pull requests. Specify only one of pull_request or push.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerSpecForProviderGithubPullRequest? PullRequest { get; set; }

    /// <summary>
    /// filter to match changes in refs, like branches or tags. Specify only one of pull_request or push.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerSpecForProviderGithubPush? Push { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicyResolveEnum>))]
public enum V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderPubsubConfigTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TriggerSpecForProviderPubsubConfigTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolveEnum>))]
public enum V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderPubsubConfigTopicSelector
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
    public V1beta2TriggerSpecForProviderPubsubConfigTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// PubsubConfig describes the configuration of a trigger that creates
/// a build whenever a Pub/Sub message is published.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderPubsubConfig
{
    /// <summary>Service account that will make the push request.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta2TriggerSpecForProviderPubsubConfigTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta2TriggerSpecForProviderPubsubConfigTopicSelector? TopicSelector { get; set; }
}

/// <summary>
/// Contains filter properties for matching Pull Requests.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderRepositoryEventConfigPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// Contains filter properties for matching git pushes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderRepositoryEventConfigPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// The configuration of a trigger that creates a build whenever an event from Repo API is received.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderRepositoryEventConfig
{
    /// <summary>
    /// Contains filter properties for matching Pull Requests.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerSpecForProviderRepositoryEventConfigPullRequest? PullRequest { get; set; }

    /// <summary>
    /// Contains filter properties for matching git pushes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerSpecForProviderRepositoryEventConfigPush? Push { get; set; }

    /// <summary>The resource name of the Repo API resource.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecForProviderServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2TriggerSpecForProviderServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecForProviderServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecForProviderServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TriggerSpecForProviderServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecForProviderServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2TriggerSpecForProviderServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecForProviderServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecForProviderServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderServiceAccountSelector
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
    public V1beta2TriggerSpecForProviderServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The repo and ref of the repository from which to build.
/// This field is used only for those triggers that do not respond to SCM events.
/// Triggers that respond to such events build source at whatever commit caused the event.
/// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderSourceToBuild
{
    /// <summary>
    /// The full resource name of the bitbucket server config.
    /// Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.
    /// </summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>
    /// The full resource name of the github enterprise config.
    /// Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The branch or tag to use. Must start with &quot;refs/&quot; .</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>
    /// The type of the repo, since it may not be explicit from the repo field (e.g from a URL).
    /// Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER
    /// Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.
    /// </summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The URI of the repo.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Template describing the types of source changes to trigger a build.
/// Branch and tag names in trigger templates are interpreted as regular
/// expressions. Any branch or tag change that matches that regular
/// expression will trigger a build.
/// One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderTriggerTemplate
{
    /// <summary>
    /// Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// ID of the project that owns the Cloud Source Repository. If
    /// omitted, the project ID requesting the build is assumed.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name &quot;default&quot; is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>
    /// Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicyResolveEnum>))]
public enum V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderWebhookConfigSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TriggerSpecForProviderWebhookConfigSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolveEnum>))]
public enum V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderWebhookConfigSecretSelector
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
    public V1beta2TriggerSpecForProviderWebhookConfigSecretSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// WebhookConfig describes the configuration of a trigger that creates
/// a build whenever a webhook is sent to a trigger&apos;s webhook URL.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProviderWebhookConfig
{
    /// <summary>Resource name for the secret required as a URL parameter.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2TriggerSpecForProviderWebhookConfigSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta2TriggerSpecForProviderWebhookConfigSecretSelector? SecretSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecForProvider
{
    /// <summary>
    /// Configuration for manual approval to start a build invocation of this BuildTrigger.
    /// Builds created by this trigger will require approval before they execute.
    /// Any user with a Cloud Build Approver role for the project can approve a build.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("approvalConfig")]
    public V1beta2TriggerSpecForProviderApprovalConfig? ApprovalConfig { get; set; }

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketServerTriggerConfig")]
    public V1beta2TriggerSpecForProviderBitbucketServerTriggerConfig? BitbucketServerTriggerConfig { get; set; }

    /// <summary>
    /// Contents of the build template. Either a filename or build template must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("build")]
    public V1beta2TriggerSpecForProviderBuild? Build { get; set; }

    /// <summary>Human-readable description of the trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the trigger is disabled or not. If true, the trigger will never result in a build.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>A Common Expression Language string. Used only with Pub/Sub and Webhook.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The file source describing the local or remote Build template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitFileSource")]
    public V1beta2TriggerSpecForProviderGitFileSource? GitFileSource { get; set; }

    /// <summary>
    /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
    /// One of trigger_template, github, pubsub_config or webhook_config must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("github")]
    public V1beta2TriggerSpecForProviderGithub? Github { get; set; }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for **.
    /// If ignoredFiles and changed files are both empty, then they are not
    /// used to determine whether or not to trigger a build.
    /// If ignoredFiles is not empty, then we ignore any files that match any
    /// of the ignored_file globs. If the change has no files that are outside
    /// of the ignoredFiles globs, then we do not trigger a build.
    /// </summary>
    [JsonPropertyName("ignoredFiles")]
    public IList<string>? IgnoredFiles { get; set; }

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS
    /// Possible values are: INCLUDE_BUILD_LOGS_UNSPECIFIED, INCLUDE_BUILD_LOGS_WITH_STATUS.
    /// </summary>
    [JsonPropertyName("includeBuildLogs")]
    public string? IncludeBuildLogs { get; set; }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for **.
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is empty, then as far as this filter is concerned, we
    /// should trigger the build.
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is not empty, then we make sure that at least one of
    /// those files matches a includedFiles glob. If not, then we do not trigger
    /// a build.
    /// </summary>
    [JsonPropertyName("includedFiles")]
    public IList<string>? IncludedFiles { get; set; }

    /// <summary>
    /// The Cloud Build location for the trigger.
    /// If not specified, &quot;global&quot; is used.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the trigger. Must be unique within the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates
    /// a build whenever a Pub/Sub message is published.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubConfig")]
    public V1beta2TriggerSpecForProviderPubsubConfig? PubsubConfig { get; set; }

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repositoryEventConfig")]
    public V1beta2TriggerSpecForProviderRepositoryEventConfig? RepositoryEventConfig { get; set; }

    /// <summary>
    /// The service account used for all user-controlled operations including
    /// triggers.patch, triggers.run, builds.create, and builds.cancel.
    /// If no service account is set, then the standard Cloud Build service account
    /// ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.
    /// Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2TriggerSpecForProviderServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2TriggerSpecForProviderServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// The repo and ref of the repository from which to build.
    /// This field is used only for those triggers that do not respond to SCM events.
    /// Triggers that respond to such events build source at whatever commit caused the event.
    /// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceToBuild")]
    public V1beta2TriggerSpecForProviderSourceToBuild? SourceToBuild { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a BuildTrigger</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// Template describing the types of source changes to trigger a build.
    /// Branch and tag names in trigger templates are interpreted as regular
    /// expressions. Any branch or tag change that matches that regular
    /// expression will trigger a build.
    /// One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerTemplate")]
    public V1beta2TriggerSpecForProviderTriggerTemplate? TriggerTemplate { get; set; }

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates
    /// a build whenever a webhook is sent to a trigger&apos;s webhook URL.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("webhookConfig")]
    public V1beta2TriggerSpecForProviderWebhookConfig? WebhookConfig { get; set; }
}

/// <summary>
/// Configuration for manual approval to start a build invocation of this BuildTrigger.
/// Builds created by this trigger will require approval before they execute.
/// Any user with a Cloud Build Approver role for the project can approve a build.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderApprovalConfig
{
    /// <summary>
    /// Whether or not approval is needed. If this is set on a build, it will become pending when run,
    /// and will need to be explicitly approved to start.
    /// </summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }
}

/// <summary>
/// Filter to match changes in pull requests.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBitbucketServerTriggerConfigPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// Filter to match changes in refs like branches, tags.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBitbucketServerTriggerConfigPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBitbucketServerTriggerConfig
{
    /// <summary>The Bitbucket server config resource that this trigger config maps to.</summary>
    [JsonPropertyName("bitbucketServerConfigResource")]
    public string? BitbucketServerConfigResource { get; set; }

    /// <summary>Key of the project that the repo is in. For example: The key for https://mybitbucket.server/projects/TEST/repos/test-repo is &quot;TEST&quot;.</summary>
    [JsonPropertyName("projectKey")]
    public string? ProjectKey { get; set; }

    /// <summary>
    /// Filter to match changes in pull requests.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerSpecInitProviderBitbucketServerTriggerConfigPullRequest? PullRequest { get; set; }

    /// <summary>
    /// Filter to match changes in refs like branches, tags.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerSpecInitProviderBitbucketServerTriggerConfigPush? Push { get; set; }

    /// <summary>
    /// Slug of the repository. A repository slug is a URL-friendly version of a repository name, automatically generated by Bitbucket for use in the URL.
    /// For example, if the repository name is &apos;test repo&apos;, in the URL it would become &apos;test-repo&apos; as in https://mybitbucket.server/projects/TEST/repos/test-repo.
    /// </summary>
    [JsonPropertyName("repoSlug")]
    public string? RepoSlug { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildArtifactsMavenArtifacts
{
    /// <summary>Maven artifactId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Maven groupId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Maven version value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildArtifactsNpmPackages
{
    /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
    [JsonPropertyName("packagePath")]
    public string? PackagePath { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.
/// Files in the workspace matching specified paths globs will be uploaded to the
/// Cloud Storage location using the builder service account&apos;s credentials.
/// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
/// If any objects fail to be pushed, the build is marked FAILURE.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildArtifactsObjects
{
    /// <summary>
    /// Cloud Storage bucket and optional object path, in the form &quot;gs://bucket/path/to/somewhere/&quot;.
    /// Files in the workspace matching any path pattern will be uploaded to Cloud Storage with
    /// this location as a prefix.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Path globs used to match files in the build&apos;s workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildArtifactsPythonPackages
{
    /// <summary>Path globs used to match files in the build&apos;s workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildArtifacts
{
    /// <summary>
    /// A list of images to be pushed upon the successful completion of all build steps.
    /// The images are pushed using the builder service account&apos;s credentials.
    /// The digests of the pushed images will be stored in the Build resource&apos;s results field.
    /// If any of the images fail to be pushed, the build status is marked FAILURE.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// A Maven artifact to upload to Artifact Registry upon successful completion of all build steps.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenArtifacts")]
    public IList<V1beta2TriggerSpecInitProviderBuildArtifactsMavenArtifacts>? MavenArtifacts { get; set; }

    /// <summary>
    /// Npm package to upload to Artifact Registry upon successful completion of all build steps.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("npmPackages")]
    public IList<V1beta2TriggerSpecInitProviderBuildArtifactsNpmPackages>? NpmPackages { get; set; }

    /// <summary>
    /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.
    /// Files in the workspace matching specified paths globs will be uploaded to the
    /// Cloud Storage location using the builder service account&apos;s credentials.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public V1beta2TriggerSpecInitProviderBuildArtifactsObjects? Objects { get; set; }

    /// <summary>
    /// Python package to upload to Artifact Registry upon successful completion of all build steps. A package can encapsulate multiple objects to be uploaded to a single repository.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonPackages")]
    public IList<V1beta2TriggerSpecInitProviderBuildArtifactsPythonPackages>? PythonPackages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildAvailableSecretsSecretManager
{
    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public string? Env { get; set; }

    /// <summary>Resource name of the SecretVersion. In format: projects//secrets//versions/*</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary>
/// Secrets and secret environment variables.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildAvailableSecrets
{
    /// <summary>
    /// Pairs a secret environment variable with a SecretVersion in Secret Manager.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretManager")]
    public IList<V1beta2TriggerSpecInitProviderBuildAvailableSecretsSecretManager>? SecretManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildOptionsVolumes
{
    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Special options for this build.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildOptions
{
    /// <summary>
    /// Requested disk size for the VM that runs the build. Note that this is NOT &quot;disk free&quot;;
    /// some of the space will be used by the operating system and build utilities.
    /// Also note that this is the minimum disk size that will be allocated for the build --
    /// the build may run with a larger disk than requested. At present, the maximum disk size
    /// is 1000GB; builds that request more than the maximum are rejected with an error.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// Option to specify whether or not to apply bash style string operations to the substitutions.
    /// NOTE this is always enabled for triggered builds and cannot be overridden in the build configuration file.
    /// </summary>
    [JsonPropertyName("dynamicSubstitutions")]
    public bool? DynamicSubstitutions { get; set; }

    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>
    /// Option to define build log streaming behavior to Google Cloud Storage.
    /// Possible values are: STREAM_DEFAULT, STREAM_ON, STREAM_OFF.
    /// </summary>
    [JsonPropertyName("logStreamingOption")]
    public string? LogStreamingOption { get; set; }

    /// <summary>
    /// Option to specify the logging mode, which determines if and where build logs are stored.
    /// Possible values are: LOGGING_UNSPECIFIED, LEGACY, GCS_ONLY, STACKDRIVER_ONLY, CLOUD_LOGGING_ONLY, NONE.
    /// </summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Compute Engine machine type on which to run the build.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Requested verifiability options.
    /// Possible values are: NOT_VERIFIED, VERIFIED.
    /// </summary>
    [JsonPropertyName("requestedVerifyOption")]
    public string? RequestedVerifyOption { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>
    /// Requested hash for SourceProvenance.
    /// Each value may be one of: NONE, SHA256, MD5.
    /// </summary>
    [JsonPropertyName("sourceProvenanceHash")]
    public IList<string>? SourceProvenanceHash { get; set; }

    /// <summary>
    /// Option to specify behavior when there is an error in the substitution checks.
    /// NOTE this is always set to ALLOW_LOOSE for triggered builds and cannot be overridden
    /// in the build configuration file.
    /// Possible values are: MUST_MATCH, ALLOW_LOOSE.
    /// </summary>
    [JsonPropertyName("substitutionOption")]
    public string? SubstitutionOption { get; set; }

    /// <summary>
    /// List of volumes to mount into the build step.
    /// Each volume is created as an empty volume prior to execution of the
    /// build step. Upon completion of the build, volumes and their contents
    /// are discarded.
    /// Using a named volume in only one step is not valid as it is
    /// indicative of a build request with an incorrect configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2TriggerSpecInitProviderBuildOptionsVolumes>? Volumes { get; set; }

    /// <summary>
    /// Option to specify a WorkerPool for the build. Format projects/{project}/workerPools/{workerPool}
    /// This field is experimental.
    /// </summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildSecret
{
    /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IDictionary<string, string>? SecretEnv { get; set; }
}

/// <summary>
/// Location of the source in a Google Cloud Source Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildSourceRepoSource
{
    /// <summary>
    /// Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// ID of the project that owns the Cloud Source Repository. If
    /// omitted, the project ID requesting the build is assumed.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name &quot;default&quot; is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>
    /// Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Location of the source in an archive file in Google Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Google Cloud Storage generation for the object.
    /// If the generation is omitted, the latest generation will be used
    /// </summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>
    /// Google Cloud Storage object containing the source.
    /// This object must be a gzipped archive file (.tar.gz) containing source to build.
    /// </summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The location of the source files to build.
/// One of storageSource or repoSource must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildSource
{
    /// <summary>
    /// Location of the source in a Google Cloud Source Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repoSource")]
    public V1beta2TriggerSpecInitProviderBuildSourceRepoSource? RepoSource { get; set; }

    /// <summary>
    /// Location of the source in an archive file in Google Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageSource")]
    public V1beta2TriggerSpecInitProviderBuildSourceStorageSource? StorageSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildStepVolumes
{
    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuildStep
{
    /// <summary>
    /// Allow this build step to fail without failing the entire build if and
    /// only if the exit code is one of the specified codes.
    /// If allowFailure is also specified, this field will take precedence.
    /// </summary>
    [JsonPropertyName("allowExitCodes")]
    public IList<double>? AllowExitCodes { get; set; }

    /// <summary>
    /// Allow this build step to fail without failing the entire build.
    /// If false, the entire build will fail if this step fails. Otherwise, the
    /// build will succeed, but this step will still have a failure status.
    /// Error information will be reported in the failureDetail field.
    /// allowExitCodes takes precedence over this field.
    /// </summary>
    [JsonPropertyName("allowFailure")]
    public bool? AllowFailure { get; set; }

    /// <summary>
    /// A list of arguments that will be presented to the step when it is started.
    /// If the image used to run the step&apos;s container has an entrypoint, the args
    /// are used as arguments to that entrypoint. If the image does not define an
    /// entrypoint, the first element in args is used as the entrypoint, and the
    /// remainder will be used as arguments.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>
    /// Entrypoint to be used instead of the build step image&apos;s
    /// default entrypoint.
    /// If unset, the image&apos;s default entrypoint is used
    /// </summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>
    /// Unique identifier for this build step, used in wait_for to
    /// reference this build step as a dependency.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A shell script to be executed in the step.
    /// When script is provided, the user cannot specify the entrypoint or args.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>
    /// Time limit for executing this build step. If not defined,
    /// the step has no
    /// time limit and will be allowed to continue to run until either it
    /// completes or the build itself times out.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>
    /// Output only. Stores timing information for executing this
    /// build step.
    /// </summary>
    [JsonPropertyName("timing")]
    public string? Timing { get; set; }

    /// <summary>
    /// List of volumes to mount into the build step.
    /// Each volume is created as an empty volume prior to execution of the
    /// build step. Upon completion of the build, volumes and their contents
    /// are discarded.
    /// Using a named volume in only one step is not valid as it is
    /// indicative of a build request with an incorrect configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2TriggerSpecInitProviderBuildStepVolumes>? Volumes { get; set; }

    /// <summary>
    /// The ID(s) of the step(s) that this build step depends on.
    /// This build step will not start until all the build steps in wait_for
    /// have completed successfully. If wait_for is empty, this build step
    /// will start when all previous build steps in the Build.Steps list
    /// have completed successfully.
    /// </summary>
    [JsonPropertyName("waitFor")]
    public IList<string>? WaitFor { get; set; }
}

/// <summary>
/// Contents of the build template. Either a filename or build template must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderBuild
{
    /// <summary>
    /// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public V1beta2TriggerSpecInitProviderBuildArtifacts? Artifacts { get; set; }

    /// <summary>
    /// Secrets and secret environment variables.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availableSecrets")]
    public V1beta2TriggerSpecInitProviderBuildAvailableSecrets? AvailableSecrets { get; set; }

    /// <summary>
    /// A list of images to be pushed upon the successful completion of all build steps.
    /// The images are pushed using the builder service account&apos;s credentials.
    /// The digests of the pushed images will be stored in the Build resource&apos;s results field.
    /// If any of the images fail to be pushed, the build status is marked FAILURE.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// Google Cloud Storage bucket where logs should be written.
    /// Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.
    /// </summary>
    [JsonPropertyName("logsBucket")]
    public string? LogsBucket { get; set; }

    /// <summary>
    /// Special options for this build.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("options")]
    public V1beta2TriggerSpecInitProviderBuildOptions? Options { get; set; }

    /// <summary>
    /// TTL in queue for this build. If provided and the build is enqueued longer than this value,
    /// the build will expire and the build status will be EXPIRED.
    /// The TTL starts ticking from createTime.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("queueTtl")]
    public string? QueueTtl { get; set; }

    /// <summary>
    /// Secrets to decrypt using Cloud Key Management Service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2TriggerSpecInitProviderBuildSecret>? Secret { get; set; }

    /// <summary>
    /// The location of the source files to build.
    /// One of storageSource or repoSource must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2TriggerSpecInitProviderBuildSource? Source { get; set; }

    /// <summary>
    /// The operations to be performed on the workspace.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("step")]
    public IList<V1beta2TriggerSpecInitProviderBuildStep>? Step { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a Build. These are not docker tags.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// Amount of time that this build should be allowed to run, to second granularity.
    /// If this amount of time elapses, work on the build will cease and the build status will be TIMEOUT.
    /// This timeout must be equal to or greater than the sum of the timeouts for build steps within the build.
    /// The expected format is the number of seconds followed by s.
    /// Default time is ten minutes (600s).
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// The file source describing the local or remote Build template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderGitFileSource
{
    /// <summary>
    /// The full resource name of the bitbucket server config.
    /// Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.
    /// </summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>
    /// The full resource name of the github enterprise config.
    /// Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The path of the file, with the repo root as the root of the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The type of the repo, since it may not be explicit from the repo field (e.g from a URL).
    /// Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER
    /// Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.
    /// </summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>
    /// The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository.
    /// If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>
    /// The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the
    /// filename . This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions
    /// If unspecified, the revision from which the trigger invocation originated is assumed to be the revision from which to read the specified path.
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>
    /// The URI of the repo . If unspecified, the repo from which the trigger
    /// invocation originated is assumed to be the repo from which to read the specified path.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// filter to match changes in pull requests. Specify only one of pull_request or push.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderGithubPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// filter to match changes in refs, like branches or tags. Specify only one of pull_request or push.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderGithubPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
/// One of trigger_template, github, pubsub_config or webhook_config must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderGithub
{
    /// <summary>
    /// The resource name of the github enterprise config that should be applied to this installation.
    /// For example: &quot;projects/{$projectId}/locations/{$locationId}/githubEnterpriseConfigs/{$configId}&quot;
    /// </summary>
    [JsonPropertyName("enterpriseConfigResourceName")]
    public string? EnterpriseConfigResourceName { get; set; }

    /// <summary>
    /// Name of the repository. For example: The name for
    /// https://github.com/googlecloudplatform/cloud-builders is &quot;cloud-builders&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Owner of the repository. For example: The owner for
    /// https://github.com/googlecloudplatform/cloud-builders is &quot;googlecloudplatform&quot;.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// filter to match changes in pull requests. Specify only one of pull_request or push.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerSpecInitProviderGithubPullRequest? PullRequest { get; set; }

    /// <summary>
    /// filter to match changes in refs, like branches or tags. Specify only one of pull_request or push.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerSpecInitProviderGithubPush? Push { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolveEnum>))]
public enum V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderPubsubConfigTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolveEnum>))]
public enum V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderPubsubConfigTopicSelector
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
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// PubsubConfig describes the configuration of a trigger that creates
/// a build whenever a Pub/Sub message is published.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderPubsubConfig
{
    /// <summary>Service account that will make the push request.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta2TriggerSpecInitProviderPubsubConfigTopicSelector? TopicSelector { get; set; }
}

/// <summary>
/// Contains filter properties for matching Pull Requests.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderRepositoryEventConfigPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// Contains filter properties for matching git pushes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderRepositoryEventConfigPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// The configuration of a trigger that creates a build whenever an event from Repo API is received.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderRepositoryEventConfig
{
    /// <summary>
    /// Contains filter properties for matching Pull Requests.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerSpecInitProviderRepositoryEventConfigPullRequest? PullRequest { get; set; }

    /// <summary>
    /// Contains filter properties for matching git pushes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerSpecInitProviderRepositoryEventConfigPush? Push { get; set; }

    /// <summary>The resource name of the Repo API resource.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecInitProviderServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2TriggerSpecInitProviderServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecInitProviderServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecInitProviderServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TriggerSpecInitProviderServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderServiceAccountSelector
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
    public V1beta2TriggerSpecInitProviderServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The repo and ref of the repository from which to build.
/// This field is used only for those triggers that do not respond to SCM events.
/// Triggers that respond to such events build source at whatever commit caused the event.
/// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderSourceToBuild
{
    /// <summary>
    /// The full resource name of the bitbucket server config.
    /// Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.
    /// </summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>
    /// The full resource name of the github enterprise config.
    /// Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The branch or tag to use. Must start with &quot;refs/&quot; .</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>
    /// The type of the repo, since it may not be explicit from the repo field (e.g from a URL).
    /// Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER
    /// Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.
    /// </summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The URI of the repo.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Template describing the types of source changes to trigger a build.
/// Branch and tag names in trigger templates are interpreted as regular
/// expressions. Any branch or tag change that matches that regular
/// expression will trigger a build.
/// One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderTriggerTemplate
{
    /// <summary>
    /// Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// ID of the project that owns the Cloud Source Repository. If
    /// omitted, the project ID requesting the build is assumed.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name &quot;default&quot; is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>
    /// Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolveEnum>))]
public enum V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderWebhookConfigSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolveEnum>))]
public enum V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderWebhookConfigSecretSelector
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
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// WebhookConfig describes the configuration of a trigger that creates
/// a build whenever a webhook is sent to a trigger&apos;s webhook URL.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecInitProviderWebhookConfig
{
    /// <summary>Resource name for the secret required as a URL parameter.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta2TriggerSpecInitProviderWebhookConfigSecretSelector? SecretSelector { get; set; }
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
public partial class V1beta2TriggerSpecInitProvider
{
    /// <summary>
    /// Configuration for manual approval to start a build invocation of this BuildTrigger.
    /// Builds created by this trigger will require approval before they execute.
    /// Any user with a Cloud Build Approver role for the project can approve a build.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("approvalConfig")]
    public V1beta2TriggerSpecInitProviderApprovalConfig? ApprovalConfig { get; set; }

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketServerTriggerConfig")]
    public V1beta2TriggerSpecInitProviderBitbucketServerTriggerConfig? BitbucketServerTriggerConfig { get; set; }

    /// <summary>
    /// Contents of the build template. Either a filename or build template must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("build")]
    public V1beta2TriggerSpecInitProviderBuild? Build { get; set; }

    /// <summary>Human-readable description of the trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the trigger is disabled or not. If true, the trigger will never result in a build.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>A Common Expression Language string. Used only with Pub/Sub and Webhook.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The file source describing the local or remote Build template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitFileSource")]
    public V1beta2TriggerSpecInitProviderGitFileSource? GitFileSource { get; set; }

    /// <summary>
    /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
    /// One of trigger_template, github, pubsub_config or webhook_config must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("github")]
    public V1beta2TriggerSpecInitProviderGithub? Github { get; set; }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for **.
    /// If ignoredFiles and changed files are both empty, then they are not
    /// used to determine whether or not to trigger a build.
    /// If ignoredFiles is not empty, then we ignore any files that match any
    /// of the ignored_file globs. If the change has no files that are outside
    /// of the ignoredFiles globs, then we do not trigger a build.
    /// </summary>
    [JsonPropertyName("ignoredFiles")]
    public IList<string>? IgnoredFiles { get; set; }

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS
    /// Possible values are: INCLUDE_BUILD_LOGS_UNSPECIFIED, INCLUDE_BUILD_LOGS_WITH_STATUS.
    /// </summary>
    [JsonPropertyName("includeBuildLogs")]
    public string? IncludeBuildLogs { get; set; }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for **.
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is empty, then as far as this filter is concerned, we
    /// should trigger the build.
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is not empty, then we make sure that at least one of
    /// those files matches a includedFiles glob. If not, then we do not trigger
    /// a build.
    /// </summary>
    [JsonPropertyName("includedFiles")]
    public IList<string>? IncludedFiles { get; set; }

    /// <summary>
    /// The Cloud Build location for the trigger.
    /// If not specified, &quot;global&quot; is used.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the trigger. Must be unique within the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates
    /// a build whenever a Pub/Sub message is published.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubConfig")]
    public V1beta2TriggerSpecInitProviderPubsubConfig? PubsubConfig { get; set; }

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repositoryEventConfig")]
    public V1beta2TriggerSpecInitProviderRepositoryEventConfig? RepositoryEventConfig { get; set; }

    /// <summary>
    /// The service account used for all user-controlled operations including
    /// triggers.patch, triggers.run, builds.create, and builds.cancel.
    /// If no service account is set, then the standard Cloud Build service account
    /// ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.
    /// Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2TriggerSpecInitProviderServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2TriggerSpecInitProviderServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// The repo and ref of the repository from which to build.
    /// This field is used only for those triggers that do not respond to SCM events.
    /// Triggers that respond to such events build source at whatever commit caused the event.
    /// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceToBuild")]
    public V1beta2TriggerSpecInitProviderSourceToBuild? SourceToBuild { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a BuildTrigger</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// Template describing the types of source changes to trigger a build.
    /// Branch and tag names in trigger templates are interpreted as regular
    /// expressions. Any branch or tag change that matches that regular
    /// expression will trigger a build.
    /// One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerTemplate")]
    public V1beta2TriggerSpecInitProviderTriggerTemplate? TriggerTemplate { get; set; }

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates
    /// a build whenever a webhook is sent to a trigger&apos;s webhook URL.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("webhookConfig")]
    public V1beta2TriggerSpecInitProviderWebhookConfig? WebhookConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecManagementPoliciesEnum>))]
public enum V1beta2TriggerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2TriggerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TriggerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2TriggerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TriggerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TriggerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TriggerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TriggerSpec defines the desired state of Trigger</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerSpec
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
    public V1beta2TriggerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2TriggerSpecForProvider ForProvider { get; set; }

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
    public V1beta2TriggerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2TriggerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2TriggerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2TriggerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration for manual approval to start a build invocation of this BuildTrigger.
/// Builds created by this trigger will require approval before they execute.
/// Any user with a Cloud Build Approver role for the project can approve a build.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderApprovalConfig
{
    /// <summary>
    /// Whether or not approval is needed. If this is set on a build, it will become pending when run,
    /// and will need to be explicitly approved to start.
    /// </summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }
}

/// <summary>
/// Filter to match changes in pull requests.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBitbucketServerTriggerConfigPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// Filter to match changes in refs like branches, tags.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBitbucketServerTriggerConfigPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBitbucketServerTriggerConfig
{
    /// <summary>The Bitbucket server config resource that this trigger config maps to.</summary>
    [JsonPropertyName("bitbucketServerConfigResource")]
    public string? BitbucketServerConfigResource { get; set; }

    /// <summary>Key of the project that the repo is in. For example: The key for https://mybitbucket.server/projects/TEST/repos/test-repo is &quot;TEST&quot;.</summary>
    [JsonPropertyName("projectKey")]
    public string? ProjectKey { get; set; }

    /// <summary>
    /// Filter to match changes in pull requests.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerStatusAtProviderBitbucketServerTriggerConfigPullRequest? PullRequest { get; set; }

    /// <summary>
    /// Filter to match changes in refs like branches, tags.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerStatusAtProviderBitbucketServerTriggerConfigPush? Push { get; set; }

    /// <summary>
    /// Slug of the repository. A repository slug is a URL-friendly version of a repository name, automatically generated by Bitbucket for use in the URL.
    /// For example, if the repository name is &apos;test repo&apos;, in the URL it would become &apos;test-repo&apos; as in https://mybitbucket.server/projects/TEST/repos/test-repo.
    /// </summary>
    [JsonPropertyName("repoSlug")]
    public string? RepoSlug { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildArtifactsMavenArtifacts
{
    /// <summary>Maven artifactId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Maven groupId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Maven version value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildArtifactsNpmPackages
{
    /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
    [JsonPropertyName("packagePath")]
    public string? PackagePath { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildArtifactsObjectsTiming
{
    /// <summary>
    /// End of time span.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to
    /// nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Start of time span.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to
    /// nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.
/// Files in the workspace matching specified paths globs will be uploaded to the
/// Cloud Storage location using the builder service account&apos;s credentials.
/// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
/// If any objects fail to be pushed, the build is marked FAILURE.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildArtifactsObjects
{
    /// <summary>
    /// Cloud Storage bucket and optional object path, in the form &quot;gs://bucket/path/to/somewhere/&quot;.
    /// Files in the workspace matching any path pattern will be uploaded to Cloud Storage with
    /// this location as a prefix.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Path globs used to match files in the build&apos;s workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>
    /// Output only. Stores timing information for executing this
    /// build step.
    /// </summary>
    [JsonPropertyName("timing")]
    public IList<V1beta2TriggerStatusAtProviderBuildArtifactsObjectsTiming>? Timing { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildArtifactsPythonPackages
{
    /// <summary>Path globs used to match files in the build&apos;s workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildArtifacts
{
    /// <summary>
    /// A list of images to be pushed upon the successful completion of all build steps.
    /// The images are pushed using the builder service account&apos;s credentials.
    /// The digests of the pushed images will be stored in the Build resource&apos;s results field.
    /// If any of the images fail to be pushed, the build status is marked FAILURE.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// A Maven artifact to upload to Artifact Registry upon successful completion of all build steps.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenArtifacts")]
    public IList<V1beta2TriggerStatusAtProviderBuildArtifactsMavenArtifacts>? MavenArtifacts { get; set; }

    /// <summary>
    /// Npm package to upload to Artifact Registry upon successful completion of all build steps.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("npmPackages")]
    public IList<V1beta2TriggerStatusAtProviderBuildArtifactsNpmPackages>? NpmPackages { get; set; }

    /// <summary>
    /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.
    /// Files in the workspace matching specified paths globs will be uploaded to the
    /// Cloud Storage location using the builder service account&apos;s credentials.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public V1beta2TriggerStatusAtProviderBuildArtifactsObjects? Objects { get; set; }

    /// <summary>
    /// Python package to upload to Artifact Registry upon successful completion of all build steps. A package can encapsulate multiple objects to be uploaded to a single repository.
    /// The location and generation of the uploaded objects will be stored in the Build resource&apos;s results field.
    /// If any objects fail to be pushed, the build is marked FAILURE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonPackages")]
    public IList<V1beta2TriggerStatusAtProviderBuildArtifactsPythonPackages>? PythonPackages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildAvailableSecretsSecretManager
{
    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public string? Env { get; set; }

    /// <summary>Resource name of the SecretVersion. In format: projects//secrets//versions/*</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary>
/// Secrets and secret environment variables.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildAvailableSecrets
{
    /// <summary>
    /// Pairs a secret environment variable with a SecretVersion in Secret Manager.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretManager")]
    public IList<V1beta2TriggerStatusAtProviderBuildAvailableSecretsSecretManager>? SecretManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildOptionsVolumes
{
    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Special options for this build.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildOptions
{
    /// <summary>
    /// Requested disk size for the VM that runs the build. Note that this is NOT &quot;disk free&quot;;
    /// some of the space will be used by the operating system and build utilities.
    /// Also note that this is the minimum disk size that will be allocated for the build --
    /// the build may run with a larger disk than requested. At present, the maximum disk size
    /// is 1000GB; builds that request more than the maximum are rejected with an error.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// Option to specify whether or not to apply bash style string operations to the substitutions.
    /// NOTE this is always enabled for triggered builds and cannot be overridden in the build configuration file.
    /// </summary>
    [JsonPropertyName("dynamicSubstitutions")]
    public bool? DynamicSubstitutions { get; set; }

    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>
    /// Option to define build log streaming behavior to Google Cloud Storage.
    /// Possible values are: STREAM_DEFAULT, STREAM_ON, STREAM_OFF.
    /// </summary>
    [JsonPropertyName("logStreamingOption")]
    public string? LogStreamingOption { get; set; }

    /// <summary>
    /// Option to specify the logging mode, which determines if and where build logs are stored.
    /// Possible values are: LOGGING_UNSPECIFIED, LEGACY, GCS_ONLY, STACKDRIVER_ONLY, CLOUD_LOGGING_ONLY, NONE.
    /// </summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Compute Engine machine type on which to run the build.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Requested verifiability options.
    /// Possible values are: NOT_VERIFIED, VERIFIED.
    /// </summary>
    [JsonPropertyName("requestedVerifyOption")]
    public string? RequestedVerifyOption { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>
    /// Requested hash for SourceProvenance.
    /// Each value may be one of: NONE, SHA256, MD5.
    /// </summary>
    [JsonPropertyName("sourceProvenanceHash")]
    public IList<string>? SourceProvenanceHash { get; set; }

    /// <summary>
    /// Option to specify behavior when there is an error in the substitution checks.
    /// NOTE this is always set to ALLOW_LOOSE for triggered builds and cannot be overridden
    /// in the build configuration file.
    /// Possible values are: MUST_MATCH, ALLOW_LOOSE.
    /// </summary>
    [JsonPropertyName("substitutionOption")]
    public string? SubstitutionOption { get; set; }

    /// <summary>
    /// List of volumes to mount into the build step.
    /// Each volume is created as an empty volume prior to execution of the
    /// build step. Upon completion of the build, volumes and their contents
    /// are discarded.
    /// Using a named volume in only one step is not valid as it is
    /// indicative of a build request with an incorrect configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2TriggerStatusAtProviderBuildOptionsVolumes>? Volumes { get; set; }

    /// <summary>
    /// Option to specify a WorkerPool for the build. Format projects/{project}/workerPools/{workerPool}
    /// This field is experimental.
    /// </summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildSecret
{
    /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IDictionary<string, string>? SecretEnv { get; set; }
}

/// <summary>
/// Location of the source in a Google Cloud Source Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildSourceRepoSource
{
    /// <summary>
    /// Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// ID of the project that owns the Cloud Source Repository. If
    /// omitted, the project ID requesting the build is assumed.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name &quot;default&quot; is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>
    /// Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Location of the source in an archive file in Google Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Google Cloud Storage generation for the object.
    /// If the generation is omitted, the latest generation will be used
    /// </summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>
    /// Google Cloud Storage object containing the source.
    /// This object must be a gzipped archive file (.tar.gz) containing source to build.
    /// </summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The location of the source files to build.
/// One of storageSource or repoSource must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildSource
{
    /// <summary>
    /// Location of the source in a Google Cloud Source Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repoSource")]
    public V1beta2TriggerStatusAtProviderBuildSourceRepoSource? RepoSource { get; set; }

    /// <summary>
    /// Location of the source in an archive file in Google Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageSource")]
    public V1beta2TriggerStatusAtProviderBuildSourceStorageSource? StorageSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildStepVolumes
{
    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path at which to mount the volume.
    /// Paths must be absolute and cannot conflict with other volume paths on
    /// the same build step or with certain reserved volume paths.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuildStep
{
    /// <summary>
    /// Allow this build step to fail without failing the entire build if and
    /// only if the exit code is one of the specified codes.
    /// If allowFailure is also specified, this field will take precedence.
    /// </summary>
    [JsonPropertyName("allowExitCodes")]
    public IList<double>? AllowExitCodes { get; set; }

    /// <summary>
    /// Allow this build step to fail without failing the entire build.
    /// If false, the entire build will fail if this step fails. Otherwise, the
    /// build will succeed, but this step will still have a failure status.
    /// Error information will be reported in the failureDetail field.
    /// allowExitCodes takes precedence over this field.
    /// </summary>
    [JsonPropertyName("allowFailure")]
    public bool? AllowFailure { get; set; }

    /// <summary>
    /// A list of arguments that will be presented to the step when it is started.
    /// If the image used to run the step&apos;s container has an entrypoint, the args
    /// are used as arguments to that entrypoint. If the image does not define an
    /// entrypoint, the first element in args is used as the entrypoint, and the
    /// remainder will be used as arguments.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>
    /// Entrypoint to be used instead of the build step image&apos;s
    /// default entrypoint.
    /// If unset, the image&apos;s default entrypoint is used
    /// </summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>
    /// A list of environment variable definitions to be used when
    /// running a step.
    /// The elements are of the form &quot;KEY=VALUE&quot; for the environment variable
    /// &quot;KEY&quot; being given the value &quot;VALUE&quot;.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>
    /// Unique identifier for this build step, used in wait_for to
    /// reference this build step as a dependency.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the volume to mount.
    /// Volume names must be unique per build step and must be valid names for
    /// Docker volumes. Each named volume must be used by at least two build steps.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A shell script to be executed in the step.
    /// When script is provided, the user cannot specify the entrypoint or args.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>
    /// A list of environment variables which are encrypted using
    /// a Cloud Key
    /// Management Service crypto key. These values must be specified in
    /// the build&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>
    /// Time limit for executing this build step. If not defined,
    /// the step has no
    /// time limit and will be allowed to continue to run until either it
    /// completes or the build itself times out.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>
    /// Output only. Stores timing information for executing this
    /// build step.
    /// </summary>
    [JsonPropertyName("timing")]
    public string? Timing { get; set; }

    /// <summary>
    /// List of volumes to mount into the build step.
    /// Each volume is created as an empty volume prior to execution of the
    /// build step. Upon completion of the build, volumes and their contents
    /// are discarded.
    /// Using a named volume in only one step is not valid as it is
    /// indicative of a build request with an incorrect configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2TriggerStatusAtProviderBuildStepVolumes>? Volumes { get; set; }

    /// <summary>
    /// The ID(s) of the step(s) that this build step depends on.
    /// This build step will not start until all the build steps in wait_for
    /// have completed successfully. If wait_for is empty, this build step
    /// will start when all previous build steps in the Build.Steps list
    /// have completed successfully.
    /// </summary>
    [JsonPropertyName("waitFor")]
    public IList<string>? WaitFor { get; set; }
}

/// <summary>
/// Contents of the build template. Either a filename or build template must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderBuild
{
    /// <summary>
    /// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public V1beta2TriggerStatusAtProviderBuildArtifacts? Artifacts { get; set; }

    /// <summary>
    /// Secrets and secret environment variables.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availableSecrets")]
    public V1beta2TriggerStatusAtProviderBuildAvailableSecrets? AvailableSecrets { get; set; }

    /// <summary>
    /// A list of images to be pushed upon the successful completion of all build steps.
    /// The images are pushed using the builder service account&apos;s credentials.
    /// The digests of the pushed images will be stored in the Build resource&apos;s results field.
    /// If any of the images fail to be pushed, the build status is marked FAILURE.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// Google Cloud Storage bucket where logs should be written.
    /// Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.
    /// </summary>
    [JsonPropertyName("logsBucket")]
    public string? LogsBucket { get; set; }

    /// <summary>
    /// Special options for this build.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("options")]
    public V1beta2TriggerStatusAtProviderBuildOptions? Options { get; set; }

    /// <summary>
    /// TTL in queue for this build. If provided and the build is enqueued longer than this value,
    /// the build will expire and the build status will be EXPIRED.
    /// The TTL starts ticking from createTime.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("queueTtl")]
    public string? QueueTtl { get; set; }

    /// <summary>
    /// Secrets to decrypt using Cloud Key Management Service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2TriggerStatusAtProviderBuildSecret>? Secret { get; set; }

    /// <summary>
    /// The location of the source files to build.
    /// One of storageSource or repoSource must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2TriggerStatusAtProviderBuildSource? Source { get; set; }

    /// <summary>
    /// The operations to be performed on the workspace.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("step")]
    public IList<V1beta2TriggerStatusAtProviderBuildStep>? Step { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a Build. These are not docker tags.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// Amount of time that this build should be allowed to run, to second granularity.
    /// If this amount of time elapses, work on the build will cease and the build status will be TIMEOUT.
    /// This timeout must be equal to or greater than the sum of the timeouts for build steps within the build.
    /// The expected format is the number of seconds followed by s.
    /// Default time is ten minutes (600s).
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// The file source describing the local or remote Build template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderGitFileSource
{
    /// <summary>
    /// The full resource name of the bitbucket server config.
    /// Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.
    /// </summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>
    /// The full resource name of the github enterprise config.
    /// Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The path of the file, with the repo root as the root of the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The type of the repo, since it may not be explicit from the repo field (e.g from a URL).
    /// Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER
    /// Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.
    /// </summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>
    /// The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository.
    /// If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>
    /// The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the
    /// filename . This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions
    /// If unspecified, the revision from which the trigger invocation originated is assumed to be the revision from which to read the specified path.
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>
    /// The URI of the repo . If unspecified, the repo from which the trigger
    /// invocation originated is assumed to be the repo from which to read the specified path.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// filter to match changes in pull requests. Specify only one of pull_request or push.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderGithubPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// filter to match changes in refs, like branches or tags. Specify only one of pull_request or push.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderGithubPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
/// One of trigger_template, github, pubsub_config or webhook_config must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderGithub
{
    /// <summary>
    /// The resource name of the github enterprise config that should be applied to this installation.
    /// For example: &quot;projects/{$projectId}/locations/{$locationId}/githubEnterpriseConfigs/{$configId}&quot;
    /// </summary>
    [JsonPropertyName("enterpriseConfigResourceName")]
    public string? EnterpriseConfigResourceName { get; set; }

    /// <summary>
    /// Name of the repository. For example: The name for
    /// https://github.com/googlecloudplatform/cloud-builders is &quot;cloud-builders&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Owner of the repository. For example: The owner for
    /// https://github.com/googlecloudplatform/cloud-builders is &quot;googlecloudplatform&quot;.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// filter to match changes in pull requests. Specify only one of pull_request or push.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerStatusAtProviderGithubPullRequest? PullRequest { get; set; }

    /// <summary>
    /// filter to match changes in refs, like branches or tags. Specify only one of pull_request or push.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerStatusAtProviderGithubPush? Push { get; set; }
}

/// <summary>
/// PubsubConfig describes the configuration of a trigger that creates
/// a build whenever a Pub/Sub message is published.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderPubsubConfig
{
    /// <summary>Service account that will make the push request.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>
    /// (Output)
    /// Potential issues with the underlying Pub/Sub subscription configuration.
    /// Only populated on get requests.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Name of the subscription.
    /// </summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }

    /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Contains filter properties for matching Pull Requests.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderRepositoryEventConfigPullRequest
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Configure builds to run whether a repository owner or collaborator need to comment /gcbrun.
    /// Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.
    /// </summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>
/// Contains filter properties for matching git pushes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderRepositoryEventConfigPush
{
    /// <summary>
    /// Regex of branches to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Regex of tags to match.
    /// The syntax of the regular expressions accepted is the syntax accepted by
    /// RE2 and described at https://github.com/google/re2/wiki/Syntax
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// The configuration of a trigger that creates a build whenever an event from Repo API is received.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderRepositoryEventConfig
{
    /// <summary>
    /// Contains filter properties for matching Pull Requests.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public V1beta2TriggerStatusAtProviderRepositoryEventConfigPullRequest? PullRequest { get; set; }

    /// <summary>
    /// Contains filter properties for matching git pushes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("push")]
    public V1beta2TriggerStatusAtProviderRepositoryEventConfigPush? Push { get; set; }

    /// <summary>The resource name of the Repo API resource.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// The repo and ref of the repository from which to build.
/// This field is used only for those triggers that do not respond to SCM events.
/// Triggers that respond to such events build source at whatever commit caused the event.
/// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderSourceToBuild
{
    /// <summary>
    /// The full resource name of the bitbucket server config.
    /// Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.
    /// </summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>
    /// The full resource name of the github enterprise config.
    /// Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The branch or tag to use. Must start with &quot;refs/&quot; .</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>
    /// The type of the repo, since it may not be explicit from the repo field (e.g from a URL).
    /// Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER
    /// Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.
    /// </summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>
    /// The qualified resource name of the Repo API repository.
    /// Either uri or repository can be specified and is required.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The URI of the repo.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Template describing the types of source changes to trigger a build.
/// Branch and tag names in trigger templates are interpreted as regular
/// expressions. Any branch or tag change that matches that regular
/// expression will trigger a build.
/// One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderTriggerTemplate
{
    /// <summary>
    /// Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// This must be a relative path. If a step&apos;s dir is specified and
    /// is an absolute path, this value is ignored for that step&apos;s
    /// execution.
    /// </summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// ID of the project that owns the Cloud Source Repository. If
    /// omitted, the project ID requesting the build is assumed.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name &quot;default&quot; is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>
    /// Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided.
    /// This field is a regular expression.
    /// </summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// WebhookConfig describes the configuration of a trigger that creates
/// a build whenever a webhook is sent to a trigger&apos;s webhook URL.
/// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProviderWebhookConfig
{
    /// <summary>Resource name for the secret required as a URL parameter.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>
    /// (Output)
    /// Potential issues with the underlying Pub/Sub subscription configuration.
    /// Only populated on get requests.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusAtProvider
{
    /// <summary>
    /// Configuration for manual approval to start a build invocation of this BuildTrigger.
    /// Builds created by this trigger will require approval before they execute.
    /// Any user with a Cloud Build Approver role for the project can approve a build.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("approvalConfig")]
    public V1beta2TriggerStatusAtProviderApprovalConfig? ApprovalConfig { get; set; }

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketServerTriggerConfig")]
    public V1beta2TriggerStatusAtProviderBitbucketServerTriggerConfig? BitbucketServerTriggerConfig { get; set; }

    /// <summary>
    /// Contents of the build template. Either a filename or build template must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("build")]
    public V1beta2TriggerStatusAtProviderBuild? Build { get; set; }

    /// <summary>Time when the trigger was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Human-readable description of the trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the trigger is disabled or not. If true, the trigger will never result in a build.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>A Common Expression Language string. Used only with Pub/Sub and Webhook.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The file source describing the local or remote Build template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitFileSource")]
    public V1beta2TriggerStatusAtProviderGitFileSource? GitFileSource { get; set; }

    /// <summary>
    /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
    /// One of trigger_template, github, pubsub_config or webhook_config must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("github")]
    public V1beta2TriggerStatusAtProviderGithub? Github { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/triggers/{{trigger_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for **.
    /// If ignoredFiles and changed files are both empty, then they are not
    /// used to determine whether or not to trigger a build.
    /// If ignoredFiles is not empty, then we ignore any files that match any
    /// of the ignored_file globs. If the change has no files that are outside
    /// of the ignoredFiles globs, then we do not trigger a build.
    /// </summary>
    [JsonPropertyName("ignoredFiles")]
    public IList<string>? IgnoredFiles { get; set; }

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS
    /// Possible values are: INCLUDE_BUILD_LOGS_UNSPECIFIED, INCLUDE_BUILD_LOGS_WITH_STATUS.
    /// </summary>
    [JsonPropertyName("includeBuildLogs")]
    public string? IncludeBuildLogs { get; set; }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for **.
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is empty, then as far as this filter is concerned, we
    /// should trigger the build.
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is not empty, then we make sure that at least one of
    /// those files matches a includedFiles glob. If not, then we do not trigger
    /// a build.
    /// </summary>
    [JsonPropertyName("includedFiles")]
    public IList<string>? IncludedFiles { get; set; }

    /// <summary>
    /// The Cloud Build location for the trigger.
    /// If not specified, &quot;global&quot; is used.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the trigger. Must be unique within the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates
    /// a build whenever a Pub/Sub message is published.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubConfig")]
    public V1beta2TriggerStatusAtProviderPubsubConfig? PubsubConfig { get; set; }

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repositoryEventConfig")]
    public V1beta2TriggerStatusAtProviderRepositoryEventConfig? RepositoryEventConfig { get; set; }

    /// <summary>
    /// The service account used for all user-controlled operations including
    /// triggers.patch, triggers.run, builds.create, and builds.cancel.
    /// If no service account is set, then the standard Cloud Build service account
    /// ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.
    /// Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>
    /// The repo and ref of the repository from which to build.
    /// This field is used only for those triggers that do not respond to SCM events.
    /// Triggers that respond to such events build source at whatever commit caused the event.
    /// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceToBuild")]
    public V1beta2TriggerStatusAtProviderSourceToBuild? SourceToBuild { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a BuildTrigger</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The unique identifier for the trigger.</summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>
    /// Template describing the types of source changes to trigger a build.
    /// Branch and tag names in trigger templates are interpreted as regular
    /// expressions. Any branch or tag change that matches that regular
    /// expression will trigger a build.
    /// One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerTemplate")]
    public V1beta2TriggerStatusAtProviderTriggerTemplate? TriggerTemplate { get; set; }

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates
    /// a build whenever a webhook is sent to a trigger&apos;s webhook URL.
    /// One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("webhookConfig")]
    public V1beta2TriggerStatusAtProviderWebhookConfig? WebhookConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatusConditions
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

/// <summary>TriggerStatus defines the observed state of Trigger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TriggerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2TriggerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2TriggerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Trigger is the Schema for the Triggers API. Configuration for an automated build in response to source repository changes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Trigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2TriggerSpec>, IStatus<V1beta2TriggerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Trigger";
    public const string KubeGroup = "cloudbuild.gcp.upbound.io";
    public const string KubePluralName = "triggers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Trigger";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerSpec defines the desired state of Trigger</summary>
    [JsonPropertyName("spec")]
    public required V1beta2TriggerSpec Spec { get; set; }

    /// <summary>TriggerStatus defines the observed state of Trigger.</summary>
    [JsonPropertyName("status")]
    public V1beta2TriggerStatus? Status { get; set; }
}
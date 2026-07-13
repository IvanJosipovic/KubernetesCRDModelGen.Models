#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codebuild.aws.upbound.io;
/// <summary>Project is the Schema for the Projects API. Provides a CodeBuild Project resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProjectList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Project>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProjectList";
    public const string KubeGroup = "codebuild.aws.upbound.io";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codebuild.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Project objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Project> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecDeletionPolicyEnum>))]
public enum V1beta1ProjectSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderArtifacts
{
    /// <summary>
    /// Artifact identifier. Must be the same specified inside the AWS CodeBuild build
    /// specification.
    /// </summary>
    [JsonPropertyName("artifactIdentifier")]
    public string? ArtifactIdentifier { get; set; }

    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. your CodeBuild service role must have the s3:PutBucketAcl permission. This permission
    /// allows CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>
    /// Information about the build output artifact location. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored. If type is set to S3, this is the name of the output bucket.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the project. If type is set to S3, this is the name of the output artifact object</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace to use in storing build artifacts. If type is set to S3, then valid values
    /// are BUILD_ID, NONE.
    /// </summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Whether a name specified in the build specification overrides the artifact name.</summary>
    [JsonPropertyName("overrideArtifactName")]
    public bool? OverrideArtifactName { get; set; }

    /// <summary>
    /// Type of build output artifact to create. If type is set to S3, valid values are NONE,
    /// ZIP
    /// </summary>
    [JsonPropertyName("packaging")]
    public string? Packaging { get; set; }

    /// <summary>If type is set to S3, this is the path to the output artifact.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Build output artifact&apos;s type. Valid values: CODEPIPELINE, NO_ARTIFACTS, S3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block specifying the restrictions for the batch build. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderBuildBatchConfigRestrictions
{
    /// <summary>
    /// An array of strings that specify the compute types that are allowed for the batch
    /// build.
    /// See Build environment compute types
    /// in the AWS CodeBuild User Guide for these values.
    /// </summary>
    [JsonPropertyName("computeTypesAllowed")]
    public IList<string>? ComputeTypesAllowed { get; set; }

    /// <summary>Specifies the maximum number of builds allowed.</summary>
    [JsonPropertyName("maximumBuildsAllowed")]
    public double? MaximumBuildsAllowed { get; set; }
}

/// <summary>Defines the batch build options for the project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderBuildBatchConfig
{
    /// <summary>
    /// Specifies if the build artifacts for the batch build should be combined into a single
    /// artifact location.
    /// </summary>
    [JsonPropertyName("combineArtifacts")]
    public bool? CombineArtifacts { get; set; }

    /// <summary>Configuration block specifying the restrictions for the batch build. Detailed below.</summary>
    [JsonPropertyName("restrictions")]
    public V1beta1ProjectSpecForProviderBuildBatchConfigRestrictions? Restrictions { get; set; }

    /// <summary>Specifies the service role ARN for the batch build project.</summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>
    /// Specifies the maximum amount of time, in minutes, that the batch build must be
    /// completed in.
    /// </summary>
    [JsonPropertyName("timeoutInMins")]
    public double? TimeoutInMins { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderCacheLocationRefPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderCacheLocationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderCacheLocationRefPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderCacheLocationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderCacheLocationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderCacheLocationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderCacheLocationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderCacheLocationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecForProviderCacheLocationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderCacheLocationSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderCacheLocationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderCacheLocationSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderCacheLocationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderCacheLocationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderCacheLocationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderCacheLocationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderCacheLocationSelector
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
    public V1beta1ProjectSpecForProviderCacheLocationSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderCache
{
    /// <summary>Namespace that determines the scope in which a cache is shared across multiple projects.</summary>
    [JsonPropertyName("cacheNamespace")]
    public string? CacheNamespace { get; set; }

    /// <summary>
    /// Location where the AWS CodeBuild project stores cached resources. For
    /// type S3, the value must be a valid S3 bucket name/prefix.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationRef")]
    public V1beta1ProjectSpecForProviderCacheLocationRef? LocationRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationSelector")]
    public V1beta1ProjectSpecForProviderCacheLocationSelector? LocationSelector { get; set; }

    /// <summary>
    /// Specifies settings that AWS CodeBuild uses to store and reuse build
    /// dependencies. Valid values:  LOCAL_SOURCE_CACHE, LOCAL_DOCKER_LAYER_CACHE, LOCAL_CUSTOM_CACHE.
    /// </summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>
    /// Type of storage that will be used for the AWS CodeBuild project cache. Valid values: NO_CACHE,
    /// LOCAL, S3. Defaults to NO_CACHE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderEnvironmentDockerServer
{
    /// <summary>
    /// Information about the compute resources the build project will use. Valid values:
    /// BUILD_GENERAL1_SMALL, BUILD_GENERAL1_MEDIUM, BUILD_GENERAL1_LARGE, BUILD_GENERAL1_XLARGE, BUILD_GENERAL1_2XLARGE, BUILD_LAMBDA_1GB,
    /// BUILD_LAMBDA_2GB, BUILD_LAMBDA_4GB, BUILD_LAMBDA_8GB, BUILD_LAMBDA_10GB. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>Security group IDs to assign to running builds.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderEnvironmentEnvironmentVariable
{
    /// <summary>
    /// Name of the project. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored
    /// if specified. If type is set to S3, this is the name of the output artifact object.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Environment variable&apos;s value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderEnvironmentFleet
{
    /// <summary>Compute fleet ARN for the build project.</summary>
    [JsonPropertyName("fleetArn")]
    public string? FleetArn { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderEnvironmentRegistryCredential
{
    /// <summary>ARN or name of credentials created using AWS Secrets Manager.</summary>
    [JsonPropertyName("credential")]
    public string? Credential { get; set; }

    /// <summary>
    /// Service that created the credentials to access a private Docker registry. Valid
    /// value: SECRETS_MANAGER (AWS Secrets Manager).
    /// </summary>
    [JsonPropertyName("credentialProvider")]
    public string? CredentialProvider { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderEnvironment
{
    /// <summary>ARN of the S3 bucket, path prefix and object key that contains the PEM-encoded certificate.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// Information about the compute resources the build project will use. Valid values:
    /// BUILD_GENERAL1_SMALL, BUILD_GENERAL1_MEDIUM, BUILD_GENERAL1_LARGE, BUILD_GENERAL1_XLARGE, BUILD_GENERAL1_2XLARGE, BUILD_LAMBDA_1GB,
    /// BUILD_LAMBDA_2GB, BUILD_LAMBDA_4GB, BUILD_LAMBDA_8GB, BUILD_LAMBDA_10GB. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("dockerServer")]
    public V1beta1ProjectSpecForProviderEnvironmentDockerServer? DockerServer { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("environmentVariable")]
    public IList<V1beta1ProjectSpecForProviderEnvironmentEnvironmentVariable>? EnvironmentVariable { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ProjectSpecForProviderEnvironmentFleet? Fleet { get; set; }

    /// <summary>
    /// Docker image to use for this build project. Valid values
    /// include Docker images provided by CodeBuild (
    /// e.g aws/codebuild/amazonlinux2-x86_64-standard:4.0), Docker Hub images (e.g.g.,
    /// 137112412989.dkr.ecr.us-west-2.amazonaws.com/amazonlinux:latest).
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Type of credentials AWS CodeBuild uses to pull images in your build. Valid
    /// values: CODEBUILD, SERVICE_ROLE. When you use a cross-account or private registry image, you must use SERVICE_ROLE
    /// credentials. When you use an AWS CodeBuild curated image, you must use CodeBuild credentials. Defaults to CODEBUILD.
    /// </summary>
    [JsonPropertyName("imagePullCredentialsType")]
    public string? ImagePullCredentialsType { get; set; }

    /// <summary>
    /// Whether to enable running the Docker daemon inside a Docker container. Defaults to
    /// false.
    /// </summary>
    [JsonPropertyName("privilegedMode")]
    public bool? PrivilegedMode { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("registryCredential")]
    public V1beta1ProjectSpecForProviderEnvironmentRegistryCredential? RegistryCredential { get; set; }

    /// <summary>
    /// Type of build environment to use for related builds. Valid values: WINDOWS_CONTAINER (deprecated), LINUX_CONTAINER,
    /// LINUX_GPU_CONTAINER, ARM_CONTAINER, WINDOWS_SERVER_2019_CONTAINER, WINDOWS_SERVER_2022_CONTAINER,
    /// LINUX_LAMBDA_CONTAINER, ARM_LAMBDA_CONTAINER, LINUX_EC2, ARM_EC2, WINDOWS_EC2, MAC_ARM. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderFileSystemLocations
{
    /// <summary>
    /// The name used to access a file system created by Amazon EFS. CodeBuild creates an
    /// environment variable by appending the identifier in all capital letters to CODEBUILD_. For example, if you specify
    /// my-efs for identifier, a new environment variable is create named CODEBUILD_MY-EFS.
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// A string that specifies the location of the file system created by Amazon EFS. Its format is
    /// efs-dns-name:/directory-path.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The mount options for a file system created by AWS EFS.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>The location in the container where you mount the file system.</summary>
    [JsonPropertyName("mountPoint")]
    public string? MountPoint { get; set; }

    /// <summary>The type of the file system. The one supported type is EFS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderLogsConfigCloudwatchLogs
{
    /// <summary>Group name of the logs in CloudWatch Logs.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// Current status of logs in CloudWatch Logs for a build project. Valid values: ENABLED,
    /// DISABLED. Defaults to ENABLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Prefix of the log stream name of the logs in CloudWatch Logs.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderLogsConfigS3Logs
{
    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. The CodeBuild service role must have the s3:PutBucketAcl permission. This permission allows
    /// CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Current status of logs in CloudWatch Logs for a build project. Valid values: ENABLED,
    /// DISABLED. Defaults to ENABLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderLogsConfig
{
    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ProjectSpecForProviderLogsConfigCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("s3Logs")]
    public V1beta1ProjectSpecForProviderLogsConfigS3Logs? S3Logs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSecondaryArtifacts
{
    /// <summary>
    /// Artifact identifier. Must be the same specified inside the AWS CodeBuild build
    /// specification.
    /// </summary>
    [JsonPropertyName("artifactIdentifier")]
    public string? ArtifactIdentifier { get; set; }

    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. The CodeBuild service role must have the s3:PutBucketAcl permission. This permission allows
    /// CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>
    /// Information about the build output artifact location. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, this is the name of the output bucket.
    /// If path is not specified, location can specify the path of the output artifact in the output bucket.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Name of the project. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored
    /// if specified. If type is set to S3, this is the name of the output artifact object.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace to use in storing build artifacts. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, valid values are BUILD_ID or NONE.
    /// </summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Whether a name specified in the build specification overrides the artifact name.</summary>
    [JsonPropertyName("overrideArtifactName")]
    public bool? OverrideArtifactName { get; set; }

    /// <summary>
    /// Type of build output artifact to create. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, valid values are NONE or ZIP.
    /// </summary>
    [JsonPropertyName("packaging")]
    public string? Packaging { get; set; }

    /// <summary>
    /// Along with namespace_type and name, the pattern that AWS CodeBuild uses to name and store the
    /// output artifact. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored if specified. If type
    /// is set to S3, this is the path to the output artifact.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Build output artifact&apos;s type. Valid values CODEPIPELINE, NO_ARTIFACTS, and S3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSecondarySourceVersion
{
    /// <summary>An identifier for a source in the build project.</summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// The source version for the corresponding source identifier.
    /// See AWS docs
    /// for more details.
    /// </summary>
    [JsonPropertyName("sourceVersion")]
    public string? SourceVersion { get; set; }
}

/// <summary>
/// Information about the strategy CodeBuild should use when authenticating with the source code host.
/// Detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSecondarySourcesAuth
{
    /// <summary>
    /// The ARN of the resource to use for authentication. For type CODECONNECTIONS this should be
    /// an AWS CodeStar Connection. For type SECRETS_MANAGER this should be an AWS Secrets Manager secret.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configuration block that contains information that defines how the build project
/// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
/// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSecondarySourcesBuildStatusConfig
{
    /// <summary>
    /// Specifies the context of the build status CodeBuild sends to the source provider. The usage of
    /// this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Specifies the target url of the build status CodeBuild sends to the source provider. The
    /// usage of this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSecondarySourcesGitSubmodulesConfig
{
    /// <summary>Whether to fetch Git submodules for the AWS CodeBuild build project.</summary>
    [JsonPropertyName("fetchSubmodules")]
    public bool? FetchSubmodules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSecondarySources
{
    /// <summary>
    /// Information about the strategy CodeBuild should use when authenticating with the source code host.
    /// Detailed below.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1beta1ProjectSpecForProviderSecondarySourcesAuth? Auth { get; set; }

    /// <summary>
    /// Configuration block that contains information that defines how the build project
    /// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
    /// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
    /// </summary>
    [JsonPropertyName("buildStatusConfig")]
    public V1beta1ProjectSpecForProviderSecondarySourcesBuildStatusConfig? BuildStatusConfig { get; set; }

    /// <summary>
    /// The build spec declaration to use for this build project&apos;s related builds. This must be set
    /// when type is NO_SOURCE. It can either be a path to a file residing in the repository to be built or a local file
    /// path leveraging the file() built-in.
    /// </summary>
    [JsonPropertyName("buildspec")]
    public string? Buildspec { get; set; }

    /// <summary>
    /// Truncate git history to this many commits. Use 0 for a Full checkout which you need
    /// to run commands like git branch --show-current.
    /// See AWS CodePipeline User Guide: Tutorial: Use full clone with a GitHub pipeline source
    /// for details.
    /// </summary>
    [JsonPropertyName("gitCloneDepth")]
    public double? GitCloneDepth { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("gitSubmodulesConfig")]
    public V1beta1ProjectSpecForProviderSecondarySourcesGitSubmodulesConfig? GitSubmodulesConfig { get; set; }

    /// <summary>Ignore SSL warnings when connecting to source control.</summary>
    [JsonPropertyName("insecureSsl")]
    public bool? InsecureSsl { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Whether to report the status of a build&apos;s start and finish to your source provider.
    /// This option is valid only when your source provider is GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or
    /// Bitbucket.
    /// </summary>
    [JsonPropertyName("reportBuildStatus")]
    public bool? ReportBuildStatus { get; set; }

    /// <summary>
    /// An identifier for this project source. The identifier can only contain alphanumeric
    /// characters and underscores, and must be less than 128 characters in length.
    /// </summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// Type of repository that contains the source code to be built. Valid values: BITBUCKET,
    /// CODECOMMIT, CODEPIPELINE, GITHUB, GITHUB_ENTERPRISE, GITLAB, GITLAB_SELF_MANAGED, NO_SOURCE, S3.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderServiceRoleRefPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderServiceRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderServiceRoleRefPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderServiceRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderServiceRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderServiceRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderServiceRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderServiceRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecForProviderServiceRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderServiceRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderServiceRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderServiceRoleSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderServiceRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderServiceRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderServiceRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderServiceRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderServiceRoleSelector
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
    public V1beta1ProjectSpecForProviderServiceRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Information about the strategy CodeBuild should use when authenticating with the source code host.
/// Detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSourceAuth
{
    /// <summary>
    /// The ARN of the resource to use for authentication. For type CODECONNECTIONS this should be
    /// an AWS CodeStar Connection. For type SECRETS_MANAGER this should be an AWS Secrets Manager secret.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configuration block that contains information that defines how the build project
/// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
/// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSourceBuildStatusConfig
{
    /// <summary>
    /// Specifies the context of the build status CodeBuild sends to the source provider. The usage of
    /// this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Specifies the target url of the build status CodeBuild sends to the source provider. The
    /// usage of this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSourceGitSubmodulesConfig
{
    /// <summary>Whether to fetch Git submodules for the AWS CodeBuild build project.</summary>
    [JsonPropertyName("fetchSubmodules")]
    public bool? FetchSubmodules { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderSource
{
    /// <summary>
    /// Information about the strategy CodeBuild should use when authenticating with the source code host.
    /// Detailed below.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1beta1ProjectSpecForProviderSourceAuth? Auth { get; set; }

    /// <summary>
    /// Configuration block that contains information that defines how the build project
    /// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
    /// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
    /// </summary>
    [JsonPropertyName("buildStatusConfig")]
    public V1beta1ProjectSpecForProviderSourceBuildStatusConfig? BuildStatusConfig { get; set; }

    /// <summary>
    /// Build specification to use for this build project&apos;s related builds. This must be set when
    /// type is NO_SOURCE. Also, if a non-default buildspec file name or file path aside from the root is used, it must be
    /// specified.
    /// </summary>
    [JsonPropertyName("buildspec")]
    public string? Buildspec { get; set; }

    /// <summary>
    /// Truncate git history to this many commits. Use 0 for a Full checkout which you need
    /// to run commands like git branch --show-current.
    /// See AWS CodePipeline User Guide: Tutorial: Use full clone with a GitHub pipeline source
    /// for details.
    /// </summary>
    [JsonPropertyName("gitCloneDepth")]
    public double? GitCloneDepth { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("gitSubmodulesConfig")]
    public V1beta1ProjectSpecForProviderSourceGitSubmodulesConfig? GitSubmodulesConfig { get; set; }

    /// <summary>Ignore SSL warnings when connecting to source control.</summary>
    [JsonPropertyName("insecureSsl")]
    public bool? InsecureSsl { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Whether to report the status of a build&apos;s start and finish to your source provider.
    /// This option is valid only when your source provider is GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or
    /// Bitbucket.
    /// </summary>
    [JsonPropertyName("reportBuildStatus")]
    public bool? ReportBuildStatus { get; set; }

    /// <summary>
    /// Type of repository that contains the source code to be built. Valid values: BITBUCKET,
    /// CODECOMMIT, CODEPIPELINE, GITHUB, GITHUB_ENTERPRISE, GITLAB, GITLAB_SELF_MANAGED, NO_SOURCE, S3.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelector
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
    public V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecForProviderVpcConfigSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigSubnetsSelector
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
    public V1beta1ProjectSpecForProviderVpcConfigSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfigVpcIdSelector
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
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderVpcConfig
{
    /// <summary>Security group IDs to assign to running builds.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1ProjectSpecForProviderVpcConfigSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>Subnet IDs within which to run builds.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsRefs")]
    public IList<V1beta1ProjectSpecForProviderVpcConfigSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta1ProjectSpecForProviderVpcConfigSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>ID of the VPC within which to run builds.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1ProjectSpecForProviderVpcConfigVpcIdSelector? VpcIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProvider
{
    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("artifacts")]
    public V1beta1ProjectSpecForProviderArtifacts? Artifacts { get; set; }

    /// <summary>
    /// Specify a maximum number of additional automatic retries after a failed build.
    /// The default is 0.
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    [JsonPropertyName("autoRetryLimit")]
    public double? AutoRetryLimit { get; set; }

    /// <summary>
    /// Generates a publicly-accessible URL for the projects build badge. Available as
    /// badge_url attribute when enabled.
    /// </summary>
    [JsonPropertyName("badgeEnabled")]
    public bool? BadgeEnabled { get; set; }

    /// <summary>Defines the batch build options for the project.</summary>
    [JsonPropertyName("buildBatchConfig")]
    public V1beta1ProjectSpecForProviderBuildBatchConfig? BuildBatchConfig { get; set; }

    /// <summary>
    /// Number of minutes, from 5 to 2160 (36 hours), for AWS CodeBuild to wait until timing out
    /// any related build that does not get marked as completed. The default is 60 minutes. The build_timeout property is
    /// not available on the Lambda compute type.
    /// </summary>
    [JsonPropertyName("buildTimeout")]
    public double? BuildTimeout { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("cache")]
    public V1beta1ProjectSpecForProviderCache? Cache { get; set; }

    /// <summary>
    /// Specify a maximum number of concurrent builds for the project. The value
    /// specified must be greater than 0 and less than the account concurrent running builds limit.
    /// </summary>
    [JsonPropertyName("concurrentBuildLimit")]
    public double? ConcurrentBuildLimit { get; set; }

    /// <summary>Short description of the project.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting
    /// the build project&apos;s build output artifacts.
    /// </summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public V1beta1ProjectSpecForProviderEnvironment? Environment { get; set; }

    /// <summary>
    /// A set of file system locations to mount inside the build. File system locations
    /// are documented below.
    /// </summary>
    [JsonPropertyName("fileSystemLocations")]
    public IList<V1beta1ProjectSpecForProviderFileSystemLocations>? FileSystemLocations { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("logsConfig")]
    public V1beta1ProjectSpecForProviderLogsConfig? LogsConfig { get; set; }

    /// <summary>
    /// Specifies the visibility of the project&apos;s builds. Possible values are: PUBLIC_READ
    /// and PRIVATE. Default value is PRIVATE.
    /// </summary>
    [JsonPropertyName("projectVisibility")]
    public string? ProjectVisibility { get; set; }

    /// <summary>
    /// Number of minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it
    /// times out. The default is 8 hours. The queued_timeout property is not available on the Lambda compute type.
    /// </summary>
    [JsonPropertyName("queuedTimeout")]
    public double? QueuedTimeout { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// The ARN of the IAM role that enables CodeBuild to access the CloudWatch Logs and
    /// Amazon S3 artifacts for the project&apos;s builds in order to display them publicly. Only applicable if
    /// project_visibility is PUBLIC_READ.
    /// </summary>
    [JsonPropertyName("resourceAccessRole")]
    public string? ResourceAccessRole { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondaryArtifacts")]
    public IList<V1beta1ProjectSpecForProviderSecondaryArtifacts>? SecondaryArtifacts { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondarySourceVersion")]
    public IList<V1beta1ProjectSpecForProviderSecondarySourceVersion>? SecondarySourceVersion { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondarySources")]
    public IList<V1beta1ProjectSpecForProviderSecondarySources>? SecondarySources { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that
    /// enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
    /// </summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleRef")]
    public V1beta1ProjectSpecForProviderServiceRoleRef? ServiceRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleSelector")]
    public V1beta1ProjectSpecForProviderServiceRoleSelector? ServiceRoleSelector { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("source")]
    public V1beta1ProjectSpecForProviderSource? Source { get; set; }

    /// <summary>
    /// Version of the build input to be built for this project. If not specified, the latest
    /// version is used.
    /// </summary>
    [JsonPropertyName("sourceVersion")]
    public string? SourceVersion { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ProjectSpecForProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderArtifacts
{
    /// <summary>
    /// Artifact identifier. Must be the same specified inside the AWS CodeBuild build
    /// specification.
    /// </summary>
    [JsonPropertyName("artifactIdentifier")]
    public string? ArtifactIdentifier { get; set; }

    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. your CodeBuild service role must have the s3:PutBucketAcl permission. This permission
    /// allows CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>
    /// Information about the build output artifact location. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored. If type is set to S3, this is the name of the output bucket.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the project. If type is set to S3, this is the name of the output artifact object</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace to use in storing build artifacts. If type is set to S3, then valid values
    /// are BUILD_ID, NONE.
    /// </summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Whether a name specified in the build specification overrides the artifact name.</summary>
    [JsonPropertyName("overrideArtifactName")]
    public bool? OverrideArtifactName { get; set; }

    /// <summary>
    /// Type of build output artifact to create. If type is set to S3, valid values are NONE,
    /// ZIP
    /// </summary>
    [JsonPropertyName("packaging")]
    public string? Packaging { get; set; }

    /// <summary>If type is set to S3, this is the path to the output artifact.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Build output artifact&apos;s type. Valid values: CODEPIPELINE, NO_ARTIFACTS, S3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block specifying the restrictions for the batch build. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderBuildBatchConfigRestrictions
{
    /// <summary>
    /// An array of strings that specify the compute types that are allowed for the batch
    /// build.
    /// See Build environment compute types
    /// in the AWS CodeBuild User Guide for these values.
    /// </summary>
    [JsonPropertyName("computeTypesAllowed")]
    public IList<string>? ComputeTypesAllowed { get; set; }

    /// <summary>Specifies the maximum number of builds allowed.</summary>
    [JsonPropertyName("maximumBuildsAllowed")]
    public double? MaximumBuildsAllowed { get; set; }
}

/// <summary>Defines the batch build options for the project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderBuildBatchConfig
{
    /// <summary>
    /// Specifies if the build artifacts for the batch build should be combined into a single
    /// artifact location.
    /// </summary>
    [JsonPropertyName("combineArtifacts")]
    public bool? CombineArtifacts { get; set; }

    /// <summary>Configuration block specifying the restrictions for the batch build. Detailed below.</summary>
    [JsonPropertyName("restrictions")]
    public V1beta1ProjectSpecInitProviderBuildBatchConfigRestrictions? Restrictions { get; set; }

    /// <summary>Specifies the service role ARN for the batch build project.</summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>
    /// Specifies the maximum amount of time, in minutes, that the batch build must be
    /// completed in.
    /// </summary>
    [JsonPropertyName("timeoutInMins")]
    public double? TimeoutInMins { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderCacheLocationRefPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderCacheLocationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderCacheLocationRefPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderCacheLocationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderCacheLocationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderCacheLocationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderCacheLocationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderCacheLocationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecInitProviderCacheLocationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderCacheLocationSelector
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
    public V1beta1ProjectSpecInitProviderCacheLocationSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderCache
{
    /// <summary>Namespace that determines the scope in which a cache is shared across multiple projects.</summary>
    [JsonPropertyName("cacheNamespace")]
    public string? CacheNamespace { get; set; }

    /// <summary>
    /// Location where the AWS CodeBuild project stores cached resources. For
    /// type S3, the value must be a valid S3 bucket name/prefix.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationRef")]
    public V1beta1ProjectSpecInitProviderCacheLocationRef? LocationRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationSelector")]
    public V1beta1ProjectSpecInitProviderCacheLocationSelector? LocationSelector { get; set; }

    /// <summary>
    /// Specifies settings that AWS CodeBuild uses to store and reuse build
    /// dependencies. Valid values:  LOCAL_SOURCE_CACHE, LOCAL_DOCKER_LAYER_CACHE, LOCAL_CUSTOM_CACHE.
    /// </summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>
    /// Type of storage that will be used for the AWS CodeBuild project cache. Valid values: NO_CACHE,
    /// LOCAL, S3. Defaults to NO_CACHE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderEnvironmentDockerServer
{
    /// <summary>
    /// Information about the compute resources the build project will use. Valid values:
    /// BUILD_GENERAL1_SMALL, BUILD_GENERAL1_MEDIUM, BUILD_GENERAL1_LARGE, BUILD_GENERAL1_XLARGE, BUILD_GENERAL1_2XLARGE, BUILD_LAMBDA_1GB,
    /// BUILD_LAMBDA_2GB, BUILD_LAMBDA_4GB, BUILD_LAMBDA_8GB, BUILD_LAMBDA_10GB. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>Security group IDs to assign to running builds.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderEnvironmentEnvironmentVariable
{
    /// <summary>
    /// Name of the project. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored
    /// if specified. If type is set to S3, this is the name of the output artifact object.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Environment variable&apos;s value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderEnvironmentFleet
{
    /// <summary>Compute fleet ARN for the build project.</summary>
    [JsonPropertyName("fleetArn")]
    public string? FleetArn { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderEnvironmentRegistryCredential
{
    /// <summary>ARN or name of credentials created using AWS Secrets Manager.</summary>
    [JsonPropertyName("credential")]
    public string? Credential { get; set; }

    /// <summary>
    /// Service that created the credentials to access a private Docker registry. Valid
    /// value: SECRETS_MANAGER (AWS Secrets Manager).
    /// </summary>
    [JsonPropertyName("credentialProvider")]
    public string? CredentialProvider { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderEnvironment
{
    /// <summary>ARN of the S3 bucket, path prefix and object key that contains the PEM-encoded certificate.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// Information about the compute resources the build project will use. Valid values:
    /// BUILD_GENERAL1_SMALL, BUILD_GENERAL1_MEDIUM, BUILD_GENERAL1_LARGE, BUILD_GENERAL1_XLARGE, BUILD_GENERAL1_2XLARGE, BUILD_LAMBDA_1GB,
    /// BUILD_LAMBDA_2GB, BUILD_LAMBDA_4GB, BUILD_LAMBDA_8GB, BUILD_LAMBDA_10GB. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("dockerServer")]
    public V1beta1ProjectSpecInitProviderEnvironmentDockerServer? DockerServer { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("environmentVariable")]
    public IList<V1beta1ProjectSpecInitProviderEnvironmentEnvironmentVariable>? EnvironmentVariable { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ProjectSpecInitProviderEnvironmentFleet? Fleet { get; set; }

    /// <summary>
    /// Docker image to use for this build project. Valid values
    /// include Docker images provided by CodeBuild (
    /// e.g aws/codebuild/amazonlinux2-x86_64-standard:4.0), Docker Hub images (e.g.g.,
    /// 137112412989.dkr.ecr.us-west-2.amazonaws.com/amazonlinux:latest).
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Type of credentials AWS CodeBuild uses to pull images in your build. Valid
    /// values: CODEBUILD, SERVICE_ROLE. When you use a cross-account or private registry image, you must use SERVICE_ROLE
    /// credentials. When you use an AWS CodeBuild curated image, you must use CodeBuild credentials. Defaults to CODEBUILD.
    /// </summary>
    [JsonPropertyName("imagePullCredentialsType")]
    public string? ImagePullCredentialsType { get; set; }

    /// <summary>
    /// Whether to enable running the Docker daemon inside a Docker container. Defaults to
    /// false.
    /// </summary>
    [JsonPropertyName("privilegedMode")]
    public bool? PrivilegedMode { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("registryCredential")]
    public V1beta1ProjectSpecInitProviderEnvironmentRegistryCredential? RegistryCredential { get; set; }

    /// <summary>
    /// Type of build environment to use for related builds. Valid values: WINDOWS_CONTAINER (deprecated), LINUX_CONTAINER,
    /// LINUX_GPU_CONTAINER, ARM_CONTAINER, WINDOWS_SERVER_2019_CONTAINER, WINDOWS_SERVER_2022_CONTAINER,
    /// LINUX_LAMBDA_CONTAINER, ARM_LAMBDA_CONTAINER, LINUX_EC2, ARM_EC2, WINDOWS_EC2, MAC_ARM. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderFileSystemLocations
{
    /// <summary>
    /// The name used to access a file system created by Amazon EFS. CodeBuild creates an
    /// environment variable by appending the identifier in all capital letters to CODEBUILD_. For example, if you specify
    /// my-efs for identifier, a new environment variable is create named CODEBUILD_MY-EFS.
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// A string that specifies the location of the file system created by Amazon EFS. Its format is
    /// efs-dns-name:/directory-path.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The mount options for a file system created by AWS EFS.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>The location in the container where you mount the file system.</summary>
    [JsonPropertyName("mountPoint")]
    public string? MountPoint { get; set; }

    /// <summary>The type of the file system. The one supported type is EFS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderLogsConfigCloudwatchLogs
{
    /// <summary>Group name of the logs in CloudWatch Logs.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// Current status of logs in CloudWatch Logs for a build project. Valid values: ENABLED,
    /// DISABLED. Defaults to ENABLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Prefix of the log stream name of the logs in CloudWatch Logs.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderLogsConfigS3Logs
{
    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. The CodeBuild service role must have the s3:PutBucketAcl permission. This permission allows
    /// CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Current status of logs in CloudWatch Logs for a build project. Valid values: ENABLED,
    /// DISABLED. Defaults to ENABLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderLogsConfig
{
    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ProjectSpecInitProviderLogsConfigCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("s3Logs")]
    public V1beta1ProjectSpecInitProviderLogsConfigS3Logs? S3Logs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSecondaryArtifacts
{
    /// <summary>
    /// Artifact identifier. Must be the same specified inside the AWS CodeBuild build
    /// specification.
    /// </summary>
    [JsonPropertyName("artifactIdentifier")]
    public string? ArtifactIdentifier { get; set; }

    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. The CodeBuild service role must have the s3:PutBucketAcl permission. This permission allows
    /// CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>
    /// Information about the build output artifact location. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, this is the name of the output bucket.
    /// If path is not specified, location can specify the path of the output artifact in the output bucket.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Name of the project. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored
    /// if specified. If type is set to S3, this is the name of the output artifact object.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace to use in storing build artifacts. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, valid values are BUILD_ID or NONE.
    /// </summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Whether a name specified in the build specification overrides the artifact name.</summary>
    [JsonPropertyName("overrideArtifactName")]
    public bool? OverrideArtifactName { get; set; }

    /// <summary>
    /// Type of build output artifact to create. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, valid values are NONE or ZIP.
    /// </summary>
    [JsonPropertyName("packaging")]
    public string? Packaging { get; set; }

    /// <summary>
    /// Along with namespace_type and name, the pattern that AWS CodeBuild uses to name and store the
    /// output artifact. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored if specified. If type
    /// is set to S3, this is the path to the output artifact.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Build output artifact&apos;s type. Valid values CODEPIPELINE, NO_ARTIFACTS, and S3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSecondarySourceVersion
{
    /// <summary>An identifier for a source in the build project.</summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// The source version for the corresponding source identifier.
    /// See AWS docs
    /// for more details.
    /// </summary>
    [JsonPropertyName("sourceVersion")]
    public string? SourceVersion { get; set; }
}

/// <summary>
/// Information about the strategy CodeBuild should use when authenticating with the source code host.
/// Detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSecondarySourcesAuth
{
    /// <summary>
    /// The ARN of the resource to use for authentication. For type CODECONNECTIONS this should be
    /// an AWS CodeStar Connection. For type SECRETS_MANAGER this should be an AWS Secrets Manager secret.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configuration block that contains information that defines how the build project
/// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
/// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSecondarySourcesBuildStatusConfig
{
    /// <summary>
    /// Specifies the context of the build status CodeBuild sends to the source provider. The usage of
    /// this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Specifies the target url of the build status CodeBuild sends to the source provider. The
    /// usage of this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSecondarySourcesGitSubmodulesConfig
{
    /// <summary>Whether to fetch Git submodules for the AWS CodeBuild build project.</summary>
    [JsonPropertyName("fetchSubmodules")]
    public bool? FetchSubmodules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSecondarySources
{
    /// <summary>
    /// Information about the strategy CodeBuild should use when authenticating with the source code host.
    /// Detailed below.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1beta1ProjectSpecInitProviderSecondarySourcesAuth? Auth { get; set; }

    /// <summary>
    /// Configuration block that contains information that defines how the build project
    /// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
    /// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
    /// </summary>
    [JsonPropertyName("buildStatusConfig")]
    public V1beta1ProjectSpecInitProviderSecondarySourcesBuildStatusConfig? BuildStatusConfig { get; set; }

    /// <summary>
    /// The build spec declaration to use for this build project&apos;s related builds. This must be set
    /// when type is NO_SOURCE. It can either be a path to a file residing in the repository to be built or a local file
    /// path leveraging the file() built-in.
    /// </summary>
    [JsonPropertyName("buildspec")]
    public string? Buildspec { get; set; }

    /// <summary>
    /// Truncate git history to this many commits. Use 0 for a Full checkout which you need
    /// to run commands like git branch --show-current.
    /// See AWS CodePipeline User Guide: Tutorial: Use full clone with a GitHub pipeline source
    /// for details.
    /// </summary>
    [JsonPropertyName("gitCloneDepth")]
    public double? GitCloneDepth { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("gitSubmodulesConfig")]
    public V1beta1ProjectSpecInitProviderSecondarySourcesGitSubmodulesConfig? GitSubmodulesConfig { get; set; }

    /// <summary>Ignore SSL warnings when connecting to source control.</summary>
    [JsonPropertyName("insecureSsl")]
    public bool? InsecureSsl { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Whether to report the status of a build&apos;s start and finish to your source provider.
    /// This option is valid only when your source provider is GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or
    /// Bitbucket.
    /// </summary>
    [JsonPropertyName("reportBuildStatus")]
    public bool? ReportBuildStatus { get; set; }

    /// <summary>
    /// An identifier for this project source. The identifier can only contain alphanumeric
    /// characters and underscores, and must be less than 128 characters in length.
    /// </summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// Type of repository that contains the source code to be built. Valid values: BITBUCKET,
    /// CODECOMMIT, CODEPIPELINE, GITHUB, GITHUB_ENTERPRISE, GITLAB, GITLAB_SELF_MANAGED, NO_SOURCE, S3.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderServiceRoleRefPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderServiceRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderServiceRoleRefPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderServiceRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderServiceRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderServiceRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderServiceRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderServiceRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecInitProviderServiceRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderServiceRoleSelector
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
    public V1beta1ProjectSpecInitProviderServiceRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Information about the strategy CodeBuild should use when authenticating with the source code host.
/// Detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSourceAuth
{
    /// <summary>
    /// The ARN of the resource to use for authentication. For type CODECONNECTIONS this should be
    /// an AWS CodeStar Connection. For type SECRETS_MANAGER this should be an AWS Secrets Manager secret.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configuration block that contains information that defines how the build project
/// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
/// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSourceBuildStatusConfig
{
    /// <summary>
    /// Specifies the context of the build status CodeBuild sends to the source provider. The usage of
    /// this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Specifies the target url of the build status CodeBuild sends to the source provider. The
    /// usage of this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSourceGitSubmodulesConfig
{
    /// <summary>Whether to fetch Git submodules for the AWS CodeBuild build project.</summary>
    [JsonPropertyName("fetchSubmodules")]
    public bool? FetchSubmodules { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderSource
{
    /// <summary>
    /// Information about the strategy CodeBuild should use when authenticating with the source code host.
    /// Detailed below.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1beta1ProjectSpecInitProviderSourceAuth? Auth { get; set; }

    /// <summary>
    /// Configuration block that contains information that defines how the build project
    /// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
    /// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
    /// </summary>
    [JsonPropertyName("buildStatusConfig")]
    public V1beta1ProjectSpecInitProviderSourceBuildStatusConfig? BuildStatusConfig { get; set; }

    /// <summary>
    /// Build specification to use for this build project&apos;s related builds. This must be set when
    /// type is NO_SOURCE. Also, if a non-default buildspec file name or file path aside from the root is used, it must be
    /// specified.
    /// </summary>
    [JsonPropertyName("buildspec")]
    public string? Buildspec { get; set; }

    /// <summary>
    /// Truncate git history to this many commits. Use 0 for a Full checkout which you need
    /// to run commands like git branch --show-current.
    /// See AWS CodePipeline User Guide: Tutorial: Use full clone with a GitHub pipeline source
    /// for details.
    /// </summary>
    [JsonPropertyName("gitCloneDepth")]
    public double? GitCloneDepth { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("gitSubmodulesConfig")]
    public V1beta1ProjectSpecInitProviderSourceGitSubmodulesConfig? GitSubmodulesConfig { get; set; }

    /// <summary>Ignore SSL warnings when connecting to source control.</summary>
    [JsonPropertyName("insecureSsl")]
    public bool? InsecureSsl { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Whether to report the status of a build&apos;s start and finish to your source provider.
    /// This option is valid only when your source provider is GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or
    /// Bitbucket.
    /// </summary>
    [JsonPropertyName("reportBuildStatus")]
    public bool? ReportBuildStatus { get; set; }

    /// <summary>
    /// Type of repository that contains the source code to be built. Valid values: BITBUCKET,
    /// CODECOMMIT, CODEPIPELINE, GITHUB, GITHUB_ENTERPRISE, GITLAB, GITLAB_SELF_MANAGED, NO_SOURCE, S3.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelector
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
    public V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelector
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
    public V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicyResolveEnum>))]
public enum V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelector
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
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderVpcConfig
{
    /// <summary>Security group IDs to assign to running builds.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1ProjectSpecInitProviderVpcConfigSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>Subnet IDs within which to run builds.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsRefs")]
    public IList<V1beta1ProjectSpecInitProviderVpcConfigSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta1ProjectSpecInitProviderVpcConfigSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>ID of the VPC within which to run builds.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1ProjectSpecInitProviderVpcConfigVpcIdSelector? VpcIdSelector { get; set; }
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
public partial class V1beta1ProjectSpecInitProvider
{
    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("artifacts")]
    public V1beta1ProjectSpecInitProviderArtifacts? Artifacts { get; set; }

    /// <summary>
    /// Specify a maximum number of additional automatic retries after a failed build.
    /// The default is 0.
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    [JsonPropertyName("autoRetryLimit")]
    public double? AutoRetryLimit { get; set; }

    /// <summary>
    /// Generates a publicly-accessible URL for the projects build badge. Available as
    /// badge_url attribute when enabled.
    /// </summary>
    [JsonPropertyName("badgeEnabled")]
    public bool? BadgeEnabled { get; set; }

    /// <summary>Defines the batch build options for the project.</summary>
    [JsonPropertyName("buildBatchConfig")]
    public V1beta1ProjectSpecInitProviderBuildBatchConfig? BuildBatchConfig { get; set; }

    /// <summary>
    /// Number of minutes, from 5 to 2160 (36 hours), for AWS CodeBuild to wait until timing out
    /// any related build that does not get marked as completed. The default is 60 minutes. The build_timeout property is
    /// not available on the Lambda compute type.
    /// </summary>
    [JsonPropertyName("buildTimeout")]
    public double? BuildTimeout { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("cache")]
    public V1beta1ProjectSpecInitProviderCache? Cache { get; set; }

    /// <summary>
    /// Specify a maximum number of concurrent builds for the project. The value
    /// specified must be greater than 0 and less than the account concurrent running builds limit.
    /// </summary>
    [JsonPropertyName("concurrentBuildLimit")]
    public double? ConcurrentBuildLimit { get; set; }

    /// <summary>Short description of the project.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting
    /// the build project&apos;s build output artifacts.
    /// </summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public V1beta1ProjectSpecInitProviderEnvironment? Environment { get; set; }

    /// <summary>
    /// A set of file system locations to mount inside the build. File system locations
    /// are documented below.
    /// </summary>
    [JsonPropertyName("fileSystemLocations")]
    public IList<V1beta1ProjectSpecInitProviderFileSystemLocations>? FileSystemLocations { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("logsConfig")]
    public V1beta1ProjectSpecInitProviderLogsConfig? LogsConfig { get; set; }

    /// <summary>
    /// Specifies the visibility of the project&apos;s builds. Possible values are: PUBLIC_READ
    /// and PRIVATE. Default value is PRIVATE.
    /// </summary>
    [JsonPropertyName("projectVisibility")]
    public string? ProjectVisibility { get; set; }

    /// <summary>
    /// Number of minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it
    /// times out. The default is 8 hours. The queued_timeout property is not available on the Lambda compute type.
    /// </summary>
    [JsonPropertyName("queuedTimeout")]
    public double? QueuedTimeout { get; set; }

    /// <summary>
    /// The ARN of the IAM role that enables CodeBuild to access the CloudWatch Logs and
    /// Amazon S3 artifacts for the project&apos;s builds in order to display them publicly. Only applicable if
    /// project_visibility is PUBLIC_READ.
    /// </summary>
    [JsonPropertyName("resourceAccessRole")]
    public string? ResourceAccessRole { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondaryArtifacts")]
    public IList<V1beta1ProjectSpecInitProviderSecondaryArtifacts>? SecondaryArtifacts { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondarySourceVersion")]
    public IList<V1beta1ProjectSpecInitProviderSecondarySourceVersion>? SecondarySourceVersion { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondarySources")]
    public IList<V1beta1ProjectSpecInitProviderSecondarySources>? SecondarySources { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that
    /// enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
    /// </summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleRef")]
    public V1beta1ProjectSpecInitProviderServiceRoleRef? ServiceRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleSelector")]
    public V1beta1ProjectSpecInitProviderServiceRoleSelector? ServiceRoleSelector { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("source")]
    public V1beta1ProjectSpecInitProviderSource? Source { get; set; }

    /// <summary>
    /// Version of the build input to be built for this project. If not specified, the latest
    /// version is used.
    /// </summary>
    [JsonPropertyName("sourceVersion")]
    public string? SourceVersion { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ProjectSpecInitProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecManagementPoliciesEnum>))]
public enum V1beta1ProjectSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1ProjectSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProjectSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1ProjectSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ProjectSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ProjectSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ProjectSpec defines the desired state of Project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpec
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
    public V1beta1ProjectSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ProjectSpecForProvider ForProvider { get; set; }

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
    public V1beta1ProjectSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ProjectSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ProjectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ProjectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderArtifacts
{
    /// <summary>
    /// Artifact identifier. Must be the same specified inside the AWS CodeBuild build
    /// specification.
    /// </summary>
    [JsonPropertyName("artifactIdentifier")]
    public string? ArtifactIdentifier { get; set; }

    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. your CodeBuild service role must have the s3:PutBucketAcl permission. This permission
    /// allows CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>
    /// Information about the build output artifact location. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored. If type is set to S3, this is the name of the output bucket.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the project. If type is set to S3, this is the name of the output artifact object</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace to use in storing build artifacts. If type is set to S3, then valid values
    /// are BUILD_ID, NONE.
    /// </summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Whether a name specified in the build specification overrides the artifact name.</summary>
    [JsonPropertyName("overrideArtifactName")]
    public bool? OverrideArtifactName { get; set; }

    /// <summary>
    /// Type of build output artifact to create. If type is set to S3, valid values are NONE,
    /// ZIP
    /// </summary>
    [JsonPropertyName("packaging")]
    public string? Packaging { get; set; }

    /// <summary>If type is set to S3, this is the path to the output artifact.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Build output artifact&apos;s type. Valid values: CODEPIPELINE, NO_ARTIFACTS, S3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block specifying the restrictions for the batch build. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderBuildBatchConfigRestrictions
{
    /// <summary>
    /// An array of strings that specify the compute types that are allowed for the batch
    /// build.
    /// See Build environment compute types
    /// in the AWS CodeBuild User Guide for these values.
    /// </summary>
    [JsonPropertyName("computeTypesAllowed")]
    public IList<string>? ComputeTypesAllowed { get; set; }

    /// <summary>Specifies the maximum number of builds allowed.</summary>
    [JsonPropertyName("maximumBuildsAllowed")]
    public double? MaximumBuildsAllowed { get; set; }
}

/// <summary>Defines the batch build options for the project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderBuildBatchConfig
{
    /// <summary>
    /// Specifies if the build artifacts for the batch build should be combined into a single
    /// artifact location.
    /// </summary>
    [JsonPropertyName("combineArtifacts")]
    public bool? CombineArtifacts { get; set; }

    /// <summary>Configuration block specifying the restrictions for the batch build. Detailed below.</summary>
    [JsonPropertyName("restrictions")]
    public V1beta1ProjectStatusAtProviderBuildBatchConfigRestrictions? Restrictions { get; set; }

    /// <summary>Specifies the service role ARN for the batch build project.</summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>
    /// Specifies the maximum amount of time, in minutes, that the batch build must be
    /// completed in.
    /// </summary>
    [JsonPropertyName("timeoutInMins")]
    public double? TimeoutInMins { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderCache
{
    /// <summary>Namespace that determines the scope in which a cache is shared across multiple projects.</summary>
    [JsonPropertyName("cacheNamespace")]
    public string? CacheNamespace { get; set; }

    /// <summary>
    /// Location where the AWS CodeBuild project stores cached resources. For
    /// type S3, the value must be a valid S3 bucket name/prefix.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Specifies settings that AWS CodeBuild uses to store and reuse build
    /// dependencies. Valid values:  LOCAL_SOURCE_CACHE, LOCAL_DOCKER_LAYER_CACHE, LOCAL_CUSTOM_CACHE.
    /// </summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>
    /// Type of storage that will be used for the AWS CodeBuild project cache. Valid values: NO_CACHE,
    /// LOCAL, S3. Defaults to NO_CACHE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderEnvironmentDockerServer
{
    /// <summary>
    /// Information about the compute resources the build project will use. Valid values:
    /// BUILD_GENERAL1_SMALL, BUILD_GENERAL1_MEDIUM, BUILD_GENERAL1_LARGE, BUILD_GENERAL1_XLARGE, BUILD_GENERAL1_2XLARGE, BUILD_LAMBDA_1GB,
    /// BUILD_LAMBDA_2GB, BUILD_LAMBDA_4GB, BUILD_LAMBDA_8GB, BUILD_LAMBDA_10GB. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>Security group IDs to assign to running builds.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderEnvironmentEnvironmentVariable
{
    /// <summary>
    /// Name of the project. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored
    /// if specified. If type is set to S3, this is the name of the output artifact object.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Environment variable&apos;s value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderEnvironmentFleet
{
    /// <summary>Compute fleet ARN for the build project.</summary>
    [JsonPropertyName("fleetArn")]
    public string? FleetArn { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderEnvironmentRegistryCredential
{
    /// <summary>ARN or name of credentials created using AWS Secrets Manager.</summary>
    [JsonPropertyName("credential")]
    public string? Credential { get; set; }

    /// <summary>
    /// Service that created the credentials to access a private Docker registry. Valid
    /// value: SECRETS_MANAGER (AWS Secrets Manager).
    /// </summary>
    [JsonPropertyName("credentialProvider")]
    public string? CredentialProvider { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderEnvironment
{
    /// <summary>ARN of the S3 bucket, path prefix and object key that contains the PEM-encoded certificate.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// Information about the compute resources the build project will use. Valid values:
    /// BUILD_GENERAL1_SMALL, BUILD_GENERAL1_MEDIUM, BUILD_GENERAL1_LARGE, BUILD_GENERAL1_XLARGE, BUILD_GENERAL1_2XLARGE, BUILD_LAMBDA_1GB,
    /// BUILD_LAMBDA_2GB, BUILD_LAMBDA_4GB, BUILD_LAMBDA_8GB, BUILD_LAMBDA_10GB. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("dockerServer")]
    public V1beta1ProjectStatusAtProviderEnvironmentDockerServer? DockerServer { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("environmentVariable")]
    public IList<V1beta1ProjectStatusAtProviderEnvironmentEnvironmentVariable>? EnvironmentVariable { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ProjectStatusAtProviderEnvironmentFleet? Fleet { get; set; }

    /// <summary>
    /// Docker image to use for this build project. Valid values
    /// include Docker images provided by CodeBuild (
    /// e.g aws/codebuild/amazonlinux2-x86_64-standard:4.0), Docker Hub images (e.g.g.,
    /// 137112412989.dkr.ecr.us-west-2.amazonaws.com/amazonlinux:latest).
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Type of credentials AWS CodeBuild uses to pull images in your build. Valid
    /// values: CODEBUILD, SERVICE_ROLE. When you use a cross-account or private registry image, you must use SERVICE_ROLE
    /// credentials. When you use an AWS CodeBuild curated image, you must use CodeBuild credentials. Defaults to CODEBUILD.
    /// </summary>
    [JsonPropertyName("imagePullCredentialsType")]
    public string? ImagePullCredentialsType { get; set; }

    /// <summary>
    /// Whether to enable running the Docker daemon inside a Docker container. Defaults to
    /// false.
    /// </summary>
    [JsonPropertyName("privilegedMode")]
    public bool? PrivilegedMode { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("registryCredential")]
    public V1beta1ProjectStatusAtProviderEnvironmentRegistryCredential? RegistryCredential { get; set; }

    /// <summary>
    /// Type of build environment to use for related builds. Valid values: WINDOWS_CONTAINER (deprecated), LINUX_CONTAINER,
    /// LINUX_GPU_CONTAINER, ARM_CONTAINER, WINDOWS_SERVER_2019_CONTAINER, WINDOWS_SERVER_2022_CONTAINER,
    /// LINUX_LAMBDA_CONTAINER, ARM_LAMBDA_CONTAINER, LINUX_EC2, ARM_EC2, WINDOWS_EC2, MAC_ARM. For additional information, see
    /// the CodeBuild User Guide.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderFileSystemLocations
{
    /// <summary>
    /// The name used to access a file system created by Amazon EFS. CodeBuild creates an
    /// environment variable by appending the identifier in all capital letters to CODEBUILD_. For example, if you specify
    /// my-efs for identifier, a new environment variable is create named CODEBUILD_MY-EFS.
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// A string that specifies the location of the file system created by Amazon EFS. Its format is
    /// efs-dns-name:/directory-path.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The mount options for a file system created by AWS EFS.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>The location in the container where you mount the file system.</summary>
    [JsonPropertyName("mountPoint")]
    public string? MountPoint { get; set; }

    /// <summary>The type of the file system. The one supported type is EFS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderLogsConfigCloudwatchLogs
{
    /// <summary>Group name of the logs in CloudWatch Logs.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// Current status of logs in CloudWatch Logs for a build project. Valid values: ENABLED,
    /// DISABLED. Defaults to ENABLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Prefix of the log stream name of the logs in CloudWatch Logs.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderLogsConfigS3Logs
{
    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. The CodeBuild service role must have the s3:PutBucketAcl permission. This permission allows
    /// CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Current status of logs in CloudWatch Logs for a build project. Valid values: ENABLED,
    /// DISABLED. Defaults to ENABLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderLogsConfig
{
    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ProjectStatusAtProviderLogsConfigCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("s3Logs")]
    public V1beta1ProjectStatusAtProviderLogsConfigS3Logs? S3Logs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSecondaryArtifacts
{
    /// <summary>
    /// Artifact identifier. Must be the same specified inside the AWS CodeBuild build
    /// specification.
    /// </summary>
    [JsonPropertyName("artifactIdentifier")]
    public string? ArtifactIdentifier { get; set; }

    /// <summary>
    /// Specifies the bucket owner&apos;s access for objects that another account uploads to
    /// their Amazon S3 bucket. By default, only the account that uploads the objects to the bucket has access to these
    /// objects. This property allows you to give the bucket owner access to these objects. Valid values are NONE,
    /// READ_ONLY, and FULL. The CodeBuild service role must have the s3:PutBucketAcl permission. This permission allows
    /// CodeBuild to modify the access control list for the bucket.
    /// </summary>
    [JsonPropertyName("bucketOwnerAccess")]
    public string? BucketOwnerAccess { get; set; }

    /// <summary>
    /// Whether to disable encrypting output artifacts. If type is set to NO_ARTIFACTS,
    /// this value is ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("encryptionDisabled")]
    public bool? EncryptionDisabled { get; set; }

    /// <summary>
    /// Information about the build output artifact location. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, this is the name of the output bucket.
    /// If path is not specified, location can specify the path of the output artifact in the output bucket.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Name of the project. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored
    /// if specified. If type is set to S3, this is the name of the output artifact object.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace to use in storing build artifacts. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, valid values are BUILD_ID or NONE.
    /// </summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Whether a name specified in the build specification overrides the artifact name.</summary>
    [JsonPropertyName("overrideArtifactName")]
    public bool? OverrideArtifactName { get; set; }

    /// <summary>
    /// Type of build output artifact to create. If type is set to CODEPIPELINE or
    /// NO_ARTIFACTS, this value is ignored if specified. If type is set to S3, valid values are NONE or ZIP.
    /// </summary>
    [JsonPropertyName("packaging")]
    public string? Packaging { get; set; }

    /// <summary>
    /// Along with namespace_type and name, the pattern that AWS CodeBuild uses to name and store the
    /// output artifact. If type is set to CODEPIPELINE or NO_ARTIFACTS, this value is ignored if specified. If type
    /// is set to S3, this is the path to the output artifact.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Build output artifact&apos;s type. Valid values CODEPIPELINE, NO_ARTIFACTS, and S3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSecondarySourceVersion
{
    /// <summary>An identifier for a source in the build project.</summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// The source version for the corresponding source identifier.
    /// See AWS docs
    /// for more details.
    /// </summary>
    [JsonPropertyName("sourceVersion")]
    public string? SourceVersion { get; set; }
}

/// <summary>
/// Information about the strategy CodeBuild should use when authenticating with the source code host.
/// Detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSecondarySourcesAuth
{
    /// <summary>
    /// The ARN of the resource to use for authentication. For type CODECONNECTIONS this should be
    /// an AWS CodeStar Connection. For type SECRETS_MANAGER this should be an AWS Secrets Manager secret.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configuration block that contains information that defines how the build project
/// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
/// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSecondarySourcesBuildStatusConfig
{
    /// <summary>
    /// Specifies the context of the build status CodeBuild sends to the source provider. The usage of
    /// this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Specifies the target url of the build status CodeBuild sends to the source provider. The
    /// usage of this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSecondarySourcesGitSubmodulesConfig
{
    /// <summary>Whether to fetch Git submodules for the AWS CodeBuild build project.</summary>
    [JsonPropertyName("fetchSubmodules")]
    public bool? FetchSubmodules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSecondarySources
{
    /// <summary>
    /// Information about the strategy CodeBuild should use when authenticating with the source code host.
    /// Detailed below.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1beta1ProjectStatusAtProviderSecondarySourcesAuth? Auth { get; set; }

    /// <summary>
    /// Configuration block that contains information that defines how the build project
    /// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
    /// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
    /// </summary>
    [JsonPropertyName("buildStatusConfig")]
    public V1beta1ProjectStatusAtProviderSecondarySourcesBuildStatusConfig? BuildStatusConfig { get; set; }

    /// <summary>
    /// The build spec declaration to use for this build project&apos;s related builds. This must be set
    /// when type is NO_SOURCE. It can either be a path to a file residing in the repository to be built or a local file
    /// path leveraging the file() built-in.
    /// </summary>
    [JsonPropertyName("buildspec")]
    public string? Buildspec { get; set; }

    /// <summary>
    /// Truncate git history to this many commits. Use 0 for a Full checkout which you need
    /// to run commands like git branch --show-current.
    /// See AWS CodePipeline User Guide: Tutorial: Use full clone with a GitHub pipeline source
    /// for details.
    /// </summary>
    [JsonPropertyName("gitCloneDepth")]
    public double? GitCloneDepth { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("gitSubmodulesConfig")]
    public V1beta1ProjectStatusAtProviderSecondarySourcesGitSubmodulesConfig? GitSubmodulesConfig { get; set; }

    /// <summary>Ignore SSL warnings when connecting to source control.</summary>
    [JsonPropertyName("insecureSsl")]
    public bool? InsecureSsl { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Whether to report the status of a build&apos;s start and finish to your source provider.
    /// This option is valid only when your source provider is GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or
    /// Bitbucket.
    /// </summary>
    [JsonPropertyName("reportBuildStatus")]
    public bool? ReportBuildStatus { get; set; }

    /// <summary>
    /// An identifier for this project source. The identifier can only contain alphanumeric
    /// characters and underscores, and must be less than 128 characters in length.
    /// </summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// Type of repository that contains the source code to be built. Valid values: BITBUCKET,
    /// CODECOMMIT, CODEPIPELINE, GITHUB, GITHUB_ENTERPRISE, GITLAB, GITLAB_SELF_MANAGED, NO_SOURCE, S3.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Information about the strategy CodeBuild should use when authenticating with the source code host.
/// Detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSourceAuth
{
    /// <summary>
    /// The ARN of the resource to use for authentication. For type CODECONNECTIONS this should be
    /// an AWS CodeStar Connection. For type SECRETS_MANAGER this should be an AWS Secrets Manager secret.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Type of environment variable. Valid values: PARAMETER_STORE, PLAINTEXT, SECRETS_MANAGER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configuration block that contains information that defines how the build project
/// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
/// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSourceBuildStatusConfig
{
    /// <summary>
    /// Specifies the context of the build status CodeBuild sends to the source provider. The usage of
    /// this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Specifies the target url of the build status CodeBuild sends to the source provider. The
    /// usage of this parameter depends on the source provider.
    /// </summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSourceGitSubmodulesConfig
{
    /// <summary>Whether to fetch Git submodules for the AWS CodeBuild build project.</summary>
    [JsonPropertyName("fetchSubmodules")]
    public bool? FetchSubmodules { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderSource
{
    /// <summary>
    /// Information about the strategy CodeBuild should use when authenticating with the source code host.
    /// Detailed below.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1beta1ProjectStatusAtProviderSourceAuth? Auth { get; set; }

    /// <summary>
    /// Configuration block that contains information that defines how the build project
    /// reports the build status to the source provider. This option is only used when the source provider is GitHub, GitHub
    /// Enterprise, GitLab, GitLab Self Managed, or Bitbucket. build_status_config blocks are documented below.
    /// </summary>
    [JsonPropertyName("buildStatusConfig")]
    public V1beta1ProjectStatusAtProviderSourceBuildStatusConfig? BuildStatusConfig { get; set; }

    /// <summary>
    /// Build specification to use for this build project&apos;s related builds. This must be set when
    /// type is NO_SOURCE. Also, if a non-default buildspec file name or file path aside from the root is used, it must be
    /// specified.
    /// </summary>
    [JsonPropertyName("buildspec")]
    public string? Buildspec { get; set; }

    /// <summary>
    /// Truncate git history to this many commits. Use 0 for a Full checkout which you need
    /// to run commands like git branch --show-current.
    /// See AWS CodePipeline User Guide: Tutorial: Use full clone with a GitHub pipeline source
    /// for details.
    /// </summary>
    [JsonPropertyName("gitCloneDepth")]
    public double? GitCloneDepth { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("gitSubmodulesConfig")]
    public V1beta1ProjectStatusAtProviderSourceGitSubmodulesConfig? GitSubmodulesConfig { get; set; }

    /// <summary>Ignore SSL warnings when connecting to source control.</summary>
    [JsonPropertyName("insecureSsl")]
    public bool? InsecureSsl { get; set; }

    /// <summary>Location of the source code from git or s3.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Whether to report the status of a build&apos;s start and finish to your source provider.
    /// This option is valid only when your source provider is GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or
    /// Bitbucket.
    /// </summary>
    [JsonPropertyName("reportBuildStatus")]
    public bool? ReportBuildStatus { get; set; }

    /// <summary>
    /// Type of repository that contains the source code to be built. Valid values: BITBUCKET,
    /// CODECOMMIT, CODEPIPELINE, GITHUB, GITHUB_ENTERPRISE, GITLAB, GITLAB_SELF_MANAGED, NO_SOURCE, S3.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderVpcConfig
{
    /// <summary>Security group IDs to assign to running builds.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Subnet IDs within which to run builds.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>ID of the VPC within which to run builds.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProvider
{
    /// <summary>ARN of the CodeBuild project.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("artifacts")]
    public V1beta1ProjectStatusAtProviderArtifacts? Artifacts { get; set; }

    /// <summary>
    /// Specify a maximum number of additional automatic retries after a failed build.
    /// The default is 0.
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    [JsonPropertyName("autoRetryLimit")]
    public double? AutoRetryLimit { get; set; }

    /// <summary>
    /// Generates a publicly-accessible URL for the projects build badge. Available as
    /// badge_url attribute when enabled.
    /// </summary>
    [JsonPropertyName("badgeEnabled")]
    public bool? BadgeEnabled { get; set; }

    /// <summary>URL of the build badge when badge_enabled is enabled.</summary>
    [JsonPropertyName("badgeUrl")]
    public string? BadgeUrl { get; set; }

    /// <summary>Defines the batch build options for the project.</summary>
    [JsonPropertyName("buildBatchConfig")]
    public V1beta1ProjectStatusAtProviderBuildBatchConfig? BuildBatchConfig { get; set; }

    /// <summary>
    /// Number of minutes, from 5 to 2160 (36 hours), for AWS CodeBuild to wait until timing out
    /// any related build that does not get marked as completed. The default is 60 minutes. The build_timeout property is
    /// not available on the Lambda compute type.
    /// </summary>
    [JsonPropertyName("buildTimeout")]
    public double? BuildTimeout { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("cache")]
    public V1beta1ProjectStatusAtProviderCache? Cache { get; set; }

    /// <summary>
    /// Specify a maximum number of concurrent builds for the project. The value
    /// specified must be greater than 0 and less than the account concurrent running builds limit.
    /// </summary>
    [JsonPropertyName("concurrentBuildLimit")]
    public double? ConcurrentBuildLimit { get; set; }

    /// <summary>Short description of the project.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting
    /// the build project&apos;s build output artifacts.
    /// </summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public V1beta1ProjectStatusAtProviderEnvironment? Environment { get; set; }

    /// <summary>
    /// A set of file system locations to mount inside the build. File system locations
    /// are documented below.
    /// </summary>
    [JsonPropertyName("fileSystemLocations")]
    public IList<V1beta1ProjectStatusAtProviderFileSystemLocations>? FileSystemLocations { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("logsConfig")]
    public V1beta1ProjectStatusAtProviderLogsConfig? LogsConfig { get; set; }

    /// <summary>
    /// Specifies the visibility of the project&apos;s builds. Possible values are: PUBLIC_READ
    /// and PRIVATE. Default value is PRIVATE.
    /// </summary>
    [JsonPropertyName("projectVisibility")]
    public string? ProjectVisibility { get; set; }

    /// <summary>The project identifier used with the public build APIs.</summary>
    [JsonPropertyName("publicProjectAlias")]
    public string? PublicProjectAlias { get; set; }

    /// <summary>
    /// Number of minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it
    /// times out. The default is 8 hours. The queued_timeout property is not available on the Lambda compute type.
    /// </summary>
    [JsonPropertyName("queuedTimeout")]
    public double? QueuedTimeout { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The ARN of the IAM role that enables CodeBuild to access the CloudWatch Logs and
    /// Amazon S3 artifacts for the project&apos;s builds in order to display them publicly. Only applicable if
    /// project_visibility is PUBLIC_READ.
    /// </summary>
    [JsonPropertyName("resourceAccessRole")]
    public string? ResourceAccessRole { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondaryArtifacts")]
    public IList<V1beta1ProjectStatusAtProviderSecondaryArtifacts>? SecondaryArtifacts { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondarySourceVersion")]
    public IList<V1beta1ProjectStatusAtProviderSecondarySourceVersion>? SecondarySourceVersion { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("secondarySources")]
    public IList<V1beta1ProjectStatusAtProviderSecondarySources>? SecondarySources { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that
    /// enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
    /// </summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("source")]
    public V1beta1ProjectStatusAtProviderSource? Source { get; set; }

    /// <summary>
    /// Version of the build input to be built for this project. If not specified, the latest
    /// version is used.
    /// </summary>
    [JsonPropertyName("sourceVersion")]
    public string? SourceVersion { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// A map of tags assigned to the resource, including those inherited from the provider
    /// .
    /// </summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ProjectStatusAtProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusConditions
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

/// <summary>ProjectStatus defines the observed state of Project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ProjectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ProjectStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Project is the Schema for the Projects API. Provides a CodeBuild Project resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Project : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProjectSpec>, IStatus<V1beta1ProjectStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Project";
    public const string KubeGroup = "codebuild.aws.upbound.io";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codebuild.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Project";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProjectSpec defines the desired state of Project</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ProjectSpec Spec { get; set; }

    /// <summary>ProjectStatus defines the observed state of Project.</summary>
    [JsonPropertyName("status")]
    public V1beta1ProjectStatus? Status { get; set; }
}
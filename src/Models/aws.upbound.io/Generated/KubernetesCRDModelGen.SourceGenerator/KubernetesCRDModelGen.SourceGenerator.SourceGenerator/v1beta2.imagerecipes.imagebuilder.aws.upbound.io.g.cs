#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.imagebuilder.aws.upbound.io;
/// <summary>ImageRecipe is the Schema for the ImageRecipes API. Manage an Image Builder Image Recipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImageRecipeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ImageRecipe>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImageRecipeList";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "imagerecipes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "imagebuilder.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageRecipeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ImageRecipe objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ImageRecipe> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecDeletionPolicyEnum>))]
public enum V1beta2ImageRecipeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderBlockDeviceMappingEbs
{
    /// <summary>Whether to delete the volume on termination. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Whether to encrypt the volume. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>Number of Input/Output (I/O) operations per second to provision for an io1 or io2 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key for encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Identifier of the EC2 Volume Snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>For GP3 volumes only. The throughput in MiB/s that the volume supports.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume, in GiB.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of the volume. For example, gp2 or io2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public V1beta2ImageRecipeSpecForProviderBlockDeviceMappingEbs? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolutionEnum>))]
public enum V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolveEnum>))]
public enum V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderComponentComponentArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolveEnum>))]
public enum V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderComponentComponentArnSelector
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
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnRef")]
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnRef? ComponentArnRef { get; set; }

    /// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnSelector")]
    public V1beta2ImageRecipeSpecForProviderComponentComponentArnSelector? ComponentArnSelector { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ImageRecipeSpecForProviderComponentParameter>? Parameter { get; set; }
}

/// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProviderSystemsManagerAgent
{
    /// <summary>Whether to remove the Systems Manager Agent after the image has been built.</summary>
    [JsonPropertyName("uninstallAfterBuild")]
    public bool? UninstallAfterBuild { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecForProvider
{
    /// <summary>Tags that are applied to the AMI that Image Builder creates during the Build phase prior to image distribution. Maximum of 50 tags.</summary>
    [JsonPropertyName("amiTags")]
    public IDictionary<string, string>? AmiTags { get; set; }

    /// <summary>Configuration block(s) with block device mappings for the image recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta2ImageRecipeSpecForProviderBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>Ordered configuration block(s) with components for the image recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta2ImageRecipeSpecForProviderComponent>? Component { get; set; }

    /// <summary>Description of the image recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the image recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The image recipe uses this image as a base from which to build your customized image. The value can be the base image ARN, an AMI ID, or an SSM Parameter referencing the AMI. For an SSM Parameter, enter the prefix ssm:, followed by the parameter name or ARN.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
    [JsonPropertyName("systemsManagerAgent")]
    public V1beta2ImageRecipeSpecForProviderSystemsManagerAgent? SystemsManagerAgent { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Base64 encoded user data. Use this to provide commands or a command script to run when you launch your build instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>The semantic version of the image recipe, which specifies the version in the following format, with numeric values in each position to indicate a specific version: major.minor.patch. For example: 1.0.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderBlockDeviceMappingEbs
{
    /// <summary>Whether to delete the volume on termination. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Whether to encrypt the volume. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>Number of Input/Output (I/O) operations per second to provision for an io1 or io2 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key for encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Identifier of the EC2 Volume Snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>For GP3 volumes only. The throughput in MiB/s that the volume supports.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume, in GiB.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of the volume. For example, gp2 or io2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public V1beta2ImageRecipeSpecInitProviderBlockDeviceMappingEbs? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolutionEnum>))]
public enum V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolveEnum>))]
public enum V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderComponentComponentArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolveEnum>))]
public enum V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelector
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
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnRef")]
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnRef? ComponentArnRef { get; set; }

    /// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnSelector")]
    public V1beta2ImageRecipeSpecInitProviderComponentComponentArnSelector? ComponentArnSelector { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ImageRecipeSpecInitProviderComponentParameter>? Parameter { get; set; }
}

/// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecInitProviderSystemsManagerAgent
{
    /// <summary>Whether to remove the Systems Manager Agent after the image has been built.</summary>
    [JsonPropertyName("uninstallAfterBuild")]
    public bool? UninstallAfterBuild { get; set; }
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
public partial class V1beta2ImageRecipeSpecInitProvider
{
    /// <summary>Tags that are applied to the AMI that Image Builder creates during the Build phase prior to image distribution. Maximum of 50 tags.</summary>
    [JsonPropertyName("amiTags")]
    public IDictionary<string, string>? AmiTags { get; set; }

    /// <summary>Configuration block(s) with block device mappings for the image recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta2ImageRecipeSpecInitProviderBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>Ordered configuration block(s) with components for the image recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta2ImageRecipeSpecInitProviderComponent>? Component { get; set; }

    /// <summary>Description of the image recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the image recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The image recipe uses this image as a base from which to build your customized image. The value can be the base image ARN, an AMI ID, or an SSM Parameter referencing the AMI. For an SSM Parameter, enter the prefix ssm:, followed by the parameter name or ARN.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
    [JsonPropertyName("systemsManagerAgent")]
    public V1beta2ImageRecipeSpecInitProviderSystemsManagerAgent? SystemsManagerAgent { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Base64 encoded user data. Use this to provide commands or a command script to run when you launch your build instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>The semantic version of the image recipe, which specifies the version in the following format, with numeric values in each position to indicate a specific version: major.minor.patch. For example: 1.0.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecManagementPoliciesEnum>))]
public enum V1beta2ImageRecipeSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ImageRecipeSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRecipeSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ImageRecipeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageRecipeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageRecipeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImageRecipeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ImageRecipeSpec defines the desired state of ImageRecipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeSpec
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
    public V1beta2ImageRecipeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ImageRecipeSpecForProvider ForProvider { get; set; }

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
    public V1beta2ImageRecipeSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ImageRecipeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ImageRecipeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ImageRecipeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatusAtProviderBlockDeviceMappingEbs
{
    /// <summary>Whether to delete the volume on termination. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Whether to encrypt the volume. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>Number of Input/Output (I/O) operations per second to provision for an io1 or io2 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key for encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Identifier of the EC2 Volume Snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>For GP3 volumes only. The throughput in MiB/s that the volume supports.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume, in GiB.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of the volume. For example, gp2 or io2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatusAtProviderBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public V1beta2ImageRecipeStatusAtProviderBlockDeviceMappingEbs? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatusAtProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatusAtProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ImageRecipeStatusAtProviderComponentParameter>? Parameter { get; set; }
}

/// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatusAtProviderSystemsManagerAgent
{
    /// <summary>Whether to remove the Systems Manager Agent after the image has been built.</summary>
    [JsonPropertyName("uninstallAfterBuild")]
    public bool? UninstallAfterBuild { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatusAtProvider
{
    /// <summary>Tags that are applied to the AMI that Image Builder creates during the Build phase prior to image distribution. Maximum of 50 tags.</summary>
    [JsonPropertyName("amiTags")]
    public IDictionary<string, string>? AmiTags { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block(s) with block device mappings for the image recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta2ImageRecipeStatusAtProviderBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>Ordered configuration block(s) with components for the image recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta2ImageRecipeStatusAtProviderComponent>? Component { get; set; }

    /// <summary>Date the image recipe was created.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>Description of the image recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the image recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the image recipe.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The image recipe uses this image as a base from which to build your customized image. The value can be the base image ARN, an AMI ID, or an SSM Parameter referencing the AMI. For an SSM Parameter, enter the prefix ssm:, followed by the parameter name or ARN.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Platform of the image recipe.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
    [JsonPropertyName("systemsManagerAgent")]
    public V1beta2ImageRecipeStatusAtProviderSystemsManagerAgent? SystemsManagerAgent { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Base64 encoded user data. Use this to provide commands or a command script to run when you launch your build instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>The semantic version of the image recipe, which specifies the version in the following format, with numeric values in each position to indicate a specific version: major.minor.patch. For example: 1.0.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatusConditions
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

/// <summary>ImageRecipeStatus defines the observed state of ImageRecipe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRecipeStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ImageRecipeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ImageRecipeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ImageRecipe is the Schema for the ImageRecipes API. Manage an Image Builder Image Recipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImageRecipe : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ImageRecipeSpec>, IStatus<V1beta2ImageRecipeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImageRecipe";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "imagerecipes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "imagebuilder.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageRecipe";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageRecipeSpec defines the desired state of ImageRecipe</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ImageRecipeSpec Spec { get; set; }

    /// <summary>ImageRecipeStatus defines the observed state of ImageRecipe.</summary>
    [JsonPropertyName("status")]
    public V1beta2ImageRecipeStatus? Status { get; set; }
}
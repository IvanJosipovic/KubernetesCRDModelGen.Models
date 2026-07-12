#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.services.k8s.aws;
/// <summary>PatchBaseline is the Schema for the PatchBaselines API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PatchBaselineList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PatchBaseline>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PatchBaselineList";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "patchbaselines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PatchBaselineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PatchBaseline objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PatchBaseline> Items { get; set; }
}

/// <summary>
/// Defines which patches should be included in a patch baseline.
/// 
/// A patch filter consists of a key and a set of values. The filter key is a
/// patch property. For example, the available filter keys for WINDOWS are PATCH_SET,
/// PRODUCT, PRODUCT_FAMILY, CLASSIFICATION, and MSRC_SEVERITY.
/// 
/// The filter values define a matching criterion for the patch property indicated
/// by the key. For example, if the filter key is PRODUCT and the filter values
/// are [&quot;Office 2013&quot;, &quot;Office 2016&quot;], then the filter accepts all patches where
/// product name is either &quot;Office 2013&quot; or &quot;Office 2016&quot;. The filter values
/// can be exact values for the patch property given as a key, or a wildcard
/// (*), which matches all values.
/// 
/// You can view lists of valid values for the patch properties by running the
/// DescribePatchProperties command. For information about which patch properties
/// can be used with each major operating system, see DescribePatchProperties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecApprovalRulesPatchRulesPatchFilterGroupPatchFilters
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A set of patch filters, typically used for approval rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecApprovalRulesPatchRulesPatchFilterGroup
{
    [JsonPropertyName("patchFilters")]
    public IList<V1alpha1PatchBaselineSpecApprovalRulesPatchRulesPatchFilterGroupPatchFilters>? PatchFilters { get; set; }
}

/// <summary>Defines an approval rule for a patch baseline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecApprovalRulesPatchRules
{
    [JsonPropertyName("approveAfterDays")]
    public long? ApproveAfterDays { get; set; }

    [JsonPropertyName("approveUntilDate")]
    public string? ApproveUntilDate { get; set; }

    [JsonPropertyName("complianceLevel")]
    public string? ComplianceLevel { get; set; }

    [JsonPropertyName("enableNonSecurity")]
    public bool? EnableNonSecurity { get; set; }

    /// <summary>A set of patch filters, typically used for approval rules.</summary>
    [JsonPropertyName("patchFilterGroup")]
    public V1alpha1PatchBaselineSpecApprovalRulesPatchRulesPatchFilterGroup? PatchFilterGroup { get; set; }
}

/// <summary>A set of rules used to include patches in the baseline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecApprovalRules
{
    [JsonPropertyName("patchRules")]
    public IList<V1alpha1PatchBaselineSpecApprovalRulesPatchRules>? PatchRules { get; set; }
}

/// <summary>
/// Defines which patches should be included in a patch baseline.
/// 
/// A patch filter consists of a key and a set of values. The filter key is a
/// patch property. For example, the available filter keys for WINDOWS are PATCH_SET,
/// PRODUCT, PRODUCT_FAMILY, CLASSIFICATION, and MSRC_SEVERITY.
/// 
/// The filter values define a matching criterion for the patch property indicated
/// by the key. For example, if the filter key is PRODUCT and the filter values
/// are [&quot;Office 2013&quot;, &quot;Office 2016&quot;], then the filter accepts all patches where
/// product name is either &quot;Office 2013&quot; or &quot;Office 2016&quot;. The filter values
/// can be exact values for the patch property given as a key, or a wildcard
/// (*), which matches all values.
/// 
/// You can view lists of valid values for the patch properties by running the
/// DescribePatchProperties command. For information about which patch properties
/// can be used with each major operating system, see DescribePatchProperties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecGlobalFiltersPatchFilters
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A set of global filters used to include patches in the baseline.
/// 
/// The GlobalFilters parameter can be configured only by using the CLI or an
/// Amazon Web Services SDK. It can&apos;t be configured from the Patch Manager console,
/// and its value isn&apos;t displayed in the console.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecGlobalFilters
{
    [JsonPropertyName("patchFilters")]
    public IList<V1alpha1PatchBaselineSpecGlobalFiltersPatchFilters>? PatchFilters { get; set; }
}

/// <summary>
/// Information about the patches to use to update the managed nodes, including
/// target operating systems and source repository. Applies to Linux managed
/// nodes only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecSources
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("products")]
    public IList<string>? Products { get; set; }
}

/// <summary>
/// Metadata that you assign to your Amazon Web Services resources. Tags enable
/// you to categorize your resources in different ways, for example, by purpose,
/// owner, or environment. In Amazon Web Services Systems Manager, you can apply
/// tags to Systems Manager documents (SSM documents), managed nodes, maintenance
/// windows, parameters, patch baselines, OpsItems, and OpsMetadata.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>PatchBaselineSpec defines the desired state of PatchBaseline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineSpec
{
    /// <summary>A set of rules used to include patches in the baseline.</summary>
    [JsonPropertyName("approvalRules")]
    public V1alpha1PatchBaselineSpecApprovalRules? ApprovalRules { get; set; }

    /// <summary>
    /// A list of explicitly approved patches for the baseline.
    /// 
    /// For information about accepted formats for lists of approved patches and
    /// rejected patches, see Package name formats for approved and rejected patch
    /// lists (https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-approved-rejected-package-name-formats.html)
    /// in the Amazon Web Services Systems Manager User Guide.
    /// </summary>
    [JsonPropertyName("approvedPatches")]
    public IList<string>? ApprovedPatches { get; set; }

    /// <summary>
    /// Defines the compliance level for approved patches. When an approved patch
    /// is reported as missing, this value describes the severity of the compliance
    /// violation. The default value is UNSPECIFIED.
    /// </summary>
    [JsonPropertyName("approvedPatchesComplianceLevel")]
    public string? ApprovedPatchesComplianceLevel { get; set; }

    /// <summary>
    /// Indicates whether the list of approved patches includes non-security updates
    /// that should be applied to the managed nodes. The default value is false.
    /// Applies to Linux managed nodes only.
    /// </summary>
    [JsonPropertyName("approvedPatchesEnableNonSecurity")]
    public bool? ApprovedPatchesEnableNonSecurity { get; set; }

    /// <summary>User-provided idempotency token.</summary>
    [JsonPropertyName("clientToken")]
    public string? ClientToken { get; set; }

    /// <summary>A description of the patch baseline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A set of global filters used to include patches in the baseline.
    /// 
    /// The GlobalFilters parameter can be configured only by using the CLI or an
    /// Amazon Web Services SDK. It can&apos;t be configured from the Patch Manager console,
    /// and its value isn&apos;t displayed in the console.
    /// </summary>
    [JsonPropertyName("globalFilters")]
    public V1alpha1PatchBaselineSpecGlobalFilters? GlobalFilters { get; set; }

    /// <summary>
    /// The name of the patch baseline.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9_\-.]{3,128}$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Defines the operating system the patch baseline applies to. The default value
    /// is WINDOWS.
    /// </summary>
    [JsonPropertyName("operatingSystem")]
    public string? OperatingSystem { get; set; }

    /// <summary>
    /// A list of explicitly rejected patches for the baseline.
    /// 
    /// For information about accepted formats for lists of approved patches and
    /// rejected patches, see Package name formats for approved and rejected patch
    /// lists (https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-approved-rejected-package-name-formats.html)
    /// in the Amazon Web Services Systems Manager User Guide.
    /// </summary>
    [JsonPropertyName("rejectedPatches")]
    public IList<string>? RejectedPatches { get; set; }

    /// <summary>
    /// The action for Patch Manager to take on patches included in the RejectedPackages
    /// list.
    /// 
    /// ALLOW_AS_DEPENDENCY
    /// 
    /// Linux and macOS: A package in the rejected patches list is installed only
    /// if it is a dependency of another package. It is considered compliant with
    /// the patch baseline, and its status is reported as INSTALLED_OTHER. This is
    /// the default action if no option is specified.
    /// 
    /// Windows Server: Windows Server doesn&apos;t support the concept of package dependencies.
    /// If a package in the rejected patches list and already installed on the node,
    /// its status is reported as INSTALLED_OTHER. Any package not already installed
    /// on the node is skipped. This is the default action if no option is specified.
    /// 
    /// # BLOCK
    /// 
    /// All OSs: Packages in the rejected patches list, and packages that include
    /// them as dependencies, aren&apos;t installed by Patch Manager under any circumstances.
    /// If a package was installed before it was added to the rejected patches list,
    /// or is installed outside of Patch Manager afterward, it&apos;s considered noncompliant
    /// with the patch baseline and its status is reported as INSTALLED_REJECTED.
    /// </summary>
    [JsonPropertyName("rejectedPatchesAction")]
    public string? RejectedPatchesAction { get; set; }

    /// <summary>
    /// Information about the patches to use to update the managed nodes, including
    /// target operating systems and source repositories. Applies to Linux managed
    /// nodes only.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1PatchBaselineSpecSources>? Sources { get; set; }

    /// <summary>
    /// Optional metadata that you assign to a resource. Tags enable you to categorize
    /// a resource in different ways, such as by purpose, owner, or environment.
    /// For example, you might want to tag a patch baseline to identify the severity
    /// level of patches it specifies and the operating system family it applies
    /// to. In this case, you could specify the following key-value pairs:
    /// 
    ///   - Key=PatchSeverity,Value=Critical
    /// 
    ///   - Key=OS,Value=Windows
    /// 
    /// To add tags to an existing patch baseline, use the AddTagsToResource operation.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1PatchBaselineSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>PatchBaselineStatus defines the observed state of PatchBaseline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PatchBaselineStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PatchBaselineStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The ID of the created patch baseline.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9_\-:/]{20,128}$`
    /// </summary>
    [JsonPropertyName("baselineID")]
    public string? BaselineID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PatchBaselineStatusConditions>? Conditions { get; set; }
}

/// <summary>PatchBaseline is the Schema for the PatchBaselines API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PatchBaseline : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PatchBaselineSpec?>, IStatus<V1alpha1PatchBaselineStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PatchBaseline";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "patchbaselines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PatchBaseline";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PatchBaselineSpec defines the desired state of PatchBaseline.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1PatchBaselineSpec? Spec { get; set; }

    /// <summary>PatchBaselineStatus defines the observed state of PatchBaseline</summary>
    [JsonPropertyName("status")]
    public V1alpha1PatchBaselineStatus? Status { get; set; }
}
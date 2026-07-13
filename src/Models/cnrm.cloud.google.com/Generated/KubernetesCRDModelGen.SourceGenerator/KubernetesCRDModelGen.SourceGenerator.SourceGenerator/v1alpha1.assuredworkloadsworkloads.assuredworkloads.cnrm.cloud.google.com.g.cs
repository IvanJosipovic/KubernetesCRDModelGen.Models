#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.assuredworkloads.cnrm.cloud.google.com;
/// <summary>AssuredWorkloadsWorkload is the Schema for the AssuredWorkloadsWorkload API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AssuredWorkloadsWorkloadList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AssuredWorkloadsWorkload>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AssuredWorkloadsWorkloadList";
    public const string KubeGroup = "assuredworkloads.cnrm.cloud.google.com";
    public const string KubePluralName = "assuredworkloadsworkloads";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "assuredworkloads.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AssuredWorkloadsWorkloadList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AssuredWorkloadsWorkload objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AssuredWorkloadsWorkload> Items { get; set; }
}

/// <summary>Optional. The billing account used for the resources which are direct children of workload. This billing account is initially associated with the resources created as part of Workload creation. After the initial creation of these resources, the customer can change the assigned billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadSpecBillingAccountRef
{
    /// <summary>A reference to an externally managed BillingAccount resource. Should be in the format &quot;billingAccounts/{billingAccountID}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BillingAccount resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BillingAccount resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadSpecResourceSettings
{
    /// <summary>User-assigned resource display name. If not empty it will be used to create a resource with the specified name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Resource identifier. For a project this represents project_id. If the project is already taken, the workload creation will fail. For KeyRing, this represents the keyring_id. For a folder, don&apos;t set this value as folder_id is assigned by Google.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Indicates the type of resource. This field should be specified to correspond the id to the right resource type (CONSUMER_FOLDER or ENCRYPTION_KEYS_PROJECT)</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>AssuredWorkloadsWorkloadSpec defines the desired state of AssuredWorkloadsWorkload</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadSpec
{
    /// <summary>Optional. The billing account used for the resources which are direct children of workload. This billing account is initially associated with the resources created as part of Workload creation. After the initial creation of these resources, the customer can change the assigned billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.</summary>
    [JsonPropertyName("billingAccountRef")]
    public V1alpha1AssuredWorkloadsWorkloadSpecBillingAccountRef? BillingAccountRef { get; set; }

    /// <summary>Required. Immutable. Compliance Regime associated with this workload.</summary>
    [JsonPropertyName("complianceRegime")]
    public string? ComplianceRegime { get; set; }

    /// <summary>
    /// Required. The user-assigned display name of the Workload.
    ///  When present it must be between 4 to 30 characters.
    ///  Allowed characters are: lowercase and uppercase letters, numbers,
    ///  hyphen, and spaces.
    /// 
    ///  Example: My Workload
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Indicates the sovereignty status of the given workload. Currently meant to be used by Europe/Canada customers.</summary>
    [JsonPropertyName("enableSovereignControls")]
    public bool? EnableSovereignControls { get; set; }

    /// <summary>Optional. Compliance Regime associated with this workload.</summary>
    [JsonPropertyName("partner")]
    public string? Partner { get; set; }

    /// <summary>The AssuredWorkloadsWorkload name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Input only. Resource properties that are used to customize workload resources. These properties (such as custom project id) will be used to create workload resources if possible. This field is optional.</summary>
    [JsonPropertyName("resourceSettings")]
    public IList<V1alpha1AssuredWorkloadsWorkloadSpecResourceSettings>? ResourceSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadStatusObservedStateResources
{
    /// <summary>Resource identifier. For a project this represents project_number.</summary>
    [JsonPropertyName("resourceID")]
    public long? ResourceID { get; set; }

    /// <summary>Indicates the type of resource.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>Output only. Represents the SAA enrollment response of the given workload. SAA enrollment response is queried during GetWorkload call. In failure cases, user friendly error message is shown in SAA details page.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadStatusObservedStateSaaEnrollmentResponse
{
    /// <summary>Indicates SAA enrollment setup error if any.</summary>
    [JsonPropertyName("setupErrors")]
    public IList<string>? SetupErrors { get; set; }

    /// <summary>Indicates SAA enrollment status of a given workload.</summary>
    [JsonPropertyName("setupStatus")]
    public string? SetupStatus { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadStatusObservedState
{
    /// <summary>Output only. Urls for services which are compliant for this Assured Workload, but which are currently disallowed by the ResourceUsageRestriction org policy. Invoke RestrictAllowedResources endpoint to allow your project developers to use these services in their environment.&quot;</summary>
    [JsonPropertyName("compliantButDisallowedServices")]
    public IList<string>? CompliantButDisallowedServices { get; set; }

    /// <summary>Output only. Immutable. The Workload creation timestamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Represents the KAJ enrollment state of the given workload.</summary>
    [JsonPropertyName("kajEnrollmentState")]
    public string? KajEnrollmentState { get; set; }

    /// <summary>Output only. The resources associated with this workload. These resources will be created when creating the workload. If any of the projects already exist, the workload creation will fail. Always read only.</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1AssuredWorkloadsWorkloadStatusObservedStateResources>? Resources { get; set; }

    /// <summary>Output only. Represents the SAA enrollment response of the given workload. SAA enrollment response is queried during GetWorkload call. In failure cases, user friendly error message is shown in SAA details page.</summary>
    [JsonPropertyName("saaEnrollmentResponse")]
    public V1alpha1AssuredWorkloadsWorkloadStatusObservedStateSaaEnrollmentResponse? SaaEnrollmentResponse { get; set; }
}

/// <summary>AssuredWorkloadsWorkloadStatus defines the config connector machine state of AssuredWorkloadsWorkload</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssuredWorkloadsWorkloadStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AssuredWorkloadsWorkloadStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AssuredWorkloadsWorkload resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AssuredWorkloadsWorkloadStatusObservedState? ObservedState { get; set; }
}

/// <summary>AssuredWorkloadsWorkload is the Schema for the AssuredWorkloadsWorkload API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AssuredWorkloadsWorkload : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AssuredWorkloadsWorkloadSpec>, IStatus<V1alpha1AssuredWorkloadsWorkloadStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AssuredWorkloadsWorkload";
    public const string KubeGroup = "assuredworkloads.cnrm.cloud.google.com";
    public const string KubePluralName = "assuredworkloadsworkloads";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "assuredworkloads.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AssuredWorkloadsWorkload";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AssuredWorkloadsWorkloadSpec defines the desired state of AssuredWorkloadsWorkload</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AssuredWorkloadsWorkloadSpec Spec { get; set; }

    /// <summary>AssuredWorkloadsWorkloadStatus defines the config connector machine state of AssuredWorkloadsWorkload</summary>
    [JsonPropertyName("status")]
    public V1alpha1AssuredWorkloadsWorkloadStatus? Status { get; set; }
}
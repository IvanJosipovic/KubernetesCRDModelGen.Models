#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firebasedatabase.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirebaseDatabaseInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FirebaseDatabaseInstance>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirebaseDatabaseInstanceList";
    public const string KubeGroup = "firebasedatabase.cnrm.cloud.google.com";
    public const string KubePluralName = "firebasedatabaseinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firebasedatabase.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirebaseDatabaseInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FirebaseDatabaseInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FirebaseDatabaseInstance> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirebaseDatabaseInstanceSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirebaseDatabaseInstanceSpec
{
    /// <summary>The intended database state.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1FirebaseDatabaseInstanceSpecProjectRef ProjectRef { get; set; }

    /// <summary>
    /// Immutable. A reference to the region where the Firebase Realtime database resides.
    /// Check all [available regions](https://firebase.google.com/docs/projects/locations#rtdb-locations).
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Immutable. Optional. The instanceId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Immutable. The database type.
    /// Each project can create one default Firebase Realtime Database, which cannot be deleted once created.
    /// Creating user Databases is only available for projects on the Blaze plan.
    /// Projects can be upgraded using the Cloud Billing API https://cloud.google.com/billing/reference/rest/v1/projects/updateBillingInfo. Default value: &quot;USER_DATABASE&quot; Possible values: [&quot;DEFAULT_DATABASE&quot;, &quot;USER_DATABASE&quot;].
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirebaseDatabaseInstanceStatusConditions
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
public partial class V1alpha1FirebaseDatabaseInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirebaseDatabaseInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The database URL in the form of https://{instance-id}.firebaseio.com for us-central1 instances
    /// or https://{instance-id}.{region}.firebasedatabase.app in other regions.
    /// </summary>
    [JsonPropertyName("databaseUrl")]
    public string? DatabaseUrl { get; set; }

    /// <summary>
    /// The fully-qualified resource name of the Firebase Realtime Database, in the
    /// format: projects/PROJECT_NUMBER/locations/REGION_IDENTIFIER/instances/INSTANCE_ID
    /// PROJECT_NUMBER: The Firebase project&apos;s [&apos;ProjectNumber&apos;](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects#FirebaseProject.FIELDS.project_number)
    /// Learn more about using project identifiers in Google&apos;s [AIP 2510 standard](https://google.aip.dev/cloud/2510).
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The current database state. Set desired_state to :DISABLED to disable the database and :ACTIVE to reenable the database.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirebaseDatabaseInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirebaseDatabaseInstanceSpec>, IStatus<V1alpha1FirebaseDatabaseInstanceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirebaseDatabaseInstance";
    public const string KubeGroup = "firebasedatabase.cnrm.cloud.google.com";
    public const string KubePluralName = "firebasedatabaseinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firebasedatabase.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirebaseDatabaseInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1FirebaseDatabaseInstanceSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1FirebaseDatabaseInstanceStatus? Status { get; set; }
}
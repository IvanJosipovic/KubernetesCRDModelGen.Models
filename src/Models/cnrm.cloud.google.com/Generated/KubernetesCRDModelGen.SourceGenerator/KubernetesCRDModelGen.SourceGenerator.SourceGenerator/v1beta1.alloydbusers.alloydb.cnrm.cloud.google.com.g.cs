#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.cnrm.cloud.google.com;
/// <summary>AlloyDBUser is the Schema for the AlloyDBUser API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlloyDBUserList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AlloyDBUser>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlloyDBUserList";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbusers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alloydb.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlloyDBUserList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AlloyDBUser objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AlloyDBUser> Items { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBUserSpecClusterRef
{
    /// <summary>A reference to an externally managed AlloyDBCluster resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/clusters/{{clusterID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a AlloyDBCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a AlloyDBCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBUserSpecPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBUserSpecPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1AlloyDBUserSpecPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Password for this database user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBUserSpecPassword
{
    /// <summary>Value of the field. Cannot be used if &apos;valueFrom&apos; is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1AlloyDBUserSpecPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>AlloyDBUserSpec defines the desired state of AlloyDBUser</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBUserSpec
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("clusterRef")]
    public required V1beta1AlloyDBUserSpecClusterRef ClusterRef { get; set; }

    /// <summary>List of database roles this database user has.</summary>
    [JsonPropertyName("databaseRoles")]
    public IList<string>? DatabaseRoles { get; set; }

    /// <summary>Password for this database user.</summary>
    [JsonPropertyName("password")]
    public V1beta1AlloyDBUserSpecPassword? Password { get; set; }

    /// <summary>Immutable. Optional. The userId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The type of this user. Possible values: [&quot;ALLOYDB_BUILT_IN&quot;, &quot;ALLOYDB_IAM_USER&quot;].</summary>
    [JsonPropertyName("userType")]
    public required string UserType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBUserStatusConditions
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

/// <summary>AlloyDBUserStatus defines the config connector machine state of AlloyDBUser</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBUserStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AlloyDBUserStatusConditions>? Conditions { get; set; }

    /// <summary>Name of the resource in the form of projects/{project}/locations/{location}/clusters/{cluster}/users/{user}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary>AlloyDBUser is the Schema for the AlloyDBUser API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlloyDBUser : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AlloyDBUserSpec>, IStatus<V1beta1AlloyDBUserStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlloyDBUser";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbusers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alloydb.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlloyDBUser";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlloyDBUserSpec defines the desired state of AlloyDBUser</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AlloyDBUserSpec Spec { get; set; }

    /// <summary>AlloyDBUserStatus defines the config connector machine state of AlloyDBUser</summary>
    [JsonPropertyName("status")]
    public V1beta1AlloyDBUserStatus? Status { get; set; }
}
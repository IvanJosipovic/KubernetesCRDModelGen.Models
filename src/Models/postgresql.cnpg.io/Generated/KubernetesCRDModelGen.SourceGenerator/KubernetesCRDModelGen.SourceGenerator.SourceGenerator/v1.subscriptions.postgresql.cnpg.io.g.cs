#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>Subscription is the Schema for the subscriptions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1Subscription>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SubscriptionList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "subscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Subscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Subscription> Items { get; set; }
}

/// <summary>The name of the PostgreSQL cluster that identifies the &quot;subscriber&quot;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpecCluster
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The policy for end-of-life maintenance of this subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1SubscriptionSpecSubscriptionReclaimPolicyEnum>))]
public enum V1SubscriptionSpecSubscriptionReclaimPolicyEnum
{
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "retain"), JsonStringEnumMemberName("retain")]
    Retain
}

/// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpec
{
    /// <summary>The name of the PostgreSQL cluster that identifies the &quot;subscriber&quot;</summary>
    [JsonPropertyName("cluster")]
    public required V1SubscriptionSpecCluster Cluster { get; set; }

    /// <summary>
    /// The name of the database where the publication will be installed in
    /// the &quot;subscriber&quot; cluster
    /// </summary>
    [JsonPropertyName("dbname")]
    public required string Dbname { get; set; }

    /// <summary>The name of the external cluster with the publication (&quot;publisher&quot;)</summary>
    [JsonPropertyName("externalClusterName")]
    public required string ExternalClusterName { get; set; }

    /// <summary>The name of the subscription inside PostgreSQL</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Subscription parameters included in the `WITH` clause of the PostgreSQL
    /// `CREATE SUBSCRIPTION` command. Most parameters cannot be changed
    /// after the subscription is created and will be ignored if modified
    /// later, except for a limited set documented at:
    /// https://www.postgresql.org/docs/current/sql-altersubscription.html#SQL-ALTERSUBSCRIPTION-PARAMS-SET
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>
    /// The name of the database containing the publication on the external
    /// cluster. Defaults to the one in the external cluster definition.
    /// </summary>
    [JsonPropertyName("publicationDBName")]
    public string? PublicationDBName { get; set; }

    /// <summary>
    /// The name of the publication inside the PostgreSQL database in the
    /// &quot;publisher&quot;
    /// </summary>
    [JsonPropertyName("publicationName")]
    public required string PublicationName { get; set; }

    /// <summary>The policy for end-of-life maintenance of this subscription</summary>
    [JsonPropertyName("subscriptionReclaimPolicy")]
    public V1SubscriptionSpecSubscriptionReclaimPolicyEnum? SubscriptionReclaimPolicy { get; set; }
}

/// <summary>SubscriptionStatus defines the observed state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionStatus
{
    /// <summary>Applied is true if the subscription was reconciled correctly</summary>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }

    /// <summary>Message is the reconciliation output message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// A sequence number representing the latest
    /// desired state that was synchronized
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Subscription is the Schema for the subscriptions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Subscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1SubscriptionSpec>, IStatus<V1SubscriptionStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Subscription";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "subscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Subscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
    [JsonPropertyName("spec")]
    public required V1SubscriptionSpec Spec { get; set; }

    /// <summary>SubscriptionStatus defines the observed state of Subscription</summary>
    [JsonPropertyName("status")]
    public V1SubscriptionStatus? Status { get; set; }
}
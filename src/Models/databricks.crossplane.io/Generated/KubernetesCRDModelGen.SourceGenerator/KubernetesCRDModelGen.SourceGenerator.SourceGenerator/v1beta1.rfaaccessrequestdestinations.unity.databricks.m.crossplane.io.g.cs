#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.m.crossplane.io;
/// <summary>RfaAccessRequestDestinations is the Schema for the RfaAccessRequestDestinationss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RfaAccessRequestDestinationsList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RfaAccessRequestDestinations>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RfaAccessRequestDestinationsList";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "rfaaccessrequestdestinations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RfaAccessRequestDestinationsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RfaAccessRequestDestinations objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RfaAccessRequestDestinations> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecForProviderDestinations
{
    /// <summary>
    /// The identifier for the destination. This is the email address for EMAIL destinations, the URL for URL destinations,
    /// or the unique Databricks notification destination ID for all other external destinations
    /// </summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The type of the destination. Possible values are: EMAIL, GENERIC_WEBHOOK, MICROSOFT_TEAMS, SLACK, URL</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>
    /// This field is used to denote whether the destination is the email of the owner of the securable object.
    /// The special destination cannot be assigned to a securable and only represents the default destination of the securable.
    /// The securable types that support default special destinations are: &quot;catalog&quot;, &quot;external_location&quot;, &quot;connection&quot;, &quot;credential&quot;, and &quot;metastore&quot;.
    /// The destination_type of a special_destination is always EMAIL. Possible values are: SPECIAL_DESTINATION_CATALOG_OWNER, SPECIAL_DESTINATION_CONNECTION_OWNER, SPECIAL_DESTINATION_CREDENTIAL_OWNER, SPECIAL_DESTINATION_EXTERNAL_LOCATION_OWNER, SPECIAL_DESTINATION_METASTORE_OWNER
    /// </summary>
    [JsonPropertyName("specialDestination")]
    public string? SpecialDestination { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The securable for which the access request destinations are being modified or read</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecForProviderSecurable
{
    /// <summary>
    /// Required. The full name of the catalog/schema/table.
    /// Optional if resource_name is present
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>
    /// Optional. The name of the Share object that contains the securable when the securable is
    /// getting shared in D2D Delta Sharing
    /// </summary>
    [JsonPropertyName("providerShare")]
    public string? ProviderShare { get; set; }

    /// <summary>
    /// Required. The type of securable (catalog/schema/table).
    /// Optional if resource_name is present. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecForProvider
{
    /// <summary>The access request destinations for the securable</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1RfaAccessRequestDestinationsSpecForProviderDestinations>? Destinations { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1RfaAccessRequestDestinationsSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The securable for which the access request destinations are being modified or read</summary>
    [JsonPropertyName("securable")]
    public V1beta1RfaAccessRequestDestinationsSpecForProviderSecurable? Securable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecInitProviderDestinations
{
    /// <summary>
    /// The identifier for the destination. This is the email address for EMAIL destinations, the URL for URL destinations,
    /// or the unique Databricks notification destination ID for all other external destinations
    /// </summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The type of the destination. Possible values are: EMAIL, GENERIC_WEBHOOK, MICROSOFT_TEAMS, SLACK, URL</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>
    /// This field is used to denote whether the destination is the email of the owner of the securable object.
    /// The special destination cannot be assigned to a securable and only represents the default destination of the securable.
    /// The securable types that support default special destinations are: &quot;catalog&quot;, &quot;external_location&quot;, &quot;connection&quot;, &quot;credential&quot;, and &quot;metastore&quot;.
    /// The destination_type of a special_destination is always EMAIL. Possible values are: SPECIAL_DESTINATION_CATALOG_OWNER, SPECIAL_DESTINATION_CONNECTION_OWNER, SPECIAL_DESTINATION_CREDENTIAL_OWNER, SPECIAL_DESTINATION_EXTERNAL_LOCATION_OWNER, SPECIAL_DESTINATION_METASTORE_OWNER
    /// </summary>
    [JsonPropertyName("specialDestination")]
    public string? SpecialDestination { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The securable for which the access request destinations are being modified or read</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecInitProviderSecurable
{
    /// <summary>
    /// Required. The full name of the catalog/schema/table.
    /// Optional if resource_name is present
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>
    /// Optional. The name of the Share object that contains the securable when the securable is
    /// getting shared in D2D Delta Sharing
    /// </summary>
    [JsonPropertyName("providerShare")]
    public string? ProviderShare { get; set; }

    /// <summary>
    /// Required. The type of securable (catalog/schema/table).
    /// Optional if resource_name is present. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecInitProvider
{
    /// <summary>The access request destinations for the securable</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1RfaAccessRequestDestinationsSpecInitProviderDestinations>? Destinations { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1RfaAccessRequestDestinationsSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The securable for which the access request destinations are being modified or read</summary>
    [JsonPropertyName("securable")]
    public V1beta1RfaAccessRequestDestinationsSpecInitProviderSecurable? Securable { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RfaAccessRequestDestinationsSpecManagementPoliciesEnum>))]
public enum V1beta1RfaAccessRequestDestinationsSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RfaAccessRequestDestinationsSpec defines the desired state of RfaAccessRequestDestinations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RfaAccessRequestDestinationsSpecForProvider ForProvider { get; set; }

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
    public V1beta1RfaAccessRequestDestinationsSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RfaAccessRequestDestinationsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RfaAccessRequestDestinationsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RfaAccessRequestDestinationsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The source securable from which the destinations are inherited. Either the same value as securable (if destination
/// is set directly on the securable) or the nearest parent securable with destinations set
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsStatusAtProviderDestinationSourceSecurable
{
    /// <summary>
    /// Required. The full name of the catalog/schema/table.
    /// Optional if resource_name is present
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>
    /// Optional. The name of the Share object that contains the securable when the securable is
    /// getting shared in D2D Delta Sharing
    /// </summary>
    [JsonPropertyName("providerShare")]
    public string? ProviderShare { get; set; }

    /// <summary>
    /// Required. The type of securable (catalog/schema/table).
    /// Optional if resource_name is present. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsStatusAtProviderDestinations
{
    /// <summary>
    /// The identifier for the destination. This is the email address for EMAIL destinations, the URL for URL destinations,
    /// or the unique Databricks notification destination ID for all other external destinations
    /// </summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The type of the destination. Possible values are: EMAIL, GENERIC_WEBHOOK, MICROSOFT_TEAMS, SLACK, URL</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>
    /// This field is used to denote whether the destination is the email of the owner of the securable object.
    /// The special destination cannot be assigned to a securable and only represents the default destination of the securable.
    /// The securable types that support default special destinations are: &quot;catalog&quot;, &quot;external_location&quot;, &quot;connection&quot;, &quot;credential&quot;, and &quot;metastore&quot;.
    /// The destination_type of a special_destination is always EMAIL. Possible values are: SPECIAL_DESTINATION_CATALOG_OWNER, SPECIAL_DESTINATION_CONNECTION_OWNER, SPECIAL_DESTINATION_CREDENTIAL_OWNER, SPECIAL_DESTINATION_EXTERNAL_LOCATION_OWNER, SPECIAL_DESTINATION_METASTORE_OWNER
    /// </summary>
    [JsonPropertyName("specialDestination")]
    public string? SpecialDestination { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The securable for which the access request destinations are being modified or read</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsStatusAtProviderSecurable
{
    /// <summary>
    /// Required. The full name of the catalog/schema/table.
    /// Optional if resource_name is present
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>
    /// Optional. The name of the Share object that contains the securable when the securable is
    /// getting shared in D2D Delta Sharing
    /// </summary>
    [JsonPropertyName("providerShare")]
    public string? ProviderShare { get; set; }

    /// <summary>
    /// Required. The type of securable (catalog/schema/table).
    /// Optional if resource_name is present. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsStatusAtProvider
{
    /// <summary>
    /// Indicates whether any destinations are hidden from the caller due to a lack of permissions.
    /// This value is true if the caller does not have permission to see all destinations
    /// </summary>
    [JsonPropertyName("areAnyDestinationsHidden")]
    public bool? AreAnyDestinationsHidden { get; set; }

    /// <summary>
    /// The source securable from which the destinations are inherited. Either the same value as securable (if destination
    /// is set directly on the securable) or the nearest parent securable with destinations set
    /// </summary>
    [JsonPropertyName("destinationSourceSecurable")]
    public V1beta1RfaAccessRequestDestinationsStatusAtProviderDestinationSourceSecurable? DestinationSourceSecurable { get; set; }

    /// <summary>The access request destinations for the securable</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1RfaAccessRequestDestinationsStatusAtProviderDestinations>? Destinations { get; set; }

    /// <summary>
    /// Required. The full name of the catalog/schema/table.
    /// Optional if resource_name is present
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1RfaAccessRequestDestinationsStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The securable for which the access request destinations are being modified or read</summary>
    [JsonPropertyName("securable")]
    public V1beta1RfaAccessRequestDestinationsStatusAtProviderSecurable? Securable { get; set; }

    /// <summary>The type of the securable</summary>
    [JsonPropertyName("securableType")]
    public string? SecurableType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsStatusConditions
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

/// <summary>RfaAccessRequestDestinationsStatus defines the observed state of RfaAccessRequestDestinations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RfaAccessRequestDestinationsStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RfaAccessRequestDestinationsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RfaAccessRequestDestinationsStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RfaAccessRequestDestinations is the Schema for the RfaAccessRequestDestinationss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RfaAccessRequestDestinations : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RfaAccessRequestDestinationsSpec>, IStatus<V1beta1RfaAccessRequestDestinationsStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RfaAccessRequestDestinations";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "rfaaccessrequestdestinations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RfaAccessRequestDestinations";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RfaAccessRequestDestinationsSpec defines the desired state of RfaAccessRequestDestinations</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RfaAccessRequestDestinationsSpec Spec { get; set; }

    /// <summary>RfaAccessRequestDestinationsStatus defines the observed state of RfaAccessRequestDestinations.</summary>
    [JsonPropertyName("status")]
    public V1beta1RfaAccessRequestDestinationsStatus? Status { get; set; }
}
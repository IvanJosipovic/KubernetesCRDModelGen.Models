#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.generic.vault.upbound.io;
/// <summary>Endpoint is the Schema for the Endpoints API. Writes arbitrary data to a given path in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Endpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EndpointList";
    public const string KubeGroup = "generic.vault.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "generic.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Endpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Endpoint> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1EndpointSpecDeletionPolicyEnum>))]
public enum V1alpha1EndpointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// String containing a JSON-encoded object that will be
/// written to the given path as the secret data.
/// JSON-encoded data to write.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecForProviderDataJsonSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecForProvider
{
    /// <summary>
    /// String containing a JSON-encoded object that will be
    /// written to the given path as the secret data.
    /// JSON-encoded data to write.
    /// </summary>
    [JsonPropertyName("dataJsonSecretRef")]
    public V1alpha1EndpointSpecForProviderDataJsonSecretRef? DataJsonSecretRef { get; set; }

    /// <summary>
    /// True/false. Set this to true if your
    /// vault authentication is not able to delete the data or if the endpoint
    /// does not support the DELETE method. Defaults to false.
    /// Don&apos;t attempt to delete the path from Vault if true
    /// </summary>
    [JsonPropertyName("disableDelete")]
    public bool? DisableDelete { get; set; }

    /// <summary>
    /// True/false. Set this to true if your vault
    /// authentication is not able to read the data or if the endpoint does
    /// not support the GET method. Setting this to true will break drift
    /// detection. You should set this to true for endpoints that are
    /// write-only. Defaults to false.
    /// Don&apos;t attempt to read the path from Vault if true; drift won&apos;t be detected
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    /// <summary>
    /// True/false. If set to true,
    /// ignore any fields present when the endpoint is read but that were not
    /// in data_json. Also, if a field that was written is not returned when
    /// the endpoint is read, treat that field as being up to date. You should
    /// set this to true when writing to endpoint that, when read, returns a
    /// different set of fields from the ones you wrote, as is common with
    /// many configuration endpoints. Defaults to false.
    /// When reading, disregard fields not present in data_json
    /// </summary>
    [JsonPropertyName("ignoreAbsentFields")]
    public bool? IgnoreAbsentFields { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The full logical path at which to write the given
    /// data. Consult each backend&apos;s documentation to see which endpoints
    /// support the PUT methods and to determine whether they also support
    /// DELETE and GET.
    /// Full path where to the endpoint that will be written
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// . A list of fields that should be returned
    /// in write_data_json and write_data. If omitted, data returned by
    /// the write operation is not available to the resource or included in
    /// state. This helps to avoid accidental storage of sensitive values in
    /// state. Some endpoints, such as many dynamic secrets endpoints, return
    /// data from writing to an endpoint rather than reading it. You should
    /// use write_fields if you need information returned in this way.
    /// Top-level fields returned by write to persist in state
    /// </summary>
    [JsonPropertyName("writeFields")]
    public IList<string>? WriteFields { get; set; }
}

/// <summary>
/// String containing a JSON-encoded object that will be
/// written to the given path as the secret data.
/// JSON-encoded data to write.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecInitProviderDataJsonSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
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
public partial class V1alpha1EndpointSpecInitProvider
{
    /// <summary>
    /// String containing a JSON-encoded object that will be
    /// written to the given path as the secret data.
    /// JSON-encoded data to write.
    /// </summary>
    [JsonPropertyName("dataJsonSecretRef")]
    public required V1alpha1EndpointSpecInitProviderDataJsonSecretRef DataJsonSecretRef { get; set; }

    /// <summary>
    /// True/false. Set this to true if your
    /// vault authentication is not able to delete the data or if the endpoint
    /// does not support the DELETE method. Defaults to false.
    /// Don&apos;t attempt to delete the path from Vault if true
    /// </summary>
    [JsonPropertyName("disableDelete")]
    public bool? DisableDelete { get; set; }

    /// <summary>
    /// True/false. Set this to true if your vault
    /// authentication is not able to read the data or if the endpoint does
    /// not support the GET method. Setting this to true will break drift
    /// detection. You should set this to true for endpoints that are
    /// write-only. Defaults to false.
    /// Don&apos;t attempt to read the path from Vault if true; drift won&apos;t be detected
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    /// <summary>
    /// True/false. If set to true,
    /// ignore any fields present when the endpoint is read but that were not
    /// in data_json. Also, if a field that was written is not returned when
    /// the endpoint is read, treat that field as being up to date. You should
    /// set this to true when writing to endpoint that, when read, returns a
    /// different set of fields from the ones you wrote, as is common with
    /// many configuration endpoints. Defaults to false.
    /// When reading, disregard fields not present in data_json
    /// </summary>
    [JsonPropertyName("ignoreAbsentFields")]
    public bool? IgnoreAbsentFields { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The full logical path at which to write the given
    /// data. Consult each backend&apos;s documentation to see which endpoints
    /// support the PUT methods and to determine whether they also support
    /// DELETE and GET.
    /// Full path where to the endpoint that will be written
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// . A list of fields that should be returned
    /// in write_data_json and write_data. If omitted, data returned by
    /// the write operation is not available to the resource or included in
    /// state. This helps to avoid accidental storage of sensitive values in
    /// state. Some endpoints, such as many dynamic secrets endpoints, return
    /// data from writing to an endpoint rather than reading it. You should
    /// use write_fields if you need information returned in this way.
    /// Top-level fields returned by write to persist in state
    /// </summary>
    [JsonPropertyName("writeFields")]
    public IList<string>? WriteFields { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1EndpointSpecManagementPoliciesEnum>))]
public enum V1alpha1EndpointSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1EndpointSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1EndpointSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1EndpointSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1EndpointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1EndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1EndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1EndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>EndpointSpec defines the desired state of Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpec
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
    public V1alpha1EndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1EndpointSpecForProvider ForProvider { get; set; }

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
    public V1alpha1EndpointSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1EndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1EndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1EndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusAtProvider
{
    /// <summary>
    /// True/false. Set this to true if your
    /// vault authentication is not able to delete the data or if the endpoint
    /// does not support the DELETE method. Defaults to false.
    /// Don&apos;t attempt to delete the path from Vault if true
    /// </summary>
    [JsonPropertyName("disableDelete")]
    public bool? DisableDelete { get; set; }

    /// <summary>
    /// True/false. Set this to true if your vault
    /// authentication is not able to read the data or if the endpoint does
    /// not support the GET method. Setting this to true will break drift
    /// detection. You should set this to true for endpoints that are
    /// write-only. Defaults to false.
    /// Don&apos;t attempt to read the path from Vault if true; drift won&apos;t be detected
    /// </summary>
    [JsonPropertyName("disableRead")]
    public bool? DisableRead { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// True/false. If set to true,
    /// ignore any fields present when the endpoint is read but that were not
    /// in data_json. Also, if a field that was written is not returned when
    /// the endpoint is read, treat that field as being up to date. You should
    /// set this to true when writing to endpoint that, when read, returns a
    /// different set of fields from the ones you wrote, as is common with
    /// many configuration endpoints. Defaults to false.
    /// When reading, disregard fields not present in data_json
    /// </summary>
    [JsonPropertyName("ignoreAbsentFields")]
    public bool? IgnoreAbsentFields { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The full logical path at which to write the given
    /// data. Consult each backend&apos;s documentation to see which endpoints
    /// support the PUT methods and to determine whether they also support
    /// DELETE and GET.
    /// Full path where to the endpoint that will be written
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// A map whose keys are the top-level data keys
    /// returned from Vault by the write operation and whose values are the
    /// corresponding values. This map can only represent string data, so
    /// any non-string values returned from Vault are serialized as JSON.
    /// Only fields set in write_fields are present in the JSON data.
    /// Map of strings returned by write operation
    /// </summary>
    [JsonPropertyName("writeData")]
    public IDictionary<string, string>? WriteData { get; set; }

    /// <summary>
    /// The JSON data returned by the write operation.
    /// Only fields set in write_fields are present in the JSON data.
    /// JSON data returned by write operation
    /// </summary>
    [JsonPropertyName("writeDataJson")]
    public string? WriteDataJson { get; set; }

    /// <summary>
    /// . A list of fields that should be returned
    /// in write_data_json and write_data. If omitted, data returned by
    /// the write operation is not available to the resource or included in
    /// state. This helps to avoid accidental storage of sensitive values in
    /// state. Some endpoints, such as many dynamic secrets endpoints, return
    /// data from writing to an endpoint rather than reading it. You should
    /// use write_fields if you need information returned in this way.
    /// Top-level fields returned by write to persist in state
    /// </summary>
    [JsonPropertyName("writeFields")]
    public IList<string>? WriteFields { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusConditions
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

/// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1EndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API. Writes arbitrary data to a given path in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EndpointSpec>, IStatus<V1alpha1EndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "generic.vault.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "generic.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Endpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointSpec defines the desired state of Endpoint</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1EndpointSpec Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
    [JsonPropertyName("status")]
    public V1alpha1EndpointStatus? Status { get; set; }
}
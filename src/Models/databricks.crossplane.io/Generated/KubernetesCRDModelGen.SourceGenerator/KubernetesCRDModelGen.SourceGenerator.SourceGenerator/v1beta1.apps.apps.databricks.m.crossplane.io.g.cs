#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apps.databricks.m.crossplane.io;
/// <summary>App is the Schema for the Apps API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppList : IKubernetesObject<V1ListMeta>, IItems<V1beta1App>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppList";
    public const string KubeGroup = "apps.databricks.m.crossplane.io";
    public const string KubePluralName = "apps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apps.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1App objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1App> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderGitRepository
{
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The URL of the app once it is deployed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderProviderConfig
{
    /// <summary>The unique ID of Genie Space.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesApp
{
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesDatabase
{
    /// <summary>The name of database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of database instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesExperiment
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("experimentId")]
    public string? ExperimentId { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesGenieSpace
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>The unique ID of Genie Space.</summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesJob
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesSecret
{
    /// <summary>Key of the secret to grant permission on.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>Scope of the secret to grant permission on.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesServingEndpoint
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesSqlWarehouse
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute (see the API docs for full list of supported UC objects)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResourcesUcSecurable
{
    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>the full name of UC securable, i.e. my-catalog.my-schema.my-volume.</summary>
    [JsonPropertyName("securableFullName")]
    public string? SecurableFullName { get; set; }

    /// <summary>the type of UC securable, i.e. VOLUME.</summary>
    [JsonPropertyName("securableType")]
    public string? SecurableType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderResources
{
    [JsonPropertyName("app")]
    public V1beta1AppSpecForProviderResourcesApp? App { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("database")]
    public V1beta1AppSpecForProviderResourcesDatabase? Database { get; set; }

    /// <summary>The description of the app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("experiment")]
    public V1beta1AppSpecForProviderResourcesExperiment? Experiment { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("genieSpace")]
    public V1beta1AppSpecForProviderResourcesGenieSpace? GenieSpace { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("job")]
    public V1beta1AppSpecForProviderResourcesJob? Job { get; set; }

    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("secret")]
    public V1beta1AppSpecForProviderResourcesSecret? Secret { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("servingEndpoint")]
    public V1beta1AppSpecForProviderResourcesServingEndpoint? ServingEndpoint { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("sqlWarehouse")]
    public V1beta1AppSpecForProviderResourcesSqlWarehouse? SqlWarehouse { get; set; }

    /// <summary>attribute (see the API docs for full list of supported UC objects)</summary>
    [JsonPropertyName("ucSecurable")]
    public V1beta1AppSpecForProviderResourcesUcSecurable? UcSecurable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProvider
{
    /// <summary>The Budget Policy ID set for this resource.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>A string specifying compute size for the App. Possible values are MEDIUM, LARGE.</summary>
    [JsonPropertyName("computeSize")]
    public string? ComputeSize { get; set; }

    /// <summary>The description of the app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("gitRepository")]
    public V1beta1AppSpecForProviderGitRepository? GitRepository { get; set; }

    [JsonPropertyName("noCompute")]
    public bool? NoCompute { get; set; }

    [JsonPropertyName("providerConfig")]
    public V1beta1AppSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>A list of resources that the app have access to.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AppSpecForProviderResources>? Resources { get; set; }

    [JsonPropertyName("space")]
    public string? Space { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }

    /// <summary>A list of api scopes granted to the user access token.</summary>
    [JsonPropertyName("userApiScopes")]
    public IList<string>? UserApiScopes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderGitRepository
{
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The URL of the app once it is deployed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderProviderConfig
{
    /// <summary>The unique ID of Genie Space.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesApp
{
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesDatabase
{
    /// <summary>The name of database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of database instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesExperiment
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("experimentId")]
    public string? ExperimentId { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesGenieSpace
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>The unique ID of Genie Space.</summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesJob
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesSecret
{
    /// <summary>Key of the secret to grant permission on.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>Scope of the secret to grant permission on.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesServingEndpoint
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesSqlWarehouse
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute (see the API docs for full list of supported UC objects)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResourcesUcSecurable
{
    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>the full name of UC securable, i.e. my-catalog.my-schema.my-volume.</summary>
    [JsonPropertyName("securableFullName")]
    public string? SecurableFullName { get; set; }

    /// <summary>the type of UC securable, i.e. VOLUME.</summary>
    [JsonPropertyName("securableType")]
    public string? SecurableType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderResources
{
    [JsonPropertyName("app")]
    public V1beta1AppSpecInitProviderResourcesApp? App { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("database")]
    public V1beta1AppSpecInitProviderResourcesDatabase? Database { get; set; }

    /// <summary>The description of the app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("experiment")]
    public V1beta1AppSpecInitProviderResourcesExperiment? Experiment { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("genieSpace")]
    public V1beta1AppSpecInitProviderResourcesGenieSpace? GenieSpace { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("job")]
    public V1beta1AppSpecInitProviderResourcesJob? Job { get; set; }

    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("secret")]
    public V1beta1AppSpecInitProviderResourcesSecret? Secret { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("servingEndpoint")]
    public V1beta1AppSpecInitProviderResourcesServingEndpoint? ServingEndpoint { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("sqlWarehouse")]
    public V1beta1AppSpecInitProviderResourcesSqlWarehouse? SqlWarehouse { get; set; }

    /// <summary>attribute (see the API docs for full list of supported UC objects)</summary>
    [JsonPropertyName("ucSecurable")]
    public V1beta1AppSpecInitProviderResourcesUcSecurable? UcSecurable { get; set; }
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
public partial class V1beta1AppSpecInitProvider
{
    /// <summary>The Budget Policy ID set for this resource.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>A string specifying compute size for the App. Possible values are MEDIUM, LARGE.</summary>
    [JsonPropertyName("computeSize")]
    public string? ComputeSize { get; set; }

    /// <summary>The description of the app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("gitRepository")]
    public V1beta1AppSpecInitProviderGitRepository? GitRepository { get; set; }

    [JsonPropertyName("noCompute")]
    public bool? NoCompute { get; set; }

    [JsonPropertyName("providerConfig")]
    public V1beta1AppSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>A list of resources that the app have access to.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AppSpecInitProviderResources>? Resources { get; set; }

    [JsonPropertyName("space")]
    public string? Space { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }

    /// <summary>A list of api scopes granted to the user access token.</summary>
    [JsonPropertyName("userApiScopes")]
    public IList<string>? UserApiScopes { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppSpecManagementPoliciesEnum>))]
public enum V1beta1AppSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AppSpec defines the desired state of App</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1AppSpecForProvider ForProvider { get; set; }

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
    public V1beta1AppSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AppSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderActiveDeploymentDeploymentArtifacts
{
    [JsonPropertyName("sourceCodePath")]
    public string? SourceCodePath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderActiveDeploymentEnvVars
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderActiveDeploymentGitSourceGitRepository
{
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The URL of the app once it is deployed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderActiveDeploymentGitSource
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    [JsonPropertyName("gitRepository")]
    public V1beta1AppStatusAtProviderActiveDeploymentGitSourceGitRepository? GitRepository { get; set; }

    [JsonPropertyName("resolvedCommit")]
    public string? ResolvedCommit { get; set; }

    [JsonPropertyName("sourceCodePath")]
    public string? SourceCodePath { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderActiveDeploymentStatus
{
    /// <summary>Compute status message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>State of the app compute.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderActiveDeployment
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The creation time of the app.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The email of the user that created the app.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    [JsonPropertyName("deploymentArtifacts")]
    public V1beta1AppStatusAtProviderActiveDeploymentDeploymentArtifacts? DeploymentArtifacts { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; set; }

    [JsonPropertyName("envVars")]
    public IList<V1beta1AppStatusAtProviderActiveDeploymentEnvVars>? EnvVars { get; set; }

    [JsonPropertyName("gitSource")]
    public V1beta1AppStatusAtProviderActiveDeploymentGitSource? GitSource { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("sourceCodePath")]
    public string? SourceCodePath { get; set; }

    [JsonPropertyName("status")]
    public V1beta1AppStatusAtProviderActiveDeploymentStatus? Status { get; set; }

    /// <summary>The update time of the app.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderAppStatus
{
    /// <summary>Compute status message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>State of the app compute.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderComputeStatus
{
    [JsonPropertyName("activeInstances")]
    public double? ActiveInstances { get; set; }

    /// <summary>Compute status message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>State of the app compute.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderGitRepository
{
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The URL of the app once it is deployed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderPendingDeploymentDeploymentArtifacts
{
    [JsonPropertyName("sourceCodePath")]
    public string? SourceCodePath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderPendingDeploymentEnvVars
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderPendingDeploymentGitSourceGitRepository
{
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The URL of the app once it is deployed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderPendingDeploymentGitSource
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    [JsonPropertyName("gitRepository")]
    public V1beta1AppStatusAtProviderPendingDeploymentGitSourceGitRepository? GitRepository { get; set; }

    [JsonPropertyName("resolvedCommit")]
    public string? ResolvedCommit { get; set; }

    [JsonPropertyName("sourceCodePath")]
    public string? SourceCodePath { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderPendingDeploymentStatus
{
    /// <summary>Compute status message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>State of the app compute.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderPendingDeployment
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The creation time of the app.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The email of the user that created the app.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    [JsonPropertyName("deploymentArtifacts")]
    public V1beta1AppStatusAtProviderPendingDeploymentDeploymentArtifacts? DeploymentArtifacts { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; set; }

    [JsonPropertyName("envVars")]
    public IList<V1beta1AppStatusAtProviderPendingDeploymentEnvVars>? EnvVars { get; set; }

    [JsonPropertyName("gitSource")]
    public V1beta1AppStatusAtProviderPendingDeploymentGitSource? GitSource { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("sourceCodePath")]
    public string? SourceCodePath { get; set; }

    [JsonPropertyName("status")]
    public V1beta1AppStatusAtProviderPendingDeploymentStatus? Status { get; set; }

    /// <summary>The update time of the app.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderProviderConfig
{
    /// <summary>The unique ID of Genie Space.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesApp
{
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesDatabase
{
    /// <summary>The name of database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of database instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesExperiment
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("experimentId")]
    public string? ExperimentId { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesGenieSpace
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>The unique ID of Genie Space.</summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesJob
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesSecret
{
    /// <summary>Key of the secret to grant permission on.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>Scope of the secret to grant permission on.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesServingEndpoint
{
    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesSqlWarehouse
{
    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>attribute (see the API docs for full list of supported UC objects)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResourcesUcSecurable
{
    /// <summary>Permission to grant on the secret scope. For secrets, only one permission is allowed. Permission must be one of: READ, WRITE, MANAGE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>the full name of UC securable, i.e. my-catalog.my-schema.my-volume.</summary>
    [JsonPropertyName("securableFullName")]
    public string? SecurableFullName { get; set; }

    [JsonPropertyName("securableKind")]
    public string? SecurableKind { get; set; }

    /// <summary>the type of UC securable, i.e. VOLUME.</summary>
    [JsonPropertyName("securableType")]
    public string? SecurableType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderResources
{
    [JsonPropertyName("app")]
    public V1beta1AppStatusAtProviderResourcesApp? App { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("database")]
    public V1beta1AppStatusAtProviderResourcesDatabase? Database { get; set; }

    /// <summary>The description of the app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("experiment")]
    public V1beta1AppStatusAtProviderResourcesExperiment? Experiment { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("genieSpace")]
    public V1beta1AppStatusAtProviderResourcesGenieSpace? GenieSpace { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("job")]
    public V1beta1AppStatusAtProviderResourcesJob? Job { get; set; }

    /// <summary>The name of the app. The name must contain only lowercase alphanumeric characters and hyphens. It must be unique within the workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("secret")]
    public V1beta1AppStatusAtProviderResourcesSecret? Secret { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("servingEndpoint")]
    public V1beta1AppStatusAtProviderResourcesServingEndpoint? ServingEndpoint { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("sqlWarehouse")]
    public V1beta1AppStatusAtProviderResourcesSqlWarehouse? SqlWarehouse { get; set; }

    /// <summary>attribute (see the API docs for full list of supported UC objects)</summary>
    [JsonPropertyName("ucSecurable")]
    public V1beta1AppStatusAtProviderResourcesUcSecurable? UcSecurable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProvider
{
    [JsonPropertyName("activeDeployment")]
    public V1beta1AppStatusAtProviderActiveDeployment? ActiveDeployment { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("appStatus")]
    public V1beta1AppStatusAtProviderAppStatus? AppStatus { get; set; }

    /// <summary>The Budget Policy ID set for this resource.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>A string specifying compute size for the App. Possible values are MEDIUM, LARGE.</summary>
    [JsonPropertyName("computeSize")]
    public string? ComputeSize { get; set; }

    /// <summary>attribute</summary>
    [JsonPropertyName("computeStatus")]
    public V1beta1AppStatusAtProviderComputeStatus? ComputeStatus { get; set; }

    /// <summary>The creation time of the app.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The email of the user that created the app.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>The default workspace file system path of the source code from which app deployment are created. This field tracks the workspace source code path of the last active deployment.</summary>
    [JsonPropertyName("defaultSourceCodePath")]
    public string? DefaultSourceCodePath { get; set; }

    /// <summary>The description of the app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The effective budget policy ID.</summary>
    [JsonPropertyName("effectiveBudgetPolicyId")]
    public string? EffectiveBudgetPolicyId { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("effectiveUsagePolicyId")]
    public string? EffectiveUsagePolicyId { get; set; }

    /// <summary>A list of effective api scopes granted to the user access token.</summary>
    [JsonPropertyName("effectiveUserApiScopes")]
    public IList<string>? EffectiveUserApiScopes { get; set; }

    [JsonPropertyName("gitRepository")]
    public V1beta1AppStatusAtProviderGitRepository? GitRepository { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("noCompute")]
    public bool? NoCompute { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("oauth2AppClientId")]
    public string? Oauth2AppClientId { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("oauth2AppIntegrationId")]
    public string? Oauth2AppIntegrationId { get; set; }

    [JsonPropertyName("pendingDeployment")]
    public V1beta1AppStatusAtProviderPendingDeployment? PendingDeployment { get; set; }

    [JsonPropertyName("providerConfig")]
    public V1beta1AppStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>A list of resources that the app have access to.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AppStatusAtProviderResources>? Resources { get; set; }

    /// <summary>client_id (application_id) of the app service principal</summary>
    [JsonPropertyName("servicePrincipalClientId")]
    public string? ServicePrincipalClientId { get; set; }

    /// <summary>id of the app service principal</summary>
    [JsonPropertyName("servicePrincipalId")]
    public double? ServicePrincipalId { get; set; }

    /// <summary>name of the app service principal</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    [JsonPropertyName("space")]
    public string? Space { get; set; }

    /// <summary>The update time of the app.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The email of the user that last updated the app.</summary>
    [JsonPropertyName("updater")]
    public string? Updater { get; set; }

    /// <summary>The URL of the app once it is deployed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Id of the SQL warehouse to grant permission on.</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }

    /// <summary>A list of api scopes granted to the user access token.</summary>
    [JsonPropertyName("userApiScopes")]
    public IList<string>? UserApiScopes { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusConditions
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

/// <summary>AppStatus defines the observed state of App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AppStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>App is the Schema for the Apps API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1App : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AppSpec>, IStatus<V1beta1AppStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "App";
    public const string KubeGroup = "apps.databricks.m.crossplane.io";
    public const string KubePluralName = "apps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apps.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "App";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppSpec defines the desired state of App</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AppSpec Spec { get; set; }

    /// <summary>AppStatus defines the observed state of App.</summary>
    [JsonPropertyName("status")]
    public V1beta1AppStatus? Status { get; set; }
}
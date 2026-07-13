#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
/// <summary>IntegrationRuntimeAzureSSIS is the Schema for the IntegrationRuntimeAzureSSISs API. Manages a Data Factory Azure-SSIS Integration Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2IntegrationRuntimeAzureSSISList : IKubernetesObject<V1ListMeta>, IItems<V1beta2IntegrationRuntimeAzureSSIS>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "IntegrationRuntimeAzureSSISList";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "integrationruntimeazuressis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IntegrationRuntimeAzureSSISList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2IntegrationRuntimeAzureSSIS objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2IntegrationRuntimeAzureSSIS> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecDeletionPolicyEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Administrator login password for the SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderCatalogInfoAdministratorPasswordSecretRef
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

/// <summary>A catalog_info block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Administrator login password for the SQL Server.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderCatalogInfoAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>The dual standby Azure-SSIS Integration Runtime pair with SSISDB failover.</summary>
    [JsonPropertyName("dualStandbyPairName")]
    public string? DualStandbyPairName { get; set; }

    /// <summary>The name of SQL elastic pool where the database will be created for the SSIS catalog. Mutually exclusive with pricing_tier.</summary>
    [JsonPropertyName("elasticPoolName")]
    public string? ElasticPoolName { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, S0, S1, S2, S3, S4, S6, S7, S9, S12, P1, P2, P4, P6, P11, P15, GP_S_Gen5_1, GP_S_Gen5_2, GP_S_Gen5_4, GP_S_Gen5_6, GP_S_Gen5_8, GP_S_Gen5_10, GP_S_Gen5_12, GP_S_Gen5_14, GP_S_Gen5_16, GP_S_Gen5_18, GP_S_Gen5_20, GP_S_Gen5_24, GP_S_Gen5_32, GP_S_Gen5_40, GP_Gen5_2, GP_Gen5_4, GP_Gen5_6, GP_Gen5_8, GP_Gen5_10, GP_Gen5_12, GP_Gen5_14, GP_Gen5_16, GP_Gen5_18, GP_Gen5_20, GP_Gen5_24, GP_Gen5_32, GP_Gen5_40, GP_Gen5_80, BC_Gen5_2, BC_Gen5_4, BC_Gen5_6, BC_Gen5_8, BC_Gen5_10, BC_Gen5_12, BC_Gen5_14, BC_Gen5_16, BC_Gen5_18, BC_Gen5_20, BC_Gen5_24, BC_Gen5_32, BC_Gen5_40, BC_Gen5_80, HS_Gen5_2, HS_Gen5_4, HS_Gen5_6, HS_Gen5_8, HS_Gen5_10, HS_Gen5_12, HS_Gen5_14, HS_Gen5_16, HS_Gen5_18, HS_Gen5_20, HS_Gen5_24, HS_Gen5_32, HS_Gen5_40 and HS_Gen5_80. Mutually exclusive with elastic_pool_name.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary>One copy_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderCopyComputeScale
{
    /// <summary>Specifies the data integration unit number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256.</summary>
    [JsonPropertyName("dataIntegrationUnit")]
    public double? DataIntegrationUnit { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScriptSasTokenSecretRef
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

/// <summary>A custom_setup_script block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }

    /// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScriptSasTokenSecretRef? SasTokenSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelector
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
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyKeyVaultPassword
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The password for the target device.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyPasswordSecretRef
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
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKey
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyKeyVaultPassword? KeyVaultPassword { get; set; }

    /// <summary>The password for the target device.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The target computer or domain name.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>The username for the target device.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentKeyVaultLicense
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The license used for the Component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentLicenseSecretRef
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
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponent
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultLicense")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentKeyVaultLicense? KeyVaultLicense { get; set; }

    /// <summary>The license used for the Component.</summary>
    [JsonPropertyName("licenseSecretRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentLicenseSecretRef? LicenseSecretRef { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An express_custom_setup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetup
{
    /// <summary>One or more command_key blocks as defined below.</summary>
    [JsonPropertyName("commandKey")]
    public IList<V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKey>? CommandKey { get; set; }

    /// <summary>One or more component blocks as defined below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponent>? Component { get; set; }

    /// <summary>The Environment Variables for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The version of Azure Powershell installed for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("powershellVersion")]
    public string? PowershellVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelector
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
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A express_vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegration
{
    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderPackageStore
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One pipeline_external_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderPipelineExternalComputeScale
{
    /// <summary>Specifies the number of the external nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfExternalNodes")]
    public double? NumberOfExternalNodes { get; set; }

    /// <summary>Specifies the number of the pipeline nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfPipelineNodes")]
    public double? NumberOfPipelineNodes { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderProxy
{
    /// <summary>The path in the data store to be used when moving data between Self-Hosted and Azure-SSIS Integration Runtimes.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name of Self Hosted Integration Runtime as a proxy.</summary>
    [JsonPropertyName("selfHostedIntegrationRuntimeName")]
    public string? SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>Name of Azure Blob Storage linked service to reference the staging data store to be used when moving data between self-hosted and Azure-SSIS integration runtimes.</summary>
    [JsonPropertyName("stagingStorageLinkedServiceName")]
    public string? StagingStorageLinkedServiceName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelector
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
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelector
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
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegration
{
    /// <summary>Static public IP addresses for the Azure-SSIS Integration Runtime. The size must be 2.</summary>
    [JsonPropertyName("publicIps")]
    public IList<string>? PublicIps { get; set; }

    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Name of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelector? SubnetNameSelector { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecForProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderCatalogInfo? CatalogInfo { get; set; }

    /// <summary>One copy_compute_scale block as defined below.</summary>
    [JsonPropertyName("copyComputeScale")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderCopyComputeScale? CopyComputeScale { get; set; }

    /// <summary>The name of a Data Factory Credential that the SSIS integration will use to access data sources. For example, azurerm_data_factory_credential_user_managed_identity</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScript? CustomSetupScript { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure-SSIS Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>An express_custom_setup block as defined below.</summary>
    [JsonPropertyName("expressCustomSetup")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetup? ExpressCustomSetup { get; set; }

    /// <summary>A express_vnet_integration block as defined below.</summary>
    [JsonPropertyName("expressVnetIntegration")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegration? ExpressVnetIntegration { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Azure-SSIS Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Azure-SSIS Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>One or more package_store block as defined below.</summary>
    [JsonPropertyName("packageStore")]
    public IList<V1beta2IntegrationRuntimeAzureSSISSpecForProviderPackageStore>? PackageStore { get; set; }

    /// <summary>One pipeline_external_compute_scale block as defined below.</summary>
    [JsonPropertyName("pipelineExternalComputeScale")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderPipelineExternalComputeScale? PipelineExternalComputeScale { get; set; }

    /// <summary>A proxy block as defined below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderProxy? Proxy { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public V1beta2IntegrationRuntimeAzureSSISSpecForProviderVnetIntegration? VnetIntegration { get; set; }
}

/// <summary>Administrator login password for the SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfoAdministratorPasswordSecretRef
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

/// <summary>A catalog_info block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Administrator login password for the SQL Server.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfoAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>The dual standby Azure-SSIS Integration Runtime pair with SSISDB failover.</summary>
    [JsonPropertyName("dualStandbyPairName")]
    public string? DualStandbyPairName { get; set; }

    /// <summary>The name of SQL elastic pool where the database will be created for the SSIS catalog. Mutually exclusive with pricing_tier.</summary>
    [JsonPropertyName("elasticPoolName")]
    public string? ElasticPoolName { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, S0, S1, S2, S3, S4, S6, S7, S9, S12, P1, P2, P4, P6, P11, P15, GP_S_Gen5_1, GP_S_Gen5_2, GP_S_Gen5_4, GP_S_Gen5_6, GP_S_Gen5_8, GP_S_Gen5_10, GP_S_Gen5_12, GP_S_Gen5_14, GP_S_Gen5_16, GP_S_Gen5_18, GP_S_Gen5_20, GP_S_Gen5_24, GP_S_Gen5_32, GP_S_Gen5_40, GP_Gen5_2, GP_Gen5_4, GP_Gen5_6, GP_Gen5_8, GP_Gen5_10, GP_Gen5_12, GP_Gen5_14, GP_Gen5_16, GP_Gen5_18, GP_Gen5_20, GP_Gen5_24, GP_Gen5_32, GP_Gen5_40, GP_Gen5_80, BC_Gen5_2, BC_Gen5_4, BC_Gen5_6, BC_Gen5_8, BC_Gen5_10, BC_Gen5_12, BC_Gen5_14, BC_Gen5_16, BC_Gen5_18, BC_Gen5_20, BC_Gen5_24, BC_Gen5_32, BC_Gen5_40, BC_Gen5_80, HS_Gen5_2, HS_Gen5_4, HS_Gen5_6, HS_Gen5_8, HS_Gen5_10, HS_Gen5_12, HS_Gen5_14, HS_Gen5_16, HS_Gen5_18, HS_Gen5_20, HS_Gen5_24, HS_Gen5_32, HS_Gen5_40 and HS_Gen5_80. Mutually exclusive with elastic_pool_name.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary>One copy_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCopyComputeScale
{
    /// <summary>Specifies the data integration unit number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256.</summary>
    [JsonPropertyName("dataIntegrationUnit")]
    public double? DataIntegrationUnit { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScriptSasTokenSecretRef
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

/// <summary>A custom_setup_script block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }

    /// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public required V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScriptSasTokenSecretRef SasTokenSecretRef { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyKeyVaultPassword
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The password for the target device.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyPasswordSecretRef
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
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKey
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyKeyVaultPassword? KeyVaultPassword { get; set; }

    /// <summary>The password for the target device.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The target computer or domain name.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>The username for the target device.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentKeyVaultLicense
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The license used for the Component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentLicenseSecretRef
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
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponent
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultLicense")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentKeyVaultLicense? KeyVaultLicense { get; set; }

    /// <summary>The license used for the Component.</summary>
    [JsonPropertyName("licenseSecretRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentLicenseSecretRef? LicenseSecretRef { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An express_custom_setup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetup
{
    /// <summary>One or more command_key blocks as defined below.</summary>
    [JsonPropertyName("commandKey")]
    public IList<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKey>? CommandKey { get; set; }

    /// <summary>One or more component blocks as defined below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponent>? Component { get; set; }

    /// <summary>The Environment Variables for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The version of Azure Powershell installed for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("powershellVersion")]
    public string? PowershellVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelector
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
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A express_vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegration
{
    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderPackageStore
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One pipeline_external_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderPipelineExternalComputeScale
{
    /// <summary>Specifies the number of the external nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfExternalNodes")]
    public double? NumberOfExternalNodes { get; set; }

    /// <summary>Specifies the number of the pipeline nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfPipelineNodes")]
    public double? NumberOfPipelineNodes { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderProxy
{
    /// <summary>The path in the data store to be used when moving data between Self-Hosted and Azure-SSIS Integration Runtimes.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name of Self Hosted Integration Runtime as a proxy.</summary>
    [JsonPropertyName("selfHostedIntegrationRuntimeName")]
    public string? SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>Name of Azure Blob Storage linked service to reference the staging data store to be used when moving data between self-hosted and Azure-SSIS integration runtimes.</summary>
    [JsonPropertyName("stagingStorageLinkedServiceName")]
    public string? StagingStorageLinkedServiceName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelector
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
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelector
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
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegration
{
    /// <summary>Static public IP addresses for the Azure-SSIS Integration Runtime. The size must be 2.</summary>
    [JsonPropertyName("publicIps")]
    public IList<string>? PublicIps { get; set; }

    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Name of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelector? SubnetNameSelector { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
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
public partial class V1beta2IntegrationRuntimeAzureSSISSpecInitProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfo? CatalogInfo { get; set; }

    /// <summary>One copy_compute_scale block as defined below.</summary>
    [JsonPropertyName("copyComputeScale")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCopyComputeScale? CopyComputeScale { get; set; }

    /// <summary>The name of a Data Factory Credential that the SSIS integration will use to access data sources. For example, azurerm_data_factory_credential_user_managed_identity</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScript? CustomSetupScript { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure-SSIS Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>An express_custom_setup block as defined below.</summary>
    [JsonPropertyName("expressCustomSetup")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetup? ExpressCustomSetup { get; set; }

    /// <summary>A express_vnet_integration block as defined below.</summary>
    [JsonPropertyName("expressVnetIntegration")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegration? ExpressVnetIntegration { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Azure-SSIS Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Azure-SSIS Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>One or more package_store block as defined below.</summary>
    [JsonPropertyName("packageStore")]
    public IList<V1beta2IntegrationRuntimeAzureSSISSpecInitProviderPackageStore>? PackageStore { get; set; }

    /// <summary>One pipeline_external_compute_scale block as defined below.</summary>
    [JsonPropertyName("pipelineExternalComputeScale")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderPipelineExternalComputeScale? PipelineExternalComputeScale { get; set; }

    /// <summary>A proxy block as defined below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderProxy? Proxy { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegration? VnetIntegration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecManagementPoliciesEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>IntegrationRuntimeAzureSSISSpec defines the desired state of IntegrationRuntimeAzureSSIS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISSpec
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
    public V1beta2IntegrationRuntimeAzureSSISSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2IntegrationRuntimeAzureSSISSpecForProvider ForProvider { get; set; }

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
    public V1beta2IntegrationRuntimeAzureSSISSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2IntegrationRuntimeAzureSSISSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2IntegrationRuntimeAzureSSISSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A catalog_info block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The dual standby Azure-SSIS Integration Runtime pair with SSISDB failover.</summary>
    [JsonPropertyName("dualStandbyPairName")]
    public string? DualStandbyPairName { get; set; }

    /// <summary>The name of SQL elastic pool where the database will be created for the SSIS catalog. Mutually exclusive with pricing_tier.</summary>
    [JsonPropertyName("elasticPoolName")]
    public string? ElasticPoolName { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, S0, S1, S2, S3, S4, S6, S7, S9, S12, P1, P2, P4, P6, P11, P15, GP_S_Gen5_1, GP_S_Gen5_2, GP_S_Gen5_4, GP_S_Gen5_6, GP_S_Gen5_8, GP_S_Gen5_10, GP_S_Gen5_12, GP_S_Gen5_14, GP_S_Gen5_16, GP_S_Gen5_18, GP_S_Gen5_20, GP_S_Gen5_24, GP_S_Gen5_32, GP_S_Gen5_40, GP_Gen5_2, GP_Gen5_4, GP_Gen5_6, GP_Gen5_8, GP_Gen5_10, GP_Gen5_12, GP_Gen5_14, GP_Gen5_16, GP_Gen5_18, GP_Gen5_20, GP_Gen5_24, GP_Gen5_32, GP_Gen5_40, GP_Gen5_80, BC_Gen5_2, BC_Gen5_4, BC_Gen5_6, BC_Gen5_8, BC_Gen5_10, BC_Gen5_12, BC_Gen5_14, BC_Gen5_16, BC_Gen5_18, BC_Gen5_20, BC_Gen5_24, BC_Gen5_32, BC_Gen5_40, BC_Gen5_80, HS_Gen5_2, HS_Gen5_4, HS_Gen5_6, HS_Gen5_8, HS_Gen5_10, HS_Gen5_12, HS_Gen5_14, HS_Gen5_16, HS_Gen5_18, HS_Gen5_20, HS_Gen5_24, HS_Gen5_32, HS_Gen5_40 and HS_Gen5_80. Mutually exclusive with elastic_pool_name.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary>One copy_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderCopyComputeScale
{
    /// <summary>Specifies the data integration unit number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256.</summary>
    [JsonPropertyName("dataIntegrationUnit")]
    public double? DataIntegrationUnit { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A custom_setup_script block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKeyKeyVaultPassword
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKey
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKeyKeyVaultPassword? KeyVaultPassword { get; set; }

    /// <summary>The target computer or domain name.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>The username for the target device.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponentKeyVaultLicense
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponent
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultLicense")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponentKeyVaultLicense? KeyVaultLicense { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An express_custom_setup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetup
{
    /// <summary>One or more command_key blocks as defined below.</summary>
    [JsonPropertyName("commandKey")]
    public IList<V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKey>? CommandKey { get; set; }

    /// <summary>One or more component blocks as defined below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponent>? Component { get; set; }

    /// <summary>The Environment Variables for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The version of Azure Powershell installed for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("powershellVersion")]
    public string? PowershellVersion { get; set; }
}

/// <summary>A express_vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressVnetIntegration
{
    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderPackageStore
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One pipeline_external_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderPipelineExternalComputeScale
{
    /// <summary>Specifies the number of the external nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfExternalNodes")]
    public double? NumberOfExternalNodes { get; set; }

    /// <summary>Specifies the number of the pipeline nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfPipelineNodes")]
    public double? NumberOfPipelineNodes { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderProxy
{
    /// <summary>The path in the data store to be used when moving data between Self-Hosted and Azure-SSIS Integration Runtimes.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name of Self Hosted Integration Runtime as a proxy.</summary>
    [JsonPropertyName("selfHostedIntegrationRuntimeName")]
    public string? SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>Name of Azure Blob Storage linked service to reference the staging data store to be used when moving data between self-hosted and Azure-SSIS integration runtimes.</summary>
    [JsonPropertyName("stagingStorageLinkedServiceName")]
    public string? StagingStorageLinkedServiceName { get; set; }
}

/// <summary>A vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProviderVnetIntegration
{
    /// <summary>Static public IP addresses for the Azure-SSIS Integration Runtime. The size must be 2.</summary>
    [JsonPropertyName("publicIps")]
    public IList<string>? PublicIps { get; set; }

    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Name of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusAtProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderCatalogInfo? CatalogInfo { get; set; }

    /// <summary>One copy_compute_scale block as defined below.</summary>
    [JsonPropertyName("copyComputeScale")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderCopyComputeScale? CopyComputeScale { get; set; }

    /// <summary>The name of a Data Factory Credential that the SSIS integration will use to access data sources. For example, azurerm_data_factory_credential_user_managed_identity</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderCustomSetupScript? CustomSetupScript { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure-SSIS Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>An express_custom_setup block as defined below.</summary>
    [JsonPropertyName("expressCustomSetup")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetup? ExpressCustomSetup { get; set; }

    /// <summary>A express_vnet_integration block as defined below.</summary>
    [JsonPropertyName("expressVnetIntegration")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderExpressVnetIntegration? ExpressVnetIntegration { get; set; }

    /// <summary>The ID of the Data Factory Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Azure-SSIS Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Azure-SSIS Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>One or more package_store block as defined below.</summary>
    [JsonPropertyName("packageStore")]
    public IList<V1beta2IntegrationRuntimeAzureSSISStatusAtProviderPackageStore>? PackageStore { get; set; }

    /// <summary>One pipeline_external_compute_scale block as defined below.</summary>
    [JsonPropertyName("pipelineExternalComputeScale")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderPipelineExternalComputeScale? PipelineExternalComputeScale { get; set; }

    /// <summary>A proxy block as defined below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderProxy? Proxy { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProviderVnetIntegration? VnetIntegration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatusConditions
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

/// <summary>IntegrationRuntimeAzureSSISStatus defines the observed state of IntegrationRuntimeAzureSSIS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IntegrationRuntimeAzureSSISStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2IntegrationRuntimeAzureSSISStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2IntegrationRuntimeAzureSSISStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IntegrationRuntimeAzureSSIS is the Schema for the IntegrationRuntimeAzureSSISs API. Manages a Data Factory Azure-SSIS Integration Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2IntegrationRuntimeAzureSSIS : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2IntegrationRuntimeAzureSSISSpec>, IStatus<V1beta2IntegrationRuntimeAzureSSISStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "IntegrationRuntimeAzureSSIS";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "integrationruntimeazuressis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IntegrationRuntimeAzureSSIS";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IntegrationRuntimeAzureSSISSpec defines the desired state of IntegrationRuntimeAzureSSIS</summary>
    [JsonPropertyName("spec")]
    public required V1beta2IntegrationRuntimeAzureSSISSpec Spec { get; set; }

    /// <summary>IntegrationRuntimeAzureSSISStatus defines the observed state of IntegrationRuntimeAzureSSIS.</summary>
    [JsonPropertyName("status")]
    public V1beta2IntegrationRuntimeAzureSSISStatus? Status { get; set; }
}
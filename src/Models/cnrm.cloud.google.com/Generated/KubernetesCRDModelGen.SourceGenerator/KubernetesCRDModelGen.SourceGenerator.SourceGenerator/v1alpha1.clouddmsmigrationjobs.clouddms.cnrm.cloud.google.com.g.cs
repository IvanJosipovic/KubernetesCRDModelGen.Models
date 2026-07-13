#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddms.cnrm.cloud.google.com;
/// <summary>CloudDMSMigrationJob is the Schema for the CloudDMSMigrationJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSMigrationJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDMSMigrationJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSMigrationJobList";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsmigrationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddms.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDMSMigrationJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudDMSMigrationJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudDMSMigrationJob> Items { get; set; }
}

/// <summary>The CMEK (customer-managed encryption key) fully qualified key name used for the migration job. This field supports all migration jobs types except for: * Mysql to Mysql (use the cmek field in the cloudsql connection profile instead). * PostrgeSQL to PostgreSQL (use the cmek field in the cloudsql connection profile instead). * PostgreSQL to AlloyDB (use the kms_key_name field in the alloydb connection profile instead). Each Cloud CMEK key has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecCmekKeyNameRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The conversion workspace used by the migration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecConversionWorkspace
{
    /// <summary>The commit ID of the conversion workspace.</summary>
    [JsonPropertyName("commitID")]
    public string? CommitID { get; set; }

    /// <summary>The resource name (URI) of the conversion workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The database engine type and provider of the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecDestinationDatabase
{
    /// <summary>The database engine.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The database provider.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}

/// <summary>Required. The Connection Profile of the destination connection profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecDestinationRef
{
    /// <summary>A reference to an externally managed CloudDMSConnectionProfile resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/connectionProfiles/{{connectionProfileID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudDMSConnectionProfile resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudDMSConnectionProfile resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecDumpFlagsDumpFlags
{
    /// <summary>The name of the flag</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the flag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The initial dump flags. This field and the &quot;dump_path&quot; field are mutually exclusive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecDumpFlags
{
    /// <summary>The flags for the initial dump.</summary>
    [JsonPropertyName("dumpFlags")]
    public IList<V1alpha1CloudDMSMigrationJobSpecDumpFlagsDumpFlags>? DumpFlags { get; set; }
}

/// <summary>Optional. Data dump parallelism settings used by the migration. Currently applicable only for MySQL to Cloud SQL for MySQL migrations only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecPerformanceConfig
{
    /// <summary>Initial dump parallelism level.</summary>
    [JsonPropertyName("dumpParallelLevel")]
    public string? DumpParallelLevel { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecReverseSSHConnectivityVmRef
{
    /// <summary>A reference to an externally managed ComputeInstance resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/instances/{{instanceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the VPC to peer with the Cloud SQL private network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecReverseSSHConnectivityVpcRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The details needed to communicate to the source over Reverse SSH tunnel connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecReverseSSHConnectivity
{
    /// <summary>Required. The IP of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
    [JsonPropertyName("vmIP")]
    public string? VmIP { get; set; }

    /// <summary>Required. The forwarding port of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
    [JsonPropertyName("vmPort")]
    public int? VmPort { get; set; }

    /// <summary>The name of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
    [JsonPropertyName("vmRef")]
    public V1alpha1CloudDMSMigrationJobSpecReverseSSHConnectivityVmRef? VmRef { get; set; }

    /// <summary>The name of the VPC to peer with the Cloud SQL private network.</summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1CloudDMSMigrationJobSpecReverseSSHConnectivityVpcRef? VpcRef { get; set; }
}

/// <summary>The database engine type and provider of the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecSourceDatabase
{
    /// <summary>The database engine.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The database provider.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}

/// <summary>Required. The Connection Profile resource of the source connection profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecSourceRef
{
    /// <summary>A reference to an externally managed CloudDMSConnectionProfile resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/connectionProfiles/{{connectionProfileID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudDMSConnectionProfile resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudDMSConnectionProfile resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>static ip connectivity data (default, no additional details needed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecStaticIPConnectivity
{
}

/// <summary>The name of the VPC network to peer with the Cloud SQL private network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecVpcPeeringConnectivityVpcRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The details of the VPC network that the source database is located in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpecVpcPeeringConnectivity
{
    /// <summary>The name of the VPC network to peer with the Cloud SQL private network.</summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1CloudDMSMigrationJobSpecVpcPeeringConnectivityVpcRef? VpcRef { get; set; }
}

/// <summary>CloudDMSMigrationJobSpec defines the desired state of CloudDMSMigrationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobSpec
{
    /// <summary>The CMEK (customer-managed encryption key) fully qualified key name used for the migration job. This field supports all migration jobs types except for: * Mysql to Mysql (use the cmek field in the cloudsql connection profile instead). * PostrgeSQL to PostgreSQL (use the cmek field in the cloudsql connection profile instead). * PostgreSQL to AlloyDB (use the kms_key_name field in the alloydb connection profile instead). Each Cloud CMEK key has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
    [JsonPropertyName("cmekKeyNameRef")]
    public V1alpha1CloudDMSMigrationJobSpecCmekKeyNameRef? CmekKeyNameRef { get; set; }

    /// <summary>The conversion workspace used by the migration.</summary>
    [JsonPropertyName("conversionWorkspace")]
    public V1alpha1CloudDMSMigrationJobSpecConversionWorkspace? ConversionWorkspace { get; set; }

    /// <summary>The database engine type and provider of the destination.</summary>
    [JsonPropertyName("destinationDatabase")]
    public V1alpha1CloudDMSMigrationJobSpecDestinationDatabase? DestinationDatabase { get; set; }

    /// <summary>Required. The Connection Profile of the destination connection profile.</summary>
    [JsonPropertyName("destinationRef")]
    public V1alpha1CloudDMSMigrationJobSpecDestinationRef? DestinationRef { get; set; }

    /// <summary>The migration job display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The initial dump flags. This field and the &quot;dump_path&quot; field are mutually exclusive.</summary>
    [JsonPropertyName("dumpFlags")]
    public V1alpha1CloudDMSMigrationJobSpecDumpFlags? DumpFlags { get; set; }

    /// <summary>The path to the dump file in Google Cloud Storage, in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]). This field and the &quot;dump_flags&quot; field are mutually exclusive.</summary>
    [JsonPropertyName("dumpPath")]
    public string? DumpPath { get; set; }

    /// <summary>This field can be used to select the entities to migrate as part of the migration job. It uses AIP-160 notation to select a subset of the entities configured on the associated conversion-workspace. This field should not be set on migration-jobs that are not associated with a conversion workspace.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The location that this resource belongs to.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Data dump parallelism settings used by the migration. Currently applicable only for MySQL to Cloud SQL for MySQL migrations only.</summary>
    [JsonPropertyName("performanceConfig")]
    public V1alpha1CloudDMSMigrationJobSpecPerformanceConfig? PerformanceConfig { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudDMSMigrationJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CloudDMSMigrationJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The details needed to communicate to the source over Reverse SSH tunnel connectivity.</summary>
    [JsonPropertyName("reverseSSHConnectivity")]
    public V1alpha1CloudDMSMigrationJobSpecReverseSSHConnectivity? ReverseSSHConnectivity { get; set; }

    /// <summary>The database engine type and provider of the source.</summary>
    [JsonPropertyName("sourceDatabase")]
    public V1alpha1CloudDMSMigrationJobSpecSourceDatabase? SourceDatabase { get; set; }

    /// <summary>Required. The Connection Profile resource of the source connection profile.</summary>
    [JsonPropertyName("sourceRef")]
    public V1alpha1CloudDMSMigrationJobSpecSourceRef? SourceRef { get; set; }

    /// <summary>static ip connectivity data (default, no additional details needed).</summary>
    [JsonPropertyName("staticIPConnectivity")]
    public V1alpha1CloudDMSMigrationJobSpecStaticIPConnectivity? StaticIPConnectivity { get; set; }

    /// <summary>Required. The migration job type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The details of the VPC network that the source database is located in.</summary>
    [JsonPropertyName("vpcPeeringConnectivity")]
    public V1alpha1CloudDMSMigrationJobSpecVpcPeeringConnectivity? VpcPeeringConnectivity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobStatusObservedState
{
}

/// <summary>CloudDMSMigrationJobStatus defines the config connector machine state of CloudDMSMigrationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSMigrationJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDMSMigrationJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudDMSMigrationJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDMSMigrationJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudDMSMigrationJob is the Schema for the CloudDMSMigrationJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSMigrationJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDMSMigrationJobSpec>, IStatus<V1alpha1CloudDMSMigrationJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSMigrationJob";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsmigrationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddms.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDMSMigrationJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudDMSMigrationJobSpec defines the desired state of CloudDMSMigrationJob</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudDMSMigrationJobSpec Spec { get; set; }

    /// <summary>CloudDMSMigrationJobStatus defines the config connector machine state of CloudDMSMigrationJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDMSMigrationJobStatus? Status { get; set; }
}
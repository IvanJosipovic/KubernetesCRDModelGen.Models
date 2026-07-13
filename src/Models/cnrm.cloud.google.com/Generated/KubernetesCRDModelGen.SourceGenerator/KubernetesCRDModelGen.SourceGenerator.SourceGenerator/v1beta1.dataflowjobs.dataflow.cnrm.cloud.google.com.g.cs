#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataflow.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataflowJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataflowJob>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataflowJobList";
    public const string KubeGroup = "dataflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dataflowjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataflow.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataflowJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DataflowJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DataflowJob> Items { get; set; }
}

/// <summary>The name for the Cloud KMS key for the job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowJobSpecKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
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
public partial class V1beta1DataflowJobSpecNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
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
public partial class V1beta1DataflowJobSpecServiceAccountRef
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
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
public partial class V1beta1DataflowJobSpecSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
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
public partial class V1beta1DataflowJobSpec
{
    /// <summary>List of experiments that should be used by the job. An example value is [&quot;enable_stackdriver_agent_metrics&quot;].</summary>
    [JsonPropertyName("additionalExperiments")]
    public IList<string>? AdditionalExperiments { get; set; }

    /// <summary>Indicates if the job should use the streaming engine feature.</summary>
    [JsonPropertyName("enableStreamingEngine")]
    public bool? EnableStreamingEngine { get; set; }

    /// <summary>The configuration for VM IPs. Options are &quot;WORKER_IP_PUBLIC&quot; or &quot;WORKER_IP_PRIVATE&quot;.</summary>
    [JsonPropertyName("ipConfiguration")]
    public string? IpConfiguration { get; set; }

    /// <summary>The name for the Cloud KMS key for the job.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1DataflowJobSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>The machine type to use for the job.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. The number of workers permitted to work on the job. More workers may improve processing speed at additional cost.</summary>
    [JsonPropertyName("maxWorkers")]
    public int? MaxWorkers { get; set; }

    [JsonPropertyName("networkRef")]
    public V1beta1DataflowJobSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Key/Value pairs to be passed to the Dataflow job (as used in the template).</summary>
    [JsonPropertyName("parameters")]
    public JsonNode? Parameters { get; set; }

    /// <summary>Immutable. The region in which the created job should run.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    [JsonPropertyName("serviceAccountRef")]
    public V1beta1DataflowJobSpecServiceAccountRef? ServiceAccountRef { get; set; }

    [JsonPropertyName("subnetworkRef")]
    public V1beta1DataflowJobSpecSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>A writeable location on Google Cloud Storage for the Dataflow job to dump its temporary data.</summary>
    [JsonPropertyName("tempGcsLocation")]
    public required string TempGcsLocation { get; set; }

    /// <summary>The Google Cloud Storage path to the Dataflow job template.</summary>
    [JsonPropertyName("templateGcsPath")]
    public required string TemplateGcsPath { get; set; }

    /// <summary>Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job.</summary>
    [JsonPropertyName("transformNameMapping")]
    public JsonNode? TransformNameMapping { get; set; }

    /// <summary>Immutable. The zone in which the created job should run. If it is not provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowJobStatusConditions
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
public partial class V1beta1DataflowJobStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataflowJobStatusConditions>? Conditions { get; set; }

    /// <summary>The unique ID of this job.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The current state of the resource, selected from the JobState enum.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The type of this job, selected from the JobType enum.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataflowJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataflowJobSpec>, IStatus<V1beta1DataflowJobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataflowJob";
    public const string KubeGroup = "dataflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dataflowjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataflow.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataflowJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1DataflowJobSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1DataflowJobStatus? Status { get; set; }
}
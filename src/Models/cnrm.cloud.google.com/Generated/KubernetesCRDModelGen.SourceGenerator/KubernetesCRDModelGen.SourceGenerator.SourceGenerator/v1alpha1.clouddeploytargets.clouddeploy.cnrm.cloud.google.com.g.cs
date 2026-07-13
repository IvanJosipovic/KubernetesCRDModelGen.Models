#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddeploy.cnrm.cloud.google.com;
/// <summary>CloudDeployTarget is the Schema for the CloudDeployTarget API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployTargetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDeployTarget>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployTargetList";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploytargets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddeploy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDeployTargetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudDeployTarget objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudDeployTarget> Items { get; set; }
}

/// <summary>Optional. Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecAnthosClusterMembershipRef
{
    /// <summary>The name of the membership. Allowed value: The Google Cloud resource name of a `GKEHubMembership` resource (format: `projects/{{project}}/locations/{{location}}/memberships/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Information specifying an Anthos Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecAnthosCluster
{
    /// <summary>Optional. Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.</summary>
    [JsonPropertyName("membershipRef")]
    public V1alpha1CloudDeployTargetSpecAnthosClusterMembershipRef? MembershipRef { get; set; }
}

/// <summary>Optional. Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecAssociatedEntitiesAnthosClustersMembershipRef
{
    /// <summary>The name of the membership. Allowed value: The Google Cloud resource name of a `GKEHubMembership` resource (format: `projects/{{project}}/locations/{{location}}/memberships/{{name}}`).</summary>
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
public partial class V1alpha1CloudDeployTargetSpecAssociatedEntitiesAnthosClusters
{
    /// <summary>Optional. Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.</summary>
    [JsonPropertyName("membershipRef")]
    public V1alpha1CloudDeployTargetSpecAssociatedEntitiesAnthosClustersMembershipRef? MembershipRef { get; set; }
}

/// <summary>Optional. Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecAssociatedEntitiesGkeClustersClusterRef
{
    /// <summary>The GKE cluster. Valid formats: `projects/{projectID}/locations/{location}/clusters/{clusterID}` `projects/{projectID}/zones/{zone}/clusters/{clusterID}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names */</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ */</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecAssociatedEntitiesGkeClusters
{
    /// <summary>Optional. Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`.</summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1CloudDeployTargetSpecAssociatedEntitiesGkeClustersClusterRef? ClusterRef { get; set; }

    /// <summary>Optional. If set, the cluster will be accessed using the DNS endpoint. Note that both `dns_endpoint` and `internal_ip` cannot be set to true.</summary>
    [JsonPropertyName("dnsEndpoint")]
    public bool? DnsEndpoint { get; set; }

    /// <summary>
    /// Optional. If true, `cluster` is accessed using the private IP address of
    ///  the control plane endpoint. Otherwise, the default IP address of the
    ///  control plane endpoint is used. The default IP address is the private IP
    ///  address for clusters with private control-plane endpoints and the public IP
    ///  address otherwise.
    /// 
    ///  Only specify this option when `cluster` is a [private GKE
    ///  cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept).
    ///  Note that `internal_ip` and `dns_endpoint` cannot both be set to true.
    /// </summary>
    [JsonPropertyName("internalIP")]
    public bool? InternalIP { get; set; }

    /// <summary>Optional. If set, used to configure a [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the Kubernetes server.</summary>
    [JsonPropertyName("proxyURL")]
    public string? ProxyURL { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecAssociatedEntities
{
    /// <summary>Optional. Information specifying Anthos clusters as associated entities.</summary>
    [JsonPropertyName("anthosClusters")]
    public IList<V1alpha1CloudDeployTargetSpecAssociatedEntitiesAnthosClusters>? AnthosClusters { get; set; }

    /// <summary>Optional. Information specifying GKE clusters as associated entities.</summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1alpha1CloudDeployTargetSpecAssociatedEntitiesGkeClusters>? GkeClusters { get; set; }
}

/// <summary>Required. The name of the CustomTargetType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecCustomTargetCustomTargetTypeRef
{
    /// <summary>A reference to an externally managed CloudDeployCustomTargetType resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/customtargettypes/{{customtargettypeID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudDeployCustomTargetType resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudDeployCustomTargetType resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Information specifying a custom target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecCustomTarget
{
    /// <summary>Required. The name of the CustomTargetType.</summary>
    [JsonPropertyName("customTargetTypeRef")]
    public V1alpha1CloudDeployTargetSpecCustomTargetCustomTargetTypeRef? CustomTargetTypeRef { get; set; }
}

/// <summary>Optional. Google service account to use for execution. If unspecified, the project execution service account (&lt;PROJECT_NUMBER&gt;-compute@developer.gserviceaccount.com) will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigsDefaultPoolServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Use default Cloud Build pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigsDefaultPool
{
    /// <summary>Optional. Cloud Storage location where execution outputs should be stored. This can either be a bucket (&quot;gs://my-bucket&quot;) or a path within a bucket (&quot;gs://my-bucket/my-dir&quot;). If unspecified, a default bucket located in the same region will be used.</summary>
    [JsonPropertyName("artifactStorage")]
    public string? ArtifactStorage { get; set; }

    /// <summary>Optional. Google service account to use for execution. If unspecified, the project execution service account (&lt;PROJECT_NUMBER&gt;-compute@developer.gserviceaccount.com) will be used.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1CloudDeployTargetSpecExecutionConfigsDefaultPoolServiceAccountRef? ServiceAccountRef { get; set; }
}

/// <summary>Optional. Google service account to use for execution. If unspecified, the project execution service account (&lt;PROJECT_NUMBER&gt;-compute@developer.gserviceaccount.com) will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigsPrivatePoolServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Resource name of the Cloud Build worker pool to use. The format is `projects/{project}/locations/{location}/workerPools/{pool}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigsPrivatePoolWorkerPoolRef
{
    /// <summary>A reference to an externally managed CloudBuildWorkerPool resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/workerPools/{{workerPoolID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudBuildWorkerPool resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudBuildWorkerPool resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Use private Cloud Build pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigsPrivatePool
{
    /// <summary>Optional. Cloud Storage location where execution outputs should be stored. This can either be a bucket (&quot;gs://my-bucket&quot;) or a path within a bucket (&quot;gs://my-bucket/my-dir&quot;). If unspecified, a default bucket located in the same region will be used.</summary>
    [JsonPropertyName("artifactStorage")]
    public string? ArtifactStorage { get; set; }

    /// <summary>Optional. Google service account to use for execution. If unspecified, the project execution service account (&lt;PROJECT_NUMBER&gt;-compute@developer.gserviceaccount.com) will be used.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1CloudDeployTargetSpecExecutionConfigsPrivatePoolServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Required. Resource name of the Cloud Build worker pool to use. The format is `projects/{project}/locations/{location}/workerPools/{pool}`.</summary>
    [JsonPropertyName("workerPoolRef")]
    public V1alpha1CloudDeployTargetSpecExecutionConfigsPrivatePoolWorkerPoolRef? WorkerPoolRef { get; set; }
}

/// <summary>Optional. Google service account to use for execution. If unspecified, the project execution service account (&lt;PROJECT_NUMBER&gt;-compute@developer.gserviceaccount.com) is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigsServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The resource name of the `WorkerPool`, with the format `projects/{project}/locations/{location}/workerPools/{worker_pool}`. If this optional field is unspecified, the default Cloud Build pool will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigsWorkerPoolRef
{
    /// <summary>A reference to an externally managed CloudBuildWorkerPool resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/workerPools/{{workerPoolID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudBuildWorkerPool resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudBuildWorkerPool resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecExecutionConfigs
{
    /// <summary>Optional. Cloud Storage location in which to store execution outputs. This can either be a bucket (&quot;gs://my-bucket&quot;) or a path within a bucket (&quot;gs://my-bucket/my-dir&quot;). If unspecified, a default bucket located in the same region will be used.</summary>
    [JsonPropertyName("artifactStorage")]
    public string? ArtifactStorage { get; set; }

    /// <summary>Optional. Use default Cloud Build pool.</summary>
    [JsonPropertyName("defaultPool")]
    public V1alpha1CloudDeployTargetSpecExecutionConfigsDefaultPool? DefaultPool { get; set; }

    /// <summary>Optional. Execution timeout for a Cloud Build Execution. This must be between 10m and 24h in seconds format. If unspecified, a default timeout of 1h is used.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }

    /// <summary>Optional. Use private Cloud Build pool.</summary>
    [JsonPropertyName("privatePool")]
    public V1alpha1CloudDeployTargetSpecExecutionConfigsPrivatePool? PrivatePool { get; set; }

    /// <summary>Optional. Google service account to use for execution. If unspecified, the project execution service account (&lt;PROJECT_NUMBER&gt;-compute@developer.gserviceaccount.com) is used.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1CloudDeployTargetSpecExecutionConfigsServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Required. Usages when this configuration should be applied.</summary>
    [JsonPropertyName("usages")]
    public IList<string>? Usages { get; set; }

    /// <summary>Optional. If true, additional logging will be enabled when running builds in this execution environment.</summary>
    [JsonPropertyName("verbose")]
    public bool? Verbose { get; set; }

    /// <summary>Optional. The resource name of the `WorkerPool`, with the format `projects/{project}/locations/{location}/workerPools/{worker_pool}`. If this optional field is unspecified, the default Cloud Build pool will be used.</summary>
    [JsonPropertyName("workerPoolRef")]
    public V1alpha1CloudDeployTargetSpecExecutionConfigsWorkerPoolRef? WorkerPoolRef { get; set; }
}

/// <summary>Optional. Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecGkeClusterRef
{
    /// <summary>The GKE cluster. Valid formats: `projects/{projectID}/locations/{location}/clusters/{clusterID}` `projects/{projectID}/zones/{zone}/clusters/{clusterID}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names */</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ */</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Information specifying a GKE Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecGke
{
    /// <summary>Optional. Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`.</summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1CloudDeployTargetSpecGkeClusterRef? ClusterRef { get; set; }

    /// <summary>Optional. If set, the cluster will be accessed using the DNS endpoint. Note that both `dns_endpoint` and `internal_ip` cannot be set to true.</summary>
    [JsonPropertyName("dnsEndpoint")]
    public bool? DnsEndpoint { get; set; }

    /// <summary>
    /// Optional. If true, `cluster` is accessed using the private IP address of
    ///  the control plane endpoint. Otherwise, the default IP address of the
    ///  control plane endpoint is used. The default IP address is the private IP
    ///  address for clusters with private control-plane endpoints and the public IP
    ///  address otherwise.
    /// 
    ///  Only specify this option when `cluster` is a [private GKE
    ///  cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept).
    ///  Note that `internal_ip` and `dns_endpoint` cannot both be set to true.
    /// </summary>
    [JsonPropertyName("internalIP")]
    public bool? InternalIP { get; set; }

    /// <summary>Optional. If set, used to configure a [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the Kubernetes server.</summary>
    [JsonPropertyName("proxyURL")]
    public string? ProxyURL { get; set; }
}

/// <summary>A resource reference to CloudDeployTarget, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecMultiTargetTargetRefs
{
    /// <summary>A reference to an externally managed CloudDeployTarget resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/targets/{{targetID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudDeployTarget resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Information specifying a multi-target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecMultiTarget
{
    /// <summary>Required. The target_ids of this multiTarget.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha1CloudDeployTargetSpecMultiTargetTargetRefs>? TargetRefs { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecProjectRef
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

/// <summary>Information specifying a Cloud Run deployment target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpecRun
{
    /// <summary>Required. The location for the Cloud Run Service. Format must be `projects/{project}/locations/{location}`.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>CloudDeployTargetSpec defines the desired state of CloudDeployTarget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetSpec
{
    /// <summary>Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Information specifying an Anthos Cluster.</summary>
    [JsonPropertyName("anthosCluster")]
    public V1alpha1CloudDeployTargetSpecAnthosCluster? AnthosCluster { get; set; }

    /// <summary>Optional. The associations between the Target and other entities.</summary>
    [JsonPropertyName("associatedEntities")]
    public IDictionary<string, V1alpha1CloudDeployTargetSpecAssociatedEntities>? AssociatedEntities { get; set; }

    /// <summary>Information specifying a custom target.</summary>
    [JsonPropertyName("customTarget")]
    public V1alpha1CloudDeployTargetSpecCustomTarget? CustomTarget { get; set; }

    /// <summary>Optional. The deploy parameters to use for this target.</summary>
    [JsonPropertyName("deployParameters")]
    public IDictionary<string, string>? DeployParameters { get; set; }

    /// <summary>Optional. Description of the `Target`. Max length is 255 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Configurations for all execution that relates to this `Target`. Each `ExecutionEnvironmentUsage` value may only be used in a single configuration; using the same value multiple times is an error. When one or more configurations are specified, they must include the `RENDER` and `DEPLOY` `ExecutionEnvironmentUsage` values. When no configurations are specified, execution will use the default specified in `DefaultPool`.</summary>
    [JsonPropertyName("executionConfigs")]
    public IList<V1alpha1CloudDeployTargetSpecExecutionConfigs>? ExecutionConfigs { get; set; }

    /// <summary>Information specifying a GKE Cluster.</summary>
    [JsonPropertyName("gke")]
    public V1alpha1CloudDeployTargetSpecGke? Gke { get; set; }

    /// <summary>Immutable. The location where the Target should reside.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Information specifying a multi-target.</summary>
    [JsonPropertyName("multiTarget")]
    public V1alpha1CloudDeployTargetSpecMultiTarget? MultiTarget { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudDeployTargetSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. Whether or not the `Target` requires approval.</summary>
    [JsonPropertyName("requireApproval")]
    public bool? RequireApproval { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Information specifying a Cloud Run deployment target.</summary>
    [JsonPropertyName("run")]
    public V1alpha1CloudDeployTargetSpecRun? Run { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetStatusConditions
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
public partial class V1alpha1CloudDeployTargetStatusObservedState
{
    /// <summary>Output only. Time at which the `Target` was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Resource id of the `Target`.</summary>
    [JsonPropertyName("targetID")]
    public string? TargetID { get; set; }

    /// <summary>Output only. Unique identifier of the `Target`.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Most recent time at which the `Target` was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CloudDeployTargetStatus defines the config connector machine state of CloudDeployTarget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployTargetStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDeployTargetStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudDeployTarget resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDeployTargetStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudDeployTarget is the Schema for the CloudDeployTarget API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployTarget : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDeployTargetSpec>, IStatus<V1alpha1CloudDeployTargetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployTarget";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploytargets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddeploy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDeployTarget";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudDeployTargetSpec defines the desired state of CloudDeployTarget</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudDeployTargetSpec Spec { get; set; }

    /// <summary>CloudDeployTargetStatus defines the config connector machine state of CloudDeployTarget</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDeployTargetStatus? Status { get; set; }
}
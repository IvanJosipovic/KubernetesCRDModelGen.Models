#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gkehub.cnrm.cloud.google.com;
/// <summary>GKEHubFeatureMembership is the Schema for the gkehub API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GKEHubFeatureMembershipList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GKEHubFeatureMembership>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GKEHubFeatureMembershipList";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubfeaturememberships";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gkehub.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GKEHubFeatureMembershipList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1GKEHubFeatureMembership objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1GKEHubFeatureMembership> Items { get; set; }
}

/// <summary>**DEPRECATED** Binauthz configuration for the cluster. This field will be ignored and should not be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementBinauthz
{
    /// <summary>Whether binauthz is enabled in this cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncGitGcpServiceAccountRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncGit
{
    [JsonPropertyName("gcpServiceAccountRef")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncGitGcpServiceAccountRef? GcpServiceAccountRef { get; set; }

    /// <summary>URL for the HTTPS proxy to be used when communicating with the Git repo.</summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary>The path within the Git repository that represents the top level of the repo to sync. Default: the root directory of the repository.</summary>
    [JsonPropertyName("policyDir")]
    public string? PolicyDir { get; set; }

    /// <summary>Type of secret configured for access to the Git repo. Must be one of ssh, cookiefile, gcenode, token, gcpserviceaccount or none. The validation of this is case-sensitive.</summary>
    [JsonPropertyName("secretType")]
    public string? SecretType { get; set; }

    /// <summary>The branch of the repository to sync from. Default: master.</summary>
    [JsonPropertyName("syncBranch")]
    public string? SyncBranch { get; set; }

    /// <summary>The URL of the Git repository to use as the source of truth.</summary>
    [JsonPropertyName("syncRepo")]
    public string? SyncRepo { get; set; }

    /// <summary>Git revision (tag or hash) to check out. Default HEAD.</summary>
    [JsonPropertyName("syncRev")]
    public string? SyncRev { get; set; }

    /// <summary>Period in seconds between consecutive syncs. Default: 15.</summary>
    [JsonPropertyName("syncWaitSecs")]
    public string? SyncWaitSecs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncMetricsGcpServiceAccountRef
{
    /// <summary>The Email of the Google Cloud Service Account (GSA) used for exporting Config Sync metrics to Cloud Monitoring. The GSA should have the Monitoring Metric Writer(roles/monitoring.metricWriter) IAM role. The Kubernetes ServiceAccount `default` in the namespace `config-management-monitoring` should be bound to the GSA. Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
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
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncOciGcpServiceAccountRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncOci
{
    [JsonPropertyName("gcpServiceAccountRef")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncOciGcpServiceAccountRef? GcpServiceAccountRef { get; set; }

    /// <summary>The absolute path of the directory that contains the local resources. Default: the root directory of the image.</summary>
    [JsonPropertyName("policyDir")]
    public string? PolicyDir { get; set; }

    /// <summary>Type of secret configured for access to the OCI Image. Must be one of gcenode, gcpserviceaccount or none. The validation of this is case-sensitive.</summary>
    [JsonPropertyName("secretType")]
    public string? SecretType { get; set; }

    /// <summary>The OCI image repository URL for the package to sync from. e.g. LOCATION-docker.pkg.dev/PROJECT_ID/REPOSITORY_NAME/PACKAGE_NAME.</summary>
    [JsonPropertyName("syncRepo")]
    public string? SyncRepo { get; set; }

    /// <summary>Period in seconds(int64 format) between consecutive syncs. Default: 15.</summary>
    [JsonPropertyName("syncWaitSecs")]
    public string? SyncWaitSecs { get; set; }
}

/// <summary>Config Sync configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSync
{
    [JsonPropertyName("git")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncGit? Git { get; set; }

    [JsonPropertyName("metricsGcpServiceAccountRef")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncMetricsGcpServiceAccountRef? MetricsGcpServiceAccountRef { get; set; }

    [JsonPropertyName("oci")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSyncOci? Oci { get; set; }

    /// <summary>Set to true to enable the Config Sync admission webhook to prevent drifts. If set to `false`, disables the Config Sync admission webhook and does not prevent drifts.</summary>
    [JsonPropertyName("preventDrift")]
    public bool? PreventDrift { get; set; }

    /// <summary>Specifies whether the Config Sync Repo is in &quot;hierarchical&quot; or &quot;unstructured&quot; mode.</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>Set to true to stop syncing configurations for a single cluster. This field is only available on clusters using Config Sync auto-upgrades or on Config Sync version 1.20.0 or later. Defaults: false.</summary>
    [JsonPropertyName("stopSyncing")]
    public bool? StopSyncing { get; set; }
}

/// <summary>Hierarchy Controller is no longer available. Use https://github.com/kubernetes-sigs/hierarchical-namespaces instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementHierarchyController
{
    /// <summary>Whether hierarchical resource quota is enabled in this cluster.</summary>
    [JsonPropertyName("enableHierarchicalResourceQuota")]
    public bool? EnableHierarchicalResourceQuota { get; set; }

    /// <summary>Whether pod tree labels are enabled in this cluster.</summary>
    [JsonPropertyName("enablePodTreeLabels")]
    public bool? EnablePodTreeLabels { get; set; }

    /// <summary>Whether Hierarchy Controller is enabled in this cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Specifies the backends Policy Controller should export metrics to. For example, to specify metrics should be exported to Cloud Monitoring and Prometheus, specify backends: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]. Default: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementPolicyControllerMonitoring
{
    /// <summary>Specifies the list of backends Policy Controller will export to. Specifying an empty value `[]` disables metrics export.</summary>
    [JsonPropertyName("backends")]
    public IList<string>? Backends { get; set; }
}

/// <summary>**DEPRECATED** Configuring Policy Controller through the configmanagement feature is no longer recommended. Use the policycontroller feature instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagementPolicyController
{
    /// <summary>Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit functionality altogether.</summary>
    [JsonPropertyName("auditIntervalSeconds")]
    public string? AuditIntervalSeconds { get; set; }

    /// <summary>Enables the installation of Policy Controller. If false, the rest of PolicyController fields take no effect.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently exist on the cluster.</summary>
    [JsonPropertyName("exemptableNamespaces")]
    public IList<string>? ExemptableNamespaces { get; set; }

    /// <summary>Logs all denies and dry run failures.</summary>
    [JsonPropertyName("logDeniesEnabled")]
    public bool? LogDeniesEnabled { get; set; }

    /// <summary>Specifies the backends Policy Controller should export metrics to. For example, to specify metrics should be exported to Cloud Monitoring and Prometheus, specify backends: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]. Default: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementPolicyControllerMonitoring? Monitoring { get; set; }

    /// <summary>Enable or disable mutation in policy controller. If true, mutation CRDs, webhook and controller deployment will be deployed to the cluster.</summary>
    [JsonPropertyName("mutationEnabled")]
    public bool? MutationEnabled { get; set; }

    /// <summary>Enables the ability to use Constraint Templates that reference to objects other than the object currently being evaluated.</summary>
    [JsonPropertyName("referentialRulesEnabled")]
    public bool? ReferentialRulesEnabled { get; set; }

    /// <summary>Installs the default template library along with Policy Controller.</summary>
    [JsonPropertyName("templateLibraryInstalled")]
    public bool? TemplateLibraryInstalled { get; set; }
}

/// <summary>Config Management-specific spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecConfigmanagement
{
    /// <summary>**DEPRECATED** Binauthz configuration for the cluster. This field will be ignored and should not be set.</summary>
    [JsonPropertyName("binauthz")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementBinauthz? Binauthz { get; set; }

    /// <summary>Config Sync configuration for the cluster.</summary>
    [JsonPropertyName("configSync")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementConfigSync? ConfigSync { get; set; }

    /// <summary>Hierarchy Controller is no longer available. Use https://github.com/kubernetes-sigs/hierarchical-namespaces instead.</summary>
    [JsonPropertyName("hierarchyController")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementHierarchyController? HierarchyController { get; set; }

    /// <summary>Optional. Whether to automatically manage the configmanagement Feature. There are 3 accepted values. MANAGEMENT_UNSPECIFIED means that the mamangement mode is unspecified. MANAGEMENT_AUTOMATIC means that Google manages the Feature for the cluster. MANAGEMENT_MANUAL means that users should manage the Feature for the cluster.</summary>
    [JsonPropertyName("management")]
    public string? Management { get; set; }

    /// <summary>**DEPRECATED** Configuring Policy Controller through the configmanagement feature is no longer recommended. Use the policycontroller feature instead.</summary>
    [JsonPropertyName("policyController")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagementPolicyController? PolicyController { get; set; }

    /// <summary>Optional. Version of ACM to install. Defaults to the latest version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecFeatureRef
{
    /// <summary>The name of the feature. Allowed value: The Google Cloud resource name of a `GKEHubFeature` resource (format: `projects/{{project}}/locations/{{location}}/features/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecMembershipRef
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

/// <summary>Manage Mesh Features</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecMesh
{
    /// <summary>**DEPRECATED** Whether to automatically manage Service Mesh control planes. Possible values: CONTROL_PLANE_MANAGEMENT_UNSPECIFIED, AUTOMATIC, MANUAL</summary>
    [JsonPropertyName("controlPlane")]
    public string? ControlPlane { get; set; }

    /// <summary>Whether to automatically manage Service Mesh. Possible values: MANAGEMENT_UNSPECIFIED, MANAGEMENT_AUTOMATIC, MANAGEMENT_MANUAL</summary>
    [JsonPropertyName("management")]
    public string? Management { get; set; }
}

/// <summary>Limits describes the maximum amount of compute resources allowed for use by the running container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionContainerResourcesLimits
{
    /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Requests describes the amount of compute resources reserved for the container by the kube-scheduler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionContainerResourcesRequests
{
    /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionContainerResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed for use by the running container.</summary>
    [JsonPropertyName("limits")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionContainerResourcesLimits? Limits { get; set; }

    /// <summary>Requests describes the amount of compute resources reserved for the container by the kube-scheduler.</summary>
    [JsonPropertyName("requests")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionContainerResourcesRequests? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionPodTolerations
{
    /// <summary>Matches a taint effect.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Matches a taint key (not necessarily unique).</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Matches a taint operator.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Matches a taint value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmission
{
    /// <summary>Container resource requirements.</summary>
    [JsonPropertyName("containerResources")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionContainerResources? ContainerResources { get; set; }

    /// <summary>Pod affinity configuration.</summary>
    [JsonPropertyName("podAffinity")]
    public string? PodAffinity { get; set; }

    /// <summary>Pod tolerations of node taints.</summary>
    [JsonPropertyName("podTolerations")]
    public IList<V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmissionPodTolerations>? PodTolerations { get; set; }

    /// <summary>Pod replica count.</summary>
    [JsonPropertyName("replicaCount")]
    public long? ReplicaCount { get; set; }
}

/// <summary>Limits describes the maximum amount of compute resources allowed for use by the running container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditContainerResourcesLimits
{
    /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Requests describes the amount of compute resources reserved for the container by the kube-scheduler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditContainerResourcesRequests
{
    /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditContainerResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed for use by the running container.</summary>
    [JsonPropertyName("limits")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditContainerResourcesLimits? Limits { get; set; }

    /// <summary>Requests describes the amount of compute resources reserved for the container by the kube-scheduler.</summary>
    [JsonPropertyName("requests")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditContainerResourcesRequests? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditPodTolerations
{
    /// <summary>Matches a taint effect.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Matches a taint key (not necessarily unique).</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Matches a taint operator.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Matches a taint value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAudit
{
    /// <summary>Container resource requirements.</summary>
    [JsonPropertyName("containerResources")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditContainerResources? ContainerResources { get; set; }

    /// <summary>Pod affinity configuration.</summary>
    [JsonPropertyName("podAffinity")]
    public string? PodAffinity { get; set; }

    /// <summary>Pod tolerations of node taints.</summary>
    [JsonPropertyName("podTolerations")]
    public IList<V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAuditPodTolerations>? PodTolerations { get; set; }

    /// <summary>Pod replica count.</summary>
    [JsonPropertyName("replicaCount")]
    public long? ReplicaCount { get; set; }
}

/// <summary>Limits describes the maximum amount of compute resources allowed for use by the running container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationContainerResourcesLimits
{
    /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Requests describes the amount of compute resources reserved for the container by the kube-scheduler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationContainerResourcesRequests
{
    /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationContainerResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed for use by the running container.</summary>
    [JsonPropertyName("limits")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationContainerResourcesLimits? Limits { get; set; }

    /// <summary>Requests describes the amount of compute resources reserved for the container by the kube-scheduler.</summary>
    [JsonPropertyName("requests")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationContainerResourcesRequests? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationPodTolerations
{
    /// <summary>Matches a taint effect.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Matches a taint key (not necessarily unique).</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Matches a taint operator.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Matches a taint value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutation
{
    /// <summary>Container resource requirements.</summary>
    [JsonPropertyName("containerResources")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationContainerResources? ContainerResources { get; set; }

    /// <summary>Pod affinity configuration.</summary>
    [JsonPropertyName("podAffinity")]
    public string? PodAffinity { get; set; }

    /// <summary>Pod tolerations of node taints.</summary>
    [JsonPropertyName("podTolerations")]
    public IList<V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutationPodTolerations>? PodTolerations { get; set; }

    /// <summary>Pod replica count.</summary>
    [JsonPropertyName("replicaCount")]
    public long? ReplicaCount { get; set; }
}

/// <summary>Map of deployment configs to deployments (“admission”, “audit”, “mutation”).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigs
{
    [JsonPropertyName("admission")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAdmission? Admission { get; set; }

    [JsonPropertyName("audit")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsAudit? Audit { get; set; }

    [JsonPropertyName("mutation")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigsMutation? Mutation { get; set; }
}

/// <summary>Specifies the backends Policy Controller should export metrics to. For example, to specify metrics should be exported to Cloud Monitoring and Prometheus, specify backends: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]. Default: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigMonitoring
{
    /// <summary>Specifies the list of backends Policy Controller will export to. Specifying an empty value `[]` disables metrics export.</summary>
    [JsonPropertyName("backends")]
    public IList<string>? Backends { get; set; }
}

/// <summary>Configures the installation of the Template Library.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigPolicyContentTemplateLibrary
{
    /// <summary>Configures the manner in which the template library is installed on the cluster. Possible values: INSTALLATION_UNSPECIFIED, NOT_INSTALLED, ALL</summary>
    [JsonPropertyName("installation")]
    public string? Installation { get; set; }
}

/// <summary>Specifies the desired policy content on the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigPolicyContent
{
    /// <summary>Configures the installation of the Template Library.</summary>
    [JsonPropertyName("templateLibrary")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigPolicyContentTemplateLibrary? TemplateLibrary { get; set; }
}

/// <summary>Policy Controller configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfig
{
    /// <summary>Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit functionality altogether.</summary>
    [JsonPropertyName("auditIntervalSeconds")]
    public long? AuditIntervalSeconds { get; set; }

    /// <summary>The maximum number of audit violations to be stored in a constraint. If not set, the internal default of 20 will be used.</summary>
    [JsonPropertyName("constraintViolationLimit")]
    public long? ConstraintViolationLimit { get; set; }

    /// <summary>Map of deployment configs to deployments (“admission”, “audit”, “mutation”).</summary>
    [JsonPropertyName("deploymentConfigs")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigDeploymentConfigs? DeploymentConfigs { get; set; }

    /// <summary>The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently exist on the cluster.</summary>
    [JsonPropertyName("exemptableNamespaces")]
    public IList<string>? ExemptableNamespaces { get; set; }

    /// <summary>Configures the mode of the Policy Controller installation. Possible values: INSTALL_SPEC_UNSPECIFIED, INSTALL_SPEC_NOT_INSTALLED, INSTALL_SPEC_ENABLED, INSTALL_SPEC_SUSPENDED, INSTALL_SPEC_DETACHED</summary>
    [JsonPropertyName("installSpec")]
    public string? InstallSpec { get; set; }

    /// <summary>Logs all denies and dry run failures.</summary>
    [JsonPropertyName("logDeniesEnabled")]
    public bool? LogDeniesEnabled { get; set; }

    /// <summary>Specifies the backends Policy Controller should export metrics to. For example, to specify metrics should be exported to Cloud Monitoring and Prometheus, specify backends: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]. Default: [&quot;cloudmonitoring&quot;, &quot;prometheus&quot;]</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigMonitoring? Monitoring { get; set; }

    /// <summary>Enables the ability to mutate resources using Policy Controller.</summary>
    [JsonPropertyName("mutationEnabled")]
    public bool? MutationEnabled { get; set; }

    /// <summary>Specifies the desired policy content on the cluster.</summary>
    [JsonPropertyName("policyContent")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfigPolicyContent? PolicyContent { get; set; }

    /// <summary>Enables the ability to use Constraint Templates that reference to objects other than the object currently being evaluated.</summary>
    [JsonPropertyName("referentialRulesEnabled")]
    public bool? ReferentialRulesEnabled { get; set; }
}

/// <summary>Policy Controller-specific spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecPolicycontroller
{
    /// <summary>Policy Controller configuration for the cluster.</summary>
    [JsonPropertyName("policyControllerHubConfig")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontrollerPolicyControllerHubConfig? PolicyControllerHubConfig { get; set; }

    /// <summary>Optional. Version of Policy Controller to install. Defaults to the latest version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipSpecProjectRef
{
    /// <summary>The project of the feature. Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
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
public partial class V1beta1GKEHubFeatureMembershipSpec
{
    /// <summary>Config Management-specific spec.</summary>
    [JsonPropertyName("configmanagement")]
    public V1beta1GKEHubFeatureMembershipSpecConfigmanagement? Configmanagement { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("featureRef")]
    public required V1beta1GKEHubFeatureMembershipSpecFeatureRef FeatureRef { get; set; }

    /// <summary>Immutable. The location of the feature</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Immutable. The location of the membership</summary>
    [JsonPropertyName("membershipLocation")]
    public string? MembershipLocation { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("membershipRef")]
    public required V1beta1GKEHubFeatureMembershipSpecMembershipRef MembershipRef { get; set; }

    /// <summary>Manage Mesh Features</summary>
    [JsonPropertyName("mesh")]
    public V1beta1GKEHubFeatureMembershipSpecMesh? Mesh { get; set; }

    /// <summary>Policy Controller-specific spec.</summary>
    [JsonPropertyName("policycontroller")]
    public V1beta1GKEHubFeatureMembershipSpecPolicycontroller? Policycontroller { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1GKEHubFeatureMembershipSpecProjectRef ProjectRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureMembershipStatusConditions
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
public partial class V1beta1GKEHubFeatureMembershipStatus
{
    /// <summary>Conditions represent the latest available observations of the GKEHubFeatureMembership&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GKEHubFeatureMembershipStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GKEHubFeatureMembership is the Schema for the gkehub API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GKEHubFeatureMembership : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GKEHubFeatureMembershipSpec>, IStatus<V1beta1GKEHubFeatureMembershipStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GKEHubFeatureMembership";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubfeaturememberships";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gkehub.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GKEHubFeatureMembership";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1GKEHubFeatureMembershipSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1GKEHubFeatureMembershipStatus? Status { get; set; }
}
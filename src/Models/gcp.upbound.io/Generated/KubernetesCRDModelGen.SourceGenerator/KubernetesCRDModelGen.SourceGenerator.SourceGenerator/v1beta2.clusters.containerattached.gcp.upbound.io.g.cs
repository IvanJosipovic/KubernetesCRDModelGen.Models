#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerattached.gcp.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API. An Anthos cluster running on customer owned infrastructure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Cluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "containerattached.gcp.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerattached.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Cluster> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecDeletionPolicyEnum>))]
public enum V1beta2ClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Configuration related to the cluster RBAC settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderAuthorization
{
    /// <summary>
    /// Groups that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the cluster-admin ClusterRole
    /// to the groups. Up to ten admin groups can be provided.
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [JsonPropertyName("adminGroups")]
    public IList<string>? AdminGroups { get; set; }

    /// <summary>
    /// Users that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the cluster-admin ClusterRole
    /// to the users. Up to ten admin users can be provided.
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [JsonPropertyName("adminUsers")]
    public IList<string>? AdminUsers { get; set; }
}

/// <summary>
/// Binary Authorization configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBinaryAuthorization
{
    /// <summary>
    /// Configure Binary Authorization evaluation mode.
    /// Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

/// <summary>
/// Fleet configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// The configuration of the logging components
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingConfigComponentConfig
{
    /// <summary>
    /// The components to be enabled.
    /// Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.
    /// </summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}

/// <summary>
/// Logging configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingConfig
{
    /// <summary>
    /// The configuration of the logging components
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("componentConfig")]
    public V1beta2ClusterSpecForProviderLoggingConfigComponentConfig? ComponentConfig { get; set; }
}

/// <summary>
/// Enable Google Cloud Managed Service for Prometheus in the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Monitoring configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMonitoringConfig
{
    /// <summary>
    /// Enable Google Cloud Managed Service for Prometheus in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public V1beta2ClusterSpecForProviderMonitoringConfigManagedPrometheusConfig? ManagedPrometheusConfig { get; set; }
}

/// <summary>
/// OIDC discovery information of the target cluster.
/// Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster
/// API server. This fields indicates how GCP services
/// validate KSA tokens in order to allow system workloads (such as GKE Connect
/// and telemetry agents) to authenticate back to GCP.
/// Both clusters with public and private issuer URLs are supported.
/// Clusters with public issuers only need to specify the issuer_url field
/// while clusters with private issuers need to provide both
/// issuer_url and jwks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderOidcConfig
{
    /// <summary>A JSON Web Token (JWT) issuer URI. issuer must start with https://</summary>
    [JsonPropertyName("issuerUrl")]
    public string? IssuerUrl { get; set; }

    /// <summary>OIDC verification keys in JWKS format (RFC 7517).</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }
}

/// <summary>
/// The Kubernetes Secret resource that contains the HTTP(S) proxy configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderProxyConfigKubernetesSecret
{
    /// <summary>Name of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Support for proxy configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderProxyConfig
{
    /// <summary>
    /// The Kubernetes Secret resource that contains the HTTP(S) proxy configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kubernetesSecret")]
    public V1beta2ClusterSpecForProviderProxyConfigKubernetesSecret? KubernetesSecret { get; set; }
}

/// <summary>
/// Enable/Disable Security Posture API features for the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderSecurityPostureConfig
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&apos;s workload vulnerability scanning.
    /// Possible values are: VULNERABILITY_DISABLED, VULNERABILITY_ENTERPRISE.
    /// </summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProvider
{
    /// <summary>
    /// Optional. Annotations on the cluster. This field has the same
    /// restrictions as Kubernetes annotations. The total size of all keys and
    /// values combined is limited to 256k. Key can have 2 segments: prefix
    /// and name , separated by a slash (/). Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Configuration related to the cluster RBAC settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorization")]
    public V1beta2ClusterSpecForProviderAuthorization? Authorization { get; set; }

    /// <summary>
    /// Binary Authorization configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta2ClusterSpecForProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// A human readable description of this attached cluster. Cannot be longer
    /// than 255 UTF-8 encoded bytes.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The Kubernetes distribution of the underlying attached cluster. Supported values:
    /// &quot;eks&quot;, &quot;aks&quot;, &quot;generic&quot;. The generic distribution provides the ability to register
    /// or migrate any CNCF conformant cluster.
    /// </summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>
    /// Fleet configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fleet")]
    public V1beta2ClusterSpecForProviderFleet? Fleet { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// Logging configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2ClusterSpecForProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// Monitoring configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta2ClusterSpecForProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>
    /// OIDC discovery information of the target cluster.
    /// Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster
    /// API server. This fields indicates how GCP services
    /// validate KSA tokens in order to allow system workloads (such as GKE Connect
    /// and telemetry agents) to authenticate back to GCP.
    /// Both clusters with public and private issuer URLs are supported.
    /// Clusters with public issuers only need to specify the issuer_url field
    /// while clusters with private issuers need to provide both
    /// issuer_url and jwks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcConfig")]
    public V1beta2ClusterSpecForProviderOidcConfig? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Support for proxy configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta2ClusterSpecForProviderProxyConfig? ProxyConfig { get; set; }

    /// <summary>
    /// Enable/Disable Security Posture API features for the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta2ClusterSpecForProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }
}

/// <summary>
/// Configuration related to the cluster RBAC settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderAuthorization
{
    /// <summary>
    /// Groups that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the cluster-admin ClusterRole
    /// to the groups. Up to ten admin groups can be provided.
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [JsonPropertyName("adminGroups")]
    public IList<string>? AdminGroups { get; set; }

    /// <summary>
    /// Users that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the cluster-admin ClusterRole
    /// to the users. Up to ten admin users can be provided.
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [JsonPropertyName("adminUsers")]
    public IList<string>? AdminUsers { get; set; }
}

/// <summary>
/// Binary Authorization configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBinaryAuthorization
{
    /// <summary>
    /// Configure Binary Authorization evaluation mode.
    /// Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

/// <summary>
/// Fleet configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// The configuration of the logging components
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingConfigComponentConfig
{
    /// <summary>
    /// The components to be enabled.
    /// Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.
    /// </summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}

/// <summary>
/// Logging configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingConfig
{
    /// <summary>
    /// The configuration of the logging components
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("componentConfig")]
    public V1beta2ClusterSpecInitProviderLoggingConfigComponentConfig? ComponentConfig { get; set; }
}

/// <summary>
/// Enable Google Cloud Managed Service for Prometheus in the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Monitoring configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMonitoringConfig
{
    /// <summary>
    /// Enable Google Cloud Managed Service for Prometheus in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public V1beta2ClusterSpecInitProviderMonitoringConfigManagedPrometheusConfig? ManagedPrometheusConfig { get; set; }
}

/// <summary>
/// OIDC discovery information of the target cluster.
/// Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster
/// API server. This fields indicates how GCP services
/// validate KSA tokens in order to allow system workloads (such as GKE Connect
/// and telemetry agents) to authenticate back to GCP.
/// Both clusters with public and private issuer URLs are supported.
/// Clusters with public issuers only need to specify the issuer_url field
/// while clusters with private issuers need to provide both
/// issuer_url and jwks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderOidcConfig
{
    /// <summary>A JSON Web Token (JWT) issuer URI. issuer must start with https://</summary>
    [JsonPropertyName("issuerUrl")]
    public string? IssuerUrl { get; set; }

    /// <summary>OIDC verification keys in JWKS format (RFC 7517).</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }
}

/// <summary>
/// The Kubernetes Secret resource that contains the HTTP(S) proxy configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderProxyConfigKubernetesSecret
{
    /// <summary>Name of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Support for proxy configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderProxyConfig
{
    /// <summary>
    /// The Kubernetes Secret resource that contains the HTTP(S) proxy configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kubernetesSecret")]
    public V1beta2ClusterSpecInitProviderProxyConfigKubernetesSecret? KubernetesSecret { get; set; }
}

/// <summary>
/// Enable/Disable Security Posture API features for the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderSecurityPostureConfig
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&apos;s workload vulnerability scanning.
    /// Possible values are: VULNERABILITY_DISABLED, VULNERABILITY_ENTERPRISE.
    /// </summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
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
public partial class V1beta2ClusterSpecInitProvider
{
    /// <summary>
    /// Optional. Annotations on the cluster. This field has the same
    /// restrictions as Kubernetes annotations. The total size of all keys and
    /// values combined is limited to 256k. Key can have 2 segments: prefix
    /// and name , separated by a slash (/). Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Configuration related to the cluster RBAC settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorization")]
    public V1beta2ClusterSpecInitProviderAuthorization? Authorization { get; set; }

    /// <summary>
    /// Binary Authorization configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta2ClusterSpecInitProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// A human readable description of this attached cluster. Cannot be longer
    /// than 255 UTF-8 encoded bytes.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The Kubernetes distribution of the underlying attached cluster. Supported values:
    /// &quot;eks&quot;, &quot;aks&quot;, &quot;generic&quot;. The generic distribution provides the ability to register
    /// or migrate any CNCF conformant cluster.
    /// </summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>
    /// Fleet configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fleet")]
    public V1beta2ClusterSpecInitProviderFleet? Fleet { get; set; }

    /// <summary>
    /// Logging configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2ClusterSpecInitProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// Monitoring configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta2ClusterSpecInitProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>
    /// OIDC discovery information of the target cluster.
    /// Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster
    /// API server. This fields indicates how GCP services
    /// validate KSA tokens in order to allow system workloads (such as GKE Connect
    /// and telemetry agents) to authenticate back to GCP.
    /// Both clusters with public and private issuer URLs are supported.
    /// Clusters with public issuers only need to specify the issuer_url field
    /// while clusters with private issuers need to provide both
    /// issuer_url and jwks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcConfig")]
    public V1beta2ClusterSpecInitProviderOidcConfig? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Support for proxy configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta2ClusterSpecInitProviderProxyConfig? ProxyConfig { get; set; }

    /// <summary>
    /// Enable/Disable Security Posture API features for the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta2ClusterSpecInitProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecManagementPoliciesEnum>))]
public enum V1beta2ClusterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpec
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
    public V1beta2ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta2ClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration related to the cluster RBAC settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderAuthorization
{
    /// <summary>
    /// Groups that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the cluster-admin ClusterRole
    /// to the groups. Up to ten admin groups can be provided.
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [JsonPropertyName("adminGroups")]
    public IList<string>? AdminGroups { get; set; }

    /// <summary>
    /// Users that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the cluster-admin ClusterRole
    /// to the users. Up to ten admin users can be provided.
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [JsonPropertyName("adminUsers")]
    public IList<string>? AdminUsers { get; set; }
}

/// <summary>
/// Binary Authorization configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBinaryAuthorization
{
    /// <summary>
    /// Configure Binary Authorization evaluation mode.
    /// Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderErrors
{
    /// <summary>Human-friendly description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>
/// Fleet configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderFleet
{
    /// <summary>
    /// (Output)
    /// The name of the managed Hub Membership resource associated to this
    /// cluster. Membership names are formatted as
    /// projects//locations/global/membership/.
    /// </summary>
    [JsonPropertyName("membership")]
    public string? Membership { get; set; }

    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// The configuration of the logging components
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderLoggingConfigComponentConfig
{
    /// <summary>
    /// The components to be enabled.
    /// Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.
    /// </summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}

/// <summary>
/// Logging configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderLoggingConfig
{
    /// <summary>
    /// The configuration of the logging components
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("componentConfig")]
    public V1beta2ClusterStatusAtProviderLoggingConfigComponentConfig? ComponentConfig { get; set; }
}

/// <summary>
/// Enable Google Cloud Managed Service for Prometheus in the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Monitoring configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderMonitoringConfig
{
    /// <summary>
    /// Enable Google Cloud Managed Service for Prometheus in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public V1beta2ClusterStatusAtProviderMonitoringConfigManagedPrometheusConfig? ManagedPrometheusConfig { get; set; }
}

/// <summary>
/// OIDC discovery information of the target cluster.
/// Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster
/// API server. This fields indicates how GCP services
/// validate KSA tokens in order to allow system workloads (such as GKE Connect
/// and telemetry agents) to authenticate back to GCP.
/// Both clusters with public and private issuer URLs are supported.
/// Clusters with public issuers only need to specify the issuer_url field
/// while clusters with private issuers need to provide both
/// issuer_url and jwks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderOidcConfig
{
    /// <summary>A JSON Web Token (JWT) issuer URI. issuer must start with https://</summary>
    [JsonPropertyName("issuerUrl")]
    public string? IssuerUrl { get; set; }

    /// <summary>OIDC verification keys in JWKS format (RFC 7517).</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }
}

/// <summary>
/// The Kubernetes Secret resource that contains the HTTP(S) proxy configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderProxyConfigKubernetesSecret
{
    /// <summary>Name of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Support for proxy configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderProxyConfig
{
    /// <summary>
    /// The Kubernetes Secret resource that contains the HTTP(S) proxy configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kubernetesSecret")]
    public V1beta2ClusterStatusAtProviderProxyConfigKubernetesSecret? KubernetesSecret { get; set; }
}

/// <summary>
/// Enable/Disable Security Posture API features for the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderSecurityPostureConfig
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&apos;s workload vulnerability scanning.
    /// Possible values are: VULNERABILITY_DISABLED, VULNERABILITY_ENTERPRISE.
    /// </summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderWorkloadIdentityConfig
{
    /// <summary>
    /// The ID of the OIDC Identity Provider (IdP) associated to
    /// the Workload Identity Pool.
    /// </summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary>The OIDC issuer URL for this cluster.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>The Workload Identity Pool associated to the cluster.</summary>
    [JsonPropertyName("workloadPool")]
    public string? WorkloadPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProvider
{
    /// <summary>
    /// Optional. Annotations on the cluster. This field has the same
    /// restrictions as Kubernetes annotations. The total size of all keys and
    /// values combined is limited to 256k. Key can have 2 segments: prefix
    /// and name , separated by a slash (/). Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Configuration related to the cluster RBAC settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorization")]
    public V1beta2ClusterStatusAtProviderAuthorization? Authorization { get; set; }

    /// <summary>
    /// Binary Authorization configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta2ClusterStatusAtProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>
    /// Output only. The region where this cluster runs.
    /// For EKS clusters, this is an AWS region. For AKS clusters,
    /// this is an Azure region.
    /// </summary>
    [JsonPropertyName("clusterRegion")]
    public string? ClusterRegion { get; set; }

    /// <summary>Output only. The time at which this cluster was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// A human readable description of this attached cluster. Cannot be longer
    /// than 255 UTF-8 encoded bytes.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The Kubernetes distribution of the underlying attached cluster. Supported values:
    /// &quot;eks&quot;, &quot;aks&quot;, &quot;generic&quot;. The generic distribution provides the ability to register
    /// or migrate any CNCF conformant cluster.
    /// </summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>for all of the annotations present on the resource.</summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>
    /// A set of errors found in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errors")]
    public IList<V1beta2ClusterStatusAtProviderErrors>? Errors { get; set; }

    /// <summary>
    /// Fleet configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fleet")]
    public V1beta2ClusterStatusAtProviderFleet? Fleet { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/attachedClusters/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Kubernetes version of the cluster.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Logging configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2ClusterStatusAtProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// Monitoring configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta2ClusterStatusAtProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>
    /// OIDC discovery information of the target cluster.
    /// Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster
    /// API server. This fields indicates how GCP services
    /// validate KSA tokens in order to allow system workloads (such as GKE Connect
    /// and telemetry agents) to authenticate back to GCP.
    /// Both clusters with public and private issuer URLs are supported.
    /// Clusters with public issuers only need to specify the issuer_url field
    /// while clusters with private issuers need to provide both
    /// issuer_url and jwks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcConfig")]
    public V1beta2ClusterStatusAtProviderOidcConfig? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Support for proxy configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta2ClusterStatusAtProviderProxyConfig? ProxyConfig { get; set; }

    /// <summary>If set, there are currently changes in flight to the cluster.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>
    /// Enable/Disable Security Posture API features for the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta2ClusterStatusAtProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }

    /// <summary>
    /// The current state of the cluster. Possible values:
    /// STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR,
    /// DEGRADED
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A globally unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The time at which this cluster was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Workload Identity settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public IList<V1beta2ClusterStatusAtProviderWorkloadIdentityConfig>? WorkloadIdentityConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. An Anthos cluster running on customer owned infrastructure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ClusterSpec>, IStatus<V1beta2ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "containerattached.gcp.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerattached.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2ClusterStatus? Status { get; set; }
}
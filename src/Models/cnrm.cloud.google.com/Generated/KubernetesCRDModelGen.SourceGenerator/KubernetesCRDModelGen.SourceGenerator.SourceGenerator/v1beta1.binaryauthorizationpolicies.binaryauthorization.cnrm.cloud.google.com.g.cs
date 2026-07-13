#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BinaryAuthorizationPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BinaryAuthorizationPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BinaryAuthorizationPolicyList";
    public const string KubeGroup = "binaryauthorization.cnrm.cloud.google.com";
    public const string KubePluralName = "binaryauthorizationpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BinaryAuthorizationPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BinaryAuthorizationPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BinaryAuthorizationPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecAdmissionWhitelistPatterns
{
    /// <summary>An image name pattern to allowlist, in the form `registry/path/to/image`. This supports a trailing `*` as a wildcard, but this is allowed only in text after the `registry/` part.</summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
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
public partial class V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public required string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public required string EvaluationMode { get; set; }

    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRuleRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Default admission rule for a cluster without a per-cluster, per-kubernetes-service-account, or per-istio-service-identity admission rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRule
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public required string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public required string EvaluationMode { get; set; }

    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRuleRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
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
public partial class V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public required string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public required string EvaluationMode { get; set; }

    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
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
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public required string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public required string EvaluationMode { get; set; }

    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
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
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public required string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public required string EvaluationMode { get; set; }

    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecProjectRef
{
    /// <summary>
    /// The project of the resource.
    /// 
    /// Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).
    /// </summary>
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
public partial class V1beta1BinaryAuthorizationPolicySpec
{
    /// <summary>Optional. Admission policy allowlisting. A matching admission request will always be permitted. This feature is typically used to exclude Google or third-party infrastructure images from Binary Authorization policies.</summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta1BinaryAuthorizationPolicySpecAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>Optional. Per-cluster admission rules. Cluster spec format: location.clusterId. There can be at most one admission rule per cluster spec. A location is either a compute zone (e.g. us-central1-a) or a region (e.g. us-central1). For clusterId syntax restrictions see https://cloud.google.com/container-engine/reference/rest/v1/projects.zones.clusters.</summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>Required. Default admission rule for a cluster without a per-cluster, per-kubernetes-service-account, or per-istio-service-identity admission rule.</summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public required V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRule DefaultAdmissionRule { get; set; }

    /// <summary>Optional. A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Controls the evaluation of a Google-maintained global admission policy for common system-level images. Images not covered by the global policy will be subject to the project admission policy. This setting has no effect when specified inside a global admission policy. Possible values: GLOBAL_POLICY_EVALUATION_MODE_UNSPECIFIED, ENABLE, DISABLE</summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>Optional. Per-istio-service-identity admission rules. Istio service identity spec format: spiffe:///ns//sa/ or /ns//sa/ e.g. spiffe://example.com/ns/test-ns/sa/default</summary>
    [JsonPropertyName("istioServiceIdentityAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRules>? IstioServiceIdentityAdmissionRules { get; set; }

    /// <summary>Optional. Per-kubernetes-namespace admission rules. K8s namespace spec format: [a-z.-]+, e.g. &apos;some-namespace&apos;</summary>
    [JsonPropertyName("kubernetesNamespaceAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRules>? KubernetesNamespaceAdmissionRules { get; set; }

    /// <summary>Optional. Per-kubernetes-service-account admission rules. Service account spec format: namespace:serviceaccount. e.g. &apos;test-ns:default&apos;</summary>
    [JsonPropertyName("kubernetesServiceAccountAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRules>? KubernetesServiceAccountAdmissionRules { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1BinaryAuthorizationPolicySpecProjectRef ProjectRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicyStatusConditions
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
public partial class V1beta1BinaryAuthorizationPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BinaryAuthorizationPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The resource name, in the format `projects/*/policy`. There is at most one policy per project.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Output only. Time when the policy was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BinaryAuthorizationPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BinaryAuthorizationPolicySpec>, IStatus<V1beta1BinaryAuthorizationPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BinaryAuthorizationPolicy";
    public const string KubeGroup = "binaryauthorization.cnrm.cloud.google.com";
    public const string KubePluralName = "binaryauthorizationpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BinaryAuthorizationPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1BinaryAuthorizationPolicySpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1BinaryAuthorizationPolicyStatus? Status { get; set; }
}
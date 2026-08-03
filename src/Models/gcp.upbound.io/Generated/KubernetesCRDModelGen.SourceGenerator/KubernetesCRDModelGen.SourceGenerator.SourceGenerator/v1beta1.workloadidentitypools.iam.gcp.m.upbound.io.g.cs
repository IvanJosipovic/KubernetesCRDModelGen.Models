#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.gcp.m.upbound.io;
/// <summary>WorkloadIdentityPool is the Schema for the WorkloadIdentityPools API. Represents a collection of external workload identities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkloadIdentityPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WorkloadIdentityPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkloadIdentityPoolList";
    public const string KubeGroup = "iam.gcp.m.upbound.io";
    public const string KubePluralName = "workloadidentitypools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkloadIdentityPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1WorkloadIdentityPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1WorkloadIdentityPool> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecForProviderAttestationRules
{
    /// <summary>
    /// A single workload operating on Google Cloud. For example:
    /// //run.googleapis.com/projects/123/type/Service/*.
    /// </summary>
    [JsonPropertyName("googleCloudResource")]
    public string? GoogleCloudResource { get; set; }
}

/// <summary>
/// Represents configuration for generating mutual TLS (mTLS) certificates for the identities
/// within this pool. Defines the Certificate Authority (CA) pool resources and configurations
/// required for issuance and rotation of mTLS workload certificates.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecForProviderInlineCertificateIssuanceConfig
{
    /// <summary>
    /// A required mapping of a cloud region to the CA pool resource located in that region used
    /// for certificate issuance, adhering to these constraints:
    /// </summary>
    [JsonPropertyName("caPools")]
    public IDictionary<string, string>? CaPools { get; set; }

    /// <summary>
    /// Key algorithm to use when generating the key pair. This key pair will be used to create
    /// the certificate. If unspecified, this will default to ECDSA_P256.
    /// </summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>
    /// Lifetime of the workload certificates issued by the CA pool in seconds. Must be between
    /// 86400s (24 hours) to 2592000s (30 days), ends in the suffix &quot;s&quot; (indicating seconds)
    /// and is preceded by the number of seconds. If unspecified, this will be defaulted to
    /// 86400s (24 hours).
    /// </summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>
    /// Rotation window percentage indicating when certificate rotation should be initiated based
    /// on remaining lifetime. Must be between 50 - 80. If unspecified, this will be defaulted
    /// to 50.
    /// </summary>
    [JsonPropertyName("rotationWindowPercentage")]
    public double? RotationWindowPercentage { get; set; }

    /// <summary>
    /// If set to true, the trust domain will utilize the GCP-provisioned default CA. A default
    /// CA in the same region as the workload will be selected to issue the certificate. Enabling
    /// this will clear any existing ca_pools configuration to provision the certificates.
    /// ~&gt; Note This field is mutually exclusive with ca_pools. If this flag is enabled,
    /// certificates will be automatically provisioned from the default shared CAs. This flag should
    /// not be set if you want to use your own CA pools to provision the certificates.
    /// </summary>
    [JsonPropertyName("useDefaultSharedCa")]
    public bool? UseDefaultSharedCa { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecForProviderInlineTrustConfigAdditionalTrustBundlesTrustAnchors
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one ca
    /// certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecForProviderInlineTrustConfigAdditionalTrustBundles
{
    /// <summary>
    /// List of Trust Anchors to be used while performing validation against a given
    /// TrustStore. The incoming end entity&apos;s certificate must be chained up to one of the
    /// trust anchors here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustAnchors")]
    public IList<V1beta1WorkloadIdentityPoolSpecForProviderInlineTrustConfigAdditionalTrustBundlesTrustAnchors>? TrustAnchors { get; set; }

    /// <summary>
    /// If set to True, the trust bundle will include the private ca managed identity regional root
    /// public certificates.
    /// ~&gt; Note trust_default_shared_ca is only supported for managed identity trust domain
    /// resource.
    /// </summary>
    [JsonPropertyName("trustDefaultSharedCa")]
    public bool? TrustDefaultSharedCa { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("trustDomain")]
    public string? TrustDomain { get; set; }
}

/// <summary>
/// Represents config to add additional trusted trust domains. Defines configuration for extending
/// trust to additional trust domains. By establishing trust with another domain, the current
/// domain will recognize and accept certificates issued by entities within the trusted domains.
/// Note that a trust domain automatically trusts itself, eliminating the need for explicit
/// configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecForProviderInlineTrustConfig
{
    /// <summary>
    /// Maps specific trust domains (e.g., &quot;example.com&quot;) to their corresponding TrustStore
    /// objects, which contain the trusted root certificates for that domain. There can be a
    /// maximum of 10 trust domain entries in this map.
    /// Note that a trust domain automatically trusts itself and don&apos;t need to be specified here.
    /// If however, this WorkloadIdentityPool&apos;s trust domain contains any trust anchors in the
    /// additional_trust_bundles map, those trust anchors will be appended to the Trust Bundle
    /// automatically derived from your InlineCertificateIssuanceConfig&apos;s ca_pools.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalTrustBundles")]
    public IList<V1beta1WorkloadIdentityPoolSpecForProviderInlineTrustConfigAdditionalTrustBundles>? AdditionalTrustBundles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecForProvider
{
    /// <summary>
    /// Defines which workloads can receive an identity within a pool. When an AttestationRule is
    /// defined under a managed identity, matching workloads may receive that identity. A maximum of
    /// 50 AttestationRules can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("attestationRules")]
    public IList<V1beta1WorkloadIdentityPoolSpecForProviderAttestationRules>? AttestationRules { get; set; }

    /// <summary>A description of the pool. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use
    /// existing tokens to access resources. If the pool is re-enabled, existing tokens grant
    /// access again.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A display name for the pool. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Represents configuration for generating mutual TLS (mTLS) certificates for the identities
    /// within this pool. Defines the Certificate Authority (CA) pool resources and configurations
    /// required for issuance and rotation of mTLS workload certificates.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineCertificateIssuanceConfig")]
    public V1beta1WorkloadIdentityPoolSpecForProviderInlineCertificateIssuanceConfig? InlineCertificateIssuanceConfig { get; set; }

    /// <summary>
    /// Represents config to add additional trusted trust domains. Defines configuration for extending
    /// trust to additional trust domains. By establishing trust with another domain, the current
    /// domain will recognize and accept certificates issued by entities within the trusted domains.
    /// Note that a trust domain automatically trusts itself, eliminating the need for explicit
    /// configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineTrustConfig")]
    public V1beta1WorkloadIdentityPoolSpecForProviderInlineTrustConfig? InlineTrustConfig { get; set; }

    /// <summary>
    /// The mode for the pool is operating in. Pools with an unspecified mode will operate as if they
    /// are in FEDERATION_ONLY mode.
    /// ~&gt; Note This field cannot be changed after the Workload Identity Pool is created.).
    /// To specify a different mode, please create a new Workload Identity Pool resource.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecInitProviderAttestationRules
{
    /// <summary>
    /// A single workload operating on Google Cloud. For example:
    /// //run.googleapis.com/projects/123/type/Service/*.
    /// </summary>
    [JsonPropertyName("googleCloudResource")]
    public string? GoogleCloudResource { get; set; }
}

/// <summary>
/// Represents configuration for generating mutual TLS (mTLS) certificates for the identities
/// within this pool. Defines the Certificate Authority (CA) pool resources and configurations
/// required for issuance and rotation of mTLS workload certificates.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecInitProviderInlineCertificateIssuanceConfig
{
    /// <summary>
    /// A required mapping of a cloud region to the CA pool resource located in that region used
    /// for certificate issuance, adhering to these constraints:
    /// </summary>
    [JsonPropertyName("caPools")]
    public IDictionary<string, string>? CaPools { get; set; }

    /// <summary>
    /// Key algorithm to use when generating the key pair. This key pair will be used to create
    /// the certificate. If unspecified, this will default to ECDSA_P256.
    /// </summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>
    /// Lifetime of the workload certificates issued by the CA pool in seconds. Must be between
    /// 86400s (24 hours) to 2592000s (30 days), ends in the suffix &quot;s&quot; (indicating seconds)
    /// and is preceded by the number of seconds. If unspecified, this will be defaulted to
    /// 86400s (24 hours).
    /// </summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>
    /// Rotation window percentage indicating when certificate rotation should be initiated based
    /// on remaining lifetime. Must be between 50 - 80. If unspecified, this will be defaulted
    /// to 50.
    /// </summary>
    [JsonPropertyName("rotationWindowPercentage")]
    public double? RotationWindowPercentage { get; set; }

    /// <summary>
    /// If set to true, the trust domain will utilize the GCP-provisioned default CA. A default
    /// CA in the same region as the workload will be selected to issue the certificate. Enabling
    /// this will clear any existing ca_pools configuration to provision the certificates.
    /// ~&gt; Note This field is mutually exclusive with ca_pools. If this flag is enabled,
    /// certificates will be automatically provisioned from the default shared CAs. This flag should
    /// not be set if you want to use your own CA pools to provision the certificates.
    /// </summary>
    [JsonPropertyName("useDefaultSharedCa")]
    public bool? UseDefaultSharedCa { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecInitProviderInlineTrustConfigAdditionalTrustBundlesTrustAnchors
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one ca
    /// certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecInitProviderInlineTrustConfigAdditionalTrustBundles
{
    /// <summary>
    /// List of Trust Anchors to be used while performing validation against a given
    /// TrustStore. The incoming end entity&apos;s certificate must be chained up to one of the
    /// trust anchors here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustAnchors")]
    public IList<V1beta1WorkloadIdentityPoolSpecInitProviderInlineTrustConfigAdditionalTrustBundlesTrustAnchors>? TrustAnchors { get; set; }

    /// <summary>
    /// If set to True, the trust bundle will include the private ca managed identity regional root
    /// public certificates.
    /// ~&gt; Note trust_default_shared_ca is only supported for managed identity trust domain
    /// resource.
    /// </summary>
    [JsonPropertyName("trustDefaultSharedCa")]
    public bool? TrustDefaultSharedCa { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("trustDomain")]
    public string? TrustDomain { get; set; }
}

/// <summary>
/// Represents config to add additional trusted trust domains. Defines configuration for extending
/// trust to additional trust domains. By establishing trust with another domain, the current
/// domain will recognize and accept certificates issued by entities within the trusted domains.
/// Note that a trust domain automatically trusts itself, eliminating the need for explicit
/// configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpecInitProviderInlineTrustConfig
{
    /// <summary>
    /// Maps specific trust domains (e.g., &quot;example.com&quot;) to their corresponding TrustStore
    /// objects, which contain the trusted root certificates for that domain. There can be a
    /// maximum of 10 trust domain entries in this map.
    /// Note that a trust domain automatically trusts itself and don&apos;t need to be specified here.
    /// If however, this WorkloadIdentityPool&apos;s trust domain contains any trust anchors in the
    /// additional_trust_bundles map, those trust anchors will be appended to the Trust Bundle
    /// automatically derived from your InlineCertificateIssuanceConfig&apos;s ca_pools.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalTrustBundles")]
    public IList<V1beta1WorkloadIdentityPoolSpecInitProviderInlineTrustConfigAdditionalTrustBundles>? AdditionalTrustBundles { get; set; }
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
public partial class V1beta1WorkloadIdentityPoolSpecInitProvider
{
    /// <summary>
    /// Defines which workloads can receive an identity within a pool. When an AttestationRule is
    /// defined under a managed identity, matching workloads may receive that identity. A maximum of
    /// 50 AttestationRules can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("attestationRules")]
    public IList<V1beta1WorkloadIdentityPoolSpecInitProviderAttestationRules>? AttestationRules { get; set; }

    /// <summary>A description of the pool. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use
    /// existing tokens to access resources. If the pool is re-enabled, existing tokens grant
    /// access again.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A display name for the pool. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Represents configuration for generating mutual TLS (mTLS) certificates for the identities
    /// within this pool. Defines the Certificate Authority (CA) pool resources and configurations
    /// required for issuance and rotation of mTLS workload certificates.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineCertificateIssuanceConfig")]
    public V1beta1WorkloadIdentityPoolSpecInitProviderInlineCertificateIssuanceConfig? InlineCertificateIssuanceConfig { get; set; }

    /// <summary>
    /// Represents config to add additional trusted trust domains. Defines configuration for extending
    /// trust to additional trust domains. By establishing trust with another domain, the current
    /// domain will recognize and accept certificates issued by entities within the trusted domains.
    /// Note that a trust domain automatically trusts itself, eliminating the need for explicit
    /// configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineTrustConfig")]
    public V1beta1WorkloadIdentityPoolSpecInitProviderInlineTrustConfig? InlineTrustConfig { get; set; }

    /// <summary>
    /// The mode for the pool is operating in. Pools with an unspecified mode will operate as if they
    /// are in FEDERATION_ONLY mode.
    /// ~&gt; Note This field cannot be changed after the Workload Identity Pool is created.).
    /// To specify a different mode, please create a new Workload Identity Pool resource.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkloadIdentityPoolSpecManagementPoliciesEnum>))]
public enum V1beta1WorkloadIdentityPoolSpecManagementPoliciesEnum
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
public partial class V1beta1WorkloadIdentityPoolSpecProviderConfigRef
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
public partial class V1beta1WorkloadIdentityPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WorkloadIdentityPoolSpec defines the desired state of WorkloadIdentityPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1WorkloadIdentityPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta1WorkloadIdentityPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkloadIdentityPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkloadIdentityPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkloadIdentityPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatusAtProviderAttestationRules
{
    /// <summary>
    /// A single workload operating on Google Cloud. For example:
    /// //run.googleapis.com/projects/123/type/Service/*.
    /// </summary>
    [JsonPropertyName("googleCloudResource")]
    public string? GoogleCloudResource { get; set; }
}

/// <summary>
/// Represents configuration for generating mutual TLS (mTLS) certificates for the identities
/// within this pool. Defines the Certificate Authority (CA) pool resources and configurations
/// required for issuance and rotation of mTLS workload certificates.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatusAtProviderInlineCertificateIssuanceConfig
{
    /// <summary>
    /// A required mapping of a cloud region to the CA pool resource located in that region used
    /// for certificate issuance, adhering to these constraints:
    /// </summary>
    [JsonPropertyName("caPools")]
    public IDictionary<string, string>? CaPools { get; set; }

    /// <summary>
    /// Key algorithm to use when generating the key pair. This key pair will be used to create
    /// the certificate. If unspecified, this will default to ECDSA_P256.
    /// </summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>
    /// Lifetime of the workload certificates issued by the CA pool in seconds. Must be between
    /// 86400s (24 hours) to 2592000s (30 days), ends in the suffix &quot;s&quot; (indicating seconds)
    /// and is preceded by the number of seconds. If unspecified, this will be defaulted to
    /// 86400s (24 hours).
    /// </summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>
    /// Rotation window percentage indicating when certificate rotation should be initiated based
    /// on remaining lifetime. Must be between 50 - 80. If unspecified, this will be defaulted
    /// to 50.
    /// </summary>
    [JsonPropertyName("rotationWindowPercentage")]
    public double? RotationWindowPercentage { get; set; }

    /// <summary>
    /// If set to true, the trust domain will utilize the GCP-provisioned default CA. A default
    /// CA in the same region as the workload will be selected to issue the certificate. Enabling
    /// this will clear any existing ca_pools configuration to provision the certificates.
    /// ~&gt; Note This field is mutually exclusive with ca_pools. If this flag is enabled,
    /// certificates will be automatically provisioned from the default shared CAs. This flag should
    /// not be set if you want to use your own CA pools to provision the certificates.
    /// </summary>
    [JsonPropertyName("useDefaultSharedCa")]
    public bool? UseDefaultSharedCa { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatusAtProviderInlineTrustConfigAdditionalTrustBundlesTrustAnchors
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one ca
    /// certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatusAtProviderInlineTrustConfigAdditionalTrustBundles
{
    /// <summary>
    /// List of Trust Anchors to be used while performing validation against a given
    /// TrustStore. The incoming end entity&apos;s certificate must be chained up to one of the
    /// trust anchors here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustAnchors")]
    public IList<V1beta1WorkloadIdentityPoolStatusAtProviderInlineTrustConfigAdditionalTrustBundlesTrustAnchors>? TrustAnchors { get; set; }

    /// <summary>
    /// If set to True, the trust bundle will include the private ca managed identity regional root
    /// public certificates.
    /// ~&gt; Note trust_default_shared_ca is only supported for managed identity trust domain
    /// resource.
    /// </summary>
    [JsonPropertyName("trustDefaultSharedCa")]
    public bool? TrustDefaultSharedCa { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("trustDomain")]
    public string? TrustDomain { get; set; }
}

/// <summary>
/// Represents config to add additional trusted trust domains. Defines configuration for extending
/// trust to additional trust domains. By establishing trust with another domain, the current
/// domain will recognize and accept certificates issued by entities within the trusted domains.
/// Note that a trust domain automatically trusts itself, eliminating the need for explicit
/// configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatusAtProviderInlineTrustConfig
{
    /// <summary>
    /// Maps specific trust domains (e.g., &quot;example.com&quot;) to their corresponding TrustStore
    /// objects, which contain the trusted root certificates for that domain. There can be a
    /// maximum of 10 trust domain entries in this map.
    /// Note that a trust domain automatically trusts itself and don&apos;t need to be specified here.
    /// If however, this WorkloadIdentityPool&apos;s trust domain contains any trust anchors in the
    /// additional_trust_bundles map, those trust anchors will be appended to the Trust Bundle
    /// automatically derived from your InlineCertificateIssuanceConfig&apos;s ca_pools.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalTrustBundles")]
    public IList<V1beta1WorkloadIdentityPoolStatusAtProviderInlineTrustConfigAdditionalTrustBundles>? AdditionalTrustBundles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatusAtProvider
{
    /// <summary>
    /// Defines which workloads can receive an identity within a pool. When an AttestationRule is
    /// defined under a managed identity, matching workloads may receive that identity. A maximum of
    /// 50 AttestationRules can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("attestationRules")]
    public IList<V1beta1WorkloadIdentityPoolStatusAtProviderAttestationRules>? AttestationRules { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A description of the pool. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use
    /// existing tokens to access resources. If the pool is re-enabled, existing tokens grant
    /// access again.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A display name for the pool. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/global/workloadIdentityPools/{{workload_identity_pool_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Represents configuration for generating mutual TLS (mTLS) certificates for the identities
    /// within this pool. Defines the Certificate Authority (CA) pool resources and configurations
    /// required for issuance and rotation of mTLS workload certificates.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineCertificateIssuanceConfig")]
    public V1beta1WorkloadIdentityPoolStatusAtProviderInlineCertificateIssuanceConfig? InlineCertificateIssuanceConfig { get; set; }

    /// <summary>
    /// Represents config to add additional trusted trust domains. Defines configuration for extending
    /// trust to additional trust domains. By establishing trust with another domain, the current
    /// domain will recognize and accept certificates issued by entities within the trusted domains.
    /// Note that a trust domain automatically trusts itself, eliminating the need for explicit
    /// configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineTrustConfig")]
    public V1beta1WorkloadIdentityPoolStatusAtProviderInlineTrustConfig? InlineTrustConfig { get; set; }

    /// <summary>
    /// The mode for the pool is operating in. Pools with an unspecified mode will operate as if they
    /// are in FEDERATION_ONLY mode.
    /// ~&gt; Note This field cannot be changed after the Workload Identity Pool is created.).
    /// To specify a different mode, please create a new Workload Identity Pool resource.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// The resource name of the pool as
    /// projects/{project_number}/locations/global/workloadIdentityPools/{workload_identity_pool_id}.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The state of the pool.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatusConditions
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

/// <summary>WorkloadIdentityPoolStatus defines the observed state of WorkloadIdentityPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WorkloadIdentityPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkloadIdentityPoolStatusConditions>? Conditions { get; set; }

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

/// <summary>WorkloadIdentityPool is the Schema for the WorkloadIdentityPools API. Represents a collection of external workload identities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkloadIdentityPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkloadIdentityPoolSpec>, IStatus<V1beta1WorkloadIdentityPoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkloadIdentityPool";
    public const string KubeGroup = "iam.gcp.m.upbound.io";
    public const string KubePluralName = "workloadidentitypools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkloadIdentityPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkloadIdentityPoolSpec defines the desired state of WorkloadIdentityPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WorkloadIdentityPoolSpec Spec { get; set; }

    /// <summary>WorkloadIdentityPoolStatus defines the observed state of WorkloadIdentityPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkloadIdentityPoolStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.gcp.upbound.io;
/// <summary>ReasoningEngine is the Schema for the ReasoningEngines API. ReasoningEngine provides a customizable runtime for models to determine which actions to take and in which order.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReasoningEngineList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ReasoningEngine>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReasoningEngineList";
    public const string KubeGroup = "vertexai.gcp.upbound.io";
    public const string KubePluralName = "reasoningengines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReasoningEngineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ReasoningEngine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ReasoningEngine> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecDeletionPolicyEnum>))]
public enum V1beta1ReasoningEngineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelector
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
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Optional. Customer-managed encryption key spec for a ReasoningEngine.
/// If set, this ReasoningEngine and all sub-resources of this ReasoningEngine
/// will be secured by this key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderEncryptionSpec
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed
    /// encryption key used to protect a resource. Has the form:
    /// projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// The key needs to be in the same region as where the compute resource
    /// is created.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpecKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
}

/// <summary>
/// Deploy from a container image with a defined entrypoint and commands.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecContainerSpec
{
    /// <summary>
    /// The Artifact Registry Docker image URI (e.g.,
    /// us-central1-docker.pkg.dev/my-project/my-repo/my-image:tag) of the
    /// container image that is to be run on each worker replica.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>Optional. Specifies the port number on the container to which the request is sent.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecEnv
{
    /// <summary>
    /// The name of the environment variable. Must be a valid C
    /// identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Variables that reference a $(VAR_NAME) are expanded using
    /// the previous defined environment variables in the container
    /// and any service environment variables. If a variable cannot
    /// be resolved, the reference in the input string will be
    /// unchanged. The $(VAR_NAME) syntax can be escaped with a
    /// double $$, ie: $$(VAR_NAME). Escaped references will never
    /// be expanded, regardless of whether the variable exists
    /// or not.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate targetNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate targetNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelector
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
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigs
{
    /// <summary>
    /// Required. The DNS name suffix of the zone being peered
    /// to, e.g., &quot;my-internal-domain.corp.&quot;.
    /// Must end with a dot.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Required. The VPC network name in the targetProject
    /// where the DNS zone specified by &apos;domain&apos; is visible.
    /// </summary>
    [JsonPropertyName("targetNetwork")]
    public string? TargetNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate targetNetwork.</summary>
    [JsonPropertyName("targetNetworkRef")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRef? TargetNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate targetNetwork.</summary>
    [JsonPropertyName("targetNetworkSelector")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelector? TargetNetworkSelector { get; set; }

    /// <summary>
    /// Required. The project id hosting the Cloud DNS managed
    /// zone that contains the &apos;domain&apos;.
    /// The Vertex AI service Agent requires the dns.peer role
    /// on this project.
    /// </summary>
    [JsonPropertyName("targetProject")]
    public string? TargetProject { get; set; }
}

/// <summary>
/// Optional. Configuration for PSC-Interface.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfig
{
    /// <summary>
    /// Optional. DNS peering configurations.
    /// When specified, Vertex AI will attempt to configure DNS
    /// peering zones in the tenant project VPC to resolve the
    /// specified domains using the target network&apos;s Cloud DNS.
    /// The user must grant the dns.peer role to the Vertex AI
    /// service Agent on the target project.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dnsPeeringConfigs")]
    public IList<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigs>? DnsPeeringConfigs { get; set; }

    /// <summary>
    /// Optional. The name of the Compute Engine network attachment
    /// to attach to the resource within the region and user project.
    /// To specify this field, you must have already created a network attachment.
    /// This field is only used for resources using PSC-Interface.
    /// </summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelector
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
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Reference to a secret stored in the Cloud Secret Manager
/// that will provide the value for this environment variable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRef
{
    /// <summary>
    /// The name of the secret in Cloud Secret Manager.
    /// Format: {secret_name}.
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelector? SecretSelector { get; set; }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &apos;latest&apos;
    /// for the latest version, an integer for a specific
    /// version, or a version alias.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnv
{
    /// <summary>
    /// The name of the environment variable. Must be a valid C
    /// identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Reference to a secret stored in the Cloud Secret Manager
    /// that will provide the value for this environment variable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnvSecretRef? SecretRef { get; set; }
}

/// <summary>
/// Optional. The specification of a Reasoning Engine deployment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpec
{
    /// <summary>
    /// Optional. Concurrency for each container and agent server.
    /// Recommended value: 2 * cpu + 1. Defaults to 9.
    /// </summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>
    /// Optional. Environment variables to be set with the Reasoning
    /// Engine deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecEnv>? Env { get; set; }

    /// <summary>
    /// Optional. The maximum number of application instances that can be
    /// launched to handle increased traffic. Defaults to 100.
    /// Range: [1, 1000]. If VPC-SC or PSC-I is enabled, the acceptable
    /// range is [1, 100].
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>
    /// Optional. The minimum number of application instances that will be
    /// kept running at all times. Defaults to 1. Range: [0, 10].
    /// </summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Optional. Configuration for PSC-Interface.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInterfaceConfig")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecPscInterfaceConfig? PscInterfaceConfig { get; set; }

    /// <summary>
    /// Optional. Resource limits for each container.
    /// Only &apos;cpu&apos; and &apos;memory&apos; keys are supported.
    /// Defaults to {&quot;cpu&quot;: &quot;4&quot;, &quot;memory&quot;: &quot;4Gi&quot;}.
    /// The only supported values for CPU are &apos;1&apos;, &apos;2&apos;, &apos;4&apos;, &apos;6&apos; and &apos;8&apos;.
    /// For more information, go to
    /// https://cloud.google.com/run/docs/configuring/cpu.
    /// The only supported values for memory are &apos;1Gi&apos;, &apos;2Gi&apos;, ... &apos;32 Gi&apos;.
    /// For more information, go to
    /// https://cloud.google.com/run/docs/configuring/memory-limits.
    /// </summary>
    [JsonPropertyName("resourceLimits")]
    public IDictionary<string, string>? ResourceLimits { get; set; }

    /// <summary>
    /// Optional. Environment variables where the value is a secret in
    /// Cloud Secret Manager. To use this feature, add &apos;Secret Manager
    /// Secret Accessor&apos; role (roles/secretmanager.secretAccessor) to AI
    /// Platform Reasoning Engine service Agent.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpecSecretEnv>? SecretEnv { get; set; }
}

/// <summary>
/// Optional. User provided package spec of the ReasoningEngine.
/// Ignored when users directly specify a deployment image through
/// deploymentSpec.first_party_image_override, but keeping the
/// field_behavior to avoid introducing breaking changes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecPackageSpec
{
    /// <summary>
    /// Optional. The Cloud Storage URI of the dependency files in tar.gz
    /// format.
    /// </summary>
    [JsonPropertyName("dependencyFilesGcsUri")]
    public string? DependencyFilesGcsUri { get; set; }

    /// <summary>Optional. The Cloud Storage URI of the pickled python object.</summary>
    [JsonPropertyName("pickleObjectGcsUri")]
    public string? PickleObjectGcsUri { get; set; }

    /// <summary>
    /// Optional. The Python version. Currently support 3.8, 3.9, 3.10,
    /// 3.11, 3.12, 3.13. If not specified, default value is 3.10.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>Optional. The Cloud Storage URI of the requirements.txtfile</summary>
    [JsonPropertyName("requirementsGcsUri")]
    public string? RequirementsGcsUri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelector
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
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Developer Connect configuration that defines the specific repository, revision, and directory to use as the source code root.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecDeveloperConnectSourceConfig
{
    /// <summary>Directory, relative to the source root, in which to run the build.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>The Developer Connect Git repository link, formatted as projects//locations//connections//gitRepositoryLink/.</summary>
    [JsonPropertyName("gitRepositoryLink")]
    public string? GitRepositoryLink { get; set; }

    /// <summary>The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git ref.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>
/// Specification for source code to be fetched from a Git repository managed through the Developer Connect service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecDeveloperConnectSource
{
    /// <summary>
    /// The Developer Connect configuration that defines the specific repository, revision, and directory to use as the source code root.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecDeveloperConnectSourceConfig? Config { get; set; }
}

/// <summary>
/// Configuration for building an image with custom config file.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecImageSpec
{
    /// <summary>Build arguments to be used. They will be passed through --build-arg flags.</summary>
    [JsonPropertyName("buildArgs")]
    public IDictionary<string, string>? BuildArgs { get; set; }
}

/// <summary>
/// Source code is provided directly in the request.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecInlineSource
{
    /// <summary>
    /// Required. Input only.
    /// The application source code archive, provided as a compressed
    /// tarball (.tar.gz) file. A base64-encoded string.
    /// </summary>
    [JsonPropertyName("sourceArchive")]
    public string? SourceArchive { get; set; }
}

/// <summary>
/// Specification for running a Python application from source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecPythonSpec
{
    /// <summary>
    /// Optional. The Python module to load as the entrypoint,
    /// specified as a fully qualified module name. For example:
    /// path.to.agent. If not specified, defaults to &quot;agent&quot;.
    /// The project root will be added to Python sys.path, allowing
    /// imports to be specified relative to the root.
    /// </summary>
    [JsonPropertyName("entrypointModule")]
    public string? EntrypointModule { get; set; }

    /// <summary>
    /// Optional. The name of the callable object within the
    /// entrypointModule to use as the application If not specified,
    /// defaults to &quot;root_agent&quot;.
    /// </summary>
    [JsonPropertyName("entrypointObject")]
    public string? EntrypointObject { get; set; }

    /// <summary>
    /// Optional. The path to the requirements file, relative to the
    /// source root. If not specified, defaults to &quot;requirements.txt&quot;.
    /// </summary>
    [JsonPropertyName("requirementsFile")]
    public string? RequirementsFile { get; set; }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &apos;latest&apos;
    /// for the latest version, an integer for a specific
    /// version, or a version alias.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Specification for deploying from source code.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpec
{
    /// <summary>
    /// Specification for source code to be fetched from a Git repository managed through the Developer Connect service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("developerConnectSource")]
    public V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecDeveloperConnectSource? DeveloperConnectSource { get; set; }

    /// <summary>
    /// Configuration for building an image with custom config file.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageSpec")]
    public V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecImageSpec? ImageSpec { get; set; }

    /// <summary>
    /// Source code is provided directly in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineSource")]
    public V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecInlineSource? InlineSource { get; set; }

    /// <summary>
    /// Specification for running a Python application from source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonSpec")]
    public V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpecPythonSpec? PythonSpec { get; set; }
}

/// <summary>
/// Optional. Configurations of the ReasoningEngine.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProviderSpec
{
    /// <summary>Optional. The OSS agent framework used to develop the agent.</summary>
    [JsonPropertyName("agentFramework")]
    public string? AgentFramework { get; set; }

    /// <summary>
    /// Optional. Declarations for object class methods in OpenAPI
    /// specification format.
    /// Otherwise, client SDKs (like agent_engines.get()) will not be able to discover the methods, and calls to the engine (or A2A integrations) will fail.
    /// Depending on the template/framework used (agent_framework), the required class methods and their parameters differ:
    /// Warning: The configuration snippets below are illustrative, may not be exhaustive, and could stop working over time. For the most up-to-date method lists and schemas, please consult the respective SDK source code:
    /// </summary>
    [JsonPropertyName("classMethods")]
    public string? ClassMethods { get; set; }

    /// <summary>
    /// Deploy from a container image with a defined entrypoint and commands.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("containerSpec")]
    public V1beta1ReasoningEngineSpecForProviderSpecContainerSpec? ContainerSpec { get; set; }

    /// <summary>
    /// Optional. The specification of a Reasoning Engine deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deploymentSpec")]
    public V1beta1ReasoningEngineSpecForProviderSpecDeploymentSpec? DeploymentSpec { get; set; }

    /// <summary>
    /// Optional. The identity type to use for the Reasoning Engine.
    /// If not specified, the service_account field will be used if set,
    /// otherwise the default Vertex AI Reasoning Engine Service Agent in the project will be used.
    /// Possible values:
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Optional. User provided package spec of the ReasoningEngine.
    /// Ignored when users directly specify a deployment image through
    /// deploymentSpec.first_party_image_override, but keeping the
    /// field_behavior to avoid introducing breaking changes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("packageSpec")]
    public V1beta1ReasoningEngineSpecForProviderSpecPackageSpec? PackageSpec { get; set; }

    /// <summary>
    /// Optional. The service account that the Reasoning Engine artifact runs
    /// as. It should have &quot;roles/storage.objectViewer&quot; for reading the user
    /// project&apos;s Cloud Storage and &quot;roles/aiplatform.user&quot; for using Vertex
    /// extensions. If not specified, the Vertex AI Reasoning Engine service
    /// Agent in the project will be used.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1ReasoningEngineSpecForProviderSpecServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// Specification for deploying from source code.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceCodeSpec")]
    public V1beta1ReasoningEngineSpecForProviderSpecSourceCodeSpec? SourceCodeSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecForProvider
{
    /// <summary>
    /// Optional. The deletion policy for the reasoning engine.
    /// Setting this to FORCE allows the reasoning engine to be deleted regardless of child undeleted resources.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>The description of the ReasoningEngine.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the ReasoningEngine.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Optional. Customer-managed encryption key spec for a ReasoningEngine.
    /// If set, this ReasoningEngine and all sub-resources of this ReasoningEngine
    /// will be secured by this key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1ReasoningEngineSpecForProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>
    /// The labels associated with this ReasoningEngine. You can use these to
    /// organize and group your ReasoningEngines.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the reasoning engine. eg us-central1</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Optional. Configurations of the ReasoningEngine.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1ReasoningEngineSpecForProviderSpec? Spec { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelector
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
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Optional. Customer-managed encryption key spec for a ReasoningEngine.
/// If set, this ReasoningEngine and all sub-resources of this ReasoningEngine
/// will be secured by this key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderEncryptionSpec
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed
    /// encryption key used to protect a resource. Has the form:
    /// projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// The key needs to be in the same region as where the compute resource
    /// is created.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpecKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
}

/// <summary>
/// Deploy from a container image with a defined entrypoint and commands.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecContainerSpec
{
    /// <summary>
    /// The Artifact Registry Docker image URI (e.g.,
    /// us-central1-docker.pkg.dev/my-project/my-repo/my-image:tag) of the
    /// container image that is to be run on each worker replica.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>Optional. Specifies the port number on the container to which the request is sent.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecEnv
{
    /// <summary>
    /// The name of the environment variable. Must be a valid C
    /// identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Variables that reference a $(VAR_NAME) are expanded using
    /// the previous defined environment variables in the container
    /// and any service environment variables. If a variable cannot
    /// be resolved, the reference in the input string will be
    /// unchanged. The $(VAR_NAME) syntax can be escaped with a
    /// double $$, ie: $$(VAR_NAME). Escaped references will never
    /// be expanded, regardless of whether the variable exists
    /// or not.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate targetNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate targetNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelector
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
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigs
{
    /// <summary>
    /// Required. The DNS name suffix of the zone being peered
    /// to, e.g., &quot;my-internal-domain.corp.&quot;.
    /// Must end with a dot.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Required. The VPC network name in the targetProject
    /// where the DNS zone specified by &apos;domain&apos; is visible.
    /// </summary>
    [JsonPropertyName("targetNetwork")]
    public string? TargetNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate targetNetwork.</summary>
    [JsonPropertyName("targetNetworkRef")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRef? TargetNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate targetNetwork.</summary>
    [JsonPropertyName("targetNetworkSelector")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkSelector? TargetNetworkSelector { get; set; }

    /// <summary>
    /// Required. The project id hosting the Cloud DNS managed
    /// zone that contains the &apos;domain&apos;.
    /// The Vertex AI service Agent requires the dns.peer role
    /// on this project.
    /// </summary>
    [JsonPropertyName("targetProject")]
    public string? TargetProject { get; set; }
}

/// <summary>
/// Optional. Configuration for PSC-Interface.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfig
{
    /// <summary>
    /// Optional. DNS peering configurations.
    /// When specified, Vertex AI will attempt to configure DNS
    /// peering zones in the tenant project VPC to resolve the
    /// specified domains using the target network&apos;s Cloud DNS.
    /// The user must grant the dns.peer role to the Vertex AI
    /// service Agent on the target project.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dnsPeeringConfigs")]
    public IList<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigs>? DnsPeeringConfigs { get; set; }

    /// <summary>
    /// Optional. The name of the Compute Engine network attachment
    /// to attach to the resource within the region and user project.
    /// To specify this field, you must have already created a network attachment.
    /// This field is only used for resources using PSC-Interface.
    /// </summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelector
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
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Reference to a secret stored in the Cloud Secret Manager
/// that will provide the value for this environment variable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRef
{
    /// <summary>
    /// The name of the secret in Cloud Secret Manager.
    /// Format: {secret_name}.
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRefSecretSelector? SecretSelector { get; set; }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &apos;latest&apos;
    /// for the latest version, an integer for a specific
    /// version, or a version alias.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnv
{
    /// <summary>
    /// The name of the environment variable. Must be a valid C
    /// identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Reference to a secret stored in the Cloud Secret Manager
    /// that will provide the value for this environment variable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnvSecretRef? SecretRef { get; set; }
}

/// <summary>
/// Optional. The specification of a Reasoning Engine deployment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpec
{
    /// <summary>
    /// Optional. Concurrency for each container and agent server.
    /// Recommended value: 2 * cpu + 1. Defaults to 9.
    /// </summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>
    /// Optional. Environment variables to be set with the Reasoning
    /// Engine deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecEnv>? Env { get; set; }

    /// <summary>
    /// Optional. The maximum number of application instances that can be
    /// launched to handle increased traffic. Defaults to 100.
    /// Range: [1, 1000]. If VPC-SC or PSC-I is enabled, the acceptable
    /// range is [1, 100].
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>
    /// Optional. The minimum number of application instances that will be
    /// kept running at all times. Defaults to 1. Range: [0, 10].
    /// </summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Optional. Configuration for PSC-Interface.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInterfaceConfig")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecPscInterfaceConfig? PscInterfaceConfig { get; set; }

    /// <summary>
    /// Optional. Resource limits for each container.
    /// Only &apos;cpu&apos; and &apos;memory&apos; keys are supported.
    /// Defaults to {&quot;cpu&quot;: &quot;4&quot;, &quot;memory&quot;: &quot;4Gi&quot;}.
    /// The only supported values for CPU are &apos;1&apos;, &apos;2&apos;, &apos;4&apos;, &apos;6&apos; and &apos;8&apos;.
    /// For more information, go to
    /// https://cloud.google.com/run/docs/configuring/cpu.
    /// The only supported values for memory are &apos;1Gi&apos;, &apos;2Gi&apos;, ... &apos;32 Gi&apos;.
    /// For more information, go to
    /// https://cloud.google.com/run/docs/configuring/memory-limits.
    /// </summary>
    [JsonPropertyName("resourceLimits")]
    public IDictionary<string, string>? ResourceLimits { get; set; }

    /// <summary>
    /// Optional. Environment variables where the value is a secret in
    /// Cloud Secret Manager. To use this feature, add &apos;Secret Manager
    /// Secret Accessor&apos; role (roles/secretmanager.secretAccessor) to AI
    /// Platform Reasoning Engine service Agent.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpecSecretEnv>? SecretEnv { get; set; }
}

/// <summary>
/// Optional. User provided package spec of the ReasoningEngine.
/// Ignored when users directly specify a deployment image through
/// deploymentSpec.first_party_image_override, but keeping the
/// field_behavior to avoid introducing breaking changes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecPackageSpec
{
    /// <summary>
    /// Optional. The Cloud Storage URI of the dependency files in tar.gz
    /// format.
    /// </summary>
    [JsonPropertyName("dependencyFilesGcsUri")]
    public string? DependencyFilesGcsUri { get; set; }

    /// <summary>Optional. The Cloud Storage URI of the pickled python object.</summary>
    [JsonPropertyName("pickleObjectGcsUri")]
    public string? PickleObjectGcsUri { get; set; }

    /// <summary>
    /// Optional. The Python version. Currently support 3.8, 3.9, 3.10,
    /// 3.11, 3.12, 3.13. If not specified, default value is 3.10.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>Optional. The Cloud Storage URI of the requirements.txtfile</summary>
    [JsonPropertyName("requirementsGcsUri")]
    public string? RequirementsGcsUri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelector
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
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Developer Connect configuration that defines the specific repository, revision, and directory to use as the source code root.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecDeveloperConnectSourceConfig
{
    /// <summary>Directory, relative to the source root, in which to run the build.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>The Developer Connect Git repository link, formatted as projects//locations//connections//gitRepositoryLink/.</summary>
    [JsonPropertyName("gitRepositoryLink")]
    public string? GitRepositoryLink { get; set; }

    /// <summary>The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git ref.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>
/// Specification for source code to be fetched from a Git repository managed through the Developer Connect service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecDeveloperConnectSource
{
    /// <summary>
    /// The Developer Connect configuration that defines the specific repository, revision, and directory to use as the source code root.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecDeveloperConnectSourceConfig? Config { get; set; }
}

/// <summary>
/// Configuration for building an image with custom config file.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecImageSpec
{
    /// <summary>Build arguments to be used. They will be passed through --build-arg flags.</summary>
    [JsonPropertyName("buildArgs")]
    public IDictionary<string, string>? BuildArgs { get; set; }
}

/// <summary>
/// Source code is provided directly in the request.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecInlineSource
{
    /// <summary>
    /// Required. Input only.
    /// The application source code archive, provided as a compressed
    /// tarball (.tar.gz) file. A base64-encoded string.
    /// </summary>
    [JsonPropertyName("sourceArchive")]
    public string? SourceArchive { get; set; }
}

/// <summary>
/// Specification for running a Python application from source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecPythonSpec
{
    /// <summary>
    /// Optional. The Python module to load as the entrypoint,
    /// specified as a fully qualified module name. For example:
    /// path.to.agent. If not specified, defaults to &quot;agent&quot;.
    /// The project root will be added to Python sys.path, allowing
    /// imports to be specified relative to the root.
    /// </summary>
    [JsonPropertyName("entrypointModule")]
    public string? EntrypointModule { get; set; }

    /// <summary>
    /// Optional. The name of the callable object within the
    /// entrypointModule to use as the application If not specified,
    /// defaults to &quot;root_agent&quot;.
    /// </summary>
    [JsonPropertyName("entrypointObject")]
    public string? EntrypointObject { get; set; }

    /// <summary>
    /// Optional. The path to the requirements file, relative to the
    /// source root. If not specified, defaults to &quot;requirements.txt&quot;.
    /// </summary>
    [JsonPropertyName("requirementsFile")]
    public string? RequirementsFile { get; set; }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &apos;latest&apos;
    /// for the latest version, an integer for a specific
    /// version, or a version alias.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Specification for deploying from source code.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpec
{
    /// <summary>
    /// Specification for source code to be fetched from a Git repository managed through the Developer Connect service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("developerConnectSource")]
    public V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecDeveloperConnectSource? DeveloperConnectSource { get; set; }

    /// <summary>
    /// Configuration for building an image with custom config file.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageSpec")]
    public V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecImageSpec? ImageSpec { get; set; }

    /// <summary>
    /// Source code is provided directly in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineSource")]
    public V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecInlineSource? InlineSource { get; set; }

    /// <summary>
    /// Specification for running a Python application from source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonSpec")]
    public V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpecPythonSpec? PythonSpec { get; set; }
}

/// <summary>
/// Optional. Configurations of the ReasoningEngine.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecInitProviderSpec
{
    /// <summary>Optional. The OSS agent framework used to develop the agent.</summary>
    [JsonPropertyName("agentFramework")]
    public string? AgentFramework { get; set; }

    /// <summary>
    /// Optional. Declarations for object class methods in OpenAPI
    /// specification format.
    /// Otherwise, client SDKs (like agent_engines.get()) will not be able to discover the methods, and calls to the engine (or A2A integrations) will fail.
    /// Depending on the template/framework used (agent_framework), the required class methods and their parameters differ:
    /// Warning: The configuration snippets below are illustrative, may not be exhaustive, and could stop working over time. For the most up-to-date method lists and schemas, please consult the respective SDK source code:
    /// </summary>
    [JsonPropertyName("classMethods")]
    public string? ClassMethods { get; set; }

    /// <summary>
    /// Deploy from a container image with a defined entrypoint and commands.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("containerSpec")]
    public V1beta1ReasoningEngineSpecInitProviderSpecContainerSpec? ContainerSpec { get; set; }

    /// <summary>
    /// Optional. The specification of a Reasoning Engine deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deploymentSpec")]
    public V1beta1ReasoningEngineSpecInitProviderSpecDeploymentSpec? DeploymentSpec { get; set; }

    /// <summary>
    /// Optional. The identity type to use for the Reasoning Engine.
    /// If not specified, the service_account field will be used if set,
    /// otherwise the default Vertex AI Reasoning Engine Service Agent in the project will be used.
    /// Possible values:
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Optional. User provided package spec of the ReasoningEngine.
    /// Ignored when users directly specify a deployment image through
    /// deploymentSpec.first_party_image_override, but keeping the
    /// field_behavior to avoid introducing breaking changes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("packageSpec")]
    public V1beta1ReasoningEngineSpecInitProviderSpecPackageSpec? PackageSpec { get; set; }

    /// <summary>
    /// Optional. The service account that the Reasoning Engine artifact runs
    /// as. It should have &quot;roles/storage.objectViewer&quot; for reading the user
    /// project&apos;s Cloud Storage and &quot;roles/aiplatform.user&quot; for using Vertex
    /// extensions. If not specified, the Vertex AI Reasoning Engine service
    /// Agent in the project will be used.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1ReasoningEngineSpecInitProviderSpecServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// Specification for deploying from source code.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceCodeSpec")]
    public V1beta1ReasoningEngineSpecInitProviderSpecSourceCodeSpec? SourceCodeSpec { get; set; }
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
public partial class V1beta1ReasoningEngineSpecInitProvider
{
    /// <summary>
    /// Optional. The deletion policy for the reasoning engine.
    /// Setting this to FORCE allows the reasoning engine to be deleted regardless of child undeleted resources.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>The description of the ReasoningEngine.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the ReasoningEngine.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Optional. Customer-managed encryption key spec for a ReasoningEngine.
    /// If set, this ReasoningEngine and all sub-resources of this ReasoningEngine
    /// will be secured by this key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1ReasoningEngineSpecInitProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>
    /// The labels associated with this ReasoningEngine. You can use these to
    /// organize and group your ReasoningEngines.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the reasoning engine. eg us-central1</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Optional. Configurations of the ReasoningEngine.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1ReasoningEngineSpecInitProviderSpec? Spec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecManagementPoliciesEnum>))]
public enum V1beta1ReasoningEngineSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1ReasoningEngineSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReasoningEngineSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1ReasoningEngineSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReasoningEngineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReasoningEngineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReasoningEngineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ReasoningEngineSpec defines the desired state of ReasoningEngine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineSpec
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
    public V1beta1ReasoningEngineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ReasoningEngineSpecForProvider ForProvider { get; set; }

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
    public V1beta1ReasoningEngineSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ReasoningEngineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReasoningEngineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReasoningEngineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Optional. Customer-managed encryption key spec for a ReasoningEngine.
/// If set, this ReasoningEngine and all sub-resources of this ReasoningEngine
/// will be secured by this key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderEncryptionSpec
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed
    /// encryption key used to protect a resource. Has the form:
    /// projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// The key needs to be in the same region as where the compute resource
    /// is created.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Deploy from a container image with a defined entrypoint and commands.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecContainerSpec
{
    /// <summary>
    /// The Artifact Registry Docker image URI (e.g.,
    /// us-central1-docker.pkg.dev/my-project/my-repo/my-image:tag) of the
    /// container image that is to be run on each worker replica.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>Optional. Specifies the port number on the container to which the request is sent.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecEnv
{
    /// <summary>
    /// The name of the environment variable. Must be a valid C
    /// identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Variables that reference a $(VAR_NAME) are expanded using
    /// the previous defined environment variables in the container
    /// and any service environment variables. If a variable cannot
    /// be resolved, the reference in the input string will be
    /// unchanged. The $(VAR_NAME) syntax can be escaped with a
    /// double $$, ie: $$(VAR_NAME). Escaped references will never
    /// be expanded, regardless of whether the variable exists
    /// or not.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigs
{
    /// <summary>
    /// Required. The DNS name suffix of the zone being peered
    /// to, e.g., &quot;my-internal-domain.corp.&quot;.
    /// Must end with a dot.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Required. The VPC network name in the targetProject
    /// where the DNS zone specified by &apos;domain&apos; is visible.
    /// </summary>
    [JsonPropertyName("targetNetwork")]
    public string? TargetNetwork { get; set; }

    /// <summary>
    /// Required. The project id hosting the Cloud DNS managed
    /// zone that contains the &apos;domain&apos;.
    /// The Vertex AI service Agent requires the dns.peer role
    /// on this project.
    /// </summary>
    [JsonPropertyName("targetProject")]
    public string? TargetProject { get; set; }
}

/// <summary>
/// Optional. Configuration for PSC-Interface.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecPscInterfaceConfig
{
    /// <summary>
    /// Optional. DNS peering configurations.
    /// When specified, Vertex AI will attempt to configure DNS
    /// peering zones in the tenant project VPC to resolve the
    /// specified domains using the target network&apos;s Cloud DNS.
    /// The user must grant the dns.peer role to the Vertex AI
    /// service Agent on the target project.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dnsPeeringConfigs")]
    public IList<V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecPscInterfaceConfigDnsPeeringConfigs>? DnsPeeringConfigs { get; set; }

    /// <summary>
    /// Optional. The name of the Compute Engine network attachment
    /// to attach to the resource within the region and user project.
    /// To specify this field, you must have already created a network attachment.
    /// This field is only used for resources using PSC-Interface.
    /// </summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }
}

/// <summary>
/// Reference to a secret stored in the Cloud Secret Manager
/// that will provide the value for this environment variable.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecSecretEnvSecretRef
{
    /// <summary>
    /// The name of the secret in Cloud Secret Manager.
    /// Format: {secret_name}.
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &apos;latest&apos;
    /// for the latest version, an integer for a specific
    /// version, or a version alias.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecSecretEnv
{
    /// <summary>
    /// The name of the environment variable. Must be a valid C
    /// identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Reference to a secret stored in the Cloud Secret Manager
    /// that will provide the value for this environment variable.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecSecretEnvSecretRef? SecretRef { get; set; }
}

/// <summary>
/// Optional. The specification of a Reasoning Engine deployment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpec
{
    /// <summary>
    /// Optional. Concurrency for each container and agent server.
    /// Recommended value: 2 * cpu + 1. Defaults to 9.
    /// </summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>
    /// Optional. Environment variables to be set with the Reasoning
    /// Engine deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecEnv>? Env { get; set; }

    /// <summary>
    /// Optional. The maximum number of application instances that can be
    /// launched to handle increased traffic. Defaults to 100.
    /// Range: [1, 1000]. If VPC-SC or PSC-I is enabled, the acceptable
    /// range is [1, 100].
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>
    /// Optional. The minimum number of application instances that will be
    /// kept running at all times. Defaults to 1. Range: [0, 10].
    /// </summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Optional. Configuration for PSC-Interface.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscInterfaceConfig")]
    public V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecPscInterfaceConfig? PscInterfaceConfig { get; set; }

    /// <summary>
    /// Optional. Resource limits for each container.
    /// Only &apos;cpu&apos; and &apos;memory&apos; keys are supported.
    /// Defaults to {&quot;cpu&quot;: &quot;4&quot;, &quot;memory&quot;: &quot;4Gi&quot;}.
    /// The only supported values for CPU are &apos;1&apos;, &apos;2&apos;, &apos;4&apos;, &apos;6&apos; and &apos;8&apos;.
    /// For more information, go to
    /// https://cloud.google.com/run/docs/configuring/cpu.
    /// The only supported values for memory are &apos;1Gi&apos;, &apos;2Gi&apos;, ... &apos;32 Gi&apos;.
    /// For more information, go to
    /// https://cloud.google.com/run/docs/configuring/memory-limits.
    /// </summary>
    [JsonPropertyName("resourceLimits")]
    public IDictionary<string, string>? ResourceLimits { get; set; }

    /// <summary>
    /// Optional. Environment variables where the value is a secret in
    /// Cloud Secret Manager. To use this feature, add &apos;Secret Manager
    /// Secret Accessor&apos; role (roles/secretmanager.secretAccessor) to AI
    /// Platform Reasoning Engine service Agent.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretEnv")]
    public IList<V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpecSecretEnv>? SecretEnv { get; set; }
}

/// <summary>
/// Optional. User provided package spec of the ReasoningEngine.
/// Ignored when users directly specify a deployment image through
/// deploymentSpec.first_party_image_override, but keeping the
/// field_behavior to avoid introducing breaking changes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecPackageSpec
{
    /// <summary>
    /// Optional. The Cloud Storage URI of the dependency files in tar.gz
    /// format.
    /// </summary>
    [JsonPropertyName("dependencyFilesGcsUri")]
    public string? DependencyFilesGcsUri { get; set; }

    /// <summary>Optional. The Cloud Storage URI of the pickled python object.</summary>
    [JsonPropertyName("pickleObjectGcsUri")]
    public string? PickleObjectGcsUri { get; set; }

    /// <summary>
    /// Optional. The Python version. Currently support 3.8, 3.9, 3.10,
    /// 3.11, 3.12, 3.13. If not specified, default value is 3.10.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>Optional. The Cloud Storage URI of the requirements.txtfile</summary>
    [JsonPropertyName("requirementsGcsUri")]
    public string? RequirementsGcsUri { get; set; }
}

/// <summary>
/// The Developer Connect configuration that defines the specific repository, revision, and directory to use as the source code root.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecDeveloperConnectSourceConfig
{
    /// <summary>Directory, relative to the source root, in which to run the build.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>The Developer Connect Git repository link, formatted as projects//locations//connections//gitRepositoryLink/.</summary>
    [JsonPropertyName("gitRepositoryLink")]
    public string? GitRepositoryLink { get; set; }

    /// <summary>The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git ref.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>
/// Specification for source code to be fetched from a Git repository managed through the Developer Connect service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecDeveloperConnectSource
{
    /// <summary>
    /// The Developer Connect configuration that defines the specific repository, revision, and directory to use as the source code root.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecDeveloperConnectSourceConfig? Config { get; set; }
}

/// <summary>
/// Configuration for building an image with custom config file.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecImageSpec
{
    /// <summary>Build arguments to be used. They will be passed through --build-arg flags.</summary>
    [JsonPropertyName("buildArgs")]
    public IDictionary<string, string>? BuildArgs { get; set; }
}

/// <summary>
/// Source code is provided directly in the request.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecInlineSource
{
    /// <summary>
    /// Required. Input only.
    /// The application source code archive, provided as a compressed
    /// tarball (.tar.gz) file. A base64-encoded string.
    /// </summary>
    [JsonPropertyName("sourceArchive")]
    public string? SourceArchive { get; set; }
}

/// <summary>
/// Specification for running a Python application from source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecPythonSpec
{
    /// <summary>
    /// Optional. The Python module to load as the entrypoint,
    /// specified as a fully qualified module name. For example:
    /// path.to.agent. If not specified, defaults to &quot;agent&quot;.
    /// The project root will be added to Python sys.path, allowing
    /// imports to be specified relative to the root.
    /// </summary>
    [JsonPropertyName("entrypointModule")]
    public string? EntrypointModule { get; set; }

    /// <summary>
    /// Optional. The name of the callable object within the
    /// entrypointModule to use as the application If not specified,
    /// defaults to &quot;root_agent&quot;.
    /// </summary>
    [JsonPropertyName("entrypointObject")]
    public string? EntrypointObject { get; set; }

    /// <summary>
    /// Optional. The path to the requirements file, relative to the
    /// source root. If not specified, defaults to &quot;requirements.txt&quot;.
    /// </summary>
    [JsonPropertyName("requirementsFile")]
    public string? RequirementsFile { get; set; }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &apos;latest&apos;
    /// for the latest version, an integer for a specific
    /// version, or a version alias.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Specification for deploying from source code.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpec
{
    /// <summary>
    /// Specification for source code to be fetched from a Git repository managed through the Developer Connect service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("developerConnectSource")]
    public V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecDeveloperConnectSource? DeveloperConnectSource { get; set; }

    /// <summary>
    /// Configuration for building an image with custom config file.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageSpec")]
    public V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecImageSpec? ImageSpec { get; set; }

    /// <summary>
    /// Source code is provided directly in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inlineSource")]
    public V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecInlineSource? InlineSource { get; set; }

    /// <summary>
    /// Specification for running a Python application from source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonSpec")]
    public V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpecPythonSpec? PythonSpec { get; set; }
}

/// <summary>
/// Optional. Configurations of the ReasoningEngine.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProviderSpec
{
    /// <summary>Optional. The OSS agent framework used to develop the agent.</summary>
    [JsonPropertyName("agentFramework")]
    public string? AgentFramework { get; set; }

    /// <summary>
    /// Optional. Declarations for object class methods in OpenAPI
    /// specification format.
    /// Otherwise, client SDKs (like agent_engines.get()) will not be able to discover the methods, and calls to the engine (or A2A integrations) will fail.
    /// Depending on the template/framework used (agent_framework), the required class methods and their parameters differ:
    /// Warning: The configuration snippets below are illustrative, may not be exhaustive, and could stop working over time. For the most up-to-date method lists and schemas, please consult the respective SDK source code:
    /// </summary>
    [JsonPropertyName("classMethods")]
    public string? ClassMethods { get; set; }

    /// <summary>
    /// Deploy from a container image with a defined entrypoint and commands.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("containerSpec")]
    public V1beta1ReasoningEngineStatusAtProviderSpecContainerSpec? ContainerSpec { get; set; }

    /// <summary>
    /// Optional. The specification of a Reasoning Engine deployment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deploymentSpec")]
    public V1beta1ReasoningEngineStatusAtProviderSpecDeploymentSpec? DeploymentSpec { get; set; }

    /// <summary>
    /// (Output)
    /// The identity to use for the Reasoning Engine.
    /// </summary>
    [JsonPropertyName("effectiveIdentity")]
    public string? EffectiveIdentity { get; set; }

    /// <summary>
    /// Optional. The identity type to use for the Reasoning Engine.
    /// If not specified, the service_account field will be used if set,
    /// otherwise the default Vertex AI Reasoning Engine Service Agent in the project will be used.
    /// Possible values:
    /// </summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>
    /// Optional. User provided package spec of the ReasoningEngine.
    /// Ignored when users directly specify a deployment image through
    /// deploymentSpec.first_party_image_override, but keeping the
    /// field_behavior to avoid introducing breaking changes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("packageSpec")]
    public V1beta1ReasoningEngineStatusAtProviderSpecPackageSpec? PackageSpec { get; set; }

    /// <summary>
    /// Optional. The service account that the Reasoning Engine artifact runs
    /// as. It should have &quot;roles/storage.objectViewer&quot; for reading the user
    /// project&apos;s Cloud Storage and &quot;roles/aiplatform.user&quot; for using Vertex
    /// extensions. If not specified, the Vertex AI Reasoning Engine service
    /// Agent in the project will be used.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>
    /// Specification for deploying from source code.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceCodeSpec")]
    public V1beta1ReasoningEngineStatusAtProviderSpecSourceCodeSpec? SourceCodeSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusAtProvider
{
    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &quot;Zulu&quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Optional. The deletion policy for the reasoning engine.
    /// Setting this to FORCE allows the reasoning engine to be deleted regardless of child undeleted resources.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>The description of the ReasoningEngine.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the ReasoningEngine.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Optional. Customer-managed encryption key spec for a ReasoningEngine.
    /// If set, this ReasoningEngine and all sub-resources of this ReasoningEngine
    /// will be secured by this key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1ReasoningEngineStatusAtProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/reasoningEngines/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The labels associated with this ReasoningEngine. You can use these to
    /// organize and group your ReasoningEngines.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The generated name of the ReasoningEngine, in the format
    /// projects/{project}/locations/{location}/reasoningEngines/{reasoningEngine}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the reasoning engine. eg us-central1</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Optional. Configurations of the ReasoningEngine.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1ReasoningEngineStatusAtProviderSpec? Spec { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &quot;Zulu&quot;
    /// format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatusConditions
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

/// <summary>ReasoningEngineStatus defines the observed state of ReasoningEngine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReasoningEngineStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ReasoningEngineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReasoningEngineStatusConditions>? Conditions { get; set; }

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

/// <summary>ReasoningEngine is the Schema for the ReasoningEngines API. ReasoningEngine provides a customizable runtime for models to determine which actions to take and in which order.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReasoningEngine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReasoningEngineSpec>, IStatus<V1beta1ReasoningEngineStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReasoningEngine";
    public const string KubeGroup = "vertexai.gcp.upbound.io";
    public const string KubePluralName = "reasoningengines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReasoningEngine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReasoningEngineSpec defines the desired state of ReasoningEngine</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ReasoningEngineSpec Spec { get; set; }

    /// <summary>ReasoningEngineStatus defines the observed state of ReasoningEngine.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReasoningEngineStatus? Status { get; set; }
}
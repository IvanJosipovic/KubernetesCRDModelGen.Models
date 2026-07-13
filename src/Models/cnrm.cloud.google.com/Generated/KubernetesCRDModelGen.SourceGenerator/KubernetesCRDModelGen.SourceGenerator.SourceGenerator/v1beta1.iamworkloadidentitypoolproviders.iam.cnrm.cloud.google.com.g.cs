#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMWorkloadIdentityPoolProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IAMWorkloadIdentityPoolProvider>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMWorkloadIdentityPoolProviderList";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamworkloadidentitypoolproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMWorkloadIdentityPoolProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1IAMWorkloadIdentityPoolProvider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1IAMWorkloadIdentityPoolProvider> Items { get; set; }
}

/// <summary>An Amazon Web Services identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMWorkloadIdentityPoolProviderSpecAws
{
    /// <summary>Required. The AWS account ID.</summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>A list of AWS STS URIs that can be used when exchanging credentials. If not provided, any valid AWS STS URI is allowed. URIs must use the form `https://sts.amazonaws.com` or `https://sts.{region}.amazonaws.com`, where {region} is a valid AWS region. You can specify a maximum of 25 URIs.</summary>
    [JsonPropertyName("stsUri")]
    public IList<string>? StsUri { get; set; }
}

/// <summary>An OpenId Connect 1.0 identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMWorkloadIdentityPoolProviderSpecOidc
{
    /// <summary>Acceptable values for the `aud` field (audience) in the OIDC token. Token exchange requests are rejected if the token audience does not match one of the configured values. Each audience may be at most 256 characters. A maximum of 10 audiences may be configured. If this list is empty, the OIDC token audience must be equal to the full canonical resource name of the WorkloadIdentityPoolProvider, with or without the HTTPS prefix. For example: ``` //iam.googleapis.com/projects//locations//workloadIdentityPools//providers/ https://iam.googleapis.com/projects//locations//workloadIdentityPools//providers/ ```</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>Required. The OIDC issuer URL. Must be an HTTPS endpoint.</summary>
    [JsonPropertyName("issuerUri")]
    public required string IssuerUri { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMWorkloadIdentityPoolProviderSpecProjectRef
{
    /// <summary>
    /// The project for the resource
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

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMWorkloadIdentityPoolProviderSpecWorkloadIdentityPoolRef
{
    /// <summary>
    /// The workloadIdentityPool for the resource
    /// 
    /// Allowed value: The Google Cloud resource name of an `IAMWorkloadIdentityPool` resource (format: `projects/{{project}}/locations/{{location}}/workloadIdentityPools/{{name}}`).
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
public partial class V1beta1IAMWorkloadIdentityPoolProviderSpec
{
    /// <summary>[A Common Expression Language](https://opensource.google/projects/cel) expression, in plain text, to restrict what otherwise valid authentication credentials issued by the provider should not be accepted. The expression must output a boolean representing whether to allow the federation. The following keywords may be referenced in the expressions: * `assertion`: JSON representing the authentication credential issued by the provider. * `google`: The Google attributes mapped from the assertion in the `attribute_mappings`. * `attribute`: The custom attributes mapped from the assertion in the `attribute_mappings`. The maximum length of the attribute condition expression is 4096 characters. If unspecified, all valid authentication credential are accepted. The following example shows how to only allow credentials with a mapped `google.groups` value of `admins`: ``` &quot; &apos;admins&apos; in google.groups&quot; ```</summary>
    [JsonPropertyName("attributeCondition")]
    public string? AttributeCondition { get; set; }

    /// <summary>Maps attributes from authentication credentials issued by an external identity provider to Google Cloud attributes, such as `subject` and `segment`. Each key must be a string specifying the Google Cloud IAM attribute to map to. The following keys are supported: * `google.subject`: The principal IAM is authenticating. You can reference this value in IAM bindings. This is also the subject that appears in Cloud Logging logs. Cannot exceed 127 characters. * `google.groups`: Groups the external identity belongs to. You can grant groups access to resources using an IAM `principalSet` binding; access applies to all members of the group. You can also provide custom attributes by specifying `attribute.{custom_attribute}`, where `{custom_attribute}` is the name of the custom attribute to be mapped. You can define a maximum of 50 custom attributes. The maximum length of a mapped attribute key is 100 characters, and the key may only contain the characters [a-z0-9_]. You can reference these attributes in IAM policies to define fine-grained access for a workload to Google Cloud resources. For example: * `google.subject`: `principal://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/subject/{value}` * `google.groups`: `principalSet://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/group/{value}` * `attribute.{custom_attribute}`: `principalSet://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/attribute.{custom_attribute}/{value}` Each value must be a [Common Expression Language] (https://opensource.google/projects/cel) function that maps an identity provider credential to the normalized attribute specified by the corresponding map key. You can use the `assertion` keyword in the expression to access a JSON representation of the authentication credential issued by the provider. The maximum length of an attribute mapping expression is 2048 characters. When evaluated, the total size of all mapped attributes must not exceed 8KB. For AWS providers, if no attribute mapping is defined, the following default mapping applies: ``` { &quot;google.subject&quot;:&quot;assertion.arn&quot;, &quot;attribute.aws_role&quot;: &quot;assertion.arn.contains(&apos;assumed-role&apos;)&quot; &quot; ? assertion.arn.extract(&apos;{account_arn}assumed-role/&apos;)&quot; &quot; + &apos;assumed-role/&apos; &quot; &quot; + assertion.arn.extract(&apos;assumed-role/{role_name}/&apos;)&quot; &quot; : assertion.arn&quot;, } ``` If any custom attribute mappings are defined, they must include a mapping to the `google.subject` attribute. For OIDC providers, you must supply a custom mapping, which must include the `google.subject` attribute. For example, the following maps the `sub` claim of the incoming credential to the `subject` attribute on a Google token: ``` {&quot;google.subject&quot;: &quot;assertion.sub&quot;} ```</summary>
    [JsonPropertyName("attributeMapping")]
    public IDictionary<string, string>? AttributeMapping { get; set; }

    /// <summary>An Amazon Web Services identity provider.</summary>
    [JsonPropertyName("aws")]
    public V1beta1IAMWorkloadIdentityPoolProviderSpecAws? Aws { get; set; }

    /// <summary>A description for the provider. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the provider is disabled. You cannot use a disabled provider to exchange tokens. However, existing tokens still grant access.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A display name for the provider. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>An OpenId Connect 1.0 identity provider.</summary>
    [JsonPropertyName("oidc")]
    public V1beta1IAMWorkloadIdentityPoolProviderSpecOidc? Oidc { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1IAMWorkloadIdentityPoolProviderSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("workloadIdentityPoolRef")]
    public required V1beta1IAMWorkloadIdentityPoolProviderSpecWorkloadIdentityPoolRef WorkloadIdentityPoolRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMWorkloadIdentityPoolProviderStatusConditions
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
public partial class V1beta1IAMWorkloadIdentityPoolProviderStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMWorkloadIdentityPoolProviderStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The state of the provider. Possible values: STATE_UNSPECIFIED, ACTIVE, DELETED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMWorkloadIdentityPoolProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMWorkloadIdentityPoolProviderSpec>, IStatus<V1beta1IAMWorkloadIdentityPoolProviderStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMWorkloadIdentityPoolProvider";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamworkloadidentitypoolproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMWorkloadIdentityPoolProvider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1IAMWorkloadIdentityPoolProviderSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1IAMWorkloadIdentityPoolProviderStatus? Status { get; set; }
}
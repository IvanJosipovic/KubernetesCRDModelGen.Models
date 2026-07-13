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
/// <summary>IAMPolicyMember is the Schema for the iampolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMPolicyMemberList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IAMPolicyMember>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMPolicyMemberList";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iampolicymembers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMPolicyMemberList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1IAMPolicyMember objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1IAMPolicyMember> Items { get; set; }
}

/// <summary>Immutable. Optional. The condition under which the binding applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecCondition
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }
}

/// <summary>Type field specifies the connection type of the BigQueryConnectionConnection resource, whose service account is to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IAMPolicyMemberSpecMemberFromBigQueryConnectionConnectionRefTypeEnum>))]
public enum V1beta1IAMPolicyMemberSpecMemberFromBigQueryConnectionConnectionRefTypeEnum
{
    [EnumMember(Value = "spark"), JsonStringEnumMemberName("spark")]
    Spark,
    [EnumMember(Value = "cloudSQL"), JsonStringEnumMemberName("cloudSQL")]
    CloudSQL,
    [EnumMember(Value = "cloudResource"), JsonStringEnumMemberName("cloudResource")]
    CloudResource
}

/// <summary>BigQueryConnectionConnection whose service account is to be bound to the role. Use the Type field to specify the connection type. For &quot;spark&quot; connetion, the service account is in `status.observedState.spark.serviceAccountID`. For &quot;cloudSQL&quot; connection, the service account is in `status.observedState.cloudSQL.serviceAccountID`. For &quot;cloudResource&quot; connection, the service account is in `status.observedState.cloudResource.serviceAccountID`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecMemberFromBigQueryConnectionConnectionRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Type field specifies the connection type of the BigQueryConnectionConnection resource, whose service account is to be bound to the role.</summary>
    [JsonPropertyName("type")]
    public required V1beta1IAMPolicyMemberSpecMemberFromBigQueryConnectionConnectionRefTypeEnum Type { get; set; }
}

/// <summary>The LoggingLogSink whose writer identity (i.e. its &apos;status.writerIdentity&apos;) is to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecMemberFromLogSinkRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The IAMServiceAccount to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecMemberFromServiceAccountRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The ServiceIdentity whose service account (i.e., its &apos;status.email&apos;) is to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecMemberFromServiceIdentityRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The SQLInstance whose service account (i.e. its &apos;status.serviceAccountEmailAddress&apos;) is to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecMemberFromSqlInstanceRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The IAM identity to be bound to the role. Exactly one of &apos;member&apos; or &apos;memberFrom&apos; must be used, and only one subfield within &apos;memberFrom&apos; can be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecMemberFrom
{
    /// <summary>BigQueryConnectionConnection whose service account is to be bound to the role. Use the Type field to specify the connection type. For &quot;spark&quot; connetion, the service account is in `status.observedState.spark.serviceAccountID`. For &quot;cloudSQL&quot; connection, the service account is in `status.observedState.cloudSQL.serviceAccountID`. For &quot;cloudResource&quot; connection, the service account is in `status.observedState.cloudResource.serviceAccountID`.</summary>
    [JsonPropertyName("bigQueryConnectionConnectionRef")]
    public V1beta1IAMPolicyMemberSpecMemberFromBigQueryConnectionConnectionRef? BigQueryConnectionConnectionRef { get; set; }

    /// <summary>The LoggingLogSink whose writer identity (i.e. its &apos;status.writerIdentity&apos;) is to be bound to the role.</summary>
    [JsonPropertyName("logSinkRef")]
    public V1beta1IAMPolicyMemberSpecMemberFromLogSinkRef? LogSinkRef { get; set; }

    /// <summary>The IAMServiceAccount to be bound to the role.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1IAMPolicyMemberSpecMemberFromServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>The ServiceIdentity whose service account (i.e., its &apos;status.email&apos;) is to be bound to the role.</summary>
    [JsonPropertyName("serviceIdentityRef")]
    public V1beta1IAMPolicyMemberSpecMemberFromServiceIdentityRef? ServiceIdentityRef { get; set; }

    /// <summary>The SQLInstance whose service account (i.e. its &apos;status.serviceAccountEmailAddress&apos;) is to be bound to the role.</summary>
    [JsonPropertyName("sqlInstanceRef")]
    public V1beta1IAMPolicyMemberSpecMemberFromSqlInstanceRef? SqlInstanceRef { get; set; }
}

/// <summary>Immutable. Required. The GCP resource to set the IAM policy on (e.g. organization, project...)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpecResourceRef
{
    /// <summary>APIVersion of the referenced resource</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referenced resource</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>IAMPolicyMemberSpec defines the desired state of IAMPolicyMember</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberSpec
{
    /// <summary>Immutable. Optional. The condition under which the binding applies.</summary>
    [JsonPropertyName("condition")]
    public V1beta1IAMPolicyMemberSpecCondition? Condition { get; set; }

    /// <summary>Immutable. The IAM identity to be bound to the role. Exactly one of &apos;member&apos; or &apos;memberFrom&apos; must be used.</summary>
    [JsonPropertyName("member")]
    public string? Member { get; set; }

    /// <summary>Immutable. The IAM identity to be bound to the role. Exactly one of &apos;member&apos; or &apos;memberFrom&apos; must be used, and only one subfield within &apos;memberFrom&apos; can be used.</summary>
    [JsonPropertyName("memberFrom")]
    public V1beta1IAMPolicyMemberSpecMemberFrom? MemberFrom { get; set; }

    /// <summary>Immutable. Required. The GCP resource to set the IAM policy on (e.g. organization, project...)</summary>
    [JsonPropertyName("resourceRef")]
    public required V1beta1IAMPolicyMemberSpecResourceRef ResourceRef { get; set; }

    /// <summary>Immutable. Required. The role for which the Member will be bound.</summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberStatusConditions
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

/// <summary>IAMPolicyMemberStatus defines the observed state of IAMPolicyMember</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyMemberStatus
{
    /// <summary>Conditions represent the latest available observations of the IAM policy&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMPolicyMemberStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IAMPolicyMember is the Schema for the iampolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMPolicyMember : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMPolicyMemberSpec?>, IStatus<V1beta1IAMPolicyMemberStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMPolicyMember";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iampolicymembers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMPolicyMember";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAMPolicyMemberSpec defines the desired state of IAMPolicyMember</summary>
    [JsonPropertyName("spec")]
    public V1beta1IAMPolicyMemberSpec? Spec { get; set; }

    /// <summary>IAMPolicyMemberStatus defines the observed state of IAMPolicyMember</summary>
    [JsonPropertyName("status")]
    public V1beta1IAMPolicyMemberStatus? Status { get; set; }
}
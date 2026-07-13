#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.services.k8s.aws;
/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Cluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Cluster> Items { get; set; }
}

/// <summary>
/// The log configuration for the results of the execute command actions. The
/// logs can be sent to CloudWatch Logs or an Amazon S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecConfigurationExecuteCommandConfigurationLogConfiguration
{
    [JsonPropertyName("cloudWatchEncryptionEnabled")]
    public bool? CloudWatchEncryptionEnabled { get; set; }

    [JsonPropertyName("cloudWatchLogGroupName")]
    public string? CloudWatchLogGroupName { get; set; }

    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    [JsonPropertyName("s3EncryptionEnabled")]
    public bool? S3EncryptionEnabled { get; set; }

    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }
}

/// <summary>The details of the execute command configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecConfigurationExecuteCommandConfiguration
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// The log configuration for the results of the execute command actions. The
    /// logs can be sent to CloudWatch Logs or an Amazon S3 bucket.
    /// </summary>
    [JsonPropertyName("logConfiguration")]
    public V1alpha1ClusterSpecConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration { get; set; }

    [JsonPropertyName("logging")]
    public string? Logging { get; set; }
}

/// <summary>The execute command configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecConfiguration
{
    /// <summary>The details of the execute command configuration.</summary>
    [JsonPropertyName("executeCommandConfiguration")]
    public V1alpha1ClusterSpecConfigurationExecuteCommandConfiguration? ExecuteCommandConfiguration { get; set; }
}

/// <summary>
/// The details of a capacity provider strategy. A capacity provider strategy
/// can be set when using the RunTask (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_RunTask.html)or
/// CreateCluster (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateCluster.html)
/// APIs or as the default capacity provider strategy for a cluster with the
/// CreateCluster API.
/// 
/// Only capacity providers that are already associated with a cluster and have
/// an ACTIVE or UPDATING status can be used in a capacity provider strategy.
/// The PutClusterCapacityProviders (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html)
/// API is used to associate a capacity provider with a cluster.
/// 
/// If specifying a capacity provider that uses an Auto Scaling group, the capacity
/// provider must already be created. New Auto Scaling group capacity providers
/// can be created with the CreateClusterCapacityProvider (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateClusterCapacityProvider.html)
/// API operation.
/// 
/// To use a Fargate capacity provider, specify either the FARGATE or FARGATE_SPOT
/// capacity providers. The Fargate capacity providers are available to all accounts
/// and only need to be associated with a cluster to be used in a capacity provider
/// strategy.
/// 
/// With FARGATE_SPOT, you can run interruption tolerant tasks at a rate that&apos;s
/// discounted compared to the FARGATE price. FARGATE_SPOT runs tasks on spare
/// compute capacity. When Amazon Web Services needs the capacity back, your
/// tasks are interrupted with a two-minute warning. FARGATE_SPOT supports Linux
/// tasks with the X86_64 architecture on platform version 1.3.0 or later. FARGATE_SPOT
/// supports Linux tasks with the ARM64 architecture on platform version 1.4.0
/// or later.
/// 
/// A capacity provider strategy can contain a maximum of 20 capacity providers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecDefaultCapacityProviderStrategy
{
    [JsonPropertyName("base")]
    public long? Base { get; set; }

    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>
/// Use this parameter to set a default Service Connect namespace. After you
/// set a default Service Connect namespace, any new services with Service Connect
/// turned on that are created in the cluster are added as client services in
/// the namespace. This setting only applies to new services that set the enabled
/// parameter to true in the ServiceConnectConfiguration. You can set the namespace
/// of each service individually in the ServiceConnectConfiguration to override
/// this default parameter.
/// 
/// Tasks that run in a namespace can use short names to connect to services
/// in the namespace. Tasks can connect to services across all of the clusters
/// in the namespace. Tasks connect through a managed proxy container that collects
/// logs and metrics for increased visibility. Only the tasks that Amazon ECS
/// services create are supported with Service Connect. For more information,
/// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecServiceConnectDefaults
{
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// The settings to use when creating a cluster. This parameter is used to turn
/// on CloudWatch Container Insights with enhanced observability or CloudWatch
/// Container Insights for a cluster.
/// 
/// Container Insights with enhanced observability provides all the Container
/// Insights metrics, plus additional task and container metrics. This version
/// supports enhanced observability for Amazon ECS clusters using the Amazon
/// EC2 and Fargate launch types. After you configure Container Insights with
/// enhanced observability on Amazon ECS, Container Insights auto-collects detailed
/// infrastructure telemetry from the cluster level down to the container level
/// in your environment and displays these critical performance data in curated
/// dashboards removing the heavy lifting in observability set-up.
/// 
/// For more information, see Monitor Amazon ECS containers using Container Insights
/// with enhanced observability (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecSettings
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The metadata that you apply to a resource to help you categorize and organize
/// them. Each tag consists of a key and an optional value. You define them.
/// 
/// The following basic restrictions apply to tags:
/// 
///   - Maximum number of tags per resource - 50
/// 
///   - For each resource, each tag key must be unique, and each tag key can
///     have only one value.
/// 
///   - Maximum key length - 128 Unicode characters in UTF-8
/// 
///   - Maximum value length - 256 Unicode characters in UTF-8
/// 
///   - If your tagging schema is used across multiple services and resources,
///     remember that other services may have restrictions on allowed characters.
///     Generally allowed characters are: letters, numbers, and spaces representable
///     in UTF-8, and the following characters: + - = . _ : / @.
/// 
///   - Tag keys and values are case-sensitive.
/// 
///   - Do not use aws:, AWS:, or any upper or lowercase combination of such
///     as a prefix for either keys or values as it is reserved for Amazon Web
///     Services use. You cannot edit or delete tag keys or values with this prefix.
///     Tags with this prefix do not count against your tags per resource limit.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ClusterSpec defines the desired state of Cluster.
/// 
/// A regional grouping of one or more container instances where you can run
/// task requests. Each account receives a default cluster the first time you
/// use the Amazon ECS service, but you may also create other clusters. Clusters
/// may contain more than one instance type simultaneously.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpec
{
    /// <summary>
    /// The short name of one or more capacity providers to associate with the cluster.
    /// A capacity provider must be associated with a cluster before it can be included
    /// as part of the default capacity provider strategy of the cluster or used
    /// in a capacity provider strategy when calling the CreateService (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateService.html)
    /// or RunTask (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_RunTask.html)
    /// actions.
    /// 
    /// If specifying a capacity provider that uses an Auto Scaling group, the capacity
    /// provider must be created but not associated with another cluster. New Auto
    /// Scaling group capacity providers can be created with the CreateCapacityProvider
    /// (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateCapacityProvider.html)
    /// API operation.
    /// 
    /// To use a Fargate capacity provider, specify either the FARGATE or FARGATE_SPOT
    /// capacity providers. The Fargate capacity providers are available to all accounts
    /// and only need to be associated with a cluster to be used.
    /// 
    /// The PutCapacityProvider (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutCapacityProvider.html)
    /// API operation is used to update the list of available capacity providers
    /// for a cluster after the cluster is created.
    /// </summary>
    [JsonPropertyName("capacityProviders")]
    public IList<string>? CapacityProviders { get; set; }

    /// <summary>The execute command configuration for the cluster.</summary>
    [JsonPropertyName("configuration")]
    public V1alpha1ClusterSpecConfiguration? Configuration { get; set; }

    /// <summary>
    /// The capacity provider strategy to set as the default for the cluster. After
    /// a default capacity provider strategy is set for a cluster, when you call
    /// the CreateService (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateService.html)
    /// or RunTask (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_RunTask.html)
    /// APIs with no capacity provider strategy or launch type specified, the default
    /// capacity provider strategy for the cluster is used.
    /// 
    /// If a default capacity provider strategy isn&apos;t defined for a cluster when
    /// it was created, it can be defined later with the PutClusterCapacityProviders
    /// (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html)
    /// API operation.
    /// </summary>
    [JsonPropertyName("defaultCapacityProviderStrategy")]
    public IList<V1alpha1ClusterSpecDefaultCapacityProviderStrategy>? DefaultCapacityProviderStrategy { get; set; }

    /// <summary>
    /// The name of your cluster. If you don&apos;t specify a name for your cluster, you
    /// create a cluster that&apos;s named default. Up to 255 letters (uppercase and lowercase),
    /// numbers, underscores, and hyphens are allowed.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Use this parameter to set a default Service Connect namespace. After you
    /// set a default Service Connect namespace, any new services with Service Connect
    /// turned on that are created in the cluster are added as client services in
    /// the namespace. This setting only applies to new services that set the enabled
    /// parameter to true in the ServiceConnectConfiguration. You can set the namespace
    /// of each service individually in the ServiceConnectConfiguration to override
    /// this default parameter.
    /// 
    /// Tasks that run in a namespace can use short names to connect to services
    /// in the namespace. Tasks can connect to services across all of the clusters
    /// in the namespace. Tasks connect through a managed proxy container that collects
    /// logs and metrics for increased visibility. Only the tasks that Amazon ECS
    /// services create are supported with Service Connect. For more information,
    /// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("serviceConnectDefaults")]
    public V1alpha1ClusterSpecServiceConnectDefaults? ServiceConnectDefaults { get; set; }

    /// <summary>
    /// The setting to use when creating a cluster. This parameter is used to turn
    /// on CloudWatch Container Insights for a cluster. If this value is specified,
    /// it overrides the containerInsights value set with PutAccountSetting (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAccountSetting.html)
    /// or PutAccountSettingDefault (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAccountSettingDefault.html).
    /// </summary>
    [JsonPropertyName("settings")]
    public IList<V1alpha1ClusterSpecSettings>? Settings { get; set; }

    /// <summary>
    /// The metadata that you apply to the cluster to help you categorize and organize
    /// them. Each tag consists of a key and an optional value. You define both.
    /// 
    /// The following basic restrictions apply to tags:
    /// 
    ///   - Maximum number of tags per resource - 50
    /// 
    ///   - For each resource, each tag key must be unique, and each tag key can
    ///     have only one value.
    /// 
    ///   - Maximum key length - 128 Unicode characters in UTF-8
    /// 
    ///   - Maximum value length - 256 Unicode characters in UTF-8
    /// 
    ///   - If your tagging schema is used across multiple services and resources,
    ///     remember that other services may have restrictions on allowed characters.
    ///     Generally allowed characters are: letters, numbers, and spaces representable
    ///     in UTF-8, and the following characters: + - = . _ : / @.
    /// 
    ///   - Tag keys and values are case-sensitive.
    /// 
    ///   - Do not use aws:, AWS:, or any upper or lowercase combination of such
    ///     as a prefix for either keys or values as it is reserved for Amazon Web
    ///     Services use. You cannot edit or delete tag keys or values with this prefix.
    ///     Tags with this prefix do not count against your tags per resource limit.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ClusterSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>A key-value pair object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAttachmentsDetails
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An object representing a container instance or task attachment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAttachments
{
    [JsonPropertyName("details")]
    public IList<V1alpha1ClusterStatusAttachmentsDetails>? Details { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>A key-value pair object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusStatistics
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ClusterStatus defines the observed state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The number of services that are running on the cluster in an ACTIVE state.
    /// You can view these services with ListServices (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListServices.html).
    /// </summary>
    [JsonPropertyName("activeServicesCount")]
    public long? ActiveServicesCount { get; set; }

    /// <summary>
    /// The resources attached to a cluster. When using a capacity provider with
    /// a cluster, the capacity provider and associated resources are returned as
    /// cluster attachments.
    /// </summary>
    [JsonPropertyName("attachments")]
    public IList<V1alpha1ClusterStatusAttachments>? Attachments { get; set; }

    /// <summary>
    /// The status of the capacity providers associated with the cluster. The following
    /// are the states that are returned.
    /// 
    /// UPDATE_IN_PROGRESS
    /// 
    /// The available capacity providers for the cluster are updating.
    /// 
    /// UPDATE_COMPLETE
    /// 
    /// The capacity providers have successfully updated.
    /// 
    /// UPDATE_FAILED
    /// 
    /// The capacity provider updates failed.
    /// </summary>
    [JsonPropertyName("attachmentsStatus")]
    public string? AttachmentsStatus { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The number of tasks in the cluster that are in the PENDING state.</summary>
    [JsonPropertyName("pendingTasksCount")]
    public long? PendingTasksCount { get; set; }

    /// <summary>
    /// The number of container instances registered into the cluster. This includes
    /// container instances in both ACTIVE and DRAINING status.
    /// </summary>
    [JsonPropertyName("registeredContainerInstancesCount")]
    public long? RegisteredContainerInstancesCount { get; set; }

    /// <summary>The number of tasks in the cluster that are in the RUNNING state.</summary>
    [JsonPropertyName("runningTasksCount")]
    public long? RunningTasksCount { get; set; }

    /// <summary>
    /// Additional information about your clusters that are separated by launch type.
    /// They include the following:
    /// 
    ///    * runningEC2TasksCount
    /// 
    ///    * RunningFargateTasksCount
    /// 
    ///    * pendingEC2TasksCount
    /// 
    ///    * pendingFargateTasksCount
    /// 
    ///    * activeEC2ServiceCount
    /// 
    ///    * activeFargateServiceCount
    /// 
    ///    * drainingEC2ServiceCount
    /// 
    ///    * drainingFargateServiceCount
    /// </summary>
    [JsonPropertyName("statistics")]
    public IList<V1alpha1ClusterStatusStatistics>? Statistics { get; set; }

    /// <summary>
    /// The status of the cluster. The following are the possible states that are
    /// returned.
    /// 
    /// ACTIVE
    /// 
    /// The cluster is ready to accept tasks and if applicable you can register container
    /// instances with the cluster.
    /// 
    /// PROVISIONING
    /// 
    /// The cluster has capacity providers that are associated with it and the resources
    /// needed for the capacity provider are being created.
    /// 
    /// DEPROVISIONING
    /// 
    /// The cluster has capacity providers that are associated with it and the resources
    /// needed for the capacity provider are being deleted.
    /// 
    /// FAILED
    /// 
    /// The cluster has capacity providers that are associated with it and the resources
    /// needed for the capacity provider have failed to create.
    /// 
    /// INACTIVE
    /// 
    /// The cluster has been deleted. Clusters with an INACTIVE status may remain
    /// discoverable in your account for a period of time. However, this behavior
    /// is subject to change in the future. We don&apos;t recommend that you rely on INACTIVE
    /// clusters persisting.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterSpec?>, IStatus<V1alpha1ClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ClusterSpec defines the desired state of Cluster.
    /// 
    /// A regional grouping of one or more container instances where you can run
    /// task requests. Each account receives a default cluster the first time you
    /// use the Amazon ECS service, but you may also create other clusters. Clusters
    /// may contain more than one instance type simultaneously.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterSpec? Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterStatus? Status { get; set; }
}
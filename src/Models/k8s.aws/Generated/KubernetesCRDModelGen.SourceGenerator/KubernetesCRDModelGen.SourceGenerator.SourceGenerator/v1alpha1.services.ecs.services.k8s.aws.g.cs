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
/// <summary>Service is the Schema for the Services API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Service>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Service objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Service> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecCapacityProviderStrategy
{
    [JsonPropertyName("base")]
    public long? Base { get; set; }

    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecClusterRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecClusterRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceSpecClusterRefFrom? From { get; set; }
}

/// <summary>
/// One of the methods which provide a way for you to quickly identify when a
/// deployment has failed, and then to optionally roll back the failure to the
/// last working deployment.
/// 
/// When the alarms are generated, Amazon ECS sets the service deployment to
/// failed. Set the rollback parameter to have Amazon ECS to roll back your service
/// to the last completed deployment after a failure.
/// 
/// You can only use the DeploymentAlarms method to detect failures when the
/// DeploymentController is set to ECS.
/// 
/// For more information, see Rolling update (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html)
/// in the Amazon Elastic Container Service Developer Guide .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecDeploymentConfigurationAlarms
{
    [JsonPropertyName("alarmNames")]
    public IList<string>? AlarmNames { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

/// <summary>
/// The deployment circuit breaker can only be used for services using the rolling
/// update (ECS) deployment type.
/// 
/// The deployment circuit breaker determines whether a service deployment will
/// fail if the service can&apos;t reach a steady state. If it is turned on, a service
/// deployment will transition to a failed state and stop launching new tasks.
/// You can also configure Amazon ECS to roll back your service to the last completed
/// deployment after a failure. For more information, see Rolling update (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// For more information about API failure reasons, see API failure reasons (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecDeploymentConfigurationDeploymentCircuitBreaker
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

/// <summary>
/// Optional deployment parameters that control how many tasks run during the
/// deployment and the ordering of stopping and starting tasks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecDeploymentConfiguration
{
    /// <summary>
    /// One of the methods which provide a way for you to quickly identify when a
    /// deployment has failed, and then to optionally roll back the failure to the
    /// last working deployment.
    /// 
    /// When the alarms are generated, Amazon ECS sets the service deployment to
    /// failed. Set the rollback parameter to have Amazon ECS to roll back your service
    /// to the last completed deployment after a failure.
    /// 
    /// You can only use the DeploymentAlarms method to detect failures when the
    /// DeploymentController is set to ECS.
    /// 
    /// For more information, see Rolling update (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html)
    /// in the Amazon Elastic Container Service Developer Guide .
    /// </summary>
    [JsonPropertyName("alarms")]
    public V1alpha1ServiceSpecDeploymentConfigurationAlarms? Alarms { get; set; }

    /// <summary>
    /// The deployment circuit breaker can only be used for services using the rolling
    /// update (ECS) deployment type.
    /// 
    /// The deployment circuit breaker determines whether a service deployment will
    /// fail if the service can&apos;t reach a steady state. If it is turned on, a service
    /// deployment will transition to a failed state and stop launching new tasks.
    /// You can also configure Amazon ECS to roll back your service to the last completed
    /// deployment after a failure. For more information, see Rolling update (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// For more information about API failure reasons, see API failure reasons (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("deploymentCircuitBreaker")]
    public V1alpha1ServiceSpecDeploymentConfigurationDeploymentCircuitBreaker? DeploymentCircuitBreaker { get; set; }

    [JsonPropertyName("maximumPercent")]
    public long? MaximumPercent { get; set; }

    [JsonPropertyName("minimumHealthyPercent")]
    public long? MinimumHealthyPercent { get; set; }
}

/// <summary>
/// The deployment controller to use for the service. If no deployment controller
/// is specified, the default value of ECS is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecDeploymentController
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecLoadBalancersLoadBalancerRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for LoadBalancerName</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecLoadBalancersLoadBalancerRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceSpecLoadBalancersLoadBalancerRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecLoadBalancersTargetGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for TargetGroupARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecLoadBalancersTargetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceSpecLoadBalancersTargetGroupRefFrom? From { get; set; }
}

/// <summary>
/// The load balancer configuration to use with a service or task set.
/// 
/// When you add, update, or remove a load balancer configuration, Amazon ECS
/// starts a new deployment with the updated Elastic Load Balancing configuration.
/// This causes tasks to register to and deregister from load balancers.
/// 
/// We recommend that you verify this on a test environment before you update
/// the Elastic Load Balancing configuration.
/// 
/// A service-linked role is required for services that use multiple target groups.
/// For more information, see Using service-linked roles (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecLoadBalancers
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("containerPort")]
    public long? ContainerPort { get; set; }

    [JsonPropertyName("loadBalancerName")]
    public string? LoadBalancerName { get; set; }

    /// <summary>Reference field for LoadBalancerName</summary>
    [JsonPropertyName("loadBalancerRef")]
    public V1alpha1ServiceSpecLoadBalancersLoadBalancerRef? LoadBalancerRef { get; set; }

    [JsonPropertyName("targetGroupARN")]
    public string? TargetGroupARN { get; set; }

    /// <summary>Reference field for TargetGroupARN</summary>
    [JsonPropertyName("targetGroupRef")]
    public V1alpha1ServiceSpecLoadBalancersTargetGroupRef? TargetGroupRef { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSecurityGroupRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSubnetRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// An object representing the networking details for a task or service. For
/// example awsVpcConfiguration={subnets=[&quot;subnet-12344321&quot;],securityGroups=[&quot;sg-12344321&quot;]}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfiguration
{
    [JsonPropertyName("assignPublicIP")]
    public string? AssignPublicIP { get; set; }

    /// <summary>Reference field for SecurityGroups</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Reference field for Subnets</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfigurationSubnetRefs>? SubnetRefs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// The network configuration for the service. This parameter is required for
/// task definitions that use the awsvpc network mode to receive their own elastic
/// network interface, and it isn&apos;t supported for other network modes. For more
/// information, see Task networking (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecNetworkConfiguration
{
    /// <summary>
    /// An object representing the networking details for a task or service. For
    /// example awsVpcConfiguration={subnets=[&quot;subnet-12344321&quot;],securityGroups=[&quot;sg-12344321&quot;]}.
    /// </summary>
    [JsonPropertyName("awsVPCConfiguration")]
    public V1alpha1ServiceSpecNetworkConfigurationAwsVPCConfiguration? AwsVPCConfiguration { get; set; }
}

/// <summary>
/// An object representing a constraint on task placement. For more information,
/// see Task placement constraints (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// If you&apos;re using the Fargate launch type, task placement constraints aren&apos;t
/// supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecPlacementConstraints
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// The task placement strategy for a task or service. For more information,
/// see Task placement strategies (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-strategies.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecPlacementStrategy
{
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// An object representing the secret to expose to your container. Secrets can
/// be exposed to a container in the following ways:
/// 
///   - To inject sensitive data into your containers as environment variables,
///     use the secrets container definition parameter.
/// 
///   - To reference sensitive information in the log configuration of a container,
///     use the secretOptions container definition parameter.
/// 
/// For more information, see Specifying sensitive data (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfigurationLogConfigurationSecretOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

/// <summary>
/// The log configuration for the container. This parameter maps to LogConfig
/// in the docker container create command and the --log-driver option to docker
/// run.
/// 
/// By default, containers use the same logging driver that the Docker daemon
/// uses. However, the container might use a different logging driver than the
/// Docker daemon by specifying a log driver configuration in the container definition.
/// 
/// Understand the following when specifying a log configuration for your containers.
/// 
///    * Amazon ECS currently supports a subset of the logging drivers available
///    to the Docker daemon. Additional log drivers may be available in future
///    releases of the Amazon ECS container agent. For tasks on Fargate, the
///    supported log drivers are awslogs, splunk, and awsfirelens. For tasks
///    hosted on Amazon EC2 instances, the supported log drivers are awslogs,
///    fluentd, gelf, json-file, journald,syslog, splunk, and awsfirelens.
/// 
///    * This parameter requires version 1.18 of the Docker Remote API or greater
///    on your container instance.
/// 
///    * For tasks that are hosted on Amazon EC2 instances, the Amazon ECS container
///    agent must register the available logging drivers with the ECS_AVAILABLE_LOGGING_DRIVERS
///    environment variable before containers placed on that instance can use
///    these log configuration options. For more information, see Amazon ECS
///    container agent configuration (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html)
///    in the Amazon Elastic Container Service Developer Guide.
/// 
///    * For tasks that are on Fargate, because you don&apos;t have access to the
///    underlying infrastructure your tasks are hosted on, any additional software
///    needed must be installed outside of the task. For example, the Fluentd
///    output aggregators or a remote host running Logstash to send Gelf logs
///    to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfigurationLogConfiguration
{
    [JsonPropertyName("logDriver")]
    public string? LogDriver { get; set; }

    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    [JsonPropertyName("secretOptions")]
    public IList<V1alpha1ServiceSpecServiceConnectConfigurationLogConfigurationSecretOptions>? SecretOptions { get; set; }
}

/// <summary>
/// Each alias (&quot;endpoint&quot;) is a fully-qualified name and port number that other
/// tasks (&quot;clients&quot;) can use to connect to this service.
/// 
/// Each name and port mapping must be unique within the namespace.
/// 
/// Tasks that run in a namespace can use short names to connect to services
/// in the namespace. Tasks can connect to services across all of the clusters
/// in the namespace. Tasks connect through a managed proxy container that collects
/// logs and metrics for increased visibility. Only the tasks that Amazon ECS
/// services create are supported with Service Connect. For more information,
/// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfigurationServicesClientAliases
{
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// An object that represents the timeout configurations for Service Connect.
/// 
/// If idleTimeout is set to a time that is less than perRequestTimeout, the
/// connection will close when the idleTimeout is reached and not the perRequestTimeout.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfigurationServicesTimeout
{
    [JsonPropertyName("idleTimeoutSeconds")]
    public long? IdleTimeoutSeconds { get; set; }

    [JsonPropertyName("perRequestTimeoutSeconds")]
    public long? PerRequestTimeoutSeconds { get; set; }
}

/// <summary>The certificate root authority that secures your service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfigurationServicesTlsIssuerCertificateAuthority
{
    [JsonPropertyName("awsPCAAuthorityARN")]
    public string? AwsPCAAuthorityARN { get; set; }
}

/// <summary>The key that encrypts and decrypts your resources for Service Connect TLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfigurationServicesTls
{
    /// <summary>The certificate root authority that secures your service.</summary>
    [JsonPropertyName("issuerCertificateAuthority")]
    public V1alpha1ServiceSpecServiceConnectConfigurationServicesTlsIssuerCertificateAuthority? IssuerCertificateAuthority { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }
}

/// <summary>
/// The Service Connect service object configuration. For more information, see
/// Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfigurationServices
{
    [JsonPropertyName("clientAliases")]
    public IList<V1alpha1ServiceSpecServiceConnectConfigurationServicesClientAliases>? ClientAliases { get; set; }

    [JsonPropertyName("discoveryName")]
    public string? DiscoveryName { get; set; }

    [JsonPropertyName("ingressPortOverride")]
    public long? IngressPortOverride { get; set; }

    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// An object that represents the timeout configurations for Service Connect.
    /// 
    /// If idleTimeout is set to a time that is less than perRequestTimeout, the
    /// connection will close when the idleTimeout is reached and not the perRequestTimeout.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1alpha1ServiceSpecServiceConnectConfigurationServicesTimeout? Timeout { get; set; }

    /// <summary>The key that encrypts and decrypts your resources for Service Connect TLS.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1ServiceSpecServiceConnectConfigurationServicesTls? Tls { get; set; }
}

/// <summary>
/// The configuration for this service to discover and connect to services, and
/// be discovered by, and connected from, other services within a namespace.
/// 
/// Tasks that run in a namespace can use short names to connect to services
/// in the namespace. Tasks can connect to services across all of the clusters
/// in the namespace. Tasks connect through a managed proxy container that collects
/// logs and metrics for increased visibility. Only the tasks that Amazon ECS
/// services create are supported with Service Connect. For more information,
/// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceConnectConfiguration
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The log configuration for the container. This parameter maps to LogConfig
    /// in the docker container create command and the --log-driver option to docker
    /// run.
    /// 
    /// By default, containers use the same logging driver that the Docker daemon
    /// uses. However, the container might use a different logging driver than the
    /// Docker daemon by specifying a log driver configuration in the container definition.
    /// 
    /// Understand the following when specifying a log configuration for your containers.
    /// 
    ///    * Amazon ECS currently supports a subset of the logging drivers available
    ///    to the Docker daemon. Additional log drivers may be available in future
    ///    releases of the Amazon ECS container agent. For tasks on Fargate, the
    ///    supported log drivers are awslogs, splunk, and awsfirelens. For tasks
    ///    hosted on Amazon EC2 instances, the supported log drivers are awslogs,
    ///    fluentd, gelf, json-file, journald,syslog, splunk, and awsfirelens.
    /// 
    ///    * This parameter requires version 1.18 of the Docker Remote API or greater
    ///    on your container instance.
    /// 
    ///    * For tasks that are hosted on Amazon EC2 instances, the Amazon ECS container
    ///    agent must register the available logging drivers with the ECS_AVAILABLE_LOGGING_DRIVERS
    ///    environment variable before containers placed on that instance can use
    ///    these log configuration options. For more information, see Amazon ECS
    ///    container agent configuration (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html)
    ///    in the Amazon Elastic Container Service Developer Guide.
    /// 
    ///    * For tasks that are on Fargate, because you don&apos;t have access to the
    ///    underlying infrastructure your tasks are hosted on, any additional software
    ///    needed must be installed outside of the task. For example, the Fluentd
    ///    output aggregators or a remote host running Logstash to send Gelf logs
    ///    to.
    /// </summary>
    [JsonPropertyName("logConfiguration")]
    public V1alpha1ServiceSpecServiceConnectConfigurationLogConfiguration? LogConfiguration { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("services")]
    public IList<V1alpha1ServiceSpecServiceConnectConfigurationServices>? Services { get; set; }
}

/// <summary>
/// The details for the service registry.
/// 
/// Each service may be associated with one service registry. Multiple service
/// registries for each service are not supported.
/// 
/// When you add, update, or remove the service registries configuration, Amazon
/// ECS starts a new deployment. New tasks are registered and deregistered to
/// the updated service registry configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecServiceRegistries
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("containerPort")]
    public long? ContainerPort { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }

    [JsonPropertyName("registryARN")]
    public string? RegistryARN { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecTaskDefinitionRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecTaskDefinitionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceSpecTaskDefinitionRefFrom? From { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecVolumeConfigurationsManagedEBSVolumeTagSpecificationsTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The tag specifications of an Amazon EBS volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecVolumeConfigurationsManagedEBSVolumeTagSpecifications
{
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1ServiceSpecVolumeConfigurationsManagedEBSVolumeTagSpecificationsTags>? Tags { get; set; }
}

/// <summary>
/// The configuration for the Amazon EBS volume that Amazon ECS creates and manages
/// on your behalf. These settings are used to create each Amazon EBS volume,
/// with one volume created for each task in the service. For information about
/// the supported launch types and operating systems, see Supported operating
/// systems and launch types (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volumes-configuration)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// Many of these parameters map 1:1 with the Amazon EBS CreateVolume API request
/// parameters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecVolumeConfigurationsManagedEBSVolume
{
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("filesystemType")]
    public string? FilesystemType { get; set; }

    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("sizeInGiB")]
    public long? SizeInGiB { get; set; }

    [JsonPropertyName("snapshotID")]
    public string? SnapshotID { get; set; }

    [JsonPropertyName("tagSpecifications")]
    public IList<V1alpha1ServiceSpecVolumeConfigurationsManagedEBSVolumeTagSpecifications>? TagSpecifications { get; set; }

    [JsonPropertyName("throughput")]
    public long? Throughput { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>
/// The configuration for a volume specified in the task definition as a volume
/// that is configured at launch time. Currently, the only supported volume type
/// is an Amazon EBS volume.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpecVolumeConfigurations
{
    /// <summary>
    /// The configuration for the Amazon EBS volume that Amazon ECS creates and manages
    /// on your behalf. These settings are used to create each Amazon EBS volume,
    /// with one volume created for each task in the service. For information about
    /// the supported launch types and operating systems, see Supported operating
    /// systems and launch types (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volumes-configuration)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// Many of these parameters map 1:1 with the Amazon EBS CreateVolume API request
    /// parameters.
    /// </summary>
    [JsonPropertyName("managedEBSVolume")]
    public V1alpha1ServiceSpecVolumeConfigurationsManagedEBSVolume? ManagedEBSVolume { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ServiceSpec defines the desired state of Service.
/// 
/// Details on a service within a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceSpec
{
    /// <summary>
    /// The capacity provider strategy to use for the service.
    /// 
    /// If you want to use Amazon ECS Managed Instances, you must use the capacityProviderStrategy
    /// request parameter and omit the launchType request parameter.
    /// 
    /// If a capacityProviderStrategy is specified, the launchType parameter must
    /// be omitted. If no capacityProviderStrategy or launchType is specified, the
    /// defaultCapacityProviderStrategy for the cluster is used.
    /// 
    /// A capacity provider strategy can contain a maximum of 20 capacity providers.
    /// </summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1alpha1ServiceSpecCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>
    /// The short name or full Amazon Resource Name (ARN) of the cluster that you
    /// run your service on. If you do not specify a cluster, the default cluster
    /// is assumed.
    /// </summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1ServiceSpecClusterRef? ClusterRef { get; set; }

    /// <summary>
    /// Optional deployment parameters that control how many tasks run during the
    /// deployment and the ordering of stopping and starting tasks.
    /// </summary>
    [JsonPropertyName("deploymentConfiguration")]
    public V1alpha1ServiceSpecDeploymentConfiguration? DeploymentConfiguration { get; set; }

    /// <summary>
    /// The deployment controller to use for the service. If no deployment controller
    /// is specified, the default value of ECS is used.
    /// </summary>
    [JsonPropertyName("deploymentController")]
    public V1alpha1ServiceSpecDeploymentController? DeploymentController { get; set; }

    /// <summary>
    /// The number of instantiations of the specified task definition to place and
    /// keep running in your service.
    /// 
    /// This is required if schedulingStrategy is REPLICA or isn&apos;t specified. If
    /// schedulingStrategy is DAEMON then this isn&apos;t required.
    /// </summary>
    [JsonPropertyName("desiredCount")]
    public long? DesiredCount { get; set; }

    /// <summary>
    /// Specifies whether to turn on Amazon ECS managed tags for the tasks within
    /// the service. For more information, see Tagging your Amazon ECS resources
    /// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// When you use Amazon ECS managed tags, you must set the propagateTags request
    /// parameter.
    /// </summary>
    [JsonPropertyName("enableECSManagedTags")]
    public bool? EnableECSManagedTags { get; set; }

    /// <summary>
    /// Determines whether the execute command functionality is turned on for the
    /// service. If true, this enables execute command functionality on all containers
    /// in the service tasks.
    /// </summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The period of time, in seconds, that the Amazon ECS service scheduler ignores
    /// unhealthy Elastic Load Balancing, VPC Lattice, and container health checks
    /// after a task has first started. If you do not specify a health check grace
    /// period value, the default value of 0 is used. If you do not use any of the
    /// health checks, then healthCheckGracePeriodSeconds is unused.
    /// 
    /// If your service has more running tasks than desired, unhealthy tasks in the
    /// grace period might be stopped to reach the desired count.
    /// </summary>
    [JsonPropertyName("healthCheckGracePeriodSeconds")]
    public long? HealthCheckGracePeriodSeconds { get; set; }

    /// <summary>
    /// The infrastructure that you run your service on. For more information, see
    /// Amazon ECS launch types (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// If you want to use Amazon ECS Managed Instances, you must use the capacityProviderStrategy
    /// request parameter and omit the launchType request parameter.
    /// 
    /// The FARGATE launch type runs your tasks on Fargate On-Demand infrastructure.
    /// 
    /// Fargate Spot infrastructure is available for use but a capacity provider
    /// strategy must be used. For more information, see Fargate capacity providers
    /// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/fargate-capacity-providers.html)
    /// in the Amazon ECS Developer Guide.
    /// 
    /// The EC2 launch type runs your tasks on Amazon EC2 instances registered to
    /// your cluster.
    /// 
    /// The EXTERNAL launch type runs your tasks on your on-premises server or virtual
    /// machine (VM) capacity registered to your cluster.
    /// 
    /// A service can use either a launch type or a capacity provider strategy. If
    /// a launchType is specified, the capacityProviderStrategy parameter must be
    /// omitted.
    /// </summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>
    /// A load balancer object representing the load balancers to use with your service.
    /// For more information, see Service load balancing (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// If the service uses the ECS deployment controller and using either an Application
    /// Load Balancer or Network Load Balancer, you must specify one or more target
    /// group ARNs to attach to the service. The service-linked role is required
    /// for services that use multiple target groups. For more information, see Using
    /// service-linked roles for Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// If the service uses the CODE_DEPLOY deployment controller, the service is
    /// required to use either an Application Load Balancer or Network Load Balancer.
    /// When creating an CodeDeploy deployment group, you specify two target groups
    /// (referred to as a targetGroupPair). During a deployment, CodeDeploy determines
    /// which task set in your service has the status PRIMARY, and it associates
    /// one target group with it. Then, it also associates the other target group
    /// with the replacement task set. The load balancer can also have up to two
    /// listeners: a required listener for production traffic and an optional listener
    /// that you can use to perform validation tests with Lambda functions before
    /// routing production traffic to it.
    /// 
    /// If you use the CODE_DEPLOY deployment controller, these values can be changed
    /// when updating the service.
    /// 
    /// For Application Load Balancers and Network Load Balancers, this object must
    /// contain the load balancer target group ARN, the container name, and the container
    /// port to access from the load balancer. The container name must be as it appears
    /// in a container definition. The load balancer name parameter must be omitted.
    /// When a task from this service is placed on a container instance, the container
    /// instance and port combination is registered as a target in the target group
    /// that&apos;s specified here.
    /// 
    /// For Classic Load Balancers, this object must contain the load balancer name,
    /// the container name , and the container port to access from the load balancer.
    /// The container name must be as it appears in a container definition. The target
    /// group ARN parameter must be omitted. When a task from this service is placed
    /// on a container instance, the container instance is registered with the load
    /// balancer that&apos;s specified here.
    /// 
    /// Services with tasks that use the awsvpc network mode (for example, those
    /// with the Fargate launch type) only support Application Load Balancers and
    /// Network Load Balancers. Classic Load Balancers aren&apos;t supported. Also, when
    /// you create any target groups for these services, you must choose ip as the
    /// target type, not instance. This is because tasks that use the awsvpc network
    /// mode are associated with an elastic network interface, not an Amazon EC2
    /// instance.
    /// </summary>
    [JsonPropertyName("loadBalancers")]
    public IList<V1alpha1ServiceSpecLoadBalancers>? LoadBalancers { get; set; }

    /// <summary>
    /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers,
    /// underscores, and hyphens are allowed. Service names must be unique within
    /// a cluster, but you can have similarly named services in multiple clusters
    /// within a Region or across multiple Regions.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The network configuration for the service. This parameter is required for
    /// task definitions that use the awsvpc network mode to receive their own elastic
    /// network interface, and it isn&apos;t supported for other network modes. For more
    /// information, see Task networking (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("networkConfiguration")]
    public V1alpha1ServiceSpecNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>
    /// An array of placement constraint objects to use for tasks in your service.
    /// You can specify a maximum of 10 constraints for each task. This limit includes
    /// constraints in the task definition and those specified at runtime.
    /// </summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1alpha1ServiceSpecPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>
    /// The placement strategy objects to use for tasks in your service. You can
    /// specify a maximum of 5 strategy rules for each service.
    /// </summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1alpha1ServiceSpecPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>
    /// The platform version that your tasks in the service are running on. A platform
    /// version is specified only for tasks using the Fargate launch type. If one
    /// isn&apos;t specified, the LATEST platform version is used. For more information,
    /// see Fargate platform versions (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>
    /// Specifies whether to propagate the tags from the task definition to the task.
    /// If no value is specified, the tags aren&apos;t propagated. Tags can only be propagated
    /// to the task during task creation. To add tags to a task after task creation,
    /// use the TagResource (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_TagResource.html)
    /// API action.
    /// 
    /// You must set this to a value other than NONE when you use Cost Explorer.
    /// For more information, see Amazon ECS usage reports (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/usage-reports.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// The default is NONE.
    /// </summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>
    /// The name or full Amazon Resource Name (ARN) of the IAM role that allows Amazon
    /// ECS to make calls to your load balancer on your behalf. This parameter is
    /// only permitted if you are using a load balancer with your service and your
    /// task definition doesn&apos;t use the awsvpc network mode. If you specify the role
    /// parameter, you must also specify a load balancer object with the loadBalancers
    /// parameter.
    /// 
    /// If your account has already created the Amazon ECS service-linked role, that
    /// role is used for your service unless you specify a role here. The service-linked
    /// role is required if your task definition uses the awsvpc network mode or
    /// if the service is configured to use service discovery, an external deployment
    /// controller, multiple target groups, or Elastic Inference accelerators in
    /// which case you don&apos;t specify a role here. For more information, see Using
    /// service-linked roles for Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// If your specified role has a path other than /, then you must either specify
    /// the full role ARN (this is recommended) or prefix the role name with the
    /// path. For example, if a role with the name bar has a path of /foo/ then you
    /// would specify /foo/bar as the role name. For more information, see Friendly
    /// names and paths (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-friendly-names)
    /// in the IAM User Guide.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1ServiceSpecRoleRef? RoleRef { get; set; }

    /// <summary>
    /// The scheduling strategy to use for the service. For more information, see
    /// Services (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html).
    /// 
    /// There are two service scheduler strategies available:
    /// 
    ///   - REPLICA-The replica scheduling strategy places and maintains the desired
    ///     number of tasks across your cluster. By default, the service scheduler
    ///     spreads tasks across Availability Zones. You can use task placement strategies
    ///     and constraints to customize task placement decisions. This scheduler
    ///     strategy is required if the service uses the CODE_DEPLOY or EXTERNAL deployment
    ///     controller types.
    /// 
    ///   - DAEMON-The daemon scheduling strategy deploys exactly one task on each
    ///     active container instance that meets all of the task placement constraints
    ///     that you specify in your cluster. The service scheduler also evaluates
    ///     the task placement constraints for running tasks and will stop tasks that
    ///     don&apos;t meet the placement constraints. When you&apos;re using this strategy,
    ///     you don&apos;t need to specify a desired number of tasks, a task placement
    ///     strategy, or use Service Auto Scaling policies. Tasks using the Fargate
    ///     launch type or the CODE_DEPLOY or EXTERNAL deployment controller types
    ///     don&apos;t support the DAEMON scheduling strategy.
    /// </summary>
    [JsonPropertyName("schedulingStrategy")]
    public string? SchedulingStrategy { get; set; }

    /// <summary>
    /// The configuration for this service to discover and connect to services, and
    /// be discovered by, and connected from, other services within a namespace.
    /// 
    /// Tasks that run in a namespace can use short names to connect to services
    /// in the namespace. Tasks can connect to services across all of the clusters
    /// in the namespace. Tasks connect through a managed proxy container that collects
    /// logs and metrics for increased visibility. Only the tasks that Amazon ECS
    /// services create are supported with Service Connect. For more information,
    /// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("serviceConnectConfiguration")]
    public V1alpha1ServiceSpecServiceConnectConfiguration? ServiceConnectConfiguration { get; set; }

    /// <summary>
    /// The details of the service discovery registry to associate with this service.
    /// For more information, see Service discovery (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html).
    /// 
    /// Each service may be associated with one service registry. Multiple service
    /// registries for each service isn&apos;t supported.
    /// </summary>
    [JsonPropertyName("serviceRegistries")]
    public IList<V1alpha1ServiceSpecServiceRegistries>? ServiceRegistries { get; set; }

    /// <summary>
    /// The metadata that you apply to the service to help you categorize and organize
    /// them. Each tag consists of a key and an optional value, both of which you
    /// define. When a service is deleted, the tags are deleted as well.
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
    public IList<V1alpha1ServiceSpecTags>? Tags { get; set; }

    /// <summary>
    /// The family and revision (family:revision) or full ARN of the task definition
    /// to run in your service. If a revision isn&apos;t specified, the latest ACTIVE
    /// revision is used.
    /// 
    /// A task definition must be specified if the service uses either the ECS or
    /// CODE_DEPLOY deployment controllers.
    /// 
    /// For more information about deployment types, see Amazon ECS deployment types
    /// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html).
    /// </summary>
    [JsonPropertyName("taskDefinition")]
    public string? TaskDefinition { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("taskDefinitionRef")]
    public V1alpha1ServiceSpecTaskDefinitionRef? TaskDefinitionRef { get; set; }

    /// <summary>
    /// The configuration for a volume specified in the task definition as a volume
    /// that is configured at launch time. Currently, the only supported volume type
    /// is an Amazon EBS volume.
    /// </summary>
    [JsonPropertyName("volumeConfigurations")]
    public IList<V1alpha1ServiceSpecVolumeConfigurations>? VolumeConfigurations { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusAckResourceMetadata
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

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsCapacityProviderStrategy
{
    [JsonPropertyName("base")]
    public long? Base { get; set; }

    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSubnetRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// An object representing the networking details for a task or service. For
/// example awsVpcConfiguration={subnets=[&quot;subnet-12344321&quot;],securityGroups=[&quot;sg-12344321&quot;]}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfiguration
{
    [JsonPropertyName("assignPublicIP")]
    public string? AssignPublicIP { get; set; }

    /// <summary>Reference field for SecurityGroups</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Reference field for Subnets</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfigurationSubnetRefs>? SubnetRefs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The network configuration for a task or service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsNetworkConfiguration
{
    /// <summary>
    /// An object representing the networking details for a task or service. For
    /// example awsVpcConfiguration={subnets=[&quot;subnet-12344321&quot;],securityGroups=[&quot;sg-12344321&quot;]}.
    /// </summary>
    [JsonPropertyName("awsVPCConfiguration")]
    public V1alpha1ServiceStatusDeploymentsNetworkConfigurationAwsVPCConfiguration? AwsVPCConfiguration { get; set; }
}

/// <summary>
/// An object representing the secret to expose to your container. Secrets can
/// be exposed to a container in the following ways:
/// 
///   - To inject sensitive data into your containers as environment variables,
///     use the secrets container definition parameter.
/// 
///   - To reference sensitive information in the log configuration of a container,
///     use the secretOptions container definition parameter.
/// 
/// For more information, see Specifying sensitive data (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationLogConfigurationSecretOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

/// <summary>
/// The log configuration for the container. This parameter maps to LogConfig
/// in the docker container create command and the --log-driver option to docker
/// run.
/// 
/// By default, containers use the same logging driver that the Docker daemon
/// uses. However, the container might use a different logging driver than the
/// Docker daemon by specifying a log driver configuration in the container definition.
/// 
/// Understand the following when specifying a log configuration for your containers.
/// 
///    * Amazon ECS currently supports a subset of the logging drivers available
///    to the Docker daemon. Additional log drivers may be available in future
///    releases of the Amazon ECS container agent. For tasks on Fargate, the
///    supported log drivers are awslogs, splunk, and awsfirelens. For tasks
///    hosted on Amazon EC2 instances, the supported log drivers are awslogs,
///    fluentd, gelf, json-file, journald,syslog, splunk, and awsfirelens.
/// 
///    * This parameter requires version 1.18 of the Docker Remote API or greater
///    on your container instance.
/// 
///    * For tasks that are hosted on Amazon EC2 instances, the Amazon ECS container
///    agent must register the available logging drivers with the ECS_AVAILABLE_LOGGING_DRIVERS
///    environment variable before containers placed on that instance can use
///    these log configuration options. For more information, see Amazon ECS
///    container agent configuration (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html)
///    in the Amazon Elastic Container Service Developer Guide.
/// 
///    * For tasks that are on Fargate, because you don&apos;t have access to the
///    underlying infrastructure your tasks are hosted on, any additional software
///    needed must be installed outside of the task. For example, the Fluentd
///    output aggregators or a remote host running Logstash to send Gelf logs
///    to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationLogConfiguration
{
    [JsonPropertyName("logDriver")]
    public string? LogDriver { get; set; }

    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    [JsonPropertyName("secretOptions")]
    public IList<V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationLogConfigurationSecretOptions>? SecretOptions { get; set; }
}

/// <summary>
/// Each alias (&quot;endpoint&quot;) is a fully-qualified name and port number that other
/// tasks (&quot;clients&quot;) can use to connect to this service.
/// 
/// Each name and port mapping must be unique within the namespace.
/// 
/// Tasks that run in a namespace can use short names to connect to services
/// in the namespace. Tasks can connect to services across all of the clusters
/// in the namespace. Tasks connect through a managed proxy container that collects
/// logs and metrics for increased visibility. Only the tasks that Amazon ECS
/// services create are supported with Service Connect. For more information,
/// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesClientAliases
{
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// An object that represents the timeout configurations for Service Connect.
/// 
/// If idleTimeout is set to a time that is less than perRequestTimeout, the
/// connection will close when the idleTimeout is reached and not the perRequestTimeout.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesTimeout
{
    [JsonPropertyName("idleTimeoutSeconds")]
    public long? IdleTimeoutSeconds { get; set; }

    [JsonPropertyName("perRequestTimeoutSeconds")]
    public long? PerRequestTimeoutSeconds { get; set; }
}

/// <summary>The certificate root authority that secures your service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesTlsIssuerCertificateAuthority
{
    [JsonPropertyName("awsPCAAuthorityARN")]
    public string? AwsPCAAuthorityARN { get; set; }
}

/// <summary>The key that encrypts and decrypts your resources for Service Connect TLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesTls
{
    /// <summary>The certificate root authority that secures your service.</summary>
    [JsonPropertyName("issuerCertificateAuthority")]
    public V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesTlsIssuerCertificateAuthority? IssuerCertificateAuthority { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }
}

/// <summary>
/// The Service Connect service object configuration. For more information, see
/// Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServices
{
    [JsonPropertyName("clientAliases")]
    public IList<V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesClientAliases>? ClientAliases { get; set; }

    [JsonPropertyName("discoveryName")]
    public string? DiscoveryName { get; set; }

    [JsonPropertyName("ingressPortOverride")]
    public long? IngressPortOverride { get; set; }

    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// An object that represents the timeout configurations for Service Connect.
    /// 
    /// If idleTimeout is set to a time that is less than perRequestTimeout, the
    /// connection will close when the idleTimeout is reached and not the perRequestTimeout.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesTimeout? Timeout { get; set; }

    /// <summary>The key that encrypts and decrypts your resources for Service Connect TLS.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServicesTls? Tls { get; set; }
}

/// <summary>
/// The Service Connect configuration of your Amazon ECS service. The configuration
/// for this service to discover and connect to services, and be discovered by,
/// and connected from, other services within a namespace.
/// 
/// Tasks that run in a namespace can use short names to connect to services
/// in the namespace. Tasks can connect to services across all of the clusters
/// in the namespace. Tasks connect through a managed proxy container that collects
/// logs and metrics for increased visibility. Only the tasks that Amazon ECS
/// services create are supported with Service Connect. For more information,
/// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectConfiguration
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The log configuration for the container. This parameter maps to LogConfig
    /// in the docker container create command and the --log-driver option to docker
    /// run.
    /// 
    /// By default, containers use the same logging driver that the Docker daemon
    /// uses. However, the container might use a different logging driver than the
    /// Docker daemon by specifying a log driver configuration in the container definition.
    /// 
    /// Understand the following when specifying a log configuration for your containers.
    /// 
    ///    * Amazon ECS currently supports a subset of the logging drivers available
    ///    to the Docker daemon. Additional log drivers may be available in future
    ///    releases of the Amazon ECS container agent. For tasks on Fargate, the
    ///    supported log drivers are awslogs, splunk, and awsfirelens. For tasks
    ///    hosted on Amazon EC2 instances, the supported log drivers are awslogs,
    ///    fluentd, gelf, json-file, journald,syslog, splunk, and awsfirelens.
    /// 
    ///    * This parameter requires version 1.18 of the Docker Remote API or greater
    ///    on your container instance.
    /// 
    ///    * For tasks that are hosted on Amazon EC2 instances, the Amazon ECS container
    ///    agent must register the available logging drivers with the ECS_AVAILABLE_LOGGING_DRIVERS
    ///    environment variable before containers placed on that instance can use
    ///    these log configuration options. For more information, see Amazon ECS
    ///    container agent configuration (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html)
    ///    in the Amazon Elastic Container Service Developer Guide.
    /// 
    ///    * For tasks that are on Fargate, because you don&apos;t have access to the
    ///    underlying infrastructure your tasks are hosted on, any additional software
    ///    needed must be installed outside of the task. For example, the Fluentd
    ///    output aggregators or a remote host running Logstash to send Gelf logs
    ///    to.
    /// </summary>
    [JsonPropertyName("logConfiguration")]
    public V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationLogConfiguration? LogConfiguration { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("services")]
    public IList<V1alpha1ServiceStatusDeploymentsServiceConnectConfigurationServices>? Services { get; set; }
}

/// <summary>
/// The Service Connect resource. Each configuration maps a discovery name to
/// a Cloud Map service name. The data is stored in Cloud Map as part of the
/// Service Connect configuration for each discovery name of this Amazon ECS
/// service.
/// 
/// A task can resolve the dnsName for each of the clientAliases of a service.
/// However a task can&apos;t resolve the discovery names. If you want to connect
/// to a service, refer to the ServiceConnectConfiguration of that service for
/// the list of clientAliases that you can use.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsServiceConnectResources
{
    [JsonPropertyName("discoveryARN")]
    public string? DiscoveryARN { get; set; }

    [JsonPropertyName("discoveryName")]
    public string? DiscoveryName { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsVolumeConfigurationsManagedEBSVolumeTagSpecificationsTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The tag specifications of an Amazon EBS volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsVolumeConfigurationsManagedEBSVolumeTagSpecifications
{
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1ServiceStatusDeploymentsVolumeConfigurationsManagedEBSVolumeTagSpecificationsTags>? Tags { get; set; }
}

/// <summary>
/// The configuration for the Amazon EBS volume that Amazon ECS creates and manages
/// on your behalf. These settings are used to create each Amazon EBS volume,
/// with one volume created for each task in the service. For information about
/// the supported launch types and operating systems, see Supported operating
/// systems and launch types (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volumes-configuration)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// Many of these parameters map 1:1 with the Amazon EBS CreateVolume API request
/// parameters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsVolumeConfigurationsManagedEBSVolume
{
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("filesystemType")]
    public string? FilesystemType { get; set; }

    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("sizeInGiB")]
    public long? SizeInGiB { get; set; }

    [JsonPropertyName("snapshotID")]
    public string? SnapshotID { get; set; }

    [JsonPropertyName("tagSpecifications")]
    public IList<V1alpha1ServiceStatusDeploymentsVolumeConfigurationsManagedEBSVolumeTagSpecifications>? TagSpecifications { get; set; }

    [JsonPropertyName("throughput")]
    public long? Throughput { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>
/// The configuration for a volume specified in the task definition as a volume
/// that is configured at launch time. Currently, the only supported volume type
/// is an Amazon EBS volume.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeploymentsVolumeConfigurations
{
    /// <summary>
    /// The configuration for the Amazon EBS volume that Amazon ECS creates and manages
    /// on your behalf. These settings are used to create each Amazon EBS volume,
    /// with one volume created for each task in the service. For information about
    /// the supported launch types and operating systems, see Supported operating
    /// systems and launch types (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volumes-configuration)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// Many of these parameters map 1:1 with the Amazon EBS CreateVolume API request
    /// parameters.
    /// </summary>
    [JsonPropertyName("managedEBSVolume")]
    public V1alpha1ServiceStatusDeploymentsVolumeConfigurationsManagedEBSVolume? ManagedEBSVolume { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The details of an Amazon ECS service deployment. This is used only when a
/// service uses the ECS deployment controller type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusDeployments
{
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1alpha1ServiceStatusDeploymentsCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("desiredCount")]
    public long? DesiredCount { get; set; }

    [JsonPropertyName("failedTasks")]
    public long? FailedTasks { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>The network configuration for a task or service.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1alpha1ServiceStatusDeploymentsNetworkConfiguration? NetworkConfiguration { get; set; }

    [JsonPropertyName("pendingCount")]
    public long? PendingCount { get; set; }

    [JsonPropertyName("platformFamily")]
    public string? PlatformFamily { get; set; }

    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    [JsonPropertyName("rolloutState")]
    public string? RolloutState { get; set; }

    [JsonPropertyName("rolloutStateReason")]
    public string? RolloutStateReason { get; set; }

    [JsonPropertyName("runningCount")]
    public long? RunningCount { get; set; }

    /// <summary>
    /// The Service Connect configuration of your Amazon ECS service. The configuration
    /// for this service to discover and connect to services, and be discovered by,
    /// and connected from, other services within a namespace.
    /// 
    /// Tasks that run in a namespace can use short names to connect to services
    /// in the namespace. Tasks can connect to services across all of the clusters
    /// in the namespace. Tasks connect through a managed proxy container that collects
    /// logs and metrics for increased visibility. Only the tasks that Amazon ECS
    /// services create are supported with Service Connect. For more information,
    /// see Service Connect (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("serviceConnectConfiguration")]
    public V1alpha1ServiceStatusDeploymentsServiceConnectConfiguration? ServiceConnectConfiguration { get; set; }

    [JsonPropertyName("serviceConnectResources")]
    public IList<V1alpha1ServiceStatusDeploymentsServiceConnectResources>? ServiceConnectResources { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("taskDefinition")]
    public string? TaskDefinition { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("volumeConfigurations")]
    public IList<V1alpha1ServiceStatusDeploymentsVolumeConfigurations>? VolumeConfigurations { get; set; }
}

/// <summary>The details for an event that&apos;s associated with a service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusEvents
{
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsCapacityProviderStrategy
{
    [JsonPropertyName("base")]
    public long? Base { get; set; }

    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsLoadBalancersLoadBalancerRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for LoadBalancerName</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsLoadBalancersLoadBalancerRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceStatusTaskSetsLoadBalancersLoadBalancerRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsLoadBalancersTargetGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for TargetGroupARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsLoadBalancersTargetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceStatusTaskSetsLoadBalancersTargetGroupRefFrom? From { get; set; }
}

/// <summary>
/// The load balancer configuration to use with a service or task set.
/// 
/// When you add, update, or remove a load balancer configuration, Amazon ECS
/// starts a new deployment with the updated Elastic Load Balancing configuration.
/// This causes tasks to register to and deregister from load balancers.
/// 
/// We recommend that you verify this on a test environment before you update
/// the Elastic Load Balancing configuration.
/// 
/// A service-linked role is required for services that use multiple target groups.
/// For more information, see Using service-linked roles (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsLoadBalancers
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("containerPort")]
    public long? ContainerPort { get; set; }

    [JsonPropertyName("loadBalancerName")]
    public string? LoadBalancerName { get; set; }

    /// <summary>Reference field for LoadBalancerName</summary>
    [JsonPropertyName("loadBalancerRef")]
    public V1alpha1ServiceStatusTaskSetsLoadBalancersLoadBalancerRef? LoadBalancerRef { get; set; }

    [JsonPropertyName("targetGroupARN")]
    public string? TargetGroupARN { get; set; }

    /// <summary>Reference field for TargetGroupARN</summary>
    [JsonPropertyName("targetGroupRef")]
    public V1alpha1ServiceStatusTaskSetsLoadBalancersTargetGroupRef? TargetGroupRef { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSubnetRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// An object representing the networking details for a task or service. For
/// example awsVpcConfiguration={subnets=[&quot;subnet-12344321&quot;],securityGroups=[&quot;sg-12344321&quot;]}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfiguration
{
    [JsonPropertyName("assignPublicIP")]
    public string? AssignPublicIP { get; set; }

    /// <summary>Reference field for SecurityGroups</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Reference field for Subnets</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfigurationSubnetRefs>? SubnetRefs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The network configuration for a task or service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsNetworkConfiguration
{
    /// <summary>
    /// An object representing the networking details for a task or service. For
    /// example awsVpcConfiguration={subnets=[&quot;subnet-12344321&quot;],securityGroups=[&quot;sg-12344321&quot;]}.
    /// </summary>
    [JsonPropertyName("awsVPCConfiguration")]
    public V1alpha1ServiceStatusTaskSetsNetworkConfigurationAwsVPCConfiguration? AwsVPCConfiguration { get; set; }
}

/// <summary>
/// A floating-point percentage of the desired number of tasks to place and keep
/// running in the task set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsScale
{
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>
/// The details for the service registry.
/// 
/// Each service may be associated with one service registry. Multiple service
/// registries for each service are not supported.
/// 
/// When you add, update, or remove the service registries configuration, Amazon
/// ECS starts a new deployment. New tasks are registered and deregistered to
/// the updated service registry configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsServiceRegistries
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("containerPort")]
    public long? ContainerPort { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }

    [JsonPropertyName("registryARN")]
    public string? RegistryARN { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSetsTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Information about a set of Amazon ECS tasks in either an CodeDeploy or an
/// EXTERNAL deployment. An Amazon ECS task set includes details such as the
/// desired number of tasks, how many tasks are running, and whether the task
/// set serves production traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatusTaskSets
{
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1alpha1ServiceStatusTaskSetsCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    [JsonPropertyName("clusterARN")]
    public string? ClusterARN { get; set; }

    [JsonPropertyName("computedDesiredCount")]
    public long? ComputedDesiredCount { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    [JsonPropertyName("loadBalancers")]
    public IList<V1alpha1ServiceStatusTaskSetsLoadBalancers>? LoadBalancers { get; set; }

    /// <summary>The network configuration for a task or service.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1alpha1ServiceStatusTaskSetsNetworkConfiguration? NetworkConfiguration { get; set; }

    [JsonPropertyName("pendingCount")]
    public long? PendingCount { get; set; }

    [JsonPropertyName("platformFamily")]
    public string? PlatformFamily { get; set; }

    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    [JsonPropertyName("runningCount")]
    public long? RunningCount { get; set; }

    /// <summary>
    /// A floating-point percentage of the desired number of tasks to place and keep
    /// running in the task set.
    /// </summary>
    [JsonPropertyName("scale")]
    public V1alpha1ServiceStatusTaskSetsScale? Scale { get; set; }

    [JsonPropertyName("serviceARN")]
    public string? ServiceARN { get; set; }

    [JsonPropertyName("serviceRegistries")]
    public IList<V1alpha1ServiceStatusTaskSetsServiceRegistries>? ServiceRegistries { get; set; }

    [JsonPropertyName("stabilityStatus")]
    public string? StabilityStatus { get; set; }

    [JsonPropertyName("stabilityStatusAt")]
    public DateTime? StabilityStatusAt { get; set; }

    [JsonPropertyName("startedBy")]
    public string? StartedBy { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1ServiceStatusTaskSetsTags>? Tags { get; set; }

    [JsonPropertyName("taskDefinition")]
    public string? TaskDefinition { get; set; }

    [JsonPropertyName("taskSetARN")]
    public string? TaskSetARN { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}

/// <summary>ServiceStatus defines the observed state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ServiceStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the cluster that hosts the service.</summary>
    [JsonPropertyName("clusterARN")]
    public string? ClusterARN { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>The Unix timestamp for the time when the service was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>The principal that created the service.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>The current state of deployments for the service.</summary>
    [JsonPropertyName("deployments")]
    public IList<V1alpha1ServiceStatusDeployments>? Deployments { get; set; }

    /// <summary>
    /// The event stream for your service. A maximum of 100 of the latest events
    /// are displayed.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<V1alpha1ServiceStatusEvents>? Events { get; set; }

    /// <summary>The number of tasks in the cluster that are in the PENDING state.</summary>
    [JsonPropertyName("pendingCount")]
    public long? PendingCount { get; set; }

    /// <summary>
    /// The operating system that your tasks in the service run on. A platform family
    /// is specified only for tasks using the Fargate launch type.
    /// 
    /// All tasks that run as part of this service must use the same platformFamily
    /// value as the service (for example, LINUX).
    /// </summary>
    [JsonPropertyName("platformFamily")]
    public string? PlatformFamily { get; set; }

    /// <summary>
    /// The ARN of the IAM role that&apos;s associated with the service. It allows the
    /// Amazon ECS container agent to register container instances with an Elastic
    /// Load Balancing load balancer.
    /// </summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>The number of tasks in the cluster that are in the RUNNING state.</summary>
    [JsonPropertyName("runningCount")]
    public long? RunningCount { get; set; }

    /// <summary>The status of the service. The valid values are ACTIVE, DRAINING, or INACTIVE.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Information about a set of Amazon ECS tasks in either an CodeDeploy or an
    /// EXTERNAL deployment. An Amazon ECS task set includes details such as the
    /// desired number of tasks, how many tasks are running, and whether the task
    /// set serves production traffic.
    /// </summary>
    [JsonPropertyName("taskSets")]
    public IList<V1alpha1ServiceStatusTaskSets>? TaskSets { get; set; }
}

/// <summary>Service is the Schema for the Services API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServiceSpec?>, IStatus<V1alpha1ServiceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Service";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Service";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ServiceSpec defines the desired state of Service.
    /// 
    /// Details on a service within a cluster.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ServiceSpec? Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service</summary>
    [JsonPropertyName("status")]
    public V1alpha1ServiceStatus? Status { get; set; }
}
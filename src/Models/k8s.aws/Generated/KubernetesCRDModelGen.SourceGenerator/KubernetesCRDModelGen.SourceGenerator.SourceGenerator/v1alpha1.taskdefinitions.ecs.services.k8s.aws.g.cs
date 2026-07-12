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
/// <summary>TaskDefinition is the Schema for the TaskDefinitions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TaskDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TaskDefinition>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TaskDefinitionList";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "taskdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TaskDefinitionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TaskDefinition objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TaskDefinition> Items { get; set; }
}

/// <summary>
/// The dependencies defined for container startup and shutdown. A container
/// can contain multiple dependencies. When a dependency is defined for container
/// startup, for container shutdown it is reversed.
/// 
/// Your Amazon ECS container instances require at least version 1.26.0 of the
/// container agent to use container dependencies. However, we recommend using
/// the latest container agent version. For information about checking your agent
/// version and updating to the latest version, see Updating the Amazon ECS Container
/// Agent (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html)
/// in the Amazon Elastic Container Service Developer Guide. If you&apos;re using
/// an Amazon ECS-optimized Linux AMI, your instance needs at least version 1.26.0-1
/// of the ecs-init package. If your container instances are launched from version
/// 20190301 or later, then they contain the required versions of the container
/// agent and ecs-init. For more information, see Amazon ECS-optimized Linux
/// AMI (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// For tasks that use the Fargate launch type, the task or service requires
/// the following platforms:
/// 
///   - Linux platform version 1.3.0 or later.
/// 
///   - Windows platform version 1.0.0 or later.
/// 
/// For more information about how to create a container dependency, see Container
/// dependency (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/example_task_definitions.html#example_task_definition-containerdependency)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsDependsOn
{
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }
}

/// <summary>A key-value pair object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsEnvironment
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A list of files containing the environment variables to pass to a container.
/// You can specify up to ten environment files. The file must have a .env file
/// extension. Each line in an environment file should contain an environment
/// variable in VARIABLE=VALUE format. Lines beginning with # are treated as
/// comments and are ignored.
/// 
/// If there are environment variables specified using the environment parameter
/// in a container definition, they take precedence over the variables contained
/// within an environment file. If multiple environment files are specified that
/// contain the same variable, they&apos;re processed from the top down. We recommend
/// that you use unique variable names. For more information, see Use a file
/// to pass environment variables to a container (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/use-environment-file.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// Environment variable files are objects in Amazon S3 and all Amazon S3 security
/// considerations apply.
/// 
/// You must use the following platforms for the Fargate launch type:
/// 
///   - Linux platform version 1.4.0 or later.
/// 
///   - Windows platform version 1.0.0 or later.
/// 
/// Consider the following when using the Fargate launch type:
/// 
///   - The file is handled like a native Docker env-file.
/// 
///   - There is no support for shell escape handling.
/// 
///   - The container entry point interperts the VARIABLE values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsEnvironmentFiles
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Hostnames and IP address entries that are added to the /etc/hosts file of
/// a container via the extraHosts parameter of its ContainerDefinition (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsExtraHosts
{
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>
/// The FireLens configuration for the container. This is used to specify and
/// configure a log router for container logs. For more information, see Custom
/// log routing (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsFirelensConfiguration
{
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// An object representing a container health check. Health check parameters
/// that are specified in a container definition override any Docker health checks
/// that exist in the container image (such as those specified in a parent image
/// or from the image&apos;s Dockerfile). This configuration maps to the HEALTHCHECK
/// parameter of docker run.
/// 
/// The Amazon ECS container agent only monitors and reports on the health checks
/// specified in the task definition. Amazon ECS does not monitor Docker health
/// checks that are embedded in a container image and not specified in the container
/// definition. Health check parameters that are specified in a container definition
/// override any Docker health checks that exist in the container image.
/// 
/// You can view the health status of both individual containers and a task with
/// the DescribeTasks API operation or when viewing the task details in the console.
/// 
/// The health check is designed to make sure that your containers survive agent
/// restarts, upgrades, or temporary unavailability.
/// 
/// Amazon ECS performs health checks on containers with the default that launched
/// the container instance or the task.
/// 
/// The following describes the possible healthStatus values for a container:
/// 
///    * HEALTHY-The container health check has passed successfully.
/// 
///    * UNHEALTHY-The container health check has failed.
/// 
///    * UNKNOWN-The container health check is being evaluated, there&apos;s no container
///    health check defined, or Amazon ECS doesn&apos;t have the health status of
///    the container.
/// 
/// The following describes the possible healthStatus values based on the container
/// health checker status of essential containers in the task with the following
/// priority order (high to low):
/// 
///    * UNHEALTHY-One or more essential containers have failed their health
///    check.
/// 
///    * UNKNOWN-Any essential container running within the task is in an UNKNOWN
///    state and no other essential containers have an UNHEALTHY state.
/// 
///    * HEALTHY-All essential containers within the task have passed their health
///    checks.
/// 
/// Consider the following task health example with 2 containers.
/// 
///    * If Container1 is UNHEALTHY and Container2 is UNKNOWN, the task health
///    is UNHEALTHY.
/// 
///    * If Container1 is UNHEALTHY and Container2 is HEALTHY, the task health
///    is UNHEALTHY.
/// 
///    * If Container1 is HEALTHY and Container2 is UNKNOWN, the task health
///    is UNKNOWN.
/// 
///    * If Container1 is HEALTHY and Container2 is HEALTHY, the task health
///    is HEALTHY.
/// 
/// Consider the following task health example with 3 containers.
/// 
///    * If Container1 is UNHEALTHY and Container2 is UNKNOWN, and Container3
///    is UNKNOWN, the task health is UNHEALTHY.
/// 
///    * If Container1 is UNHEALTHY and Container2 is UNKNOWN, and Container3
///    is HEALTHY, the task health is UNHEALTHY.
/// 
///    * If Container1 is UNHEALTHY and Container2 is HEALTHY, and Container3
///    is HEALTHY, the task health is UNHEALTHY.
/// 
///    * If Container1 is HEALTHY and Container2 is UNKNOWN, and Container3 is
///    HEALTHY, the task health is UNKNOWN.
/// 
///    * If Container1 is HEALTHY and Container2 is UNKNOWN, and Container3 is
///    UNKNOWN, the task health is UNKNOWN.
/// 
///    * If Container1 is HEALTHY and Container2 is HEALTHY, and Container3 is
///    HEALTHY, the task health is HEALTHY.
/// 
/// If a task is run manually, and not as part of a service, the task will continue
/// its lifecycle regardless of its health status. For tasks that are part of
/// a service, if the task reports as unhealthy then the task will be stopped
/// and the service scheduler will replace it.
/// 
/// When a container health check fails for a task that is part of a service,
/// the following process occurs:
/// 
/// The task is marked as UNHEALTHY.
/// 
/// The unhealthy task will be stopped, and during the stopping process, it will
/// go through the following states:
/// 
///    * DEACTIVATING - In this state, Amazon ECS performs additional steps before
///    stopping the task. For example, for tasks that are part of services configured
///    to use Elastic Load Balancing target groups, target groups will be deregistered
///    in this state.
/// 
///    * STOPPING - The task is in the process of being stopped.
/// 
///    * DEPROVISIONING - Resources associated with the task are being cleaned
///    up.
/// 
///    * STOPPED - The task has been completely stopped.
/// 
/// After the old task stops, a new task will be launched to ensure service operation,
/// and the new task will go through the following lifecycle:
/// 
///    * PROVISIONING - Resources required for the task are being provisioned.
/// 
///    * PENDING - The task is waiting to be placed on a container instance.
/// 
///    * ACTIVATING - In this state, Amazon ECS pulls container images, creates
///    containers, configures task networking, registers load balancer target
///    groups, and configures service discovery status.
/// 
///    * RUNNING - The task is running and performing its work.
/// 
/// For more detailed information about task lifecycle states, see Task lifecycle
/// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-lifecycle-explanation.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// The following are notes about container health check support:
/// 
///    * If the Amazon ECS container agent becomes disconnected from the Amazon
///    ECS service, this won&apos;t cause a container to transition to an UNHEALTHY
///    status. This is by design, to ensure that containers remain running during
///    agent restarts or temporary unavailability. The health check status is
///    the &quot;last heard from&quot; response from the Amazon ECS agent, so if the container
///    was considered HEALTHY prior to the disconnect, that status will remain
///    until the agent reconnects and another health check occurs. There are
///    no assumptions made about the status of the container health checks.
/// 
///    * Container health checks require version 1.17.0 or greater of the Amazon
///    ECS container agent. For more information, see Updating the Amazon ECS
///    container agent (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html).
/// 
///    * Container health checks are supported for Fargate tasks if you&apos;re using
///    platform version 1.1.0 or greater. For more information, see Fargate platform
///    versions (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html).
/// 
///    * Container health checks aren&apos;t supported for tasks that are part of
///    a service that&apos;s configured to use a Classic Load Balancer.
/// 
/// For an example of how to specify a task definition with multiple containers
/// where container dependency is specified, see Container dependency (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/example_task_definitions.html#example_task_definition-containerdependency)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsHealthCheck
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("interval")]
    public long? Interval { get; set; }

    [JsonPropertyName("retries")]
    public long? Retries { get; set; }

    [JsonPropertyName("startPeriod")]
    public long? StartPeriod { get; set; }

    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}

/// <summary>
/// The Linux capabilities to add or remove from the default Docker configuration
/// for a container defined in the task definition. For more detailed information
/// about these Linux capabilities, see the capabilities(7) (http://man7.org/linux/man-pages/man7/capabilities.7.html)
/// Linux manual page.
/// 
/// The following describes how Docker processes the Linux capabilities specified
/// in the add and drop request parameters. For information about the latest
/// behavior, see Docker Compose: order of cap_drop and cap_add (https://forums.docker.com/t/docker-compose-order-of-cap-drop-and-cap-add/97136/1)
/// in the Docker Community Forum.
/// 
///    * When the container is a privleged container, the container capabilities
///    are all of the default Docker capabilities. The capabilities specified
///    in the add request parameter, and the drop request parameter are ignored.
/// 
///    * When the add request parameter is set to ALL, the container capabilities
///    are all of the default Docker capabilities, excluding those specified
///    in the drop request parameter.
/// 
///    * When the drop request parameter is set to ALL, the container capabilities
///    are the capabilities specified in the add request parameter.
/// 
///    * When the add request parameter and the drop request parameter are both
///    empty, the capabilities the container capabilities are all of the default
///    Docker capabilities.
/// 
///    * The default is to first drop the capabilities specified in the drop
///    request parameter, and then add the capabilities specified in the add
///    request parameter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParametersCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary>An object representing a container instance host device.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParametersDevices
{
    [JsonPropertyName("containerPath")]
    public string? ContainerPath { get; set; }

    [JsonPropertyName("hostPath")]
    public string? HostPath { get; set; }

    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }
}

/// <summary>The container path, mount options, and size of the tmpfs mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParametersTmpfs
{
    [JsonPropertyName("containerPath")]
    public string? ContainerPath { get; set; }

    [JsonPropertyName("mountOptions")]
    public IList<string>? MountOptions { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }
}

/// <summary>
/// The Linux-specific options that are applied to the container, such as Linux
/// KernelCapabilities (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_KernelCapabilities.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParameters
{
    /// <summary>
    /// The Linux capabilities to add or remove from the default Docker configuration
    /// for a container defined in the task definition. For more detailed information
    /// about these Linux capabilities, see the capabilities(7) (http://man7.org/linux/man-pages/man7/capabilities.7.html)
    /// Linux manual page.
    /// 
    /// The following describes how Docker processes the Linux capabilities specified
    /// in the add and drop request parameters. For information about the latest
    /// behavior, see Docker Compose: order of cap_drop and cap_add (https://forums.docker.com/t/docker-compose-order-of-cap-drop-and-cap-add/97136/1)
    /// in the Docker Community Forum.
    /// 
    ///    * When the container is a privleged container, the container capabilities
    ///    are all of the default Docker capabilities. The capabilities specified
    ///    in the add request parameter, and the drop request parameter are ignored.
    /// 
    ///    * When the add request parameter is set to ALL, the container capabilities
    ///    are all of the default Docker capabilities, excluding those specified
    ///    in the drop request parameter.
    /// 
    ///    * When the drop request parameter is set to ALL, the container capabilities
    ///    are the capabilities specified in the add request parameter.
    /// 
    ///    * When the add request parameter and the drop request parameter are both
    ///    empty, the capabilities the container capabilities are all of the default
    ///    Docker capabilities.
    /// 
    ///    * The default is to first drop the capabilities specified in the drop
    ///    request parameter, and then add the capabilities specified in the add
    ///    request parameter.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParametersCapabilities? Capabilities { get; set; }

    [JsonPropertyName("devices")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParametersDevices>? Devices { get; set; }

    [JsonPropertyName("initProcessEnabled")]
    public bool? InitProcessEnabled { get; set; }

    [JsonPropertyName("maxSwap")]
    public long? MaxSwap { get; set; }

    [JsonPropertyName("sharedMemorySize")]
    public long? SharedMemorySize { get; set; }

    [JsonPropertyName("swappiness")]
    public long? Swappiness { get; set; }

    [JsonPropertyName("tmpfs")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParametersTmpfs>? Tmpfs { get; set; }
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
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsLogConfigurationSecretOptions
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
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsLogConfiguration
{
    [JsonPropertyName("logDriver")]
    public string? LogDriver { get; set; }

    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    [JsonPropertyName("secretOptions")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsLogConfigurationSecretOptions>? SecretOptions { get; set; }
}

/// <summary>The details for a volume mount point that&apos;s used in a container definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsMountPoints
{
    [JsonPropertyName("containerPath")]
    public string? ContainerPath { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("sourceVolume")]
    public string? SourceVolume { get; set; }
}

/// <summary>
/// Port mappings allow containers to access ports on the host container instance
/// to send or receive traffic. Port mappings are specified as part of the container
/// definition.
/// 
/// If you use containers in a task with the awsvpc or host network mode, specify
/// the exposed ports using containerPort. The hostPort can be left blank or
/// it must be the same value as the containerPort.
/// 
/// Most fields of this parameter (containerPort, hostPort, protocol) maps to
/// PortBindings in the docker container create command and the --publish option
/// to docker run. If the network mode of a task definition is set to host, host
/// ports must either be undefined or match the container port in the port mapping.
/// 
/// You can&apos;t expose the same container port for multiple protocols. If you attempt
/// this, an error is returned.
/// 
/// After a task reaches the RUNNING status, manual and automatic host and container
/// port assignments are visible in the networkBindings section of DescribeTasks
/// (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeTasks.html)
/// API responses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsPortMappings
{
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }

    [JsonPropertyName("containerPort")]
    public long? ContainerPort { get; set; }

    [JsonPropertyName("containerPortRange")]
    public string? ContainerPortRange { get; set; }

    [JsonPropertyName("hostPort")]
    public long? HostPort { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>The repository credentials for private registry authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsRepositoryCredentials
{
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }
}

/// <summary>
/// The type and amount of a resource to assign to a container. The supported
/// resource types are GPUs, Neuron devices, and Elastic Inference accelerators.
/// For more information, see Working with GPUs on Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-gpu.html)
/// or Working with Amazon Elastic Inference on Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-inference.html)
/// in the Amazon Elastic Container Service Developer Guide
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsResourceRequirements
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
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
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

/// <summary>
/// A list of namespaced kernel parameters to set in the container. This parameter
/// maps to Sysctls in the docker container create command and the --sysctl option
/// to docker run. For example, you can configure net.ipv4.tcp_keepalive_time
/// setting to maintain longer lived connections.
/// 
/// We don&apos;t recommend that you specify network-related systemControls parameters
/// for multiple containers in a single task that also uses either the awsvpc
/// or host network mode. Doing this has the following disadvantages:
/// 
///   - For tasks that use the awsvpc network mode including Fargate, if you
///     set systemControls for any container, it applies to all containers in
///     the task. If you set different systemControls for multiple containers
///     in a single task, the container that&apos;s started last determines which systemControls
///     take effect.
/// 
///   - For tasks that use the host network mode, the network namespace systemControls
///     aren&apos;t supported.
/// 
/// If you&apos;re setting an IPC resource namespace to use for the containers in
/// the task, the following conditions apply to your system controls. For more
/// information, see IPC mode (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#task_definition_ipcmode).
/// 
///   - For tasks that use the host IPC mode, IPC namespace systemControls aren&apos;t
///     supported.
/// 
///   - For tasks that use the task IPC mode, IPC namespace systemControls values
///     apply to all containers within a task.
/// 
/// This parameter is not supported for Windows containers.
/// 
/// This parameter is only supported for tasks that are hosted on Fargate if
/// the tasks are using platform version 1.4.0 or later (Linux). This isn&apos;t supported
/// for Windows containers on Fargate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsSystemControls
{
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The ulimit settings to pass to the container.
/// 
/// Amazon ECS tasks hosted on Fargate use the default resource limit values
/// set by the operating system with the exception of the nofile resource limit
/// parameter which Fargate overrides. The nofile resource limit sets a restriction
/// on the number of open files that a container can use. The default nofile
/// soft limit is 65535 and the default hard limit is 65535.
/// 
/// You can specify the ulimit settings for a container in a task definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsUlimits
{
    [JsonPropertyName("hardLimit")]
    public long? HardLimit { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("softLimit")]
    public long? SoftLimit { get; set; }
}

/// <summary>Details on a data volume from another container in the same task definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitionsVolumesFrom
{
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("sourceContainer")]
    public string? SourceContainer { get; set; }
}

/// <summary>
/// Container definitions are used in task definitions to describe the different
/// containers that are launched as part of a task.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecContainerDefinitions
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("cpu")]
    public long? Cpu { get; set; }

    [JsonPropertyName("credentialSpecs")]
    public IList<string>? CredentialSpecs { get; set; }

    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsDependsOn>? DependsOn { get; set; }

    [JsonPropertyName("disableNetworking")]
    public bool? DisableNetworking { get; set; }

    [JsonPropertyName("dnsSearchDomains")]
    public IList<string>? DnsSearchDomains { get; set; }

    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    [JsonPropertyName("dockerLabels")]
    public IDictionary<string, string>? DockerLabels { get; set; }

    [JsonPropertyName("dockerSecurityOptions")]
    public IList<string>? DockerSecurityOptions { get; set; }

    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    [JsonPropertyName("environment")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsEnvironment>? Environment { get; set; }

    [JsonPropertyName("environmentFiles")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsEnvironmentFiles>? EnvironmentFiles { get; set; }

    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    [JsonPropertyName("extraHosts")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsExtraHosts>? ExtraHosts { get; set; }

    /// <summary>
    /// The FireLens configuration for the container. This is used to specify and
    /// configure a log router for container logs. For more information, see Custom
    /// log routing (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("firelensConfiguration")]
    public V1alpha1TaskDefinitionSpecContainerDefinitionsFirelensConfiguration? FirelensConfiguration { get; set; }

    /// <summary>
    /// An object representing a container health check. Health check parameters
    /// that are specified in a container definition override any Docker health checks
    /// that exist in the container image (such as those specified in a parent image
    /// or from the image&apos;s Dockerfile). This configuration maps to the HEALTHCHECK
    /// parameter of docker run.
    /// 
    /// The Amazon ECS container agent only monitors and reports on the health checks
    /// specified in the task definition. Amazon ECS does not monitor Docker health
    /// checks that are embedded in a container image and not specified in the container
    /// definition. Health check parameters that are specified in a container definition
    /// override any Docker health checks that exist in the container image.
    /// 
    /// You can view the health status of both individual containers and a task with
    /// the DescribeTasks API operation or when viewing the task details in the console.
    /// 
    /// The health check is designed to make sure that your containers survive agent
    /// restarts, upgrades, or temporary unavailability.
    /// 
    /// Amazon ECS performs health checks on containers with the default that launched
    /// the container instance or the task.
    /// 
    /// The following describes the possible healthStatus values for a container:
    /// 
    ///    * HEALTHY-The container health check has passed successfully.
    /// 
    ///    * UNHEALTHY-The container health check has failed.
    /// 
    ///    * UNKNOWN-The container health check is being evaluated, there&apos;s no container
    ///    health check defined, or Amazon ECS doesn&apos;t have the health status of
    ///    the container.
    /// 
    /// The following describes the possible healthStatus values based on the container
    /// health checker status of essential containers in the task with the following
    /// priority order (high to low):
    /// 
    ///    * UNHEALTHY-One or more essential containers have failed their health
    ///    check.
    /// 
    ///    * UNKNOWN-Any essential container running within the task is in an UNKNOWN
    ///    state and no other essential containers have an UNHEALTHY state.
    /// 
    ///    * HEALTHY-All essential containers within the task have passed their health
    ///    checks.
    /// 
    /// Consider the following task health example with 2 containers.
    /// 
    ///    * If Container1 is UNHEALTHY and Container2 is UNKNOWN, the task health
    ///    is UNHEALTHY.
    /// 
    ///    * If Container1 is UNHEALTHY and Container2 is HEALTHY, the task health
    ///    is UNHEALTHY.
    /// 
    ///    * If Container1 is HEALTHY and Container2 is UNKNOWN, the task health
    ///    is UNKNOWN.
    /// 
    ///    * If Container1 is HEALTHY and Container2 is HEALTHY, the task health
    ///    is HEALTHY.
    /// 
    /// Consider the following task health example with 3 containers.
    /// 
    ///    * If Container1 is UNHEALTHY and Container2 is UNKNOWN, and Container3
    ///    is UNKNOWN, the task health is UNHEALTHY.
    /// 
    ///    * If Container1 is UNHEALTHY and Container2 is UNKNOWN, and Container3
    ///    is HEALTHY, the task health is UNHEALTHY.
    /// 
    ///    * If Container1 is UNHEALTHY and Container2 is HEALTHY, and Container3
    ///    is HEALTHY, the task health is UNHEALTHY.
    /// 
    ///    * If Container1 is HEALTHY and Container2 is UNKNOWN, and Container3 is
    ///    HEALTHY, the task health is UNKNOWN.
    /// 
    ///    * If Container1 is HEALTHY and Container2 is UNKNOWN, and Container3 is
    ///    UNKNOWN, the task health is UNKNOWN.
    /// 
    ///    * If Container1 is HEALTHY and Container2 is HEALTHY, and Container3 is
    ///    HEALTHY, the task health is HEALTHY.
    /// 
    /// If a task is run manually, and not as part of a service, the task will continue
    /// its lifecycle regardless of its health status. For tasks that are part of
    /// a service, if the task reports as unhealthy then the task will be stopped
    /// and the service scheduler will replace it.
    /// 
    /// When a container health check fails for a task that is part of a service,
    /// the following process occurs:
    /// 
    /// The task is marked as UNHEALTHY.
    /// 
    /// The unhealthy task will be stopped, and during the stopping process, it will
    /// go through the following states:
    /// 
    ///    * DEACTIVATING - In this state, Amazon ECS performs additional steps before
    ///    stopping the task. For example, for tasks that are part of services configured
    ///    to use Elastic Load Balancing target groups, target groups will be deregistered
    ///    in this state.
    /// 
    ///    * STOPPING - The task is in the process of being stopped.
    /// 
    ///    * DEPROVISIONING - Resources associated with the task are being cleaned
    ///    up.
    /// 
    ///    * STOPPED - The task has been completely stopped.
    /// 
    /// After the old task stops, a new task will be launched to ensure service operation,
    /// and the new task will go through the following lifecycle:
    /// 
    ///    * PROVISIONING - Resources required for the task are being provisioned.
    /// 
    ///    * PENDING - The task is waiting to be placed on a container instance.
    /// 
    ///    * ACTIVATING - In this state, Amazon ECS pulls container images, creates
    ///    containers, configures task networking, registers load balancer target
    ///    groups, and configures service discovery status.
    /// 
    ///    * RUNNING - The task is running and performing its work.
    /// 
    /// For more detailed information about task lifecycle states, see Task lifecycle
    /// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-lifecycle-explanation.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// The following are notes about container health check support:
    /// 
    ///    * If the Amazon ECS container agent becomes disconnected from the Amazon
    ///    ECS service, this won&apos;t cause a container to transition to an UNHEALTHY
    ///    status. This is by design, to ensure that containers remain running during
    ///    agent restarts or temporary unavailability. The health check status is
    ///    the &quot;last heard from&quot; response from the Amazon ECS agent, so if the container
    ///    was considered HEALTHY prior to the disconnect, that status will remain
    ///    until the agent reconnects and another health check occurs. There are
    ///    no assumptions made about the status of the container health checks.
    /// 
    ///    * Container health checks require version 1.17.0 or greater of the Amazon
    ///    ECS container agent. For more information, see Updating the Amazon ECS
    ///    container agent (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html).
    /// 
    ///    * Container health checks are supported for Fargate tasks if you&apos;re using
    ///    platform version 1.1.0 or greater. For more information, see Fargate platform
    ///    versions (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html).
    /// 
    ///    * Container health checks aren&apos;t supported for tasks that are part of
    ///    a service that&apos;s configured to use a Classic Load Balancer.
    /// 
    /// For an example of how to specify a task definition with multiple containers
    /// where container dependency is specified, see Container dependency (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/example_task_definitions.html#example_task_definition-containerdependency)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TaskDefinitionSpecContainerDefinitionsHealthCheck? HealthCheck { get; set; }

    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("interactive")]
    public bool? Interactive { get; set; }

    [JsonPropertyName("links")]
    public IList<string>? Links { get; set; }

    /// <summary>
    /// The Linux-specific options that are applied to the container, such as Linux
    /// KernelCapabilities (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_KernelCapabilities.html).
    /// </summary>
    [JsonPropertyName("linuxParameters")]
    public V1alpha1TaskDefinitionSpecContainerDefinitionsLinuxParameters? LinuxParameters { get; set; }

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
    public V1alpha1TaskDefinitionSpecContainerDefinitionsLogConfiguration? LogConfiguration { get; set; }

    [JsonPropertyName("memory")]
    public long? Memory { get; set; }

    [JsonPropertyName("memoryReservation")]
    public long? MemoryReservation { get; set; }

    [JsonPropertyName("mountPoints")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsMountPoints>? MountPoints { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("portMappings")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsPortMappings>? PortMappings { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("pseudoTerminal")]
    public bool? PseudoTerminal { get; set; }

    [JsonPropertyName("readonlyRootFilesystem")]
    public bool? ReadonlyRootFilesystem { get; set; }

    /// <summary>The repository credentials for private registry authentication.</summary>
    [JsonPropertyName("repositoryCredentials")]
    public V1alpha1TaskDefinitionSpecContainerDefinitionsRepositoryCredentials? RepositoryCredentials { get; set; }

    [JsonPropertyName("resourceRequirements")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsResourceRequirements>? ResourceRequirements { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsSecrets>? Secrets { get; set; }

    [JsonPropertyName("startTimeout")]
    public long? StartTimeout { get; set; }

    [JsonPropertyName("stopTimeout")]
    public long? StopTimeout { get; set; }

    [JsonPropertyName("systemControls")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsSystemControls>? SystemControls { get; set; }

    [JsonPropertyName("ulimits")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsUlimits>? Ulimits { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    [JsonPropertyName("volumesFrom")]
    public IList<V1alpha1TaskDefinitionSpecContainerDefinitionsVolumesFrom>? VolumesFrom { get; set; }

    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>
/// The amount of ephemeral storage to allocate for the task. This parameter
/// is used to expand the total amount of ephemeral storage available, beyond
/// the default amount, for tasks hosted on Fargate. For more information, see
/// Using data volumes in tasks (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html)
/// in the Amazon ECS Developer Guide.
/// 
/// For tasks using the Fargate launch type, the task requires the following
/// platforms:
/// 
///   - Linux platform version 1.4.0 or later.
/// 
///   - Windows platform version 1.0.0 or later.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecEphemeralStorage
{
    [JsonPropertyName("sizeInGiB")]
    public long? SizeInGiB { get; set; }
}

/// <summary>
/// Details on an Elastic Inference accelerator. For more information, see Working
/// with Amazon Elastic Inference on Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-inference.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecInferenceAccelerators
{
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("deviceType")]
    public string? DeviceType { get; set; }
}

/// <summary>
/// The constraint on task placement in the task definition. For more information,
/// see Task placement constraints (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// Task placement constraints aren&apos;t supported for tasks run on Fargate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecPlacementConstraints
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A key-value pair object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecProxyConfigurationProperties
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The configuration details for the App Mesh proxy.
/// 
/// For tasks hosted on Amazon EC2 instances, the container instances require
/// at least version 1.26.0 of the container agent and at least version 1.26.0-1
/// of the ecs-init package to use a proxy configuration. If your container instances
/// are launched from the Amazon ECS-optimized AMI version 20190301 or later,
/// then they contain the required versions of the container agent and ecs-init.
/// For more information, see Amazon ECS-optimized AMI versions (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-ami-versions.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecProxyConfiguration
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("properties")]
    public IList<V1alpha1TaskDefinitionSpecProxyConfigurationProperties>? Properties { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The operating system that your tasks definitions run on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecRuntimePlatform
{
    [JsonPropertyName("cpuArchitecture")]
    public string? CpuArchitecture { get; set; }

    [JsonPropertyName("operatingSystemFamily")]
    public string? OperatingSystemFamily { get; set; }
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
public partial class V1alpha1TaskDefinitionSpecTags
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
public partial class V1alpha1TaskDefinitionSpecTaskRoleRefFrom
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
public partial class V1alpha1TaskDefinitionSpecTaskRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1TaskDefinitionSpecTaskRoleRefFrom? From { get; set; }
}

/// <summary>
/// This parameter is specified when you&apos;re using Docker volumes. Docker volumes
/// are only supported when you&apos;re using the EC2 launch type. Windows containers
/// only support the use of the local driver. To use bind mounts, specify a host
/// instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecVolumesDockerVolumeConfiguration
{
    [JsonPropertyName("autoprovision")]
    public bool? Autoprovision { get; set; }

    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("driverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>The authorization configuration details for the Amazon EFS file system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecVolumesEfsVolumeConfigurationAuthorizationConfig
{
    [JsonPropertyName("accessPointID")]
    public string? AccessPointID { get; set; }

    [JsonPropertyName("iam")]
    public string? Iam { get; set; }
}

/// <summary>
/// This parameter is specified when you&apos;re using an Amazon Elastic File System
/// file system for task storage. For more information, see Amazon EFS volumes
/// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/efs-volumes.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecVolumesEfsVolumeConfiguration
{
    /// <summary>The authorization configuration details for the Amazon EFS file system.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1alpha1TaskDefinitionSpecVolumesEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }

    [JsonPropertyName("transitEncryption")]
    public string? TransitEncryption { get; set; }

    [JsonPropertyName("transitEncryptionPort")]
    public long? TransitEncryptionPort { get; set; }
}

/// <summary>
/// The authorization configuration details for Amazon FSx for Windows File Server
/// file system. See FSxWindowsFileServerVolumeConfiguration (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_FSxWindowsFileServerVolumeConfiguration.html)
/// in the Amazon ECS API Reference.
/// 
/// For more information and the input format, see Amazon FSx for Windows File
/// Server Volumes (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/wfsx-volumes.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecVolumesFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
{
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }

    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary>
/// This parameter is specified when you&apos;re using Amazon FSx for Windows File
/// Server (https://docs.aws.amazon.com/fsx/latest/WindowsGuide/what-is.html)
/// file system for task storage.
/// 
/// For more information and the input format, see Amazon FSx for Windows File
/// Server volumes (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/wfsx-volumes.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecVolumesFsxWindowsFileServerVolumeConfiguration
{
    /// <summary>
    /// The authorization configuration details for Amazon FSx for Windows File Server
    /// file system. See FSxWindowsFileServerVolumeConfiguration (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_FSxWindowsFileServerVolumeConfiguration.html)
    /// in the Amazon ECS API Reference.
    /// 
    /// For more information and the input format, see Amazon FSx for Windows File
    /// Server Volumes (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/wfsx-volumes.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("authorizationConfig")]
    public V1alpha1TaskDefinitionSpecVolumesFsxWindowsFileServerVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

/// <summary>Details on a container instance bind mount host volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecVolumesHost
{
    [JsonPropertyName("sourcePath")]
    public string? SourcePath { get; set; }
}

/// <summary>
/// The data volume configuration for tasks launched using this task definition.
/// Specifying a volume configuration in a task definition is optional. The volume
/// configuration may contain multiple volumes but only one volume configured
/// at launch is supported. Each volume defined in the volume configuration may
/// only specify a name and one of either configuredAtLaunch, dockerVolumeConfiguration,
/// efsVolumeConfiguration, s3filesVolumeConfiguration, fsxWindowsFileServerVolumeConfiguration,
/// or host. If an empty volume configuration is specified, by default Amazon
/// ECS uses a host volume. For more information, see Using data volumes in tasks
/// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpecVolumes
{
    [JsonPropertyName("configuredAtLaunch")]
    public bool? ConfiguredAtLaunch { get; set; }

    /// <summary>
    /// This parameter is specified when you&apos;re using Docker volumes. Docker volumes
    /// are only supported when you&apos;re using the EC2 launch type. Windows containers
    /// only support the use of the local driver. To use bind mounts, specify a host
    /// instead.
    /// </summary>
    [JsonPropertyName("dockerVolumeConfiguration")]
    public V1alpha1TaskDefinitionSpecVolumesDockerVolumeConfiguration? DockerVolumeConfiguration { get; set; }

    /// <summary>
    /// This parameter is specified when you&apos;re using an Amazon Elastic File System
    /// file system for task storage. For more information, see Amazon EFS volumes
    /// (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/efs-volumes.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("efsVolumeConfiguration")]
    public V1alpha1TaskDefinitionSpecVolumesEfsVolumeConfiguration? EfsVolumeConfiguration { get; set; }

    /// <summary>
    /// This parameter is specified when you&apos;re using Amazon FSx for Windows File
    /// Server (https://docs.aws.amazon.com/fsx/latest/WindowsGuide/what-is.html)
    /// file system for task storage.
    /// 
    /// For more information and the input format, see Amazon FSx for Windows File
    /// Server volumes (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/wfsx-volumes.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("fsxWindowsFileServerVolumeConfiguration")]
    public V1alpha1TaskDefinitionSpecVolumesFsxWindowsFileServerVolumeConfiguration? FsxWindowsFileServerVolumeConfiguration { get; set; }

    /// <summary>Details on a container instance bind mount host volume.</summary>
    [JsonPropertyName("host")]
    public V1alpha1TaskDefinitionSpecVolumesHost? Host { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// TaskDefinitionSpec defines the desired state of TaskDefinition.
/// 
/// The details of a task definition which describes the container and volume
/// definitions of an Amazon Elastic Container Service task. You can specify
/// which Docker images to use, the required resources, and other configurations
/// related to launching the task definition through an Amazon ECS service or
/// task.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionSpec
{
    /// <summary>
    /// A list of container definitions in JSON format that describe the different
    /// containers that make up your task.
    /// </summary>
    [JsonPropertyName("containerDefinitions")]
    public required IList<V1alpha1TaskDefinitionSpecContainerDefinitions> ContainerDefinitions { get; set; }

    /// <summary>
    /// The number of CPU units used by the task. It can be expressed as an integer
    /// using CPU units (for example, 1024) or as a string using vCPUs (for example,
    /// 1 vCPU or 1 vcpu) in a task definition. String values are converted to an
    /// integer indicating the CPU units when the task definition is registered.
    /// 
    /// Task-level CPU and memory parameters are ignored for Windows containers.
    /// We recommend specifying container-level resources for Windows containers.
    /// 
    /// If you&apos;re using the EC2 launch type or external launch type, this field is
    /// optional. Supported values are between 128 CPU units (0.125 vCPUs) and 196608
    /// CPU units (192 vCPUs). If you do not specify a value, the parameter is ignored.
    /// 
    /// This field is required for Fargate. For information about the valid values,
    /// see Task size (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#task_size)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>
    /// The amount of ephemeral storage to allocate for the task. This parameter
    /// is used to expand the total amount of ephemeral storage available, beyond
    /// the default amount, for tasks hosted on Fargate. For more information, see
    /// Using data volumes in tasks (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html)
    /// in the Amazon ECS Developer Guide.
    /// 
    /// For tasks using the Fargate launch type, the task requires the following
    /// platforms:
    /// 
    ///   - Linux platform version 1.4.0 or later.
    /// 
    ///   - Windows platform version 1.0.0 or later.
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1alpha1TaskDefinitionSpecEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the task execution role that grants the
    /// Amazon ECS container agent permission to make Amazon Web Services API calls
    /// on your behalf. For informationabout the required IAM roles for Amazon ECS,
    /// see IAM roles for Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/security-ecs-iam-role-overview.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("executionRoleARN")]
    public string? ExecutionRoleARN { get; set; }

    /// <summary>
    /// You must specify a family for a task definition. You can use it track multiple
    /// versions of the same task definition. The family is used as a name for your
    /// task definition. Up to 255 letters (uppercase and lowercase), numbers, underscores,
    /// and hyphens are allowed.
    /// </summary>
    [JsonPropertyName("family")]
    public required string Family { get; set; }

    /// <summary>The Elastic Inference accelerators to use for the containers in the task.</summary>
    [JsonPropertyName("inferenceAccelerators")]
    public IList<V1alpha1TaskDefinitionSpecInferenceAccelerators>? InferenceAccelerators { get; set; }

    /// <summary>
    /// The IPC resource namespace to use for the containers in the task. The valid
    /// values are host, task, or none. If host is specified, then all containers
    /// within the tasks that specified the host IPC mode on the same container instance
    /// share the same IPC resources with the host Amazon EC2 instance. If task is
    /// specified, all containers within the specified task share the same IPC resources.
    /// If none is specified, then IPC resources within the containers of a task
    /// are private and not shared with other containers in a task or on the container
    /// instance. If no value is specified, then the IPC resource namespace sharing
    /// depends on the Docker daemon setting on the container instance.
    /// 
    /// If the host IPC mode is used, be aware that there is a heightened risk of
    /// undesired IPC namespace expose.
    /// 
    /// If you are setting namespaced kernel parameters using systemControls for
    /// the containers in the task, the following will apply to your IPC resource
    /// namespace. For more information, see System Controls (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    ///   - For tasks that use the host IPC mode, IPC namespace related systemControls
    ///     are not supported.
    /// 
    ///   - For tasks that use the task IPC mode, IPC namespace related systemControls
    ///     will apply to all containers within a task.
    /// 
    /// This parameter is not supported for Windows containers or tasks run on Fargate.
    /// </summary>
    [JsonPropertyName("ipcMode")]
    public string? IpcMode { get; set; }

    /// <summary>
    /// The amount of memory (in MiB) used by the task. It can be expressed as an
    /// integer using MiB (for example ,1024) or as a string using GB (for example,
    /// 1GB or 1 GB) in a task definition. String values are converted to an integer
    /// indicating the MiB when the task definition is registered.
    /// 
    /// Task-level CPU and memory parameters are ignored for Windows containers.
    /// We recommend specifying container-level resources for Windows containers.
    /// 
    /// If using the EC2 launch type, this field is optional.
    /// 
    /// If using the Fargate launch type, this field is required and you must use
    /// one of the following values. This determines your range of supported values
    /// for the cpu parameter.
    /// 
    /// The CPU units cannot be less than 1 vCPU when you use Windows containers
    /// on Fargate.
    /// 
    ///   - 512 (0.5 GB), 1024 (1 GB), 2048 (2 GB) - Available cpu values: 256 (.25
    ///     vCPU)
    /// 
    ///   - 1024 (1 GB), 2048 (2 GB), 3072 (3 GB), 4096 (4 GB) - Available cpu values:
    ///     512 (.5 vCPU)
    /// 
    ///   - 2048 (2 GB), 3072 (3 GB), 4096 (4 GB), 5120 (5 GB), 6144 (6 GB), 7168
    ///     (7 GB), 8192 (8 GB) - Available cpu values: 1024 (1 vCPU)
    /// 
    ///   - Between 4096 (4 GB) and 16384 (16 GB) in increments of 1024 (1 GB) -
    ///     Available cpu values: 2048 (2 vCPU)
    /// 
    ///   - Between 8192 (8 GB) and 30720 (30 GB) in increments of 1024 (1 GB) -
    ///     Available cpu values: 4096 (4 vCPU)
    /// 
    ///   - Between 16 GB and 60 GB in 4 GB increments - Available cpu values: 8192
    ///     (8 vCPU) This option requires Linux platform 1.4.0 or later.
    /// 
    ///   - Between 32GB and 120 GB in 8 GB increments - Available cpu values: 16384
    ///     (16 vCPU) This option requires Linux platform 1.4.0 or later.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The Docker networking mode to use for the containers in the task. The valid
    /// values are none, bridge, awsvpc, and host. If no network mode is specified,
    /// the default is bridge.
    /// 
    /// For Amazon ECS tasks on Fargate, the awsvpc network mode is required. For
    /// Amazon ECS tasks on Amazon EC2 Linux instances, any network mode can be used.
    /// For Amazon ECS tasks on Amazon EC2 Windows instances, &lt;default&gt; or awsvpc
    /// can be used. If the network mode is set to none, you cannot specify port
    /// mappings in your container definitions, and the tasks containers do not have
    /// external connectivity. The host and awsvpc network modes offer the highest
    /// networking performance for containers because they use the EC2 network stack
    /// instead of the virtualized network stack provided by the bridge mode.
    /// 
    /// With the host and awsvpc network modes, exposed container ports are mapped
    /// directly to the corresponding host port (for the host network mode) or the
    /// attached elastic network interface port (for the awsvpc network mode), so
    /// you cannot take advantage of dynamic host port mappings.
    /// 
    /// When using the host network mode, you should not run containers using the
    /// root user (UID 0). It is considered best practice to use a non-root user.
    /// 
    /// If the network mode is awsvpc, the task is allocated an elastic network interface,
    /// and you must specify a NetworkConfiguration (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_NetworkConfiguration.html)
    /// value when you create a service or run a task with the task definition. For
    /// more information, see Task Networking (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// If the network mode is host, you cannot run multiple instantiations of the
    /// same task on a single container instance when port mappings are used.
    /// </summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>
    /// The process namespace to use for the containers in the task. The valid values
    /// are host or task. On Fargate for Linux containers, the only valid value is
    /// task. For example, monitoring sidecars might need pidMode to access information
    /// about other containers running in the same task.
    /// 
    /// If host is specified, all containers within the tasks that specified the
    /// host PID mode on the same container instance share the same process namespace
    /// with the host Amazon EC2 instance.
    /// 
    /// If task is specified, all containers within the specified task share the
    /// same process namespace.
    /// 
    /// If no value is specified, the The default is a private namespace for each
    /// container.
    /// 
    /// If the host PID mode is used, there&apos;s a heightened risk of undesired process
    /// namespace exposure.
    /// 
    /// This parameter is not supported for Windows containers.
    /// 
    /// This parameter is only supported for tasks that are hosted on Fargate if
    /// the tasks are using platform version 1.4.0 or later (Linux). This isn&apos;t supported
    /// for Windows containers on Fargate.
    /// </summary>
    [JsonPropertyName("pidMode")]
    public string? PidMode { get; set; }

    /// <summary>
    /// An array of placement constraint objects to use for the task. You can specify
    /// a maximum of 10 constraints for each task. This limit includes constraints
    /// in the task definition and those specified at runtime.
    /// </summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1alpha1TaskDefinitionSpecPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>
    /// The configuration details for the App Mesh proxy.
    /// 
    /// For tasks hosted on Amazon EC2 instances, the container instances require
    /// at least version 1.26.0 of the container agent and at least version 1.26.0-1
    /// of the ecs-init package to use a proxy configuration. If your container instances
    /// are launched from the Amazon ECS-optimized AMI version 20190301 or later,
    /// then they contain the required versions of the container agent and ecs-init.
    /// For more information, see Amazon ECS-optimized AMI versions (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-ami-versions.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("proxyConfiguration")]
    public V1alpha1TaskDefinitionSpecProxyConfiguration? ProxyConfiguration { get; set; }

    /// <summary>
    /// The task launch type that Amazon ECS validates the task definition against.
    /// A client exception is returned if the task definition doesn&apos;t validate against
    /// the compatibilities specified. If no value is specified, the parameter is
    /// omitted from the response.
    /// </summary>
    [JsonPropertyName("requiresCompatibilities")]
    public IList<string>? RequiresCompatibilities { get; set; }

    /// <summary>The operating system that your tasks definitions run on.</summary>
    [JsonPropertyName("runtimePlatform")]
    public V1alpha1TaskDefinitionSpecRuntimePlatform? RuntimePlatform { get; set; }

    /// <summary>
    /// The metadata that you apply to the task definition to help you categorize
    /// and organize them. Each tag consists of a key and an optional value. You
    /// define both of them.
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
    public IList<V1alpha1TaskDefinitionSpecTags>? Tags { get; set; }

    /// <summary>
    /// The short name or full Amazon Resource Name (ARN) of the IAM role that containers
    /// in this task can assume. All containers in this task are granted the permissions
    /// that are specified in this role. For more information, see IAM Roles for
    /// Tasks (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("taskRoleARN")]
    public string? TaskRoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("taskRoleRef")]
    public V1alpha1TaskDefinitionSpecTaskRoleRef? TaskRoleRef { get; set; }

    /// <summary>
    /// A list of volume definitions in JSON format that containers in your task
    /// might use.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1TaskDefinitionSpecVolumes>? Volumes { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionStatusAckResourceMetadata
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
public partial class V1alpha1TaskDefinitionStatusConditions
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
/// An attribute is a name-value pair that&apos;s associated with an Amazon ECS object.
/// Use attributes to extend the Amazon ECS data model by adding custom metadata
/// to your resources. For more information, see Attributes (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionStatusRequiresAttributes
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("targetID")]
    public string? TargetID { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>TaskDefinitionStatus defines the observed state of TaskDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TaskDefinitionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1TaskDefinitionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// Amazon ECS validates the task definition parameters with those supported
    /// by the launch type. For more information, see Amazon ECS launch types (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// </summary>
    [JsonPropertyName("compatibilities")]
    public IList<string>? Compatibilities { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TaskDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>The Unix timestamp for the time when the task definition was deregistered.</summary>
    [JsonPropertyName("deregisteredAt")]
    public DateTime? DeregisteredAt { get; set; }

    /// <summary>The Unix timestamp for the time when the task definition was registered.</summary>
    [JsonPropertyName("registeredAt")]
    public DateTime? RegisteredAt { get; set; }

    /// <summary>The principal that registered the task definition.</summary>
    [JsonPropertyName("registeredBy")]
    public string? RegisteredBy { get; set; }

    /// <summary>
    /// The container instance attributes required by your task. When an Amazon EC2
    /// instance is registered to your cluster, the Amazon ECS container agent assigns
    /// some standard attributes to the instance. You can apply custom attributes.
    /// These are specified as key-value pairs using the Amazon ECS console or the
    /// PutAttributes (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAttributes.html)
    /// API. These attributes are used when determining task placement for tasks
    /// hosted on Amazon EC2 instances. For more information, see Attributes (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// This parameter isn&apos;t supported for tasks run on Fargate.
    /// </summary>
    [JsonPropertyName("requiresAttributes")]
    public IList<V1alpha1TaskDefinitionStatusRequiresAttributes>? RequiresAttributes { get; set; }

    /// <summary>
    /// The revision of the task in a particular family. The revision is a version
    /// number of a task definition in a family. When you register a task definition
    /// for the first time, the revision is 1. Each time that you register a new
    /// revision of a task definition in the same family, the revision value always
    /// increases by one. This is even if you deregistered previous revisions in
    /// this family.
    /// </summary>
    [JsonPropertyName("revision")]
    public long? Revision { get; set; }

    /// <summary>The status of the task definition.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>TaskDefinition is the Schema for the TaskDefinitions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TaskDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TaskDefinitionSpec?>, IStatus<V1alpha1TaskDefinitionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TaskDefinition";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "taskdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TaskDefinition";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// TaskDefinitionSpec defines the desired state of TaskDefinition.
    /// 
    /// The details of a task definition which describes the container and volume
    /// definitions of an Amazon Elastic Container Service task. You can specify
    /// which Docker images to use, the required resources, and other configurations
    /// related to launching the task definition through an Amazon ECS service or
    /// task.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1TaskDefinitionSpec? Spec { get; set; }

    /// <summary>TaskDefinitionStatus defines the observed state of TaskDefinition</summary>
    [JsonPropertyName("status")]
    public V1alpha1TaskDefinitionStatus? Status { get; set; }
}
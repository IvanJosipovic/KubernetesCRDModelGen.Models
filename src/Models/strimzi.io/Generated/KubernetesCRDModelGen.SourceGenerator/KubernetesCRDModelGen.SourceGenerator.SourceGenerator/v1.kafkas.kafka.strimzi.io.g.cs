#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.strimzi.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaList : IKubernetesObject<V1ListMeta>, IItems<V1Kafka>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaList";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkas";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Kafka objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Kafka> Items { get; set; }
}

/// <summary>
/// Type of the listener. The supported types are as follows: 
/// 
/// * `internal` type exposes Kafka internally only within the Kubernetes cluster.
/// * `route` type uses OpenShift Routes to expose Kafka.
/// * `loadbalancer` type uses LoadBalancer type services to expose Kafka.
/// * `nodeport` type uses NodePort type services to expose Kafka.
/// * `ingress` (deprecated) type uses Kubernetes Nginx Ingress to expose Kafka with TLS passthrough.
/// * `cluster-ip` type uses a per-broker `ClusterIP` service.
/// 
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaListenersTypeEnum>))]
public enum V1KafkaSpecKafkaListenersTypeEnum
{
    [EnumMember(Value = "internal"), JsonStringEnumMemberName("internal")]
    Internal,
    [EnumMember(Value = "route"), JsonStringEnumMemberName("route")]
    Route,
    [EnumMember(Value = "tlsroute"), JsonStringEnumMemberName("tlsroute")]
    Tlsroute,
    [EnumMember(Value = "loadbalancer"), JsonStringEnumMemberName("loadbalancer")]
    Loadbalancer,
    [EnumMember(Value = "nodeport"), JsonStringEnumMemberName("nodeport")]
    Nodeport,
    [EnumMember(Value = "ingress"), JsonStringEnumMemberName("ingress")]
    Ingress,
    [EnumMember(Value = "cluster-ip"), JsonStringEnumMemberName("cluster-ip")]
    ClusterIp
}

/// <summary>Authentication type. `scram-sha-512` type uses SASL SCRAM-SHA-512 Authentication. `tls` type uses TLS Client Authentication. `tls` type is supported only on TLS listeners. `custom` type allows for any authentication type to be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaListenersAuthenticationTypeEnum>))]
public enum V1KafkaSpecKafkaListenersAuthenticationTypeEnum
{
    [EnumMember(Value = "tls"), JsonStringEnumMemberName("tls")]
    Tls,
    [EnumMember(Value = "scram-sha-512"), JsonStringEnumMemberName("scram-sha-512")]
    ScramSha512,
    [EnumMember(Value = "custom"), JsonStringEnumMemberName("custom")]
    Custom
}

/// <summary>Authentication configuration for this listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersAuthentication
{
    /// <summary>Configuration to be used for a specific listener. All values are prefixed with `listener.name.&lt;listener_name&gt;`.</summary>
    [JsonPropertyName("listenerConfig")]
    public JsonNode? ListenerConfig { get; set; }

    /// <summary>Enable or disable SASL on this listener.</summary>
    [JsonPropertyName("sasl")]
    public bool? Sasl { get; set; }

    /// <summary>Authentication type. `scram-sha-512` type uses SASL SCRAM-SHA-512 Authentication. `tls` type uses TLS Client Authentication. `tls` type is supported only on TLS listeners. `custom` type allows for any authentication type to be used.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaListenersAuthenticationTypeEnum Type { get; set; }
}

/// <summary>Reference to the `Secret` which holds the certificate and private key pair which will be used for this listener. The certificate can optionally contain the whole chain. This field can be used only with listeners with enabled TLS encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersConfigurationBrokerCertChainAndKey
{
    /// <summary>The name of the Secret containing the certificate.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the file certificate in the Secret.</summary>
    [JsonPropertyName("certificate")]
    public required string Certificate { get; set; }

    /// <summary>The name of the private key in the secret. The private key must be in unencrypted PKCS #8 format. For more information, see RFC 5208: https://datatracker.ietf.org/doc/html/rfc5208.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

/// <summary>
/// Specifies whether the service routes external traffic to cluster-wide or node-local endpoints:
/// 
/// * `Cluster` may cause a second hop to another node and obscures the client source IP.
/// * `Local` avoids a second hop for `LoadBalancer` and `Nodeport` type services and preserves the client source IP (when supported by the infrastructure).
/// 
/// If unspecified, Kubernetes uses `Cluster` as the default. For `loadbalancer` or `nodeport` listeners only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaListenersConfigurationExternalTrafficPolicyEnum>))]
public enum V1KafkaSpecKafkaListenersConfigurationExternalTrafficPolicyEnum
{
    [EnumMember(Value = "Local"), JsonStringEnumMemberName("Local")]
    Local,
    [EnumMember(Value = "Cluster"), JsonStringEnumMemberName("Cluster")]
    Cluster
}

/// <summary>Bootstrap configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersConfigurationBootstrap
{
    /// <summary>Additional alternative names for the bootstrap service. The alternative names will be added to the list of subject alternative names of the TLS certificates.</summary>
    [JsonPropertyName("alternativeNames")]
    public IList<string>? AlternativeNames { get; set; }

    /// <summary>Specifies the hostname used for the bootstrap resource. For `route` (optional) or `ingress` (required) listeners only. Ensure the hostname resolves to the Ingress endpoints; no validation is performed by Strimzi.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Node port for the bootstrap service. For `nodeport` listeners only.</summary>
    [JsonPropertyName("nodePort")]
    public int? NodePort { get; set; }

    /// <summary>The loadbalancer is requested with the IP address specified in this property. This feature depends on whether the underlying cloud provider supports specifying the `loadBalancerIP` when a load balancer is created. This property is ignored if the cloud provider does not support the feature. For `loadbalancer` listeners only.</summary>
    [JsonPropertyName("loadBalancerIP")]
    public string? LoadBalancerIP { get; set; }

    /// <summary>Annotations added to `Ingress`, `Route`, or `Service` resources. You can use this property to configure DNS providers such as External DNS. For `loadbalancer`, `nodeport`, `route`, or `ingress` listeners only.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels added to `Ingress`, `Route`, or `Service` resources. For `loadbalancer`, `nodeport`, `route`, or `ingress` listeners only.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>External IPs associated to the nodeport service. These IPs are used by clients external to the Kubernetes cluster to access the Kafka brokers. This property is helpful when `nodeport` without `externalIP` is not sufficient. For example on bare-metal Kubernetes clusters that do not support Loadbalancer service types. For `nodeport` listeners only.</summary>
    [JsonPropertyName("externalIPs")]
    public IList<string>? ExternalIPs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersConfigurationBrokers
{
    /// <summary>ID of the kafka broker (broker identifier). Broker IDs start from 0 and correspond to the number of broker replicas.</summary>
    [JsonPropertyName("broker")]
    public required int Broker { get; set; }

    /// <summary>The host name used in the brokers&apos; `advertised.listeners`.</summary>
    [JsonPropertyName("advertisedHost")]
    public string? AdvertisedHost { get; set; }

    /// <summary>The port number used in the brokers&apos; `advertised.listeners`.</summary>
    [JsonPropertyName("advertisedPort")]
    public int? AdvertisedPort { get; set; }

    /// <summary>The broker host. This field will be used in the Ingress resource or in the Route resource to specify the desired hostname. This field can be used only with `route` (optional) or `ingress` (required) type listeners.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Node port for the per-broker service. This field can be used only with `nodeport` type listener.</summary>
    [JsonPropertyName("nodePort")]
    public int? NodePort { get; set; }

    /// <summary>The loadbalancer is requested with the IP address specified in this field. This feature depends on whether the underlying cloud provider supports specifying the `loadBalancerIP` when a load balancer is created. This field is ignored if the cloud provider does not support the feature.This field can be used only with `loadbalancer` type listener.</summary>
    [JsonPropertyName("loadBalancerIP")]
    public string? LoadBalancerIP { get; set; }

    /// <summary>Annotations that will be added to the `Ingress` or `Service` resource. You can use this field to configure DNS providers such as External DNS. This field can be used only with `loadbalancer`, `nodeport`, or `ingress` type listeners.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels that will be added to the `Ingress`, `Route`, or `Service` resource. This field can be used only with `loadbalancer`, `nodeport`, `route`, or `ingress` type listeners.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>External IPs associated to the nodeport service. These IPs are used by clients external to the Kubernetes cluster to access the Kafka brokers. This field is helpful when `nodeport` without `externalIP` is not sufficient. For example on bare-metal Kubernetes clusters that do not support Loadbalancer service types. This field can only be used with `nodeport` type listener.</summary>
    [JsonPropertyName("externalIPs")]
    public IList<string>? ExternalIPs { get; set; }
}

/// <summary>
/// Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`:
/// 
/// * `SingleStack` is for a single IP family.
/// * `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters.
/// * `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters.
/// 
/// If unspecified, Kubernetes will choose the default value based on the service type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaListenersConfigurationIpFamilyPolicyEnum>))]
public enum V1KafkaSpecKafkaListenersConfigurationIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaListenersConfigurationIpFamiliesEnum>))]
public enum V1KafkaSpecKafkaListenersConfigurationIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>
/// Defines which address type should be used as the node address. Available types are: `ExternalDNS`, `ExternalIP`, `InternalDNS`, `InternalIP` and `Hostname`. By default, the addresses are used in the following order (the first one found is used):
/// 
/// * `ExternalDNS`
/// * `ExternalIP`
/// * `InternalDNS`
/// * `InternalIP`
/// * `Hostname`
/// 
/// This property is used to select the preferred address type, which is checked first. If no address is found for this address type, the other types are checked in the default order. For `nodeport` listeners only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaListenersConfigurationPreferredNodePortAddressTypeEnum>))]
public enum V1KafkaSpecKafkaListenersConfigurationPreferredNodePortAddressTypeEnum
{
    [EnumMember(Value = "ExternalIP"), JsonStringEnumMemberName("ExternalIP")]
    ExternalIP,
    [EnumMember(Value = "ExternalDNS"), JsonStringEnumMemberName("ExternalDNS")]
    ExternalDNS,
    [EnumMember(Value = "InternalIP"), JsonStringEnumMemberName("InternalIP")]
    InternalIP,
    [EnumMember(Value = "InternalDNS"), JsonStringEnumMemberName("InternalDNS")]
    InternalDNS,
    [EnumMember(Value = "Hostname"), JsonStringEnumMemberName("Hostname")]
    Hostname
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersConfigurationParentRefs
{
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("sectionName")]
    public string? SectionName { get; set; }
}

/// <summary>Additional listener configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersConfiguration
{
    /// <summary>Reference to the `Secret` which holds the certificate and private key pair which will be used for this listener. The certificate can optionally contain the whole chain. This field can be used only with listeners with enabled TLS encryption.</summary>
    [JsonPropertyName("brokerCertChainAndKey")]
    public V1KafkaSpecKafkaListenersConfigurationBrokerCertChainAndKey? BrokerCertChainAndKey { get; set; }

    /// <summary>
    /// Configures a specific class for `Ingress` and `LoadBalancer` that defines which controller is used. If not specified, the default controller is used.
    /// 
    /// * For an `ingress` listener, the operator uses this property to set the `ingressClassName` property in the `Ingress` resources.
    /// * For a `loadbalancer` listener, the operator uses this property to set the `loadBalancerClass` property  in the `Service` resources.
    /// 
    /// For `ingress` and `loadbalancer` listeners only.
    /// </summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary>
    /// Specifies whether the service routes external traffic to cluster-wide or node-local endpoints:
    /// 
    /// * `Cluster` may cause a second hop to another node and obscures the client source IP.
    /// * `Local` avoids a second hop for `LoadBalancer` and `Nodeport` type services and preserves the client source IP (when supported by the infrastructure).
    /// 
    /// If unspecified, Kubernetes uses `Cluster` as the default. For `loadbalancer` or `nodeport` listeners only.
    /// </summary>
    [JsonPropertyName("externalTrafficPolicy")]
    public V1KafkaSpecKafkaListenersConfigurationExternalTrafficPolicyEnum? ExternalTrafficPolicy { get; set; }

    /// <summary>A list of CIDR ranges (for example `10.0.0.0/8` or `130.211.204.1/32`) from which clients can connect to loadbalancer listeners. If supported by the platform, traffic through the loadbalancer is restricted to the specified CIDR ranges. This field is applicable only for loadbalancer type services and is ignored if the cloud provider does not support the feature. For `loadbalancer` listeners only.</summary>
    [JsonPropertyName("loadBalancerSourceRanges")]
    public IList<string>? LoadBalancerSourceRanges { get; set; }

    /// <summary>Bootstrap configuration.</summary>
    [JsonPropertyName("bootstrap")]
    public V1KafkaSpecKafkaListenersConfigurationBootstrap? Bootstrap { get; set; }

    /// <summary>Per-broker configurations.</summary>
    [JsonPropertyName("brokers")]
    public IList<V1KafkaSpecKafkaListenersConfigurationBrokers>? Brokers { get; set; }

    /// <summary>
    /// Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`:
    /// 
    /// * `SingleStack` is for a single IP family.
    /// * `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters.
    /// * `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters.
    /// 
    /// If unspecified, Kubernetes will choose the default value based on the service type.
    /// </summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaSpecKafkaListenersConfigurationIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaSpecKafkaListenersConfigurationIpFamiliesEnum>? IpFamilies { get; set; }

    /// <summary>Whether to create the bootstrap service or not. The bootstrap service is created by default (if not specified differently). This field can be used with the `loadbalancer` listener.</summary>
    [JsonPropertyName("createBootstrapService")]
    public bool? CreateBootstrapService { get; set; }

    /// <summary>A list of finalizers configured for the `LoadBalancer` type services created for this listener. If supported by the platform, the finalizer `service.kubernetes.io/load-balancer-cleanup` to make sure that the external load balancer is deleted together with the service.For more information, see https://kubernetes.io/docs/tasks/access-application-cluster/create-external-load-balancer/#garbage-collecting-load-balancers. For `loadbalancer` listeners only.</summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary>
    /// Configures whether the Kubernetes service DNS domain should be included in the generated addresses.
    /// 
    /// * If set to `false`, the generated addresses do not contain the service DNS domain suffix. For example, `my-cluster-kafka-0.my-cluster-kafka-brokers.myproject.svc`.
    /// * If set to `true`, the generated addresses contain the service DNS domain suffix. For example, `my-cluster-kafka-0.my-cluster-kafka-brokers.myproject.svc.cluster.local`.
    /// 
    /// The default is `.cluster.local`, but this is customizable using the environment variable `KUBERNETES_SERVICE_DNS_DOMAIN`. For `internal` and `cluster-ip` listeners only.
    /// </summary>
    [JsonPropertyName("useServiceDnsDomain")]
    public bool? UseServiceDnsDomain { get; set; }

    /// <summary>The maximum number of connections we allow for this listener in the broker at any time. New connections are blocked if the limit is reached.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>The maximum connection creation rate we allow in this listener at any time. New connections will be throttled if the limit is reached.</summary>
    [JsonPropertyName("maxConnectionCreationRate")]
    public int? MaxConnectionCreationRate { get; set; }

    /// <summary>
    /// Defines which address type should be used as the node address. Available types are: `ExternalDNS`, `ExternalIP`, `InternalDNS`, `InternalIP` and `Hostname`. By default, the addresses are used in the following order (the first one found is used):
    /// 
    /// * `ExternalDNS`
    /// * `ExternalIP`
    /// * `InternalDNS`
    /// * `InternalIP`
    /// * `Hostname`
    /// 
    /// This property is used to select the preferred address type, which is checked first. If no address is found for this address type, the other types are checked in the default order. For `nodeport` listeners only.
    /// </summary>
    [JsonPropertyName("preferredNodePortAddressType")]
    public V1KafkaSpecKafkaListenersConfigurationPreferredNodePortAddressTypeEnum? PreferredNodePortAddressType { get; set; }

    /// <summary>Configures whether the service endpoints are considered &quot;ready&quot; even if the Pods themselves are not. Defaults to `false`. This field can not be used with `internal` listeners.</summary>
    [JsonPropertyName("publishNotReadyAddresses")]
    public bool? PublishNotReadyAddresses { get; set; }

    /// <summary>Configures the template used to generate annotations for individual brokers. You can use the `{nodeId}` and `{nodePodName}` placeholders in annotation values. Templating applies only to annotation values.</summary>
    [JsonPropertyName("perBrokerAnnotationsTemplate")]
    public IDictionary<string, string>? PerBrokerAnnotationsTemplate { get; set; }

    /// <summary>Configures the template used to generate labels for individual brokers. You can use the `{nodeId}` and `{nodePodName}` placeholders in label values. Templating applies only to label values.</summary>
    [JsonPropertyName("perBrokerLabelsTemplate")]
    public IDictionary<string, string>? PerBrokerLabelsTemplate { get; set; }

    /// <summary>Configures the template for generating the hostnames of the individual brokers. Valid placeholders that you can use in the template are `{nodeId}` and `{nodePodName}`.</summary>
    [JsonPropertyName("hostTemplate")]
    public string? HostTemplate { get; set; }

    /// <summary>Configures the template for generating the advertised hostnames of the individual brokers. Valid placeholders that you can use in the template are `{nodeId}` and `{nodePodName}`.</summary>
    [JsonPropertyName("advertisedHostTemplate")]
    public string? AdvertisedHostTemplate { get; set; }

    /// <summary>Configures the template for generating the advertised ports of the individual brokers. It allows to specify a simple mathematics formula that will be used to calculate the port. The only valid placeholder that you can use in the template is `{nodeId}`. Supported operations are `+`, `-`, and `*`. For example, `9000 + {nodeId}` will generate ports `9000`, `9001`, `9002`, and so on for the individual brokers. You can also use a fixed port number in the template, for example `9000`, which will generate the same port for all brokers.</summary>
    [JsonPropertyName("advertisedPortTemplate")]
    public string? AdvertisedPortTemplate { get; set; }

    /// <summary>
    /// Configures whether to allocate NodePort automatically for the `Service` with type `LoadBalancer`.
    /// This is a one to one with the `spec.allocateLoadBalancerNodePorts` configuration in the `Service` type
    /// For `loadbalancer` listeners only.
    /// </summary>
    [JsonPropertyName("allocateLoadBalancerNodePorts")]
    public bool? AllocateLoadBalancerNodePorts { get; set; }

    /// <summary>
    /// For `tlsroute` listeners only.
    /// Configures the Gateway API resource or resources that generated `TLSRoute` resources attach to.
    /// Typically, this is a `Gateway` resource.
    /// </summary>
    [JsonPropertyName("parentRefs")]
    public IList<V1KafkaSpecKafkaListenersConfigurationParentRefs>? ParentRefs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersNetworkPolicyPeersIpBlock
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("except")]
    public IList<string>? Except { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersNetworkPolicyPeersNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersNetworkPolicyPeersNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaListenersNetworkPolicyPeersNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersNetworkPolicyPeersPodSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersNetworkPolicyPeersPodSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaListenersNetworkPolicyPeersPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListenersNetworkPolicyPeers
{
    [JsonPropertyName("ipBlock")]
    public V1KafkaSpecKafkaListenersNetworkPolicyPeersIpBlock? IpBlock { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaListenersNetworkPolicyPeersNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("podSelector")]
    public V1KafkaSpecKafkaListenersNetworkPolicyPeersPodSelector? PodSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaListeners
{
    /// <summary>Name of the listener. The name will be used to identify the listener and the related Kubernetes objects. The name has to be unique within given a Kafka cluster. The name can consist of lowercase characters and numbers and be up to 11 characters long.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Port number used by the listener inside Kafka. The port number has to be unique within a given Kafka cluster. Allowed port numbers are 9092 and higher with the exception of ports 9404 and 9999, which are already used for Prometheus and JMX. Depending on the listener type, the port number might not be the same as the port number that connects Kafka clients.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>
    /// Type of the listener. The supported types are as follows: 
    /// 
    /// * `internal` type exposes Kafka internally only within the Kubernetes cluster.
    /// * `route` type uses OpenShift Routes to expose Kafka.
    /// * `loadbalancer` type uses LoadBalancer type services to expose Kafka.
    /// * `nodeport` type uses NodePort type services to expose Kafka.
    /// * `ingress` (deprecated) type uses Kubernetes Nginx Ingress to expose Kafka with TLS passthrough.
    /// * `cluster-ip` type uses a per-broker `ClusterIP` service.
    /// 
    /// </summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaListenersTypeEnum Type { get; set; }

    /// <summary>Enables TLS encryption on the listener. This is a required property. For `route` and `ingress` type listeners, TLS encryption must be always enabled.</summary>
    [JsonPropertyName("tls")]
    public required bool Tls { get; set; }

    /// <summary>Authentication configuration for this listener.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaSpecKafkaListenersAuthentication? Authentication { get; set; }

    /// <summary>Additional listener configuration.</summary>
    [JsonPropertyName("configuration")]
    public V1KafkaSpecKafkaListenersConfiguration? Configuration { get; set; }

    /// <summary>List of peers which should be able to connect to this listener. Peers in this list are combined using a logical OR operation. If this field is empty or missing, all connections will be allowed for this listener. If this field is present and contains at least one item, the listener only allows the traffic which matches at least one item in this list.</summary>
    [JsonPropertyName("networkPolicyPeers")]
    public IList<V1KafkaSpecKafkaListenersNetworkPolicyPeers>? NetworkPolicyPeers { get; set; }
}

/// <summary>Authorization type. Currently, the supported types are `simple` and `custom`. `simple` authorization type uses Kafka&apos;s built-in authorizer for authorization. `custom` authorization type uses user-provided implementation for authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaAuthorizationTypeEnum>))]
public enum V1KafkaSpecKafkaAuthorizationTypeEnum
{
    [EnumMember(Value = "simple"), JsonStringEnumMemberName("simple")]
    Simple,
    [EnumMember(Value = "custom"), JsonStringEnumMemberName("custom")]
    Custom
}

/// <summary>Authorization configuration for Kafka brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaAuthorization
{
    /// <summary>Authorization implementation class, which must be available in classpath.</summary>
    [JsonPropertyName("authorizerClass")]
    public string? AuthorizerClass { get; set; }

    /// <summary>List of super users, which are user principals with unlimited access rights.</summary>
    [JsonPropertyName("superUsers")]
    public IList<string>? SuperUsers { get; set; }

    /// <summary>Indicates whether the custom authorizer supports the APIs for managing ACLs using the Kafka Admin API. Defaults to `false`.</summary>
    [JsonPropertyName("supportsAdminApi")]
    public bool? SupportsAdminApi { get; set; }

    /// <summary>Authorization type. Currently, the supported types are `simple` and `custom`. `simple` authorization type uses Kafka&apos;s built-in authorizer for authorization. `custom` authorization type uses user-provided implementation for authorization.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaAuthorizationTypeEnum Type { get; set; }
}

/// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaRackTypeEnum>))]
public enum V1KafkaSpecKafkaRackTypeEnum
{
    [EnumMember(Value = "topology-label"), JsonStringEnumMemberName("topology-label")]
    TopologyLabel,
    [EnumMember(Value = "environment-variable"), JsonStringEnumMemberName("environment-variable")]
    EnvironmentVariable
}

/// <summary>Configuration of the `broker.rack` broker config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaRack
{
    /// <summary>The name of the environment variable that defines the rack ID. Its value sets the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("envVarName")]
    public string? EnvVarName { get; set; }

    /// <summary>A key that matches labels assigned to the Kubernetes cluster nodes. The value of the label is used to set a broker&apos;s `broker.rack` config, and the `client.rack` config for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    /// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
    [JsonPropertyName("type")]
    public V1KafkaSpecKafkaRackTypeEnum? Type { get; set; }
}

/// <summary>Pod liveness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaLivenessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Pod readiness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaReadinessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaJvmOptionsJavaSystemProperties
{
    /// <summary>The system property name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The system property value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>JVM Options for pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaJvmOptions
{
    /// <summary>A map of -XX options to the JVM.</summary>
    [JsonPropertyName("-XX")]
    public IDictionary<string, string>? XX { get; set; }

    /// <summary>-Xmx option to to the JVM.</summary>
    [JsonPropertyName("-Xmx")]
    public string? Xmx { get; set; }

    /// <summary>-Xms option to to the JVM.</summary>
    [JsonPropertyName("-Xms")]
    public string? Xms { get; set; }

    /// <summary>Specifies whether the Garbage Collection logging is enabled. The default is false.</summary>
    [JsonPropertyName("gcLoggingEnabled")]
    public bool? GcLoggingEnabled { get; set; }

    /// <summary>A map of additional system properties which will be passed using the `-D` option to the JVM.</summary>
    [JsonPropertyName("javaSystemProperties")]
    public IList<V1KafkaSpecKafkaJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Authentication type. Currently the only supported types are `password`.`password` type creates a username and protected port with no TLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaJmxOptionsAuthenticationTypeEnum>))]
public enum V1KafkaSpecKafkaJmxOptionsAuthenticationTypeEnum
{
    [EnumMember(Value = "password"), JsonStringEnumMemberName("password")]
    Password
}

/// <summary>Authentication configuration for connecting to the JMX port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaJmxOptionsAuthentication
{
    /// <summary>Authentication type. Currently the only supported types are `password`.`password` type creates a username and protected port with no TLS.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaJmxOptionsAuthenticationTypeEnum Type { get; set; }
}

/// <summary>JMX Options for Kafka brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaJmxOptions
{
    /// <summary>Authentication configuration for connecting to the JMX port.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaSpecKafkaJmxOptionsAuthentication? Authentication { get; set; }
}

/// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaMetricsConfigTypeEnum>))]
public enum V1KafkaSpecKafkaMetricsConfigTypeEnum
{
    [EnumMember(Value = "jmxPrometheusExporter"), JsonStringEnumMemberName("jmxPrometheusExporter")]
    JmxPrometheusExporter,
    [EnumMember(Value = "strimziMetricsReporter"), JsonStringEnumMemberName("strimziMetricsReporter")]
    StrimziMetricsReporter
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaMetricsConfigValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaMetricsConfigValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecKafkaMetricsConfigValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaMetricsConfigValues
{
    /// <summary>A list of regex patterns to filter the metrics to collect. Should contain at least one element.</summary>
    [JsonPropertyName("allowList")]
    public IList<string>? AllowList { get; set; }
}

/// <summary>Metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaMetricsConfig
{
    /// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaMetricsConfigTypeEnum Type { get; set; }

    /// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecKafkaMetricsConfigValueFrom? ValueFrom { get; set; }

    /// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
    [JsonPropertyName("values")]
    public V1KafkaSpecKafkaMetricsConfigValues? Values { get; set; }
}

/// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaLoggingTypeEnum>))]
public enum V1KafkaSpecKafkaLoggingTypeEnum
{
    [EnumMember(Value = "inline"), JsonStringEnumMemberName("inline")]
    Inline,
    [EnumMember(Value = "external"), JsonStringEnumMemberName("external")]
    External
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaLoggingValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaLoggingValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecKafkaLoggingValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Logging configuration for Kafka.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaLogging
{
    /// <summary>A Map from logger name to logger level.</summary>
    [JsonPropertyName("loggers")]
    public IDictionary<string, string>? Loggers { get; set; }

    /// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaLoggingTypeEnum Type { get; set; }

    /// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecKafkaLoggingValueFrom? ValueFrom { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Configures pod-level security attributes and common container settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecKafkaTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public int? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecKafkaTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecKafkaTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaSpecKafkaTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecKafkaTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaSpecKafkaTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaSpecKafkaTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaSpecKafkaTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public int? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public int? MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public string? WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaTemplatePodDnsPolicyEnum>))]
public enum V1KafkaSpecKafkaTemplatePodDnsPolicyEnum
{
    [EnumMember(Value = "ClusterFirst"), JsonStringEnumMemberName("ClusterFirst")]
    ClusterFirst,
    [EnumMember(Value = "ClusterFirstWithHostNet"), JsonStringEnumMemberName("ClusterFirstWithHostNet")]
    ClusterFirstWithHostNet,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaSpecKafkaTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecKafkaTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecKafkaTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaSpecKafkaTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaSpecKafkaTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaSpecKafkaTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaSpecKafkaTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaSpecKafkaTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaSpecKafkaTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaSpecKafkaTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaSpecKafkaTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaSpecKafkaTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for Kafka `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaSpecKafkaTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecKafkaTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaSpecKafkaTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaSpecKafkaTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaSpecKafkaTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaSpecKafkaTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaSpecKafkaTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaSpecKafkaTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaSpecKafkaTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateBootstrapServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaTemplateBootstrapServiceIpFamilyPolicyEnum>))]
public enum V1KafkaSpecKafkaTemplateBootstrapServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaTemplateBootstrapServiceIpFamiliesEnum>))]
public enum V1KafkaSpecKafkaTemplateBootstrapServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for Kafka bootstrap `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateBootstrapService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateBootstrapServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaSpecKafkaTemplateBootstrapServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaSpecKafkaTemplateBootstrapServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateBrokersServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaTemplateBrokersServiceIpFamilyPolicyEnum>))]
public enum V1KafkaSpecKafkaTemplateBrokersServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaTemplateBrokersServiceIpFamiliesEnum>))]
public enum V1KafkaSpecKafkaTemplateBrokersServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for Kafka broker `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateBrokersService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateBrokersServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaSpecKafkaTemplateBrokersServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaSpecKafkaTemplateBrokersServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateExternalBootstrapServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka external bootstrap `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateExternalBootstrapService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateExternalBootstrapServiceMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePerPodServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka per-pod `Services` used for access from outside of Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePerPodService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplatePerPodServiceMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateExternalBootstrapRouteMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka external bootstrap `Route`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateExternalBootstrapRoute
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateExternalBootstrapRouteMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePerPodRouteMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka per-pod `Routes` used for access from outside of OpenShift.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePerPodRoute
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplatePerPodRouteMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateExternalBootstrapIngressMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka external bootstrap `Ingress`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateExternalBootstrapIngress
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateExternalBootstrapIngressMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePerPodIngressMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka per-pod `Ingress` used for access from outside of Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePerPodIngress
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplatePerPodIngressMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePersistentVolumeClaimMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for all Kafka `PersistentVolumeClaims`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePersistentVolumeClaim
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplatePersistentVolumeClaimMetadata? Metadata { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodDisruptionBudgetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka `PodDisruptionBudget`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodDisruptionBudget
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplatePodDisruptionBudgetMetadata? Metadata { get; set; }

    /// <summary>Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaSpecKafkaTemplateKafkaContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecKafkaTemplateKafkaContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecKafkaTemplateKafkaContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecKafkaTemplateKafkaContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka broker container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateKafkaContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaSpecKafkaTemplateKafkaContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecKafkaTemplateKafkaContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaSpecKafkaTemplateKafkaContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaSpecKafkaTemplateInitContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecKafkaTemplateInitContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecKafkaTemplateInitContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecKafkaTemplateInitContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaSpecKafkaTemplateInitContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecKafkaTemplateInitContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecKafkaTemplateInitContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecKafkaTemplateInitContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateInitContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaSpecKafkaTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecKafkaTemplateInitContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaSpecKafkaTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateClusterCaCertMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Secret with Kafka Cluster certificate public key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateClusterCaCert
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateClusterCaCertMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateJmxSecretMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Secret of the Kafka Cluster JMX authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateJmxSecret
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateJmxSecretMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateClusterRoleBindingMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka ClusterRoleBinding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplateClusterRoleBinding
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplateClusterRoleBindingMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka `StrimziPodSet` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplatePodSet
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaTemplatePodSetMetadata? Metadata { get; set; }
}

/// <summary>Template for Kafka cluster resources. The template allows users to specify how the Kubernetes resources are generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTemplate
{
    /// <summary>Template for Kafka `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaSpecKafkaTemplatePod? Pod { get; set; }

    /// <summary>Template for Kafka bootstrap `Service`.</summary>
    [JsonPropertyName("bootstrapService")]
    public V1KafkaSpecKafkaTemplateBootstrapService? BootstrapService { get; set; }

    /// <summary>Template for Kafka broker `Service`.</summary>
    [JsonPropertyName("brokersService")]
    public V1KafkaSpecKafkaTemplateBrokersService? BrokersService { get; set; }

    /// <summary>Template for Kafka external bootstrap `Service`.</summary>
    [JsonPropertyName("externalBootstrapService")]
    public V1KafkaSpecKafkaTemplateExternalBootstrapService? ExternalBootstrapService { get; set; }

    /// <summary>Template for Kafka per-pod `Services` used for access from outside of Kubernetes.</summary>
    [JsonPropertyName("perPodService")]
    public V1KafkaSpecKafkaTemplatePerPodService? PerPodService { get; set; }

    /// <summary>Template for Kafka external bootstrap `Route`.</summary>
    [JsonPropertyName("externalBootstrapRoute")]
    public V1KafkaSpecKafkaTemplateExternalBootstrapRoute? ExternalBootstrapRoute { get; set; }

    /// <summary>Template for Kafka per-pod `Routes` used for access from outside of OpenShift.</summary>
    [JsonPropertyName("perPodRoute")]
    public V1KafkaSpecKafkaTemplatePerPodRoute? PerPodRoute { get; set; }

    /// <summary>Template for Kafka external bootstrap `Ingress`.</summary>
    [JsonPropertyName("externalBootstrapIngress")]
    public V1KafkaSpecKafkaTemplateExternalBootstrapIngress? ExternalBootstrapIngress { get; set; }

    /// <summary>Template for Kafka per-pod `Ingress` used for access from outside of Kubernetes.</summary>
    [JsonPropertyName("perPodIngress")]
    public V1KafkaSpecKafkaTemplatePerPodIngress? PerPodIngress { get; set; }

    /// <summary>Template for all Kafka `PersistentVolumeClaims`.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaSpecKafkaTemplatePersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>Template for Kafka `PodDisruptionBudget`.</summary>
    [JsonPropertyName("podDisruptionBudget")]
    public V1KafkaSpecKafkaTemplatePodDisruptionBudget? PodDisruptionBudget { get; set; }

    /// <summary>Template for the Kafka broker container.</summary>
    [JsonPropertyName("kafkaContainer")]
    public V1KafkaSpecKafkaTemplateKafkaContainer? KafkaContainer { get; set; }

    /// <summary>Template for the Kafka init container.</summary>
    [JsonPropertyName("initContainer")]
    public V1KafkaSpecKafkaTemplateInitContainer? InitContainer { get; set; }

    /// <summary>Template for Secret with Kafka Cluster certificate public key.</summary>
    [JsonPropertyName("clusterCaCert")]
    public V1KafkaSpecKafkaTemplateClusterCaCert? ClusterCaCert { get; set; }

    /// <summary>Template for the Kafka service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KafkaSpecKafkaTemplateServiceAccount? ServiceAccount { get; set; }

    /// <summary>Template for Secret of the Kafka Cluster JMX authentication.</summary>
    [JsonPropertyName("jmxSecret")]
    public V1KafkaSpecKafkaTemplateJmxSecret? JmxSecret { get; set; }

    /// <summary>Template for the Kafka ClusterRoleBinding.</summary>
    [JsonPropertyName("clusterRoleBinding")]
    public V1KafkaSpecKafkaTemplateClusterRoleBinding? ClusterRoleBinding { get; set; }

    /// <summary>Template for Kafka `StrimziPodSet` resource.</summary>
    [JsonPropertyName("podSet")]
    public V1KafkaSpecKafkaTemplatePodSet? PodSet { get; set; }
}

/// <summary>Configuration for the Remote Storage Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTieredStorageRemoteStorageManager
{
    /// <summary>The class name for the `RemoteStorageManager` implementation.</summary>
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }

    /// <summary>The class path for the `RemoteStorageManager` implementation.</summary>
    [JsonPropertyName("classPath")]
    public string? ClassPath { get; set; }

    /// <summary>The additional configuration map for the `RemoteStorageManager` implementation. Keys will be automatically prefixed with `rsm.config.`, and added to Kafka broker configuration.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }
}

/// <summary>Storage type, only &apos;custom&apos; is supported at the moment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaTieredStorageTypeEnum>))]
public enum V1KafkaSpecKafkaTieredStorageTypeEnum
{
    [EnumMember(Value = "custom"), JsonStringEnumMemberName("custom")]
    Custom
}

/// <summary>Configure the tiered storage feature for Kafka brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaTieredStorage
{
    /// <summary>Configuration for the Remote Storage Manager.</summary>
    [JsonPropertyName("remoteStorageManager")]
    public V1KafkaSpecKafkaTieredStorageRemoteStorageManager? RemoteStorageManager { get; set; }

    /// <summary>Storage type, only &apos;custom&apos; is supported at the moment.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaTieredStorageTypeEnum Type { get; set; }
}

/// <summary>Quotas plugin type. Currently, the supported types are `kafka` and `strimzi`. `kafka` quotas type uses Kafka&apos;s built-in quotas plugin. `strimzi` quotas type uses Strimzi quotas plugin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaQuotasTypeEnum>))]
public enum V1KafkaSpecKafkaQuotasTypeEnum
{
    [EnumMember(Value = "kafka"), JsonStringEnumMemberName("kafka")]
    Kafka,
    [EnumMember(Value = "strimzi"), JsonStringEnumMemberName("strimzi")]
    Strimzi
}

/// <summary>Quotas plugin configuration for Kafka brokers allows setting quotas for disk usage, produce/fetch rates, and more. Supported plugin types include `kafka` (default) and `strimzi`. If not specified, the default `kafka` quotas plugin is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaQuotas
{
    /// <summary>A per-broker byte-rate quota for clients consuming from a broker, independent of their number. If clients consume at maximum speed, the quota is shared equally between all non-excluded consumers. Otherwise, the quota is divided based on each client&apos;s consumption rate.</summary>
    [JsonPropertyName("consumerByteRate")]
    public int? ConsumerByteRate { get; set; }

    /// <summary>The default client quota on the rate at which mutations are accepted per second for create topic requests, create partition requests, and delete topic requests, defined for each broker. The mutations rate is measured by the number of partitions created or deleted. Applied on a per-broker basis.</summary>
    [JsonPropertyName("controllerMutationRate")]
    public double? ControllerMutationRate { get; set; }

    /// <summary>List of principals that are excluded from the quota. The principals have to be prefixed with `User:`, for example `User:my-user;User:CN=my-other-user`.</summary>
    [JsonPropertyName("excludedPrincipals")]
    public IList<string>? ExcludedPrincipals { get; set; }

    /// <summary>Stop message production if the available size (in bytes) of the storage is lower than or equal to this specified value. This condition is mutually exclusive with `minAvailableRatioPerVolume`.</summary>
    [JsonPropertyName("minAvailableBytesPerVolume")]
    public int? MinAvailableBytesPerVolume { get; set; }

    /// <summary>Stop message production if the percentage of available storage space falls below or equals the specified ratio (set as a decimal representing a percentage). This condition is mutually exclusive with `minAvailableBytesPerVolume`.</summary>
    [JsonPropertyName("minAvailableRatioPerVolume")]
    public double? MinAvailableRatioPerVolume { get; set; }

    /// <summary>A per-broker byte-rate quota for clients producing to a broker, independent of their number. If clients produce at maximum speed, the quota is shared equally between all non-excluded producers. Otherwise, the quota is divided based on each client&apos;s production rate.</summary>
    [JsonPropertyName("producerByteRate")]
    public int? ProducerByteRate { get; set; }

    /// <summary>The default client quota limits the maximum CPU utilization of each client as a percentage of the network and I/O threads of each broker. Applied on a per-broker basis.</summary>
    [JsonPropertyName("requestPercentage")]
    public int? RequestPercentage { get; set; }

    /// <summary>Quotas plugin type. Currently, the supported types are `kafka` and `strimzi`. `kafka` quotas type uses Kafka&apos;s built-in quotas plugin. `strimzi` quotas type uses Strimzi quotas plugin.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecKafkaQuotasTypeEnum Type { get; set; }
}

/// <summary>Configuration of the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafka
{
    /// <summary>The Kafka broker version. Defaults to the latest version. Consult the user documentation to understand the process required to upgrade or downgrade the version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The KRaft metadata version used by the Kafka cluster. This property is ignored when running in ZooKeeper mode. If the property is not set, it defaults to the metadata version that corresponds to the `version` property.</summary>
    [JsonPropertyName("metadataVersion")]
    public string? MetadataVersion { get; set; }

    /// <summary>The container image used for Kafka pods. If the property is not set, the default Kafka image version is determined based on the `version` configuration. The image names are specifically mapped to corresponding versions in the Cluster Operator configuration. Changing the Kafka image version does not automatically update the image versions for other components, such as Kafka Exporter. </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Configures listeners to provide access to Kafka brokers.</summary>
    [JsonPropertyName("listeners")]
    public required IList<V1KafkaSpecKafkaListeners> Listeners { get; set; }

    /// <summary>Kafka broker config properties with certain prefixes cannot be set unless it is in the exception list. Consult the documentation for the list of forbidden prefixes and exceptions.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Authorization configuration for Kafka brokers.</summary>
    [JsonPropertyName("authorization")]
    public V1KafkaSpecKafkaAuthorization? Authorization { get; set; }

    /// <summary>Configuration of the `broker.rack` broker config.</summary>
    [JsonPropertyName("rack")]
    public V1KafkaSpecKafkaRack? Rack { get; set; }

    /// <summary>The image of the init container used for initializing the `broker.rack`.</summary>
    [JsonPropertyName("brokerRackInitImage")]
    public string? BrokerRackInitImage { get; set; }

    /// <summary>Pod liveness checking.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaSpecKafkaLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness checking.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaSpecKafkaReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>JVM Options for pods.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaSpecKafkaJvmOptions? JvmOptions { get; set; }

    /// <summary>JMX Options for Kafka brokers.</summary>
    [JsonPropertyName("jmxOptions")]
    public V1KafkaSpecKafkaJmxOptions? JmxOptions { get; set; }

    /// <summary>Metrics configuration.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1KafkaSpecKafkaMetricsConfig? MetricsConfig { get; set; }

    /// <summary>Logging configuration for Kafka.</summary>
    [JsonPropertyName("logging")]
    public V1KafkaSpecKafkaLogging? Logging { get; set; }

    /// <summary>Template for Kafka cluster resources. The template allows users to specify how the Kubernetes resources are generated.</summary>
    [JsonPropertyName("template")]
    public V1KafkaSpecKafkaTemplate? Template { get; set; }

    /// <summary>Configure the tiered storage feature for Kafka brokers.</summary>
    [JsonPropertyName("tieredStorage")]
    public V1KafkaSpecKafkaTieredStorage? TieredStorage { get; set; }

    /// <summary>Quotas plugin configuration for Kafka brokers allows setting quotas for disk usage, produce/fetch rates, and more. Supported plugin types include `kafka` (default) and `strimzi`. If not specified, the default `kafka` quotas plugin is used.</summary>
    [JsonPropertyName("quotas")]
    public V1KafkaSpecKafkaQuotas? Quotas { get; set; }
}

/// <summary>Pod startup checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorStartupProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Pod liveness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorLivenessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Pod readiness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorReadinessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>CPU and memory resources to reserve.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaSpecEntityOperatorTopicOperatorResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecEntityOperatorTopicOperatorLoggingTypeEnum>))]
public enum V1KafkaSpecEntityOperatorTopicOperatorLoggingTypeEnum
{
    [EnumMember(Value = "inline"), JsonStringEnumMemberName("inline")]
    Inline,
    [EnumMember(Value = "external"), JsonStringEnumMemberName("external")]
    External
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorLoggingValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorLoggingValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecEntityOperatorTopicOperatorLoggingValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Logging configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorLogging
{
    /// <summary>A Map from logger name to logger level.</summary>
    [JsonPropertyName("loggers")]
    public IDictionary<string, string>? Loggers { get; set; }

    /// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecEntityOperatorTopicOperatorLoggingTypeEnum Type { get; set; }

    /// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecEntityOperatorTopicOperatorLoggingValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorJvmOptionsJavaSystemProperties
{
    /// <summary>The system property name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The system property value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>JVM Options for pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperatorJvmOptions
{
    /// <summary>A map of -XX options to the JVM.</summary>
    [JsonPropertyName("-XX")]
    public IDictionary<string, string>? XX { get; set; }

    /// <summary>-Xmx option to to the JVM.</summary>
    [JsonPropertyName("-Xmx")]
    public string? Xmx { get; set; }

    /// <summary>-Xms option to to the JVM.</summary>
    [JsonPropertyName("-Xms")]
    public string? Xms { get; set; }

    /// <summary>Specifies whether the Garbage Collection logging is enabled. The default is false.</summary>
    [JsonPropertyName("gcLoggingEnabled")]
    public bool? GcLoggingEnabled { get; set; }

    /// <summary>A map of additional system properties which will be passed using the `-D` option to the JVM.</summary>
    [JsonPropertyName("javaSystemProperties")]
    public IList<V1KafkaSpecEntityOperatorTopicOperatorJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Configuration of the Topic Operator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTopicOperator
{
    /// <summary>The namespace the Topic Operator should watch.</summary>
    [JsonPropertyName("watchedNamespace")]
    public string? WatchedNamespace { get; set; }

    /// <summary>The image to use for the Topic Operator.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Interval between periodic reconciliations in milliseconds.</summary>
    [JsonPropertyName("reconciliationIntervalMs")]
    public int? ReconciliationIntervalMs { get; set; }

    /// <summary>Pod startup checking.</summary>
    [JsonPropertyName("startupProbe")]
    public V1KafkaSpecEntityOperatorTopicOperatorStartupProbe? StartupProbe { get; set; }

    /// <summary>Pod liveness checking.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaSpecEntityOperatorTopicOperatorLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness checking.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaSpecEntityOperatorTopicOperatorReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>CPU and memory resources to reserve.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaSpecEntityOperatorTopicOperatorResources? Resources { get; set; }

    /// <summary>Logging configuration.</summary>
    [JsonPropertyName("logging")]
    public V1KafkaSpecEntityOperatorTopicOperatorLogging? Logging { get; set; }

    /// <summary>JVM Options for pods.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaSpecEntityOperatorTopicOperatorJvmOptions? JvmOptions { get; set; }
}

/// <summary>Pod liveness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorLivenessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Pod readiness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorReadinessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>CPU and memory resources to reserve.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaSpecEntityOperatorUserOperatorResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecEntityOperatorUserOperatorLoggingTypeEnum>))]
public enum V1KafkaSpecEntityOperatorUserOperatorLoggingTypeEnum
{
    [EnumMember(Value = "inline"), JsonStringEnumMemberName("inline")]
    Inline,
    [EnumMember(Value = "external"), JsonStringEnumMemberName("external")]
    External
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorLoggingValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorLoggingValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecEntityOperatorUserOperatorLoggingValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Logging configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorLogging
{
    /// <summary>A Map from logger name to logger level.</summary>
    [JsonPropertyName("loggers")]
    public IDictionary<string, string>? Loggers { get; set; }

    /// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecEntityOperatorUserOperatorLoggingTypeEnum Type { get; set; }

    /// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecEntityOperatorUserOperatorLoggingValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorJvmOptionsJavaSystemProperties
{
    /// <summary>The system property name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The system property value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>JVM Options for pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperatorJvmOptions
{
    /// <summary>A map of -XX options to the JVM.</summary>
    [JsonPropertyName("-XX")]
    public IDictionary<string, string>? XX { get; set; }

    /// <summary>-Xmx option to to the JVM.</summary>
    [JsonPropertyName("-Xmx")]
    public string? Xmx { get; set; }

    /// <summary>-Xms option to to the JVM.</summary>
    [JsonPropertyName("-Xms")]
    public string? Xms { get; set; }

    /// <summary>Specifies whether the Garbage Collection logging is enabled. The default is false.</summary>
    [JsonPropertyName("gcLoggingEnabled")]
    public bool? GcLoggingEnabled { get; set; }

    /// <summary>A map of additional system properties which will be passed using the `-D` option to the JVM.</summary>
    [JsonPropertyName("javaSystemProperties")]
    public IList<V1KafkaSpecEntityOperatorUserOperatorJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Configuration of the User Operator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorUserOperator
{
    /// <summary>The namespace the User Operator should watch.</summary>
    [JsonPropertyName("watchedNamespace")]
    public string? WatchedNamespace { get; set; }

    /// <summary>The image to use for the User Operator.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Interval between periodic reconciliations in milliseconds.</summary>
    [JsonPropertyName("reconciliationIntervalMs")]
    public int? ReconciliationIntervalMs { get; set; }

    /// <summary>The prefix that will be added to the KafkaUser name to be used as the Secret name.</summary>
    [JsonPropertyName("secretPrefix")]
    public string? SecretPrefix { get; set; }

    /// <summary>Pod liveness checking.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaSpecEntityOperatorUserOperatorLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness checking.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaSpecEntityOperatorUserOperatorReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>CPU and memory resources to reserve.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaSpecEntityOperatorUserOperatorResources? Resources { get; set; }

    /// <summary>Logging configuration.</summary>
    [JsonPropertyName("logging")]
    public V1KafkaSpecEntityOperatorUserOperatorLogging? Logging { get; set; }

    /// <summary>JVM Options for pods.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaSpecEntityOperatorUserOperatorJvmOptions? JvmOptions { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateDeploymentMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecEntityOperatorTemplateDeploymentDeploymentStrategyEnum>))]
public enum V1KafkaSpecEntityOperatorTemplateDeploymentDeploymentStrategyEnum
{
    [EnumMember(Value = "RollingUpdate"), JsonStringEnumMemberName("RollingUpdate")]
    RollingUpdate,
    [EnumMember(Value = "Recreate"), JsonStringEnumMemberName("Recreate")]
    Recreate
}

/// <summary>Template for Entity Operator `Deployment`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateDeployment
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecEntityOperatorTemplateDeploymentMetadata? Metadata { get; set; }

    /// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
    [JsonPropertyName("deploymentStrategy")]
    public V1KafkaSpecEntityOperatorTemplateDeploymentDeploymentStrategyEnum? DeploymentStrategy { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Configures pod-level security attributes and common container settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecEntityOperatorTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public int? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecEntityOperatorTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecEntityOperatorTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecEntityOperatorTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public int? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecEntityOperatorTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public int? MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public string? WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecEntityOperatorTemplatePodDnsPolicyEnum>))]
public enum V1KafkaSpecEntityOperatorTemplatePodDnsPolicyEnum
{
    [EnumMember(Value = "ClusterFirst"), JsonStringEnumMemberName("ClusterFirst")]
    ClusterFirst,
    [EnumMember(Value = "ClusterFirstWithHostNet"), JsonStringEnumMemberName("ClusterFirstWithHostNet")]
    ClusterFirstWithHostNet,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecEntityOperatorTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaSpecEntityOperatorTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaSpecEntityOperatorTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for Entity Operator `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecEntityOperatorTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecEntityOperatorTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaSpecEntityOperatorTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaSpecEntityOperatorTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaSpecEntityOperatorTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaSpecEntityOperatorTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Entity Topic Operator container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaSpecEntityOperatorTemplateTopicOperatorContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Entity User Operator container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaSpecEntityOperatorTemplateUserOperatorContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaSpecEntityOperatorTemplateUserOperatorContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Entity Operator service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecEntityOperatorTemplateServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodDisruptionBudgetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Entity Operator Pod Disruption Budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplatePodDisruptionBudget
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecEntityOperatorTemplatePodDisruptionBudgetMetadata? Metadata { get; set; }

    /// <summary>Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateEntityOperatorRoleMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Entity Operator Role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateEntityOperatorRole
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecEntityOperatorTemplateEntityOperatorRoleMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorRoleBindingMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Entity Topic Operator RoleBinding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateTopicOperatorRoleBinding
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorRoleBindingMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorRoleBindingMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Entity Topic Operator RoleBinding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplateUserOperatorRoleBinding
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorRoleBindingMetadata? Metadata { get; set; }
}

/// <summary>Template for Entity Operator resources. The template allows users to specify how a `Deployment` and `Pod` is generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperatorTemplate
{
    /// <summary>Template for Entity Operator `Deployment`.</summary>
    [JsonPropertyName("deployment")]
    public V1KafkaSpecEntityOperatorTemplateDeployment? Deployment { get; set; }

    /// <summary>Template for Entity Operator `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaSpecEntityOperatorTemplatePod? Pod { get; set; }

    /// <summary>Template for the Entity Topic Operator container.</summary>
    [JsonPropertyName("topicOperatorContainer")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorContainer? TopicOperatorContainer { get; set; }

    /// <summary>Template for the Entity User Operator container.</summary>
    [JsonPropertyName("userOperatorContainer")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorContainer? UserOperatorContainer { get; set; }

    /// <summary>Template for the Entity Operator service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KafkaSpecEntityOperatorTemplateServiceAccount? ServiceAccount { get; set; }

    /// <summary>Template for the Entity Operator Pod Disruption Budget.</summary>
    [JsonPropertyName("podDisruptionBudget")]
    public V1KafkaSpecEntityOperatorTemplatePodDisruptionBudget? PodDisruptionBudget { get; set; }

    /// <summary>Template for the Entity Operator Role.</summary>
    [JsonPropertyName("entityOperatorRole")]
    public V1KafkaSpecEntityOperatorTemplateEntityOperatorRole? EntityOperatorRole { get; set; }

    /// <summary>Template for the Entity Topic Operator RoleBinding.</summary>
    [JsonPropertyName("topicOperatorRoleBinding")]
    public V1KafkaSpecEntityOperatorTemplateTopicOperatorRoleBinding? TopicOperatorRoleBinding { get; set; }

    /// <summary>Template for the Entity Topic Operator RoleBinding.</summary>
    [JsonPropertyName("userOperatorRoleBinding")]
    public V1KafkaSpecEntityOperatorTemplateUserOperatorRoleBinding? UserOperatorRoleBinding { get; set; }
}

/// <summary>Configuration of the Entity Operator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecEntityOperator
{
    /// <summary>Configuration of the Topic Operator.</summary>
    [JsonPropertyName("topicOperator")]
    public V1KafkaSpecEntityOperatorTopicOperator? TopicOperator { get; set; }

    /// <summary>Configuration of the User Operator.</summary>
    [JsonPropertyName("userOperator")]
    public V1KafkaSpecEntityOperatorUserOperator? UserOperator { get; set; }

    /// <summary>Template for Entity Operator resources. The template allows users to specify how a `Deployment` and `Pod` is generated.</summary>
    [JsonPropertyName("template")]
    public V1KafkaSpecEntityOperatorTemplate? Template { get; set; }
}

/// <summary>How should CA certificate expiration be handled when `generateCertificateAuthority=true`. The default is for a new CA certificate to be generated reusing the existing private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecClusterCaCertificateExpirationPolicyEnum>))]
public enum V1KafkaSpecClusterCaCertificateExpirationPolicyEnum
{
    [EnumMember(Value = "renew-certificate"), JsonStringEnumMemberName("renew-certificate")]
    RenewCertificate,
    [EnumMember(Value = "replace-key"), JsonStringEnumMemberName("replace-key")]
    ReplaceKey
}

/// <summary>Configuration of the cluster certificate authority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecClusterCa
{
    /// <summary>If true then Certificate Authority certificates will be generated automatically. Otherwise the user will need to provide a Secret with the CA certificate. Default is true.</summary>
    [JsonPropertyName("generateCertificateAuthority")]
    public bool? GenerateCertificateAuthority { get; set; }

    /// <summary>If `true`, the Cluster and Client CA Secrets are configured with the `ownerReference` set to the `Kafka` resource. If the `Kafka` resource is deleted when `true`, the CA Secrets are also deleted. If `false`, the `ownerReference` is disabled. If the `Kafka` resource is deleted when `false`, the CA Secrets are retained and available for reuse. Default is `true`.</summary>
    [JsonPropertyName("generateSecretOwnerReference")]
    public bool? GenerateSecretOwnerReference { get; set; }

    /// <summary>The number of days generated certificates should be valid for. The default is 365.</summary>
    [JsonPropertyName("validityDays")]
    public int? ValidityDays { get; set; }

    /// <summary>The number of days in the certificate renewal period. This is the number of days before the a certificate expires during which renewal actions may be performed. When `generateCertificateAuthority` is true, this will cause the generation of a new certificate. When `generateCertificateAuthority` is true, this will cause extra logging at WARN level about the pending certificate expiry. Default is 30.</summary>
    [JsonPropertyName("renewalDays")]
    public int? RenewalDays { get; set; }

    /// <summary>How should CA certificate expiration be handled when `generateCertificateAuthority=true`. The default is for a new CA certificate to be generated reusing the existing private key.</summary>
    [JsonPropertyName("certificateExpirationPolicy")]
    public V1KafkaSpecClusterCaCertificateExpirationPolicyEnum? CertificateExpirationPolicy { get; set; }
}

/// <summary>How should CA certificate expiration be handled when `generateCertificateAuthority=true`. The default is for a new CA certificate to be generated reusing the existing private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecClientsCaCertificateExpirationPolicyEnum>))]
public enum V1KafkaSpecClientsCaCertificateExpirationPolicyEnum
{
    [EnumMember(Value = "renew-certificate"), JsonStringEnumMemberName("renew-certificate")]
    RenewCertificate,
    [EnumMember(Value = "replace-key"), JsonStringEnumMemberName("replace-key")]
    ReplaceKey
}

/// <summary>Configuration of the clients certificate authority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecClientsCa
{
    /// <summary>If true then Certificate Authority certificates will be generated automatically. Otherwise the user will need to provide a Secret with the CA certificate. Default is true.</summary>
    [JsonPropertyName("generateCertificateAuthority")]
    public bool? GenerateCertificateAuthority { get; set; }

    /// <summary>If `true`, the Cluster and Client CA Secrets are configured with the `ownerReference` set to the `Kafka` resource. If the `Kafka` resource is deleted when `true`, the CA Secrets are also deleted. If `false`, the `ownerReference` is disabled. If the `Kafka` resource is deleted when `false`, the CA Secrets are retained and available for reuse. Default is `true`.</summary>
    [JsonPropertyName("generateSecretOwnerReference")]
    public bool? GenerateSecretOwnerReference { get; set; }

    /// <summary>The number of days generated certificates should be valid for. The default is 365.</summary>
    [JsonPropertyName("validityDays")]
    public int? ValidityDays { get; set; }

    /// <summary>The number of days in the certificate renewal period. This is the number of days before the a certificate expires during which renewal actions may be performed. When `generateCertificateAuthority` is true, this will cause the generation of a new certificate. When `generateCertificateAuthority` is true, this will cause extra logging at WARN level about the pending certificate expiry. Default is 30.</summary>
    [JsonPropertyName("renewalDays")]
    public int? RenewalDays { get; set; }

    /// <summary>How should CA certificate expiration be handled when `generateCertificateAuthority=true`. The default is for a new CA certificate to be generated reusing the existing private key.</summary>
    [JsonPropertyName("certificateExpirationPolicy")]
    public V1KafkaSpecClientsCaCertificateExpirationPolicyEnum? CertificateExpirationPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>CPU and memory resources to reserve for the Cruise Control container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaSpecCruiseControlResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>Pod liveness checking for the Cruise Control container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlLivenessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Pod readiness checking for the Cruise Control container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlReadinessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlJvmOptionsJavaSystemProperties
{
    /// <summary>The system property name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The system property value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>JVM Options for the Cruise Control container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlJvmOptions
{
    /// <summary>A map of -XX options to the JVM.</summary>
    [JsonPropertyName("-XX")]
    public IDictionary<string, string>? XX { get; set; }

    /// <summary>-Xmx option to to the JVM.</summary>
    [JsonPropertyName("-Xmx")]
    public string? Xmx { get; set; }

    /// <summary>-Xms option to to the JVM.</summary>
    [JsonPropertyName("-Xms")]
    public string? Xms { get; set; }

    /// <summary>Specifies whether the Garbage Collection logging is enabled. The default is false.</summary>
    [JsonPropertyName("gcLoggingEnabled")]
    public bool? GcLoggingEnabled { get; set; }

    /// <summary>A map of additional system properties which will be passed using the `-D` option to the JVM.</summary>
    [JsonPropertyName("javaSystemProperties")]
    public IList<V1KafkaSpecCruiseControlJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlLoggingTypeEnum>))]
public enum V1KafkaSpecCruiseControlLoggingTypeEnum
{
    [EnumMember(Value = "inline"), JsonStringEnumMemberName("inline")]
    Inline,
    [EnumMember(Value = "external"), JsonStringEnumMemberName("external")]
    External
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlLoggingValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlLoggingValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecCruiseControlLoggingValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Logging configuration (Log4j 2) for Cruise Control.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlLogging
{
    /// <summary>A Map from logger name to logger level.</summary>
    [JsonPropertyName("loggers")]
    public IDictionary<string, string>? Loggers { get; set; }

    /// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecCruiseControlLoggingTypeEnum Type { get; set; }

    /// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecCruiseControlLoggingValueFrom? ValueFrom { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateDeploymentMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlTemplateDeploymentDeploymentStrategyEnum>))]
public enum V1KafkaSpecCruiseControlTemplateDeploymentDeploymentStrategyEnum
{
    [EnumMember(Value = "RollingUpdate"), JsonStringEnumMemberName("RollingUpdate")]
    RollingUpdate,
    [EnumMember(Value = "Recreate"), JsonStringEnumMemberName("Recreate")]
    Recreate
}

/// <summary>Template for Cruise Control `Deployment`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateDeployment
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecCruiseControlTemplateDeploymentMetadata? Metadata { get; set; }

    /// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
    [JsonPropertyName("deploymentStrategy")]
    public V1KafkaSpecCruiseControlTemplateDeploymentDeploymentStrategyEnum? DeploymentStrategy { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Configures pod-level security attributes and common container settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecCruiseControlTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public int? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecCruiseControlTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecCruiseControlTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaSpecCruiseControlTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecCruiseControlTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaSpecCruiseControlTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public int? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecCruiseControlTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecCruiseControlTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public int? MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public string? WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlTemplatePodDnsPolicyEnum>))]
public enum V1KafkaSpecCruiseControlTemplatePodDnsPolicyEnum
{
    [EnumMember(Value = "ClusterFirst"), JsonStringEnumMemberName("ClusterFirst")]
    ClusterFirst,
    [EnumMember(Value = "ClusterFirstWithHostNet"), JsonStringEnumMemberName("ClusterFirstWithHostNet")]
    ClusterFirstWithHostNet,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaSpecCruiseControlTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecCruiseControlTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecCruiseControlTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaSpecCruiseControlTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaSpecCruiseControlTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for Cruise Control `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecCruiseControlTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaSpecCruiseControlTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecCruiseControlTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaSpecCruiseControlTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaSpecCruiseControlTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaSpecCruiseControlTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaSpecCruiseControlTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaSpecCruiseControlTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaSpecCruiseControlTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaSpecCruiseControlTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateApiServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlTemplateApiServiceIpFamilyPolicyEnum>))]
public enum V1KafkaSpecCruiseControlTemplateApiServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlTemplateApiServiceIpFamiliesEnum>))]
public enum V1KafkaSpecCruiseControlTemplateApiServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for Cruise Control API `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateApiService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecCruiseControlTemplateApiServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaSpecCruiseControlTemplateApiServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaSpecCruiseControlTemplateApiServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodDisruptionBudgetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Cruise Control `PodDisruptionBudget`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplatePodDisruptionBudget
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecCruiseControlTemplatePodDisruptionBudgetMetadata? Metadata { get; set; }

    /// <summary>Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Cruise Control container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateCruiseControlContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaSpecCruiseControlTemplateCruiseControlContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaSpecCruiseControlTemplateCruiseControlContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Cruise Control service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplateServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecCruiseControlTemplateServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Template to specify how Cruise Control resources, `Deployments` and `Pods`, are generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlTemplate
{
    /// <summary>Template for Cruise Control `Deployment`.</summary>
    [JsonPropertyName("deployment")]
    public V1KafkaSpecCruiseControlTemplateDeployment? Deployment { get; set; }

    /// <summary>Template for Cruise Control `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaSpecCruiseControlTemplatePod? Pod { get; set; }

    /// <summary>Template for Cruise Control API `Service`.</summary>
    [JsonPropertyName("apiService")]
    public V1KafkaSpecCruiseControlTemplateApiService? ApiService { get; set; }

    /// <summary>Template for Cruise Control `PodDisruptionBudget`.</summary>
    [JsonPropertyName("podDisruptionBudget")]
    public V1KafkaSpecCruiseControlTemplatePodDisruptionBudget? PodDisruptionBudget { get; set; }

    /// <summary>Template for the Cruise Control container.</summary>
    [JsonPropertyName("cruiseControlContainer")]
    public V1KafkaSpecCruiseControlTemplateCruiseControlContainer? CruiseControlContainer { get; set; }

    /// <summary>Template for the Cruise Control service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KafkaSpecCruiseControlTemplateServiceAccount? ServiceAccount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlBrokerCapacityOverrides
{
    /// <summary>List of Kafka brokers (broker identifiers).</summary>
    [JsonPropertyName("brokers")]
    public required IList<int> Brokers { get; set; }

    /// <summary>Broker capacity for CPU resource in cores or millicores. For example, 1, 1.500, 1500m. For more information on valid CPU resource units see https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/#meaning-of-cpu.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Broker capacity for inbound network throughput in bytes per second. Use an integer value with standard Kubernetes byte units (K, M, G) or their bibyte (power of two) equivalents (Ki, Mi, Gi) per second. For example, 10000KiB/s.</summary>
    [JsonPropertyName("inboundNetwork")]
    public string? InboundNetwork { get; set; }

    /// <summary>Broker capacity for outbound network throughput in bytes per second. Use an integer value with standard Kubernetes byte units (K, M, G) or their bibyte (power of two) equivalents (Ki, Mi, Gi) per second. For example, 10000KiB/s.</summary>
    [JsonPropertyName("outboundNetwork")]
    public string? OutboundNetwork { get; set; }
}

/// <summary>The Cruise Control `brokerCapacity` configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlBrokerCapacity
{
    /// <summary>Broker capacity for CPU resource in cores or millicores. For example, 1, 1.500, 1500m. For more information on valid CPU resource units see https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/#meaning-of-cpu.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Broker capacity for inbound network throughput in bytes per second. Use an integer value with standard Kubernetes byte units (K, M, G) or their bibyte (power of two) equivalents (Ki, Mi, Gi) per second. For example, 10000KiB/s.</summary>
    [JsonPropertyName("inboundNetwork")]
    public string? InboundNetwork { get; set; }

    /// <summary>Broker capacity for outbound network throughput in bytes per second. Use an integer value with standard Kubernetes byte units (K, M, G) or their bibyte (power of two) equivalents (Ki, Mi, Gi) per second. For example, 10000KiB/s.</summary>
    [JsonPropertyName("outboundNetwork")]
    public string? OutboundNetwork { get; set; }

    /// <summary>Overrides for individual brokers. The `overrides` property lets you specify a different capacity configuration for different brokers.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1KafkaSpecCruiseControlBrokerCapacityOverrides>? Overrides { get; set; }
}

/// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlMetricsConfigTypeEnum>))]
public enum V1KafkaSpecCruiseControlMetricsConfigTypeEnum
{
    [EnumMember(Value = "jmxPrometheusExporter"), JsonStringEnumMemberName("jmxPrometheusExporter")]
    JmxPrometheusExporter,
    [EnumMember(Value = "strimziMetricsReporter"), JsonStringEnumMemberName("strimziMetricsReporter")]
    StrimziMetricsReporter
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlMetricsConfigValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlMetricsConfigValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecCruiseControlMetricsConfigValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlMetricsConfigValues
{
    /// <summary>A list of regex patterns to filter the metrics to collect. Should contain at least one element.</summary>
    [JsonPropertyName("allowList")]
    public IList<string>? AllowList { get; set; }
}

/// <summary>Metrics configuration. Only `jmxPrometheusExporter` can be configured, as this component does not support `strimziMetricsReporter`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlMetricsConfig
{
    /// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecCruiseControlMetricsConfigTypeEnum Type { get; set; }

    /// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecCruiseControlMetricsConfigValueFrom? ValueFrom { get; set; }

    /// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
    [JsonPropertyName("values")]
    public V1KafkaSpecCruiseControlMetricsConfigValues? Values { get; set; }
}

/// <summary>Type of the Cruise Control API users configuration. Supported format is: `hashLoginService`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlApiUsersTypeEnum>))]
public enum V1KafkaSpecCruiseControlApiUsersTypeEnum
{
    [EnumMember(Value = "hashLoginService"), JsonStringEnumMemberName("hashLoginService")]
    HashLoginService
}

/// <summary>Selects a key of a Secret in the resource&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlApiUsersValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Secret from which the custom Cruise Control API authentication credentials are read.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlApiUsersValueFrom
{
    /// <summary>Selects a key of a Secret in the resource&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaSpecCruiseControlApiUsersValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Configuration of the Cruise Control REST API users.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlApiUsers
{
    /// <summary>Type of the Cruise Control API users configuration. Supported format is: `hashLoginService`.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaSpecCruiseControlApiUsersTypeEnum Type { get; set; }

    /// <summary>Secret from which the custom Cruise Control API authentication credentials are read.</summary>
    [JsonPropertyName("valueFrom")]
    public required V1KafkaSpecCruiseControlApiUsersValueFrom ValueFrom { get; set; }
}

/// <summary>
/// Specifies the mode for automatically rebalancing when brokers are added or removed. Supported modes are `add-brokers` and `remove-brokers`. 
/// 
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecCruiseControlAutoRebalanceModeEnum>))]
public enum V1KafkaSpecCruiseControlAutoRebalanceModeEnum
{
    [EnumMember(Value = "add-brokers"), JsonStringEnumMemberName("add-brokers")]
    AddBrokers,
    [EnumMember(Value = "remove-brokers"), JsonStringEnumMemberName("remove-brokers")]
    RemoveBrokers
}

/// <summary>Reference to the KafkaRebalance custom resource to be used as the configuration template for the auto-rebalancing on scaling when running for the corresponding mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlAutoRebalanceTemplate
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControlAutoRebalance
{
    /// <summary>
    /// Specifies the mode for automatically rebalancing when brokers are added or removed. Supported modes are `add-brokers` and `remove-brokers`. 
    /// 
    /// </summary>
    [JsonPropertyName("mode")]
    public required V1KafkaSpecCruiseControlAutoRebalanceModeEnum Mode { get; set; }

    /// <summary>Reference to the KafkaRebalance custom resource to be used as the configuration template for the auto-rebalancing on scaling when running for the corresponding mode.</summary>
    [JsonPropertyName("template")]
    public V1KafkaSpecCruiseControlAutoRebalanceTemplate? Template { get; set; }
}

/// <summary>Configuration for Cruise Control deployment. Deploys a Cruise Control instance when specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecCruiseControl
{
    /// <summary>The container image used for Cruise Control pods. If no image name is explicitly specified, the image name corresponds to the name specified in the Cluster Operator configuration. If an image name is not defined in the Cluster Operator configuration, a default value is used.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>CPU and memory resources to reserve for the Cruise Control container.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaSpecCruiseControlResources? Resources { get; set; }

    /// <summary>Pod liveness checking for the Cruise Control container.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaSpecCruiseControlLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness checking for the Cruise Control container.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaSpecCruiseControlReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>JVM Options for the Cruise Control container.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaSpecCruiseControlJvmOptions? JvmOptions { get; set; }

    /// <summary>Logging configuration (Log4j 2) for Cruise Control.</summary>
    [JsonPropertyName("logging")]
    public V1KafkaSpecCruiseControlLogging? Logging { get; set; }

    /// <summary>Template to specify how Cruise Control resources, `Deployments` and `Pods`, are generated.</summary>
    [JsonPropertyName("template")]
    public V1KafkaSpecCruiseControlTemplate? Template { get; set; }

    /// <summary>The Cruise Control `brokerCapacity` configuration.</summary>
    [JsonPropertyName("brokerCapacity")]
    public V1KafkaSpecCruiseControlBrokerCapacity? BrokerCapacity { get; set; }

    /// <summary>The Cruise Control configuration. For a full list of configuration options refer to https://github.com/linkedin/cruise-control/wiki/Configurations. Note that properties with the following prefixes cannot be set: bootstrap.servers, client.id, zookeeper., network., security., failed.brokers.zk.path,webserver.http., webserver.api.urlprefix, webserver.session.path, webserver.accesslog., two.step., request.reason.required,metric.reporter.sampler.bootstrap.servers, capacity.config.file, self.healing., ssl., kafka.broker.failure.detection.enable, topic.config.provider.class (with the exception of: ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols, webserver.http.cors.enabled, webserver.http.cors.origin, webserver.http.cors.exposeheaders, webserver.security.enable, webserver.ssl.enable).</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Metrics configuration. Only `jmxPrometheusExporter` can be configured, as this component does not support `strimziMetricsReporter`.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1KafkaSpecCruiseControlMetricsConfig? MetricsConfig { get; set; }

    /// <summary>Configuration of the Cruise Control REST API users.</summary>
    [JsonPropertyName("apiUsers")]
    public V1KafkaSpecCruiseControlApiUsers? ApiUsers { get; set; }

    /// <summary>Auto-rebalancing on scaling related configuration listing the modes, when brokers are added or removed, with the corresponding rebalance template configurations.If this field is set, at least one mode has to be defined.</summary>
    [JsonPropertyName("autoRebalance")]
    public IList<V1KafkaSpecCruiseControlAutoRebalance>? AutoRebalance { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>CPU and memory resources to reserve.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaSpecKafkaExporterResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>Pod liveness check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterLivenessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Pod readiness check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterReadinessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateDeploymentMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaExporterTemplateDeploymentDeploymentStrategyEnum>))]
public enum V1KafkaSpecKafkaExporterTemplateDeploymentDeploymentStrategyEnum
{
    [EnumMember(Value = "RollingUpdate"), JsonStringEnumMemberName("RollingUpdate")]
    RollingUpdate,
    [EnumMember(Value = "Recreate"), JsonStringEnumMemberName("Recreate")]
    Recreate
}

/// <summary>Template for Kafka Exporter `Deployment`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateDeployment
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaExporterTemplateDeploymentMetadata? Metadata { get; set; }

    /// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
    [JsonPropertyName("deploymentStrategy")]
    public V1KafkaSpecKafkaExporterTemplateDeploymentDeploymentStrategyEnum? DeploymentStrategy { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Configures pod-level security attributes and common container settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecKafkaExporterTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public int? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecKafkaExporterTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecKafkaExporterTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecKafkaExporterTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public int? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaSpecKafkaExporterTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public int? MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public string? WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaExporterTemplatePodDnsPolicyEnum>))]
public enum V1KafkaSpecKafkaExporterTemplatePodDnsPolicyEnum
{
    [EnumMember(Value = "ClusterFirst"), JsonStringEnumMemberName("ClusterFirst")]
    ClusterFirst,
    [EnumMember(Value = "ClusterFirstWithHostNet"), JsonStringEnumMemberName("ClusterFirstWithHostNet")]
    ClusterFirstWithHostNet,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaSpecKafkaExporterTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaSpecKafkaExporterTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaSpecKafkaExporterTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for Kafka Exporter `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaExporterTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecKafkaExporterTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaSpecKafkaExporterTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaSpecKafkaExporterTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaSpecKafkaExporterTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaSpecKafkaExporterTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaSpecKafkaExporterTemplateContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaSpecKafkaExporterTemplateContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaSpecKafkaExporterTemplateContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaSpecKafkaExporterTemplateContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaSpecKafkaExporterTemplateContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaSpecKafkaExporterTemplateContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaSpecKafkaExporterTemplateContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaSpecKafkaExporterTemplateContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka Exporter container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaSpecKafkaExporterTemplateContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaSpecKafkaExporterTemplateContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaSpecKafkaExporterTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Exporter service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplateServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaExporterTemplateServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodDisruptionBudgetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Pod Disruption Budget for Kafka Exporter pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplatePodDisruptionBudget
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaSpecKafkaExporterTemplatePodDisruptionBudgetMetadata? Metadata { get; set; }

    /// <summary>Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }
}

/// <summary>Customization of deployment templates and pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporterTemplate
{
    /// <summary>Template for Kafka Exporter `Deployment`.</summary>
    [JsonPropertyName("deployment")]
    public V1KafkaSpecKafkaExporterTemplateDeployment? Deployment { get; set; }

    /// <summary>Template for Kafka Exporter `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaSpecKafkaExporterTemplatePod? Pod { get; set; }

    /// <summary>Template for the Kafka Exporter container.</summary>
    [JsonPropertyName("container")]
    public V1KafkaSpecKafkaExporterTemplateContainer? Container { get; set; }

    /// <summary>Template for the Kafka Exporter service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KafkaSpecKafkaExporterTemplateServiceAccount? ServiceAccount { get; set; }

    /// <summary>Template for the Pod Disruption Budget for Kafka Exporter pods.</summary>
    [JsonPropertyName("podDisruptionBudget")]
    public V1KafkaSpecKafkaExporterTemplatePodDisruptionBudget? PodDisruptionBudget { get; set; }
}

/// <summary>Configuration of the Kafka Exporter. Kafka Exporter can provide additional metrics, for example lag of consumer group at topic/partition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpecKafkaExporter
{
    /// <summary>The container image used for the Kafka Exporter pods. If no image name is explicitly specified, the image name corresponds to the version specified in the Cluster Operator configuration. If an image name is not defined in the Cluster Operator configuration, a default value is used.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Regular expression to specify which consumer groups to collect. Default value is `.*`.</summary>
    [JsonPropertyName("groupRegex")]
    public string? GroupRegex { get; set; }

    /// <summary>Regular expression to specify which topics to collect. Default value is `.*`.</summary>
    [JsonPropertyName("topicRegex")]
    public string? TopicRegex { get; set; }

    /// <summary>Regular expression to specify which consumer groups to exclude.</summary>
    [JsonPropertyName("groupExcludeRegex")]
    public string? GroupExcludeRegex { get; set; }

    /// <summary>Regular expression to specify which topics to exclude.</summary>
    [JsonPropertyName("topicExcludeRegex")]
    public string? TopicExcludeRegex { get; set; }

    /// <summary>CPU and memory resources to reserve.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaSpecKafkaExporterResources? Resources { get; set; }

    /// <summary>Only log messages with the given severity or above. Valid levels: [`info`, `debug`, `trace`]. Default log level is `info`.</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Pod liveness check.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaSpecKafkaExporterLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness check.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaSpecKafkaExporterReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Enable Sarama logging, a Go client library used by the Kafka Exporter.</summary>
    [JsonPropertyName("enableSaramaLogging")]
    public bool? EnableSaramaLogging { get; set; }

    /// <summary>Whether show the offset/lag for all consumer group, otherwise, only show connected consumer groups.</summary>
    [JsonPropertyName("showAllOffsets")]
    public bool? ShowAllOffsets { get; set; }

    /// <summary>Customization of deployment templates and pods.</summary>
    [JsonPropertyName("template")]
    public V1KafkaSpecKafkaExporterTemplate? Template { get; set; }
}

/// <summary>The specification of the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaSpec
{
    /// <summary>Configuration of the Kafka cluster.</summary>
    [JsonPropertyName("kafka")]
    public required V1KafkaSpecKafka Kafka { get; set; }

    /// <summary>Configuration of the Entity Operator.</summary>
    [JsonPropertyName("entityOperator")]
    public V1KafkaSpecEntityOperator? EntityOperator { get; set; }

    /// <summary>Configuration of the cluster certificate authority.</summary>
    [JsonPropertyName("clusterCa")]
    public V1KafkaSpecClusterCa? ClusterCa { get; set; }

    /// <summary>Configuration of the clients certificate authority.</summary>
    [JsonPropertyName("clientsCa")]
    public V1KafkaSpecClientsCa? ClientsCa { get; set; }

    /// <summary>Configuration for Cruise Control deployment. Deploys a Cruise Control instance when specified.</summary>
    [JsonPropertyName("cruiseControl")]
    public V1KafkaSpecCruiseControl? CruiseControl { get; set; }

    /// <summary>Configuration of the Kafka Exporter. Kafka Exporter can provide additional metrics, for example lag of consumer group at topic/partition.</summary>
    [JsonPropertyName("kafkaExporter")]
    public V1KafkaSpecKafkaExporter? KafkaExporter { get; set; }

    /// <summary>A list of time windows for maintenance tasks (that is, certificates renewal). Each time window is defined by a cron expression.</summary>
    [JsonPropertyName("maintenanceTimeWindows")]
    public IList<string>? MaintenanceTimeWindows { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaStatusConditions
{
    /// <summary>The unique identifier of a condition, used to distinguish between other conditions in the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The status of the condition, either True, False or Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Last time the condition of a type changed from one status to another. The required format is &apos;yyyy-MM-ddTHH:mm:ssZ&apos;, in the UTC time zone.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>The reason for the condition&apos;s last transition (a single word in CamelCase).</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Human-readable message indicating details about the condition&apos;s last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaStatusListenersAddresses
{
    /// <summary>The DNS name or IP address of the Kafka bootstrap service.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port of the Kafka bootstrap service.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaStatusListeners
{
    /// <summary>The name of the listener.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of the addresses for this listener.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1KafkaStatusListenersAddresses>? Addresses { get; set; }

    /// <summary>A comma-separated list of `host:port` pairs for connecting to the Kafka cluster using this listener.</summary>
    [JsonPropertyName("bootstrapServers")]
    public string? BootstrapServers { get; set; }

    /// <summary>A list of TLS certificates which can be used to verify the identity of the server when connecting to the given listener. Set only for `tls` and `external` listeners.</summary>
    [JsonPropertyName("certificates")]
    public IList<string>? Certificates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaStatusKafkaNodePools
{
    /// <summary>The name of the KafkaNodePool used by this Kafka resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The current state of an auto-rebalancing operation. Possible values are: 
/// 
/// * `Idle` as the initial state when an auto-rebalancing is requested or as final state when it completes or fails.
/// * `RebalanceOnScaleDown` if an auto-rebalance related to a scale-down operation is running.
/// * `RebalanceOnScaleUp` if an auto-rebalance related to a scale-up operation is running.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaStatusAutoRebalanceStateEnum>))]
public enum V1KafkaStatusAutoRebalanceStateEnum
{
    [EnumMember(Value = "Idle"), JsonStringEnumMemberName("Idle")]
    Idle,
    [EnumMember(Value = "RebalanceOnScaleDown"), JsonStringEnumMemberName("RebalanceOnScaleDown")]
    RebalanceOnScaleDown,
    [EnumMember(Value = "RebalanceOnScaleUp"), JsonStringEnumMemberName("RebalanceOnScaleUp")]
    RebalanceOnScaleUp
}

/// <summary>Mode for which there is an auto-rebalancing operation in progress or queued, when brokers are added or removed. The possible modes are `add-brokers` and `remove-brokers`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaStatusAutoRebalanceModesModeEnum>))]
public enum V1KafkaStatusAutoRebalanceModesModeEnum
{
    [EnumMember(Value = "add-brokers"), JsonStringEnumMemberName("add-brokers")]
    AddBrokers,
    [EnumMember(Value = "remove-brokers"), JsonStringEnumMemberName("remove-brokers")]
    RemoveBrokers
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaStatusAutoRebalanceModes
{
    /// <summary>Mode for which there is an auto-rebalancing operation in progress or queued, when brokers are added or removed. The possible modes are `add-brokers` and `remove-brokers`.</summary>
    [JsonPropertyName("mode")]
    public V1KafkaStatusAutoRebalanceModesModeEnum? Mode { get; set; }

    /// <summary>
    /// List of broker IDs involved in an auto-rebalancing operation related to the current mode. 
    /// The list contains one of the following: 
    /// 
    /// * Broker IDs for a current auto-rebalance. 
    /// * Broker IDs for a queued auto-rebalance (if a previous auto-rebalance is still in progress). 
    /// 
    /// </summary>
    [JsonPropertyName("brokers")]
    public IList<int>? Brokers { get; set; }
}

/// <summary>The status of an auto-rebalancing triggered by a cluster scaling request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaStatusAutoRebalance
{
    /// <summary>
    /// The current state of an auto-rebalancing operation. Possible values are: 
    /// 
    /// * `Idle` as the initial state when an auto-rebalancing is requested or as final state when it completes or fails.
    /// * `RebalanceOnScaleDown` if an auto-rebalance related to a scale-down operation is running.
    /// * `RebalanceOnScaleUp` if an auto-rebalance related to a scale-up operation is running.
    /// </summary>
    [JsonPropertyName("state")]
    public V1KafkaStatusAutoRebalanceStateEnum? State { get; set; }

    /// <summary>The timestamp of the latest auto-rebalancing state update.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>
    /// List of modes where an auto-rebalancing operation is either running or queued. 
    /// Each mode entry (`add-brokers` or `remove-brokers`) includes one of the following: 
    /// 
    /// * Broker IDs for a current auto-rebalance. 
    /// * Broker IDs for a queued auto-rebalance (if a previous rebalance is still in progress).
    /// </summary>
    [JsonPropertyName("modes")]
    public IList<V1KafkaStatusAutoRebalanceModes>? Modes { get; set; }
}

/// <summary>The status of the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaStatus
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaStatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Addresses of the internal and external listeners.</summary>
    [JsonPropertyName("listeners")]
    public IList<V1KafkaStatusListeners>? Listeners { get; set; }

    /// <summary>List of the KafkaNodePools used by this Kafka cluster.</summary>
    [JsonPropertyName("kafkaNodePools")]
    public IList<V1KafkaStatusKafkaNodePools>? KafkaNodePools { get; set; }

    /// <summary>Kafka cluster Id.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>The version of the Strimzi Cluster Operator which performed the last successful reconciliation.</summary>
    [JsonPropertyName("operatorLastSuccessfulVersion")]
    public string? OperatorLastSuccessfulVersion { get; set; }

    /// <summary>The version of Kafka currently deployed in the cluster.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>The KRaft metadata.version currently used by the Kafka cluster.</summary>
    [JsonPropertyName("kafkaMetadataVersion")]
    public string? KafkaMetadataVersion { get; set; }

    /// <summary>The status of an auto-rebalancing triggered by a cluster scaling request.</summary>
    [JsonPropertyName("autoRebalance")]
    public V1KafkaStatusAutoRebalance? AutoRebalance { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Kafka : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaSpec>, IStatus<V1KafkaStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Kafka";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkas";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Kafka";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the Kafka cluster.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaSpec Spec { get; set; }

    /// <summary>The status of the Kafka cluster.</summary>
    [JsonPropertyName("status")]
    public V1KafkaStatus? Status { get; set; }
}
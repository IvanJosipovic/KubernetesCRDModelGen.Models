#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>HealthCheck is the Schema for the HealthChecks API. Health Checks determine whether instances are responsive and able to do work.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HealthCheckList : IKubernetesObject<V1ListMeta>, IItems<V1beta2HealthCheck>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HealthCheckList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "healthchecks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HealthCheckList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2HealthCheck objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2HealthCheck> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthCheckSpecDeletionPolicyEnum>))]
public enum V1beta2HealthCheckSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProviderGrpcHealthCheck
{
    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    /// </summary>
    [JsonPropertyName("grpcServiceName")]
    public string? GrpcServiceName { get; set; }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if portName and portSpecification are not set
    /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProviderHttp2HealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTP2 health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP2 health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP2 health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProviderHttpHealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTP health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProviderHttpsHealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTPS health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// Configure logging on this health check.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProviderLogConfig
{
    /// <summary>
    /// Indicates whether or not to export logs. This is false by default,
    /// which means no health check logging will be done.
    /// </summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProviderSslHealthCheck
{
    /// <summary>
    /// The TCP port number for the SSL health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the SSL connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProviderTcpHealthCheck
{
    /// <summary>
    /// The TCP port number for the TCP health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the TCP connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecForProvider
{
    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcHealthCheck")]
    public V1beta2HealthCheckSpecForProviderGrpcHealthCheck? GrpcHealthCheck { get; set; }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("http2HealthCheck")]
    public V1beta2HealthCheckSpecForProviderHttp2HealthCheck? Http2HealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHealthCheck")]
    public V1beta2HealthCheckSpecForProviderHttpHealthCheck? HttpHealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpsHealthCheck")]
    public V1beta2HealthCheckSpecForProviderHttpsHealthCheck? HttpsHealthCheck { get; set; }

    /// <summary>
    /// Configure logging on this health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2HealthCheckSpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The list of cloud regions from which health checks are performed. If
    /// any regions are specified, then exactly 3 regions should be specified.
    /// The region names must be valid names of Google Cloud regions. This can
    /// only be set for global health check. If this list is non-empty, then
    /// there are restrictions on what other health check fields are supported
    /// and what other resources can use this health check:
    /// </summary>
    [JsonPropertyName("sourceRegions")]
    public IList<string>? SourceRegions { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sslHealthCheck")]
    public V1beta2HealthCheckSpecForProviderSslHealthCheck? SslHealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tcpHealthCheck")]
    public V1beta2HealthCheckSpecForProviderTcpHealthCheck? TcpHealthCheck { get; set; }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecInitProviderGrpcHealthCheck
{
    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    /// </summary>
    [JsonPropertyName("grpcServiceName")]
    public string? GrpcServiceName { get; set; }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if portName and portSpecification are not set
    /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecInitProviderHttp2HealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTP2 health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP2 health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP2 health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecInitProviderHttpHealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTP health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecInitProviderHttpsHealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTPS health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// Configure logging on this health check.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecInitProviderLogConfig
{
    /// <summary>
    /// Indicates whether or not to export logs. This is false by default,
    /// which means no health check logging will be done.
    /// </summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecInitProviderSslHealthCheck
{
    /// <summary>
    /// The TCP port number for the SSL health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the SSL connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecInitProviderTcpHealthCheck
{
    /// <summary>
    /// The TCP port number for the TCP health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the TCP connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
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
public partial class V1beta2HealthCheckSpecInitProvider
{
    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcHealthCheck")]
    public V1beta2HealthCheckSpecInitProviderGrpcHealthCheck? GrpcHealthCheck { get; set; }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("http2HealthCheck")]
    public V1beta2HealthCheckSpecInitProviderHttp2HealthCheck? Http2HealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHealthCheck")]
    public V1beta2HealthCheckSpecInitProviderHttpHealthCheck? HttpHealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpsHealthCheck")]
    public V1beta2HealthCheckSpecInitProviderHttpsHealthCheck? HttpsHealthCheck { get; set; }

    /// <summary>
    /// Configure logging on this health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2HealthCheckSpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The list of cloud regions from which health checks are performed. If
    /// any regions are specified, then exactly 3 regions should be specified.
    /// The region names must be valid names of Google Cloud regions. This can
    /// only be set for global health check. If this list is non-empty, then
    /// there are restrictions on what other health check fields are supported
    /// and what other resources can use this health check:
    /// </summary>
    [JsonPropertyName("sourceRegions")]
    public IList<string>? SourceRegions { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sslHealthCheck")]
    public V1beta2HealthCheckSpecInitProviderSslHealthCheck? SslHealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tcpHealthCheck")]
    public V1beta2HealthCheckSpecInitProviderTcpHealthCheck? TcpHealthCheck { get; set; }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthCheckSpecManagementPoliciesEnum>))]
public enum V1beta2HealthCheckSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthCheckSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2HealthCheckSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2HealthCheckSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2HealthCheckSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2HealthCheckSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2HealthCheckSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2HealthCheckSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>HealthCheckSpec defines the desired state of HealthCheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckSpec
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
    public V1beta2HealthCheckSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2HealthCheckSpecForProvider ForProvider { get; set; }

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
    public V1beta2HealthCheckSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2HealthCheckSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2HealthCheckSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2HealthCheckSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProviderGrpcHealthCheck
{
    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    /// </summary>
    [JsonPropertyName("grpcServiceName")]
    public string? GrpcServiceName { get; set; }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if portName and portSpecification are not set
    /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProviderHttp2HealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTP2 health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP2 health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP2 health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProviderHttpHealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTP health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProviderHttpsHealthCheck
{
    /// <summary>
    /// The value of the host header in the HTTPS health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// Configure logging on this health check.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProviderLogConfig
{
    /// <summary>
    /// Indicates whether or not to export logs. This is false by default,
    /// which means no health check logging will be done.
    /// </summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProviderSslHealthCheck
{
    /// <summary>
    /// The TCP port number for the SSL health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the SSL connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProviderTcpHealthCheck
{
    /// <summary>
    /// The TCP port number for the TCP health check request.
    /// The default value is 443.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// </summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend.
    /// Default value is NONE.
    /// Possible values are: NONE, PROXY_V1.
    /// </summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the TCP connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusAtProvider
{
    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcHealthCheck")]
    public V1beta2HealthCheckStatusAtProviderGrpcHealthCheck? GrpcHealthCheck { get; set; }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("http2HealthCheck")]
    public V1beta2HealthCheckStatusAtProviderHttp2HealthCheck? Http2HealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHealthCheck")]
    public V1beta2HealthCheckStatusAtProviderHttpHealthCheck? HttpHealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpsHealthCheck")]
    public V1beta2HealthCheckStatusAtProviderHttpsHealthCheck? HttpsHealthCheck { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/healthChecks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Configure logging on this health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2HealthCheckStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// The list of cloud regions from which health checks are performed. If
    /// any regions are specified, then exactly 3 regions should be specified.
    /// The region names must be valid names of Google Cloud regions. This can
    /// only be set for global health check. If this list is non-empty, then
    /// there are restrictions on what other health check fields are supported
    /// and what other resources can use this health check:
    /// </summary>
    [JsonPropertyName("sourceRegions")]
    public IList<string>? SourceRegions { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sslHealthCheck")]
    public V1beta2HealthCheckStatusAtProviderSslHealthCheck? SslHealthCheck { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tcpHealthCheck")]
    public V1beta2HealthCheckStatusAtProviderTcpHealthCheck? TcpHealthCheck { get; set; }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>The type of the health check. One of HTTP, HTTPS, TCP, or SSL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatusConditions
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

/// <summary>HealthCheckStatus defines the observed state of HealthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2HealthCheckStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2HealthCheckStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2HealthCheckStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HealthCheck is the Schema for the HealthChecks API. Health Checks determine whether instances are responsive and able to do work.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2HealthCheck : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2HealthCheckSpec>, IStatus<V1beta2HealthCheckStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "HealthCheck";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "healthchecks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HealthCheck";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HealthCheckSpec defines the desired state of HealthCheck</summary>
    [JsonPropertyName("spec")]
    public required V1beta2HealthCheckSpec Spec { get; set; }

    /// <summary>HealthCheckStatus defines the observed state of HealthCheck.</summary>
    [JsonPropertyName("status")]
    public V1beta2HealthCheckStatus? Status { get; set; }
}
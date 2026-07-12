#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53.services.k8s.aws;
/// <summary>RecordSet is the Schema for the RecordSets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RecordSetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RecordSet>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RecordSetList";
    public const string KubeGroup = "route53.services.k8s.aws";
    public const string KubePluralName = "recordsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecordSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RecordSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RecordSet> Items { get; set; }
}

/// <summary>
/// Alias resource record sets only: Information about the Amazon Web Services
/// resource, such as a CloudFront distribution or an Amazon S3 bucket, that
/// you want to route traffic to.
/// 
/// If you&apos;re creating resource records sets for a private hosted zone, note
/// the following:
/// 
///   - You can&apos;t create an alias resource record set in a private hosted zone
///     to route traffic to a CloudFront distribution.
/// 
///   - For information about creating failover resource record sets in a private
///     hosted zone, see Configuring Failover in a Private Hosted Zone (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html)
///     in the Amazon Route 53 Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetSpecAliasTarget
{
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    [JsonPropertyName("evaluateTargetHealth")]
    public bool? EvaluateTargetHealth { get; set; }

    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }
}

/// <summary>
/// The object that is specified in resource record set object when you are linking
/// a resource record set to a CIDR location.
/// 
/// A LocationName with an asterisk “*” can be used to create a default CIDR
/// record. CollectionId is still required for default record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetSpecCidrRoutingConfig
{
    [JsonPropertyName("collectionID")]
    public string? CollectionID { get; set; }

    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>
/// Geolocation resource record sets only: A complex type that lets you control
/// how Amazon Route 53 responds to DNS queries based on the geographic origin
/// of the query. For example, if you want all queries from Africa to be routed
/// to a web server with an IP address of 192.0.2.111, create a resource record
/// set with a Type of A and a ContinentCode of AF.
/// 
/// If you create separate resource record sets for overlapping geographic regions
/// (for example, one resource record set for a continent and one for a country
/// on the same continent), priority goes to the smallest geographic region.
/// This allows you to route most queries for a continent to one resource and
/// to route queries for a country on that continent to a different resource.
/// 
/// You can&apos;t create two geolocation resource record sets that specify the same
/// geographic location.
/// 
/// The value * in the CountryCode element matches all geographic locations that
/// aren&apos;t specified in other geolocation resource record sets that have the
/// same values for the Name and Type elements.
/// 
/// Geolocation works by mapping IP addresses to locations. However, some IP
/// addresses aren&apos;t mapped to geographic locations, so even if you create geolocation
/// resource record sets that cover all seven continents, Route 53 will receive
/// some DNS queries from locations that it can&apos;t identify. We recommend that
/// you create a resource record set for which the value of CountryCode is *.
/// Two groups of queries are routed to the resource that you specify in this
/// record: queries that come from locations for which you haven&apos;t created geolocation
/// resource record sets and queries from IP addresses that aren&apos;t mapped to
/// a location. If you don&apos;t create a * resource record set, Route 53 returns
/// a &quot;no answer&quot; response for queries from those locations.
/// 
/// You can&apos;t create non-geolocation resource record sets that have the same
/// values for the Name and Type elements as geolocation resource record sets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetSpecGeoLocation
{
    [JsonPropertyName("continentCode")]
    public string? ContinentCode { get; set; }

    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("subdivisionCode")]
    public string? SubdivisionCode { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetSpecHealthCheckRefFrom
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
public partial class V1alpha1RecordSetSpecHealthCheckRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RecordSetSpecHealthCheckRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetSpecHostedZoneRefFrom
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
public partial class V1alpha1RecordSetSpecHostedZoneRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RecordSetSpecHostedZoneRefFrom? From { get; set; }
}

/// <summary>
/// Information specific to the resource record.
/// 
/// If you&apos;re creating an alias resource record set, omit ResourceRecord.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetSpecResourceRecords
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>RecordSetSpec defines the desired state of RecordSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetSpec
{
    /// <summary>
    /// Alias resource record sets only: Information about the Amazon Web Services
    /// resource, such as a CloudFront distribution or an Amazon S3 bucket, that
    /// you want to route traffic to.
    /// 
    /// If you&apos;re creating resource records sets for a private hosted zone, note
    /// the following:
    /// 
    ///   - You can&apos;t create an alias resource record set in a private hosted zone
    ///     to route traffic to a CloudFront distribution.
    /// 
    ///   - For information about creating failover resource record sets in a private
    ///     hosted zone, see Configuring Failover in a Private Hosted Zone (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html)
    ///     in the Amazon Route 53 Developer Guide.
    /// </summary>
    [JsonPropertyName("aliasTarget")]
    public V1alpha1RecordSetSpecAliasTarget? AliasTarget { get; set; }

    /// <summary>
    /// The object that is specified in resource record set object when you are linking
    /// a resource record set to a CIDR location.
    /// 
    /// A LocationName with an asterisk “*” can be used to create a default CIDR
    /// record. CollectionId is still required for default record.
    /// </summary>
    [JsonPropertyName("cidrRoutingConfig")]
    public V1alpha1RecordSetSpecCidrRoutingConfig? CidrRoutingConfig { get; set; }

    /// <summary>
    /// Failover resource record sets only: To configure failover, you add the Failover
    /// element to two resource record sets. For one resource record set, you specify
    /// PRIMARY as the value for Failover; for the other resource record set, you
    /// specify SECONDARY. In addition, you include the HealthCheckId element and
    /// specify the health check that you want Amazon Route 53 to perform for each
    /// resource record set.
    /// 
    /// Except where noted, the following failover behaviors assume that you have
    /// included the HealthCheckId element in both resource record sets:
    /// 
    ///   - When the primary resource record set is healthy, Route 53 responds to
    ///     DNS queries with the applicable value from the primary resource record
    ///     set regardless of the health of the secondary resource record set.
    /// 
    ///   - When the primary resource record set is unhealthy and the secondary
    ///     resource record set is healthy, Route 53 responds to DNS queries with
    ///     the applicable value from the secondary resource record set.
    /// 
    ///   - When the secondary resource record set is unhealthy, Route 53 responds
    ///     to DNS queries with the applicable value from the primary resource record
    ///     set regardless of the health of the primary resource record set.
    /// 
    ///   - If you omit the HealthCheckId element for the secondary resource record
    ///     set, and if the primary resource record set is unhealthy, Route 53 always
    ///     responds to DNS queries with the applicable value from the secondary resource
    ///     record set. This is true regardless of the health of the associated endpoint.
    /// 
    /// You can&apos;t create non-failover resource record sets that have the same values
    /// for the Name and Type elements as failover resource record sets.
    /// 
    /// For failover alias resource record sets, you must also include the EvaluateTargetHealth
    /// element and set the value to true.
    /// 
    /// For more information about configuring failover for Route 53, see the following
    /// topics in the Amazon Route 53 Developer Guide:
    /// 
    ///   - Route 53 Health Checks and DNS Failover (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html)
    /// 
    ///   - Configuring Failover in a Private Hosted Zone (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html)
    /// </summary>
    [JsonPropertyName("failover")]
    public string? Failover { get; set; }

    /// <summary>
    /// Geolocation resource record sets only: A complex type that lets you control
    /// how Amazon Route 53 responds to DNS queries based on the geographic origin
    /// of the query. For example, if you want all queries from Africa to be routed
    /// to a web server with an IP address of 192.0.2.111, create a resource record
    /// set with a Type of A and a ContinentCode of AF.
    /// 
    /// If you create separate resource record sets for overlapping geographic regions
    /// (for example, one resource record set for a continent and one for a country
    /// on the same continent), priority goes to the smallest geographic region.
    /// This allows you to route most queries for a continent to one resource and
    /// to route queries for a country on that continent to a different resource.
    /// 
    /// You can&apos;t create two geolocation resource record sets that specify the same
    /// geographic location.
    /// 
    /// The value * in the CountryCode element matches all geographic locations that
    /// aren&apos;t specified in other geolocation resource record sets that have the
    /// same values for the Name and Type elements.
    /// 
    /// Geolocation works by mapping IP addresses to locations. However, some IP
    /// addresses aren&apos;t mapped to geographic locations, so even if you create geolocation
    /// resource record sets that cover all seven continents, Route 53 will receive
    /// some DNS queries from locations that it can&apos;t identify. We recommend that
    /// you create a resource record set for which the value of CountryCode is *.
    /// Two groups of queries are routed to the resource that you specify in this
    /// record: queries that come from locations for which you haven&apos;t created geolocation
    /// resource record sets and queries from IP addresses that aren&apos;t mapped to
    /// a location. If you don&apos;t create a * resource record set, Route 53 returns
    /// a &quot;no answer&quot; response for queries from those locations.
    /// 
    /// You can&apos;t create non-geolocation resource record sets that have the same
    /// values for the Name and Type elements as geolocation resource record sets.
    /// </summary>
    [JsonPropertyName("geoLocation")]
    public V1alpha1RecordSetSpecGeoLocation? GeoLocation { get; set; }

    /// <summary>
    /// If you want Amazon Route 53 to return this resource record set in response
    /// to a DNS query only when the status of a health check is healthy, include
    /// the HealthCheckId element and specify the ID of the applicable health check.
    /// 
    /// Route 53 determines whether a resource record set is healthy based on one
    /// of the following:
    /// 
    ///   - By periodically sending a request to the endpoint that is specified
    ///     in the health check
    /// 
    ///   - By aggregating the status of a specified group of health checks (calculated
    ///     health checks)
    /// 
    ///   - By determining the current state of a CloudWatch alarm (CloudWatch metric
    ///     health checks)
    /// 
    /// Route 53 doesn&apos;t check the health of the endpoint that is specified in the
    /// resource record set, for example, the endpoint specified by the IP address
    /// in the Value element. When you add a HealthCheckId element to a resource
    /// record set, Route 53 checks the health of the endpoint that you specified
    /// in the health check.
    /// 
    /// For more information, see the following topics in the Amazon Route 53 Developer
    /// Guide:
    /// 
    ///   - How Amazon Route 53 Determines Whether an Endpoint Is Healthy (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html)
    /// 
    ///   - Route 53 Health Checks and DNS Failover (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html)
    /// 
    ///   - Configuring Failover in a Private Hosted Zone (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html)
    /// 
    /// # When to Specify HealthCheckId
    /// 
    /// Specifying a value for HealthCheckId is useful only when Route 53 is choosing
    /// between two or more resource record sets to respond to a DNS query, and you
    /// want Route 53 to base the choice in part on the status of a health check.
    /// Configuring health checks makes sense only in the following configurations:
    /// 
    ///   - Non-alias resource record sets: You&apos;re checking the health of a group
    ///     of non-alias resource record sets that have the same routing policy, name,
    ///     and type (such as multiple weighted records named www.example.com with
    ///     a type of A) and you specify health check IDs for all the resource record
    ///     sets. If the health check status for a resource record set is healthy,
    ///     Route 53 includes the record among the records that it responds to DNS
    ///     queries with. If the health check status for a resource record set is
    ///     unhealthy, Route 53 stops responding to DNS queries using the value for
    ///     that resource record set. If the health check status for all resource
    ///     record sets in the group is unhealthy, Route 53 considers all resource
    ///     record sets in the group healthy and responds to DNS queries accordingly.
    /// 
    ///   - Alias resource record sets: You specify the following settings: You
    ///     set EvaluateTargetHealth to true for an alias resource record set in a
    ///     group of resource record sets that have the same routing policy, name,
    ///     and type (such as multiple weighted records named www.example.com with
    ///     a type of A). You configure the alias resource record set to route traffic
    ///     to a non-alias resource record set in the same hosted zone. You specify
    ///     a health check ID for the non-alias resource record set. If the health
    ///     check status is healthy, Route 53 considers the alias resource record
    ///     set to be healthy and includes the alias record among the records that
    ///     it responds to DNS queries with. If the health check status is unhealthy,
    ///     Route 53 stops responding to DNS queries using the alias resource record
    ///     set. The alias resource record set can also route traffic to a group of
    ///     non-alias resource record sets that have the same routing policy, name,
    ///     and type. In that configuration, associate health checks with all of the
    ///     resource record sets in the group of non-alias resource record sets.
    /// 
    /// # Geolocation Routing
    /// 
    /// For geolocation resource record sets, if an endpoint is unhealthy, Route
    /// 53 looks for a resource record set for the larger, associated geographic
    /// region. For example, suppose you have resource record sets for a state in
    /// the United States, for the entire United States, for North America, and a
    /// resource record set that has * for CountryCode is *, which applies to all
    /// locations. If the endpoint for the state resource record set is unhealthy,
    /// Route 53 checks for healthy resource record sets in the following order until
    /// it finds a resource record set for which the endpoint is healthy:
    /// 
    ///   - The United States
    /// 
    ///   - North America
    /// 
    ///   - The default resource record set
    /// 
    /// # Specifying the Health Check Endpoint by Domain Name
    /// 
    /// If your health checks specify the endpoint only by domain name, we recommend
    /// that you create a separate health check for each endpoint. For example, create
    /// a health check for each HTTP server that is serving content for www.example.com.
    /// For the value of FullyQualifiedDomainName, specify the domain name of the
    /// server (such as us-east-2-www.example.com), not the name of the resource
    /// record sets (www.example.com).
    /// 
    /// Health check results will be unpredictable if you do the following:
    /// 
    ///   - Create a health check that has the same value for FullyQualifiedDomainName
    ///     as the name of a resource record set.
    /// 
    ///   - Associate that health check with the resource record set.
    /// </summary>
    [JsonPropertyName("healthCheckID")]
    public string? HealthCheckID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("healthCheckRef")]
    public V1alpha1RecordSetSpecHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>
    /// The ID of the hosted zone that contains the resource record sets that you
    /// want to change.
    /// </summary>
    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("hostedZoneRef")]
    public V1alpha1RecordSetSpecHostedZoneRef? HostedZoneRef { get; set; }

    /// <summary>
    /// Multivalue answer resource record sets only: To route traffic approximately
    /// randomly to multiple resources, such as web servers, create one multivalue
    /// answer record for each resource and specify true for MultiValueAnswer. Note
    /// the following:
    /// 
    ///   - If you associate a health check with a multivalue answer resource record
    ///     set, Amazon Route 53 responds to DNS queries with the corresponding IP
    ///     address only when the health check is healthy.
    /// 
    ///   - If you don&apos;t associate a health check with a multivalue answer record,
    ///     Route 53 always considers the record to be healthy.
    /// 
    ///   - Route 53 responds to DNS queries with up to eight healthy records; if
    ///     you have eight or fewer healthy records, Route 53 responds to all DNS
    ///     queries with all the healthy records.
    /// 
    ///   - If you have more than eight healthy records, Route 53 responds to different
    ///     DNS resolvers with different combinations of healthy records.
    /// 
    ///   - When all records are unhealthy, Route 53 responds to DNS queries with
    ///     up to eight unhealthy records.
    /// 
    ///   - If a resource becomes unavailable after a resolver caches a response,
    ///     client software typically tries another of the IP addresses in the response.
    /// 
    /// You can&apos;t create multivalue answer alias records.
    /// </summary>
    [JsonPropertyName("multiValueAnswer")]
    public bool? MultiValueAnswer { get; set; }

    /// <summary>
    /// For ChangeResourceRecordSets requests, the name of the record that you want
    /// to create, update, or delete. For ListResourceRecordSets responses, the name
    /// of a record in the specified hosted zone.
    /// 
    /// # ChangeResourceRecordSets Only
    /// 
    /// Enter a fully qualified domain name, for example, www.example.com. You can
    /// optionally include a trailing dot. If you omit the trailing dot, Amazon Route
    /// 53 assumes that the domain name that you specify is fully qualified. This
    /// means that Route 53 treats www.example.com (without a trailing dot) and www.example.com.
    /// (with a trailing dot) as identical.
    /// 
    /// For information about how to specify characters other than a-z, 0-9, and
    /// - (hyphen) and how to specify internationalized domain names, see DNS Domain
    /// Name Format (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html)
    /// in the Amazon Route 53 Developer Guide.
    /// 
    /// You can use the asterisk (*) wildcard to replace the leftmost label in a
    /// domain name, for example, *.example.com. Note the following:
    /// 
    ///   - The * must replace the entire label. For example, you can&apos;t specify
    ///     *prod.example.com or prod*.example.com.
    /// 
    ///   - The * can&apos;t replace any of the middle labels, for example, marketing.*.example.com.
    /// 
    ///   - If you include * in any position other than the leftmost label in a
    ///     domain name, DNS treats it as an * character (ASCII 42), not as a wildcard.
    ///     You can&apos;t use the * wildcard for resource records sets that have a type
    ///     of NS.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The DNS record type. For information about different record types and how
    /// data is encoded for them, see Supported DNS Resource Record Types (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html)
    /// in the Amazon Route 53 Developer Guide.
    /// 
    /// Valid values for basic resource record sets: A | AAAA | CAA | CNAME | DS
    /// |MX | NAPTR | NS | PTR | SOA | SPF | SRV | TXT| TLSA| SSHFP| SVCB| HTTPS
    /// 
    /// Values for weighted, latency, geolocation, and failover resource record sets:
    /// A | AAAA | CAA | CNAME | MX | NAPTR | PTR | SPF | SRV | TXT| TLSA| SSHFP|
    /// SVCB| HTTPS. When creating a group of weighted, latency, geolocation, or
    /// failover resource record sets, specify the same value for all of the resource
    /// record sets in the group.
    /// 
    /// Valid values for multivalue answer resource record sets: A | AAAA | MX |
    /// NAPTR | PTR | SPF | SRV | TXT| CAA| TLSA| SSHFP| SVCB| HTTPS
    /// 
    /// SPF records were formerly used to verify the identity of the sender of email
    /// messages. However, we no longer recommend that you create resource record
    /// sets for which the value of Type is SPF. RFC 7208, Sender Policy Framework
    /// (SPF) for Authorizing Use of Domains in Email, Version 1, has been updated
    /// to say, &quot;...[I]ts existence and mechanism defined in [RFC4408] have led to
    /// some interoperability issues. Accordingly, its use is no longer appropriate
    /// for SPF version 1; implementations are not to use it.&quot; In RFC 7208, see section
    /// 14.1, The SPF DNS Record Type (http://tools.ietf.org/html/rfc7208#section-14.1).
    /// 
    /// Values for alias resource record sets:
    /// 
    ///   - Amazon API Gateway custom regional APIs and edge-optimized APIs: A
    /// 
    ///   - CloudFront distributions: A If IPv6 is enabled for the distribution,
    ///     create two resource record sets to route traffic to your distribution,
    ///     one with a value of A and one with a value of AAAA.
    /// 
    ///   - Amazon API Gateway environment that has a regionalized subdomain: A
    /// 
    ///   - ELB load balancers: A | AAAA
    /// 
    ///   - Amazon S3 buckets: A
    /// 
    ///   - Amazon Virtual Private Cloud interface VPC endpoints A
    /// 
    ///   - Another resource record set in this hosted zone: Specify the type of
    ///     the resource record set that you&apos;re creating the alias for. All values
    ///     are supported except NS and SOA. If you&apos;re creating an alias record that
    ///     has the same name as the hosted zone (known as the zone apex), you can&apos;t
    ///     route traffic to a record for which the value of Type is CNAME. This is
    ///     because the alias record must have the same type as the record you&apos;re
    ///     routing traffic to, and creating a CNAME record for the zone apex isn&apos;t
    ///     supported even for an alias record.
    /// </summary>
    [JsonPropertyName("recordType")]
    public required string RecordType { get; set; }

    /// <summary>
    /// Latency-based resource record sets only: The Amazon EC2 Region where you
    /// created the resource that this resource record set refers to. The resource
    /// typically is an Amazon Web Services resource, such as an EC2 instance or
    /// an ELB load balancer, and is referred to by an IP address or a DNS domain
    /// name, depending on the record type.
    /// 
    /// When Amazon Route 53 receives a DNS query for a domain name and type for
    /// which you have created latency resource record sets, Route 53 selects the
    /// latency resource record set that has the lowest latency between the end user
    /// and the associated Amazon EC2 Region. Route 53 then returns the value that
    /// is associated with the selected resource record set.
    /// 
    /// Note the following:
    /// 
    ///   - You can only specify one ResourceRecord per latency resource record
    ///     set.
    /// 
    ///   - You can only create one latency resource record set for each Amazon
    ///     EC2 Region.
    /// 
    ///   - You aren&apos;t required to create latency resource record sets for all Amazon
    ///     EC2 Regions. Route 53 will choose the region with the best latency from
    ///     among the regions that you create latency resource record sets for.
    /// 
    ///   - You can&apos;t create non-latency resource record sets that have the same
    ///     values for the Name and Type elements as latency resource record sets.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Information about the resource records to act upon.
    /// 
    /// If you&apos;re creating an alias resource record set, omit ResourceRecords.
    /// </summary>
    [JsonPropertyName("resourceRecords")]
    public IList<V1alpha1RecordSetSpecResourceRecords>? ResourceRecords { get; set; }

    /// <summary>
    /// Resource record sets that have a routing policy other than simple: An identifier
    /// that differentiates among multiple resource record sets that have the same
    /// combination of name and type, such as multiple weighted resource record sets
    /// named acme.example.com that have a type of A. In a group of resource record
    /// sets that have the same name and type, the value of SetIdentifier must be
    /// unique for each resource record set.
    /// 
    /// For information about routing policies, see Choosing a Routing Policy (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html)
    /// in the Amazon Route 53 Developer Guide.
    /// </summary>
    [JsonPropertyName("setIdentifier")]
    public string? SetIdentifier { get; set; }

    /// <summary>
    /// The resource record cache time to live (TTL), in seconds. Note the following:
    /// 
    ///   - If you&apos;re creating or updating an alias resource record set, omit TTL.
    ///     Amazon Route 53 uses the value of TTL for the alias target.
    /// 
    ///   - If you&apos;re associating this resource record set with a health check (if
    ///     you&apos;re adding a HealthCheckId element), we recommend that you specify
    ///     a TTL of 60 seconds or less so clients respond quickly to changes in health
    ///     status.
    /// 
    ///   - All of the resource record sets in a group of weighted resource record
    ///     sets must have the same value for TTL.
    /// 
    ///   - If a group of weighted resource record sets includes one or more weighted
    ///     alias resource record sets for which the alias target is an ELB load balancer,
    ///     we recommend that you specify a TTL of 60 seconds for all of the non-alias
    ///     weighted resource record sets that have the same name and type. Values
    ///     other than 60 seconds (the TTL for load balancers) will change the effect
    ///     of the values that you specify for Weight.
    /// </summary>
    [JsonPropertyName("ttl")]
    public long? Ttl { get; set; }

    /// <summary>
    /// Weighted resource record sets only: Among resource record sets that have
    /// the same combination of DNS name and type, a value that determines the proportion
    /// of DNS queries that Amazon Route 53 responds to using the current resource
    /// record set. Route 53 calculates the sum of the weights for the resource record
    /// sets that have the same combination of DNS name and type. Route 53 then responds
    /// to queries based on the ratio of a resource&apos;s weight to the total. Note the
    /// following:
    /// 
    ///   - You must specify a value for the Weight element for every weighted resource
    ///     record set.
    /// 
    ///   - You can only specify one ResourceRecord per weighted resource record
    ///     set.
    /// 
    ///   - You can&apos;t create latency, failover, or geolocation resource record sets
    ///     that have the same values for the Name and Type elements as weighted resource
    ///     record sets.
    /// 
    ///   - You can create a maximum of 100 weighted resource record sets that have
    ///     the same values for the Name and Type elements.
    /// 
    ///   - For weighted (but not weighted alias) resource record sets, if you set
    ///     Weight to 0 for a resource record set, Route 53 never responds to queries
    ///     with the applicable value for that resource record set. However, if you
    ///     set Weight to 0 for all resource record sets that have the same combination
    ///     of DNS name and type, traffic is routed to all resources with equal probability.
    ///     The effect of setting Weight to 0 is different when you associate health
    ///     checks with weighted resource record sets. For more information, see Options
    ///     for Configuring Route 53 Active-Active and Active-Passive Failover (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html)
    ///     in the Amazon Route 53 Developer Guide.
    /// </summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetStatusAckResourceMetadata
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
public partial class V1alpha1RecordSetStatusConditions
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

/// <summary>RecordSetStatus defines the observed state of RecordSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RecordSetStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RecordSetStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RecordSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// This element contains an ID that you use when performing a GetChange (https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetChange.html)
    /// action to get detailed information about the change.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The current state of the request. PENDING indicates that this request has
    /// not yet been applied to all Amazon Route 53 DNS servers.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The date and time that the change request was submitted in ISO 8601 format
    /// (https://en.wikipedia.org/wiki/ISO_8601) and Coordinated Universal Time (UTC).
    /// For example, the value 2017-03-27T17:48:16.751Z represents March 27, 2017
    /// at 17:48:16.751 UTC.
    /// </summary>
    [JsonPropertyName("submittedAt")]
    public DateTime? SubmittedAt { get; set; }
}

/// <summary>RecordSet is the Schema for the RecordSets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RecordSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RecordSetSpec?>, IStatus<V1alpha1RecordSetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RecordSet";
    public const string KubeGroup = "route53.services.k8s.aws";
    public const string KubePluralName = "recordsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecordSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecordSetSpec defines the desired state of RecordSet.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1RecordSetSpec? Spec { get; set; }

    /// <summary>RecordSetStatus defines the observed state of RecordSet</summary>
    [JsonPropertyName("status")]
    public V1alpha1RecordSetStatus? Status { get; set; }
}
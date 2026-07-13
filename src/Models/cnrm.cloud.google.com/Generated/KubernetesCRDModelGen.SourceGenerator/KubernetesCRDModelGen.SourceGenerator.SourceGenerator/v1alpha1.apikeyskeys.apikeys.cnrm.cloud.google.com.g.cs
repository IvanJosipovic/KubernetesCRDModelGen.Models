#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apikeys.cnrm.cloud.google.com;
/// <summary>APIKeysKey is the Schema for the APIKeysKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIKeysKeyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIKeysKey>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIKeysKeyList";
    public const string KubeGroup = "apikeys.cnrm.cloud.google.com";
    public const string KubePluralName = "apikeyskeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apikeys.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIKeysKeyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIKeysKey objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIKeysKey> Items { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecRestrictionsAndroidKeyRestrictionsAllowedApplications
{
    /// <summary>The package name of the application.</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>The SHA1 fingerprint of the application. For example, both sha1 formats are acceptable : DA:39:A3:EE:5E:6B:4B:0D:32:55:BF:EF:95:60:18:90:AF:D8:07:09 or DA39A3EE5E6B4B0D3255BFEF95601890AFD80709. Output format is the latter.</summary>
    [JsonPropertyName("sha1Fingerprint")]
    public string? Sha1Fingerprint { get; set; }
}

/// <summary>The Android apps that are allowed to use the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecRestrictionsAndroidKeyRestrictions
{
    /// <summary>A list of Android applications that are allowed to make API calls with this key.</summary>
    [JsonPropertyName("allowedApplications")]
    public IList<V1alpha1APIKeysKeySpecRestrictionsAndroidKeyRestrictionsAllowedApplications>? AllowedApplications { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecRestrictionsApiTargets
{
    /// <summary>Optional. List of one or more methods that can be called. If empty, all methods for the service are allowed. A wildcard (*) can be used as the last symbol. Valid examples: `google.cloud.translate.v2.TranslateService.GetSupportedLanguage` `TranslateText` `Get*` `translate.googleapis.com.Get*`</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>The service for this restriction. It should be the canonical service name, for example: `translate.googleapis.com`. You can use [`gcloud services list`](/sdk/gcloud/reference/services/list) to get a list of services that are enabled in the project.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>The HTTP referrers (websites) that are allowed to use the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecRestrictionsBrowserKeyRestrictions
{
    /// <summary>A list of regular expressions for the referrer URLs that are allowed to make API calls with this key.</summary>
    [JsonPropertyName("allowedReferrers")]
    public IList<string>? AllowedReferrers { get; set; }
}

/// <summary>The iOS apps that are allowed to use the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecRestrictionsIosKeyRestrictions
{
    /// <summary>A list of bundle IDs that are allowed when making API calls with this key.</summary>
    [JsonPropertyName("allowedBundleIds")]
    public IList<string>? AllowedBundleIds { get; set; }
}

/// <summary>The IP addresses of callers that are allowed to use the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecRestrictionsServerKeyRestrictions
{
    /// <summary>A list of the caller IP addresses that are allowed to make API calls with this key.</summary>
    [JsonPropertyName("allowedIps")]
    public IList<string>? AllowedIps { get; set; }
}

/// <summary>Key restrictions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpecRestrictions
{
    /// <summary>The Android apps that are allowed to use the key.</summary>
    [JsonPropertyName("androidKeyRestrictions")]
    public V1alpha1APIKeysKeySpecRestrictionsAndroidKeyRestrictions? AndroidKeyRestrictions { get; set; }

    /// <summary>A restriction for a specific service and optionally one or more specific methods. Requests are allowed if they match any of these restrictions. If no restrictions are specified, all targets are allowed.</summary>
    [JsonPropertyName("apiTargets")]
    public IList<V1alpha1APIKeysKeySpecRestrictionsApiTargets>? ApiTargets { get; set; }

    /// <summary>The HTTP referrers (websites) that are allowed to use the key.</summary>
    [JsonPropertyName("browserKeyRestrictions")]
    public V1alpha1APIKeysKeySpecRestrictionsBrowserKeyRestrictions? BrowserKeyRestrictions { get; set; }

    /// <summary>The iOS apps that are allowed to use the key.</summary>
    [JsonPropertyName("iosKeyRestrictions")]
    public V1alpha1APIKeysKeySpecRestrictionsIosKeyRestrictions? IosKeyRestrictions { get; set; }

    /// <summary>The IP addresses of callers that are allowed to use the key.</summary>
    [JsonPropertyName("serverKeyRestrictions")]
    public V1alpha1APIKeysKeySpecRestrictionsServerKeyRestrictions? ServerKeyRestrictions { get; set; }
}

/// <summary>APIKeysKeySpec defines the desired state of APIKeysKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeySpec
{
    /// <summary>Human-readable display name of this key that you can modify. The maximum length is 63 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1APIKeysKeySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Key restrictions.</summary>
    [JsonPropertyName("restrictions")]
    public V1alpha1APIKeysKeySpecRestrictions? Restrictions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeyStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeyStatusObservedState
{
    /// <summary>Output only. Unique id in UUID4 format.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>APIKeysKeyStatus defines the config connector machine state of APIKeysKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIKeysKeyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIKeysKeyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the APIKeysKey resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1APIKeysKeyStatusObservedState? ObservedState { get; set; }
}

/// <summary>APIKeysKey is the Schema for the APIKeysKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIKeysKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIKeysKeySpec>, IStatus<V1alpha1APIKeysKeyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIKeysKey";
    public const string KubeGroup = "apikeys.cnrm.cloud.google.com";
    public const string KubePluralName = "apikeyskeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apikeys.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIKeysKey";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIKeysKeySpec defines the desired state of APIKeysKey</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1APIKeysKeySpec Spec { get; set; }

    /// <summary>APIKeysKeyStatus defines the config connector machine state of APIKeysKey</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIKeysKeyStatus? Status { get; set; }
}
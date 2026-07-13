#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.billing.cnrm.cloud.google.com;
/// <summary>BillingAccount is the Schema for the BillingAccount API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BillingAccountList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BillingAccount>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BillingAccountList";
    public const string KubeGroup = "billing.cnrm.cloud.google.com";
    public const string KubePluralName = "billingaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "billing.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BillingAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BillingAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BillingAccount> Items { get; set; }
}

/// <summary>Optional. The billing account&apos;s parent resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BillingAccountSpecParentRef
{
    /// <summary>A reference to an externally managed BillingAccount resource. Should be in the format &quot;billingAccounts/{billingAccountID}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BillingAccount resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BillingAccount resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BillingAccountSpec defines the desired state of BillingAccount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BillingAccountSpec
{
    /// <summary>
    /// Optional. The currency in which the billing account is billed and charged,
    ///  represented as an ISO 4217 code such as `USD`.
    /// 
    ///  Billing account currency is determined at the time of billing account
    ///  creation and cannot be updated subsequently, so this field should not be
    ///  set on update requests. In addition, a subaccount always matches the
    ///  currency of its parent billing account, so this field should not be set on
    ///  subaccounts. Clients can read this field to determine the
    ///  currency of an existing billing account.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; set; }

    /// <summary>The display name given to the billing account, such as `My Billing Account`. This name is displayed in the Google Cloud Console.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. The billing account&apos;s parent resource.</summary>
    [JsonPropertyName("parentRef")]
    public V1alpha1BillingAccountSpecParentRef? ParentRef { get; set; }

    /// <summary>The BillingAccount name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BillingAccountStatusConditions
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
public partial class V1alpha1BillingAccountStatusObservedState
{
    /// <summary>Optional. The currency in which the billing account is billed and charged, represented as an ISO 4217 code such as `USD`.</summary>
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; set; }

    /// <summary>If this account is a [subaccount](https://cloud.google.com/billing/docs/concepts), then this will be the resource name of the parent billing account that it is being resold through. Otherwise this will be empty.</summary>
    [JsonPropertyName("masterBillingAccount")]
    public string? MasterBillingAccount { get; set; }

    /// <summary>Output only. The resource name of the billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF` would be the resource name for billing account `012345-567890-ABCDEF`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. True if the billing account is open, and will therefore be charged for any usage on associated projects. False if the billing account is closed, and therefore projects associated with it are unable to use paid services.</summary>
    [JsonPropertyName("open")]
    public bool? Open { get; set; }
}

/// <summary>BillingAccountStatus defines the config connector machine state of BillingAccount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BillingAccountStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BillingAccountStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BillingAccount resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BillingAccountStatusObservedState? ObservedState { get; set; }
}

/// <summary>BillingAccount is the Schema for the BillingAccount API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BillingAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BillingAccountSpec>, IStatus<V1alpha1BillingAccountStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BillingAccount";
    public const string KubeGroup = "billing.cnrm.cloud.google.com";
    public const string KubePluralName = "billingaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "billing.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BillingAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BillingAccountSpec defines the desired state of BillingAccount</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BillingAccountSpec Spec { get; set; }

    /// <summary>BillingAccountStatus defines the config connector machine state of BillingAccount</summary>
    [JsonPropertyName("status")]
    public V1alpha1BillingAccountStatus? Status { get; set; }
}
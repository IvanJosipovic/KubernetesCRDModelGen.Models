#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.managed.vault.upbound.io;
/// <summary>Keys is the Schema for the Keyss API. Configures Managed Keys in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KeysList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Keys>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KeysList";
    public const string KubeGroup = "managed.vault.upbound.io";
    public const string KubePluralName = "keys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "managed.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KeysList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Keys objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Keys> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1KeysSpecDeletionPolicyEnum>))]
public enum V1alpha1KeysSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecForProviderAws
{
    /// <summary>
    /// The AWS access key to use.
    /// The AWS access key to use
    /// </summary>
    [JsonPropertyName("accessKey")]
    public string? AccessKey { get; set; }

    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The curve to use for an ECDSA key. Used when key_type
    /// is ECDSA. Required if allow_generate_key is true.
    /// The curve to use for an ECDSA key. Used when key_type is &apos;ECDSA&apos;. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>
    /// Used to specify a custom AWS endpoint.
    /// Used to specify a custom AWS endpoint
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// The size in bits for an RSA key. This field is required when &apos;key_type&apos; is &apos;RSA&apos;
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The type of key to use.
    /// The type of key to use
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// An identifier for the key.
    /// An identifier for the key
    /// </summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AWS region where the keys are stored (or will be stored).
    /// The AWS region where the keys are stored (or will be stored)
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The AWS access key to use.
    /// The AWS secret key to use
    /// </summary>
    [JsonPropertyName("secretKey")]
    public string? SecretKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecForProviderAzure
{
    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The client id for credentials to query the Azure APIs.
    /// The client id for credentials to query the Azure APIs
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret for credentials to query the Azure APIs.
    /// The client secret for credentials to query the Azure APIs
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>
    /// The Azure Cloud environment API endpoints to use.
    /// The Azure Cloud environment API endpoints to use
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// The size in bits for an RSA key. This field is required when &apos;key_type&apos; is &apos;RSA&apos; or when &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The Key Vault key to use for encryption and decryption.
    /// The Key Vault key to use for encryption and decryption
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// The type of key to use.
    /// The type of key to use
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The Azure Key Vault resource&apos;s DNS Suffix to connect to.
    /// The Azure Key Vault resource&apos;s DNS Suffix to connect to
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// The tenant id for the Azure Active Directory organization.
    /// The tenant id for the Azure Active Directory organization
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// The Key Vault vault to use for encryption and decryption.
    /// The Key Vault vault to use the encryption keys for encryption and decryption
    /// </summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecForProviderGcp
{
    /// <summary>
    /// The signature algorithm to be used with the key. Supported values are:
    /// The signature algorithm to be used with the key. Supported values: ec_sign_p256_sha256, ec_sign_p384_sha384, rsa_sign_pss_2048_sha256, rsa_sign_pss_3072_sha256, rsa_sign_pss_4096_sha256, rsa_sign_pss_4096_sha512, rsa_sign_pkcs1_2048_sha256, rsa_sign_pkcs1_3072_sha256, rsa_sign_pkcs1_4096_sha256, rsa_sign_pkcs1_4096_sha512
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The GCP service account credentials JSON contents (the raw JSON
    /// key data), not a path to a credentials file.
    /// The GCP service account credentials JSON to use for authenticating to GCP.
    /// </summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>
    /// The name of the Cloud KMS crypto key to use.
    /// The name of the GCP Cloud KMS key. If no existing key exists and allow_generate_key is true, Vault will generate a key with this name
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public string? CryptoKey { get; set; }

    /// <summary>
    /// The version of the key to use. (Default: 1)
    /// The version of the key to use. (Default: 1)
    /// </summary>
    [JsonPropertyName("cryptoKeyVersion")]
    public string? CryptoKeyVersion { get; set; }

    /// <summary>
    /// The name of the Cloud KMS key ring.
    /// The name of the key ring in GCP Cloud KMS. This needs to be created prior to key creation
    /// </summary>
    [JsonPropertyName("keyRing")]
    public string? KeyRing { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The GCP project ID where the Cloud KMS resources are located.
    /// The GCP project ID.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The AWS region where the keys are stored (or will be stored).
    /// The GCP region where the key ring was created.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecForProviderPkcs
{
    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The curve to use for an ECDSA key. Used when key_type
    /// is ECDSA. Required if allow_generate_key is true.
    /// Supplies the curve value when using the &apos;CKM_ECDSA&apos; mechanism. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>
    /// Force all operations to open up a read-write session to
    /// the HSM.
    /// Force all operations to open up a read-write session to the HSM
    /// </summary>
    [JsonPropertyName("forceRwSession")]
    public string? ForceRwSession { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// Supplies the size in bits of the key when using &apos;CKM_RSA_PKCS_PSS&apos;, &apos;CKM_RSA_PKCS_OAEP&apos; or &apos;CKM_RSA_PKCS&apos; as a value for &apos;mechanism&apos;. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The id of a PKCS#11 key to use.
    /// The id of a PKCS#11 key to use
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// The label of the key to use.
    /// The label of the key to use
    /// </summary>
    [JsonPropertyName("keyLabel")]
    public string? KeyLabel { get; set; }

    /// <summary>
    /// The name of the kms_library stanza to use from Vault&apos;s config
    /// to lookup the local library path.
    /// The name of the kms_library stanza to use from Vault&apos;s config to lookup the local library path
    /// </summary>
    [JsonPropertyName("library")]
    public string? Library { get; set; }

    /// <summary>
    /// The encryption/decryption mechanism to use, specified as a
    /// hexadecimal (prefixed by 0x) string.
    /// The encryption/decryption mechanism to use, specified as a hexadecimal (prefixed by 0x) string.
    /// </summary>
    [JsonPropertyName("mechanism")]
    public string? Mechanism { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The PIN for login.
    /// The PIN for login
    /// </summary>
    [JsonPropertyName("pin")]
    public string? Pin { get; set; }

    /// <summary>
    /// The slot number to use, specified as a string in a decimal format
    /// (e.g. 2305843009213693953).
    /// The slot number to use, specified as a string in a decimal format (e.g. &apos;2305843009213693953&apos;)
    /// </summary>
    [JsonPropertyName("slot")]
    public string? Slot { get; set; }

    /// <summary>
    /// The slot token label to use.
    /// The slot token label to use
    /// </summary>
    [JsonPropertyName("tokenLabel")]
    public string? TokenLabel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecForProvider
{
    /// <summary>Configuration block for AWS Managed Keys</summary>
    [JsonPropertyName("aws")]
    public IList<V1alpha1KeysSpecForProviderAws>? Aws { get; set; }

    /// <summary>Configuration block for Azure Managed Keys</summary>
    [JsonPropertyName("azure")]
    public IList<V1alpha1KeysSpecForProviderAzure>? Azure { get; set; }

    /// <summary>Configuration block for GCP Cloud KMS Managed Keys</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1KeysSpecForProviderGcp>? Gcp { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Configuration block for PKCS Managed Keys</summary>
    [JsonPropertyName("pkcs")]
    public IList<V1alpha1KeysSpecForProviderPkcs>? Pkcs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecInitProviderAws
{
    /// <summary>
    /// The AWS access key to use.
    /// The AWS access key to use
    /// </summary>
    [JsonPropertyName("accessKey")]
    public string? AccessKey { get; set; }

    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The curve to use for an ECDSA key. Used when key_type
    /// is ECDSA. Required if allow_generate_key is true.
    /// The curve to use for an ECDSA key. Used when key_type is &apos;ECDSA&apos;. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>
    /// Used to specify a custom AWS endpoint.
    /// Used to specify a custom AWS endpoint
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// The size in bits for an RSA key. This field is required when &apos;key_type&apos; is &apos;RSA&apos;
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The type of key to use.
    /// The type of key to use
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// An identifier for the key.
    /// An identifier for the key
    /// </summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AWS region where the keys are stored (or will be stored).
    /// The AWS region where the keys are stored (or will be stored)
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The AWS access key to use.
    /// The AWS secret key to use
    /// </summary>
    [JsonPropertyName("secretKey")]
    public string? SecretKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecInitProviderAzure
{
    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The client id for credentials to query the Azure APIs.
    /// The client id for credentials to query the Azure APIs
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret for credentials to query the Azure APIs.
    /// The client secret for credentials to query the Azure APIs
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>
    /// The Azure Cloud environment API endpoints to use.
    /// The Azure Cloud environment API endpoints to use
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// The size in bits for an RSA key. This field is required when &apos;key_type&apos; is &apos;RSA&apos; or when &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The Key Vault key to use for encryption and decryption.
    /// The Key Vault key to use for encryption and decryption
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// The type of key to use.
    /// The type of key to use
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The Azure Key Vault resource&apos;s DNS Suffix to connect to.
    /// The Azure Key Vault resource&apos;s DNS Suffix to connect to
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// The tenant id for the Azure Active Directory organization.
    /// The tenant id for the Azure Active Directory organization
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// The Key Vault vault to use for encryption and decryption.
    /// The Key Vault vault to use the encryption keys for encryption and decryption
    /// </summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecInitProviderGcp
{
    /// <summary>
    /// The signature algorithm to be used with the key. Supported values are:
    /// The signature algorithm to be used with the key. Supported values: ec_sign_p256_sha256, ec_sign_p384_sha384, rsa_sign_pss_2048_sha256, rsa_sign_pss_3072_sha256, rsa_sign_pss_4096_sha256, rsa_sign_pss_4096_sha512, rsa_sign_pkcs1_2048_sha256, rsa_sign_pkcs1_3072_sha256, rsa_sign_pkcs1_4096_sha256, rsa_sign_pkcs1_4096_sha512
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The GCP service account credentials JSON contents (the raw JSON
    /// key data), not a path to a credentials file.
    /// The GCP service account credentials JSON to use for authenticating to GCP.
    /// </summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>
    /// The name of the Cloud KMS crypto key to use.
    /// The name of the GCP Cloud KMS key. If no existing key exists and allow_generate_key is true, Vault will generate a key with this name
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public string? CryptoKey { get; set; }

    /// <summary>
    /// The version of the key to use. (Default: 1)
    /// The version of the key to use. (Default: 1)
    /// </summary>
    [JsonPropertyName("cryptoKeyVersion")]
    public string? CryptoKeyVersion { get; set; }

    /// <summary>
    /// The name of the Cloud KMS key ring.
    /// The name of the key ring in GCP Cloud KMS. This needs to be created prior to key creation
    /// </summary>
    [JsonPropertyName("keyRing")]
    public string? KeyRing { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The GCP project ID where the Cloud KMS resources are located.
    /// The GCP project ID.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The AWS region where the keys are stored (or will be stored).
    /// The GCP region where the key ring was created.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecInitProviderPkcs
{
    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The curve to use for an ECDSA key. Used when key_type
    /// is ECDSA. Required if allow_generate_key is true.
    /// Supplies the curve value when using the &apos;CKM_ECDSA&apos; mechanism. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>
    /// Force all operations to open up a read-write session to
    /// the HSM.
    /// Force all operations to open up a read-write session to the HSM
    /// </summary>
    [JsonPropertyName("forceRwSession")]
    public string? ForceRwSession { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// Supplies the size in bits of the key when using &apos;CKM_RSA_PKCS_PSS&apos;, &apos;CKM_RSA_PKCS_OAEP&apos; or &apos;CKM_RSA_PKCS&apos; as a value for &apos;mechanism&apos;. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The id of a PKCS#11 key to use.
    /// The id of a PKCS#11 key to use
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// The label of the key to use.
    /// The label of the key to use
    /// </summary>
    [JsonPropertyName("keyLabel")]
    public string? KeyLabel { get; set; }

    /// <summary>
    /// The name of the kms_library stanza to use from Vault&apos;s config
    /// to lookup the local library path.
    /// The name of the kms_library stanza to use from Vault&apos;s config to lookup the local library path
    /// </summary>
    [JsonPropertyName("library")]
    public string? Library { get; set; }

    /// <summary>
    /// The encryption/decryption mechanism to use, specified as a
    /// hexadecimal (prefixed by 0x) string.
    /// The encryption/decryption mechanism to use, specified as a hexadecimal (prefixed by 0x) string.
    /// </summary>
    [JsonPropertyName("mechanism")]
    public string? Mechanism { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The PIN for login.
    /// The PIN for login
    /// </summary>
    [JsonPropertyName("pin")]
    public string? Pin { get; set; }

    /// <summary>
    /// The slot number to use, specified as a string in a decimal format
    /// (e.g. 2305843009213693953).
    /// The slot number to use, specified as a string in a decimal format (e.g. &apos;2305843009213693953&apos;)
    /// </summary>
    [JsonPropertyName("slot")]
    public string? Slot { get; set; }

    /// <summary>
    /// The slot token label to use.
    /// The slot token label to use
    /// </summary>
    [JsonPropertyName("tokenLabel")]
    public string? TokenLabel { get; set; }
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
public partial class V1alpha1KeysSpecInitProvider
{
    /// <summary>Configuration block for AWS Managed Keys</summary>
    [JsonPropertyName("aws")]
    public IList<V1alpha1KeysSpecInitProviderAws>? Aws { get; set; }

    /// <summary>Configuration block for Azure Managed Keys</summary>
    [JsonPropertyName("azure")]
    public IList<V1alpha1KeysSpecInitProviderAzure>? Azure { get; set; }

    /// <summary>Configuration block for GCP Cloud KMS Managed Keys</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1KeysSpecInitProviderGcp>? Gcp { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Configuration block for PKCS Managed Keys</summary>
    [JsonPropertyName("pkcs")]
    public IList<V1alpha1KeysSpecInitProviderPkcs>? Pkcs { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1KeysSpecManagementPoliciesEnum>))]
public enum V1alpha1KeysSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1KeysSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1KeysSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1KeysSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1KeysSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1KeysSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1KeysSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1KeysSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>KeysSpec defines the desired state of Keys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysSpec
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
    public V1alpha1KeysSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1KeysSpecForProvider ForProvider { get; set; }

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
    public V1alpha1KeysSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1KeysSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1KeysSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1KeysSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysStatusAtProviderAws
{
    /// <summary>
    /// The AWS access key to use.
    /// The AWS access key to use
    /// </summary>
    [JsonPropertyName("accessKey")]
    public string? AccessKey { get; set; }

    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The curve to use for an ECDSA key. Used when key_type
    /// is ECDSA. Required if allow_generate_key is true.
    /// The curve to use for an ECDSA key. Used when key_type is &apos;ECDSA&apos;. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>
    /// Used to specify a custom AWS endpoint.
    /// Used to specify a custom AWS endpoint
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// The size in bits for an RSA key. This field is required when &apos;key_type&apos; is &apos;RSA&apos;
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The type of key to use.
    /// The type of key to use
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// An identifier for the key.
    /// An identifier for the key
    /// </summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The AWS region where the keys are stored (or will be stored).
    /// The AWS region where the keys are stored (or will be stored)
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The AWS access key to use.
    /// The AWS secret key to use
    /// </summary>
    [JsonPropertyName("secretKey")]
    public string? SecretKey { get; set; }

    /// <summary>ID of the managed key read from Vault</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysStatusAtProviderAzure
{
    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The client id for credentials to query the Azure APIs.
    /// The client id for credentials to query the Azure APIs
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret for credentials to query the Azure APIs.
    /// The client secret for credentials to query the Azure APIs
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>
    /// The Azure Cloud environment API endpoints to use.
    /// The Azure Cloud environment API endpoints to use
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// The size in bits for an RSA key. This field is required when &apos;key_type&apos; is &apos;RSA&apos; or when &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The Key Vault key to use for encryption and decryption.
    /// The Key Vault key to use for encryption and decryption
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// The type of key to use.
    /// The type of key to use
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The Azure Key Vault resource&apos;s DNS Suffix to connect to.
    /// The Azure Key Vault resource&apos;s DNS Suffix to connect to
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// The tenant id for the Azure Active Directory organization.
    /// The tenant id for the Azure Active Directory organization
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>ID of the managed key read from Vault</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// The Key Vault vault to use for encryption and decryption.
    /// The Key Vault vault to use the encryption keys for encryption and decryption
    /// </summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysStatusAtProviderGcp
{
    /// <summary>
    /// The signature algorithm to be used with the key. Supported values are:
    /// The signature algorithm to be used with the key. Supported values: ec_sign_p256_sha256, ec_sign_p384_sha384, rsa_sign_pss_2048_sha256, rsa_sign_pss_3072_sha256, rsa_sign_pss_4096_sha256, rsa_sign_pss_4096_sha512, rsa_sign_pkcs1_2048_sha256, rsa_sign_pkcs1_3072_sha256, rsa_sign_pkcs1_4096_sha256, rsa_sign_pkcs1_4096_sha512
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The GCP service account credentials JSON contents (the raw JSON
    /// key data), not a path to a credentials file.
    /// The GCP service account credentials JSON to use for authenticating to GCP.
    /// </summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>
    /// The name of the Cloud KMS crypto key to use.
    /// The name of the GCP Cloud KMS key. If no existing key exists and allow_generate_key is true, Vault will generate a key with this name
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public string? CryptoKey { get; set; }

    /// <summary>
    /// The version of the key to use. (Default: 1)
    /// The version of the key to use. (Default: 1)
    /// </summary>
    [JsonPropertyName("cryptoKeyVersion")]
    public string? CryptoKeyVersion { get; set; }

    /// <summary>
    /// The name of the Cloud KMS key ring.
    /// The name of the key ring in GCP Cloud KMS. This needs to be created prior to key creation
    /// </summary>
    [JsonPropertyName("keyRing")]
    public string? KeyRing { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The GCP project ID where the Cloud KMS resources are located.
    /// The GCP project ID.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The AWS region where the keys are stored (or will be stored).
    /// The GCP region where the key ring was created.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ID of the managed key read from Vault</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysStatusAtProviderPkcs
{
    /// <summary>
    /// If no existing key can be found in
    /// the referenced backend, instructs Vault to generate a key within the backend.
    /// If no existing key can be found in the referenced backend, instructs Vault to generate a key within the backend
    /// </summary>
    [JsonPropertyName("allowGenerateKey")]
    public bool? AllowGenerateKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to replace through
    /// generation or importing a key into the configured backend even
    /// if a key is present, if set to false those operations are forbidden
    /// if a key exists.
    /// Controls the ability for Vault to replace through generation or importing a key into the configured backend even if a key is present, if set to false those operations are forbidden if a key exists.
    /// </summary>
    [JsonPropertyName("allowReplaceKey")]
    public bool? AllowReplaceKey { get; set; }

    /// <summary>
    /// Controls the ability for Vault to import a key to the
    /// configured backend, if false, those operations will be forbidden.
    /// Controls the ability for Vault to import a key to the configured backend, if &apos;false&apos;, those operations will be forbidden
    /// </summary>
    [JsonPropertyName("allowStoreKey")]
    public bool? AllowStoreKey { get; set; }

    /// <summary>
    /// If true, allows usage from any mount point within the
    /// namespace.
    /// Allow usage from any mount point within the namespace if &apos;true&apos;
    /// </summary>
    [JsonPropertyName("anyMount")]
    public bool? AnyMount { get; set; }

    /// <summary>
    /// The curve to use for an ECDSA key. Used when key_type
    /// is ECDSA. Required if allow_generate_key is true.
    /// Supplies the curve value when using the &apos;CKM_ECDSA&apos; mechanism. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>
    /// Force all operations to open up a read-write session to
    /// the HSM.
    /// Force all operations to open up a read-write session to the HSM
    /// </summary>
    [JsonPropertyName("forceRwSession")]
    public string? ForceRwSession { get; set; }

    /// <summary>
    /// The size in bits for an RSA key.
    /// Supplies the size in bits of the key when using &apos;CKM_RSA_PKCS_PSS&apos;, &apos;CKM_RSA_PKCS_OAEP&apos; or &apos;CKM_RSA_PKCS&apos; as a value for &apos;mechanism&apos;. Required if &apos;allow_generate_key&apos; is true
    /// </summary>
    [JsonPropertyName("keyBits")]
    public string? KeyBits { get; set; }

    /// <summary>
    /// The id of a PKCS#11 key to use.
    /// The id of a PKCS#11 key to use
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// The label of the key to use.
    /// The label of the key to use
    /// </summary>
    [JsonPropertyName("keyLabel")]
    public string? KeyLabel { get; set; }

    /// <summary>
    /// The name of the kms_library stanza to use from Vault&apos;s config
    /// to lookup the local library path.
    /// The name of the kms_library stanza to use from Vault&apos;s config to lookup the local library path
    /// </summary>
    [JsonPropertyName("library")]
    public string? Library { get; set; }

    /// <summary>
    /// The encryption/decryption mechanism to use, specified as a
    /// hexadecimal (prefixed by 0x) string.
    /// The encryption/decryption mechanism to use, specified as a hexadecimal (prefixed by 0x) string.
    /// </summary>
    [JsonPropertyName("mechanism")]
    public string? Mechanism { get; set; }

    /// <summary>
    /// A unique lowercase name that serves as identifying the key.
    /// A unique lowercase name that serves as identifying the key
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The PIN for login.
    /// The PIN for login
    /// </summary>
    [JsonPropertyName("pin")]
    public string? Pin { get; set; }

    /// <summary>
    /// The slot number to use, specified as a string in a decimal format
    /// (e.g. 2305843009213693953).
    /// The slot number to use, specified as a string in a decimal format (e.g. &apos;2305843009213693953&apos;)
    /// </summary>
    [JsonPropertyName("slot")]
    public string? Slot { get; set; }

    /// <summary>
    /// The slot token label to use.
    /// The slot token label to use
    /// </summary>
    [JsonPropertyName("tokenLabel")]
    public string? TokenLabel { get; set; }

    /// <summary>ID of the managed key read from Vault</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysStatusAtProvider
{
    /// <summary>Configuration block for AWS Managed Keys</summary>
    [JsonPropertyName("aws")]
    public IList<V1alpha1KeysStatusAtProviderAws>? Aws { get; set; }

    /// <summary>Configuration block for Azure Managed Keys</summary>
    [JsonPropertyName("azure")]
    public IList<V1alpha1KeysStatusAtProviderAzure>? Azure { get; set; }

    /// <summary>Configuration block for GCP Cloud KMS Managed Keys</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1KeysStatusAtProviderGcp>? Gcp { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Configuration block for PKCS Managed Keys</summary>
    [JsonPropertyName("pkcs")]
    public IList<V1alpha1KeysStatusAtProviderPkcs>? Pkcs { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysStatusConditions
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

/// <summary>KeysStatus defines the observed state of Keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeysStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1KeysStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1KeysStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Keys is the Schema for the Keyss API. Configures Managed Keys in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Keys : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1KeysSpec>, IStatus<V1alpha1KeysStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Keys";
    public const string KubeGroup = "managed.vault.upbound.io";
    public const string KubePluralName = "keys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "managed.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Keys";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KeysSpec defines the desired state of Keys</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1KeysSpec Spec { get; set; }

    /// <summary>KeysStatus defines the observed state of Keys.</summary>
    [JsonPropertyName("status")]
    public V1alpha1KeysStatus? Status { get; set; }
}
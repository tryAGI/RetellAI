
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsDestinationVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsDestinationVariant2TypeJsonConverter))]
        public global::RetellAI.SmsDestinationVariant2Type Type { get; set; }

        /// <summary>
        /// Destination phone number in E.164 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// If true, skip E.164 validation for this phone number (same semantics as transfer_call ignore_e164_validation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_e164_validation")]
        public bool? IgnoreE164Validation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsDestinationVariant2" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Destination phone number in E.164 format.
        /// </param>
        /// <param name="type"></param>
        /// <param name="ignoreE164Validation">
        /// If true, skip E.164 validation for this phone number (same semantics as transfer_call ignore_e164_validation).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsDestinationVariant2(
            string phoneNumber,
            global::RetellAI.SmsDestinationVariant2Type type,
            bool? ignoreE164Validation)
        {
            this.Type = type;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.IgnoreE164Validation = ignoreE164Validation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsDestinationVariant2" /> class.
        /// </summary>
        public SmsDestinationVariant2()
        {
        }
    }
}
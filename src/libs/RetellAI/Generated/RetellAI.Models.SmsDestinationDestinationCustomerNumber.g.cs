
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SmsDestinationDestinationCustomerNumber
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsDestinationDestinationCustomerNumberTypeJsonConverter))]
        public global::RetellAI.SmsDestinationDestinationCustomerNumberType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsDestinationDestinationCustomerNumber" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsDestinationDestinationCustomerNumber(
            global::RetellAI.SmsDestinationDestinationCustomerNumberType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsDestinationDestinationCustomerNumber" /> class.
        /// </summary>
        public SmsDestinationDestinationCustomerNumber()
        {
        }

    }
}
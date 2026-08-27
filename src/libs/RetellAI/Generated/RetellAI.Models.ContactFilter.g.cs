
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filter criteria for contacts. All conditions are implicitly connected with AND. first_name and last_name are not filterable here; use search_query to match on those.
    /// </summary>
    public sealed partial class ContactFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        public global::RetellAI.StringFilter? ContactId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public global::RetellAI.StringFilter? PhoneNumber { get; set; }

        /// <summary>
        /// Filter by the record id in the connected CRM. Use a `present` filter to separate synced from unsynced contacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>? ExternalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_call")]
        public global::RetellAI.BooleanFilter? DoNotCall { get; set; }

        /// <summary>
        /// Filter by when the contact was last spoken to, in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversation_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? LastConversationTimestamp { get; set; }

        /// <summary>
        /// Filter by custom contact fields defined in CRM config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_fields")]
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? CustomFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactFilter" /> class.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="externalId">
        /// Filter by the record id in the connected CRM. Use a `present` filter to separate synced from unsynced contacts.
        /// </param>
        /// <param name="doNotCall"></param>
        /// <param name="lastConversationTimestamp">
        /// Filter by when the contact was last spoken to, in epoch milliseconds.
        /// </param>
        /// <param name="customFields">
        /// Filter by custom contact fields defined in CRM config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactFilter(
            global::RetellAI.StringFilter? contactId,
            global::RetellAI.StringFilter? phoneNumber,
            global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.PresentFilter>? externalId,
            global::RetellAI.BooleanFilter? doNotCall,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? lastConversationTimestamp,
            global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? customFields)
        {
            this.ContactId = contactId;
            this.PhoneNumber = phoneNumber;
            this.ExternalId = externalId;
            this.DoNotCall = doNotCall;
            this.LastConversationTimestamp = lastConversationTimestamp;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactFilter" /> class.
        /// </summary>
        public ContactFilter()
        {
        }

    }
}
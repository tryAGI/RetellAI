
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Contact
    {
        /// <summary>
        /// Unique identifier for the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContactId { get; set; }

        /// <summary>
        /// Organization this contact belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Phone number of the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// First name of the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Whether this contact should not be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_call")]
        public bool? DoNotCall { get; set; }

        /// <summary>
        /// CRM record ID from the external provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Tags assigned to the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Custom fields defined in CRM config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_fields")]
        public object? CustomFields { get; set; }

        /// <summary>
        /// Number of conversations (calls and chats) associated with this contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        public double? ConversationCount { get; set; }

        /// <summary>
        /// Epoch milliseconds of the most recent conversation with this contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversation_timestamp")]
        public double? LastConversationTimestamp { get; set; }

        /// <summary>
        /// Epoch milliseconds when the contact was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedTimestamp { get; set; }

        /// <summary>
        /// Epoch milliseconds when the contact was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        public double? UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="contactId">
        /// Unique identifier for the contact.
        /// </param>
        /// <param name="orgId">
        /// Organization this contact belongs to.
        /// </param>
        /// <param name="phoneNumber">
        /// Phone number of the contact.
        /// </param>
        /// <param name="createdTimestamp">
        /// Epoch milliseconds when the contact was created.
        /// </param>
        /// <param name="firstName">
        /// First name of the contact.
        /// </param>
        /// <param name="lastName">
        /// Last name of the contact.
        /// </param>
        /// <param name="doNotCall">
        /// Whether this contact should not be called.
        /// </param>
        /// <param name="externalId">
        /// CRM record ID from the external provider.
        /// </param>
        /// <param name="tags">
        /// Tags assigned to the contact.
        /// </param>
        /// <param name="customFields">
        /// Custom fields defined in CRM config.
        /// </param>
        /// <param name="conversationCount">
        /// Number of conversations (calls and chats) associated with this contact.
        /// </param>
        /// <param name="lastConversationTimestamp">
        /// Epoch milliseconds of the most recent conversation with this contact.
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// Epoch milliseconds when the contact was last modified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Contact(
            string contactId,
            string orgId,
            string phoneNumber,
            double createdTimestamp,
            string? firstName,
            string? lastName,
            bool? doNotCall,
            string? externalId,
            global::System.Collections.Generic.IList<string>? tags,
            object? customFields,
            double? conversationCount,
            double? lastConversationTimestamp,
            double? userModifiedTimestamp)
        {
            this.ContactId = contactId ?? throw new global::System.ArgumentNullException(nameof(contactId));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DoNotCall = doNotCall;
            this.ExternalId = externalId;
            this.Tags = tags;
            this.CustomFields = customFields;
            this.ConversationCount = conversationCount;
            this.LastConversationTimestamp = lastConversationTimestamp;
            this.CreatedTimestamp = createdTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        public Contact()
        {
        }

    }
}
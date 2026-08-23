
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactRequest
    {
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_call")]
        public bool? DoNotCall { get; set; }

        /// <summary>
        /// Values must match the types defined in CRM config custom fields. Set a value to null to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_fields")]
        public object? CustomFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactRequest" /> class.
        /// </summary>
        /// <param name="firstName">
        /// First name of the contact.
        /// </param>
        /// <param name="lastName">
        /// Last name of the contact.
        /// </param>
        /// <param name="doNotCall"></param>
        /// <param name="customFields">
        /// Values must match the types defined in CRM config custom fields. Set a value to null to clear it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactRequest(
            string? firstName,
            string? lastName,
            bool? doNotCall,
            object? customFields)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DoNotCall = doNotCall;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactRequest" /> class.
        /// </summary>
        public UpdateContactRequest()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Independently selectable handbook prompts for chat agents. Voice-only handbooks are excluded. Phase 1 accepts legacy booleans in requests, but responses always return the object form.
    /// </summary>
    public sealed partial class ChatHandbookConfig
    {
        /// <summary>
        /// Configuration for an enabled handbook. Omit custom_prompt or set it to null to use the Retell-provided prompt. An empty string intentionally injects no prompt for this handbook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_support")]
        public global::RetellAI.HandbookEntryConfig? CustomerSupport { get; set; }

        /// <summary>
        /// Configuration for an enabled handbook. Omit custom_prompt or set it to null to use the Retell-provided prompt. An empty string intentionally injects no prompt for this handbook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational")]
        public global::RetellAI.HandbookEntryConfig? Conversational { get; set; }

        /// <summary>
        /// Legacy name for customer_support. Cannot be sent together with customer_support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_personality")]
        public bool? DefaultPersonality { get; set; }

        /// <summary>
        /// Legacy name for conversational. Cannot be sent together with conversational. Colloquial rewriting is not available for chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational_personality")]
        public bool? ConversationalPersonality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_empathy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? HighEmpathy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_disclosure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? AiDisclosure { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_boundaries")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? ScopeBoundaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatHandbookConfig" /> class.
        /// </summary>
        /// <param name="customerSupport">
        /// Configuration for an enabled handbook. Omit custom_prompt or set it to null to use the Retell-provided prompt. An empty string intentionally injects no prompt for this handbook.
        /// </param>
        /// <param name="conversational">
        /// Configuration for an enabled handbook. Omit custom_prompt or set it to null to use the Retell-provided prompt. An empty string intentionally injects no prompt for this handbook.
        /// </param>
        /// <param name="defaultPersonality">
        /// Legacy name for customer_support. Cannot be sent together with customer_support.
        /// </param>
        /// <param name="conversationalPersonality">
        /// Legacy name for conversational. Cannot be sent together with conversational. Colloquial rewriting is not available for chat.
        /// </param>
        /// <param name="highEmpathy"></param>
        /// <param name="aiDisclosure"></param>
        /// <param name="scopeBoundaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatHandbookConfig(
            global::RetellAI.HandbookEntryConfig? customerSupport,
            global::RetellAI.HandbookEntryConfig? conversational,
            bool? defaultPersonality,
            bool? conversationalPersonality,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? highEmpathy,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? aiDisclosure,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? scopeBoundaries)
        {
            this.CustomerSupport = customerSupport;
            this.Conversational = conversational;
            this.DefaultPersonality = defaultPersonality;
            this.ConversationalPersonality = conversationalPersonality;
            this.HighEmpathy = highEmpathy;
            this.AiDisclosure = aiDisclosure;
            this.ScopeBoundaries = scopeBoundaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatHandbookConfig" /> class.
        /// </summary>
        public ChatHandbookConfig()
        {
        }

    }
}
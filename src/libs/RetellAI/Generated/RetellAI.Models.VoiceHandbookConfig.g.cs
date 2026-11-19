
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Independently selectable handbook prompts for voice agents. Phase 1 accepts legacy booleans in requests, but responses always return the object form.
    /// </summary>
    public sealed partial class VoiceHandbookConfig
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
        /// Legacy name for conversational. Cannot be sent together with conversational. For compatibility, true also enables enable_colloquial_model when that field is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational_personality")]
        public bool? ConversationalPersonality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natural_filler_words")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? NaturalFillerWords { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_empathy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? HighEmpathy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo_verification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? EchoVerification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nato_phonetic_alphabet")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? NatoPhoneticAlphabet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_normalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? SpeechNormalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_matching")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LegacyBooleanOrHandbookEntryConfigJsonConverter))]
        public global::RetellAI.LegacyBooleanOrHandbookEntryConfig? SmartMatching { get; set; }

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
        /// Initializes a new instance of the <see cref="VoiceHandbookConfig" /> class.
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
        /// Legacy name for conversational. Cannot be sent together with conversational. For compatibility, true also enables enable_colloquial_model when that field is omitted.
        /// </param>
        /// <param name="naturalFillerWords"></param>
        /// <param name="highEmpathy"></param>
        /// <param name="echoVerification"></param>
        /// <param name="natoPhoneticAlphabet"></param>
        /// <param name="speechNormalization"></param>
        /// <param name="smartMatching"></param>
        /// <param name="aiDisclosure"></param>
        /// <param name="scopeBoundaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceHandbookConfig(
            global::RetellAI.HandbookEntryConfig? customerSupport,
            global::RetellAI.HandbookEntryConfig? conversational,
            bool? defaultPersonality,
            bool? conversationalPersonality,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? naturalFillerWords,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? highEmpathy,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? echoVerification,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? natoPhoneticAlphabet,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? speechNormalization,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? smartMatching,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? aiDisclosure,
            global::RetellAI.LegacyBooleanOrHandbookEntryConfig? scopeBoundaries)
        {
            this.CustomerSupport = customerSupport;
            this.Conversational = conversational;
            this.DefaultPersonality = defaultPersonality;
            this.ConversationalPersonality = conversationalPersonality;
            this.NaturalFillerWords = naturalFillerWords;
            this.HighEmpathy = highEmpathy;
            this.EchoVerification = echoVerification;
            this.NatoPhoneticAlphabet = natoPhoneticAlphabet;
            this.SpeechNormalization = speechNormalization;
            this.SmartMatching = smartMatching;
            this.AiDisclosure = aiDisclosure;
            this.ScopeBoundaries = scopeBoundaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceHandbookConfig" /> class.
        /// </summary>
        public VoiceHandbookConfig()
        {
        }

    }
}
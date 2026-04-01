
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Behavior presets for voice agents. All presets are available.
    /// </summary>
    public sealed partial class VoiceHandbookConfig
    {
        /// <summary>
        /// Professional call center rep baseline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_personality")]
        public bool? DefaultPersonality { get; set; }

        /// <summary>
        /// Sprinkle natural speech fillers like "um", "you know" for a more human, conversational tone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natural_filler_words")]
        public bool? NaturalFillerWords { get; set; }

        /// <summary>
        /// Warm acknowledgment of caller concerns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_empathy")]
        public bool? HighEmpathy { get; set; }

        /// <summary>
        /// Repeat back and confirm important details (voice only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo_verification")]
        public bool? EchoVerification { get; set; }

        /// <summary>
        /// Spell using NATO phonetic alphabet style (voice only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nato_phonetic_alphabet")]
        public bool? NatoPhoneticAlphabet { get; set; }

        /// <summary>
        /// Convert numbers/dates/currency to spoken forms (voice only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_normalization")]
        public bool? SpeechNormalization { get; set; }

        /// <summary>
        /// Treat near-match similar words as same entity to reduce impact of transcription error (voice only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_matching")]
        public bool? SmartMatching { get; set; }

        /// <summary>
        /// When asked, acknowledge being a virtual assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_disclosure")]
        public bool? AiDisclosure { get; set; }

        /// <summary>
        /// Stay within prompt/context scope, don't invent details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_boundaries")]
        public bool? ScopeBoundaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceHandbookConfig" /> class.
        /// </summary>
        /// <param name="defaultPersonality">
        /// Professional call center rep baseline.
        /// </param>
        /// <param name="naturalFillerWords">
        /// Sprinkle natural speech fillers like "um", "you know" for a more human, conversational tone.
        /// </param>
        /// <param name="highEmpathy">
        /// Warm acknowledgment of caller concerns.
        /// </param>
        /// <param name="echoVerification">
        /// Repeat back and confirm important details (voice only).
        /// </param>
        /// <param name="natoPhoneticAlphabet">
        /// Spell using NATO phonetic alphabet style (voice only).
        /// </param>
        /// <param name="speechNormalization">
        /// Convert numbers/dates/currency to spoken forms (voice only).
        /// </param>
        /// <param name="smartMatching">
        /// Treat near-match similar words as same entity to reduce impact of transcription error (voice only).
        /// </param>
        /// <param name="aiDisclosure">
        /// When asked, acknowledge being a virtual assistant.
        /// </param>
        /// <param name="scopeBoundaries">
        /// Stay within prompt/context scope, don't invent details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceHandbookConfig(
            bool? defaultPersonality,
            bool? naturalFillerWords,
            bool? highEmpathy,
            bool? echoVerification,
            bool? natoPhoneticAlphabet,
            bool? speechNormalization,
            bool? smartMatching,
            bool? aiDisclosure,
            bool? scopeBoundaries)
        {
            this.DefaultPersonality = defaultPersonality;
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
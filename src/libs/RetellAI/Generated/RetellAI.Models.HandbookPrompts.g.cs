
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HandbookPrompts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_support")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerSupport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Conversational { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natural_filler_words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NaturalFillerWords { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_empathy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HighEmpathy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EchoVerification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nato_phonetic_alphabet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NatoPhoneticAlphabet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_normalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeechNormalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_matching")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SmartMatching { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_disclosure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AiDisclosure { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_boundaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopeBoundaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HandbookPrompts" /> class.
        /// </summary>
        /// <param name="customerSupport"></param>
        /// <param name="conversational"></param>
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
        public HandbookPrompts(
            string customerSupport,
            string conversational,
            string naturalFillerWords,
            string highEmpathy,
            string echoVerification,
            string natoPhoneticAlphabet,
            string speechNormalization,
            string smartMatching,
            string aiDisclosure,
            string scopeBoundaries)
        {
            this.CustomerSupport = customerSupport ?? throw new global::System.ArgumentNullException(nameof(customerSupport));
            this.Conversational = conversational ?? throw new global::System.ArgumentNullException(nameof(conversational));
            this.NaturalFillerWords = naturalFillerWords ?? throw new global::System.ArgumentNullException(nameof(naturalFillerWords));
            this.HighEmpathy = highEmpathy ?? throw new global::System.ArgumentNullException(nameof(highEmpathy));
            this.EchoVerification = echoVerification ?? throw new global::System.ArgumentNullException(nameof(echoVerification));
            this.NatoPhoneticAlphabet = natoPhoneticAlphabet ?? throw new global::System.ArgumentNullException(nameof(natoPhoneticAlphabet));
            this.SpeechNormalization = speechNormalization ?? throw new global::System.ArgumentNullException(nameof(speechNormalization));
            this.SmartMatching = smartMatching ?? throw new global::System.ArgumentNullException(nameof(smartMatching));
            this.AiDisclosure = aiDisclosure ?? throw new global::System.ArgumentNullException(nameof(aiDisclosure));
            this.ScopeBoundaries = scopeBoundaries ?? throw new global::System.ArgumentNullException(nameof(scopeBoundaries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandbookPrompts" /> class.
        /// </summary>
        public HandbookPrompts()
        {
        }

    }
}
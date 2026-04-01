
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Behavior presets for chat agents. Voice-only presets are excluded.
    /// </summary>
    public sealed partial class ChatHandbookConfig
    {
        /// <summary>
        /// Professional call center rep baseline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_personality")]
        public bool? DefaultPersonality { get; set; }

        /// <summary>
        /// Warm acknowledgment of caller concerns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_empathy")]
        public bool? HighEmpathy { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatHandbookConfig" /> class.
        /// </summary>
        /// <param name="defaultPersonality">
        /// Professional call center rep baseline.
        /// </param>
        /// <param name="highEmpathy">
        /// Warm acknowledgment of caller concerns.
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
        public ChatHandbookConfig(
            bool? defaultPersonality,
            bool? highEmpathy,
            bool? aiDisclosure,
            bool? scopeBoundaries)
        {
            this.DefaultPersonality = defaultPersonality;
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
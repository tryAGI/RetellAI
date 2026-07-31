
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Hallucination details for a single agent utterance.
    /// </summary>
    public sealed partial class UtteranceHallucination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseId { get; set; }

        /// <summary>
        /// Type of hallucination detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hallucination_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.UtteranceHallucinationHallucinationTypeJsonConverter))]
        public global::RetellAI.UtteranceHallucinationHallucinationType? HallucinationType { get; set; }

        /// <summary>
        /// Explanation of the hallucination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// True for minor hallucinations; false or omitted for major ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_severity")]
        public bool? LowSeverity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceHallucination" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="hallucinationType">
        /// Type of hallucination detected.
        /// </param>
        /// <param name="explanation">
        /// Explanation of the hallucination.
        /// </param>
        /// <param name="lowSeverity">
        /// True for minor hallucinations; false or omitted for major ones.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceHallucination(
            double responseId,
            global::RetellAI.UtteranceHallucinationHallucinationType? hallucinationType,
            string? explanation,
            bool? lowSeverity)
        {
            this.ResponseId = responseId;
            this.HallucinationType = hallucinationType;
            this.Explanation = explanation;
            this.LowSeverity = lowSeverity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceHallucination" /> class.
        /// </summary>
        public UtteranceHallucination()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Analysis of agent hallucinations across utterances.
    /// </summary>
    public sealed partial class HallucinationAnalysis
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.UtteranceHallucination> Details { get; set; }

        /// <summary>
        /// Number of utterances containing a hallucination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hallucination_utterance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HallucinationUtteranceCount { get; set; }

        /// <summary>
        /// Total number of agent utterances evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_utterance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUtteranceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="hallucinationUtteranceCount">
        /// Number of utterances containing a hallucination.
        /// </param>
        /// <param name="totalUtteranceCount">
        /// Total number of agent utterances evaluated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HallucinationAnalysis(
            global::System.Collections.Generic.IList<global::RetellAI.UtteranceHallucination> details,
            double hallucinationUtteranceCount,
            double totalUtteranceCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.HallucinationUtteranceCount = hallucinationUtteranceCount;
            this.TotalUtteranceCount = totalUtteranceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationAnalysis" /> class.
        /// </summary>
        public HallucinationAnalysis()
        {
        }

    }
}
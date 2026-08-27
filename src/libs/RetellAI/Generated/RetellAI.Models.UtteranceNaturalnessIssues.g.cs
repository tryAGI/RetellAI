
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UtteranceNaturalnessIssues
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naturalness_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue> NaturalnessIssues { get; set; }

        /// <summary>
        /// Explanation of the naturalness issues found in the utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceNaturalnessIssues" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="naturalnessIssues"></param>
        /// <param name="reason">
        /// Explanation of the naturalness issues found in the utterance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceNaturalnessIssues(
            double responseId,
            global::System.Collections.Generic.IList<global::RetellAI.NaturalnessIssue> naturalnessIssues,
            string? reason)
        {
            this.ResponseId = responseId;
            this.NaturalnessIssues = naturalnessIssues ?? throw new global::System.ArgumentNullException(nameof(naturalnessIssues));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceNaturalnessIssues" /> class.
        /// </summary>
        public UtteranceNaturalnessIssues()
        {
        }

    }
}
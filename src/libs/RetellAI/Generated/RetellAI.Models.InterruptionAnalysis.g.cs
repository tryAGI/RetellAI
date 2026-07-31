
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Analysis of the agent interrupting the user.
    /// </summary>
    public sealed partial class InterruptionAnalysis
    {
        /// <summary>
        /// Time spans where the agent interrupted the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.Duration> Details { get; set; }

        /// <summary>
        /// Total number of times the agent interrupted the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InterruptionCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptionAnalysis" /> class.
        /// </summary>
        /// <param name="details">
        /// Time spans where the agent interrupted the user.
        /// </param>
        /// <param name="interruptionCount">
        /// Total number of times the agent interrupted the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InterruptionAnalysis(
            global::System.Collections.Generic.IList<global::RetellAI.Duration> details,
            double interruptionCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.InterruptionCount = interruptionCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptionAnalysis" /> class.
        /// </summary>
        public InterruptionAnalysis()
        {
        }

    }
}
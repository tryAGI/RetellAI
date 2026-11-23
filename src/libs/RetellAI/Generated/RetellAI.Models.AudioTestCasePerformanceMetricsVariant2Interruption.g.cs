
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTestCasePerformanceMetricsVariant2Interruption
    {
        /// <summary>
        /// Times the agent and the caller talked over each other.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2Interruption" /> class.
        /// </summary>
        /// <param name="count">
        /// Times the agent and the caller talked over each other.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCasePerformanceMetricsVariant2Interruption(
            int count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2Interruption" /> class.
        /// </summary>
        public AudioTestCasePerformanceMetricsVariant2Interruption()
        {
        }

    }
}
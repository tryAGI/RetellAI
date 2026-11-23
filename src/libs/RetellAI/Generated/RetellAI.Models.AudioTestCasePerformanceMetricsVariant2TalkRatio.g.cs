
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTestCasePerformanceMetricsVariant2TalkRatio
    {
        /// <summary>
        /// Share of the call duration the agent spent talking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Agent { get; set; }

        /// <summary>
        /// Share of the call duration the caller spent talking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2TalkRatio" /> class.
        /// </summary>
        /// <param name="agent">
        /// Share of the call duration the agent spent talking.
        /// </param>
        /// <param name="user">
        /// Share of the call duration the caller spent talking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCasePerformanceMetricsVariant2TalkRatio(
            double agent,
            double user)
        {
            this.Agent = agent;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2TalkRatio" /> class.
        /// </summary>
        public AudioTestCasePerformanceMetricsVariant2TalkRatio()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// `call_id` counts calls; `chat_id` counts chats. For a disconnection reason breakdown, use `call_id` for calls or `chat_id` for chats and set `group: disconnection_reason`.
    /// </summary>
    public sealed partial class ChartShowItemKeywordSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemKeywordSourceSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemKeywordSourceMeasurement Measurement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSource" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="measurement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemKeywordSource(
            global::RetellAI.ChartShowItemKeywordSourceSource source,
            global::RetellAI.ChartShowItemKeywordSourceMeasurement measurement)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Measurement = measurement ?? throw new global::System.ArgumentNullException(nameof(measurement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSource" /> class.
        /// </summary>
        public ChartShowItemKeywordSource()
        {
        }

    }
}
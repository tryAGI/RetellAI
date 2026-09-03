
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartGroupItemVariant1
    {
        /// <summary>
        /// Breakdown dimension. Call-only values include `batch_call_id`, `call_successful`, `call_status`, `direction`, and `call_type`; chat-only values are `chat_successful` and `chat_status`. `agent_version` also separates results by `agent_id`. On donut charts, `direction` includes phone calls only. Do not set `time`; it is added automatically for `line`, `bar`, and `column`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartGroupItemVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartGroupItemVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartGroupItemVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Breakdown dimension. Call-only values include `batch_call_id`, `call_successful`, `call_status`, `direction`, and `call_type`; chat-only values are `chat_successful` and `chat_status`. `agent_version` also separates results by `agent_id`. On donut charts, `direction` includes phone calls only. Do not set `time`; it is added automatically for `line`, `bar`, and `column`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartGroupItemVariant1(
            global::RetellAI.ChartGroupItemVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartGroupItemVariant1" /> class.
        /// </summary>
        public ChartGroupItemVariant1()
        {
        }

    }
}
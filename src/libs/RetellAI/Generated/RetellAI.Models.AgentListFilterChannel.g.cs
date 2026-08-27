
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filter by agent channel. Use `op: eq`.
    /// </summary>
    public sealed partial class AgentListFilterChannel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentListFilterChannelOpJsonConverter))]
        public global::RetellAI.AgentListFilterChannelOp? Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentListFilterChannelValueJsonConverter))]
        public global::RetellAI.AgentListFilterChannelValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListFilterChannel" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentListFilterChannel(
            global::RetellAI.AgentListFilterChannelOp? op,
            global::RetellAI.AgentListFilterChannelValue? value)
        {
            this.Op = op;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListFilterChannel" /> class.
        /// </summary>
        public AgentListFilterChannel()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A fake response for one tool. During a simulation, when a tool call matches `tool_name`, `node_id` and `input_match_rule`, the real tool is not run; `output` is returned to the LLM instead. This keeps runs deterministic and avoids calling live integrations. A tool call that matches no mock falls through to the real tool.
    /// </summary>
    public sealed partial class ToolMock
    {
        /// <summary>
        /// The tool's function name, not the tool ID, i.e. the name the LLM uses when it calls the tool (for example `check_availability_cal`, `book_appointment_cal`, or the name you gave a custom function). Leave it out to match every tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Conversation flow agents only. The ID of the node the tool runs in. Leave it out to match every node. To mock an SMS or Call Transfer node, set `node_id` and `result`, and leave out `tool_name`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// Decides which calls to the tool this mock applies to, based on the arguments the LLM passes to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_match_rule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ToolMockInputMatchRule InputMatchRule { get; set; }

        /// <summary>
        /// The tool result fed back to the LLM in place of the real tool's output. Should be a JSON string, the same shape the real tool would return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// Whether the call succeeds (`true`) or fails (`false`). Required to mock SMS, transfer and escalation calls; for those calls, a mock without `result` is ignored. Not used for other tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMock" /> class.
        /// </summary>
        /// <param name="inputMatchRule">
        /// Decides which calls to the tool this mock applies to, based on the arguments the LLM passes to the tool.
        /// </param>
        /// <param name="output">
        /// The tool result fed back to the LLM in place of the real tool's output. Should be a JSON string, the same shape the real tool would return.
        /// </param>
        /// <param name="toolName">
        /// The tool's function name, not the tool ID, i.e. the name the LLM uses when it calls the tool (for example `check_availability_cal`, `book_appointment_cal`, or the name you gave a custom function). Leave it out to match every tool.
        /// </param>
        /// <param name="nodeId">
        /// Conversation flow agents only. The ID of the node the tool runs in. Leave it out to match every node. To mock an SMS or Call Transfer node, set `node_id` and `result`, and leave out `tool_name`.
        /// </param>
        /// <param name="result">
        /// Whether the call succeeds (`true`) or fails (`false`). Required to mock SMS, transfer and escalation calls; for those calls, a mock without `result` is ignored. Not used for other tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMock(
            global::RetellAI.ToolMockInputMatchRule inputMatchRule,
            string output,
            string? toolName,
            string? nodeId,
            bool? result)
        {
            this.ToolName = toolName;
            this.NodeId = nodeId;
            this.InputMatchRule = inputMatchRule;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMock" /> class.
        /// </summary>
        public ToolMock()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPlaygroundCompletionRequest
    {
        /// <summary>
        /// Full conversation history, same shape as chat completion messages. message_id and created_timestamp are optional — server generates them if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput> Messages { get; set; }

        /// <summary>
        /// Key-value pairs for dynamic variable substitution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? DynamicVariables { get; set; }

        /// <summary>
        /// Optional mock responses for tools. When provided, the agent uses these instead of executing real tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mocks")]
        public global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? ToolMocks { get; set; }

        /// <summary>
        /// Current state name for retell-llm agents. Used to resume from a specific state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_state")]
        public string? CurrentState { get; set; }

        /// <summary>
        /// Current node id for conversation-flow agents. Used to resume from a specific node. Must be provided together with component_id when testing components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_node_id")]
        public string? CurrentNodeId { get; set; }

        /// <summary>
        /// Conversation flow component id. Required when current_node_id refers to a node within a component.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component_id")]
        public string? ComponentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlaygroundCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Full conversation history, same shape as chat completion messages. message_id and created_timestamp are optional — server generates them if omitted.
        /// </param>
        /// <param name="dynamicVariables">
        /// Key-value pairs for dynamic variable substitution.
        /// </param>
        /// <param name="toolMocks">
        /// Optional mock responses for tools. When provided, the agent uses these instead of executing real tool calls.
        /// </param>
        /// <param name="currentState">
        /// Current state name for retell-llm agents. Used to resume from a specific state.
        /// </param>
        /// <param name="currentNodeId">
        /// Current node id for conversation-flow agents. Used to resume from a specific node. Must be provided together with component_id when testing components.
        /// </param>
        /// <param name="componentId">
        /// Conversation flow component id. Required when current_node_id refers to a node within a component.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPlaygroundCompletionRequest(
            global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput> messages,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables,
            global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? toolMocks,
            string? currentState,
            string? currentNodeId,
            string? componentId)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.DynamicVariables = dynamicVariables;
            this.ToolMocks = toolMocks;
            this.CurrentState = currentState;
            this.CurrentNodeId = currentNodeId;
            this.ComponentId = componentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlaygroundCompletionRequest" /> class.
        /// </summary>
        public AgentPlaygroundCompletionRequest()
        {
        }
    }
}
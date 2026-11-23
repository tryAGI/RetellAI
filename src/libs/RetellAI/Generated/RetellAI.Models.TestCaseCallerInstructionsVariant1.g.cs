
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseCallerInstructionsVariant1
    {
        /// <summary>
        /// The simulated caller is an LLM that follows `user_prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseCallerInstructionsVariant1TypeJsonConverter))]
        public global::RetellAI.TestCaseCallerInstructionsVariant1Type Type { get; set; }

        /// <summary>
        /// Instructions for the simulated caller, such as who they are and what they want.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// Extra instructions added to the end of the caller's prompt, such as how they speak or react.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_behavior")]
        public string? CallerBehavior { get; set; }

        /// <summary>
        /// Conversation turns, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_transcript")]
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>>? StartingTranscript { get; set; }

        /// <summary>
        /// ID of the conversation flow node to start the simulation at. Not supported for flex mode agents, which always start from the start node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_node")]
        public string? StartingNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseCallerInstructionsVariant1" /> class.
        /// </summary>
        /// <param name="userPrompt">
        /// Instructions for the simulated caller, such as who they are and what they want.
        /// </param>
        /// <param name="type">
        /// The simulated caller is an LLM that follows `user_prompt`.
        /// </param>
        /// <param name="callerBehavior">
        /// Extra instructions added to the end of the caller's prompt, such as how they speak or react.
        /// </param>
        /// <param name="startingTranscript">
        /// Conversation turns, in order.
        /// </param>
        /// <param name="startingNode">
        /// ID of the conversation flow node to start the simulation at. Not supported for flex mode agents, which always start from the start node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseCallerInstructionsVariant1(
            string userPrompt,
            global::RetellAI.TestCaseCallerInstructionsVariant1Type type,
            string? callerBehavior,
            global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>>? startingTranscript,
            string? startingNode)
        {
            this.Type = type;
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.CallerBehavior = callerBehavior;
            this.StartingTranscript = startingTranscript;
            this.StartingNode = startingNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseCallerInstructionsVariant1" /> class.
        /// </summary>
        public TestCaseCallerInstructionsVariant1()
        {
        }

    }
}
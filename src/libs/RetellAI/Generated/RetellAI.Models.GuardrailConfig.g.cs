
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailConfig
    {
        /// <summary>
        /// Selected prohibited agent topic categories to check. When agent messages contain these topics, they will be replaced with a placeholder message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_topics")]
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>? OutputTopics { get; set; }

        /// <summary>
        /// Selected prohibited user topic categories to check. When user messages contain these topics, the agent will respond with a placeholder message instead of processing the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_topics")]
        public global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>? InputTopics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailConfig" /> class.
        /// </summary>
        /// <param name="outputTopics">
        /// Selected prohibited agent topic categories to check. When agent messages contain these topics, they will be replaced with a placeholder message.
        /// </param>
        /// <param name="inputTopics">
        /// Selected prohibited user topic categories to check. When user messages contain these topics, the agent will respond with a placeholder message instead of processing the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailConfig(
            global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigOutputTopic>? outputTopics,
            global::System.Collections.Generic.IList<global::RetellAI.GuardrailConfigInputTopic>? inputTopics)
        {
            this.OutputTopics = outputTopics;
            this.InputTopics = inputTopics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailConfig" /> class.
        /// </summary>
        public GuardrailConfig()
        {
        }
    }
}
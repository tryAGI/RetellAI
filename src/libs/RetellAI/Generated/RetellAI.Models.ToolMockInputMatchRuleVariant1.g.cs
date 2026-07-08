
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMockInputMatchRuleVariant1
    {
        /// <summary>
        /// Match every call to the tool, no matter what arguments were passed. Use this for a catch-all mock.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant1TypeJsonConverter))]
        public global::RetellAI.ToolMockInputMatchRuleVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Match every call to the tool, no matter what arguments were passed. Use this for a catch-all mock.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMockInputMatchRuleVariant1(
            global::RetellAI.ToolMockInputMatchRuleVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant1" /> class.
        /// </summary>
        public ToolMockInputMatchRuleVariant1()
        {
        }

    }
}
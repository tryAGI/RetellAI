
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMockInputMatchRuleVariant2
    {
        /// <summary>
        /// Match only calls whose arguments contain the values listed in `args`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ToolMockInputMatchRuleVariant2TypeJsonConverter))]
        public global::RetellAI.ToolMockInputMatchRuleVariant2Type Type { get; set; }

        /// <summary>
        /// Argument values the call must have to match. Only the fields you list here are checked, and each must equal the value in the actual call. Extra fields in the call are ignored, so this is a subset match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant2" /> class.
        /// </summary>
        /// <param name="args">
        /// Argument values the call must have to match. Only the fields you list here are checked, and each must equal the value in the actual call. Extra fields in the call are ignored, so this is a subset match.
        /// </param>
        /// <param name="type">
        /// Match only calls whose arguments contain the values listed in `args`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMockInputMatchRuleVariant2(
            object args,
            global::RetellAI.ToolMockInputMatchRuleVariant2Type type)
        {
            this.Type = type;
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant2" /> class.
        /// </summary>
        public ToolMockInputMatchRuleVariant2()
        {
        }

    }
}
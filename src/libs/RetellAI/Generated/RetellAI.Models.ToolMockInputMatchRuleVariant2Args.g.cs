
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Argument values the call must have to match. Only the fields you list here are checked, and each must equal the value in the actual call. Extra fields in the call are ignored, so this is a subset match.
    /// </summary>
    public sealed partial class ToolMockInputMatchRuleVariant2Args
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
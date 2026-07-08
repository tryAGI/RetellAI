
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRootTagState
    {
        /// <summary>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRootTagState" /> class.
        /// </summary>
        /// <param name="version">
        /// Example: 15
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRootTagState(
            int? version,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables)
        {
            this.Version = version;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRootTagState" /> class.
        /// </summary>
        public AgentRootTagState()
        {
        }

    }
}
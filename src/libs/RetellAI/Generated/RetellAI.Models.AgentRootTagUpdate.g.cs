
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRootTagUpdate
    {
        /// <summary>
        /// Version for the tag to point to. Set to null to make the tag follow the latest version. If omitted, the tag keeps its current version.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Dynamic variable values supplied when a call uses this tag. Replaces all of the tag's current values. Set to null to remove them. If omitted, the tag keeps its current values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRootTagUpdate" /> class.
        /// </summary>
        /// <param name="version">
        /// Version for the tag to point to. Set to null to make the tag follow the latest version. If omitted, the tag keeps its current version.<br/>
        /// Example: 15
        /// </param>
        /// <param name="dynamicVariables">
        /// Dynamic variable values supplied when a call uses this tag. Replaces all of the tag's current values. Set to null to remove them. If omitted, the tag keeps its current values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRootTagUpdate(
            int? version,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables)
        {
            this.Version = version;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRootTagUpdate" /> class.
        /// </summary>
        public AgentRootTagUpdate()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Configuration for an enabled handbook. Omit custom_prompt or set it to null to use the Retell-provided prompt. An empty string intentionally injects no prompt for this handbook.
    /// </summary>
    public sealed partial class HandbookEntryConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_prompt")]
        public string? CustomPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HandbookEntryConfig" /> class.
        /// </summary>
        /// <param name="customPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HandbookEntryConfig(
            string? customPrompt)
        {
            this.CustomPrompt = customPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandbookEntryConfig" /> class.
        /// </summary>
        public HandbookEntryConfig()
        {
        }

    }
}
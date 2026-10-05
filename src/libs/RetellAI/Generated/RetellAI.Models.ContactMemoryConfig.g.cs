
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Contact memory settings for phone calls and SMS chats. Creating an agent defaults enable_update to false and enable_read to true. Updates only change the supplied flags; omitted flags stay unchanged and an empty object has no effect. Set a flag to false to disable it. The configuration cannot be cleared. Existing agents without this configuration have both disabled.
    /// </summary>
    public sealed partial class ContactMemoryConfig
    {
        /// <summary>
        /// Rewrite the contact memory after each conversation. Requires storing conversation data. Chat agents must also have end_chat_after_silence_ms set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_update")]
        public bool? EnableUpdate { get; set; }

        /// <summary>
        /// Automatically add saved contact memory to the agent prompt. Skippable nodes can use answers from the current conversation even when this setting is disabled. Contact dynamic variables, including contact_memory, remain available regardless of this setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_read")]
        public bool? EnableRead { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactMemoryConfig" /> class.
        /// </summary>
        /// <param name="enableUpdate">
        /// Rewrite the contact memory after each conversation. Requires storing conversation data. Chat agents must also have end_chat_after_silence_ms set.
        /// </param>
        /// <param name="enableRead">
        /// Automatically add saved contact memory to the agent prompt. Skippable nodes can use answers from the current conversation even when this setting is disabled. Contact dynamic variables, including contact_memory, remain available regardless of this setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactMemoryConfig(
            bool? enableUpdate,
            bool? enableRead)
        {
            this.EnableUpdate = enableUpdate;
            this.EnableRead = enableRead;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactMemoryConfig" /> class.
        /// </summary>
        public ContactMemoryConfig()
        {
        }

    }
}
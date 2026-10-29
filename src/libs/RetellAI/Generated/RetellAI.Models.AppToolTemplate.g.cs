
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppToolTemplate
    {
        /// <summary>
        /// Privacy scope of an integration function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.PrivacyScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.PrivacyScope PrivacyScope { get; set; }

        /// <summary>
        /// Unique tool name within the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Also the LLM-facing description when used as a mid-call tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Per-invocation timeout for this tool, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppToolTemplate" /> class.
        /// </summary>
        /// <param name="privacyScope">
        /// Privacy scope of an integration function.
        /// </param>
        /// <param name="name">
        /// Unique tool name within the provider.
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="description">
        /// Also the LLM-facing description when used as a mid-call tool.
        /// </param>
        /// <param name="timeoutMs">
        /// Per-invocation timeout for this tool, in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppToolTemplate(
            global::RetellAI.PrivacyScope privacyScope,
            string name,
            string displayName,
            string description,
            double timeoutMs)
        {
            this.PrivacyScope = privacyScope;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppToolTemplate" /> class.
        /// </summary>
        public AppToolTemplate()
        {
        }

    }
}
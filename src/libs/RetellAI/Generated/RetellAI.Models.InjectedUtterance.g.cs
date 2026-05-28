
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InjectedUtterance
    {
        /// <summary>
        /// External context injected into the conversation via the update-live-call API. Not spoken by either party.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.InjectedUtteranceRoleJsonConverter))]
        public global::RetellAI.InjectedUtteranceRole Role { get; set; }

        /// <summary>
        /// The injected context text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Time the context was injected, in seconds relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectedUtterance" /> class.
        /// </summary>
        /// <param name="content">
        /// The injected context text.
        /// </param>
        /// <param name="timeSec">
        /// Time the context was injected, in seconds relative to the start of the call.
        /// </param>
        /// <param name="role">
        /// External context injected into the conversation via the update-live-call API. Not spoken by either party.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InjectedUtterance(
            string content,
            double timeSec,
            global::RetellAI.InjectedUtteranceRole role)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.TimeSec = timeSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectedUtterance" /> class.
        /// </summary>
        public InjectedUtterance()
        {
        }

    }
}
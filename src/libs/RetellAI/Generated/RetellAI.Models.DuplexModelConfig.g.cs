
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Retell LLMs only. A full-duplex voice model talks to the user and delegates to a cascading backend model, which runs the LLM's prompt, tools and knowledge base. Requires backend, and the Retell LLM's voice_prompt. Tools' speak_during_execution is ignored, since the voice model covers the wait itself, and speak_after_execution is always on.
    /// </summary>
    public sealed partial class DuplexModelConfig
    {
        /// <summary>
        /// Runs a full-duplex voice model with a cascading backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.DuplexModelConfigTypeJsonConverter))]
        public global::RetellAI.DuplexModelConfigType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::RetellAI.DuplexModelRef? Primary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public global::RetellAI.TextModelRef? Backend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NullableBackupModelRefJsonConverter))]
        public global::RetellAI.NullableBackupModelRef? Backup { get; set; }

        /// <summary>
        /// Randomness of the response, from 0 to 1. Defaults to 0; a lower value is recommended for tool calling.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplexModelConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Runs a full-duplex voice model with a cascading backend.
        /// </param>
        /// <param name="primary"></param>
        /// <param name="backend"></param>
        /// <param name="backup"></param>
        /// <param name="temperature">
        /// Randomness of the response, from 0 to 1. Defaults to 0; a lower value is recommended for tool calling.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DuplexModelConfig(
            global::RetellAI.DuplexModelConfigType? type,
            global::RetellAI.DuplexModelRef? primary,
            global::RetellAI.TextModelRef? backend,
            global::RetellAI.NullableBackupModelRef? backup,
            double? temperature)
        {
            this.Type = type;
            this.Primary = primary;
            this.Backend = backend;
            this.Backup = backup;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplexModelConfig" /> class.
        /// </summary>
        public DuplexModelConfig()
        {
        }

    }
}
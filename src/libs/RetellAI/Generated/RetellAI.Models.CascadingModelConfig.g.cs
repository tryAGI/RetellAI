
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CascadingModelConfig
    {
        /// <summary>
        /// Runs a text LLM with a separate voice. This is the default type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CascadingModelConfigTypeJsonConverter))]
        public global::RetellAI.CascadingModelConfigType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::RetellAI.TextModelRef? Primary { get; set; }

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
        /// Initializes a new instance of the <see cref="CascadingModelConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Runs a text LLM with a separate voice. This is the default type.
        /// </param>
        /// <param name="primary"></param>
        /// <param name="backup"></param>
        /// <param name="temperature">
        /// Randomness of the response, from 0 to 1. Defaults to 0; a lower value is recommended for tool calling.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CascadingModelConfig(
            global::RetellAI.CascadingModelConfigType? type,
            global::RetellAI.TextModelRef? primary,
            global::RetellAI.NullableBackupModelRef? backup,
            double? temperature)
        {
            this.Type = type;
            this.Primary = primary;
            this.Backup = backup;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CascadingModelConfig" /> class.
        /// </summary>
        public CascadingModelConfig()
        {
        }

    }
}
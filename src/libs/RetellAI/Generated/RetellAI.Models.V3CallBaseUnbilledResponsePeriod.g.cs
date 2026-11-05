
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V3CallBaseUnbilledResponsePeriod
    {
        /// <summary>
        /// Start of the span in milliseconds from call start.<br/>
        /// Example: 12000
        /// </summary>
        /// <example>12000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartMs { get; set; }

        /// <summary>
        /// End of the span in milliseconds from call start.<br/>
        /// Example: 45000
        /// </summary>
        /// <example>45000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndMs { get; set; }

        /// <summary>
        /// The engine that ran during the span. A span is split where an agent swap changes the engine. `cascading` credits LLM and TTS time, `s2s` credits the realtime model's time, and `duplex` credits only the backend model's time, because the duplex voice model is still billed in full. Absent when the engine is not known.<br/>
        /// Example: cascading
        /// </summary>
        /// <example>cascading</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.V3CallBaseUnbilledResponsePeriodTypeJsonConverter))]
        public global::RetellAI.V3CallBaseUnbilledResponsePeriodType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V3CallBaseUnbilledResponsePeriod" /> class.
        /// </summary>
        /// <param name="startMs">
        /// Start of the span in milliseconds from call start.<br/>
        /// Example: 12000
        /// </param>
        /// <param name="endMs">
        /// End of the span in milliseconds from call start.<br/>
        /// Example: 45000
        /// </param>
        /// <param name="type">
        /// The engine that ran during the span. A span is split where an agent swap changes the engine. `cascading` credits LLM and TTS time, `s2s` credits the realtime model's time, and `duplex` credits only the backend model's time, because the duplex voice model is still billed in full. Absent when the engine is not known.<br/>
        /// Example: cascading
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V3CallBaseUnbilledResponsePeriod(
            double startMs,
            double endMs,
            global::RetellAI.V3CallBaseUnbilledResponsePeriodType? type)
        {
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3CallBaseUnbilledResponsePeriod" /> class.
        /// </summary>
        public V3CallBaseUnbilledResponsePeriod()
        {
        }

    }
}
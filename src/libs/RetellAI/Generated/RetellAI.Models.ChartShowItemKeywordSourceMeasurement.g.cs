
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartShowItemKeywordSourceMeasurement
    {
        /// <summary>
        /// Count matching records or non-null values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemKeywordSourceMeasurementTypeJsonConverter))]
        public global::RetellAI.ChartShowItemKeywordSourceMeasurementType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSourceMeasurement" /> class.
        /// </summary>
        /// <param name="type">
        /// Count matching records or non-null values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemKeywordSourceMeasurement(
            global::RetellAI.ChartShowItemKeywordSourceMeasurementType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSourceMeasurement" /> class.
        /// </summary>
        public ChartShowItemKeywordSourceMeasurement()
        {
        }

    }
}
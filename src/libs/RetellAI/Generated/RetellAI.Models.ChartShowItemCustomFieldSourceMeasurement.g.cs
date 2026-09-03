
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartShowItemCustomFieldSourceMeasurement
    {
        /// <summary>
        /// `count` works for any value; other options require numeric or castable values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceMeasurementTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomFieldSourceMeasurement" /> class.
        /// </summary>
        /// <param name="type">
        /// `count` works for any value; other options require numeric or castable values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemCustomFieldSourceMeasurement(
            global::RetellAI.ChartShowItemCustomFieldSourceMeasurementType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomFieldSourceMeasurement" /> class.
        /// </summary>
        public ChartShowItemCustomFieldSourceMeasurement()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Custom analysis / attribute sources — field is required.
    /// </summary>
    public sealed partial class ChartShowItemCustomFieldSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemCustomFieldSourceSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemCustomFieldSourceMeasurement Measurement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomFieldSource" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="measurement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemCustomFieldSource(
            global::RetellAI.ChartShowItemCustomFieldSourceSource source,
            global::RetellAI.ChartShowItemCustomFieldSourceMeasurement measurement)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Measurement = measurement ?? throw new global::System.ArgumentNullException(nameof(measurement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomFieldSource" /> class.
        /// </summary>
        public ChartShowItemCustomFieldSource()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Custom tool call metrics — avg measurement only.
    /// </summary>
    public sealed partial class ChartShowItemCustomToolSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemCustomToolSourceSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemCustomToolSourceMeasurement Measurement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomToolSource" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="measurement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemCustomToolSource(
            global::RetellAI.ChartShowItemCustomToolSourceSource source,
            global::RetellAI.ChartShowItemCustomToolSourceMeasurement measurement)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Measurement = measurement ?? throw new global::System.ArgumentNullException(nameof(measurement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomToolSource" /> class.
        /// </summary>
        public ChartShowItemCustomToolSource()
        {
        }

    }
}
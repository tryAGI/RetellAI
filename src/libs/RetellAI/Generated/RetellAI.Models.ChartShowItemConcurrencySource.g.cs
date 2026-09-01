
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Call concurrency — max measurement only.
    /// </summary>
    public sealed partial class ChartShowItemConcurrencySource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemConcurrencySourceSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemConcurrencySourceMeasurement Measurement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemConcurrencySource" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="measurement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemConcurrencySource(
            global::RetellAI.ChartShowItemConcurrencySourceSource source,
            global::RetellAI.ChartShowItemConcurrencySourceMeasurement measurement)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Measurement = measurement ?? throw new global::System.ArgumentNullException(nameof(measurement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemConcurrencySource" /> class.
        /// </summary>
        public ChartShowItemConcurrencySource()
        {
        }

    }
}
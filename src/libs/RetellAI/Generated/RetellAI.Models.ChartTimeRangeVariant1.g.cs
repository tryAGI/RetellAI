
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Rolling interval ending now.
    /// </summary>
    public sealed partial class ChartTimeRangeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartTimeRangeVariant1TypeJsonConverter))]
        public global::RetellAI.ChartTimeRangeVariant1Type Type { get; set; }

        /// <summary>
        /// Amount of time to look back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartTimeRangeVariant1Window Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartTimeRangeVariant1" /> class.
        /// </summary>
        /// <param name="window">
        /// Amount of time to look back.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartTimeRangeVariant1(
            global::RetellAI.ChartTimeRangeVariant1Window window,
            global::RetellAI.ChartTimeRangeVariant1Type type)
        {
            this.Type = type;
            this.Window = window ?? throw new global::System.ArgumentNullException(nameof(window));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartTimeRangeVariant1" /> class.
        /// </summary>
        public ChartTimeRangeVariant1()
        {
        }

    }
}
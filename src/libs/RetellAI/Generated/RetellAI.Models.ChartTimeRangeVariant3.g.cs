
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The current day, week, month or year so far, resolved per request in the request's timezone. Weeks start Monday.
    /// </summary>
    public sealed partial class ChartTimeRangeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartTimeRangeVariant3TypeJsonConverter))]
        public global::RetellAI.ChartTimeRangeVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartTimeRangeVariant3UnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartTimeRangeVariant3Unit Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartTimeRangeVariant3" /> class.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartTimeRangeVariant3(
            global::RetellAI.ChartTimeRangeVariant3Unit unit,
            global::RetellAI.ChartTimeRangeVariant3Type type)
        {
            this.Type = type;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartTimeRangeVariant3" /> class.
        /// </summary>
        public ChartTimeRangeVariant3()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// All available records with no time filter.
    /// </summary>
    public sealed partial class ChartTimeRangeVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartTimeRangeVariant5TypeJsonConverter))]
        public global::RetellAI.ChartTimeRangeVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartTimeRangeVariant5" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartTimeRangeVariant5(
            global::RetellAI.ChartTimeRangeVariant5Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartTimeRangeVariant5" /> class.
        /// </summary>
        public ChartTimeRangeVariant5()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartShowItemKeywordSourceSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemKeywordSourceSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemKeywordSourceSourceType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartGroupTypeJsonConverter))]
        public global::RetellAI.ChartGroupType? Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSourceSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="group"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemKeywordSourceSource(
            global::RetellAI.ChartShowItemKeywordSourceSourceType type,
            global::RetellAI.ChartGroupType? group)
        {
            this.Type = type;
            this.Group = group;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSourceSource" /> class.
        /// </summary>
        public ChartShowItemKeywordSourceSource()
        {
        }

    }
}
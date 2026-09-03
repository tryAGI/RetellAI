
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartShowItemConcurrencySourceSource
    {
        /// <summary>
        /// Number of calls active at the same time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemConcurrencySourceSourceTypeJsonConverter))]
        public global::RetellAI.ChartShowItemConcurrencySourceSourceType Type { get; set; }

        /// <summary>
        /// Do not set; concurrency supports time only.
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
        /// Initializes a new instance of the <see cref="ChartShowItemConcurrencySourceSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Number of calls active at the same time.
        /// </param>
        /// <param name="group">
        /// Do not set; concurrency supports time only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemConcurrencySourceSource(
            global::RetellAI.ChartShowItemConcurrencySourceSourceType type,
            global::RetellAI.ChartGroupType? group)
        {
            this.Type = type;
            this.Group = group;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemConcurrencySourceSource" /> class.
        /// </summary>
        public ChartShowItemConcurrencySourceSource()
        {
        }

    }
}
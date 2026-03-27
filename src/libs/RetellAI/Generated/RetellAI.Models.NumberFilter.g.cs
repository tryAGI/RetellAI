
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumberFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NumberFilterTypeJsonConverter))]
        public global::RetellAI.NumberFilterType Type { get; set; }

        /// <summary>
        /// eq: equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NumberFilterOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.NumberFilterOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberFilter" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="op">
        /// eq: equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumberFilter(
            global::RetellAI.NumberFilterOp op,
            double value,
            global::RetellAI.NumberFilterType type)
        {
            this.Op = op;
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberFilter" /> class.
        /// </summary>
        public NumberFilter()
        {
        }
    }
}
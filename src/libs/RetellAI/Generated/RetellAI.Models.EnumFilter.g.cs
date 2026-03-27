
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnumFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EnumFilterTypeJsonConverter))]
        public global::RetellAI.EnumFilterType Type { get; set; }

        /// <summary>
        /// in: value is one of the listed values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EnumFilterOpJsonConverter))]
        public global::RetellAI.EnumFilterOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumFilter" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="op">
        /// in: value is one of the listed values
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnumFilter(
            global::System.Collections.Generic.IList<string> value,
            global::RetellAI.EnumFilterType type,
            global::RetellAI.EnumFilterOp op)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumFilter" /> class.
        /// </summary>
        public EnumFilter()
        {
        }
    }
}
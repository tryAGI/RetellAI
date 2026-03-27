
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IvrActionHangup
    {
        /// <summary>
        /// Example: hangup
        /// </summary>
        /// <example>hangup</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.IvrActionHangupTypeJsonConverter))]
        public global::RetellAI.IvrActionHangupType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IvrActionHangup" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: hangup
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IvrActionHangup(
            global::RetellAI.IvrActionHangupType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IvrActionHangup" /> class.
        /// </summary>
        public IvrActionHangup()
        {
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TakeOverLiveCallResponse6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TakeOverLiveCallResponseStatus5JsonConverter))]
        public global::RetellAI.TakeOverLiveCallResponseStatus5? Status { get; set; }

        /// <summary>
        /// Example: Resource update conflict.
        /// </summary>
        /// <example>Resource update conflict.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TakeOverLiveCallResponse6" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Resource update conflict.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TakeOverLiveCallResponse6(
            global::RetellAI.TakeOverLiveCallResponseStatus5? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TakeOverLiveCallResponse6" /> class.
        /// </summary>
        public TakeOverLiveCallResponse6()
        {
        }

    }
}
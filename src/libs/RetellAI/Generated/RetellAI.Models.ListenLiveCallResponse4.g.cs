
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenLiveCallResponse4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListenLiveCallResponseStatus3JsonConverter))]
        public global::RetellAI.ListenLiveCallResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: Forbidden
        /// </summary>
        /// <example>Forbidden</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenLiveCallResponse4" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Forbidden
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenLiveCallResponse4(
            global::RetellAI.ListenLiveCallResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenLiveCallResponse4" /> class.
        /// </summary>
        public ListenLiveCallResponse4()
        {
        }

    }
}
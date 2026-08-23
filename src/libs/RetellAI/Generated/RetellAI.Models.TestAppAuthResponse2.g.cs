
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestAppAuthResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestAppAuthResponseStatusJsonConverter))]
        public global::RetellAI.TestAppAuthResponseStatus? Status { get; set; }

        /// <summary>
        /// Example: API key is missing or invalid.
        /// </summary>
        /// <example>API key is missing or invalid.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestAppAuthResponse2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: API key is missing or invalid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestAppAuthResponse2(
            global::RetellAI.TestAppAuthResponseStatus? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestAppAuthResponse2" /> class.
        /// </summary>
        public TestAppAuthResponse2()
        {
        }

    }
}
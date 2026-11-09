
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EscalationDestinationDestination
    {
        /// <summary>
        /// Customer webhook URL for transfer requests and forwarded SMS messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EscalationDestinationDestinationMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.EscalationDestinationDestinationMethod Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retry")]
        public int? MaxRetry { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? QueryParams { get; set; }

        /// <summary>
        /// Customer-defined fields nested in args on chat_transfer_requested events. String values support dynamic variables such as {{customer_id}}, including inside nested objects and arrays. Field names and non-string values are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationDestinationDestination" /> class.
        /// </summary>
        /// <param name="url">
        /// Customer webhook URL for transfer requests and forwarded SMS messages.
        /// </param>
        /// <param name="method"></param>
        /// <param name="timeoutMs"></param>
        /// <param name="maxRetry"></param>
        /// <param name="headers"></param>
        /// <param name="queryParams"></param>
        /// <param name="body">
        /// Customer-defined fields nested in args on chat_transfer_requested events. String values support dynamic variables such as {{customer_id}}, including inside nested objects and arrays. Field names and non-string values are preserved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EscalationDestinationDestination(
            string url,
            global::RetellAI.EscalationDestinationDestinationMethod method,
            int? timeoutMs,
            int? maxRetry,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? queryParams,
            object? body)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.TimeoutMs = timeoutMs;
            this.MaxRetry = maxRetry;
            this.Headers = headers;
            this.QueryParams = queryParams;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationDestinationDestination" /> class.
        /// </summary>
        public EscalationDestinationDestination()
        {
        }

    }
}
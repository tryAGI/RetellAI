
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
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::RetellAI.ToolParameter? Parameters { get; set; }

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
        /// <param name="parameters">
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
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
            global::RetellAI.ToolParameter? parameters)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.TimeoutMs = timeoutMs;
            this.MaxRetry = maxRetry;
            this.Headers = headers;
            this.QueryParams = queryParams;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationDestinationDestination" /> class.
        /// </summary>
        public EscalationDestinationDestination()
        {
        }

    }
}
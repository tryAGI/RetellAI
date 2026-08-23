
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyAuthConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ApiKeyAuthConfigRequestTypeJsonConverter))]
        public global::RetellAI.ApiKeyAuthConfigRequestType Type { get; set; }

        /// <summary>
        /// API key credential; stored encrypted at rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyAuthConfigRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// API key credential; stored encrypted at rest.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyAuthConfigRequest(
            string apiKey,
            global::RetellAI.ApiKeyAuthConfigRequestType type)
        {
            this.Type = type;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyAuthConfigRequest" /> class.
        /// </summary>
        public ApiKeyAuthConfigRequest()
        {
        }

    }
}
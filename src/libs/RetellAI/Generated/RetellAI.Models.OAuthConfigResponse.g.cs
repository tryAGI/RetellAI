
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OAuthConfigResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OAuthConfigResponseTypeJsonConverter))]
        public global::RetellAI.OAuthConfigResponseType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigResponse" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthConfigResponse(
            string clientId,
            global::RetellAI.OAuthConfigResponseType type)
        {
            this.Type = type;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigResponse" /> class.
        /// </summary>
        public OAuthConfigResponse()
        {
        }

    }
}
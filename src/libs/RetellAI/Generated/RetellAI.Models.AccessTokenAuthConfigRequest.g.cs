
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccessTokenAuthConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AccessTokenAuthConfigRequestTypeJsonConverter))]
        public global::RetellAI.AccessTokenAuthConfigRequestType Type { get; set; }

        /// <summary>
        /// OAuth-obtained access token used directly as a static bearer secret; stored encrypted at rest. An alternative to the OAuth connect flow, which persists the same config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenAuthConfigRequest" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// OAuth-obtained access token used directly as a static bearer secret; stored encrypted at rest. An alternative to the OAuth connect flow, which persists the same config.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessTokenAuthConfigRequest(
            string accessToken,
            global::RetellAI.AccessTokenAuthConfigRequestType type)
        {
            this.Type = type;
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenAuthConfigRequest" /> class.
        /// </summary>
        public AccessTokenAuthConfigRequest()
        {
        }

    }
}
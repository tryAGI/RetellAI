
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RefreshTokenAuthConfigRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.RefreshTokenAuthConfigRequestTypeJsonConverter))]
        public global::RetellAI.RefreshTokenAuthConfigRequestType Type { get; set; }

        /// <summary>
        /// OAuth refresh token; stored encrypted at rest. An alternative to the OAuth connect flow, which persists the same config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenAuthConfigRequest" /> class.
        /// </summary>
        /// <param name="refreshToken">
        /// OAuth refresh token; stored encrypted at rest. An alternative to the OAuth connect flow, which persists the same config.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefreshTokenAuthConfigRequest(
            string refreshToken,
            global::RetellAI.RefreshTokenAuthConfigRequestType type)
        {
            this.Type = type;
            this.RefreshToken = refreshToken ?? throw new global::System.ArgumentNullException(nameof(refreshToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenAuthConfigRequest" /> class.
        /// </summary>
        public RefreshTokenAuthConfigRequest()
        {
        }

    }
}
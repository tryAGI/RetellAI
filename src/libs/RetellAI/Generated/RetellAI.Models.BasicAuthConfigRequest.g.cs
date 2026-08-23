
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasicAuthConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.BasicAuthConfigRequestTypeJsonConverter))]
        public global::RetellAI.BasicAuthConfigRequestType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Password credential; stored encrypted at rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthConfigRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password">
        /// Password credential; stored encrypted at rest.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasicAuthConfigRequest(
            string username,
            string password,
            global::RetellAI.BasicAuthConfigRequestType type)
        {
            this.Type = type;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthConfigRequest" /> class.
        /// </summary>
        public BasicAuthConfigRequest()
        {
        }

    }
}
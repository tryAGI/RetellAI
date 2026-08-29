
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IceServer
    {
        /// <summary>
        /// Example: stun:stun.l.google.com:19302
        /// </summary>
        /// <example>stun:stun.l.google.com:19302</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.OneOf<string, global::System.Collections.Generic.IList<string>> Urls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IceServer" /> class.
        /// </summary>
        /// <param name="urls">
        /// Example: stun:stun.l.google.com:19302
        /// </param>
        /// <param name="username"></param>
        /// <param name="credential"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IceServer(
            global::RetellAI.OneOf<string, global::System.Collections.Generic.IList<string>> urls,
            string? username,
            string? credential)
        {
            this.Urls = urls;
            this.Username = username;
            this.Credential = credential;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IceServer" /> class.
        /// </summary>
        public IceServer()
        {
        }

    }
}
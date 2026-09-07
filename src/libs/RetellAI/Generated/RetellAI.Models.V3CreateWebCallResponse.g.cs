
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V3CreateWebCallResponse
    {
        /// <summary>
        /// Unique identifier for the web call.<br/>
        /// Example: call_Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>call_Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Token authorizing this browser to join the web call. Pass it to your frontend.<br/>
        /// Example: eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Connection transport to select in the web client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.V3CreateWebCallResponseTransportJsonConverter))]
        public global::RetellAI.V3CreateWebCallResponseTransport Transport { get; set; }

        /// <summary>
        /// ICE servers to configure before the browser creates its peer connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ice_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.IceServer> IceServers { get; set; }

        /// <summary>
        /// Unix epoch ms when the access_token expires.<br/>
        /// Example: 1735689600000
        /// </summary>
        /// <example>1735689600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V3CreateWebCallResponse" /> class.
        /// </summary>
        /// <param name="callId">
        /// Unique identifier for the web call.<br/>
        /// Example: call_Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="accessToken">
        /// Token authorizing this browser to join the web call. Pass it to your frontend.<br/>
        /// Example: eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p
        /// </param>
        /// <param name="iceServers">
        /// ICE servers to configure before the browser creates its peer connection.
        /// </param>
        /// <param name="expiresAt">
        /// Unix epoch ms when the access_token expires.<br/>
        /// Example: 1735689600000
        /// </param>
        /// <param name="transport">
        /// Connection transport to select in the web client.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V3CreateWebCallResponse(
            string callId,
            string accessToken,
            global::System.Collections.Generic.IList<global::RetellAI.IceServer> iceServers,
            long expiresAt,
            global::RetellAI.V3CreateWebCallResponseTransport transport)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.Transport = transport;
            this.IceServers = iceServers ?? throw new global::System.ArgumentNullException(nameof(iceServers));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3CreateWebCallResponse" /> class.
        /// </summary>
        public V3CreateWebCallResponse()
        {
        }

    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V3WebCallResponseVariant1
    {
        /// <summary>
        /// Type of the call. Used to distinguish between web call and phone call.<br/>
        /// Example: web_call
        /// </summary>
        /// <example>web_call</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.V3WebCallResponseVariant1CallTypeJsonConverter))]
        public global::RetellAI.V3WebCallResponseVariant1CallType CallType { get; set; }

        /// <summary>
        /// Access token to enter the web call room. This needs to be passed to your frontend to join the call.<br/>
        /// Example: eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Which media stack issued the access_token, and therefore where the client signals. The two tokens are indistinguishable, so a client must read this rather than infer it. `gateway` clients address Retell itself; `livekit` clients connect to the returned `url`. Optional only because a server predating the field omits it during a rollout; treat absent as `livekit`.<br/>
        /// Example: gateway
        /// </summary>
        /// <example>gateway</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CallTransportJsonConverter))]
        public global::RetellAI.CallTransport? Transport { get; set; }

        /// <summary>
        /// Public side of the gateway instance handling this call, for diagnostics only — the client's media address comes from the SDP answer's ICE candidates. `gateway` transport only.<br/>
        /// Example: 54.183.22.7
        /// </summary>
        /// <example>54.183.22.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateway_ip")]
        public string? GatewayIp { get; set; }

        /// <summary>
        /// ICE servers the client must configure before creating its PeerConnection — they cannot be added afterwards. `gateway` transport only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ice_servers")]
        public global::System.Collections.Generic.IList<global::RetellAI.IceServer>? IceServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V3WebCallResponseVariant1" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// Access token to enter the web call room. This needs to be passed to your frontend to join the call.<br/>
        /// Example: eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p
        /// </param>
        /// <param name="callType">
        /// Type of the call. Used to distinguish between web call and phone call.<br/>
        /// Example: web_call
        /// </param>
        /// <param name="transport">
        /// Which media stack issued the access_token, and therefore where the client signals. The two tokens are indistinguishable, so a client must read this rather than infer it. `gateway` clients address Retell itself; `livekit` clients connect to the returned `url`. Optional only because a server predating the field omits it during a rollout; treat absent as `livekit`.<br/>
        /// Example: gateway
        /// </param>
        /// <param name="gatewayIp">
        /// Public side of the gateway instance handling this call, for diagnostics only — the client's media address comes from the SDP answer's ICE candidates. `gateway` transport only.<br/>
        /// Example: 54.183.22.7
        /// </param>
        /// <param name="iceServers">
        /// ICE servers the client must configure before creating its PeerConnection — they cannot be added afterwards. `gateway` transport only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V3WebCallResponseVariant1(
            string accessToken,
            global::RetellAI.V3WebCallResponseVariant1CallType callType,
            global::RetellAI.CallTransport? transport,
            string? gatewayIp,
            global::System.Collections.Generic.IList<global::RetellAI.IceServer>? iceServers)
        {
            this.CallType = callType;
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.Transport = transport;
            this.GatewayIp = gatewayIp;
            this.IceServers = iceServers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3WebCallResponseVariant1" /> class.
        /// </summary>
        public V3WebCallResponseVariant1()
        {
        }

    }
}
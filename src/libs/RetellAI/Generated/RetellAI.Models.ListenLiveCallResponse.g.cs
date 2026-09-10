
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenLiveCallResponse
    {
        /// <summary>
        /// Which media stack issued the access_token, and therefore where the client signals. The two tokens are indistinguishable, so a client must read this rather than infer it. `gateway` clients address Retell itself; `livekit` clients connect to the returned `url`. Optional only because a server predating the field omits it during a rollout; treat absent as `livekit`.<br/>
        /// Example: gateway
        /// </summary>
        /// <example>gateway</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CallTransportJsonConverter))]
        public global::RetellAI.CallTransport? Transport { get; set; }

        /// <summary>
        /// Server URL the client should connect to with the access_token. Present only when `transport` is `livekit`; a `gateway` listener signals to Retell and needs no address.<br/>
        /// Example: wss://realtime-host.example.com
        /// </summary>
        /// <example>wss://realtime-host.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Subscribe-only JWT scoped to the call's room. Cannot publish. Listener participant is hidden from other participants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Room name to join. Always the call's original room — does not follow warm transfers.<br/>
        /// Example: web_call_119c3f8e47135a29e65947eeb34cf12d
        /// </summary>
        /// <example>web_call_119c3f8e47135a29e65947eeb34cf12d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("room_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoomName { get; set; }

        /// <summary>
        /// Public side of the gateway instance handling this call, for diagnostics only — the client's media address comes from the SDP answer's ICE candidates. `gateway` transport only.<br/>
        /// Example: 54.183.22.7
        /// </summary>
        /// <example>54.183.22.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateway_ip")]
        public string? GatewayIp { get; set; }

        /// <summary>
        /// Identity this listener joins as, and the value to hand back to /v2/take-over-live-call. Returned on both transports; a `livekit` client can equally read it off its own room object, a `gateway` one has no equivalent to read.<br/>
        /// Example: listener_a1b2c3d4e5f6g7h8i9j0
        /// </summary>
        /// <example>listener_a1b2c3d4e5f6g7h8i9j0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("participant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParticipantId { get; set; }

        /// <summary>
        /// ICE servers the client must configure before creating its PeerConnection — they cannot be added afterwards. `gateway` transport only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ice_servers")]
        public global::System.Collections.Generic.IList<global::RetellAI.IceServer>? IceServers { get; set; }

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
        /// Initializes a new instance of the <see cref="ListenLiveCallResponse" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// Subscribe-only JWT scoped to the call's room. Cannot publish. Listener participant is hidden from other participants.
        /// </param>
        /// <param name="roomName">
        /// Room name to join. Always the call's original room — does not follow warm transfers.<br/>
        /// Example: web_call_119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="participantId">
        /// Identity this listener joins as, and the value to hand back to /v2/take-over-live-call. Returned on both transports; a `livekit` client can equally read it off its own room object, a `gateway` one has no equivalent to read.<br/>
        /// Example: listener_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="expiresAt">
        /// Unix epoch ms when the access_token expires.<br/>
        /// Example: 1735689600000
        /// </param>
        /// <param name="transport">
        /// Which media stack issued the access_token, and therefore where the client signals. The two tokens are indistinguishable, so a client must read this rather than infer it. `gateway` clients address Retell itself; `livekit` clients connect to the returned `url`. Optional only because a server predating the field omits it during a rollout; treat absent as `livekit`.<br/>
        /// Example: gateway
        /// </param>
        /// <param name="url">
        /// Server URL the client should connect to with the access_token. Present only when `transport` is `livekit`; a `gateway` listener signals to Retell and needs no address.<br/>
        /// Example: wss://realtime-host.example.com
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
        public ListenLiveCallResponse(
            string accessToken,
            string roomName,
            string participantId,
            long expiresAt,
            global::RetellAI.CallTransport? transport,
            string? url,
            string? gatewayIp,
            global::System.Collections.Generic.IList<global::RetellAI.IceServer>? iceServers)
        {
            this.Transport = transport;
            this.Url = url;
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.GatewayIp = gatewayIp;
            this.ParticipantId = participantId ?? throw new global::System.ArgumentNullException(nameof(participantId));
            this.IceServers = iceServers;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenLiveCallResponse" /> class.
        /// </summary>
        public ListenLiveCallResponse()
        {
        }

    }
}
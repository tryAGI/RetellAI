
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneNumberResponseSipOutboundTrunkConfig
    {
        /// <summary>
        /// The termination URI for the SIP trunk for the phone number.<br/>
        /// Example: someuri.pstn.twilio.com
        /// </summary>
        /// <example>someuri.pstn.twilio.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_uri")]
        public string? TerminationUri { get; set; }

        /// <summary>
        /// The username used for authenticating the SIP trunk for the phone number.<br/>
        /// Example: username
        /// </summary>
        /// <example>username</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_username")]
        public string? AuthUsername { get; set; }

        /// <summary>
        /// Outbound transport protocol for the SIP trunk for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </summary>
        /// <example>TCP</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public string? Transport { get; set; }

        /// <summary>
        /// SIP codec preferences for custom phone numbers only, used for inbound and outbound gateway calls. Retell-managed Twilio and Telnyx phone numbers do not support this setting. An empty list uses the gateway's default codecs. Codec names are extensible and are not limited to the examples.<br/>
        /// Example: [PCMU, PCMA, G.722]
        /// </summary>
        /// <example>[PCMU, PCMA, G.722]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("codecs")]
        public global::System.Collections.Generic.IList<string>? Codecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberResponseSipOutboundTrunkConfig" /> class.
        /// </summary>
        /// <param name="terminationUri">
        /// The termination URI for the SIP trunk for the phone number.<br/>
        /// Example: someuri.pstn.twilio.com
        /// </param>
        /// <param name="authUsername">
        /// The username used for authenticating the SIP trunk for the phone number.<br/>
        /// Example: username
        /// </param>
        /// <param name="transport">
        /// Outbound transport protocol for the SIP trunk for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </param>
        /// <param name="codecs">
        /// SIP codec preferences for custom phone numbers only, used for inbound and outbound gateway calls. Retell-managed Twilio and Telnyx phone numbers do not support this setting. An empty list uses the gateway's default codecs. Codec names are extensible and are not limited to the examples.<br/>
        /// Example: [PCMU, PCMA, G.722]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberResponseSipOutboundTrunkConfig(
            string? terminationUri,
            string? authUsername,
            string? transport,
            global::System.Collections.Generic.IList<string>? codecs)
        {
            this.TerminationUri = terminationUri;
            this.AuthUsername = authUsername;
            this.Transport = transport;
            this.Codecs = codecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberResponseSipOutboundTrunkConfig" /> class.
        /// </summary>
        public PhoneNumberResponseSipOutboundTrunkConfig()
        {
        }

    }
}
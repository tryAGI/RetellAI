
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Calls Per Second (CPS) configuration for different telephony providers
    /// </summary>
    public sealed partial class CpsConfig
    {
        /// <summary>
        /// CPS limit for Twilio provider (1-5)<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio")]
        public int? Twilio { get; set; }

        /// <summary>
        /// CPS limit for Telnyx provider (1-16)<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("telnyx")]
        public int? Telnyx { get; set; }

        /// <summary>
        /// CPS limit for custom provider (1-150). Check your custom telephony provider for CPS limits; Retell will smooth outbound dialing to fit the configured limit.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public int? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CpsConfig" /> class.
        /// </summary>
        /// <param name="twilio">
        /// CPS limit for Twilio provider (1-5)<br/>
        /// Example: 3
        /// </param>
        /// <param name="telnyx">
        /// CPS limit for Telnyx provider (1-16)<br/>
        /// Example: 10
        /// </param>
        /// <param name="custom">
        /// CPS limit for custom provider (1-150). Check your custom telephony provider for CPS limits; Retell will smooth outbound dialing to fit the configured limit.<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CpsConfig(
            int? twilio,
            int? telnyx,
            int? custom)
        {
            this.Twilio = twilio;
            this.Telnyx = telnyx;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CpsConfig" /> class.
        /// </summary>
        public CpsConfig()
        {
        }

    }
}
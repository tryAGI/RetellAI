
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Which media stack issued the access_token, and therefore where the client signals. The two tokens are indistinguishable, so a client must read this rather than infer it. `gateway` clients address Retell itself; `livekit` clients connect to the returned `url`. Optional only because a server predating the field omits it during a rollout; treat absent as `livekit`.<br/>
    /// Example: gateway
    /// </summary>
    public enum CallTransport
    {
        /// <summary>
        ///
        /// </summary>
        Gateway,
        /// <summary>
        ///
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallTransport value)
        {
            return value switch
            {
                CallTransport.Gateway => "gateway",
                CallTransport.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallTransport? ToEnum(string value)
        {
            return value switch
            {
                "gateway" => CallTransport.Gateway,
                "livekit" => CallTransport.Livekit,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Connection transport to select in the web client.
    /// </summary>
    public enum V3CreateWebCallResponseTransport
    {
        /// <summary>
        ///
        /// </summary>
        Gateway,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V3CreateWebCallResponseTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V3CreateWebCallResponseTransport value)
        {
            return value switch
            {
                V3CreateWebCallResponseTransport.Gateway => "gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V3CreateWebCallResponseTransport? ToEnum(string value)
        {
            return value switch
            {
                "gateway" => V3CreateWebCallResponseTransport.Gateway,
                _ => null,
            };
        }
    }
}
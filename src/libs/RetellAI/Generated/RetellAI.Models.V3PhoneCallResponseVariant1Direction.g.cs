
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Direction of the phone call.<br/>
    /// Example: inbound
    /// </summary>
    public enum V3PhoneCallResponseVariant1Direction
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V3PhoneCallResponseVariant1DirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V3PhoneCallResponseVariant1Direction value)
        {
            return value switch
            {
                V3PhoneCallResponseVariant1Direction.Inbound => "inbound",
                V3PhoneCallResponseVariant1Direction.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V3PhoneCallResponseVariant1Direction? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => V3PhoneCallResponseVariant1Direction.Inbound,
                "outbound" => V3PhoneCallResponseVariant1Direction.Outbound,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BasicAuthConfigResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BasicAuthConfigResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BasicAuthConfigResponseType value)
        {
            return value switch
            {
                BasicAuthConfigResponseType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BasicAuthConfigResponseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => BasicAuthConfigResponseType.Basic,
                _ => null,
            };
        }
    }
}
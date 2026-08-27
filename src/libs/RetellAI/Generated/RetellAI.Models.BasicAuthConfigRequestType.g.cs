
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BasicAuthConfigRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BasicAuthConfigRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BasicAuthConfigRequestType value)
        {
            return value switch
            {
                BasicAuthConfigRequestType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BasicAuthConfigRequestType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => BasicAuthConfigRequestType.Basic,
                _ => null,
            };
        }
    }
}
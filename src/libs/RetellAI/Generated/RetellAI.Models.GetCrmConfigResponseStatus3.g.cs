
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCrmConfigResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCrmConfigResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCrmConfigResponseStatus3 value)
        {
            return value switch
            {
                GetCrmConfigResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCrmConfigResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCrmConfigResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
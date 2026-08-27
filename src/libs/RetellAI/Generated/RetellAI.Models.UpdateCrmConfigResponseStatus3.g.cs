
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateCrmConfigResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCrmConfigResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCrmConfigResponseStatus3 value)
        {
            return value switch
            {
                UpdateCrmConfigResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCrmConfigResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCrmConfigResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
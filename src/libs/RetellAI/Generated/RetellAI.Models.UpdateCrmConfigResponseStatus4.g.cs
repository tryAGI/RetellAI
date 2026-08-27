
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateCrmConfigResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCrmConfigResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCrmConfigResponseStatus4 value)
        {
            return value switch
            {
                UpdateCrmConfigResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCrmConfigResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCrmConfigResponseStatus4.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCrmConfigResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCrmConfigResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCrmConfigResponseStatus5 value)
        {
            return value switch
            {
                UpdateCrmConfigResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCrmConfigResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCrmConfigResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
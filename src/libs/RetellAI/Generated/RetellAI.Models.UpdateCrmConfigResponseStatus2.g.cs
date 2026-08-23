
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCrmConfigResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCrmConfigResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCrmConfigResponseStatus2 value)
        {
            return value switch
            {
                UpdateCrmConfigResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCrmConfigResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCrmConfigResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
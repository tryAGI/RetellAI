
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRetellLLMResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRetellLLMResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRetellLLMResponseStatus5 value)
        {
            return value switch
            {
                UpdateRetellLLMResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRetellLLMResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateRetellLLMResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
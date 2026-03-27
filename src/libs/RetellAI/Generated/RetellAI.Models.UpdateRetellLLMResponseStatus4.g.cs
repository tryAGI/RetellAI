
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRetellLLMResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRetellLLMResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRetellLLMResponseStatus4 value)
        {
            return value switch
            {
                UpdateRetellLLMResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRetellLLMResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateRetellLLMResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
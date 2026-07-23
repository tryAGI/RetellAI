
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRetellLLMResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRetellLLMResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRetellLLMResponseStatus3 value)
        {
            return value switch
            {
                ListRetellLLMResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRetellLLMResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListRetellLLMResponseStatus3.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListRetellLLMResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRetellLLMResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRetellLLMResponseStatus4 value)
        {
            return value switch
            {
                ListRetellLLMResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRetellLLMResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListRetellLLMResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
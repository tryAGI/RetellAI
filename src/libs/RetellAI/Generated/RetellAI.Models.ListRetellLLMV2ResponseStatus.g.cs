
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRetellLLMV2ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRetellLLMV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRetellLLMV2ResponseStatus value)
        {
            return value switch
            {
                ListRetellLLMV2ResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRetellLLMV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListRetellLLMV2ResponseStatus.Error,
                _ => null,
            };
        }
    }
}
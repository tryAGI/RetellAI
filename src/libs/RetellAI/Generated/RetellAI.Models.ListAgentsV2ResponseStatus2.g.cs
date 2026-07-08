
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAgentsV2ResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentsV2ResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsV2ResponseStatus2 value)
        {
            return value switch
            {
                ListAgentsV2ResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsV2ResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListAgentsV2ResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
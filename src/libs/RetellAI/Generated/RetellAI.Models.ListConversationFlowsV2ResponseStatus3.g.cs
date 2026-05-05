
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowsV2ResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowsV2ResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsV2ResponseStatus3 value)
        {
            return value switch
            {
                ListConversationFlowsV2ResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsV2ResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowsV2ResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
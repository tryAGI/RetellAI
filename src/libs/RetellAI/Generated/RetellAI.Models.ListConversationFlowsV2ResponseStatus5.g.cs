
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowsV2ResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowsV2ResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsV2ResponseStatus5 value)
        {
            return value switch
            {
                ListConversationFlowsV2ResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsV2ResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowsV2ResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
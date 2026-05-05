
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowsV2ResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowsV2ResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsV2ResponseStatus4 value)
        {
            return value switch
            {
                ListConversationFlowsV2ResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsV2ResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowsV2ResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
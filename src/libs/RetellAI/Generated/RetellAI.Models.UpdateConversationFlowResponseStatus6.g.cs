
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConversationFlowResponseStatus6
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConversationFlowResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationFlowResponseStatus6 value)
        {
            return value switch
            {
                UpdateConversationFlowResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationFlowResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateConversationFlowResponseStatus6.Error,
                _ => null,
            };
        }
    }
}
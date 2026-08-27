
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConversationFlowComponentResponseStatus6
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConversationFlowComponentResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationFlowComponentResponseStatus6 value)
        {
            return value switch
            {
                UpdateConversationFlowComponentResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationFlowComponentResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateConversationFlowComponentResponseStatus6.Error,
                _ => null,
            };
        }
    }
}
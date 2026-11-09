
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RecordChatMessageResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordChatMessageResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordChatMessageResponseStatus3 value)
        {
            return value switch
            {
                RecordChatMessageResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordChatMessageResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => RecordChatMessageResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
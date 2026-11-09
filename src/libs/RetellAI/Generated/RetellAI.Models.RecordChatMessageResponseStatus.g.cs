
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RecordChatMessageResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordChatMessageResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordChatMessageResponseStatus value)
        {
            return value switch
            {
                RecordChatMessageResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordChatMessageResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => RecordChatMessageResponseStatus.Error,
                _ => null,
            };
        }
    }
}
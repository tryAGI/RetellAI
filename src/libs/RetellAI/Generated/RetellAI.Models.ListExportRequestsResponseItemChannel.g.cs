
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListExportRequestsResponseItemChannel
    {
        /// <summary>
        ///
        /// </summary>
        Call,
        /// <summary>
        ///
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExportRequestsResponseItemChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsResponseItemChannel value)
        {
            return value switch
            {
                ListExportRequestsResponseItemChannel.Call => "call",
                ListExportRequestsResponseItemChannel.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsResponseItemChannel? ToEnum(string value)
        {
            return value switch
            {
                "call" => ListExportRequestsResponseItemChannel.Call,
                "chat" => ListExportRequestsResponseItemChannel.Chat,
                _ => null,
            };
        }
    }
}
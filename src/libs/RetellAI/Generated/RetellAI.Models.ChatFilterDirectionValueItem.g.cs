
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatFilterDirectionValueItem
    {
        /// <summary>
        ///
        /// </summary>
        Inbound,
        /// <summary>
        ///
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFilterDirectionValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFilterDirectionValueItem value)
        {
            return value switch
            {
                ChatFilterDirectionValueItem.Inbound => "inbound",
                ChatFilterDirectionValueItem.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFilterDirectionValueItem? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ChatFilterDirectionValueItem.Inbound,
                "outbound" => ChatFilterDirectionValueItem.Outbound,
                _ => null,
            };
        }
    }
}
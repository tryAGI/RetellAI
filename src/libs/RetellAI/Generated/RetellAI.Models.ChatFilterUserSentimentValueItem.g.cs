
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatFilterUserSentimentValueItem
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Positive,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFilterUserSentimentValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFilterUserSentimentValueItem value)
        {
            return value switch
            {
                ChatFilterUserSentimentValueItem.Negative => "Negative",
                ChatFilterUserSentimentValueItem.Neutral => "Neutral",
                ChatFilterUserSentimentValueItem.Positive => "Positive",
                ChatFilterUserSentimentValueItem.Unknown => "Unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFilterUserSentimentValueItem? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => ChatFilterUserSentimentValueItem.Negative,
                "Neutral" => ChatFilterUserSentimentValueItem.Neutral,
                "Positive" => ChatFilterUserSentimentValueItem.Positive,
                "Unknown" => ChatFilterUserSentimentValueItem.Unknown,
                _ => null,
            };
        }
    }
}
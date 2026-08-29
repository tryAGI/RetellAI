
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// User sentiment from Post Chat Extraction.
    /// </summary>
    public enum ContactChatSentiment
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
    public static class ContactChatSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactChatSentiment value)
        {
            return value switch
            {
                ContactChatSentiment.Negative => "Negative",
                ContactChatSentiment.Neutral => "Neutral",
                ContactChatSentiment.Positive => "Positive",
                ContactChatSentiment.Unknown => "Unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactChatSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => ContactChatSentiment.Negative,
                "Neutral" => ContactChatSentiment.Neutral,
                "Positive" => ContactChatSentiment.Positive,
                "Unknown" => ContactChatSentiment.Unknown,
                _ => null,
            };
        }
    }
}
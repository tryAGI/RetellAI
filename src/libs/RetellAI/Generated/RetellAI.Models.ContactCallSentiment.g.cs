
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// User sentiment from Post Call Extraction.
    /// </summary>
    public enum ContactCallSentiment
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
    public static class ContactCallSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactCallSentiment value)
        {
            return value switch
            {
                ContactCallSentiment.Negative => "Negative",
                ContactCallSentiment.Neutral => "Neutral",
                ContactCallSentiment.Positive => "Positive",
                ContactCallSentiment.Unknown => "Unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactCallSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => ContactCallSentiment.Negative,
                "Neutral" => ContactCallSentiment.Neutral,
                "Positive" => ContactCallSentiment.Positive,
                "Unknown" => ContactCallSentiment.Unknown,
                _ => null,
            };
        }
    }
}
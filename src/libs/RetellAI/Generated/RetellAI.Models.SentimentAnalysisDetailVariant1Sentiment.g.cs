
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sentiment detected during the time range.
    /// </summary>
    public enum SentimentAnalysisDetailVariant1Sentiment
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentAnalysisDetailVariant1SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentAnalysisDetailVariant1Sentiment value)
        {
            return value switch
            {
                SentimentAnalysisDetailVariant1Sentiment.Negative => "Negative",
                SentimentAnalysisDetailVariant1Sentiment.Neutral => "Neutral",
                SentimentAnalysisDetailVariant1Sentiment.Positive => "Positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentAnalysisDetailVariant1Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => SentimentAnalysisDetailVariant1Sentiment.Negative,
                "Neutral" => SentimentAnalysisDetailVariant1Sentiment.Neutral,
                "Positive" => SentimentAnalysisDetailVariant1Sentiment.Positive,
                _ => null,
            };
        }
    }
}
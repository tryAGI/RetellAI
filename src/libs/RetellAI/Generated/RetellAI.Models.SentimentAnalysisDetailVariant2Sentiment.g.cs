
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sentiment detected for the response.
    /// </summary>
    public enum SentimentAnalysisDetailVariant2Sentiment
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
    public static class SentimentAnalysisDetailVariant2SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentAnalysisDetailVariant2Sentiment value)
        {
            return value switch
            {
                SentimentAnalysisDetailVariant2Sentiment.Negative => "Negative",
                SentimentAnalysisDetailVariant2Sentiment.Neutral => "Neutral",
                SentimentAnalysisDetailVariant2Sentiment.Positive => "Positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentAnalysisDetailVariant2Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => SentimentAnalysisDetailVariant2Sentiment.Negative,
                "Neutral" => SentimentAnalysisDetailVariant2Sentiment.Neutral,
                "Positive" => SentimentAnalysisDetailVariant2Sentiment.Positive,
                _ => null,
            };
        }
    }
}
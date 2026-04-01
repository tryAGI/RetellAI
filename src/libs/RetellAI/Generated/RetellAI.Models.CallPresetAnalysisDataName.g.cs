
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Preset identifier for voice agent analysis.<br/>
    /// Example: call_summary
    /// </summary>
    public enum CallPresetAnalysisDataName
    {
        /// <summary>
        /// 
        /// </summary>
        CallSuccessful,
        /// <summary>
        /// 
        /// </summary>
        CallSummary,
        /// <summary>
        /// 
        /// </summary>
        UserSentiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallPresetAnalysisDataNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallPresetAnalysisDataName value)
        {
            return value switch
            {
                CallPresetAnalysisDataName.CallSuccessful => "call_successful",
                CallPresetAnalysisDataName.CallSummary => "call_summary",
                CallPresetAnalysisDataName.UserSentiment => "user_sentiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallPresetAnalysisDataName? ToEnum(string value)
        {
            return value switch
            {
                "call_successful" => CallPresetAnalysisDataName.CallSuccessful,
                "call_summary" => CallPresetAnalysisDataName.CallSummary,
                "user_sentiment" => CallPresetAnalysisDataName.UserSentiment,
                _ => null,
            };
        }
    }
}
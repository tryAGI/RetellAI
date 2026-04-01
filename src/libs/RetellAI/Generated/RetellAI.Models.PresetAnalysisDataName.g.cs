
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Preset identifier. Use call_summary/call_successful for voice; chat_summary/chat_successful for chat; user_sentiment for both.<br/>
    /// Example: call_summary
    /// </summary>
    public enum PresetAnalysisDataName
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
        ChatSuccessful,
        /// <summary>
        /// 
        /// </summary>
        ChatSummary,
        /// <summary>
        /// 
        /// </summary>
        UserSentiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresetAnalysisDataNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetAnalysisDataName value)
        {
            return value switch
            {
                PresetAnalysisDataName.CallSuccessful => "call_successful",
                PresetAnalysisDataName.CallSummary => "call_summary",
                PresetAnalysisDataName.ChatSuccessful => "chat_successful",
                PresetAnalysisDataName.ChatSummary => "chat_summary",
                PresetAnalysisDataName.UserSentiment => "user_sentiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetAnalysisDataName? ToEnum(string value)
        {
            return value switch
            {
                "call_successful" => PresetAnalysisDataName.CallSuccessful,
                "call_summary" => PresetAnalysisDataName.CallSummary,
                "chat_successful" => PresetAnalysisDataName.ChatSuccessful,
                "chat_summary" => PresetAnalysisDataName.ChatSummary,
                "user_sentiment" => PresetAnalysisDataName.UserSentiment,
                _ => null,
            };
        }
    }
}
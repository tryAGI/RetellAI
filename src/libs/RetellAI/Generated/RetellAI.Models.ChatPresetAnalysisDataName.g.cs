
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Preset identifier for chat agent analysis.<br/>
    /// Example: chat_summary
    /// </summary>
    public enum ChatPresetAnalysisDataName
    {
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
    public static class ChatPresetAnalysisDataNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatPresetAnalysisDataName value)
        {
            return value switch
            {
                ChatPresetAnalysisDataName.ChatSuccessful => "chat_successful",
                ChatPresetAnalysisDataName.ChatSummary => "chat_summary",
                ChatPresetAnalysisDataName.UserSentiment => "user_sentiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatPresetAnalysisDataName? ToEnum(string value)
        {
            return value switch
            {
                "chat_successful" => ChatPresetAnalysisDataName.ChatSuccessful,
                "chat_summary" => ChatPresetAnalysisDataName.ChatSummary,
                "user_sentiment" => ChatPresetAnalysisDataName.UserSentiment,
                _ => null,
            };
        }
    }
}
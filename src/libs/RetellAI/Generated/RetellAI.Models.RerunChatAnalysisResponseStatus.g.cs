
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RerunChatAnalysisResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunChatAnalysisResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunChatAnalysisResponseStatus value)
        {
            return value switch
            {
                RerunChatAnalysisResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunChatAnalysisResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunChatAnalysisResponseStatus.Error,
                _ => null,
            };
        }
    }
}
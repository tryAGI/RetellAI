
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RerunChatAnalysisResponseStatus5
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunChatAnalysisResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunChatAnalysisResponseStatus5 value)
        {
            return value switch
            {
                RerunChatAnalysisResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunChatAnalysisResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunChatAnalysisResponseStatus5.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RerunChatAnalysisResponseStatus7
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunChatAnalysisResponseStatus7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunChatAnalysisResponseStatus7 value)
        {
            return value switch
            {
                RerunChatAnalysisResponseStatus7.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunChatAnalysisResponseStatus7? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunChatAnalysisResponseStatus7.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RerunChatAnalysisResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunChatAnalysisResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunChatAnalysisResponseStatus3 value)
        {
            return value switch
            {
                RerunChatAnalysisResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunChatAnalysisResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunChatAnalysisResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
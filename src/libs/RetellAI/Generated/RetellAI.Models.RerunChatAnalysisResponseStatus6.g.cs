
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RerunChatAnalysisResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunChatAnalysisResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunChatAnalysisResponseStatus6 value)
        {
            return value switch
            {
                RerunChatAnalysisResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunChatAnalysisResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunChatAnalysisResponseStatus6.Error,
                _ => null,
            };
        }
    }
}
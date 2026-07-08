
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RerunCallAnalysisResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunCallAnalysisResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunCallAnalysisResponseStatus5 value)
        {
            return value switch
            {
                RerunCallAnalysisResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunCallAnalysisResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunCallAnalysisResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
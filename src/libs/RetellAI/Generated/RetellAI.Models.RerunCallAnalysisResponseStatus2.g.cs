
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RerunCallAnalysisResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunCallAnalysisResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunCallAnalysisResponseStatus2 value)
        {
            return value switch
            {
                RerunCallAnalysisResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunCallAnalysisResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunCallAnalysisResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
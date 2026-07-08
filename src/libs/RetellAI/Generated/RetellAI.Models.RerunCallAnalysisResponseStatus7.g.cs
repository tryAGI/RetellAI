
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RerunCallAnalysisResponseStatus7
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunCallAnalysisResponseStatus7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunCallAnalysisResponseStatus7 value)
        {
            return value switch
            {
                RerunCallAnalysisResponseStatus7.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunCallAnalysisResponseStatus7? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunCallAnalysisResponseStatus7.Error,
                _ => null,
            };
        }
    }
}
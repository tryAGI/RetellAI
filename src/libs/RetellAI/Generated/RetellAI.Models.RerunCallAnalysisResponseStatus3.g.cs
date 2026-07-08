
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RerunCallAnalysisResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunCallAnalysisResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunCallAnalysisResponseStatus3 value)
        {
            return value switch
            {
                RerunCallAnalysisResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunCallAnalysisResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunCallAnalysisResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
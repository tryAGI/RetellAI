
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RerunCallAnalysisResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerunCallAnalysisResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerunCallAnalysisResponseStatus value)
        {
            return value switch
            {
                RerunCallAnalysisResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerunCallAnalysisResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => RerunCallAnalysisResponseStatus.Error,
                _ => null,
            };
        }
    }
}
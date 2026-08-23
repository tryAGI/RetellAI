
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackfillContactAnalysisDataResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackfillContactAnalysisDataResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackfillContactAnalysisDataResponseStatus2 value)
        {
            return value switch
            {
                BackfillContactAnalysisDataResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackfillContactAnalysisDataResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => BackfillContactAnalysisDataResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
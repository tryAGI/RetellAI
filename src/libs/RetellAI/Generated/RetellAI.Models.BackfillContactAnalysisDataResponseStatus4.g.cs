
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackfillContactAnalysisDataResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackfillContactAnalysisDataResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackfillContactAnalysisDataResponseStatus4 value)
        {
            return value switch
            {
                BackfillContactAnalysisDataResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackfillContactAnalysisDataResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => BackfillContactAnalysisDataResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
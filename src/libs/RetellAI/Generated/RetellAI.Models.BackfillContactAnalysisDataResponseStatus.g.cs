
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BackfillContactAnalysisDataResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackfillContactAnalysisDataResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackfillContactAnalysisDataResponseStatus value)
        {
            return value switch
            {
                BackfillContactAnalysisDataResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackfillContactAnalysisDataResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => BackfillContactAnalysisDataResponseStatus.Error,
                _ => null,
            };
        }
    }
}
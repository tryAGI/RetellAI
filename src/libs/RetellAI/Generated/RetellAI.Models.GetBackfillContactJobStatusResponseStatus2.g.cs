
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBackfillContactJobStatusResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBackfillContactJobStatusResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBackfillContactJobStatusResponseStatus2 value)
        {
            return value switch
            {
                GetBackfillContactJobStatusResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBackfillContactJobStatusResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetBackfillContactJobStatusResponseStatus2.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBackfillContactJobStatusResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBackfillContactJobStatusResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBackfillContactJobStatusResponseStatus3 value)
        {
            return value switch
            {
                GetBackfillContactJobStatusResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBackfillContactJobStatusResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetBackfillContactJobStatusResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
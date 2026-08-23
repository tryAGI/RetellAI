
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSyncJobStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSyncJobStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSyncJobStatusResponseStatus value)
        {
            return value switch
            {
                GetSyncJobStatusResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSyncJobStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetSyncJobStatusResponseStatus.Error,
                _ => null,
            };
        }
    }
}
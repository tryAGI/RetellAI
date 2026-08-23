
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatusStatus value)
        {
            return value switch
            {
                JobStatusStatus.Idle => "idle",
                JobStatusStatus.Queued => "queued",
                JobStatusStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "idle" => JobStatusStatus.Idle,
                "queued" => JobStatusStatus.Queued,
                "running" => JobStatusStatus.Running,
                _ => null,
            };
        }
    }
}
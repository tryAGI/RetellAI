
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Whether the job was started by an explicit API call (`manual`) or by the scheduled sync (`cron`).
    /// </summary>
    public enum JobStatusTriggeredBy
    {
        /// <summary>
        ///
        /// </summary>
        Cron,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStatusTriggeredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatusTriggeredBy value)
        {
            return value switch
            {
                JobStatusTriggeredBy.Cron => "cron",
                JobStatusTriggeredBy.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatusTriggeredBy? ToEnum(string value)
        {
            return value switch
            {
                "cron" => JobStatusTriggeredBy.Cron,
                "manual" => JobStatusTriggeredBy.Manual,
                _ => null,
            };
        }
    }
}
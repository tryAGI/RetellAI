
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum StopCallResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopCallResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopCallResponseStatus value)
        {
            return value switch
            {
                StopCallResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopCallResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => StopCallResponseStatus.Error,
                _ => null,
            };
        }
    }
}
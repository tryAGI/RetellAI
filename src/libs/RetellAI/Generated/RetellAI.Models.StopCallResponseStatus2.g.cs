
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum StopCallResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopCallResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopCallResponseStatus2 value)
        {
            return value switch
            {
                StopCallResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopCallResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => StopCallResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
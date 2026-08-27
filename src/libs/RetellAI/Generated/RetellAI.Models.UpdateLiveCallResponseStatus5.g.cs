
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateLiveCallResponseStatus5
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLiveCallResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLiveCallResponseStatus5 value)
        {
            return value switch
            {
                UpdateLiveCallResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLiveCallResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateLiveCallResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
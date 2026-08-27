
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateLiveCallResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLiveCallResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLiveCallResponseStatus2 value)
        {
            return value switch
            {
                UpdateLiveCallResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLiveCallResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateLiveCallResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
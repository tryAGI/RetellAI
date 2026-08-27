
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateLiveCallResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLiveCallResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLiveCallResponseStatus4 value)
        {
            return value switch
            {
                UpdateLiveCallResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLiveCallResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateLiveCallResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
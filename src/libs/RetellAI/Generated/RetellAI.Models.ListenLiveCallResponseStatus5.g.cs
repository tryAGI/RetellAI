
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListenLiveCallResponseStatus5
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenLiveCallResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenLiveCallResponseStatus5 value)
        {
            return value switch
            {
                ListenLiveCallResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenLiveCallResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListenLiveCallResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
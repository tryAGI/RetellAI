
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListenLiveCallResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenLiveCallResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenLiveCallResponseStatus3 value)
        {
            return value switch
            {
                ListenLiveCallResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenLiveCallResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListenLiveCallResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
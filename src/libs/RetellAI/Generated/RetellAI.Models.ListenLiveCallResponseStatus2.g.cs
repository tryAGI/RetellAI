
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListenLiveCallResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenLiveCallResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenLiveCallResponseStatus2 value)
        {
            return value switch
            {
                ListenLiveCallResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenLiveCallResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListenLiveCallResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
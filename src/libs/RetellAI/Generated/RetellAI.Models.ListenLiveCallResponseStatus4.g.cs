
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListenLiveCallResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenLiveCallResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenLiveCallResponseStatus4 value)
        {
            return value switch
            {
                ListenLiveCallResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenLiveCallResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListenLiveCallResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
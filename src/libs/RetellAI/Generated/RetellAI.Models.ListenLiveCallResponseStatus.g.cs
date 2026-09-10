
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListenLiveCallResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenLiveCallResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenLiveCallResponseStatus value)
        {
            return value switch
            {
                ListenLiveCallResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenLiveCallResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListenLiveCallResponseStatus.Error,
                _ => null,
            };
        }
    }
}
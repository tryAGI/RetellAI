
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TakeOverLiveCallResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TakeOverLiveCallResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TakeOverLiveCallResponseStatus4 value)
        {
            return value switch
            {
                TakeOverLiveCallResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TakeOverLiveCallResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => TakeOverLiveCallResponseStatus4.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TakeOverLiveCallResponseStatus5
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TakeOverLiveCallResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TakeOverLiveCallResponseStatus5 value)
        {
            return value switch
            {
                TakeOverLiveCallResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TakeOverLiveCallResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => TakeOverLiveCallResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
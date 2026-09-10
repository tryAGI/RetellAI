
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TakeOverLiveCallResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TakeOverLiveCallResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TakeOverLiveCallResponseStatus2 value)
        {
            return value switch
            {
                TakeOverLiveCallResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TakeOverLiveCallResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => TakeOverLiveCallResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
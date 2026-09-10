
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TakeOverLiveCallResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TakeOverLiveCallResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TakeOverLiveCallResponseStatus3 value)
        {
            return value switch
            {
                TakeOverLiveCallResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TakeOverLiveCallResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => TakeOverLiveCallResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
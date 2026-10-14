
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TakeOverLiveCallResponseStatus6
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TakeOverLiveCallResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TakeOverLiveCallResponseStatus6 value)
        {
            return value switch
            {
                TakeOverLiveCallResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TakeOverLiveCallResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => TakeOverLiveCallResponseStatus6.Error,
                _ => null,
            };
        }
    }
}
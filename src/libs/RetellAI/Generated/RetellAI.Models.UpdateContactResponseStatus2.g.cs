
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateContactResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateContactResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateContactResponseStatus2 value)
        {
            return value switch
            {
                UpdateContactResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateContactResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateContactResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
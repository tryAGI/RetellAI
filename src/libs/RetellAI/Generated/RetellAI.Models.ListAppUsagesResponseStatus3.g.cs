
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListAppUsagesResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAppUsagesResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAppUsagesResponseStatus3 value)
        {
            return value switch
            {
                ListAppUsagesResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAppUsagesResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListAppUsagesResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
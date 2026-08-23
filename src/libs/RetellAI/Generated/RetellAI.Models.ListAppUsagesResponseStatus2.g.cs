
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAppUsagesResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAppUsagesResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAppUsagesResponseStatus2 value)
        {
            return value switch
            {
                ListAppUsagesResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAppUsagesResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListAppUsagesResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
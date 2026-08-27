
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListExportRequestsResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExportRequestsResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsResponseStatus3 value)
        {
            return value switch
            {
                ListExportRequestsResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListExportRequestsResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
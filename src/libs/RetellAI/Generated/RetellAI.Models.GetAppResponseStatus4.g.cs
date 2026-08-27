
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAppResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAppResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAppResponseStatus4 value)
        {
            return value switch
            {
                GetAppResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAppResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAppResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
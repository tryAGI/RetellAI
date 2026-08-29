
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContactImportResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContactImportResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactImportResponseStatus3 value)
        {
            return value switch
            {
                GetContactImportResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactImportResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetContactImportResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
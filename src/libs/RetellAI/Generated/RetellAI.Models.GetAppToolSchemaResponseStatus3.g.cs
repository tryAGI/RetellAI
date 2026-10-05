
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAppToolSchemaResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAppToolSchemaResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAppToolSchemaResponseStatus3 value)
        {
            return value switch
            {
                GetAppToolSchemaResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAppToolSchemaResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAppToolSchemaResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
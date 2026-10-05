
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAppToolSchemaResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAppToolSchemaResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAppToolSchemaResponseStatus2 value)
        {
            return value switch
            {
                GetAppToolSchemaResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAppToolSchemaResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAppToolSchemaResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
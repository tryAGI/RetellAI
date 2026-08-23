
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCrmSchemaResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCrmSchemaResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCrmSchemaResponseStatus3 value)
        {
            return value switch
            {
                GetCrmSchemaResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCrmSchemaResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCrmSchemaResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
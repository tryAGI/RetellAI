
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCrmSchemaResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCrmSchemaResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCrmSchemaResponseStatus6 value)
        {
            return value switch
            {
                GetCrmSchemaResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCrmSchemaResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCrmSchemaResponseStatus6.Error,
                _ => null,
            };
        }
    }
}
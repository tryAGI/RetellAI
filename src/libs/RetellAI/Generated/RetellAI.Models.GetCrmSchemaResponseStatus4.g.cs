
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCrmSchemaResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCrmSchemaResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCrmSchemaResponseStatus4 value)
        {
            return value switch
            {
                GetCrmSchemaResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCrmSchemaResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCrmSchemaResponseStatus4.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCrmSchemaResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCrmSchemaResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCrmSchemaResponseStatus2 value)
        {
            return value switch
            {
                GetCrmSchemaResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCrmSchemaResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCrmSchemaResponseStatus2.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRetellLLMResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRetellLLMResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRetellLLMResponseStatus2 value)
        {
            return value switch
            {
                CreateRetellLLMResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRetellLLMResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateRetellLLMResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
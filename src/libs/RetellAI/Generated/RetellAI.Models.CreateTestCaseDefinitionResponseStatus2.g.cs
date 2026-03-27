
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTestCaseDefinitionResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTestCaseDefinitionResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTestCaseDefinitionResponseStatus2 value)
        {
            return value switch
            {
                CreateTestCaseDefinitionResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTestCaseDefinitionResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateTestCaseDefinitionResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
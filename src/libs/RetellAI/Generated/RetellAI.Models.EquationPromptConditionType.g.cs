
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EquationPromptConditionType
    {
        /// <summary>
        ///
        /// </summary>
        EquationPrompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EquationPromptConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EquationPromptConditionType value)
        {
            return value switch
            {
                EquationPromptConditionType.EquationPrompt => "equation_prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EquationPromptConditionType? ToEnum(string value)
        {
            return value switch
            {
                "equation_prompt" => EquationPromptConditionType.EquationPrompt,
                _ => null,
            };
        }
    }
}
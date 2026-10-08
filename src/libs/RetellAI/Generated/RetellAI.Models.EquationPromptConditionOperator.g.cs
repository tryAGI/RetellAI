
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EquationPromptConditionOperator
    {
        /// <summary>
        ///
        /// </summary>
        And,
        /// <summary>
        ///
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EquationPromptConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EquationPromptConditionOperator value)
        {
            return value switch
            {
                EquationPromptConditionOperator.And => "&&",
                EquationPromptConditionOperator.Or => "||",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EquationPromptConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "&&" => EquationPromptConditionOperator.And,
                "||" => EquationPromptConditionOperator.Or,
                _ => null,
            };
        }
    }
}
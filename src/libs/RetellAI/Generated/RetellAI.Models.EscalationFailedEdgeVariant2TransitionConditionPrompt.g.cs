
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EscalationFailedEdgeVariant2TransitionConditionPrompt
    {
        /// <summary>
        ///
        /// </summary>
        EscalationFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EscalationFailedEdgeVariant2TransitionConditionPromptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EscalationFailedEdgeVariant2TransitionConditionPrompt value)
        {
            return value switch
            {
                EscalationFailedEdgeVariant2TransitionConditionPrompt.EscalationFailed => "Escalation failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EscalationFailedEdgeVariant2TransitionConditionPrompt? ToEnum(string value)
        {
            return value switch
            {
                "Escalation failed" => EscalationFailedEdgeVariant2TransitionConditionPrompt.EscalationFailed,
                _ => null,
            };
        }
    }
}
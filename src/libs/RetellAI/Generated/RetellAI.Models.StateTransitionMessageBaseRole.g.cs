
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// This is a state transition.
    /// </summary>
    public enum StateTransitionMessageBaseRole
    {
        /// <summary>
        ///
        /// </summary>
        StateTransition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateTransitionMessageBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StateTransitionMessageBaseRole value)
        {
            return value switch
            {
                StateTransitionMessageBaseRole.StateTransition => "state_transition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StateTransitionMessageBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "state_transition" => StateTransitionMessageBaseRole.StateTransition,
                _ => null,
            };
        }
    }
}
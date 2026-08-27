
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// How this node was reached. "global" means a global node transition, "global_go_back" means returning from a global node, "interrupt_go_back" means going back due to user interruption, and "normal" means a regular edge transition.
    /// </summary>
    public enum NodeTransitionMessageBaseTransitionType
    {
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        GlobalGoBack,
        /// <summary>
        ///
        /// </summary>
        InterruptGoBack,
        /// <summary>
        ///
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeTransitionMessageBaseTransitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeTransitionMessageBaseTransitionType value)
        {
            return value switch
            {
                NodeTransitionMessageBaseTransitionType.Global => "global",
                NodeTransitionMessageBaseTransitionType.GlobalGoBack => "global_go_back",
                NodeTransitionMessageBaseTransitionType.InterruptGoBack => "interrupt_go_back",
                NodeTransitionMessageBaseTransitionType.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeTransitionMessageBaseTransitionType? ToEnum(string value)
        {
            return value switch
            {
                "global" => NodeTransitionMessageBaseTransitionType.Global,
                "global_go_back" => NodeTransitionMessageBaseTransitionType.GlobalGoBack,
                "interrupt_go_back" => NodeTransitionMessageBaseTransitionType.InterruptGoBack,
                "normal" => NodeTransitionMessageBaseTransitionType.Normal,
                _ => null,
            };
        }
    }
}
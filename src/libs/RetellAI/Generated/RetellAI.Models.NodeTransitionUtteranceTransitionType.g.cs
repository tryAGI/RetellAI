
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// How this node was reached. "global" means a global node transition, "global_go_back" means returning from a global node, "interrupt_go_back" means going back due to user interruption, and "normal" means a regular edge transition.
    /// </summary>
    public enum NodeTransitionUtteranceTransitionType
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
    public static class NodeTransitionUtteranceTransitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeTransitionUtteranceTransitionType value)
        {
            return value switch
            {
                NodeTransitionUtteranceTransitionType.Global => "global",
                NodeTransitionUtteranceTransitionType.GlobalGoBack => "global_go_back",
                NodeTransitionUtteranceTransitionType.InterruptGoBack => "interrupt_go_back",
                NodeTransitionUtteranceTransitionType.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeTransitionUtteranceTransitionType? ToEnum(string value)
        {
            return value switch
            {
                "global" => NodeTransitionUtteranceTransitionType.Global,
                "global_go_back" => NodeTransitionUtteranceTransitionType.GlobalGoBack,
                "interrupt_go_back" => NodeTransitionUtteranceTransitionType.InterruptGoBack,
                "normal" => NodeTransitionUtteranceTransitionType.Normal,
                _ => null,
            };
        }
    }
}
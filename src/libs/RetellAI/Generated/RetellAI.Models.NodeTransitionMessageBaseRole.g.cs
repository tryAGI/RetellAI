
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// This is a node transition.
    /// </summary>
    public enum NodeTransitionMessageBaseRole
    {
        /// <summary>
        ///
        /// </summary>
        NodeTransition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeTransitionMessageBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeTransitionMessageBaseRole value)
        {
            return value switch
            {
                NodeTransitionMessageBaseRole.NodeTransition => "node_transition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeTransitionMessageBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "node_transition" => NodeTransitionMessageBaseRole.NodeTransition,
                _ => null,
            };
        }
    }
}
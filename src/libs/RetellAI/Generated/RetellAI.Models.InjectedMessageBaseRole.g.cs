
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// External context injected into the conversation via the update-live-call API. Not spoken by either party.
    /// </summary>
    public enum InjectedMessageBaseRole
    {
        /// <summary>
        /// 
        /// </summary>
        Injected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InjectedMessageBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InjectedMessageBaseRole value)
        {
            return value switch
            {
                InjectedMessageBaseRole.Injected => "injected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InjectedMessageBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "injected" => InjectedMessageBaseRole.Injected,
                _ => null,
            };
        }
    }
}
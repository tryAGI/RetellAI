
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// External context injected into the conversation via the update-live-call API. Not spoken by either party.
    /// </summary>
    public enum InjectedUtteranceRole
    {
        /// <summary>
        /// 
        /// </summary>
        Injected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InjectedUtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InjectedUtteranceRole value)
        {
            return value switch
            {
                InjectedUtteranceRole.Injected => "injected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InjectedUtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "injected" => InjectedUtteranceRole.Injected,
                _ => null,
            };
        }
    }
}
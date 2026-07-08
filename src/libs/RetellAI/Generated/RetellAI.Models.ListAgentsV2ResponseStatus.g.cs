
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAgentsV2ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentsV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsV2ResponseStatus value)
        {
            return value switch
            {
                ListAgentsV2ResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListAgentsV2ResponseStatus.Error,
                _ => null,
            };
        }
    }
}
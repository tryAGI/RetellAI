
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentVersionResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentVersionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentVersionResponseStatus value)
        {
            return value switch
            {
                CreateAgentVersionResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentVersionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateAgentVersionResponseStatus.Error,
                _ => null,
            };
        }
    }
}
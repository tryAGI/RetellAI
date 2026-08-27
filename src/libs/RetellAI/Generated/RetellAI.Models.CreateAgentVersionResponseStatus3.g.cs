
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentVersionResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentVersionResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentVersionResponseStatus3 value)
        {
            return value switch
            {
                CreateAgentVersionResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentVersionResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateAgentVersionResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
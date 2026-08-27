
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteAgentVersionResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAgentVersionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAgentVersionResponseStatus value)
        {
            return value switch
            {
                DeleteAgentVersionResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAgentVersionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteAgentVersionResponseStatus.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteAgentVersionResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAgentVersionResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAgentVersionResponseStatus4 value)
        {
            return value switch
            {
                DeleteAgentVersionResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAgentVersionResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteAgentVersionResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
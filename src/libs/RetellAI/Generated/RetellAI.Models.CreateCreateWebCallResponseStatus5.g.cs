
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCreateWebCallResponseStatus5
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCreateWebCallResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCreateWebCallResponseStatus5 value)
        {
            return value switch
            {
                CreateCreateWebCallResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCreateWebCallResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCreateWebCallResponseStatus5.Error,
                _ => null,
            };
        }
    }
}
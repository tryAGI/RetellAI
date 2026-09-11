
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCreateWebCallResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCreateWebCallResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCreateWebCallResponseStatus2 value)
        {
            return value switch
            {
                CreateCreateWebCallResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCreateWebCallResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCreateWebCallResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
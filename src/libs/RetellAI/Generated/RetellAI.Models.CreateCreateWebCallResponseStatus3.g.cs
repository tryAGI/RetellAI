
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCreateWebCallResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCreateWebCallResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCreateWebCallResponseStatus3 value)
        {
            return value switch
            {
                CreateCreateWebCallResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCreateWebCallResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCreateWebCallResponseStatus3.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCreateWebCallResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCreateWebCallResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCreateWebCallResponseStatus4 value)
        {
            return value switch
            {
                CreateCreateWebCallResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCreateWebCallResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCreateWebCallResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
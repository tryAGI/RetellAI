
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCreateWebCallResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCreateWebCallResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCreateWebCallResponseStatus value)
        {
            return value switch
            {
                CreateCreateWebCallResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCreateWebCallResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCreateWebCallResponseStatus.Error,
                _ => null,
            };
        }
    }
}
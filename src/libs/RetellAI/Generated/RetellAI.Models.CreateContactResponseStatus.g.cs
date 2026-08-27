
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateContactResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContactResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContactResponseStatus value)
        {
            return value switch
            {
                CreateContactResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContactResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateContactResponseStatus.Error,
                _ => null,
            };
        }
    }
}
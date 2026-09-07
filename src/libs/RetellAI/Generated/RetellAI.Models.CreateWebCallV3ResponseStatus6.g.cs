
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateWebCallV3ResponseStatus6
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebCallV3ResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebCallV3ResponseStatus6 value)
        {
            return value switch
            {
                CreateWebCallV3ResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebCallV3ResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateWebCallV3ResponseStatus6.Error,
                _ => null,
            };
        }
    }
}
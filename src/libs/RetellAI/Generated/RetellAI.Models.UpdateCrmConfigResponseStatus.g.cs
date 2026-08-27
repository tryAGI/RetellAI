
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateCrmConfigResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCrmConfigResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCrmConfigResponseStatus value)
        {
            return value switch
            {
                UpdateCrmConfigResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCrmConfigResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateCrmConfigResponseStatus.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContactImportResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContactImportResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactImportResponseStatus value)
        {
            return value switch
            {
                GetContactImportResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactImportResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetContactImportResponseStatus.Error,
                _ => null,
            };
        }
    }
}
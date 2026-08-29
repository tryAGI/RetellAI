
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadContactImportFileResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadContactImportFileResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadContactImportFileResponseStatus4 value)
        {
            return value switch
            {
                UploadContactImportFileResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadContactImportFileResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => UploadContactImportFileResponseStatus4.Error,
                _ => null,
            };
        }
    }
}
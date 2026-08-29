
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadContactImportFileResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadContactImportFileResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadContactImportFileResponseStatus value)
        {
            return value switch
            {
                UploadContactImportFileResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadContactImportFileResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UploadContactImportFileResponseStatus.Error,
                _ => null,
            };
        }
    }
}
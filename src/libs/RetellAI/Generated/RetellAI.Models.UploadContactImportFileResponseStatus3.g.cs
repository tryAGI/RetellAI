
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadContactImportFileResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadContactImportFileResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadContactImportFileResponseStatus3 value)
        {
            return value switch
            {
                UploadContactImportFileResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadContactImportFileResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => UploadContactImportFileResponseStatus3.Error,
                _ => null,
            };
        }
    }
}
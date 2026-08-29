
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadContactImportFileResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadContactImportFileResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadContactImportFileResponseStatus2 value)
        {
            return value switch
            {
                UploadContactImportFileResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadContactImportFileResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UploadContactImportFileResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
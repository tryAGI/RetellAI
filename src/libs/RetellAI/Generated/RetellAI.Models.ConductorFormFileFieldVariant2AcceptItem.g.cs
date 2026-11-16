
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormFileFieldVariant2AcceptItem
    {
        /// <summary>
        ///
        /// </summary>
        Csv,
        /// <summary>
        ///
        /// </summary>
        Docx,
        /// <summary>
        ///
        /// </summary>
        Gif,
        /// <summary>
        ///
        /// </summary>
        Htm,
        /// <summary>
        ///
        /// </summary>
        Html,
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Jpg,
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Md,
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Pdf,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Rtf,
        /// <summary>
        ///
        /// </summary>
        Txt,
        /// <summary>
        ///
        /// </summary>
        Wav,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormFileFieldVariant2AcceptItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormFileFieldVariant2AcceptItem value)
        {
            return value switch
            {
                ConductorFormFileFieldVariant2AcceptItem.Csv => "csv",
                ConductorFormFileFieldVariant2AcceptItem.Docx => "docx",
                ConductorFormFileFieldVariant2AcceptItem.Gif => "gif",
                ConductorFormFileFieldVariant2AcceptItem.Htm => "htm",
                ConductorFormFileFieldVariant2AcceptItem.Html => "html",
                ConductorFormFileFieldVariant2AcceptItem.Jpeg => "jpeg",
                ConductorFormFileFieldVariant2AcceptItem.Jpg => "jpg",
                ConductorFormFileFieldVariant2AcceptItem.Json => "json",
                ConductorFormFileFieldVariant2AcceptItem.Md => "md",
                ConductorFormFileFieldVariant2AcceptItem.Mp3 => "mp3",
                ConductorFormFileFieldVariant2AcceptItem.Pdf => "pdf",
                ConductorFormFileFieldVariant2AcceptItem.Png => "png",
                ConductorFormFileFieldVariant2AcceptItem.Rtf => "rtf",
                ConductorFormFileFieldVariant2AcceptItem.Txt => "txt",
                ConductorFormFileFieldVariant2AcceptItem.Wav => "wav",
                ConductorFormFileFieldVariant2AcceptItem.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormFileFieldVariant2AcceptItem? ToEnum(string value)
        {
            return value switch
            {
                "csv" => ConductorFormFileFieldVariant2AcceptItem.Csv,
                "docx" => ConductorFormFileFieldVariant2AcceptItem.Docx,
                "gif" => ConductorFormFileFieldVariant2AcceptItem.Gif,
                "htm" => ConductorFormFileFieldVariant2AcceptItem.Htm,
                "html" => ConductorFormFileFieldVariant2AcceptItem.Html,
                "jpeg" => ConductorFormFileFieldVariant2AcceptItem.Jpeg,
                "jpg" => ConductorFormFileFieldVariant2AcceptItem.Jpg,
                "json" => ConductorFormFileFieldVariant2AcceptItem.Json,
                "md" => ConductorFormFileFieldVariant2AcceptItem.Md,
                "mp3" => ConductorFormFileFieldVariant2AcceptItem.Mp3,
                "pdf" => ConductorFormFileFieldVariant2AcceptItem.Pdf,
                "png" => ConductorFormFileFieldVariant2AcceptItem.Png,
                "rtf" => ConductorFormFileFieldVariant2AcceptItem.Rtf,
                "txt" => ConductorFormFileFieldVariant2AcceptItem.Txt,
                "wav" => ConductorFormFileFieldVariant2AcceptItem.Wav,
                "webp" => ConductorFormFileFieldVariant2AcceptItem.Webp,
                _ => null,
            };
        }
    }
}
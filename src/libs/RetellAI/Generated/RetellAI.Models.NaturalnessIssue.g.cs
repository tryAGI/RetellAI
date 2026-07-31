
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NaturalnessIssue
    {
        /// <summary>
        /// 
        /// </summary>
        AudioArtifacts,
        /// <summary>
        /// 
        /// </summary>
        Mispronunciation,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        PoorArticulation,
        /// <summary>
        /// 
        /// </summary>
        UnnaturalIntonation,
        /// <summary>
        /// 
        /// </summary>
        UnnaturalPacing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NaturalnessIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NaturalnessIssue value)
        {
            return value switch
            {
                NaturalnessIssue.AudioArtifacts => "AudioArtifacts",
                NaturalnessIssue.Mispronunciation => "Mispronunciation",
                NaturalnessIssue.Other => "Other",
                NaturalnessIssue.PoorArticulation => "PoorArticulation",
                NaturalnessIssue.UnnaturalIntonation => "UnnaturalIntonation",
                NaturalnessIssue.UnnaturalPacing => "UnnaturalPacing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NaturalnessIssue? ToEnum(string value)
        {
            return value switch
            {
                "AudioArtifacts" => NaturalnessIssue.AudioArtifacts,
                "Mispronunciation" => NaturalnessIssue.Mispronunciation,
                "Other" => NaturalnessIssue.Other,
                "PoorArticulation" => NaturalnessIssue.PoorArticulation,
                "UnnaturalIntonation" => NaturalnessIssue.UnnaturalIntonation,
                "UnnaturalPacing" => NaturalnessIssue.UnnaturalPacing,
                _ => null,
            };
        }
    }
}
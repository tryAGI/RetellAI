
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Why the backup won. primary_failed means primary attempts failed; preference_expired means backup was ready within the primary preference window; first_usable means backup became ready after that window and won the race.
    /// </summary>
    public enum BackupModelUsedReason
    {
        /// <summary>
        ///
        /// </summary>
        FirstUsable,
        /// <summary>
        ///
        /// </summary>
        PreferenceExpired,
        /// <summary>
        ///
        /// </summary>
        PrimaryFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupModelUsedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupModelUsedReason value)
        {
            return value switch
            {
                BackupModelUsedReason.FirstUsable => "first_usable",
                BackupModelUsedReason.PreferenceExpired => "preference_expired",
                BackupModelUsedReason.PrimaryFailed => "primary_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupModelUsedReason? ToEnum(string value)
        {
            return value switch
            {
                "first_usable" => BackupModelUsedReason.FirstUsable,
                "preference_expired" => BackupModelUsedReason.PreferenceExpired,
                "primary_failed" => BackupModelUsedReason.PrimaryFailed,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The music to play while the caller is being transferred. Use `custom` together with `custom_on_hold_music_asset_id` to play an uploaded audio asset.
    /// </summary>
    public enum TransferOptionAgenticWarmTransferOnHoldMusic
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        RelaxingSound,
        /// <summary>
        ///
        /// </summary>
        Ringtone,
        /// <summary>
        ///
        /// </summary>
        UpliftingBeats,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferOptionAgenticWarmTransferOnHoldMusicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionAgenticWarmTransferOnHoldMusic value)
        {
            return value switch
            {
                TransferOptionAgenticWarmTransferOnHoldMusic.Custom => "custom",
                TransferOptionAgenticWarmTransferOnHoldMusic.None => "none",
                TransferOptionAgenticWarmTransferOnHoldMusic.RelaxingSound => "relaxing_sound",
                TransferOptionAgenticWarmTransferOnHoldMusic.Ringtone => "ringtone",
                TransferOptionAgenticWarmTransferOnHoldMusic.UpliftingBeats => "uplifting_beats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionAgenticWarmTransferOnHoldMusic? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TransferOptionAgenticWarmTransferOnHoldMusic.Custom,
                "none" => TransferOptionAgenticWarmTransferOnHoldMusic.None,
                "relaxing_sound" => TransferOptionAgenticWarmTransferOnHoldMusic.RelaxingSound,
                "ringtone" => TransferOptionAgenticWarmTransferOnHoldMusic.Ringtone,
                "uplifting_beats" => TransferOptionAgenticWarmTransferOnHoldMusic.UpliftingBeats,
                _ => null,
            };
        }
    }
}
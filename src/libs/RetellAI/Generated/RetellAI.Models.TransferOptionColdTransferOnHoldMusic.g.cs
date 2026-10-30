
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The music to play while the caller is being transferred. If omitted, preserves the existing transfer audio behavior. Use `custom` together with `custom_on_hold_music_asset_id` to play an uploaded audio asset.
    /// </summary>
    public enum TransferOptionColdTransferOnHoldMusic
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
    public static class TransferOptionColdTransferOnHoldMusicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionColdTransferOnHoldMusic value)
        {
            return value switch
            {
                TransferOptionColdTransferOnHoldMusic.Custom => "custom",
                TransferOptionColdTransferOnHoldMusic.None => "none",
                TransferOptionColdTransferOnHoldMusic.RelaxingSound => "relaxing_sound",
                TransferOptionColdTransferOnHoldMusic.Ringtone => "ringtone",
                TransferOptionColdTransferOnHoldMusic.UpliftingBeats => "uplifting_beats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionColdTransferOnHoldMusic? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TransferOptionColdTransferOnHoldMusic.Custom,
                "none" => TransferOptionColdTransferOnHoldMusic.None,
                "relaxing_sound" => TransferOptionColdTransferOnHoldMusic.RelaxingSound,
                "ringtone" => TransferOptionColdTransferOnHoldMusic.Ringtone,
                "uplifting_beats" => TransferOptionColdTransferOnHoldMusic.UpliftingBeats,
                _ => null,
            };
        }
    }
}
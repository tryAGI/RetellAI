
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The music to play while the caller is being transferred. Use `custom` together with `custom_on_hold_music_asset_id` to play an uploaded audio asset.
    /// </summary>
    public enum TransferOptionWarmTransferOnHoldMusic
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
    public static class TransferOptionWarmTransferOnHoldMusicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionWarmTransferOnHoldMusic value)
        {
            return value switch
            {
                TransferOptionWarmTransferOnHoldMusic.Custom => "custom",
                TransferOptionWarmTransferOnHoldMusic.None => "none",
                TransferOptionWarmTransferOnHoldMusic.RelaxingSound => "relaxing_sound",
                TransferOptionWarmTransferOnHoldMusic.Ringtone => "ringtone",
                TransferOptionWarmTransferOnHoldMusic.UpliftingBeats => "uplifting_beats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionWarmTransferOnHoldMusic? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TransferOptionWarmTransferOnHoldMusic.Custom,
                "none" => TransferOptionWarmTransferOnHoldMusic.None,
                "relaxing_sound" => TransferOptionWarmTransferOnHoldMusic.RelaxingSound,
                "ringtone" => TransferOptionWarmTransferOnHoldMusic.Ringtone,
                "uplifting_beats" => TransferOptionWarmTransferOnHoldMusic.UpliftingBeats,
                _ => null,
            };
        }
    }
}
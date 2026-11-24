
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Background sound mixed into the caller's audio.
    /// </summary>
    public enum AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound
    {
        /// <summary>
        ///
        /// </summary>
        Airport,
        /// <summary>
        ///
        /// </summary>
        BusyStreet,
        /// <summary>
        ///
        /// </summary>
        CarInterior,
        /// <summary>
        ///
        /// </summary>
        Construction,
        /// <summary>
        ///
        /// </summary>
        CracklingStatic,
        /// <summary>
        ///
        /// </summary>
        CrowdedBar,
        /// <summary>
        ///
        /// </summary>
        Subway,
        /// <summary>
        ///
        /// </summary>
        TvInRestaurant,
        /// <summary>
        ///
        /// </summary>
        Wind,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound value)
        {
            return value switch
            {
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Airport => "airport",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.BusyStreet => "busy-street",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CarInterior => "car-interior",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Construction => "construction",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CracklingStatic => "crackling-static",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CrowdedBar => "crowded-bar",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Subway => "subway",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.TvInRestaurant => "tv-in-restaurant",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Wind => "wind",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound? ToEnum(string value)
        {
            return value switch
            {
                "airport" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Airport,
                "busy-street" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.BusyStreet,
                "car-interior" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CarInterior,
                "construction" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Construction,
                "crackling-static" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CracklingStatic,
                "crowded-bar" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CrowdedBar,
                "subway" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Subway,
                "tv-in-restaurant" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.TvInRestaurant,
                "wind" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.Wind,
                _ => null,
            };
        }
    }
}

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
        CallCenter,
        /// <summary>
        ///
        /// </summary>
        CoffeeShop,
        /// <summary>
        ///
        /// </summary>
        ConventionHall,
        /// <summary>
        ///
        /// </summary>
        MountainOutdoor,
        /// <summary>
        ///
        /// </summary>
        StaticNoise,
        /// <summary>
        ///
        /// </summary>
        SummerOutdoor,
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
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CallCenter => "call-center",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CoffeeShop => "coffee-shop",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.ConventionHall => "convention-hall",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.MountainOutdoor => "mountain-outdoor",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.StaticNoise => "static-noise",
                AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.SummerOutdoor => "summer-outdoor",
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
                "call-center" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CallCenter,
                "coffee-shop" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.CoffeeShop,
                "convention-hall" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.ConventionHall,
                "mountain-outdoor" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.MountainOutdoor,
                "static-noise" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.StaticNoise,
                "summer-outdoor" => AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound.SummerOutdoor,
                _ => null,
            };
        }
    }
}
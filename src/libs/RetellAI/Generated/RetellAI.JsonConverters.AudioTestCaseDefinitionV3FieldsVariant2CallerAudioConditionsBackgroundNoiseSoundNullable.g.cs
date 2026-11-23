#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSoundNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound?>
    {
        /// <inheritdoc />
        public override global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSoundExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSoundExtensions.ToValueString(value.Value));
            }
        }
    }
}

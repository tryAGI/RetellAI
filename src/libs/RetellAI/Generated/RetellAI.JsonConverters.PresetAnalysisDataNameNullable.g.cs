#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class PresetAnalysisDataNameNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.PresetAnalysisDataName?>
    {
        /// <inheritdoc />
        public override global::RetellAI.PresetAnalysisDataName? Read(
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
                        return global::RetellAI.PresetAnalysisDataNameExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.PresetAnalysisDataName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.PresetAnalysisDataName?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.PresetAnalysisDataName? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.PresetAnalysisDataNameExtensions.ToValueString(value.Value));
            }
        }
    }
}

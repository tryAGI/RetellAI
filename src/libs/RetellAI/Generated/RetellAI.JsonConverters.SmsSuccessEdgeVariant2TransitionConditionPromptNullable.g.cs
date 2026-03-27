#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SmsSuccessEdgeVariant2TransitionConditionPromptNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt?>
    {
        /// <inheritdoc />
        public override global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt? Read(
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
                        return global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPromptExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPrompt? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.SmsSuccessEdgeVariant2TransitionConditionPromptExtensions.ToValueString(value.Value));
            }
        }
    }
}

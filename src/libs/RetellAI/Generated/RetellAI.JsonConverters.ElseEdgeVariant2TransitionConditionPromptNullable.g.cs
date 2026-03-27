#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ElseEdgeVariant2TransitionConditionPromptNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt?>
    {
        /// <inheritdoc />
        public override global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt? Read(
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
                        return global::RetellAI.ElseEdgeVariant2TransitionConditionPromptExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ElseEdgeVariant2TransitionConditionPrompt? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.ElseEdgeVariant2TransitionConditionPromptExtensions.ToValueString(value.Value));
            }
        }
    }
}

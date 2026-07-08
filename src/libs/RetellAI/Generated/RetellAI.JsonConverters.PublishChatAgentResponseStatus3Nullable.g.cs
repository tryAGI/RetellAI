#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublishChatAgentResponseStatus3NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.PublishChatAgentResponseStatus3?>
    {
        /// <inheritdoc />
        public override global::RetellAI.PublishChatAgentResponseStatus3? Read(
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
                        return global::RetellAI.PublishChatAgentResponseStatus3Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.PublishChatAgentResponseStatus3)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.PublishChatAgentResponseStatus3?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.PublishChatAgentResponseStatus3? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.PublishChatAgentResponseStatus3Extensions.ToValueString(value.Value));
            }
        }
    }
}

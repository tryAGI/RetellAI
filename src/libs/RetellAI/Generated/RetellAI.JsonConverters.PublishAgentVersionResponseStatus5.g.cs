#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublishAgentVersionResponseStatus5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.PublishAgentVersionResponseStatus5>
    {
        /// <inheritdoc />
        public override global::RetellAI.PublishAgentVersionResponseStatus5 Read(
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
                        return global::RetellAI.PublishAgentVersionResponseStatus5Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.PublishAgentVersionResponseStatus5)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.PublishAgentVersionResponseStatus5);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.PublishAgentVersionResponseStatus5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.PublishAgentVersionResponseStatus5Extensions.ToValueString(value));
        }
    }
}

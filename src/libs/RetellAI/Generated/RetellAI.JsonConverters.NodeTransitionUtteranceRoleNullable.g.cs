#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class NodeTransitionUtteranceRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.NodeTransitionUtteranceRole?>
    {
        /// <inheritdoc />
        public override global::RetellAI.NodeTransitionUtteranceRole? Read(
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
                        return global::RetellAI.NodeTransitionUtteranceRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.NodeTransitionUtteranceRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.NodeTransitionUtteranceRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.NodeTransitionUtteranceRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.NodeTransitionUtteranceRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}

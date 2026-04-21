#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class NodeTransitionMessageBaseRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.NodeTransitionMessageBaseRole?>
    {
        /// <inheritdoc />
        public override global::RetellAI.NodeTransitionMessageBaseRole? Read(
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
                        return global::RetellAI.NodeTransitionMessageBaseRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.NodeTransitionMessageBaseRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.NodeTransitionMessageBaseRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.NodeTransitionMessageBaseRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.NodeTransitionMessageBaseRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}

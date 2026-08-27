#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateCrmConfigResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.UpdateCrmConfigResponseStatus?>
    {
        /// <inheritdoc />
        public override global::RetellAI.UpdateCrmConfigResponseStatus? Read(
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
                        return global::RetellAI.UpdateCrmConfigResponseStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.UpdateCrmConfigResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.UpdateCrmConfigResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.UpdateCrmConfigResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.UpdateCrmConfigResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}

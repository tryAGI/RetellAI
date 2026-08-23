#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class RefreshTokenAuthConfigResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.RefreshTokenAuthConfigResponseType?>
    {
        /// <inheritdoc />
        public override global::RetellAI.RefreshTokenAuthConfigResponseType? Read(
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
                        return global::RetellAI.RefreshTokenAuthConfigResponseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.RefreshTokenAuthConfigResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.RefreshTokenAuthConfigResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.RefreshTokenAuthConfigResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.RefreshTokenAuthConfigResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

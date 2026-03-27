#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2PhoneCallResponseVariant1CallTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.V2PhoneCallResponseVariant1CallType?>
    {
        /// <inheritdoc />
        public override global::RetellAI.V2PhoneCallResponseVariant1CallType? Read(
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
                        return global::RetellAI.V2PhoneCallResponseVariant1CallTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.V2PhoneCallResponseVariant1CallType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.V2PhoneCallResponseVariant1CallType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.V2PhoneCallResponseVariant1CallType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.V2PhoneCallResponseVariant1CallTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

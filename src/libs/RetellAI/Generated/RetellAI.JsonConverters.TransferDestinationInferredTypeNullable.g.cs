#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransferDestinationInferredTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.TransferDestinationInferredType?>
    {
        /// <inheritdoc />
        public override global::RetellAI.TransferDestinationInferredType? Read(
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
                        return global::RetellAI.TransferDestinationInferredTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.TransferDestinationInferredType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.TransferDestinationInferredType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.TransferDestinationInferredType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.TransferDestinationInferredTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

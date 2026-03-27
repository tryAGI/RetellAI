#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransferFailedEdgeVariant2TransitionConditionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType?>
    {
        /// <inheritdoc />
        public override global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType? Read(
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
                        return global::RetellAI.TransferFailedEdgeVariant2TransitionConditionTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.TransferFailedEdgeVariant2TransitionConditionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.TransferFailedEdgeVariant2TransitionConditionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

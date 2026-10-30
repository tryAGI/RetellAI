#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransferOptionColdTransferOnHoldMusicJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.TransferOptionColdTransferOnHoldMusic>
    {
        /// <inheritdoc />
        public override global::RetellAI.TransferOptionColdTransferOnHoldMusic Read(
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
                        return global::RetellAI.TransferOptionColdTransferOnHoldMusicExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.TransferOptionColdTransferOnHoldMusic)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.TransferOptionColdTransferOnHoldMusic);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.TransferOptionColdTransferOnHoldMusic value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.TransferOptionColdTransferOnHoldMusicExtensions.ToValueString(value));
        }
    }
}

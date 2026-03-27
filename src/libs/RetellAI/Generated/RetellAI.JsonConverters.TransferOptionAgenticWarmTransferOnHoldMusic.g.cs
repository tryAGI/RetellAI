#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransferOptionAgenticWarmTransferOnHoldMusicJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic>
    {
        /// <inheritdoc />
        public override global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic Read(
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
                        return global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusicExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusicExtensions.ToValueString(value));
        }
    }
}

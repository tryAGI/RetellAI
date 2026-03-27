#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoicemailActionBridgeTransferTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.VoicemailActionBridgeTransferType>
    {
        /// <inheritdoc />
        public override global::RetellAI.VoicemailActionBridgeTransferType Read(
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
                        return global::RetellAI.VoicemailActionBridgeTransferTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.VoicemailActionBridgeTransferType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.VoicemailActionBridgeTransferType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.VoicemailActionBridgeTransferType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.VoicemailActionBridgeTransferTypeExtensions.ToValueString(value));
        }
    }
}

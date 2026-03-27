#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionNodeVariant2ToolTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.FunctionNodeVariant2ToolType>
    {
        /// <inheritdoc />
        public override global::RetellAI.FunctionNodeVariant2ToolType Read(
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
                        return global::RetellAI.FunctionNodeVariant2ToolTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.FunctionNodeVariant2ToolType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.FunctionNodeVariant2ToolType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.FunctionNodeVariant2ToolType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.FunctionNodeVariant2ToolTypeExtensions.ToValueString(value));
        }
    }
}

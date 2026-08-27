#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteAppResponseStatus3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.DeleteAppResponseStatus3>
    {
        /// <inheritdoc />
        public override global::RetellAI.DeleteAppResponseStatus3 Read(
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
                        return global::RetellAI.DeleteAppResponseStatus3Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.DeleteAppResponseStatus3)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.DeleteAppResponseStatus3);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.DeleteAppResponseStatus3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.DeleteAppResponseStatus3Extensions.ToValueString(value));
        }
    }
}

#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChartTimeRangeVariant5TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ChartTimeRangeVariant5Type>
    {
        /// <inheritdoc />
        public override global::RetellAI.ChartTimeRangeVariant5Type Read(
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
                        return global::RetellAI.ChartTimeRangeVariant5TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.ChartTimeRangeVariant5Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.ChartTimeRangeVariant5Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ChartTimeRangeVariant5Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.ChartTimeRangeVariant5TypeExtensions.ToValueString(value));
        }
    }
}

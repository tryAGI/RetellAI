#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChartShowItemNumericSourceSourceTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ChartShowItemNumericSourceSourceType>
    {
        /// <inheritdoc />
        public override global::RetellAI.ChartShowItemNumericSourceSourceType Read(
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
                        return global::RetellAI.ChartShowItemNumericSourceSourceTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.ChartShowItemNumericSourceSourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.ChartShowItemNumericSourceSourceType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ChartShowItemNumericSourceSourceType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.ChartShowItemNumericSourceSourceTypeExtensions.ToValueString(value));
        }
    }
}

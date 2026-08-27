#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CohortQaListArgsSortKeyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.CohortQaListArgsSortKey?>
    {
        /// <inheritdoc />
        public override global::RetellAI.CohortQaListArgsSortKey? Read(
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
                        return global::RetellAI.CohortQaListArgsSortKeyExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.CohortQaListArgsSortKey)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.CohortQaListArgsSortKey?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.CohortQaListArgsSortKey? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.CohortQaListArgsSortKeyExtensions.ToValueString(value.Value));
            }
        }
    }
}

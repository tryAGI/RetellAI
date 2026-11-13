#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchPhoneNumbersSortOrderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.SearchPhoneNumbersSortOrder>
    {
        /// <inheritdoc />
        public override global::RetellAI.SearchPhoneNumbersSortOrder Read(
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
                        return global::RetellAI.SearchPhoneNumbersSortOrderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.SearchPhoneNumbersSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.SearchPhoneNumbersSortOrder);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.SearchPhoneNumbersSortOrder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.SearchPhoneNumbersSortOrderExtensions.ToValueString(value));
        }
    }
}

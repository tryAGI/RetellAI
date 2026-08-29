#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadContactImportFileResponseStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.UploadContactImportFileResponseStatus>
    {
        /// <inheritdoc />
        public override global::RetellAI.UploadContactImportFileResponseStatus Read(
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
                        return global::RetellAI.UploadContactImportFileResponseStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.UploadContactImportFileResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.UploadContactImportFileResponseStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.UploadContactImportFileResponseStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.UploadContactImportFileResponseStatusExtensions.ToValueString(value));
        }
    }
}

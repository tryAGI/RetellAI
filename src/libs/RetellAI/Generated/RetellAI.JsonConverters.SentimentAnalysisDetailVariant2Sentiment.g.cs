#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SentimentAnalysisDetailVariant2SentimentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.SentimentAnalysisDetailVariant2Sentiment>
    {
        /// <inheritdoc />
        public override global::RetellAI.SentimentAnalysisDetailVariant2Sentiment Read(
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
                        return global::RetellAI.SentimentAnalysisDetailVariant2SentimentExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.SentimentAnalysisDetailVariant2Sentiment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.SentimentAnalysisDetailVariant2Sentiment);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.SentimentAnalysisDetailVariant2Sentiment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.SentimentAnalysisDetailVariant2SentimentExtensions.ToValueString(value));
        }
    }
}

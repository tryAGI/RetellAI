#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SentimentAnalysisDetailVariant1SentimentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.SentimentAnalysisDetailVariant1Sentiment>
    {
        /// <inheritdoc />
        public override global::RetellAI.SentimentAnalysisDetailVariant1Sentiment Read(
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
                        return global::RetellAI.SentimentAnalysisDetailVariant1SentimentExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.SentimentAnalysisDetailVariant1Sentiment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.SentimentAnalysisDetailVariant1Sentiment);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.SentimentAnalysisDetailVariant1Sentiment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.SentimentAnalysisDetailVariant1SentimentExtensions.ToValueString(value));
        }
    }
}

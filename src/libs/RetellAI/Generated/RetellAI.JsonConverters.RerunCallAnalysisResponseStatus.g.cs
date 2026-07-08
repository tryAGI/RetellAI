#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class RerunCallAnalysisResponseStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.RerunCallAnalysisResponseStatus>
    {
        /// <inheritdoc />
        public override global::RetellAI.RerunCallAnalysisResponseStatus Read(
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
                        return global::RetellAI.RerunCallAnalysisResponseStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.RerunCallAnalysisResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.RerunCallAnalysisResponseStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.RerunCallAnalysisResponseStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.RerunCallAnalysisResponseStatusExtensions.ToValueString(value));
        }
    }
}

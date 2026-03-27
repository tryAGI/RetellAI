#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class QaViewFilterScoreRangeOpJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.QaViewFilterScoreRangeOp>
    {
        /// <inheritdoc />
        public override global::RetellAI.QaViewFilterScoreRangeOp Read(
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
                        return global::RetellAI.QaViewFilterScoreRangeOpExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.QaViewFilterScoreRangeOp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.QaViewFilterScoreRangeOp);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.QaViewFilterScoreRangeOp value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.QaViewFilterScoreRangeOpExtensions.ToValueString(value));
        }
    }
}

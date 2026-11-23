#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus>
    {
        /// <inheritdoc />
        public override global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus Read(
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
                        return global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatusExtensions.ToValueString(value));
        }
    }
}

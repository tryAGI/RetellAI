#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TestCaseJobV3BaseStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.TestCaseJobV3BaseStatus>
    {
        /// <inheritdoc />
        public override global::RetellAI.TestCaseJobV3BaseStatus Read(
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
                        return global::RetellAI.TestCaseJobV3BaseStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.TestCaseJobV3BaseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.TestCaseJobV3BaseStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.TestCaseJobV3BaseStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.TestCaseJobV3BaseStatusExtensions.ToValueString(value));
        }
    }
}

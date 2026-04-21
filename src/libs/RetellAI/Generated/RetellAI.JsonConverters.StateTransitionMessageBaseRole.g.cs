#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class StateTransitionMessageBaseRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.StateTransitionMessageBaseRole>
    {
        /// <inheritdoc />
        public override global::RetellAI.StateTransitionMessageBaseRole Read(
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
                        return global::RetellAI.StateTransitionMessageBaseRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.StateTransitionMessageBaseRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.StateTransitionMessageBaseRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.StateTransitionMessageBaseRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.StateTransitionMessageBaseRoleExtensions.ToValueString(value));
        }
    }
}

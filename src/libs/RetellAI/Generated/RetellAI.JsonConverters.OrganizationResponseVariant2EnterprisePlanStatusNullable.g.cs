#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrganizationResponseVariant2EnterprisePlanStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus?>
    {
        /// <inheritdoc />
        public override global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus? Read(
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
                        return global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}

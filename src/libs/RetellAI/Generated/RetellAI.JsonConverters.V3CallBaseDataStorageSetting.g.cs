#nullable enable

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class V3CallBaseDataStorageSettingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.V3CallBaseDataStorageSetting>
    {
        /// <inheritdoc />
        public override global::RetellAI.V3CallBaseDataStorageSetting Read(
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
                        return global::RetellAI.V3CallBaseDataStorageSettingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::RetellAI.V3CallBaseDataStorageSetting)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::RetellAI.V3CallBaseDataStorageSetting);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.V3CallBaseDataStorageSetting value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::RetellAI.V3CallBaseDataStorageSettingExtensions.ToValueString(value));
        }
    }
}

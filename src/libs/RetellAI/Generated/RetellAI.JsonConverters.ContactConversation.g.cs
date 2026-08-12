#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ContactConversationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ContactConversation>
    {
        /// <inheritdoc />
        public override global::RetellAI.ContactConversation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("call_id")) __score0++;
            if (__jsonProps.Contains("direction")) __score0++;
            if (__jsonProps.Contains("disconnection_reason")) __score0++;
            if (__jsonProps.Contains("duration_ms")) __score0++;
            if (__jsonProps.Contains("sentiment")) __score0++;
            if (__jsonProps.Contains("start_timestamp")) __score0++;
            if (__jsonProps.Contains("successful")) __score0++;
            if (__jsonProps.Contains("summary")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("chat_id")) __score1++;
            if (__jsonProps.Contains("direction")) __score1++;
            if (__jsonProps.Contains("disconnection_reason")) __score1++;
            if (__jsonProps.Contains("duration_ms")) __score1++;
            if (__jsonProps.Contains("sentiment")) __score1++;
            if (__jsonProps.Contains("start_timestamp")) __score1++;
            if (__jsonProps.Contains("successful")) __score1++;
            if (__jsonProps.Contains("summary")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::RetellAI.ContactCall? call = default;
            global::RetellAI.ContactChat? chat = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ContactCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ContactCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ContactCall).Name}");
                        call = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ContactChat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ContactChat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ContactChat).Name}");
                        chat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (call == null && chat == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ContactCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ContactCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ContactCall).Name}");
                    call = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (call == null && chat == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ContactChat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ContactChat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ContactChat).Name}");
                    chat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.ContactConversation(
                call,

                chat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ContactConversation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ContactCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ContactCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ContactCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Call!, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ContactChat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ContactChat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ContactChat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat!, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class RetellLLMResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.RetellLLMResponse>
    {
        /// <inheritdoc />
        public override global::RetellAI.RetellLLMResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::RetellAI.RetellLLMResponseVariant1? retellLLMResponseVariant1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RetellLLMResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RetellLLMResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RetellLLMResponseVariant1).Name}");
                retellLLMResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::RetellAI.RetellLlmRequest? llmRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RetellLlmRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RetellLlmRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RetellLlmRequest).Name}");
                llmRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::RetellAI.RetellLLMResponseVariant3? retellLLMResponseVariant3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RetellLLMResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RetellLLMResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RetellLLMResponseVariant3).Name}");
                retellLLMResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::RetellAI.RetellLLMResponse(
                retellLLMResponseVariant1,

                llmRequest,

                retellLLMResponseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.RetellLLMResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsRetellLLMResponseVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RetellLLMResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RetellLLMResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RetellLLMResponseVariant1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.RetellLLMResponseVariant1!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsLlmRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RetellLlmRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RetellLlmRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RetellLlmRequest).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.LlmRequest!.Value, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsRetellLLMResponseVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RetellLLMResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RetellLLMResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RetellLLMResponseVariant3).Name}");
                var __element2 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.RetellLLMResponseVariant3!, typeInfo);
                if (__element2.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element2.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class SmsFailedEdgeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.SmsFailedEdge>
    {
        /// <inheritdoc />
        public override global::RetellAI.SmsFailedEdge Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::RetellAI.NodeEdge? node = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeEdge), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeEdge> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeEdge).Name}");
                node = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::RetellAI.SmsFailedEdgeVariant2? smsFailedEdgeVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsFailedEdgeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsFailedEdgeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsFailedEdgeVariant2).Name}");
                smsFailedEdgeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::RetellAI.SmsFailedEdge(
                node,

                smsFailedEdgeVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.SmsFailedEdge value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsNode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeEdge), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeEdge?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeEdge).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Node!, typeInfo);
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
            if (value.IsSmsFailedEdgeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsFailedEdgeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsFailedEdgeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsFailedEdgeVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SmsFailedEdgeVariant2!, typeInfo);
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
            writer.WriteEndObject();
        }
    }
}
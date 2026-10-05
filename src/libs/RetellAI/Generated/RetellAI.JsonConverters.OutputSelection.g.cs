#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class OutputSelectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.OutputSelection>
    {
        /// <inheritdoc />
        public override global::RetellAI.OutputSelection Read(
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
            if (__jsonProps.Contains("fields")) __score0++;
            if (__jsonProps.Contains("mode")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("fields")) __score1++;
            if (__jsonProps.Contains("mode")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::RetellAI.OutputSelectionVariant1? outputSelectionVariant1 = default;
            global::RetellAI.OutputSelectionVariant2? outputSelectionVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OutputSelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OutputSelectionVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OutputSelectionVariant1).Name}");
                        outputSelectionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OutputSelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OutputSelectionVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OutputSelectionVariant2).Name}");
                        outputSelectionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputSelectionVariant1 == null && outputSelectionVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OutputSelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OutputSelectionVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OutputSelectionVariant1).Name}");
                    outputSelectionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (outputSelectionVariant1 == null && outputSelectionVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OutputSelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OutputSelectionVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OutputSelectionVariant2).Name}");
                    outputSelectionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.OutputSelection(
                outputSelectionVariant1,

                outputSelectionVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.OutputSelection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutputSelectionVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OutputSelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OutputSelectionVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OutputSelectionVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOutputSelectionVariant1(), typeInfo);
            }
            else if (value.IsOutputSelectionVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OutputSelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OutputSelectionVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OutputSelectionVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOutputSelectionVariant2(), typeInfo);
            }
        }
    }
}
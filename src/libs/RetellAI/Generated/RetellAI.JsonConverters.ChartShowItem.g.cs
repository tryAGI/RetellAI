#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ChartShowItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ChartShowItem>
    {
        /// <inheritdoc />
        public override global::RetellAI.ChartShowItem Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("measurement")) __score0++;
            if (__jsonProps.Contains("measurement.type")) __score0++;
            if (__jsonProps.Contains("source")) __score0++;
            if (__jsonProps.Contains("source.group")) __score0++;
            if (__jsonProps.Contains("source.type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("measurement")) __score1++;
            if (__jsonProps.Contains("measurement.type")) __score1++;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("source.group")) __score1++;
            if (__jsonProps.Contains("source.type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("measurement")) __score2++;
            if (__jsonProps.Contains("measurement.type")) __score2++;
            if (__jsonProps.Contains("source")) __score2++;
            if (__jsonProps.Contains("source.cast")) __score2++;
            if (__jsonProps.Contains("source.field")) __score2++;
            if (__jsonProps.Contains("source.group")) __score2++;
            if (__jsonProps.Contains("source.type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("measurement")) __score3++;
            if (__jsonProps.Contains("measurement.type")) __score3++;
            if (__jsonProps.Contains("source")) __score3++;
            if (__jsonProps.Contains("source.group")) __score3++;
            if (__jsonProps.Contains("source.type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("measurement")) __score4++;
            if (__jsonProps.Contains("measurement.type")) __score4++;
            if (__jsonProps.Contains("source")) __score4++;
            if (__jsonProps.Contains("source.group")) __score4++;
            if (__jsonProps.Contains("source.type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::RetellAI.ChartShowItemKeywordSource? keywordSource = default;
            global::RetellAI.ChartShowItemNumericSource? numericSource = default;
            global::RetellAI.ChartShowItemCustomFieldSource? customFieldSource = default;
            global::RetellAI.ChartShowItemConcurrencySource? concurrencySource = default;
            global::RetellAI.ChartShowItemCustomToolSource? customToolSource = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemKeywordSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemKeywordSource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemKeywordSource).Name}");
                        keywordSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemNumericSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemNumericSource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemNumericSource).Name}");
                        numericSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemCustomFieldSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemCustomFieldSource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemCustomFieldSource).Name}");
                        customFieldSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemConcurrencySource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemConcurrencySource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemConcurrencySource).Name}");
                        concurrencySource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemCustomToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemCustomToolSource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemCustomToolSource).Name}");
                        customToolSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (keywordSource == null && numericSource == null && customFieldSource == null && concurrencySource == null && customToolSource == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemKeywordSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemKeywordSource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemKeywordSource).Name}");
                    keywordSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (keywordSource == null && numericSource == null && customFieldSource == null && concurrencySource == null && customToolSource == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemNumericSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemNumericSource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemNumericSource).Name}");
                    numericSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (keywordSource == null && numericSource == null && customFieldSource == null && concurrencySource == null && customToolSource == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemCustomFieldSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemCustomFieldSource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemCustomFieldSource).Name}");
                    customFieldSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (keywordSource == null && numericSource == null && customFieldSource == null && concurrencySource == null && customToolSource == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemConcurrencySource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemConcurrencySource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemConcurrencySource).Name}");
                    concurrencySource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (keywordSource == null && numericSource == null && customFieldSource == null && concurrencySource == null && customToolSource == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemCustomToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemCustomToolSource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemCustomToolSource).Name}");
                    customToolSource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.ChartShowItem(
                keywordSource,

                numericSource,

                customFieldSource,

                concurrencySource,

                customToolSource
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ChartShowItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsKeywordSource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemKeywordSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemKeywordSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemKeywordSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KeywordSource!, typeInfo);
            }
            else if (value.IsNumericSource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemNumericSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemNumericSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemNumericSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumericSource!, typeInfo);
            }
            else if (value.IsCustomFieldSource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemCustomFieldSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemCustomFieldSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemCustomFieldSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomFieldSource!, typeInfo);
            }
            else if (value.IsConcurrencySource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemConcurrencySource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemConcurrencySource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemConcurrencySource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConcurrencySource!, typeInfo);
            }
            else if (value.IsCustomToolSource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartShowItemCustomToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartShowItemCustomToolSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartShowItemCustomToolSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolSource!, typeInfo);
            }
        }
    }
}
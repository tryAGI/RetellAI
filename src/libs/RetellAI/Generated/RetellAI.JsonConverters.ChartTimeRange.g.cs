#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ChartTimeRangeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ChartTimeRange>
    {
        /// <inheritdoc />
        public override global::RetellAI.ChartTimeRange Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("window")) __score0++;
            if (__jsonProps.Contains("window.unit")) __score0++;
            if (__jsonProps.Contains("window.value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("unit")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::RetellAI.ChartTimeRangeVariant1? chartTimeRangeVariant1 = default;
            global::RetellAI.ChartTimeRangeVariant2? chartTimeRangeVariant2 = default;
            global::RetellAI.ChartTimeRangeVariant3? chartTimeRangeVariant3 = default;
            global::RetellAI.ChartTimeRangeVariant4? chartTimeRangeVariant4 = default;
            global::RetellAI.ChartTimeRangeVariant5? chartTimeRangeVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant1).Name}");
                        chartTimeRangeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant2).Name}");
                        chartTimeRangeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant3).Name}");
                        chartTimeRangeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant4).Name}");
                        chartTimeRangeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant5).Name}");
                        chartTimeRangeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chartTimeRangeVariant1 == null && chartTimeRangeVariant2 == null && chartTimeRangeVariant3 == null && chartTimeRangeVariant4 == null && chartTimeRangeVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant1).Name}");
                    chartTimeRangeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chartTimeRangeVariant1 == null && chartTimeRangeVariant2 == null && chartTimeRangeVariant3 == null && chartTimeRangeVariant4 == null && chartTimeRangeVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant2).Name}");
                    chartTimeRangeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chartTimeRangeVariant1 == null && chartTimeRangeVariant2 == null && chartTimeRangeVariant3 == null && chartTimeRangeVariant4 == null && chartTimeRangeVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant3).Name}");
                    chartTimeRangeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chartTimeRangeVariant1 == null && chartTimeRangeVariant2 == null && chartTimeRangeVariant3 == null && chartTimeRangeVariant4 == null && chartTimeRangeVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant4).Name}");
                    chartTimeRangeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chartTimeRangeVariant1 == null && chartTimeRangeVariant2 == null && chartTimeRangeVariant3 == null && chartTimeRangeVariant4 == null && chartTimeRangeVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant5).Name}");
                    chartTimeRangeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.ChartTimeRange(
                chartTimeRangeVariant1,

                chartTimeRangeVariant2,

                chartTimeRangeVariant3,

                chartTimeRangeVariant4,

                chartTimeRangeVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ChartTimeRange value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChartTimeRangeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChartTimeRangeVariant1!, typeInfo);
            }
            else if (value.IsChartTimeRangeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChartTimeRangeVariant2!, typeInfo);
            }
            else if (value.IsChartTimeRangeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChartTimeRangeVariant3!, typeInfo);
            }
            else if (value.IsChartTimeRangeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChartTimeRangeVariant4!, typeInfo);
            }
            else if (value.IsChartTimeRangeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ChartTimeRangeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ChartTimeRangeVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ChartTimeRangeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChartTimeRangeVariant5!, typeInfo);
            }
        }
    }
}
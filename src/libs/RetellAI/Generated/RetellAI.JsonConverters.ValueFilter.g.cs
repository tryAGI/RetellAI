#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ValueFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ValueFilter>
    {
        /// <inheritdoc />
        public override global::RetellAI.ValueFilter Read(
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
            if (__jsonProps.Contains("op")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("op")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("op")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("op")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("op")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("op")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::RetellAI.StringFilter? @string = default;
            global::RetellAI.NumberFilter? number = default;
            global::RetellAI.BooleanFilter? boolean = default;
            global::RetellAI.RangeFilter? range = default;
            global::RetellAI.EnumFilter? @enum = default;
            global::RetellAI.PresentFilter? present = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StringFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StringFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StringFilter).Name}");
                        @string = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NumberFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NumberFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NumberFilter).Name}");
                        number = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BooleanFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BooleanFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BooleanFilter).Name}");
                        boolean = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RangeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RangeFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RangeFilter).Name}");
                        range = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EnumFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EnumFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EnumFilter).Name}");
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PresentFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PresentFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PresentFilter).Name}");
                        present = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@string == null && number == null && boolean == null && range == null && @enum == null && present == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StringFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StringFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StringFilter).Name}");
                    @string = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NumberFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NumberFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NumberFilter).Name}");
                    number = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BooleanFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BooleanFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BooleanFilter).Name}");
                    boolean = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RangeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RangeFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RangeFilter).Name}");
                    range = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EnumFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EnumFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EnumFilter).Name}");
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PresentFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PresentFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PresentFilter).Name}");
                    present = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.ValueFilter(
                @string,

                number,

                boolean,

                range,

                @enum,

                present
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ValueFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StringFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StringFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StringFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String!, typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NumberFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NumberFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NumberFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Number!, typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BooleanFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BooleanFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BooleanFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Boolean!, typeInfo);
            }
            else if (value.IsRange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RangeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RangeFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RangeFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Range!, typeInfo);
            }
            else if (value.IsEnum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EnumFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EnumFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EnumFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum!, typeInfo);
            }
            else if (value.IsPresent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PresentFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PresentFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PresentFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Present!, typeInfo);
            }
        }
    }
}
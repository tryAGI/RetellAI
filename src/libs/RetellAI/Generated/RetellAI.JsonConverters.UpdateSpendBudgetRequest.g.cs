#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class UpdateSpendBudgetRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.UpdateSpendBudgetRequest>
    {
        /// <inheritdoc />
        public override global::RetellAI.UpdateSpendBudgetRequest Read(
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
            if (__jsonProps.Contains("enabled")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("custom_alerts")) __score1++;
            if (__jsonProps.Contains("enabled")) __score1++;
            if (__jsonProps.Contains("monthly_budget_cents")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::RetellAI.UpdateSpendBudgetRequestVariant1? updateSpendBudgetRequestVariant1 = default;
            global::RetellAI.UpdateSpendBudgetRequestVariant2? updateSpendBudgetRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.UpdateSpendBudgetRequestVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1).Name}");
                        updateSpendBudgetRequestVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.UpdateSpendBudgetRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2).Name}");
                        updateSpendBudgetRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (updateSpendBudgetRequestVariant1 == null && updateSpendBudgetRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.UpdateSpendBudgetRequestVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1).Name}");
                    updateSpendBudgetRequestVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (updateSpendBudgetRequestVariant1 == null && updateSpendBudgetRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.UpdateSpendBudgetRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2).Name}");
                    updateSpendBudgetRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.UpdateSpendBudgetRequest(
                updateSpendBudgetRequestVariant1,

                updateSpendBudgetRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.UpdateSpendBudgetRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUpdateSpendBudgetRequestVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.UpdateSpendBudgetRequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.UpdateSpendBudgetRequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateSpendBudgetRequestVariant1!, typeInfo);
            }
            else if (value.IsUpdateSpendBudgetRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.UpdateSpendBudgetRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.UpdateSpendBudgetRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateSpendBudgetRequestVariant2!, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class StoredCallFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.StoredCallFilter>
    {
        /// <inheritdoc />
        public override global::RetellAI.StoredCallFilter Read(
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
            if (__jsonProps.Contains("agent")) __score0++;
            if (__jsonProps.Contains("agent_tag")) __score0++;
            if (__jsonProps.Contains("batch_call_id")) __score0++;
            if (__jsonProps.Contains("batch_call_id.op")) __score0++;
            if (__jsonProps.Contains("batch_call_id.type")) __score0++;
            if (__jsonProps.Contains("batch_call_id.value")) __score0++;
            if (__jsonProps.Contains("call_id")) __score0++;
            if (__jsonProps.Contains("call_status")) __score0++;
            if (__jsonProps.Contains("call_successful")) __score0++;
            if (__jsonProps.Contains("call_successful.op")) __score0++;
            if (__jsonProps.Contains("call_successful.type")) __score0++;
            if (__jsonProps.Contains("call_successful.value")) __score0++;
            if (__jsonProps.Contains("call_type")) __score0++;
            if (__jsonProps.Contains("combined_cost")) __score0++;
            if (__jsonProps.Contains("custom_analysis_data")) __score0++;
            if (__jsonProps.Contains("custom_attributes")) __score0++;
            if (__jsonProps.Contains("data_storage_setting")) __score0++;
            if (__jsonProps.Contains("direction")) __score0++;
            if (__jsonProps.Contains("disconnection_reason")) __score0++;
            if (__jsonProps.Contains("duration_ms")) __score0++;
            if (__jsonProps.Contains("dynamic_variables")) __score0++;
            if (__jsonProps.Contains("e2e_latency_p50")) __score0++;
            if (__jsonProps.Contains("end_timestamp")) __score0++;
            if (__jsonProps.Contains("from_number")) __score0++;
            if (__jsonProps.Contains("from_number.op")) __score0++;
            if (__jsonProps.Contains("from_number.type")) __score0++;
            if (__jsonProps.Contains("from_number.value")) __score0++;
            if (__jsonProps.Contains("in_voicemail")) __score0++;
            if (__jsonProps.Contains("in_voicemail.op")) __score0++;
            if (__jsonProps.Contains("in_voicemail.type")) __score0++;
            if (__jsonProps.Contains("in_voicemail.value")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("start_timestamp")) __score0++;
            if (__jsonProps.Contains("to_number")) __score0++;
            if (__jsonProps.Contains("to_number.op")) __score0++;
            if (__jsonProps.Contains("to_number.type")) __score0++;
            if (__jsonProps.Contains("to_number.value")) __score0++;
            if (__jsonProps.Contains("tool_calls")) __score0++;
            if (__jsonProps.Contains("user_sentiment")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("transfer_agent")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::RetellAI.CallFilter? callFilter = default;
            global::RetellAI.StoredCallFilterVariant2? storedCallFilterVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CallFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CallFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CallFilter).Name}");
                        callFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StoredCallFilterVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StoredCallFilterVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StoredCallFilterVariant2).Name}");
                        storedCallFilterVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (callFilter == null && storedCallFilterVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CallFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CallFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CallFilter).Name}");
                    callFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (callFilter == null && storedCallFilterVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StoredCallFilterVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StoredCallFilterVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StoredCallFilterVariant2).Name}");
                    storedCallFilterVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.StoredCallFilter(
                callFilter,

                storedCallFilterVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.StoredCallFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCallFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CallFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CallFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CallFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallFilter!, typeInfo);
            }
            else if (value.IsStoredCallFilterVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StoredCallFilterVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StoredCallFilterVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StoredCallFilterVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StoredCallFilterVariant2!, typeInfo);
            }
        }
    }
}
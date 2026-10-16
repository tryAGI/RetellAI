#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class SmsDestination2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.SmsDestination2>
    {
        /// <inheritdoc />
        public override global::RetellAI.SmsDestination2 Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("ignore_e164_validation")) __score1++;
            if (__jsonProps.Contains("phone_number")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::RetellAI.SmsDestinationDestinationCustomerNumber? destinationCustomerNumber = default;
            global::RetellAI.SmsDestinationDestinationPhoneNumber? destinationPhoneNumber = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsDestinationDestinationCustomerNumber> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber).Name}");
                        destinationCustomerNumber = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsDestinationDestinationPhoneNumber> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber).Name}");
                        destinationPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (destinationCustomerNumber == null && destinationPhoneNumber == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsDestinationDestinationCustomerNumber> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber).Name}");
                    destinationCustomerNumber = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (destinationCustomerNumber == null && destinationPhoneNumber == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsDestinationDestinationPhoneNumber> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber).Name}");
                    destinationPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.SmsDestination2(
                destinationCustomerNumber,

                destinationPhoneNumber
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.SmsDestination2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDestinationCustomerNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsDestinationDestinationCustomerNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsDestinationDestinationCustomerNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDestinationCustomerNumber(), typeInfo);
            }
            else if (value.IsDestinationPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsDestinationDestinationPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsDestinationDestinationPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDestinationPhoneNumber(), typeInfo);
            }
        }
    }
}
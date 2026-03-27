
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Available LLM models for agents.
    /// </summary>
    public enum LLMModelNullable
    {
        /// <summary>
        /// 
        /// </summary>
        Claude45Haiku,
        /// <summary>
        /// 
        /// </summary>
        Claude45Sonnet,
        /// <summary>
        /// 
        /// </summary>
        Claude46Sonnet,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini30Flash,
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt51,
        /// <summary>
        /// 
        /// </summary>
        Gpt52,
        /// <summary>
        /// 
        /// </summary>
        Gpt54,
        /// <summary>
        /// 
        /// </summary>
        Gpt54Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt54Nano,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMModelNullableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMModelNullable value)
        {
            return value switch
            {
                LLMModelNullable.Claude45Haiku => "claude-4.5-haiku",
                LLMModelNullable.Claude45Sonnet => "claude-4.5-sonnet",
                LLMModelNullable.Claude46Sonnet => "claude-4.6-sonnet",
                LLMModelNullable.Gemini25Flash => "gemini-2.5-flash",
                LLMModelNullable.Gemini25FlashLite => "gemini-2.5-flash-lite",
                LLMModelNullable.Gemini30Flash => "gemini-3.0-flash",
                LLMModelNullable.Gpt41 => "gpt-4.1",
                LLMModelNullable.Gpt41Mini => "gpt-4.1-mini",
                LLMModelNullable.Gpt41Nano => "gpt-4.1-nano",
                LLMModelNullable.Gpt5 => "gpt-5",
                LLMModelNullable.Gpt5Mini => "gpt-5-mini",
                LLMModelNullable.Gpt5Nano => "gpt-5-nano",
                LLMModelNullable.Gpt51 => "gpt-5.1",
                LLMModelNullable.Gpt52 => "gpt-5.2",
                LLMModelNullable.Gpt54 => "gpt-5.4",
                LLMModelNullable.Gpt54Mini => "gpt-5.4-mini",
                LLMModelNullable.Gpt54Nano => "gpt-5.4-nano",
                LLMModelNullable.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMModelNullable? ToEnum(string value)
        {
            return value switch
            {
                "claude-4.5-haiku" => LLMModelNullable.Claude45Haiku,
                "claude-4.5-sonnet" => LLMModelNullable.Claude45Sonnet,
                "claude-4.6-sonnet" => LLMModelNullable.Claude46Sonnet,
                "gemini-2.5-flash" => LLMModelNullable.Gemini25Flash,
                "gemini-2.5-flash-lite" => LLMModelNullable.Gemini25FlashLite,
                "gemini-3.0-flash" => LLMModelNullable.Gemini30Flash,
                "gpt-4.1" => LLMModelNullable.Gpt41,
                "gpt-4.1-mini" => LLMModelNullable.Gpt41Mini,
                "gpt-4.1-nano" => LLMModelNullable.Gpt41Nano,
                "gpt-5" => LLMModelNullable.Gpt5,
                "gpt-5-mini" => LLMModelNullable.Gpt5Mini,
                "gpt-5-nano" => LLMModelNullable.Gpt5Nano,
                "gpt-5.1" => LLMModelNullable.Gpt51,
                "gpt-5.2" => LLMModelNullable.Gpt52,
                "gpt-5.4" => LLMModelNullable.Gpt54,
                "gpt-5.4-mini" => LLMModelNullable.Gpt54Mini,
                "gpt-5.4-nano" => LLMModelNullable.Gpt54Nano,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => LLMModelNullable.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}
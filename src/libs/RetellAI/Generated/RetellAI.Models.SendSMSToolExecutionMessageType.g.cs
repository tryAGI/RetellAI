
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
    /// </summary>
    public enum SendSMSToolExecutionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        StaticText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendSMSToolExecutionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendSMSToolExecutionMessageType value)
        {
            return value switch
            {
                SendSMSToolExecutionMessageType.Prompt => "prompt",
                SendSMSToolExecutionMessageType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendSMSToolExecutionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => SendSMSToolExecutionMessageType.Prompt,
                "static_text" => SendSMSToolExecutionMessageType.StaticText,
                _ => null,
            };
        }
    }
}
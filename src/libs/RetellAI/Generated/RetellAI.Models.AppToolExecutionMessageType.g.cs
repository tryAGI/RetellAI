
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Only applies to during conversation functions; ignored by the pre/post conversation. Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
    /// </summary>
    public enum AppToolExecutionMessageType
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
    public static class AppToolExecutionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppToolExecutionMessageType value)
        {
            return value switch
            {
                AppToolExecutionMessageType.Prompt => "prompt",
                AppToolExecutionMessageType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppToolExecutionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => AppToolExecutionMessageType.Prompt,
                "static_text" => AppToolExecutionMessageType.StaticText,
                _ => null,
            };
        }
    }
}
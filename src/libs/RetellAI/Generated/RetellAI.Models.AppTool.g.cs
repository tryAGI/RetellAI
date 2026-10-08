
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppTool
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AppToolTypeJsonConverter))]
        public global::RetellAI.AppToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within the phase's tools; referenced by depends_on. Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The connection (App) this tool runs against. Must be a connection in the organization whose provider matches this tool's provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppId { get; set; }

        /// <summary>
        /// Provider of the connection. Must match the connection's provider; supported providers are listed by list-app-templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Name of the catalog template within the provider, as listed by list-app-templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_tool_template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppToolTemplateName { get; set; }

        /// <summary>
        /// The resolved input parameters, in order. Properties may pin a value with const (including {{variable}} references) or provide a description for LLM inference. Each property may also record selected_input_mode, the editor mode the user selected ("const_enum", "const_boolean", "const_value", "description_custom", or "description_preset"); it is stored and returned as-is, used only by the tool config UI. Omit the key when no mode is recorded; when set, const_* modes require a non-empty const, and description_* modes must omit const entirely. Each parameter's required list must match the schema returned by the corresponding step of the get-app-tool-schema loop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>? Parameters { get; set; }

        /// <summary>
        /// Mapping of a dynamic-variable name to the response field (dot-path) it is populated from. Missing paths are ignored.<br/>
        /// Example: {"contact_first_name":"data.first_name"}
        /// </summary>
        /// <example>{"contact_first_name":"data.first_name"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ResponseVariables { get; set; }

        /// <summary>
        /// What the agent and the transcript see of the tool's response. Omit to send the full response. Does not affect response_variables, which are always extracted from the raw response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OutputSelectionJsonConverter))]
        public global::RetellAI.OutputSelection? OutputSelection { get; set; }

        /// <summary>
        /// Only applies to during conversation functions; ignored by the pre/post conversation. Overrides the catalog template's LLM-facing description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Only applies to during conversation functions; ignored by the pre/post conversation. If true, will speak during execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Only applies to during conversation functions; ignored by the pre/post conversation. Determines whether the agent would call LLM another time and speak when the result of the tool is obtained.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_after_execution")]
        public bool? SpeakAfterExecution { get; set; }

        /// <summary>
        /// Only applies to during conversation functions; ignored by the pre/post conversation. The message for the agent to speak when executing the tool. Only applicable when speak_during_execution is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Only applies to during conversation functions; ignored by the pre/post conversation. Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AppToolExecutionMessageTypeJsonConverter))]
        public global::RetellAI.AppToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// Only applies to during conversation functions; ignored by the pre/post conversation. If true, play a typing sound on the agent audio track while this tool is executing. Useful when the tool takes a noticeable amount of time to prevent silence on the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_typing_sound")]
        public bool? EnableTypingSound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within the phase's tools; referenced by depends_on. Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="appId">
        /// The connection (App) this tool runs against. Must be a connection in the organization whose provider matches this tool's provider.
        /// </param>
        /// <param name="provider">
        /// Provider of the connection. Must match the connection's provider; supported providers are listed by list-app-templates.
        /// </param>
        /// <param name="appToolTemplateName">
        /// Name of the catalog template within the provider, as listed by list-app-templates.
        /// </param>
        /// <param name="type"></param>
        /// <param name="parameters">
        /// The resolved input parameters, in order. Properties may pin a value with const (including {{variable}} references) or provide a description for LLM inference. Each property may also record selected_input_mode, the editor mode the user selected ("const_enum", "const_boolean", "const_value", "description_custom", or "description_preset"); it is stored and returned as-is, used only by the tool config UI. Omit the key when no mode is recorded; when set, const_* modes require a non-empty const, and description_* modes must omit const entirely. Each parameter's required list must match the schema returned by the corresponding step of the get-app-tool-schema loop.
        /// </param>
        /// <param name="responseVariables">
        /// Mapping of a dynamic-variable name to the response field (dot-path) it is populated from. Missing paths are ignored.<br/>
        /// Example: {"contact_first_name":"data.first_name"}
        /// </param>
        /// <param name="outputSelection">
        /// What the agent and the transcript see of the tool's response. Omit to send the full response. Does not affect response_variables, which are always extracted from the raw response.
        /// </param>
        /// <param name="description">
        /// Only applies to during conversation functions; ignored by the pre/post conversation. Overrides the catalog template's LLM-facing description.
        /// </param>
        /// <param name="speakDuringExecution">
        /// Only applies to during conversation functions; ignored by the pre/post conversation. If true, will speak during execution.
        /// </param>
        /// <param name="speakAfterExecution">
        /// Only applies to during conversation functions; ignored by the pre/post conversation. Determines whether the agent would call LLM another time and speak when the result of the tool is obtained.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="executionMessageDescription">
        /// Only applies to during conversation functions; ignored by the pre/post conversation. The message for the agent to speak when executing the tool. Only applicable when speak_during_execution is true.
        /// </param>
        /// <param name="executionMessageType">
        /// Only applies to during conversation functions; ignored by the pre/post conversation. Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        /// <param name="enableTypingSound">
        /// Only applies to during conversation functions; ignored by the pre/post conversation. If true, play a typing sound on the agent audio track while this tool is executing. Useful when the tool takes a noticeable amount of time to prevent silence on the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppTool(
            string name,
            string appId,
            string provider,
            string appToolTemplateName,
            global::RetellAI.AppToolType type,
            global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>? parameters,
            global::System.Collections.Generic.Dictionary<string, string>? responseVariables,
            global::RetellAI.OutputSelection? outputSelection,
            string? description,
            bool? speakDuringExecution,
            bool? speakAfterExecution,
            string? executionMessageDescription,
            global::RetellAI.AppToolExecutionMessageType? executionMessageType,
            bool? enableTypingSound)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.AppToolTemplateName = appToolTemplateName ?? throw new global::System.ArgumentNullException(nameof(appToolTemplateName));
            this.Parameters = parameters;
            this.ResponseVariables = responseVariables;
            this.OutputSelection = outputSelection;
            this.Description = description;
            this.SpeakDuringExecution = speakDuringExecution;
            this.SpeakAfterExecution = speakAfterExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
            this.EnableTypingSound = enableTypingSound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppTool" /> class.
        /// </summary>
        public AppTool()
        {
        }

    }
}
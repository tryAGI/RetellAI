
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CustomToolTypeJsonConverter))]
        public global::RetellAI.CustomToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Describes what this tool does and when to call this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Method to use for the request, default to POST.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CustomToolMethodJsonConverter))]
        public global::RetellAI.CustomToolMethod? Method { get; set; }

        /// <summary>
        /// Headers to add to the request.<br/>
        /// Example: {"Authorization":"Bearer 1234567890"}
        /// </summary>
        /// <example>{"Authorization":"Bearer 1234567890"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Query parameters to append to the request URL.<br/>
        /// Example: {"page":"1","sort":"asc"}
        /// </summary>
        /// <example>{"page":"1","sort":"asc"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? QueryParams { get; set; }

        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::RetellAI.ToolParameter? Parameters { get; set; }

        /// <summary>
        /// A mapping of variable names to JSON paths in the response body. These values will be extracted from the response and made available as dynamic variables for use.<br/>
        /// Example: {"user_name":"data.user.name"}
        /// </summary>
        /// <example>{"user_name":"data.user.name"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ResponseVariables { get; set; }

        /// <summary>
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the function. Recommend to turn on if your function call takes over 1s (including network) to complete, so that your agent remains responsive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained. Usually this needs to get turned on so user can get update for the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_after_execution")]
        public bool? SpeakAfterExecution { get; set; }

        /// <summary>
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true. Can write what to say or even provide examples. The default is "The message you will say to callee when calling this tool. Make sure it fits into the conversation smoothly.".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CustomToolExecutionMessageTypeJsonConverter))]
        public global::RetellAI.CustomToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// The maximum time in milliseconds the tool can run before it's considered timeout. If the tool times out, the agent would have that info. The minimum value allowed is 1000 ms (1 s), and maximum value allowed is 600,000 ms (10 min). By default, this is set to 120,000 ms (2 min).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Maximum number of times to retry the request after a failed attempt, from 0 (no retry) to 5. Retries happen on any failure, with exponential backoff between attempts; the backoff delay is not configurable. `timeout_ms` applies per attempt rather than as a budget across all attempts, so an attempt that times out is still retried and the worst-case total duration is `timeout_ms` multiplied by (`max_retry` + 1) as well as any latency incurred by the exponential backoff + jitter between each retry. Only the final attempt's result is reported to the agent. Because retries repeat the request, only set this above 0 if your endpoint is idempotent — a retried request may be processed more than once. Defaults to 0 (no retry).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retry")]
        public int? MaxRetry { get; set; }

        /// <summary>
        /// If set to true, the parameters will be passed as root level JSON object instead of nested under "args".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args_at_root")]
        public bool? ArgsAtRoot { get; set; }

        /// <summary>
        /// How the tool's `parameters` are authored and shown in the dashboard editor — "form" for the visual parameter builder, "json" for a raw JSON Schema. Both produce the same `parameters` schema; this does not change how the request body is encoded (see `args_at_root`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CustomToolParameterTypeJsonConverter))]
        public global::RetellAI.CustomToolParameterType? ParameterType { get; set; }

        /// <summary>
        /// If true, play a typing sound on the agent audio track while this tool is executing. Useful when the tool takes a noticeable amount of time to prevent silence on the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_typing_sound")]
        public bool? EnableTypingSound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="url">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what this tool does and when to call this tool.
        /// </param>
        /// <param name="method">
        /// Method to use for the request, default to POST.
        /// </param>
        /// <param name="headers">
        /// Headers to add to the request.<br/>
        /// Example: {"Authorization":"Bearer 1234567890"}
        /// </param>
        /// <param name="queryParams">
        /// Query parameters to append to the request URL.<br/>
        /// Example: {"page":"1","sort":"asc"}
        /// </param>
        /// <param name="parameters">
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </param>
        /// <param name="responseVariables">
        /// A mapping of variable names to JSON paths in the response body. These values will be extracted from the response and made available as dynamic variables for use.<br/>
        /// Example: {"user_name":"data.user.name"}
        /// </param>
        /// <param name="speakDuringExecution">
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the function. Recommend to turn on if your function call takes over 1s (including network) to complete, so that your agent remains responsive.
        /// </param>
        /// <param name="speakAfterExecution">
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained. Usually this needs to get turned on so user can get update for the function call.
        /// </param>
        /// <param name="executionMessageDescription">
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true. Can write what to say or even provide examples. The default is "The message you will say to callee when calling this tool. Make sure it fits into the conversation smoothly.".
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        /// <param name="timeoutMs">
        /// The maximum time in milliseconds the tool can run before it's considered timeout. If the tool times out, the agent would have that info. The minimum value allowed is 1000 ms (1 s), and maximum value allowed is 600,000 ms (10 min). By default, this is set to 120,000 ms (2 min).
        /// </param>
        /// <param name="maxRetry">
        /// Maximum number of times to retry the request after a failed attempt, from 0 (no retry) to 5. Retries happen on any failure, with exponential backoff between attempts; the backoff delay is not configurable. `timeout_ms` applies per attempt rather than as a budget across all attempts, so an attempt that times out is still retried and the worst-case total duration is `timeout_ms` multiplied by (`max_retry` + 1) as well as any latency incurred by the exponential backoff + jitter between each retry. Only the final attempt's result is reported to the agent. Because retries repeat the request, only set this above 0 if your endpoint is idempotent — a retried request may be processed more than once. Defaults to 0 (no retry).
        /// </param>
        /// <param name="argsAtRoot">
        /// If set to true, the parameters will be passed as root level JSON object instead of nested under "args".
        /// </param>
        /// <param name="parameterType">
        /// How the tool's `parameters` are authored and shown in the dashboard editor — "form" for the visual parameter builder, "json" for a raw JSON Schema. Both produce the same `parameters` schema; this does not change how the request body is encoded (see `args_at_root`).
        /// </param>
        /// <param name="enableTypingSound">
        /// If true, play a typing sound on the agent audio track while this tool is executing. Useful when the tool takes a noticeable amount of time to prevent silence on the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTool(
            string name,
            string url,
            global::RetellAI.CustomToolType type,
            string? description,
            global::RetellAI.CustomToolMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? queryParams,
            global::RetellAI.ToolParameter? parameters,
            global::System.Collections.Generic.Dictionary<string, string>? responseVariables,
            bool? speakDuringExecution,
            bool? speakAfterExecution,
            string? executionMessageDescription,
            global::RetellAI.CustomToolExecutionMessageType? executionMessageType,
            int? timeoutMs,
            int? maxRetry,
            bool? argsAtRoot,
            global::RetellAI.CustomToolParameterType? parameterType,
            bool? enableTypingSound)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description;
            this.Method = method;
            this.Headers = headers;
            this.QueryParams = queryParams;
            this.Parameters = parameters;
            this.ResponseVariables = responseVariables;
            this.SpeakDuringExecution = speakDuringExecution;
            this.SpeakAfterExecution = speakAfterExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
            this.TimeoutMs = timeoutMs;
            this.MaxRetry = maxRetry;
            this.ArgsAtRoot = argsAtRoot;
            this.ParameterType = parameterType;
            this.EnableTypingSound = enableTypingSound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        public CustomTool()
        {
        }

    }
}
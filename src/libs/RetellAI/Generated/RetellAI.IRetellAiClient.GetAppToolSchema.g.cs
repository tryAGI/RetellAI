#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// One round of multi-step schema resolution for an app tool template against a connected App. parameters is the input parameters resolved so far, with properties configured by const or description, and is empty on the first call. Returns the next input_schema to fill; complete marks the last round (it may accompany the final input_schema) and may include an optional response_schema. Input-schema property descriptions provide the default text for LLM inference, and each property's default_input_mode ("const" or "description") is the input mode to preselect for it. A property may also carry extra_info ({ text?, link? }), guidance to render under its editor, e.g. a docs link on how to find an id. Used by the tool config UI.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.GetAppToolSchemaResponse> GetAppToolSchemaAsync(
            string appId,

            global::RetellAI.GetAppToolSchemaRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// One round of multi-step schema resolution for an app tool template against a connected App. parameters is the input parameters resolved so far, with properties configured by const or description, and is empty on the first call. Returns the next input_schema to fill; complete marks the last round (it may accompany the final input_schema) and may include an optional response_schema. Input-schema property descriptions provide the default text for LLM inference, and each property's default_input_mode ("const" or "description") is the input mode to preselect for it. A property may also carry extra_info ({ text?, link? }), guidance to render under its editor, e.g. a docs link on how to find an id. Used by the tool config UI.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.GetAppToolSchemaResponse>> GetAppToolSchemaAsResponseAsync(
            string appId,

            global::RetellAI.GetAppToolSchemaRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// One round of multi-step schema resolution for an app tool template against a connected App. parameters is the input parameters resolved so far, with properties configured by const or description, and is empty on the first call. Returns the next input_schema to fill; complete marks the last round (it may accompany the final input_schema) and may include an optional response_schema. Input-schema property descriptions provide the default text for LLM inference, and each property's default_input_mode ("const" or "description") is the input mode to preselect for it. A property may also carry extra_info ({ text?, link? }), guidance to render under its editor, e.g. a docs link on how to find an id. Used by the tool config UI.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appToolTemplateName">
        /// The app tool template name (the provider's catalog tool name).
        /// </param>
        /// <param name="parameters">
        /// The input parameters resolved so far; empty on the first call.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.GetAppToolSchemaResponse> GetAppToolSchemaAsync(
            string appId,
            string appToolTemplateName,
            global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>? parameters = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
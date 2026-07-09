#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Update metadata and sensitive data storage settings for an existing call.
        /// </summary>
        /// <param name="callId">
        /// Example: call_a4441234567890777c4a4a123e6
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.V2CallResponse> UpdateCallMetadataAsync(
            string callId,

            global::RetellAI.UpdateCallMetadataRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metadata and sensitive data storage settings for an existing call.
        /// </summary>
        /// <param name="callId">
        /// Example: call_a4441234567890777c4a4a123e6
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.V2CallResponse>> UpdateCallMetadataAsResponseAsync(
            string callId,

            global::RetellAI.UpdateCallMetadataRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metadata and sensitive data storage settings for an existing call.
        /// </summary>
        /// <param name="callId">
        /// Example: call_a4441234567890777c4a4a123e6
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object. Size limited to 50kB max.<br/>
        /// Example: {"customer_id":"cust_123","notes":"Follow-up required"}
        /// </param>
        /// <param name="dataStorageSetting">
        /// Data storage setting for this call. Overrides the agent's default setting. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
        /// Example: everything_except_pii
        /// </param>
        /// <param name="customAttributes">
        /// Custom attributes for the call<br/>
        /// Example: {"custom_attribute_1":"value1","custom_attribute_2":"value2"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.V2CallResponse> UpdateCallMetadataAsync(
            string callId,
            object? metadata = default,
            global::RetellAI.UpdateCallMetadataRequestDataStorageSetting? dataStorageSetting = default,
            object? customAttributes = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
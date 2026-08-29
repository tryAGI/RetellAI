#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Start an incremental contact import from an uploaded CSV: creates new contacts and updates existing ones matched by phone number. Mapped columns overwrite the matched contact's fields; unmapped columns are ignored. Runs asynchronously — poll get-contact-import for progress.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.JobStatus> CreateContactImportAsync(

            global::RetellAI.CreateContactImportRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an incremental contact import from an uploaded CSV: creates new contacts and updates existing ones matched by phone number. Mapped columns overwrite the matched contact's fields; unmapped columns are ignored. Runs asynchronously — poll get-contact-import for progress.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.JobStatus>> CreateContactImportAsResponseAsync(

            global::RetellAI.CreateContactImportRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an incremental contact import from an uploaded CSV: creates new contacts and updates existing ones matched by phone number. Mapped columns overwrite the matched contact's fields; unmapped columns are ignored. Runs asynchronously — poll get-contact-import for progress.
        /// </summary>
        /// <param name="uploadId">
        /// Id returned by upload-contact-import-file.
        /// </param>
        /// <param name="columnMapping">
        /// CSV headers mapped to contact fields. field_name is the contact field and external_field_name is the CSV header. Exactly one mapping must target phone_number. Unmapped columns are ignored.
        /// </param>
        /// <param name="defaultCountry">
        /// Country for parsing phone numbers without a country code. Defaults to US.
        /// </param>
        /// <param name="tags">
        /// Tags added to every contact in this import. Existing tags are preserved. Omit to leave tags unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.JobStatus> CreateContactImportAsync(
            string uploadId,
            global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping> columnMapping,
            string? defaultCountry = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
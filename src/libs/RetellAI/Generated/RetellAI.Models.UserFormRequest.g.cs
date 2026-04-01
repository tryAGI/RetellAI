
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserFormRequest
    {
        /// <summary>
        /// A JSON object containing survey form data with string values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("form")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Form { get; set; }

        /// <summary>
        /// UTM tracking parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utm_parameters")]
        public global::System.Collections.Generic.Dictionary<string, string>? UtmParameters { get; set; }

        /// <summary>
        /// Referrer URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referrer")]
        public string? Referrer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFormRequest" /> class.
        /// </summary>
        /// <param name="form">
        /// A JSON object containing survey form data with string values
        /// </param>
        /// <param name="utmParameters">
        /// UTM tracking parameters
        /// </param>
        /// <param name="referrer">
        /// Referrer URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserFormRequest(
            global::System.Collections.Generic.Dictionary<string, string> form,
            global::System.Collections.Generic.Dictionary<string, string>? utmParameters,
            string? referrer)
        {
            this.Form = form ?? throw new global::System.ArgumentNullException(nameof(form));
            this.UtmParameters = utmParameters;
            this.Referrer = referrer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFormRequest" /> class.
        /// </summary>
        public UserFormRequest()
        {
        }
    }
}
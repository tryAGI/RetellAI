
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormTimeValue
    {
        /// <summary>
        /// 24-hour `HH:mm`, such as `21:30`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Time { get; set; }

        /// <summary>
        /// IANA time zone name, such as `America/Los_Angeles`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimeZone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormTimeValue" /> class.
        /// </summary>
        /// <param name="time">
        /// 24-hour `HH:mm`, such as `21:30`.
        /// </param>
        /// <param name="timeZone">
        /// IANA time zone name, such as `America/Los_Angeles`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormTimeValue(
            string time,
            string timeZone)
        {
            this.Time = time ?? throw new global::System.ArgumentNullException(nameof(time));
            this.TimeZone = timeZone ?? throw new global::System.ArgumentNullException(nameof(timeZone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormTimeValue" /> class.
        /// </summary>
        public ConductorFormTimeValue()
        {
        }

    }
}
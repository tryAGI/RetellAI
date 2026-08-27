
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Score threshold a call must meet to be marked successful.
    /// </summary>
    public sealed partial class CohortSuccessfulCriteria
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CohortSuccessfulCriteriaTypeJsonConverter))]
        public global::RetellAI.CohortSuccessfulCriteriaType? Type { get; set; }

        /// <summary>
        /// Score threshold value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Comparison operator applied against `value`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CohortSuccessfulCriteriaOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.CohortSuccessfulCriteriaOp Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortSuccessfulCriteria" /> class.
        /// </summary>
        /// <param name="value">
        /// Score threshold value.
        /// </param>
        /// <param name="op">
        /// Comparison operator applied against `value`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortSuccessfulCriteria(
            double value,
            global::RetellAI.CohortSuccessfulCriteriaOp op,
            global::RetellAI.CohortSuccessfulCriteriaType? type)
        {
            this.Type = type;
            this.Value = value;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortSuccessfulCriteria" /> class.
        /// </summary>
        public CohortSuccessfulCriteria()
        {
        }

    }
}
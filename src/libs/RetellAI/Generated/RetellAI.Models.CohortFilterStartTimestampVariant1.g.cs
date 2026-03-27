
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortFilterStartTimestampVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CohortFilterStartTimestampVariant1OpJsonConverter))]
        public global::RetellAI.CohortFilterStartTimestampVariant1Op? Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterStartTimestampVariant1" /> class.
        /// </summary>
        /// <param name="op"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortFilterStartTimestampVariant1(
            global::RetellAI.CohortFilterStartTimestampVariant1Op? op)
        {
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterStartTimestampVariant1" /> class.
        /// </summary>
        public CohortFilterStartTimestampVariant1()
        {
        }
    }
}
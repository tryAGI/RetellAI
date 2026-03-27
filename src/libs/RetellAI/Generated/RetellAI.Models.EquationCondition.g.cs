
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EquationCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EquationConditionTypeJsonConverter))]
        public global::RetellAI.EquationConditionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.Equation> Equations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EquationConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.EquationConditionOperator Operator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EquationCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="equations"></param>
        /// <param name="operator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EquationCondition(
            global::System.Collections.Generic.IList<global::RetellAI.Equation> equations,
            global::RetellAI.EquationConditionOperator @operator,
            global::RetellAI.EquationConditionType type)
        {
            this.Equations = equations ?? throw new global::System.ArgumentNullException(nameof(equations));
            this.Operator = @operator;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquationCondition" /> class.
        /// </summary>
        public EquationCondition()
        {
        }
    }
}
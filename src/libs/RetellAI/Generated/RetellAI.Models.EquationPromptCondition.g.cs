
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EquationPromptCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EquationPromptConditionTypeJsonConverter))]
        public global::RetellAI.EquationPromptConditionType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EquationPromptConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.EquationPromptConditionOperator Operator { get; set; }

        /// <summary>
        /// Optional prompt combined with the equations by operator. Omit to evaluate only equations. With no equations, only the prompt is evaluated. Deterministic matches take priority; otherwise the prompt uses normal prompt transition timing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_condition")]
        public global::RetellAI.PromptCondition? PromptCondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EquationPromptCondition" /> class.
        /// </summary>
        /// <param name="equations"></param>
        /// <param name="operator"></param>
        /// <param name="type"></param>
        /// <param name="promptCondition">
        /// Optional prompt combined with the equations by operator. Omit to evaluate only equations. With no equations, only the prompt is evaluated. Deterministic matches take priority; otherwise the prompt uses normal prompt transition timing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EquationPromptCondition(
            global::System.Collections.Generic.IList<global::RetellAI.Equation> equations,
            global::RetellAI.EquationPromptConditionOperator @operator,
            global::RetellAI.EquationPromptConditionType type,
            global::RetellAI.PromptCondition? promptCondition)
        {
            this.Type = type;
            this.Equations = equations ?? throw new global::System.ArgumentNullException(nameof(equations));
            this.Operator = @operator;
            this.PromptCondition = promptCondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquationPromptCondition" /> class.
        /// </summary>
        public EquationPromptCondition()
        {
        }

    }
}
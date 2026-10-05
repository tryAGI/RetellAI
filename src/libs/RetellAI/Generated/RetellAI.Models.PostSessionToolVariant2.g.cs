
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostSessionToolVariant2
    {
        /// <summary>
        /// Names of tools that must run before this one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depends_on")]
        public global::System.Collections.Generic.IList<string>? DependsOn { get; set; }

        /// <summary>
        /// Optional gate; the step only runs when the condition holds. Defaults to always running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::RetellAI.EquationCondition? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSessionToolVariant2" /> class.
        /// </summary>
        /// <param name="dependsOn">
        /// Names of tools that must run before this one.
        /// </param>
        /// <param name="condition">
        /// Optional gate; the step only runs when the condition holds. Defaults to always running.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostSessionToolVariant2(
            global::System.Collections.Generic.IList<string>? dependsOn,
            global::RetellAI.EquationCondition? condition)
        {
            this.DependsOn = dependsOn;
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSessionToolVariant2" /> class.
        /// </summary>
        public PostSessionToolVariant2()
        {
        }

    }
}